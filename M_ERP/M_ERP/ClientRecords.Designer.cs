namespace M_ERP
{
    partial class ClientRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRecords));
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.dGridV_InvenLog = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PayedRadioBtn = new System.Windows.Forms.RadioButton();
            this.InvoicesRadioBtn = new System.Windows.Forms.RadioButton();
            this.AllRadioBtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_raseed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TotalOut = new System.Windows.Forms.TextBox();
            this.txt_TotalIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.allClientsCheckBox = new System.Windows.Forms.CheckBox();
            this.clmn_Blnce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEOutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEInCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TETitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_TEDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(734, 170);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "اسـم العميل: ";
            // 
            // dtp_to
            // 
            this.dtp_to.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_to.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_to.Location = new System.Drawing.Point(37, 96);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(275, 27);
            this.dtp_to.TabIndex = 1;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_from.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_from.Location = new System.Drawing.Point(467, 96);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(275, 27);
            this.dtp_from.TabIndex = 0;
            this.dtp_from.ValueChanged += new System.EventHandler(this.dtp_from_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(341, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "الـي: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(776, 102);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 43;
            this.label2.Text = "مـن: ";
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(467, 162);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientNameComboBox.Size = new System.Drawing.Size(252, 27);
            this.clientNameComboBox.TabIndex = 2;
            this.clientNameComboBox.SelectedIndexChanged += new System.EventHandler(this.clientNameComboBox_SelectedIndexChanged);
            // 
            // dGridV_InvenLog
            // 
            this.dGridV_InvenLog.AllowUserToAddRows = false;
            this.dGridV_InvenLog.AllowUserToDeleteRows = false;
            this.dGridV_InvenLog.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridV_InvenLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_InvenLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_Blnce,
            this.ClientNameCol,
            this.clmn_TEOutCount,
            this.clmn_TEInCount,
            this.clmn_TETitle,
            this.clmn_TEDate,
            this.clmn_TEDesc});
            this.dGridV_InvenLog.Location = new System.Drawing.Point(12, 265);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(856, 272);
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.ReadOnly = true;
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(856, 272);
            this.dGridV_InvenLog.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PayedRadioBtn);
            this.groupBox1.Controls.Add(this.InvoicesRadioBtn);
            this.groupBox1.Controls.Add(this.AllRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(185, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 100);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // PayedRadioBtn
            // 
            this.PayedRadioBtn.AutoSize = true;
            this.PayedRadioBtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.PayedRadioBtn.Location = new System.Drawing.Point(117, 55);
            this.PayedRadioBtn.Name = "PayedRadioBtn";
            this.PayedRadioBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PayedRadioBtn.Size = new System.Drawing.Size(77, 23);
            this.PayedRadioBtn.TabIndex = 5;
            this.PayedRadioBtn.TabStop = true;
            this.PayedRadioBtn.Text = "مدفوعات";
            this.PayedRadioBtn.UseVisualStyleBackColor = true;
            this.PayedRadioBtn.CheckedChanged += new System.EventHandler(this.PayedRadioBtn_CheckedChanged);
            // 
            // InvoicesRadioBtn
            // 
            this.InvoicesRadioBtn.AutoSize = true;
            this.InvoicesRadioBtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.InvoicesRadioBtn.Location = new System.Drawing.Point(48, 17);
            this.InvoicesRadioBtn.Name = "InvoicesRadioBtn";
            this.InvoicesRadioBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoicesRadioBtn.Size = new System.Drawing.Size(61, 23);
            this.InvoicesRadioBtn.TabIndex = 4;
            this.InvoicesRadioBtn.TabStop = true;
            this.InvoicesRadioBtn.Text = "فواتير";
            this.InvoicesRadioBtn.UseVisualStyleBackColor = true;
            this.InvoicesRadioBtn.CheckedChanged += new System.EventHandler(this.InvoicesRadioBtn_CheckedChanged);
            // 
            // AllRadioBtn
            // 
            this.AllRadioBtn.AutoSize = true;
            this.AllRadioBtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.AllRadioBtn.Location = new System.Drawing.Point(146, 17);
            this.AllRadioBtn.Name = "AllRadioBtn";
            this.AllRadioBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllRadioBtn.Size = new System.Drawing.Size(49, 23);
            this.AllRadioBtn.TabIndex = 3;
            this.AllRadioBtn.TabStop = true;
            this.AllRadioBtn.Text = "الكل";
            this.AllRadioBtn.UseVisualStyleBackColor = true;
            this.AllRadioBtn.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(206, 560);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "الرصيد :";
            // 
            // txt_raseed
            // 
            this.txt_raseed.BackColor = System.Drawing.SystemColors.Control;
            this.txt_raseed.Enabled = false;
            this.txt_raseed.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_raseed.Location = new System.Drawing.Point(80, 556);
            this.txt_raseed.Name = "txt_raseed";
            this.txt_raseed.Size = new System.Drawing.Size(100, 27);
            this.txt_raseed.TabIndex = 74;
            this.txt_raseed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(479, 560);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "اجمالي مدين :";
            // 
            // txt_TotalOut
            // 
            this.txt_TotalOut.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalOut.Enabled = false;
            this.txt_TotalOut.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TotalOut.Location = new System.Drawing.Point(353, 557);
            this.txt_TotalOut.Name = "txt_TotalOut";
            this.txt_TotalOut.Size = new System.Drawing.Size(100, 27);
            this.txt_TotalOut.TabIndex = 72;
            this.txt_TotalOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalIn
            // 
            this.txt_TotalIn.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalIn.Enabled = false;
            this.txt_TotalIn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TotalIn.Location = new System.Drawing.Point(618, 557);
            this.txt_TotalIn.Name = "txt_TotalIn";
            this.txt_TotalIn.Size = new System.Drawing.Size(100, 27);
            this.txt_TotalIn.TabIndex = 71;
            this.txt_TotalIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(743, 561);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "اجمالي دائن :";
            // 
            // clientBalanceTextBox
            // 
            this.clientBalanceTextBox.Enabled = false;
            this.clientBalanceTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBalanceTextBox.Location = new System.Drawing.Point(298, 27);
            this.clientBalanceTextBox.Name = "clientBalanceTextBox";
            this.clientBalanceTextBox.Size = new System.Drawing.Size(149, 27);
            this.clientBalanceTextBox.TabIndex = 77;
            this.clientBalanceTextBox.Text = "0";
            this.clientBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientBalanceTextBox.TextChanged += new System.EventHandler(this.clientBalanceTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "رصيد العميل:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 79;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(12, 170);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(140, 41);
            this.printBtn.TabIndex = 78;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(248, 31);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 80;
            this.label8.Text = " مدين ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(21, 560);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = " مدين ";
            // 
            // allClientsCheckBox
            // 
            this.allClientsCheckBox.AutoSize = true;
            this.allClientsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.allClientsCheckBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.allClientsCheckBox.Location = new System.Drawing.Point(609, 218);
            this.allClientsCheckBox.Name = "allClientsCheckBox";
            this.allClientsCheckBox.Size = new System.Drawing.Size(84, 23);
            this.allClientsCheckBox.TabIndex = 82;
            this.allClientsCheckBox.Text = "كل العملاء";
            this.allClientsCheckBox.UseVisualStyleBackColor = false;
            this.allClientsCheckBox.CheckedChanged += new System.EventHandler(this.allClientsCheckBox_CheckedChanged);
            // 
            // clmn_Blnce
            // 
            this.clmn_Blnce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Blnce.HeaderText = "رصيد";
            this.clmn_Blnce.Name = "clmn_Blnce";
            this.clmn_Blnce.ReadOnly = true;
            this.clmn_Blnce.Visible = false;
            this.clmn_Blnce.Width = 55;
            // 
            // ClientNameCol
            // 
            this.ClientNameCol.HeaderText = "إسم العميل";
            this.ClientNameCol.Name = "ClientNameCol";
            this.ClientNameCol.ReadOnly = true;
            // 
            // clmn_TEOutCount
            // 
            this.clmn_TEOutCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEOutCount.HeaderText = "دائن";
            this.clmn_TEOutCount.Name = "clmn_TEOutCount";
            this.clmn_TEOutCount.ReadOnly = true;
            this.clmn_TEOutCount.Width = 51;
            // 
            // clmn_TEInCount
            // 
            this.clmn_TEInCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEInCount.HeaderText = "مدين";
            this.clmn_TEInCount.Name = "clmn_TEInCount";
            this.clmn_TEInCount.ReadOnly = true;
            this.clmn_TEInCount.Width = 53;
            // 
            // clmn_TETitle
            // 
            this.clmn_TETitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TETitle.HeaderText = "البيان";
            this.clmn_TETitle.Name = "clmn_TETitle";
            this.clmn_TETitle.ReadOnly = true;
            this.clmn_TETitle.Width = 57;
            // 
            // clmn_TEDate
            // 
            this.clmn_TEDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEDate.HeaderText = "التـاريـخ";
            this.clmn_TEDate.Name = "clmn_TEDate";
            this.clmn_TEDate.ReadOnly = true;
            this.clmn_TEDate.Width = 69;
            // 
            // clmn_TEDesc
            // 
            this.clmn_TEDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_TEDesc.HeaderText = "المــلاحـظات";
            this.clmn_TEDesc.Name = "clmn_TEDesc";
            this.clmn_TEDesc.ReadOnly = true;
            this.clmn_TEDesc.Width = 85;
            // 
            // ClientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(880, 607);
            this.Controls.Add(this.allClientsCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.clientBalanceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_raseed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TotalOut);
            this.Controls.Add(this.txt_TotalIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGridV_InvenLog);
            this.Controls.Add(this.clientNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابات ا لعملاء";
            this.Load += new System.EventHandler(this.ClientRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientNameComboBox;
        private System.Windows.Forms.DataGridView dGridV_InvenLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton AllRadioBtn;
        private System.Windows.Forms.RadioButton PayedRadioBtn;
        private System.Windows.Forms.RadioButton InvoicesRadioBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_raseed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TotalOut;
        private System.Windows.Forms.TextBox txt_TotalIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientBalanceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox allClientsCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Blnce;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEOutCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEInCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TETitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_TEDesc;
    }
}