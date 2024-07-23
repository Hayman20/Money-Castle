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
        public string UserDetailPath = "Details.txt";
        public string CostsPath = "Costs.txt";

        private void chtCostvsGross_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }
        void tax(float income) 
        { 
            switch (income) 
            {
                case > 18201:
            
            
            }
        
        }

        private void View_Load(object sender, EventArgs e)
        {
            string[] line = File.ReadAllLines(UserDetailPath);
            string[] lines = line[0].Split(',');
         
            lblIncome.Text = lines[0];
            /*
             $18,201 – $45,000	19c for each $1 over $18,200
            $45,001 – $120,000	$5,092 plus 32.5c for each $1 over $45,000
            $120,001 – $180,000	$29,467 plus 37c for each $1 over $120,000
            $180,001 and over	$51,667 plus 45c for each $1 over $180,000
            */
            switch (lines[1]) 
            {
                case "Weekly":
                    float income = float.Parse(lines[0])*55;
                    break;
            
            } 
            
             
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

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
