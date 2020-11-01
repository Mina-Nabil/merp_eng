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
    public partial class ItemRemovePermission : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        List<InventoryEditPermission> permlist;
        InvLog invLog;

        public ItemRemovePermission()
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
            text_countOld.Text = "";

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (cmbbx_ProdType.Text == "") { cmbbx_ProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (cmbbx_ProdName.Text == "") { cmbbx_ProdName.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_Count.Text == "") { txt_Count.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                if (Convert.ToInt32(txt_Count.Text) > 0)
                {
                    int itembalance = Convert.ToInt32(text_countOld.Text);

                    if (getItemQuantity(Convert.ToInt32(cmbbx_ProdName.SelectedValue), Convert.ToInt32(txt_Count.Text)) > itembalance)
                    {
                        MessageBox.Show("الكمية المطلوبة اكثر من الحد فى المخازن");
                        return;
                    }
                    
                    Int32 prodID = Convert.ToInt32(cmbbx_ProdName.SelectedValue);
                    Int32 count = Convert.ToInt32(txt_Count.Text);
                    String prodName = Convert.ToString(cmbbx_ProdName.Text);
                    String prodType = Convert.ToString(cmbbx_ProdType.Text);
                    String date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    double b = 0;

                    dGridV_ItemAddPer.Rows.Add(prodID, prodType, prodName, count, date);
                    permlist.Add(new InventoryEditPermission(prodID, count, prodType, prodName, date,b));
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show("يوجد خـــطــأ في البيانات");
            }
        }

        private int getItemQuantity(int id, int overQuantity)
        {
            int itemQuantity = overQuantity;

            for (int i = 0; i < dGridV_ItemAddPer.RowCount; i++)
            {
                if (id == Convert.ToInt32(dGridV_ItemAddPer.Rows[i].Cells[0].Value))
                {
                    itemQuantity += Convert.ToInt32(dGridV_ItemAddPer.Rows[i].Cells[3].Value);
                }
            }

            return itemQuantity;
        }


        private void updateProdBlnc(int prodID, int Count, int opType)
        {

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


        private int getProdCount(int prdID)
        {
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

        private void updateCountTxtBox()
        {
            int count = getProdCount(Convert.ToInt32(cmbbx_ProdName.SelectedValue));
            if (count != -1)
            {
                text_countOld.Text = Convert.ToString(count);
            }
        }

        private void cmbbx_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCountTxtBox();
        }

        private void ItemRemovePermission_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (InventoryEditPermission i in permlist)
                {
                    if (checkStock(i.prodID, i.count, i.prodNam))
                    {
                        int prdBlnc = getItemBalance(i.prodID);
                        removeFromStock(i.prodID, i.count);
                        updateProdBlnc(i.prodID, i.count, 0);
                        invLog.addToLog(i.prodID, 0, i.count, DateTime.Now, "اذن حذف للمخزن", "حذف", Varibles.user_id,0,0,0,0,prdBlnc);
                    }
                    
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

        private bool checkStock(int pr_id,int pr_balance,String pr_name)
        {
            
            try //check stock
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int stock_balance = 0;



                if (isInStock(pr_id))
                {
                    stock_balance = balanceInStock(pr_id);

                    if (pr_balance > stock_balance)
                    {
                        MessageBox.Show("خطأ" + " " + "العدد الموجود من هذا الصنف" + "\n" + pr_name + "\n" + "في المخزن" + " " + stock_balance);
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("خطأ" + " " + "لا يوجد من هذا الصنف" + "\n" + pr_name + "\n" + "في المخزن");
                    return false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {

                Varibles.closeConnection();
            }

            return true;
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


        private void removeFromStock(int pr_id , int pr_balance)
        {
            List<StockItem> stockItemsList = new List<StockItem>();

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

                    StockItem st = new StockItem(stock_balance, stock_price);
                    stockItemsList.Add(st);

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
            bool finishReader = false;
            for (int ii = 0; ii < stockItemsList.Count; ii++)
            {
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
           
                if (finishReader)
                {
                    break;
                }
            }
        }

        private void deleteFromStock(int prdId, double prdBuyPrice)
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();
            String query = "Delete From stock where stock.prod_id = '" + prdId + "' AND stock.buy_price = '" + prdBuyPrice + "'";

            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            Varibles.closeConnection();


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
