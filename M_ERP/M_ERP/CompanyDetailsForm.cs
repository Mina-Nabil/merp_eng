using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_ERP
{
    public partial class CompanyDetailsForm : Form
    {
        public CompanyDetailsForm()
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

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (companyNameTB.Text == "") { companyNameTB.Focus(); MessageBox.Show("من فضلك أدخل إسم الشركة"); return; };

            try
            {
                Properties.Settings.Default.companyName = companyNameTB.Text;
                Properties.Settings.Default.companyAddress = AddressTB.Text;
                Properties.Settings.Default.companyMobile = mobileTB.Text;
                Properties.Settings.Default.companyPhone = phoneTB.Text;
                Properties.Settings.Default.companyTaxesCard = TaxesCardTB.Text;
                Properties.Settings.Default.companyCommercialRegister = commercialRegisterTB.Text;

                Properties.Settings.Default.Save();

                MessageBox.Show("تم تعديل بيانات الشركة بنجاح");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompanyDetailsForm_Load(object sender, EventArgs e)
        {
            try
            {
                companyNameTB.Text = Properties.Settings.Default.companyName;
                AddressTB.Text = Properties.Settings.Default.companyAddress;
                mobileTB.Text = Properties.Settings.Default.companyMobile;
                phoneTB.Text = Properties.Settings.Default.companyPhone;
                TaxesCardTB.Text = Properties.Settings.Default.companyTaxesCard;
                commercialRegisterTB.Text = Properties.Settings.Default.companyCommercialRegister;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
