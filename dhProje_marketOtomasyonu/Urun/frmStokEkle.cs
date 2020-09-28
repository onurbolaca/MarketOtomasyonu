using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace dhProje_marketOtomasyonu.Urun
{
    public partial class frmStokEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmStokEkle(string stockId)
        {
            InitializeComponent();

            _stockId = stockId;
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string _stockId = "";

        string newStockId = "";


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStokEkle_Load(object sender, EventArgs e)
        {
            txtProductName.Focus();

            FillCombobox();

            GetToUpdate();
        }

        void FillCombobox()
        {
            try
            {
                using (da.SelectCommand = new SqlCommand(@"SELECT CategoryId, CategoryName
FROM            Categories", DbConnection.Connect()))
                {
                    da.Fill(dt);
                }

                cmbKategori.DataSource = dt;
                cmbKategori.DisplayMember = "CategoryName";
                cmbKategori.ValueMember = "CategoryId";
                cmbKategori.SelectedIndex = -1;

               

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        void GetToUpdate()
        {
            try
            {
                if (_stockId != "-1")
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandType = CommandType.Text,
                        Connection = DbConnection.Connect(),
                    };

                    cmd.CommandText = @"SELECT        dbo.Products.ProductName, dbo.Categories.CategoryId, dbo.Categories.CategoryName, dbo.Stocks.StockBarcode, dbo.Stocks.KdvRate, dbo.Stocks.BuyingPrice, dbo.Stocks.SellingPrice, dbo.Stocks.QuantityPerUnit, 
                         dbo.Stocks.UnitsInStock, dbo.Stocks.UnitsInOrder, dbo.Stocks.MinStockLevel, dbo.Stocks.StockId
FROM            dbo.Stocks INNER JOIN
                         dbo.Products ON dbo.Stocks.StockId = dbo.Products.StockId INNER JOIN
                         dbo.Categories ON dbo.Products.CategoryId = dbo.Categories.CategoryId
WHERE        (dbo.Stocks.StockId = @StockId) ";

                    cmd.Parameters.Add("@StockId", SqlDbType.Int).Value = Convert.ToInt32(_stockId);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            cmbKategori.Text = dr["CategoryName"].ToString();
                             txtProductName.Text = dr["ProductName"].ToString();
                            txtBuyingPrice.Text = dr["BuyingPrice"].ToString();
                            txtKdvRate.Text = dr["KdvRate"].ToString();
                            txtMinStockLevel.Text = dr["MinStockLevel"].ToString();
                            txtQuantityPerUnit.Text = dr["QuantityPerUnit"].ToString();
                            txtSellingPrice.Text = dr["SellingPrice"].ToString();
                            txtStockBarcode.Text = dr["StockBarcode"].ToString();
                            txtUnitsInOrder.Text = dr["UnitsInOrder"].ToString();
                            txtUnitsInStock.Text = dr["UnitsInStock"].ToString();
                        }
                    }

                    cmd.Parameters.Clear();

                    cmd.Dispose();

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        void SetStocks()
        {
            try
            {

                if (_stockId != "-1")
                {
                    SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                 

                    cmd.CommandText = @"UPDATE Stocks
                        SET dbo.Stocks.StockBarcode= @StockBarcode, dbo.Stocks.KdvRate= @KdvRate, dbo.Stocks.BuyingPrice= @BuyingPrice, dbo.Stocks.SellingPrice= @SellingPrice, dbo.Stocks.QuantityPerUnit= @QuantityPerUnit, dbo.Stocks.UnitsInStock= @UnitsInStock, 
dbo.Stocks.UnitsInOrder= @UnitsInOrder, dbo.Stocks.MinStockLevel= @MinStockLevel, 	
  	dbo.Stocks.StockDescription= @StockDescription
FROM            dbo.Stocks INNER JOIN
                         dbo.Products ON dbo.Stocks.StockId = dbo.Products.StockId
WHERE(dbo.Stocks.StockId = @StockId)";

                    cmd.Parameters.Add("@StockId", SqlDbType.Int).Value = Convert.ToInt32(_stockId);

                    cmd.Parameters.Add("@StockBarcode", SqlDbType.NVarChar).Value = txtStockBarcode.Text;

                    cmd.Parameters.Add("@KdvRate", SqlDbType.Int).Value = txtKdvRate.Text;

                    cmd.Parameters.Add("@BuyingPrice", SqlDbType.Decimal).Value = txtBuyingPrice.Text;

                    cmd.Parameters.Add("@SellingPrice", SqlDbType.Decimal).Value = txtSellingPrice.Text;

                    cmd.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar).Value = txtQuantityPerUnit.Text;

                    cmd.Parameters.Add("@UnitsInOrder", SqlDbType.Int).Value = txtUnitsInOrder.Text;

                    cmd.Parameters.Add("@UnitsInStock", SqlDbType.Int).Value = txtUnitsInStock.Text;

                    cmd.Parameters.Add("@MinStockLevel", SqlDbType.Int).Value = txtMinStockLevel.Text;

                    cmd.Parameters.Add("@StockDescription", SqlDbType.NVarChar).Value = txtProductName.Text;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();


                    cmd.CommandText = @"UPDATE Products
                        SET dbo.Products.ProductName = @ProductName, dbo.Products.CategoryId= @CategoryId
FROM            dbo.Stocks INNER JOIN
                         dbo.Products ON dbo.Stocks.StockId = dbo.Products.StockId
WHERE(dbo.Stocks.StockId = @StockId)";

                    cmd.Parameters.Add("@StockId", SqlDbType.Int).Value = Convert.ToInt32(_stockId);
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = txtProductName.Text;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = (int)cmbKategori.SelectedValue;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();

                    MessageBox.Show("Stok güncellendi ✔");

                    this.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                    cmd.CommandText = @"INSERT INTO 
Stocks (dbo.Stocks.StockBarcode, dbo.Stocks.KdvRate, dbo.Stocks.BuyingPrice, dbo.Stocks.SellingPrice, dbo.Stocks.QuantityPerUnit, dbo.Stocks.UnitsInStock, dbo.Stocks.UnitsInOrder, dbo.Stocks.MinStockLevel, dbo.Stocks.StockDescription)
                        
VALUES  (@StockBarcode,  @KdvRate,  @BuyingPrice,  @SellingPrice,  @QuantityPerUnit, @UnitsInStock, @UnitsInOrder,  @MinStockLevel, @StockDescription) SET @newStockId=SCOPE_IDENTITY() ";


                    cmd.Parameters.Add("@StockBarcode", SqlDbType.NVarChar).Value = txtStockBarcode.Text;

                    cmd.Parameters.Add("@KdvRate", SqlDbType.Int).Value = txtKdvRate.Text;

                    cmd.Parameters.Add("@BuyingPrice", SqlDbType.Decimal).Value = txtBuyingPrice.Text;

                    cmd.Parameters.Add("@SellingPrice", SqlDbType.Decimal).Value = txtSellingPrice.Text;

                    cmd.Parameters.Add("@QuantityPerUnit", SqlDbType.NVarChar).Value = txtQuantityPerUnit.Text;

                    cmd.Parameters.Add("@UnitsInOrder", SqlDbType.Int).Value = txtUnitsInOrder.Text;

                    cmd.Parameters.Add("@UnitsInStock", SqlDbType.Int).Value = txtUnitsInStock.Text;

                    cmd.Parameters.Add("@MinStockLevel", SqlDbType.Int).Value = txtMinStockLevel.Text;

                    cmd.Parameters.Add("@StockDescription", SqlDbType.NVarChar).Value = txtProductName.Text;


                    cmd.Parameters.Add("@newStockId", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    newStockId = cmd.Parameters["@newStockId"].Value.ToString();

                    cmd.Parameters.Clear();
                    cmd.Dispose();

                    cmd.CommandText = @"INSERT INTO Products (ProductName, CategoryId, StockId)
                       VALUES (@ProductName, @CategoryId, @StockId) ";

                    cmd.Parameters.Add("@StockId", SqlDbType.Int).Value = Convert.ToInt32(newStockId);
                    cmd.Parameters.Add("@ProductName", SqlDbType.NVarChar).Value = txtProductName.Text;
                    cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = (int)cmbKategori.SelectedValue;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();

                    MessageBox.Show("Yeni stok eklendi ✔");

                    this.Close();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SetStocks();

        }

      
    }
}