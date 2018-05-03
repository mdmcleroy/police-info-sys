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

                //vehicles = (from v in db.vwVehicles
                //            where v.SSN == SSN
                //              && v.Active == true
                //              && v.Deleted == false
                //            orderby v.SSN
                //            select v).ToList();
            }
        }

        private void FormatData()
        {
            foreach (var item in drivers)
            {
                txtListAll.AppendText(String.Format("{0}-{1}-{2} {3} {4} {5} {6} {7}",
                    item.SSN.Substring(0, 3), item.SSN.Substring(3, 2), item.SSN.Substring(5, 4),
                    item.LastName.PadRight(20), item.FirstName.PadRight(12), item.MI.PadRight(2), 
                    item.Address1.PadRight(30), item.Address2));
                txtListAll.AppendText(Environment.NewLine);

                var driverState = String.Format("({0:00}) {1} {2}", item.StateCode, item.DriverStateAbbr, item.DriverStateName);
                var postalCode = String.Format("{0}-{1}", item.PostalCode.Substring(0, 5), item.PostalCode.Substring(5, 4));
                var driverCounty = String.Format("({0:00}) {1}", item.CountyCode, item.CountyName);
                txtListAll.AppendText(String.Format("  {0} {1} {2} {3} {4}", 
                    item.OLN.PadRight(9), item.City.PadRight(20), driverState.PadRight(23), 
                    postalCode.PadRight(22), driverCounty));
                txtListAll.AppendText(Environment.NewLine);

                var organDonor = item.OrganDonor ? "DONOR" : String.Empty;
                var driverHeight = String.Format("{0}' {1}\"", item.Height.Substring(0, 1), item.Height.Substring(1, 2));
                txtListAll.AppendText(String.Format("    {0} {1} {2} {3}", organDonor.PadRight(7), driverHeight.PadRight(10), item.Weight.PadRight(9), item.Gender.PadRight(3)));
                txtListAll.AppendText(Environment.NewLine);

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
                    var tagExpiration = DateTime.ParseExact(vehicle.TagExpiration, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
                    txtListAll.AppendText(String.Format("\t    {0} {1} {2} {3}", 
                        vehicleMake.PadRight(20), vehicleType.PadRight(23), vehicle.Tag.PadRight(22), tagExpiration));
                    txtListAll.AppendText(Environment.NewLine);
                    txtListAll.AppendText(String.Format("\t    {0} {1}", topColor.PadRight(44), bottomColor));
                }

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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
