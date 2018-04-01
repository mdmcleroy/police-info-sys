namespace cbhproj
{
    partial class AddMenu
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
            this.lblAddRecordSubHeading = new System.Windows.Forms.Label();
            this.lblAddRecordHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddRecordSubHeading
            // 
            this.lblAddRecordSubHeading.AutoSize = true;
            this.lblAddRecordSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblAddRecordSubHeading.Location = new System.Drawing.Point(348, 78);
            this.lblAddRecordSubHeading.Name = "lblAddRecordSubHeading";
            this.lblAddRecordSubHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddRecordSubHeading.Size = new System.Drawing.Size(319, 55);
            this.lblAddRecordSubHeading.TabIndex = 7;
            this.lblAddRecordSubHeading.Text = "Add a Record";
            // 
            // lblAddRecordHeading
            // 
            this.lblAddRecordHeading.AutoSize = true;
            this.lblAddRecordHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRecordHeading.Location = new System.Drawing.Point(79, -1);
            this.lblAddRecordHeading.Name = "lblAddRecordHeading";
            this.lblAddRecordHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddRecordHeading.Size = new System.Drawing.Size(857, 79);
            this.lblAddRecordHeading.TabIndex = 6;
            this.lblAddRecordHeading.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(362, 615);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAddRecordSubHeading);
            this.Controls.Add(this.lblAddRecordHeading);
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddRecordSubHeading;
        private System.Windows.Forms.Label lblAddRecordHeading;
        private System.Windows.Forms.Button btnClose;
    }
}