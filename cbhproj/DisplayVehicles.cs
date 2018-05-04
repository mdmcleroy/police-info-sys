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
            lblTag.Text = "Tag: " + vehicle.Tag.Trim();
            var tempDate = DateTime.ParseExact(vehicle.TagExpiration, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            lblTagExpiration.Text = "Tag Expiration: " + tempDate;
            lblVehicleCount.Text = String.Format("Vehicle {0}/{1}", vehicleIndex + 1, vehicles.Count());
            pb18Wheel.Visible = (vehicle.VTypeName.Trim().ToUpper() == "18 WHEEL") ? true : false;
            pbHatchback.Visible = (vehicle.VTypeName.Trim().ToUpper() == "HATCHBACK") ? true : false;
            pbLimousine.Visible = (vehicle.VTypeName.Trim().ToUpper() == "LIMOUSINE") ? true : false;
            pbMotorcycle.Visible = (vehicle.VTypeName.Trim().ToUpper() == "MOTORCYCLE") ? true : false;
            pbSchoolBus.Visible = (vehicle.VTypeName.Trim().ToUpper() == "SCHOOL BUS") ? true : false;
            pbTruck.Visible = (vehicle.VTypeName.Trim().ToUpper() == "TRUCK, 2WD" || vehicle.VTypeName.Trim().ToUpper() == "TRUCK, 4WD") ? true : false;
            pbVan.Visible = (vehicle.VTypeName.Trim().ToUpper() == "VAN/BUS") ? true : false;
            pbConvertible.Visible = (vehicle.VTypeName.Trim().ToUpper() == "CONVERTIBLE") ? true : false;
            pbFuneralVehicle.Visible = (vehicle.VTypeName.Trim().ToUpper() == "FUNERAL VEHICLE") ? true : false;
            pbSedan.Visible = (vehicle.VTypeName.Trim().ToUpper() == "2 DOOR SEDAN" || vehicle.VTypeName.Trim().ToUpper() == "4 DOOR SEDAN") ? true : false;
            pbTrailer.Visible = (vehicle.VTypeName.Trim().ToUpper() == "TRAILER") ? true : false;
            pbStationWagon.Visible = (vehicle.VTypeName.Trim().ToUpper() == "STATION WAGON") ? true : false;
            pbMotorHome.Visible = (vehicle.VTypeName.Trim().ToUpper() == "MOTORHOME") ? true : false;
        }

        private void ClearFields()
        {
            pb18Wheel.Visible = false;
            pbHatchback.Visible = false;
            pbLimousine.Visible = false;
            pbMotorcycle.Visible = false;
            pbSchoolBus.Visible = false;
            pbTruck.Visible = false;
            pbVan.Visible = false;
            pbConvertible.Visible = false;
            pbFuneralVehicle.Visible = false;
            pbSedan.Visible = false;
            pbTrailer.Visible = false;
            pbStationWagon.Visible = false;
            pbMotorHome.Visible = false;
            btnPreviousVehicle.Visible = false;
            btnNextVehicle.Visible = false;
            lblVMake.Text = String.Empty;
            lblVType.Text = String.Empty;
            lblTopColor.Text = String.Empty;
            lblBottomColor.Text = String.Empty;
            lblTag.Text = String.Empty;
            lblTagExpiration.Text = String.Empty;
            lblVehicleCount.Text = String.Empty;
        }

        public DisplayVehicles(List<vwVehicle> vehiclesData)
        {
            InitializeComponent();
            ClearFields();
            vehicles = vehiclesData;
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

            if (vehicleIndex >= vehicles.Count)
            {
                return;
            }

            VehicleLookup(vehicleIndex);
            FormatData();
            btnPreviousVehicle.Visible = true;
            if (vehicleIndex >= vehicles.Count - 1)
            {
                btnNextVehicle.Visible = false;
            }
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

        private void DisplayVehicles_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
        }
    }
}
