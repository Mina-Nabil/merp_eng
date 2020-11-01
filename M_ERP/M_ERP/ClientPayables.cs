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
    public partial class ClientPayables : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;


        int clientID = 0;
        String clientName = "";
        DateTime paymentDate;
        double paymentAmount = 0;
        String notes = "";


        public ClientPayables()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;

            resetClientNameComboBox();


        }

        public void resetClientNameComboBox()
        {
            

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                
                String sqlCommand = "Select CLT_NAME, CLT_ID FROM merp.clients";
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


        private void ClientPayables_Load(object sender, EventArgs e)
        {

        }


        private void addClientPayables() {
            
            double clientBalance = getClientBalance(clientID);

            TreasuryEntry tresuereEntry = new TreasuryEntry();

            tresuereEntry.addToTreasury(paymentAmount, 0, paymentDate, notes, " مدفوعات عميل : " + clientName, TreasuryEntry.TE_IN, 0, clientID, clientBalance);
/*
            Varibles.setConnection();
            cmd = Varibles.getCommand();
            
            string query = "INSERT INTO `merp`.`treasuryentries` (`TE_IN`, `TE_DATE`, `TE_OPTITLE`, `TE_CMMTS`, `TE_CLNT_ID`, `TE_OPTYPE_ID`, `TE_BLNCE`) " +
                           " VALUES ('" + paymentAmount + "', '" + paymentDate + "'," +
                           " 'مدفوعات عميل : " +  clientName + "', '" + notes + "', '" + clientID + "', '1', '" + clientBalance + "')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            Varibles.closeConnection();
  */      
        }

        private void UpdateClientBalance() {
            try
            {

                double clientBalance = getClientBalance(clientID);

                Varibles.setConnection();
                cmd = Varibles.getCommand();
                string query = "UPDATE `merp`.`clients` SET `CLNT_BLNCE`='" + (clientBalance + paymentAmount) + "' WHERE `CLT_ID` = '" + clientID + "'";
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


        private double getClientBalance(int clientID)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();


                String query = "SELECT CLNT_BLNCE FROM merp.clients WHERE CLT_ID = '" + clientID + "' ;";

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

                return cltBalance;
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

        private void btn_addPay_Click(object sender, EventArgs e)
        {
            try
            {
                clientID = Convert.ToInt32(this.clientNameComboBox.SelectedValue);
                clientName = Convert.ToString(this.clientNameComboBox.Text);
                paymentDate = Convert.ToDateTime(this.dtp_date.Value);
                paymentAmount = Convert.ToDouble(this.txt_amount.Text);
                notes = this.txt_cmnts.Text;

                addClientPayables();     
                UpdateClientBalance();

                MessageBox.Show("تمت العملية بنجاح");

                txt_amount.Text = "";
                txt_cmnts.Text = "";
            }
            catch (SystemException ex) {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
