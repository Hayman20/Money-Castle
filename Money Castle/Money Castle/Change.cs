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
        {   // closes this form 
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtOld.Text != ""&& txtConform.Text != "")
            {   // if non of the input areas are empty it will run
                Login.DecryptFile(Login.path, Login.temppath);
                string[] lines = File.ReadAllLines(Login.temppath);
                int count = 0;
                bool update = false;
                // reads each line in the file
                foreach (string line in lines)
                {   // adds one to the count to find right index(same line as all the other user info), when saving to file 
                    count++;
                    string[] users = line.Split(",");
                    if (users[0] == Login.username && users[1] == txtOld.Text && txtPassword.Text == txtConform.Text)
                    { // if the username matchs the logged in username and all the passwords are right it will replace the old password with the new one 
                        users[1] = txtPassword.Text;
                        // defining a record to save
                        string record = users[0] + "," + users[1] + "," + users[2] + "," + users[3];
                        using (TextWriter tw = new StreamWriter(Login.temppath, true))
                        {   // text at the index of count-1 is updated with the text of record
                            lines[count - 1] = record;
                            // makes update true to see if the file updated
                            update = true;
                            break;
                        }

                    }

                }
                // if true the file will be updated 
                if (update)

                {   // replaces the line with lines 
                    File.WriteAllLines(Login.temppath, lines);
                    Login.EncryptFile(Login.temppath, Login.path);
                    File.Delete(Login.temppath);
                    MessageBox.Show("Updated");
                }
                else
                {   // validation if one of the 3 tests don't match
                    MessageBox.Show("Password is wrong, or new one doesn't match");
                }
            }
            else 
            {   // if the input areas are emptry, throws error
                MessageBox.Show("Please fill out all boxes");
            }

        }
    }
}
