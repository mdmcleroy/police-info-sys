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
    public partial class DisplayVTypes : Form
    {
        string strTestData = String.Empty;
        List<VehicleType> VTypeList = new List<VehicleType>();
        string[] strVTypes = new string[2];
        readonly int NumberInColumn = 8;

        private void LoadVTypes()
        {
            using (var db = new mdmcleroyEntities())
            {
                VTypeList = (from s in db.VehicleTypes
                             where s.Active == true
                             orderby s.VTypeCode
                             select s).ToList();
                if (!VTypeList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < VTypeList.Count; ++i)
            {
                strVTypes[column] += String.Format(" {0:00} {1}\n",
                    VTypeList[i].VTypeCode, VTypeList[i].VTypeName);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayVTypes()
        {
            InitializeComponent();
            LoadVTypes();
            FormatData();
            lblColumn1.Text = strVTypes[0];
            lblColumn2.Text = strVTypes[1];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VTypeMenu_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
        }
    }
}
