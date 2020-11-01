namespace M_ERP
{
    partial class RecordTreasury
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordTreasury));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_TreasEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.cmb_TEType = new System.Windows.Forms.ComboBox();
            this.txt_TETitle = new System.Windows.Forms.TextBox();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(453, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "تاريخ: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(453, 188);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "عنوان الحركه: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(453, 87);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "المبلغ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(453, 134);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "نوع الحركه: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(453, 240);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "ملاحظات: ";
            // 
            // dtp_TreasEntryDate
            // 
            this.dtp_TreasEntryDate.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.dtp_TreasEntryDate.Location = new System.Drawing.Point(141, 31);
            this.dtp_TreasEntryDate.Name = "dtp_TreasEntryDate";
            this.dtp_TreasEntryDate.Size = new System.Drawing.Size(273, 27);
            this.dtp_TreasEntryDate.TabIndex = 0;
            this.dtp_TreasEntryDate.ValueChanged += new System.EventHandler(this.dtp_TreasEntryDate_ValueChanged);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_Amount.Location = new System.Drawing.Point(161, 85);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Amount.Size = new System.Drawing.Size(253, 27);
            this.txt_Amount.TabIndex = 1;
            // 
            // cmb_TEType
            // 
            this.cmb_TEType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TEType.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.cmb_TEType.FormattingEnabled = true;
            this.cmb_TEType.Location = new System.Drawing.Point(161, 130);
            this.cmb_TEType.Name = "cmb_TEType";
            this.cmb_TEType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_TEType.Size = new System.Drawing.Size(253, 27);
            this.cmb_TEType.TabIndex = 2;
            // 
            // txt_TETitle
            // 
            this.txt_TETitle.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_TETitle.Location = new System.Drawing.Point(161, 184);
            this.txt_TETitle.Name = "txt_TETitle";
            this.txt_TETitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_TETitle.Size = new System.Drawing.Size(253, 27);
            this.txt_TETitle.TabIndex = 3;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.txt_Notes.Location = new System.Drawing.Point(86, 228);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Notes.Size = new System.Drawing.Size(328, 52);
            this.txt_Notes.TabIndex = 4;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.save_btn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(29, 305);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(118, 40);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "حـفـظ";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // RecordTreasury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.txt_TETitle);
            this.Controls.Add(this.cmb_TEType);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.dtp_TreasEntryDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordTreasury";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل النقدية";
            this.Load += new System.EventHandler(this.RecordTreasury_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_TreasEntryDate;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.ComboBox cmb_TEType;
        private System.Windows.Forms.TextBox txt_TETitle;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Button save_btn;
    }
}