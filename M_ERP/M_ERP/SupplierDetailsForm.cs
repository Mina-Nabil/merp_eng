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
    public partial class SupplierDetailsForm : Form
    {
        int bigHeightForm = 660;
        int smallHeightForm = 500;

        int bigHeightGroup = 600;
        int smallHeightGroup = 440;

        MySqlCommand cmd;
        MySqlDataReader reader;
        bool lock1;

        public SupplierDetailsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.merp1_ExR_icon;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lock1 = true;

            radioButton2.Checked = true;
        }

        public void emptyFields()
        {
            try
            {
                supplierRespTB.Text = "";
                addressTB.Text = "";
                emailTB.Text = "";
                PhoneTB.Text = "";
                mobileTB.Text = "";
                beginBalanceTB.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void resetClientNameComboBox()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "Select SPLR_NAME FROM merp.suppliers";
                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                Varibles.closeConnection();

                supplierNameComboBox.DisplayMember = "SPLR_NAME";
                supplierNameComboBox.ValueMember = "SPLR_NAME";
                supplierNameComboBox.DataSource = ds.Tables[0];


                supplierNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                supplierNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void formFormat(bool big)
        {
            try
            {
                if (big)
                {
                    balanceGroupBox.Visible = true;
                    addBtn.Visible = true;
                    editBtn.Visible = false;
                    deleteBtn.Visible = false;

                    this.Height = bigHeightForm;
                    groupBox1.Height = bigHeightGroup;

                    emptyFields();
                }
                else
                {
                    balanceGroupBox.Visible = false;
                    addBtn.Visible = false;
                    editBtn.Visible = true;
                    deleteBtn.Visible = true;

                    this.Height = smallHeightForm;
                    groupBox1.Height = smallHeightGroup;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void showInfo()
        {
            try
            {
                if (!lock1)
                {
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();

                    String sqlCommand = "Select SPLR_RespName , SPLR_EMAIL , SPLR_TEL , SPLR_MOB , SPLR_ADRS FROM merp.suppliers WHERE SPLR_NAME LIKE '" + supplierNameComboBox.Text + "'";
                    cmd.CommandText = sqlCommand;

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            formFormat(false);
                            supplierRespTB.Text = reader.GetString(0);
                            emailTB.Text = reader.GetString(1);
                            PhoneTB.Text = reader.GetString(2);
                            mobileTB.Text = reader.GetString(3);
                            addressTB.Text = reader.GetString(4);
                        }

                    }
                    else
                    {
                        formFormat(true);
                    }
                    reader.Close();
                    Varibles.closeConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String splr_name = supplierNameComboBox.Text;

                if (splr_name == "" || splr_name == null)
                {
                    MessageBox.Show("لا يمكن ترك اسم المورد فارغ");
                }
                else
                {
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();
                    String splr_REspName = supplierRespTB.Text;
                    String splr_Email = emailTB.Text;
                    String splr_Tele = PhoneTB.Text;
                    String splr_mob = mobileTB.Text;
                    String splr_adrs = addressTB.Text;

                    double value = 0;

                    try
                    {
                        value = Convert.ToDouble(beginBalanceTB.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("يوجد خطأ فى رصيد البداية سيتم احتساب قيمة رصيد البداية بصفر");
                        value = 0;
                    }

                    if (radioButton1.Checked)
                    {
                        value *= -1;
                    }
                    else if (radioButton2.Checked)
                    {

                    }

                    cmd.CommandText = "INSERT  merp.suppliers" +
                                        " SET SPLR_NAME = '" + splr_name + "' , SPLR_RespName = '" + splr_REspName + "' , "
                                        + " SPLR_EMAIL =  '" + splr_Email + "' , SPLR_TEL = '" + splr_Tele + "' , " +
                                        " SPLR_MOB = '" + splr_mob + "' , SPLR_ADRS = '" + splr_adrs + "' , SPLR_BLNCE = " + value;



                    cmd.ExecuteReader().Close();
                    Varibles.closeConnection();

                    resetClientNameComboBox();
                    supplierNameComboBox.Text = splr_name;

                    MessageBox.Show("تم اضافة مورد جديد بنجاح ");

                    supplierNameComboBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupplierDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                formFormat(true);

                resetClientNameComboBox();

                supplierNameComboBox.SelectedIndex = -1;


                lock1 = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String splrName = supplierNameComboBox.Text;

                String condition = " SPLR_NAME LIKE '" + splrName + "'";

                String respName = supplierRespTB.Text;
                String email = emailTB.Text;
                String tele = PhoneTB.Text;
                String mob = mobileTB.Text;
                String address = addressTB.Text;

                cmd.CommandText = "UPDATE        merp.suppliers" +
                                    " SET  SPLR_RespName = '" + respName + "' , SPLR_EMAIL = '" + email + "' , SPLR_TEL = '" + tele
                                    + "' , SPLR_MOB = '" + mob + "' , SPLR_ADRS = '" + address + "' "
                                    +
                                    " WHERE        ( " + condition + " )";



                cmd.ExecuteReader().Close();
                Varibles.closeConnection();

                MessageBox.Show("تم اجراء التعديل بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String supplierName = supplierNameComboBox.Text;

                String condition = " SPLR_NAME LIKE '" + supplierName + "'";

                cmd.CommandText = "DELETE FROM merp.suppliers" +
                                    " WHERE        ( " + condition + " )";



                cmd.ExecuteReader().Close();
                Varibles.closeConnection();



                MessageBox.Show("تم حذف العميل بنجاح");

                resetClientNameComboBox();

                supplierNameComboBox.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void supplierNameComboBox_TextChanged(object sender, EventArgs e)
        {
            showInfo();
        }
    }
}
