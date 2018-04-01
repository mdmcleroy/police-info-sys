namespace cbhproj
{
    partial class SSNMenu
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
            this.lblSSNSubHeading = new System.Windows.Forms.Label();
            this.lblSSNHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSSNSubHeading
            // 
            this.lblSSNSubHeading.AutoSize = true;
            this.lblSSNSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblSSNSubHeading.Location = new System.Drawing.Point(209, 79);
            this.lblSSNSubHeading.Name = "lblSSNSubHeading";
            this.lblSSNSubHeading.Size = new System.Drawing.Size(598, 55);
            this.lblSSNSubHeading.TabIndex = 3;
            this.lblSSNSubHeading.Text = "Display a Record (by SSN)";
            // 
            // lblSSNHeading
            // 
            this.lblSSNHeading.AutoSize = true;
            this.lblSSNHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSNHeading.Location = new System.Drawing.Point(80, 0);
            this.lblSSNHeading.Name = "lblSSNHeading";
            this.lblSSNHeading.Size = new System.Drawing.Size(857, 79);
            this.lblSSNHeading.TabIndex = 2;
            this.lblSSNHeading.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(361, 657);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SSNMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1016, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSSNSubHeading);
            this.Controls.Add(this.lblSSNHeading);
            this.Name = "SSNMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSNMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSSNSubHeading;
        private System.Windows.Forms.Label lblSSNHeading;
        private System.Windows.Forms.Button btnClose;
    }
}