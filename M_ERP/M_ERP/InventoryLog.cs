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
using System.IO;

namespace M_ERP
{
    public partial class InventoryLog : Form
    {
        private static Microsoft.Office.Interop.Excel.Workbook list_Excel;
        private static Microsoft.Office.Interop.Excel.Workbook list_export;

        private static Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        private static Excel.Worksheet xlWorkSheet;
        private static Excel.Worksheet Worksheet_export;

        MySqlCommand cmd;
        MySqlDataReader reader;


        public InventoryLog()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();
          

            fillProdTypes();

            cmbbx_ProdType.SelectedIndex = -1;
            
        }

        private void fillprodNames() {

            try
            {

                int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);

                String sqlCommand = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_WHLSALEPRICE, PRD_SCTRPRICE, PRD_BUYPRICE,  merp.prod_types.is_supplies " +
                           " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_TYPE_ID = " + prodTypeID;

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                cmbbx_ProdName.DisplayMember = "PRD_NAME";
                cmbbx_ProdName.ValueMember = "PRD_ID";
                cmbbx_ProdName.DataSource = ds.Tables[0];


                cmbbx_ProdName.AutoCompleteMode = AutoCompleteMode.Suggest;
                cmbbx_ProdName.AutoCompleteSource = AutoCompleteSource.ListItems;

                cmbbx_ProdName.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
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


        private void cmbbx_ProdType_SelectedIndexChanged(object sender, EventArgs e)
        {

            allCheckBox.Checked = false;
            fillprodNames();
          
            populateGrid();
           
        }

        private void fillLogByType() {
            Int32 prodTypeId = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                            "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, merp.prod_types.is_supplies , " +
                            "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price , prd_current_blnc " +
                            " FROM merp.inventory_log, merp.products, merp.prod_types " +
                            "WHERE INVLOG_PROD_ID = PRD_ID " +
                            "AND PRD_TYPE_ID = PRDTYP_ID " +
                            " AND PRDTYP_ID = " + prodTypeId + " AND INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'";

            cmd.CommandText = query;

            
            
        }

        private void fillLogByName() {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);


            Int32 prodId = Convert.ToInt32(this.cmbbx_ProdName.SelectedValue);
            String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                            "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, merp.prod_types.is_supplies , " +
                            "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price , prd_current_blnc " +
                            " FROM merp.inventory_log, merp.products, merp.prod_types " +
                            "WHERE INVLOG_PROD_ID = PRD_ID " +
                            "AND PRD_TYPE_ID = PRDTYP_ID " +
                            "AND INVLOG_PROD_ID = " + prodId + " AND INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'";

            cmd.CommandText = query;

            
            
        }

        private void fillLogAll()
        {

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                            "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, merp.prod_types.is_supplies , " +
                            "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price , prd_current_blnc " +
                            " FROM merp.inventory_log, merp.products, merp.prod_types " +
                            "WHERE  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                            "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "' AND "+"INVLOG_PROD_ID = PRD_ID " +
                            "AND PRD_TYPE_ID = PRDTYP_ID ";

            cmd.CommandText = query;



        }


        private void populateLog() {


            String prdName = "", prdType = "", logDesc = "";
            Double currentBuyPrice = 0, currentSellPrice = 0;
            DateTime logDate ;
            Int32 prdID = 0, logIN = 0, logOUT = 0, logInvID = 0, currentBlnc = 0, diff = 0;
            bool is_supplies;

            reader = cmd.ExecuteReader();

            while (reader.Read()) {
                prdName = reader.GetString("PRD_NAME");
                prdType = reader.GetString("PRDTYP_NAME");
                logDesc = reader.GetString("INVLOG_DESC");
                currentBuyPrice = reader.GetDouble("current_buy_price");
                currentSellPrice = reader.GetDouble("current_sell_price");
                logDate = reader.GetDateTime("INVLOG_DATE");
                prdID = reader.GetInt32("INVLOG_PROD_ID");
                logIN = reader.GetInt32("INVLOG_INCOUNT");
                logOUT = reader.GetInt32("INVLOG_OUTCOUNT");
                currentBlnc = reader.GetInt32("prd_current_blnc");
                is_supplies = reader.GetBoolean("is_supplies");

                diff = currentBlnc - logOUT + logIN;
                try
                {
                    logInvID = reader.GetInt32("INVLOG_INV_ID");
                }
                catch (SystemException ex) { }

                dGridV_InvenLog.Rows.Add(prdID, prdType, prdName,  logOUT,logIN ,currentBlnc,diff,currentSellPrice, currentBuyPrice,is_supplies ,logInvID, logDate, logDesc);
            }
            reader.Close();
        }

