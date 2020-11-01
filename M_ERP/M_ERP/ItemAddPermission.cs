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
    public partial class ItemAddPermission : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        List<InventoryEditPermission> permlist;
        InvLog invLog;

        public ItemAddPermission()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            permlist = new List<InventoryEditPermission>();
            
            invLog = new InvLog();

            fillProdTypes();

            cmbbx_ProdType.SelectedIndex = -1;
        }



        private void fillProdTypes()
        {

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

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
            finally
            {
                Varibles.closeConnection();
            }
        }




        private void fillprodNames()
        {

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

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
                txt_Count.Text = "0";
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

        private void cmbbx_ProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillprodNames();
            text_oldCount.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (cmbbx_ProdType.Text == "") { cmbbx_ProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (cmbbx_ProdName.Text == "") { cmbbx_ProdName.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_Count.Text == "") { txt_Count.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (buyPriceTB.Text == "") {buyPriceTB.Focus() ; MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; }
            try
            {
                if (Convert.ToInt32(txt_Count.Text) > 0 && Convert.ToDouble(buyPriceTB.Text) >= 0)
                {

                    Int32 prodID = Convert.ToInt32(cmbbx_ProdName.SelectedValue);
                    Int32 count = Convert.ToInt32(txt_Count.Text);
                    String prodName = Convert.ToString(cmbbx_ProdName.Text);
                    String prodType = Convert.ToString(cmbbx_ProdType.Text);
                    String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    double buyPrice = Convert.ToDouble(buyPriceTB.Text);

                    dGridV_ItemAddPer.Rows.Add(prodID, prodType, prodName, buyPrice ,count, date);
                    permlist.Add(new InventoryEditPermission(prodID, count, prodType, prodName, date,buyPrice));
                }
            }
            catch (SystemException ex) {
                MessageBox.Show("يوجد خـــطــأ في البيانات");
            }
        }

        private void updateProdBlnc(int prodID, int Count, int opType) {

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query;

                if (opType == 1)
                    query = "UPDATE `merp`.`products` SET `PRD_BALANCE`= PRD_BALANCE + '" + Count + "' WHERE `PRD_ID`='" + prodID + "'";
                else
                    query = "UPDATE `merp`.`products` SET `PRD_BALANCE`= PRD_BALANCE - '" + Count + "' WHERE `PRD_ID`='" + prodID + "'";

                cmd.CommandText = query;
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

       

        private int getProdCount(int prdID) {
            int count = -1;
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT PRD_BALANCE FROM merp.products WHERE PRD_ID = " + prdID;
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                count = -1;

                while (reader.Read())
                {
                    count = reader.GetInt32("PRD_BALANCE");
                }
                return count;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return count;

            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();

            }
        }

        private void updateCountTxtBox() {
            int count = getProdCount(Convert.ToInt32(cmbbx_ProdName.SelectedValue));
            if (count != -1)
            {
                text_oldCount.Text = Convert.ToString(count);
            }
        }

        private void cmbbx_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCountTxtBox();
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (InventoryEditPermission i in permlist)
                {
                    int prdBlnc = getItemBalance(i.prodID);
                    addToStock(i.prodID, i.buyPrice, i.count);
                    updateProdBlnc(i.prodID, i.count, 1);
                    invLog.addToLog(i.prodID, i.count, 0, DateTime.Now, "إذن إضافه للمخزن", "إضافه", Varibles.user_id,0,i.buyPrice,0,0,prdBlnc);
                }
                dGridV_ItemAddPer.Rows.Clear();
                permlist.Clear();
                updateCountTxtBox();
                MessageBox.Show("تمت العملية بنجاح");
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void addToStock(int pr_id, double pr_price , int pr_balance )
        {
            try //update stock
            {
                int new_balance = 0;

                if (isInStock(pr_id, pr_price))
                {
                    new_balance = pr_balance + countInStock(pr_id, pr_price);
                    updateStock(pr_id, new_balance, pr_price);
                }
                else
                {
                    insertInStock(pr_id, pr_balance, pr_price);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private bool isInStock(int prdId, double prdBuyPrice)
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();
            int count = 0;
            try
            {
                String query = "SELECT COUNT(*) AS count FROM stock where stock.prod_id = '" + prdId + "' AND stock.buy_price = '" + prdBuyPrice + "'";

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
                Varibles.closeConnection();
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

        private int countInStock(int prdId, double prdBuyPrice)
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();

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
                Varibles.closeConnection();
            }

            return count;


        }

        private void updateStock(int prdId, int prdBalance, double prdBuyPrice)
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            String query = "Update stock set stock.count = '" + prdBalance + "' where stock.prod_id = '" + prdId + "' AND stock.buy_price = '" + prdBuyPrice + "'";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            Varibles.closeConnection();

        }

        private void insertInStock(int prdId, int prdBalance, double prdBuyPrice)
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            String query = "Insert Into stock (stock.prod_id, stock.count , stock.buy_price ) " +
            "VALUES ( " + prdId + " , " + prdBalance + " , "
                        + prdBuyPrice + " )";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            Varibles.closeConnection();

        }


        private void txt_Count_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                if (txt_Count.Text != "")
                {
                    count = Convert.ToInt32(txt_Count.Text);
                }
            }
            catch (Exception ex)
            {
                count = 0;
                txt_Count.Text = "0";
                MessageBox.Show("خطأ فى الكمية");
            }
        }

        private void ItemAddPermission_Load(object sender, EventArgs e)
        {

        }

        private void dGridV_ItemAddPer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


    }
}
