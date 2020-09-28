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
    public partial class frmMalzemeEnvanter : DevExpress.XtraEditors.XtraForm
    {
        public frmMalzemeEnvanter()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private void frmMalzemeEnvanter_Load(object sender, EventArgs e)
        {
            GetStocks();

        }


        void GetStocks()
        {
            try
            {
                using (da.SelectCommand = new SqlCommand(@"SELECT        dbo.Products.ProductName, dbo.Categories.CategoryId, dbo.Categories.CategoryName, dbo.Stocks.StockBarcode, dbo.Stocks.KdvRate, dbo.Stocks.BuyingPrice, dbo.Stocks.SellingPrice, dbo.Stocks.QuantityPerUnit, 
                         dbo.Stocks.UnitsInStock, dbo.Stocks.UnitsInOrder, dbo.Stocks.MinStockLevel, dbo.Stocks.StockId
FROM            dbo.Stocks INNER JOIN
                         dbo.Products ON dbo.Stocks.StockId = dbo.Products.StockId INNER JOIN
                         dbo.Categories ON dbo.Products.CategoryId = dbo.Categories.CategoryId", DbConnection.Connect()))
                {
                    da.Fill(dt);
                }

                gcList.DataSource = dt;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " \n\n " + hata.StackTrace);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun.frmStokEkle frmStokEkle = new Urun.frmStokEkle("-1");

                frmStokEkle.FormClosed += FrmStokEkle_FormClosed;

                frmStokEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " \n\n " + hata.StackTrace);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
             try
            {
                Urun.frmStokEkle frmStokEkle = new Urun.frmStokEkle(gvList.GetFocusedRowCellDisplayText("StockId"));

                frmStokEkle.FormClosed += FrmStokEkle_FormClosed;

                frmStokEkle.ShowDialog();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " \n\n " + hata.StackTrace);
            }
        }

        private void FrmStokEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            csExceleAktar csExceleAktar = new csExceleAktar(gcList);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Seçilen stok kalıcı olarak silinecektir. \n\nOnaylıyor musunuz?", "Stok Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };


                cmd.CommandText = @"DELETE FROM Products WHERE StockId =@StockId";

                cmd.Parameters.Add(@"StockId", SqlDbType.NVarChar).Value = gvList.GetFocusedRowCellDisplayText("StockId");

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Parameters.Clear();


                cmd.CommandText = @"DELETE FROM Stocks WHERE StockId =@StockId";

                cmd.Parameters.Add(@"StockId", SqlDbType.NVarChar).Value = gvList.GetFocusedRowCellDisplayText("StockId");

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

        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            Urun.frmKategoriEkle frmKategoriEkle = new Urun.frmKategoriEkle();

            frmKategoriEkle.FormClosed += FrmKategoriEkle_FormClosed;

            frmKategoriEkle.ShowDialog();

        }

        private void FrmKategoriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}