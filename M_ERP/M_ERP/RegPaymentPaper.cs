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
    public partial class RegPaymentPaper : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;

        public RegPaymentPaper()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;

            resetClientNameComboBox();
            supplierNameComboBox.SelectedIndex = -1;
        }


        public void resetClientNameComboBox()
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


        private void btn_Add_Click(object sender, EventArgs e)
        {
            String bankName, bankbranch, accNo, pprNo, pprType, SpplrName;
            Int32 SpplrID;
            Double Amount;
            DateTime releaseDate, EndDate;

            if (supplierNameComboBox.Text == "") { supplierNameComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
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
                SpplrID = Convert.ToInt32(supplierNameComboBox.SelectedValue);
                SpplrName = supplierNameComboBox.Text;
                Amount = Convert.ToDouble(txt_Amount.Text);
                releaseDate = dtp_releaseDate.Value;
                EndDate = dtp_releaseDate.Value;

                dGridV_InvenLog.Rows.Add(SpplrID, SpplrName, bankName, bankbranch, accNo, pprNo, releaseDate, EndDate, pprType, Amount); 


            }
            catch (SystemException ex) {
                MessageBox.Show("خطأ في البيانات");
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

                        String query = "INSERT INTO `merp`.`payment_papers` (`PYMNTP_SPPLRID`, `PYMNT_BANKNAME`, `PYMNT_BANKBRNCH`, " +
                                        "`PYMNT_ACCNO`, `PYMNT_PPRNO`, `PYMNT_RLSEDATE`, " +
                                        "`PYMNT_ENDDATE`, `PYMNT_PPRTYPE`, `PYMNT_AMNT`) " +
                                        "VALUES ('" + SpplrID + "', '" + bankName + "', '" + bankbranch + "', '" + accNo +
                                        "', '" + pprNo + "', '" + releaseDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                                        "'" + EndDate.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + pprType + "', '" + Amount + "')";

                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();
                        Varibles.closeConnection();
                        DecSupplier(SpplrID, Amount);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Varibles.closeConnection();
                    }
                    finally
                    {

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
        private void DecSupplier(int SuppID, Double amount)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "UPDATE `merp`.`suppliers` SET `SPLR_BLNCE`= SPLR_BLNCE - " + amount + " WHERE `SPLR_ID`='" + SuppID + "'";
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

        private void RegPaymentPaper_Load(object sender, EventArgs e)
        {

        }
    }
}
