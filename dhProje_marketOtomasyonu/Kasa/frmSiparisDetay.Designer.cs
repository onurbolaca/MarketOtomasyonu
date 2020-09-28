namespace dhProje_marketOtomasyonu.Kasa
{
    partial class frmSiparisDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisDetay));
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UrunIsmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ToplamFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(635, 465);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UrunIsmi,
            this.Fiyat,
            this.Miktar,
            this.ToplamFiyat});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.OptionsBehavior.ReadOnly = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            // 
            // UrunIsmi
            // 
            this.UrunIsmi.Caption = "Ürün İsmi";
            this.UrunIsmi.FieldName = "ProductName";
            this.UrunIsmi.Name = "UrunIsmi";
            this.UrunIsmi.Visible = true;
            this.UrunIsmi.VisibleIndex = 0;
            // 
            // Fiyat
            // 
            this.Fiyat.Caption = "Fiyat";
            this.Fiyat.FieldName = "SellingPrice";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Visible = true;
            this.Fiyat.VisibleIndex = 1;
            // 
            // Miktar
            // 
            this.Miktar.Caption = "Miktar";
            this.Miktar.FieldName = "Quantity";
            this.Miktar.Name = "Miktar";
            this.Miktar.Visible = true;
            this.Miktar.VisibleIndex = 2;
            // 
            // ToplamFiyat
            // 
            this.ToplamFiyat.Caption = "Toplam Fiyat";
            this.ToplamFiyat.FieldName = "TotalRowPrice";
            this.ToplamFiyat.Name = "ToplamFiyat";
            this.ToplamFiyat.Visible = true;
            this.ToplamFiyat.VisibleIndex = 3;
            // 
            // frmSiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 465);
            this.Controls.Add(this.gcList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiparisDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detayı";
            this.Load += new System.EventHandler(this.frmSiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn UrunIsmi;
        private DevExpress.XtraGrid.Columns.GridColumn Fiyat;
        private DevExpress.XtraGrid.Columns.GridColumn Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn ToplamFiyat;
    }
}