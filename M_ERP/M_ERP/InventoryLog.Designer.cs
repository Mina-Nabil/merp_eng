namespace M_ERP
{
    partial class InventoryLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryLog));
            this.dGridV_InvenLog = new System.Windows.Forms.DataGridView();
            this.cmbbx_ProdName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbx_ProdType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.clmn_ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogInCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogOutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_WHLPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_BuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_supplies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmn_InvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_LogDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.QuantityBefore,
            this.QuantityAfter,
            this.clmn_WHLPrice,
            this.clmn_BuyPrice,
            this.is_supplies,
            this.clmn_InvID,
            this.clmn_LogDate,
            this.clmn_LogDesc});
            this.dGridV_InvenLog.Location = new System.Drawing.Point(12, 246);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(1000, 365);
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.ReadOnly = true;
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(1000, 365);
            this.dGridV_InvenLog.TabIndex = 38;
            // 
            // cmbbx_ProdName
            // 
            this.cmbbx_ProdName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdName.FormattingEnabled = true;
            this.cmbbx_ProdName.Location = new System.Drawing.Point(307, 74);
            this.cmbbx_ProdName.Name = "cmbbx_ProdName";
            this.cmbbx_ProdName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_ProdName.Size = new System.Drawing.Size(437, 27);
            this.cmbbx_ProdName.TabIndex = 1;
            this.cmbbx_ProdName.SelectedIndexChanged += new System.EventHandler(this.cmbbx_ProdName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(775, 79);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "اسم الصنف: ";
            // 
            // cmbbx_ProdType
            // 
            this.cmbbx_ProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdType.FormattingEnabled = true;
            this.cmbbx_ProdType.Location = new System.Drawing.Point(307, 27);
            this.cmbbx_ProdType.Name = "cmbbx_ProdType";
            this.cmbbx_ProdType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_ProdType.Size = new System.Drawing.Size(437, 27);
            this.cmbbx_ProdType.TabIndex = 0;
            this.cmbbx_ProdType.SelectedIndexChanged += new System.EventHandler(this.cmbbx_ProdType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(774, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "نوع الصنف: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.printBtn);
            this.groupBox1.Controls.Add(this.allCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbbx_ProdType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbbx_ProdName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1000, 126);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 40;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(22, 19);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(140, 41);
            this.printBtn.TabIndex = 39;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(223, 51);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(50, 23);
            this.allCheckBox.TabIndex = 36;
            this.allCheckBox.Text = "الكل";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            // QuantityBefore
            // 
            this.QuantityBefore.HeaderText = "الكمية قبل الحركة";
            this.QuantityBefore.Name = "QuantityBefore";
            this.QuantityBefore.ReadOnly = true;
            this.QuantityBefore.Width = 120;
            // 
            // QuantityAfter
            // 
            this.QuantityAfter.HeaderText = "الكمية بعد الحركة";
            this.QuantityAfter.Name = "QuantityAfter";
            this.QuantityAfter.ReadOnly = true;
            this.QuantityAfter.Width = 120;
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
            // is_supplies
            // 
            this.is_supplies.HeaderText = "مؤن و امدادات";
            this.is_supplies.Name = "is_supplies";
            this.is_supplies.ReadOnly = true;
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
            // InventoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1024, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGridV_InvenLog);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حركة الأصناف";
            this.Load += new System.EventHandler(this.InventoryLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridV_InvenLog;
        private System.Windows.Forms.ComboBox cmbbx_ProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbx_ProdType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogInCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogOutCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityAfter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_WHLPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_BuyPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_supplies;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_InvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_LogDesc;
    }
}