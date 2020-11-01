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
    public partial class ShowPayPapers : Form
    {

        DateTime fromDate, toDate;
        int state = 0;
        MySqlCommand cmd;
        MySqlDataReader reader;
        List<ComboboxItem> states;


        public ShowPayPapers()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.merp1_ExR_icon;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            states = new List<ComboboxItem>();
           
            
            cmb_state.DisplayMember = "Text";
            cmb_state.ValueMember = "Value";

            states.Add(new ComboboxItem("تحت الدفع", 0));
            states.Add(new ComboboxItem("مدفوع", 1));
            states.Add(new ComboboxItem("مرفوض", 2));
            cmb_state.DataSource = states;
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

        private void populateGrid() {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);



                String query = "SELECT PYMNTP_SPPLRID, PYMNTP_ID, SPLR_NAME, PYMNT_BANKNAME, PYMNT_BANKBRNCH, PYMNT_ACCNO, PYMNT_PPRNO, " +
                                "PYMNT_RLSEDATE, PYMNT_ENDDATE, PYMNT_PPRTYPE, PYMNT_AMNT FROM merp.payment_papers, " +
                                "merp.suppliers WHERE PYMNTP_SPPLRID = SPLR_ID AND PYMNT_STATE = '" + state + "' AND " +
                                "PYMNT_RLSEDATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "' AND PYMNT_RLSEDATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();


                String bankName, bankbranch, accNo, pprNo, pprType, SpplrName;
                int paymentID, suppId;
                Double Amount;
                DateTime releaseDate, EndDate;
                dGridV_InvenLog.Rows.Clear();
                while (reader.Read())
                {
                    suppId = reader.GetInt32("PYMNTP_SPPLRID");
                    bankName = reader.GetString("PYMNT_BANKNAME");
                    bankbranch = reader.GetString("PYMNT_BANKBRNCH");
                    accNo = reader.GetString("PYMNT_ACCNO");
                    pprNo = reader.GetString("PYMNT_PPRNO");
                    pprType = reader.GetString("PYMNT_PPRTYPE");
                    SpplrName = reader.GetString("SPLR_NAME");
                    Amount = reader.GetDouble("PYMNT_AMNT");
                    releaseDate = reader.GetDateTime("PYMNT_RLSEDATE");
                    EndDate = reader.GetDateTime("PYMNT_ENDDATE");
                    paymentID = reader.GetInt32("PYMNTP_ID");


                    dGridV_InvenLog.Rows.Add(suppId, SpplrName, bankName, bankbranch, accNo, pprNo, releaseDate, EndDate, pprType, Amount, paymentID);

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
                }
                else if (cmb_state.SelectedIndex == 1)
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


        private void refusePaper(int paperID, int SuppID, double amount) {
            try
            {
                IncSupplier(SuppID, amount);
                updatePaper(paperID, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IncSupplier(int SuppID, Double amount) {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();    
                String query = "UPDATE `merp`.`suppliers` SET `SPLR_BLNCE`= SPLR_BLNCE + " + amount + " WHERE `SPLR_ID`='" + SuppID + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }finally{
                Varibles.closeConnection();
            }
        }

        private void updatePaper(int paperID, int newState) {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query = "UPDATE `merp`.`payment_papers` SET `PYMNT_STATE`='" + newState + "' WHERE `PYMNTP_ID`='" + paperID + "'";
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

        private Double getSuppBalance(int SuppID)
        {
            
            Double blnce = -1;
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query = "SELECT SPLR_BLNCE FROM merp.suppliers WHERE SPLR_NAME = " + SuppID;
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    blnce = reader.GetDouble("SPLR_BLNCE");
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

        private void collectPaper(int paperID, int SuppID, double amount)
        {
            try
            {
                TreasuryEntry treasury = new TreasuryEntry();
                updatePaper(paperID, 1);
                Double supplBlnc = getSuppBalance(SuppID);
                treasury.addToTreasury(0, amount, DateTime.Now, "دفع ورقة دفع", " مدفوعات", 2, SuppID, 0, supplBlnc);
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
                int paperID = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["PPRID_HIDDEN"].Value);
                double amount = Convert.ToDouble(dGridV_InvenLog.SelectedRows[0].Cells["clmn_Amnt"].Value);
                int suppID = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["spplrID"].Value);
                refusePaper(paperID, suppID, amount);
                populateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rec_Click(object sender, EventArgs e)
        {
            try
            {
                int paperID = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["PPRID_HIDDEN"].Value);
                double amount = Convert.ToDouble(dGridV_InvenLog.SelectedRows[0].Cells["clmn_Amnt"].Value);
                int suppID = Convert.ToInt32(dGridV_InvenLog.SelectedRows[0].Cells["spplrID"].Value);
                collectPaper(paperID, suppID, amount);
                populateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void ShowPayPapers_Load(object sender, EventArgs e)
        {

        }
    }
}
