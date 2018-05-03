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
            cbhproj addRecord = new cbhproj();
            addRecord.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
        }

        private void btnResetData_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            var message = "Are you sure you want to reset the database?";
            dialog = MessageBox.Show(message, "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                return;
            }

            ResetDatabase();

            message = "Database reset.";
            dialog = MessageBox.Show(message, "Success!", MessageBoxButtons.OK);
        }

        private void ResetDatabase()
        {
            using (var db = new mdmcleroyEntities())
            {
                db.cbhprojResetData();
                db.SaveChanges();
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            ListAll listAll = new ListAll();
            listAll.ShowDialog();
        }
    }
}
