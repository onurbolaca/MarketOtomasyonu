namespace dhProje_marketOtomasyonu.Firma
{
    partial class frmFirmaHareketleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaHareketleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.lkpUrunler = new DevExpress.XtraEditors.GridLookUpEdit();
            this.lkpMusterilerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtMarketinBorcu = new DevExpress.XtraEditors.TextEdit();
            this.txtTedarikciBorcu = new DevExpress.XtraEditors.TextEdit();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderQuantity = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblMarketsDebt = new System.Windows.Forms.Label();
            this.lblSuppliersDebt = new System.Windows.Forms.Label();
            this.btnUrunTanimla = new DevExpress.XtraEditors.SimpleButton();
            this.btnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUrunler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarketinBorcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikciBorcu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.lblSirketAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 54);
            this.panel1.TabIndex = 0;
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdi.ForeColor = System.Drawing.Color.Transparent;
            this.lblSirketAdi.Location = new System.Drawing.Point(141, 18);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(92, 22);
            this.lblSirketAdi.TabIndex = 1;
            this.lblSirketAdi.Text = "Şirket Adı";
            // 
            // lkpUrunler
            // 
            this.lkpUrunler.EditValue = "İsim Yazın";
            this.lkpUrunler.Location = new System.Drawing.Point(12, 76);
            this.lkpUrunler.Name = "lkpUrunler";
            this.lkpUrunler.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkpUrunler.Properties.Appearance.Options.UseFont = true;
            this.lkpUrunler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpUrunler.Properties.PopupView = this.lkpMusterilerGrid;
            this.lkpUrunler.Size = new System.Drawing.Size(230, 24);
            this.lkpUrunler.TabIndex = 41;
            // 
            // lkpMusterilerGrid
            // 
            this.lkpMusterilerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UrunAdi});
            this.lkpMusterilerGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lkpMusterilerGrid.Name = "lkpMusterilerGrid";
            this.lkpMusterilerGrid.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.lkpMusterilerGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lkpMusterilerGrid.OptionsView.ShowGroupPanel = false;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Caption = "Ürün Adı";
            this.UrunAdi.FieldName = "ProductName";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Visible = true;
            this.UrunAdi.VisibleIndex = 0;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Location = new System.Drawing.Point(12, 176);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 16);
            this.lblProductName.TabIndex = 42;
            this.lblProductName.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(130, 170);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Properties.Appearance.Options.UseFont = true;
            this.txtUrunAdi.Properties.ReadOnly = true;
            this.txtUrunAdi.Size = new System.Drawing.Size(232, 22);
            this.txtUrunAdi.TabIndex = 43;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(130, 220);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTarih.Properties.Appearance.Options.UseFont = true;
            this.txtTarih.Properties.Mask.EditMask = "d";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtTarih.Size = new System.Drawing.Size(232, 22);
            this.txtTarih.TabIndex = 44;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(130, 271);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Properties.Appearance.Options.UseFont = true;
            this.txtMiktar.Size = new System.Drawing.Size(232, 22);
            this.txtMiktar.TabIndex = 45;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(130, 323);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtFiyat.Size = new System.Drawing.Size(232, 22);
            this.txtFiyat.TabIndex = 46;
            // 
            // txtMarketinBorcu
            // 
            this.txtMarketinBorcu.Location = new System.Drawing.Point(130, 378);
            this.txtMarketinBorcu.Name = "txtMarketinBorcu";
            this.txtMarketinBorcu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketinBorcu.Properties.Appearance.Options.UseFont = true;
            this.txtMarketinBorcu.Size = new System.Drawing.Size(232, 22);
            this.txtMarketinBorcu.TabIndex = 47;
            // 
            // txtTedarikciBorcu
            // 
            this.txtTedarikciBorcu.Location = new System.Drawing.Point(130, 427);
            this.txtTedarikciBorcu.Name = "txtTedarikciBorcu";
            this.txtTedarikciBorcu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTedarikciBorcu.Properties.Appearance.Options.UseFont = true;
            this.txtTedarikciBorcu.Size = new System.Drawing.Size(232, 22);
            this.txtTedarikciBorcu.TabIndex = 48;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderDate.Location = new System.Drawing.Point(12, 226);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(49, 16);
            this.lblOrderDate.TabIndex = 49;
            this.lblOrderDate.Text = "Tarih :";
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.AutoSize = true;
            this.lblOrderQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderQuantity.Location = new System.Drawing.Point(12, 273);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblOrderQuantity.TabIndex = 50;
            this.lblOrderQuantity.Text = "Miktar :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 329);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(101, 16);
            this.lblTotalPrice.TabIndex = 51;
            this.lblTotalPrice.Text = "Toplam Fiyat : ";
            // 
            // lblMarketsDebt
            // 
            this.lblMarketsDebt.AutoSize = true;
            this.lblMarketsDebt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMarketsDebt.Location = new System.Drawing.Point(12, 381);
            this.lblMarketsDebt.Name = "lblMarketsDebt";
            this.lblMarketsDebt.Size = new System.Drawing.Size(115, 16);
            this.lblMarketsDebt.TabIndex = 52;
            this.lblMarketsDebt.Text = "Marketin Borcu :";
            // 
            // lblSuppliersDebt
            // 
            this.lblSuppliersDebt.AutoSize = true;
            this.lblSuppliersDebt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuppliersDebt.Location = new System.Drawing.Point(12, 433);
            this.lblSuppliersDebt.Name = "lblSuppliersDebt";
            this.lblSuppliersDebt.Size = new System.Drawing.Size(115, 16);
            this.lblSuppliersDebt.TabIndex = 53;
            this.lblSuppliersDebt.Text = "Tedarikçi Borcu :";
            // 
            // btnUrunTanimla
            // 
            this.btnUrunTanimla.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunTanimla.Appearance.Options.UseFont = true;
            this.btnUrunTanimla.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.next3;
            this.btnUrunTanimla.Location = new System.Drawing.Point(15, 106);
            this.btnUrunTanimla.Name = "btnUrunTanimla";
            this.btnUrunTanimla.Size = new System.Drawing.Size(227, 35);
            this.btnUrunTanimla.TabIndex = 54;
            this.btnUrunTanimla.Text = "Ürün Tanımla";
            this.btnUrunTanimla.Click += new System.EventHandler(this.btnUrunTanimla_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Appearance.Options.UseFont = true;
            this.btnUrunEkle.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.actions_addcircled;
            this.btnUrunEkle.Location = new System.Drawing.Point(260, 79);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(107, 61);
            this.btnUrunEkle.TabIndex = 55;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(203, 472);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 52);
            this.btnOK.TabIndex = 57;
            this.btnOK.Text = "Ekle";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIptal.ImageOptions.SvgImage")));
            this.btnIptal.Location = new System.Drawing.Point(64, 472);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 52);
            this.btnIptal.TabIndex = 56;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmFirmaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 546);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnUrunTanimla);
            this.Controls.Add(this.lblSuppliersDebt);
            this.Controls.Add(this.lblMarketsDebt);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtTedarikciBorcu);
            this.Controls.Add(this.txtMarketinBorcu);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lkpUrunler);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFirmaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Firma Hareketleri";
            this.Load += new System.EventHandler(this.frmFirmaHareketleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpUrunler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarketinBorcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTedarikciBorcu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSirketAdi;
        private DevExpress.XtraEditors.GridLookUpEdit lkpUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView lkpMusterilerGrid;
        private System.Windows.Forms.Label lblProductName;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtMarketinBorcu;
        private DevExpress.XtraEditors.TextEdit txtTedarikciBorcu;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderQuantity;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblMarketsDebt;
        private System.Windows.Forms.Label lblSuppliersDebt;
        private DevExpress.XtraEditors.SimpleButton btnUrunTanimla;
        private DevExpress.XtraEditors.SimpleButton btnUrunEkle;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraGrid.Columns.GridColumn UrunAdi;
    }
}