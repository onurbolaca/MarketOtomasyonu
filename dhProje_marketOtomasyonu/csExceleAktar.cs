using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhProje_marketOtomasyonu
{
    class csExceleAktar
    {

        SaveFileDialog sfdKaydet = new SaveFileDialog();

        public csExceleAktar(DevExpress.XtraGrid.GridControl _GelenGrid)
        {
            try
            {
                sfdKaydet.Filter = "Excel Files |*.xlsx";

                if (sfdKaydet.ShowDialog() == DialogResult.OK)
                {
                    DevExpress.XtraPrinting.XlsxExportOptions excelDosyaOzellikleri = new DevExpress.XtraPrinting.XlsxExportOptions();
                    excelDosyaOzellikleri.ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFile;
                    excelDosyaOzellikleri.ShowGridLines = true;
                    excelDosyaOzellikleri.ExportHyperlinks = true;
                    excelDosyaOzellikleri.RawDataMode = true;
                    excelDosyaOzellikleri.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value;
                    excelDosyaOzellikleri.SheetName = sfdKaydet.FileName;

                    GridView view = _GelenGrid.MainView as GridView;
                    view.BestFitColumns();
                    view.OptionsPrint.AutoWidth = false;
                    view.OptionsPrint.UsePrintStyles = false;

                    view.ExportToXlsx(sfdKaydet.FileName, excelDosyaOzellikleri);

                    //_GelenGrid.ExportToXls(sfdKaydet.FileName, a);

                    if (DevExpress.XtraEditors.XtraMessageBox.Show("Kaydetme Başarılı.\nKaydedilen Dosya Açılsın mı?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        System.Diagnostics.Process.Start(sfdKaydet.FileName);
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(hata.Message);
            }
        }
    }
}

