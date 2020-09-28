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
using dhProje_marketOtomasyonu.Musteri;

namespace dhProje_marketOtomasyonu.Kasa
{
    public partial class frmSiparisIptal : DevExpress.XtraEditors.XtraForm
    {
        public frmSiparisIptal()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        int OrderId = 0;


        Dictionary<string, string> IdQuantityOfOrderDetails = new Dictionary<string, string>();
        // Dictionary<string, string> IdQuantityOfOrders = new Dictionary<string, string>();
        Dictionary<string, string> IdQuantityOfStocks = new Dictionary<string, string>();

        private void frmSiparisIptal_Load(object sender, EventArgs e)
        {
            try
            {


                using (da.SelectCommand = new SqlCommand(@"SELECT  dbo.Orders.OrderId, dbo.Orders.CustomersId, dbo.Orders.OrderDate, dbo.Orders.PaymentMethod, dbo.Orders.DiscountRate, dbo.Orders.TotalOrderPrice, dbo.Customers.CustomerName FROM            dbo.Orders LEFT JOIN
                         dbo.Customers ON dbo.Orders.CustomersId = dbo.Customers.CustomerId", DbConnection.Connect()))
                {
                    da.Fill(dt);

                }

                gcList.DataSource = dt;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void btnIslemVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            try
            {
                OrderId = Convert.ToInt32(gvList.GetFocusedRowCellDisplayText("OrderId"));


                DialogResult answer = MessageBox.Show("Seçilen Sipariş Silinecektir. \n\n Onaylıyor musunuz?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return;
                }
                else
                {
                    AddBackToStocks();

                    DeleteFromDb();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            OrderId = Convert.ToInt32(gvList.GetFocusedRowCellDisplayText("OrderId"));

            frmSiparisDetay frmSiparisDetay = new frmSiparisDetay(OrderId);

            frmSiparisDetay.ShowDialog(); 


        }

        void DeleteFromDb()
        {

            SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

            cmd.CommandText = @"DELETE FROM Orders WHERE OrderId=@OrderId";

            cmd.Parameters.Add(@"OrderId", SqlDbType.Int).Value = OrderId;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd.CommandText = @"DELETE FROM OrderDetails WHERE OrderId=@OrderId";

            cmd.Parameters.Add(@"OrderId", SqlDbType.Int).Value = OrderId;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Dispose();

            dt.Clear();
            da.Fill(dt);
        }

        void AddBackToStocks()
        {
            DialogResult answer = MessageBox.Show("Ürünler stoklara geri eklensin mi?", "Sipariş İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No)
            {
                return;
            }
            else
            {
                SortRelatedOrders();
                GetStocksFromDb();
                SetStocksToDb();
            }

        }

        void SortRelatedOrders()
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };


                cmd.CommandText = @"SELECT ProductId, Quantity FROM OrderDetails WHERE OrderId=@OrderId ";

                cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = OrderId;


                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult
                    ))
                {
                    while (dr.Read())
                    {
                        string ProductId = dr["ProductId"].ToString();
                        string OrderQuantity = dr["Quantity"].ToString();

                        if (IdQuantityOfOrderDetails.ContainsKey(ProductId))
                        //böylece tek bir siparişte aynı olan ürünlerin miktarlarını ürüne ait olan id altında birleştirdim
                        {
                            IdQuantityOfOrderDetails[ProductId] += OrderQuantity;
                        }
                        else
                        {
                            IdQuantityOfOrderDetails.Add(ProductId, OrderQuantity);

                        }
                    }
                }

                cmd.Parameters.Clear();

                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void GetStocksFromDb()
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


                foreach (KeyValuePair<string, string> Product in IdQuantityOfOrderDetails)
                {
                    int ProductId = Convert.ToInt32(Product.Key);

                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = ProductId;

                    string productId = Product.Key;

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            string dbStockQuantity = dr["UnitsInStock"].ToString();

                            IdQuantityOfStocks.Add(productId, dbStockQuantity);
                        }
                    }

                    cmd.Parameters.Clear();

                }

                cmd.Dispose();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        void SetStocksToDb()
        {
            try
            {
                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE Stocks SET UnitsInStock=@Quantity FROM dbo.Stocks AS S INNER JOIN
                         dbo.Products AS P ON S.StockId = P.StockId WHERE (P.ProductId = @ProductId)";

                foreach (KeyValuePair<string, string> Product in IdQuantityOfOrderDetails)
                {
                    decimal stockQuantity = 0;
                    decimal orderQuantity = 0;
                    decimal AddedQuantity = 0;

                    if (IdQuantityOfStocks.ContainsKey(Product.Key))
                    {
                        stockQuantity = Convert.ToDecimal(IdQuantityOfStocks[Product.Key]);

                        orderQuantity = Convert.ToDecimal(Product.Value);

                        AddedQuantity = stockQuantity + orderQuantity;
                    }

                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(Product.Key);

                    cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = AddedQuantity;

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }

                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void gvList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
