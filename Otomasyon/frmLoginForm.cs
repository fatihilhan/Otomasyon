using System;

namespace Otomasyon
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaForm frm = new AnaForm();
            frm.Show();
        }

        private void BtnAyar_Click(object sender, EventArgs e)
        {
            frmAyar frm = new frmAyar();
            frm.ShowDialog();
        }
    }
}