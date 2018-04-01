namespace cbhproj
{
    partial class ColorMenu
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
            this.lblColumn3 = new System.Windows.Forms.Label();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblColorHeading = new System.Windows.Forms.Label();
            this.lblColorMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColumn3
            // 
            this.lblColumn3.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn3.Location = new System.Drawing.Point(709, 152);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(315, 475);
            this.lblColumn3.TabIndex = 14;
            // 
            // lblColumn2
            // 
            this.lblColumn2.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn2.Location = new System.Drawing.Point(406, 152);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(315, 475);
            this.lblColumn2.TabIndex = 13;
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(94, 152);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(315, 475);
            this.lblColumn1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(235, 630);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblColorHeading
            // 
            this.lblColorHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColorHeading.AutoSize = true;
            this.lblColorHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblColorHeading.Location = new System.Drawing.Point(334, 80);
            this.lblColorHeading.Name = "lblColorHeading";
            this.lblColorHeading.Size = new System.Drawing.Size(411, 67);
            this.lblColorHeading.TabIndex = 10;
            this.lblColorHeading.Text = "Vehicle Colors";
            // 
            // lblColorMenu
            // 
            this.lblColorMenu.AutoSize = true;
            this.lblColorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorMenu.Location = new System.Drawing.Point(170, 40);
            this.lblColorMenu.Name = "lblColorMenu";
            this.lblColorMenu.Size = new System.Drawing.Size(857, 79);
            this.lblColorMenu.TabIndex = 9;
            this.lblColorMenu.Text = "Police Information System";
            // 
            // ColorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblColorHeading);
            this.Controls.Add(this.lblColorMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColorMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorMenu";
            this.Load += new System.EventHandler(this.ColorMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColumn3;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblColorHeading;
        private System.Windows.Forms.Label lblColorMenu;
    }
}