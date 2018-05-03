namespace cbhproj
{
    partial class ListAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAll));
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblStateMenu = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtListAll = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubHeading.Location = new System.Drawing.Point(465, 100);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(94, 31);
            this.lblSubHeading.TabIndex = 8;
            this.lblSubHeading.Text = "List All";
            this.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStateMenu
            // 
            this.lblStateMenu.AutoSize = true;
            this.lblStateMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMenu.Location = new System.Drawing.Point(276, 9);
            this.lblStateMenu.Name = "lblStateMenu";
            this.lblStateMenu.Size = new System.Drawing.Size(473, 42);
            this.lblStateMenu.TabIndex = 7;
            this.lblStateMenu.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 77);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtListAll
            // 
            this.txtListAll.BackColor = System.Drawing.SystemColors.Menu;
            this.txtListAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListAll.Location = new System.Drawing.Point(-1, 193);
            this.txtListAll.Multiline = true;
            this.txtListAll.Name = "txtListAll";
            this.txtListAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListAll.Size = new System.Drawing.Size(1027, 477);
            this.txtListAll.TabIndex = 21;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.SystemColors.Menu;
            this.txtHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeading.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtHeading.Location = new System.Drawing.Point(-1, 92);
            this.txtHeading.Multiline = true;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(1027, 100);
            this.txtHeading.TabIndex = 22;
            this.txtHeading.Text = resources.GetString("txtHeading.Text");
            // 
            // ListAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.txtListAll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblStateMenu);
            this.Name = "ListAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListAll";
            this.Load += new System.EventHandler(this.ListAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblStateMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtListAll;
        private System.Windows.Forms.TextBox txtHeading;
    }
}