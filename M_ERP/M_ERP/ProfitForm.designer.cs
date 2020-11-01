namespace M_ERP
{
    partial class ProfitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfitForm));
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.treasuryGridView = new System.Windows.Forms.DataGridView();
            this.clmn_TEDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEOutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEInCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TETitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salesTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.costTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expendsTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.netProfitTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treasuryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridV_InvenLog
            // 
            this.dGridV_InvenLog.AllowUserToAddRows = false;
            this.dGridV_InvenLog.AllowUserToDeleteRows = false;
            this.dGridV_InvenLog.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dGridV_InvenLog.Location = new System.Drawing.Point(12, 174);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(1000, 365);
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.ReadOnly = true;
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(1000, 188);
            this.dGridV_InvenLog.TabIndex = 38;
            // 
            // clmn_ProdID
            // 
            this.clmn_ProdID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdID.HeaderText = "كود الصنف";
            this.clmn_ProdID.Name = "clmn_ProdID";
            this.clmn_ProdID.ReadOnly = true;
            this.clmn_ProdID.Width = 81;
            // 
            // clmn_ProdType
            // 
            this.clmn_ProdType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdType.HeaderText = "نــــوع الصنف";
            this.clmn_ProdType.Name = "clmn_ProdType";
            this.clmn_ProdType.ReadOnly = true;
            this.clmn_ProdType.Width = 92;
            // 
            // clmn_ProdName
            // 
            this.clmn_ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdName.HeaderText = "اســـم الصـــنـف";
            this.clmn_ProdName.Name = "clmn_ProdName";
            this.clmn_ProdName.ReadOnly = true;
            this.clmn_ProdName.Width = 101;
            // 
            // clmn_LogInCount
            // 
            this.clmn_LogInCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogInCount.HeaderText = "صــادر";
            this.clmn_LogInCount.Name = "clmn_LogInCount";
            this.clmn_LogInCount.ReadOnly = true;
            this.clmn_LogInCount.Width = 61;
            // 
            // clmn_LogOutCount
            // 
            this.clmn_LogOutCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogOutCount.HeaderText = "وارد";
            this.clmn_LogOutCount.Name = "clmn_LogOutCount";
            this.clmn_LogOutCount.ReadOnly = true;
            this.clmn_LogOutCount.Width = 51;
            // 
            // clmn_WHLPrice
            // 
            this.clmn_WHLPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_WHLPrice.HeaderText = "سعر البيع";
            this.clmn_WHLPrice.Name = "clmn_WHLPrice";
            this.clmn_WHLPrice.ReadOnly = true;
            this.clmn_WHLPrice.Width = 76;
            // 
            // clmn_BuyPrice
            // 
            this.clmn_BuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_BuyPrice.HeaderText = "سـعـر الـشــراء";
            this.clmn_BuyPrice.Name = "clmn_BuyPrice";
            this.clmn_BuyPrice.ReadOnly = true;
            this.clmn_BuyPrice.Width = 99;
            // 
            // clmn_InvID
            // 
            this.clmn_InvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_InvID.HeaderText = "رقم الفـاتـوره";
            this.clmn_InvID.Name = "clmn_InvID";
            this.clmn_InvID.ReadOnly = true;
            this.clmn_InvID.Width = 93;
            // 
            // clmn_LogDate
            // 
            this.clmn_LogDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogDate.HeaderText = "التـاريـخ";
            this.clmn_LogDate.Name = "clmn_LogDate";
            this.clmn_LogDate.ReadOnly = true;
            this.clmn_LogDate.Width = 69;
            // 
            // clmn_LogDesc
            // 
            this.clmn_LogDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_LogDesc.HeaderText = "المــلاحـظات";
            this.clmn_LogDesc.Name = "clmn_LogDesc";
            this.clmn_LogDesc.ReadOnly = true;
            this.clmn_LogDesc.Width = 85;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1000, 87);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحديد التـاريـخ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(345, 36);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "الـي: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(807, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "مـــن: ";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_to.Location = new System.Drawing.Point(31, 30);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(294, 27);
            this.dtp_to.TabIndex = 3;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_from.Location = new System.Drawing.Point(498, 30);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(292, 27);
            this.dtp_from.TabIndex = 2;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // treasuryGridView
            // 
            this.treasuryGridView.AllowUserToAddRows = false;
            this.treasuryGridView.AllowUserToDeleteRows = false;
            this.treasuryGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.treasuryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treasuryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_TEDate,
            this.clmn_TEOutCount,
            this.clmn_TEInCount,
            this.clmn_TETitle,
            this.clmn_TEDesc});
            this.treasuryGridView.Location = new System.Drawing.Point(179, 395);
            this.treasuryGridView.MaximumSize = new System.Drawing.Size(680, 295);
            this.treasuryGridView.Name = "treasuryGridView";
            this.treasuryGridView.ReadOnly = true;
            this.treasuryGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treasuryGridView.Size = new System.Drawing.Size(680, 180);
            this.treasuryGridView.TabIndex = 45;
            // 
            // clmn_TEDate
            // 
            this.clmn_TEDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEDate.HeaderText = "التـاريـخ";
            this.clmn_TEDate.Name = "clmn_TEDate";
            this.clmn_TEDate.ReadOnly = true;
            this.clmn_TEDate.Width = 69;
            // 
            // clmn_TEOutCount
            // 
            this.clmn_TEOutCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEOutCount.HeaderText = "صــادر";
            this.clmn_TEOutCount.Name = "clmn_TEOutCount";
            this.clmn_TEOutCount.ReadOnly = true;
            this.clmn_TEOutCount.Width = 61;
            // 
            // clmn_TEInCount
            // 
            this.clmn_TEInCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEInCount.HeaderText = "وارد";
            this.clmn_TEInCount.Name = "clmn_TEInCount";
            this.clmn_TEInCount.ReadOnly = true;
            this.clmn_TEInCount.Width = 51;
            // 
            // clmn_TETitle
            // 
            this.clmn_TETitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TETitle.HeaderText = "نــــوع الحـركـة";
            this.clmn_TETitle.Name = "clmn_TETitle";
            this.clmn_TETitle.ReadOnly = true;
            // 
            // clmn_TEDesc
            // 
            this.clmn_TEDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEDesc.HeaderText = "المــلاحـظات";
            this.clmn_TEDesc.Name = "clmn_TEDesc";
            this.clmn_TEDesc.ReadOnly = true;
            this.clmn_TEDesc.Width = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(510, 152);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "المبيعات";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(506, 373);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "المصروفات";
            // 
            // salesTB
            // 
            this.salesTB.BackColor = System.Drawing.SystemColors.Control;
            this.salesTB.Enabled = false;
            this.salesTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.salesTB.Location = new System.Drawing.Point(783, 594);
            this.salesTB.Name = "salesTB";
            this.salesTB.Size = new System.Drawing.Size(100, 27);
            this.salesTB.TabIndex = 65;
            this.salesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(889, 597);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = " إجمالي المبيعات :";
            // 
            // costTB
            // 
            this.costTB.BackColor = System.Drawing.SystemColors.Control;
            this.costTB.Enabled = false;
            this.costTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.costTB.Location = new System.Drawing.Point(531, 594);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(100, 27);
            this.costTB.TabIndex = 67;
            this.costTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(637, 597);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "إجمالي التكلفة :";
            // 
            // expendsTB
            // 
            this.expendsTB.BackColor = System.Drawing.SystemColors.Control;
            this.expendsTB.Enabled = false;
            this.expendsTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.expendsTB.Location = new System.Drawing.Point(271, 594);
            this.expendsTB.Name = "expendsTB";
            this.expendsTB.Size = new System.Drawing.Size(100, 27);
            this.expendsTB.TabIndex = 69;
            this.expendsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(377, 597);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 68;
            this.label7.Text = "إجمالي المصروفات :";
            // 
            // netProfitTB
            // 
            this.netProfitTB.BackColor = System.Drawing.SystemColors.Control;
            this.netProfitTB.Enabled = false;
            this.netProfitTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.netProfitTB.Location = new System.Drawing.Point(12, 594);
            this.netProfitTB.Name = "netProfitTB";
            this.netProfitTB.Size = new System.Drawing.Size(100, 27);
            this.netProfitTB.TabIndex = 71;
            this.netProfitTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(118, 597);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "صافي الربحية :";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1024, 643);
            this.Controls.Add(this.netProfitTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.expendsTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salesTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treasuryGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGridV_InvenLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfitForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الأرباح";
            this.Load += new System.EventHandler(this.InventoryLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treasuryGridView)).EndInit();
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
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView treasuryGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEOutCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEInCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TETitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salesTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expendsTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox netProfitTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}