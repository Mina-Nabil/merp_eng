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
    public partial class ProdTypeMod : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;


        public ProdTypeMod()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            fillProdTypes();

            cmbbx_ProdType.SelectedIndex = -1;

            txtbx_editProdName.Enabled = false;
            btn_Edit.Enabled = false;
            btn_Add.Enabled = false;


            this.ActiveControl = txtbx_NewProdType;

            
        }


        private void refreshPage() {
            
            fillProdTypes();

            cmbbx_ProdType.SelectedIndex = -1;

            txtbx_editProdName.Text = "";
            txtbx_NewProdType.Text = "";

            
        }

        private void fillProdTypes()
        {

            try
            {


                String sqlCommand = "SELECT PRDTYP_ID, PRDTYP_NAME FROM merp.prod_types";

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                cmbbx_ProdType.DisplayMember = "PRDTYP_NAME";
                cmbbx_ProdType.ValueMember = "PRDTYP_ID";
                cmbbx_ProdType.DataSource = ds.Tables[0];



                cmbbx_ProdType.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbbx_ProdType.AutoCompleteSource = AutoCompleteSource.ListItems;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {

            if (cmbbx_ProdType.Text == "") { cmbbx_ProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txtbx_editProdName.Text == "") { txtbx_editProdName.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                if (txtbx_editProdName.Text == "")
                {
                    MessageBox.Show("لا يمكن تعديل صنف بدون اسم");
                }
                else
                {
                    EditProdName(Convert.ToInt32(cmbbx_ProdType.SelectedValue), txtbx_editProdName.Text);
                    MessageBox.Show("تــــم تــعديــل اســم النـــوع بنــجاح");
                    refreshPage();
                }
            }
            catch (SystemException ex)
            { 
                MessageBox.Show("Edit Error: " + ex.Message);
            }
        }

        private void EditProdName(int prodID, String NewName) {
            bool isSupplies = is_supplies_change_CB.Checked;
            Int16 is_supplies_int = (isSupplies) ? (Int16)1 : (Int16)0;
            String query = "UPDATE prod_types SET PRDTYP_NAME =  '" + NewName + "', is_supplies = " + is_supplies_int + " WHERE PRDTYP_ID = " + prodID;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        private void AddProdName(String newName,bool isSupplies) {
            Int16 is_supplies_int = (isSupplies) ? (Int16)1 : (Int16)0;
            String query = "INSERT INTO prod_types (PRDTYP_NAME,is_supplies) VALUES ('" + newName + "'," + is_supplies_int + ")";
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtbx_NewProdType.Text == "") { txtbx_NewProdType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                if (txtbx_NewProdType.Text == "")
                {
                    MessageBox.Show("لا يمكن إضافة صنف بدون اسم");
                }
                else
                {
                    AddProdName(txtbx_NewProdType.Text,is_supplies_CB.Checked);
                    MessageBox.Show("تــــم اضـــافــةالنـــوع بنــجاح");
                    refreshPage();
                }
            }
            catch (SystemException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void cmbbx_ProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbx_editProdName.Text = cmbbx_ProdType.Text;
            txtbx_editProdName.Enabled = true;
            btn_Edit.Enabled = true;

            String sqlCommand = "SELECT is_supplies FROM merp.prod_types where PRDTYP_ID = '" + cmbbx_ProdType.SelectedValue + "';";

            cmd.CommandText = sqlCommand;

            reader = cmd.ExecuteReader();

            bool isSupplies = false; 
            while (reader.Read())
            {
                try
                {
                    isSupplies = reader.GetBoolean("is_supplies");
                }
                catch (Exception ex)
                {
                    isSupplies = false;
                }
            }
            is_supplies_change_CB.Checked = isSupplies;
            reader.Close();
        }

        private void ProdTypeMod_Load(object sender, EventArgs e)
        {
        }

        private void cmbbx_ProdType_TextChanged(object sender, EventArgs e)
        {
            txtbx_editProdName.Enabled = false;
            btn_Edit.Enabled = false;

        }

        private void txtbx_NewProdType_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_NewProdType.Text == "")
            {
                btn_Add.Enabled = false;
            }
            else
            {
                btn_Add.Enabled = true;
            }
        }

    }
}
