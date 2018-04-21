namespace cbhproj
{
    partial class DisplayColors
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
            this.lblColumn3.Location = new System.Drawing.Point(732, 168);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(315, 356);
            this.lblColumn3.TabIndex = 14;
            // 
            // lblColumn2
            // 
            this.lblColumn2.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn2.Location = new System.Drawing.Point(417, 168);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(315, 356);
            this.lblColumn2.TabIndex = 13;
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(102, 168);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(315, 356);
            this.lblColumn1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblColorHeading
            // 
            this.lblColorHeading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColorHeading.AutoSize = true;
            this.lblColorHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblColorHeading.Location = new System.Drawing.Point(418, 100);
            this.lblColorHeading.Name = "lblColorHeading";
            this.lblColorHeading.Size = new System.Drawing.Size(189, 31);
            this.lblColorHeading.TabIndex = 10;
            this.lblColorHeading.Text = "Vehicle Colors";
            // 
            // lblColorMenu
            // 
            this.lblColorMenu.AutoSize = true;
            this.lblColorMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblColorMenu.Location = new System.Drawing.Point(276, 60);
            this.lblColorMenu.Name = "lblColorMenu";
            this.lblColorMenu.Size = new System.Drawing.Size(473, 42);
            this.lblColorMenu.TabIndex = 9;
            this.lblColorMenu.Text = "Police Information System";
            // 
            // DisplayColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblColorHeading);
            this.Controls.Add(this.lblColorMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayColors";
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