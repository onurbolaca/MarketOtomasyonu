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

namespace dhProje_marketOtomasyonu
{
    public partial class frmMusteriEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteriEkle(string customerId)
        {
            InitializeComponent();

            _customerId = customerId;
        }

        string _customerId = "";
        int newCustomerId = 0;

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
            if (_customerId != "-1")
            {
                SetTextboxes();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_customerId == "-1")
            {
                InsertCustomer();
                InsertCustomerDebt();
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


        void SetTextboxes()
        {
            try
            {

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"SELECT * FROM Customers WHERE CustomerId = @CustomerId";

                cmd.Parameters.Add("@CustomerId", SqlDbType.NVarChar).Value = _customerId;

                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    if (dr.Read())
                    {
                        txtAddress.Text = dr["Address"].ToString();
                        txtCity.Text = dr["City"].ToString();
                        txtCustomerName.Text = dr["CustomerName"].ToString();
                        txtPhone.Text = dr["Phone"].ToString();
                        txtPostalCode.Text = dr["PostalCode"].ToString();
                        txtRegion.Text = dr["Region"].ToString();
                        txtSocialNumber.Text = dr["SocialNumber"].ToString();
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

                cmd.CommandText = @"INSERT INTO Customers(CustomerName, Address, City, Phone, Region, PostalCode, SocialNumber)
VALUES (@CustomerName,@Address,@City,@Phone,@PostalCode,@Region,@SocialNumber) SET  @newCustomerId=SCOPE_IDENTITY()";

                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = txtCustomerName.Text;

                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text;

                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;

                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text;

                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtRegion.Text;

                cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = txtPostalCode.Text;

                cmd.Parameters.Add("@SocialNumber", SqlDbType.NVarChar).Value = txtSocialNumber.Text;

                cmd.Parameters.Add("@newCustomerId", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                newCustomerId = Convert.ToInt32(cmd.Parameters["@newCustomerId"].Value);
                
                cmd.Parameters.Clear();

                cmd.Dispose();


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void InsertCustomerDebt()
        {
            SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

            cmd.CommandText = @"INSERT INTO CustomerDebts(CustomerId, DebtQuantity)
VALUES (@CustomerId, @DebtQuantity)";

            cmd.Parameters.Add("@CustomerId", SqlDbType.NVarChar).Value = newCustomerId;
            cmd.Parameters.Add("@DebtQuantity", SqlDbType.Decimal).Value = 0;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Dispose();

            MessageBox.Show("Yeni müşteri eklendi ✔");

            this.Close();

        }

        void UpdateCustomer()
        {
            try
            {
                DialogResult answer = MessageBox.Show("Bilgiler güncellenecektir. \n\nOnaylıyor musunuz?", "Müşteri Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE Customers
SET                CustomerName =@CustomerName, Address =@Address, City =@City, Phone =@Phone, Region =@Region, PostalCode =@PostalCode, SocialNumber =@SocialNumber WHERE CustomerId=@CustomerId";

                cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = Convert.ToInt32(_customerId);

                cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = txtCustomerName.Text;

                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text;

                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;

                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text;

                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtRegion.Text;

                cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = txtPostalCode.Text;

                cmd.Parameters.Add("@SocialNumber", SqlDbType.NVarChar).Value = txtSocialNumber.Text;

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
    }
}