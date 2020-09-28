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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using System.Collections;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraLayout.Converter;
using DevExpress.XtraRichEdit.Model;
using DevExpress.ClipboardSource.SpreadsheetML;
using dhProje_marketOtomasyonu.Musteri;
using dhProje_marketOtomasyonu.Kasa;

namespace dhProje_marketOtomasyonu
{
    public partial class frmMarket : DevExpress.XtraEditors.XtraForm
    {
        public frmMarket()
        {
            InitializeComponent();
        }

        //TODO Transaction EKLE

        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string ProductIdStr = "";

        decimal TotalTotalRowPrice = 0;

        string newOrderDetailId = "";
        string newOrderId = "";

        public string customerId = "";
        public string customerName = "";

        string discountRate = "";

        bool isReturn = false;

        int cashMoney = 0;
        int cardMoney = 0;


        List<OrderDetails> OrderDetailsList = new List<OrderDetails>();

        List<string> orderDetailIdList = new List<string>();

        Dictionary<string, string> IdQuantityOfOrders = new Dictionary<string, string>();
        Dictionary<string, string> IdQuantityOfStocks = new Dictionary<string, string>();



        private void cmbUrunler_TextChanged(object sender, EventArgs e)
        {
            FindProductName();
        }


        private void cmbUrunler_Properties_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbUrunler.ClosePopup();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void sbtnIsımIle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(cmbUrunler.Text))
                {
                    MessageBox.Show("Lütfen Ürün İsmi Girin");
                    cmbUrunler.Focus();
                    return;
                }

                if (cmbUrunler.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen Bir Ürün Seçin");
                    cmbUrunler.Focus();
                    return;
                }

                FindProductId();

                SetCalculatedOrder();

                #region ToplamFiyat kolonundaki tüm fiyatları ekrana yazdırıyorum
                //int summary = 0;
                //summary += Convert.ToInt32(ToplamFiyat.SummaryText);

