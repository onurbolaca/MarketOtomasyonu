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

namespace dhProje_marketOtomasyonu.Urun
{
    public partial class frmKategoriEkle : DevExpress.XtraEditors.XtraForm
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void rdoEkle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEkle.Checked == false)
            {
                txtEkle.Enabled = false;
                lkpSec.Enabled = true;
            }
            else
            {
                txtEkle.Enabled = true;
                txtEkle.Focus();
                lkpSec.Enabled = false;
                txtEkle.Text = "";
            }
        }

        private void rdoGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGuncelle.Checked)
            {
                txtEkle.Enabled = true;

                lkpSec.Focus();
            }
        }

        private void rdoSil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSil.Checked)
            {

                txtEkle.Text = "";
                lkpSec.Focus();
            }
        }

        private void lkpSec_EditValueChanged(object sender, EventArgs e)
        {
            txtEkle.Text = lkpSec.Text;
            txtEkle.Focus();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKategoriEkle_Load(object sender, EventArgs e)
        {
            rdoEkle.Checked = true;
            lkpSec.Enabled = false;
            FillCombobox();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoEkle.Checked)
                {
                    InsertCategory();
                }
                else if (rdoGuncelle.Checked)
                {
                    UpdateCategory();
                }
                else if (rdoSil.Checked)
                {
                    DeleteCategory();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void FillCombobox()
        {
            try
            {
                using (da.SelectCommand = new SqlCommand(@"SELECT CategoryId, CategoryName
FROM            Categories", DbConnection.Connect()))
                {
                    da.Fill(dt);
                }

                lkpSec.Properties.DataSource = dt;
                lkpSec.Properties.DisplayMember = "CategoryName";
                lkpSec.Properties.ValueMember = "CategoryId";
                lkpSec.SelectedText = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        void InsertCategory()
        {
            try
            {
                DialogResult answer = MessageBox.Show("Girilen kategori eklenecektir. \n\nOnaylıyor musunuz?", "Kategori Ekle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"INSERT INTO Categories(CategoryName) VALUES (@CategoryName)";

                cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = txtEkle.Text;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

                MessageBox.Show("Yeni kategori eklendi ✔");

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void UpdateCategory()
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen kategori girilen isim ile güncellecektir. \n\nOnaylıyor musunuz?", "Kategori Güncelle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };
 
                object selectedRows = lkpSec.GetSelectedDataRow();

                DataRowView selectedRow = (DataRowView)selectedRows;

                string selectedId = selectedRow.Row.ItemArray[0].ToString();

                cmd.CommandText = @"UPDATE Categories SET CategoryName = @CategoryName WHERE (CategoryId = @CategoryId)";

                cmd.Parameters.Add("@CategoryId", SqlDbType.Int).Value = Convert.ToInt32(selectedId);
                cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = txtEkle.Text;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();

                MessageBox.Show("Kategori güncellendi ✔");

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void DeleteCategory()
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen kategori kalıcı olarak silinecektir. \n\nOnaylıyor musunuz?", "Kategori Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                object selectedRows = lkpSec.GetSelectedDataRow();

                DataRowView selectedRow = (DataRowView)selectedRows;

                string selectedId = selectedRow.Row.ItemArray[0].ToString();

                cmd.CommandText = @"DELETE FROM Categories WHERE CategoryId =@CategoryId";

                cmd.Parameters.Add(@"CategoryId", SqlDbType.NVarChar).Value = selectedId;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Parameters.Clear();

                MessageBox.Show("Kategori silindi ✔");

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
       
    }
}