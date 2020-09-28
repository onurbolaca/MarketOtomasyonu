namespace dhProje_marketOtomasyonu.Urun
{
    partial class frmStokEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokEkle));
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.lblMinStockLevel = new DevExpress.XtraEditors.LabelControl();
            this.txtMinStockLevel = new DevExpress.XtraEditors.TextEdit();
            this.lblUnitsInOrder = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitsInOrder = new DevExpress.XtraEditors.TextEdit();
            this.lblUnitsInStock = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitsInStock = new DevExpress.XtraEditors.TextEdit();
            this.lblQuantityPerUnit = new DevExpress.XtraEditors.LabelControl();
            this.txtQuantityPerUnit = new DevExpress.XtraEditors.TextEdit();
            this.lblSellingPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtSellingPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblBuyingPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtBuyingPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblKdvRate = new DevExpress.XtraEditors.LabelControl();
            this.txtKdvRate = new DevExpress.XtraEditors.TextEdit();
            this.lblStockBarcode = new DevExpress.XtraEditors.LabelControl();
            this.txtStockBarcode = new DevExpress.XtraEditors.TextEdit();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinStockLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityPerUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellingPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyingPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockBarcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOK.ImageOptions.SvgImage")));
            this.btnOK.Location = new System.Drawing.Point(178, 483);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(118, 52);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "Ekle";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIptal.ImageOptions.SvgImage")));
            this.btnIptal.Location = new System.Drawing.Point(39, 483);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 52);
            this.btnIptal.TabIndex = 38;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblMinStockLevel
            // 
            this.lblMinStockLevel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinStockLevel.Appearance.Options.UseFont = true;
            this.lblMinStockLevel.Location = new System.Drawing.Point(14, 383);
            this.lblMinStockLevel.Name = "lblMinStockLevel";
            this.lblMinStockLevel.Size = new System.Drawing.Size(108, 16);
            this.lblMinStockLevel.TabIndex = 37;
            this.lblMinStockLevel.Text = "Min Stok Miktarı:";
            // 
            // txtMinStockLevel
            // 
            this.txtMinStockLevel.Location = new System.Drawing.Point(127, 377);
            this.txtMinStockLevel.Name = "txtMinStockLevel";
            this.txtMinStockLevel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMinStockLevel.Properties.Appearance.Options.UseFont = true;
            this.txtMinStockLevel.Size = new System.Drawing.Size(190, 22);
            this.txtMinStockLevel.TabIndex = 36;
            // 
            // lblUnitsInOrder
            // 
            this.lblUnitsInOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitsInOrder.Appearance.Options.UseFont = true;
            this.lblUnitsInOrder.Location = new System.Drawing.Point(14, 339);
            this.lblUnitsInOrder.Name = "lblUnitsInOrder";
            this.lblUnitsInOrder.Size = new System.Drawing.Size(102, 16);
            this.lblUnitsInOrder.TabIndex = 35;
            this.lblUnitsInOrder.Text = "Siparişte Olan  :";
            // 
            // txtUnitsInOrder
            // 
            this.txtUnitsInOrder.Location = new System.Drawing.Point(127, 332);
            this.txtUnitsInOrder.Name = "txtUnitsInOrder";
            this.txtUnitsInOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitsInOrder.Properties.Appearance.Options.UseFont = true;
            this.txtUnitsInOrder.Size = new System.Drawing.Size(190, 22);
            this.txtUnitsInOrder.TabIndex = 34;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnitsInStock.Appearance.Options.UseFont = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(14, 293);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(90, 16);
            this.lblUnitsInStock.TabIndex = 33;
            this.lblUnitsInStock.Text = "Stok Miktarı  :";
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(127, 286);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitsInStock.Properties.Appearance.Options.UseFont = true;
            this.txtUnitsInStock.Size = new System.Drawing.Size(190, 22);
            this.txtUnitsInStock.TabIndex = 32;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuantityPerUnit.Appearance.Options.UseFont = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(14, 245);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(68, 16);
            this.lblQuantityPerUnit.TabIndex = 31;
            this.lblQuantityPerUnit.Text = "Ürün Tipi  :";
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Location = new System.Drawing.Point(127, 238);
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQuantityPerUnit.Properties.Appearance.Options.UseFont = true;
            this.txtQuantityPerUnit.Size = new System.Drawing.Size(190, 22);
            this.txtQuantityPerUnit.TabIndex = 30;
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSellingPrice.Appearance.Options.UseFont = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(14, 201);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(83, 16);
            this.lblSellingPrice.TabIndex = 29;
            this.lblSellingPrice.Text = "Satış Fiyatı  :";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(127, 194);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSellingPrice.Properties.Appearance.Options.UseFont = true;
            this.txtSellingPrice.Size = new System.Drawing.Size(190, 22);
            this.txtSellingPrice.TabIndex = 28;
            // 
            // lblBuyingPrice
            // 
            this.lblBuyingPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBuyingPrice.Appearance.Options.UseFont = true;
            this.lblBuyingPrice.Location = new System.Drawing.Point(14, 156);
            this.lblBuyingPrice.Name = "lblBuyingPrice";
            this.lblBuyingPrice.Size = new System.Drawing.Size(74, 16);
            this.lblBuyingPrice.TabIndex = 27;
            this.lblBuyingPrice.Text = "Alış Fiyatı  :";
            // 
            // txtBuyingPrice
            // 
            this.txtBuyingPrice.Location = new System.Drawing.Point(127, 149);
            this.txtBuyingPrice.Name = "txtBuyingPrice";
            this.txtBuyingPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBuyingPrice.Properties.Appearance.Options.UseFont = true;
            this.txtBuyingPrice.Size = new System.Drawing.Size(190, 22);
            this.txtBuyingPrice.TabIndex = 26;
            // 
            // lblKdvRate
            // 
            this.lblKdvRate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKdvRate.Appearance.Options.UseFont = true;
            this.lblKdvRate.Location = new System.Drawing.Point(14, 110);
            this.lblKdvRate.Name = "lblKdvRate";
            this.lblKdvRate.Size = new System.Drawing.Size(68, 16);
            this.lblKdvRate.TabIndex = 25;
            this.lblKdvRate.Text = "Kdv Rate :";
            // 
            // txtKdvRate
            // 
            this.txtKdvRate.Location = new System.Drawing.Point(127, 103);
            this.txtKdvRate.Name = "txtKdvRate";
            this.txtKdvRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKdvRate.Properties.Appearance.Options.UseFont = true;
            this.txtKdvRate.Size = new System.Drawing.Size(190, 22);
            this.txtKdvRate.TabIndex = 24;
            // 
            // lblStockBarcode
            // 
            this.lblStockBarcode.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStockBarcode.Appearance.Options.UseFont = true;
            this.lblStockBarcode.Location = new System.Drawing.Point(14, 67);
            this.lblStockBarcode.Name = "lblStockBarcode";
            this.lblStockBarcode.Size = new System.Drawing.Size(91, 16);
            this.lblStockBarcode.TabIndex = 23;
            this.lblStockBarcode.Text = "Stok Barkod  :";
            // 
            // txtStockBarcode
            // 
            this.txtStockBarcode.Location = new System.Drawing.Point(127, 60);
            this.txtStockBarcode.Name = "txtStockBarcode";
            this.txtStockBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStockBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtStockBarcode.Size = new System.Drawing.Size(190, 22);
            this.txtStockBarcode.TabIndex = 22;
            // 
            // lblProductName
            // 
            this.lblProductName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductName.Appearance.Options.UseFont = true;
            this.lblProductName.Location = new System.Drawing.Point(14, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(68, 16);
            this.lblProductName.TabIndex = 41;
            this.lblProductName.Text = "Ürün Adı  :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(127, 21);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProductName.Properties.Appearance.Options.UseFont = true;
            this.txtProductName.Size = new System.Drawing.Size(190, 22);
            this.txtProductName.TabIndex = 40;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(127, 423);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(190, 22);
            this.cmbKategori.TabIndex = 42;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryName.Appearance.Options.UseFont = true;
            this.lblCategoryName.Location = new System.Drawing.Point(14, 428);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(93, 16);
            this.lblCategoryName.TabIndex = 43;
            this.lblCategoryName.Text = "Kategori Adı  :";
            // 
            // frmStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 547);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblMinStockLevel);
            this.Controls.Add(this.txtMinStockLevel);
            this.Controls.Add(this.lblUnitsInOrder);
            this.Controls.Add(this.txtUnitsInOrder);
            this.Controls.Add(this.lblUnitsInStock);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.lblQuantityPerUnit);
            this.Controls.Add(this.txtQuantityPerUnit);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.lblBuyingPrice);
            this.Controls.Add(this.txtBuyingPrice);
            this.Controls.Add(this.lblKdvRate);
            this.Controls.Add(this.txtKdvRate);
            this.Controls.Add(this.lblStockBarcode);
            this.Controls.Add(this.txtStockBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Ekle";
            this.Load += new System.EventHandler(this.frmStokEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMinStockLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitsInStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityPerUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellingPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyingPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKdvRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStockBarcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl lblMinStockLevel;
        private DevExpress.XtraEditors.TextEdit txtMinStockLevel;
        private DevExpress.XtraEditors.LabelControl lblUnitsInOrder;
        private DevExpress.XtraEditors.TextEdit txtUnitsInOrder;
        private DevExpress.XtraEditors.LabelControl lblUnitsInStock;
        private DevExpress.XtraEditors.TextEdit txtUnitsInStock;
        private DevExpress.XtraEditors.LabelControl lblQuantityPerUnit;
        private DevExpress.XtraEditors.TextEdit txtQuantityPerUnit;
        private DevExpress.XtraEditors.LabelControl lblSellingPrice;
        private DevExpress.XtraEditors.TextEdit txtSellingPrice;
        private DevExpress.XtraEditors.LabelControl lblBuyingPrice;
        private DevExpress.XtraEditors.TextEdit txtBuyingPrice;
        private DevExpress.XtraEditors.LabelControl lblKdvRate;
        private DevExpress.XtraEditors.TextEdit txtKdvRate;
        private DevExpress.XtraEditors.LabelControl lblStockBarcode;
        private DevExpress.XtraEditors.TextEdit txtStockBarcode;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private System.Windows.Forms.ComboBox cmbKategori;
        private DevExpress.XtraEditors.LabelControl lblCategoryName;
    }
}