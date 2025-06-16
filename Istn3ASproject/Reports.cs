using Istn3ASproject.WstGrp11DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Istn3ASproject
{
    public partial class frmReports : Form
    {
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
        private int stockID;

        private void frmReports_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'wstGrp11DataSet.ExpiredStock' table. You can move, or remove it, as needed.
            //wstGrp11DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'wstGrp11DataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.wstGrp11DataSet.Stock);
           
            

        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            try
            {
                wstGrp11DataSet.EnforceConstraints = false;
                stockTableAdapter.FillByLowStock(wstGrp11DataSet.Stock);
                wstGrp11DataSet.EnforceConstraints = true;
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Constraint issue: " + ex.Message);
            }
        }

        private void btnExpiredStock_Click(object sender, EventArgs e)
        {
            try
            {
                taExpiredStock.FillBy(wstGrp11DataSet.ExpiredStock);
                Console.WriteLine("Loaded");
            }
            catch (ConstraintException ex)
            {
                // Log, show message, or inspect dataset
                foreach (DataRow row in wstGrp11DataSet.ExpiredStock.Rows)
                {
                    if (row.HasErrors)
                        Console.WriteLine(row.RowError);
                }
            }

        }


       
          

    
        private void LoadStockChart(int stockID)


        {
            
            chartStockTrends.Series.Clear();
            SupplierLineOrderTableAdapter supplierLineOrderTableAdapter = new SupplierLineOrderTableAdapter();
            SupplierOrderTableAdapter supplierOrderTableAdapter = new SupplierOrderTableAdapter();
            supplierLineOrderTableAdapter.Fill(wstGrp11DataSet.SupplierLineOrder);
            supplierOrderTableAdapter.Fill(wstGrp11DataSet.SupplierOrder);

            OrderLineTableAdapter orderLineTableAdapter = new OrderLineTableAdapter();
            OrderTableAdapter orderTable = new OrderTableAdapter();
            orderLineTableAdapter.Fill(wstGrp11DataSet.OrderLine);
            orderTable.Fill(wstGrp11DataSet.Order);

            // Clear old points

            List<(DateTime Date, int Quantity, string Type)> allTransactions = new List<(DateTime, int, string)>();


            // Loop through SupplierLineOrder
            for (int i = 0; i < wstGrp11DataSet.SupplierLineOrder.Rows.Count; i++)
            {
                int currentStockID = Convert.ToInt32(wstGrp11DataSet.SupplierLineOrder.Rows[i]["StockID"]);
                if (currentStockID == stockID)
                {
                    int supplierOrderID = Convert.ToInt32(wstGrp11DataSet.SupplierLineOrder.Rows[i]["SupplierOrderID"]);
                    int quantity = Convert.ToInt32(wstGrp11DataSet.SupplierLineOrder.Rows[i]["Quantity"]);

                    // Now look for the matching arrival date in SupplierOrder
                    for (int j = 0; j < wstGrp11DataSet.SupplierOrder.Rows.Count; j++)
                    {
                        int currentSupplierOrderID = Convert.ToInt32(wstGrp11DataSet.SupplierOrder.Rows[j]["SupplierOrderID"]);
                        if (currentSupplierOrderID == supplierOrderID)
                        {
                            DateTime date = Convert.ToDateTime(wstGrp11DataSet.SupplierOrder.Rows[j]["ArrivalDate"]);

                            allTransactions.Add((date, quantity, "Purchase"));
                            break; 
                        }
                    }
                }
            }
            for (int i = 0; i < wstGrp11DataSet.OrderLine.Rows.Count; i++)
            {
                if (Convert.ToInt32(wstGrp11DataSet.OrderLine.Rows[i]["StockID"]) == stockID)
                {
                    int orderID = Convert.ToInt32(wstGrp11DataSet.OrderLine.Rows[i]["OrderID"]);

                    // Find the order date from the Order table
                    for (int j = 0; j < wstGrp11DataSet.Order.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(wstGrp11DataSet.Order.Rows[j]["OrderID"]) == orderID)
                        {
                            DateTime saleDate = Convert.ToDateTime(wstGrp11DataSet.Order.Rows[j]["Date"]);
                            int saleQty = Convert.ToInt32(wstGrp11DataSet.OrderLine.Rows[i]["Quantity"]);

                            allTransactions.Add((saleDate, saleQty, "Sale"));
                            break;
                        }
                    }
                }
            }
           

  
            

            Series purchaseSeries = new Series("Purchases")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Green
            };

            Series saleSeries = new Series("Sales")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                Color = Color.Red
            };
            foreach (var t in allTransactions.OrderBy(t => t.Date))
            {
                if (t.Type == "Purchase")
                    purchaseSeries.Points.AddXY(t.Date.ToShortDateString(), t.Quantity);
                else if (t.Type == "Sale")
                    saleSeries.Points.AddXY(t.Date.ToShortDateString(), t.Quantity);
            }
            chartStockTrends.Series.Clear();
            chartStockTrends.Series.Add(purchaseSeries);
            chartStockTrends.Series.Add(saleSeries);
            chartStockTrends.ChartAreas[0].AxisX.Interval = 5;
          
            chartStockTrends.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Optional: better spacing




        }



        private void btnChart_Click(object sender, EventArgs e)
        {
            
            LoadStockChart(stockID);
        }

        private void dvgInventory1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            chartStockTrends.Series.Clear();
            stockID = Convert.ToInt32(dvgInventory1.CurrentRow.Cells[0].Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.stockTableAdapter.Fill(this.wstGrp11DataSet.Stock);
        }
    }
}
