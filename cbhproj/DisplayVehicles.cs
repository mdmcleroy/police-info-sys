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
    public partial class DisplayVehicles : Form
    {
        int vehicleIndex = 0;
        List<vwVehicle> vehicles = new List<vwVehicle>();
        vwVehicle vehicle = new vwVehicle();

        private void LoadVehicles(string aSSN)
        {
            using (var db = new mdmcleroyEntities())
            {
                vehicles = (from d in db.vwVehicles         // FIX ME: since there is only 1 vehicle per driver, displaying random amounts of vehicles
                            where d.TopColorActive == true //where d.SSN == aSSN && d.Active == true
                            select d).ToList();

                if (!vehicles.Any())
                {
                    return;
                }
                vehicle = vehicles.First();
            }
        }

        private void VehicleLookup(int vehicleIndex)
        {
            vehicle = vehicles[vehicleIndex];
        }

        private void FormatData()
        {
            if (vehicles.Count > 1)
            {
                btnNextVehicle.Visible = true;
            }

            lblVMake.Text = String.Format("Vehicle Make: ({0:00}) {1}", vehicle.VMakeCode, vehicle.VMakeName);
            lblVType.Text = String.Format("Vehicle Type: ({0:00}) {1}", vehicle.VTypeCode, vehicle.VTypeName);
            lblTopColor.Text = String.Format("Top Color: ({0:00}) {1}", vehicle.TCCode, vehicle.TopColorName);
            lblBottomColor.Text = String.Format("Bottom Color: ({0:00}) {1}", vehicle.BCCode, vehicle.BottomColorName);
            lblTag.Text = "Tag: " + vehicle.Tag;
            var tempDate = DateTime.ParseExact(vehicle.TagExpiration, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            lblTagExpiration.Text = "Tag Expiration: " + tempDate;
        }

        private void ClearFields()
        {
            btnPreviousVehicle.Visible = false;
            btnNextVehicle.Visible = false;
            lblVMake.Text = String.Empty;
            lblVType.Text = String.Empty;
            lblTopColor.Text = String.Empty;
            lblBottomColor.Text = String.Empty;
            lblTag.Text = String.Empty;
            lblTagExpiration.Text = String.Empty;
        }

        public DisplayVehicles(string aSSN)
        {
            InitializeComponent();
            ClearFields();
            LoadVehicles(aSSN);
            VehicleLookup(vehicleIndex);
            FormatData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNextVehicle_Click(object sender, EventArgs e)
        {
            ++vehicleIndex;
            if (vehicleIndex >= vehicles.Count - 1)
            {
                btnNextVehicle.Visible = false;
            }

            if (vehicleIndex > vehicles.Count - 1)
            {
                return;
            }

            VehicleLookup(vehicleIndex);
            FormatData();
            btnPreviousVehicle.Visible = true;
        }

        private void btnPreviousVehicle_Click(object sender, EventArgs e)
        {
            --vehicleIndex;
            if (vehicleIndex < 1)
            {
                btnPreviousVehicle.Visible = false;
            }

            if (vehicleIndex < 0)
            {
                return;
            }

            VehicleLookup(vehicleIndex);
            FormatData();
        }
    }
}
