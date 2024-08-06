using Microsoft.VisualBasic;
using System.IO;
using System.Xml.Linq;
using System;
using System.Runtime;
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
    public partial class Login : Form
    {
        public static View view;
        public static Input input= new Input();
        public static Login login= new Login();
        public static Raw_data raw_Data= new Raw_data();
        public static Settings settings = new Settings();
        public static User use= new User();
        public static Help help=new Help();
        public static Change change = new Change();
        public static string ID;
        public static string UserDetailPath;
        public static string CostsPath;
        


        public static string path = "User.txt";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static public void open(Form open, Form close) 
        {
            close.Hide();
            open.FormClosed += (s, args) => close.Close();
            open.Show();

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Sign_up myForm = new Sign_up();
            myForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }
       
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            string user = txtUsername.Text;
            bool match= false;
            if (user == "" | pass == "") 
            {
                MessageBox.Show("please enter a password and username.");
            }
            
            else if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] users = line.Split(",");
                    if ( users[0] == txtUsername.Text && users[1] == txtPassword.Text)
                    {
                        MessageBox.Show("welcome");
                        
                        
                        this.Hide();
                        match = true;
                        ID = users[3];
                        UserDetailPath = users[3]+ "Details.txt";
                        CostsPath = users[3] + "Costs.txt";
                        view = new View();
                        view.Show();
                        this.Hide();
                        view.Closed += (s, args) => this.Close();





                        break;
                        
                    }
                   

                }
                if (match==false)
                {
                    MessageBox.Show("Wrong User info, please try again");
                }


            }
        }
    }
}