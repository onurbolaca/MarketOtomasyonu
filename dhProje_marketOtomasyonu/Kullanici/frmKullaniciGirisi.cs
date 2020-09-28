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
using dhProje_marketOtomasyonu.Kullanicilar;

namespace dhProje_marketOtomasyonu
{
    public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {

                #region BOŞ ALAN KONTORLÜ
                if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
                {
                    XtraMessageBox.Show("Kullanıcı Kodu Boş Geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKullaniciAdi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtKullaniciSifre.Text))
                {
                    XtraMessageBox.Show("Kullanıcı Şifre Boş Geçilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKullaniciSifre.Focus();
                    return;
                }
                #endregion


                bool giris = false;

                using (SqlCommand cmd = new SqlCommand(@"SELECT EmployeesId, UserName, Password, FirstName, LastName
FROM            dbo.Employees WHERE UserName=@UserName AND Password=@Password", DbConnection.Connect()))
                {
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = txtKullaniciAdi.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtKullaniciSifre.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader                        (CommandBehavior.SingleResult))

                    {
                        if (dr.Read())
                        {
                            giris = true;
                            Kullanicilar.Kullanicilar.FirstName = dr["FirstName"].ToString();
                            Kullanicilar.Kullanicilar.LastName = dr["LastName"].ToString();
                            Kullanicilar.Kullanicilar.EmployeesId = Convert.ToInt32( dr["EmployeesId"]);

                        }
                    }
                }

                if (giris == false)
                {
                    XtraMessageBox.Show("Kullanıcı Kodu veya Sifreniz hatalıdır.");
                    return;
                }

                frmAnasayfa frmAnasayfa = new frmAnasayfa();
                frmAnasayfa.FormClosed += FrmAnasayfa_FormClosed;

                this.Hide();

                frmAnasayfa.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void FrmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }

}
