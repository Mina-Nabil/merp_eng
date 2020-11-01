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
    public partial class RecordTreasury : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;
        TreasuryEntry te;

        public RecordTreasury()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();
            te = new TreasuryEntry();
            fillTreasuryEntryTypes();
        }

        private void fillTreasuryEntryTypes() {

            String sqlCommand = "SELECT TRTYPE_ID, TRTYPE_NAME FROM merp.treasury_op_type";

            cmd.CommandText = sqlCommand;

            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();

            cmb_TEType.DisplayMember = "TRTYPE_NAME";
            cmb_TEType.ValueMember = "TRTYPE_ID";
            cmb_TEType.DataSource = ds.Tables[0];


         //   cmb_TEType.AutoCompleteMode = AutoCompleteMode.Suggest;
         //   cmb_TEType.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void RecordTreasury_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            String TENotes, TETitle;
            Double TEAmount;
            int TETypeID;
            DateTime TEDate;

            TEAmount = Convert.ToDouble(txt_Amount.Text);
            if (txt_Amount.Text == "") { txt_Amount.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (TEAmount <= 0) { txt_Amount.Focus(); MessageBox.Show("لايمكن أن تكون الكمية أقل من 1"); return; };

            if (cmb_TEType.Text == "") { cmb_TEType.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };
            if (txt_TETitle.Text == "") { txt_TETitle.Focus(); MessageBox.Show("من فضلك إستكمل البيانات المطلوبة"); return; };

            try
            {
                TEDate = dtp_TreasEntryDate.Value;
                TETypeID = Convert.ToInt32(cmb_TEType.SelectedValue);
                TEAmount = Convert.ToDouble(txt_Amount.Text);
                TENotes = txt_Notes.Text;
                TETitle = txt_TETitle.Text;

                if (TETypeID == 1)
                {
                    te.addToTreasury(TEAmount, 0, TEDate, TENotes, TETitle, TETypeID, 0, 0,0);
                }
                else
                {
                    te.addToTreasury(0, TEAmount, TEDate, TENotes, TETitle, TETypeID, 0, 0,0);
                }

                MessageBox.Show("تمت العملية بنجاح");
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtp_TreasEntryDate_ValueChanged(object sender, EventArgs e)
        {

        }
    
    
    
    }
}
