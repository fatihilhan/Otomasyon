﻿using System;
using System.Data;
using System.Linq;

namespace Otomasyon.Modul_Cek
{
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        int SecilenID = -1;
        public bool Secim = false;

        public frmCekListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var lst = from s in DB.TBL_CEKLER
                      where s.TIPI.Contains(txtCekTuru.Text) && s.BANKA.Contains(txtBanka.Text) && s.CEKNO.Contains(txtCekNo.Text)
                      select s;
            Liste.DataSource = lst;
        }

        private void FrmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Sec()
        {
            try
            {
                SecilenID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecilenID > 0)
            {
                AnaForm.Aktarma = SecilenID;
                this.Close();
            }
        }

        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}