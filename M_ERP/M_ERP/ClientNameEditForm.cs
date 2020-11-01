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
    public partial class ClientNameEditForm : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        public ClientNameEditForm()
        {

            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
        }

        private void ClientEditForm_Load(object sender, EventArgs e)
        {
            resetClientNameComboBox();
            clientNameComboBox.SelectedIndex = -1;
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (clientNameComboBox.Text == "") { clientNameComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (newClientNameTB.Text == "") { newClientNameTB.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String oldclientName = clientNameComboBox.Text;
                String condition = "CLT_NAME LIKE '" + oldclientName + "'";

                String sqlCommand = "Select CLT_NAME FROM merp.clients "
                    + " WHERE ( " + condition + " )";
                    
                cmd.CommandText = sqlCommand;

                reader = cmd.ExecuteReader();

                
                String newClientName = newClientNameTB.Text;
                if (reader.HasRows)
                {
                    reader.Close();
                    if (newClientName != "" && newClientName != null)
                    {
                        cmd.CommandText = "UPDATE        merp.clients" +
                                    " SET  CLT_NAME = '" + newClientName + "'"
                                    + " WHERE ( " + condition + " ) ";

                        cmd.ExecuteReader().Close();

                        
                        MessageBox.Show("تم اجراء التعديل بنجاح");

                        newClientNameTB.Text = "";
                        resetClientNameComboBox();
                        clientNameComboBox.Text = newClientName;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن ترك اسم العميل فارغ");
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("يجب اختيار عميل اولا");
                }

                Varibles.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
