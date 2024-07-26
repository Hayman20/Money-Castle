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
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    user_id++;
                    string[] users = line.Split(",");
                    if (users[0] == txtUsername.Text)
                    {

                        exists = true;

                    }
                  


                }
            }
            if (exists==true) 
            {
                MessageBox.Show("same");

            }
            else if (user == "" | pass == "" | con == "")
            {
                MessageBox.Show("Please fill out all boxes");
            }
            else if (pass != con)
            {
                MessageBox.Show("the two passwords don't match");
            }
            else
            {
                string record = user + "," + pass + ',' + date + "," + user_id;
                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(record);
                    MessageBox.Show("Added to file");
                    tw.Close();



                }


            }
        }
    }
}
