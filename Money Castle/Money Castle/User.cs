using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Money_Castle
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Login.open(Login.view, Login.use);

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Login.open(Login.input, Login.use);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Login.open(Login.help, Login.use);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Login.open(Login.settings, Login.use);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            Login.DecryptFile(Login.path, Login.temppath);
            string[] s = File.ReadAllLines(Login.temppath);
            foreach (string a in s)
            {   // checks the users file for the user's info to be displayed
                string[] users = a.Split(",");
                if (users[0] == Login.username)
                {
                    lblUser.Text = users[0];
                    lblDate.Text = users[2];
                    File.Delete(Login.temppath);
                }
            }
            if (File.Exists(Login.UserDetailPath))
            {//checks the user's details file for info to display
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');
                lblIncome.Text = "$" + lines[0] + " " + lines[1];
                lblPercent.Text = lines[4] + "%";
                lblSaving.Text = "$" + lines[3];
                lblDebt.Text = "$" + (int.Parse(lines[6]) - int.Parse(lines[7]));


            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Login.change.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Login.DecryptFile(Login.path, Login.temppath);
            string[] s = File.ReadAllLines(Login.temppath);
            foreach (string a in s)
            {   // checks the users file for the user's info to be displayed
                string[] users = a.Split(",");
                if (users[0] == Login.username)
                {
                    lblUser.Text = users[0];
                    lblDate.Text = users[2];
                    File.Delete(Login.temppath);
                }
            }
            if (File.Exists(Login.UserDetailPath))
            {//checks the user's details file for info to display
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');
                lblIncome.Text = "$" + lines[0] + " " + lines[1];
                lblPercent.Text = lines[4] + "%";
                lblSaving.Text = "$" + lines[3];
                lblDebt.Text = "$" + (int.Parse(lines[6]) - int.Parse(lines[7]));


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login.open(Login.login, Login.use);

        }
    }
}
