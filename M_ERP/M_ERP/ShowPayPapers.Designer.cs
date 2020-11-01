namespace M_ERP
{
    partial class ShowPayPapers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPayPapers));
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.PPRID_HIDDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_state = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ref = new System.Windows.Forms.Button();
            this.btn_rec = new System.Windows.Forms.Button();
            this.txt_TotalIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_to
            // 
            this.dtp_to.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_to.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_to.Location = new System.Drawing.Point(39, 25);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(278, 27);
            this.dtp_to.TabIndex = 1;
            this.dtp_to.ValueChanged += new System.EventHandler(this.dtp_to_ValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_from.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_from.Location = new System.Drawing.Point(472, 25);
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
            this.label1.Location = new System.Drawing.Point(333, 29);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "الـي: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(769, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "مـن: ";
            // 
            // dGridV_InvenLog
            // 
            this.dGridV_InvenLog.AllowUserToAddRows = false;
            this.dGridV_InvenLog.AllowUserToDeleteRows = false;
            this.dGridV_InvenLog.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.clmn_Amnt,
            this.PPRID_HIDDEN});
            this.dGridV_InvenLog.Location = new System.Drawing.Point(12, 135);
            this.dGridV_InvenLog.MaximumSize = new System.Drawing.Size(1000, 365);
            this.dGridV_InvenLog.MultiSelect = false;
            this.dGridV_InvenLog.Name = "dGridV_InvenLog";
            this.dGridV_InvenLog.ReadOnly = true;
            this.dGridV_InvenLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_InvenLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridV_InvenLog.Size = new System.Drawing.Size(860, 305);
            this.dGridV_InvenLog.TabIndex = 65;
            // 
            // spplrID
            // 
            this.spplrID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.spplrID.HeaderText = "spplierID_HIDDEN";
            this.spplrID.Name = "spplrID";
            this.spplrID.ReadOnly = true;
            this.spplrID.Visible = false;
            // 
            // clmn_Spplr
            // 
            this.clmn_Spplr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Spplr.HeaderText = "المورد";
            this.clmn_Spplr.Name = "clmn_Spplr";
            this.clmn_Spplr.ReadOnly = true;
            this.clmn_Spplr.Width = 69;
            // 
            // clmn_BNKName
            // 
            this.clmn_BNKName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_BNKName.HeaderText = "اسم البنك";
            this.clmn_BNKName.Name = "clmn_BNKName";
            this.clmn_BNKName.ReadOnly = true;
            this.clmn_BNKName.Width = 89;
            // 
            // clmn_BNKBranch
            // 
            this.clmn_BNKBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_BNKBranch.HeaderText = "فرع";
            this.clmn_BNKBranch.Name = "clmn_BNKBranch";
            this.clmn_BNKBranch.ReadOnly = true;
            this.clmn_BNKBranch.Width = 54;
            // 
            // clmn_AccNo
            // 
            this.clmn_AccNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_AccNo.HeaderText = "رقم الحساب";
            this.clmn_AccNo.Name = "clmn_AccNo";
            this.clmn_AccNo.ReadOnly = true;
            // 
            // clmn_PprNo
            // 
            this.clmn_PprNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_PprNo.HeaderText = "رقم الورقة";
            this.clmn_PprNo.Name = "clmn_PprNo";
            this.clmn_PprNo.ReadOnly = true;
            this.clmn_PprNo.Width = 87;
            // 
            // clmn_ReleaseDate
            // 
            this.clmn_ReleaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ReleaseDate.HeaderText = "تاريخ التحرير";
            this.clmn_ReleaseDate.Name = "clmn_ReleaseDate";
            this.clmn_ReleaseDate.ReadOnly = true;
            this.clmn_ReleaseDate.Width = 96;
            // 
            // clmn_endDate
            // 
            this.clmn_endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_endDate.HeaderText = "تاريخ الاستحقاق";
            this.clmn_endDate.Name = "clmn_endDate";
            this.clmn_endDate.ReadOnly = true;
            this.clmn_endDate.Width = 123;
            // 
            // clmn_pprType
            // 
            this.clmn_pprType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_pprType.HeaderText = "نوع الورقه";
            this.clmn_pprType.Name = "clmn_pprType";
            this.clmn_pprType.ReadOnly = true;
            this.clmn_pprType.Width = 86;
            // 
            // clmn_Amnt
            // 
            this.clmn_Amnt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Amnt.HeaderText = "المبلغ";
            this.clmn_Amnt.Name = "clmn_Amnt";
            this.clmn_Amnt.ReadOnly = true;
            this.clmn_Amnt.Width = 69;
            // 
            // PPRID_HIDDEN
            // 
            this.PPRID_HIDDEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PPRID_HIDDEN.HeaderText = "PaperID_HIDDEN";
            this.PPRID_HIDDEN.Name = "PPRID_HIDDEN";
            this.PPRID_HIDDEN.ReadOnly = true;
            this.PPRID_HIDDEN.Visible = false;
            // 
            // cmb_state
            // 
            this.cmb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_state.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmb_state.FormattingEnabled = true;
            this.cmb_state.Location = new System.Drawing.Point(487, 78);
            this.cmb_state.Name = "cmb_state";
            this.cmb_state.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_state.Size = new System.Drawing.Size(244, 27);
            this.cmb_state.TabIndex = 2;
            this.cmb_state.SelectedIndexChanged += new System.EventHandler(this.cmb_state_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(769, 86);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "الحالة: ";
            // 
            // btn_ref
            // 
            this.btn_ref.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ref.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_ref.ForeColor = System.Drawing.Color.White;
            this.btn_ref.Location = new System.Drawing.Point(211, 459);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(118, 38);
            this.btn_ref.TabIndex = 3;
            this.btn_ref.Text = "رفـض";
            this.btn_ref.UseVisualStyleBackColor = false;
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // btn_rec
            // 
            this.btn_rec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rec.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_rec.ForeColor = System.Drawing.Color.White;
            this.btn_rec.Location = new System.Drawing.Point(74, 459);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(118, 38);
            this.btn_rec.TabIndex = 4;
            this.btn_rec.Text = "دفع";
            this.btn_rec.UseVisualStyleBackColor = false;
            this.btn_rec.Click += new System.EventHandler(this.btn_rec_Click);
            // 
            // txt_TotalIn
            // 
            this.txt_TotalIn.BackColor = System.Drawing.SystemColors.Control;
            this.txt_TotalIn.Enabled = false;
            this.txt_TotalIn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TotalIn.Location = new System.Drawing.Point(517, 469);
            this.txt_TotalIn.Name = "txt_TotalIn";
            this.txt_TotalIn.Size = new System.Drawing.Size(100, 27);
            this.txt_TotalIn.TabIndex = 78;
            this.txt_TotalIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(642, 469);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 77;
            this.label4.Text = "اجمالي المبلغ: ";
            // 
            // ShowPayPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.txt_TotalIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ref);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_state);
            this.Controls.Add(this.dGridV_InvenLog);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowPayPapers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معاينة أوراق الدفع";
            this.Load += new System.EventHandler(this.ShowPayPapers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_InvenLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGridV_InvenLog;
        private System.Windows.Forms.ComboBox cmb_state;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ref;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.TextBox txt_TotalIn;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PPRID_HIDDEN;
    }
}