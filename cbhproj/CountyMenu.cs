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
    public partial class CountyMenu : Form
    {
        string strTestData = String.Empty;
        List<County> CountyList = new List<County>();
        string[] strCounties = new string[3];
        readonly int NumberInColumn = 23;

        private void LoadCounties()
        {
            using (var db = new mdmcleroyEntities())
            {
                CountyList = (from s in db.Counties
                             where s.Active == true
                             orderby s.CountyCode
                             select s).ToList();
                if (!CountyList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < CountyList.Count; ++i)
            {
                strCounties[column] += String.Format(" {0:00} {1}\n",
                    CountyList[i].CountyCode, CountyList[i].CountyName);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public CountyMenu()
        {
            InitializeComponent();
            LoadCounties();
            FormatData();
            lblColumn1.Text = strCounties[0];
            lblColumn2.Text = strCounties[1];
            lblColumn3.Text = strCounties[2];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CountyMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }
    }
}
