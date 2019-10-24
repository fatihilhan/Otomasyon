using System;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon.Modul_Fatura
{
    public partial class frmSatisFaturasi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int OdemeID = -1;
        int FaturaID = -1;
        int IrsaliyeID = -1;
        string OdemeYeri = "";
        bool Edit = false;
        bool IrsaliyeAc = false;

        void Temizle()
        {
            CariID = -1;
            OdemeID = -1;
            FaturaID = -1;
            IrsaliyeID = -1;
            OdemeYeri = "";
            Edit = false;
            IrsaliyeAc = false;
            txtAciklama.Text = "";
            txtAraToplam.Text = "0.00";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtFaturaNo.Text = "";
            txtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txtFaturaTuru.SelectedIndex = 0;
            txtGenelToplam.Text = "0.00";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIrsaliyeNo.Text = "";
            txtIrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtKDV.Text = "0.00";
            txtOdemeYeri.SelectedIndex = 0;
            AnaForm.Aktarma = -1;
            for (int i = 0; i < gridView1.RowCount + 1; i++)
            {
                gridView1.DeleteRow(0);
            }
        }

        void FaturaGetir()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR Fatura = DB.TBL_FATURALAR.First(s => s.ID == FaturaID);
                txtAciklama.Text = Fatura.ACIKLAMA;
                txtFaturaNo.Text = Fatura.FATURANO;
                if (Fatura.ODEMEYERIID > 0) //Kapalı fatura ise
                {
                    txtFaturaTuru.SelectedIndex = 1; //Fatura türünü kapalı faturaya getiriyoruz.

                    if (Fatura.ODEMEYERI == "Kasa")
                    {
                        txtOdemeYeri.SelectedIndex = 0;
                        OdemeYeri = Fatura.ODEMEYERI;
                        txtKasaAdi.Text = DB.TBL_KASALAR.First(s => s.ID == Fatura.ODEMEYERIID.Value).KASAADI;
                        txtKasaKodu.Text = DB.TBL_KASALAR.First(s => s.ID == Fatura.ODEMEYERIID.Value).KASAKODU;
                    }
                    else if (Fatura.ODEMEYERI == "Banka")
                    {
                        txtOdemeYeri.SelectedIndex = 1;
                        OdemeYeri = Fatura.ODEMEYERI;
                        txtHesapAdi.Text = DB.TBL_BANKALAR.First(s => s.ID == Fatura.ODEMEYERIID.Value).HESAPADI;
                        txtHesapNo.Text = DB.TBL_BANKALAR.First(s => s.ID == Fatura.ODEMEYERIID.Value).HESAPNO;
                    }
                    OdemeID = Fatura.ODEMEYERIID.Value;
                }
                else if (Fatura.ODEMEYERIID < 1) txtFaturaTuru.SelectedIndex = 0;
                txtIrsaliyeNo.Text = DB.TBL_IRSALIYELER.First(s => s.ID == Fatura.IRSALIYEID).IRSALIYENO;
                txtIrsaliyeTarihi.EditValue = DB.TBL_IRSALIYELER.First(s => s.ID == Fatura.IRSALIYEID).TARIHI.Value.ToShortDateString();
                txtCariAdi.Text = DB.TBL_CARILER.First(s => s.CARIKODU == Fatura.CARIKODU).CARIADI;
                txtCariKodu.Text = Fatura.CARIKODU;
                txtFaturaTarihi.EditValue = Fatura.TARIHI.Value.ToShortDateString();
                var srg = from s in DB.VW_KALEMLER
                          where s.FATURAID == FaturaID
                          select s;
                foreach(Fonksiyonlar.VW_KALEMLER k in srg)
                {
                    gridView1.AddNewRow();
                    gridView1.SetFocusedRowCellValue("MIKTAR", k.MIKTAR);
                    gridView1.SetFocusedRowCellValue("BIRIMFIYAT", k.BIRIMFIYAT);
                    gridView1.SetFocusedRowCellValue("KDV", k.KDV);
                    gridView1.SetFocusedRowCellValue("BARKOD", k.STOKBARKOD);
                    gridView1.SetFocusedRowCellValue("STOKKODU", k.STOKKODU);
                    gridView1.SetFocusedRowCellValue("STOKADI", k.STOKADI);
                    gridView1.SetFocusedRowCellValue("BIRIM", k.STOKBIRIM);
                    gridView1.UpdateCurrentRow();
                }
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        public frmSatisFaturasi(bool Ac, int ID, bool Irsaliye)
        {
            InitializeComponent();
            Edit = Ac;
            if (Irsaliye) IrsaliyeID = ID;
            else FaturaID = ID;
            IrsaliyeAc = Irsaliye;
            this.Shown += FrmSatisFaturasi_Shown; //bu event özellikleri için fatura 3. video 33:00 a bakabilirsin.
        }

        private void FrmSatisFaturasi_Shown(object sender, EventArgs e) //bu event özellikleri için fatura 3. video 33:00 a bakabilirsin.
        {
            if (Edit) FaturaGetir();
        }

        void StokGetir(int StokID)
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
                gridView1.AddNewRow();
                gridView1.SetFocusedRowCellValue("MIKTAR", "0");
                gridView1.SetFocusedRowCellValue("BARKOD", Stok.STOKBARKOD);
                gridView1.SetFocusedRowCellValue("STOKKODU", Stok.STOKKODU);
                gridView1.SetFocusedRowCellValue("STOKADI", Stok.STOKADI);
                gridView1.SetFocusedRowCellValue("BIRIM", Stok.STOKBIRIM);
                gridView1.SetFocusedRowCellValue("BIRIMFIYAT", Stok.STOKSATISFIYAT);
                gridView1.SetFocusedRowCellValue("KDV", Stok.STOKSATISKDV);

            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void BtnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int StokID = Formlar.StokListesi(true);
            if (StokID > 0)
            {
                StokGetir(StokID);
            }
            AnaForm.Aktarma = -1;
        }

        private void FrmSatisFaturasi_Load(object sender, EventArgs e)
        {
            txtFaturaTarihi.Text = DateTime.Now.ToShortDateString();
            txtIrsaliyeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        private void GridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                decimal Miktar = 0, BirimFiyat = 0, Toplam = 0;

                if (e.Column.Name != "colTOPLAM")
                {
                    Miktar = decimal.Parse(gridView1.GetFocusedRowCellValue("MIKTAR").ToString());
                    if (gridView1.GetFocusedRowCellValue("BIRIMFIYAT").ToString() != "")
                    {
                        BirimFiyat = decimal.Parse(gridView1.GetFocusedRowCellValue("BIRIMFIYAT").ToString());
                    }
                    Toplam = Miktar * BirimFiyat;

                    gridView1.SetFocusedRowCellValue("TOPLAM", Toplam.ToString());
                    Hesapla();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Hesapla()
        {
            try
            {
                decimal BirimFiyat = 0, Miktar = 0, GenelToplam = 0, AraToplam = 0, KDV = 0;

                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    BirimFiyat = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                    Miktar = decimal.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString()) / 100 + 1;
                    AraToplam += Miktar * BirimFiyat;
                    GenelToplam += decimal.Parse(gridView1.GetRowCellValue(i, "TOPLAM").ToString()) * KDV;
                }

                txtAraToplam.Text = AraToplam.ToString("0.00");
                txtKDV.Text = (GenelToplam - AraToplam).ToString("0.00");
                txtGenelToplam.Text = GenelToplam.ToString("0.00");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GridView1_RowCountChanged(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0) CariSec(ID);
            AnaForm.Aktarma = -1;
        }

        void CariSec(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                txtCariKodu.Text = Cari.CARIKODU;
                txtCariAdi.Text = Cari.CARIADI;
            }
            catch (Exception ex)
            {

                Mesajlar.Hata(ex);
            }
        }

        private void TxtFaturaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFaturaTuru.SelectedIndex == 0) pnlOdemeYerleri.Enabled = false;
            if (txtFaturaTuru.SelectedIndex == 1) pnlOdemeYerleri.Enabled = true;
        }

        private void TxtOdemeYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtOdemeYeri.SelectedIndex == 0)
            {
                txtHesapAdi.Enabled = false;
                txtHesapNo.Enabled = false;
                txtKasaAdi.Enabled = true;
                txtKasaKodu.Enabled = true;
            }
            if (txtOdemeYeri.SelectedIndex == 1)
            {
                txtHesapAdi.Enabled = true;
                txtHesapNo.Enabled = true;
                txtKasaAdi.Enabled = false;
                txtKasaKodu.Enabled = false;
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void YeniFaturaKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_FATURALAR Fatura = new Fonksiyonlar.TBL_FATURALAR();
                Fatura.ACIKLAMA = txtAciklama.Text;
                Fatura.CARIKODU = txtCariKodu.Text;
                Fatura.FATURANO = txtFaturaNo.Text;
                Fatura.FATURATURU = "Satış Faturası";
                Fatura.GENELTOPLAM = decimal.Parse(txtGenelToplam.Text);
                Fatura.IRSALIYEID = IrsaliyeID;
                Fatura.ODEMEYERI = OdemeYeri;
                Fatura.ODEMEYERIID = OdemeID;
                Fatura.TARIHI = DateTime.Parse(txtFaturaTarihi.Text);
                Fatura.SAVEDATE = DateTime.Now;
                Fatura.SAVEUSER = AnaForm.UserID;
                DB.TBL_FATURALAR.InsertOnSubmit(Fatura);
                DB.SubmitChanges();
                FaturaID = Fatura.ID;

                if (IrsaliyeID < 0)
                {
                    Fonksiyonlar.TBL_IRSALIYELER Irsaliye = new Fonksiyonlar.TBL_IRSALIYELER();
                    Irsaliye.ACIKLAMA = txtAciklama.Text;
                    Irsaliye.CARIKODU = txtCariKodu.Text;
                    Irsaliye.FATURAID = Fatura.ID;
                    Irsaliye.IRSALIYENO = txtIrsaliyeNo.Text;
                    Irsaliye.TARIHI = DateTime.Parse(txtIrsaliyeTarihi.Text);
                    Irsaliye.SAVEDATE = DateTime.Now;
                    Irsaliye.SAVEUSER = AnaForm.UserID;
                    DB.TBL_IRSALIYELER.InsertOnSubmit(Irsaliye);
                    DB.SubmitChanges();
                    IrsaliyeID = Irsaliye.ID;
                    Fatura.IRSALIYEID = IrsaliyeID;
                }

                Fonksiyonlar.TBL_STOKHAREKETLERI[] StokHareketi = new Fonksiyonlar.TBL_STOKHAREKETLERI[gridView1.RowCount];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    StokHareketi[i] = new Fonksiyonlar.TBL_STOKHAREKETLERI();
                    StokHareketi[i].BIRIMFIYAT = decimal.Parse(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());
                    StokHareketi[i].FATURAID = Fatura.ID;
                    StokHareketi[i].GCKODU = "C";
                    StokHareketi[i].IRSALIYEID = IrsaliyeID;
                    StokHareketi[i].KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString());
                    StokHareketi[i].MIKTAR = int.Parse(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    StokHareketi[i].STOKKODU = gridView1.GetRowCellValue(i, "STOKKODU").ToString();
                    StokHareketi[i].TIPI = "Satış Faturası";
                    StokHareketi[i].SAVEDATE = DateTime.Now;
                    StokHareketi[i].SAVEUSER = AnaForm.UserID;
                    DB.TBL_STOKHAREKETLERI.InsertOnSubmit(StokHareketi[i]);
                }
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtFaturaNo.Text + " no'lu satış faturası tutarı";
                if (txtFaturaTuru.SelectedIndex == 0)
                {
                    CariHareket.ALACAK = 0;
                    CariHareket.BORC = decimal.Parse(txtGenelToplam.Text);
                }
                else if (txtFaturaTuru.SelectedIndex == 1)
                {
                    CariHareket.ALACAK = decimal.Parse(txtGenelToplam.Text);
                    CariHareket.BORC = decimal.Parse(txtGenelToplam.Text);
                }
                CariHareket.CARIID = CariID;
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "SF";
                CariHareket.EVRAKTURU = "Satış Faturası";
                CariHareket.EVRAKID = Fatura.ID;
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Fatura Kaydı başarı ile yapılmıştır.");
                Temizle();
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniFaturaKaydet();
        }
    }
}