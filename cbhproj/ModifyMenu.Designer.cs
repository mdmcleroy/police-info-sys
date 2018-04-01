namespace cbhproj
{
    partial class ModifyMenu
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
            this.lblModifyRecordSubHeading = new System.Windows.Forms.Label();
            this.lblModifyRecordHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(360, 644);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 79);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblModifyRecordSubHeading
            // 
            this.lblModifyRecordSubHeading.AutoSize = true;
            this.lblModifyRecordSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblModifyRecordSubHeading.Location = new System.Drawing.Point(321, 79);
            this.lblModifyRecordSubHeading.Name = "lblModifyRecordSubHeading";
            this.lblModifyRecordSubHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblModifyRecordSubHeading.Size = new System.Drawing.Size(374, 55);
            this.lblModifyRecordSubHeading.TabIndex = 11;
            this.lblModifyRecordSubHeading.Text = "Modify a Record";
            // 
            // lblModifyRecordHeading
            // 
            this.lblModifyRecordHeading.AutoSize = true;
            this.lblModifyRecordHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyRecordHeading.Location = new System.Drawing.Point(79, 0);
            this.lblModifyRecordHeading.Name = "lblModifyRecordHeading";
            this.lblModifyRecordHeading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblModifyRecordHeading.Size = new System.Drawing.Size(857, 79);
            this.lblModifyRecordHeading.TabIndex = 10;
            this.lblModifyRecordHeading.Text = "Police Information System";
            this.lblModifyRecordHeading.Click += new System.EventHandler(this.lblDeleteRecordHeading_Click);
            // 
            // ModifyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1015, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblModifyRecordSubHeading);
            this.Controls.Add(this.lblModifyRecordHeading);
            this.Name = "ModifyRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModifyRecordSubHeading;
        private System.Windows.Forms.Label lblModifyRecordHeading;
    }
}