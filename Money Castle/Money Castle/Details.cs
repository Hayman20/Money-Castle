using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Money_Castle
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        public double monthly;


        private void chtCostvsGross_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }
        public float tax(float income)
        {
            float tax = 0;
            /*
            $18,201 – $45,000	19c for each $1 over $18,200
           $45,001 – $120,000	$5,092 plus 32.5c for each $1 over $45,000
           $120,001 – $180,000	$29,467 plus 37c for each $1 over $120,000
           $180,001 and over	$51,667 plus 45c for each $1 over $180,000
           */
            if (income > 182001 && income < 45000)
            {
                tax = (income - 18200) * 0.19f;

            }
            else if (income > 45001 && income < 120000)
            {
                tax = 5092 + ((income - 45000) * 0.325f);

            }
            else if (income > 120001 && income < 180000)
            {
                tax = 29467 + ((income - 12000) * 0.37f);

            }
            else if (income > 180001)
            {
                tax = 51667 + ((income - 180001) * 0.45f);
            }

            return tax;

        }
        private void Graph(string seriesName, string[] x, double[] y, Chart graph, Color colour, SeriesChartType type)
        {


            // Create a new Series and set its properties
            Series series = new Series(seriesName)
            {

                Color = colour,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = type,
                BorderWidth = 2,

            };



            // Clear any existing series
            // Add the new series to the chart
            graph.Series.Add(series);
            series.Points.DataBindXY(x, y);
            Legend legend = new Legend("MainLegend")
            {
                Docking = Docking.Top, // Position the legend
                Alignment = StringAlignment.Center, // Center the legend title
                LegendStyle = LegendStyle.Row, // Arrange the items in a row
                IsDockedInsideChartArea = false // Dock the legend outside the chart area
            };
            try
            {
                graph.Legends.Add(legend);
                legend.BackColor = System.Drawing.Color.LightGray;
            }
            catch { }


        }
        class MonthlyTotal
        {
            public string Month { get; set; }
            public float TotalCost { get; set; }
        }
        public void reload()
        {
            if (File.Exists(Login.UserDetailPath))
            {
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');

                lblIncome.Text = lines[0] + " " + lines[1];
                float income = float.Parse(lines[0]);
                float total;


                switch (lines[1])
                {
                    case "Weekly":
                        total = income * 55;
                        monthly = total / 12;
                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round(total - tax(total)).ToString();
                        break;
                    case "Fortnightly":
                        total = income * 26;
                        monthly = total / 12;

                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round(total - tax(total)).ToString();
                        break;
                    case "Monthly":
                        total = income * 12;
                        monthly = total / 12;

                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round(total - tax(total)).ToString();
                        break;
                    case "Yearly":
                        total = income * 1;
                        monthly = total / 12;

                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round((total - tax(total))).ToString();
                        break;
                }



            }
            var costMonth = new List<string> { };
            var costTotal = new List<double>();
            var grossTotal = new List<double>();
            // creates new lists for it to output and be comverted into an array


            // Customize the chart area
            ChartArea chartArea = new ChartArea
            {
                Name = "MainChartArea"
            };
            chtCost.ChartAreas.Add(chartArea);
            List<MonthlyTotal> monthlyTotals = new List<MonthlyTotal>();
            //Creates a new object

            using (StreamReader sr = new StreamReader(Login.CostsPath))
            {
                string line;

                // Read the file line by line
                while ((line = sr.ReadLine()) != null)
                {
                    var items = line.Split(',');
                    DateTime date = DateTime.Parse(items[0]);
                    float cost = float.Parse(items[2]);
                    string monthKey = date.ToString("yyyy-MM");

                    MonthlyTotal monthlyTotal = monthlyTotals.Find(mt => mt.Month == monthKey);
                    if (monthlyTotal != null)
                    {
                        // Add cost to the existing entry
                        monthlyTotal.TotalCost += cost;
                    }
                    else
                    {
                        // Create a new entry for the month
                        monthlyTotals.Add(new MonthlyTotal { Month = monthKey, TotalCost = cost });
                    }


                }
                foreach (var monthlyTotal in monthlyTotals)
                {
                    costMonth.Add(monthlyTotal.Month);
                    costTotal.Add(monthlyTotal.TotalCost);
                    grossTotal.Add(monthly - monthlyTotal.TotalCost);
                    // Add all info from lists to to another list
                }
                string[] asd = costMonth.ToArray();
                double[] ew = costTotal.ToArray();
                double[] fuck = grossTotal.ToArray();
                // converts all the lists to an array
                Graph("cost", asd, ew, chtCost, Color.Red, SeriesChartType.Line);
                Graph("gross", asd, fuck, chtCost, Color.Green, SeriesChartType.Line);
                double[] y = { monthly, monthly, monthly, monthly, monthly, monthly, monthly, monthly, monthly, monthly, monthly, monthly };
                // Defines an array of 12 values of monthly pay to be graphed
                Graph("Income", asd, y, chtCost, Color.Blue, SeriesChartType.Line);
                // calls my graph funtion to create the series on the graph, and define their type.


            }
            using (StreamReader sr = new StreamReader(Login.UserDetailPath))
            {
                string line;

                // Read the file line by line
                while ((line = sr.ReadLine()) != null)
                {
                    var items = line.Split(',');
                    DateTime date = DateTime.Parse(items[9]);
                    float Debtamout = float.Parse(items[6]);
                    float DebtPaid = float.Parse(items[7]);
                    float debttotal = Debtamout - DebtPaid;
                    float debtPayment = float.Parse(items[8]);
                    var debts = new List<double> { };
                    var months = new List<DateTime> {date };
                    var strings = new List<string>();
                    string monthKey = date.ToString("yyyy-MM");
                    for (; debttotal <= 0; debttotal=debttotal-debtPayment) 
                    { 
                        debts.Add(debttotal);
                        date.AddMonths(1);
                        months.Add(date);
                    }
                    strings.Add(months.ToString());
                    double[] debt =debts.ToArray();
                    string[] month = strings.ToArray();
                    Graph("Debt vs time", month, debt, chtDebt, Color.Azure, SeriesChartType.Line);





                }

            }
        }

       

        private void View_Load(object sender, EventArgs e)
        {
            reload();

           





        }

        private void button1_Click(object sender, EventArgs e)
        {

            Login.open(Login.raw_Data, Login.view);

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Login.open(Login.input, Login.view);

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }

        private void chtCost_Click(object sender, EventArgs e)
        {

        }

        private void chtTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void chtDebt_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Login.open(Login.use, Login.view);

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Login.open(Login.help, Login.view);

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Login.open(Login.settings, Login.view);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
