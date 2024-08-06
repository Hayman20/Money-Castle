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
    { // defining all the form classes so new forms aren't made on every open
        public static View view;
        public static Input input= new Input();
        public static Login login= new Login();
        public static Raw_data raw_Data= new Raw_data();
        public static Settings settings = new Settings();
        public static User use= new User();
        public static Help help=new Help();
        public static Change change = new Change();
        // defines public static varible to be used throughout the soultion
        public static string ID;
        public static string UserDetailPath;
        public static string CostsPath;
        public static string username;


        public static string path = "User.txt";
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static public void open(Form open, Form close) 
        {   // creates a funtion that can be accessed from anywhere in the solution that shows and hides forms, and maps them to eachother so the program closes 
            close.Hide();
            open.FormClosed += (s, args) => close.Close();
            open.Show();

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {   
            Sign_up myForm = new Sign_up();
            // shows a window that has to be closed to interact with the soultion again
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
            { // checks if the user and pass inputs are empty/null
                //if they are it will throw a error message to the user
                MessageBox.Show("please enter a password and username.");
            }
            
            else if (File.Exists(path))
            {// checks if the file exists
                string[] lines = File.ReadAllLines(path);
                // creates a array of all lines in file 
                foreach (string line in lines)
                {   // for each item in the array lines it will run this 
                    
                    string[] users = line.Split(",");
                    // splits the line at line into 4 different indexs 
                    if ( users[0] == txtUsername.Text && users[1] == txtPassword.Text)
                    { // if the 0,1 idexs matchs the login info entered by the user it will run this.
                        MessageBox.Show("welcome");
                        
                        this.Hide();
                        match = true;
                        ID = users[3];
                        // stores the uses id for later use
                        UserDetailPath = users[3]+ "Details.txt";
                        CostsPath = users[3] + "Costs.txt";
                        // stores the users unqie file path for later use
                        username = users[0];
                        //stores username for later use
                        view = new View();
                        view.Show();
                        this.Hide();
                        view.Closed += (s, args) => this.Close();
                        // hides the login and opens the details form, mapping login to it so the mian form can close





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