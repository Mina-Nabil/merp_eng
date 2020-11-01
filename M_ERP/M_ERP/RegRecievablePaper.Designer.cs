namespace M_ERP
{
    partial class RegRecievablePaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegRecievablePaper));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dGridV_InvenLog = new System.Windows.Forms.DataGridView();
            this.spplrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Spplr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_BNKName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_BNKBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_AccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_PprNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_pprType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Amnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PprType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_ = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PprNo = new System.Windows.Forms.TextBox();
            this.txt_AccNo = new System.Windows.Forms.TextBox();
            this.txt_bankBranch = new System.Windows.Forms.TextBox();
            this.txt_bankName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(88, 596);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 41);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "حـفـظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(88, 218);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 34);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "اضافة";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dGridV_InvenLog
            // 
            this.dGridV_InvenLog.AllowUserToAddRows = false;
            this.dGridV_InvenLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_InvenLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spplrID,
            this.clmn_Spplr,
            this.clmn_BNKName,
            this.clmn_BNKBranch,
            this.clmn_AccNo,
            this.clmn_PprNo,
            this.clmn_ReleaseDate,
            this.clmn_endDate,
            this.clmn_pprType,
            this.clmn_Amnt});
            this.dGridV_InvenLog.Location = new System.Drawing.Point(11, 276);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(855, 295);
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(855, 295);
            this.dGridV_InvenLog.TabIndex = 85;
            // 
            // spplrID
            // 
            this.spplrID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.spplrID.HeaderText = "Column1";
            this.spplrID.Name = "spplrID";
            this.spplrID.Visible = false;
            // 
            // clmn_Spplr
            // 
            this.clmn_Spplr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Spplr.HeaderText = "العميل";
            this.clmn_Spplr.Name = "clmn_Spplr";
            this.clmn_Spplr.Width = 73;
            // 
            // clmn_BNKName
            // 
            this.clmn_BNKName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_BNKName.HeaderText = "اسم البنك";
            this.clmn_BNKName.Name = "clmn_BNKName";
            this.clmn_BNKName.Width = 89;
            // 
            // clmn_BNKBranch
            // 
            this.clmn_BNKBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_BNKBranch.HeaderText = "فرع";
            this.clmn_BNKBranch.Name = "clmn_BNKBranch";
            this.clmn_BNKBranch.Width = 54;
            // 
            // clmn_AccNo
            // 
            this.clmn_AccNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_AccNo.HeaderText = "رقم الحساب";
            this.clmn_AccNo.Name = "clmn_AccNo";
            // 
            // clmn_PprNo
            // 
            this.clmn_PprNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_PprNo.HeaderText = "رقم الورقة";
            this.clmn_PprNo.Name = "clmn_PprNo";
            this.clmn_PprNo.Width = 87;
            // 
            // clmn_ReleaseDate
            // 
            this.clmn_ReleaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ReleaseDate.HeaderText = "تاريخ التحرير";
            this.clmn_ReleaseDate.Name = "clmn_ReleaseDate";
            this.clmn_ReleaseDate.Width = 96;
            // 
            // clmn_endDate
            // 
            this.clmn_endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_endDate.HeaderText = "تاريخ الاستحقاق";
            this.clmn_endDate.Name = "clmn_endDate";
            this.clmn_endDate.Width = 123;
            // 
            // clmn_pprType
            // 
            this.clmn_pprType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_pprType.HeaderText = "نوع الورقه";
            this.clmn_pprType.Name = "clmn_pprType";
            this.clmn_pprType.Width = 86;
            // 
            // clmn_Amnt
            // 
            this.clmn_Amnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Amnt.HeaderText = "المبلغ";
            this.clmn_Amnt.Name = "clmn_Amnt";
            this.clmn_Amnt.Width = 69;
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_Amount.Location = new System.Drawing.Point(49, 156);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Amount.Size = new System.Drawing.Size(238, 27);
            this.txt_Amount.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(309, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 83;
            this.label9.Text = "المبلـغ :";
            // 
            // txt_PprType
            // 
            this.txt_PprType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_PprType.Location = new System.Drawing.Point(49, 110);
            this.txt_PprType.Name = "txt_PprType";
            this.txt_PprType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_PprType.Size = new System.Drawing.Size(238, 27);
            this.txt_PprType.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(309, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 81;
            this.label8.Text = "نوع الورقة :";
            // 
            // dtp_
            // 
            this.dtp_.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_.Location = new System.Drawing.Point(12, 65);
            this.dtp_.Name = "dtp_";
            this.dtp_.Size = new System.Drawing.Size(275, 27);
            this.dtp_.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(309, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 79;
            this.label7.Text = "تاريخ الاستحقاق :";
            // 
            // dtp_releaseDate
            // 
            this.dtp_releaseDate.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_releaseDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_releaseDate.Location = new System.Drawing.Point(12, 21);
            this.dtp_releaseDate.Name = "dtp_releaseDate";
            this.dtp_releaseDate.Size = new System.Drawing.Size(275, 27);
            this.dtp_releaseDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(309, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "تاريخ التحرير :";
            // 
            // txt_PprNo
            // 
            this.txt_PprNo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_PprNo.Location = new System.Drawing.Point(486, 205);
            this.txt_PprNo.Name = "txt_PprNo";
            this.txt_PprNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_PprNo.Size = new System.Drawing.Size(266, 27);
            this.txt_PprNo.TabIndex = 4;
            // 
            // txt_AccNo
            // 
            this.txt_AccNo.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_AccNo.Location = new System.Drawing.Point(486, 161);
            this.txt_AccNo.Name = "txt_AccNo";
            this.txt_AccNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_AccNo.Size = new System.Drawing.Size(266, 27);
            this.txt_AccNo.TabIndex = 3;
            // 
            // txt_bankBranch
            // 
            this.txt_bankBranch.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_bankBranch.Location = new System.Drawing.Point(486, 116);
            this.txt_bankBranch.Name = "txt_bankBranch";
            this.txt_bankBranch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_bankBranch.Size = new System.Drawing.Size(266, 27);
            this.txt_bankBranch.TabIndex = 2;
            // 
            // txt_bankName
            // 
            this.txt_bankName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_bankName.Location = new System.Drawing.Point(486, 72);
            this.txt_bankName.Name = "txt_bankName";
            this.txt_bankName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_bankName.Size = new System.Drawing.Size(266, 27);
            this.txt_bankName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(772, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 72;
            this.label5.Text = "اسم البنك :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(772, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "فـــرع :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(772, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "رقـم حساب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(772, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "رقـم الورقة :";
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(486, 23);
            this.clientNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientNameComboBox.Size = new System.Drawing.Size(266, 27);
            this.clientNameComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(771, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "وارد من :";
            // 
            // RegRecievablePaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(880, 657);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dGridV_InvenLog);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_PprType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_releaseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PprNo);
            this.Controls.Add(this.txt_AccNo);
            this.Controls.Add(this.txt_bankBranch);
            this.Controls.Add(this.txt_bankName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientNameComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegRecievablePaper";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل أوراق القبض";
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dGridV_InvenLog;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PprType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_releaseDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PprNo;
        private System.Windows.Forms.TextBox txt_AccNo;
        private System.Windows.Forms.TextBox txt_bankBranch;
        private System.Windows.Forms.TextBox txt_bankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clientNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn spplrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Spplr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_BNKName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_BNKBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_AccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_PprNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_pprType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Amnt;
    }
}