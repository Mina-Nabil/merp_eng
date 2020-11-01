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
    public partial class AdminPasswordEdit : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        public AdminPasswordEdit()
        {
            try
            {
                InitializeComponent();
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Icon = Properties.Resources.merp1_ExR_icon;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmOldPassBtn_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "") { usernameTB.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (passTB.Text == "") { passTB.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };


            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String username = usernameTB.Text;
                String pass = passTB.Text;

                String condition = "USR_NAME LIKE '" + username + "' AND " + "USR_PASS LIKE '" + pass + "' AND USR_ID = "+"1";
                cmd.CommandText = "SELECT        USR_NAME" +
                                    " FROM            merp.users" +
                                    " WHERE        ( " + condition + " )";



                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    this.groupBox2.Visible = true;
                    this.Height = 424;
                    
                }
                else
                {
                    MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");
                    this.groupBox2.Visible = false;
                    this.Height = 234;
                }

                reader.Close();

                Varibles.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminPasswordEdit_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Visible = false;
                this.Height = 234;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (newUser.Text == "") { newUser.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (newPass.Text == "") { newPass.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String username = newUser.Text;
                String pass = newPass.Text;

                String condition = " USR_ID = " + "1";
                cmd.CommandText = "UPDATE        merp.users" +
                                    " SET  USR_NAME = '" + username + "' , USR_PASS = '" + pass + "'" +
                                    " WHERE        ( " + condition + " )";



                cmd.ExecuteReader().Close();
                Varibles.closeConnection();
                
                MessageBox.Show("تم تعديل بيانات المدير بنجاح");


                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
