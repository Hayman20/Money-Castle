using System;
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
            Login.open(Login.view, Login.raw_Data);
        }

        private void Raw_data_Load(object sender, EventArgs e)
        {   
            if (File.Exists(Login.UserDetailPath))
            {// if the file exists it will populate the lables with the debt data from it
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');

                lblDebt.Text = lines[6];
                lblPaid.Text = (lines[7]);



            }

            if (File.Exists(Login.CostsPath))
            {
                // if the file exists it will populate the list view box
                string[] lines = File.ReadAllLines(Login.CostsPath);
                foreach (string line in lines)
                {
                    ListViewItem ListItem = new ListViewItem();
                    string[] items = line.Split(",");
                    for (int i = 0; i < items.Length; i++)
                    {
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
               var delete = (lsvOutput.SelectedItems[0]).Text + "," + (lsvOutput.SelectedItems[0].SubItems[1]).Text + "," + (lsvOutput.SelectedItems[0].SubItems[2]).Text + "," + (lsvOutput.SelectedItems[0].SubItems[3]).Text;
                // reads all items in the selected entry and adds it to a delete varible to reduce mutiple entrys from being deleted for having the same date or store
               var tempFile = Path.GetTempFileName();//creats a temp file path
                                                     //MessageBox.Show(delele);
                                                     // error testing
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


            }
            else 
            {
                MessageBox.Show("Please select a record");
            }



        }

       
    }
}
