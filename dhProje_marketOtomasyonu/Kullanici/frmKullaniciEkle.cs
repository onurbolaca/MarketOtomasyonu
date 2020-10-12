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

namespace dhProje_marketOtomasyonu.Kullanici
{
    public partial class frmKullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciEkle(string employeesId)
        {
            InitializeComponent();

            _employeesId = employeesId;
        }

        string _employeesId = "";

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            if (_employeesId != "-1")
            {

                SetTextboxes();
            }
        }




        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (_employeesId == "-1")
                {
                    InsertEmployee();

                }
                else
                {
                    UpdateEmployee();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void InsertEmployee()
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Employees(LastName, FirstName, Password, Title, BirthDate, HireDate, Address, City, Region, PostalCode, Phone
) values (@LastName, @FirstName, @Password, @Title, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Phone
)", DbConnection.Connect());

            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = txtLastName.Text;

            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = txtFirstName.Text;
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = txtTitle.Text;
            cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = txtBirthDate.Text;
            cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = txtHireDate.Text;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text;
            cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;
            cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtRegion.Text;
            cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = txtPostalCode.Text;
            cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text;

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Dispose();

            MessageBox.Show("Yeni kullanıcı eklendi ✔");

            this.Close();
        }


        void UpdateEmployee()
        {
            try
            {

                DialogResult answer = MessageBox.Show("Bilgiler güncellenecektir. \n\nOnaylıyor musunuz?", "Kullanıcı Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };



                cmd.CommandText = @"UPDATE Employees
SET                LastName =@LastName, FirstName =@FirstName, Password =@Password, Title =@Title, BirthDate =@BirthDate, HireDate =@HireDate, Address =@Address, City =@City, Region=@Region,  PostalCode=@PostalCode, Phone=@Phone WHERE EmployeesId=@EmployeesId";

                cmd.Parameters.Add("@EmployeesId", SqlDbType.NVarChar).Value = _employeesId;

                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = txtLastName.Text;

                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = txtFirstName.Text;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = txtTitle.Text;
                cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = txtBirthDate.Text;
                cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = txtHireDate.Text;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text;
                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtCity.Text;
                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtRegion.Text;
                cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = txtPostalCode.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtPhone.Text;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

                MessageBox.Show("Kullanıcı güncellendi ✔");

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }


        void SetTextboxes()
        {
            try
            {

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };



                cmd.CommandText = @"SELECT * FROM Employees WHERE @EmployeesId = EmployeesId";

                cmd.Parameters.Add("@EmployeesId", SqlDbType.NVarChar).Value = _employeesId;

                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    if (dr.Read())
                    {

                        txtLastName.Text = dr["LastName"].ToString();
                        txtFirstName.Text = dr["FirstName"].ToString();
                        txtPassword.Text = dr["Password"].ToString();
                        txtTitle.Text = dr["Title"].ToString();
                        txtBirthDate.Text = dr["BirthDate"].ToString();
                        txtHireDate.Text = dr["HireDate"].ToString();
                        txtAddress.Text = dr["Address"].ToString();
                        txtCity.Text = dr["City"].ToString();
                        txtRegion.Text = dr["Region"].ToString();
                        txtPostalCode.Text = dr["PostalCode"].ToString();
                        txtPhone.Text = dr["Phone"].ToString();
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

    }
}