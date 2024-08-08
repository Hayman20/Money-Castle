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
            {
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');
               
                lblDebt.Text = lines[6];
                lblPaid.Text = (lines[7]);
               


            }

            if (File.Exists(Login.CostsPath))
            {

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
            
            
                items = items.OrderBy(item => item.SubItems[columnIndex].Text).ToList();
            
            
            // Clear and repopulate the ListView
            lsvOutput.Items.Clear();
            lsvOutput.Items.AddRange(items.ToArray());
        }
    }
}
