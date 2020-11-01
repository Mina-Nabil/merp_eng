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
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace M_ERP
{
    public partial class MainForm : Form
    {
        MySqlDataReader reader;
        MySqlCommand cmd;
        int limit = 50;
        string sSelectedPath = "";
        InvLog invLog = new InvLog();
        public MainForm()
        {
            
            try
            {
                InitializeComponent();
                this.Icon = Properties.Resources.merp1_ExR_icon;
                this.BackgroundImageLayout = ImageLayout.Stretch;
           //     Varibles.setConnection();
            //    cmd = Varibles.getCommand();
                this.MaximizeBox = false;

                if (checkInvoicesCountunderLimit() || Varibles.isActivated())
                {
                    
                }
                else
                {
                    MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
                }

                if (Varibles.getUserId() != 1)
                {
                    setAllVisible(false);
                    getPermisions();
                }
                else
                {
                    setAllVisible(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void getPermisions()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT * FROM merp.usr_prm WHERE PRMUSR_USR_ID = '"+Varibles.getUserId()+"' ";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    int formID = reader.GetInt32("PRMUSR_PRM_ID");
                    setFormVisible(formID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();

            }
        }

        private void setFormVisible(int formID)
        {
            switch (formID)
            {
                case 0 :
                InvoicesToolStripMenuItem.Visible = true;
                sellingnvoicesToolStripMenuItem.Visible = true;
                break;
                case 1 :
                InvoicesToolStripMenuItem.Visible = true;
                buyingInvoicesToolStripMenuItem.Visible = true;

                break;
                case 2:
                InvoicesToolStripMenuItem.Visible = true;
                returnSellingInvoicesToolStripMenuItem.Visible = true;

                break;

                case 3:
                InvoicesToolStripMenuItem.Visible = true;
                returnBuyingInvoicesToolStripMenuItem.Visible = true;

                break;

                case 4:
                clientsToolStripMenuItem.Visible = true;
                clientsDetailsToolStripMenuItem.Visible = true;
                break;

                case 5:
                clientsToolStripMenuItem.Visible = true;
                clientEditToolStripMenuItem.Visible = true;
                break;

                case 6:
                clientsToolStripMenuItem.Visible = true;
                ClientPayableToolStripMenuItem.Visible = true;

                break;

                case 7 :
                clientsToolStripMenuItem.Visible = true;
                ClientRecordsToolStripMenuItem.Visible = true;
                break;

                case 8:
                suppliersToolStripMenuItem.Visible = true;
                suppliersDetailsStripMenuItem.Visible = true;
                break;

                case 9:
                suppliersToolStripMenuItem.Visible = true;
                supplierNameEditToolStripMenuItem.Visible = true;

                break;

                case 10:
                suppliersToolStripMenuItem.Visible = true;
                SuppliersPayableToolStripMenuItem.Visible = true;

                break;

                case 11:
                suppliersToolStripMenuItem.Visible = true;
                SupplierRecordsToolStripMenuItem.Visible = true;
                break;

                case 12:
                InventoryToolStripMenuItem.Visible = true;
                addProdTypeToolStripMenuItem.Visible = true;
                break;

                case 13:
                InventoryToolStripMenuItem.Visible = true;
                addProductToolStripMenuItem.Visible = true;
                break;

                case 14:
                InventoryToolStripMenuItem.Visible = true;
                ItemEdittoolStripMenuItem1.Visible = true;
                break;

                case 15:
                InventoryToolStripMenuItem.Visible = true;
                ItemsUnderLimitToolStripMenuItem.Visible = true;

                break;

                case 16:
                InventoryToolStripMenuItem.Visible = true;
                InventoryBalanceToolStripMenuItem.Visible = true;
                InventoryBalanceToolStripByDateMenuItem.Visible = true;

                break;

                case 17:
                InventoryToolStripMenuItem.Visible = true;
                InventoryLogtoolStripMenuItem1.Visible = true;

                break;

                case 18:
                InventoryToolStripMenuItem.Visible = true;
                itemAddPermissionToolStripMenuItem.Visible = true;

                break;

                case 19:
                InventoryToolStripMenuItem.Visible = true;
                itemRemovePermissionToolStripMenuItem.Visible = true;

                break;

                case 20 :
                treasuryToolStripMenuItem.Visible = true;
                recordTreasuryToolStripMenuItem.Visible = true;
                break;

                case 21:
                treasuryToolStripMenuItem.Visible = true;
                TreasuryLogToolStripMenuItem.Visible = true;
                break;

                case 22:
                treasuryToolStripMenuItem.Visible = true;
                profitToolStripMenuItem.Visible = true;
                break;

                case 23:
                salesToolStripMenuItem.Visible = true;
                salesReportsToolStripMenuItem.Visible = true;
                break;

                case 24:
                boughtToolStripMenuItem.Visible = true;
                boughtReportsToolStripMenuItem.Visible = true;
                break;

                case 25:
                ReciveablePapperToolStripMenuItem.Visible = true;
                RegRecievablePaperToolStripMenuItem.Visible = true;
                break;

                case 26:
                ReciveablePapperToolStripMenuItem.Visible = true;
                ShowRecivablePaperToolStripMenuItem.Visible = true;
                break;

                    
                case 27:
                paymentPapperToolStripMenuItem.Visible = true;
                RegPaymentPaperToolStripMenuItem.Visible = true;
                break;

                case 28:
                paymentPapperToolStripMenuItem.Visible = true;
                ShowPayPaperToolStripMenuItem.Visible = true;
                break;

                

                

                
         
            
            }
        }

        private void setAllVisible(bool tf)
        {
            InvoicesToolStripMenuItem.Visible = tf;
            sellingnvoicesToolStripMenuItem.Visible = tf;
            buyingInvoicesToolStripMenuItem.Visible = tf;
            returnSellingInvoicesToolStripMenuItem.Visible = tf;
            returnBuyingInvoicesToolStripMenuItem.Visible = tf;

            ///////////////////////////////////
            clientsToolStripMenuItem.Visible = tf;
            clientsDetailsToolStripMenuItem.Visible = tf;
            clientEditToolStripMenuItem.Visible = tf;
            ClientPayableToolStripMenuItem.Visible = tf;
            ClientRecordsToolStripMenuItem.Visible = tf;

            ///////////////////////////////////
            suppliersToolStripMenuItem.Visible = tf;
            suppliersDetailsStripMenuItem.Visible = tf;
            supplierNameEditToolStripMenuItem.Visible = tf;
            SuppliersPayableToolStripMenuItem.Visible = tf;
            SupplierRecordsToolStripMenuItem.Visible = tf;

            ///////////////////////////////////////////////
            InventoryToolStripMenuItem.Visible = tf;
            addProdTypeToolStripMenuItem.Visible = tf;
            addProductToolStripMenuItem.Visible = tf;
            ItemEdittoolStripMenuItem1.Visible = tf;
            ItemsUnderLimitToolStripMenuItem.Visible = tf;
            InventoryBalanceToolStripMenuItem.Visible = tf;
            InventoryBalanceToolStripByDateMenuItem.Visible = tf;

            InventoryLogtoolStripMenuItem1.Visible = tf;
            itemAddPermissionToolStripMenuItem.Visible = tf;
            itemRemovePermissionToolStripMenuItem.Visible = tf;
            
            //////////////////////////////////////
            treasuryToolStripMenuItem.Visible = tf;
            recordTreasuryToolStripMenuItem.Visible = tf;
            TreasuryLogToolStripMenuItem.Visible = tf;
            profitToolStripMenuItem.Visible = tf;
            
            ////////////////////////////////////////
            salesToolStripMenuItem.Visible = tf;
            salesReportsToolStripMenuItem.Visible = tf;

            /////////////////////////////////////////////
            boughtToolStripMenuItem.Visible = tf;
            boughtReportsToolStripMenuItem.Visible = tf;

            ///////////////////////////////////////////
            ReciveablePapperToolStripMenuItem.Visible = tf;
            RegRecievablePaperToolStripMenuItem.Visible = tf;
            ShowRecivablePaperToolStripMenuItem.Visible = tf;

            ////////////////////////////////////////
            paymentPapperToolStripMenuItem.Visible = tf;
            RegPaymentPaperToolStripMenuItem.Visible = tf;
            ShowPayPaperToolStripMenuItem.Visible = tf;

            ///////////////////////////////////////
            settingsToolStripMenuItem.Visible = true; // exception because of logout
            logoutToolStripMenuItem.Visible = true;
            createDatabaseToolStripMenuItem.Visible = true;

            /////////////////////////////////////////
            companyDetailsToolStripMenuItem.Visible = tf;
            adminPasswordEditToolStripMenuItem.Visible = tf;
            userPermissionToolStripMenuItem.Visible = tf;
            ActivationToolStripMenuItem.Visible = tf;
            toolStripSeparator5.Visible = tf;
            importDataToolStripMenuItem.Visible = false; //import
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
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

        private void clientsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ClientsDetailsForm form = new ClientsDetailsForm();


                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }



        }

        private void clientEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ClientNameEditForm form = new ClientNameEditForm();


                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void suppliersDetailsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    SupplierDetailsForm form = new SupplierDetailsForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }


        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    CompanyDetailsForm form = new CompanyDetailsForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void adminPasswordEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    AdminPasswordEdit form = new AdminPasswordEdit();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void supplierNameEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    SupplierNameEditForm form = new SupplierNameEditForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ProductAdditionForm form = new ProductAdditionForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void addProdTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ProdTypeMod form = new ProdTypeMod();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void ItemEdittoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ItemCatalogeEdit form = new ItemCatalogeEdit();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void ItemsUnderLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    InventoryLimitCheck form = new InventoryLimitCheck();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void InventoryBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    InventoryBalance form = new InventoryBalance();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void InventoryLogtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    InventoryLog form = new InventoryLog();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void sellingInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    SellInvoicesForm form = new SellInvoicesForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void buyingInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    BuyInvoiceForm form = new BuyInvoiceForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void returnSellingInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    SellReturnInvoiceForm form = new SellReturnInvoiceForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void returnBuyingInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {

                    BuyingReturnInvoiceForm form = new BuyingReturnInvoiceForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void itemAddPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ItemAddPermission form = new ItemAddPermission();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void itemRemovePermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ItemRemovePermission form = new ItemRemovePermission();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void recordTreasuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    RecordTreasury form = new RecordTreasury();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void ClientRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    ClientRecords form = new ClientRecords();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void SupplierRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    SupplierRecords form = new SupplierRecords();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }

        private void ActivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Varibles.isActivated())
            {
                MessageBox.Show("نسخة البرنامج مفعلة " + limit);
            }
            else
            {
                try
                {
                    ActivationForm form = new ActivationForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool checkInventoryLimit()
        {
            int count = 0;

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT Count(*) as count FROM  merp.products WHERE PRD_BALANCE <= PRD_LIMIT ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        count = reader.GetInt32("count");
                    }
                    catch (Exception ex)
                    {
                        count = 0;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();

            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkInvoicesCountunderLimit()
        {
            int count = limit;

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = "SELECT Count(*) as count FROM merp.invoices ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        count = reader.GetInt32("count");
                    }
                    catch (Exception ex)
                    {
                        count = limit;
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                Varibles.closeConnection();

            }

            if (count >= limit)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TreasuryLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    TreasuryLog form = new TreasuryLog();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void RegPaymentPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    RegPaymentPaper form = new RegPaymentPaper();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void RegRecievablePaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    RegRecievablePaper form = new RegRecievablePaper();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void ShowPayPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    ShowPayPapers form = new ShowPayPapers();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void ShowRecivablePaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    ShowRecPapers form = new ShowRecPapers();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void userPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    UserPermissionsForm form = new UserPermissionsForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }
        }

        private void ClientPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    ClientPayables form = new ClientPayables();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void SuppliersPayableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    SuppPayables form = new SuppPayables();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                if (checkInventoryLimit())
                {
                    try
                    {
                        MessageBox.Show("!!! البضاعة فى المخزن اقل من الحد الادنى");
                        InventoryLimitCheck form = new InventoryLimitCheck();

                        form.ShowInTaskbar = false;
                        form.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void boughtReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    BoughtReportForm boughtreportform = new BoughtReportForm();

                    boughtreportform.ShowInTaskbar = false;
                    boughtreportform.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void salesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    SalesReportForm salesreportform = new SalesReportForm();
                    

                    salesreportform.ShowInTaskbar = false;
                    salesreportform.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void profitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {

                try
                {
                    ProfitForm profitform = new ProfitForm();


                    profitform.ShowInTaskbar = false;
                    profitform.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        
        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            createBackup();
             
        }

        private void createBackup()
        {
            String enterDest = "";
            String dest="";

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                enterDest = fbd.SelectedPath;
            }

            String date = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year;

            dest = "cd /d \"C:\\Program Files\\MySQL\\MySQL Server 5.7\\bin \" \n" +
    " set bkupfilename= DB_" + date + ".sql" + "\n" +
    " mysqldump --port 3306 --routines -u root -pm_erp  merp > " + enterDest + "\\\"MERP%bkupfilename%\" \n";
  //  " forfiles /p D:\\mysql_daily_backups /s /m *.* /d -3 /c \"cmd /c del @file : date >= 3days\" \n" + " timeout /t -1 \n";



            //MessageBox.Show(dest);

            System.IO.StreamWriter SW = new System.IO.StreamWriter("test.bat");
            SW.WriteLine(dest);
            SW.Flush();
            SW.Close();
            SW.Dispose();
            SW = null;
            System.Diagnostics.Process.Start("test.bat");







           /* String command = @dest;
            ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            cmdsi.Arguments = command;
            Process cmd = Process.Start(cmdsi);
            cmd.WaitForExit(); */
            
        }


        private static Microsoft.Office.Interop.Excel.Workbook list_Excel;

        private static Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        private static Excel.Worksheet worksheet;
        private static Excel.Worksheet Worksheet_export;
        string prod_name = "", prod_desc = "";
        double prod_Quant = 0,  prod_BuyPrice = 0, prod_GomlaPrice = 0, prod_MefredPrice = 0;
        int prod_id = 0;
        int prd_limit = 0;
        private int product_id = 0;
        String worksheetName = "";
        String barcode = "";
        String prod_typ_name = "";
        String prev_type = "";
        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Worksheet xlWorkSheet;
            try
            {

                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {

                    System.IO.FileInfo File = new System.IO.FileInfo(openFileDialog1.FileName);
                    try
                    {
                        list_Excel = xlApp.Workbooks.Open(File.FullName, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                    }
                    catch (System.Exception ex)
                    {

                    }
                    
                        xlWorkSheet = (Excel.Worksheet)list_Excel.Worksheets.get_Item("Sheet1");
                    
                  
                  
                         

                       //essageBox.Show("" + prod_typ_name);
                        Microsoft.Office.Interop.Excel.Range range = xlWorkSheet.UsedRange;
                        int i = 1;
                        
                        

                        MessageBox.Show("" + range.Rows.Count);
                       // MessageBox.Show("Product id = " + prod_id);
                        for (i = 4; i <= range.Rows.Count; i++)
                        {
                            try
                            {
                                if (xlWorkSheet.Cells[i, 2].Value != null)
                                    barcode = xlWorkSheet.Cells[i, 2].Value;

                                else
                                    barcode = "";
                                if (xlWorkSheet.Cells[i, 3].Value != null)
                                    prod_name = (xlWorkSheet.Cells[i, 3].Value);

                                else
                                    prod_name = "";
                                ///////////////////////////////////////
                                if (xlWorkSheet.Cells[i, 4].Value != null)
                                {
                                    prod_typ_name = xlWorkSheet.Cells[i, 4].Value;

                                }
                                else
                                    prod_typ_name = "";
                                ///////////////////////////////////////

                                if (xlWorkSheet.Cells[i, 5].Value != null)
                                    prod_BuyPrice = Convert.ToDouble(xlWorkSheet.Cells[i, 5].Value);

                                else
                                    prod_BuyPrice = 0;
                                //////////////////////////////////////////

                                if (xlWorkSheet.Cells[i, 8].Value != null)
                                {
                                    prod_MefredPrice = Convert.ToDouble(xlWorkSheet.Cells[i, 8].Value);
                                    prod_GomlaPrice = Convert.ToDouble(xlWorkSheet.Cells[i, 8].Value);
                                }
                                else
                                {
                                    prod_MefredPrice = 0;
                                    prod_GomlaPrice = 0;
                                }//////////////////////////////////////////
                                if (xlWorkSheet.Cells[i, 9].Value != null)
                                    prod_Quant = Convert.ToInt32(xlWorkSheet.Cells[i, 9].Value);
                                else
                                    prod_Quant = 0;
                                ///////////////////////////////////////////
                                if (xlWorkSheet.Cells[i, 10].Value != null)
                                    prd_limit = Convert.ToInt32(xlWorkSheet.Cells[i, 10].Value);
                                else
                                    prd_limit = 0;

                                // MessageBox.Show(prod_name + " , " + prod_Quant + " , " + prod_BuyPrice + " , " + prod_GomlaPrice + " , " + prod_MefredPrice + " , " + limit);


                                try
                                {
                                    add_prod_typ(prod_typ_name);
                                }
                                catch (Exception ex)
                                {
                                }

                                try
                                {
                                    prod_id = get_prod_typ_id(prod_typ_name);

                                    insertIntoProds();

                                    product_id = get_prod_id(prod_name);
                                    // MessageBox.Show("" + product_id);

                                    insertIntoStock();
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                            catch (Exception ex)
                            {

                            }
                            
                        }
                    }
                    MessageBox.Show("تم إدخال البيانات بنجاح");
                    try
                    {
                        //  this.pRODUCTTableAdapter.Fill(this._Cafe_3laWad3o2DataSet.PRODUCT);
                    }
                    catch (System.Exception ex)
                    {
                        xlApp.Quit();
                    }

                    xlApp.Quit();
                }
            
            catch (System.Exception ex)
            {
                xlApp.Quit();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void insertIntoStock()
        {
            if (prod_Quant > 0)
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String query = " Insert Into stock (stock.prod_id, stock.count , stock.buy_price ) " +
                    "VALUES ( " + product_id + " , " + prod_Quant + " , "
                                + prod_BuyPrice + " )";


                DateTime date1 = new DateTime(2017, 9, 11, 0, 0, 1);


                invLog.addToLog(product_id, Convert.ToInt32(prod_Quant), 0, date1, "رصيد اول المخزن", "إضافه", Varibles.user_id, 0, prod_BuyPrice, 0, 0, 0);


                cmd.CommandText = query;

                cmd.ExecuteNonQuery();

                Varibles.closeConnection();
            }
           
        }
        

        private bool checkIsProdFound(int prdId, String prdName)
        {
            int count = 0;

            try
            {


                String query = "SELECT count(*) as countProd FROM merp.products WHERE PRD_TYPE_ID = '" + prdId + "' AND PRD_NAME LIKE  '" + prdName + "' ";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    count = reader.GetInt32("countProd");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }


            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        private void getProdId()
        {

            try
            {
           reader = cmd.ExecuteReader();

                                    while (reader.Read())
                                        {
                                            try
                                            {
                                                prod_id = reader.GetInt32("PRDTYP_ID");
                                                MessageBox.Show("" + prod_id);
                                            }
                                            catch (Exception ex)
                                            {
                                                prod_id = 0;
                                                MessageBox.Show("" + ex);
                                            }
                                        }
    }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                reader.Close();
            }
        }

        private void insertIntoProdTypes()
        {
            try
            {

                String query = "INSERT INTO prod_types (PRDTYP_NAME) VALUES ('" + worksheetName + "')";
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();


            }
            catch (SystemException ex)
            {
                MessageBox.Show("" + ex);
            }
        }


        private void add_prod_typ(String prod_typ_name)
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            String q1 = "INSERT INTO merp.prod_types (PRDTYP_NAME) VALUES ('" + prod_typ_name + "');";
            cmd.CommandText = q1;

            cmd.ExecuteNonQuery();
            Varibles.closeConnection();
        }



        private int get_prod_typ_id(String prod_typ_name)
        {
            int id = 0;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            String q = "SELECT * FROM merp.prod_types WHERE prod_types.PRDTYP_NAME = '" + prod_typ_name + "'";

            cmd.CommandText = q;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    id = reader.GetInt32("PRDTYP_ID");

                }
                catch (Exception ex)
                {
                    id = 0;
                    MessageBox.Show(ex.Message);
                }
            }

            reader.Close();
            Varibles.closeConnection();

            return id;
        }


        private int get_prod_id(String prod_name)
        {
            int id = 0;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            String q = "SELECT * FROM merp.products WHERE products.PRD_NAME = '" + prod_name + "'";

            cmd.CommandText = q;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                try
                {
                    id = reader.GetInt32("PRD_ID");

                }
                catch (Exception ex)
                {
                    id = 0;
                    MessageBox.Show(ex.Message);
                }
            }

            reader.Close();
            Varibles.closeConnection();

            return id;
        }
        private void insertIntoProds()
        {
            Varibles.setConnection();
            cmd = Varibles.getCommand();
            String query;
            try
            {
                if (barcode == "")
                {

                    query = " Insert Into products (products.PRD_NAME, products.PRD_TYPE_ID, products.PRD_LIMIT, products.PRD_BUYPRICE, products.PRD_WHLSALEPRICE, " +
                          " products.PRD_SCTRPRICE, products.PRD_BALANCE  ) VALUES ( '" + prod_name + "' , " + prod_id + " , " + prd_limit + ","
                           + prod_BuyPrice + "," + prod_GomlaPrice + " ," + prod_MefredPrice + ", " + prod_Quant + " )";
                }
                else 
                {
                    query = " Insert Into products (products.PRD_NAME, products.PRD_TYPE_ID, products.PRD_LIMIT, products.PRD_BUYPRICE, products.PRD_WHLSALEPRICE, " +
                         " products.PRD_SCTRPRICE, products.PRD_BALANCE , PRD_BAR_CODE  ) VALUES ( '" + prod_name + "' , " + prod_id + " , " + prd_limit + ","
                          + prod_BuyPrice + "," + prod_GomlaPrice + " ," + prod_MefredPrice + ", " + prod_Quant + " , '" + barcode + "'  )";

                }
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();



            }
            catch (System.Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
            Varibles.closeConnection();
        }

        private void InventoryBalanceToolStripByDateMenuItem_Click(object sender, EventArgs e)
        {

            if (checkInvoicesCountunderLimit() || Varibles.isActivated())
            {
                try
                {
                    InventoryBalanceByDateForm form = new InventoryBalanceByDateForm();

                    form.ShowInTaskbar = false;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("نسخة البرنامج ليست مفعلة و لقد تعديت الحد الاقصى من الفواتير " + limit);
            }

        }
        
    }
}