                txtSummary.Text = TotalTotalRowPrice.ToString() + " TL";
                #endregion

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }


        //TODO: Isim ile yaptığını bununla yapacak mısın?
        private void sbtnBarkodIle_Click(object sender, EventArgs e)
        {
            int barcodeNumb = 0;

            try
            {
                if (int.TryParse(cmbUrunler.Text, out barcodeNumb) == false)
                {
                    MessageBox.Show("Barkod Numarası Girin");
                    cmbUrunler.Focus();
                }

                MessageBox.Show("Barkod ile?");

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }




        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            GetPaymentMethod();

            if (isReturn == true) //PaymentMethod'un veri girişinde bir hata olduysa, devam etme.
            {
                return;
            }

            SetOrderDetails();

            SetOrder();

            SetOrderIdToAllRelatedRows();

            SortOrdersOnInterface();

            GetStocksFromDb();

            SetStocksToDb();

            try
            {
                //Dict boşalt nerede yapıcan?



                //Tüm gerekli işlemleri temizler

                customerId = "";
                customerName = "";
                txtMusteriIsmi.Text = "";
                discountRate = "";
                lstPayment.SelectedIndex = 0;
                TotalTotalRowPrice = 0;
                txtSummary.Text = "";
                cmbUrunler.Focus();
                rdoIndirimHayir.Checked = true;
                rdoVeresiyeHayir.Checked = true;
                dt.Clear();
                OrderDetailsList.Clear();
                orderDetailIdList.Clear();
                IdQuantityOfOrders.Clear();
                IdQuantityOfStocks.Clear();

                //Devamı gelecek.

                MessageBox.Show("Sipariş Kaydedildi ✔");

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void frmMarket_Load(object sender, EventArgs e)
        {
            try
            {
                lblKullanici.Text = Kullanicilar.Kullanicilar.FirstName + " " + Kullanicilar.Kullanicilar.LastName;

                btnSiparisiTamamla.Enabled = false;

                lstPayment.SelectedIndex = 0;

                //timer1.Start();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void txtGivenMoney_EditValueChanged(object sender, EventArgs e)
        {
            try
            { //PARAÜSTÜNÜ HESAPLAR

                //if (txtSummary.Text.Length == 0)
                //{
                //    return;
                //}
                //string summary = txtSummary.Text ;

                txtMoneyToGive.Text =
                (Convert.ToInt32(txtGivenMoney.Text) - Convert.ToInt32(TotalTotalRowPrice)).ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void txtSummary_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //SİPARİŞ TAMAMLA BUTONUNU AÇIP KAPATIR.
                if (txtSummary.Text.Length == 0)
                {
                    btnSiparisiTamamla.Enabled = false;
                    return;
                }

                btnSiparisiTamamla.Enabled = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }


        //TODO: SAATİ Bİ ARA AÇ
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //lblTime.Text = DateTime.Now.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void rdoIndirimEvet_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoIndirimEvet.Checked == true)
                {
                    GetDiscount();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void rdoIndirimHayir_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtSummary.Text = ToplamFiyat.SummaryText + " TL";
                discountRate = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void rdoVeresiyeEvet_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoVeresiyeEvet.Checked == true)
                {
                    GetCustomerDebt();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void rdoVeresiyeHayir_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoVeresiyeHayir.Checked == true)
                {
                    customerId = "";
                    customerName = "";
                    txtMusteriIsmi.Text = "";
                    MessageBox.Show("Veresiye işlemi iptal edildi.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void btnSiparisIptal_Click(object sender, EventArgs e)
        {
            try
            {
                frmSiparisIptal frmSiparisIptal = new frmSiparisIptal();

                frmSiparisIptal.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " \n\n " + hata.StackTrace);
            }
        }

        private void btnSatirSil_Click(object sender, EventArgs e)


        {
            DialogResult answer = MessageBox.Show("Seçilen Satır Silinecektir. \n\nOnaylıyor musunuz?", "Satır Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.No)
            {
                return;
            }
            else
            {
                DataRow dataRow = gvList.GetFocusedDataRow();

                gvList.DeleteSelectedRows();

                dt.Rows.Remove(dataRow);


                int totalRows = gvList.RowCount;
                //Her işlem yapıldığında sonuncu satırdan itibaren başlamasına emin oluyorum
                gvList.FocusedRowHandle = totalRows - 1;


            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Ekran Temizlenecektir. \n\nOnaylıyor musunuz?", "Ekran Temizle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.No)
            {
                return;
            }
            else
            {

                ProductIdStr = "";
                newOrderDetailId = "";
                newOrderId = "";
                customerId = "";
                customerName = "";
                txtMusteriIsmi.Text = "";
                discountRate = "";
                lstPayment.SelectedIndex = 0;
                TotalTotalRowPrice = 0;
                txtSummary.Text = "";
                cmbUrunler.Focus();
                rdoIndirimHayir.Checked = true;
                rdoVeresiyeHayir.Checked = true;
                dt.Clear();
                OrderDetailsList.Clear();
                orderDetailIdList.Clear();
                IdQuantityOfOrders.Clear();
                IdQuantityOfStocks.Clear();
            }
        }


        //BUNLAR DAHA SONRA FARKLI FONKSİYONLARIN ALTINA ALINABİLİR Mİ? FOR A BETTER DESIGN
        void FindProductId()
        {
            string stringText = cmbUrunler.SelectedText;
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"SELECT ProductId
FROM            dbo.Products WHERE ProductName=@ProductName";

                cmd.Parameters.Add(@"ProductName", SqlDbType.NVarChar).Value = stringText;

                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    if (dr.Read())
                    {
                        ProductIdStr = dr["ProductId"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Ürün İsmini Tam Giriniz");
                        cmbUrunler.Focus();
                    }

                }

                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);


            }
        }

        //Find fonksiyonlarını birleştirebilirsin sanırım
        void FindProductName()
        {
            try
            {
                cmbUrunler.Properties.Items.Clear();

                string stringText = cmbUrunler.Text;

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"SELECT ProductName, ProductId
FROM            dbo.Products WHERE ProductName LIKE @stringText";

                cmd.Parameters.Add(@"stringText", SqlDbType.NVarChar).Value = stringText + "%";

                using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                {
                    while (dr.Read())
                    {
                        cmbUrunler.Properties.Items.Add(dr["ProductName"].ToString());
                        cmbUrunler.ShowPopup();
                    }

                    //cmbUrunler.SelectedIndexChanged += CmbUrunler_SelectedIndexChanged;
                }

                if (cmbUrunler.Text.Length == 0)
                {
                    cmbUrunler.Properties.Items.Clear();
                }

                cmd.Dispose();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);


            }
        }

        //KULLANICININ BAŞKA BİR SATIRI SEÇMESİNİ KONTROL EDİP SON SATIRI SEÇİLİ HALE GETİRME OLMUYOR
        void SetCalculatedOrder()
        {
            decimal TotalRowPrice = 0;
            string SellingPrice = "";
            decimal ProductQuantity = 0;

            try
            {
                if (Convert.ToInt32(ProductIdStr) == -1)
                { //Cmbox'ta tam girilmemesi durumunu için bir kontrol
                    return;
                }

                using (da.SelectCommand = new SqlCommand(@"SELECT dbo.Stocks.StockBarcode, dbo.Products.ProductName, dbo.Stocks.QuantityPerUnit, dbo.Stocks.SellingPrice
FROM            dbo.Products INNER JOIN
                         dbo.Stocks ON dbo.Products.StockId = dbo.Stocks.StockId WHERE ProductId=@ProductId", DbConnection.Connect()))
                {
                    da.SelectCommand.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(ProductIdStr);

                    da.Fill(dt);

                    foreach (DataRow row in dt.AsEnumerable())
                    {
                        SellingPrice = row.ItemArray[3].ToString();
                    }
                }

                ProductQuantity = numericUpDown1.Value;

                TotalRowPrice = Convert.ToDecimal(SellingPrice) * ProductQuantity;

                TotalTotalRowPrice += TotalRowPrice;

                OrderDetailsList.Add(new OrderDetails { _ProductIdStr = ProductIdStr, _ProductQuantity = ProductQuantity, _SellingPrice = SellingPrice, _TotalRowPrice = TotalRowPrice });


                if (dt.Columns.Count != 6)
                {
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("TotalRowPrice");
                }

                gcList.DataSource = dt;


                int totalRows = gvList.RowCount;
                //Her işlem yapıldığında sonuncu satırdan itibaren başlamasına emin oluyorum
                gvList.FocusedRowHandle = totalRows - 1;


                gvList.SetRowCellValue(gvList.FocusedRowHandle, "Quantity", ProductQuantity);
                gvList.SetRowCellValue(gvList.FocusedRowHandle, "TotalRowPrice", TotalRowPrice);

                ProductIdStr = "-1"; //Cmbox'ta tam girilmemesi durumu için bir kontrol
                cmbUrunler.Text = "";
                numericUpDown1.Value = 1;

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);

            }
        }



        //Cash ve Card seçeneklerinde içeri sayı alıp almadığını kontrol et
        void GetPaymentMethod()
        {
            //Gün sonu ile beraber listeler temizlenir

            try
            {
                switch (lstPayment.SelectedIndex)
                {
                    case 0:
                        cashMoney = Convert.ToInt32(TotalTotalRowPrice);
                        break;
                    case 1:
                        cardMoney = Convert.ToInt32(TotalTotalRowPrice);
                        break;
                    case 2:

                        string cashStr = "";
                        string cardStr = "";
                        cashMoney = 0;
                        cardMoney = 0;

                        cashStr = Microsoft.VisualBasic.Interaction.InputBox("Nakit Satış Miktarını Girin: ", "NAKİT SATIŞ");

                        #region Giriş Kontrol
                        if (string.IsNullOrEmpty(cashStr))
                        {
                            MessageBox.Show("Bir Değer Girin");
                            isReturn = true;
                            return;
                        }

                        string leftMoney = "";
                        if (int.TryParse(cashStr, out cashMoney) == false)
                        {
                            MessageBox.Show("Lütfen bir sayı girin");
                            isReturn = true;
                            return;
                        }
                        #endregion
                        else
                        {
                            leftMoney = (Convert.ToInt32(TotalTotalRowPrice) - cashMoney).ToString();

                            //(txtSummary.Text.Remove(txtSummary.Text.Length - 3)) - Convert.ToInt32(cashStr))
                        }

                        cardStr = Microsoft.VisualBasic.Interaction.InputBox("Kart Satış Miktarını Girin: \n\nKalan Miktar: " + leftMoney + " TL", "KART SATIŞ");

                        #region Giriş Kontrol
                        if (string.IsNullOrEmpty(cardStr))
                        {
                            MessageBox.Show("Bir Değer Girin");
                            isReturn = true;
                            return;
                        }

                        if (int.TryParse(cardStr, out cardMoney) == false)
                        {
                            MessageBox.Show("Lütfen bir sayı girin");
                            isReturn = true;
                            return;
                        }
                        #endregion
                        else
                        {

                            if (cashMoney + cardMoney > Convert.ToInt32(TotalTotalRowPrice))
                            {
                                MessageBox.Show("Toplam Fiyatın Üstünde Fiyat Girdiniz.");
                                isReturn = true;
                                return;
                            }

                            if (cardMoney < Convert.ToInt32(leftMoney))
                            {
                                DialogResult answer = MessageBox.Show("Toplam Fiyatın Altında Fiyat Girdiniz. \nDevam etmek istediğinize emin misiniz? \n\nHayır derseniz işleminiz iptal edilecektir.", "Fiyat", MessageBoxButtons.YesNo);

                                if (answer == DialogResult.Yes)
                                {
                                    return; //diğer fonksiyonlara devam edecek
                                }
                                else
                                {
                                    isReturn = true;
                                    return;
                                }
                            }

                        }


                        break;
                    default:
                        break;
                }
            }
            catch (Exception hata)
            {
                isReturn = true;
                MessageBox.Show(hata.Message);
            }
        }

        void GetDiscount()
        {
            try
            {
                discountRate = Microsoft.VisualBasic.Interaction.InputBox("Yapılacak İndirimin Miktarını Giriniz: \n 'Not: Başında Yüzde(%) İşareti Olmamalı' ", "İNDİRİM");

                if (discountRate == "")
                {
                    rdoIndirimHayir.Checked = true;
                    return;
                }

                decimal discountRateDecimal = 0;
                if (decimal.TryParse(discountRate, out discountRateDecimal) == false)
                {
                    MessageBox.Show("Yalnızca sayı girişine izin verilir.");
                    return;
                }

                decimal calculatedDiscount = 0;
                decimal discountRateInMoney = 0;

                discountRateInMoney = (Convert.ToDecimal(txtSummary.Text.Remove(txtSummary.Text.Length - 3)) / 100) * discountRateDecimal;

                calculatedDiscount = Convert.ToDecimal(txtSummary.Text.Remove(txtSummary.Text.Length - 3)) - discountRateInMoney;

                txtSummary.Text = calculatedDiscount.ToString() + " TL";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        void GetCustomerDebt()
        {
            DialogResult answerVeresiye = MessageBox.Show("Veresiye girilsin mi?", "VERESİYE", MessageBoxButtons.YesNo);

            if (answerVeresiye == DialogResult.Yes)
            {
                frmMusteriBul frmMusteriBul = new frmMusteriBul();
                frmMusteriBul.ShowDialog();
            }
            else
            {
                rdoVeresiyeHayir.Checked = true;
                return;
            }
        }



        void SetOrderDetails()
        {
            try
            {
                //  her eklendiğinde o satıra ait olan bilgileri order details tablosuna dağıtma işi
                //Hesaplattığım Total Price'ı, db'deki Order Detail'e kalan değerler ile veriyorum.

                SqlCommand cmd2 = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd2.CommandText = @"INSERT INTO OrderDetails(ProductId, SellingPrice, Quantity, TotalRowPrice) VALUES(@ProductId,@SellingPrice,@Quantity,@TotalRowPrice) SET @newOrderDetailId=SCOPE_IDENTITY()";

                foreach (var orderDetail in OrderDetailsList)
                {
                    cmd2.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(orderDetail._ProductIdStr);
                    cmd2.Parameters.Add("@SellingPrice", SqlDbType.NVarChar).Value = orderDetail._SellingPrice;
                    cmd2.Parameters.Add("@Quantity", SqlDbType.Int).Value = Convert.ToInt32(orderDetail._ProductQuantity);
                    cmd2.Parameters.Add("@TotalRowPrice", SqlDbType.NVarChar).Value = orderDetail._TotalRowPrice.ToString();


                    cmd2.Parameters.Add("@newOrderDetailId", SqlDbType.Int).Direction = ParameterDirection.Output;

                    cmd2.ExecuteNonQuery();

                    newOrderDetailId = cmd2.Parameters["@newOrderDetailId"].Value.ToString();

                    orderDetailIdList.Add(newOrderDetailId);

                    cmd2.Parameters.Clear();
                }

                cmd2.Dispose();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }  //içerdeki tablodaki tüm satırları -> order details tablosuna

        //TODO: employee'yi db'ye aç.
        void SetOrder()
        {
            try
            {
                //Tüm parametreleri toplar ve yeni bir order oluşturur. 

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"INSERT INTO Orders (OrderDate, PaymentMethod, DiscountRate, TotalOrderPrice, EmployeesId, CustomersId, CashSales , CardSales) VALUES(@OrderDate, @PaymentMethod, @DiscountRate, @TotalOrderPrice, @EmployeesId, @CustomersId,@CashSales,@CardSales ) SET @newOrderId=SCOPE_IDENTITY()";

                cmd.Parameters.Add("@PaymentMethod", SqlDbType.NVarChar).Value = lstPayment.SelectedItem.ToString().Trim();
                cmd.Parameters.Add("@TotalOrderPrice", SqlDbType.Decimal).Value = TotalTotalRowPrice;

                cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime).Value = DateTime.Now;

                cmd.Parameters.Add("@EmployeesId", SqlDbType.Int).Value = DBNull.Value; //Kullanicilar.Kullanicilar.EmployeesId;

                if (discountRate == "")
                {
                    cmd.Parameters.Add("@DiscountRate", SqlDbType.SmallInt).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@DiscountRate", SqlDbType.SmallInt).Value = Convert.ToInt32(discountRate);
                }

                if (customerId == "")
                {
                    cmd.Parameters.Add("@CustomersId", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CustomersId", SqlDbType.Int).Value = Convert.ToInt32(customerId);
                }

                if (cashMoney == 0)
                {
                    cmd.Parameters.Add("@CashSales", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CashSales", SqlDbType.NVarChar).Value = cashMoney;
                }

                if (cardMoney == 0)
                {
                    cmd.Parameters.Add("@CardSales", SqlDbType.NVarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CardSales", SqlDbType.NVarChar).Value = cardMoney;
                }

                cmd.Parameters.Add("@newOrderId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                newOrderId = cmd.Parameters["@newOrderId"].Value.ToString();

                cmd.Parameters.Clear();
                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }  //order tablosuna, gerekli parametreler ile (discount, debt, paymentMethod)

        void SetOrderIdToAllRelatedRows()
        {
            try
            {
                //Son girilen order id'yi setOrder içinde aldık. Aşağıda, orderDetails tablosundaki sipariş satırlarını tek bir order'lara ilişkilendirecek şekilde her satıra aynı id'yi verir. Girilen satırları tek bir sipariş yapar.

                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                foreach (var OrderDetailIds in orderDetailIdList)
                {
                    cmd.CommandText = @"UPDATE OrderDetails SET OrderId=@OrderId WHERE (OrderDetailId=@OrderDetailId)";

                    cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = Convert.ToInt32(newOrderId);
                    cmd.Parameters.Add("@OrderDetailId", SqlDbType.Int).Value = Convert.ToInt32(OrderDetailIds);

                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }        //order details tablosuna order id'leri




        void SortOrdersOnInterface()
        {

            try
            {
                string isSameId = "";
                string ProductQuantityOnInterface = "";
                string getCurrentQuantity = "";
                decimal InterfaceTotalQuantity = 0;

                foreach (var orderDetail in OrderDetailsList) // id ve quantity tutan liste
                {
                    isSameId = orderDetail._ProductIdStr;
                    ProductQuantityOnInterface = orderDetail._ProductQuantity.ToString();

                    if (IdQuantityOfOrders.ContainsKey(isSameId))
                    {

                        getCurrentQuantity = IdQuantityOfOrders[isSameId];

                        //Sadece += ile ProductQuantityOnInterface eklesem de olurdu.
                        //Product aynı olduğundan, içinde bulunan miktara ekleme yaptım.

                        InterfaceTotalQuantity = Convert.ToDecimal(getCurrentQuantity) + Convert.ToDecimal(ProductQuantityOnInterface);

                        IdQuantityOfOrders[isSameId] = InterfaceTotalQuantity.ToString();

                    }
                    else
                    {
                        IdQuantityOfOrders.Add(isSameId, ProductQuantityOnInterface);
                    }
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }

        }

        void GetStocksFromDb()
        {
            try
            {
                //kaç adet düşecek? + (kaç adet geri ekleyecek? -sipariş iptalinde)

                SqlCommand cmd = new SqlCommand()
                {
                    CommandType = CommandType.Text,
                    Connection = DbConnection.Connect(),
                };

                cmd.CommandText = @"SELECT dbo.Stocks.UnitsInStock 
FROM            dbo.Stocks INNER JOIN
                         dbo.Products ON dbo.Stocks.StockId = dbo.Products.StockId WHERE (Products.ProductId = @ProductId)";


                foreach (KeyValuePair<string, string> Order in IdQuantityOfOrders)
                {
                    int ProductId = Convert.ToInt32(Order.Key);

                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = ProductId;


                    string productId = Order.Key;

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr.Read())
                        {
                            string dbStockQuantity = dr["UnitsInStock"].ToString();

                            IdQuantityOfStocks.Add(productId, dbStockQuantity);
                        }
                    }

                    cmd.Parameters.Clear();

                }

                cmd.Dispose();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        void SetStocksToDb()
        {
            try
            {
                SqlCommand cmd = new SqlCommand { CommandType = CommandType.Text, Connection = DbConnection.Connect() };

                cmd.CommandText = @"UPDATE Stocks SET UnitsInStock=@Quantity FROM dbo.Stocks AS S INNER JOIN
                         dbo.Products AS P ON S.StockId = P.StockId WHERE (P.ProductId = @ProductId)";

                foreach (KeyValuePair<string, string> Order in IdQuantityOfOrders)
                {
                    decimal stockQuantity = 0;
                    decimal orderQuantity = 0;
                    decimal leftQuantity = 0;

                    if (IdQuantityOfStocks.ContainsKey(Order.Key))
                    {
                        stockQuantity = Convert.ToDecimal(IdQuantityOfStocks[Order.Key]);

                        orderQuantity = Convert.ToDecimal(Order.Value);

                        leftQuantity = stockQuantity - orderQuantity;
                    }

                    //Burada ürün tekrar olabilir, tekrarlayan ürünleri teke indirip stoktaki temsilini yapmam lazım
                    //Tekrarlayan ürünün sipariş miktarını birleştirmem lazım. 
                    //Aynı sınıf içinde id ile birleşen quantity'i aynı id altında toplamalıyım.

                    cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = Convert.ToInt32(Order.Key);

                    cmd.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = leftQuantity;

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }

                cmd.Dispose();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message + " " + hata.StackTrace);
            }
        }

        private void btnGunSonu_Click(object sender, EventArgs e)
        {



        }

        private void btnFirmaOdeme_Click(object sender, EventArgs e)
        {

        }


    }
}