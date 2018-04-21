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
    public partial class DisplayClasses : Form
    {
        List<Class> ClassList = new List<Class>();
        string[] strClasses = new string[1];
        readonly int NumberInColumn = 6;

        private void LoadClasses()
        {
            using (var db = new mdmcleroyEntities())
            {
                ClassList = (from s in db.Classes
                             where s.Active == true
                             orderby s.ClassCode
                             select s).ToList();
                if (!ClassList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < ClassList.Count; ++i)
            {
                strClasses[column] += String.Format(" {0:00} {1}\n",
                    ClassList[i].ClassCode, ClassList[i].ClassDesc);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayClasses()
        {
            InitializeComponent();
            LoadClasses();
            FormatData();
            lblColumn1.Text = strClasses[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
