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
    public partial class DBConfiguration : Form
    {
        public DBConfiguration()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
        }

        private void DBConfigBtn_Click(object sender, EventArgs e)
        {
            Varibles.setDBserverame(serverTextBox.Text);
            Varibles.setDBuserID(useridTextBox.Text);
            Varibles.setDBPassword(passwordTextBox.Text);
            Varibles.setDBPort(portTextBox.Text);

            if (Varibles.checkConnection())
            {
                Varibles.setValidConnection(true);
                MessageBox.Show("Valid Connection");

                try
                {
                    LoginForm form = new LoginForm();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                Varibles.setValidConnection(false);

                MessageBox.Show("InValid Connection");
            }

        }

        
       

        private void Activation_Load(object sender, EventArgs e)
        {
         //   MessageBox.Show(Varibles.getDBServerName() + " " + Varibles.getDBUserID() + " " + Varibles.getDBPassword() + " " + Varibles.getDBPort());
            
            serverTextBox.Text = Varibles.getDBServerName();
            useridTextBox.Text = Varibles.getDBUserID();
            passwordTextBox.Text = Varibles.getDBPassword();
            portTextBox.Text = Varibles.getDBPort();

        }
    }
}
