using System;
using System.Data;
using System.Linq;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool Secim = false;
        int SecimID = -1;

        public frmKasaListesi()
        {
            InitializeComponent();
        }

        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASALISTESI
                      where s.KASAKODU.Contains(txtKasaKodu.Text) && s.KASAADI.Contains(txtKasaAdi.Text)
                      select s;
            Liste.DataSource = lst;
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

        private void BtnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}