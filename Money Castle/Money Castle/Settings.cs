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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        /* this form was in my design but during creation of my solution
         * it was found that all three of my ideas for settings were
         * impossoble with my level of skill and knewledge so it's functionality
         * was cut from the final solution  
         */
        private void btnDetails_Click(object sender, EventArgs e)
        {
            Login.open(Login.view, Login.settings);

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Login.open(Login.input, Login.settings);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login.open(Login.use, Login.settings);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Login.open(Login.help, Login.settings);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.open(Login.login, Login.settings);
        }

        private void cmbColour_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (cmbColour.Text == "Dark Mode")
            //{
             //   Login.settings.ForeColor = Color.White;
              //  Login.settings.BackColor = Color.Black;
            //}
            //else if (cmbColour.Text == "Light Mode")
            //{
             // /  Login.settings.ForeColor = Color.Black;
              // / Login.settings.BackColor = Color.White;
               // Login.view.ForeColor = Color.Black;
                //Login.view.BackColor = Color.White;
           // }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
