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
    public partial class DisplayClassesPopup : Form
    {
        Dictionary<string, string> ClassesDict = new Dictionary<string, string>();
        public DisplayClassesPopup(string aClasses)
        {
            InitializeComponent();
            LoadClasses();
            ClassLookup(aClasses);
        }

        private void LoadClasses()
        {
            using (var db = new mdmcleroyEntities())
            {
                var classes = (from c in db.Classes
                               where c.Active == true
                               orderby c.ClassCode
                               select c).ToList();

                foreach (var item in classes)
                {
                    ClassesDict.Add(item.ClassCode, item.ClassDesc);
                }
            }
        }

        private void ClassLookup(string aClasses)
        {
            string classList = String.Empty;
            string tempClass = String.Empty;
            string letter = String.Empty;

            for (int i = 0; i < aClasses.Length; ++i)
            {
                letter = aClasses.Substring(i, 1);
                if (ClassesDict.TryGetValue(letter, out tempClass))
                {
                    classList += String.Format("{0}: {1}\n", letter, tempClass);
                }
                lblClasses.Text = classList;
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayClassesPopup_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
        }
    }
}
