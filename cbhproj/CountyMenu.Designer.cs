namespace cbhproj
{
    partial class CountyMenu
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCountySubHeading = new System.Windows.Forms.Label();
            this.lblCountyMenu = new System.Windows.Forms.Label();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.lblColumn3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(433, 637);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 57);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCountySubHeading
            // 
            this.lblCountySubHeading.AutoSize = true;
            this.lblCountySubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblCountySubHeading.Location = new System.Drawing.Point(361, 70);
            this.lblCountySubHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountySubHeading.Name = "lblCountySubHeading";
            this.lblCountySubHeading.Size = new System.Drawing.Size(292, 55);
            this.lblCountySubHeading.TabIndex = 7;
            this.lblCountySubHeading.Text = "County Data";
            // 
            // lblCountyMenu
            // 
            this.lblCountyMenu.AutoSize = true;
            this.lblCountyMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountyMenu.Location = new System.Drawing.Point(40, 0);
            this.lblCountyMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountyMenu.Name = "lblCountyMenu";
            this.lblCountyMenu.Size = new System.Drawing.Size(857, 79);
            this.lblCountyMenu.TabIndex = 6;
            this.lblCountyMenu.Text = "Police Information System";
            // 
            // lblColumn2
            // 
            this.lblColumn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColumn2.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblColumn2.Location = new System.Drawing.Point(350, 135);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(315, 498);
            this.lblColumn2.TabIndex = 9;
            // 
            // lblColumn1
            // 
            this.lblColumn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColumn1.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblColumn1.Location = new System.Drawing.Point(12, 135);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(315, 498);
            this.lblColumn1.TabIndex = 10;
            // 
            // lblColumn3
            // 
            this.lblColumn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColumn3.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.lblColumn3.Location = new System.Drawing.Point(688, 135);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(315, 498);
            this.lblColumn3.TabIndex = 11;
            // 
            // CountyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCountySubHeading);
            this.Controls.Add(this.lblCountyMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CountyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CountyMenu";
            this.Load += new System.EventHandler(this.CountyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCountySubHeading;
        private System.Windows.Forms.Label lblCountyMenu;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Label lblColumn3;
    }
}