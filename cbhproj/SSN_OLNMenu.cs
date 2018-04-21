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
        // fix 
        public bool flag = false;
        public string StateData;
        public string EyeColorData;
        public string HairColorData;
        bool searchByOLN;
        string userInput;

        // FIX ME: what do i do with the view data
        List<vwDriver> drivers = new List<vwDriver>();
        vwDriver driver = new vwDriver();
        //List<vwLicense> viewLicenses = new List<vwLicense>();
        //vwLicense viewLicense = new vwLicense();
        // List<Driver> drivers = new List<Driver>();
        // Driver driver = new Driver();

        private void SSNLookup()
        {
            using (var db = new mdmcleroyEntities())
            {
                drivers = (from d in db.vwDrivers
                           where d.SSN == userInput && d.Active == true
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
                           where d.OLN == userInput && d.Active == true
                           select d).ToList();

                if (!drivers.Any())
                {
                    return;
                }
                driver = drivers.First();
            }
        }

        private void FormatData()
        {
            string fixMe = "FIX ME";
            lblLicenseInfo.Visible = true;
            lblSSN.Text = String.Format("SSN: {0}-{1}-{2}", driver.SSN.Substring(0, 3), driver.SSN.Substring(3, 2), driver.SSN.Substring(5, 4));
            lblName.Text = String.Format("{0}, {1} {2}", driver.LastName.Trim(), driver.FirstName.Trim(), driver.MI.Trim());
            lblAddress1.Text = driver.Address1;
            lblAddress2.Text = driver.Address2;
            lblCity.Text = driver.City;
            lblState.Text = String.Format("({0:00})  {1}  {2}", driver.StateCode, driver.StateAbbr, driver.StateName);
            lblOLN.Text = String.Format("OLN: {0}", driver.OLN);
            lblZip.Text = String.Format("{0}-{1}", driver.PostalCode.Substring(0, 5), driver.PostalCode.Substring(5, 4));
            lblHeight.Text = String.Format("Height: {0}' {1}\"", driver.Height.Substring(1, 1), driver.Height.Substring(2, 2));
            lblWeight.Text = String.Format("Weight: {0} lbs", driver.Weight.Substring(1, 3));
            lblGender.Text = String.Format("Gender: {0}", driver.Gender);
            lblEyeColor.Text = String.Format("Eye Color: {0} {1}", driver.EyeColorAbbr, driver.EyeColorName);
            lblHairColor.Text = String.Format("Hair Color: {0} {1}", driver.HairColorAbbr, driver.HairColorName);
            lblOrganDonor.Text = "Organ Donor: " + (driver.OrganDonor ? "Yes" : "No");
            lblStatus.Text = "Status: " + (String.IsNullOrEmpty(driver.LicenseStatus) ? String.Format("N/A") : String.Format("({0}) {1}", driver.LicenseStatus, fixMe));
            lblClass.Text = String.Format("Class: {0}", driver.LicenseClass);
            var tempDate = DateTime.ParseExact(driver.LicenseIssue, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            lblIssue.Text = "Issue: " + (String.IsNullOrEmpty(driver.LicenseIssue) ? "N/A" : tempDate);
            tempDate = DateTime.ParseExact(driver.LicenseExpiration, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            lblExpiration.Text = "Expiration: " + (String.IsNullOrEmpty(driver.LicenseIssue) ? "N/A" : tempDate);
            lblRestriction.Text = "Restriction: " + (String.IsNullOrEmpty(driver.LicenseRestrictions) ? "N/A" : driver.LicenseRestrictions);
            lblEndorsement.Text = "Endorsement: " + (String.IsNullOrEmpty(driver.LicenseEndorsements) ? "N/A" : driver.LicenseEndorsements);
            lblStateLicense.Text = String.Format("({0:00})  {1}  {2}", driver.StateCode, driver.StateAbbr, driver.StateName);
            lblCounty.Text = String.Format("({0:00}) {1}", driver.LicenseCounty, fixMe);
        }

        public SSN_OLNMenu()
        {
            InitializeComponent();
            ClearFields();
            lblUserPrompt.Text = "Enter SSN:";
            lblSubHeading.Text = "Display a Record (by SSN)";
            lblSubHeading.Visible = true;
        }

        public SSN_OLNMenu(int a)
        {
            InitializeComponent();
            ClearFields();
            lblUserPrompt.Text = "Enter OLN:";
            lblSubHeading.Text = "Display a Record (by OLN)";
            lblSubHeading.Visible = true;
            searchByOLN = true;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearFields()
        {
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
            lblHairColor.Text = String.Empty;
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

            // Darren event
            lblFlagMessage.Text = String.Empty;
            picDarren.Visible = false;
            BackColor = DefaultBackColor;
        }

        private void txtUserSSN_TextChanged(object sender, EventArgs e)
        {
            //    if (txtUserSSN.Text.Length != 9)
            //    {
            //        ClearFields();
            //        return;
            //    }

            //    SSNLookup();
            //    if (drivers.Count == 0)
            //    {
            //        MessageBox.Show("Driver not found");
            //        if (!flag)
            //        {
            //            picDarren.Visible = true;
            //            BackColor = System.Drawing.Color.IndianRed;
            //            lblFlagMessage.Text = "*this event only triggers once per run of cbhproj";
            //            lblFlagMessage.Visible = true;
            //            flag = true;
            //        }
            //        return;
            //    }
            //    FormatData();
            ClearFields();
        }

        private void SSNMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            userInput = txtUserInput.Text.Trim();
            if (searchByOLN)
            {
                OLNLookup();
            }
            else
            {
                SSNLookup();
            }

            if (drivers.Count == 0)
            {
                MessageBox.Show("Driver not found");
                if (!flag)
                {
                    picDarren.Visible = true;
                    BackColor = System.Drawing.Color.IndianRed;
                    lblFlagMessage.Text = "*this event only triggers once per run of cbhproj";
                    lblFlagMessage.Visible = true;
                    flag = true;
                }
                return;
            }
            FormatData();
        }
    }
}
