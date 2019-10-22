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