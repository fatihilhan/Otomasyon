using System;
using System.Data;
using System.Linq;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;
        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void FrmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_STOKLAR
                      where s.STOKADI.Contains(txtStokAdi.Text) && s.STOKBARKOD.Contains(txtStokBarkod.Text) && s.STOKKODU.Contains(txtStokKodu.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            txtStokBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }
        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}