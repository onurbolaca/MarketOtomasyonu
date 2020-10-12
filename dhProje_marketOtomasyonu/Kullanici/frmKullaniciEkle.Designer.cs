namespace dhProje_marketOtomasyonu.Kullanici
{
    partial class frmKullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkle));
            this.lblRegion = new DevExpress.XtraEditors.LabelControl();
            this.lblFirstName = new DevExpress.XtraEditors.LabelControl();
            this.txtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.lblCity = new DevExpress.XtraEditors.LabelControl();
            this.txtCity = new DevExpress.XtraEditors.TextEdit();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.lblHireDate = new DevExpress.XtraEditors.LabelControl();
            this.txtHireDate = new DevExpress.XtraEditors.TextEdit();
            this.lblBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.txtBirthDate = new DevExpress.XtraEditors.TextEdit();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblLastName = new DevExpress.XtraEditors.LabelControl();
            this.txtLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtRegion = new DevExpress.XtraEditors.TextEdit();
            this.txtPostalCode = new DevExpress.XtraEditors.TextEdit();
            this.lblPostalCode = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblPhone = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHireDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostalCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegion
            // 
            this.lblRegion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegion.Appearance.Options.UseFont = true;
            this.lblRegion.Location = new System.Drawing.Point(12, 376);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(46, 16);
            this.lblRegion.TabIndex = 65;
            this.lblRegion.Text = "Semt  :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.Appearance.Options.UseFont = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(34, 16);
            this.lblFirstName.TabIndex = 63;
            this.lblFirstName.Text = "Adı  :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Properties.Appearance.Options.UseFont = true;
            this.txtFirstName.Size = new System.Drawing.Size(190, 22);
            this.txtFirstName.TabIndex = 62;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(175, 515);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 52);
            this.btnOK.TabIndex = 61;
            this.btnOK.Text = "Ekle";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIptal.ImageOptions.SvgImage")));
            this.btnIptal.Location = new System.Drawing.Point(36, 515);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 52);
            this.btnIptal.TabIndex = 60;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblCity
            // 
            this.lblCity.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Appearance.Options.UseFont = true;
            this.lblCity.Location = new System.Drawing.Point(12, 334);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 16);
            this.lblCity.TabIndex = 59;
            this.lblCity.Text = "Şehir :";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(125, 328);
            this.txtCity.Name = "txtCity";
            this.txtCity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCity.Properties.Appearance.Options.UseFont = true;
            this.txtCity.Size = new System.Drawing.Size(190, 22);
            this.txtCity.TabIndex = 58;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.Appearance.Options.UseFont = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 290);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(52, 16);
            this.lblAddress.TabIndex = 57;
            this.lblAddress.Text = "Adres  :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 283);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(190, 22);
            this.txtAddress.TabIndex = 56;
            // 
            // lblHireDate
            // 
            this.lblHireDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHireDate.Appearance.Options.UseFont = true;
            this.lblHireDate.Location = new System.Drawing.Point(12, 244);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(103, 16);
            this.lblHireDate.TabIndex = 55;
            this.lblHireDate.Text = "İşe Alım Tarihi  :";
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(125, 237);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHireDate.Properties.Appearance.Options.UseFont = true;
            this.txtHireDate.Size = new System.Drawing.Size(190, 22);
            this.txtHireDate.TabIndex = 54;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirthDate.Appearance.Options.UseFont = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 196);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(96, 16);
            this.lblBirthDate.TabIndex = 53;
            this.lblBirthDate.Text = "Doğum Tarihi  :";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(125, 189);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirthDate.Properties.Appearance.Options.UseFont = true;
            this.txtBirthDate.Size = new System.Drawing.Size(190, 22);
            this.txtBirthDate.TabIndex = 52;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 152);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 16);
            this.lblTitle.TabIndex = 51;
            this.lblTitle.Text = "Ünvan :";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(125, 145);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Properties.Appearance.Options.UseFont = true;
            this.txtTitle.Size = new System.Drawing.Size(190, 22);
            this.txtTitle.TabIndex = 50;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(39, 16);
            this.lblPassword.TabIndex = 49;
            this.lblPassword.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(125, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Size = new System.Drawing.Size(190, 22);
            this.txtPassword.TabIndex = 48;
            // 
            // lblLastName
            // 
            this.lblLastName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.Appearance.Options.UseFont = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 16);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Soyadı  :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(125, 59);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Properties.Appearance.Options.UseFont = true;
            this.txtLastName.Size = new System.Drawing.Size(190, 22);
            this.txtLastName.TabIndex = 44;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(125, 373);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRegion.Properties.Appearance.Options.UseFont = true;
            this.txtRegion.Size = new System.Drawing.Size(190, 22);
            this.txtRegion.TabIndex = 66;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(125, 415);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPostalCode.Properties.Appearance.Options.UseFont = true;
            this.txtPostalCode.Size = new System.Drawing.Size(190, 22);
            this.txtPostalCode.TabIndex = 68;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPostalCode.Appearance.Options.UseFont = true;
            this.lblPostalCode.Location = new System.Drawing.Point(12, 418);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(86, 16);
            this.lblPostalCode.TabIndex = 67;
            this.lblPostalCode.Text = "Posta Kodu  :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(125, 458);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Size = new System.Drawing.Size(190, 22);
            this.txtPhone.TabIndex = 70;
            // 
            // lblPhone
            // 
            this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.Appearance.Options.UseFont = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 461);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 16);
            this.lblPhone.TabIndex = 69;
            this.lblPhone.Text = "Telefon  :";
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 579);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Name = "frmKullaniciEkle";
            this.Text = "frmKullaniciEkle";
            this.Load += new System.EventHandler(this.frmKullaniciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHireDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPostalCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblRegion;
        private DevExpress.XtraEditors.LabelControl lblFirstName;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl lblCity;
        private DevExpress.XtraEditors.TextEdit txtCity;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl lblHireDate;
        private DevExpress.XtraEditors.TextEdit txtHireDate;
        private DevExpress.XtraEditors.LabelControl lblBirthDate;
        private DevExpress.XtraEditors.TextEdit txtBirthDate;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblLastName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtRegion;
        private DevExpress.XtraEditors.TextEdit txtPostalCode;
        private DevExpress.XtraEditors.LabelControl lblPostalCode;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lblPhone;
    }
}