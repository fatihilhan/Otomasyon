using System;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cek
{
    public partial class frmCariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {

        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frmCariyeCekCikisi()
        {
            InitializeComponent();
        }

        private void FrmCariyeCekCikisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtSube.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            txtVadeTarih.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILER.First(s => s.ID == CariID);
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKODU;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void CekGetir(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                txtBanka.Text = Cek.BANKA;
                txtCekNo.Text = Cek.CEKNO;
                txtSube.Text = Cek.SUBE;
                txtVadeTarih.Text = Cek.VADETARIHI.Value.ToShortDateString();
                txtTutar.Text = Cek.TUTAR.Value.ToString();
                if (Cek.VERILENCARIID != null)
                {
                    if (Cek.VERILENCARIID.Value > 0)
                    {
                        CariAc(Cek.VERILENCARIID.Value);
                        txtBelgeNo.Text = Cek.VERILENCARI_BELGENO;
                        txtTarih.Text = Cek.VERILENCARI_TARIHI.Value.ToShortDateString();
                    }
                }
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUMU = "Caride";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new Fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtCekNo.Text + " çek numaralı ve " + txtBelgeNo.Text + " belge numaralı çek";
                CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = CekID;
                CariHareket.EVRAKTURU = "Cariye Çek";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "Çek İşlemi";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIHAREKETLERI.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Cariye çek çıkışı işleminin hareket kaydı ve çek kaydı güncellemesi yapılmıştır.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                Cek.VERILENCARIID = CariID;
                Cek.VERILENCARI_TARIHI = DateTime.Parse(txtTarih.Text);
                Cek.VERILENCARI_BELGENO = txtBelgeNo.Text;
                Cek.DURUMU = "Caride";
                Cek.EDITDATE = DateTime.Now;
                Cek.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKTURU == "Cariye Çek" && s.EVRAKID == CekID);
                CariHareket.ACIKLAMA = txtCekNo.Text + " çek numaralı ve " + txtBelgeNo.Text + " belge numaralı çek";
                CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = CekID;
                CariHareket.EVRAKTURU = "Cariye Çek";
                CariHareket.TARIH = DateTime.Now;
                CariHareket.TIPI = "Çek İşlemi";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }

        public void Ac(int CekinIDsi)
        {
            try
            {
                CekID = CekinIDsi;
                CekGetir(CekID);
                Edit = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                Temizle();
            }
        }

        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0) CariAc(id);
            AnaForm.Aktarma = -1;
        }

        private void TxtCekNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CekListesi(true);
            if (id > 0) CekGetir(id);
            AnaForm.Aktarma = -1;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && CekID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else if (CariID > 0 && CekID > 0) YeniKaydet();
            else MessageBox.Show("Çek veya Cari Seçimi yapmadınız.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit && CariID > 0 && CekID > 0 && Mesajlar.Sil() == DialogResult.Yes)
                {
                    DB.TBL_CARIHAREKETLERI.DeleteOnSubmit(DB.TBL_CARIHAREKETLERI.First(s => s.EVRAKTURU == "Çek İşlemi" && s.EVRAKID == CekID));
                    Fonksiyonlar.TBL_CEKLER Cek = DB.TBL_CEKLER.First(s => s.ID == CekID);
                    Cek.VERILENCARI_BELGENO = "";
                    Cek.VERILENCARIID = -1;
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Mesajlar.Hata(ex);
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}