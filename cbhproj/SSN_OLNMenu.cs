using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cbhproj.Models;

namespace cbhproj
{
    public partial class SSN_OLNMenu : Form
    {
        bool searchBySSN = false;
        bool searchByOLN = false;
        bool deleteBySSN = false;
        bool deleteByOLN = false;
        string userInput = String.Empty;
        string errorMessage = String.Empty;


        List<vwDriver> drivers = new List<vwDriver>();
        vwDriver driver = new vwDriver();
        List<vwVehicle> vehicles = new List<vwVehicle>();

        List<Vehicle> vehiclesData = new List<Vehicle>();
        Driver driverData = new Driver();
         Models.License licenseData = new Models.License();

        // Constructor
        public SSN_OLNMenu(int aOption)
        {
            InitializeComponent();
            ClearFields();

            switch (aOption)
            {
                case 1:
                    lblSubHeading.Text = "Display a Record (by SSN)";
                    lblUserPrompt.Text = "Enter SSN:";
                    searchBySSN = true;
                    break;
                case 2:
                    lblSubHeading.Text = "Display a Record (by OLN)";
                    lblUserPrompt.Text = "Enter OLN:";
                    searchByOLN = true;
                    break;
                case 3:
                    lblSubHeading.Text = "Delete a Record (by SSN)";
                    lblUserPrompt.Text = "Enter SSN:";
                    deleteBySSN = true;
                    break;
                case 4:
                    lblSubHeading.Text = "Delete a Record (by OLN)";
                    lblUserPrompt.Text = "Enter OLN:";
                    deleteByOLN = true;
                    break;
            }
        }

        // Methods
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

