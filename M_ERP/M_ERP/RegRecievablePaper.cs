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
    public partial class RegRecievablePaper : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;

        public RegRecievablePaper()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;


            resetClientNameComboBox();
            clientNameComboBox.SelectedIndex = -1;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            String bankName, bankbranch, accNo, pprNo, pprType, SpplrName;
            Int32 SpplrID;
            Double Amount;
            DateTime releaseDate, EndDate;

            if (clientNameComboBox.Text == "") { clientNameComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_bankName.Text == "") { txt_bankName.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_bankBranch.Text == "") { txt_bankBranch.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_AccNo.Text == "") { txt_AccNo.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_PprNo.Text == "") { txt_PprNo.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_PprType.Text == "") { txt_PprType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            double txt_AmountValue = Convert.ToInt32(txt_Amount.Text);
            if (txt_Amount.Text == "") { txt_Amount.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_AmountValue < 0) { txt_Amount.Focus(); MessageBox.Show("لايمكن أن تكون الكمية أقل من 1"); return; };

            try
            {
                bankName = txt_bankName.Text;
                bankbranch = txt_bankBranch.Text;
                accNo = txt_AccNo.Text;
                pprNo = txt_PprNo.Text;
                pprType = txt_PprType.Text;
                SpplrID = Convert.ToInt32(clientNameComboBox.SelectedValue);
                SpplrName = clientNameComboBox.Text;
                Amount = Convert.ToDouble(txt_Amount.Text);
                releaseDate = dtp_releaseDate.Value;
                EndDate = dtp_releaseDate.Value;

                dGridV_InvenLog.Rows.Add(SpplrID, SpplrName, bankName, bankbranch, accNo, pprNo, releaseDate, EndDate, pprType, Amount);


            }
            catch (SystemException ex)
            {
                MessageBox.Show("خطأ في البيانات");
            }

        }

        private void IncClientBalance(int ClientID, Double Amount)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query = "UPDATE `merp`.`clients` SET `CLNT_BLNCE`= CLNT_BLNCE + " + Amount + " WHERE `CLT_ID`='" + ClientID + "'";
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


        private void btn_save_Click(object sender, EventArgs e)
        {
            String bankName, bankbranch, accNo, pprNo, pprType;
            Int32 SpplrID;
            Double Amount;
            DateTime releaseDate, EndDate;

            try
            {
                foreach (DataGridViewRow i in dGridV_InvenLog.Rows)
                {
                    try
                    {
                        Varibles.setConnection();
                        cmd = Varibles.getCommand();
                        bankName = Convert.ToString(i.Cells["clmn_BNKName"].Value);
                        bankbranch = Convert.ToString(i.Cells["clmn_BNKBranch"].Value);
                        accNo = Convert.ToString(i.Cells["clmn_AccNo"].Value);
                        pprNo = Convert.ToString(i.Cells["clmn_PprNo"].Value);
                        pprType = Convert.ToString(i.Cells["clmn_pprType"].Value);
                        SpplrID = Convert.ToInt32(i.Cells["spplrID"].Value);
                        Amount = Convert.ToDouble(i.Cells["clmn_Amnt"].Value);
                        releaseDate = Convert.ToDateTime(i.Cells["clmn_ReleaseDate"].Value); ;
                        EndDate = Convert.ToDateTime(i.Cells["clmn_endDate"].Value);

                        String query = "INSERT INTO `merp`.`receivable_papers` (`RCVP_CLNT_ID`, `RCVP_BANKNAME`, `RCVP_BANKBRNCH`, `RCVP_ACCNO`, `RCVP_PPRNO`, " +
                                        "`RCVP_RELDATE`, `RCVP_ENDDATE`, `RCVP_PPRTYPE`, `RCVP_AMNT`) VALUES " +
                                        "('" + SpplrID + "', '" + bankName + "', '" + bankbranch + "', '" + accNo + "', '" + pprNo + "', '" + releaseDate.ToString("yyyy-MM-dd HH:mm:ss")
                                        + "', '" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + pprType + "', '" + Amount + "')";

                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        Varibles.closeConnection();
                        IncClientBalance(SpplrID, Amount);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Varibles.closeConnection();
                    }
                }

                MessageBox.Show("العملية تمت بنجاح");
                dGridV_InvenLog.Rows.Clear();
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }

       
    }
}
