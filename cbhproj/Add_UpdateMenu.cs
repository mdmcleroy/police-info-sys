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
    public partial class Add_UpdateMenu : Form
    {
        bool add = false;
        string userInput = String.Empty;

        List<vwDriver> drivers = new List<vwDriver>();
        vwDriver driver = new vwDriver();
        List<vwVehicle> vehicles = new List<vwVehicle>();

        List<Vehicle> vehiclesData = new List<Vehicle>();
        Driver driverData = new Driver();
        Models.License licenseData = new Models.License();

        // Constructor
        public Add_UpdateMenu()
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
                    cbStatus.Items.Add(String.Format("({0}) {1}", item.StatusCode, item.StatusName));
                }

                var classes = (from c in db.Classes
                                where c.Active == true
                                orderby c.ClassCode
                                select c).ToList();
                cbClass.Items.Add("N/A");
                foreach (var item in classes)
                {
                    cbClass.Items.Add(String.Format("({0}) {1}", item.ClassCode, item.ClassDesc));
                }

                var restrictions = (from r in db.Restrictions
                               where r.Active == true
                               orderby r.RestrictionCode
                               select r).ToList();
                cbRestriction.Items.Add("N/A");
                foreach (var item in restrictions)
                {
                    cbRestriction.Items.Add(String.Format("({0}) {1}", item.RestrictionCode, item.RestrictionDesc));
                }

                var endorsements = (from e in db.Endorsements
                                    where e.Active == true
                                    orderby e.EndorsementCode
                                    select e).ToList();
                cbEndorsement.Items.Add("N/A");
                foreach (var item in endorsements)
                {
                    cbEndorsement.Items.Add(String.Format("({0}) {1}", item.EndorsementCode, item.EndorsementDesc));
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
                cbHeightInches.Items.Add(String.Format("{0}\"", i));
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
            btnClose.Text = "Cancel";
            btnAddUpdate.Text = "Update";
            SetVisibility_True();
            lblNumVehicles.Visible = true;
            lblNumVehicles.Text = "Number of Vehicles: " + vehicles.Count();
            txtLastName.Text = driver.LastName;
            txtFirstName.Text = driver.FirstName;
            txtMiddleInitial.Text = driver.MI.Trim();
            txtAddress1.Text = driver.Address1;
            txtAddress2.Text = driver.Address2;
            txtCity.Text = driver.City;
            cbDriverState.Text = String.Format("({0:00}) {1} {2}", driver.DriverStateCode, driver.DriverStateAbbr, driver.DriverStateName);
            txtZip.Text = driver.PostalCode;
            cbHeightFeet.Text = String.Format("{0}'", driver.Height.Substring(1, 1));
            cbHeightInches.Text = String.Format("{0}\n", driver.Height.Substring(2, 2));
            txtWeight.Text = driver.Weight.Substring(1, 3);
            chkMale.Checked = (driver.Gender.Trim().ToUpper() == "M") ? true : false;
            chkFemale.Checked = (driver.Gender.Trim().ToUpper() == "F") ? true : false;
            chkOther.Checked = (driver.Gender.Trim().ToUpper() != "M" && driver.Gender.Trim().ToUpper() != "F") ? true : false;
            cbEyeColor.Text = String.Format("({0:00}) {1} {2}", driver.EyeColorCode, driver.EyeColorAbbr, driver.EyeColorName);
            cbHairColor.Text = String.Format("({0:00}) {1} {2}", driver.HairColorCode, driver.HairColorAbbr, driver.HairColorName);
            chkOrganDonor.Checked = driver.OrganDonor ? true : false;
            txtOLN.Text = driver.OLN;
            cbStatus.Text = String.IsNullOrEmpty(driver.StatusCode) ? "N/A" : String.Format("({0}) {1}", driver.StatusCode, driver.StatusName);
            cbClass.Text = driver.LicenseClass;
            //var tempDate = DateTime.ParseExact(driver.LicenseIssue, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            //dtIssue.Value = (DateTime)tempDate;
            //tempDate = DateTime.ParseExact(driver.LicenseExpiration, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            //lblExpiration.Text = "Expiration: " + (String.IsNullOrEmpty(driver.LicenseIssue) ? "N/A" : tempDate);
            cbRestriction.Text = String.IsNullOrEmpty(driver.LicenseRestrictions) ? "N/A" : driver.LicenseRestrictions;
            cbEndorsement.Text = String.IsNullOrEmpty(driver.LicenseEndorsements) ? "N/A" : driver.LicenseEndorsements;
            cbLicenseState.Text = String.Format("({0:00})  {1}  {2}", driver.LicensesStateCode, driver.LicensesStateAbbr, driver.LicensesStateName);
            cbCounty.Text = String.Format("({0:00}) {1}", driver.CountyCode, driver.CountyName);
        }

        private void Add_FormatData()
        {
            btnClose.Text = "Cancel";
            btnAddUpdate.Text = "Add";
            SetVisibility_True();
            btnVehicleInfo.Text = "Add Vehicle";
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
            cbClass.Text = "Select Class...";
            cbRestriction.Text = "Select Restriction...";
            cbEndorsement.Text = "Select Endorsement...";
            cbLicenseState.Text = "Select State...";
            cbCounty.Text = "Select County...";
            txtWeight.Text = "Weight (Ex. 225)";
            txtOLN.Text = "OLN";
            lblNumVehicles.Text = String.Empty;
        }

        private void ClearFields()
        {
            SetVisibility_False();
            lblNumVehicles.Text = String.Empty;
            cbHeightInches.Items.Clear();
            cbHeightFeet.Items.Clear();
            cbDriverState.Items.Clear();
            cbEyeColor.Items.Clear();
            cbHairColor.Items.Clear();
            cbStatus.Items.Clear();
            cbClass.Items.Clear();
            cbRestriction.Items.Clear();
            cbEndorsement.Items.Clear();
            cbLicenseState.Items.Clear();
            cbCounty.Items.Clear();
        }

        private void SetVisibility_False()
        {
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
            btnVehicleInfo.Visible = false;
            lblNumVehicles.Visible = false;
            chkMale.Visible = false;
            chkFemale.Visible = false;
            chkOther.Visible = false;
            cbStatus.Visible = false;
            cbClass.Visible = false;
            cbRestriction.Visible = false;
            cbEndorsement.Visible = false;
            cbLicenseState.Visible = false;
            cbCounty.Visible = false;
            dtIssue.Visible = false;
            dtExpiration.Visible = false;
            lblIssue.Visible = false;
            lblExpiration.Visible = false;
        }

        private void SetVisibility_True()
        {
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
            btnVehicleInfo.Visible = true;
            lblNumVehicles.Visible = true;
            chkMale.Visible = true;
            chkFemale.Visible = true;
            chkOther.Visible = true;
            cbStatus.Visible = true;
            cbClass.Visible = true;
            cbRestriction.Visible = true;
            cbEndorsement.Visible = true;
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

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            var addUpdateMsg = (add) ? String.Format("Are you sure you want to add {0} {1}?", driver.FirstName, driver.LastName) 
                                     : String.Format("Are you sure you want to update {0} {1}?", driver.FirstName, driver.LastName);
            dialog = MessageBox.Show(addUpdateMsg, "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                return;
            }

            UpdateAddDriverLicenseVehicle();

            SSNLookup();
            Modify_FormatData();
            btnClose.Text = "Close";
            addUpdateMsg = (add) ? String.Format("{0} {1} added.", driver.FirstName, driver.LastName) 
                                 : String.Format("{0} {1} updated.", driver.FirstName, driver.LastName);
           dialog = MessageBox.Show(addUpdateMsg, "Success!", MessageBoxButtons.OK);
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
                }
                else
                {
                    driverData.DriverID = Guid.NewGuid();
                    driverData.SSN = userInput;
                    driverData.CreateDate = DateTime.Now;
                    driverData.LastUpdate = DateTime.Now;
                }
                driverData.LastName = txtLastName.Text.Trim().ToUpper();
                driverData.FirstName = txtFirstName.Text.Trim().ToUpper();
                driverData.MI = txtMiddleInitial.Text.Trim().ToUpper();
                driverData.Address1 = txtAddress1.Text.Trim().ToUpper();
                driverData.Address2 = txtAddress2.Text.Trim().ToUpper();
                driverData.City = txtCity.Text.Trim().ToUpper();
                driverData.StateCode = Convert.ToInt32(cbDriverState.Text.ToString().Split('(', ')')[1]);
                //driverData.PostalCode = txtZip.Text.Trim().Split('-')[0] + txtZip.Text.Trim().Split('-')[1];
                driverData.Height = "0" + cbHeightFeet.Text.Trim().Split('\'')[0] + cbHeightInches.Text.Trim().Split('\"')[0];
                driverData.Weight = "0" + txtWeight.Text.Trim();
                driverData.Gender = chkMale.Checked ? "M" : (chkFemale.Checked ? "F" : "O");
                driverData.EyeColorCode = Convert.ToInt32(cbEyeColor.Text.ToString().Split('(', ')')[1]);
                driverData.HairColorCode = Convert.ToInt32(cbHairColor.Text.ToString().Split('(', ')')[1]);
                driverData.OrganDonor = chkOrganDonor.Checked;
                driverData.OLN = txtOLN.Text.Trim();
                //licenseData.LicenseStatus = cbStatus.Text.ToString().Split('(', ')')[1];
                //licenseData.LicenseEndorsements = cbStatus.Text.ToString().Split('(', ')')[1];
                //licenseData.LicenseStatus = cbStatus.Text.ToString().Split('(', ')')[1];
                //licenseData.LicenseStatus = cbStatus.Text.ToString().Split('(', ')')[1];
                //driverData.LastName = txtLastName.Text.Trim().ToUpper();
                //driverData.LastName = txtLastName.Text.Trim().ToUpper();
                //driverData.LastName = txtLastName.Text.Trim().ToUpper();

                if (add)
                {
                    db.Drivers.Add(driverData);
                }

                db.SaveChanges();
            }
        }

        private void btnVehicleInfo_Click(object sender, EventArgs e)
        {
            DisplayVehicles displayVehicles = new DisplayVehicles(vehicles);
            displayVehicles.ShowDialog();
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {
            ClearFields();
            if (txtUserInput.Text.Length > 9)
            {
                txtUserInput.Text = String.Empty;
            }
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
            if (txtAddress1.Text.Length == 0)
            {
                txtAddress1.Text = "Address 1";
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
            if (txtAddress2.Text.Length == 0)
            {
                txtAddress2.Text = "Address 2";
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
            }
        }

        private void cbState_Leave(object sender, EventArgs e)
        {
            if (cbDriverState.Text.Length == 0)
            {
                cbDriverState.Text = "Select State...";
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
            }
        }

        private void cbHeightFeet_Leave(object sender, EventArgs e)
        {
            if (cbHeightFeet.Text.Length == 0)
            {
                cbHeightFeet.Text = "0'";
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
            }
        }

        private void chkMale_MouseClick(object sender, MouseEventArgs e)
        {
            chkFemale.Checked = false;
            chkOther.Checked = false;
        }

        private void chkFemale_MouseClick(object sender, MouseEventArgs e)
        {
            chkMale.Checked = false;
            chkOther.Checked = false;
        }

        private void chkOther_MouseClick(object sender, MouseEventArgs e)
        {
            chkMale.Checked = false;
            chkFemale.Checked = false;
        }

        private void cbEyeColor_Leave(object sender, EventArgs e)
        {
            if (cbEyeColor.Text.Length == 0)
            {
                cbEyeColor.Text = "Select Eye Color...";
            }
        }

        private void cbHairColor_Leave(object sender, EventArgs e)
        {
            if (cbHairColor.Text.Length == 0)
            {
                cbHairColor.Text = "Select Hair Color...";
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
            }
        }

        private void cbClass_Leave(object sender, EventArgs e)
        {
            if (cbClass.Text.Length == 0)
            {
                cbClass.Text = "Select Class...";
            }
        }

        private void cbRestriction_Leave(object sender, EventArgs e)
        {
            if (cbRestriction.Text.Length == 0)
            {
                cbRestriction.Text = "Select Restriction...";
            }
        }

        private void cbEndorsement_Leave(object sender, EventArgs e)
        {
            if (cbEndorsement.Text.Length == 0)
            {
                cbEndorsement.Text = "Select Endorsement...";
            }
        }

        private void cbLicenseState_Leave(object sender, EventArgs e)
        {
            if (cbLicenseState.Text.Length == 0)
            {
                cbLicenseState.Text = "Select State...";
            }
        }

        private void cbCounty_Leave(object sender, EventArgs e)
        {
            if (cbCounty.Text.Length == 0)
            {
                cbCounty.Text = "Select County...";
            }
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            if (txtZip.Text.Length == 5)
            {
                txtZip.Text += "-";
                txtZip.SelectionStart = txtZip.Text.Length;
            }
        }
    }
}
