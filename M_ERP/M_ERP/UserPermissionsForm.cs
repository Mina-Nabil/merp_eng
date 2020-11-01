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
    public partial class UserPermissionsForm : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;

        List<String> permissionArray;

        public UserPermissionsForm()
        {
            permissionArray = new List<string>();
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
        }

        private void UserPermissionsForm_Load(object sender, EventArgs e)
        {
            resetUsersNameComboBox();
            usersComboBox.SelectedIndex = -1;
            fillParentForms();
            fillChildrenForms();
        }

        public void resetUsersNameComboBox()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "SELECT * FROM merp.users WHERE USR_ID <> '1'";
                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                usersComboBox.DisplayMember = "USR_NAME";
                usersComboBox.ValueMember = "USR_ID";
                usersComboBox.DataSource = ds.Tables[0];


                usersComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                usersComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

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

        private void fillParentForms()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "Select Parent_name FROM merp.parents_form";
                cmd.CommandText = sqlCommand;

                reader = cmd.ExecuteReader();



                String parentName;

                while (reader.Read())
                {
                    parentName = reader.GetString("Parent_name");
                    userPermTreeView.Nodes.Add(parentName);
                }

                reader.Close();

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

        private void fillChildrenForms()
        {
            for (int i = 0; i < userPermTreeView.Nodes.Count; i++)
            {
                try
                {
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();

                    String sqlCommand = "Select forms_name FROM merp.forms_name where form_parent = '"+i+"' ";
                    cmd.CommandText = sqlCommand;

                    reader = cmd.ExecuteReader();



                    String formName;

                    while (reader.Read())
                    {
                        formName = reader.GetString("forms_name");
                        userPermTreeView.Nodes[i].Nodes.Add(formName);
                    }

                    reader.Close();

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
        }

        private void putCheckedinTable()
        {
            try
            {
                int selected = Convert.ToInt32(usersComboBox.SelectedValue);
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                for (int i = 0; i < permissionArray.Count; i++)
                {
                    

                    String sqlCommand = "INSERT INTO `merp`.`usr_prm` (`PRMUSR_USR_ID`, `PRMUSR_PRM_ID`) VALUES ('" + selected + "', '" + permissionArray[i] + "');";
                    cmd.CommandText = sqlCommand;

                    cmd.ExecuteNonQuery();
                    

                }
                   
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


        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersComboBox.Text != "")
            {
                try
                {
                    string usrPassword = "";
                    int usrID = Convert.ToInt32(usersComboBox.SelectedValue);
                    Varibles.setConnection();
                    cmd = Varibles.getCommand();

                    String query = "SELECT USR_PASS FROM merp.users WHERE USR_ID = '" + usrID + "' ;";

                    cmd.CommandText = query;

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            usrPassword = reader.GetString("USR_PASS");
                        }
                        catch (Exception ex)
                        {
                            usrPassword = "";
                        }
                    }

                    passTextBox.Text = usrPassword;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Varibles.closeConnection();
                }

                try
                {
                    setPermissionsFalse();
                    setPermissions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("برجاء إدحال اسم الستخدم");
            }
        }

        private void usersComboBox_TextChanged(object sender, EventArgs e)
        {
            passTextBox.Text = "";
        }

        private void setPermissions()
        {
            try
            {
                
                int usrID = Convert.ToInt32(usersComboBox.SelectedValue);
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT * FROM merp.usr_prm WHERE PRMUSR_USR_ID = '" + usrID + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int prm_ID = 0;
                    try
                    {
                        prm_ID = reader.GetInt32("PRMUSR_PRM_ID");

                        int counter = 0;

                        for (int i = 0; i < userPermTreeView.Nodes.Count; i++)
                        {
                            for (int j = 0; j < userPermTreeView.Nodes[i].Nodes.Count; j++)
                            {
                                if (counter == prm_ID)
                                {
                                    userPermTreeView.Nodes[i].Nodes[j].Checked = true;
                                    userPermTreeView.Nodes[i].Checked = true;
                                    userPermTreeView.Nodes[i].Expand(); 
                                }
                                counter++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        prm_ID = 0;
                    }
                }

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

        private void setPermissionsFalse()
        {
            userPermTreeView.CollapseAll();
            for (int i = 0; i < userPermTreeView.Nodes.Count; i++)
            {
                userPermTreeView.Nodes[i].Checked = false;
                for (int j = 0; j < userPermTreeView.Nodes[i].Nodes.Count; j++)
                {
                    
                    userPermTreeView.Nodes[i].Nodes[j].Checked = false;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool newUser = false;
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                int selected = Convert.ToInt32(usersComboBox.SelectedValue);
                string query = "";
                if (selected == 0)
                {
                     query = "INSERT INTO `merp`.`users` (`USR_NAME`, `USR_PASS`) VALUES ('" + usersComboBox.Text + "' , '" + passTextBox.Text + "')";

                     newUser = true;
                }
                else
                {
                    query = "UPDATE        merp.users" +
                                    " SET  USR_NAME = '" + usersComboBox.Text + "' , USR_PASS = '" + passTextBox.Text + "' " +
                                    " WHERE        ( USR_ID = '" + selected + "' )";

                    
                }



                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                if (selected != 0)
                {
                    query = "DELETE FROM usr_prm WHERE PRMUSR_USR_ID = '" + selected + "'";

                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();

                }

                int counter = 0;
                permissionArray = new List<string>();
                for (int i = 0; i < userPermTreeView.Nodes.Count; i++)
                {
                    for (int j = 0; j < userPermTreeView.Nodes[i].Nodes.Count; j++)
                    {
                        if (userPermTreeView.Nodes[i].Nodes[j].Checked == true)
                        {
                            permissionArray.Add(Convert.ToString(counter));
                        }
                        counter++;
                    }
                }
                MessageBox.Show("تم التعديل بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Varibles.closeConnection();


                if (newUser)
                {
                    resetUsersNameComboBox();
                    usersComboBox.SelectedIndex = usersComboBox.Items.Count - 1;
                }

                putCheckedinTable();

                setPermissionsFalse();
                setPermissions();
            }
        }
    }
}
