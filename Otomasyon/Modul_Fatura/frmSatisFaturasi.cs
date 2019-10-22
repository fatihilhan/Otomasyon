using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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

        public frmSatisFaturasi()
        {
            InitializeComponent();
        }

        public frmSatisFaturasi(bool Edit, int ID)
        {
            InitializeComponent();
        }


        private void BtnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int StokID = Formlar.StokListesi(true);
            if (StokID > 0)
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
                    Miktar = decimal.Parse(gridView1.GetRowCellValue(i, "MİKTAR").ToString());
                    KDV = decimal.Parse(gridView1.GetRowCellValue(i, "KDV").ToString()) / 100 + 1;
                    AraToplam += Miktar * BirimFiyat;
                    GenelToplam += decimal.Parse(gridView1.GetRowCellValue(i, "TOPLAM").ToString()) * KDV;
                }

                txtAraToplam.Text = AraToplam.ToString("0,00");
                txtKDV.Text = (GenelToplam - AraToplam).ToString("0,00");
                txtGenelToplam.Text = GenelToplam.ToString("0,00");
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
            if(txtOdemeYeri.SelectedIndex==0)
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
                Fatura.ACIKLAMA=txt
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }
    }
}