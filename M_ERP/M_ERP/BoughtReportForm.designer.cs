namespace M_ERP
{
    partial class BoughtReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoughtReportForm));
            this.dGridV_InvenLog = new System.Windows.Forms.DataGridView();
            this.clmn_ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogInCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogOutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_WHLPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_InvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.SaleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laterRadioBtn = new System.Windows.Forms.RadioButton();
            this.cashRadioBtn = new System.Windows.Forms.RadioButton();
            this.allPaymentRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.returnSaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.saleOnlyRadioBtn = new System.Windows.Forms.RadioButton();
            this.allInvoicesRadioButton = new System.Windows.Forms.RadioButton();
            this.returnSaleTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.netSaleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.discountSaleReturn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaleDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGridV_InvenLog
            // 
            this.dGridV_InvenLog.AllowUserToAddRows = false;
            this.dGridV_InvenLog.AllowUserToDeleteRows = false;
            this.dGridV_InvenLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGridV_InvenLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_InvenLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_ProdID,
            this.clmn_ProdType,
            this.clmn_ProdName,
            this.clmn_LogInCount,
            this.clmn_LogOutCount,
            this.clmn_WHLPrice,
            this.clmn_BuyPrice,
            this.clmn_InvID,
            this.clmn_LogDate,
            this.clmn_LogDesc});
            this.dGridV_InvenLog.Location = new System.Drawing.Point(15, 300);
            this.dGridV_InvenLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(1333, 449);
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.ReadOnly = true;
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(1333, 449);
            this.dGridV_InvenLog.TabIndex = 38;
            // 
            // clmn_ProdID
            // 
            this.clmn_ProdID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdID.HeaderText = "كود الصنف";
            this.clmn_ProdID.Name = "clmn_ProdID";
            this.clmn_ProdID.ReadOnly = true;
            this.clmn_ProdID.Width = 90;
            // 
            // clmn_ProdType
            // 
            this.clmn_ProdType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdType.HeaderText = "نــــوع الصنف";
            this.clmn_ProdType.Name = "clmn_ProdType";
            this.clmn_ProdType.ReadOnly = true;
            this.clmn_ProdType.Width = 102;
            // 
            // clmn_ProdName
            // 
            this.clmn_ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdName.HeaderText = "اســـم الصـــنـف";
            this.clmn_ProdName.Name = "clmn_ProdName";
            this.clmn_ProdName.ReadOnly = true;
            this.clmn_ProdName.Width = 110;
            // 
            // clmn_LogInCount
            // 
            this.clmn_LogInCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogInCount.HeaderText = "صــادر";
            this.clmn_LogInCount.Name = "clmn_LogInCount";
            this.clmn_LogInCount.ReadOnly = true;
            this.clmn_LogInCount.Width = 70;
            // 
            // clmn_LogOutCount
            // 
            this.clmn_LogOutCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogOutCount.HeaderText = "وارد";
            this.clmn_LogOutCount.Name = "clmn_LogOutCount";
            this.clmn_LogOutCount.ReadOnly = true;
            this.clmn_LogOutCount.Width = 58;
            // 
            // clmn_WHLPrice
            // 
            this.clmn_WHLPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_WHLPrice.HeaderText = "سعر البيع";
            this.clmn_WHLPrice.Name = "clmn_WHLPrice";
            this.clmn_WHLPrice.ReadOnly = true;
            this.clmn_WHLPrice.Width = 79;
            // 
            // clmn_BuyPrice
            // 
            this.clmn_BuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_BuyPrice.HeaderText = "سـعـر الـشــراء";
            this.clmn_BuyPrice.Name = "clmn_BuyPrice";
            this.clmn_BuyPrice.ReadOnly = true;
            this.clmn_BuyPrice.Width = 106;
            // 
            // clmn_InvID
            // 
            this.clmn_InvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_InvID.HeaderText = "رقم الفـاتـوره";
            this.clmn_InvID.Name = "clmn_InvID";
            this.clmn_InvID.ReadOnly = true;
            this.clmn_InvID.Width = 96;
            // 
            // clmn_LogDate
            // 
            this.clmn_LogDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogDate.HeaderText = "التـاريـخ";
            this.clmn_LogDate.Name = "clmn_LogDate";
            this.clmn_LogDate.ReadOnly = true;
            this.clmn_LogDate.Width = 73;
            // 
            // clmn_LogDesc
            // 
            this.clmn_LogDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogDesc.HeaderText = "المــلاحـظات";
            this.clmn_LogDesc.Name = "clmn_LogDesc";
            this.clmn_LogDesc.ReadOnly = true;
            this.clmn_LogDesc.Width = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(16, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1333, 107);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحديد التـاريـخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(460, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "الـي: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1076, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "مـــن: ";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_to.Location = new System.Drawing.Point(41, 37);
            this.dtp_to.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(391, 32);
            this.dtp_to.TabIndex = 3;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_from.Location = new System.Drawing.Point(664, 37);
            this.dtp_from.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(388, 32);
            this.dtp_from.TabIndex = 2;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // SaleBox
            // 
            this.SaleBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SaleBox.Enabled = false;
            this.SaleBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.SaleBox.Location = new System.Drawing.Point(1107, 770);
            this.SaleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaleBox.Name = "SaleBox";
            this.SaleBox.Size = new System.Drawing.Size(132, 32);
            this.SaleBox.TabIndex = 53;
            this.SaleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(1248, 774);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "المشتريات:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.laterRadioBtn);
            this.groupBox1.Controls.Add(this.cashRadioBtn);
            this.groupBox1.Controls.Add(this.allPaymentRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(337, 144);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 140);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طريقة الدفع";
            // 
            // laterRadioBtn
            // 
            this.laterRadioBtn.AutoSize = true;
            this.laterRadioBtn.Location = new System.Drawing.Point(168, 101);
            this.laterRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laterRadioBtn.Name = "laterRadioBtn";
            this.laterRadioBtn.Size = new System.Drawing.Size(58, 29);
            this.laterRadioBtn.TabIndex = 2;
            this.laterRadioBtn.Text = "اجل";
            this.laterRadioBtn.UseVisualStyleBackColor = true;
            this.laterRadioBtn.CheckedChanged += new System.EventHandler(this.laterRadioBtn_CheckedChanged);
            // 
            // cashRadioBtn
            // 
            this.cashRadioBtn.AutoSize = true;
            this.cashRadioBtn.Location = new System.Drawing.Point(171, 66);
            this.cashRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cashRadioBtn.Name = "cashRadioBtn";
            this.cashRadioBtn.Size = new System.Drawing.Size(54, 29);
            this.cashRadioBtn.TabIndex = 1;
            this.cashRadioBtn.Text = "نقدا";
            this.cashRadioBtn.UseVisualStyleBackColor = true;
            this.cashRadioBtn.CheckedChanged += new System.EventHandler(this.cashRadioBtn_CheckedChanged);
            // 
            // allPaymentRadioBtn
            // 
            this.allPaymentRadioBtn.AutoSize = true;
            this.allPaymentRadioBtn.Checked = true;
            this.allPaymentRadioBtn.Location = new System.Drawing.Point(167, 30);
            this.allPaymentRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allPaymentRadioBtn.Name = "allPaymentRadioBtn";
            this.allPaymentRadioBtn.Size = new System.Drawing.Size(59, 29);
            this.allPaymentRadioBtn.TabIndex = 0;
            this.allPaymentRadioBtn.TabStop = true;
            this.allPaymentRadioBtn.Text = "الكل";
            this.allPaymentRadioBtn.UseVisualStyleBackColor = true;
            this.allPaymentRadioBtn.CheckedChanged += new System.EventHandler(this.allRadioBtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.returnSaleRadioBtn);
            this.groupBox3.Controls.Add(this.saleOnlyRadioBtn);
            this.groupBox3.Controls.Add(this.allInvoicesRadioButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(803, 144);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(267, 140);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "نوع الفاتورة";
            // 
            // returnSaleRadioBtn
            // 
            this.returnSaleRadioBtn.AutoSize = true;
            this.returnSaleRadioBtn.Location = new System.Drawing.Point(100, 101);
            this.returnSaleRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnSaleRadioBtn.Name = "returnSaleRadioBtn";
            this.returnSaleRadioBtn.Size = new System.Drawing.Size(122, 29);
            this.returnSaleRadioBtn.TabIndex = 2;
            this.returnSaleRadioBtn.Text = "مرتجع الشراء";
            this.returnSaleRadioBtn.UseVisualStyleBackColor = true;
            this.returnSaleRadioBtn.CheckedChanged += new System.EventHandler(this.returnSaleRadioBtn_CheckedChanged);
            // 
            // saleOnlyRadioBtn
            // 
            this.saleOnlyRadioBtn.AutoSize = true;
            this.saleOnlyRadioBtn.Location = new System.Drawing.Point(157, 64);
            this.saleOnlyRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saleOnlyRadioBtn.Name = "saleOnlyRadioBtn";
            this.saleOnlyRadioBtn.Size = new System.Drawing.Size(66, 29);
            this.saleOnlyRadioBtn.TabIndex = 1;
            this.saleOnlyRadioBtn.Text = "شراء";
            this.saleOnlyRadioBtn.UseVisualStyleBackColor = true;
            this.saleOnlyRadioBtn.CheckedChanged += new System.EventHandler(this.saleOnlyRadioBtn_CheckedChanged);
            // 
            // allInvoicesRadioButton
            // 
            this.allInvoicesRadioButton.AutoSize = true;
            this.allInvoicesRadioButton.Checked = true;
            this.allInvoicesRadioButton.Location = new System.Drawing.Point(167, 30);
            this.allInvoicesRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allInvoicesRadioButton.Name = "allInvoicesRadioButton";
            this.allInvoicesRadioButton.Size = new System.Drawing.Size(59, 29);
            this.allInvoicesRadioButton.TabIndex = 0;
            this.allInvoicesRadioButton.TabStop = true;
            this.allInvoicesRadioButton.Text = "الكل";
            this.allInvoicesRadioButton.UseVisualStyleBackColor = true;
            this.allInvoicesRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // returnSaleTB
            // 
            this.returnSaleTB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.returnSaleTB.Enabled = false;
            this.returnSaleTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.returnSaleTB.Location = new System.Drawing.Point(532, 769);
            this.returnSaleTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnSaleTB.Name = "returnSaleTB";
            this.returnSaleTB.Size = new System.Drawing.Size(132, 32);
            this.returnSaleTB.TabIndex = 63;
            this.returnSaleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.returnSaleTB.TextChanged += new System.EventHandler(this.returnSaleTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(663, 773);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "مرتجع الشراء : ";
            // 
            // netSaleTB
            // 
            this.netSaleTB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.netSaleTB.Enabled = false;
            this.netSaleTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.netSaleTB.Location = new System.Drawing.Point(17, 767);
            this.netSaleTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.netSaleTB.Name = "netSaleTB";
            this.netSaleTB.Size = new System.Drawing.Size(132, 32);
            this.netSaleTB.TabIndex = 65;
            this.netSaleTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(159, 770);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "الاجمالى :";
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(15, 176);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(187, 50);
            this.printBtn.TabIndex = 67;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 50);
            this.button1.TabIndex = 68;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // discountSaleReturn
            // 
            this.discountSaleReturn.BackColor = System.Drawing.SystemColors.Control;
            this.discountSaleReturn.Enabled = false;
            this.discountSaleReturn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.discountSaleReturn.Location = new System.Drawing.Point(247, 769);
            this.discountSaleReturn.Margin = new System.Windows.Forms.Padding(4);
            this.discountSaleReturn.Name = "discountSaleReturn";
            this.discountSaleReturn.Size = new System.Drawing.Size(115, 32);
            this.discountSaleReturn.TabIndex = 75;
            this.discountSaleReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(371, 773);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "خصم مرتجع البيع :";
            // 
            // SaleDiscount
            // 
            this.SaleDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.SaleDiscount.Enabled = false;
            this.SaleDiscount.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.SaleDiscount.Location = new System.Drawing.Point(803, 770);
            this.SaleDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.SaleDiscount.Name = "SaleDiscount";
            this.SaleDiscount.Size = new System.Drawing.Size(132, 32);
            this.SaleDiscount.TabIndex = 73;
            this.SaleDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(944, 773);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "خصم المبيعات :";
            // 
            // BoughtReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1365, 823);
            this.Controls.Add(this.discountSaleReturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaleDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.netSaleTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnSaleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SaleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGridV_InvenLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BoughtReportForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المشتريات";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridV_InvenLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogInCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogOutCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_WHLPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_BuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_InvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogDesc;
        private System.Windows.Forms.TextBox SaleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton laterRadioBtn;
        private System.Windows.Forms.RadioButton cashRadioBtn;
        private System.Windows.Forms.RadioButton allPaymentRadioBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton returnSaleRadioBtn;
        private System.Windows.Forms.RadioButton saleOnlyRadioBtn;
        private System.Windows.Forms.RadioButton allInvoicesRadioButton;
        private System.Windows.Forms.TextBox returnSaleTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox netSaleTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button printBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox discountSaleReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SaleDiscount;
        private System.Windows.Forms.Label label5;
    }
}