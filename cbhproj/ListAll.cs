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
    public partial class ListAll : Form
    {
        List<vwDriver> drivers = new List<vwDriver>();

        public ListAll()
        {
            InitializeComponent();
            LoadData();
            FormatData();
        }

        private void LoadData()
        {
            using (var db = new mdmcleroyEntities())
            {
                drivers = (from d in db.vwDrivers
                           where d.Active == true
                             && d.Deleted == false
                           orderby d.SSN
                           select d).ToList();
            }
        }

        private void FormatData()
        {
            foreach (var item in drivers)
            {
                txtListAll.AppendText(String.Format("{0}-{1}-{2} {3} {4} {5} {6} {7}",
                    item.SSN.Substring(0, 3), item.SSN.Substring(3, 2), item.SSN.Substring(5, 4),
                    item.LastName.PadRight(20), item.FirstName.PadRight(12), item.MI.PadRight(2), 
                    item.Address1.PadRight(30), item.Address2.PadRight(30)));
                txtListAll.AppendText(Environment.NewLine);
            }
        }

        private void ListAll_Load(object sender, EventArgs e)
        {
            Text = "cbhproj";
            Width = 1041;
            Height = 820;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
