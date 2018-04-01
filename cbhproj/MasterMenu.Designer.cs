namespace cbhproj
{
    partial class MasterMenu
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
            this.lblMasterHeading = new System.Windows.Forms.Label();
            this.lblMasterMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(362, 617);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMasterHeading
            // 
            this.lblMasterHeading.AutoSize = true;
            this.lblMasterHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblMasterHeading.Location = new System.Drawing.Point(334, 80);
            this.lblMasterHeading.Name = "lblMasterHeading";
            this.lblMasterHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMasterHeading.Size = new System.Drawing.Size(347, 55);
            this.lblMasterHeading.TabIndex = 10;
            this.lblMasterHeading.Text = "List Master File";
            // 
            // lblMasterMenu
            // 
            this.lblMasterMenu.AutoSize = true;
            this.lblMasterMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterMenu.Location = new System.Drawing.Point(79, 1);
            this.lblMasterMenu.Name = "lblMasterMenu";
            this.lblMasterMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMasterMenu.Size = new System.Drawing.Size(857, 79);
            this.lblMasterMenu.TabIndex = 9;
            this.lblMasterMenu.Text = "Police Information System";
            // 
            // MasterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMasterHeading);
            this.Controls.Add(this.lblMasterMenu);
            this.Name = "MasterMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListMaster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMasterHeading;
        private System.Windows.Forms.Label lblMasterMenu;
    }
}