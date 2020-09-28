namespace dhProje_marketOtomasyonu
{
    partial class frmVeresiye
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
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lkpMusteriler = new DevExpress.XtraEditors.GridLookUpEdit();
            this.lkpMusterilerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MüsteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnMusteriBorcEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnHepsiniGetir = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriBorcGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriDetay = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusteriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 110);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1279, 560);
            this.gcList.TabIndex = 3;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.OptionsBehavior.ReadOnly = true;
            this.gvList.OptionsView.ShowFooter = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lkpMusteriler);
            this.panel1.Controls.Add(this.btnMusteriBorcEkle);
            this.panel1.Controls.Add(this.btnHepsiniGetir);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnMusteriBorcGuncelle);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnMusteriDetay);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 110);
            this.panel1.TabIndex = 4;
            // 
            // lkpMusteriler
            // 
            this.lkpMusteriler.EditValue = "İsim Yazın";
            this.lkpMusteriler.Location = new System.Drawing.Point(7, 11);
            this.lkpMusteriler.Name = "lkpMusteriler";
            this.lkpMusteriler.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkpMusteriler.Properties.Appearance.Options.UseFont = true;
            this.lkpMusteriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMusteriler.Properties.PopupView = this.lkpMusterilerGrid;
            this.lkpMusteriler.Size = new System.Drawing.Size(294, 30);
            this.lkpMusteriler.TabIndex = 52;
            this.lkpMusteriler.EditValueChanged += new System.EventHandler(this.lkpMusteriler_EditValueChanged);
            // 
            // lkpMusterilerGrid
            // 
            this.lkpMusterilerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MüsteriAdi,
            this.TcNo});
            this.lkpMusterilerGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lkpMusterilerGrid.Name = "lkpMusterilerGrid";
            this.lkpMusterilerGrid.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.lkpMusterilerGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lkpMusterilerGrid.OptionsView.ShowGroupPanel = false;
            // 
            // MüsteriAdi
            // 
            this.MüsteriAdi.Caption = "Müşteri Adı";
            this.MüsteriAdi.FieldName = "CustomerName";
            this.MüsteriAdi.Name = "MüsteriAdi";
            this.MüsteriAdi.Visible = true;
            this.MüsteriAdi.VisibleIndex = 0;
            // 
            // TcNo
            // 
            this.TcNo.Caption = "Tc No:";
            this.TcNo.FieldName = "SocialNumber";
            this.TcNo.Name = "TcNo";
            this.TcNo.Visible = true;
            this.TcNo.VisibleIndex = 1;
            // 
            // btnMusteriBorcEkle
            // 
            this.btnMusteriBorcEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBorcEkle.Appearance.Options.UseFont = true;
            this.btnMusteriBorcEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteriBorcEkle.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.business_cash1;
            this.btnMusteriBorcEkle.Location = new System.Drawing.Point(459, 24);
            this.btnMusteriBorcEkle.Name = "btnMusteriBorcEkle";
            this.btnMusteriBorcEkle.Size = new System.Drawing.Size(109, 61);
            this.btnMusteriBorcEkle.TabIndex = 49;
            this.btnMusteriBorcEkle.Text = "Borç \r\nEkle";
            this.btnMusteriBorcEkle.Click += new System.EventHandler(this.btnMusteriBorcEkle_Click);
            // 
            // btnHepsiniGetir
            // 
            this.btnHepsiniGetir.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniGetir.Appearance.Options.UseFont = true;
            this.btnHepsiniGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHepsiniGetir.ImageOptions.Image = global::dhProje_marketOtomasyonu.Properties.Resources.converttorange_32x32;
            this.btnHepsiniGetir.Location = new System.Drawing.Point(157, 47);
            this.btnHepsiniGetir.Name = "btnHepsiniGetir";
            this.btnHepsiniGetir.Size = new System.Drawing.Size(144, 52);
            this.btnHepsiniGetir.TabIndex = 47;
            this.btnHepsiniGetir.Text = "Hepsini Getir";
            this.btnHepsiniGetir.Click += new System.EventHandler(this.btnHepsiniGetir_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.ImageOptions.Image = global::dhProje_marketOtomasyonu.Properties.Resources.exporttocsv_32x32;
            this.btnExcel.Location = new System.Drawing.Point(1132, 24);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 61);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = global::dhProje_marketOtomasyonu.Properties.Resources.cancel_32x322;
            this.btnSil.Location = new System.Drawing.Point(975, 24);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 61);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Müşteri Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnMusteriBorcGuncelle
            // 
            this.btnMusteriBorcGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBorcGuncelle.Appearance.Options.UseFont = true;
            this.btnMusteriBorcGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteriBorcGuncelle.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.update;
            this.btnMusteriBorcGuncelle.Location = new System.Drawing.Point(574, 24);
            this.btnMusteriBorcGuncelle.Name = "btnMusteriBorcGuncelle";
            this.btnMusteriBorcGuncelle.Size = new System.Drawing.Size(117, 61);
            this.btnMusteriBorcGuncelle.TabIndex = 45;
            this.btnMusteriBorcGuncelle.Text = "Borç \r\nGüncelle";
            this.btnMusteriBorcGuncelle.Click += new System.EventHandler(this.btnMusteriBorcGuncelle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = global::dhProje_marketOtomasyonu.Properties.Resources.refreshallpivottable_32x32;
            this.btnGuncelle.Location = new System.Drawing.Point(842, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 61);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Müşteri \r\nGüncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ImageOptions.Image = global::dhProje_marketOtomasyonu.Properties.Resources.add_32x32;
            this.btnEkle.Location = new System.Drawing.Point(724, 24);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 61);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Müşteri \r\nEkle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnMusteriDetay
            // 
            this.btnMusteriDetay.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriDetay.Appearance.Options.UseFont = true;
            this.btnMusteriDetay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMusteriDetay.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.bo_report;
            this.btnMusteriDetay.Location = new System.Drawing.Point(319, 24);
            this.btnMusteriDetay.Name = "btnMusteriDetay";
            this.btnMusteriDetay.Size = new System.Drawing.Size(109, 61);
            this.btnMusteriDetay.TabIndex = 44;
            this.btnMusteriDetay.Text = "Müşteri\r\nDetay";
            this.btnMusteriDetay.Click += new System.EventHandler(this.btnMusteriDetay_Click);
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAra.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.next2;
            this.btnAra.Location = new System.Drawing.Point(7, 47);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(144, 52);
            this.btnAra.TabIndex = 43;
            this.btnAra.Text = "Müşteri Getir";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmVeresiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 670);
            this.Controls.Add(this.gcList);
            this.Controls.Add(this.panel1);
            this.Name = "frmVeresiye";
            this.Text = "frmVeresiye";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVeresiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusteriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnHepsiniGetir;
        private DevExpress.XtraEditors.SimpleButton btnMusteriBorcGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnMusteriDetay;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnMusteriBorcEkle;
        private DevExpress.XtraEditors.GridLookUpEdit lkpMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView lkpMusterilerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn MüsteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn TcNo;
    }
}