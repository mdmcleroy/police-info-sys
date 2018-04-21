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
    public partial class DisplayRestrictions : Form
    {
        List<Restriction> RestrictionList = new List<Restriction>();
        string[] strRestrictions = new string[2];
        readonly int NumberInColumn = 10;

        private void LoadRestrictions()
        {
            using (var db = new mdmcleroyEntities())
            {
                RestrictionList = (from s in db.Restrictions
                             where s.Active == true
                             orderby s.RestrictionCode
                             select s).ToList();
                if (!RestrictionList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < RestrictionList.Count; ++i)
            {
                strRestrictions[column] += String.Format(" {0:00} {1}\n",
                    RestrictionList[i].RestrictionCode, RestrictionList[i].RestrictionDesc);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayRestrictions()
        {
            InitializeComponent();
            LoadRestrictions();
            FormatData();
            lblColumn1.Text = strRestrictions[0];
            lblColumn2.Text = strRestrictions[1];
        }

        private void RestrictionMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