        private void populateGrid() {

            

            dGridV_InvenLog.Rows.Clear();

            try
            {
                if (allCheckBox.Checked == true)
                {
                    fillLogAll();
                }
                else
                {
                    if (cmbbx_ProdName.SelectedIndex == -1)
                    {

                        fillLogByType();
                    }

                    else fillLogByName();
                }
                populateLog();
               
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
                
            }
            reader.Close();
        }

        private void cmbbx_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            allCheckBox.Checked = false;
            populateGrid();

        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void InventoryLog_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.Checked)
            {
                populateGrid();
            }
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
                int iCount =11;
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
                        e.Graphics.DrawString("حركة الأصناف", new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                e.Graphics.MeasureString("حركة الأصناف", new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        //Draw Date
                        e.Graphics.DrawString(strDate, new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                e.Graphics.MeasureString(strDate, new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                e.Graphics.MeasureString("حركة الأصناف", new Font(new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        iTopMargin = e.MarginBounds.Top;
                        foreach (DataGridViewColumn GridCol in dGridV_InvenLog.Columns)
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
                                iCount-- ;
                            
                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 11;
                    //Draw Columns Contents                
                    foreach (DataGridViewCell Cel in GridRow.Cells)
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
                printDocument1.DocumentName = "Page Print";
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }


        public void ExportToExcel()
        {

            xlApp.DisplayAlerts = false;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath != "")
            {
                String date = DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year;
                string filepath = fbd.SelectedPath + "\\حركة الأصناف.xlsx";
                int i = 1;
                
            
                    filepath = fbd.SelectedPath + "\\حركة الأصناف" + "_" + date + ".xls";
                
                list_export = xlApp.Workbooks.Add();
                Worksheet_export = list_export.Worksheets.Add();
                Worksheet_export.DisplayRightToLeft = true;
                Worksheet_export.Name = "حركة الأصناف";

                Worksheet_export.Cells[1, 12] = "ملاحظات";
                Worksheet_export.Cells[1, 11] = "تاريخ";
                Worksheet_export.Cells[1, 10] = "رقم الفاتورة";
                Worksheet_export.Cells[1, 9] = "سعر الشراء";
                Worksheet_export.Cells[1, 8] = "سعر البيع";
                Worksheet_export.Cells[1, 7] = "الكمية بعد الحركة";
                Worksheet_export.Cells[1, 6] = "الكمية قبل الحركة";
                Worksheet_export.Cells[1, 5] = "وارد";
                Worksheet_export.Cells[1, 4] = "صادر";
                Worksheet_export.Cells[1, 3] = "اسم الصنف";
                Worksheet_export.Cells[1, 2] = "نوع الصنف";
                Worksheet_export.Cells[1, 1] = "كود الصنف";

                int iii = 2;
                for (int ii = 0; ii < dGridV_InvenLog.Rows.Count; ii++)
                {
                    
                    DataGridViewRow tempRow = dGridV_InvenLog.Rows[ii];
                    int cell = 12;
                    for (int j = tempRow.Cells.Count - 1; j >= 0 ; j--)
                    {


                        Worksheet_export.Cells[iii, cell].Value = tempRow.Cells[j].Value;



                        
                        cell--;
                         
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
       

       

    }
}
