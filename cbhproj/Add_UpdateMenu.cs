using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using cbhproj.Models;

namespace cbhproj
{
    public partial class cbhproj : Form
    {
        bool add = false;
        string userInput = String.Empty;

        List<vwDriver> drivers = new List<vwDriver>();
        vwDriver driver = new vwDriver();
        List<vwVehicle> vehicles = new List<vwVehicle>();

        List<Vehicle> vehiclesData = new List<Vehicle>();
        Driver driverData = new Driver();
        Models.License licenseData = new Models.License();

        Dictionary<string, string> ClassesDict = new Dictionary<string, string>();

        // Constructor
        public cbhproj()
        {
            InitializeComponent();
            ClearFields();
        }

        // Methods
        private void LoadDropdowns()
        {
            using (var db = new mdmcleroyEntities())
            {
                var states = (from s in db.States
                              where s.Active == true
                                && s.Deleted == false
                              orderby s.StateCode
                              select s).ToList();
                foreach (var item in states)
                {
                    cbDriverState.Items.Add(String.Format("({0:00}) {1} {2}", item.StateCode, item.StateAbbr, item.StateName));
                    cbLicenseState.Items.Add(String.Format("({0:00}) {1} {2}", item.StateCode, item.StateAbbr, item.StateName));
                }

                var colors = (from c in db.Colors
                              where c.Active == true
                                && c.Deleted == false
                              orderby c.ColorCode
                              select c).ToList();
                foreach (var item in colors)
                {
                   cbEyeColor.Items.Add(String.Format("({0:00}) {1} {2}", item.ColorCode, item.ColorAbbr, item.ColorName));
                   cbHairColor.Items.Add(String.Format("({0:00}) {1} {2}", item.ColorCode, item.ColorAbbr, item.ColorName));
                }

                var statuses = (from s in db.Statuses
                                where s.Active == true
                                orderby s.StatusCode
                                select s).ToList();
                cbStatus.Items.Add("N/A");
                foreach (var item in statuses)
                {
                    cbStatus.Items.Add(String.Format("(0{0}) {1}", item.StatusCode, item.StatusName));
                }

                var classes = (from c in db.Classes
                                where c.Active == true
                                orderby c.ClassCode
                                select c).ToList();
                lbClass.Items.Add("N/A");
                foreach (var item in classes)
                {
                    lbClass.Items.Add(String.Format("{0} {1}", item.ClassCode, item.ClassDesc));
                }

                var restrictions = (from r in db.Restrictions
                               where r.Active == true
                               orderby r.RestrictionCode
                               select r).ToList();
                lbRestriction.Items.Add("N/A");
                foreach (var item in restrictions)
                {
                    lbRestriction.Items.Add(String.Format("{0} {1}", item.RestrictionCode, item.RestrictionDesc));
                }

                var endorsements = (from e in db.Endorsements
                                    where e.Active == true
                                    orderby e.EndorsementCode
                                    select e).ToList();
                lbEndorsement.Items.Add("N/A");
                foreach (var item in endorsements)
                {
                    lbEndorsement.Items.Add(String.Format("{0} {1}", item.EndorsementCode, item.EndorsementDesc));
                }

                var counties = (from c in db.Counties
                                    where c.Active == true
                                      && c.Deleted == false
                                    orderby c.CountyCode
                                    select c).ToList();
                foreach (var item in counties)
                {
                    cbCounty.Items.Add(String.Format("({0:00}) {1}", item.CountyCode, item.CountyName));
                }
            }

            for (int i = 0; i < 12; ++i)
            {
                cbHeightInches.Items.Add(String.Format("{0:00}\"", i));
            }

            for (int i = 0; i < 9; ++i)
            {
                cbHeightFeet.Items.Add(String.Format("{0}'", i));
            }
        }

        private void SSNLookup()
        {
            using (var db = new mdmcleroyEntities())
            {
                drivers = (from d in db.vwDrivers
                           where d.SSN == userInput
                             && d.Active == true
                             && d.Deleted == false
                           select d).ToList();

                if (!drivers.Any())
                {
                    return;
                }
                driver = drivers.First();
            }
        }

