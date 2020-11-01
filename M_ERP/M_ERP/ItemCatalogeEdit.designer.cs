namespace M_ERP
{
    partial class ItemCatalogeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemCatalogeEdit));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbbx_ProdType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbbx_ProdName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ChooseProd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.newPrdNameTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_PrdDsc = new System.Windows.Forms.TextBox();
            this.cmbbx_NewProdType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_limit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbx_ItemProfit = new System.Windows.Forms.TextBox();
            this.txtbx_ID = new System.Windows.Forms.TextBox();
            this.txtbx_blnce = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_SctorSlPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_WhlSlPrice = new System.Windows.Forms.TextBox();
            this.txtbx_buyPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(664, 41);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "نوع الصنف: ";
            // 
            // cmbbx_ProdType
            // 
            this.cmbbx_ProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdType.FormattingEnabled = true;
            this.cmbbx_ProdType.Location = new System.Drawing.Point(326, 34);
            this.cmbbx_ProdType.Name = "cmbbx_ProdType";
            this.cmbbx_ProdType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_ProdType.Size = new System.Drawing.Size(299, 27);
            this.cmbbx_ProdType.TabIndex = 0;
            this.cmbbx_ProdType.SelectedIndexChanged += new System.EventHandler(this.cmbbx_ProdType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(664, 95);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "اسم الصنف: ";
            // 
            // cmbbx_ProdName
            // 
            this.cmbbx_ProdName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_ProdName.FormattingEnabled = true;
            this.cmbbx_ProdName.Location = new System.Drawing.Point(326, 88);
            this.cmbbx_ProdName.Name = "cmbbx_ProdName";
            this.cmbbx_ProdName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_ProdName.Size = new System.Drawing.Size(299, 27);
            this.cmbbx_ProdName.TabIndex = 1;
            this.cmbbx_ProdName.SelectedIndexChanged += new System.EventHandler(this.cmbbx_ProdName_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_ChooseProd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbbx_ProdName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbbx_ProdType);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(840, 139);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار الصنف";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_ChooseProd
            // 
            this.btn_ChooseProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChooseProd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_ChooseProd.ForeColor = System.Drawing.Color.White;
            this.btn_ChooseProd.Location = new System.Drawing.Point(25, 83);
            this.btn_ChooseProd.Name = "btn_ChooseProd";
            this.btn_ChooseProd.Size = new System.Drawing.Size(132, 40);
            this.btn_ChooseProd.TabIndex = 2;
            this.btn_ChooseProd.Text = "إختيار";
            this.btn_ChooseProd.UseVisualStyleBackColor = false;
            this.btn_ChooseProd.Click += new System.EventHandler(this.btn_ChooseProd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.barcodeText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_Save);
            this.groupBox2.Controls.Add(this.newPrdNameTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtbx_PrdDsc);
            this.groupBox2.Controls.Add(this.cmbbx_NewProdType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbx_limit);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtbx_ItemProfit);
            this.groupBox2.Controls.Add(this.txtbx_ID);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(840, 463);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إضافة صنف";
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.barcodeText.Location = new System.Drawing.Point(53, 105);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barcodeText.Size = new System.Drawing.Size(234, 27);
            this.barcodeText.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(298, 108);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "الباركود :";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(44, 379);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(132, 40);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "تعديل";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // newPrdNameTB
            // 
            this.newPrdNameTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.newPrdNameTB.Location = new System.Drawing.Point(477, 105);
            this.newPrdNameTB.Name = "newPrdNameTB";
            this.newPrdNameTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newPrdNameTB.Size = new System.Drawing.Size(234, 27);
            this.newPrdNameTB.TabIndex = 4;
            this.newPrdNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(708, 383);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(47, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "إنتاج :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtbx_PrdDsc
            // 
            this.txtbx_PrdDsc.AcceptsReturn = true;
            this.txtbx_PrdDsc.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_PrdDsc.Location = new System.Drawing.Point(252, 358);
            this.txtbx_PrdDsc.Multiline = true;
            this.txtbx_PrdDsc.Name = "txtbx_PrdDsc";
            this.txtbx_PrdDsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_PrdDsc.Size = new System.Drawing.Size(437, 78);
            this.txtbx_PrdDsc.TabIndex = 11;
            // 
            // cmbbx_NewProdType
            // 
            this.cmbbx_NewProdType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmbbx_NewProdType.FormattingEnabled = true;
            this.cmbbx_NewProdType.Location = new System.Drawing.Point(44, 46);
            this.cmbbx_NewProdType.Name = "cmbbx_NewProdType";
            this.cmbbx_NewProdType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbbx_NewProdType.Size = new System.Drawing.Size(243, 27);
            this.cmbbx_NewProdType.TabIndex = 3;
            this.cmbbx_NewProdType.SelectedIndexChanged += new System.EventHandler(this.cmbbx_NewProdType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(722, 110);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "اسم الصنف: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(708, 294);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "حد اعادة طلب: ";
            // 
            // txtbx_limit
            // 
            this.txtbx_limit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_limit.Location = new System.Drawing.Point(567, 289);
            this.txtbx_limit.Name = "txtbx_limit";
            this.txtbx_limit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_limit.Size = new System.Drawing.Size(122, 27);
            this.txtbx_limit.TabIndex = 10;
            this.txtbx_limit.Text = "0";
            this.txtbx_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(298, 55);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "نوع الصنف: ";
            // 
            // txtbx_ItemProfit
            // 
            this.txtbx_ItemProfit.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtbx_ItemProfit.Enabled = false;
            this.txtbx_ItemProfit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_ItemProfit.Location = new System.Drawing.Point(165, 228);
            this.txtbx_ItemProfit.Name = "txtbx_ItemProfit";
            this.txtbx_ItemProfit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_ItemProfit.Size = new System.Drawing.Size(122, 27);
            this.txtbx_ItemProfit.TabIndex = 9;
            this.txtbx_ItemProfit.Text = "0";
            this.txtbx_ItemProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_ID
            // 
            this.txtbx_ID.Enabled = false;
            this.txtbx_ID.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_ID.Location = new System.Drawing.Point(477, 51);
            this.txtbx_ID.Name = "txtbx_ID";
            this.txtbx_ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_ID.Size = new System.Drawing.Size(234, 27);
            this.txtbx_ID.TabIndex = 40;
            // 
            // txtbx_blnce
            // 
            this.txtbx_blnce.Enabled = false;
            this.txtbx_blnce.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_blnce.Location = new System.Drawing.Point(617, 228);
            this.txtbx_blnce.Name = "txtbx_blnce";
            this.txtbx_blnce.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_blnce.Size = new System.Drawing.Size(94, 27);
            this.txtbx_blnce.TabIndex = 8;
            this.txtbx_blnce.Text = "0";
            this.txtbx_blnce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(326, 235);
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
            this.label5.Location = new System.Drawing.Point(724, 55);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "كود الصنف: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(728, 233);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "الرصيد : ";
            // 
            // txtbx_SctorSlPrice
            // 
            this.txtbx_SctorSlPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_SctorSlPrice.Location = new System.Drawing.Point(44, 161);
            this.txtbx_SctorSlPrice.Name = "txtbx_SctorSlPrice";
            this.txtbx_SctorSlPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_SctorSlPrice.Size = new System.Drawing.Size(94, 27);
            this.txtbx_SctorSlPrice.TabIndex = 7;
            this.txtbx_SctorSlPrice.Text = "0";
            this.txtbx_SctorSlPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_SctorSlPrice.TextChanged += new System.EventHandler(this.txtbx_SctorSlPrice_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(727, 166);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "سعر الشراء: ";
            // 
            // txtbx_WhlSlPrice
            // 
            this.txtbx_WhlSlPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_WhlSlPrice.Location = new System.Drawing.Point(343, 161);
            this.txtbx_WhlSlPrice.Name = "txtbx_WhlSlPrice";
            this.txtbx_WhlSlPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_WhlSlPrice.Size = new System.Drawing.Size(94, 27);
            this.txtbx_WhlSlPrice.TabIndex = 6;
            this.txtbx_WhlSlPrice.Text = "0";
            this.txtbx_WhlSlPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_buyPrice
            // 
            this.txtbx_buyPrice.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtbx_buyPrice.Location = new System.Drawing.Point(617, 161);
            this.txtbx_buyPrice.Name = "txtbx_buyPrice";
            this.txtbx_buyPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtbx_buyPrice.Size = new System.Drawing.Size(94, 27);
            this.txtbx_buyPrice.TabIndex = 5;
            this.txtbx_buyPrice.Text = "0";
            this.txtbx_buyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_buyPrice.TextChanged += new System.EventHandler(this.txtbx_buyPrice_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(447, 166);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "سعر البيع الجملة: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(144, 166);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "سعر البيع القطاعي: ";
            // 
            // ItemCatalogeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(860, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemCatalogeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ItemCatalogeEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbbx_ProdType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbbx_ProdName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChooseProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox newPrdNameTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_PrdDsc;
        private System.Windows.Forms.ComboBox cmbbx_NewProdType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_limit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbx_ItemProfit;
        private System.Windows.Forms.TextBox txtbx_ID;
        private System.Windows.Forms.TextBox txtbx_blnce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_SctorSlPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_WhlSlPrice;
        private System.Windows.Forms.TextBox txtbx_buyPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Label label1;
    }
}