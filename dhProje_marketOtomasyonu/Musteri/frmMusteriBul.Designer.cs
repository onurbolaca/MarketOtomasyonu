namespace dhProje_marketOtomasyonu
{
    partial class frmMusteriBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriBul));
            this.btnVeresiyeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblMusteriIsmi = new System.Windows.Forms.Label();
            this.lkpMusteriler = new DevExpress.XtraEditors.GridLookUpEdit();
            this.lkpMusterilerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MüsteriAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TcNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnYeniMusteri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusteriler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVeresiyeEkle
            // 
            this.btnVeresiyeEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeresiyeEkle.Appearance.Options.UseFont = true;
            this.btnVeresiyeEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVeresiyeEkle.ImageOptions.SvgImage")));
            this.btnVeresiyeEkle.Location = new System.Drawing.Point(176, 90);
            this.btnVeresiyeEkle.Name = "btnVeresiyeEkle";
            this.btnVeresiyeEkle.Size = new System.Drawing.Size(149, 54);
            this.btnVeresiyeEkle.TabIndex = 39;
            this.btnVeresiyeEkle.Text = "Veresiye Ekle ";
            this.btnVeresiyeEkle.Click += new System.EventHandler(this.btnVeresiyeEkle_Click);
            // 
            // lblMusteriIsmi
            // 
            this.lblMusteriIsmi.AutoSize = true;
            this.lblMusteriIsmi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriIsmi.Location = new System.Drawing.Point(12, 20);
            this.lblMusteriIsmi.Name = "lblMusteriIsmi";
            this.lblMusteriIsmi.Size = new System.Drawing.Size(174, 18);
            this.lblMusteriIsmi.TabIndex = 37;
            this.lblMusteriIsmi.Text = "Lütfen Bir İsim Yazın :";
            // 
            // lkpMusteriler
            // 
            this.lkpMusteriler.EditValue = "İsim Yazın";
            this.lkpMusteriler.Location = new System.Drawing.Point(15, 44);
            this.lkpMusteriler.Name = "lkpMusteriler";
            this.lkpMusteriler.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkpMusteriler.Properties.Appearance.Options.UseFont = true;
            this.lkpMusteriler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpMusteriler.Properties.PopupView = this.lkpMusterilerGrid;
            this.lkpMusteriler.Size = new System.Drawing.Size(310, 30);
            this.lkpMusteriler.TabIndex = 40;
            this.lkpMusteriler.EditValueChanged += new System.EventHandler(this.lkpMusteriler_EditValueChanged);
            // 
            // lkpMusterilerGrid
            // 
            this.lkpMusterilerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MüsteriAdi,
            this.Telefon,
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
            // Telefon
            // 
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Phone";
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 1;
            // 
            // TcNo
            // 
            this.TcNo.Caption = "Tc No:";
            this.TcNo.FieldName = "SocialNumber";
            this.TcNo.Name = "TcNo";
            this.TcNo.Visible = true;
            this.TcNo.VisibleIndex = 2;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.Appearance.Options.UseFont = true;
            this.btnYeniMusteri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYeniMusteri.ImageOptions.SvgImage")));
            this.btnYeniMusteri.Location = new System.Drawing.Point(12, 89);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(149, 54);
            this.btnYeniMusteri.TabIndex = 41;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmMusteriBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 164);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lkpMusteriler);
            this.Controls.Add(this.btnVeresiyeEkle);
            this.Controls.Add(this.lblMusteriIsmi);
            this.Name = "frmMusteriBul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Bul";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMusteriBul_FormClosed);
            this.Load += new System.EventHandler(this.frmMusteriBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusteriler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnVeresiyeEkle;
        private System.Windows.Forms.Label lblMusteriIsmi;
        private DevExpress.XtraEditors.GridLookUpEdit lkpMusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView lkpMusterilerGrid;
        private DevExpress.XtraEditors.SimpleButton btnYeniMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn MüsteriAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn TcNo;
    }
}