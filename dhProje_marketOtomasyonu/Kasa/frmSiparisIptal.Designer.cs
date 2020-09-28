namespace dhProje_marketOtomasyonu.Kasa
{
    partial class frmSiparisIptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSiparisIptal));
            this.btnIslemVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisIptal = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetay = new DevExpress.XtraEditors.SimpleButton();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.o = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SiparisToplami = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MüsteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIslemVazgec
            // 
            this.btnIslemVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemVazgec.Appearance.Options.UseFont = true;
            this.btnIslemVazgec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIslemVazgec.ImageOptions.SvgImage")));
            this.btnIslemVazgec.Location = new System.Drawing.Point(76, 13);
            this.btnIslemVazgec.Name = "btnIslemVazgec";
            this.btnIslemVazgec.Size = new System.Drawing.Size(149, 54);
            this.btnIslemVazgec.TabIndex = 45;
            this.btnIslemVazgec.Text = "Vazgeç";
            this.btnIslemVazgec.Click += new System.EventHandler(this.btnIslemVazgec_Click);
            // 
            // btnSiparisIptal
            // 
            this.btnSiparisIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisIptal.Appearance.Options.UseFont = true;
            this.btnSiparisIptal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparisIptal.ImageOptions.SvgImage")));
            this.btnSiparisIptal.Location = new System.Drawing.Point(451, 13);
            this.btnSiparisIptal.Name = "btnSiparisIptal";
            this.btnSiparisIptal.Size = new System.Drawing.Size(149, 54);
            this.btnSiparisIptal.TabIndex = 43;
            this.btnSiparisIptal.Text = "Siparişi Sil";
            this.btnSiparisIptal.Click += new System.EventHandler(this.btnSiparisIptal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDetay);
            this.panel1.Controls.Add(this.btnIslemVazgec);
            this.panel1.Controls.Add(this.btnSiparisIptal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 79);
            this.panel1.TabIndex = 46;
            // 
            // btnDetay
            // 
            this.btnDetay.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetay.Appearance.Options.UseFont = true;
            this.btnDetay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDetay.ImageOptions.SvgImage")));
            this.btnDetay.Location = new System.Drawing.Point(262, 13);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(149, 54);
            this.btnDetay.TabIndex = 46;
            this.btnDetay.Text = "Sipariş Detay";
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(683, 421);
            this.gcList.TabIndex = 47;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.o,
            this.SiparisToplami,
            this.Tarih,
            this.OdemeSekli,
            this.IndirimOrani,
            this.MüsteriAdi});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.OptionsBehavior.ReadOnly = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvList_SelectionChanged);
            // 
            // o
            // 
            this.o.Caption = "Sipariş Kodu";
            this.o.FieldName = "OrderId";
            this.o.Name = "o";
            this.o.Visible = true;
            this.o.VisibleIndex = 5;
            // 
            // SiparisToplami
            // 
            this.SiparisToplami.Caption = "Sipariş Toplamı";
            this.SiparisToplami.FieldName = "TotalOrderPrice";
            this.SiparisToplami.Name = "SiparisToplami";
            this.SiparisToplami.Visible = true;
            this.SiparisToplami.VisibleIndex = 0;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Tarih.FieldName = "OrderDate";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 1;
            // 
            // OdemeSekli
            // 
            this.OdemeSekli.Caption = "Ödeme Şekli";
            this.OdemeSekli.FieldName = "PaymentMethod";
            this.OdemeSekli.Name = "OdemeSekli";
            this.OdemeSekli.Visible = true;
            this.OdemeSekli.VisibleIndex = 2;
            // 
            // IndirimOrani
            // 
            this.IndirimOrani.Caption = "İndirim Oranı";
            this.IndirimOrani.FieldName = "DiscountRate";
            this.IndirimOrani.Name = "IndirimOrani";
            this.IndirimOrani.Visible = true;
            this.IndirimOrani.VisibleIndex = 3;
            // 
            // MüsteriAdi
            // 
            this.MüsteriAdi.Caption = "Müşteri Adı";
            this.MüsteriAdi.FieldName = "CustomerName";
            this.MüsteriAdi.Name = "MüsteriAdi";
            this.MüsteriAdi.Visible = true;
            this.MüsteriAdi.VisibleIndex = 4;
            // 
            // frmSiparisIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 500);
            this.Controls.Add(this.gcList);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSiparisIptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş İptali";
            this.Load += new System.EventHandler(this.frmSiparisIptal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnIslemVazgec;
        private DevExpress.XtraEditors.SimpleButton btnSiparisIptal;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn SiparisToplami;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn OdemeSekli;
        private DevExpress.XtraGrid.Columns.GridColumn IndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn MüsteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn o;
        private DevExpress.XtraEditors.SimpleButton btnDetay;
    }
}