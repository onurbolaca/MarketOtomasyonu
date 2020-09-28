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
using DevExpress.XtraGrid.Columns;

namespace dhProje_marketOtomasyonu
{
    public partial class frmFirmaTakibi : DevExpress.XtraEditors.XtraForm
    {
        public frmFirmaTakibi()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        SqlDataAdapter daLkpFirmalar = new SqlDataAdapter();
        DataTable dtLkpFirmalar = new DataTable();

        string lkpSelectedId = "";
        string selectedCompanyName = "";


        private void frmFirmaTakibi_Load(object sender, EventArgs e)
        {
            try
            {
                GetSuppliers();
                GetSuppliersByNames();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void lkpFirmalar_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                lkpFirmalar.Properties.DisplayMember = "CompanyName";

                object selectedRows = lkpFirmalar.GetSelectedDataRow();

                DataRowView selectedRow = (DataRowView)selectedRows;

                lkpSelectedId = selectedRow.Row.ItemArray[0].ToString();
                selectedCompanyName = selectedRow.Row.ItemArray[1].ToString();

                if(selectedCompanyName == "")
                {
                    lkpFirmalar.Properties.DisplayMember = "ContactName";
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            if (lkpFirmalar.Text == "")
            {
                MessageBox.Show("Bir seçim yapınız.");
                lkpFirmalar.Focus();
                return;
            }

            GetSelectedSupplier();
        }

        private void btnHepsiniGetir_Click(object sender, EventArgs e)
        {
            dt.Clear();
            
            GetSuppliers();
        }

        private void btnFirmaDetay_Click(object sender, EventArgs e)
        {
            Firma.frmFirmaDetay frmFirmaDetay = new Firma.frmFirmaDetay(gvList.GetFocusedRowCellDisplayText("SupplierId"));

            frmFirmaDetay.Show();

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            csExceleAktar csExceleAktar = new csExceleAktar(gcList);
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            Firma.frmFirmaEkle frmFirmaEkle = new Firma.frmFirmaEkle("-1");

            frmFirmaEkle.FormClosed += FrmFirmaEkle_FormClosed;


            frmFirmaEkle.ShowDialog();


        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {

            Firma.frmFirmaEkle frmFirmaEkle = new Firma.frmFirmaEkle(gvList.GetFocusedRowCellDisplayText("SupplierId"));

            frmFirmaEkle.FormClosed += FrmFirmaEkle_FormClosed;

            frmFirmaEkle.ShowDialog();

        }

        private void FrmFirmaEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
        }

        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen firma kalıcı olarak silinecektir. \n\nOnaylıyor musunuz?", "Firma Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"DELETE FROM Suppliers WHERE SupplierId =@SupplierId";

                cmd.Parameters.Add(@"SupplierId", SqlDbType.NVarChar).Value = gvList.GetFocusedRowCellDisplayText("SupplierId");

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

        private void btnFirmaHareket_Click(object sender, EventArgs e)
        {
            try
            {
                Firma.frmFirmaHareketleri frmFirmaHareketleri = new Firma.frmFirmaHareketleri(gvList.GetFocusedRowCellDisplayText("SupplierId"));

                frmFirmaHareketleri.Show();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void GetSuppliers()
        {
            try
            {
                using (da.SelectCommand = new SqlCommand(@"SELECT SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, Phone, TaxNumber, dbo.MarketsDebtSums(SupplierId) AS MarketsDebtSums, dbo.SuppliersDebtSums(SupplierId) AS SuppliersDebtSums
FROM            Suppliers", DbConnection.Connect()))
                {
                    da.Fill(dt);
                }

                gcList.DataSource = dt;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void GetSuppliersByNames()
        {
            try
            {
                using (daLkpFirmalar.SelectCommand = new SqlCommand(@"SELECT SupplierId,CompanyName, ContactName 
FROM            Suppliers", DbConnection.Connect()))
                {
                    daLkpFirmalar.Fill(dtLkpFirmalar);
                }

                lkpFirmalar.Properties.DataSource = dtLkpFirmalar;

                lkpFirmalar.Properties.DisplayMember = "CompanyName";

                lkpFirmalar.Properties.ValueMember = "SupplierId";


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        void GetSelectedSupplier()
        {
            try
            {
                dt.Clear();

                using (da.SelectCommand = new SqlCommand(@"SELECT SupplierId, CompanyName, ContactName, ContactTitle, Address, City, Region, Phone, TaxNumber, dbo.MarketsDebtSums(SupplierId) AS MarketsDebtSums, dbo.SuppliersDebtSums(SupplierId) AS SuppliersDebtSums
FROM            Suppliers WHERE SupplierId=@SupplierId", DbConnection.Connect()))
                {
                    da.SelectCommand.Parameters.Add(@"SupplierId", SqlDbType.Int).Value = Convert.ToInt32( lkpSelectedId);
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