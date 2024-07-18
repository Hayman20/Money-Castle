using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Castle
{
    public partial class Raw_data : Form
    {
        public Raw_data()
        {
            InitializeComponent();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Close();
        }
    }
}
