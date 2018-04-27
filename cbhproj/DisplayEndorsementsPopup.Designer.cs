namespace cbhproj
{
    partial class DisplayEndorsementsPopup
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
            this.lblSearch = new System.Windows.Forms.Button();
            this.lblEndorsements = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.lblSearch.Location = new System.Drawing.Point(126, 167);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(122, 36);
            this.lblSearch.TabIndex = 50;
            this.lblSearch.Text = "Close";
            this.lblSearch.UseVisualStyleBackColor = true;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // lblEndorsements
            // 
            this.lblEndorsements.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndorsements.Location = new System.Drawing.Point(24, 15);
            this.lblEndorsements.Name = "lblEndorsements";
            this.lblEndorsements.Size = new System.Drawing.Size(326, 113);
            this.lblEndorsements.TabIndex = 49;
            // 
            // DisplayEndorsementsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(374, 219);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblEndorsements);
            this.Name = "DisplayEndorsementsPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayEndorsementsPopup";
            this.Load += new System.EventHandler(this.DisplayEndorsementsPopup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lblSearch;
        private System.Windows.Forms.Label lblEndorsements;
    }
}