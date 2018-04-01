namespace cbhproj
{
    partial class DeleteMenu
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
            this.lblDeleteRecordSubHeading = new System.Windows.Forms.Label();
            this.lblDeleteRecordHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteRecordSubHeading
            // 
            this.lblDeleteRecordSubHeading.AutoSize = true;
            this.lblDeleteRecordSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblDeleteRecordSubHeading.Location = new System.Drawing.Point(321, 78);
            this.lblDeleteRecordSubHeading.Name = "lblDeleteRecordSubHeading";
            this.lblDeleteRecordSubHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeleteRecordSubHeading.Size = new System.Drawing.Size(372, 55);
            this.lblDeleteRecordSubHeading.TabIndex = 7;
            this.lblDeleteRecordSubHeading.Text = "Delete a Record";
            // 
            // lblDeleteRecordHeading
            // 
            this.lblDeleteRecordHeading.AutoSize = true;
            this.lblDeleteRecordHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteRecordHeading.Location = new System.Drawing.Point(79, -1);
            this.lblDeleteRecordHeading.Name = "lblDeleteRecordHeading";
            this.lblDeleteRecordHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeleteRecordHeading.Size = new System.Drawing.Size(857, 79);
            this.lblDeleteRecordHeading.TabIndex = 6;
            this.lblDeleteRecordHeading.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(360, 618);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDeleteRecordSubHeading);
            this.Controls.Add(this.lblDeleteRecordHeading);
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteRecordSubHeading;
        private System.Windows.Forms.Label lblDeleteRecordHeading;
        private System.Windows.Forms.Button btnClose;
    }
}