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
    public partial class DisplayStates : Form
    {
        string strTestData = String.Empty;
        List<State> StateList = new List<State>();
        string[] strStates = new string[3];
        readonly int NumberInColumn = 17;

        private void LoadStates()
        {
            using (var db = new mdmcleroyEntities())
            {
                StateList = (from s in db.States
                             where s.Active == true
                             orderby s.StateCode
                             select s).ToList();
                if (!StateList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < StateList.Count; ++i)
            {
                strStates[column] += String.Format(" {0:00} {1}\n",
                    StateList[i].StateCode, StateList[i].StateName);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayStates()
        {
            InitializeComponent();
            LoadStates();
            FormatData();
            lblColumn1.Text = strStates[0];
            lblColumn2.Text = strStates[1];
            lblColumn3.Text = strStates[2];
        }

        private void lblAuxMenu_Click(object sender, EventArgs e)
        {

        }

        private void lblAuxFiles_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StateMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }
    }
}
