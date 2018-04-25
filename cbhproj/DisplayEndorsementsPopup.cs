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
    public partial class DisplayEndorsementsPopup : Form
    {
        Dictionary<string, string> EndorsementsDict = new Dictionary<string, string>();
        public DisplayEndorsementsPopup(string aEndorsements)
        {
            InitializeComponent();
            LoadEndorsements();
            ClassLookup(aEndorsements);
        }

        private void LoadEndorsements()
        {
            using (var db = new mdmcleroyEntities())
            {
                var endorsements = (from c in db.Endorsements
                               where c.Active == true
                               orderby c.EndorsementCode
                               select c).ToList();

                foreach (var item in endorsements)
                {
                    EndorsementsDict.Add(item.EndorsementCode, item.EndorsementDesc);
                }
            }
        }

        private void ClassLookup(string aEndorsements)
        {
            string classList = String.Empty;
            string tempClass = String.Empty;
            string letter = String.Empty;

            for (int i = 0; i < aEndorsements.Length; ++i)
            {
                letter = aEndorsements.Substring(i, 1);
                if (EndorsementsDict.TryGetValue(letter, out tempClass))
                {
                    classList += String.Format("{0}: {1}\n", letter, tempClass);
                }
                lblEndorsements.Text = classList;
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
