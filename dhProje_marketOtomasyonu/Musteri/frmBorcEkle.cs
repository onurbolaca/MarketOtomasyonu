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
    public partial class frmBorcEkle : DevExpress.XtraEditors.XtraForm
    {

        public frmBorcEkle(string customerId, string customerName, string procedureName)
        {
            InitializeComponent();

            _customerId = customerId;
            _customerName = customerName;
            _procedureName = procedureName;

        }

        string _customerId = "";
        string _customerName = "";
        string _procedureName = "";

        decimal debtInDb = 0;
        int debtId = 0;

        private void frmBorcEkle_Load(object sender, EventArgs e)
        {
            lblShowName.Text = _customerName;

            SetTextbox();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_procedureName == "Insert")
            {
                InsertCustomer();
            }
            else
            {
                UpdateCustomer();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void SetTextbox()
        {
            try
            {

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"SELECT DebtQuantity, DebtId FROM CustomerDebts WHERE CustomerId = @CustomerId";

                cmd.Parameters.Add("@CustomerId", SqlDbType.NVarChar).Value = _customerId;

                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    if (dr.Read())
                    {
                        if (_procedureName == "Update")
                        {
                            txtDebtQuantity.Text = dr["DebtQuantity"].ToString();
                        }

                        debtId = Convert.ToInt32(dr["DebtId"]);
                        debtInDb = Convert.ToDecimal(dr["DebtQuantity"]);
                    }
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

        void InsertCustomer()
        {
            try
            {
                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };


                cmd.CommandText = @"UPDATE CustomerDebts
SET                DebtQuantity =@DebtQuantity, CustomerId=@CustomerId WHERE DebtId=@DebtId";

                decimal totalDebt = Convert.ToDecimal(txtDebtQuantity.Text) + debtInDb;

                cmd.Parameters.Add("@DebtQuantity", SqlDbType.Decimal).Value = totalDebt;
                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Convert.ToInt32(_customerId);
                cmd.Parameters.Add("@DebtId", SqlDbType.Int).Value = debtId;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

                MessageBox.Show("Borç eklendi ✔");

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void UpdateCustomer()
        {
            try
            {
                if (Convert.ToInt32(txtDebtQuantity.Text) == 0)
                {
                    DialogResult answer = MessageBox.Show("Borç SIFIRLANACAKTIR. \n\nOnaylıyor musunuz?", "Müşteri Bakiye", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.No)
                    {
                        return;
                    }

                    DeleteOrdersOfCustomer();
                }

                if (Convert.ToInt32(txtDebtQuantity.Text) > 0)
                {
                    DialogResult answer = MessageBox.Show("Yeni bakiyeyi onaylıyor musunuz?", "Müşteri Bakiye", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (answer == DialogResult.No)
                    {
                        return;
                    }
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE CustomerDebts
SET                DebtQuantity =@DebtQuantity WHERE CustomerId=@CustomerId";

                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Convert.ToInt32(_customerId);
                cmd.Parameters.Add("@DebtQuantity", SqlDbType.Int).Value = Convert.ToInt32(txtDebtQuantity.Text);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

                MessageBox.Show("İşlem Başarılı ✔");

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void DeleteOrdersOfCustomer()
        {

            SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

            cmd.CommandText = @"UPDATE Orders
            SET       CustomersId =@NullCustomersId WHERE CustomersId=@CustomersId";

            cmd.Parameters.Add("@CustomersId", SqlDbType.Int).Value = Convert.ToInt32(_customerId);
            cmd.Parameters.Add("@NullCustomersId", SqlDbType.Int).Value = DBNull.Value;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Dispose();

        }
    }
}
