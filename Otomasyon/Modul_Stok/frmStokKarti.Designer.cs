﻿namespace Otomasyon.Modul_Stok
{
    partial class frmStokKarti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokKarti));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisKDV = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisKDV = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtBirim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnResimSec);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtStokKodu);
            this.groupControl1.Controls.Add(this.txtStokAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(412, 88);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ana Stok Bilgileri";
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(312, 25);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(60, 50);
            this.btnResimSec.TabIndex = 2;
            this.btnResimSec.Text = "Stok\r\nResmi\r\nSeç";
            this.btnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(235, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu :";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(74, 29);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStokKodu.Size = new System.Drawing.Size(148, 20);
            this.txtStokKodu.TabIndex = 0;
            this.txtStokKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtStokKodu_ButtonClick);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(74, 55);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(148, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl7);
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 88);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(412, 270);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Genel Stok Bilgileri";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.labelControl9);
            this.groupControl7.Controls.Add(this.labelControl10);
            this.groupControl7.Controls.Add(this.txtSatisFiyat);
            this.groupControl7.Controls.Add(this.txtAlisFiyat);
            this.groupControl7.Location = new System.Drawing.Point(229, 23);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(178, 81);
            this.groupControl7.TabIndex = 2;
            this.groupControl7.Text = "Fiyat Bilgileri";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(10, 53);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Satış Fiyatı :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(11, 27);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Alış Fiyatı :";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(75, 50);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Properties.Mask.EditMask = "c";
            this.txtSatisFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSatisFiyat.Size = new System.Drawing.Size(89, 20);
            this.txtSatisFiyat.TabIndex = 1;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.Location = new System.Drawing.Point(75, 24);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Properties.Mask.EditMask = "c";
            this.txtAlisFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlisFiyat.Size = new System.Drawing.Size(89, 20);
            this.txtAlisFiyat.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.labelControl7);
            this.groupControl6.Controls.Add(this.labelControl8);
            this.groupControl6.Controls.Add(this.txtSatisKDV);
            this.groupControl6.Controls.Add(this.txtAlisKDV);
            this.groupControl6.Location = new System.Drawing.Point(228, 110);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(178, 79);
            this.groupControl6.TabIndex = 3;
            this.groupControl6.Text = "KDV Bilgileri %";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Satış KDV :";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Alış KDV :";
            // 
            // txtSatisKDV
            // 
            this.txtSatisKDV.Location = new System.Drawing.Point(77, 50);
            this.txtSatisKDV.Name = "txtSatisKDV";
            this.txtSatisKDV.Properties.Mask.EditMask = "c";
            this.txtSatisKDV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSatisKDV.Size = new System.Drawing.Size(89, 20);
            this.txtSatisKDV.TabIndex = 1;
            // 
            // txtAlisKDV
            // 
            this.txtAlisKDV.Location = new System.Drawing.Point(77, 24);
            this.txtAlisKDV.Name = "txtAlisKDV";
            this.txtAlisKDV.Properties.Mask.EditMask = "c";
            this.txtAlisKDV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlisKDV.Size = new System.Drawing.Size(89, 20);
            this.txtAlisKDV.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.txtBarkod);
            this.groupControl5.Controls.Add(this.txtBirim);
            this.groupControl5.Location = new System.Drawing.Point(2, 110);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(220, 79);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Barkod ve Birim";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Barkod :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Birim :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(69, 50);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(142, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // txtBirim
            // 
            this.txtBirim.EditValue = "ADET";
            this.txtBirim.Location = new System.Drawing.Point(69, 24);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirim.Properties.Items.AddRange(new object[] {
            "ADET",
            "TANE",
            "KİLO",
            "METRE"});
            this.txtBirim.Size = new System.Drawing.Size(142, 20);
            this.txtBirim.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl4);
            this.groupControl4.Controls.Add(this.txtGrupAdi);
            this.groupControl4.Controls.Add(this.labelControl3);
            this.groupControl4.Controls.Add(this.txtGrupKodu);
            this.groupControl4.Location = new System.Drawing.Point(2, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(221, 81);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Grup Bilgileri";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Grup Kodu :";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Location = new System.Drawing.Point(69, 46);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(142, 20);
            this.txtGrupAdi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Grup Adı :";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(69, 20);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGrupKodu.Size = new System.Drawing.Size(142, 20);
            this.txtGrupKodu.TabIndex = 0;
            this.txtGrupKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.TxtGrupKodu_ButtonClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnKapat);
            this.groupControl3.Controls.Add(this.btnKaydet);
            this.groupControl3.Controls.Add(this.btnSil);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 285);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(412, 73);
            this.groupControl3.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(332, 24);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 44);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = global::Otomasyon.Properties.Resources.Kaydet24x24;
            this.btnKaydet.Location = new System.Drawing.Point(170, 24);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 44);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(251, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 44);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // frmStokKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 358);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Açılış Kartı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStokKarti_FormClosed);
            this.Load += new System.EventHandler(this.FrmStokKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSatisKDV;
        private DevExpress.XtraEditors.TextEdit txtAlisKDV;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.ComboBoxEdit txtBirim;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit txtGrupKodu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}