namespace M_ERP
{
    partial class SellInvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellInvoicesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barcodeTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.newInvoiceBtn = new System.Windows.Forms.Button();
            this.printInvoiceBtn = new System.Windows.Forms.Button();
            this.saveInvoiceBtn = new System.Windows.Forms.Button();
            this.invoiceCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItemPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payAfterGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.payingValueTB = new System.Windows.Forms.TextBox();
            this.netTotalInvoicePrice = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payAfterRadioButton = new System.Windows.Forms.RadioButton();
            this.payNowRadioButton = new System.Windows.Forms.RadioButton();
            this.DiscoutTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalInvoicePriceLBL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.totalItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.priceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientBalanceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.payAfterGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.barcodeTB);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.deleteItemBtn);
            this.groupBox1.Controls.Add(this.newInvoiceBtn);
            this.groupBox1.Controls.Add(this.printInvoiceBtn);
            this.groupBox1.Controls.Add(this.saveInvoiceBtn);
            this.groupBox1.Controls.Add(this.invoiceCodeComboBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.payAfterGroupBox);
            this.groupBox1.Controls.Add(this.netTotalInvoicePrice);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DiscoutTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.totalInvoicePriceLBL);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.addItemBtn);
            this.groupBox1.Controls.Add(this.totalItemPriceTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.itemPriceTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.priceTypeComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.productBalanceTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.clientBalanceTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.productNameComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.productTypeComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clientNameComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(917, 666);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // barcodeTB
            // 
            this.barcodeTB.Location = new System.Drawing.Point(520, 134);
            this.barcodeTB.Name = "barcodeTB";
            this.barcodeTB.Size = new System.Drawing.Size(231, 27);
            this.barcodeTB.TabIndex = 32;
            this.barcodeTB.TextChanged += new System.EventHandler(this.barcodeTB_TextChanged);
            this.barcodeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.barcodeTB_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(777, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 27);
            this.button1.TabIndex = 31;
            this.button1.Text = "باركود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteItemBtn.ForeColor = System.Drawing.Color.White;
            this.deleteItemBtn.Location = new System.Drawing.Point(64, 282);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(140, 41);
            this.deleteItemBtn.TabIndex = 9;
            this.deleteItemBtn.Text = "حذف";
            this.deleteItemBtn.UseVisualStyleBackColor = false;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // newInvoiceBtn
            // 
            this.newInvoiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newInvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.newInvoiceBtn.Location = new System.Drawing.Point(88, 610);
            this.newInvoiceBtn.Name = "newInvoiceBtn";
            this.newInvoiceBtn.Size = new System.Drawing.Size(140, 41);
            this.newInvoiceBtn.TabIndex = 16;
            this.newInvoiceBtn.Text = "فاتورة جديدة";
            this.newInvoiceBtn.UseVisualStyleBackColor = false;
            this.newInvoiceBtn.Click += new System.EventHandler(this.newInvoiceBtn_Click);
            // 
            // printInvoiceBtn
            // 
            this.printInvoiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printInvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.printInvoiceBtn.Location = new System.Drawing.Point(402, 610);
            this.printInvoiceBtn.Name = "printInvoiceBtn";
            this.printInvoiceBtn.Size = new System.Drawing.Size(140, 41);
            this.printInvoiceBtn.TabIndex = 15;
            this.printInvoiceBtn.Text = "طباعة";
            this.printInvoiceBtn.UseVisualStyleBackColor = false;
            this.printInvoiceBtn.Click += new System.EventHandler(this.printInvoiceBtn_Click);
            // 
            // saveInvoiceBtn
            // 
            this.saveInvoiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveInvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.saveInvoiceBtn.Location = new System.Drawing.Point(700, 610);
            this.saveInvoiceBtn.Name = "saveInvoiceBtn";
            this.saveInvoiceBtn.Size = new System.Drawing.Size(140, 41);
            this.saveInvoiceBtn.TabIndex = 14;
            this.saveInvoiceBtn.Text = "حفظ";
            this.saveInvoiceBtn.UseVisualStyleBackColor = false;
            this.saveInvoiceBtn.Click += new System.EventHandler(this.saveInvoiceBtn_Click);
            // 
            // invoiceCodeComboBox
            // 
            this.invoiceCodeComboBox.FormattingEnabled = true;
            this.invoiceCodeComboBox.ItemHeight = 19;
            this.invoiceCodeComboBox.Location = new System.Drawing.Point(660, 34);
            this.invoiceCodeComboBox.Name = "invoiceCodeComboBox";
            this.invoiceCodeComboBox.Size = new System.Drawing.Size(121, 27);
            this.invoiceCodeComboBox.TabIndex = 30;
            this.invoiceCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.invoiceCodeComboBox_SelectedIndexChanged);
            this.invoiceCodeComboBox.TextChanged += new System.EventHandler(this.invoiceCodeComboBox_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(797, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 19);
            this.label17.TabIndex = 29;
            this.label17.Text = "رقم الفاتورة:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemCodeColumn,
            this.ProductTypeColumn,
            this.ProductNameColumn,
            this.QuantityColumn,
            this.ItemPriceColumn,
            this.TotalItemPriceColumn});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(23, 340);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(870, 170);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(870, 170);
            this.dataGridView1.TabIndex = 20;
            // 
            // itemCodeColumn
            // 
            this.itemCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemCodeColumn.HeaderText = "كود الصنف";
            this.itemCodeColumn.Name = "itemCodeColumn";
            this.itemCodeColumn.ReadOnly = true;
            this.itemCodeColumn.Width = 97;
            // 
            // ProductTypeColumn
            // 
            this.ProductTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductTypeColumn.HeaderText = "نوع الصنف";
            this.ProductTypeColumn.Name = "ProductTypeColumn";
            this.ProductTypeColumn.ReadOnly = true;
            this.ProductTypeColumn.Width = 99;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductNameColumn.HeaderText = "اسم الصنف";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            this.ProductNameColumn.Width = 97;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantityColumn.HeaderText = "الكمية";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 67;
            // 
            // ItemPriceColumn
            // 
            this.ItemPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemPriceColumn.HeaderText = "سعر الوحدة";
            this.ItemPriceColumn.Name = "ItemPriceColumn";
            this.ItemPriceColumn.ReadOnly = true;
            this.ItemPriceColumn.Width = 98;
            // 
            // TotalItemPriceColumn
            // 
            this.TotalItemPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalItemPriceColumn.HeaderText = "المجموع";
            this.TotalItemPriceColumn.Name = "TotalItemPriceColumn";
            this.TotalItemPriceColumn.ReadOnly = true;
            this.TotalItemPriceColumn.Width = 82;
            // 
            // payAfterGroupBox
            // 
            this.payAfterGroupBox.Controls.Add(this.label16);
            this.payAfterGroupBox.Controls.Add(this.payingValueTB);
            this.payAfterGroupBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.payAfterGroupBox.Location = new System.Drawing.Point(12, 520);
            this.payAfterGroupBox.Name = "payAfterGroupBox";
            this.payAfterGroupBox.Size = new System.Drawing.Size(193, 66);
            this.payAfterGroupBox.TabIndex = 27;
            this.payAfterGroupBox.TabStop = false;
            this.payAfterGroupBox.Text = "دفعة من الحساب";
            this.payAfterGroupBox.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(129, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 19);
            this.label16.TabIndex = 29;
            this.label16.Text = "مبلغ";
            // 
            // payingValueTB
            // 
            this.payingValueTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.payingValueTB.Location = new System.Drawing.Point(6, 29);
            this.payingValueTB.Name = "payingValueTB";
            this.payingValueTB.Size = new System.Drawing.Size(105, 27);
            this.payingValueTB.TabIndex = 13;
            this.payingValueTB.Text = "0";
            this.payingValueTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // netTotalInvoicePrice
            // 
            this.netTotalInvoicePrice.AutoSize = true;
            this.netTotalInvoicePrice.Enabled = false;
            this.netTotalInvoicePrice.Location = new System.Drawing.Point(675, 574);
            this.netTotalInvoicePrice.Name = "netTotalInvoicePrice";
            this.netTotalInvoicePrice.Size = new System.Drawing.Size(40, 19);
            this.netTotalInvoicePrice.TabIndex = 28;
            this.netTotalInvoicePrice.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(786, 574);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 19);
            this.label15.TabIndex = 27;
            this.label15.Text = "صافى الفاتورة:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payAfterRadioButton);
            this.groupBox2.Controls.Add(this.payNowRadioButton);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(229, 520);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 66);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طريقة الدفع";
            // 
            // payAfterRadioButton
            // 
            this.payAfterRadioButton.AutoSize = true;
            this.payAfterRadioButton.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.payAfterRadioButton.Location = new System.Drawing.Point(28, 27);
            this.payAfterRadioButton.Name = "payAfterRadioButton";
            this.payAfterRadioButton.Size = new System.Drawing.Size(48, 23);
            this.payAfterRadioButton.TabIndex = 12;
            this.payAfterRadioButton.Text = "آجل";
            this.payAfterRadioButton.UseVisualStyleBackColor = true;
            this.payAfterRadioButton.CheckedChanged += new System.EventHandler(this.payAfterRadioButton_CheckedChanged);
            // 
            // payNowRadioButton
            // 
            this.payNowRadioButton.AutoSize = true;
            this.payNowRadioButton.Checked = true;
            this.payNowRadioButton.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.payNowRadioButton.Location = new System.Drawing.Point(113, 27);
            this.payNowRadioButton.Name = "payNowRadioButton";
            this.payNowRadioButton.Size = new System.Drawing.Size(48, 23);
            this.payNowRadioButton.TabIndex = 11;
            this.payNowRadioButton.TabStop = true;
            this.payNowRadioButton.Text = "نقداً";
            this.payNowRadioButton.UseVisualStyleBackColor = true;
            this.payNowRadioButton.CheckedChanged += new System.EventHandler(this.payNowRadioButton_CheckedChanged);
            // 
            // DiscoutTextBox
            // 
            this.DiscoutTextBox.Location = new System.Drawing.Point(448, 536);
            this.DiscoutTextBox.Name = "DiscoutTextBox";
            this.DiscoutTextBox.Size = new System.Drawing.Size(105, 27);
            this.DiscoutTextBox.TabIndex = 10;
            this.DiscoutTextBox.Text = "0";
            this.DiscoutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscoutTextBox.TextChanged += new System.EventHandler(this.DisscoutTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 537);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "خصم:";
            // 
            // totalInvoicePriceLBL
            // 
            this.totalInvoicePriceLBL.AutoSize = true;
            this.totalInvoicePriceLBL.Enabled = false;
            this.totalInvoicePriceLBL.Location = new System.Drawing.Point(675, 539);
            this.totalInvoicePriceLBL.Name = "totalInvoicePriceLBL";
            this.totalInvoicePriceLBL.Size = new System.Drawing.Size(40, 19);
            this.totalInvoicePriceLBL.TabIndex = 23;
            this.totalInvoicePriceLBL.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(781, 539);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "اجمالى الفاتورة:";
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.Location = new System.Drawing.Point(232, 282);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(140, 41);
            this.addItemBtn.TabIndex = 8;
            this.addItemBtn.Text = "إضافة";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // totalItemPriceTextBox
            // 
            this.totalItemPriceTextBox.Enabled = false;
            this.totalItemPriceTextBox.Location = new System.Drawing.Point(616, 287);
            this.totalItemPriceTextBox.Name = "totalItemPriceTextBox";
            this.totalItemPriceTextBox.Size = new System.Drawing.Size(135, 27);
            this.totalItemPriceTextBox.TabIndex = 7;
            this.totalItemPriceTextBox.Text = "0.00";
            this.totalItemPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(794, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "المجموع:";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Enabled = false;
            this.itemPriceTextBox.Location = new System.Drawing.Point(95, 226);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(110, 27);
            this.itemPriceTextBox.TabIndex = 6;
            this.itemPriceTextBox.Text = "0";
            this.itemPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemPriceTextBox.TextChanged += new System.EventHandler(this.itemPriceTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "سعر الوحدة:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Enabled = false;
            this.quantityTextBox.Location = new System.Drawing.Point(352, 227);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(92, 27);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.Text = "0";
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "الكمية:";
            // 
            // priceTypeComboBox
            // 
            this.priceTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.priceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priceTypeComboBox.FormattingEnabled = true;
            this.priceTypeComboBox.Items.AddRange(new object[] {
            "خاص",
            "قطاعى ",
            "جملة"});
            this.priceTypeComboBox.Location = new System.Drawing.Point(606, 227);
            this.priceTypeComboBox.Name = "priceTypeComboBox";
            this.priceTypeComboBox.Size = new System.Drawing.Size(145, 27);
            this.priceTypeComboBox.TabIndex = 4;
            this.priceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.priceTypeComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "سعر البيع:";
            // 
            // productBalanceTextBox
            // 
            this.productBalanceTextBox.Enabled = false;
            this.productBalanceTextBox.Location = new System.Drawing.Point(23, 34);
            this.productBalanceTextBox.Name = "productBalanceTextBox";
            this.productBalanceTextBox.Size = new System.Drawing.Size(149, 27);
            this.productBalanceTextBox.TabIndex = 11;
            this.productBalanceTextBox.Text = "0";
            this.productBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "رصيد الصنف:";
            // 
            // clientBalanceTextBox
            // 
            this.clientBalanceTextBox.Enabled = false;
            this.clientBalanceTextBox.Location = new System.Drawing.Point(343, 35);
            this.clientBalanceTextBox.Name = "clientBalanceTextBox";
            this.clientBalanceTextBox.Size = new System.Drawing.Size(149, 27);
            this.clientBalanceTextBox.TabIndex = 9;
            this.clientBalanceTextBox.Text = "0";
            this.clientBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "رصيد العميل:";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(76, 170);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(231, 27);
            this.productNameComboBox.TabIndex = 3;
            this.productNameComboBox.SelectedIndexChanged += new System.EventHandler(this.productNameComboBox_SelectedIndexChanged);
            this.productNameComboBox.TextChanged += new System.EventHandler(this.productNameComboBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "اسم الصنف:";
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Location = new System.Drawing.Point(520, 175);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(231, 27);
            this.productTypeComboBox.TabIndex = 2;
            this.productTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.productTypeComboBox_SelectedIndexChanged);
            this.productTypeComboBox.TextChanged += new System.EventHandler(this.productTypeComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(783, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "نوع الصنف:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 27);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "التاريخ:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(520, 92);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.Size = new System.Drawing.Size(231, 27);
            this.clientNameComboBox.TabIndex = 0;
            this.clientNameComboBox.SelectedIndexChanged += new System.EventHandler(this.clientNameComboBox_SelectedIndexChanged);
            this.clientNameComboBox.TextChanged += new System.EventHandler(this.clientNameComboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(781, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل:";
            // 
            // SellInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 686);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellInvoicesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة البيع";
            this.Load += new System.EventHandler(this.BuyInvoicesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.payAfterGroupBox.ResumeLayout(false);
            this.payAfterGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox clientNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox priceTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productBalanceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientBalanceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalItemPriceTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button newInvoiceBtn;
        private System.Windows.Forms.Button printInvoiceBtn;
        private System.Windows.Forms.Button saveInvoiceBtn;
        private System.Windows.Forms.ComboBox invoiceCodeComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox payAfterGroupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox payingValueTB;
        private System.Windows.Forms.Label netTotalInvoicePrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton payAfterRadioButton;
        private System.Windows.Forms.RadioButton payNowRadioButton;
        private System.Windows.Forms.TextBox DiscoutTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalInvoicePriceLBL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItemPriceColumn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox barcodeTB;
    }
}