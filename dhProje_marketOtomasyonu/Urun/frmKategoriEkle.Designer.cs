namespace dhProje_marketOtomasyonu.Urun
{
    partial class frmKategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKategoriEkle));
            this.lblKategoriAdi = new System.Windows.Forms.Label();
            this.txtEkle = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOnayla = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoGuncelle = new System.Windows.Forms.RadioButton();
            this.rdoSil = new System.Windows.Forms.RadioButton();
            this.rdoEkle = new System.Windows.Forms.RadioButton();
            this.lkpSec = new DevExpress.XtraEditors.GridLookUpEdit();
            this.lkpMusterilerGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Kategoriler = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtEkle.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.AutoSize = true;
            this.lblKategoriAdi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriAdi.Location = new System.Drawing.Point(9, 203);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(124, 16);
            this.lblKategoriAdi.TabIndex = 1;
            this.lblKategoriAdi.Text = "Kategori Adı Seç :";
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(9, 118);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEkle.Properties.Appearance.Options.UseFont = true;
            this.txtEkle.Size = new System.Drawing.Size(201, 24);
            this.txtEkle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı Gir :";
            // 
            // btnOnayla
            // 
            this.btnOnayla.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Appearance.Options.UseFont = true;
            this.btnOnayla.Location = new System.Drawing.Point(124, 280);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(86, 48);
            this.btnOnayla.TabIndex = 6;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Location = new System.Drawing.Point(12, 280);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(86, 48);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lkpSec);
            this.panel1.Controls.Add(this.rdoEkle);
            this.panel1.Controls.Add(this.rdoSil);
            this.panel1.Controls.Add(this.rdoGuncelle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.txtEkle);
            this.panel1.Controls.Add(this.lblKategoriAdi);
            this.panel1.Controls.Add(this.btnOnayla);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 339);
            this.panel1.TabIndex = 10;
            // 
            // rdoGuncelle
            // 
            this.rdoGuncelle.AutoSize = true;
            this.rdoGuncelle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoGuncelle.ForeColor = System.Drawing.Color.Maroon;
            this.rdoGuncelle.Location = new System.Drawing.Point(9, 48);
            this.rdoGuncelle.Name = "rdoGuncelle";
            this.rdoGuncelle.Size = new System.Drawing.Size(172, 23);
            this.rdoGuncelle.TabIndex = 10;
            this.rdoGuncelle.TabStop = true;
            this.rdoGuncelle.Text = "Kategori Güncelle";
            this.rdoGuncelle.UseVisualStyleBackColor = true;
            this.rdoGuncelle.CheckedChanged += new System.EventHandler(this.rdoGuncelle_CheckedChanged);
            // 
            // rdoSil
            // 
            this.rdoSil.AutoSize = true;
            this.rdoSil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoSil.ForeColor = System.Drawing.Color.Maroon;
            this.rdoSil.Location = new System.Drawing.Point(12, 159);
            this.rdoSil.Name = "rdoSil";
            this.rdoSil.Size = new System.Drawing.Size(122, 23);
            this.rdoSil.TabIndex = 11;
            this.rdoSil.TabStop = true;
            this.rdoSil.Text = "Kategori Sil";
            this.rdoSil.UseVisualStyleBackColor = true;
            this.rdoSil.CheckedChanged += new System.EventHandler(this.rdoSil_CheckedChanged);
            // 
            // rdoEkle
            // 
            this.rdoEkle.AutoSize = true;
            this.rdoEkle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoEkle.ForeColor = System.Drawing.Color.Maroon;
            this.rdoEkle.Location = new System.Drawing.Point(9, 19);
            this.rdoEkle.Name = "rdoEkle";
            this.rdoEkle.Size = new System.Drawing.Size(137, 23);
            this.rdoEkle.TabIndex = 12;
            this.rdoEkle.TabStop = true;
            this.rdoEkle.Text = "Kategori Ekle";
            this.rdoEkle.UseVisualStyleBackColor = true;
            this.rdoEkle.CheckedChanged += new System.EventHandler(this.rdoEkle_CheckedChanged);
            // 
            // lkpSec
            // 
            this.lkpSec.EditValue = ".";
            this.lkpSec.Location = new System.Drawing.Point(12, 235);
            this.lkpSec.Name = "lkpSec";
            this.lkpSec.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkpSec.Properties.Appearance.Options.UseFont = true;
            this.lkpSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpSec.Properties.PopupView = this.lkpMusterilerGrid;
            this.lkpSec.Size = new System.Drawing.Size(198, 24);
            this.lkpSec.TabIndex = 41;
            this.lkpSec.EditValueChanged += new System.EventHandler(this.lkpSec_EditValueChanged);
            // 
            // lkpMusterilerGrid
            // 
            this.lkpMusterilerGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Kategoriler});
            this.lkpMusterilerGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.lkpMusterilerGrid.Name = "lkpMusterilerGrid";
            this.lkpMusterilerGrid.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.lkpMusterilerGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.lkpMusterilerGrid.OptionsView.ShowGroupPanel = false;
            // 
            // Kategoriler
            // 
            this.Kategoriler.Caption = "Kategoriler";
            this.Kategoriler.FieldName = "CategoryName";
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Visible = true;
            this.Kategoriler.VisibleIndex = 0;
            // 
            // frmKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 360);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori Ekle";
            this.Load += new System.EventHandler(this.frmKategoriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEkle.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpMusterilerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblKategoriAdi;
        private DevExpress.XtraEditors.TextEdit txtEkle;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnOnayla;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoEkle;
        private System.Windows.Forms.RadioButton rdoSil;
        private System.Windows.Forms.RadioButton rdoGuncelle;
        private DevExpress.XtraEditors.GridLookUpEdit lkpSec;
        private DevExpress.XtraGrid.Views.Grid.GridView lkpMusterilerGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Kategoriler;
    }
}