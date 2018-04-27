using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbhproj
{
    public partial class ListAll : Form
    {
        public ListAll()
        {
            InitializeComponent();
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
