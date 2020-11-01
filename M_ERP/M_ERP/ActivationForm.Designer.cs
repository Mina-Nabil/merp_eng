namespace M_ERP
{
    partial class ActivationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivationForm));
            this.MacAddressTB = new System.Windows.Forms.TextBox();
            this.activateCodeTB = new System.Windows.Forms.TextBox();
            this.activateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MacAddressTB
            // 
            this.MacAddressTB.Enabled = false;
            this.MacAddressTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.MacAddressTB.Location = new System.Drawing.Point(32, 85);
            this.MacAddressTB.Name = "MacAddressTB";
            this.MacAddressTB.Size = new System.Drawing.Size(310, 27);
            this.MacAddressTB.TabIndex = 0;
            this.MacAddressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activateCodeTB
            // 
            this.activateCodeTB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.activateCodeTB.Location = new System.Drawing.Point(32, 184);
            this.activateCodeTB.Name = "activateCodeTB";
            this.activateCodeTB.Size = new System.Drawing.Size(310, 27);
            this.activateCodeTB.TabIndex = 1;
            this.activateCodeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activateBtn
            // 
            this.activateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activateBtn.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.activateBtn.ForeColor = System.Drawing.Color.White;
            this.activateBtn.Location = new System.Drawing.Point(133, 264);
            this.activateBtn.Name = "activateBtn";
            this.activateBtn.Size = new System.Drawing.Size(120, 37);
            this.activateBtn.TabIndex = 2;
            this.activateBtn.Text = "تفعيل";
            this.activateBtn.UseVisualStyleBackColor = false;
            this.activateBtn.Click += new System.EventHandler(this.activateBtn_Click);
            // 
            // ActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::M_ERP.Properties.Resources.BgB1;
            this.ClientSize = new System.Drawing.Size(392, 326);
            this.Controls.Add(this.activateBtn);
            this.Controls.Add(this.activateCodeTB);
            this.Controls.Add(this.MacAddressTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كود التسجيل";
            this.Load += new System.EventHandler(this.ActivationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MacAddressTB;
        private System.Windows.Forms.TextBox activateCodeTB;
        private System.Windows.Forms.Button activateBtn;
    }
}