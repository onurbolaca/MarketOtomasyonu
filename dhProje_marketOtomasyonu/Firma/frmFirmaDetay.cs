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
    public partial class frmFirmaDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmFirmaDetay(string supplierId)
        {
            InitializeComponent();
            _supplierId = supplierId;
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string _supplierId = "";
        string companyName = "";
        string productId = "";

        string dbStockQuantity = "";



        private void frmFirmaDetay_Load(object sender, EventArgs e)
        {
            try
            {
                using (da.SelectCommand = new SqlCommand(@"SELECT        dbo.Suppliers.CompanyName, dbo.Products.ProductId, dbo.SupplierAccounts.AccountId, dbo.Suppliers.ContactName, dbo.Products.ProductName, dbo.SupplierAccounts.MarketsDebt, dbo.SupplierAccounts.SuppliersDebt, dbo.SupplierAccounts.OrderDate, 
                         dbo.SupplierAccounts.OrderQuantity, dbo.SupplierAccounts.TotalPrice, dbo.SupplierAccounts.SupplierId
FROM            dbo.Products INNER JOIN
                         dbo.SupplierAccounts ON dbo.Products.ProductId = dbo.SupplierAccounts.ProductId INNER JOIN
                         dbo.Suppliers ON dbo.SupplierAccounts.SupplierId = dbo.Suppliers.SupplierId
WHERE        (dbo.SupplierAccounts.SupplierId = @SupplierId)", DbConnection.Connect()))
                {
                    da.SelectCommand.Parameters.Add("@SupplierId", SqlDbType.NVarChar).Value = _supplierId;

                    da.Fill(dt);

                    foreach (DataRow row in dt.AsEnumerable())
                    {
                        companyName = row.ItemArray[0].ToString();
                        
                    }
                }

                lblSirketAdi.Text = companyName;

                gcList.DataSource = dt;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            csExceleAktar csExceleAktar = new csExceleAktar(gcList);
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen firma siparişi kalıcı olarak silinecektir. \n\nOnaylıyor musunuz?", "Siparişi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                GetStocks();
                SetStocks();

                cmd.CommandText = @"DELETE FROM SupplierAccounts WHERE AccountId =@AccountId";

                cmd.Parameters.Add(@"AccountId", SqlDbType.NVarChar).Value = gvList.GetFocusedRowCellDisplayText("AccountId");

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Parameters.Clear();

                dt.Clear();
                da.Fill(dt);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
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

                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(gvList.GetFocusedRowCellDisplayText("ProductId"));


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
                decimal leftQuantity = 0;

                stockQuantity = Convert.ToDecimal(dbStockQuantity);

                orderQuantity = Convert.ToDecimal(gvList.GetFocusedRowCellDisplayText("OrderQuantity"));

                leftQuantity = stockQuantity - orderQuantity;

                cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(gvList.GetFocusedRowCellDisplayText("ProductId"));

                cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = leftQuantity;


                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Firma.frmFirmaHareketleri frmFirmaHareketleri = new Firma.frmFirmaHareketleri
                    (supplierId: gvList.GetFocusedRowCellDisplayText("SupplierId") , 
                    accountId: gvList.GetFocusedRowCellDisplayText("AccountId"));

                frmFirmaHareketleri.FormClosed += FrmFirmaHareketleri_FormClosed;

                frmFirmaHareketleri.ShowDialog();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void FrmFirmaHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
        }



    }
}