        private void VehicleLookup()
        {
            using (var db = new mdmcleroyEntities())
            {
                vehicles = (from d in db.vwVehicles         // FIX ME: since there is only 1 vehicle per driver, displaying random amounts of vehicles
                            where d.TopColorActive == true  // where d.SSN == aSSN && d.Active == true
                            select d).ToList();

                if (!vehicles.Any())
                {
                    return;
                }
            }
        }

        private void Modify_FormatData()
        {
            lblSubHeading.Left = 407;
            lblSubHeading.Text = "Modify a Record";
            btnClearReset.Text = "Reset";
            btnClose.Text = "Cancel";
            btnAddUpdate.Text = "Update";
            SetVisibility_True();
            txtLastName.Text = driver.LastName;
            txtFirstName.Text = driver.FirstName;
            txtMiddleInitial.Text = String.IsNullOrWhiteSpace(driver.MI) ? String.Empty : driver.MI.Trim();
            txtAddress1.Text = driver.Address1;
            txtAddress2.Text = String.IsNullOrWhiteSpace(driver.Address2) ? String.Empty : driver.Address2;
            txtCity.Text = driver.City;
            cbDriverState.Text = String.Format("({0:00}) {1} {2}", driver.DriverStateCode, driver.DriverStateAbbr, driver.DriverStateName);
            txtZip.Text = driver.PostalCode.Substring(0, 5) + '-' + driver.PostalCode.Substring(5, 4);
            var driverHeight = driver.Height.Substring(0, 1) == "0" ? String.Format("{0}{1}\"", driver.Height.Substring(1, 1), driver.Height.Substring(2, driver.Height.Length - 2))
                                                                    : String.Format("{0}{1}", driver.Height.Substring(0, 1), driver.Height.Substring(1, driver.Height.Length - 1));
            cbHeightFeet.Text = String.Format("{0}'", driverHeight.Substring(0, 1));
            cbHeightInches.Text = String.Format("{0}\"", driverHeight.Substring(1, 2));
            var driverWeight = driver.Weight.Substring(0, 1) == "0" ? driver.Weight.Substring(1, driver.Weight.Length - 1)
                                                                    : driver.Weight.Substring(0, driver.Weight.Length);
            txtWeight.Text = driverWeight;
            chkMale.Checked = driver.Gender.Trim().ToUpper() == "M" ? true : false;
            chkFemale.Checked = driver.Gender.Trim().ToUpper() == "F" ? true : false;
            chkOther.Checked = driver.Gender.Trim().ToUpper() != "M" && driver.Gender.Trim().ToUpper() != "F" ? true : false;
            var eyeColor = (driver.EyeColorCode > 33) ? "Invalid Eye Color" : String.Format("({0:00}) {1} {2}", driver.EyeColorCode, driver.EyeColorAbbr, driver.EyeColorName);
            var hairColor = (driver.HairColorCode > 33) ? "Invalid Hair Color" : String.Format("({0:00}) {1} {2}", driver.HairColorCode, driver.HairColorAbbr, driver.HairColorName);
            cbEyeColor.Text = eyeColor;
            cbHairColor.Text = hairColor;
            chkOrganDonor.Checked = driver.OrganDonor ? true : false;
            pbHeartIcon.Visible = chkOrganDonor.Checked ? true : false;
            pbBrokenHeartIcon.Visible = !chkOrganDonor.Checked ? true : false;
            txtOLN.Text = driver.OLN;
            cbStatus.Text = String.IsNullOrEmpty(driver.StatusCode) ? "N/A" : String.Format("(0{0}) {1}", driver.StatusCode, driver.StatusName);
            if (String.IsNullOrEmpty(driver.LicenseClass))
            {
                lbClass.SetSelected(0, true);
            }
            else
            {
                foreach (var ch in driver.LicenseClass)
                {
                    for (int i = 1; i < lbClass.Items.Count; i++)
                    {
                        string defaultClass = lbClass.Items[i].ToString();
                        if (ch.ToString() == String.Format("{0}", defaultClass[0]))
                            lbClass.SetSelected(i, true);
                    }
                }
            }

            if (String.IsNullOrEmpty(driver.LicenseRestrictions))
            {
                lbRestriction.SetSelected(0, true);
            }
            else
            {
                foreach (var ch in driver.LicenseRestrictions)
                {
                    for (int i = 1; i < lbRestriction.Items.Count; i++)
                    {
                        string defaultClass = lbRestriction.Items[i].ToString();
                        if (ch.ToString() == String.Format("{0}", defaultClass[0]))
                            lbRestriction.SetSelected(i, true);
                    }
                }
            }

            if (String.IsNullOrEmpty(driver.LicenseEndorsements))
            {
                lbEndorsement.SetSelected(0, true);
            }
            else
            {
                foreach (var ch in driver.LicenseEndorsements)
                {
                    for (int i = 1; i < lbEndorsement.Items.Count; i++)
                    {
                        string defaultClass = lbEndorsement.Items[i].ToString();
                        if (ch.ToString() == String.Format("{0}", defaultClass[0]))
                            lbEndorsement.SetSelected(i, true);
                    }
                }
            }
            dtIssue.Value = (DateTime)driver.LicenseIssue;
            dtExpiration.Value = (DateTime)driver.LicenseExpiration;
            cbLicenseState.Text = String.Format("({0:00})  {1}  {2}", driver.LicensesStateCode, driver.LicensesStateAbbr, driver.LicensesStateName);
            cbCounty.Text = String.Format("({0:00}) {1}", driver.CountyCode, driver.CountyName);
        }

