namespace dhProje_marketOtomasyonu
{
    partial class frmFirmaTakibi
    {
        /// <
        /// >
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirmaTakibi));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SirketAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.İletisimSorumlusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SorumluRutbesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sehir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bolge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VergiNumarasi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarketinBorcu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TedarikcininBorcu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TedarikciKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFirmaSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnHepsiniGetir = new DevExpress.XtraEditors.SimpleButton();
            this.lkpFirmalar = new DevExpress.XtraEditors.GridLookUpEdit();
            this.lkpMusterilerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaHareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirmaDetay = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpFirmalar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 100);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1337, 564);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SirketAdi,
            this.İletisimSorumlusu,
            this.SorumluRutbesi,
            this.Adres,
            this.Sehir,
            this.Telefon,
            this.Bolge,
            this.VergiNumarasi,
            this.MarketinBorcu,
            this.TedarikcininBorcu,
            this.TedarikciKodu});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.OptionsBehavior.ReadOnly = true;
            this.gvList.OptionsView.ShowFooter = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            // 
            // SirketAdi
            // 
            this.SirketAdi.Caption = "Şirket Adı";
            this.SirketAdi.FieldName = "CompanyName";
            this.SirketAdi.Name = "SirketAdi";
            this.SirketAdi.Visible = true;
            this.SirketAdi.VisibleIndex = 0;
            // 
            // İletisimSorumlusu
            // 
            this.İletisimSorumlusu.Caption = "İletişim Sorumlusu";
            this.İletisimSorumlusu.FieldName = "ContactName";
            this.İletisimSorumlusu.Name = "İletisimSorumlusu";
            this.İletisimSorumlusu.Visible = true;
            this.İletisimSorumlusu.VisibleIndex = 1;
            // 
            // SorumluRutbesi
            // 
            this.SorumluRutbesi.Caption = "Sorumlu Rütbesi";
            this.SorumluRutbesi.FieldName = "ContactTitle";
            this.SorumluRutbesi.Name = "SorumluRutbesi";
            this.SorumluRutbesi.Visible = true;
            this.SorumluRutbesi.VisibleIndex = 2;
            // 
            // Adres
            // 
            this.Adres.Caption = "Adres";
            this.Adres.FieldName = "Address";
            this.Adres.Name = "Adres";
            this.Adres.Visible = true;
            this.Adres.VisibleIndex = 3;
            // 
            // Sehir
            // 
            this.Sehir.Caption = "Şehir";
            this.Sehir.FieldName = "City";
            this.Sehir.Name = "Sehir";
            this.Sehir.Visible = true;
            this.Sehir.VisibleIndex = 4;
            // 
            // Telefon
            // 
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Phone";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 5;
            // 
            // Bolge
            // 
            this.Bolge.Caption = "Bölge";
            this.Bolge.FieldName = "Region";
            this.Bolge.Name = "Bolge";
            this.Bolge.Visible = true;
            this.Bolge.VisibleIndex = 6;
            // 
            // VergiNumarasi
            // 
            this.VergiNumarasi.Caption = "Vergi Numarası";
            this.VergiNumarasi.FieldName = "TaxNumber";
            this.VergiNumarasi.Name = "VergiNumarasi";
            this.VergiNumarasi.Visible = true;
            this.VergiNumarasi.VisibleIndex = 7;
            // 
            // MarketinBorcu
            // 
            this.MarketinBorcu.Caption = "Marketin Borcu";
            this.MarketinBorcu.FieldName = "MarketsDebtSums";
            this.MarketinBorcu.Name = "MarketinBorcu";
            this.MarketinBorcu.Visible = true;
            this.MarketinBorcu.VisibleIndex = 8;
            // 
            // TedarikcininBorcu
            // 
            this.TedarikcininBorcu.Caption = "Tedarikçinin Borcu";
            this.TedarikcininBorcu.FieldName = "SuppliersDebtSums";
            this.TedarikcininBorcu.Name = "TedarikcininBorcu";
            this.TedarikcininBorcu.Visible = true;
            this.TedarikcininBorcu.VisibleIndex = 9;
            // 
            // TedarikciKodu
            // 
            this.TedarikciKodu.Caption = "Tedarikçi Kodu";
            this.TedarikciKodu.FieldName = "SupplierId";
            this.TedarikciKodu.Name = "TedarikciKodu";
            this.TedarikciKodu.Visible = true;
            this.TedarikciKodu.VisibleIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFirmaSil);
            this.panel1.Controls.Add(this.btnFirmaGuncelle);
            this.panel1.Controls.Add(this.btnHepsiniGetir);
            this.panel1.Controls.Add(this.lkpFirmalar);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnFirmaHareket);
            this.panel1.Controls.Add(this.btnFirmaEkle);
            this.panel1.Controls.Add(this.btnFirmaDetay);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnFirmaSil
            // 
            this.btnFirmaSil.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaSil.Appearance.Options.UseFont = true;
            this.btnFirmaSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirmaSil.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.deletedatasource;
            this.btnFirmaSil.Location = new System.Drawing.Point(864, 15);
            this.btnFirmaSil.Name = "btnFirmaSil";
            this.btnFirmaSil.Size = new System.Drawing.Size(135, 70);
            this.btnFirmaSil.TabIndex = 44;
            this.btnFirmaSil.Text = "Firma Sil";
            this.btnFirmaSil.Click += new System.EventHandler(this.btnFirmaSil_Click);
            // 
            // btnFirmaGuncelle
            // 
            this.btnFirmaGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaGuncelle.Appearance.Options.UseFont = true;
            this.btnFirmaGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirmaGuncelle.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.managequeries;
            this.btnFirmaGuncelle.Location = new System.Drawing.Point(1016, 15);
            this.btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            this.btnFirmaGuncelle.Size = new System.Drawing.Size(133, 70);
            this.btnFirmaGuncelle.TabIndex = 43;
            this.btnFirmaGuncelle.Text = "Firma \r\nGüncelle";
            this.btnFirmaGuncelle.Click += new System.EventHandler(this.btnFirmaGuncelle_Click);
            // 
            // btnHepsiniGetir
            // 
            this.btnHepsiniGetir.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniGetir.Appearance.Options.UseFont = true;
            this.btnHepsiniGetir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHepsiniGetir.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.bo_vendor;
            this.btnHepsiniGetir.Location = new System.Drawing.Point(254, 15);
            this.btnHepsiniGetir.Name = "btnHepsiniGetir";
            this.btnHepsiniGetir.Size = new System.Drawing.Size(126, 70);
            this.btnHepsiniGetir.TabIndex = 42;
            this.btnHepsiniGetir.Text = "Hepsini\r\n Getir";
            this.btnHepsiniGetir.Click += new System.EventHandler(this.btnHepsiniGetir_Click);
            // 
            // lkpFirmalar
            // 
            this.lkpFirmalar.EditValue = "İsim Yazın";
            this.lkpFirmalar.Location = new System.Drawing.Point(12, 12);
            this.lkpFirmalar.Name = "lkpFirmalar";
            this.lkpFirmalar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkpFirmalar.Properties.Appearance.Options.UseFont = true;
            this.lkpFirmalar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpFirmalar.Properties.PopupView = this.lkpMusterilerGrid;
            this.lkpFirmalar.Size = new System.Drawing.Size(225, 32);
            this.lkpFirmalar.TabIndex = 41;
            this.lkpFirmalar.EditValueChanged += new System.EventHandler(this.lkpFirmalar_EditValueChanged);
            // 
            // lkpMusterilerGrid
            // 
            this.lkpMusterilerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CompanyName,
            this.ContactName});
            this.lkpMusterilerGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lkpMusterilerGrid.Name = "lkpMusterilerGrid";
            this.lkpMusterilerGrid.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.lkpMusterilerGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lkpMusterilerGrid.OptionsView.ShowGroupPanel = false;
            // 
            // CompanyName
            // 
            this.CompanyName.Caption = "Şirket Adı";
            this.CompanyName.FieldName = "CompanyName";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Visible = true;
            this.CompanyName.VisibleIndex = 0;
            // 
            // ContactName
            // 
            this.ContactName.Caption = "İletişim Sorumlusu";
            this.ContactName.FieldName = "ContactName";
            this.ContactName.Name = "ContactName";
            this.ContactName.Visible = true;
            this.ContactName.VisibleIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcel.ImageOptions.Image = global::dhProje_marketOtomasyonu.Properties.Resources.exporttocsv_32x321;
            this.btnExcel.Location = new System.Drawing.Point(1164, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(112, 70);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnFirmaHareket
            // 
            this.btnFirmaHareket.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaHareket.Appearance.Options.UseFont = true;
            this.btnFirmaHareket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirmaHareket.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.columntotalsposition;
            this.btnFirmaHareket.Location = new System.Drawing.Point(527, 15);
            this.btnFirmaHareket.Name = "btnFirmaHareket";
            this.btnFirmaHareket.Size = new System.Drawing.Size(156, 70);
            this.btnFirmaHareket.TabIndex = 10;
            this.btnFirmaHareket.Text = "Firma\r\nHareketleri";
            this.btnFirmaHareket.Click += new System.EventHandler(this.btnFirmaHareket_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.Appearance.Options.UseFont = true;
            this.btnFirmaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirmaEkle.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.adddatasource;
            this.btnFirmaEkle.Location = new System.Drawing.Point(701, 15);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(147, 70);
            this.btnFirmaEkle.TabIndex = 9;
            this.btnFirmaEkle.Text = "Firma Ekle";
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // btnFirmaDetay
            // 
            this.btnFirmaDetay.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaDetay.Appearance.Options.UseFont = true;
            this.btnFirmaDetay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFirmaDetay.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.bo_report;
            this.btnFirmaDetay.Location = new System.Drawing.Point(397, 15);
            this.btnFirmaDetay.Name = "btnFirmaDetay";
            this.btnFirmaDetay.Size = new System.Drawing.Size(115, 70);
            this.btnFirmaDetay.TabIndex = 8;
            this.btnFirmaDetay.Text = "Firma\r\nDetay";
            this.btnFirmaDetay.Click += new System.EventHandler(this.btnFirmaDetay_Click);
            // 
            // btnAra
            // 
            this.btnAra.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Appearance.Options.UseFont = true;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAra.ImageOptions.SvgImage = global::dhProje_marketOtomasyonu.Properties.Resources.next2;
            this.btnAra.Location = new System.Drawing.Point(12, 53);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(225, 41);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Firma Getir";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmFirmaTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 664);
            this.Controls.Add(this.gcList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFirmaTakibi";
            this.Text = "Firmalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFirmaTakibi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkpFirmalar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.Columns.GridColumn SirketAdi;
        private DevExpress.XtraGrid.Columns.GridColumn İletisimSorumlusu;
        private DevExpress.XtraGrid.Columns.GridColumn SorumluRutbesi;
        private DevExpress.XtraGrid.Columns.GridColumn Adres;
        private DevExpress.XtraGrid.Columns.GridColumn Sehir;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn Bolge;
        private DevExpress.XtraGrid.Columns.GridColumn VergiNumarasi;
        private DevExpress.XtraGrid.Columns.GridColumn TedarikciKodu;
        private DevExpress.XtraGrid.Columns.GridColumn MarketinBorcu;
        private DevExpress.XtraGrid.Columns.GridColumn TedarikcininBorcu;
        private DevExpress.XtraEditors.SimpleButton btnFirmaDetay;
        private DevExpress.XtraEditors.SimpleButton btnFirmaEkle;
        private DevExpress.XtraEditors.SimpleButton btnFirmaHareket;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.GridLookUpEdit lkpFirmalar;
        private DevExpress.XtraGrid.Views.Grid.GridView lkpMusterilerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn CompanyName;
        private DevExpress.XtraEditors.SimpleButton btnHepsiniGetir;
        private DevExpress.XtraGrid.Columns.GridColumn ContactName;
        private DevExpress.XtraEditors.SimpleButton btnFirmaSil;
        private DevExpress.XtraEditors.SimpleButton btnFirmaGuncelle;
    }
}