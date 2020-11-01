namespace M_ERP
{
    partial class ProductAdditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdditionForm));
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtbx_PrdDsc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_limit = new System.Windows.Forms.TextBox();
            this.txtbx_ItemProfit = new System.Windows.Forms.TextBox();
            this.txtbx_blnce = new System.Windows.Forms.TextBox();
            this.txtbx_SctorSlPrice = new System.Windows.Forms.TextBox();
            this.txtbx_WhlSlPrice = new System.Windows.Forms.TextBox();
            this.txtbx_buyPrice = new System.Windows.Forms.TextBox();
            this.prdtxtbx_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barcodeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.cmbbx_NewProdType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(40, 379);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 40);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "إضافة";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txtbx_PrdDsc
            // 
            this.txtbx_PrdDsc.AcceptsReturn = true;
            this.txtbx_PrdDsc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_PrdDsc.Location = new System.Drawing.Point(248, 358);
            this.txtbx_PrdDsc.Multiline = true;
            this.txtbx_PrdDsc.Name = "txtbx_PrdDsc";
            this.txtbx_PrdDsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_PrdDsc.Size = new System.Drawing.Size(437, 78);
            this.txtbx_PrdDsc.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(704, 379);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "إنتاج :";
            // 
            // txtbx_limit
            // 
            this.txtbx_limit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_limit.Location = new System.Drawing.Point(563, 289);
            this.txtbx_limit.Name = "txtbx_limit";
            this.txtbx_limit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_limit.Size = new System.Drawing.Size(122, 27);
            this.txtbx_limit.TabIndex = 7;
            this.txtbx_limit.Text = "0";
            this.txtbx_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_ItemProfit
            // 
            this.txtbx_ItemProfit.Enabled = false;
            this.txtbx_ItemProfit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_ItemProfit.Location = new System.Drawing.Point(161, 228);
            this.txtbx_ItemProfit.Name = "txtbx_ItemProfit";
            this.txtbx_ItemProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_ItemProfit.Size = new System.Drawing.Size(122, 27);
            this.txtbx_ItemProfit.TabIndex = 6;
            this.txtbx_ItemProfit.Text = "0";
            this.txtbx_ItemProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_blnce
            // 
            this.txtbx_blnce.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_blnce.Location = new System.Drawing.Point(563, 230);
            this.txtbx_blnce.Name = "txtbx_blnce";
            this.txtbx_blnce.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_blnce.Size = new System.Drawing.Size(122, 27);
            this.txtbx_blnce.TabIndex = 5;
            this.txtbx_blnce.Text = "0";
            this.txtbx_blnce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_SctorSlPrice
            // 
            this.txtbx_SctorSlPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_SctorSlPrice.Location = new System.Drawing.Point(40, 161);
            this.txtbx_SctorSlPrice.Name = "txtbx_SctorSlPrice";
            this.txtbx_SctorSlPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_SctorSlPrice.Size = new System.Drawing.Size(94, 27);
            this.txtbx_SctorSlPrice.TabIndex = 4;
            this.txtbx_SctorSlPrice.Text = "0";
            this.txtbx_SctorSlPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_SctorSlPrice.TextChanged += new System.EventHandler(this.txtbx_SctorSlPrice_TextChanged);
            // 
            // txtbx_WhlSlPrice
            // 
            this.txtbx_WhlSlPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_WhlSlPrice.Location = new System.Drawing.Point(339, 161);
            this.txtbx_WhlSlPrice.Name = "txtbx_WhlSlPrice";
            this.txtbx_WhlSlPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_WhlSlPrice.Size = new System.Drawing.Size(94, 27);
            this.txtbx_WhlSlPrice.TabIndex = 3;
            this.txtbx_WhlSlPrice.Text = "0";
            this.txtbx_WhlSlPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_buyPrice
            // 
            this.txtbx_buyPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_buyPrice.Location = new System.Drawing.Point(613, 161);
            this.txtbx_buyPrice.Name = "txtbx_buyPrice";
            this.txtbx_buyPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_buyPrice.Size = new System.Drawing.Size(94, 27);
            this.txtbx_buyPrice.TabIndex = 2;
            this.txtbx_buyPrice.Text = "0";
            this.txtbx_buyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_buyPrice.TextChanged += new System.EventHandler(this.txtbx_buyPrice_TextChanged);
            // 
            // prdtxtbx_ID
            // 
            this.prdtxtbx_ID.Enabled = false;
            this.prdtxtbx_ID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.prdtxtbx_ID.Location = new System.Drawing.Point(473, 51);
            this.prdtxtbx_ID.Name = "prdtxtbx_ID";
            this.prdtxtbx_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prdtxtbx_ID.Size = new System.Drawing.Size(234, 27);
            this.prdtxtbx_ID.TabIndex = 35;
            this.prdtxtbx_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(691, 228);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(112, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "الرصيد الافتتاحي: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(443, 161);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "سعر البيع الجملة: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(704, 289);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "حد اعادة طلب: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(322, 230);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "ربحية الصنف: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(720, 50);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "كود الصنف: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(723, 161);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "سعر الشراء: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(140, 161);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "سعر البيع القطاعي: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.barcodeTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.itemNameTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtbx_PrdDsc);
            this.groupBox2.Controls.Add(this.cmbbx_NewProdType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbx_limit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtbx_ItemProfit);
            this.groupBox2.Controls.Add(this.prdtxtbx_ID);
            this.groupBox2.Controls.Add(this.txtbx_blnce);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtbx_SctorSlPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbx_WhlSlPrice);
            this.groupBox2.Controls.Add(this.txtbx_buyPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(840, 463);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إضافة صنف";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // barcodeTB
            // 
            this.barcodeTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.barcodeTB.Location = new System.Drawing.Point(49, 105);
            this.barcodeTB.Name = "barcodeTB";
            this.barcodeTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barcodeTB.Size = new System.Drawing.Size(234, 27);
            this.barcodeTB.TabIndex = 43;
            this.barcodeTB.TextChanged += new System.EventHandler(this.barcodeTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(294, 105);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "الباركود :";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.itemNameTextBox.Location = new System.Drawing.Point(473, 105);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemNameTextBox.Size = new System.Drawing.Size(234, 27);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // cmbbx_NewProdType
            // 
            this.cmbbx_NewProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_NewProdType.FormattingEnabled = true;
            this.cmbbx_NewProdType.Location = new System.Drawing.Point(18, 46);
            this.cmbbx_NewProdType.Name = "cmbbx_NewProdType";
            this.cmbbx_NewProdType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_NewProdType.Size = new System.Drawing.Size(265, 27);
            this.cmbbx_NewProdType.TabIndex = 0;
            this.cmbbx_NewProdType.SelectedIndexChanged += new System.EventHandler(this.cmbbx_NewProdType_SelectedIndexChanged);
            this.cmbbx_NewProdType.TextChanged += new System.EventHandler(this.cmbbx_NewProdType_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(718, 105);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "اسم الصنف: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(294, 50);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "نوع الصنف: ";
            // 
            // ProductAdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(870, 487);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductAdditionForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كارت الصنف";
            this.Load += new System.EventHandler(this.ProductAdditionForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtbx_PrdDsc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_limit;
        private System.Windows.Forms.TextBox txtbx_ItemProfit;
        private System.Windows.Forms.TextBox txtbx_blnce;
        private System.Windows.Forms.TextBox txtbx_SctorSlPrice;
        private System.Windows.Forms.TextBox txtbx_WhlSlPrice;
        private System.Windows.Forms.TextBox txtbx_buyPrice;
        private System.Windows.Forms.TextBox prdtxtbx_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.ComboBox cmbbx_NewProdType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox barcodeTB;
        private System.Windows.Forms.Label label1;
    }
}