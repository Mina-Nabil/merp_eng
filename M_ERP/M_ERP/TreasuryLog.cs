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
    public partial class TreasuryLog : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;
        DateTime from;
        DateTime to;
        int TEType;
        bool AllTypes = false;

        public TreasuryLog()
        {

            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            fillTreasuryEntryTypes();
        }

        private void fillTreasuryEntryTypes()
        {
            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();

                String sqlCommand = "SELECT TRTYPE_ID, TRTYPE_NAME FROM merp.treasury_op_type";

                cmd.CommandText = sqlCommand;

                MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, Varibles.getConnection());
                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.ExecuteNonQuery();

                cmb_TEType.DisplayMember = "TRTYPE_NAME";
                cmb_TEType.ValueMember = "TRTYPE_ID";
                cmb_TEType.DataSource = ds.Tables[0];


          //      cmb_TEType.AutoCompleteMode = AutoCompleteMode.Suggest;
         //       cmb_TEType.AutoCompleteSource = AutoCompleteSource.ListItems;
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


        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            to = dtp_to.Value;
            populateGrid();
        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            from = dtp_from.Value;
            populateGrid();
        }

        private void cmb_TEType_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            TEType = Convert.ToInt32(cmb_TEType.SelectedValue);
            populateGrid();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AllTypes = checkBox1.Checked;
            populateGrid();
        }

        private void populateGrid() {

            try
            {
                Varibles.setConnection();
                cmd = Varibles.getCommand();
                String query;

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

                

                if (AllTypes == true)
                {
                    query = "SELECT TE_DATE, TE_IN, TE_OUT, TE_OPTITLE, TE_CMMTS FROM merp.treasuryentries " +
                             " WHERE TE_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND TE_DATE <= '" +
                             date2.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                }
                else
                {
                    query = "SELECT TE_DATE, TE_IN, TE_OUT, TE_OPTITLE, TE_CMMTS FROM merp.treasuryentries " +
                             " WHERE TE_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND TE_DATE <= '" +
                             date2.ToString("yyyy-MM-dd HH:mm:ss") + "' AND TE_OPTYPE_ID = " + TEType;
                }

                cmd.CommandText = query;
                dGridV_InvenLog.Rows.Clear();
                reader = cmd.ExecuteReader();

                DateTime TEDate;
                Double In, Out;
                String TETitle, TENotes;
                Double TotalIn = 0, TotalOut = 0, totalAll=0;
                
                while (reader.Read())
                {
                    TEDate = reader.GetDateTime("TE_DATE");
                    In = reader.GetDouble("TE_IN");
                    Out = reader.GetDouble("TE_OUT");
                    TETitle = reader.GetString("TE_OPTITLE");
                    TENotes = reader.GetString("TE_CMMTS");
                    TotalIn = TotalIn + In;
                    TotalOut = TotalOut + Out;
                    dGridV_InvenLog.Rows.Add(TEDate, Out, In, TETitle, TENotes);

                }
                txt_TotalIn.Text = Convert.ToString(TotalIn);
                txt_TotalOut.Text = Convert.ToString(TotalOut);

                if (checkBox1.Checked)
                {

                    totalAll = TotalIn - TotalOut;
                    netSaleBox.Text = Convert.ToString(totalAll);
                }
                else
                {
                    netSaleBox.Text = "0"; 
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

        private void TeasuryLog_Load(object sender, EventArgs e)
        {

        }

        private void txt_TotalIn_TextChanged(object sender, EventArgs e)
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
                int iCount = 4;
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
                            iCount--;

                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 4;
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
                printDocument1.DocumentName = "Test Page Print";
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
                string filepath = fbd.SelectedPath + "\\تقارير الخزينة.xlsx";
                int i = 1;


                filepath = fbd.SelectedPath + "\\تقارير الخزينة" + "_" + date  + ".xls";

                list_export = xlApp.Workbooks.Add();
                Worksheet_export = list_export.Worksheets.Add();
                Worksheet_export.Name = "تقارير الخزينة";
                Worksheet_export.DisplayRightToLeft = true;

                Worksheet_export.Cells[1, 5] = "ملاحظات";
                Worksheet_export.Cells[1, 4] = "نوع الحركة";
                Worksheet_export.Cells[1, 3] = "وارد";
                Worksheet_export.Cells[1, 2] = "صادر";
                Worksheet_export.Cells[1, 1] = "تاريخ";
                
                int iii = 2;
                for (int ii = 0; ii < dGridV_InvenLog.Rows.Count; ii++)
                {

                    DataGridViewRow tempRow = dGridV_InvenLog.Rows[ii];
                    int cell = 1;
                    for (int j = 0; j < tempRow.Cells.Count; j++)
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
    }
}
