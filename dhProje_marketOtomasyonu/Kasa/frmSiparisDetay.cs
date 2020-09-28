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

namespace dhProje_marketOtomasyonu.Kasa
{
    public partial class frmSiparisDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmSiparisDetay(int orderId)
        {
            InitializeComponent();
             _orderId = orderId;
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        int _orderId = 0;

        private void frmSiparisDetay_Load(object sender, EventArgs e)
        {
            try
            {

                using (da.SelectCommand = new SqlCommand(@"SELECT dbo.Products.ProductName, dbo.OrderDetails.SellingPrice, dbo.OrderDetails.Quantity, dbo.OrderDetails.TotalRowPrice
FROM            dbo.Products INNER JOIN
                         dbo.OrderDetails ON dbo.Products.ProductId = dbo.OrderDetails.ProductId WHERE  dbo.OrderDetails.OrderId = @OrderId", DbConnection.Connect()))
                {
                    da.SelectCommand.Parameters.Add("@OrderId", SqlDbType.Int).Value = _orderId;


                    da.Fill(dt);

                }

                gcList.DataSource = dt;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}