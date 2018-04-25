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
    public partial class DisplayEndorsements : Form
    {
        string strTestData = String.Empty;
        List<Endorsement> EndorsementList = new List<Endorsement>();
        string[] strEndorsements = new string[1];
        readonly int NumberInColumn = 6;

        private void LoadEndorsements()
        {
            using (var db = new mdmcleroyEntities())
            {
                EndorsementList = (from s in db.Endorsements
                             where s.Active == true
                             orderby s.EndorsementCode
                             select s).ToList();
                if (!EndorsementList.Any())
                    return;
            }
        }

        private void FormatData()
        {
            int column = 0;
            int row = 0;
            for (int i = 0; i < EndorsementList.Count; ++i)
            {
                strEndorsements[column] += String.Format(" {0:00} {1}\n",
                    EndorsementList[i].EndorsementCode, EndorsementList[i].EndorsementDesc);
                ++row;
                if (row >= NumberInColumn)
                {
                    row = 0;
                    ++column;
                }
            }
        }

        public DisplayEndorsements()
        {
            InitializeComponent();
            LoadEndorsements();
            FormatData();
            lblColumn1.Text = strEndorsements[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndorsementMenu_Load(object sender, EventArgs e)
        {
            this.Width = 1041;
            this.Height = 820;
        }
    }
}
