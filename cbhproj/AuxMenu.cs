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
            ColorMenu colorMenu = new ColorMenu();
            colorMenu.ShowDialog();
        }

        private void btnDisplayResrictions_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayStates_Click(object sender, EventArgs e)
        {
            StateMenu stateMenu = new StateMenu();
            stateMenu.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CountyMenu countyMenu = new CountyMenu();
            countyMenu.ShowDialog();
        }

        private void btnDisplayMakes_Click(object sender, EventArgs e)
        {
            VMakeMenu vMakeMenu = new VMakeMenu();
            vMakeMenu.ShowDialog();
        }

        private void AuxMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }

        private void btnDisplayTypes_Click(object sender, EventArgs e)
        {
            VTypeMenu vTypeMenu = new VTypeMenu();
            vTypeMenu.ShowDialog();
        }
    }
}