        private void OLNLookup()
        {
            using (var db = new mdmcleroyEntities())
            {
                drivers = (from d in db.vwDrivers
                           where d.OLN == userInput
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
                vehicles = (from d in db.vwVehicles
                            where d.SSN == userInput
                              && d.Active == true
                            select d).ToList();

                if (!vehicles.Any())
                {
                    return;
                }
            }
        }

        private void FormatData()
        {
            // shift info up if no Address 2
            if (String.IsNullOrEmpty(driver.Address2))
            {
                lblCity.Top = 330;
                lblState.Top = 364;
                lblSSN.Top = 398;
                lblZip.Top = 364;
            }

            btnVehicleInfo.Visible = true;
            lblSSN.Text = String.Format("SSN: {0}-{1}-{2}", driver.SSN.Substring(0, 3), driver.SSN.Substring(3, 2), driver.SSN.Substring(5, 4));
            lblName.Text = String.Format("{0}, {1} {2}", driver.LastName.Trim(), driver.FirstName.Trim(), driver.MI.Trim());
            lblAddress1.Text = driver.Address1;
            lblAddress2.Text = driver.Address2;
            lblCity.Text = driver.City;
            lblState.Text = String.Format("({0:00})  {1}  {2}", driver.StateCode, driver.DriverStateAbbr, driver.DriverStateName);
            lblOLN.Text = String.Format("OLN: {0}", driver.OLN);
            lblZip.Text = String.Format("{0}-{1}", driver.PostalCode.Substring(0, 5), driver.PostalCode.Substring(5, 4));
            var driverHeight = "Height: " + (driver.Height.Substring(0, 1) == "0" ? String.Format("{0}' {1}\"", driver.Height.Substring(1, 1), driver.Height.Substring(2, driver.Height.Length - 2))
                                                                                  : String.Format("{0}' {1}\"", driver.Height.Substring(0, 1), driver.Height.Substring(1, driver.Height.Length - 1)));
            lblHeight.Text = driverHeight;
            var driverWeight = "Weight: " + (driver.Weight.Substring(0, 1) == "0" ? driver.Weight.Substring(1, driver.Weight.Length - 1)
                                                                                  : driver.Weight.Substring(0, driver.Weight.Length));
            driverWeight += " lbs";
            lblWeight.Text = driverWeight;
            lblGender.Text = "Gender:";
            pbMaleIcon.Visible = (driver.Gender.Trim().ToUpper() == "M") ? true : false;
            pbFemaleIcon.Visible = (driver.Gender.Trim().ToUpper() == "F") ? true : false;
            pbOtherIcon.Visible = (driver.Gender.Trim().ToUpper() == "O") ? true : false;
            pbHeartIcon.Visible = driver.OrganDonor ? true : false;
            pbBrokenHeartIcon.Visible = !driver.OrganDonor ? true : false;
            lblEyeColor.Text = (driver.EyeColorCode > 33) ? "Invalid Eye Color" : String.Format("Eye Color: ({0:00}) {1} {2}", driver.EyeColorCode, driver.EyeColorAbbr, driver.EyeColorName.Split('/')[0]);
            lblEyeColorSplit.Text = String.IsNullOrWhiteSpace(driver.HairColorName) ? String.Empty : (GlobalFunctions.Contains(driver.HairColorName, '/') ? driver.EyeColorName.Split('/')[1] : String.Empty);
            lblHairColor.Text = (driver.HairColorCode > 33) ? "Invalid Hair Color" : String.Format("Hair Color: ({0:00}) {1} {2}", driver.HairColorCode, driver.HairColorAbbr, driver.HairColorName.Split('/')[0]);
            lblHairColorSplit.Text = String.IsNullOrWhiteSpace(driver.HairColorName) ? String.Empty : (GlobalFunctions.Contains(driver.HairColorName, '/') ? driver.HairColorName.Split('/')[1] : String.Empty);
            lblOrganDonor.Text = "Organ Donor:";
            lblStatus.Text = "Status: " + (String.IsNullOrEmpty(driver.StatusCode) ? "N/A" : String.Format("(0{0}) {1}", driver.StatusCode, driver.StatusName));
            lblLicenseInfo.Text = "License Info";
            lblLicenseInfo.Visible = true;
            pbMaleProfile.Visible = (driver.Gender.Trim().ToUpper() == "M" && driver.LastName.Trim().ToUpper() != "EVANS-YOUNG") ? true : false;
            pbFemaleProfile.Visible = (driver.Gender.Trim().ToUpper() == "F" && driver.LastName.Trim().ToUpper() != "EVANS-YOUNG") ? true : false;
            pbOtherProfile.Visible = (driver.Gender.Trim().ToUpper() == "O" && driver.LastName.Trim().ToUpper() != "EVANS-YOUNG") ? true : false;
            pbDarrenProfile.Visible = (driver.LastName.Trim().ToUpper() == "EVANS-YOUNG") ? true : false;
            lblClass.Text = "Class: " + (String.IsNullOrWhiteSpace(driver.LicenseClass) ? "N/A" : driver.LicenseClass);
            lblIssue.Text = "Issue: " + (String.IsNullOrWhiteSpace(driver.LicenseIssue.ToString()) ? "N/A" : ((DateTime)driver.LicenseIssue).ToShortDateString());
            lblExpiration.Text = "Expiration: " + (String.IsNullOrWhiteSpace(driver.LicenseExpiration.ToString()) ? "N/A" : ((DateTime)driver.LicenseExpiration).ToShortDateString());
            lblRestriction.Text = "Restriction: " + (String.IsNullOrWhiteSpace(driver.LicenseRestrictions) ? "N/A" : (String.IsNullOrEmpty(driver.LicenseRestrictions) ? "N/A" : driver.LicenseRestrictions));
            lblEndorsement.Text = "Endorsement: " + (String.IsNullOrWhiteSpace(driver.LicenseEndorsements) ? "N/A" : driver.LicenseEndorsements);
            lblStateLicense.Text = String.IsNullOrWhiteSpace(driver.LicenseState.ToString()) ? "State: N/A" : String.Format("({0:00})  {1}  {2}", driver.LicensesStateCode, driver.LicensesStateAbbr, driver.LicensesStateName);
            lblCounty.Text = String.IsNullOrWhiteSpace(driver.LicenseCounty.ToString()) ? "County: N/A" : String.Format("({0:00})  {1}", driver.LicenseCounty, driver.CountyName);
            lblNumVehicles.Text = (vehicles.Count() < 1) ? String.Empty : String.Format("Number of Vehicles: {0}", vehicles.Count());
            btnVehicleInfo.Visible = (vehicles.Count() < 1) ? false : true;
        }

        private void DeleteDriverLicenseVehicle()
        {
            using (var db = new mdmcleroyEntities())
            {
                driverData = (from d in db.Drivers
                              where d.SSN == driver.SSN
                                && d.Active == true
                                && d.Deleted == false
                              select d).First();
                driverData.Deleted = true;

                licenseData = (from l in db.Licenses
                               where l.LicenseCode == driver.OLN
                                 && l.Active == true
                                 && l.Deleted == false
                               select l).First();
                licenseData.Deleted = true;

                vehiclesData = (from v in db.Vehicles
                                where v.SSN == driver.SSN
                                  && v.Active == true
                                  && v.Deleted == false
                                select v).ToList();
                foreach (var item in vehicles)
                {
                    item.Deleted = true;
                }

                db.SaveChanges();
            }
        }

        private void ClearFields()
        {
            lblLength.Visible = false;
            pbDarrenProfile.Visible = false;
            pbMaleProfile.Visible = false;
            pbFemaleProfile.Visible = false;
            pbOtherProfile.Visible = false;
            pbMaleIcon.Visible = false;
            pbFemaleIcon.Visible = false;
            pbOtherIcon.Visible = false;
            pbHeartIcon.Visible = false;
            pbBrokenHeartIcon.Visible = false;
            btnVehicleInfo.Visible = false;
            btnDelete.Visible = false;
            lblSSN.Text = String.Empty;
            lblName.Text = String.Empty;
            lblAddress1.Text = String.Empty;
            lblAddress2.Text = String.Empty;
            lblCity.Text = String.Empty;
            lblState.Text = String.Empty;
            lblOLN.Text = String.Empty;
            lblZip.Text = String.Empty;
            lblHeight.Text = String.Empty;
            lblWeight.Text = String.Empty;
            lblGender.Text = String.Empty;
            lblEyeColor.Text = String.Empty;
            lblEyeColorSplit.Text = String.Empty;
            lblHairColor.Text = String.Empty;
            lblHairColorSplit.Text = String.Empty;
            lblOrganDonor.Text = String.Empty;
            lblLicenseInfo.Text = String.Empty;
            lblStatus.Text = String.Empty;
            lblClass.Text = String.Empty;
            lblIssue.Text = String.Empty;
            lblExpiration.Text = String.Empty;
            lblRestriction.Text = String.Empty;
            lblEndorsement.Text = String.Empty;
            lblStateLicense.Text = String.Empty;
            lblCounty.Text = String.Empty;
            lblNumVehicles.Text = String.Empty;
        }

        // Events
        private void SSNMenu_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
            ActiveControl = txtUserInput;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            userInput = txtUserInput.Text.Trim();

            // Validate user input
            if (!GlobalFunctions.IsDigitsOnly(userInput))
            {
                MessageBox.Show("Invalid input\nUsage: XXXXXXXXX", "Error", MessageBoxButtons.OK);
                return;
            }

            // Determine appropriate actions
            if (searchByOLN)
            {
                if (userInput.Length < 7 || userInput.Length > 9)
                {
                    return;
                }

                OLNLookup();
            }
            else if (searchBySSN)
            {
                if (userInput.Length < 9)
                {
                    return;
                }

                SSNLookup();
            }
            else if (deleteBySSN)
            {
                if (userInput.Length != 9)
                {
                    return;
                }

                btnDelete.Visible = true;
                SSNLookup();
            }
            else if (deleteByOLN)
            {
                if (userInput.Length < 7 || userInput.Length > 9)
                {
                    return;
                }

                btnDelete.Visible = true;
                OLNLookup();
            }

            if (drivers.Count == 0)
            {
                btnDelete.Visible = false;
                if (searchByOLN)
                {
                    errorMessage = String.Format("OLN {0} not found\nUsage: XXXXXXX or XXXXXXXXX", userInput);
                }
                else if (searchBySSN)
                {
                    errorMessage = String.Format("SSN {0} not found\nUsage: XXXXXXXXX", userInput);
                }
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK);
                return;
            }

