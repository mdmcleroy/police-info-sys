namespace cbhproj
{
    partial class DisplayVMakes
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
            this.lblVMakeHeading = new System.Windows.Forms.Label();
            this.lblVMakeMenu = new System.Windows.Forms.Label();
            this.lblColumn4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColumn3
            // 
            this.lblColumn3.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn3.Location = new System.Drawing.Point(538, 158);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(183, 510);
            this.lblColumn3.TabIndex = 14;
            // 
            // lblColumn2
            // 
            this.lblColumn2.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn2.Location = new System.Drawing.Point(325, 158);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(183, 510);
            this.lblColumn2.TabIndex = 13;
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(112, 158);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(183, 510);
            this.lblColumn1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 77);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblVMakeHeading
            // 
            this.lblVMakeHeading.AutoSize = true;
            this.lblVMakeHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblVMakeHeading.Location = new System.Drawing.Point(417, 100);
            this.lblVMakeHeading.Name = "lblVMakeHeading";
            this.lblVMakeHeading.Size = new System.Drawing.Size(190, 31);
            this.lblVMakeHeading.TabIndex = 10;
            this.lblVMakeHeading.Text = "Vehicle Makes";
            // 
            // lblVMakeMenu
            // 
            this.lblVMakeMenu.AutoSize = true;
            this.lblVMakeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblVMakeMenu.Location = new System.Drawing.Point(276, 60);
            this.lblVMakeMenu.Name = "lblVMakeMenu";
            this.lblVMakeMenu.Size = new System.Drawing.Size(473, 42);
            this.lblVMakeMenu.TabIndex = 9;
            this.lblVMakeMenu.Text = "Police Information System";
            // 
            // lblColumn4
            // 
            this.lblColumn4.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn4.Location = new System.Drawing.Point(751, 158);
            this.lblColumn4.Name = "lblColumn4";
            this.lblColumn4.Size = new System.Drawing.Size(183, 510);
            this.lblColumn4.TabIndex = 15;
            // 
            // DisplayVMakes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblColumn4);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVMakeHeading);
            this.Controls.Add(this.lblVMakeMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplayVMakes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VMakeMenu";
            this.Load += new System.EventHandler(this.VMakeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColumn3;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVMakeHeading;
        private System.Windows.Forms.Label lblVMakeMenu;
        private System.Windows.Forms.Label lblColumn4;
    }
}