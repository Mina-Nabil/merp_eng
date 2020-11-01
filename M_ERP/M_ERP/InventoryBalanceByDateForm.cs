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

namespace M_ERP
{
    public partial class InventoryBalanceByDateForm : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        bool allProducts = false;

        
        int sumBLNCE;

        public InventoryBalanceByDateForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            fillProdTypes();

            refreshSums();

            cmbbx_ProdType.SelectedIndex = -1;
            cmbbx_ProdName.SelectedIndex = -1;
        }

        private void refreshSums()
        {
            sumBLNCE = 0;

        }

        private void InventoryBalanceByDateForm_Load(object sender, EventArgs e)
        {

        }

        private void fillProdTypes()
        {
            try
            {


                String sqlCommand = "SELECT PRDTYP_ID, PRDTYP_NAME FROM merp.prod_types";

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                cmbbx_ProdType.DisplayMember = "PRDTYP_NAME";
                cmbbx_ProdType.ValueMember = "PRDTYP_ID";
                cmbbx_ProdType.DataSource = ds.Tables[0];


                cmbbx_ProdType.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbbx_ProdType.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbbx_ProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillByType();
        }

        private void fillByType()
        {
            chbx_All.Checked = false;
            dispAllnv.Checked = false;

            dGridV_prods.Rows.Clear();

            DateTime date1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 59, 59);

            String date2 = date1.ToString("yyyy/MM/dd HH:mm:ss");


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);
            String query = "SELECT prd_id , PRDTYP_NAME ,  prd_name , INVLOG_INCOUNT , INVLOG_OUTCOUNT , prd_current_blnc  , merp.prod_types.is_supplies " +
                                " FROM merp.inventory_log T1 , merp.products   , merp.prod_types " +
                                " WHERE INVLOG_ID = ( " +
                                " SELECT max(INVLOG_ID) " +
                                " FROM merp.inventory_log T3 " +
                                "  WHERE T1.INVLOG_PROD_ID=T3.INVLOG_PROD_ID AND INVLOG_DATE <= '" + date2 + "' " +
                                " ) " +
                                " AND merp.products.PRD_ID = T1.INVLOG_PROD_ID " +
                                " AND merp.prod_types.PRDTYP_ID = products.PRD_TYPE_ID AND PRDTYP_ID = '" + prodTypeID + "' ;";

            fillProdName();

            cmd.CommandText = query;

            reader = cmd.ExecuteReader();


            String prdName, prdType;
            int prdID;
            int logIN, logOUT, currentBlnc, diff;
            bool is_supplies;
            refreshSums();

            while (reader.Read())
            {
                prdName = reader.GetString("PRD_NAME");
                prdID = reader.GetInt32("PRD_ID");
                prdType = reader.GetString("PRDTYP_NAME");

                logIN = reader.GetInt32("INVLOG_INCOUNT");
                logOUT = reader.GetInt32("INVLOG_OUTCOUNT");
                currentBlnc = reader.GetInt32("prd_current_blnc");
                is_supplies = reader.GetBoolean("is_supplies");

                diff = currentBlnc - logOUT + logIN;

                sumBLNCE = sumBLNCE + diff;

                dGridV_prods.Rows.Add(prdID, prdType, prdName, diff, is_supplies);
            }

            updateSums();
            reader.Close();

        }

        private void fillProdName()
        {
            try
            {
                if (chbx_All.Checked == false)
                {
                    int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);

                    String sqlCommand = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_WHLSALEPRICE, PRD_SCTRPRICE, PRD_BUYPRICE " +
                               " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_TYPE_ID = " + prodTypeID;

                    cmd.CommandText = sqlCommand;

                    MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    cmd.ExecuteNonQuery();

                    cmbbx_ProdName.DisplayMember = "PRD_NAME";
                    cmbbx_ProdName.ValueMember = "PRD_ID";
                    cmbbx_ProdName.DataSource = ds.Tables[0];


                    cmbbx_ProdName.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cmbbx_ProdName.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cmbbx_ProdName.SelectedIndex = -1;
                }
                else
                {

                    int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);

                    String sqlCommand = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_WHLSALEPRICE, PRD_SCTRPRICE, PRD_BUYPRICE " +
                               " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID ";

                    cmd.CommandText = sqlCommand;

                    MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    cmd.ExecuteNonQuery();

                    cmbbx_ProdName.DisplayMember = "PRD_NAME";
                    cmbbx_ProdName.ValueMember = "PRD_ID";
                    cmbbx_ProdName.DataSource = ds.Tables[0];


                    cmbbx_ProdName.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cmbbx_ProdName.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cmbbx_ProdName.SelectedIndex = -1;

                    if (allProducts)
                    {
                        allProducts = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void updateSums()
        {
            txt_BLNCE.Text = Convert.ToString(sumBLNCE);
           
        }

        private void cmbbx_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillByName();
        }

        private void fillByName()
        {
            if (allProducts)
            {
            }
            else
            {
                chbx_All.Checked = false;
                dispAllnv.Checked = false;

                dGridV_prods.Rows.Clear();
                String prodName = Convert.ToString(this.cmbbx_ProdName.Text);

                DateTime date1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 59, 59);

                String date2 = date1.ToString("yyyy-MM-dd HH:mm:ss");

                String query = "SELECT prd_id , PRDTYP_NAME ,  prd_name , INVLOG_INCOUNT , INVLOG_OUTCOUNT , prd_current_blnc  , merp.prod_types.is_supplies " +
                                " FROM merp.inventory_log T1 , merp.products   , merp.prod_types " +
                                " WHERE INVLOG_ID = ( " +
                                " SELECT max(INVLOG_ID) " +
                                " FROM merp.inventory_log T3 " +
                                "  WHERE T1.INVLOG_PROD_ID=T3.INVLOG_PROD_ID AND INVLOG_DATE <= '" + date2 + "' " +
                                " ) " +
                                " AND merp.products.PRD_ID = T1.INVLOG_PROD_ID " +
                                " AND merp.prod_types.PRDTYP_ID = products.PRD_TYPE_ID AND prd_name ='" + prodName + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();



                String prdName, prdType;
                int prdID;
                int logIN, logOUT, currentBlnc, diff;
                bool is_supplies;
                refreshSums();

                while (reader.Read())
                {
                    prdName = reader.GetString("PRD_NAME");
                    prdID = reader.GetInt32("PRD_ID");
                    prdType = reader.GetString("PRDTYP_NAME");

                    logIN = reader.GetInt32("INVLOG_INCOUNT");
                    logOUT = reader.GetInt32("INVLOG_OUTCOUNT");
                    currentBlnc = reader.GetInt32("prd_current_blnc");
                    is_supplies = reader.GetBoolean("is_supplies");

                    diff = currentBlnc - logOUT + logIN;



                    sumBLNCE = sumBLNCE + diff;

                    dGridV_prods.Rows.Add(prdID, prdType, prdName, diff,is_supplies);
                }

                updateSums();
                reader.Close();

            }

        }

        private void dispAllnv_CheckedChanged(object sender, EventArgs e)
        {
            if (dispAllnv.Checked)
            {
                cmbbx_ProdName.SelectedIndex = -1;
                cmbbx_ProdType.SelectedIndex = -1;

                dispAllnv.Checked = true;
                fillAllInventory();
            }
        }

        private void fillAllInventory()
        {

            try
            {
                dGridV_prods.Rows.Clear();

                DateTime date1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 23, 59, 59);

                String date2 = date1.ToString("yyyy/MM/dd HH:mm:ss");


                String query = "SELECT prd_id , PRDTYP_NAME ,  prd_name , INVLOG_INCOUNT , INVLOG_OUTCOUNT , prd_current_blnc , merp.prod_types.is_supplies " +
                            " FROM merp.inventory_log T1 , merp.products   , merp.prod_types " +
                            " WHERE INVLOG_ID = ( " +
                            " SELECT max(INVLOG_ID) " +
                            " FROM merp.inventory_log T3 " +
                            "  WHERE T1.INVLOG_PROD_ID=T3.INVLOG_PROD_ID AND INVLOG_DATE <= '" + date2 + "' " +
                            " ) " +
                            " AND merp.products.PRD_ID = T1.INVLOG_PROD_ID " +
                            " AND merp.prod_types.PRDTYP_ID = products.PRD_TYPE_ID ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                String prdName, prdType;
                int prdID;
                int logIN, logOUT, currentBlnc, diff;
                bool is_supplies;
                refreshSums();

                while (reader.Read())
                {
                    prdName = reader.GetString("PRD_NAME");
                    prdID = reader.GetInt32("PRD_ID");
                    prdType = reader.GetString("PRDTYP_NAME");

                    logIN = reader.GetInt32("INVLOG_INCOUNT");
                    logOUT = reader.GetInt32("INVLOG_OUTCOUNT");
                    currentBlnc = reader.GetInt32("prd_current_blnc");
                    is_supplies = reader.GetBoolean("is_supplies");

                    diff = currentBlnc - logOUT + logIN;



                    sumBLNCE = sumBLNCE + diff;

                    dGridV_prods.Rows.Add(prdID, prdType, prdName, diff, is_supplies);
                }

                updateSums();
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

        private void chbx_All_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbx_All.Checked)
                {
                    allProducts = true;
                    fillProdName();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (chbx_All.Checked)
            {
                fillAllInventory();
            }else if(cmbbx_ProdName.SelectedIndex != -1)
            {
                fillByName();
            }
            else if (cmbbx_ProdType.SelectedIndex != -1)
            {
                fillByType();
            }
        }



    }
}
