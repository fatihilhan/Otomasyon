using System;
using System.Windows.Forms;
using System.Linq;

namespace Otomasyon
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public frmLoginForm()
        {
            InitializeComponent();
            txtKullanici.Focus();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILAR.First(s => s.KULLANICI == txtKullanici.Text.Trim() && s.SIFRE == txtSifre.Text.Trim());
                Kullanici.LASTLOGIN = DateTime.Now;
                DB.SubmitChanges();
                this.Hide();
                AnaForm frm = new AnaForm(Kullanici);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullancı adı veya şifreniz yanlış!");
                return;
            }
            //this.Hide();
            //AnaForm frm = new AnaForm();
            //frm.Show();
        }

        private void BtnAyar_Click(object sender, EventArgs e)
        {
            frmAyar frm = new frmAyar();
            frm.ShowDialog();
        }

        private void FrmLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}