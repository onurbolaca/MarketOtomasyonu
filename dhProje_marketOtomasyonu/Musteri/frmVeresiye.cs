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

namespace dhProje_marketOtomasyonu
{
    public partial class frmVeresiye : DevExpress.XtraEditors.XtraForm
    {
        public frmVeresiye()
        {
            InitializeComponent();
        }

        SqlDataAdapter daLkpMusteriler = new SqlDataAdapter();
        DataTable dtLkpMusteriler = new DataTable();

        SqlDataAdapter daCustomers = new SqlDataAdapter();
        DataTable dtCustomers = new DataTable();



        string lkpCustomerId = "";
        int CustomerId = 0;

        private void btnExcel_Click(object sender, EventArgs e)
        {
            csExceleAktar csExceleAktar = new csExceleAktar(gcList);
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerId = Convert.ToInt32(gvList.GetFocusedRowCellDisplayText("CustomerId"));

                //todo: BURADA TRANSACTION ŞART. YOKSA BİR HATADA 3 ayrı tablodan, müşteri ile ilgili ÖNEMLİ BİLGİLER ZİYAN OLUYOR.
                //todo: BURADA Cascade yapıyı kontrol etmek şart. Vaktin olursa yap.

                DeleteOrdersOfCustomer();
                DeleteCustomerDebt();
                DeleteCustomer();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void frmVeresiye_Load(object sender, EventArgs e)
        {
            FillCustomerLookupedit();

            GetCustomers();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                frmMusteriEkle frmMusteriEkle = new frmMusteriEkle("-1");
                frmMusteriEkle.FormClosed += FrmMusteriEkle_FormClosed;

                frmMusteriEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                frmMusteriEkle frmMusteriEkle = new frmMusteriEkle(gvList.GetFocusedRowCellDisplayText("CustomerId"));

                frmMusteriEkle.FormClosed += FrmMusteriEkle_FormClosed;

                frmMusteriEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void FrmMusteriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtCustomers.Clear();
            daCustomers.Fill(dtCustomers);

            dtLkpMusteriler.Clear();
            daLkpMusteriler.Fill(dtLkpMusteriler);
        }

        private void lkpMusteriler_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                object selectedRows = lkpMusteriler.GetSelectedDataRow();

                DataRowView selectedRow = (DataRowView)selectedRows;

                lkpCustomerId = selectedRow.Row.ItemArray[0].ToString();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnHepsiniGetir_Click(object sender, EventArgs e)
        {
            GetCustomers();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (lkpMusteriler.Text == "")
            {
                MessageBox.Show("Bir seçim yapınız.");
                lkpMusteriler.Focus();
                return;
            }

            GetSelectedCustomer();
        }

        private void btnMusteriDetay_Click(object sender, EventArgs e)
        {
            try
            {
                frmMusteriDetay frmMusteriDetay = new frmMusteriDetay(gvList.GetFocusedRowCellDisplayText("CustomerId"));

                frmMusteriDetay.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }


        private void btnMusteriBorcEkle_Click(object sender, EventArgs e)
        {
            try
            {
                frmBorcEkle frmBorcEkle = new frmBorcEkle(gvList.GetFocusedRowCellValue("CustomerId").ToString(), gvList.GetFocusedRowCellValue("CustomerName").ToString(), "Insert");

                frmBorcEkle.FormClosed += FrmBorcEkle_FormClosed;

                frmBorcEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void FrmBorcEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtCustomers.Clear();
            daCustomers.Fill(dtCustomers);
        }

        private void btnMusteriBorcGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                frmBorcEkle frmBorcEkle = new frmBorcEkle(gvList.GetFocusedRowCellValue("CustomerId").ToString(), gvList.GetFocusedRowCellValue("CustomerName").ToString(), "Update");

                frmBorcEkle.FormClosed += FrmBorcEkle_FormClosed;

                frmBorcEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }


        void FillCustomerLookupedit()
        {
            try
            {
                using (daLkpMusteriler.SelectCommand = new SqlCommand(@"SELECT  CustomerId, CustomerName, SocialNumber
FROM            dbo.Customers", DbConnection.Connect()))

                {
                    daLkpMusteriler.Fill(dtLkpMusteriler);
                }

                lkpMusteriler.Properties.DataSource = dtLkpMusteriler;

                lkpMusteriler.Properties.DisplayMember = "CustomerName";
                // lkpMusteriler.Properties.ValueMember = "CustomerId";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void GetCustomers()
        {
            try
            {
                dtCustomers.Clear();

                using (daCustomers.SelectCommand = new SqlCommand(@"SELECT        dbo.Customers.CustomerName, dbo.Customers.Address, dbo.Customers.PostalCode, dbo.Customers.City, dbo.Customers.Region, dbo.Customers.Phone, dbo.Customers.SocialNumber, dbo.Customers.CustomerId, 
                         dbo.CustomerDebts.DebtQuantity
FROM            dbo.Customers LEFT JOIN
                         dbo.CustomerDebts ON dbo.Customers.CustomerId = dbo.CustomerDebts.CustomerId", DbConnection.Connect()))

                {
                    daCustomers.Fill(dtCustomers);
                }

                gcList.DataSource = dtCustomers;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        void GetSelectedCustomer()
        {
            try
            {
                dtCustomers.Clear();

                using (daCustomers.SelectCommand = new SqlCommand(@"SELECT        dbo.Customers.CustomerName, dbo.Customers.Address, dbo.Customers.PostalCode, dbo.Customers.City, dbo.Customers.Region, dbo.Customers.Phone, dbo.Customers.SocialNumber, dbo.Customers.CustomerId, 
                         dbo.CustomerDebts.DebtQuantity
FROM            dbo.Customers INNER JOIN
                         dbo.CustomerDebts ON dbo.Customers.CustomerId = dbo.CustomerDebts.CustomerId
WHERE        (dbo.Customers.CustomerId = @CustomerId)", DbConnection.Connect()))
                {
                    daCustomers.SelectCommand.Parameters.Add(@"CustomerId", SqlDbType.Int).Value = Convert.ToInt32(lkpCustomerId);

                    daCustomers.Fill(dtCustomers);
                }

                gcList.DataSource = dtCustomers;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void DeleteCustomer()
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"DELETE FROM Customers WHERE CustomerId =@CustomerId";


                cmd.Parameters.Add(@"CustomerId", SqlDbType.Int).Value = CustomerId;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Parameters.Clear();


                dtCustomers.Clear();
                daCustomers.Fill(dtCustomers);

               
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
                throw;
            }
        }

        void DeleteCustomerDebt()
        {
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"DELETE FROM CustomerDebts WHERE CustomerId =@CustomerId";


                cmd.Parameters.Add(@"CustomerId", SqlDbType.Int).Value = CustomerId;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Parameters.Clear();

                dtCustomers.Clear();
                daCustomers.Fill(dtCustomers);

                

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);

            }
        }

        void DeleteOrdersOfCustomer()
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen müşterinin varsa borcu ve kaydı kalıcı olarak silinecektir. \n\nOnaylıyor musunuz?", "Müşteri ve Borç Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

               // DialogResult answer = MessageBox.Show("Borç SIFIRLANACAKTIR. \n\nOnaylıyor musunuz?", "Müşteri ////Bakiye", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE Orders
            SET       CustomersId =@NullCustomersId WHERE CustomersId=@CustomersId";


                cmd.Parameters.Add("@CustomersId", SqlDbType.Int).Value = CustomerId;
                cmd.Parameters.Add("@NullCustomersId", SqlDbType.Int).Value = DBNull.Value;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

               

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
                throw;
            }

        }
    }
}

