namespace cbhproj
{
    partial class OLNMenu
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
            this.lblOLNSubHeading = new System.Windows.Forms.Label();
            this.lblOLNHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOLNSubHeading
            // 
            this.lblOLNSubHeading.AutoSize = true;
            this.lblOLNSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblOLNSubHeading.Location = new System.Drawing.Point(208, 80);
            this.lblOLNSubHeading.Name = "lblOLNSubHeading";
            this.lblOLNSubHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOLNSubHeading.Size = new System.Drawing.Size(598, 55);
            this.lblOLNSubHeading.TabIndex = 5;
            this.lblOLNSubHeading.Text = "Display a Record (by OLN)";
            // 
            // lblOLNHeading
            // 
            this.lblOLNHeading.AutoSize = true;
            this.lblOLNHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOLNHeading.Location = new System.Drawing.Point(79, 1);
            this.lblOLNHeading.Name = "lblOLNHeading";
            this.lblOLNHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOLNHeading.Size = new System.Drawing.Size(857, 79);
            this.lblOLNHeading.TabIndex = 4;
            this.lblOLNHeading.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(360, 657);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OLNMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOLNSubHeading);
            this.Controls.Add(this.lblOLNHeading);
            this.Name = "OLNMenu";
            this.Text = "OLNMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOLNSubHeading;
        private System.Windows.Forms.Label lblOLNHeading;
        private System.Windows.Forms.Button btnClose;
    }
}