﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimID = -1;

        public frmCariGruplari()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }

        void Listele()

        {
            var lst = from s in DB.TBL_CARIGRUPLARI
                      select s;
            Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIGRUPLARI.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni cari grup kaydı oluşturuldu!");
                Listele();
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
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARI.First(s => s.ID == SecimID);
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.EDITDATE = DateTime.Now;
                Grup.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Listele();
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
                DB.TBL_CARIGRUPLARI.DeleteOnSubmit(DB.TBL_CARIGRUPLARI.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
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