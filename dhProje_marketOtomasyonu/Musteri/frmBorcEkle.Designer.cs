namespace dhProje_marketOtomasyonu.Musteri
{
    partial class frmBorcEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorcEkle));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.txtDebtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.lblDebtQuantity = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebtQuantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(118, 90);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 40);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "Ekle";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIptal.ImageOptions.SvgImage")));
            this.btnIptal.Location = new System.Drawing.Point(12, 90);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(89, 40);
            this.btnIptal.TabIndex = 35;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtDebtQuantity
            // 
            this.txtDebtQuantity.Location = new System.Drawing.Point(89, 53);
            this.txtDebtQuantity.Name = "txtDebtQuantity";
            this.txtDebtQuantity.Size = new System.Drawing.Size(116, 20);
            this.txtDebtQuantity.TabIndex = 23;
            // 
            // lblDebtQuantity
            // 
            this.lblDebtQuantity.AutoSize = true;
            this.lblDebtQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDebtQuantity.Location = new System.Drawing.Point(24, 56);
            this.lblDebtQuantity.Name = "lblDebtQuantity";
            this.lblDebtQuantity.Size = new System.Drawing.Size(46, 16);
            this.lblDebtQuantity.TabIndex = 22;
            this.lblDebtQuantity.Text = "Borç :";
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblShowName.Location = new System.Drawing.Point(69, 20);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(86, 16);
            this.lblShowName.TabIndex = 37;
            this.lblShowName.Text = "Müşteri Adı ";
            // 
            // frmBorcEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 144);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.txtDebtQuantity);
            this.Controls.Add(this.lblDebtQuantity);
            this.Name = "frmBorcEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borç Bilgisi";
            this.Load += new System.EventHandler(this.frmBorcEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDebtQuantity.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.TextEdit txtDebtQuantity;
        private System.Windows.Forms.Label lblDebtQuantity;
        private System.Windows.Forms.Label lblShowName;
    }
}