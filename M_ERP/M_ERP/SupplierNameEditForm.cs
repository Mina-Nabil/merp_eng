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
    public partial class SupplierNameEditForm : Form
    {
        MySqlCommand cmd;
        MySqlDataReader reader;
        public SupplierNameEditForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            }

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (supplierNameComboBox.Text == "") { supplierNameComboBox.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (newSupplierNameTB.Text == "") { newSupplierNameTB.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String oldsupplierName = supplierNameComboBox.Text;
                String condition = "SPLR_NAME LIKE '" + oldsupplierName + "'";

                String sqlCommand = "Select SPLR_NAME FROM merp.suppliers "
                    + " WHERE ( " + condition + " )";

                cmd.CommandText = sqlCommand;

                reader = cmd.ExecuteReader();


                String newSupplierName = newSupplierNameTB.Text;
                if (reader.HasRows)
                {
                    reader.Close();
                    if (newSupplierName != "" && newSupplierName != null)
                    {
                        cmd.CommandText = "UPDATE        merp.suppliers" +
                                    " SET  SPLR_NAME = '" + newSupplierName + "'"
                                    + " WHERE ( " + condition + " ) ";

                        cmd.ExecuteReader().Close();


                        MessageBox.Show("تم اجراء التعديل بنجاح");

                        newSupplierNameTB.Text = "";
                        resetClientNameComboBox();
                        supplierNameComboBox.Text = newSupplierName;
                    }
                    else
                    {
                        MessageBox.Show("لا يمكن ترك اسم المورد فارغ");
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("يجب اختيار مورد اولا");
                }

                Varibles.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupplierNameEditForm_Load(object sender, EventArgs e)
        {
            resetClientNameComboBox();
            supplierNameComboBox.SelectedIndex = -1;
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
    }
}