        private void Add_FormatData()
        {
            lblSubHeading.Left = 423;
            lblSubHeading.Text = "Add a Record";
            btnClearReset.Text = "Clear";
            btnClose.Text = "Cancel";
            btnAddUpdate.Text = "Add";
            SetVisibility_True();
            txtLastName.Text = "Last Name";
            txtFirstName.Text = "First Name";
            txtMiddleInitial.Text = "MI";
            txtAddress1.Text = "Address 1";
            txtAddress2.Text = "Address 2";
            txtCity.Text = "City";
            txtZip.Text = "Zip";
            cbDriverState.Text = "Select State...";
            cbHeightFeet.Text = "0'";
            cbHeightInches.Text = "0\"";
            cbEyeColor.Text = "Select Eye Color...";
            cbHairColor.Text = "Select Hair Color...";
            cbStatus.Text = "Select Status...";
            cbLicenseState.Text = "Select State...";
            cbCounty.Text = "Select County...";
            txtWeight.Text = "Weight (Ex. 225)";
            txtOLN.Text = "OLN";
            lbEndorsement.SetSelected(0, true);
            lbClass.SetSelected(0, true);
            lbRestriction.SetSelected(0, true);
            progBar.Visible = true;
        }

        private void ClearFields()
        {
            lblSubHeading.Left = 375;
            lblSubHeading.Text = "Add/Modify a Record";
            SetVisibility_False();
            progBar.Increment(-100);
            cbHeightInches.Items.Clear();
            cbHeightFeet.Items.Clear();
            cbDriverState.Items.Clear();
            cbEyeColor.Items.Clear();
            cbHairColor.Items.Clear();
            cbStatus.Items.Clear();
            cbLicenseState.Items.Clear();
            cbCounty.Items.Clear();
        }

