namespace cbhproj
{
    partial class DisplayClasses
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
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStateHeading = new System.Windows.Forms.Label();
            this.lblStateMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(316, 167);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(426, 374);
            this.lblColumn1.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 646);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStateHeading
            // 
            this.lblStateHeading.AutoSize = true;
            this.lblStateHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStateHeading.Location = new System.Drawing.Point(406, 100);
            this.lblStateHeading.Name = "lblStateHeading";
            this.lblStateHeading.Size = new System.Drawing.Size(213, 31);
            this.lblStateHeading.TabIndex = 10;
            this.lblStateHeading.Text = "License Classes";
            // 
            // lblStateMenu
            // 
            this.lblStateMenu.AutoSize = true;
            this.lblStateMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMenu.Location = new System.Drawing.Point(276, 60);
            this.lblStateMenu.Name = "lblStateMenu";
            this.lblStateMenu.Size = new System.Drawing.Size(473, 42);
            this.lblStateMenu.TabIndex = 9;
            this.lblStateMenu.Text = "Police Information System";
            // 
            // DisplayClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStateHeading);
            this.Controls.Add(this.lblStateMenu);
            this.Name = "DisplayClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayClasses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStateHeading;
        private System.Windows.Forms.Label lblStateMenu;
    }
}