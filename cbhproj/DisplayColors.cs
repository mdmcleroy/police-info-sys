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
    public partial class DisplayColors : Form
    {
        string strTestData = String.Empty;
        List<Models.Color> ColorList = new List<Models.Color>();
        string[] strColors = new string[3];
        readonly int NumberInColumn = 11;

        private void LoadColors()
        {
            using (var db = new mdmcleroyEntities())
            {
                ColorList = (from s in db.Colors
                             where s.Active == true
                             orderby s.ColorCode
                             select s).ToList();
                if (!ColorList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < ColorList.Count; ++i)
            {
                strColors[column] += String.Format(" {0:00} {1}\n",
                    ColorList[i].ColorCode, ColorList[i].ColorName);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayColors()
        {
            InitializeComponent();
            LoadColors();
            FormatData();
            lblColumn1.Text = strColors[0];
            lblColumn2.Text = strColors[1];
            lblColumn3.Text = strColors[2];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColorMenu_Load(object sender, EventArgs e)
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
