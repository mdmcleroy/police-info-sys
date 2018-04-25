using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cbhproj.Models;

namespace cbhproj
{
    public partial class MainMenu : Form
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        List<Driver> drivers = new List<Driver>();
        List<Models.License> licenses = new List<Models.License>();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to exit?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAuxFIles_Click(object sender, EventArgs e)
        {
            AuxMenu auxMenu = new AuxMenu();
            auxMenu.ShowDialog();
        }

        private void btnSearchBySSN_Click(object sender, EventArgs e)
        {
            SSN_OLNMenu searchBySSN = new SSN_OLNMenu(1); // 1: Search by SSN
            searchBySSN.ShowDialog();
        }

        private void btnSearchByOLN_Click(object sender, EventArgs e)
        {
            SSN_OLNMenu searchByOLN = new SSN_OLNMenu(2);  // 2: Search by OLN
            searchByOLN.ShowDialog();
        }

        private void btnDeleteBySSN_Click(object sender, EventArgs e)
        {
            SSN_OLNMenu deleteBySSN = new SSN_OLNMenu(3);  // 3: Delete by SSN
            deleteBySSN.ShowDialog();
        }

        private void btnDeleteByOLN_Click(object sender, EventArgs e)
        {
            SSN_OLNMenu deleteByOLN = new SSN_OLNMenu(4);  // 4: Delete by OLN
            deleteByOLN.ShowDialog();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddMenu addRecord = new AddMenu();
            addRecord.ShowDialog();
        }

        private void btnModifyRecord_Click(object sender, EventArgs e)
        {
            ModifyMenu modifyRecord = new ModifyMenu();
            modifyRecord.ShowDialog();
        }

        private void btnListMaster_Click(object sender, EventArgs e)
        {
            MasterMenu listMaster = new MasterMenu();
            listMaster.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }

        private void btnInitialDataLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            var message = "Refreshing database...";
            dialog = MessageBox.Show(message, "Alert!", MessageBoxButtons.OK);

            RefreshDatabase();

            message = "Success! Database refreshed.";
            dialog = MessageBox.Show(message, "Alert!", MessageBoxButtons.OK);
        }

        private void RefreshDatabase()
        {
            using (var db = new mdmcleroyEntities())
            {
                drivers = (from d in db.Drivers
                           select d).ToList();
                foreach (var item in drivers)
                {
                    item.Active = true;
                    item.Deleted = false;
                }

                licenses = (from l in db.Licenses
                            select l).ToList();
                foreach (var item in licenses)
                {
                    item.Active = true;
                    item.Deleted = false;
                }

                vehicles = (from v in db.Vehicles
                            select v).ToList();
                foreach (var item in vehicles)
                {
                    item.Active = true;
                    item.Deleted = false;
                }

                db.SaveChanges();
            }
        }
    }
}
