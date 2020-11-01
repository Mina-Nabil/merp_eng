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
    public partial class ScanBarcodeForm : Form
    {
        public String barcodePass;
        MySqlCommand cmd;
        MySqlDataReader reader;
        
        public ScanBarcodeForm()
        {
           
;
            try
            {
                InitializeComponent();
                this.MaximizeBox = false;
                this.ActiveControl = barcodeTB2;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DateTime lastKeyPress = DateTime.Now;
        private void barcodeTB_TextChanged(object sender, EventArgs e)
        {

            if (((TimeSpan)(DateTime.Now - lastKeyPress)).TotalMilliseconds > 10)
            {
                barcodeTB2.Text = "";
            }
            lastKeyPress = DateTime.Now;
            barcodePass = Convert.ToString(barcodeTB2);

            this.Close();
        }

       

        
    }
}
