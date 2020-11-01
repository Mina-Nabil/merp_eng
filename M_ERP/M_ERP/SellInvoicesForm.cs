using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace M_ERP
{
    public partial class SellInvoicesForm : Form
    {
        private static Excel.Workbook ExcelTemplate;

        private static Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        private static Excel.Worksheet xlWorkSheet;
        
        private int invoiceFormNo = Varibles.sellInvoiceForm;
        private double clientBalance = 0;
        private int itemBalance = 0;

        private bool barcodeFlag = false;
        private int MinLength = 0;
        MySqlDataReader reader;
        MySqlCommand cmd;
        String temp = "";
        public SellInvoicesForm()
        {


            
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            this.ActiveControl = barcodeTB;
            this.KeyPreview = true;
            //this.KeyPress += new KeyPressEventHandler(keypressed);

            try
            {
                MinLength = getMinBarcode();

            }
            catch (Exception ex)
            {
                MinLength = 0;
            }
            fillIvoiceCodeNumber();

            fillProdTypes();

            fillClientName();

            clientNameComboBox.SelectedIndex = -1;
            productTypeComboBox.SelectedIndex = -1;
            productNameComboBox.SelectedIndex = -1;
            priceTypeComboBox.SelectedIndex = 0;
            productNameComboBox.Enabled = false;

            showQuantitygroup(false);
            enableAll(true);
            showDeleteItemBtn();

        }

        private void fillClientName()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "SELECT CLT_ID, CLT_NAME FROM merp.clients";

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                clientNameComboBox.DisplayMember = "CLT_NAME";
                clientNameComboBox.ValueMember = "CLT_ID";
                clientNameComboBox.DataSource = ds.Tables[0];


                clientNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                clientNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Varibles.closeConnection();
            }
        }

        private void fillIvoiceCodeNumber()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String sqlCommand = "SELECT INV_ID FROM merp.invoices WHERE INV_TYPE_ID = '"+invoiceFormNo+"' ;";

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                invoiceCodeComboBox.DisplayMember = "INV_ID";
                invoiceCodeComboBox.ValueMember = "INV_ID";
                invoiceCodeComboBox.DataSource = ds.Tables[0];



                invoiceCodeComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                invoiceCodeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
                Varibles.closeConnection();

                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query = "SELECT max(INV_ID) as max FROM merp.invoices WHERE INV_TYPE_ID = '" + invoiceFormNo+"' ;";
                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                int id = 0;
                while (reader.Read())
                {
                    try
                    {
                        id = reader.GetInt32("max");
                    }
                    catch (Exception ex)
                    {
                        id = 0;
                    }
                }

                id ++;

                invoiceCodeComboBox.SelectedIndex = -1;
                invoiceCodeComboBox.Text = "" + id ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }
        }


        private void fillProdTypes()
        {

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "SELECT PRDTYP_ID, PRDTYP_NAME FROM merp.prod_types where merp.prod_types.is_supplies = '0';";

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                productTypeComboBox.DisplayMember = "PRDTYP_NAME";
                productTypeComboBox.ValueMember = "PRDTYP_ID";
                productTypeComboBox.DataSource = ds.Tables[0];


                productTypeComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                productTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Varibles.closeConnection();
            }

        }

        private void fillProdName()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int prodTypeID = Convert.ToInt32(this.productTypeComboBox.SelectedValue);

                String sqlCommand = "SELECT PRD_ID, PRD_NAME " +
                           " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_TYPE_ID = " + prodTypeID;

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                productNameComboBox.DisplayMember = "PRD_NAME";
                productNameComboBox.ValueMember = "PRD_ID";
                productNameComboBox.DataSource = ds.Tables[0];


                productNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                productNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                productNameComboBox.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                Varibles.closeConnection();
            }

        }




      

        

        private void BuyInvoicesForm_Load(object sender, EventArgs e)
        {
        }

        private void productTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            barcodeFlag = false;
            fillProdName();
            productNameComboBox.Enabled = true;
            addItemBtn.Enabled = false;
            showQuantitygroup(false);
        }

        private void productNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            barcodeFlag = false;
            showQuantitygroup(true);
            addItemBtn.Enabled = true;
            loadItemBalance();
            priceTypeComboBox.SelectedIndex = 0;
        }

        private void showQuantitygroup(bool tf)
        {
            quantityTextBox.Enabled = tf;
            itemPriceTextBox.Enabled = tf;
        }

        private void productNameComboBox_TextChanged(object sender, EventArgs e)
        {
            showQuantitygroup(false);
            addItemBtn.Enabled = false;
            loadItemBalance();
            showQuantitygroup(false);
        }

        private void productTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            productNameComboBox.Enabled = false;
            addItemBtn.Enabled = false;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //if (clientNameComboBox.Text == "") { clientNameComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (productTypeComboBox.Text == "") { productTypeComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (productNameComboBox.Text == "") { productNameComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (priceTypeComboBox.Text == "") { priceTypeComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            int quantityTextBoxValue = Convert.ToInt32(quantityTextBox.Text);
            if (quantityTextBox.Text == "") { quantityTextBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (quantityTextBoxValue < 0) { quantityTextBox.Focus(); MessageBox.Show("لايمكن أن تكون الكمية أقل من 1"); return; };

            if (itemPriceTextBox.Text == "") { itemPriceTextBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };


            double itemPrice = 0;
            int itemQuantity = 0;
            try
            {
                try
                {
                    itemPrice = Convert.ToDouble(itemPriceTextBox.Text);
                }
                catch (Exception ex)
                {
                    itemPrice = 0;
                    itemPriceTextBox.Text = "0";
                    MessageBox.Show("خطأ فى سعر الوحدة");
                    return;
                }
                try
                {
                    itemQuantity = Convert.ToInt32(quantityTextBox.Text);
                }
                catch (Exception ex)
                {
                    itemQuantity = 0;
                    quantityTextBox.Text = "0";
                    MessageBox.Show("خطأ فى الكمية");
                    return;
                }
                if (itemPrice <= 0)
                {
                    MessageBox.Show("خطأ فى سعر الوحدة");
                    return;
                }

                if (itemQuantity <= 0)
                {
                    MessageBox.Show("خطأ فى الكمية");
                    return;
                }

                //int itembalance = Convert.ToInt32(productBalanceTextBox.Text);

                //if (getItemQuantity(Convert.ToInt32(productNameComboBox.SelectedValue), itemQuantity) > itembalance)
                //{
                //    MessageBox.Show("الكمية المطلوبة اكثر من الحد فى المخازن");
                //    return;
                //}
                else
                {
                    int n = 6;
                    string[] row = new string[n];

                    row[0] = ""+productNameComboBox.SelectedValue;
                    row[1] = "" + productTypeComboBox.Text;
                    row[2] = "" + productNameComboBox.Text;
                    row[3] = "" + itemQuantity;
                    row[4] = "" + itemPrice;
                    row[5] = "" + totalItemPriceTextBox.Text;
                  
                    dataGridView1.Rows.Add(row);

                     calculateTotalInvoice();
                     showDeleteItemBtn();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            focusAndClear();
        }

        private int getItemQuantity(int id,int overQuantity)
        {
            int itemQuantity = overQuantity;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (id == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                {
                    itemQuantity += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                }
            }

            return itemQuantity;
        }

        private void calculateTotalInvoice()
        {
            double discount = 0,total = 0,net = 0;
            try
            {
                total = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    double item = Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    total += item;
                }

                totalInvoicePriceLBL.Text = total.ToString("0.00"); ;

                discount = Convert.ToDouble(DiscoutTextBox.Text);

            }
            catch (Exception ex)
            {
                discount = 0;
                DiscoutTextBox.Text = "0";
                MessageBox.Show("خطأ فى مدخلات الخصم");
            }
            finally
            {
                net = total - discount;
                netTotalInvoicePrice.Text = net.ToString("0.00") ;
            }

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            barcodeFlag = false;
            calculatTotalForItem();
        }


        private void itemPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            barcodeFlag = false;
            calculatTotalForItem();
        }

        private void calculatTotalForItem()
        {
            double total = 0;
            double itemPrice = 0;
            int itemQuantity = 0;
            try
            {
                try
                {
                    if (itemPriceTextBox.Text != "")
                    {
                        itemPrice = Convert.ToDouble(itemPriceTextBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    total = 0;
                    itemPrice = 0;
                    itemPriceTextBox.Text = "0";
                    totalItemPriceTextBox.Text = "0.00";
                    MessageBox.Show("خطأ فى سعر الوحدة");
                    return;
                }
                try
                {
                    if (quantityTextBox.Text != "")
                    {
                        itemQuantity = Convert.ToInt32(quantityTextBox.Text);
                    }
                }
                catch (Exception ex)
                {
                    total = 0;
                    itemQuantity = 0;
                    quantityTextBox.Text = "0";
                    totalItemPriceTextBox.Text = "0.00";
                    MessageBox.Show("خطأ فى الكمية");
                    return;
                }

                if (itemPrice < 0)
                {
                    MessageBox.Show("خطأ فى سعر الوحدة");
                    return;
                }

                if (itemQuantity < 0 )
                {
                    MessageBox.Show("خطأ فى الكمية");
                    return;
                }

                total = itemPrice*itemQuantity;

                totalItemPriceTextBox.Text = total.ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void priceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (priceTypeComboBox.SelectedIndex == 0)
            {
                itemPriceTextBox.Enabled = true;
            }
            else if (priceTypeComboBox.SelectedIndex == 1)
            {
                itemPriceTextBox.Enabled = false;
                loadSctrPRice();
            }
            else if (priceTypeComboBox.SelectedIndex == 2)
            {
                itemPriceTextBox.Enabled = false;
                loadWHLSalePRice();
            }
        }

        private void loadSctrPRice()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int prdNameId = Convert.ToInt32(productNameComboBox.SelectedValue);

                String query = "SELECT PRD_SCTRPRICE FROM merp.products WHERE PRD_ID = " + prdNameId + " ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                double price = 0;
                while (reader.Read())
                {
                    try
                    {
                        price = reader.GetDouble("PRD_SCTRPRICE");
                    }
                    catch (Exception ex)
                    {
                        price = 0;
                    }
                }


                itemPriceTextBox.Text = price.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }
        }

        private void loadWHLSalePRice()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int prdNameId = Convert.ToInt32(productNameComboBox.SelectedValue);

                String query = "SELECT PRD_WHLSALEPRICE FROM merp.products WHERE PRD_ID = " + prdNameId + " ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                double price = 0;
                while (reader.Read())
                {
                    try
                    {
                        price = reader.GetDouble("PRD_WHLSALEPRICE");
                    }
                    catch (Exception ex)
                    {
                        price = 0;
                    }
                }


                itemPriceTextBox.Text = price.ToString("0.00") ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }

        }

        private void clientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            barcodeFlag = false;
            loadClientBalance();
            groupBox2.Enabled = true;
        }

        private void loadClientBalance()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int cltNameID = Convert.ToInt32(clientNameComboBox.SelectedValue);

                String query = "SELECT CLNT_BLNCE FROM merp.clients WHERE CLT_ID = '" + cltNameID + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                double cltBalance = 0;
                while (reader.Read())
                {
                    try
                    {
                        cltBalance = reader.GetDouble("CLNT_BLNCE");
                    }
                    catch (Exception ex)
                    {
                        cltBalance = 0;
                    }
                }

                clientBalance = -1*cltBalance;

                clientBalanceTextBox.Text = clientBalance.ToString("0.00") ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }
        }

        private void loadItemBalance()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int prdID = Convert.ToInt32(productNameComboBox.SelectedValue);

                String query = "SELECT PRD_BALANCE FROM merp.products WHERE PRD_ID = " + prdID + " ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                int itemBlnc = 0;
                while (reader.Read())
                {
                    try
                    {
                        itemBlnc = reader.GetInt32("PRD_BALANCE");
                    }
                    catch (Exception ex)
                    {
                        itemBlnc = 0;
                    }
                }

                itemBalance = itemBlnc;

                productBalanceTextBox.Text = ""+itemBalance ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }
        }

        private int getItemBalance(int id)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int prdID = id;

                String query = "SELECT PRD_BALANCE FROM merp.products WHERE PRD_ID = " + prdID + " ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                int itemBlnc = 0;
                while (reader.Read())
                {
                    try
                    {
                        itemBlnc = reader.GetInt32("PRD_BALANCE");
                    }
                    catch (Exception ex)
                    {
                        itemBlnc = 0;
                    }
                }

                return itemBlnc;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;

            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }
        }

        private void clientNameComboBox_TextChanged(object sender, EventArgs e)
        {
            clientBalance = 0.00;
            clientBalanceTextBox.Text = ""+(-1*clientBalance);
            groupBox2.Enabled = false;
            payNowRadioButton.Checked = true;
        }

        private void DisscoutTextBox_TextChanged(object sender, EventArgs e)
        {
            barcodeFlag = false;
            if (DiscoutTextBox.Text != "")
            {
                calculateTotalInvoice();
            }
        }


        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                showDeleteItemBtn();
                focusAndClear();
                //calculatTotalForItem();
                calculateTotalInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showDeleteItemBtn()
        {
            if (dataGridView1.RowCount <= 0)
            {
                deleteItemBtn.Enabled = false;
            }
            else
            {
                deleteItemBtn.Enabled = true;
            }
        }

        private void enableAll(bool tf)
        {
            clientNameComboBox.Enabled = tf;
            productTypeComboBox.Enabled = tf;
            productNameComboBox.Enabled = tf;
            addItemBtn.Enabled = tf;
            DiscoutTextBox.Enabled = tf;
            groupBox2.Enabled = tf;
            saveInvoiceBtn.Enabled = tf;
            payAfterGroupBox.Enabled = tf;
            if (tf)
            {
                clientNameComboBox.Text = "";
                DiscoutTextBox.Text = "0";
                totalInvoicePriceLBL.Text = "0.00";
                netTotalInvoicePrice.Text = "0.00";
                payingValueTB.Text = "0";

                productTypeComboBox.SelectedIndex = -1;
                productNameComboBox.SelectedIndex = -1;
                productTypeComboBox.Text = "";
                productNameComboBox.Text = "";
                itemPriceTextBox.Text = "0";
                quantityTextBox.Text = "0";
            }

        }

        private void invoiceCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invoiceCodeComboBox.SelectedIndex > -1)
            {
                showFormDetails();
                showTablesDetails();
                enableAll(false);
                printInvoiceBtn.Enabled = true;
            }
        }


        private void showFormDetails()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int inv_Id = Convert.ToInt32(invoiceCodeComboBox.Text);

                

                String query = "SELECT * FROM merp.invoices WHERE invoices.INV_ID = '" + inv_Id + "' AND invoices.INV_TYPE_ID = '" + invoiceFormNo + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                DateTime dateTime;
                double netTotal;
                String prsn_Name;
                double discount;
                double clint_blnc;
                bool paymentWay;
                double inv_paid;
                while (reader.Read())
                {
                    try
                    {
                        dateTime = reader.GetDateTime("INV_DATE");
                    }
                    catch(Exception ex)
                    {
                        dateTime = DateTime.Now;
                    }

                    try
                    {
                        netTotal = reader.GetDouble("INV_TOTAL");
                    }
                    catch(Exception ex)
                    {
                        netTotal = 0;
                    }

                    try
                    {
                       prsn_Name = reader.GetString("INV_PRSN_NAME");
                    }
                    catch(Exception ex)
                    {
                        prsn_Name = "";
                    }

                    try
                    {
                        discount = reader.GetDouble("DISCOUNT");
                    }
                    catch(Exception ex)
                    {
                        discount = 0;
                    }

                    try
                    {
                        clint_blnc = reader.GetDouble("INV_CRNTBLNCE");
                    }
                    catch (Exception ex)
                    {
                        clint_blnc = 0;
                    }

                    try
                    {
                        paymentWay = reader.GetBoolean("INV_FLAG");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        paymentWay = false ;
                    }


                    if (paymentWay)
                    {
                        payAfterRadioButton.Checked = true;
                        try
                        {
                            inv_paid = reader.GetDouble("INV_PAID");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            inv_paid = 0;
                        }

                        payingValueTB.Text = inv_paid.ToString("0.00");
                    }
                    else
                    {
                        payNowRadioButton.Checked = true;
                    }

                    clientNameComboBox.Text = prsn_Name;
                    dateTimePicker1.Value = dateTime;
                    DiscoutTextBox.Text = discount.ToString("0.00");
                    netTotalInvoicePrice.Text = netTotal.ToString("0.00") ;
                    double totalInv = netTotal + discount;
                    totalInvoicePriceLBL.Text = totalInv.ToString("0.00");

                    clint_blnc *= -1;

                    clientBalanceTextBox.Text = clint_blnc.ToString("0.00");

                    if (paymentWay)
                    {
                        payAfterRadioButton.Checked = true;
                    }
                    else
                    {
                        payNowRadioButton.Checked = true;
                    }

                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }
        }

        private void showTablesDetails()
        {
            try
            {
                dataGridView1.Rows.Clear();
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int inv_Id = Convert.ToInt32(invoiceCodeComboBox.Text);


                String query = "SELECT * FROM merp.inv_prod_rel, merp.products , merp.prod_types WHERE  merp.inv_prod_rel.INVPROD_PRD_ID = merp.products.PRD_ID AND merp.products.PRD_TYPE_ID = merp.prod_types.PRDTYP_ID AND inv_prod_rel.INVPROD_INV_ID = '" + inv_Id + "' AND merp.inv_prod_rel.INVPROD_INVTYPE_ID = '" + invoiceFormNo + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                int prdCode;
                String prd_Type;
                String prd_name;
                int prd_count;
                double price;
                double total_price;

                while (reader.Read())
                {
                    try
                    {
                        prdCode = reader.GetInt32("INVPROD_PRD_ID");
                    }
                    catch (Exception ex)
                    {
                        prdCode = 0;
                    }

                    try
                    {
                        prd_Type = reader.GetString("PRDTYP_NAME");
                    }
                    catch (Exception ex)
                    {
                        prd_Type = "";
                    }

                    try
                    {
                        prd_name = reader.GetString("PRD_NAME");
                    }
                    catch (Exception ex)
                    {
                        prd_name = "";
                    }

                    try
                    {
                        prd_count = reader.GetInt32("INVPROD_COUNT");
                    }
                    catch (Exception ex)
                    {
                        prd_count = 0;
                    }

                    try
                    {
                        price = reader.GetDouble("INVPROD_PRICE");
                    }
                    catch (Exception ex)
                    {
                        price = 0;
                    }

                    try
                    {
                        total_price = prd_count * price;
                    }
                    catch (Exception ex)
                    {
                        total_price = 0;
                    }

                    int n = 6;
                    string[] row = new string[n];

                    row[0] = "" + prdCode;
                    row[1] = "" + prd_Type;
                    row[2] = "" + prd_name;
                    row[3] = "" + prd_count;
                    row[4] = "" + price;
                    row[5] = "" + total_price;

                    dataGridView1.Rows.Add(row);


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }

            
        }

        private void invoiceCodeComboBox_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            enableAll(true);
            dataGridView1.Rows.Clear();
            printInvoiceBtn.Enabled = false;
        }


        private void payNowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            payAfterGroupBox.Visible = false;
        }

        private void payAfterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            payAfterGroupBox.Visible = true;
        }

        private void newInvoiceBtn_Click(object sender, EventArgs e)
        {
            focusAndClear();
            enableAll(true);
            printInvoiceBtn.Enabled = false;
            fillIvoiceCodeNumber();
            dataGridView1.Rows.Clear();
            showDeleteItemBtn();
            showQuantitygroup(false);
            barcodeTB.Text = "";
        }

        private void saveInvoiceBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try //check stock
                {

                    //Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();
                    int pr_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    double pr_price = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    int pr_balance = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    String pr_name = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);

                    int stock_balance = 0;



                    if (isInStock(pr_id))
                    {
                        stock_balance = balanceInStock(pr_id);

                        if (pr_balance > stock_balance)
                        {
                            MessageBox.Show("خطأ" + " " + "العدد الموجود من هذا الصنف" + "\n" + pr_name + "\n" + "في المخزن" + " " + stock_balance);
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("خطأ" + " " + "لا يوجد من هذا الصنف" + "\n" + pr_name + "\n" + "في المخزن");
                        return;
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    Varibles.closeConnection();
                }
            }

            List<int> listOfItems = new List<int>();
            int payingWay;
            double payingValue;
            int selected;
            InvLog inv = new InvLog();

            try
            {
                selected = Convert.ToInt32(clientNameComboBox.SelectedValue);
                String q;
                payingWay = 0;
                payingValue = 0;

                if (payNowRadioButton.Checked)
                {
                    payingWay = 0;
                    payingValue = Convert.ToDouble(netTotalInvoicePrice.Text);
                }
                else if (payAfterRadioButton.Checked)
                {
                    payingWay = 1;
                    payingValue = Convert.ToDouble(payingValueTB.Text);
                }


                if (selected == 0)
                {
                    q = "INSERT INTO `merp`.`invoices` (`INV_ID`, `INV_DATE`, `INV_TYPE_ID`, `INV_TOTAL`, `INV_PRSN_NAME`, `DISCOUNT`, `INV_PAID`, `INV_FLAG`, `INV_CRNTBLNCE`, `INV_USER_ID`) VALUES ('" + invoiceCodeComboBox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + invoiceFormNo + "', '" + Convert.ToDouble(netTotalInvoicePrice.Text) + "' , '" + clientNameComboBox.Text + "' , '" + Convert.ToDouble(DiscoutTextBox.Text) + "' , '" + payingValue + "' , " + payingWay + " , '" + (-1 * Convert.ToDouble(clientBalanceTextBox.Text)) + "' , '" + Varibles.getUserId() + "' );";

                }
                else
                {
                    q = "INSERT INTO `merp`.`invoices` (`INV_ID`, `INV_DATE`, `INV_TYPE_ID`, `INV_TOTAL`, `INV_PRSN_NAME`, `DISCOUNT`, `INV_CLNT` , `INV_PAID`, `INV_FLAG`, `INV_CRNTBLNCE`, `INV_USER_ID`) VALUES ('" + invoiceCodeComboBox.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + invoiceFormNo + "', '" + Convert.ToDouble(netTotalInvoicePrice.Text) + "' , '" + clientNameComboBox.Text + "' , '" + Convert.ToDouble(DiscoutTextBox.Text) + "' , '" + selected + "' , '" + payingValue + "' , " + payingWay + " , '" + (-1* Convert.ToDouble(clientBalanceTextBox.Text) )+ "' , '" + Varibles.getUserId() + "' );";

                }


                Varibles.setConnection();
                cmd = Varibles.getCommand();




                cmd.CommandText = q;


                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Varibles.closeConnection();
                return;
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();


                    String sqlCommand = "INSERT INTO `merp`.`inv_prod_rel` (`INVPROD_PRD_ID`, `INVPROD_INV_ID`, `INVPROD_INVTYPE_ID` , `INVPROD_COUNT`, `INVPROD_PRICE`) VALUES ('" + Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) + "', '" + Convert.ToInt32(invoiceCodeComboBox.Text) + "', '" + invoiceFormNo + "'  , '" + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) + "', '" + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) + "');";

                    cmd.CommandText = sqlCommand;


                    cmd.ExecuteNonQuery();

                    if (!listOfItems.Contains(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)))
                    {
                        listOfItems.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    Varibles.closeConnection();
                }




                try
                {
                    List<StockItem> stockItemsList = new List<StockItem>();
                    int pr_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                    double pr_price = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                    int pr_balance = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    //String pr_name = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);

                    Varibles.setConnection();
                    cmd = Varibles.getCommand();
                    double stock_price = 0;
                    int stock_balance = 0;
                    try
                    {
                        String query = "SELECT * FROM stock where stock.prod_id = '" + pr_id + "' ORDER BY stock.buy_price ASC ";

                        cmd.CommandText = query;

                        reader = cmd.ExecuteReader();

                        
                        
                        while (reader.Read())
                        {

                            stock_price = reader.GetDouble("buy_price");
                            stock_balance = reader.GetInt32("count");

                            StockItem st = new StockItem(stock_balance,stock_price);
                            stockItemsList.Add(st);

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }finally
                    {
                        reader.Close();
                    }

                    bool finishReader = false;
                    for (int ii = 0; ii < stockItemsList.Count; ii++)
                    {
                        int ProdCurrentBlnc = getItemBalance2(pr_id);
                        StockItem st = stockItemsList[ii];
                        stock_balance = st.getCount();
                        stock_price = st.getBuyPrice();

                        int currentBlnc = 0;
                        int soldCount = 0;

                        if (pr_balance > stock_balance)
                        {
                            currentBlnc = stock_balance;
                            pr_balance -= stock_balance;
                            deleteFromStock(pr_id, stock_price);

                        }
                        else
                        {
                            currentBlnc = pr_balance;
                            int new_balance = countInStock(pr_id, stock_price) - pr_balance;

                            if (new_balance == 0)
                            {
                                deleteFromStock(pr_id, stock_price);
                            }
                            else
                            {
                                updateStock(pr_id, new_balance, stock_price);
                            }

                            finishReader = true;
                        }
                        soldCount = currentBlnc;
                        if (isInSold(pr_id, stock_price))
                        {
                            soldCount += countInSold(pr_id, stock_price);

                            updateSold(pr_id, soldCount, stock_price);

                        }
                        else
                        {
                            insertInSold(pr_id, soldCount, stock_price);
                        }


                        String desc = "فاتورة بيع رقم - " +
                            invoiceCodeComboBox.Text + " - " +
                            "للعميل - " +
                            clientNameComboBox.Text + " - " +
                            "للصنف - " +
                            Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) + " / " +
                            Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) + " - " +
                            "بكمية - " +
                            currentBlnc+ " - ";


                        inv.addToLog(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), 0, currentBlnc, dateTimePicker1.Value, desc, "فاتورة بيع", Varibles.user_id, Convert.ToInt32(invoiceCodeComboBox.Text), stock_price, pr_price, invoiceFormNo, ProdCurrentBlnc);

                        if (finishReader)
                        {
                            break;
                        }
                    }

                    



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            try
            {
                for (int i = 0; i < listOfItems.Count; i++)
                {
                    int itemId = listOfItems[i];

                    int itemBalance = getItemBalance(itemId);

                    int itemQuantity = getItemQuantity(itemId, 0);

                    int itemRemains = itemBalance - itemQuantity;

                    try
                    {
                        Varibles.setConnection();
                        cmd = Varibles.getCommand();


                        String sqlCommand = "UPDATE `merp`.`products` SET `PRD_BALANCE` = '" + itemRemains + "' WHERE `PRD_ID` = '" + itemId + "';";

                        cmd.CommandText = sqlCommand;


                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Varibles.closeConnection();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            if (payingWay == 1)
            {
                try
                {
                    double toBePayed = Convert.ToDouble(netTotalInvoicePrice.Text) - payingValue;

                    double paymentOnHim = (-1 * Convert.ToDouble(clientBalanceTextBox.Text)) - toBePayed;

                    Varibles.setConnection();
                    cmd = Varibles.getCommand();


                    String sqlCommand = "UPDATE `merp`.`clients` SET `CLNT_BLNCE`= '" + paymentOnHim + "' WHERE `CLT_ID`= '" + selected + "' ;";

                    cmd.CommandText = sqlCommand;


                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Varibles.closeConnection();
                }
            }

            try
            {
                String desc = "فاتورة بيع رقم - " +
                        invoiceCodeComboBox.Text + " - " +
                        "للعميل - " +
                        clientNameComboBox.Text + " - ";

                TreasuryEntry tr = new TreasuryEntry();

                tr.addToTreasury(payingValue, 0, dateTimePicker1.Value, desc, "فاتورة بيع", TreasuryEntry.TE_IN, 0, selected, (-1 * Convert.ToDouble(clientBalanceTextBox.Text)));


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("تم حفظ الفاتورة بنجاح");
            enableAll(false);
            printInvoiceBtn.Enabled = true;

        }

        private bool isInStock(int prdId)
        {
            int count = 0;
            try
            {
                String query = "SELECT COUNT(*) AS count FROM stock where stock.prod_id = '" + prdId + "' ";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("count");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }


            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private Int32 getMinBarcode()
        {
            String count = "";
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT MIN(LENGTH(PRD_BAR_CODE)) AS min FROM merp.products";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetString("min");

                }
            }
            catch (Exception ex)
            {
                count = "";
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();
            }


            if (count.Count() == 0)
            {
                return 0;
            }
            else
            {
                return count.Count();
            }

        }

        private int balanceInStock(int prdId)
        {

            int count = 0;
            try
            {
                String query = "SELECT SUM(stock.count) AS count FROM stock where stock.prod_id = '" + prdId + "' ";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("count");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }

            return count;


        }

        private int countInStock(int prdId, double prdBuyPrice)
        {

            int count = 0;
            try
            {
                String query = "SELECT stock.count AS count FROM stock where stock.prod_id = '" + prdId + "' AND stock.buy_price = '" + prdBuyPrice + "'";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("count");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }

            return count;


        }


        private void deleteFromStock(int prdId, double prdBuyPrice)
        {

            String query = "Delete From stock where stock.prod_id = '" + prdId + "' AND stock.buy_price = '" + prdBuyPrice + "'";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();


        }
        private void updateStock(int prdId, int prdBalance, double prdBuyPrice)
        {

            String query = "Update stock set stock.count = '" + prdBalance + "' where stock.prod_id = '" + prdId + "' AND stock.buy_price = '" + prdBuyPrice + "'";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

        }

        private void insertInSold(int prdId, int prdBalance, double prdBuyPrice)
        {
            cmd = Varibles.getCommand();

            String query = "Insert Into sold_items (sold_items.prod_id, sold_items.count , sold_items.buy_price ) " +
            "VALUES ( " + prdId + " , " + prdBalance + " , "
                        + prdBuyPrice + " )";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();


        }

        private void updateSold(int prdId, int prdBalance, double prdBuyPrice)
        {

            String query = "Update sold_items set sold_items.count = '" + prdBalance + "' where sold_items.prod_id = '" + prdId + "' AND sold_items.buy_price = '" + prdBuyPrice + "'";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

        }

        private bool isInSold(int prdId, double prdBuyPrice)
        {
            int count = 0;
            try
            {
                String query = "SELECT COUNT(*) AS count FROM sold_items where sold_items.prod_id = '" + prdId + "' AND sold_items.buy_price = '" + prdBuyPrice + "'";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("count");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }


            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private int countInSold(int prdId, double prdBuyPrice)
        {

            int count = 0;
            try
            {
                String query = "SELECT sold_items.count AS count FROM sold_items where sold_items.prod_id = '" + prdId + "' AND sold_items.buy_price = '" + prdBuyPrice + "'";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("count");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }

            return count;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            focusAndClear();
        }

       
        private void barcodeTB_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (Convert.ToString(barcodeTB.Text) != "")
                {
                    if ((barcodeTB.Text).Count() >= MinLength )
                    {
                        barcodeFlag = true;
                        fillAutomatic();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }*/
        }

        private void focusAndClear()
        {
            this.ActiveControl = barcodeTB;
            barcodeTB.Text = "";
        }

        private void fillAutomatic()
        {

            String prodName = "", prodType = "";
            if (barcodeFlag)
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();


                String barcode = barcodeTB.Text;
                try
                {
                    String query = "SELECT * FROM merp.products , merp.prod_types WHERE PRD_BAR_CODE= '" + barcode + "' AND PRD_TYPE_ID=PRDTYP_ID ";

                    cmd.CommandText = query;

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        prodName = reader.GetString("PRD_NAME");
                        prodType = reader.GetString("PRDTYP_NAME");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader.Close();
                    Varibles.closeConnection();
                }
                productTypeComboBox.Text = prodType;

                productNameComboBox.Text = prodName;
            }
        }
        DateTime lastKeyPress = DateTime.Now;
        char a = ' ';
        bool tf = false;
       /* private void SellInvoicesForm_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (((TimeSpan)(DateTime.Now - lastKeyPress)).TotalMilliseconds < 20)
            {
                if(!tf)
                {
                    /*try
                    {
                       String ss = this.ActiveControl.Text;
                       ss = ss.Substring(2, ss.Length - 1);
                       this.ActiveControl.Text = ss;
                    }catch(Exception ex)
                    {

                    }
                    this.ActiveControl = barcodeTB;
                    temp = "";

                    temp += a;
                    tf = true;
                }
                temp += e.KeyChar;
            }else
            {
                a = e.KeyChar;
                tf = false;
            }
            barcodeTB.Text = temp;
            lastKeyPress = DateTime.Now;
        
        } */

        /*private void keypressed(Object o, KeyPressEventArgs e)
        {
            if (barcodeFlag)
            {
                if (((TimeSpan)(DateTime.Now - lastKeyPress)).TotalMilliseconds < 10)
                {
                    barcodeTB.Text += e.KeyChar;
                }
                lastKeyPress = DateTime.Now;
            }
        }*/




        private void printProfitReport()
        {
            try
            {
                
                string sPath = System.IO.Path.GetTempFileName();
                System.IO.File.WriteAllBytes(sPath, Properties.Resources.SaleReciept);
                System.IO.FileInfo template = new System.IO.FileInfo(sPath);
                ExcelTemplate = xlApp.Workbooks.Open(template.FullName);
                xlWorkSheet = ExcelTemplate.Worksheets[1];



                xlWorkSheet.Cells[9, 6] = dateTimePicker1.Value.ToShortDateString();
                xlWorkSheet.Cells[10, 6] = clientNameComboBox.Text;
               
               
                int i = 14;

                int firstCol = 3;
                int lastCol = 8;
                
                for (int ii = 0; ii < dataGridView1.Rows.Count; ii++)
                {
                    DataGridViewRow tempRow = dataGridView1.Rows[ii];
                    int cell = 8;
                    for (int j = 0; j < tempRow.Cells.Count; j++ )
                    {

                        xlWorkSheet.Cells[i, cell].Value =  tempRow.Cells[j].Value;
                         


                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = 2d;
                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = 2d;
                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = 2d;
                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 2d;


                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].Borders.Color = System.Drawing.ColorTranslator.ToOle(Color.Black);


                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].WrapText = true;



                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                        xlWorkSheet.Range[xlWorkSheet.Cells[i, firstCol], xlWorkSheet.Cells[i, lastCol]].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;


                        cell--;    
                    }
                    i++;
                    
                }
                int initial1=24, initial2=26;

                xlWorkSheet.Range[ xlWorkSheet.Cells[i + 9, 7], xlWorkSheet.Cells[i + 9, 7]].Font.Size = 14;
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 9, 7], xlWorkSheet.Cells[i + 9, 7]].WrapText = true;
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 9, 7], xlWorkSheet.Cells[i + 9, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                xlWorkSheet.Cells[i + 9, 7] = netTotalInvoicePrice.Text;
               
               
                
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 9, 8], xlWorkSheet.Cells[i + 9, 8]].Font.Size = 14;
                xlWorkSheet.Cells[i + 9, 8] = "الصافي :";

                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 4], xlWorkSheet.Cells[i + 5, 4]].Font.Size = 14;
                xlWorkSheet.Cells[i + 5, 4] = "الخصم :";

                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 3], xlWorkSheet.Cells[i + 5, 3]].Font.Size = 14;
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 3], xlWorkSheet.Cells[i + 5, 3]].WrapText = true;
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 3], xlWorkSheet.Cells[i + 5, 3]].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                xlWorkSheet.Cells[i+5, 3] = DiscoutTextBox.Text;

                
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 6], xlWorkSheet.Cells[i + 5, 6]].Font.Size = 14;
                xlWorkSheet.Cells[i + 5, 6] = "طريقة الدفع :";

                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 5], xlWorkSheet.Cells[i + 5, 5]].Font.Size = 14;
                xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 5], xlWorkSheet.Cells[i + 5, 5]].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    if (payNowRadioButton.Checked)
                    {
                        xlWorkSheet.Cells[i+5, 5] = payNowRadioButton.Text;
                    }
                    else
                    {
                        xlWorkSheet.Cells[i+5, 5] = payAfterRadioButton.Text;

                        xlWorkSheet.Range[xlWorkSheet.Cells[i + 7, 8], xlWorkSheet.Cells[i + 7, 8]].Font.Size = 14;
                        xlWorkSheet.Cells[i + 7, 8] = "المدفوع :";

                        xlWorkSheet.Range[xlWorkSheet.Cells[i + 7, 7], xlWorkSheet.Cells[i + 7, 7]].Font.Size = 14;
                        xlWorkSheet.Range[xlWorkSheet.Cells[i + 7, 7], xlWorkSheet.Cells[i + 7, 7]].WrapText = true;
                        xlWorkSheet.Range[xlWorkSheet.Cells[i + 7, 7], xlWorkSheet.Cells[i + 7, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                        xlWorkSheet.Cells[i + 7, 7] = payingValueTB.Text;
                    }

                    
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 7], xlWorkSheet.Cells[i + 5, 7]].Font.Size = 14;
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 7], xlWorkSheet.Cells[i + 5, 7]].WrapText=true;
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 7], xlWorkSheet.Cells[i + 5, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Cells[i + 5, 7] = totalInvoicePriceLBL.Text;

                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 5, 8], xlWorkSheet.Cells[i + 5, 8]].Font.Size = 14;
                    xlWorkSheet.Cells[i + 5, 8] = "المجموع :";

                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 11, 2], xlWorkSheet.Cells[i + 11, 4]].Select();
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 11, 2], xlWorkSheet.Cells[i + 11, 4]].Merge(true);
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 11, 2], xlWorkSheet.Cells[i + 11,4]].Font.Size = 14;
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 11, 2], xlWorkSheet.Cells[i + 11, 4]].WrapText = true;
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 11, 2], xlWorkSheet.Cells[i + 11, 4]].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
                    xlWorkSheet.Range[xlWorkSheet.Cells[i + 11, 2], xlWorkSheet.Cells[i + 11, 4]].Value = "شكرا لتعاملكم معنا";
                xlWorkSheet.PrintOutEx();
                ExcelTemplate.Close(false);
                xlApp.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printInvoiceBtn_Click(object sender, EventArgs e)
        {
            printProfitReport();
        }

        private int getItemBalance2(int id)
        {
            try
            {

                int prdID = id;

                String query = "SELECT sum(stock.count) AS PRD_BALANCE FROM merp.stock where stock.prod_id = " + prdID + " ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                int itemBlnc = 0;
                while (reader.Read())
                {
                    try
                    {
                        itemBlnc = reader.GetInt32("PRD_BALANCE");
                    }
                    catch (Exception ex)
                    {
                        itemBlnc = 0;
                    }
                }

                return itemBlnc;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;

            }
            finally
            {
                reader.Close();
            }

            
        }

        private void barcodeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                barcodeFlag = true;
                fillAutomatic();
            }
        }

    }
}