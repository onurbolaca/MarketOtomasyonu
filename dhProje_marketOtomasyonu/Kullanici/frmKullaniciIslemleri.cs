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
using dhProje_marketOtomasyonu.Kullanici;

namespace dhProje_marketOtomasyonu
{
    public partial class frmKullaniciIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();


        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {

            using (da.SelectCommand = new SqlCommand(@"SELECT         EmployeesId, LastName, FirstName, Password, Title, BirthDate, HireDate, Address, City, Region, PostalCode, Phone
FROM            Employees", DbConnection.Connect()))
            {
                da.Fill(dt);

            }

            gcList.DataSource = dt;

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            csExceleAktar csExceleAktar = new csExceleAktar(gcList);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle("-1");


            frmKullaniciEkle.FormClosed += FrmKullaniciEkle_FormClosed;


            frmKullaniciEkle.ShowDialog();
        }

        private void FrmKullaniciEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frmKullaniciEkle = new frmKullaniciEkle(gvList.GetFocusedRowCellValue("EmployeesId").ToString());


            frmKullaniciEkle.FormClosed += FrmKullaniciEkle_FormClosed;


            frmKullaniciEkle.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen kullanıcı kalıcı olarak silinecektir. \n\nOnaylıyor musunuz?", "Kullanıcıyı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

               
                cmd.CommandText = @"DELETE FROM Employees WHERE EmployeesId =@EmployeesId";

                cmd.Parameters.Add(@"EmployeesId", SqlDbType.NVarChar).Value = gvList.GetFocusedRowCellDisplayText("EmployeesId");

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
    }
}