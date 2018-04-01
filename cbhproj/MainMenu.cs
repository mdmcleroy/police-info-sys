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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void btnSSNMenu_Click(object sender, EventArgs e)
        {
            SSNMenu ssnMenu = new SSNMenu();
            ssnMenu.ShowDialog();
        }

        private void btnOLNMenu_Click(object sender, EventArgs e)
        {
            OLNMenu olnMenu = new OLNMenu();
            olnMenu.ShowDialog();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddMenu addRecord = new AddMenu();
            addRecord.ShowDialog();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteMenu deleteRecord = new DeleteMenu();
            deleteRecord.ShowDialog();
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
    }
}
