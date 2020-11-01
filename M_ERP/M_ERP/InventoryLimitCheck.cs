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
    public partial class InventoryLimitCheck : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;



        public InventoryLimitCheck()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Icon = Properties.Resources.merp1_ExR_icon;
            Varibles.setConnection();
            cmd = Varibles.getCommand();

            fillProdTypes();
            cmbbx_ProdType.SelectedIndex = -1;

            AllCheckBox.Checked = true;
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
            AllCheckBox.Checked = false;

            dGridV_prods.Rows.Clear();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);
            String query = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_LIMIT , merp.prod_types.is_supplies " +
                           " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_BALANCE <= PRD_LIMIT AND PRD_TYPE_ID = " + prodTypeID;
            cmd.CommandText = query;

            reader = cmd.ExecuteReader();

            

            String prdName, prdType;

            Int32 prdBalance, prdID, prdLimit, countProd = 0;
            bool is_supplies;

            while (reader.Read())
            {
                prdName = reader.GetString("PRD_NAME");
                prdID = reader.GetInt32("PRD_ID");
                prdType = reader.GetString("PRDTYP_NAME");
                prdBalance = reader.GetInt32("PRD_BALANCE");
                prdLimit = reader.GetInt32("PRD_LIMIT");
                is_supplies = reader.GetBoolean("is_supplies");

                countProd++;


                dGridV_prods.Rows.Add(prdID, prdType, prdName, prdBalance, prdLimit, is_supplies);
            }
            lbl_Count.Text = Convert.ToString(countProd);   
            reader.Close();


        }

        
        private void InventoryLimitCheck_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AllCheckBox.Checked) {
                cmbbx_ProdType.SelectedIndex = -1;
                dGridV_prods.Rows.Clear();

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                int prodTypeID = Convert.ToInt32(this.cmbbx_ProdType.SelectedValue);
                String query = "SELECT PRD_ID, PRD_NAME, PRDTYP_NAME,  PRD_BALANCE, PRD_LIMIT , merp.prod_types.is_supplies " +
                               " FROM merp.products , merp.prod_types WHERE PRDTYP_ID = PRD_TYPE_ID AND PRD_BALANCE <= PRD_LIMIT ";

                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                String prdName, prdType;

                Int32 prdBalance, prdID, prdLimit, countProd = 0;
                bool is_supplies;

                while (reader.Read())
                {
                    prdName = reader.GetString("PRD_NAME");
                    prdID = reader.GetInt32("PRD_ID");
                    prdType = reader.GetString("PRDTYP_NAME");
                    prdBalance = reader.GetInt32("PRD_BALANCE");
                    prdLimit = reader.GetInt32("PRD_LIMIT");
                    is_supplies = reader.GetBoolean("is_supplies");
                    countProd++;


                    dGridV_prods.Rows.Add(prdID, prdType, prdName, prdBalance, prdLimit,is_supplies);
                }
                lbl_Count.Text = Convert.ToString(countProd);
                reader.Close();
 
            }
            else dGridV_prods.Rows.Clear();
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
                        e.Graphics.DrawString("تقرير الأصناف تحت حد الطلب", new Font(dGridV_prods.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقرير الأصناف تحت حد الطلب", new Font(dGridV_prods.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                        String strDate = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
                        //Draw Date
                        e.Graphics.DrawString(strDate, new Font(dGridV_prods.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                e.Graphics.MeasureString(strDate, new Font(dGridV_prods.Font,
                                FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                e.Graphics.MeasureString("تقرير الأصناف تحت حد الطلب", new Font(new Font(dGridV_prods.Font,
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
                printDocument1.DocumentName = "تقرير الأصناف تحت حد الطلب";
                printDocument1.Print();
            }
        }
    }
}
