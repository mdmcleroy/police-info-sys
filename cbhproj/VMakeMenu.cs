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
    public partial class VMakeMenu : Form
    {
        string strTestData = String.Empty;
        List<VehicleMake> VMakeList = new List<VehicleMake>();
        string[] strVMakes = new string[3];
        readonly int NumberInColumn = 28;

        private void LoadVMakes()
        {
            using (var db = new mdmcleroyEntities())
            {
                VMakeList = (from s in db.VehicleMakes
                              where s.Active == true
                              orderby s.VMakeCode
                              select s).ToList();
                if (!VMakeList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < VMakeList.Count; ++i)
            {
                strVMakes[column] += String.Format(" {0:00} {1}\n",
                    VMakeList[i].VMakeCode, VMakeList[i].VMakeName);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public VMakeMenu()
        {
            InitializeComponent();
            LoadVMakes();
            FormatData();
            lblColumn1.Text = strVMakes[0];
            lblColumn2.Text = strVMakes[1];
            lblColumn3.Text = strVMakes[2];
        }

        private void VMakeMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
