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
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;

namespace M_ERP
{
    public partial class SalesReportForm : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;
        double totalSale, total_retun_sale, total_diff;
        double discount, discount_return;

        int SellType = 1;
        int SellReturnType = 3;

        public SalesReportForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();
          
                
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            allInvoicesRadioButton.Checked = true;
            allPaymentRadioBtn.Checked = true;
            populateGrid();
        }




        private void DiscountAll1()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {



                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis" +
                           " FROM merp.invoices " +
                           "WHERE    INV_TYPE_ID = '" + SellType + "' AND INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        discount = reader.GetDouble("sum_dis");
                    }
                    catch
                    {

                    }
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
        }

        private void DiscountAll2()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {



                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis" +
                           " FROM merp.invoices " +
                           "WHERE    INV_TYPE_ID = '" + SellReturnType + "' AND INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        discount_return = reader.GetDouble("sum_dis");
                    }
                    catch
                    {

                    }
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
        }

        private void DiscountSaleAndAll()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {



                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis" +
                           " FROM merp.invoices " +
                           "WHERE (INV_FLAG=1 OR INV_FLAG=0) AND INV_TYPE_ID = '" + SellType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        discount = reader.GetDouble("sum_dis");
                    }
                    catch
                    {

                    }
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
        }

        private void DiscountReturnSaleAll()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE (INV_FLAG=1 OR INV_FLAG=0) AND  INV_TYPE_ID = '" + SellReturnType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount_return = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountAllCash1()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=0 AND  INV_TYPE_ID = '" +SellType+"' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountAllCash2()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=0 AND  INV_TYPE_ID = '" + SellReturnType +"' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount_return = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountAllLater1()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=1 AND  INV_TYPE_ID = '" + SellType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountAllLater2()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=1 AND  INV_TYPE_ID = '" + SellReturnType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount_return = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountSaleCash()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=0 AND  INV_TYPE_ID = '" + SellType +  "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountSaleLater()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=1 AND  INV_TYPE_ID = '" + SellType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountReturnSaleCash()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=0 AND  INV_TYPE_ID = '" + SellReturnType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount_return = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }

        private void DiscountReturnSaleLater()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT COALESCE(SUM(DISCOUNT), 0) AS sum_dis " +
                                          " FROM merp.invoices " +
                                          "WHERE INV_FLAG=1 AND  INV_TYPE_ID = '" + SellReturnType + "' AND  INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                                           "' AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    discount_return = reader.GetDouble("sum_dis");


                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }
        }
       
        private void FilterByInvTypeLaterAndAll()
        {



            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {
                


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price" +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID   AND invoices.INV_FLAG= '1'  AND (inventory_log.invoice_type = '" + SellType + "' OR inventory_log.invoice_type = '" + SellReturnType + "') AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FilterByInvTypeLaterAndSaleOnly()
        {



            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID  AND invoices.INV_FLAG= '1'  AND inventory_log.invoice_type = '" + SellType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetDiscountSalesAndReturns()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);



        }


        private void FilterByInvTypeLaterAndReturnSaleOnly()
        {




            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID  AND invoices.INV_FLAG= '1'  AND inventory_log.invoice_type = '" + SellReturnType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'   ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FilterByInvTypeCashAndAll()
        {



            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {
                


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID  AND invoices.INV_FLAG= '0'  AND (inventory_log.invoice_type = '" + SellType + "' OR inventory_log.invoice_type = '" + SellReturnType + "') AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FilterByInvTypeCashAndSaleOnly()
        {



            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID  AND invoices.INV_FLAG= '0'  AND inventory_log.invoice_type = '" + SellType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FilterByInvTypeCashAndReturnSaleOnly()
        {




            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID  AND invoices.INV_FLAG= '0'  AND inventory_log.invoice_type = '" + SellReturnType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'   ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FilterByInvTypeAllAndAll()
        {



            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price  " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID   AND (inventory_log.invoice_type = '" + SellType + "' OR inventory_log.invoice_type = '" + SellReturnType + "') AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FilterByInvTypeAllAndSaleOnly()
        {



            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID   AND inventory_log.invoice_type = '" + SellType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void FilterByInvTypeAllAndReturnSaleOnly()
        {


            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            try
            {


                String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                           "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                           "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price  " +
                           " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                           "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID = PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID   AND inventory_log.invoice_type = '" + SellReturnType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'   ORDER BY  INVLOG_DATE ASC ";

                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(query, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void populateGrid()
        {
            bool populateTF = true;
           
            if (allPaymentRadioBtn.Checked && allInvoicesRadioButton.Checked)
            {

                DiscountAll1();
                DiscountAll2();

              //  DiscountReturnSale();
                FilterByInvTypeAllAndAll();
                
            }
            else if (allPaymentRadioBtn.Checked && saleOnlyRadioBtn.Checked)
            {
                discount_return = 0;
                DiscountSaleAndAll();
                FilterByInvTypeAllAndSaleOnly();
            }
            else if (allPaymentRadioBtn.Checked && returnSaleRadioBtn.Checked)
            {
                discount = 0;
                DiscountReturnSaleAll();
                FilterByInvTypeAllAndReturnSaleOnly();
            }
            else if (cashRadioBtn.Checked && allInvoicesRadioButton.Checked)
            {
                DiscountAllCash1();
                DiscountAllCash2();
                FilterByInvTypeCashAndAll();
            }
            else if (cashRadioBtn.Checked && saleOnlyRadioBtn.Checked)
            {
                discount_return = 0;
                DiscountSaleCash();
                FilterByInvTypeCashAndSaleOnly();
            }
            else if (cashRadioBtn.Checked && returnSaleRadioBtn.Checked)
            {
                discount = 0;
                DiscountReturnSaleCash();
                FilterByInvTypeCashAndReturnSaleOnly();
            }
            else if (laterRadioBtn.Checked && allInvoicesRadioButton.Checked)
            {
                /////kan fi moshkla /////
                DiscountAllLater1();
                DiscountAllLater2();
                FilterByInvTypeLaterAndAll();
            }
            else if (laterRadioBtn.Checked && saleOnlyRadioBtn.Checked)
            {
                discount_return = 0;
                DiscountSaleLater();
                FilterByInvTypeLaterAndSaleOnly();
            }
            else if (laterRadioBtn.Checked && returnSaleRadioBtn.Checked)
            {
                discount = 0;
                DiscountReturnSaleLater();
                FilterByInvTypeLaterAndReturnSaleOnly();
            }
            totalSale = 0;
            total_retun_sale = 0;
            total_diff = 0;
            
            dGridV_InvenLog.Rows.Clear();
            
            if(populateTF)
            {
                try
                {

                    populateLog();
                    SaleBox.Text = Convert.ToString(totalSale);
                    returnSaleTB.Text = Convert.ToString(total_retun_sale);
                    netSaleTB.Text = Convert.ToString(total_diff);
                    try
                    {
                        SaleDiscount.Text = Convert.ToString(discount);
                        discountSaleReturn.Text = Convert.ToString(discount_return);
                    }
                    catch { 

                        }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show("Error\n" + ex.Message);

                }
                finally
                {
                reader.Close();
                }
            }
        }


        private void populateLog()
        {
            

            String prdName = "", prdType = "", logDesc = "";
            Double currentBuyPrice = 0, currentSellPrice = 0;
            DateTime logDate;
            Int32 prdID = 0, logIN = 0, logOUT = 0, logInvID = 0;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                prdName = reader.GetString("PRD_NAME");
                prdType = reader.GetString("PRDTYP_NAME");
                logDesc = reader.GetString("INVLOG_DESC");
                currentBuyPrice = reader.GetDouble("current_buy_price");
                currentSellPrice = reader.GetDouble("current_sell_price");
                logDate = reader.GetDateTime("INVLOG_DATE");
                prdID = reader.GetInt32("INVLOG_PROD_ID");
                logIN = reader.GetInt32("INVLOG_INCOUNT");
                logOUT = reader.GetInt32("INVLOG_OUTCOUNT");

                totalSale += (currentSellPrice * logOUT);
                total_retun_sale += (currentSellPrice * logIN);

                total_diff = totalSale - total_retun_sale - discount + discount_return;
               
                

                try
                {
                    logInvID = reader.GetInt32("INVLOG_INV_ID");
                }
                catch (SystemException ex) { }

                dGridV_InvenLog.Rows.Add(prdID, prdType, prdName, logOUT, logIN, currentSellPrice, currentBuyPrice, logInvID, logDate, logDesc);
                
            }
            reader.Close();
        }

      
       
       

        private void saleOnlyChkBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            populateGrid();

        }

        private void allRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
                
                populateGrid();               
            
        }

        private void cashRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
                populateGrid();
            
        }

        private void laterRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
                populateGrid();
            
        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            
            populateGrid();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
                populateGrid();
            
        }

        private void saleOnlyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
                populateGrid();
            
        }

        private void returnSaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
                populateGrid();
            
        }

        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // try
            //{
            //Set the left margin
            int iLeftMargin = e.MarginBounds.Left;
            //MessageBox.Show("" + iLeftMargin);
            //Set the top margin
            int iTopMargin = e.MarginBounds.Top;
            //Whether more pages have to print or not
            bool bMorePagesToPrint = false;
            int iTmpWidth = 0;

            //For the first page to print set the cell width and header height
            if (bFirstPage)
            {
                DataGridViewColumn tempCol;
                //DataGridViewColumn temp;

                //foreach (DataGridViewColumn GridCol in dGridV_InvenLog.Columns)
                //MessageBox.Show("Itmp loop");
                for (int w = (dGridV_InvenLog.Columns.Count - 1); w >= 0; w--)
                {
                    tempCol = dGridV_InvenLog.Columns[w];
                    //temp = dGridV_InvenLog.Columns[w];

                    iTmpWidth = (int)(Math.Floor((double)((double)tempCol.Width /
                                   (double)iTotalWidth * (double)iTotalWidth *
                                   ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                    //MessageBox.Show("iTMP" + iTmpWidth);
                    iHeaderHeight = (int)(e.Graphics.MeasureString(tempCol.HeaderText,
                                tempCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                    // Save width and height of headres
                    arrColumnLefts.Add(iLeftMargin);
                    arrColumnWidths.Add(iTmpWidth);
                    iLeftMargin += iTmpWidth;
                }
            }

            //Loop till all the grid rows not get printed

            while (iRow <= dGridV_InvenLog.Rows.Count - 1)
            {
                DataGridViewRow GridRow = dGridV_InvenLog.Rows[iRow];
                //Set the cell height
                iCellHeight = GridRow.Height + 5;
                int iCount = 9;
                //Check whether the current page settings allo more rows to print
                if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    bNewPage = true;
                    bFirstPage = false;
                    bMorePagesToPrint = true;
                    break;
                }
                else
                {
                    if (bNewPage)
                    {
                        //Draw Header
                        e.Graphics.DrawString("تقرير المبيعات", new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقرير المبيعات", new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        //Draw Date
                        e.Graphics.DrawString(strDate, new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                e.Graphics.MeasureString(strDate, new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقرير المبيعات", new Font(new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        iTopMargin = e.MarginBounds.Top;
                        foreach (DataGridViewColumn GridCol in dGridV_InvenLog.Columns)
                        {

                            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight));

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                            iCount--;

                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 9;
                    //Draw Columns Contents                
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {

                        if (Cel.Value != null)
                        {
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                        (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                        }
                        //MessageBox.Show("" + iCount);
                        //Drawing Cells Borders 
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                        iCount--;
                    }

                }
                iRow++;
                iTopMargin += iCellHeight;
            }

            //If more lines exist, print another page.
            if (bMorePagesToPrint)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            //}
            //catch (Exception exc)
            //{
            // MessageBox.Show(exc.Message, "2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Show();
            try
            {
                //MessageBox.Show("am in begin print");
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dGridV_InvenLog.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
                iTotalWidth = iTotalWidth - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "تقرير المبيعات";
                printDocument1.Print();
            }
        }

        private static Microsoft.Office.Interop.Excel.Workbook list_Excel;
        private static Microsoft.Office.Interop.Excel.Workbook list_export;

        private static Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        private static Excel.Worksheet xlWorkSheet;
        private static Excel.Worksheet Worksheet_export;
        public void ExportToExcel()
        {

            xlApp.DisplayAlerts = false;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                String date = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year;
                string filepath = fbd.SelectedPath + "\\المبيعات.xlsx";
                int i = 1;


                filepath = fbd.SelectedPath + "\\المبيعات" + "_" + date  + ".xls";

                list_export = xlApp.Workbooks.Add();
                Worksheet_export = list_export.Worksheets.Add();
                Worksheet_export.Name = "المبيعات";
                Worksheet_export.DisplayRightToLeft = true;

                Worksheet_export.Cells[1, 10] = "ملاحظات";
                Worksheet_export.Cells[1, 9] = "تاريخ";
                Worksheet_export.Cells[1, 8] = "رقم الفاتورة";
                Worksheet_export.Cells[1, 7] = "سعر الشراء";
                Worksheet_export.Cells[1, 6] = "سعر البيع";
                Worksheet_export.Cells[1, 5] = "وارد";
                Worksheet_export.Cells[1, 4] = "صادر";
                Worksheet_export.Cells[1, 3] = "اسم الصنف";
                Worksheet_export.Cells[1, 2] = "نوع الصنف";
                Worksheet_export.Cells[1, 1] = "كود الصنف";

                int iii = 2;
                for (int ii = 0; ii < dGridV_InvenLog.Rows.Count; ii++)
                {

                    DataGridViewRow tempRow = dGridV_InvenLog.Rows[ii];
                    int cell = 1;
                    for (int j = 0; j < tempRow.Cells.Count; j++)
                    {


                        Worksheet_export.Cells[iii, cell].Value = tempRow.Cells[j].Value;




                        cell++;

                    }

                    iii = iii + 1;
                }

                Worksheet_export.Columns.AutoFit();
                // Worksheet_export.Rows.AutoFit();
                list_export.SaveAs(filepath);

                xlApp.Quit();
                MessageBox.Show("تم حفظ الملف بنجاح");
            }
        }
    





        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void returnSaleTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }



    }
}
