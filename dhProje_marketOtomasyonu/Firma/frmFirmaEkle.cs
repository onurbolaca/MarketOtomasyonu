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
    public partial class frmFirmaEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmFirmaEkle(string supplierId)
        {
            InitializeComponent();
            _supplierId = supplierId;
        }

        string _supplierId = "";

        private void frmFirmaEkle_Load(object sender, EventArgs e)
        {
            if (_supplierId != "-1")
            {
                SetTextboxes();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_supplierId == "-1")
            {

                InsertSupplier();
            }
            else
            {
                UpdateSupplier();
            }

        }

        void InsertSupplier()
        {
            try
            {

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"INSERT INTO Suppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, Phone, TaxNumber)
VALUES (@CompanyName,@ContactName,@ContactTitle,@Address,@City,@Region,@Phone,@TaxNumber)";

                cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = txtSirketAdi.Text;

                cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = txtIletisim.Text;

                cmd.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = txtRutbe.Text;

                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAdres.Text;

                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtSehir.Text;

                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtBolge.Text;

                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtTelefon.Text;

                cmd.Parameters.Add("@TaxNumber", SqlDbType.NVarChar).Value = txtVergiNo.Text;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

                MessageBox.Show("Yeni tedarikçi eklendi ✔");

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

                cmd.CommandText = @"SELECT * FROM Suppliers WHERE SupplierId = @SupplierId";

                cmd.Parameters.Add("@SupplierId", SqlDbType.NVarChar).Value = _supplierId;

                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    if (dr.Read())
                    {
                        txtSirketAdi.Text = dr["CompanyName"].ToString();
                        txtIletisim.Text = dr["ContactName"].ToString();
                        txtRutbe.Text = dr["ContactTitle"].ToString();
                        txtAdres.Text = dr["Address"].ToString();
                        txtSehir.Text = dr["City"].ToString();
                        txtBolge.Text = dr["Region"].ToString();
                        txtTelefon.Text = dr["Phone"].ToString();
                        txtVergiNo.Text = dr["TaxNumber"].ToString();

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

        void UpdateSupplier()
        {
            try
            {

                DialogResult answer = MessageBox.Show("Bilgiler güncellenecektir. \n\nOnaylıyor musunuz?", "Firma Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE Suppliers
SET                CompanyName =@CompanyName, ContactName =@ContactName, ContactTitle =@ContactTitle, Address =@Address, City =@City, Region =@Region, Phone =@Phone, TaxNumber =@TaxNumber WHERE SupplierId=@SupplierId";

                cmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = Convert.ToInt32(_supplierId);

                cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = txtSirketAdi.Text;

                cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = txtIletisim.Text;

                cmd.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = txtRutbe.Text;

                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAdres.Text;

                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = txtSehir.Text;

                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = txtBolge.Text;

                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = txtTelefon.Text;

                cmd.Parameters.Add("@TaxNumber", SqlDbType.NVarChar).Value = txtVergiNo.Text;

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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}