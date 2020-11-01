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
    public partial class ItemCatalogeEdit : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;


        public ItemCatalogeEdit()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            this.MaximizeBox = false;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            fillProdTypes(); //Fill Prod Types Combobox
            cmbbx_ProdType.SelectedIndex = -1;


            fillProdTypes2();

            cmbbx_NewProdType.SelectedIndex = -1;


            btn_ChooseProd.Enabled = false;

            this.groupBox2.Enabled = false;
           
        }

    
        private void cmbbx_ProdType_SelectedIndexChanged(object sender, EventArgs e)
        {

            fillProdName();

            btn_ChooseProd.Enabled = false;

        }

        private void fillProdName()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void fillProdTypes2()
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



        private void fillProdForm() {

            String prodName = this.cmbbx_ProdName.Text;
            int prdID = Convert.ToInt32(this.cmbbx_ProdName.SelectedValue);
            int prdTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);
            String query = "SELECT  PRD_ID, PRD_NAME, PRD_TYPE_ID, PRD_LIMIT, " +
                           " PRD_BUYPRICE, PRD_WHLSALEPRICE, PRD_SCTRPRICE, PRD_DESC, PRD_BALANCE , PRDTYP_NAME , PRD_BAR_CODE FROM merp.products , merp.prod_types WHERE PRD_ID = '" + prdID + "' AND PRDTYP_ID = '" + prdTypeID + "'";
            Double wholeSalesPrice, sectorSalesPrice, buyPrice;

            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                buyPrice = reader.GetDouble(4);
                txtbx_ID.Text = Convert.ToString(reader.GetInt32(0));
                txtbx_buyPrice.Text = Convert.ToString(buyPrice);
                txtbx_blnce.Text = Convert.ToString(reader.GetDouble("PRD_BALANCE"));
                txtbx_limit.Text = Convert.ToString(reader.GetInt32("PRD_LIMIT"));
                txtbx_PrdDsc.Text = Convert.ToString(reader.GetString("PRD_DESC"));
                wholeSalesPrice = reader.GetDouble("PRD_WHLSALEPRICE");
                sectorSalesPrice = reader.GetDouble("PRD_SCTRPRICE");
                txtbx_WhlSlPrice.Text = Convert.ToString(wholeSalesPrice);
                txtbx_SctorSlPrice.Text = Convert.ToString(sectorSalesPrice);
                cmbbx_NewProdType.SelectedValue = reader.GetInt32("PRD_ID");
                cmbbx_NewProdType.Text = reader.GetString("PRDTYP_NAME");
                try
                {
                    barcodeText.Text = Convert.ToString(reader.GetString("PRD_BAR_CODE"));
                }
                catch (Exception ex)
                {
                    barcodeText.Text = "";
                }
                newPrdNameTB.Text = reader.GetString("PRD_NAME");

                if (wholeSalesPrice >= sectorSalesPrice)
                {
                    txtbx_ItemProfit.Text = Convert.ToString(wholeSalesPrice - buyPrice);
                }
                else
                {
                    txtbx_ItemProfit.Text = Convert.ToString(sectorSalesPrice - buyPrice);
                }
            }

            reader.Close();
        }


        private void saveEditedProdData() {
            int prdId, prdTypeId, prdLimit, prdBalance;
            double prdBuyPrice, prdWhlPrice, prdSctrPrice;
            String prdName, prdDesc;
            String prdBarcode;

            prdId = Convert.ToInt32(txtbx_ID.Text);
            prdTypeId = Convert.ToInt32(cmbbx_NewProdType.SelectedValue);
            prdLimit = Convert.ToInt32(txtbx_limit.Text);
           // prdBalance = Convert.ToInt32(txtbx_blnce.Text);
            prdBuyPrice = Convert.ToDouble(txtbx_buyPrice.Text);
            prdWhlPrice = Convert.ToDouble(txtbx_WhlSlPrice.Text);
            prdSctrPrice = Convert.ToDouble(txtbx_SctorSlPrice.Text);
            prdName = newPrdNameTB.Text;
            prdDesc = txtbx_PrdDsc.Text;
            prdBarcode = Convert.ToString(barcodeText.Text);
            String query;

            if (prdBarcode != "")
            {
                query = " update products set products.PRD_NAME = '" + prdName + "' , " +
                               " products.PRD_TYPE_ID = " + prdTypeId + " , " +
                               " products.PRD_LIMIT = " + prdLimit + "," +
                               " products.PRD_BUYPRICE = " + prdBuyPrice + "," +
                               " products.PRD_WHLSALEPRICE = " + prdWhlPrice + "," +
                               " products.PRD_SCTRPRICE = " + prdSctrPrice + "," +
                               " products.PRD_BAR_CODE = '" + prdBarcode + "' ," +
                               " products.PRD_DESC = '" + prdDesc + "' " +

                               " where products.PRD_ID = '" + prdId + "' ";
            }
            else
            {
                query = " update products set products.PRD_NAME = '" + prdName + "' , " +
                               " products.PRD_TYPE_ID = " + prdTypeId + " , " +
                               " products.PRD_LIMIT = " + prdLimit + "," +
                               " products.PRD_BUYPRICE = " + prdBuyPrice + "," +
                               " products.PRD_WHLSALEPRICE = " + prdWhlPrice + "," +
                               " products.PRD_SCTRPRICE = " + prdSctrPrice + "," +
                               " products.PRD_BAR_CODE = NULL ," +
                               " products.PRD_DESC = '" + prdDesc + "' " +

                               " where products.PRD_ID = '" + prdId + "' ";
            }
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            fillProdForm();

        }

        private void btn_ChooseProd_Click(object sender, EventArgs e)
        {

            if (cmbbx_ProdType.Text == "") { cmbbx_ProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (cmbbx_ProdName.Text == "") { cmbbx_ProdName.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            fillProdForm();


            cmbbx_ProdName.SelectedIndex = -1;


            cmbbx_ProdType.SelectedIndex = -1;

            btn_ChooseProd.Enabled = false;

            this.groupBox2.Enabled = true;

        }

       

        private void btn_Save_Click_1(object sender, EventArgs e)
        {

            if (cmbbx_NewProdType.Text == "") { cmbbx_NewProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (newPrdNameTB.Text == "") { newPrdNameTB.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                saveEditedProdData();
                MessageBox.Show("تم تعديــل البيانــات ");
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Please Check Edited Data! \nError details: " + ex.Message);
            }
        }

        private void cmbbx_NewProdType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbbx_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ChooseProd.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ItemCatalogeEdit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

    }
}
