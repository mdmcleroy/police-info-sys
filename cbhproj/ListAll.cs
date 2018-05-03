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
    public partial class ListAll : Form
    {
        List<vwDriver> drivers = new List<vwDriver>();
        List<vwVehicle> vehicles = new List<vwVehicle>();

        public ListAll()
        {
            InitializeComponent();
            LoadData();
            FormatData();
        }

        private void LoadData()
        {
            using (var db = new mdmcleroyEntities())
            {
                drivers = (from d in db.vwDrivers
                           where d.Active == true
                             && d.Deleted == false
                           orderby d.SSN
                           select d).ToList();
            }
        }

        private void FormatData()
        {
            foreach (var item in drivers)
            {
                // Driver
                txtListAll.AppendText(String.Format("{0}-{1}-{2} {3} {4} {5} {6} {7}",
                    item.SSN.Substring(0, 3), item.SSN.Substring(3, 2), item.SSN.Substring(5, 4),
                    item.LastName.Trim().PadRight(20), item.FirstName.Trim().PadRight(12), 
                    item.MI.Trim().PadRight(2), item.Address1.Trim().PadRight(30), item.Address2));
                txtListAll.AppendText(Environment.NewLine);

                var organDonor = item.OrganDonor ? "DONOR" : String.Empty;
                var driverState = String.Format("({0:00}) {1} {2}", item.StateCode, item.DriverStateAbbr, item.DriverStateName);
                var postalCode = String.Format("{0}-{1}", item.PostalCode.Substring(0, 5), item.PostalCode.Substring(5, 4));
                var driverCounty = String.Format("({0:00}) {1}", item.CountyCode, item.CountyName);
                txtListAll.AppendText(String.Format("    {0} {1} {2} {3} {4}",
                    organDonor.PadRight(7), item.City.PadRight(20), driverState.PadRight(28),
                    postalCode.PadRight(17), driverCounty));
                txtListAll.AppendText(Environment.NewLine);

                var driverHeight = String.Format("{0}' {1}\"", item.Height.Substring(1, 1), item.Height.Substring(2, 2));
                var eyeColor = (item.EyeColorCode > 33) ? "Invalid Eye Color" : String.Format("({0:00}) {1} {2}", item.EyeColorCode, item.EyeColorAbbr, item.EyeColorName);
                var hairColor = (item.HairColorCode > 33) ? "Invalid Hair Color" : String.Format("({0:00}) {1} {2}", item.HairColorCode, item.HairColorAbbr, item.HairColorName);
                txtListAll.AppendText(String.Format("\t    {0} {1} {2} {3} {4}", 
                    driverHeight.PadRight(10), item.Weight.PadRight(9),
                    item.Gender.PadRight(23), eyeColor.PadRight(22), hairColor));
                txtListAll.AppendText(Environment.NewLine);

                // License
                var licenseStatus = (String.IsNullOrWhiteSpace(item.StatusCode)) ? "N/A" : String.Format("(0{0}) {1}", item.StatusCode, item.StatusName);
                var licenseClass = (String.IsNullOrEmpty(item.LicenseClass)) ? "N/A" : item.LicenseClass;
                var licenseRestriction = (String.IsNullOrEmpty(item.LicenseRestrictions)) ? "N/A" : item.LicenseRestrictions;
                var licenseEndorsement = (String.IsNullOrEmpty(item.LicenseEndorsements)) ? "N/A" : item.LicenseEndorsements;
                var licenseIssue = (String.IsNullOrEmpty(item.LicenseIssue.ToString())) ? "N/A" : ((DateTime)item.LicenseIssue).ToShortDateString();
                var licenseExpiration = (String.IsNullOrEmpty(item.LicenseExpiration.ToString())) ? "N/A" : ((DateTime)item.LicenseExpiration).ToShortDateString();
                txtListAll.AppendText(String.Format("  {0} {1} {2} {3} {4} {5} {6}", 
                    item.OLN.PadRight(9), licenseStatus.PadRight(20), licenseClass.PadRight(9), 
                    licenseRestriction.PadRight(11), licenseEndorsement.PadRight(12), licenseIssue.PadRight(11), licenseExpiration));
                txtListAll.AppendText(Environment.NewLine);

                // Vehicles
                using (var db = new mdmcleroyEntities())
                {
                    vehicles = (from v in db.vwVehicles
                                where v.SSN == item.SSN
                                  && v.Active == true
                                  && v.Deleted == false
                                orderby v.SSN
                                select v).ToList();
                }
                foreach (var vehicle in vehicles)
                {
                    var vehicleType = String.Format("({0:00}) {1}", vehicle.VTypeCode, vehicle.VTypeName);
                    var vehicleMake = String.Format("({0:00}) {1}", vehicle.VMakeCode, vehicle.VMakeName);
                    var topColor = String.Format("({0:00}) {1} {2}", vehicle.TCCode, vehicle.TopColorAbbr, vehicle.TopColorName);
                    var bottomColor = String.Format("({0:00}) {1} {2}", vehicle.BCCode, vehicle.BottomColorAbbr, vehicle.BottomColorName);
                    var tagExpiration = DateTime.ParseExact(vehicle.TagExpiration, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("M/d/yyyy");
                    txtListAll.AppendText(String.Format("\t    {0} {1} {2} {3}",
                        vehicleMake.PadRight(20), vehicleType.PadRight(23), vehicle.Tag.PadRight(22), tagExpiration));
                    txtListAll.AppendText(Environment.NewLine);
                    txtListAll.AppendText(String.Format("\t    {0} {1}", topColor.PadRight(44), bottomColor));
                }

                txtListAll.AppendText(Environment.NewLine);
                txtListAll.AppendText(Environment.NewLine);
                txtListAll.AppendText(Environment.NewLine);
                txtListAll.AppendText(Environment.NewLine);
            }
        }

        private void ListAll_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
            ActiveControl = txtListAll;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