        private void SetVisibility_False()
        {
            pbHeartIcon.Visible = false;
            pbBrokenHeartIcon.Visible = false;
            lbClass.Visible = false;
            lbEndorsement.Visible = false;
            lbRestriction.Visible = false;
            lblStatus.Visible = false;
            lblClass.Visible = false;
            lblRestriction.Visible = false;
            lblEndorsement.Visible = false;
            btnClearReset.Visible = false;
            btnAddUpdate.Visible = false;
            txtLastName.Visible = false;
            txtFirstName.Visible = false;
            txtMiddleInitial.Visible = false;
            txtAddress1.Visible = false;
            txtAddress2.Visible = false;
            txtCity.Visible = false;
            cbDriverState.Visible = false;
            txtZip.Visible = false;
            cbHeightFeet.Visible = false;
            cbHeightInches.Visible = false;
            txtWeight.Visible = false;
            cbEyeColor.Visible = false;
            cbHairColor.Visible = false;
            lblLicenseInfo.Visible = false;
            txtOLN.Visible = false;
            chkOrganDonor.Visible = false;
            chkMale.Visible = false;
            chkFemale.Visible = false;
            chkOther.Visible = false;
            cbStatus.Visible = false;
            cbLicenseState.Visible = false;
            cbCounty.Visible = false;
            dtIssue.Visible = false;
            dtExpiration.Visible = false;
            lblIssue.Visible = false;
            lblExpiration.Visible = false;
            progBar.Visible = false;
        }

        private void SetVisibility_True()
        {
            lbClass.Visible = true;
            lbEndorsement.Visible = true;
            lbRestriction.Visible = true;
            lblStatus.Visible = true;
            lblClass.Visible = true;
            lblRestriction.Visible = true;
            lblEndorsement.Visible = true;
            btnClearReset.Visible = true;
            btnAddUpdate.Visible = true;
            txtLastName.Visible = true;
            txtFirstName.Visible = true;
            txtMiddleInitial.Visible = true;
            txtAddress1.Visible = true;
            txtAddress2.Visible = true;
            txtCity.Visible = true;
            cbDriverState.Visible = true;
            txtZip.Visible = true;
            cbHeightFeet.Visible = true;
            cbHeightInches.Visible = true;
            txtWeight.Visible = true;
            cbEyeColor.Visible = true;
            cbHairColor.Visible = true;
            lblLicenseInfo.Visible = true;
            txtOLN.Visible = true;
            chkOrganDonor.Visible = true;
            chkMale.Visible = true;
            chkFemale.Visible = true;
            chkOther.Visible = true;
            cbStatus.Visible = true;
            cbLicenseState.Visible = true;
            cbCounty.Visible = true;
            dtIssue.Visible = true;
            dtExpiration.Visible = true;
            lblIssue.Visible = true;
            lblExpiration.Visible = true;
        }

        // Events
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            userInput = txtUserInput.Text.Trim();

            // Validate user input
            if (!GlobalFunctions.IsDigitsOnly(userInput))
            {
                MessageBox.Show("Invalid input.\nUsage: XXXXXXXXX", "Error", MessageBoxButtons.OK);
                return;
            }

            if (userInput.Length < 9 || userInput.Length > 11)
            {
                return;
            }

            SSNLookup();
            LoadDropdowns();

            add = false;
            if (drivers.Count == 0)
            {
                add = true;
            }

            if (add)
            {
                Add_FormatData();
            }
            else
            {
                VehicleLookup();
                Modify_FormatData();
            }
            SetVisibility_True();
        }

