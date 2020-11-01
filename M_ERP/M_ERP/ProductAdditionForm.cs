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
    public partial class ProductAdditionForm : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;

        int prd_id = 0;
        public ProductAdditionForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            this.MaximizeBox = false;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            fillProdTypes();

            cmbbx_NewProdType.SelectedIndex = -1;

            showAll(false);

            loadCode();

        }

        private void loadCode()
        {
            

            String query = "SELECT max(PRD_ID) as count FROM merp.products;";

            cmd.CommandText = query;

            reader = cmd.ExecuteReader();

            int id = 0;
            while (reader.Read())
            {
                try
                {
                    id = reader.GetInt32("count");
                }
                catch (Exception ex)
                {
                    id = 0;
                }
            }

            id++;

            prdtxtbx_ID.Text = "" + id;

            reader.Close();
        }


        private void refreshForm() {

            this.txtbx_blnce.Text = "0";
            this.txtbx_buyPrice.Text = "0";
            this.prdtxtbx_ID.Text = "";
            this.txtbx_ItemProfit.Text = "0";
            this.txtbx_limit.Text = "0";
            this.txtbx_PrdDsc.Text = "";
            this.txtbx_SctorSlPrice.Text = "0";
            this.txtbx_WhlSlPrice.Text = "0";
            this.itemNameTextBox.Text = "";
            this.barcodeTB.Text = "";
            loadCode();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmbbx_NewProdType.Text == "") { cmbbx_NewProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (itemNameTextBox.Text == "") { itemNameTextBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            int prdTypeId = Convert.ToInt32(cmbbx_NewProdType.SelectedValue);
            String prdName = itemNameTextBox.Text;

            try
            {
                
                if (checkIsProdFound(prdTypeId,prdName))
                {
                    MessageBox.Show("هذا الصنف موجود بالفعل");
                    return;
                }
                else
                {
                    
                    saveNewProdData();
                    insertInStock();
                    MessageBox.Show("تم اضـــافــة البيانــات بنجاح ");
                    refreshForm();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("تاكد من البيانات \n " + ex.Message);
            }
        }


        private int getMaxID()
        {
            int count = 0;

            try
            {


                String query = "SELECT Max(PRD_ID) as maxProd FROM merp.products ";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("maxProd");

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

                cmbbx_NewProdType.DisplayMember = "PRDTYP_NAME";
                cmbbx_NewProdType.ValueMember = "PRDTYP_ID";
                cmbbx_NewProdType.DataSource = ds.Tables[0];



                cmbbx_NewProdType.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbbx_NewProdType.AutoCompleteSource = AutoCompleteSource.ListItems;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void saveNewProdData()
        {
            int prdTypeId, prdLimit, prdBalance;
            String barcode = "";
            double prdBuyPrice, prdWhlPrice, prdSctrPrice;
            String prdName, prdDesc;

           
            prdTypeId = Convert.ToInt32(cmbbx_NewProdType.SelectedValue);
            prdLimit = Convert.ToInt32(txtbx_limit.Text);
            prdBalance = Convert.ToInt32(txtbx_blnce.Text);
            prdBuyPrice = Convert.ToDouble(txtbx_buyPrice.Text);
            prdWhlPrice = Convert.ToDouble(txtbx_WhlSlPrice.Text);
            prdSctrPrice = Convert.ToDouble(txtbx_SctorSlPrice.Text);
            prdName = itemNameTextBox.Text;
            prdDesc = txtbx_PrdDsc.Text;
            barcode = Convert.ToString(barcodeTB.Text);
            String query;
            if (barcode != "")
            {
                query = " Insert Into products (products.PRD_NAME, products.PRD_TYPE_ID, products.PRD_LIMIT, products.PRD_BUYPRICE, products.PRD_WHLSALEPRICE, " +
                              " products.PRD_SCTRPRICE, products.PRD_DESC, products.PRD_BALANCE , products.PRD_BAR_CODE ) VALUES ( '" + prdName + "' , " + prdTypeId + " , " + prdLimit + ","
                               + prdBuyPrice + "," + prdWhlPrice + " ," + prdSctrPrice + ", '" + prdDesc + "' ," + prdBalance + "," + barcode + " )";
            }
            else
            {
                query = " Insert Into products (products.PRD_NAME, products.PRD_TYPE_ID, products.PRD_LIMIT, products.PRD_BUYPRICE, products.PRD_WHLSALEPRICE, " +
                             " products.PRD_SCTRPRICE, products.PRD_DESC, products.PRD_BALANCE ) VALUES ( '" + prdName + "' , " + prdTypeId + " , " + prdLimit + ","
                              + prdBuyPrice + "," + prdWhlPrice + " ," + prdSctrPrice + ", '" + prdDesc + "' ," + prdBalance + " )";
            }
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();

        }

        private void insertInStock()
        {
            prd_id = getMaxID();
            int  prdBalance;
            double prdBuyPrice;


            prdBalance = Convert.ToInt32(txtbx_blnce.Text);
            prdBuyPrice = Convert.ToDouble(txtbx_buyPrice.Text);

            if (prdBalance > 0)
            {
                String query = " Insert Into stock (stock.prod_id, stock.count , stock.buy_price ) "+
                "VALUES ( "+ prd_id + " , " + prdBalance + " , "
                            + prdBuyPrice + " )";

                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }


            

        }

        private bool checkIsProdFound(int prdId, String prdName)
        {
            int count = 0;

            try
            {


                String query = "SELECT count(*) as countProd FROM merp.products WHERE PRD_TYPE_ID = '" + prdId + "' AND PRD_NAME LIKE  '" + prdName + "' ";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("countProd");

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


        private void ProductAdditionForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbbx_NewProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            showAll(true);
        }

        private void showAll(bool tf)
        {
            itemNameTextBox.Enabled = tf;
            txtbx_buyPrice.Enabled = tf;
            txtbx_WhlSlPrice.Enabled = tf;
            txtbx_SctorSlPrice.Enabled = tf;
            txtbx_blnce.Enabled = tf;
            txtbx_limit.Enabled = tf;
            txtbx_PrdDsc.Enabled = tf;
        }

        private void cmbbx_NewProdType_TextChanged(object sender, EventArgs e)
        {
            showAll(false);
        }

        private void txtbx_SctorSlPrice_TextChanged(object sender, EventArgs e)
        {
            loadTotalPrice();
        }

        private void loadTotalPrice()
        {
            double total = 0;
            double itemBuyPrice = 0;
            double itemSellPrice = 0;

            try
            {
                try
                {
                    itemBuyPrice = Convert.ToDouble(txtbx_buyPrice.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ فى سعر الشراء");
                }

                try
                {
                    itemSellPrice = Convert.ToDouble(txtbx_SctorSlPrice.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ فى سعر البيع القطاعى");
                }

                if (itemSellPrice < 0)
                {
                    MessageBox.Show("سعر الشراء اقل من صفر");
                }

                if (itemBuyPrice < 0)
                {
                    MessageBox.Show("سعر البيع القطاعى اقل من صفر");
                }

                total = itemSellPrice - itemBuyPrice;

                

                txtbx_ItemProfit.Text = total.ToString("0.00");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void txtbx_buyPrice_TextChanged(object sender, EventArgs e)
        {
            loadTotalPrice();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void barcodeTB_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
