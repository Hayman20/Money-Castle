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
        { // defines a funtion used to find your tax bracket in Australia
            float tax = 0;
            /*
            $18,201 – $45,000	19c for each $1 over $18,200
           $45,001 – $120,000	$5,092 plus 32.5c for each $1 over $45,000
           $120,001 – $180,000	$29,467 plus 37c for each $1 over $120,000
           $180,001 and over	$51,667 plus 45c for each $1 over $180,000
           */
            // checks you bracket by checking each range.
            // when found it will calculate your tax and return it for later use 
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
        private void Graph(string seriesName, string[] x, double[] y, Chart graph, Color colour, SeriesChartType type, double min, double max)
        {


            // Create a new Series and set its properties
            Series series = new Series(seriesName)
            {

                Color = colour,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = type,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                LabelBackColor = colour,
                LabelBorderWidth = 1,

            };



            // Adds the new series to the chart
            graph.Series.Add(series);
            // sets the min y value to the lowest number in the array
            graph.ChartAreas[0].AxisY.Minimum = min;
           
            // binds the series data points to the input x and y values inputed 
            series.Points.DataBindXY(x, y);
         

            Legend legend = new Legend("MainLegend")
            { // creates a custom legend to make the graphs less confusing  
                Docking = Docking.Top, // Position the legend
                Alignment = StringAlignment.Center, // Center the legend title
                LegendStyle = LegendStyle.Row, // Arrange the items in a row
                IsDockedInsideChartArea = false // Dock the legend outside the chart area
            };
            try
            {// tests it 
                // i added this becuase it was throwing errors on build, with out this it will try and create mutilpe legend when display mutilple inputs on a graph
                graph.Legends.Add(legend);
                legend.BackColor = System.Drawing.Color.LightGray;
            }
            catch { }


        }
        class MonthlyTotal
        { // creates a class that has two list
            public string Month { get; set; }
            public float TotalCost { get; set; }
        }
        class StoreTotal 
        { 
            public string Store { get; set; }

            public float TotalCost { get; set; }
            
        }
        public void reload()
        { // creates a reload funtion to make it easy to recall 
            chtCost.Series.Clear();
            chtDebt.Series.Clear();
            chtTotal.Series.Clear();
            if (File.Exists(Login.UserDetailPath))
            { // if the user detail file exists it will read it 
                string[] line = File.ReadAllLines(Login.UserDetailPath);
                string[] lines = line[0].Split(',');

                lblIncome.Text = lines[0] + " " + lines[1];
                float income = float.Parse(lines[0]);
                float total;


                switch (lines[1])
                {// checks the index of lines[1] for a pay period 
                    case "Weekly":
                        // when found it will calculate total income, monthly income after tax, display tax using the tax funtionn and display net income
                        total = income * 55;
                        monthly = Math.Round(total - tax(total))/ 12;
                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round(total - tax(total)).ToString();
                        break;
                    case "Fortnightly":
                        total = income * 26;
                        monthly = Math.Round(total - tax(total)) / 12;

                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round(total - tax(total)).ToString();
                        break;
                    case "Monthly":
                        total = income * 12;
                        monthly = Math.Round(total - tax(total)) / 12;

                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round(total - tax(total)).ToString();
                        break;
                    case "Yearly":
                        total = income * 1;
                        monthly = Math.Round(total - tax(total)) / 12;

                        lblTax.Text = Math.Round(tax(total)).ToString();
                        lblNet.Text = Math.Round((total - tax(total))).ToString();
                        break;
                }
                // rounds the value of monthly to 0 deciamls places
                monthly = Math.Round(monthly);


            }
            if (File.Exists(Login.CostsPath))
            {
                var costMonth = new List<string> { };
                var costTotal = new List<double>();
                var grossTotal = new List<double>();
                var Store = new List<string>();
                var storeCosts = new List<double>();
                // creates new lists for it to output and be comverted into an array

                List<StoreTotal> storeTotals = new List<StoreTotal>();

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
                        string storeName = items[1];


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
                        StoreTotal storeTotal = storeTotals.Find(st => st.Store.Equals(storeName, StringComparison.OrdinalIgnoreCase));
                        if (storeTotal == null)
                        {
                            // Create a new store and add it to the list if not found

                            storeTotals.Add(new StoreTotal { Store = storeName, TotalCost = cost });
                        }
                        else 
                        { 
                            storeTotal.TotalCost += cost;
                        }


                    }
                    foreach (var monthlyTotal in monthlyTotals)
                    {
                        costMonth.Add(monthlyTotal.Month);
                        costTotal.Add(Math.Round(monthlyTotal.TotalCost));
                        grossTotal.Add(Math.Round(monthly - monthlyTotal.TotalCost));
                        // Add all info from lists to another list
                    }
                    foreach (var storeTotal in storeTotals) 
                    {
                        Store.Add(storeTotal.Store);
                        storeCosts.Add(storeTotal.TotalCost);
                    }
                    string[] months = costMonth.ToArray();
                    double[] costs = costTotal.ToArray();
                    double[] gross = grossTotal.ToArray();
                    string[] stores = Store.ToArray();
                    double[] storecost = storeCosts.ToArray();
                    // coverts list into array to work with the graph funtion
                    var temp_y = new List<double>();
                    for (int i = 0; i < months.Length; i++)
                    { // finds the length of the months that have a cost and adds mothnly pay to a list
                        temp_y.Add(monthly);
                    }
                    double[] y = temp_y.ToArray();
                    //coverts list to array
                    double min;
                    if (costs.Min() > gross.Min())
                    {   // finds the array with the lowest number so the y min can be set
                        min = Math.Round(gross.Min());

                    }
                    else
                    {
                        min = Math.Round(costs.Min());
                    }
                    // converts all the lists to an array  Math.Round(gross.Min())
                    Graph("cost", months, costs, chtCost, Color.Red, SeriesChartType.Line, min, Math.Round(costs.Max()));
                    Graph("net", months, gross, chtCost, Color.Green, SeriesChartType.Line, min, Math.Round(costs.Max()));

                    // Defines an array of 12 values of monthly pay to be graphed
                    Graph("Income", months, y, chtCost, Color.LightBlue, SeriesChartType.Line, Math.Round(costs.Min()), Math.Round(costs.Max()));
                    // calls my graph funtion to create the series on the graph, and define their type.
                    Graph("Stores", stores, storecost, chtTotal, Color.Brown, SeriesChartType.Pie, storecost.Min(), storecost.Max());

                }
            }
            if (File.Exists(Login.UserDetailPath))
            {
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
                        var debts = new List<double> { debttotal };
                        var yearlydebt = new List<double> { };
                        var months = new List<string> { date.ToString("yyyy-MM") };
                        var strings = new List<string>();
                        var years = new List<string> { date.ToString("yyyy") };
                        int count = 0;
                        bool yearly = false;
                        while (debttotal >= 0)
                        {// runs untill debt total is equal or less than 0, 
                         // this is used to find how long monthly or yearly it will take to pay off the debt
                            count++;
                            debttotal = debttotal - debtPayment;
                            debts.Add(debttotal);
                            date = date.AddMonths(1);
                            months.Add(date.ToString("yyyy-MM"));
                            //if the while loop has looped more than 12 times it will starts to find how long it will take to pay the debt off yearly
                            // i did this to fix the domain issue stated in the graph funtion
                            if (count > 12)
                            {
                                yearly = true;
                                count = 0;
                                years.Add(date.ToString("yyyy"));
                                yearlydebt.Add(debts.Last());
                                debts.Clear();
                                // makes yearly true to display yearly not monthly on graph
                                // adds the year to the years array, and finds the last value in the debt list to find how much debt was paid off that year
                                // it than clears the debt list to calculate the year again
                            }
                        }

                        // if yearly is true it will display debt payments by year on the graph
                        if (yearly == true)
                        {   // converts the lists to arrays and adds 0 to the debt to find end point
                            yearlydebt.Add(0);
                            double[] debt = yearlydebt.ToArray();
                            string[] time = years.ToArray();

                           
                            // once lists are coverted to arrays it will display on the chtDebt graph using the graph funtion
                            Graph("Debt", time, debt, chtDebt, Color.Blue, SeriesChartType.Line, 0, debttotal);

                        }
                        // if yearly us false it will display debt paymentys by month on the graph
                        else
                        {
                            // converts the lists to arrays 

                            double[] debt = debts.ToArray();
                            string[] time = months.ToArray();
                          
                            // once lists are coverted to arrays it will display on the chtDebt graph using the graph funtion

                            Graph("Debt", time, debt, chtDebt, Color.Blue, SeriesChartType.Line, 0, debttotal);
                        }




                    }

                }
            }
        }

       

        private void View_Load(object sender, EventArgs e)
        {// runs the reload funtion on load
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
        { // runs the reload funtion on click
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