        private bool CheckErrors()
        {
            DialogResult dialog = new DialogResult();
            var errorMessage = String.Empty;

            if (String.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text == "Last Name" 
                || !Regex.IsMatch(txtLastName.Text, @"^[\p{L}]+$"))
            {
                errorMessage = "You must enter a valid Last Name.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text == "First Name"
                || !Regex.IsMatch(txtFirstName.Text, @"^[\p{L}]+$"))
            {
                errorMessage = "You must enter a valid First Name.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtMiddleInitial.Text) || txtMiddleInitial.Text == "MI"
                || !Regex.IsMatch(txtMiddleInitial.Text, @"^[\p{L}]+$"))
            {
                errorMessage = "You must enter a valid Middle Initial or remove \"MI\".";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }

            if (String.IsNullOrWhiteSpace(txtAddress1.Text) || txtAddress1.Text == "Address 1")
            {
                errorMessage = "You must enter a valid Address 1.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtCity.Text) || txtCity.Text == "City"
                || !Regex.IsMatch(txtCity.Text, @"^[\p{L}]+$"))
            {
                errorMessage = "You must enter a valid City.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (txtAddress2.Text == "Address 2")
            {
                errorMessage = "You must enter a valid Address 2 or remove \"Address 2\".";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (!cbDriverState.Items.Contains(cbDriverState.Text) ||
                String.IsNullOrWhiteSpace(cbDriverState.Text) || cbDriverState.Text == "Select State...")
            {
                errorMessage = "You must select a valid Driver State.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtZip.Text) || txtZip.Text == "Zip"
                || !GlobalFunctions.IsDigitsOnly(txtZip.Text, '-'))
            {
                errorMessage = "You must enter a valid Postal Code.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (!cbHeightFeet.Items.Contains(cbHeightFeet.Text) ||
                String.IsNullOrWhiteSpace(cbHeightFeet.Text) || cbHeightFeet.Text == "0'")
            {
                errorMessage = "You must select a valid Height (feet).";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (!cbHeightInches.Items.Contains(cbHeightInches.Text) ||
                String.IsNullOrWhiteSpace(cbHeightInches.Text) || cbHeightInches.Text == "0\"")
            {
                errorMessage = "You must select a valid Height (inches).";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtWeight.Text) || txtWeight.Text == "Weight (Ex. 225)"
                || !GlobalFunctions.IsDigitsOnly(txtWeight.Text))
            {
                errorMessage = "You must enter a valid Weight (lbs).";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (!cbEyeColor.Items.Contains(cbEyeColor.Text) ||
                String.IsNullOrWhiteSpace(cbEyeColor.Text) || cbEyeColor.Text == "Select Eye Color...")
            {
                errorMessage = "You must select a valid Eye Color.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (!cbHairColor.Items.Contains(cbHairColor.Text) ||
                String.IsNullOrWhiteSpace(cbHairColor.Text) || cbHairColor.Text == "Select Hair Color...")
            {
                errorMessage = "You must select a valid Hair Color.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            if (chkMale.Checked == false && chkFemale.Checked == false && chkOther.Checked == false)
            {
                errorMessage = "You must select a Gender.";
                dialog = MessageBox.Show(errorMessage, "Error!", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (CheckErrors())
            {
                return;
            }
            else
            {
                DialogResult dialog = new DialogResult();
                var addUpdateMsg = (add) ? String.Format("Are you sure you want to add SSN {0}?", userInput)
                                         : String.Format("Are you sure you want to update SSN {0}?", userInput);
                dialog = MessageBox.Show(addUpdateMsg, "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.No)
                {
                    return;
                }

                UpdateAddDriverLicenseVehicle();

                addUpdateMsg = "Would you like to add a vehicle?";
                dialog = MessageBox.Show(addUpdateMsg, "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    Add_ModifyVehicle addVehicle = new Add_ModifyVehicle(userInput, add);
                    addVehicle.ShowDialog();
                }

                SSNLookup();
                Modify_FormatData();
                btnClose.Text = "Close";
                addUpdateMsg = (add) ? String.Format("SSN {0} added.", driver.SSN)
                                     : String.Format("SSN {0} updated.", driver.SSN);
                dialog = MessageBox.Show(addUpdateMsg, "Success!", MessageBoxButtons.OK);
            }
        }
        
        private void UpdateAddDriverLicenseVehicle()
        { 
            DateTime currentDateTime = DateTime.Now;
            using (var db = new mdmcleroyEntities())
            {
                if (!add)
                {
                    driverData = (from d in db.Drivers
                                  where d.SSN == userInput
                                  select d).First();
                    driverData.LastUpdate = currentDateTime;
                    licenseData.LastUpdate = currentDateTime;
                }
                else
                {
                    driverData.DriverID = Guid.NewGuid();
                    driverData.SSN = userInput;
                    driverData.CreateDate = currentDateTime;
                    driverData.LastUpdate = currentDateTime;
                    licenseData.LicenseID = Guid.NewGuid();
                    licenseData.CreateDate = currentDateTime;
                    licenseData.LastUpdate = currentDateTime;
                }
                driverData.OLN = txtOLN.Text.Trim();
                driverData.LastName = txtLastName.Text.Trim().ToUpper();
                driverData.FirstName = txtFirstName.Text.Trim().ToUpper();
                driverData.MI = String.IsNullOrWhiteSpace(txtMiddleInitial.Text) ? 
                                String.Empty : txtMiddleInitial.Text.Trim().ToUpper();
                driverData.Address1 = txtAddress1.Text.Trim().ToUpper();
                driverData.Address2 = String.IsNullOrWhiteSpace(txtAddress2.Text) ? 
                                      String.Empty : txtAddress2.Text.Trim().ToUpper();
                driverData.City = txtCity.Text.Trim().ToUpper();
                driverData.StateCode = Convert.ToInt32(cbDriverState.Text.ToString().Split('(', ')')[1]);
                driverData.PostalCode = (txtZip.Text.Contains("-")) ? txtZip.Text.Trim().Split('-')[0] + txtZip.Text.Trim().Split('-')[1]
                                                                    : txtZip.Text.Trim();
                driverData.Height = cbHeightFeet.Text.Trim().Split('\'')[0] + cbHeightInches.Text.Trim().Split('\"')[0];
                driverData.Weight = txtWeight.Text.Trim();
                driverData.Gender = chkMale.Checked ? "M" : (chkFemale.Checked ? "F" : "O");
                driverData.EyeColorCode = Convert.ToInt32(cbEyeColor.Text.ToString().Split('(', ')')[1]);
                driverData.HairColorCode = Convert.ToInt32(cbHairColor.Text.ToString().Split('(', ')')[1]);
                driverData.OrganDonor = chkOrganDonor.Checked;
                driverData.Active = true;
                driverData.Deleted = false;

                licenseData.LicenseCode = txtOLN.Text.Trim();
                licenseData.LicenseState = Convert.ToInt32(cbLicenseState.Text.ToString().Split('(', ')')[1]);
                licenseData.LicenseCounty = Convert.ToInt32(cbCounty.Text.ToString().Split('(', ')')[1]);
                licenseData.LicenseStatus = cbStatus.Text.ToString().Split('(', ')')[1];

                bool isSelected;
                licenseData.LicenseClass = String.Empty;
                if (!lbClass.GetSelected(0))
                {
                    for (int i = 0; i < lbClass.Items.Count; i++)
                    {
                        isSelected = lbClass.GetSelected(i);
                        if (isSelected)
                            licenseData.LicenseClass += lbClass.Items[i].ToString().Substring(0, 1);
                    }
                }

                licenseData.LicenseRestrictions = String.Empty;
                if (!lbRestriction.GetSelected(0))
                {
                    for (int i = 0; i < lbRestriction.Items.Count; i++)
                    {
                        isSelected = lbRestriction.GetSelected(i);
                        if (isSelected)
                            licenseData.LicenseRestrictions += lbRestriction.Items[i].ToString().Substring(0, 1);
                    }
                }

                licenseData.LicenseEndorsements = String.Empty;
                if (!lbEndorsement.GetSelected(0))
                {
                    for (int i = 0; i < lbEndorsement.Items.Count; i++)
                    {
                        isSelected = lbEndorsement.GetSelected(i);
                        if (isSelected)
                            licenseData.LicenseEndorsements += lbEndorsement.Items[i].ToString().Substring(0, 1);
                    }
                }

                licenseData.LicenseIssue = dtIssue.Value;
                licenseData.LicenseExpiration = dtExpiration.Value;
                licenseData.Active = true;
                licenseData.Deleted = false;

                if (add)
                {
                    db.Drivers.Add(driverData);
                    db.Licenses.Add(licenseData);
                }

                db.SaveChanges();
            }
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (txtUserInput.Text.Length > 9)
            {
                txtUserInput.Text = String.Empty;
            }
            lblLength.Visible = true;
            lblLength.Text = "Length: " + Convert.ToString(txtUserInput.Text.Length);
        }

        private void txtLastName_Click(object sender, MouseEventArgs e)
        {
            if (txtLastName.Text.Trim() == "Last Name")
            {
                txtLastName.Text = String.Empty;
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length == 0)
            {
                txtLastName.Text = "Last Name";
                //progBar.Increment(-4);
                return;
            }

            if (txtLastName.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtFirstName_Click(object sender, MouseEventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = String.Empty;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length == 0)
            {
                txtFirstName.Text = "First Name";
                return;
            }

            if (txtFirstName.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtMiddleInitial_Click(object sender, MouseEventArgs e)
        {
            if (txtMiddleInitial.Text == "MI")
            {
                txtMiddleInitial.Text = String.Empty;
            }
        }

        private void txtMiddleInitial_Leave(object sender, EventArgs e)
        {
            if (txtMiddleInitial.Text.Length == 0)
            {
                txtMiddleInitial.Text = "MI";
                return;
            }

            if (txtMiddleInitial.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtAddress1_Click(object sender, MouseEventArgs e)
        {
            if (txtAddress1.Text == "Address 1")
            {
                txtAddress1.Text = String.Empty;
            }
        }

        private void txtAddress1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddress1.Text))
            {
                txtAddress1.Text = "Address 1";
                return;
            }

            if (txtAddress1.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtAddress2_Click(object sender, MouseEventArgs e)
        {
            if (txtAddress2.Text == "Address 2")
            {
                txtAddress2.Text = String.Empty;
            }
        }

        private void txtAddress2_Leave(object sender, EventArgs e)
        {
            if (txtAddress2.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtCity_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCity.Text == "City")
            {
                txtCity.Text = String.Empty;
            }
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Length == 0)
            {
                txtCity.Text = "City";
                return;
            }

            if (txtCity.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void cbState_Leave(object sender, EventArgs e)
        {
            if (cbDriverState.Text.Length == 0)
            {
                cbDriverState.Text = "Select State...";
                return;
            }

            if (cbDriverState.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtZip_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtZip.Text == "Zip")
            {
                txtZip.Text = String.Empty;
            }
        }

        private void txtZip_Leave(object sender, EventArgs e)
        {
            if (txtZip.Text.Length == 0)
            {
                txtZip.Text = "Zip";
                return;
            }

            if (txtZip.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void cbHeightFeet_Leave(object sender, EventArgs e)
        {
            if (cbHeightFeet.Text.Length == 0)
            {
                cbHeightFeet.Text = "0'";
                return;
            }

            if (cbHeightFeet.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void cbHeightInches_Leave(object sender, EventArgs e)
        {
            if (cbHeightInches.Text.Length == 0)
            {
                cbHeightInches.Text = "0\"";
                return;
            }

            if (cbHeightInches.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtWeight.Text == "Weight (Ex. 225)")
            {
                txtWeight.Text = String.Empty;
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (txtWeight.Text.Length == 0)
            {
                txtWeight.Text = "Weight (Ex. 225)";
                return;
            }

            if (txtWeight.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void chkMale_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkMale.Checked || chkOther.Checked)
            {
                progBar.Increment(-4);
            }
            chkFemale.Checked = false;
            chkOther.Checked = false;
            progBar.Increment(4);
        }

        private void chkFemale_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkMale.Checked || chkOther.Checked)
            {
                progBar.Increment(-4);
            }
            chkMale.Checked = false;
            chkOther.Checked = false;
            progBar.Increment(4);
        }

        private void chkOther_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkMale.Checked || chkFemale.Checked)
            {
                progBar.Increment(-4);
            }
            chkMale.Checked = false;
            chkFemale.Checked = false;
            progBar.Increment(4);

        }

        private void cbEyeColor_Leave(object sender, EventArgs e)
        {
            if (cbEyeColor.Text.Length == 0)
            {
                cbEyeColor.Text = "Select Eye Color...";
                return;
            }

            if (cbEyeColor.Text.Length > 0 && cbEyeColor.Text != "Select Eye Color...")
            {
                progBar.Increment(4);
                return;
            }
        }

        private void cbHairColor_Leave(object sender, EventArgs e)
        {
            if (cbHairColor.Text.Length == 0)
            {
                cbHairColor.Text = "Select Hair Color...";
                return;
            }

            if (cbHairColor.Text.Length > 0 && cbHairColor.Text != "Select Hair Color...")
            {
                progBar.Increment(4);
                return;
            }
        }

        private void txtOLN_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtOLN.Text == "OLN")
            {
                txtOLN.Text = String.Empty;
            }
        }

        private void txtOLN_Leave(object sender, EventArgs e)
        {
            if (txtOLN.Text.Length == 0)
            {
                txtOLN.Text = "OLN";
            }
        }

        private void cbStatus_Leave(object sender, EventArgs e)
        {
            if (cbStatus.Text.Length == 0)
            {
                cbStatus.Text = "Select Status...";
                return;
            }

            if (cbStatus.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void cbLicenseState_Leave(object sender, EventArgs e)
        {
            if (cbLicenseState.Text.Length == 0)
            {
                cbLicenseState.Text = "Select State...";
                return;
            }

            if (cbLicenseState.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void cbCounty_Leave(object sender, EventArgs e)
        {
            if (cbCounty.Text.Length == 0)
            {
                cbCounty.Text = "Select County...";
                return;
            }

            if (cbCounty.Text.Length > 0)
            {
                progBar.Increment(4);
                return;
            }
        }

        private void btnClearReset_Click(object sender, EventArgs e)
        {
            progBar.Increment(-100);
            if (add)
            {
                Add_FormatData();
                chkOrganDonor.Checked = false;
                chkMale.Checked = false;
                chkFemale.Checked = false;
                chkOther.Checked = false;
            }
            else
            {
                Modify_FormatData();
            }
        }

        private void txtMiddleInitial_TextChanged(object sender, EventArgs e)
        {
            if (txtMiddleInitial.Text.Length >= 1 && txtMiddleInitial.Text != "MI")
            {
                txtMiddleInitial.Text = txtMiddleInitial.Text.Substring(0, 1);
                txtMiddleInitial.SelectionStart = txtMiddleInitial.Text.Length;
                return;
            }
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWeight.Text.Length >= 3 && txtWeight.Text != "Weight (Ex. 225)")
            {
                txtWeight.Text = txtWeight.Text.Substring(0, 3);
                txtWeight.SelectionStart = txtWeight.Text.Length;
                return;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length >= 20 && txtLastName.Text != "Last Name")
            {
                txtLastName.Text = txtLastName.Text.Substring(0, 20);
                txtLastName.SelectionStart = txtLastName.Text.Length;
                return;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length >= 12 && txtFirstName.Text != "First Name")
            {
                txtFirstName.Text = txtFirstName.Text.Substring(0, 12);
                txtFirstName.SelectionStart = txtFirstName.Text.Length;
                return;
            }
        }

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress1.Text.Length >= 30 && txtAddress1.Text != "Address 1")
            {
                txtAddress1.Text = txtAddress1.Text.Substring(0, 30);
                txtAddress1.SelectionStart = txtAddress1.Text.Length;
                return;
            }
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress2.Text.Length >= 30 && txtAddress2.Text != "Address 2")
            {
                txtAddress2.Text = txtAddress2.Text.Substring(0, 30);
                txtAddress2.SelectionStart = txtAddress2.Text.Length;
                return;
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length >= 20 && txtCity.Text != "City")
            {
                txtCity.Text = txtCity.Text.Substring(0, 20);
                txtCity.SelectionStart = txtCity.Text.Length;
                return;
            }
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            if (txtZip.Text.Length == 5)
            {
                txtZip.Text += "-";
                txtZip.SelectionStart = txtZip.Text.Length;
            }

            if (txtZip.Text.Length >= 10 && txtZip.Text != "Zip")
            {
                txtZip.Text = txtZip.Text.Substring(0, 10);
                txtZip.SelectionStart = txtZip.Text.Length;
                return;
            }
        }

        private void cbhproj_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
            ActiveControl = txtUserInput;
        }

        private void chkOrganDonor_CheckedChanged(object sender, EventArgs e)
        {
            pbHeartIcon.Visible = chkOrganDonor.Checked ? true : false;
            pbBrokenHeartIcon.Visible = chkOrganDonor.Checked ? false : true;
        }
    }
}