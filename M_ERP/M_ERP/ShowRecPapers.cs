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
    public partial class ShowRecPapers : Form
    {

        DateTime fromDate, toDate;
        MySqlCommand cmd;
        int state = 0;
        MySqlDataReader reader;
        TreasuryEntry treasury;
        List<ComboboxItem> states;

        public ShowRecPapers()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.merp1_ExR_icon;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            states = new List<ComboboxItem>();

            cmb_state.DisplayMember = "Text";
            cmb_state.ValueMember = "Value";

            states.Add(new ComboboxItem("تحت التحصيل", 0));
            states.Add(new ComboboxItem("محصل", 1));
            states.Add(new ComboboxItem("مرفوض", 2));
            cmb_state.DataSource = states;

            treasury = new TreasuryEntry();
            calcTotal();
        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            fromDate = dtp_from.Value;
            populateGrid();

        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            toDate = dtp_to.Value;
            populateGrid();

        }

        private void populateGrid()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);



                String query = "SELECT RCVP_CLNT_ID, RCVP_ID, CLT_NAME, RCVP_BANKNAME, RCVP_BANKBRNCH, RCVP_ACCNO, RCVP_PPRNO, RCVP_RELDATE, RCVP_ENDDATE, RCVP_PPRTYPE, RCVP_AMNT" +
                                " FROM merp.receivable_papers, merp.clients WHERE RCVP_CLNT_ID = CLT_ID AND RCVP_STATE = " + state + " AND " +
                                " RCVP_RELDATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND RCVP_RELDATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();


                String bankName, bankbranch, accNo, pprNo, pprType, SpplrName;
                Int32 pprID, clntID;
                Double Amount;
                DateTime releaseDate, EndDate;
                dGridV_InvenLog.Rows.Clear();
                while (reader.Read())
                {

                    bankName = reader.GetString("RCVP_BANKNAME");
                    bankbranch = reader.GetString("RCVP_BANKBRNCH");
                    accNo = reader.GetString("RCVP_ACCNO");
                    pprNo = reader.GetString("RCVP_PPRNO");
                    pprType = reader.GetString("RCVP_PPRTYPE");
                    SpplrName = reader.GetString("CLT_NAME");
                    Amount = reader.GetDouble("RCVP_AMNT");
                    releaseDate = reader.GetDateTime("RCVP_RELDATE");
                    EndDate = reader.GetDateTime("RCVP_ENDDATE");
                    pprID = reader.GetInt32("RCVP_ID");
                    clntID = reader.GetInt32("RCVP_CLNT_ID");

                    dGridV_InvenLog.Rows.Add(clntID, SpplrName, bankName, bankbranch, accNo, pprNo, releaseDate, EndDate, pprType, Amount, pprID);

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
            calcTotal();

        }

        private void DecClientBalance(int ClientID, Double Amount)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query = "UPDATE `merp`.`clients` SET `CLNT_BLNCE`= CLNT_BLNCE - " + Amount + " WHERE `CLT_ID`='" + ClientID + "'";
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

        private void UpdateRecPapers(int pprID, int newState) {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query = "UPDATE `merp`.`receivable_papers` SET `RCVP_STATE`='" + newState + "' WHERE `RCVP_ID`='" + pprID + "'";
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

        private Double getClientBlnc(int clientID) {

            Double blnce = -1;

            try
            {


                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT CLNT_BLNCE FROM merp.clients WHERE CLT_ID = " + clientID;
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    blnce = reader.GetDouble("CLNT_BLNCE");
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

            return blnce;
        }

        private void btn_rec_Click(object sender, EventArgs e)
        {

            try
            {
                int pprID = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["PPRID_HIDDEN"].Value);
                double amount = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["clmn_Amnt"].Value);
                int client = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["spplrID"].Value);
                Double clientBlnc = getClientBlnc(client);
                UpdateRecPapers(pprID, 1);

                treasury.addToTreasury(amount, 0, DateTime.Now, "تحصيل ورقة قبض", "تحصيل", 1, 0, client, clientBlnc);
                populateGrid();
        }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
}

        private void btn_ref_Click(object sender, EventArgs e)
        {

            try
            {
                int client = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["spplrID"].Value);
                double amount = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["clmn_Amnt"].Value);
                UpdateRecPapers(Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["PPRID_HIDDEN"].Value), 2);
                DecClientBalance(client, amount);
                populateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_state_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                state = Convert.ToInt32(cmb_state.SelectedValue);
                populateGrid();

                if (cmb_state.SelectedIndex == 0)
                {
                    btn_rec.Enabled = true;
                    btn_ref.Enabled = true;
                }else if(cmb_state.SelectedIndex == 1)
                {
                    btn_rec.Enabled = false;
                    btn_ref.Enabled = false;
                }
                else if (cmb_state.SelectedIndex == 2)
                {
                    btn_rec.Enabled = false;
                    btn_ref.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void calcTotal()
        {

         int sum = 0;
            for (int i = 0; i < dGridV_InvenLog.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dGridV_InvenLog.Rows[i].Cells[9].Value);
            }
            txt_TotalIn.Text = sum.ToString();
        }

        private void ShowRecPapers_Load(object sender, EventArgs e)
        {

        }
    }
    
}
