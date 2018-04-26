﻿namespace cbhproj
{
    partial class Add_UpdateMenu
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
            this.cbDriverState = new System.Windows.Forms.ComboBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblUserPrompt = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.cbEyeColor = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cbHairColor = new System.Windows.Forms.ComboBox();
            this.cbHeightFeet = new System.Windows.Forms.ComboBox();
            this.cbHeightInches = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblLicenseInfo = new System.Windows.Forms.Label();
            this.txtOLN = new System.Windows.Forms.TextBox();
            this.btnVehicleInfo = new System.Windows.Forms.Button();
            this.lblNumVehicles = new System.Windows.Forms.Label();
            this.chkOrganDonor = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbRestriction = new System.Windows.Forms.ComboBox();
            this.cbEndorsement = new System.Windows.Forms.ComboBox();
            this.cbLicenseState = new System.Windows.Forms.ComboBox();
            this.cbCounty = new System.Windows.Forms.ComboBox();
            this.dtIssue = new System.Windows.Forms.DateTimePicker();
            this.lblIssue = new System.Windows.Forms.Label();
            this.dtExpiration = new System.Windows.Forms.DateTimePicker();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStateHeading
            // 
            this.lblStateHeading.AutoSize = true;
            this.lblStateHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStateHeading.Location = new System.Drawing.Point(375, 100);
            this.lblStateHeading.Name = "lblStateHeading";
            this.lblStateHeading.Size = new System.Drawing.Size(275, 31);
            this.lblStateHeading.TabIndex = 6;
            this.lblStateHeading.Text = "Add/Update a Record";
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
            // cbDriverState
            // 
            this.cbDriverState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDriverState.Font = new System.Drawing.Font("Arial", 12F);
            this.cbDriverState.FormattingEnabled = true;
            this.cbDriverState.Location = new System.Drawing.Point(87, 398);
            this.cbDriverState.Name = "cbDriverState";
            this.cbDriverState.Size = new System.Drawing.Size(224, 26);
            this.cbDriverState.TabIndex = 7;
            this.cbDriverState.Leave += new System.EventHandler(this.cbState_Leave);
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Arial", 12F);
            this.txtZip.Location = new System.Drawing.Point(317, 398);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(94, 26);
            this.txtZip.TabIndex = 8;
            this.txtZip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtZip_MouseClick);
            this.txtZip.Leave += new System.EventHandler(this.txtZip_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(381, 675);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 77);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress2.Location = new System.Drawing.Point(87, 330);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(324, 26);
            this.txtAddress2.TabIndex = 21;
            this.txtAddress2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddress2_Click);
            this.txtAddress2.Leave += new System.EventHandler(this.txtAddress2_Leave);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress1.Location = new System.Drawing.Point(87, 296);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(324, 26);
            this.txtAddress1.TabIndex = 22;
            this.txtAddress1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddress1_Click);
            this.txtAddress1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLastName.Location = new System.Drawing.Point(87, 262);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 26);
            this.txtLastName.TabIndex = 23;
            this.txtLastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLastName_Click);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(238, 262);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 26);
            this.txtFirstName.TabIndex = 24;
            this.txtFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFirstName_Click);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMiddleInitial.Location = new System.Drawing.Point(389, 262);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(22, 26);
            this.txtMiddleInitial.TabIndex = 25;
            this.txtMiddleInitial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMiddleInitial_Click);
            this.txtMiddleInitial.Leave += new System.EventHandler(this.txtMiddleInitial_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.btnSearch.Location = new System.Drawing.Point(451, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 36);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblUserPrompt
            // 
            this.lblUserPrompt.AutoSize = true;
            this.lblUserPrompt.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUserPrompt.Location = new System.Drawing.Point(467, 147);
            this.lblUserPrompt.Name = "lblUserPrompt";
            this.lblUserPrompt.Size = new System.Drawing.Size(90, 18);
            this.lblUserPrompt.TabIndex = 49;
            this.lblUserPrompt.Text = "Enter SSN: ";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Font = new System.Drawing.Font("Arial", 14F);
            this.txtUserInput.Location = new System.Drawing.Point(436, 175);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(152, 29);
            this.txtUserInput.TabIndex = 48;
            this.txtUserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserInput.TextChanged += new System.EventHandler(this.txtUserInput_TextChanged);
            // 
            // cbEyeColor
            // 
            this.cbEyeColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEyeColor.Font = new System.Drawing.Font("Arial", 12F);
            this.cbEyeColor.FormattingEnabled = true;
            this.cbEyeColor.Location = new System.Drawing.Point(732, 262);
            this.cbEyeColor.Name = "cbEyeColor";
            this.cbEyeColor.Size = new System.Drawing.Size(261, 26);
            this.cbEyeColor.TabIndex = 51;
            this.cbEyeColor.Text = "(09) COM Chrome/Stainless Steel";
            this.cbEyeColor.Leave += new System.EventHandler(this.cbEyeColor_Leave);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCity.Location = new System.Drawing.Point(87, 364);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(224, 26);
            this.txtCity.TabIndex = 52;
            this.txtCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCity_MouseClick);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // cbHairColor
            // 
            this.cbHairColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHairColor.Font = new System.Drawing.Font("Arial", 12F);
            this.cbHairColor.FormattingEnabled = true;
            this.cbHairColor.Location = new System.Drawing.Point(732, 296);
            this.cbHairColor.Name = "cbHairColor";
            this.cbHairColor.Size = new System.Drawing.Size(261, 26);
            this.cbHairColor.TabIndex = 53;
            this.cbHairColor.Text = "(09) COM Chrome/Stainless Steel";
            this.cbHairColor.Leave += new System.EventHandler(this.cbHairColor_Leave);
            // 
            // cbHeightFeet
            // 
            this.cbHeightFeet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHeightFeet.Font = new System.Drawing.Font("Arial", 12F);
            this.cbHeightFeet.FormattingEnabled = true;
            this.cbHeightFeet.Location = new System.Drawing.Point(600, 262);
            this.cbHeightFeet.Name = "cbHeightFeet";
            this.cbHeightFeet.Size = new System.Drawing.Size(37, 26);
            this.cbHeightFeet.TabIndex = 55;
            this.cbHeightFeet.Leave += new System.EventHandler(this.cbHeightFeet_Leave);
            // 
            // cbHeightInches
            // 
            this.cbHeightInches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHeightInches.Font = new System.Drawing.Font("Arial", 12F);
            this.cbHeightInches.FormattingEnabled = true;
            this.cbHeightInches.Location = new System.Drawing.Point(643, 262);
            this.cbHeightInches.Name = "cbHeightInches";
            this.cbHeightInches.Size = new System.Drawing.Size(48, 26);
            this.cbHeightInches.TabIndex = 56;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWeight.Location = new System.Drawing.Point(600, 296);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(126, 26);
            this.txtWeight.TabIndex = 57;
            this.txtWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWeight_MouseClick);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLicenseInfo.Location = new System.Drawing.Point(467, 449);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(91, 18);
            this.lblLicenseInfo.TabIndex = 59;
            this.lblLicenseInfo.Text = "License Info";
            // 
            // txtOLN
            // 
            this.txtOLN.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOLN.Location = new System.Drawing.Point(468, 482);
            this.txtOLN.Name = "txtOLN";
            this.txtOLN.Size = new System.Drawing.Size(88, 26);
            this.txtOLN.TabIndex = 60;
            this.txtOLN.Text = "444444444";
            this.txtOLN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOLN_MouseClick);
            this.txtOLN.Leave += new System.EventHandler(this.txtOLN_Leave);
            // 
            // btnVehicleInfo
            // 
            this.btnVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehicleInfo.Location = new System.Drawing.Point(782, 482);
            this.btnVehicleInfo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnVehicleInfo.Name = "btnVehicleInfo";
            this.btnVehicleInfo.Size = new System.Drawing.Size(211, 51);
            this.btnVehicleInfo.TabIndex = 61;
            this.btnVehicleInfo.Text = "Show Vehicles";
            this.btnVehicleInfo.UseVisualStyleBackColor = true;
            this.btnVehicleInfo.Visible = false;
            this.btnVehicleInfo.Click += new System.EventHandler(this.btnVehicleInfo_Click);
            // 
            // lblNumVehicles
            // 
            this.lblNumVehicles.AutoSize = true;
            this.lblNumVehicles.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNumVehicles.Location = new System.Drawing.Point(806, 449);
            this.lblNumVehicles.Name = "lblNumVehicles";
            this.lblNumVehicles.Size = new System.Drawing.Size(160, 18);
            this.lblNumVehicles.TabIndex = 62;
            this.lblNumVehicles.Text = "Number of Vehicles: #";
            // 
            // chkOrganDonor
            // 
            this.chkOrganDonor.AutoSize = true;
            this.chkOrganDonor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOrganDonor.Font = new System.Drawing.Font("Arial", 12F);
            this.chkOrganDonor.Location = new System.Drawing.Point(732, 332);
            this.chkOrganDonor.Name = "chkOrganDonor";
            this.chkOrganDonor.Size = new System.Drawing.Size(117, 22);
            this.chkOrganDonor.TabIndex = 63;
            this.chkOrganDonor.Text = "Organ Donor";
            this.chkOrganDonor.UseVisualStyleBackColor = true;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMale.Font = new System.Drawing.Font("Arial", 12F);
            this.chkMale.Location = new System.Drawing.Point(600, 332);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(61, 22);
            this.chkMale.TabIndex = 64;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkMale_MouseClick);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkFemale.Font = new System.Drawing.Font("Arial", 12F);
            this.chkFemale.Location = new System.Drawing.Point(600, 360);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(80, 22);
            this.chkFemale.TabIndex = 65;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkFemale_MouseClick);
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOther.Font = new System.Drawing.Font("Arial", 12F);
            this.chkOther.Location = new System.Drawing.Point(600, 388);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(65, 22);
            this.chkOther.TabIndex = 66;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkOther_MouseClick);
            // 
            // cbStatus
            // 
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(274, 513);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(185, 26);
            this.cbStatus.TabIndex = 67;
            this.cbStatus.Text = "Select Status...";
            this.cbStatus.Leave += new System.EventHandler(this.cbStatus_Leave);
            // 
            // cbClass
            // 
            this.cbClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbClass.Font = new System.Drawing.Font("Arial", 12F);
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(274, 545);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(185, 26);
            this.cbClass.TabIndex = 68;
            this.cbClass.Text = "Select Class...";
            this.cbClass.Leave += new System.EventHandler(this.cbClass_Leave);
            // 
            // cbRestriction
            // 
            this.cbRestriction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRestriction.Font = new System.Drawing.Font("Arial", 12F);
            this.cbRestriction.FormattingEnabled = true;
            this.cbRestriction.Location = new System.Drawing.Point(564, 513);
            this.cbRestriction.Name = "cbRestriction";
            this.cbRestriction.Size = new System.Drawing.Size(185, 26);
            this.cbRestriction.TabIndex = 69;
            this.cbRestriction.Text = "Select Restriction...";
            this.cbRestriction.Leave += new System.EventHandler(this.cbRestriction_Leave);
            // 
            // cbEndorsement
            // 
            this.cbEndorsement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEndorsement.Font = new System.Drawing.Font("Arial", 12F);
            this.cbEndorsement.FormattingEnabled = true;
            this.cbEndorsement.Location = new System.Drawing.Point(564, 545);
            this.cbEndorsement.Name = "cbEndorsement";
            this.cbEndorsement.Size = new System.Drawing.Size(185, 26);
            this.cbEndorsement.TabIndex = 70;
            this.cbEndorsement.Text = "Select Endorsement...";
            this.cbEndorsement.Leave += new System.EventHandler(this.cbEndorsement_Leave);
            // 
            // cbLicenseState
            // 
            this.cbLicenseState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLicenseState.Font = new System.Drawing.Font("Arial", 12F);
            this.cbLicenseState.FormattingEnabled = true;
            this.cbLicenseState.Location = new System.Drawing.Point(564, 577);
            this.cbLicenseState.Name = "cbLicenseState";
            this.cbLicenseState.Size = new System.Drawing.Size(224, 26);
            this.cbLicenseState.TabIndex = 71;
            this.cbLicenseState.Leave += new System.EventHandler(this.cbLicenseState_Leave);
            // 
            // cbCounty
            // 
            this.cbCounty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCounty.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCounty.FormattingEnabled = true;
            this.cbCounty.Location = new System.Drawing.Point(564, 609);
            this.cbCounty.Name = "cbCounty";
            this.cbCounty.Size = new System.Drawing.Size(224, 26);
            this.cbCounty.TabIndex = 72;
            this.cbCounty.Text = "(65) WASHINGTON";
            this.cbCounty.Leave += new System.EventHandler(this.cbCounty_Leave);
            // 
            // dtIssue
            // 
            this.dtIssue.Font = new System.Drawing.Font("Arial", 12F);
            this.dtIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIssue.Location = new System.Drawing.Point(357, 583);
            this.dtIssue.Name = "dtIssue";
            this.dtIssue.Size = new System.Drawing.Size(102, 26);
            this.dtIssue.TabIndex = 73;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIssue.Location = new System.Drawing.Point(305, 589);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(48, 18);
            this.lblIssue.TabIndex = 74;
            this.lblIssue.Text = "Issue:";
            // 
            // dtExpiration
            // 
            this.dtExpiration.Font = new System.Drawing.Font("Arial", 12F);
            this.dtExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpiration.Location = new System.Drawing.Point(357, 615);
            this.dtExpiration.Name = "dtExpiration";
            this.dtExpiration.Size = new System.Drawing.Size(102, 26);
            this.dtExpiration.TabIndex = 75;
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Arial", 12F);
            this.lblExpiration.Location = new System.Drawing.Point(271, 621);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(82, 18);
            this.lblExpiration.TabIndex = 76;
            this.lblExpiration.Text = "Expiration:";
            // 
            // Add_UpdateMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.dtExpiration);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.dtIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.cbCounty);
            this.Controls.Add(this.cbLicenseState);
            this.Controls.Add(this.cbEndorsement);
            this.Controls.Add(this.cbRestriction);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.chkOrganDonor);
            this.Controls.Add(this.lblNumVehicles);
            this.Controls.Add(this.btnVehicleInfo);
            this.Controls.Add(this.txtOLN);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.cbHeightInches);
            this.Controls.Add(this.cbHeightFeet);
            this.Controls.Add(this.cbHairColor);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.cbEyeColor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblUserPrompt);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.cbDriverState);
            this.Controls.Add(this.lblStateHeading);
            this.Controls.Add(this.lblStateMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_UpdateMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStateHeading;
        private System.Windows.Forms.Label lblStateMenu;
        private System.Windows.Forms.ComboBox cbDriverState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblUserPrompt;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.ComboBox cbEyeColor;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cbHairColor;
        private System.Windows.Forms.ComboBox cbHeightFeet;
        private System.Windows.Forms.ComboBox cbHeightInches;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblLicenseInfo;
        private System.Windows.Forms.TextBox txtOLN;
        private System.Windows.Forms.Button btnVehicleInfo;
        private System.Windows.Forms.Label lblNumVehicles;
        private System.Windows.Forms.CheckBox chkOrganDonor;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbRestriction;
        private System.Windows.Forms.ComboBox cbEndorsement;
        private System.Windows.Forms.ComboBox cbLicenseState;
        private System.Windows.Forms.ComboBox cbCounty;
        private System.Windows.Forms.DateTimePicker dtIssue;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.DateTimePicker dtExpiration;
        private System.Windows.Forms.Label lblExpiration;
    }
}