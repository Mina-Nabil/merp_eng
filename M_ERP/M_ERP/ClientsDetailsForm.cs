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
    public partial class ClientsDetailsForm : Form
    {
        int bigHeightForm = 660;
        int smallHeightForm = 500;

        int bigHeightGroup = 600;
        int smallHeightGroup = 440;

        MySqlCommand cmd;
        MySqlDataReader reader;
        bool lock1;
        public ClientsDetailsForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lock1 = true; 
            this.Icon = Properties.Resources.merp1_ExR_icon;

            radioButton1.Checked = true;

        }
        public void emptyFields()
        {
            try
            {
                clientRespTB.Text = "";
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

                String sqlCommand = "Select CLT_NAME FROM merp.clients";
                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();
                Varibles.closeConnection();

                clientNameComboBox.DisplayMember = "CLT_NAME";
                clientNameComboBox.ValueMember = "CLT_NAME";
                clientNameComboBox.DataSource = ds.Tables[0];


                clientNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                clientNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

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

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                String clt_name = clientNameComboBox.Text;
                if (clt_name == "" || clt_name == null)
                {
                    MessageBox.Show("لا يمكن ترك اسم العميل فارغ");
                }
                else
                {
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();

                    String clt_REspName = clientRespTB.Text;
                    String clt_Email = emailTB.Text;
                    String clt_Tele = PhoneTB.Text;
                    String clt_mob = mobileTB.Text;
                    String clt_adrs = addressTB.Text;


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
                    cmd.CommandText = "INSERT  merp.clients" +
                                        " SET CLT_NAME = '" + clt_name + "' , CLT_RespName = '" + clt_REspName + "' , "
                                        + " CLT_EMAIL =  '" + clt_Email + "' , CLT_TELE = '" + clt_Tele + "' , " +
                                        " CLT_MOB = '" + clt_mob + "' , CLT_ADRS = '" + clt_adrs + "' , CLNT_BLNCE = " + value;



                    cmd.ExecuteReader().Close();
                    Varibles.closeConnection();

                    resetClientNameComboBox();
                    clientNameComboBox.Text = clt_name;
                    MessageBox.Show("تم اضافة عميل جديد بنجاح ");

                    clientNameComboBox.Text = "";

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                formFormat(true);

                resetClientNameComboBox();

                clientNameComboBox.SelectedIndex = -1;


                lock1 = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void showInfo()
        {
            try
            {
                if (!lock1)
                {
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();

                    String sqlCommand = "Select CLT_RespName , CLT_EMAIL , CLT_TELE , CLT_MOB , CLT_ADRS FROM merp.clients WHERE CLT_NAME LIKE '" + clientNameComboBox.Text + "'";
                    cmd.CommandText = sqlCommand;

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            formFormat(false);
                            clientRespTB.Text = reader.GetString(0);
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
                MessageBox.Show(ex.Message );
            }
        }
        private void nameComboBox_TextChanged(object sender, EventArgs e)
        {
            showInfo();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String clientName = clientNameComboBox.Text;

                String condition = " CLT_NAME LIKE '" + clientName+ "'";
                String respName = clientRespTB.Text;
                String email = emailTB.Text;
                String tele = PhoneTB.Text;
                String mob = mobileTB.Text;
                String address = addressTB.Text;
                cmd.CommandText = "UPDATE        merp.clients" +
                                    " SET  CLT_RespName = '" + respName + "' , CLT_EMAIL = '" + email + "' , CLT_TELE = '" + tele
                                    + "' , CLT_MOB = '" + mob + "' , CLT_ADRS = '" + address +"' "
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

                String clientName = clientNameComboBox.Text;

                String condition = " CLT_NAME LIKE '" + clientName + "'";
               
                cmd.CommandText = "DELETE FROM merp.clients" +
                                    " WHERE        ( " + condition + " )";



                cmd.ExecuteReader().Close();
                Varibles.closeConnection();

               

                MessageBox.Show("تم حذف العميل بنجاح");

                resetClientNameComboBox();

                clientNameComboBox.SelectedIndex = -1;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        
    }
}
