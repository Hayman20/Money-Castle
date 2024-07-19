using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Castle
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void chtCostvsGross_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            lblIncome.Text = string.Empty;
            lblTax.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Raw_data myForm = new Raw_data();
            myForm.Show();
            this.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Input myForm = new Input();
            myForm.Show();
            this.Hide();
            myForm.Closed += (s, args) => this.Close();
           
        }
    }
}
