namespace cbhproj
{
    partial class DisplayCounties
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
            this.lblCountySubHeading = new System.Windows.Forms.Label();
            this.lblCountyMenu = new System.Windows.Forms.Label();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.lblColumn3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCountySubHeading
            // 
            this.lblCountySubHeading.AutoSize = true;
            this.lblCountySubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCountySubHeading.Location = new System.Drawing.Point(429, 100);
            this.lblCountySubHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountySubHeading.Name = "lblCountySubHeading";
            this.lblCountySubHeading.Size = new System.Drawing.Size(166, 31);
            this.lblCountySubHeading.TabIndex = 7;
            this.lblCountySubHeading.Text = "County Data";
            // 
            // lblCountyMenu
            // 
            this.lblCountyMenu.AutoSize = true;
            this.lblCountyMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblCountyMenu.Location = new System.Drawing.Point(276, 60);
            this.lblCountyMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountyMenu.Name = "lblCountyMenu";
            this.lblCountyMenu.Size = new System.Drawing.Size(473, 42);
            this.lblCountyMenu.TabIndex = 6;
            this.lblCountyMenu.Text = "Police Information System";
            // 
            // lblColumn2
            // 
            this.lblColumn2.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn2.Location = new System.Drawing.Point(428, 144);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(315, 534);
            this.lblColumn2.TabIndex = 9;
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(90, 144);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(315, 534);
            this.lblColumn1.TabIndex = 10;
            // 
            // lblColumn3
            // 
            this.lblColumn3.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn3.Location = new System.Drawing.Point(766, 144);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(315, 534);
            this.lblColumn3.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // DisplayCounties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.lblCountySubHeading);
            this.Controls.Add(this.lblCountyMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayCounties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountyMenu";
            this.Load += new System.EventHandler(this.CountyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCountySubHeading;
        private System.Windows.Forms.Label lblCountyMenu;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Label lblColumn3;
        private System.Windows.Forms.Button btnClose;
    }
}