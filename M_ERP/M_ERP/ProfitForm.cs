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


namespace M_ERP
{
    public partial class ProfitForm : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;
        Double totalSale, totalCost, totalExpenditure,totalProfit;
        int SellType = 1;
        
        public ProfitForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();
          

         

           
            
        }





        
   

  

 


        private void populateLogInv() {


            String prdName = "", prdType = "", logDesc = "";
            Double currentBuyPrice = 0, currentSellPrice = 0;
            DateTime logDate ;
            Int32 prdID = 0, logIN = 0, logOUT = 0, logInvID = 0;

            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);

            String query = "SELECT INVLOG_PROD_ID, PRD_NAME, PRDTYP_NAME, PRD_WHLSALEPRICE, " +
                         "PRD_SCTRPRICE, PRD_BUYPRICE, INVLOG_DATE, INVLOG_DESC, " +
                         "INVLOG_OUTCOUNT, INVLOG_INCOUNT, INVLOG_INV_ID , current_buy_price , current_sell_price  " +
                         " FROM merp.inventory_log, merp.products, merp.prod_types , merp.invoices " +
                         "WHERE INVLOG_PROD_ID = PRD_ID AND PRD_TYPE_ID=PRDTYP_ID AND inventory_log.INVLOG_INV_ID = invoices.INV_ID AND inventory_log.invoice_type = invoices.INV_TYPE_ID  AND invoices.INV_FLAG= '0'  AND inventory_log.invoice_type = '" + SellType + "'AND  INVLOG_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") +
                          "' AND INVLOG_DATE <= '" + date2.ToString("yyyy-MM-dd HH:mm:ss") + "'  ORDER BY  INVLOG_DATE ASC ";

            cmd.CommandText = query;

            reader = cmd.ExecuteReader();

            totalSale = 0; totalCost = 0;
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

                totalSale += (currentSellPrice * logOUT);
                totalCost += (currentBuyPrice * logOUT);

                try
                {
                    logInvID = reader.GetInt32("INVLOG_INV_ID");
                }
                catch (SystemException ex) { }

                dGridV_InvenLog.Rows.Add(prdID, prdType, prdName,  logOUT,logIN ,currentSellPrice, currentBuyPrice, logInvID, logDate, logDesc);

                
            }
            reader.Close();
        }

        private void populateGrid() {

            

            dGridV_InvenLog.Rows.Clear();


            DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

            DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);
            

            try
            {
              
               
                
                populateLogInv();
                salesTB.Text = "" + Decimal.Parse(totalSale.ToString("0.00"));
                
                costTB.Text = "" + Decimal.Parse(totalCost.ToString("0.00"));
               
            }
            catch (SystemException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
                
            }
            reader.Close();
            
        }

      

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            totalProfit = 0;

            populateGrid();
            populateGridTreasury();

            totalProfit = totalSale - (totalCost + totalExpenditure);
            netProfitTB.Text = "" + Decimal.Parse(totalProfit.ToString("0.00"));
        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            totalProfit = 0;

            populateGrid();
            populateGridTreasury();

            totalProfit = totalSale - (totalCost + totalExpenditure);
            netProfitTB.Text = "" + Decimal.Parse(totalProfit.ToString("0.00"));
        }

        private void InventoryLog_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void populateGridTreasury()
        {

            try
            {
                String query;

                DateTime date1 = new DateTime(dtp_from.Value.Year, dtp_from.Value.Month, dtp_from.Value.Day, 0, 0, 0);

                DateTime date2 = new DateTime(dtp_to.Value.Year, dtp_to.Value.Month, dtp_to.Value.Day, 23, 59, 59);



                

                    query = "SELECT TE_DATE, TE_IN, TE_OUT, TE_OPTITLE, TE_CMMTS FROM merp.treasuryentries " +
                             " WHERE TE_OPTYPE_ID=3 AND TE_DATE >= '" + date1.ToString("yyyy-MM-dd HH:mm:ss") + "' AND TE_DATE <= '" +
                             date2.ToString("yyyy-MM-dd HH:mm:ss") + "'";
         


                cmd.CommandText = query;
                treasuryGridView.Rows.Clear();
                reader = cmd.ExecuteReader();

                DateTime TEDate;
                Double In, Out;
                String TETitle, TENotes;
                Double TotalIn = 0, TotalOut = 0, totalAll = 0;
                totalExpenditure = 0;

                while (reader.Read())
                {
                    TEDate = reader.GetDateTime("TE_DATE");
                    In = reader.GetDouble("TE_IN");
                    Out = reader.GetDouble("TE_OUT");
                    TETitle = reader.GetString("TE_OPTITLE");
                    TENotes = reader.GetString("TE_CMMTS");

                    totalExpenditure += Out;

                    treasuryGridView.Rows.Add(TEDate, Out, In, TETitle, TENotes);

                }
                expendsTB.Text = "" + Decimal.Parse(totalExpenditure.ToString("0.00"));

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                
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
                //MessageBox.Show("Itmp loop");
                foreach (DataGridViewColumn GridCol in dGridV_InvenLog.Columns)
                {
                    iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                   (double)iTotalWidth * (double)iTotalWidth *
                                   ((double)e.MarginBounds.Width / (double)iTotalWidth))));
                    //MessageBox.Show("iTMP" + iTmpWidth);
                    iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

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
                int iCount = 0;
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
                        e.Graphics.DrawString("تقارير الخزينة", new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقارير الخزينة", new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        //Draw Date
                        e.Graphics.DrawString(strDate, new Font(dGridV_InvenLog.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                e.Graphics.MeasureString(strDate, new Font(dGridV_InvenLog.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقارير الخزينة", new Font(new Font(dGridV_InvenLog.Font,
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
                            iCount++;

                        }
                        bNewPage = false;
                        iTopMargin += iHeaderHeight;
                    }
                    iCount = 0;
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

                        iCount++;
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

        }

    }
}
