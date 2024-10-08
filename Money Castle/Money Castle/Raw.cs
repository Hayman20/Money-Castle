﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Money_Castle
{
    public partial class Raw_data : Form
    {
        public Raw_data()
        {
            InitializeComponent();
        }
        public int columnIndex;

        private void btnGraph_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reload()
        {
            lsvOutput.Items.Clear();
            if (File.Exists(Login.CostsPath))
            {
                // if the file exists it will populate the list view box
                string[] lines = File.ReadAllLines(Login.CostsPath);
                foreach (string line in lines)
                {
                    ListViewItem ListItem = new ListViewItem();
                    string[] items = line.Split(",");
                    for (int i = 0; i < items.Length; i++)
                    {   // reads each line of the file and displays it as a record, reads the whole
                        if (i == 0)
                        {
                            ListItem.Text = items[i];
                        }
                        else
                        {
                            ListItem.SubItems.Add(items[i]);
                        }
                    }
                    lsvOutput.Items.Add(ListItem);

                }


            }

        }

        private void Raw_data_Load(object sender, EventArgs e)
        {
            reload();
            dtpDate.Text = DateTime.Now.ToString("dd-MM-yyyy");


        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmbSort.Text;
            // when the user picks how they want to sort by it changes the value of the columnidex varible 
            if (selectedItem.Contains("Type"))
            {
                columnIndex = 3;
            }
            /* else if (selectedItem.Contains("Cost"))
             { i was going to make it sort by cost too but it doesn't work because it treats it as a string not a float
                 columnIndex = 2;
             }
             */
            else if (selectedItem.Contains("Date"))
            {
                columnIndex = 0;
            }
            else if (selectedItem.Contains("Store"))
            {
                columnIndex = 1;

            }

            // Create a list of ListViewItem for sorting
            List<ListViewItem> items = lsvOutput.Items.Cast<ListViewItem>().ToList();

            // Sort based on the selected column and order

            // depending on what columnidex was selected it sorts by that index
            items = items.OrderBy(item => item.SubItems[columnIndex].Text).ToList();


            // Clears and repopulate the ListView
            lsvOutput.Items.Clear();
            lsvOutput.Items.AddRange(items.ToArray());
        }

        private void lsvOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvOutput.SelectedItems.Count > 0)
            {   // if something in the list view box is selected
                string delete = (lsvOutput.SelectedItems[0]).Text + "," + (lsvOutput.SelectedItems[0].SubItems[1]).Text + "," + (lsvOutput.SelectedItems[0].SubItems[2]).Text + "," + (lsvOutput.SelectedItems[0].SubItems[3]).Text;
                // reads all items in the selected entry and adds it to a delete varible to reduce mutiple entrys from being deleted for having the same date or store
                string tempFile = Path.GetTempFileName();//creats a temp file path
                                                         //MessageBox.Show(delele); error testing
                var linesToKeep = File.ReadLines(Login.CostsPath).Where(l => l != delete);
                //if the line read doesn't match delete it is kept

                File.WriteAllLines(tempFile, linesToKeep);
                // writes all the saved lines to a temp file
                File.Delete(Login.CostsPath);
                //deletes the origial file
                File.Move(tempFile, Login.CostsPath);
                //creates a new file with all the saved lines transfered from the temp file
                lsvOutput.SelectedItems[0].Remove();
                // removes the entry from the list view box
                reload();


            }
            else
            {   // if a record isn't selectd it will throw an error
                MessageBox.Show("Please select a record");
            }



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login.open(Login.login, Login.raw_Data);

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Login.open(Login.view, Login.raw_Data);

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Login.open(Login.input, Login.raw_Data);

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login.open(Login.use, Login.raw_Data);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Login.open(Login.help, Login.raw_Data);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Login.open(Login.settings, Login.raw_Data);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dtpDate.Text;
            string store = txtStore.Text;
            string cost = txtCost.Text;
            string type = cmbType.Text;
            string costs = date + "," + store + "," + cost + "," + type;
            if (File.Exists(Login.CostsPath))
            {
                if (cost != "" && store != "" && type != "")
                {

                    if (float.TryParse(cost, out float test10))
                    {   // if cost is a number it will save the record to the file
                        using (TextWriter tw = new StreamWriter(Login.CostsPath, true))
                        {
                            tw.WriteLine(costs);
                            tw.Close();
                            MessageBox.Show("Cost added to file.");
                            reload();
                            txtCost.Text = "";
                            txtStore.Text = "";
                            cmbType.Text = "";
                        }
                    }
                    else { MessageBox.Show("please use numbers for cost"); }
                }
                else
                {
                    MessageBox.Show("Please fill out all cost inputs to add a cost");
                }
            }
        }
    }
}
