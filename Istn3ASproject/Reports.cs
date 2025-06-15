using Istn3ASproject.WstGrp11DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Istn3ASproject
{
    public partial class frmReports: Form
    {
        //private Istn3ASproject.WstGrp11DataSet WSTGRP11DataSet;
        //DataSet dataSet = new Istn3ASproject.WstGrp11DataSet();
        public frmReports()
        {
            InitializeComponent();
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
}
