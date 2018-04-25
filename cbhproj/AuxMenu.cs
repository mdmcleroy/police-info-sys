using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbhproj
{
    public partial class AuxMenu : Form
    {
        public AuxMenu()
        {
            InitializeComponent();
        }

        private void lblAuxMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnDisplayColors_Click(object sender, EventArgs e)
        {
            DisplayColors colorMenu = new DisplayColors();
            colorMenu.ShowDialog();
        }

        private void btnDisplayResrictions_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayStates_Click(object sender, EventArgs e)
        {
            DisplayStates stateMenu = new DisplayStates();
            stateMenu.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayCounties countyMenu = new DisplayCounties();
            countyMenu.ShowDialog();
        }

        private void btnDisplayMakes_Click(object sender, EventArgs e)
        {
            DisplayVMakes vMakeMenu = new DisplayVMakes();
            vMakeMenu.ShowDialog();
        }

        private void AuxMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }

        private void btnDisplayTypes_Click(object sender, EventArgs e)
        {
            DisplayVTypes vTypeMenu = new DisplayVTypes();
            vTypeMenu.ShowDialog();
        }

        private void btnDisplayEndorsements_Click(object sender, EventArgs e)
        {
            DisplayEndorsements endorsementMenu = new DisplayEndorsements();
            endorsementMenu.ShowDialog();
        }

        private void btnDisplayRestrictions_Click(object sender, EventArgs e)
        {
            DisplayRestrictions displayRestrictions = new DisplayRestrictions();
            displayRestrictions.ShowDialog();
        }

        private void btnDisplayClasses_Click(object sender, EventArgs e)
        {
            DisplayClasses displayClasses = new DisplayClasses();
            displayClasses.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayStatuses displayStatuses = new DisplayStatuses();
            displayStatuses.ShowDialog();
        }
    }
}
