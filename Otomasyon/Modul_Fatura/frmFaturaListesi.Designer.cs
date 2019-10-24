namespace Otomasyon.Modul_Fatura
{
    partial class frmFaturaListesi
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
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURATURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.txtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtFaturaTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtStokBarkod = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 609);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fatura No";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FATURANO,
            this.FATURATURU,
            this.CARIKODU});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "Fatura Numarası";
            this.FATURANO.FieldName = "FATURANO";
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.FixedWidth = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 0;
            this.FATURANO.Width = 40;
            // 
            // FATURATURU
            // 
            this.FATURATURU.Caption = "Fatura Türü";
            this.FATURATURU.FieldName = "FATURATURU";
            this.FATURATURU.Name = "FATURATURU";
            this.FATURATURU.OptionsColumn.AllowEdit = false;
            this.FATURATURU.OptionsColumn.AllowFocus = false;
            this.FATURATURU.OptionsColumn.FixedWidth = true;
            this.FATURATURU.Visible = true;
            this.FATURATURU.VisibleIndex = 1;
            this.FATURATURU.Width = 90;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "Cari Kodu";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 2;
            this.CARIKODU.Width = 50;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(5, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(720, 609);
            this.Liste.TabIndex = 1;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(11, 83);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(168, 20);
            this.txtFaturaNo.TabIndex = 3;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtFaturaNo);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtFaturaTuru);
            this.xtraTabPage1.Controls.Add(this.txtStokBarkod);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(191, 581);
            this.xtraTabPage1.Text = "Arama";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::Otomasyon.Properties.Resources.Sil32x32;
            this.simpleButton2.Location = new System.Drawing.Point(98, 154);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 42);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 154);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(81, 42);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tarih";
            // 
            // txtFaturaTuru
            // 
            this.txtFaturaTuru.EditValue = "Satış Faturası";
            this.txtFaturaTuru.Location = new System.Drawing.Point(11, 38);
            this.txtFaturaTuru.Name = "txtFaturaTuru";
            this.txtFaturaTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFaturaTuru.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.txtFaturaTuru.Properties.ReadOnly = true;
            this.txtFaturaTuru.Size = new System.Drawing.Size(168, 20);
            this.txtFaturaTuru.TabIndex = 1;
            this.txtFaturaTuru.SelectedIndexChanged += new System.EventHandler(this.TxtFaturaTuru_SelectedIndexChanged);
            // 
            // txtStokBarkod
            // 
            this.txtStokBarkod.EditValue = null;
            this.txtStokBarkod.Location = new System.Drawing.Point(11, 128);
            this.txtStokBarkod.Name = "txtStokBarkod";
            this.txtStokBarkod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStokBarkod.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStokBarkod.Properties.DisplayFormat.FormatString = "";
            this.txtStokBarkod.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStokBarkod.Properties.EditFormat.FormatString = "";
            this.txtStokBarkod.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStokBarkod.Properties.Mask.EditMask = "";
            this.txtStokBarkod.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtStokBarkod.Size = new System.Drawing.Size(168, 20);
            this.txtStokBarkod.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(197, 609);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Controls.Add(this.splitterControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(927, 609);
            this.splitContainerControl1.SplitterPosition = 197;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // frmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 609);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmFaturaListesi";
            this.Text = "frmFaturaListesi";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.Columns.GridColumn FATURATURU;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.TextEdit txtFaturaNo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtFaturaTuru;
        private DevExpress.XtraEditors.DateEdit txtStokBarkod;
    }
}