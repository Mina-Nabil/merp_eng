namespace M_ERP
{
    partial class ItemAddPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAddPermission));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_oldCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbx_ProdType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbx_ProdName = new System.Windows.Forms.ComboBox();
            this.dGridV_ItemAddPer = new System.Windows.Forms.DataGridView();
            this.save_Btn = new System.Windows.Forms.Button();
            this.buyPriceTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clmn_ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_ItemAddPer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buyPriceTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.text_oldCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.txt_Count);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbbx_ProdType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbbx_ProdName);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1000, 250);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // text_oldCount
            // 
            this.text_oldCount.Enabled = false;
            this.text_oldCount.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.text_oldCount.Location = new System.Drawing.Point(542, 125);
            this.text_oldCount.Name = "text_oldCount";
            this.text_oldCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_oldCount.Size = new System.Drawing.Size(202, 27);
            this.text_oldCount.TabIndex = 2;
            this.text_oldCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(775, 125);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "الكــميـة في المخزن: ";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(33, 183);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(129, 35);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "إضـافـة";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Count
            // 
            this.txt_Count.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_Count.Location = new System.Drawing.Point(542, 172);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(202, 27);
            this.txt_Count.TabIndex = 3;
            this.txt_Count.Text = "0";
            this.txt_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Count.TextChanged += new System.EventHandler(this.txt_Count_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(775, 172);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "الكــميـة: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(775, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "نوع الصنف: ";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(775, 77);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "اسم الصنف: ";
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
            // dGridV_ItemAddPer
            // 
            this.dGridV_ItemAddPer.AllowUserToAddRows = false;
            this.dGridV_ItemAddPer.AllowUserToDeleteRows = false;
            this.dGridV_ItemAddPer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridV_ItemAddPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridV_ItemAddPer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_ProdID,
            this.clmn_ProdType,
            this.clmn_ProdName,
            this.buyPriceCol,
            this.clmn_Count,
            this.clmn_Date});
            this.dGridV_ItemAddPer.Location = new System.Drawing.Point(12, 300);
            this.dGridV_ItemAddPer.MaximumSize = new System.Drawing.Size(1000, 268);
            this.dGridV_ItemAddPer.Name = "dGridV_ItemAddPer";
            this.dGridV_ItemAddPer.ReadOnly = true;
            this.dGridV_ItemAddPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dGridV_ItemAddPer.Size = new System.Drawing.Size(1000, 262);
            this.dGridV_ItemAddPer.TabIndex = 39;
            this.dGridV_ItemAddPer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridV_ItemAddPer_CellContentClick);
            // 
            // save_Btn
            // 
            this.save_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.save_Btn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.save_Btn.ForeColor = System.Drawing.Color.White;
            this.save_Btn.Location = new System.Drawing.Point(45, 593);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.Size = new System.Drawing.Size(129, 35);
            this.save_Btn.TabIndex = 5;
            this.save_Btn.Text = "حــفظ";
            this.save_Btn.UseVisualStyleBackColor = false;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // buyPriceTB
            // 
            this.buyPriceTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.buyPriceTB.Location = new System.Drawing.Point(542, 213);
            this.buyPriceTB.Name = "buyPriceTB";
            this.buyPriceTB.Size = new System.Drawing.Size(202, 27);
            this.buyPriceTB.TabIndex = 41;
            this.buyPriceTB.Text = "0";
            this.buyPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(775, 217);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "سعر شراء الوحدة :";
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
            // buyPriceCol
            // 
            this.buyPriceCol.HeaderText = "سعر الشراء";
            this.buyPriceCol.Name = "buyPriceCol";
            this.buyPriceCol.ReadOnly = true;
            // 
            // clmn_Count
            // 
            this.clmn_Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Count.HeaderText = "كـمــية";
            this.clmn_Count.Name = "clmn_Count";
            this.clmn_Count.ReadOnly = true;
            this.clmn_Count.Width = 62;
            // 
            // clmn_Date
            // 
            this.clmn_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmn_Date.HeaderText = "التـاريـخ";
            this.clmn_Date.Name = "clmn_Date";
            this.clmn_Date.ReadOnly = true;
            this.clmn_Date.Width = 69;
            // 
            // ItemAddPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(1024, 650);
            this.Controls.Add(this.save_Btn);
            this.Controls.Add(this.dGridV_ItemAddPer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemAddPermission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إذن إضافة للمخازن";
            this.Load += new System.EventHandler(this.ItemAddPermission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridV_ItemAddPer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbx_ProdType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbx_ProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.DataGridView dGridV_ItemAddPer;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button save_Btn;
        private System.Windows.Forms.TextBox text_oldCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buyPriceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_Date;
    }
}