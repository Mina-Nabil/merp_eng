namespace M_ERP
{
    partial class TreasuryLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreasuryLog));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.cmb_TEType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dGridV_InvenLog = new System.Windows.Forms.DataGridView();
            this.clmn_TEDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEOutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEInCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TETitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TotalIn = new System.Windows.Forms.TextBox();
            this.txt_TotalOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.netSaleBox = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(652, 40);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "مـن: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "الـي: ";
            // 
            // dtp_from
            // 
            this.dtp_from.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_from.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_from.Location = new System.Drawing.Point(365, 34);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(271, 27);
            this.dtp_from.TabIndex = 0;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // dtp_to
            // 
            this.dtp_to.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_to.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_to.Location = new System.Drawing.Point(12, 33);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(279, 27);
            this.dtp_to.TabIndex = 1;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // cmb_TEType
            // 
            this.cmb_TEType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TEType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmb_TEType.FormattingEnabled = true;
            this.cmb_TEType.Location = new System.Drawing.Point(323, 110);
            this.cmb_TEType.Name = "cmb_TEType";
            this.cmb_TEType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_TEType.Size = new System.Drawing.Size(205, 27);
            this.cmb_TEType.TabIndex = 2;
            this.cmb_TEType.SelectedIndexChanged += new System.EventHandler(this.cmb_TEType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(573, 113);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "نوع الحركه: ";
            // 
            // dGridV_InvenLog
            // 
            this.dGridV_InvenLog.AllowUserToAddRows = false;
            this.dGridV_InvenLog.AllowUserToDeleteRows = false;
            this.dGridV_InvenLog.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridV_InvenLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_InvenLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_TEDate,
            this.clmn_TEOutCount,
            this.clmn_TEInCount,
            this.clmn_TETitle,
            this.clmn_TEDesc});
            this.dGridV_InvenLog.Location = new System.Drawing.Point(21, 179);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(680, 295);
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.ReadOnly = true;
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(680, 295);
            this.dGridV_InvenLog.TabIndex = 44;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(212, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(55, 23);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "عامة";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(611, 509);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "اجمالي الوارد: ";
            // 
            // txt_TotalIn
            // 
            this.txt_TotalIn.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalIn.Enabled = false;
            this.txt_TotalIn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TotalIn.Location = new System.Drawing.Point(505, 506);
            this.txt_TotalIn.Name = "txt_TotalIn";
            this.txt_TotalIn.Size = new System.Drawing.Size(100, 27);
            this.txt_TotalIn.TabIndex = 47;
            this.txt_TotalIn.Text = "7";
            this.txt_TotalIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_TotalIn.TextChanged += new System.EventHandler(this.txt_TotalIn_TextChanged);
            // 
            // txt_TotalOut
            // 
            this.txt_TotalOut.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalOut.Enabled = false;
            this.txt_TotalOut.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TotalOut.Location = new System.Drawing.Point(259, 506);
            this.txt_TotalOut.Name = "txt_TotalOut";
            this.txt_TotalOut.Size = new System.Drawing.Size(100, 27);
            this.txt_TotalOut.TabIndex = 48;
            this.txt_TotalOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(365, 509);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "اجمالي الصادر: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(124, 509);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 50;
            this.label6.Text = "اجمالي الرصيد: ";
            // 
            // netSaleBox
            // 
            this.netSaleBox.BackColor = System.Drawing.SystemColors.Control;
            this.netSaleBox.Enabled = false;
            this.netSaleBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.netSaleBox.Location = new System.Drawing.Point(21, 506);
            this.netSaleBox.Name = "netSaleBox";
            this.netSaleBox.Size = new System.Drawing.Size(100, 27);
            this.netSaleBox.TabIndex = 51;
            this.netSaleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(21, 79);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(140, 41);
            this.printBtn.TabIndex = 52;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 53;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TreasuryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(725, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.netSaleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TotalOut);
            this.Controls.Add(this.txt_TotalIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dGridV_InvenLog);
            this.Controls.Add(this.cmb_TEType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreasuryLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الخزينة";
            this.Load += new System.EventHandler(this.TeasuryLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.ComboBox cmb_TEType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGridV_InvenLog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TotalIn;
        private System.Windows.Forms.TextBox txt_TotalOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEOutCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEInCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TETitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox netSaleBox;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button button1;
    }
}