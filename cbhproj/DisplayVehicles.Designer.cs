namespace cbhproj
{
    partial class DisplayVehicles
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
            this.lblStateHeading = new System.Windows.Forms.Label();
            this.lblStateMenu = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVMake = new System.Windows.Forms.Label();
            this.lblVType = new System.Windows.Forms.Label();
            this.lblTopColor = new System.Windows.Forms.Label();
            this.lblBottomColor = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblTagExpiration = new System.Windows.Forms.Label();
            this.btnNextVehicle = new System.Windows.Forms.Button();
            this.btnPreviousVehicle = new System.Windows.Forms.Button();
            this.lblVehicleCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStateHeading
            // 
            this.lblStateHeading.AutoSize = true;
            this.lblStateHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStateHeading.Location = new System.Drawing.Point(389, 100);
            this.lblStateHeading.Name = "lblStateHeading";
            this.lblStateHeading.Size = new System.Drawing.Size(246, 31);
            this.lblStateHeading.TabIndex = 6;
            this.lblStateHeading.Text = "Vehicle Information";
            // 
            // lblStateMenu
            // 
            this.lblStateMenu.AutoSize = true;
            this.lblStateMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateMenu.Location = new System.Drawing.Point(276, 60);
            this.lblStateMenu.Name = "lblStateMenu";
            this.lblStateMenu.Size = new System.Drawing.Size(473, 42);
            this.lblStateMenu.TabIndex = 5;
            this.lblStateMenu.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 77);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVMake
            // 
            this.lblVMake.AutoSize = true;
            this.lblVMake.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVMake.Location = new System.Drawing.Point(356, 254);
            this.lblVMake.Name = "lblVMake";
            this.lblVMake.Size = new System.Drawing.Size(110, 18);
            this.lblVMake.TabIndex = 26;
            this.lblVMake.Text = "Vehicle Make: ";
            // 
            // lblVType
            // 
            this.lblVType.AutoSize = true;
            this.lblVType.Font = new System.Drawing.Font("Arial", 12F);
            this.lblVType.Location = new System.Drawing.Point(362, 286);
            this.lblVType.Name = "lblVType";
            this.lblVType.Size = new System.Drawing.Size(104, 18);
            this.lblVType.TabIndex = 27;
            this.lblVType.Text = "Vehicle Type: ";
            // 
            // lblTopColor
            // 
            this.lblTopColor.AutoSize = true;
            this.lblTopColor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTopColor.Location = new System.Drawing.Point(383, 318);
            this.lblTopColor.Name = "lblTopColor";
            this.lblTopColor.Size = new System.Drawing.Size(83, 18);
            this.lblTopColor.TabIndex = 28;
            this.lblTopColor.Text = "Top Color: ";
            // 
            // lblBottomColor
            // 
            this.lblBottomColor.AutoSize = true;
            this.lblBottomColor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBottomColor.Location = new System.Drawing.Point(358, 350);
            this.lblBottomColor.Name = "lblBottomColor";
            this.lblBottomColor.Size = new System.Drawing.Size(108, 18);
            this.lblBottomColor.TabIndex = 29;
            this.lblBottomColor.Text = "Bottom Color: ";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTag.Location = new System.Drawing.Point(425, 382);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(41, 18);
            this.lblTag.TabIndex = 30;
            this.lblTag.Text = "Tag: ";
            // 
            // lblTagExpiration
            // 
            this.lblTagExpiration.AutoSize = true;
            this.lblTagExpiration.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTagExpiration.Location = new System.Drawing.Point(351, 414);
            this.lblTagExpiration.Name = "lblTagExpiration";
            this.lblTagExpiration.Size = new System.Drawing.Size(115, 18);
            this.lblTagExpiration.TabIndex = 31;
            this.lblTagExpiration.Text = "Tag Expiration: ";
            // 
            // btnNextVehicle
            // 
            this.btnNextVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextVehicle.Location = new System.Drawing.Point(725, 596);
            this.btnNextVehicle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnNextVehicle.Name = "btnNextVehicle";
            this.btnNextVehicle.Size = new System.Drawing.Size(242, 77);
            this.btnNextVehicle.TabIndex = 32;
            this.btnNextVehicle.Text = "Next Vehicle";
            this.btnNextVehicle.UseVisualStyleBackColor = true;
            this.btnNextVehicle.Click += new System.EventHandler(this.btnNextVehicle_Click);
            // 
            // btnPreviousVehicle
            // 
            this.btnPreviousVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousVehicle.Location = new System.Drawing.Point(58, 596);
            this.btnPreviousVehicle.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPreviousVehicle.Name = "btnPreviousVehicle";
            this.btnPreviousVehicle.Size = new System.Drawing.Size(242, 77);
            this.btnPreviousVehicle.TabIndex = 33;
            this.btnPreviousVehicle.Text = "Previous Vehicle";
            this.btnPreviousVehicle.UseVisualStyleBackColor = true;
            this.btnPreviousVehicle.Click += new System.EventHandler(this.btnPreviousVehicle_Click);
            // 
            // lblVehicleCount
            // 
            this.lblVehicleCount.AutoSize = true;
            this.lblVehicleCount.Font = new System.Drawing.Font("Arial", 14F);
            this.lblVehicleCount.Location = new System.Drawing.Point(460, 623);
            this.lblVehicleCount.Name = "lblVehicleCount";
            this.lblVehicleCount.Size = new System.Drawing.Size(104, 22);
            this.lblVehicleCount.TabIndex = 34;
            this.lblVehicleCount.Text = "Vehicle #/#";
            // 
            // DisplayVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblVehicleCount);
            this.Controls.Add(this.btnPreviousVehicle);
            this.Controls.Add(this.btnNextVehicle);
            this.Controls.Add(this.lblTagExpiration);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblBottomColor);
            this.Controls.Add(this.lblTopColor);
            this.Controls.Add(this.lblVType);
            this.Controls.Add(this.lblVMake);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStateHeading);
            this.Controls.Add(this.lblStateMenu);
            this.Name = "DisplayVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayVehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStateHeading;
        private System.Windows.Forms.Label lblStateMenu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVMake;
        private System.Windows.Forms.Label lblVType;
        private System.Windows.Forms.Label lblTopColor;
        private System.Windows.Forms.Label lblBottomColor;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblTagExpiration;
        private System.Windows.Forms.Button btnNextVehicle;
        private System.Windows.Forms.Button btnPreviousVehicle;
        private System.Windows.Forms.Label lblVehicleCount;
    }
}