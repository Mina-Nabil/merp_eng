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
    public partial class SuppPayables : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;


        int suppID = 0;
        String suppName = "";
        DateTime paymentDate;
        double paymentAmount = 0;
        String notes = "";


        public SuppPayables()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            resetSupplierNameComboBox();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void resetSupplierNameComboBox()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "Select SPLR_NAME, SPLR_ID FROM merp.suppliers";
                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                supplierNameComboBox.DisplayMember = "SPLR_NAME";
                supplierNameComboBox.ValueMember = "SPLR_ID";
                supplierNameComboBox.DataSource = ds.Tables[0];


                supplierNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                supplierNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

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


        private double getSuppBalance(int suppID)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();


                String query = "SELECT SPLR_BLNCE FROM merp.suppliers WHERE SPLR_ID = '" + suppID + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                double splrBalance = 0;
                while (reader.Read())
                {
                    try
                    {
                        splrBalance = reader.GetDouble("SPLR_BLNCE");
                    }
                    catch (Exception ex)
                    {
                        splrBalance = 0;
                    }
                }

                return splrBalance;
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
            return 0;
        }



        private void addSupplierPayables()
        {

            double suppBalance = getSuppBalance(suppID);

            TreasuryEntry tresuereEntry = new TreasuryEntry();

            tresuereEntry.addToTreasury(0, paymentAmount, paymentDate, notes, " مدفوعات مورد : " + suppName, TreasuryEntry.TE_OUT, suppID, 0, suppBalance);

/*
            string query = "INSERT INTO `merp`.`treasuryentries` (`TE_IN`, `TE_DATE`, `TE_OPTITLE`, `TE_CMMTS`, `TE_SPLR_ID`, `TE_OPTYPE_ID`, `TE_BLNCE`) " +
                           " VALUES ('" + paymentAmount + "', '" + paymentDate + "'," +
                           " 'مدفوعات عميل : " + suppName + "', '" + notes + "', '" + suppID + "', '1', '" + suppBalance + "')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            */
        }

        private void UpdateSuppBalance()
        {
            try
            {
                double suppBalance = getSuppBalance(suppID);
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                string query = "UPDATE `merp`.`suppliers` SET `SPLR_BLNCE`='" + (suppBalance - paymentAmount) + "' WHERE `SPLR_ID`='" + suppID + "'";
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






        private void btn_addPay_Click(object sender, EventArgs e)
        {
            try
            {
                suppID = Convert.ToInt32(this.supplierNameComboBox.SelectedValue);
                suppName = Convert.ToString(this.supplierNameComboBox.Text);
                paymentDate = Convert.ToDateTime(this.dtp_date.Value);
                paymentAmount = Convert.ToDouble(this.txt_amount.Text);
                notes = this.txt_cmnts.Text;

                addSupplierPayables();
                UpdateSuppBalance();

                MessageBox.Show("تمت العملية بنجاح");

                txt_amount.Text = "";
                txt_cmnts.Text = "";

            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }

            
                 
        }

        private void SuppPayables_Load(object sender, EventArgs e)
        {

        }
    }
}
