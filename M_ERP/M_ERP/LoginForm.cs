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
    public partial class LoginForm : Form
    {
        
        MySqlCommand cmd;
        MySqlDataReader reader;

        public LoginForm()
        {
            this.AcceptButton = this.LoginBtn;
;
            try
            {


                InitializeComponent();
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Icon = Properties.Resources.merp1_ExR_icon;
                this.MaximizeBox = false;


                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            login();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (!Varibles.getValidConnection())
            {
                try
                {
                    DBConfiguration form = new DBConfiguration();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void userNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }


        private void login()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String username = userNametextBox.Text;
                String pass = PasstextBox.Text;

                if (username == "MMM" && pass == "M123M123M")
                {
                    DBConfiguration form = new DBConfiguration();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    String condition = "USR_NAME LIKE '" + username + "' AND " + "USR_PASS LIKE '" + pass + "' ";
                    cmd.CommandText = "SELECT        USR_NAME , USR_ID" +
                                        " FROM            merp.users" +
                                        " WHERE        ( " + condition + " )";



                    reader = cmd.ExecuteReader();
                    int usr_id = 0;
                    while (reader.Read())
                    {
                        usr_id = reader.GetInt32("USR_ID");
                        break;
                    }

                    Varibles.setUserId(usr_id);


                    if (reader.HasRows)
                    {
                        MainForm form = new MainForm();
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");
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

        private void PasstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }
        
    }
}
