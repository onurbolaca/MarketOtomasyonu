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

namespace dhProje_marketOtomasyonu.Musteri
{
    public partial class frmMusteriDetay : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteriDetay(string customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        string _customerId = "";


        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void frmMusteriDetay_Load(object sender, EventArgs e)
        {
            using (da.SelectCommand = new SqlCommand(@"SELECT        CustomersId, EmployeesId, OrderDate, PaymentMethod, CashSales, CardSales, DiscountRate, TotalOrderPrice, ReceiptId
FROM            dbo.Orders
WHERE        ( dbo.Orders.CustomersId = @CustomerId)", DbConnection.Connect()))
            {
                da.SelectCommand.Parameters.Add(@"CustomerId", SqlDbType.Int).Value = Convert.ToInt32(_customerId);
                da.Fill(dt);
            }

            gcList.DataSource = dt;
        }
    }
}