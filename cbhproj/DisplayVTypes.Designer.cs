namespace cbhproj
{
    partial class DisplayVTypes
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
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVTypeHeading = new System.Windows.Forms.Label();
            this.lblVTypeMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColumn2
            // 
            this.lblColumn2.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn2.Location = new System.Drawing.Point(565, 248);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(239, 260);
            this.lblColumn2.TabIndex = 19;
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(278, 248);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(239, 260);
            this.lblColumn1.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 77);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVTypeHeading
            // 
            this.lblVTypeHeading.AutoSize = true;
            this.lblVTypeHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblVTypeHeading.Location = new System.Drawing.Point(420, 100);
            this.lblVTypeHeading.Name = "lblVTypeHeading";
            this.lblVTypeHeading.Size = new System.Drawing.Size(185, 31);
            this.lblVTypeHeading.TabIndex = 16;
            this.lblVTypeHeading.Text = "Vehicle Types";
            // 
            // lblVTypeMenu
            // 
            this.lblVTypeMenu.AutoSize = true;
            this.lblVTypeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblVTypeMenu.Location = new System.Drawing.Point(276, 60);
            this.lblVTypeMenu.Name = "lblVTypeMenu";
            this.lblVTypeMenu.Size = new System.Drawing.Size(473, 42);
            this.lblVTypeMenu.TabIndex = 15;
            this.lblVTypeMenu.Text = "Police Information System";
            // 
            // DisplayVTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVTypeHeading);
            this.Controls.Add(this.lblVTypeMenu);
            this.Name = "DisplayVTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTypeMenu";
            this.Load += new System.EventHandler(this.VTypeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVTypeHeading;
        private System.Windows.Forms.Label lblVTypeMenu;
    }
}