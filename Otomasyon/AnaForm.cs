using DevExpress.XtraBars;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        public static int UserID = -1;
        public static int Aktarma = -1; // Formlar arası geçişler için aktarma değişkeni oluşturduk.
        public AnaForm()
        {
            InitializeComponent();
        }

        public void Mesaj(string Baslik, string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }

        #region Stok Butonları
        private void BarBtnStokKartlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void BarBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void BarBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void BarBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void NavBtnStokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void NavBtnStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void NavBtnStokGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void NavBtnStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.StokHareketleri();
        }


        #endregion

        #region Cari Butonları
        private void BarBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void BarBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void BarBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void BarBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void NavBtnCariAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void NavBtnCariGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void NavBtnCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void NavBtnCariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        #endregion

        #region Kasa Butonları
        private void BarBtnKasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void BarBtnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void BarBtnKasaDevirIslemleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void BarBtnKasaTahsilatOdeme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void BarBtnKasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void NavBtnKasaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void NavBtnKasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void NavBtnKasaDeviIslemleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaDevirIslemKarti();
        }

        private void NavBtnKasaTahsilatOdeme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void NavBtnKasaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        #endregion

        #region Banka Butonları
        private void BarBtnBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void BarBtnBankaIslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void BarBtnBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void BarBtnParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void BarBtnBankaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaHareketleri();
        }

        private void NavBtnBankaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void NavBtnParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaParaTransfer();
        }

        private void NavBtnBankaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void NavBtnBankaIslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaIslem();
        }

        private void NavBtnBankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Formlar.BankaHareketleri();
        }

        #endregion

        #region  Çek Formları
        private void BarBtnMusteriCeki_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void BarBtnKendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void BarBtnBankayaCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankayaCekCikisi();
        }

        private void BarBtnCariyeCekCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariyeCekCikisi();
        }
        #endregion

        private void BarBtnCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BarBtnSatisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Fatura();
        }

        private void BarBtnSatisIadeFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.FaturaListesi();
        }
    }
}