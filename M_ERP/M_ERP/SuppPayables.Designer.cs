namespace M_ERP
{
    partial class SuppPayables
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
            this.btn_addPay = new System.Windows.Forms.Button();
            this.txt_cmnts = new System.Windows.Forms.TextBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.supplierNameComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addPay
            // 
            this.btn_addPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addPay.ForeColor = System.Drawing.Color.White;
            this.btn_addPay.Location = new System.Drawing.Point(37, 311);
            this.btn_addPay.Name = "btn_addPay";
            this.btn_addPay.Size = new System.Drawing.Size(131, 43);
            this.btn_addPay.TabIndex = 21;
            this.btn_addPay.Text = "اضف مدفوعات";
            this.btn_addPay.UseVisualStyleBackColor = false;
            this.btn_addPay.Click += new System.EventHandler(this.btn_addPay_Click);
            // 
            // txt_cmnts
            // 
            this.txt_cmnts.Location = new System.Drawing.Point(328, 240);
            this.txt_cmnts.Name = "txt_cmnts";
            this.txt_cmnts.Size = new System.Drawing.Size(265, 27);
            this.txt_cmnts.TabIndex = 20;
            this.txt_cmnts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(409, 185);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(184, 27);
            this.txt_amount.TabIndex = 19;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.dtp_date.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_date.Location = new System.Drawing.Point(328, 126);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(275, 27);
            this.dtp_date.TabIndex = 18;
            // 
            // supplierNameComboBox
            // 
            this.supplierNameComboBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.supplierNameComboBox.FormattingEnabled = true;
            this.supplierNameComboBox.Location = new System.Drawing.Point(328, 64);
            this.supplierNameComboBox.Name = "supplierNameComboBox";
            this.supplierNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.supplierNameComboBox.Size = new System.Drawing.Size(275, 27);
            this.supplierNameComboBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(626, 188);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "المـبلــغ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(626, 132);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "التـاريـخ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(626, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "اسم المورد :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(626, 243);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "ملاحـظـات :";
            // 
            // SuppPayables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(749, 386);
            this.Controls.Add(this.btn_addPay);
            this.Controls.Add(this.txt_cmnts);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.supplierNameComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "SuppPayables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدفوعات المورد";
            this.Load += new System.EventHandler(this.SuppPayables_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addPay;
        private System.Windows.Forms.TextBox txt_cmnts;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox supplierNameComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;

    }
}