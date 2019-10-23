using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();

        bool Edit = false;
        int SecimID = -1;

        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void FrmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarası();
            Listele();
        }

        void Temizle()
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarası();
            txtKasaAdi.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = new Fonksiyonlar.TBL_KASALAR();
                Kasa.ACIKLAMA = txtAciklama.Text;
                Kasa.KASAADI = txtKasaAdi.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.SAVEDATE = DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASALAR.InsertOnSubmit(Kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni Kasa kaydı oluşturulmuştur!");
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
                Fonksiyonlar.TBL_KASALAR Kasa = DB.TBL_KASALAR.First(s => s.ID == SecimID);
                Kasa.ACIKLAMA = txtAciklama.Text;
                Kasa.KASAADI = txtKasaAdi.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.EDITDATE = DateTime.Now;
                Kasa.EDITUSER = AnaForm.UserID;
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
                DB.TBL_KASALAR.DeleteOnSubmit(DB.TBL_KASALAR.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();
                txtAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KASALAR
                      select s;
            Liste.DataSource = lst;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaAdi.Text != "" && txtAciklama.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else YeniKaydet();
            }
            else MessageBox.Show("Kasa Adı ve Açıklama girilmesi gerekmektedir!", "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}