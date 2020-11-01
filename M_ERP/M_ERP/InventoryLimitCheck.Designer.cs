namespace M_ERP
{
    partial class InventoryLimitCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryLimitCheck));
            this.cmbbx_ProdType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dGridV_prods = new System.Windows.Forms.DataGridView();
            this.clmn_ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdBlnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_prdLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.AllCheckBox = new System.Windows.Forms.CheckBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.is_supplies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_prods)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbx_ProdType
            // 
            this.cmbbx_ProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdType.FormattingEnabled = true;
            this.cmbbx_ProdType.Location = new System.Drawing.Point(522, 34);
            this.cmbbx_ProdType.Name = "cmbbx_ProdType";
            this.cmbbx_ProdType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_ProdType.Size = new System.Drawing.Size(381, 27);
            this.cmbbx_ProdType.TabIndex = 0;
            this.cmbbx_ProdType.SelectedIndexChanged += new System.EventHandler(this.cmbbx_ProdType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(916, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "نوع الصنف: ";
            // 
            // dGridV_prods
            // 
            this.dGridV_prods.AllowUserToAddRows = false;
            this.dGridV_prods.AllowUserToDeleteRows = false;
            this.dGridV_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_prods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_ProdID,
            this.clmn_ProdType,
            this.clmn_ProdName,
            this.clmn_ProdBlnc,
            this.clmn_prdLimit,
            this.is_supplies});
            this.dGridV_prods.Location = new System.Drawing.Point(12, 111);
            this.dGridV_prods.MaximumSize = new System.Drawing.Size(1000, 371);
            this.dGridV_prods.Name = "dGridV_prods";
            this.dGridV_prods.ReadOnly = true;
            this.dGridV_prods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_prods.Size = new System.Drawing.Size(1000, 371);
            this.dGridV_prods.TabIndex = 33;
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
            // clmn_ProdBlnc
            // 
            this.clmn_ProdBlnc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdBlnc.HeaderText = "الرصـــيـد";
            this.clmn_ProdBlnc.Name = "clmn_ProdBlnc";
            this.clmn_ProdBlnc.ReadOnly = true;
            this.clmn_ProdBlnc.Width = 73;
            // 
            // clmn_prdLimit
            // 
            this.clmn_prdLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_prdLimit.HeaderText = "حـــد الــطـلــب";
            this.clmn_prdLimit.Name = "clmn_prdLimit";
            this.clmn_prdLimit.ReadOnly = true;
            this.clmn_prdLimit.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(677, 537);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "عــدد الاصنـــــاف: ";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Count.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Count.Location = new System.Drawing.Point(540, 537);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Count.Size = new System.Drawing.Size(18, 19);
            this.lbl_Count.TabIndex = 35;
            this.lbl_Count.Text = "0";
            // 
            // AllCheckBox
            // 
            this.AllCheckBox.AutoSize = true;
            this.AllCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AllCheckBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.AllCheckBox.Location = new System.Drawing.Point(197, 37);
            this.AllCheckBox.Name = "AllCheckBox";
            this.AllCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllCheckBox.Size = new System.Drawing.Size(56, 23);
            this.AllCheckBox.TabIndex = 1;
            this.AllCheckBox.Text = "الكــل";
            this.AllCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllCheckBox.UseVisualStyleBackColor = false;
            this.AllCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(12, 488);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(140, 41);
            this.printBtn.TabIndex = 73;
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
            // is_supplies
            // 
            this.is_supplies.HeaderText = "مؤن و امدادات";
            this.is_supplies.Name = "is_supplies";
            this.is_supplies.ReadOnly = true;
            // 
            // InventoryLimitCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.AllCheckBox);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGridV_prods);
            this.Controls.Add(this.cmbbx_ProdType);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryLimitCheck";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأصناف تحت حد الطلب";
            this.Load += new System.EventHandler(this.InventoryLimitCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_prods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbx_ProdType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGridV_prods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.CheckBox AllCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdBlnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_prdLimit;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_supplies;
    }
}