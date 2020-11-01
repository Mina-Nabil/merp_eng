namespace M_ERP
{
    partial class InventoryBalanceByDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryBalanceByDateForm));
            this.dGridV_prods = new System.Windows.Forms.DataGridView();
            this.txt_BLNCE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dispAllnv = new System.Windows.Forms.CheckBox();
            this.chbx_All = new System.Windows.Forms.CheckBox();
            this.cmbbx_ProdType = new System.Windows.Forms.ComboBox();
            this.cmbbx_ProdName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clmn_ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdBlnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_spplies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_prods)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGridV_prods
            // 
            this.dGridV_prods.AllowUserToAddRows = false;
            this.dGridV_prods.AllowUserToDeleteRows = false;
            this.dGridV_prods.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridV_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_prods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_ProdID,
            this.clmn_ProdType,
            this.clmn_ProdName,
            this.clmn_ProdBlnc,
            this.is_spplies});
            this.dGridV_prods.Location = new System.Drawing.Point(381, 181);
            this.dGridV_prods.MaximumSize = new System.Drawing.Size(1000, 371);
            this.dGridV_prods.Name = "dGridV_prods";
            this.dGridV_prods.ReadOnly = true;
            this.dGridV_prods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_prods.Size = new System.Drawing.Size(631, 371);
            this.dGridV_prods.TabIndex = 33;
            // 
            // txt_BLNCE
            // 
            this.txt_BLNCE.BackColor = System.Drawing.SystemColors.Control;
            this.txt_BLNCE.Enabled = false;
            this.txt_BLNCE.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_BLNCE.Location = new System.Drawing.Point(690, 591);
            this.txt_BLNCE.Name = "txt_BLNCE";
            this.txt_BLNCE.Size = new System.Drawing.Size(134, 27);
            this.txt_BLNCE.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(830, 595);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "اجــــمالي الرصـــــيــد: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dispAllnv);
            this.groupBox1.Controls.Add(this.chbx_All);
            this.groupBox1.Controls.Add(this.cmbbx_ProdType);
            this.groupBox1.Controls.Add(this.cmbbx_ProdName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1000, 133);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار الصنف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "فى تاريخ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 27);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dispAllnv
            // 
            this.dispAllnv.AutoSize = true;
            this.dispAllnv.Location = new System.Drawing.Point(293, 44);
            this.dispAllnv.Name = "dispAllnv";
            this.dispAllnv.Size = new System.Drawing.Size(124, 23);
            this.dispAllnv.TabIndex = 31;
            this.dispAllnv.Text = "عرض كل المخزن";
            this.dispAllnv.UseVisualStyleBackColor = true;
            this.dispAllnv.CheckedChanged += new System.EventHandler(this.dispAllnv_CheckedChanged);
            // 
            // chbx_All
            // 
            this.chbx_All.AutoSize = true;
            this.chbx_All.Location = new System.Drawing.Point(324, 80);
            this.chbx_All.Name = "chbx_All";
            this.chbx_All.Size = new System.Drawing.Size(93, 23);
            this.chbx_All.TabIndex = 30;
            this.chbx_All.Text = "كل الأصناف";
            this.chbx_All.UseVisualStyleBackColor = true;
            this.chbx_All.CheckedChanged += new System.EventHandler(this.chbx_All_CheckedChanged);
            // 
            // cmbbx_ProdType
            // 
            this.cmbbx_ProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdType.FormattingEnabled = true;
            this.cmbbx_ProdType.Location = new System.Drawing.Point(435, 21);
            this.cmbbx_ProdType.Name = "cmbbx_ProdType";
            this.cmbbx_ProdType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_ProdType.Size = new System.Drawing.Size(437, 27);
            this.cmbbx_ProdType.TabIndex = 0;
            this.cmbbx_ProdType.SelectedIndexChanged += new System.EventHandler(this.cmbbx_ProdType_SelectedIndexChanged);
            // 
            // cmbbx_ProdName
            // 
            this.cmbbx_ProdName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdName.FormattingEnabled = true;
            this.cmbbx_ProdName.Location = new System.Drawing.Point(435, 81);
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
            this.label6.Location = new System.Drawing.Point(892, 84);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "اسم الصنف: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(892, 24);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "نوع الصنف: ";
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
            // is_spplies
            // 
            this.is_spplies.HeaderText = "مؤن و امدادات";
            this.is_spplies.Name = "is_spplies";
            this.is_spplies.ReadOnly = true;
            this.is_spplies.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_spplies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InventoryBalanceByDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1024, 654);
            this.Controls.Add(this.txt_BLNCE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGridV_prods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoryBalanceByDateForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رصيد المخزن";
            this.Load += new System.EventHandler(this.InventoryBalanceByDateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_prods)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridV_prods;
        private System.Windows.Forms.TextBox txt_BLNCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dispAllnv;
        private System.Windows.Forms.CheckBox chbx_All;
        private System.Windows.Forms.ComboBox cmbbx_ProdType;
        private System.Windows.Forms.ComboBox cmbbx_ProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdBlnc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_spplies;
    }
}