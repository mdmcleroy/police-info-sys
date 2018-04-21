namespace cbhproj
{
    partial class DisplayStates
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
            this.lblStateHeading = new System.Windows.Forms.Label();
            this.lblStateMenu = new System.Windows.Forms.Label();
            this.lblColumn1 = new System.Windows.Forms.Label();
            this.lblColumn2 = new System.Windows.Forms.Label();
            this.lblColumn3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStateHeading
            // 
            this.lblStateHeading.AutoSize = true;
            this.lblStateHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStateHeading.Location = new System.Drawing.Point(441, 100);
            this.lblStateHeading.Name = "lblStateHeading";
            this.lblStateHeading.Size = new System.Drawing.Size(143, 31);
            this.lblStateHeading.TabIndex = 4;
            this.lblStateHeading.Text = "State Data";
            this.lblStateHeading.Click += new System.EventHandler(this.lblAuxFiles_Click);
            // 
            // lblStateMenu
            // 
            this.lblStateMenu.AutoSize = true;
            this.lblStateMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMenu.Location = new System.Drawing.Point(276, 60);
            this.lblStateMenu.Name = "lblStateMenu";
            this.lblStateMenu.Size = new System.Drawing.Size(473, 42);
            this.lblStateMenu.TabIndex = 3;
            this.lblStateMenu.Text = "Police Information System";
            this.lblStateMenu.Click += new System.EventHandler(this.lblAuxMenu_Click);
            // 
            // lblColumn1
            // 
            this.lblColumn1.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn1.Location = new System.Drawing.Point(118, 170);
            this.lblColumn1.Name = "lblColumn1";
            this.lblColumn1.Size = new System.Drawing.Size(315, 475);
            this.lblColumn1.TabIndex = 6;
            // 
            // lblColumn2
            // 
            this.lblColumn2.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn2.Location = new System.Drawing.Point(433, 170);
            this.lblColumn2.Name = "lblColumn2";
            this.lblColumn2.Size = new System.Drawing.Size(315, 475);
            this.lblColumn2.TabIndex = 7;
            // 
            // lblColumn3
            // 
            this.lblColumn3.Font = new System.Drawing.Font("Arial", 14.125F);
            this.lblColumn3.Location = new System.Drawing.Point(748, 170);
            this.lblColumn3.Name = "lblColumn3";
            this.lblColumn3.Size = new System.Drawing.Size(315, 475);
            this.lblColumn3.TabIndex = 8;
            // 
            // StateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblColumn3);
            this.Controls.Add(this.lblColumn2);
            this.Controls.Add(this.lblColumn1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStateHeading);
            this.Controls.Add(this.lblStateMenu);
            this.Name = "StateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateMenu";
            this.Load += new System.EventHandler(this.StateMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStateHeading;
        private System.Windows.Forms.Label lblStateMenu;
        private System.Windows.Forms.Label lblColumn1;
        private System.Windows.Forms.Label lblColumn2;
        private System.Windows.Forms.Label lblColumn3;
    }
}