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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Login.open(Login.view, Login.help);

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Login.open(Login.input, Login.help);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login.open(Login.use, Login.help);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Login.open(Login.settings, Login.help);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.open(Login.login, Login.help);

        }
    }
}
