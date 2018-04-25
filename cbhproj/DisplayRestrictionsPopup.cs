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
    public partial class DisplayRestrictionsPopup : Form
    {
        Dictionary<string, string> RestrictionsDict = new Dictionary<string, string>();
        public DisplayRestrictionsPopup(string aRestrictions)
        {
            InitializeComponent();
            LoadRestrictions();
            RestrictionLookup(aRestrictions);
        }

        private void LoadRestrictions()
        {
            using (var db = new mdmcleroyEntities())
            {
                var restrictions = (from c in db.Restrictions
                               where c.Active == true
                               orderby c.RestrictionCode
                               select c).ToList();

                foreach (var item in restrictions)
                {
                    RestrictionsDict.Add(item.RestrictionCode, item.RestrictionDesc);
                }
            }
        }

        private void RestrictionLookup(string aRestrictions)
        {
            string restrictionList = String.Empty;
            string tempRestriction = String.Empty;
            string letter = String.Empty;

            for (int i = 0; i < aRestrictions.Length; ++i)
            {
                letter = aRestrictions.Substring(i, 1);
                if (RestrictionsDict.TryGetValue(letter, out tempRestriction))
                {
                    restrictionList += String.Format("{0}: {1}\n", letter, tempRestriction);
                }
                lblRestrictions.Text = restrictionList;
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
