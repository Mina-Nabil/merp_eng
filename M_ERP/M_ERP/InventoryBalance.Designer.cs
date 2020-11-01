namespace M_ERP
{
    partial class InventoryBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryBalance));
            this.cmbbx_ProdName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbx_ProdType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.dispAllnv = new System.Windows.Forms.CheckBox();
            this.chbx_All = new System.Windows.Forms.CheckBox();
            this.dGridV_prods = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SCTRPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SumWHLPrice = new System.Windows.Forms.TextBox();
            this.txt_SumBUYPrice = new System.Windows.Forms.TextBox();
            this.txt_BLNCE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.clmn_ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdBlnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_prdBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_WHLPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_SCTRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_spplies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_prods)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbx_ProdName
            // 
            this.cmbbx_ProdName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdName.FormattingEnabled = true;
            this.cmbbx_ProdName.Location = new System.Drawing.Point(313, 81);
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
            this.label6.Location = new System.Drawing.Point(770, 84);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "اسم الصنف: ";
            // 
            // cmbbx_ProdType
            // 
            this.cmbbx_ProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdType.FormattingEnabled = true;
            this.cmbbx_ProdType.Location = new System.Drawing.Point(313, 21);
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
            this.label2.Location = new System.Drawing.Point(770, 24);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "نوع الصنف: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.printBtn);
            this.groupBox1.Controls.Add(this.dispAllnv);
            this.groupBox1.Controls.Add(this.chbx_All);
            this.groupBox1.Controls.Add(this.cmbbx_ProdType);
            this.groupBox1.Controls.Add(this.cmbbx_ProdName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1000, 133);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 74;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(17, 25);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(140, 41);
            this.printBtn.TabIndex = 73;
            this.printBtn.Text = "طباعة";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // dispAllnv
            // 
            this.dispAllnv.AutoSize = true;
            this.dispAllnv.Location = new System.Drawing.Point(171, 44);
            this.dispAllnv.Name = "dispAllnv";
            this.dispAllnv.Size = new System.Drawing.Size(124, 23);
            this.dispAllnv.TabIndex = 31;
            this.dispAllnv.Text = "عرض كل المخزن";
            this.dispAllnv.UseVisualStyleBackColor = true;
            this.dispAllnv.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chbx_All
            // 
            this.chbx_All.AutoSize = true;
            this.chbx_All.Location = new System.Drawing.Point(202, 80);
            this.chbx_All.Name = "chbx_All";
            this.chbx_All.Size = new System.Drawing.Size(93, 23);
            this.chbx_All.TabIndex = 30;
            this.chbx_All.Text = "كل الأصناف";
            this.chbx_All.UseVisualStyleBackColor = true;
            this.chbx_All.CheckedChanged += new System.EventHandler(this.chbx_All_CheckedChanged);
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
            this.clmn_Value,
            this.clmn_ProdBlnc,
            this.clmn_prdBuyPrice,
            this.clmn_WHLPrice,
            this.clmn_SCTRPrice,
            this.is_spplies});
            this.dGridV_prods.Location = new System.Drawing.Point(12, 157);
            this.dGridV_prods.MaximumSize = new System.Drawing.Size(1000, 371);
            this.dGridV_prods.Name = "dGridV_prods";
            this.dGridV_prods.ReadOnly = true;
            this.dGridV_prods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_prods.Size = new System.Drawing.Size(1000, 371);
            this.dGridV_prods.TabIndex = 32;
            this.dGridV_prods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridV_prods_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_SCTRPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_SumWHLPrice);
            this.groupBox2.Controls.Add(this.txt_SumBUYPrice);
            this.groupBox2.Controls.Add(this.txt_BLNCE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 536);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1000, 111);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اجــمالــيات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(304, 73);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "اجــــمالي سعــــــر القطـاعي: ";
            // 
            // txt_SCTRPrice
            // 
            this.txt_SCTRPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SCTRPrice.Enabled = false;
            this.txt_SCTRPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_SCTRPrice.Location = new System.Drawing.Point(152, 70);
            this.txt_SCTRPrice.Name = "txt_SCTRPrice";
            this.txt_SCTRPrice.Size = new System.Drawing.Size(143, 27);
            this.txt_SCTRPrice.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(301, 35);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "اجــــمالي سعــــــر الجملة: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(749, 70);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "اجــــمالي سعــــــر الشــــراء: ";
            // 
            // txt_SumWHLPrice
            // 
            this.txt_SumWHLPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SumWHLPrice.Enabled = false;
            this.txt_SumWHLPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_SumWHLPrice.Location = new System.Drawing.Point(151, 33);
            this.txt_SumWHLPrice.Name = "txt_SumWHLPrice";
            this.txt_SumWHLPrice.Size = new System.Drawing.Size(144, 27);
            this.txt_SumWHLPrice.TabIndex = 36;
            // 
            // txt_SumBUYPrice
            // 
            this.txt_SumBUYPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txt_SumBUYPrice.Enabled = false;
            this.txt_SumBUYPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_SumBUYPrice.Location = new System.Drawing.Point(608, 70);
            this.txt_SumBUYPrice.Name = "txt_SumBUYPrice";
            this.txt_SumBUYPrice.Size = new System.Drawing.Size(134, 27);
            this.txt_SumBUYPrice.TabIndex = 35;
            // 
            // txt_BLNCE
            // 
            this.txt_BLNCE.BackColor = System.Drawing.SystemColors.Control;
            this.txt_BLNCE.Enabled = false;
            this.txt_BLNCE.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_BLNCE.Location = new System.Drawing.Point(608, 32);
            this.txt_BLNCE.Name = "txt_BLNCE";
            this.txt_BLNCE.Size = new System.Drawing.Size(134, 27);
            this.txt_BLNCE.TabIndex = 34;
            this.txt_BLNCE.TextChanged += new System.EventHandler(this.txt_BLNCE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(748, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "اجــــمالي الرصـــــيــد: ";
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
            // clmn_Value
            // 
            this.clmn_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Value.HeaderText = "إنتاج";
            this.clmn_Value.Name = "clmn_Value";
            this.clmn_Value.ReadOnly = true;
            this.clmn_Value.Width = 56;
            // 
            // clmn_ProdBlnc
            // 
            this.clmn_ProdBlnc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_ProdBlnc.HeaderText = "الرصـــيـد";
            this.clmn_ProdBlnc.Name = "clmn_ProdBlnc";
            this.clmn_ProdBlnc.ReadOnly = true;
            this.clmn_ProdBlnc.Width = 73;
            // 
            // clmn_prdBuyPrice
            // 
            this.clmn_prdBuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_prdBuyPrice.HeaderText = "ســعـر الشـــراء";
            this.clmn_prdBuyPrice.Name = "clmn_prdBuyPrice";
            this.clmn_prdBuyPrice.ReadOnly = true;
            this.clmn_prdBuyPrice.Width = 102;
            // 
            // clmn_WHLPrice
            // 
            this.clmn_WHLPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_WHLPrice.HeaderText = "سعــر الجــملة";
            this.clmn_WHLPrice.Name = "clmn_WHLPrice";
            this.clmn_WHLPrice.ReadOnly = true;
            this.clmn_WHLPrice.Width = 93;
            // 
            // clmn_SCTRPrice
            // 
            this.clmn_SCTRPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_SCTRPrice.HeaderText = "ســعر القــطاعي";
            this.clmn_SCTRPrice.Name = "clmn_SCTRPrice";
            this.clmn_SCTRPrice.ReadOnly = true;
            this.clmn_SCTRPrice.Width = 97;
            // 
            // is_spplies
            // 
            this.is_spplies.HeaderText = "مؤن و امدادات";
            this.is_spplies.Name = "is_spplies";
            this.is_spplies.ReadOnly = true;
            this.is_spplies.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_spplies.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InventoryBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1024, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGridV_prods);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryBalance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رصيد المخزن";
            this.Load += new System.EventHandler(this.InventoryBalance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_prods)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbx_ProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbx_ProdType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGridV_prods;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_BLNCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SumWHLPrice;
        private System.Windows.Forms.TextBox txt_SumBUYPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SCTRPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dispAllnv;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbx_All;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdBlnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_prdBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_WHLPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_SCTRPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_spplies;
    }
}