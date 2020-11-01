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
    public partial class InventoryBalance : Form
    {


        MySqlCommand cmd;
        MySqlDataReader reader;
        bool allProducts = false;

        double sumWHLPrice, sumSCTRPrice, sumValue, sumBUYPrice;
        int sumBLNCE;

        public InventoryBalance()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            fillProdTypes();

            refreshSums();

            cmbbx_ProdType.SelectedIndex = -1;
            cmbbx_ProdName.SelectedIndex = -1;
        }

        private void refreshSums() { 
        sumWHLPrice = 0;
        sumSCTRPrice = 0;
        sumValue = 0;
        sumBUYPrice = 0;
        sumBLNCE = 0;
        
        }

        

        private void fillProdTypes()
        {
            /*
            cmbbx_ProdType.Items.Clear();

            String query = "SELECT PRDTYP_ID, PRDTYP_NAME FROM merp.prod_types";
            cmd.CommandText = query;

            reader = cmd.ExecuteReader();




            while (reader.Read())
            {


                prodTypes.Add(new ComboboxItem(reader.GetString(1), reader.GetInt32(0)));

                //cmbbx_NewProdType.Items.Add(item);
            }
            reader.Close();

            */

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

        private void fillProdName()
        {
            try
            {
                if (chbx_All.Checked == false)
                {
                    int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);

                    String sqlCommand = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_WHLSALEPRICE, PRD_SCTRPRICE, PRD_BUYPRICE " +
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
                else
                {

                    int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);

                    String sqlCommand = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_WHLSALEPRICE, PRD_SCTRPRICE, PRD_BUYPRICE " +
                               " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID ";

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

                    if (allProducts)
                    {
                        allProducts = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbbx_ProdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbx_All.Checked = false;
            dispAllnv.Checked = false;
            
            
            dGridV_prods.Rows.Clear();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);
            String query = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  stock.count , PRD_WHLSALEPRICE, PRD_SCTRPRICE, stock.buy_price , PRD_DESC , merp.prod_types.is_supplies " +
                           " FROM merp.products , merp.prod_types , merp.stock WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_TYPE_ID = '" + prodTypeID +"' AND stock.prod_id = products.PRD_ID "  ;
            fillProdName();

            cmd.CommandText = query;

            reader = cmd.ExecuteReader();


            String prdName, prdType, prdDesc;
            Double prdWHLPrice, prdSCTRPrice, prdBuyPrice;
            Int32 prdBalance, prdID;
            bool is_supplies;
            refreshSums();

            while (reader.Read())
            {
                prdName = reader.GetString("PRD_NAME");
                prdID = reader.GetInt32("PRD_ID");
                prdType = reader.GetString("PRDTYP_NAME");
                prdBalance = reader.GetInt32("count");
                prdWHLPrice = reader.GetDouble("PRD_WHLSALEPRICE");
                prdSCTRPrice = reader.GetDouble("PRD_SCTRPRICE");
                prdBuyPrice = reader.GetDouble("buy_price");
                is_supplies = reader.GetBoolean("is_supplies");
                try
                {
                    prdDesc = reader.GetString("PRD_DESC");
                }
                catch (Exception ex)
                {
                    prdDesc = "";
                }


                sumBLNCE = sumBLNCE + prdBalance;
                sumBUYPrice = sumBUYPrice + (prdBuyPrice * prdBalance);
                sumSCTRPrice = sumSCTRPrice + (prdSCTRPrice * prdBalance);
                sumWHLPrice = sumWHLPrice + (prdWHLPrice * prdBalance);



                dGridV_prods.Rows.Add(prdID, prdType, prdName, prdDesc, prdBalance, prdBuyPrice, prdWHLPrice, prdSCTRPrice, is_supplies);
            }



            updateSums();
            reader.Close();




        }

        private void updateSums()
        {
            txt_BLNCE.Text = Convert.ToString(sumBLNCE);
            txt_SCTRPrice.Text = Convert.ToString(sumSCTRPrice);
            txt_SumWHLPrice.Text = Convert.ToString(sumWHLPrice);
            txt_SumBUYPrice.Text = Convert.ToString(sumBUYPrice);
        }

        private void cmbbx_ProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allProducts)
            {
            }
            else
            {
                chbx_All.Checked = false;
                dispAllnv.Checked = false;

                dGridV_prods.Rows.Clear();
                String prodName = Convert.ToString(this.cmbbx_ProdName.Text);
                String query = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  stock.count , PRD_WHLSALEPRICE, stock.buy_price , PRD_SCTRPRICE , PRD_DESC , merp.prod_types.is_supplies " +
                               " FROM merp.products , merp.prod_types , merp.stock WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_NAME = '" + prodName + "'  AND stock.prod_id = products.PRD_ID ";
                cmd.CommandText = query;

                reader = cmd.ExecuteReader();



                String prdName, prdType, prdDesc;
                Double prdWHLPrice, prdSCTRPrice, prdBuyPrice;
                Int32 prdBalance, prdID;
                bool is_supplies;
                refreshSums();

                while (reader.Read())
                {
                    prdName = reader.GetString("PRD_NAME");
                    prdID = reader.GetInt32("PRD_ID");
                    prdType = reader.GetString("PRDTYP_NAME");
                    prdBalance = reader.GetInt32("count");
                    prdWHLPrice = reader.GetDouble("PRD_WHLSALEPRICE");
                    prdSCTRPrice = reader.GetDouble("PRD_SCTRPRICE");
                    prdBuyPrice = reader.GetDouble("buy_price");
                    is_supplies = reader.GetBoolean("is_supplies");

                    try
                    {
                        prdDesc = reader.GetString("PRD_DESC");
                    }
                    catch (Exception ex)
                    {
                        prdDesc = "";
                    }
                    sumBLNCE = sumBLNCE + prdBalance;
                    sumBUYPrice = sumBUYPrice + (prdBuyPrice * prdBalance);
                    sumSCTRPrice = sumSCTRPrice + (prdSCTRPrice * prdBalance);
                    sumWHLPrice = sumWHLPrice + (prdWHLPrice * prdBalance);

                    dGridV_prods.Rows.Add(prdID, prdType, prdName, prdDesc, prdBalance, prdBuyPrice, prdWHLPrice, prdSCTRPrice,is_supplies);
                }
                updateSums();
                reader.Close();

            }

        }

        private void InventoryBalance_Load(object sender, EventArgs e)
        {
        }

        private void dGridV_prods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                int row = e.RowIndex;

                String prdName, prdType;
                Double prdWHLPrice, prdSCTRPrice, prdBuyPrice;
                Int32 prdBalance, prdID;
                refreshSums();


                prdID = Convert.ToInt32(dGridV_prods.Rows[row].Cells[0].Value.ToString());

                prdType = dGridV_prods.Rows[row].Cells[1].Value.ToString();

                prdName = dGridV_prods.Rows[row].Cells[2].Value.ToString();

                prdBalance = Convert.ToInt32(dGridV_prods.Rows[row].Cells[4].Value.ToString());

                prdBuyPrice = Convert.ToDouble(dGridV_prods.Rows[row].Cells[5].Value.ToString());


                prdWHLPrice = Convert.ToDouble(dGridV_prods.Rows[row].Cells[6].Value.ToString());

                prdSCTRPrice = Convert.ToDouble(dGridV_prods.Rows[row].Cells[7].Value.ToString());




                sumBLNCE = sumBLNCE + prdBalance;
                sumBUYPrice = sumBUYPrice + (prdBuyPrice * prdBalance);
                sumSCTRPrice = sumSCTRPrice + (prdSCTRPrice * prdBalance);
                sumWHLPrice = sumWHLPrice + (prdWHLPrice * prdBalance);

                updateSums();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             */ 
        }

        private void chbx_All_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbx_All.Checked)
                {
                    allProducts = true;
                    fillProdName();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dGridV_prods.Rows.Clear();
                String query = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  stock.count, PRD_WHLSALEPRICE, stock.buy_price, PRD_SCTRPRICE , PRD_DESC , merp.prod_types.is_supplies " +
                               " FROM merp.products , merp.prod_types ,  merp.stock WHERE stock.prod_id = products.PRD_ID AND products.PRD_TYPE_ID = prod_types.PRDTYP_ID ";
                cmd.CommandText = query;

                reader = cmd.ExecuteReader();



                String prdName, prdType, prdDesc = "";
                Double prdWHLPrice, prdSCTRPrice, prdBuyPrice;
                Int32 prdBalance, prdID;
                bool is_supplies;
                refreshSums();

                while (reader.Read())
                {
                    prdName = reader.GetString("PRD_NAME");
                    prdID = reader.GetInt32("PRD_ID");
                    prdType = reader.GetString("PRDTYP_NAME");
                    prdBalance = reader.GetInt32("count");
                    prdWHLPrice = reader.GetDouble("PRD_WHLSALEPRICE");
                    prdSCTRPrice = reader.GetDouble("PRD_SCTRPRICE");
                    prdBuyPrice = reader.GetDouble("buy_price");
                    is_supplies = reader.GetBoolean("is_supplies");

                   try
                    {
                        prdDesc = reader.GetString("PRD_DESC");
                    }
                    catch (Exception ex)
                    {
                        prdDesc = "";
                    }
                    sumBLNCE = sumBLNCE + prdBalance;
                    sumBUYPrice = sumBUYPrice + (prdBuyPrice * prdBalance);
                    sumSCTRPrice = sumSCTRPrice + (prdSCTRPrice * prdBalance);
                    sumWHLPrice = sumWHLPrice + (prdWHLPrice * prdBalance);

                    dGridV_prods.Rows.Add(prdID, prdType, prdName, prdDesc, prdBalance, prdBuyPrice, prdWHLPrice, prdSCTRPrice,is_supplies);
                }
                updateSums();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_BLNCE_TextChanged(object sender, EventArgs e)
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
                for (int w = (dGridV_prods.Columns.Count - 1); w >= 0; w--)
                {
                    tempCol = dGridV_prods.Columns[w];
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

            while (iRow <= dGridV_prods.Rows.Count - 1)
            {
                DataGridViewRow GridRow = dGridV_prods.Rows[iRow];
                //Set the cell height
                iCellHeight = GridRow.Height + 5;
                int iCount = 7;
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
                        e.Graphics.DrawString("تقرير رصيد المخزن", new Font(dGridV_prods.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقرير رصيد المخزن", new Font(dGridV_prods.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        //Draw Date
                        e.Graphics.DrawString(strDate, new Font(dGridV_prods.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                e.Graphics.MeasureString(strDate, new Font(dGridV_prods.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقرير رصيد المخزن", new Font(new Font(dGridV_prods.Font,
                                FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        //Draw Columns                 
                        iTopMargin = e.MarginBounds.Top;
                        foreach (DataGridViewColumn GridCol in dGridV_prods.Columns)
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
                    iCount = 7;
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
                foreach (DataGridViewColumn dgvGridCol in dGridV_prods.Columns)
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
                printDocument1.DocumentName = "تقرير رصيد المخزن";
                printDocument1.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
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
                string filepath = fbd.SelectedPath + "\\رصيد المخزن.xlsx";
                int i = 1;


                filepath = fbd.SelectedPath + "\\رصيد المخزن" + "_" + date + ".xls";

                list_export = xlApp.Workbooks.Add();
                Worksheet_export = list_export.Worksheets.Add();
                Worksheet_export.Name = "رصيد المخزن";
                Worksheet_export.DisplayRightToLeft= true;
               
                Worksheet_export.Cells[1, 8] = "سعر القطاعي";
                Worksheet_export.Cells[1, 7] = "سعر الجملة";
                Worksheet_export.Cells[1, 6] = "سعر الشراء";
                Worksheet_export.Cells[1, 5] = "الرصيد";
                Worksheet_export.Cells[1, 4] = "وصف الصنف";
                Worksheet_export.Cells[1, 3] = "اسم الصنف";
                Worksheet_export.Cells[1, 2] = "نوع الصنف";
                Worksheet_export.Cells[1, 1] = "كود الصنف";

                int iii = 2;
                for (int ii = 0; ii < dGridV_prods.Rows.Count; ii++)
                {

                    DataGridViewRow tempRow = dGridV_prods.Rows[ii];
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
    
    
    
    }

}
