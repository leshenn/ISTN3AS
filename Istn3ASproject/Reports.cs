using Istn3ASproject.WstGrp11DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Istn3ASproject
{
    public partial class frmReports: Form
    {
        //private Istn3ASproject.WstGrp11DataSet WSTGRP11DataSet;
        //DataSet dataSet = new Istn3ASproject.WstGrp11DataSet();
        public frmReports()
        {
            InitializeComponent();
            dtpFinancialChart.Format = DateTimePickerFormat.Custom;
            dtpFinancialChart.CustomFormat = "yyyy/MM";
            dtpFinancialChart.ShowUpDown = true;
            chrtFinancialLine.ChartAreas[0].AxisX.Interval = 1;
            loadFinancialChart();
            loadLifeTimeGraphFinancial();

        }




        public void loadLifeTimeGraphFinancial()
        {
            chrtFinancial.Series["Money Flow"].Points.Clear();


            taSupplierOrderFinancial.Fill(wstGrp11DataSet1.SupplierOrder);
            taOrderFinancial.Fill(wstGrp11DataSet1.Order);

            decimal dept = 0;
            decimal income = 0;

            //CALCULATE EXPENSES
            for (int i = 0; i < wstGrp11DataSet1.SupplierOrder.Rows.Count; i++)
            {
                dept += Convert.ToDecimal(wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[2]);
            }

            //CALCULATE iNCOME
            for (int i = 0; i < wstGrp11DataSet1.Order.Rows.Count; i++)
            {
                income += Convert.ToDecimal(wstGrp11DataSet1.Order.Rows[i].ItemArray[7]);
            }


            chrtFinancial.Series["Money Flow"].Points.AddXY("Expenses", dept);
            chrtFinancial.Series["Money Flow"].Points.AddXY("Income", income);
            SetLabels(income, dept);
        }



        public void loadDailyeGraphFinancial()
        {
            chrtFinancial.Series["Money Flow"].Points.Clear();
            String Today = DateTime.Today.ToString("yyyy/MM/dd");


            taSupplierOrderFinancial.Fill(wstGrp11DataSet1.SupplierOrder);
            taOrderFinancial.Fill(wstGrp11DataSet1.Order);

            decimal dept = 0;
            decimal income = 0;


            string message = "";
            //CALCULATE EXPENSES
            for (int i = 0; i < wstGrp11DataSet1.SupplierOrder.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[5].ToString();
                string date = input.Split(' ')[0];

                message += input + "\n";
               
                if (Today == date)
                {
                    dept += Convert.ToDecimal(wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[2]);
                }

               
            }
            MessageBox.Show(message);

            //CALCULATE iNCOME
            for (int i = 0; i < wstGrp11DataSet1.Order.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.Order.Rows[i].ItemArray[5].ToString();
                string date = input.Split(' ')[0];


                if (Today == date)
                {
                    income += Convert.ToDecimal(wstGrp11DataSet1.Order.Rows[i].ItemArray[7]);
                }
            }


            chrtFinancial.Series["Money Flow"].Points.AddXY("Expenses", dept);
            chrtFinancial.Series["Money Flow"].Points.AddXY("Income", income);
            SetLabels(income, dept);
        }



        public void loadMonthlyeGraphFinancial()
        {
            chrtFinancial.Series["Money Flow"].Points.Clear();
            String Today = DateTime.Today.ToString("yyyy/MM");


            taSupplierOrderFinancial.Fill(wstGrp11DataSet1.SupplierOrder);
            taOrderFinancial.Fill(wstGrp11DataSet1.Order);

            decimal dept = 0;
            decimal income = 0;

            //CALCULATE EXPENSES
            for (int i = 0; i < wstGrp11DataSet1.SupplierOrder.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[5].ToString();
                string date = input.Split('/')[0];
                date +="/"+ input.Split('/')[1];

                if (Today == date)
                {
                    dept += Convert.ToDecimal(wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[2]);
                }


            }

            //CALCULATE iNCOME
            for (int i = 0; i < wstGrp11DataSet1.Order.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.Order.Rows[i].ItemArray[5].ToString();
                string date = input.Split('/')[0];
                date += "/" + input.Split('/')[1];


                if (Today == date)
                {
                    income += Convert.ToDecimal(wstGrp11DataSet1.Order.Rows[i].ItemArray[7]);
                }
            }


            chrtFinancial.Series["Money Flow"].Points.AddXY("Expenses", dept);
            chrtFinancial.Series["Money Flow"].Points.AddXY("Income", income);
            SetLabels(income, dept);
        }

        public void loadYearlyGraphFinancial()
        {
            chrtFinancial.Series["Money Flow"].Points.Clear();
            String Today = DateTime.Today.ToString("yyyy");


            taSupplierOrderFinancial.Fill(wstGrp11DataSet1.SupplierOrder);
            taOrderFinancial.Fill(wstGrp11DataSet1.Order);

            decimal dept = 0;
            decimal income = 0;

            //CALCULATE EXPENSES
            for (int i = 0; i < wstGrp11DataSet1.SupplierOrder.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[5].ToString();
                string date = input.Split('/')[0];

                if (Today == date)
                {
                    dept += Convert.ToDecimal(wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[2]);
                }


            }

            //CALCULATE iNCOME
            for (int i = 0; i < wstGrp11DataSet1.Order.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.Order.Rows[i].ItemArray[5].ToString();
                string date = input.Split('/')[0];



                if (Today == date)
                {
                    income += Convert.ToDecimal(wstGrp11DataSet1.Order.Rows[i].ItemArray[7]);
                }
            }


            chrtFinancial.Series["Money Flow"].Points.AddXY("Expenses", dept);
            chrtFinancial.Series["Money Flow"].Points.AddXY("Income", income);
            SetLabels(income, dept);
        }


        public void loadWeeklyGraphFinancial()
        {
            chrtFinancial.Series["Money Flow"].Points.Clear();
            String Today = DateTime.Today.ToString("yyyy/MM/dd");
            DateTime dtToday = DateTime.Parse(Today);


            taSupplierOrderFinancial.Fill(wstGrp11DataSet1.SupplierOrder);
            taOrderFinancial.Fill(wstGrp11DataSet1.Order);

            decimal dept = 0;
            decimal income = 0;

            //CALCULATE EXPENSES
            for (int i = 0; i < wstGrp11DataSet1.SupplierOrder.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[5].ToString();
                string date = input.Split(' ')[0];
                DateTime dtDate = DateTime.Parse(date);

                TimeSpan diff = (dtToday - dtDate).Duration();


                if (diff.TotalDays<=7)
                {
                    dept += Convert.ToDecimal(wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[2]);
                }

            }

            //CALCULATE iNCOME
            for (int i = 0; i < wstGrp11DataSet1.Order.Rows.Count; i++)
            {
                string input = wstGrp11DataSet1.Order.Rows[i].ItemArray[5].ToString();
                string date = input.Split(' ')[0];
                DateTime dtDate = DateTime.Parse(date);

                TimeSpan diff = (dtToday - dtDate).Duration();

                if (diff.TotalDays <= 7)
                 {
                     income += Convert.ToDecimal(wstGrp11DataSet1.Order.Rows[i].ItemArray[7]);
                 }
            }


            chrtFinancial.Series["Money Flow"].Points.AddXY("Expenses", dept);
            chrtFinancial.Series["Money Flow"].Points.AddXY("Income", income);

            SetLabels(income, dept);
        }

        private void label1Financial_Click(object sender, EventArgs e)
        {

        }

        private void SetLabels(decimal income, decimal expenses)
        {
            lblIncomeFinancial.Text = income.ToString("C2");
            lblExpensesFinancial.Text = expenses.ToString("C2");

            decimal profit = income - expenses;
            lblProfitFinancial.Text = profit.ToString("C2");
        }

        private void btnRefreshFinancialGraph_Click(object sender, EventArgs e)
        {

            if (cmbPeriodFinancial.Text == "Lifetime"){
                loadLifeTimeGraphFinancial();

            } 
            else if (cmbPeriodFinancial.Text == "Weekly")
            {
                loadWeeklyGraphFinancial();
            }
            else if (cmbPeriodFinancial.Text == "Monthly")
            {
                loadMonthlyeGraphFinancial();
            }
            else if (cmbPeriodFinancial.Text == "Daily")
            {
                loadDailyeGraphFinancial();
            }
            else if (cmbPeriodFinancial.Text == "Yearly")
            {
                loadYearlyGraphFinancial();
            }
        }

        private void dtpFinancialChart_ValueChanged(object sender, EventArgs e)
        {
            loadFinancialChart();
        }

        private void loadFinancialChart()
        {
            chrtFinancialLine.Series["income"].Points.Clear();
            chrtFinancialLine.Series["expenses"].Points.Clear();

            Decimal[] dailyIncome = new decimal[31];
            Decimal[] dailyExpense = new decimal[31];

            for (int i =0; i<31; i++)
            {
                dailyIncome[i] = 0;
                dailyIncome[i] = 0;
            }

            string input = dtpFinancialChart.Value.ToString();
            string Cdate = input.Split('/')[0];
            Cdate += '/' + input.Split('/')[1];

           taOrderFinancial.Fill(wstGrp11DataSet1.Order);
           taSupplierOrderFinancial.Fill(wstGrp11DataSet1.SupplierOrder);


            //CALCULATE iNCOME
            for (int i = 0; i < wstGrp11DataSet1.Order.Rows.Count; i++)
            {
                input = wstGrp11DataSet1.Order.Rows[i].ItemArray[5].ToString();
                string date = input.Split('/')[0];
                date += '/' + input.Split('/')[1];


                if (date == Cdate)
                {
                    string dateInput = input.Split('/')[2];
                    int day = Convert.ToInt32(dateInput.Split(' ')[0]);
                   // MessageBox.Show(day.ToString());

                    dailyIncome[day]+= Convert.ToDecimal(wstGrp11DataSet1.Order.Rows[i].ItemArray[7]);
                }
            }

            //CALCULATE EXPENSES
            for (int i = 0; i < wstGrp11DataSet1.SupplierOrder.Rows.Count; i++)
            {
                input = wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[5].ToString();
                string date = input.Split('/')[0];
                date += '/' + input.Split('/')[1];


                if (date == Cdate)
                {
                    string dateInput = input.Split('/')[2];
                    int day = Convert.ToInt32(dateInput.Split(' ')[0]);

                    dailyExpense[day] += Convert.ToDecimal(wstGrp11DataSet1.SupplierOrder.Rows[i].ItemArray[2]);
                }
            }

            for (int i =0; i <31; i++)
            {
                chrtFinancialLine.Series["income"].Points.AddXY((i + 1).ToString(), dailyIncome[i]);
                chrtFinancialLine.Series["expenses"].Points.AddXY((i + 1).ToString(), dailyExpense[i]);
            }

        }

        private void btnCustPerProvince_Click(object sender, EventArgs e)
        {
            //bar chart
            //display num of customers per province

            chtCustomerPerProvince.Series.Clear();
            chtCustomerPerProvince.Titles.Clear();


            // Initialize components
            CustomerTableAdapter customerTableAdapter = new CustomerTableAdapter();
            WstGrp11DataSet dataset = new WstGrp11DataSet(); // Create new dataset instance
            dataset.EnforceConstraints = false;


            // This FILLS the DataTable but returns row count
            int recordsLoaded = customerTableAdapter.FillByProvinceReports(dataset.Customer);

            // 3. Extract the actual data
            DataTable provinceData = dataset.Customer;

            // 4. Configure chart series
            Series series = new Series("Customers")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.SteelBlue,
                Font = new Font("Arial", 8, FontStyle.Bold)
            };

            // 5. Add data points
            foreach (WstGrp11DataSet.CustomerRow row in provinceData.Rows)
            {
                // Use the exact column name from your query
                string province = row["Province"].ToString();
                int count = Convert.ToInt32(row["Count"]); // Match your query's COUNT column name

                series.Points.AddXY(province, count);
            }

            // 6. Finalize chart
            chtCustomerPerProvince.Series.Add(series);
            chtCustomerPerProvince.Titles.Add("Customers Per Province");

            // Optional formatting
            chtCustomerPerProvince.ChartAreas[0].AxisX.Title = "Province";
            chtCustomerPerProvince.ChartAreas[0].AxisY.Title = "Customer Count";
            chtCustomerPerProvince.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            if (cmbTotalSales.SelectedIndex == -1) 
            {
                MessageBox.Show("Please Select An Option To Load the Pie Chart","Option Not Selected",MessageBoxButtons.OK);
            }
            else {
                chtTotalSalesDate.Series.Clear();
                chtTotalSalesDate.Titles.Clear();

                string timePeriod = cmbTotalSales.SelectedItem.ToString();

                // Create a new dataset instance
                WstGrp11DataSet dataset = new WstGrp11DataSet();
                OrderTableAdapter orderTableAdapter = new OrderTableAdapter();
                dataset.EnforceConstraints = false;

                // Choose which TableAdapter method to call based on time period
                switch (timePeriod)
                {
                    case "Day":
                        orderTableAdapter.FillBySalesPerDay(dataset.Order); // Uses your FillByDay query
                        break;

                    case "Month":
                        orderTableAdapter.FillBySalesPerMonth(dataset.Order); // Uses your FillByMonth query
                        break;

                    case "Year":
                        orderTableAdapter.FillBySalesByYear(dataset.Order); // Uses your FillByYear query
                        break;

                    default:
                        throw new ArgumentException("Invalid time period");
                }

                // Create pie series
                Series series = new Series("Revenue")
                {
                    ChartType = SeriesChartType.Pie,
                    IsValueShownAsLabel = true,
                    LabelFormat = "C0", // Currency format
                    LegendText = "#VALX (#PERCENT{P0})", // Shows "Period (XX%)" in legend
                    ToolTip = "#VALX: #VALY{C2} (#PERCENT{P2})" // Detailed tooltip
                };

                // 5. Add data points to the chart
                foreach (WstGrp11DataSet.OrderRow row in dataset.Order)
                {

                    // SAFE DATE ACCESS
                    DateTime orderDate;
                    if (row["Date"] == DBNull.Value || !DateTime.TryParse(row["Date"].ToString(), out orderDate))
                    {
                        orderDate = DateTime.Today; // Default value
                    }

                    // SAFE AMOUNT ACCESS
                    decimal amount = row["TotalCost"] == DBNull.Value ? 0 : Convert.ToDecimal(row["TotalCost"]);
                    series.Points.AddXY(
                        row.Date.ToString("d"), // Format date based on period
                        row.TotalCost // Your revenue column
                    );
                }

                // 6. Add the series to the chart
                chtTotalSalesDate.Series.Add(series);
                chtTotalSalesDate.Titles.Add($"{timePeriod} Revenue");

                // 7. Optional: Improve appearance
                chtTotalSalesDate.Legends[0].Docking = Docking.Right;

            }

            
        }

        private void btnTransactionReports_Click(object sender, EventArgs e)
        {
            chtTransactionTypes.Series.Clear();
            chtTransactionTypes.Titles.Clear();
            chtTransactionTypes.Legends.Clear();

            // Create dataset and adapter
            WstGrp11DataSet dataset = new WstGrp11DataSet();
            OrderTableAdapter orderTableAdapter = new OrderTableAdapter();
            dataset.EnforceConstraints = false;

            // Add title
            chtTransactionTypes.Titles.Add("Payment Method Distribution (Donut Chart)");
            chtTransactionTypes.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Get data from database - CORRECTED APPROACH
            DataTable dtPayments = dataset.Order; // Get reference to the DataTable
            int rowsReturned = orderTableAdapter.FillByTransactionTypeReports(dataset.Order); // Fill existing table

            // Create series for donut chart
            Series series = new Series("PaymentMethods");
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0}: {1} orders\n#PERCENT{P1}";
            series.ToolTip = "#VALX: #VALY orders\nTotal: #TOTAL{C}";
            series["DoughnutRadius"] = "60";
            series.Palette = ChartColorPalette.BrightPastel;

            // Add data points
            foreach (DataRow row in dtPayments.Rows)
            {
                string method = row["MethodOfPayment"].ToString();
                int count = Convert.ToInt32(row["OrderCount"]);
                decimal amount = Convert.ToDecimal(row["TotalAmount"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(method, count);
                point.Label = $"{method}\n{count} orders";
                point.LegendText = $"{method} - {amount:C}";
                series.Points.Add(point);
            }

            // Add series to chart
            chtTransactionTypes.Series.Add(series);

            // Add and customize legend
            Legend legend = new Legend();
            legend.Title = "Payment Methods";
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            chtTransactionTypes.Legends.Add(legend);

            // Customize donut appearance
            chtTransactionTypes.ChartAreas[0].Area3DStyle.Enable3D = true;
            chtTransactionTypes.ChartAreas[0].Area3DStyle.Inclination = 30;
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            series.BorderWidth = 1;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            // Enable vertical scrolling
            this.AutoScroll = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

           
        }

        private void btnSalesRefundsReports_Click(object sender, EventArgs e)
        {
            // Clear existing chart elements
            chtSaleRefund.Series.Clear();
            chtSaleRefund.Titles.Clear();
            chtSaleRefund.Legends.Clear();

            // Set chart title
            chtSaleRefund.Titles.Add("Sales vs Refunds");
            chtSaleRefund.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Get data from database
           
            WstGrp11DataSet dataset = new WstGrp11DataSet();
            dataset.EnforceConstraints = false;
            OrderTableAdapter orderTA = new OrderTableAdapter();
            DataTable dtTransactions = dataset.Order;
            orderTA.FillBySaleOrRefundReports(dataset.Order);
           



            // Create donut series
            Series series = new Series("TransactionTypes");
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#PERCENT{P1}"; // Show percentages
            series["DoughnutRadius"] = "60"; // 60% width (40% hole)
            series.BorderWidth = 2;
            series.BorderColor = Color.White;

            // Custom colors for transaction types
            Dictionary<string, Color> typeColors = new Dictionary<string, Color>()
    {
        { "Sale", Color.Green },
        { "Refund", Color.Red }
    };

            // Add data points
            foreach (DataRow row in dtTransactions.Rows)
            {
                string type = row["TransactionType"].ToString();
                int count = Convert.ToInt32(row["TransactionCount"]);
                decimal amount = Convert.ToDecimal(row["TotalAmount"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(type, count);
                point.Color = typeColors.ContainsKey(type) ? typeColors[type] : Color.Blue;
                point.Label = $"{type}\n{count} transactions\n{amount:C}";
                point.LegendText = $"{type} ({count})";
                series.Points.Add(point);
            }

            // Add series to chart
            chtSaleRefund.Series.Add(series);

            // Customize legend
            Legend legend = new Legend();
            legend.Title = "Transaction Types";
            legend.Docking = Docking.Right;
            legend.Font = new Font("Arial", 9,FontStyle.Bold);
            chtSaleRefund.Legends.Add(legend);

            // 3D effects
            chtSaleRefund.ChartAreas[0].Area3DStyle.Enable3D = true;
            chtSaleRefund.ChartAreas[0].Area3DStyle.Inclination = 30;
        }

        private void btnMostLeastBought_Click(object sender, EventArgs e)
        {
            // Clear existing elements
            chtLeastMostBoughtReports.Series.Clear();
            chtLeastMostBoughtReports.Titles.Clear();
            chtLeastMostBoughtReports.Legends.Clear();

            // Set chart title
            chtLeastMostBoughtReports.Titles.Add("Product Sales Funnel");
            chtLeastMostBoughtReports.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Get data from database
            WstGrp11DataSet dataset = new WstGrp11DataSet();
            dataset.EnforceConstraints = false;
            OrderLineTableAdapter orderLineTA = new OrderLineTableAdapter();
            DataTable dtProducts = dataset.OrderLine; // Temporary storage
            orderLineTA.FillByLeastAndMostBought(dataset.OrderLine);

            // Create funnel series
            Series series = new Series("Products");
            series.ChartType = SeriesChartType.Funnel;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#VALX\n#VALY items\n#PERCENT{P2} of total";
            series["FunnelStyle"] = "YIsWidth"; // Width represents quantity
            series["FunnelNeckHeight"] = "15"; // Narrow part at bottom
            series["FunnelNeckWidth"] = "15";
            series.Color = Color.SteelBlue;
            series.BorderWidth = 2;
            series.BorderColor = Color.White;

            // Add data points (top 10 products)
            int maxProductsToShow = 10;
            for (int i = 0; i < Math.Min(maxProductsToShow, dtProducts.Rows.Count); i++)
            {
                DataRow row = dtProducts.Rows[i];
                string productName = row["ProductName"].ToString();
                int quantity = Convert.ToInt32(row["TotalQuantitySold"]);
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(productName, quantity);
                point.Label = $"{productName}\n{quantity} sold\n{revenue:C}";
                point.LegendText = $"{productName} ({quantity})";
                point.Color = GetColorForPosition(i); // Color by position
                series.Points.Add(point);
            }

            // Add series to chart
            chtLeastMostBoughtReports.Series.Add(series);

            // Customize chart area
            chtLeastMostBoughtReports.ChartAreas[0].Area3DStyle.Enable3D = true;
            chtLeastMostBoughtReports.ChartAreas[0].Area3DStyle.Inclination = 15;
            chtLeastMostBoughtReports.ChartAreas[0].Area3DStyle.IsRightAngleAxes = false;

            // Add legend
            Legend legend = new Legend();
            legend.Title = "Top Products";
            legend.Docking = Docking.Right;
            legend.Font = new Font("Arial", 8);
            chtLeastMostBoughtReports.Legends.Add(legend);
        }
        private Color GetColorForPosition(int position)
        {
            // Gradient from green (most popular) to red (least popular)
            float ratio = position / 9f; // For top 10 items
            return Color.FromArgb(
                (int)(255 * (1 - ratio)),  // Red component decreases
                (int)(255 * ratio),        // Green component increases
                100                        // Constant blue
            );
        }

        private void btnSalesRefunds_Click(object sender, EventArgs e)
        {
            // Clear existing chart elements
            chtSaleRefund.Series.Clear();
            chtSaleRefund.Titles.Clear();
            chtSaleRefund.Legends.Clear();

            // Set chart title
            chtSaleRefund.Titles.Add("Sales vs Refunds");
            chtSaleRefund.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Get data from database

            WstGrp11DataSet dataset = new WstGrp11DataSet();
            dataset.EnforceConstraints = false;
            OrderTableAdapter orderTA = new OrderTableAdapter();
            DataTable dtTransactions = dataset.Order;
            orderTA.FillBySaleOrRefundReports(dataset.Order);




            // Create donut series
            Series series = new Series("TransactionTypes");
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#PERCENT{P1}"; // Show percentages
            series["DoughnutRadius"] = "60"; // 60% width (40% hole)
            series.BorderWidth = 2;
            series.BorderColor = Color.White;

            // Custom colors for transaction types
            Dictionary<string, Color> typeColors = new Dictionary<string, Color>()
{
    { "Sale", Color.Green },
    { "Refund", Color.Red }
};

            // Add data points
            foreach (DataRow row in dtTransactions.Rows)
            {
                string type = row["TransactionType"].ToString();
                int count = Convert.ToInt32(row["TransactionCount"]);
                decimal amount = Convert.ToDecimal(row["TotalAmount"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(type, count);
                point.Color = typeColors.ContainsKey(type) ? typeColors[type] : Color.Blue;
                point.Label = $"{type}\n{count} transactions\n{amount:C}";
                point.LegendText = $"{type} ({count})";
                series.Points.Add(point);
            }

            // Add series to chart
            chtSaleRefund.Series.Add(series);

            // Customize legend
            Legend legend = new Legend();
            legend.Title = "Transaction Types";
            legend.Docking = Docking.Right;
            legend.Font = new Font("Arial", 9, FontStyle.Bold);
            chtSaleRefund.Legends.Add(legend);

            // 3D effects
            chtSaleRefund.ChartAreas[0].Area3DStyle.Enable3D = true;
            chtSaleRefund.ChartAreas[0].Area3DStyle.Inclination = 30;
        }

        private void btnLeastMostBought_Click(object sender, EventArgs e)
        {
            // Clear existing elements
            chtLeastMostBoughtReports.Series.Clear();
            chtLeastMostBoughtReports.Titles.Clear();
            chtLeastMostBoughtReports.Legends.Clear();
            

            // Set chart title
            chtLeastMostBoughtReports.Titles.Add("Product Sales Funnel");
            chtLeastMostBoughtReports.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Get data from database
            WstGrp11DataSet dataset = new WstGrp11DataSet();
            dataset.EnforceConstraints = false;
            OrderLineTableAdapter orderLineTA = new OrderLineTableAdapter();
            DataTable dtProducts = dataset.OrderLine; // Temporary storage
            orderLineTA.FillByLeastAndMostBought(dataset.OrderLine);

            // Create funnel series
            Series series = new Series("Products");
            series.ChartType = SeriesChartType.Funnel;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#VALX\n#VALY items\n#PERCENT{P2} of total";
            series["FunnelStyle"] = "YIsWidth"; // Width represents quantity
            series["FunnelNeckHeight"] = "15"; // Narrow part at bottom
            series["FunnelNeckWidth"] = "15";
            series.Color = Color.SteelBlue;
            series.BorderWidth = 2;
            series.BorderColor = Color.White;

            // Add data points (top 10 products)
            int maxProductsToShow = 10;
            for (int i = 0; i < Math.Min(maxProductsToShow, dtProducts.Rows.Count); i++)
            {
                DataRow row = dtProducts.Rows[i];
                string productName = row["ProductName"].ToString();
                int quantity = Convert.ToInt32(row["TotalQuantitySold"]);
                decimal revenue = Convert.ToDecimal(row["TotalRevenue"]);

                DataPoint point = new DataPoint();
                point.SetValueXY(productName, quantity);
                point.Label = $"{productName}\n{quantity} sold\n{revenue:C}";
                point.LegendText = $"{productName} ({quantity})";
                point.Color = GetColorForPos(i); // Color by position
                series.Points.Add(point);
            }

            // Add series to chart
            chtLeastMostBoughtReports.Series.Add(series);

            // Customize chart area
            chtLeastMostBoughtReports.ChartAreas[0].Area3DStyle.Enable3D = true;
            chtLeastMostBoughtReports.ChartAreas[0].Area3DStyle.Inclination = 15;
            chtLeastMostBoughtReports.ChartAreas[0].Area3DStyle.IsRightAngleAxes = false;

            // Add legend
            Legend legend = new Legend();
            legend.Title = "Top Products";
            legend.Docking = Docking.Right;
            legend.Font = new Font("Arial", 8);
            chtLeastMostBoughtReports.Legends.Add(legend);
        }

        private Color GetColorForPos(int position)
        {
            // Gradient from green (most popular) to red (least popular)
            float ratio = position / 9f; // For top 10 items
            return Color.FromArgb(
                (int)(255 * (1 - ratio)),  // Red component decreases
                (int)(255 * ratio),        // Green component increases
                100                        // Constant blue
            );
        }

    }
}
