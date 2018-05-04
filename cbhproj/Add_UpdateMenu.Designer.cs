namespace cbhproj
{
    partial class cbhproj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cbhproj));
            this.lblSubHeading = new System.Windows.Forms.Label();
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
            this.chkOrganDonor = new System.Windows.Forms.CheckBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbLicenseState = new System.Windows.Forms.ComboBox();
            this.cbCounty = new System.Windows.Forms.ComboBox();
            this.dtIssue = new System.Windows.Forms.DateTimePicker();
            this.lblIssue = new System.Windows.Forms.Label();
            this.dtExpiration = new System.Windows.Forms.DateTimePicker();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnClearReset = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.ListBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lbRestriction = new System.Windows.Forms.ListBox();
            this.lbEndorsement = new System.Windows.Forms.ListBox();
            this.lblRestriction = new System.Windows.Forms.Label();
            this.lblEndorsement = new System.Windows.Forms.Label();
            this.pbBrokenHeartIcon = new System.Windows.Forms.PictureBox();
            this.pbHeartIcon = new System.Windows.Forms.PictureBox();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrokenHeartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSubHeading.Location = new System.Drawing.Point(379, 100);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(267, 31);
            this.lblSubHeading.TabIndex = 6;
            this.lblSubHeading.Text = "Add/Modify a Record";
            this.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.cbDriverState.TabIndex = 8;
            this.cbDriverState.Leave += new System.EventHandler(this.cbState_Leave);
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Arial", 12F);
            this.txtZip.Location = new System.Drawing.Point(317, 398);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(94, 26);
            this.txtZip.TabIndex = 9;
            this.txtZip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtZip_MouseClick);
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            this.txtZip.Leave += new System.EventHandler(this.txtZip_Leave);
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
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress2.Location = new System.Drawing.Point(87, 330);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(324, 26);
            this.txtAddress2.TabIndex = 6;
            this.txtAddress2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddress2_Click);
            this.txtAddress2.TextChanged += new System.EventHandler(this.txtAddress2_TextChanged);
            this.txtAddress2.Leave += new System.EventHandler(this.txtAddress2_Leave);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtAddress1.Location = new System.Drawing.Point(87, 296);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(324, 26);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAddress1_Click);
            this.txtAddress1.TextChanged += new System.EventHandler(this.txtAddress1_TextChanged);
            this.txtAddress1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLastName.Location = new System.Drawing.Point(87, 262);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 26);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLastName_Click);
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(238, 262);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 26);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFirstName_Click);
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtMiddleInitial
            // 
            this.txtMiddleInitial.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMiddleInitial.Location = new System.Drawing.Point(389, 262);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(22, 26);
            this.txtMiddleInitial.TabIndex = 4;
            this.txtMiddleInitial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMiddleInitial_Click);
            this.txtMiddleInitial.TextChanged += new System.EventHandler(this.txtMiddleInitial_TextChanged);
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
            this.txtUserInput.TabIndex = 1;
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
            this.cbEyeColor.TabIndex = 16;
            this.cbEyeColor.Text = "(09) COM Chrome/Stainless Steel";
            this.cbEyeColor.Leave += new System.EventHandler(this.cbEyeColor_Leave);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCity.Location = new System.Drawing.Point(87, 364);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(224, 26);
            this.txtCity.TabIndex = 7;
            this.txtCity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCity_MouseClick);
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
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
            this.cbHairColor.TabIndex = 17;
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
            this.cbHeightFeet.TabIndex = 10;
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
            this.cbHeightInches.TabIndex = 11;
            this.cbHeightInches.Leave += new System.EventHandler(this.cbHeightInches_Leave);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Arial", 12F);
            this.txtWeight.Location = new System.Drawing.Point(600, 296);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(126, 26);
            this.txtWeight.TabIndex = 12;
            this.txtWeight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWeight_MouseClick);
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblLicenseInfo.Location = new System.Drawing.Point(455, 429);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(115, 22);
            this.lblLicenseInfo.TabIndex = 59;
            this.lblLicenseInfo.Text = "License Info";
            // 
            // txtOLN
            // 
            this.txtOLN.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOLN.Location = new System.Drawing.Point(223, 480);
            this.txtOLN.Name = "txtOLN";
            this.txtOLN.Size = new System.Drawing.Size(88, 26);
            this.txtOLN.TabIndex = 19;
            this.txtOLN.Text = "444444444";
            this.txtOLN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtOLN_MouseClick);
            this.txtOLN.TextChanged += new System.EventHandler(this.txtOLN_TextChanged);
            this.txtOLN.Leave += new System.EventHandler(this.txtOLN_Leave);
            // 
            // chkOrganDonor
            // 
            this.chkOrganDonor.AutoSize = true;
            this.chkOrganDonor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOrganDonor.Font = new System.Drawing.Font("Arial", 12F);
            this.chkOrganDonor.Location = new System.Drawing.Point(732, 332);
            this.chkOrganDonor.Name = "chkOrganDonor";
            this.chkOrganDonor.Size = new System.Drawing.Size(117, 22);
            this.chkOrganDonor.TabIndex = 18;
            this.chkOrganDonor.Text = "Organ Donor";
            this.chkOrganDonor.UseVisualStyleBackColor = true;
            this.chkOrganDonor.CheckedChanged += new System.EventHandler(this.chkOrganDonor_CheckedChanged);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkMale.Font = new System.Drawing.Font("Arial", 12F);
            this.chkMale.Location = new System.Drawing.Point(600, 332);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(61, 22);
            this.chkMale.TabIndex = 13;
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
            this.chkFemale.TabIndex = 14;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkFemale_MouseClick);
            // 
            // cbStatus
            // 
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(185, 510);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(126, 26);
            this.cbStatus.TabIndex = 20;
            this.cbStatus.Text = "Select Status...";
            this.cbStatus.Leave += new System.EventHandler(this.cbStatus_Leave);
            // 
            // cbLicenseState
            // 
            this.cbLicenseState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLicenseState.Font = new System.Drawing.Font("Arial", 12F);
            this.cbLicenseState.FormattingEnabled = true;
            this.cbLicenseState.Location = new System.Drawing.Point(87, 542);
            this.cbLicenseState.Name = "cbLicenseState";
            this.cbLicenseState.Size = new System.Drawing.Size(224, 26);
            this.cbLicenseState.TabIndex = 26;
            this.cbLicenseState.Leave += new System.EventHandler(this.cbLicenseState_Leave);
            // 
            // cbCounty
            // 
            this.cbCounty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCounty.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCounty.FormattingEnabled = true;
            this.cbCounty.Location = new System.Drawing.Point(87, 574);
            this.cbCounty.Name = "cbCounty";
            this.cbCounty.Size = new System.Drawing.Size(224, 26);
            this.cbCounty.TabIndex = 27;
            this.cbCounty.Text = "(65) WASHINGTON";
            this.cbCounty.Leave += new System.EventHandler(this.cbCounty_Leave);
            // 
            // dtIssue
            // 
            this.dtIssue.Font = new System.Drawing.Font("Arial", 12F);
            this.dtIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIssue.Location = new System.Drawing.Point(209, 606);
            this.dtIssue.Name = "dtIssue";
            this.dtIssue.Size = new System.Drawing.Size(102, 26);
            this.dtIssue.TabIndex = 22;
            this.dtIssue.Leave += new System.EventHandler(this.dtIssue_Leave);
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Font = new System.Drawing.Font("Arial", 12F);
            this.lblIssue.Location = new System.Drawing.Point(157, 612);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(48, 18);
            this.lblIssue.TabIndex = 74;
            this.lblIssue.Text = "Issue:";
            // 
            // dtExpiration
            // 
            this.dtExpiration.Font = new System.Drawing.Font("Arial", 12F);
            this.dtExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpiration.Location = new System.Drawing.Point(209, 638);
            this.dtExpiration.Name = "dtExpiration";
            this.dtExpiration.Size = new System.Drawing.Size(102, 26);
            this.dtExpiration.TabIndex = 23;
            this.dtExpiration.Leave += new System.EventHandler(this.dtExpiration_Leave);
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Font = new System.Drawing.Font("Arial", 12F);
            this.lblExpiration.Location = new System.Drawing.Point(123, 644);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(82, 18);
            this.lblExpiration.TabIndex = 76;
            this.lblExpiration.Text = "Expiration:";
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOther.Font = new System.Drawing.Font("Arial", 12F);
            this.chkOther.Location = new System.Drawing.Point(600, 388);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(65, 22);
            this.chkOther.TabIndex = 15;
            this.chkOther.Text = "Other";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkOther_MouseClick);
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.btnAddUpdate.Location = new System.Drawing.Point(451, 253);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(122, 36);
            this.btnAddUpdate.TabIndex = 77;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = false;
            this.btnAddUpdate.Visible = false;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(451, 387);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(122, 23);
            this.progBar.TabIndex = 78;
            // 
            // btnClearReset
            // 
            this.btnClearReset.BackColor = System.Drawing.Color.Orange;
            this.btnClearReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.btnClearReset.Location = new System.Drawing.Point(451, 295);
            this.btnClearReset.Name = "btnClearReset";
            this.btnClearReset.Size = new System.Drawing.Size(122, 36);
            this.btnClearReset.TabIndex = 79;
            this.btnClearReset.Text = "Clear";
            this.btnClearReset.UseVisualStyleBackColor = false;
            this.btnClearReset.Click += new System.EventHandler(this.btnClearReset_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLength.Location = new System.Drawing.Point(346, 181);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(63, 18);
            this.lblLength.TabIndex = 80;
            this.lblLength.Text = "Length: ";
            // 
            // lbClass
            // 
            this.lbClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClass.Font = new System.Drawing.Font("Arial", 12F);
            this.lbClass.FormattingEnabled = true;
            this.lbClass.HorizontalScrollbar = true;
            this.lbClass.ItemHeight = 18;
            this.lbClass.Location = new System.Drawing.Point(698, 585);
            this.lbClass.Name = "lbClass";
            this.lbClass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbClass.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbClass.Size = new System.Drawing.Size(295, 76);
            this.lbClass.TabIndex = 81;
            this.lbClass.Leave += new System.EventHandler(this.lbClass_Leave);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Arial", 12F);
            this.lblClass.Location = new System.Drawing.Point(699, 564);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(52, 18);
            this.lblClass.TabIndex = 82;
            this.lblClass.Text = "Class:";
            // 
            // lbRestriction
            // 
            this.lbRestriction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRestriction.Font = new System.Drawing.Font("Arial", 12F);
            this.lbRestriction.FormattingEnabled = true;
            this.lbRestriction.HorizontalScrollbar = true;
            this.lbRestriction.ItemHeight = 18;
            this.lbRestriction.Location = new System.Drawing.Point(365, 480);
            this.lbRestriction.Name = "lbRestriction";
            this.lbRestriction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRestriction.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRestriction.Size = new System.Drawing.Size(295, 184);
            this.lbRestriction.TabIndex = 83;
            this.lbRestriction.Leave += new System.EventHandler(this.lbRestriction_Leave);
            // 
            // lbEndorsement
            // 
            this.lbEndorsement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEndorsement.Font = new System.Drawing.Font("Arial", 12F);
            this.lbEndorsement.FormattingEnabled = true;
            this.lbEndorsement.HorizontalScrollbar = true;
            this.lbEndorsement.ItemHeight = 18;
            this.lbEndorsement.Location = new System.Drawing.Point(698, 480);
            this.lbEndorsement.Name = "lbEndorsement";
            this.lbEndorsement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEndorsement.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbEndorsement.Size = new System.Drawing.Size(295, 76);
            this.lbEndorsement.TabIndex = 84;
            this.lbEndorsement.Leave += new System.EventHandler(this.lbEndorsement_Leave);
            // 
            // lblRestriction
            // 
            this.lblRestriction.AutoSize = true;
            this.lblRestriction.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRestriction.Location = new System.Drawing.Point(366, 459);
            this.lblRestriction.Name = "lblRestriction";
            this.lblRestriction.Size = new System.Drawing.Size(86, 18);
            this.lblRestriction.TabIndex = 85;
            this.lblRestriction.Text = "Restriction:";
            // 
            // lblEndorsement
            // 
            this.lblEndorsement.AutoSize = true;
            this.lblEndorsement.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndorsement.Location = new System.Drawing.Point(699, 459);
            this.lblEndorsement.Name = "lblEndorsement";
            this.lblEndorsement.Size = new System.Drawing.Size(105, 18);
            this.lblEndorsement.TabIndex = 86;
            this.lblEndorsement.Text = "Endorsement:";
            // 
            // pbBrokenHeartIcon
            // 
            this.pbBrokenHeartIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbBrokenHeartIcon.Image")));
            this.pbBrokenHeartIcon.Location = new System.Drawing.Point(846, 330);
            this.pbBrokenHeartIcon.Name = "pbBrokenHeartIcon";
            this.pbBrokenHeartIcon.Size = new System.Drawing.Size(24, 24);
            this.pbBrokenHeartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrokenHeartIcon.TabIndex = 88;
            this.pbBrokenHeartIcon.TabStop = false;
            this.pbBrokenHeartIcon.Visible = false;
            // 
            // pbHeartIcon
            // 
            this.pbHeartIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbHeartIcon.Image")));
            this.pbHeartIcon.Location = new System.Drawing.Point(846, 330);
            this.pbHeartIcon.Name = "pbHeartIcon";
            this.pbHeartIcon.Size = new System.Drawing.Size(24, 24);
            this.pbHeartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeartIcon.TabIndex = 89;
            this.pbHeartIcon.TabStop = false;
            this.pbHeartIcon.Visible = false;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F);
            this.btnAddVehicle.Location = new System.Drawing.Point(451, 337);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(122, 36);
            this.btnAddVehicle.TabIndex = 90;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = false;
            this.btnAddVehicle.Visible = false;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // cbhproj
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1025, 781);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.pbHeartIcon);
            this.Controls.Add(this.pbBrokenHeartIcon);
            this.Controls.Add(this.lblEndorsement);
            this.Controls.Add(this.lblRestriction);
            this.Controls.Add(this.lbEndorsement);
            this.Controls.Add(this.lbRestriction);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.btnClearReset);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.dtExpiration);
            this.Controls.Add(this.lblExpiration);
            this.Controls.Add(this.dtIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.cbCounty);
            this.Controls.Add(this.cbLicenseState);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.chkOther);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.chkOrganDonor);
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
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblStateMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cbhproj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord";
            this.Load += new System.EventHandler(this.cbhproj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBrokenHeartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeartIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubHeading;
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
        private System.Windows.Forms.CheckBox chkOrganDonor;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbLicenseState;
        private System.Windows.Forms.ComboBox cbCounty;
        private System.Windows.Forms.DateTimePicker dtIssue;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.DateTimePicker dtExpiration;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnClearReset;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ListBox lbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ListBox lbRestriction;
        private System.Windows.Forms.ListBox lbEndorsement;
        private System.Windows.Forms.Label lblRestriction;
        private System.Windows.Forms.Label lblEndorsement;
        private System.Windows.Forms.PictureBox pbBrokenHeartIcon;
        private System.Windows.Forms.PictureBox pbHeartIcon;
        private System.Windows.Forms.Button btnAddVehicle;
    }
}