using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void Input_Load(object sender, EventArgs e)
        {
            dtpDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            if (File.Exists(Login.UserDetailPath))
            {
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');
                txtIncome.Text = lines[0];
                cmbPeriod.Text = lines[1];
                txtSavingdes.Text = lines[2];
                txtSavingAmont.Text = lines[3];
                cmbPercent.Text = lines[4];
                txtDebtDes.Text = lines[5];
                txtDebtAmount.Text = lines[6];
                txtDebtPaid.Text = lines[7];
                txtMonthly.Text = lines[8];
                dtpDebtTime.Text = lines[9];


            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   // defines every input as a vaarible for easy access


            string income = txtIncome.Text;
            string period = cmbPeriod.Text;
            string date = dtpDate.Text;
            string store = txtStore.Text;
            string cost = txtCost.Text;
            string type = cmbType.Text;
            string savingDes = txtSavingdes.Text;
            string savingAmount = txtSavingAmont.Text;
            string percent = cmbPercent.Text;
            string debtDes = txtDebtDes.Text;
            string debtAmount = txtDebtAmount.Text;
            string debtPaid = txtDebtPaid.Text;
            string debtPay = txtMonthly.Text;
            string debtTime = dtpDebtTime.Text;
            bool worked = false;
            // puts each varible in a collection of varible sorted by what info goes in what file 
            string userDetils = income + "," + period + "," + savingDes + "," + savingAmount + "," + percent + "," + debtDes + "," + debtAmount + "," + debtPaid+","+debtPay+","+debtTime;
            /* In my design instead of the usering input this costs, i would of maded my user to 
             * input the file location of a bank statment which is impossible with my level of skill and knowledge
             * so instead of this i have the user input it themselves
            */
            string costs = date + "," + store + "," + cost + "," + type;
            // checks if any of the inputs are empty
            if (income == null |   savingAmount == null | savingDes == null | debtAmount == null | debtDes == null | debtPaid == null | debtPay == null)
            {
                MessageBox.Show("Please fill all boxes");
            }

            // checks if some of the inputs are only numbers 
            else if (!float.TryParse(income, out float test) | !float.TryParse(savingAmount, out float test2) | !float.TryParse(debtAmount, out float test3) | !float.TryParse(debtPaid, out float test4))

            {
                MessageBox.Show("please only use numbers for income/cost/savings/debts");
            }
            else if (int.Parse(debtPay) <= 0) 
            {
                MessageBox.Show("Monthly payments need to be above $0");
            }
            // once every thing is correct it will save it to two files 
            else
            {   // adds a entry to the costs of the user
                if (cost != "" && store != "" && type != "")
                {

                    if (float.TryParse(cost, out float test10))
                    {
                        using (TextWriter tw = new StreamWriter(Login.CostsPath, true))
                        {
                            tw.WriteLine(costs);
                            worked = true;
                            tw.Close();
                        }
                    }
                    else { MessageBox.Show("please use numbers for cost"); }
                }
                else if (cost != "" | store != "" | type != "")
                {
                    MessageBox.Show("To add a cost please fill out all boxes.");
                }
                // if the userDetail file doesn't exist it will create one and save all the data to it
                if (!File.Exists(Login.UserDetailPath))
                {
                    using (TextWriter tw = new StreamWriter(Login.UserDetailPath, true))
                    {
                        tw.WriteLine(userDetils);
                        worked = true;
                        tw.Close();
                    }
                }
                // if the file does exist it will replace all the info with new inputted info
                else
                {
                    string[] lines = File.ReadAllLines(Login.UserDetailPath);
                    lines[0] = userDetils;
                    File.WriteAllLines(Login.UserDetailPath, lines);
                    worked = true ;
                }
                // sorts the array then remakes it
                string[] Allcosts = File.ReadAllLines(Login.CostsPath);
                Array.Sort(Allcosts);
                File.Delete(Login.CostsPath);
                File.WriteAllLines(Login.CostsPath, Allcosts);
                if (worked)
                {
                    MessageBox.Show("File updated");

                }
                else 
                {
                    MessageBox.Show("Something went wrong");
                }

            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Login.open(Login.view, Login.input);


        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login.open(Login.use, Login.input);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Login.open(Login.help, Login.input);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Login.open(Login.settings, Login.input);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
