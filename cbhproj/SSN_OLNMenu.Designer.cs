namespace cbhproj
{
    partial class SSN_OLNMenu
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
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblSSNHeading = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblOLN = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblHairColor = new System.Windows.Forms.Label();
            this.lblOrganDonor = new System.Windows.Forms.Label();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblRestriction = new System.Windows.Forms.Label();
            this.lblEndorsement = new System.Windows.Forms.Label();
            this.lblStateLicense = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.lblUserPrompt = new System.Windows.Forms.Label();
            this.lblFlagMessage = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbDriverPic = new System.Windows.Forms.PictureBox();
            this.btnVehicleInfo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNumVehicles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubHeading.Location = new System.Drawing.Point(343, 100);
            this.lblSubHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(338, 31);
            this.lblSubHeading.TabIndex = 3;
            this.lblSubHeading.Text = "Display a Record (by SSN)";
            // 
            // lblSSNHeading
            // 
            this.lblSSNHeading.AutoSize = true;
            this.lblSSNHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblSSNHeading.Location = new System.Drawing.Point(276, 60);
            this.lblSSNHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSNHeading.Name = "lblSSNHeading";
            this.lblSSNHeading.Size = new System.Drawing.Size(473, 42);
            this.lblSSNHeading.TabIndex = 2;
            this.lblSSNHeading.Text = "Police Information System";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(365, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 77);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Font = new System.Drawing.Font("Arial", 14F);
            this.txtUserInput.Location = new System.Drawing.Point(436, 175);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(152, 29);
            this.txtUserInput.TabIndex = 19;
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInput.TextChanged += new System.EventHandler(this.txtUserSSN_TextChanged);
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSSN.Location = new System.Drawing.Point(107, 433);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(130, 18);
            this.lblSSN.TabIndex = 20;
            this.lblSSN.Text = "SSN: 143466098";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblName.Location = new System.Drawing.Point(107, 262);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(181, 18);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "LastName, FirstName MI";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAddress1.Location = new System.Drawing.Point(107, 296);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(76, 18);
            this.lblAddress1.TabIndex = 22;
            this.lblAddress1.Text = "Address1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAddress2.Location = new System.Drawing.Point(107, 330);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(76, 18);
            this.lblAddress2.TabIndex = 23;
            this.lblAddress2.Text = "Address2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCity.Location = new System.Drawing.Point(107, 364);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 18);
            this.lblCity.TabIndex = 24;
            this.lblCity.Text = "City";
            // 
            // lblOLN
            // 
            this.lblOLN.AutoSize = true;
            this.lblOLN.Font = new System.Drawing.Font("Arial", 12F);
            this.lblOLN.Location = new System.Drawing.Point(457, 482);
            this.lblOLN.Name = "lblOLN";
            this.lblOLN.Size = new System.Drawing.Size(111, 18);
            this.lblOLN.TabIndex = 25;
            this.lblOLN.Text = "OLN: 1234567";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Arial", 12F);
            this.lblZip.Location = new System.Drawing.Point(280, 398);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(94, 18);
            this.lblZip.TabIndex = 26;
            this.lblZip.Text = "35057-1234";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 12F);
            this.lblState.Location = new System.Drawing.Point(107, 398);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(124, 18);
            this.lblState.TabIndex = 27;
            this.lblState.Text = "(01) AL Alabama";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial", 12F);
            this.lblHeight.Location = new System.Drawing.Point(628, 262);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 18);
            this.lblHeight.TabIndex = 28;
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEyeColor.Location = new System.Drawing.Point(772, 262);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(85, 18);
            this.lblEyeColor.TabIndex = 29;
            this.lblEyeColor.Text = "Eye Color: ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 12F);
            this.lblWeight.Location = new System.Drawing.Point(624, 296);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 18);
            this.lblWeight.TabIndex = 30;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGender.Location = new System.Drawing.Point(622, 330);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 18);
            this.lblGender.TabIndex = 31;
            // 
            // lblHairColor
            // 
            this.lblHairColor.AutoSize = true;
            this.lblHairColor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblHairColor.Location = new System.Drawing.Point(772, 296);
            this.lblHairColor.Name = "lblHairColor";
            this.lblHairColor.Size = new System.Drawing.Size(87, 18);
            this.lblHairColor.TabIndex = 32;
            this.lblHairColor.Text = "Hair Color: ";
            // 
            // lblOrganDonor
            // 
            this.lblOrganDonor.AutoSize = true;
            this.lblOrganDonor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblOrganDonor.Location = new System.Drawing.Point(753, 330);
            this.lblOrganDonor.Name = "lblOrganDonor";
            this.lblOrganDonor.Size = new System.Drawing.Size(0, 18);
            this.lblOrganDonor.TabIndex = 33;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIssue.Location = new System.Drawing.Point(358, 578);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(52, 18);
            this.lblIssue.TabIndex = 34;
            this.lblIssue.Text = "Issue: ";
            // 
            // lblRestriction
            // 
            this.lblRestriction.AutoSize = true;
            this.lblRestriction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRestriction.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRestriction.Location = new System.Drawing.Point(576, 512);
            this.lblRestriction.Name = "lblRestriction";
            this.lblRestriction.Size = new System.Drawing.Size(90, 18);
            this.lblRestriction.TabIndex = 35;
            this.lblRestriction.Text = "Restriction: ";
            this.lblRestriction.Click += new System.EventHandler(this.lblRestriction_Click);
            // 
            // lblEndorsement
            // 
            this.lblEndorsement.AutoSize = true;
            this.lblEndorsement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEndorsement.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndorsement.Location = new System.Drawing.Point(557, 545);
            this.lblEndorsement.Name = "lblEndorsement";
            this.lblEndorsement.Size = new System.Drawing.Size(109, 18);
            this.lblEndorsement.TabIndex = 36;
            this.lblEndorsement.Text = "Endorsement: ";
            this.lblEndorsement.Click += new System.EventHandler(this.lblEndorsement_Click);
            // 
            // lblStateLicense
            // 
            this.lblStateLicense.AutoSize = true;
            this.lblStateLicense.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStateLicense.Location = new System.Drawing.Point(557, 578);
            this.lblStateLicense.Name = "lblStateLicense";
            this.lblStateLicense.Size = new System.Drawing.Size(124, 18);
            this.lblStateLicense.TabIndex = 37;
            this.lblStateLicense.Text = "(01) AL Alabama";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCounty.Location = new System.Drawing.Point(557, 611);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(87, 18);
            this.lblCounty.TabIndex = 38;
            this.lblCounty.Text = "(58) Shelby";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStatus.Location = new System.Drawing.Point(350, 512);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 18);
            this.lblStatus.TabIndex = 39;
            this.lblStatus.Text = "Status: ";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClass.Font = new System.Drawing.Font("Arial", 12F);
            this.lblClass.Location = new System.Drawing.Point(354, 545);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(56, 18);
            this.lblClass.TabIndex = 40;
            this.lblClass.Text = "Class: ";
            this.lblClass.Click += new System.EventHandler(this.lblClass_Click);
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Arial", 12F);
            this.lblExpiration.Location = new System.Drawing.Point(324, 611);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(86, 18);
            this.lblExpiration.TabIndex = 41;
            this.lblExpiration.Text = "Expiration: ";
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLicenseInfo.Location = new System.Drawing.Point(467, 449);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(91, 18);
            this.lblLicenseInfo.TabIndex = 42;
            this.lblLicenseInfo.Text = "License Info";
            // 
            // lblUserPrompt
            // 
            this.lblUserPrompt.AutoSize = true;
            this.lblUserPrompt.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUserPrompt.Location = new System.Drawing.Point(467, 147);
            this.lblUserPrompt.Name = "lblUserPrompt";
            this.lblUserPrompt.Size = new System.Drawing.Size(90, 18);
            this.lblUserPrompt.TabIndex = 43;
            this.lblUserPrompt.Text = "Enter SSN: ";
            // 
            // lblFlagMessage
            // 
            this.lblFlagMessage.AutoSize = true;
            this.lblFlagMessage.Font = new System.Drawing.Font("Arial", 12F);
            this.lblFlagMessage.Location = new System.Drawing.Point(676, 734);
            this.lblFlagMessage.Name = "lblFlagMessage";
            this.lblFlagMessage.Size = new System.Drawing.Size(0, 18);
            this.lblFlagMessage.TabIndex = 46;
            this.lblFlagMessage.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.btnSearch.Location = new System.Drawing.Point(451, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 36);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // pbDriverPic
            // 
            this.pbDriverPic.Image = global::cbhproj.Properties.Resources._175x175;
            this.pbDriverPic.Location = new System.Drawing.Point(138, 479);
            this.pbDriverPic.Name = "pbDriverPic";
            this.pbDriverPic.Size = new System.Drawing.Size(150, 150);
            this.pbDriverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverPic.TabIndex = 44;
            this.pbDriverPic.TabStop = false;
            this.pbDriverPic.Visible = false;
            // 
            // btnVehicleInfo
            // 
            this.btnVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleInfo.Location = new System.Drawing.Point(775, 545);
            this.btnVehicleInfo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnVehicleInfo.Name = "btnVehicleInfo";
            this.btnVehicleInfo.Size = new System.Drawing.Size(211, 51);
            this.btnVehicleInfo.TabIndex = 48;
            this.btnVehicleInfo.Text = "Show Vehicles";
            this.btnVehicleInfo.UseVisualStyleBackColor = true;
            this.btnVehicleInfo.Visible = false;
            this.btnVehicleInfo.Click += new System.EventHandler(this.btnVehicleInfo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.btnDelete.Location = new System.Drawing.Point(451, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 36);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNumVehicles
            // 
            this.lblNumVehicles.AutoSize = true;
            this.lblNumVehicles.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNumVehicles.Location = new System.Drawing.Point(802, 512);
            this.lblNumVehicles.Name = "lblNumVehicles";
            this.lblNumVehicles.Size = new System.Drawing.Size(160, 18);
            this.lblNumVehicles.TabIndex = 50;
            this.lblNumVehicles.Text = "Number of Vehicles: #";
            // 
            // SSN_OLNMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.lblNumVehicles);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnVehicleInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblFlagMessage);
            this.Controls.Add(this.pbDriverPic);
            this.Controls.Add(this.lblUserPrompt);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblStateLicense);
            this.Controls.Add(this.lblEndorsement);
            this.Controls.Add(this.lblRestriction);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.lblOrganDonor);
            this.Controls.Add(this.lblHairColor);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblOLN);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblSSNHeading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SSN_OLNMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSNMenu";
            this.Load += new System.EventHandler(this.SSNMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblSSNHeading;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblOLN;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblHairColor;
        private System.Windows.Forms.Label lblOrganDonor;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblRestriction;
        private System.Windows.Forms.Label lblEndorsement;
        private System.Windows.Forms.Label lblStateLicense;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.Label lblUserPrompt;
        private System.Windows.Forms.PictureBox pbDriverPic;
        private System.Windows.Forms.Label lblFlagMessage;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnVehicleInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNumVehicles;
    }
}