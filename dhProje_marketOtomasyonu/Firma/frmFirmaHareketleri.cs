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

namespace dhProje_marketOtomasyonu.Firma
{
    public partial class frmFirmaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmFirmaHareketleri(string supplierId = "-1", string accountId = "-1")
        {
            InitializeComponent();
            _supplierId = supplierId;
            _accountId = accountId;
        }

        SqlDataAdapter daCompanyName = new SqlDataAdapter();
        DataTable dtCompanyName = new DataTable();

        SqlDataAdapter daProducts = new SqlDataAdapter();
        DataTable dtProducts = new DataTable();

        string _supplierId = "";
        string _accountId = "";


        string companyName = "";
        string contactName = "";

        string lkpSelectedProductId = "";
        string selectedProductName = "";

        string dbStockQuantity = "";

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFirmaHareketleri_Load(object sender, EventArgs e)
        {
            SetTitle();

            SetProducts();

            GetToUpdate();
        }

        private void btnUrunTanimla_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedRows = lkpUrunler.GetSelectedDataRow();

                DataRowView selectedRow = (DataRowView)selectedRows;

                lkpSelectedProductId = selectedRow.Row.ItemArray[0].ToString();
                selectedProductName = selectedRow.Row.ItemArray[1].ToString();

                txtUrunAdi.Text = selectedProductName;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            SetSupplierAccount();
            GetStocks();
            SetStocks();
        }

        void GetToUpdate()
        {
            if (_accountId != "-1")
            {
                try
                {
                    SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                    cmd.CommandText = @"SELECT  dbo.Products.ProductName,  dbo.Products.ProductId, dbo.SupplierAccounts.MarketsDebt, dbo.SupplierAccounts.SuppliersDebt, dbo.SupplierAccounts.OrderDate, 
                         dbo.SupplierAccounts.OrderQuantity, dbo.SupplierAccounts.TotalPrice 
FROM            dbo.Products INNER JOIN
                         dbo.SupplierAccounts ON dbo.Products.ProductId = dbo.SupplierAccounts.ProductId INNER JOIN
                         dbo.Suppliers ON dbo.SupplierAccounts.SupplierId = dbo.Suppliers.SupplierId
WHERE        (dbo.SupplierAccounts.AccountId  = @AccountId)";

                    cmd.Parameters.Add("@AccountId", SqlDbType.Int).Value = Convert.ToInt32(_accountId);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        dr.Read();

                         txtUrunAdi.Text = dr["ProductName"].ToString();
                        txtFiyat.Text = dr["TotalPrice"].ToString();
                        txtMiktar.Text = dr["OrderQuantity"].ToString();
                        txtTarih.Text = dr["OrderDate"].ToString();
                        txtMarketinBorcu.Text = dr["MarketsDebt"].ToString();
                        txtTedarikciBorcu.Text = dr["SuppliersDebt"].ToString();
                        lkpSelectedProductId = dr["ProductId"].ToString();
                    }

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
        }

        void SetTitle()
        {
            try
            {
                using (daCompanyName.SelectCommand = new SqlCommand(@"SELECT CompanyName, ContactName FROM Suppliers WHERE SupplierId=@SupplierId", DbConnection.Connect()))
                {
                    daCompanyName.SelectCommand.Parameters.Add("@SupplierId", SqlDbType.NVarChar).Value = _supplierId;

                    daCompanyName.Fill(dtCompanyName);

                    foreach (DataRow row in dtCompanyName.AsEnumerable())
                    {
                        companyName = row.ItemArray[0].ToString();
                        contactName = row.ItemArray[1].ToString();
                    }
                }

                if (companyName != "")
                {
                    lblSirketAdi.Text = companyName;
                }
                else
                {
                    lblSirketAdi.Text = contactName;
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        void SetProducts()
        {
            try
            {
                using (daProducts.SelectCommand = new SqlCommand(@"SELECT ProductId, ProductName
FROM Products", DbConnection.Connect()))
                {
                    daProducts.Fill(dtProducts);
                }

                lkpUrunler.Properties.DataSource = dtProducts;

                lkpUrunler.Properties.DisplayMember = "ProductName";

                lkpUrunler.Properties.ValueMember = "ProductId";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void SetSupplierAccount()
        {
            try
            {
                if (_accountId != "-1")
                {
                    SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                    cmd.CommandText = @"UPDATE  SupplierAccounts
SET                MarketsDebt =@MarketsDebt, SuppliersDebt =@SuppliersDebt, OrderDate =@OrderDate, ProductId =@ProductId, OrderQuantity =@OrderQuantity, TotalPrice =@TotalPrice WHERE AccountId=@AccountId";

                    cmd.Parameters.Add("@AccountId", SqlDbType.Int).Value = Convert.ToInt32(_accountId);

                    cmd.Parameters.Add("@MarketsDebt", SqlDbType.Decimal).Value = txtMarketinBorcu.Text;

                    cmd.Parameters.Add("@SuppliersDebt", SqlDbType.Decimal).Value = txtTedarikciBorcu.Text;

                    cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = txtTarih.Text;

                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(lkpSelectedProductId);

                    cmd.Parameters.Add("@OrderQuantity", SqlDbType.Decimal).Value = txtMiktar.Text;

                    cmd.Parameters.Add("@TotalPrice", SqlDbType.Decimal).Value = txtFiyat.Text;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();

                    MessageBox.Show("Güncelleme yapıldı ✔");

                    this.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                    cmd.CommandText = @"INSERT  
INTO              SupplierAccounts(SupplierId, MarketsDebt, SuppliersDebt, OrderDate, ProductId, OrderQuantity, TotalPrice)
VALUES  (@SupplierId,@MarketsDebt,@SuppliersDebt,@OrderDate,@ProductId,@OrderQuantity,@TotalPrice)";


                    cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = Convert.ToInt32(_supplierId);

                    cmd.Parameters.Add("@MarketsDebt", SqlDbType.Decimal).Value = txtMarketinBorcu.Text;

                    cmd.Parameters.Add("@SuppliersDebt", SqlDbType.Decimal).Value = txtTedarikciBorcu.Text;

                    cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = txtTarih.Text;

                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(lkpSelectedProductId);

                    cmd.Parameters.Add("@OrderQuantity", SqlDbType.Decimal).Value = txtMiktar.Text;

                    cmd.Parameters.Add("@TotalPrice", SqlDbType.Decimal).Value = txtFiyat.Text;

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    cmd.Dispose();

                    MessageBox.Show("Yeni işlem eklendi ✔");

                    this.Close();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }


        void GetStocks()
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"SELECT dbo.Stocks.UnitsInStock 
FROM            dbo.Stocks INNER JOIN
                         dbo.Products ON dbo.Stocks.StockId = dbo.Products.StockId WHERE (Products.ProductId = @ProductId)";

                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(lkpSelectedProductId);


                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    if (dr.Read())
                    {
                        dbStockQuantity = dr["UnitsInStock"].ToString();
                    }
                }

                cmd.Parameters.Clear();

                cmd.Dispose();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        void SetStocks()
        {
            try
            {
                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE Stocks SET UnitsInStock=@Quantity FROM dbo.Stocks AS S INNER JOIN
                         dbo.Products AS P ON S.StockId = P.StockId WHERE (P.ProductId = @ProductId)";

                decimal stockQuantity = 0;
                decimal orderQuantity = 0;
                decimal totalQuantity = 0;

                stockQuantity = Convert.ToDecimal(dbStockQuantity); 

                orderQuantity = Convert.ToDecimal(txtMiktar.Text);

                totalQuantity = stockQuantity + orderQuantity;


                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(lkpSelectedProductId);

                cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = totalQuantity;


                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun.frmStokEkle frmStokEkle = new Urun.frmStokEkle("-1");

            frmStokEkle.FormClosed += FrmStokEkle_FormClosed;

            frmStokEkle.ShowDialog();

           
        }

        private void FrmStokEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtProducts.Clear();
            daProducts.Fill(dtProducts);
        }




    }
}