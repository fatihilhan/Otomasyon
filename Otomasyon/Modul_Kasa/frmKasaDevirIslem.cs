using System;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;

        public frmKasaDevirIslem()
        {
            InitializeComponent();
        }

        private void FrmKasaDevirIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = new Fonksiyonlar.TBL_KASAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASAHAREKETLERI.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Devir Kartı Hareket Kaydı işlenmiştir.");
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
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "Kasa Devir Kartı";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = KasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_KASAHAREKETLERI.DeleteOnSubmit(DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.TBL_KASAHAREKETLERI Hareket = DB.TBL_KASAHAREKETLERI.First(s => s.ID == IslemID);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                KasaAc(Hareket.KASAID.Value);
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.Value.ToString();
                if (Hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtnCikis.Checked = true;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception)
            {


            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void TxtBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}