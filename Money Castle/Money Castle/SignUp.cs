using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Money_Castle
{
    public partial class Sign_up : Form
    {
        public string path = Login.path;
        public Sign_up()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;
            string con = txtConform.Text;
            bool exists = false;
            string date = DateTime.Now.ToString("dd/MM/yyyy");  
            int user_id=1;
            if (File.Exists(path))
            {// if the file exists it will save to the file, if it doesn't it will create a new one at the path location
                Login.DecryptFile(path, Login.temppath);

                if (File.Exists(Login.temppath))
                {

                    string[] lines = File.ReadAllLines(Login.temppath);
                    foreach (string line in lines)
                    {// reads each line in the users text file
                        user_id++;
                        string[] users = line.Split(",");
                        if (users[0] == txtUsername.Text)
                        {// if the username is already in use it will make exists true

                            exists = true;
                            File.Delete(Login.temppath);

                            break;
                        }



                    }
                }
            }
            if (exists==true) 
            {// if exists is true it will throw an error message that the username is already in use
                MessageBox.Show("same");

            }
            else if (user == "" | pass == "" | con == "")
            {// if one of the inputs in null it will throw an error message
                MessageBox.Show("Please fill out all boxes");
            }
            else if (pass != con)
            {// if the inputed password and conformation password don't match it will throw an error
                MessageBox.Show("the two passwords don't match");
            }
            else
            { 
                string record = user + "," + pass + ',' + date + "," + user_id;
                using (TextWriter tw = new StreamWriter(Login.temppath, true))
                {// creates a record out of the inputed data to be saved into the users text file
                    tw.WriteLine(record);
                    MessageBox.Show("Added to file");
                    tw.Close();
                    Login.EncryptFile(Login.temppath,path);
                    File.Delete(Login.temppath);


                }


            }
        }
    }
}
