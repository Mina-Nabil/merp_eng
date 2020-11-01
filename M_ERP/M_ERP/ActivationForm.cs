using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace M_ERP
{
    public partial class ActivationForm : Form
    {
        String macAddress = "";
        public ActivationForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            macAddress = GetMacAddress();

            MacAddressTB.Text = macAddress;
        }

        private void ActivationForm_Load(object sender, EventArgs e)
        {

        }

        private string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                
                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            if (Varibles.MD5(macAddress) == activateCodeTB.Text)
            {
                Varibles.setActivated();
                this.Hide();
                this.Close();
                MessageBox.Show("لقد تم تفعيل البرنامج بنجاح");
            }
            else
            {
                MessageBox.Show("كود التفعيل غير صحيح");
                activateCodeTB.Focus();
            }
        }


    }
}
