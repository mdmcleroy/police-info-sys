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
    public partial class DisplayStatuses : Form
    {
        List<Status> StatusList = new List<Status>();
        string[] strStatuses = new string[1];
        readonly int NumberInColumn = 5;

        private void LoadStatuses()
        {
            using (var db = new mdmcleroyEntities())
            {
                StatusList = (from s in db.Statuses
                             where s.Active == true
                             orderby s.StatusCode
                             select s).ToList();
                if (!StatusList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < StatusList.Count; ++i)
            {
                strStatuses[column] += String.Format(" {0:00} {1}\n",
                    StatusList[i].StatusCode, StatusList[i].StatusName);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayStatuses()
        {
            InitializeComponent();
            LoadStatuses();
            FormatData();
            lblColumn1.Text = strStatuses[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayStatuses_Load(object sender, EventArgs e)
        {

        }
    }
}
