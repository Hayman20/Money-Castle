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
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        public string UserDetail = "Details.txt";
        public string Costs = "Costs.txt";
        private void Input_Load(object sender, EventArgs e)
        {

        }
    }
}
