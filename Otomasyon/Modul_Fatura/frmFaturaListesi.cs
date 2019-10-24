using System.Linq;

namespace Otomasyon.Modul_Fatura
{
    public partial class frmFaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Secimm = false;
        public frmFaturaListesi(bool Secim)
        {
            InitializeComponent();
            Secimm = Secim;
        }

        private void FrmFaturaListesi_Load(object sender, System.EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_FATURALAR
                      where s.FATURATURU.Contains(txtFaturaTuru.Text) && s.FATURANO.Contains(txtFaturaNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void TxtFaturaTuru_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Listele();
        }

        private void BtnAra_Click(object sender, System.EventArgs e)
        {
            Listele();
        }

        private void GridView1_DoubleClick(object sender, System.EventArgs e)
        {
            int ID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            if (ID > 0)
            {
                Formlar.Fatura(true, ID, false);//Aktarma yaptık
            }
        }
    }
}