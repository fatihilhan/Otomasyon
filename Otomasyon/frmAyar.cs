using System;

namespace Otomasyon
{
    public partial class frmAyar : DevExpress.XtraEditors.XtraForm
    {
        public frmAyar()
        {
            InitializeComponent();
        }

        private void ChkYeniGiris_CheckedChanged(object sender, EventArgs e)
        {
            txtDatabase.Enabled = !txtDatabase.Enabled; //bu dönüşümle true ise false, false ise true'ya çevirir.
            txtPassword.Enabled = !txtPassword.Enabled;
            txtSunucu.Enabled = !txtSunucu.Enabled;
            txtUserID.Enabled = !txtUserID.Enabled;
            btnYeniAyarlariKaydet.Enabled = !btnYeniAyarlariKaydet.Enabled;
        }

        private void BtnYeniAyarlariKaydet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.cs_Sunucu = txtSunucu.Text.Trim() + ";";
            Properties.Settings.Default.cs_Database = txtDatabase.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID = txtUserID.Text.Trim() + ";";
            Properties.Settings.Default.cs_Password = txtPassword.Text.Trim() + ";";
            Properties.Settings.Default.Database = txtDatabase.Text.Trim();
            Properties.Settings.Default.Save();
            //Application.Restart();
            this.Close();
        }

        private void FrmAyar_Load(object sender, EventArgs e)
        {
            labelControl2.Text = Properties.Settings.Default.cs1 + Properties.Settings.Default.cs_Sunucu + Properties.Settings.Default.cs2 + Properties.Settings.Default.cs_Database + Properties.Settings.Default.cs3 + Properties.Settings.Default.cs_UserID + Properties.Settings.Default.cs4 + Properties.Settings.Default.cs_Password;
        }
    }
}