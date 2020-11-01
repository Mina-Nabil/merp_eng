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
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;

namespace M_ERP
{
    public partial class SupplierRecords : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;

        int ClientID;
        DateTime From, To;
        bool invoices, all = true, paid;

        double splrBalance = 0;


        public SupplierRecords()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            AllRadioBtn.Checked = true;
            resetClientNameComboBox();
        }

        public void resetClientNameComboBox()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "Select SPLR_NAME, SPLR_ID FROM merp.suppliers";
                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                supplierNameComboBox.DisplayMember = "SPLR_NAME";
                supplierNameComboBox.ValueMember = "SPLR_ID";
                supplierNameComboBox.DataSource = ds.Tables[0];


                supplierNameComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                supplierNameComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

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


        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            From = dtp_from.Value;
            populateGrid();
        }

        private void clientNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSupplierBalance();
            ClientID = Convert.ToInt32(supplierNameComboBox.SelectedValue);
            populateGrid();
        }

        private void loadSupplierBalance()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                int splrNameID = Convert.ToInt32(supplierNameComboBox.SelectedValue);

                String query = "SELECT SPLR_BLNCE FROM merp.suppliers WHERE SPLR_ID = '" + splrNameID + "' ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        splrBalance = reader.GetDouble("SPLR_BLNCE");
                    }
                    catch (Exception ex)
                    {
                        splrBalance = 0;
                    }
                }

                supplierBalanceTextBox.Text = splrBalance.ToString("0.00");
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

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            To = dtp_to.Value;
            populateGrid();
        }

       

        private void populateGrid()
        {
            try
            {
                dGridV_InvenLog.Rows.Clear();
                if (invoices)
                {
                    if (allSuppliersCheckBox.Checked)
                    {
                        fillAllInvoices();
                    }
                    else
                    {
                        fillInvoices();
                    }
                }
                else if (paid)
                {
                    if (allSuppliersCheckBox.Checked)
                    {
                        fillAllPayables();
                    }
                    else
                    {
                        fillPayables();
                    }
                }
                else if (all)
                {
                    if (allSuppliersCheckBox.Checked)
                    {
                        fillAllInvoices();
                        fillAllPayables();
                    }
                    else
                    {
                        fillInvoices();
                        fillPayables();
                    }
                    dGridV_InvenLog.Sort(this.clmn_TEDate, ListSortDirection.Descending);
                }


                inTotal();
                outTotal();
                
                double txt_TotalInValue = Convert.ToDouble(txt_TotalIn.Text);
                double txt_TotalOutValue = Convert.ToDouble(txt_TotalOut.Text);
                double txt_raseedValue = 0;

                double totalInFinal = txt_TotalOutValue + splrBalance;

                txt_TotalIn.Text = "" + totalInFinal;


                txt_raseedValue = splrBalance;
                txt_raseed.Text = ""+txt_raseedValue;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillInvoices()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);


                String query = "SELECT SPLR_NAME , INV_CRNTBLNCE, INV_TOTAL, INV_DATE FROM merp.invoices , merp.suppliers WHERE " +
                                    " INV_SPLR = SPLR_ID AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "' AND INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND INV_SPLR = '" + ClientID + "' ;";


                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                Double For, Against, Balance;
                DateTime InvDate;
                String splrName;

                while (reader.Read())
                {
                    splrName = reader.GetString("SPLR_NAME");
                    Against = reader.GetDouble("INV_TOTAL");
                    For = 0;
                    Balance = reader.GetDouble("INV_CRNTBLNCE");
                    InvDate = reader.GetDateTime("INV_DATE");

                    dGridV_InvenLog.Rows.Add(Balance,splrName,  Against , For, "فاتوره", InvDate, "");
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

        private void fillAllInvoices()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);


                String query = "SELECT SPLR_NAME , INV_CRNTBLNCE, INV_TOTAL, INV_DATE FROM merp.invoices , merp.suppliers WHERE " +
                                    " INV_SPLR = SPLR_ID AND INV_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "' AND INV_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND INV_SPLR is not NULL ;";


                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                Double For, Against, Balance;
                DateTime InvDate;
                String splrName;

                while (reader.Read())
                {
                    splrName = reader.GetString("SPLR_NAME");
                    Against = reader.GetDouble("INV_TOTAL");
                    For = 0;
                    Balance = reader.GetDouble("INV_CRNTBLNCE");
                    InvDate = reader.GetDateTime("INV_DATE");

                    dGridV_InvenLog.Rows.Add(Balance, splrName, Against, For, "فاتوره", InvDate, "");
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


        private void fillPayables()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);


                String query = "SELECT SPLR_NAME ,  TE_BLNCE, TE_IN, TE_OUT, TE_CMMTS, TE_DATE FROM merp.treasuryentries , merp.suppliers " +
                                " WHERE TE_SPPLR_ID = SPLR_ID AND  TE_SPPLR_ID = " + ClientID + " AND TE_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") +
                                "' AND TE_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' ;";


                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                Double PaidHim, PaidME, Balance;
                DateTime InvDate;
                String Comments, splrName; 

                while (reader.Read())
                {
                    splrName = reader.GetString("SPLR_NAME");
                    PaidME = reader.GetDouble("TE_IN"); ;
                    PaidHim = reader.GetDouble("TE_OUT");
                    Balance = reader.GetDouble("TE_BLNCE");
                    InvDate = reader.GetDateTime("TE_DATE");
                    Comments = reader.GetString("TE_CMMTS");

                    dGridV_InvenLog.Rows.Add(Balance,splrName, PaidME, PaidHim, "اذن دفع", InvDate, Comments);

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

        private void fillAllPayables()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);


                String query = "SELECT SPLR_NAME ,  TE_BLNCE, TE_IN, TE_OUT, TE_CMMTS, TE_DATE FROM merp.treasuryentries , merp.suppliers " +
                                " WHERE TE_SPPLR_ID = SPLR_ID AND  TE_SPPLR_ID is not NULL AND TE_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") +
                                "' AND TE_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' ;";


                cmd.CommandText = query;
                reader = cmd.ExecuteReader();

                Double PaidHim, PaidME, Balance;
                DateTime InvDate;
                String Comments, splrName;

                while (reader.Read())
                {
                    splrName = reader.GetString("SPLR_NAME");
                    PaidME = reader.GetDouble("TE_IN"); ;
                    PaidHim = reader.GetDouble("TE_OUT");
                    Balance = reader.GetDouble("TE_BLNCE");
                    InvDate = reader.GetDateTime("TE_DATE");
                    Comments = reader.GetString("TE_CMMTS");

                    dGridV_InvenLog.Rows.Add(Balance, splrName, PaidME, PaidHim, "اذن دفع", InvDate, Comments);

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

       
        private void AllRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
            invoices = false;
            all = true; 
            paid = false;
            populateGrid();
        }

        private void InvoicesRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            
            invoices = true;
            all = false;
            paid = false;
            populateGrid();
        }

        private void PayedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
           
            invoices = false;
            all = false;
            paid = true;
            populateGrid();
        }

        private void inTotal()
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < dGridV_InvenLog.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dGridV_InvenLog.Rows[i].Cells[2].Value);
                }
                txt_TotalIn.Text = ""+sum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void outTotal()
        {
            try
            {
                double sum = 0;
                for (int i = 0; i < dGridV_InvenLog.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dGridV_InvenLog.Rows[i].Cells[3].Value);
                }
                txt_TotalOut.Text = ""+sum;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupplierRecords_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dGridV_InvenLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_raseed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TotalOut_TextChanged(object sender, EventArgs e)
        {

        }


        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // try
            //{
            //Set the left margin
            int iLeftMargin = e.MarginBounds.Left;
            //MessageBox.Show("" + iLeftMargin);
            //Set the top margin
            int iTopMargin = e.MarginBounds.Top;
            //Whether more pages have to print or not
            bool bMorePagesToPrint = false;
            int iTmpWidth = 0;

            //For the first page to print set the cell width and header height
            if (bFirstPage)
            {
                DataGridViewColumn tempCol;
                //DataGridViewColumn temp;

                //foreach (DataGridViewColumn GridCol in dGridV_InvenLog.Columns)
                //MessageBox.Show("Itmp loop");
                for (int w = (dGridV_InvenLog.Columns.Count - 1); w >= 0; w--)
                {
                    tempCol = dGridV_InvenLog.Columns[w];
                    //temp = dGridV_InvenLog.Columns[w];

                    iTmpWidth = (int)(Math.Floor((double)((double)tempCol.Width /
                                   (double)iTotalWidth * (double)iTotalWidth *
                                   ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                    //MessageBox.Show("iTMP" + iTmpWidth);
                    iHeaderHeight = (int)(e.Graphics.MeasureString(tempCol.HeaderText,
                                tempCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                    // Save width and height of headres
                    arrColumnLefts.Add(iLeftMargin);
                    arrColumnWidths.Add(iTmpWidth);
                    iLeftMargin += iTmpWidth;
                }
            }

            //Loop till all the grid rows not get printed

            while (iRow <= dGridV_InvenLog.Rows.Count - 1)
            {
                DataGridViewRow GridRow = dGridV_InvenLog.Rows[iRow];
                //Set the cell height
                iCellHeight = GridRow.Height + 5;
                int iCount = 5;
                //Check whether the current page settings allo more rows to print
                if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                {
                    bNewPage = true;
                    bFirstPage = false;
                    bMorePagesToPrint = true;
                    break;
                }
                else
                {
                    if (bNewPage)
                    {
                        //Draw Header
                        e.Graphics.DrawString(supplierNameComboBox.Text +":" + "اسم المورد \n" + "  تقرير حسابات الموردين ", new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                e.Graphics.MeasureString(supplierNameComboBox.Text + ":" + "اسم المورد \n" + "  تقرير حسابات الموردين ", new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        //Draw Date
                        e.Graphics.DrawString(strDate, new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                e.Graphics.MeasureString(strDate, new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                e.Graphics.MeasureString(supplierNameComboBox.Text + ":" + "اسم المورد \n" + "  تقرير حسابات الموردين ", new Font(new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        iTopMargin = e.MarginBounds.Top;
                        foreach (DataGridViewColumn GridCol in dGridV_InvenLog.Columns)
                        {
                            if (GridCol.Index == 0)
                            {

                            }
                            else
                            {

                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount--;

                            }
                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 5;
                    //Draw Columns Contents                
                    foreach (DataGridViewCell Cel in GridRow.Cells)
                    {
                        if (Cel.ColumnIndex == 0)
                        {

                        }
                        else
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //MessageBox.Show("" + iCount);
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount--;
                        }
                    }
                }
                iRow++;
                iTopMargin += iCellHeight;
            }

            //If more lines exist, print another page.
            if (bMorePagesToPrint)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
            //}
            //catch (Exception exc)
            //{
            // MessageBox.Show(exc.Message, "2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Show();
            try
            {
                //MessageBox.Show("am in begin print");
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dGridV_InvenLog.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
                iTotalWidth = iTotalWidth - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;
            //Get the document
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "تقرير حسابات الموردين";
                printDocument1.Print();
            }
        }



        private static Microsoft.Office.Interop.Excel.Workbook list_Excel;
        private static Microsoft.Office.Interop.Excel.Workbook list_export;

        private static Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        private static Excel.Worksheet xlWorkSheet;
        private static Excel.Worksheet Worksheet_export;
        public void ExportToExcel()
        {

            xlApp.DisplayAlerts = false;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                String date = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year;
                string filepath = fbd.SelectedPath + "\\حسابات موردين.xlsx";
                int i = 1;


                filepath = fbd.SelectedPath + "\\حسابات موردين" + "_" + date  + ".xls";

                list_export = xlApp.Workbooks.Add();
                Worksheet_export = list_export.Worksheets.Add();
                Worksheet_export.Name = "حسابات موردين";
                Worksheet_export.DisplayRightToLeft = true;

                if (allSuppliersCheckBox.Checked == false)
                {
                    Worksheet_export.Cells[1, 2] = "اسم المورد";
                    Worksheet_export.Cells[1, 3] = supplierNameComboBox.Text;
                }

                Worksheet_export.Cells[2, 6] = "ملاحظات";
                Worksheet_export.Cells[2, 5] = "تاريخ";
                Worksheet_export.Cells[2, 4] = "البيان";
                Worksheet_export.Cells[2, 3] = "دائن";
                Worksheet_export.Cells[2, 2] = "مدين";
                Worksheet_export.Cells[2, 1] = "إسم المورد";

                int iii = 3;
                for (int ii = 0; ii < dGridV_InvenLog.Rows.Count; ii++)
                {

                    DataGridViewRow tempRow = dGridV_InvenLog.Rows[ii];
                    int cell = 1;
                    for (int j = 1; j < tempRow.Cells.Count; j++)
                    {


                        Worksheet_export.Cells[iii, cell].Value = tempRow.Cells[j].Value;

                        cell++;

                    }

                    iii = iii + 1;
                }

                Worksheet_export.Columns.AutoFit();
                // Worksheet_export.Rows.AutoFit();
                list_export.SaveAs(filepath);

                xlApp.Quit();
                MessageBox.Show("تم حفظ الملف بنجاح");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void supplierBalanceTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void loadAllSupplierBalance()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();


                String query = "SELECT SUM(SPLR_BLNCE) as SumSPLR_BLNCE FROM merp.suppliers ;";

                cmd.CommandText = query;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    try
                    {
                        splrBalance = reader.GetDouble("SumSPLR_BLNCE");
                    }
                    catch (Exception ex)
                    {
                        splrBalance = 0;
                    }
                }

                supplierBalanceTextBox.Text = splrBalance.ToString("0.00");
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

       

        private void allSuppliersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allSuppliersCheckBox.Checked)
            {
                loadAllSupplierBalance();
                populateGrid();
            }
            else
            {
                loadSupplierBalance();
                ClientID = Convert.ToInt32(supplierNameComboBox.SelectedValue);
                populateGrid();
            }
        }


    }
}
