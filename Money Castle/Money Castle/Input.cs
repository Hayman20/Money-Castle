﻿using System;
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

namespace Money_Castle
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        public string UserDetailPath = "Details.txt";
        public string CostsPath = "Costs.txt";
        private void Input_Load(object sender, EventArgs e)
        {
            if (File.Exists(UserDetailPath))
            {
                string[] line = File.ReadAllLines(UserDetailPath);
                string[] lines = line[0].Split(',');
                txtIncome.Text = lines[0];
                cmbPeriod.Text = lines[1];
                txtSavingdes.Text = lines[2];
                txtSavingAmont.Text = lines[3];
                cmbPercent.Text = lines[4];
                txtDebtDes.Text = lines[5];
                txtDebtAmount.Text = lines[6];
                txtDebtPaid.Text = lines[7];


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
            // puts each varible in a collection of varible sorted by what info goes in what file 
            string userDetils = income + "," + period + "," + savingDes + "," + savingAmount + "," + percent + "," + debtDes + "," + debtAmount + "," + debtPaid;
            string costs = date + "," + store + "," + cost + "," + type;
            // checks if any of the inputs are empty
            if (income == null | store == null | cost == null | savingAmount == null | savingDes == null | debtAmount == null | debtDes == null | debtPaid == null)
            {
                MessageBox.Show("Please fill all boxes");
            }
            // checks if some of the inputs are only numbers 
            else if (!float.TryParse(income, out float test) | !float.TryParse(cost, out float test1) | !float.TryParse(savingAmount, out float test2) | !float.TryParse(debtAmount, out float test3) | !float.TryParse(debtPaid, out float test4))

            {
                MessageBox.Show("please only use numbers for income/cost/savings/debts");
            }
            // once every thing is correct it will save it to two files 
            else
            {   // adds a entry to the costs of the user
                using (TextWriter tw = new StreamWriter(CostsPath, true))
                {
                    tw.WriteLine(costs);
                    MessageBox.Show("File created");
                    tw.Close();
                }
                // if the userDetail file doesn't exist it will create one and save all the data to it
                if (!File.Exists(UserDetailPath))
                {
                    using (TextWriter tw = new StreamWriter(UserDetailPath, true))
                    {
                        tw.WriteLine(userDetils);
                        MessageBox.Show("File created");
                        tw.Close();
                    }
                }
                // if the file does exist it will replace all the info with new inputted info
                else
                {
                    string[] lines = File.ReadAllLines(UserDetailPath);
                    lines[0] = userDetils;
                    File.WriteAllLines(UserDetailPath, lines);
                    MessageBox.Show("File updated");
                }

            }
        }
    }
}