            VehicleLookup();
            FormatData();
        }

        private void txtUserSSN_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (txtUserInput.Text.Length > 9)
            {
                txtUserInput.Text = String.Empty;
                return;
            }
            lblLength.Visible = true;
            lblLength.Text = "Length: " + Convert.ToString(txtUserInput.Text.Length);
        }

        private void lblClass_Click(object sender, EventArgs e)
        {
            DisplayClassesPopup classesPopup = new DisplayClassesPopup(driver.LicenseClass);
            classesPopup.ShowDialog();
        }

        private void lblRestriction_Click(object sender, EventArgs e)
        {
            DisplayRestrictionsPopup restrictionsPopup = new DisplayRestrictionsPopup(driver.LicenseRestrictions);
            restrictionsPopup.ShowDialog();
        }

        private void lblEndorsement_Click(object sender, EventArgs e)
        {
            DisplayEndorsementsPopup endorsementsPopup = new DisplayEndorsementsPopup(driver.LicenseEndorsements);
            endorsementsPopup.ShowDialog();
        }

        private void btnVehicleInfo_Click(object sender, EventArgs e)
        {
            DisplayVehicles displayVehicles = new DisplayVehicles(vehicles);
            displayVehicles.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            var deleteMsg = String.Format("Are you sure you want to delete {0} {1}?", driver.FirstName, driver.LastName);
            dialog = MessageBox.Show(deleteMsg, "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                return;
            }

            DeleteDriverLicenseVehicle();

            ClearFields();
            txtUserInput.Text = String.Empty;
            deleteMsg = String.Format("{0} {1} deleted.", driver.FirstName, driver.LastName);
            dialog = MessageBox.Show(deleteMsg, "Success!", MessageBoxButtons.OK);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
