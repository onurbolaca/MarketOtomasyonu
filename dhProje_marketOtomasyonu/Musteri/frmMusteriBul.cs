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
    public partial class frmMusteriBul : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteriBul()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        bool checkClosing = false;

        private void frmMusteriBul_Load(object sender, EventArgs e)
        {
            try
            {
                using (da.SelectCommand = new SqlCommand(@"SELECT  CustomerId,CustomerName, Phone, SocialNumber
FROM            dbo.Customers", DbConnection.Connect()))

                {
                    da.Fill(dt);
                }

                lkpMusteriler.Properties.DataSource = dt;
                //lkpMusteriler.Properties.Populate

                lkpMusteriler.Properties.DisplayMember = "CustomerName";
                //lkpMusteriler.Properties.ValueMember = "CustomerId";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            } 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try //EKLE
            {
                frmMusteriEkle frmMusteriEkle = new frmMusteriEkle("-1");
                frmMusteriEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnVeresiyeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedRows = lkpMusteriler.GetSelectedDataRow();

                DataRowView selectedRow = (DataRowView)selectedRows;

                string selectedId = selectedRow.Row.ItemArray[0].ToString();
                string selectedName = selectedRow.Row.ItemArray[1].ToString();

                ((frmMarket)Application.OpenForms["frmMarket"]).customerId = selectedId;
                ((frmMarket)Application.OpenForms["frmMarket"]).txtMusteriIsmi.Text = selectedName;

                checkClosing = true;

                this.Close();
            }
            catch (Exception hata) {
                MessageBox.Show(hata.Message);
            }
            
        }

        private void frmMusteriBul_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (checkClosing != true)
                {
                    ((frmMarket)Application.OpenForms["frmMarket"]).rdoVeresiyeHayir.Checked = true;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void lkpMusteriler_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}