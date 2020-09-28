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

namespace dhProje_marketOtomasyonu
{
    public partial class frmAnasayfa : DevExpress.XtraEditors.XtraForm
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }


        public void FormuAc(Form GelenForm)
        {
            bool Aktif = false;
            foreach (var item in this.MdiChildren)

            {
                if (GelenForm.Name == item.Name)
                {
                    Aktif = true;
                    item.Activate();
                    break;
                }
            }
            if (Aktif == true)
            {
                //MessageBox.Show("Form Zaten Açık.");
            }
            else
            {
                GelenForm.MdiParent = this;
                GelenForm.Show();
            }
        }


        private void btnMarket_Click(object sender, EventArgs e)
        {
            frmMarket frmMarket = new frmMarket();
            FormuAc(frmMarket);
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            frmKasa frmKasa = new frmKasa();

            FormuAc(frmKasa);

        }

        private void btnVeresiyeDefteri_Click(object sender, EventArgs e)
        {
            frmVeresiye frmVeresiye = new frmVeresiye();

            FormuAc(frmVeresiye);

        }

        private void btnFirmaTakibi_Click(object sender, EventArgs e)
        {
            frmFirmaTakibi frmFirma = new frmFirmaTakibi();

            FormuAc(frmFirma);

        }

        private void btnSatisRaporlari_Click(object sender, EventArgs e)
        {
            frmSatisRaporlari frmSatisRaporlari = new frmSatisRaporlari();

            FormuAc(frmSatisRaporlari);

        }

        private void btnMalzemeEnvanter_Click(object sender, EventArgs e)
        {
            frmMalzemeEnvanter frmMalzemeEnvanter = new frmMalzemeEnvanter();

            FormuAc(frmMalzemeEnvanter);
        }

        private void btnKullaniciİslemleri_Click(object sender, EventArgs e)
        {
            frmKullaniciIslemleri frmKullaniciIslemleri = new frmKullaniciIslemleri();

            FormuAc(frmKullaniciIslemleri);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            frmMarket frmMarket = new frmMarket();
            FormuAc(frmMarket);
        }
    }
}