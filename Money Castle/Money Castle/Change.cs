using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Castle
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Login.path);
            int count = 0;
            bool update=false;
            foreach (string line in lines)
            {
                count++;
                string[] users = line.Split(",");
                if (users[0] == txtOld.Text && txtPassword.Text == txtConform.Text)
                {
                    users[1] = txtPassword.Text;
                    string record = users[0] + "," + users[1] + "," + users[2] + ","+users[3];
                    using (TextWriter tw = new StreamWriter(Login.path, true))
                    {
                        lines[count - 1] = record;
                        update = true;
                        break;
                    }

                }
                else 
                {
                    MessageBox.Show("Password is wrong, or new one doesn't match");
                }
            }
            if (update)
            {
                File.WriteAllLines(Login.path, lines);
                MessageBox.Show("Updated");
            }
            
        }
    }
}
