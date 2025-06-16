namespace Istn3ASproject
{
    partial class frmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.grpbxTransactionReport = new System.Windows.Forms.GroupBox();
            this.btnTransactionReports = new System.Windows.Forms.Button();
            this.chtTransactionTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxSalesReports = new System.Windows.Forms.GroupBox();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.cmbTotalSales = new System.Windows.Forms.ComboBox();
            this.chtTotalSalesDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxCustSales = new System.Windows.Forms.GroupBox();
            this.chtCustomerPerProvince = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCustPerProvince = new System.Windows.Forms.Button();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.tbpFinancial = new System.Windows.Forms.TabPage();
            this.labelFinancial10 = new System.Windows.Forms.Label();
            this.grpbFinancialLine = new System.Windows.Forms.GroupBox();
            this.chrtFinancialLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpFinancialChart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1Financial = new System.Windows.Forms.GroupBox();
            this.lblProfitFinancial = new System.Windows.Forms.Label();
            this.lblExpensesFinancial = new System.Windows.Forms.Label();
            this.lblIncomeFinancial = new System.Windows.Forms.Label();
            this.Financiallabel3 = new System.Windows.Forms.Label();
            this.Financiallabel2 = new System.Windows.Forms.Label();
            this.Financiallabel1 = new System.Windows.Forms.Label();
            this.btnRefreshFinancialGraph = new System.Windows.Forms.Button();
            this.label1Financial = new System.Windows.Forms.Label();
            this.cmbPeriodFinancial = new System.Windows.Forms.ComboBox();
            this.taSupplierOrderFinancial = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter();
            this.wstGrp11DataSet1 = new Istn3ASproject.WstGrp11DataSet();
            this.taOrderFinancial = new Istn3ASproject.WstGrp11DataSetTableAdapters.OrderTableAdapter();
            this.chrtFinancial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tcReports.SuspendLayout();
            this.tbpSales.SuspendLayout();
            this.grpbxTransactionReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTransactionTypes)).BeginInit();
            this.grpbxSalesReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalSalesDate)).BeginInit();
            this.grpbxCustSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPerProvince)).BeginInit();
            this.tbpFinancial.SuspendLayout();
            this.grpbFinancialLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancialLine)).BeginInit();
            this.groupBox1Financial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.tbpSales);
            this.tcReports.Controls.Add(this.tbpInventory);
            this.tcReports.Controls.Add(this.tbpFinancial);
            this.tcReports.Location = new System.Drawing.Point(0, 11);
            this.tcReports.Margin = new System.Windows.Forms.Padding(2);
            this.tcReports.Name = "tcReports";
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(2028, 761);
            this.tcReports.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Controls.Add(this.grpbxTransactionReport);
            this.tbpSales.Controls.Add(this.grpbxSalesReports);
            this.tbpSales.Controls.Add(this.grpbxCustSales);
            this.tbpSales.Location = new System.Drawing.Point(4, 25);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSales.Size = new System.Drawing.Size(1381, 732);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            // 
            // grpbxTransactionReport
            // 
            this.grpbxTransactionReport.Controls.Add(this.btnTransactionReports);
            this.grpbxTransactionReport.Controls.Add(this.chtTransactionTypes);
            this.grpbxTransactionReport.Location = new System.Drawing.Point(5, 460);
            this.grpbxTransactionReport.Name = "grpbxTransactionReport";
            this.grpbxTransactionReport.Size = new System.Drawing.Size(748, 186);
            this.grpbxTransactionReport.TabIndex = 5;
            this.grpbxTransactionReport.TabStop = false;
            this.grpbxTransactionReport.Text = "Transaction Types";
            // 
            // btnTransactionReports
            // 
            this.btnTransactionReports.Location = new System.Drawing.Point(618, 57);
            this.btnTransactionReports.Name = "btnTransactionReports";
            this.btnTransactionReports.Size = new System.Drawing.Size(75, 41);
            this.btnTransactionReports.TabIndex = 3;
            this.btnTransactionReports.Text = "Load Donut Chart";
            this.btnTransactionReports.UseVisualStyleBackColor = true;
            this.btnTransactionReports.Click += new System.EventHandler(this.btnTransactionReports_Click);
            // 
            // chtTransactionTypes
            // 
            chartArea16.Name = "ChartArea1";
            this.chtTransactionTypes.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chtTransactionTypes.Legends.Add(legend16);
            this.chtTransactionTypes.Location = new System.Drawing.Point(17, 19);
            this.chtTransactionTypes.Name = "chtTransactionTypes";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chtTransactionTypes.Series.Add(series19);
            this.chtTransactionTypes.Size = new System.Drawing.Size(540, 151);
            this.chtTransactionTypes.TabIndex = 0;
            this.chtTransactionTypes.Text = "Transaction Types";
            // 
            // grpbxSalesReports
            // 
            this.grpbxSalesReports.Controls.Add(this.btnSalesReport);
            this.grpbxSalesReports.Controls.Add(this.cmbTotalSales);
            this.grpbxSalesReports.Controls.Add(this.chtTotalSalesDate);
            this.grpbxSalesReports.Location = new System.Drawing.Point(8, 253);
            this.grpbxSalesReports.Name = "grpbxSalesReports";
            this.grpbxSalesReports.Size = new System.Drawing.Size(748, 186);
            this.grpbxSalesReports.TabIndex = 2;
            this.grpbxSalesReports.TabStop = false;
            this.grpbxSalesReports.Text = "Total Sales";
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(618, 57);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(75, 41);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "Load Pie Chart";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // cmbTotalSales
            // 
            this.cmbTotalSales.FormattingEnabled = true;
            this.cmbTotalSales.Items.AddRange(new object[] {
            "Day",
            "Month",
            "Year"});
            this.cmbTotalSales.Location = new System.Drawing.Point(563, 19);
            this.cmbTotalSales.Name = "cmbTotalSales";
            this.cmbTotalSales.Size = new System.Drawing.Size(179, 24);
            this.cmbTotalSales.TabIndex = 4;
            this.cmbTotalSales.Text = "Choose Per Day, Month or Year";
            // 
            // chtTotalSalesDate
            // 
            chartArea17.Name = "ChartArea1";
            this.chtTotalSalesDate.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chtTotalSalesDate.Legends.Add(legend17);
            this.chtTotalSalesDate.Location = new System.Drawing.Point(17, 19);
            this.chtTotalSalesDate.Name = "chtTotalSalesDate";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chtTotalSalesDate.Series.Add(series20);
            this.chtTotalSalesDate.Size = new System.Drawing.Size(540, 151);
            this.chtTotalSalesDate.TabIndex = 0;
            this.chtTotalSalesDate.Text = "chart1";
            // 
            // grpbxCustSales
            // 
            this.grpbxCustSales.Controls.Add(this.chtCustomerPerProvince);
            this.grpbxCustSales.Controls.Add(this.btnCustPerProvince);
            this.grpbxCustSales.Location = new System.Drawing.Point(8, 18);
            this.grpbxCustSales.Name = "grpbxCustSales";
            this.grpbxCustSales.Size = new System.Drawing.Size(748, 215);
            this.grpbxCustSales.TabIndex = 0;
            this.grpbxCustSales.TabStop = false;
            this.grpbxCustSales.Text = "Customers Per Province";
            // 
            // chtCustomerPerProvince
            // 
            chartArea18.Name = "ChartArea1";
            this.chtCustomerPerProvince.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chtCustomerPerProvince.Legends.Add(legend18);
            this.chtCustomerPerProvince.Location = new System.Drawing.Point(6, 19);
            this.chtCustomerPerProvince.Name = "chtCustomerPerProvince";
            series21.ChartArea = "ChartArea1";
            series21.Legend = "Legend1";
            series21.Name = "Series1";
            this.chtCustomerPerProvince.Series.Add(series21);
            this.chtCustomerPerProvince.Size = new System.Drawing.Size(624, 185);
            this.chtCustomerPerProvince.TabIndex = 0;
            // 
            // btnCustPerProvince
            // 
            this.btnCustPerProvince.Location = new System.Drawing.Point(639, 84);
            this.btnCustPerProvince.Name = "btnCustPerProvince";
            this.btnCustPerProvince.Size = new System.Drawing.Size(75, 41);
            this.btnCustPerProvince.TabIndex = 1;
            this.btnCustPerProvince.Text = "Load Bar Graph";
            this.btnCustPerProvince.UseVisualStyleBackColor = true;
            this.btnCustPerProvince.Click += new System.EventHandler(this.btnCustPerProvince_Click);
            // 
            // tbpInventory
            // 
            this.tbpInventory.Location = new System.Drawing.Point(4, 25);
            this.tbpInventory.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInventory.Size = new System.Drawing.Size(1381, 732);
            this.tbpInventory.TabIndex = 1;
            this.tbpInventory.Text = "Inventory";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // tbpFinancial
            // 
            this.tbpFinancial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpFinancial.Controls.Add(this.labelFinancial10);
            this.tbpFinancial.Controls.Add(this.grpbFinancialLine);
            this.tbpFinancial.Controls.Add(this.dtpFinancialChart);
            this.tbpFinancial.Controls.Add(this.groupBox1Financial);
            this.tbpFinancial.Location = new System.Drawing.Point(4, 25);
            this.tbpFinancial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpFinancial.Name = "tbpFinancial";
            this.tbpFinancial.Size = new System.Drawing.Size(2020, 732);
            this.tbpFinancial.TabIndex = 2;
            this.tbpFinancial.Text = "Financial";
            // 
            // labelFinancial10
            // 
            this.labelFinancial10.AutoSize = true;
            this.labelFinancial10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinancial10.Location = new System.Drawing.Point(759, 48);
            this.labelFinancial10.Name = "labelFinancial10";
            this.labelFinancial10.Size = new System.Drawing.Size(200, 29);
            this.labelFinancial10.TabIndex = 6;
            this.labelFinancial10.Text = "Filter by month :";
            // 
            // grpbFinancialLine
            // 
            this.grpbFinancialLine.Controls.Add(this.chrtFinancialLine);
            this.grpbFinancialLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbFinancialLine.Location = new System.Drawing.Point(759, 120);
            this.grpbFinancialLine.Name = "grpbFinancialLine";
            this.grpbFinancialLine.Size = new System.Drawing.Size(1173, 425);
            this.grpbFinancialLine.TabIndex = 5;
            this.grpbFinancialLine.TabStop = false;
            this.grpbFinancialLine.Text = "Monthly Financial Chart";
            // 
            // chrtFinancialLine
            // 
            chartArea19.Name = "ChartArea1";
            this.chrtFinancialLine.ChartAreas.Add(chartArea19);
            this.chrtFinancialLine.Dock = System.Windows.Forms.DockStyle.Fill;
            legend19.Name = "Legend1";
            this.chrtFinancialLine.Legends.Add(legend19);
            this.chrtFinancialLine.Location = new System.Drawing.Point(3, 30);
            this.chrtFinancialLine.Name = "chrtFinancialLine";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Legend = "Legend1";
            series22.Name = "income";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Legend = "Legend1";
            series23.Name = "expenses";
            this.chrtFinancialLine.Series.Add(series22);
            this.chrtFinancialLine.Series.Add(series23);
            this.chrtFinancialLine.Size = new System.Drawing.Size(1167, 392);
            this.chrtFinancialLine.TabIndex = 4;
            this.chrtFinancialLine.Text = "chart1";
            // 
            // dtpFinancialChart
            // 
            this.dtpFinancialChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinancialChart.Location = new System.Drawing.Point(759, 80);
            this.dtpFinancialChart.Name = "dtpFinancialChart";
            this.dtpFinancialChart.Size = new System.Drawing.Size(200, 34);
            this.dtpFinancialChart.TabIndex = 3;
            this.dtpFinancialChart.ValueChanged += new System.EventHandler(this.dtpFinancialChart_ValueChanged);
            // 
            // groupBox1Financial
            // 
            this.groupBox1Financial.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1Financial.Controls.Add(this.chrtFinancial);
            this.groupBox1Financial.Controls.Add(this.lblProfitFinancial);
            this.groupBox1Financial.Controls.Add(this.lblExpensesFinancial);
            this.groupBox1Financial.Controls.Add(this.lblIncomeFinancial);
            this.groupBox1Financial.Controls.Add(this.Financiallabel3);
            this.groupBox1Financial.Controls.Add(this.Financiallabel2);
            this.groupBox1Financial.Controls.Add(this.Financiallabel1);
            this.groupBox1Financial.Controls.Add(this.btnRefreshFinancialGraph);
            this.groupBox1Financial.Controls.Add(this.label1Financial);
            this.groupBox1Financial.Controls.Add(this.cmbPeriodFinancial);
            this.groupBox1Financial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1Financial.Location = new System.Drawing.Point(28, 129);
            this.groupBox1Financial.Name = "groupBox1Financial";
            this.groupBox1Financial.Size = new System.Drawing.Size(690, 429);
            this.groupBox1Financial.TabIndex = 2;
            this.groupBox1Financial.TabStop = false;
            this.groupBox1Financial.Text = "Profit to Loss Comparison";
            // 
            // lblProfitFinancial
            // 
            this.lblProfitFinancial.AutoSize = true;
            this.lblProfitFinancial.Location = new System.Drawing.Point(492, 384);
            this.lblProfitFinancial.Name = "lblProfitFinancial";
            this.lblProfitFinancial.Size = new System.Drawing.Size(95, 32);
            this.lblProfitFinancial.TabIndex = 10;
            this.lblProfitFinancial.Text = "R0.00";
            // 
            // lblExpensesFinancial
            // 
            this.lblExpensesFinancial.AutoSize = true;
            this.lblExpensesFinancial.Location = new System.Drawing.Point(492, 294);
            this.lblExpensesFinancial.Name = "lblExpensesFinancial";
            this.lblExpensesFinancial.Size = new System.Drawing.Size(95, 32);
            this.lblExpensesFinancial.TabIndex = 9;
            this.lblExpensesFinancial.Text = "R0.00";
            // 
            // lblIncomeFinancial
            // 
            this.lblIncomeFinancial.AutoSize = true;
            this.lblIncomeFinancial.Location = new System.Drawing.Point(492, 200);
            this.lblIncomeFinancial.Name = "lblIncomeFinancial";
            this.lblIncomeFinancial.Size = new System.Drawing.Size(95, 32);
            this.lblIncomeFinancial.TabIndex = 8;
            this.lblIncomeFinancial.Text = "R0.00";
            // 
            // Financiallabel3
            // 
            this.Financiallabel3.AutoSize = true;
            this.Financiallabel3.Location = new System.Drawing.Point(464, 340);
            this.Financiallabel3.Name = "Financiallabel3";
            this.Financiallabel3.Size = new System.Drawing.Size(220, 32);
            this.Financiallabel3.TabIndex = 7;
            this.Financiallabel3.Text = "Profit Margins :";
            // 
            // Financiallabel2
            // 
            this.Financiallabel2.AutoSize = true;
            this.Financiallabel2.Location = new System.Drawing.Point(464, 248);
            this.Financiallabel2.Name = "Financiallabel2";
            this.Financiallabel2.Size = new System.Drawing.Size(198, 32);
            this.Financiallabel2.TabIndex = 6;
            this.Financiallabel2.Text = "Expenenses :";
            // 
            // Financiallabel1
            // 
            this.Financiallabel1.AutoSize = true;
            this.Financiallabel1.Location = new System.Drawing.Point(492, 157);
            this.Financiallabel1.Name = "Financiallabel1";
            this.Financiallabel1.Size = new System.Drawing.Size(129, 32);
            this.Financiallabel1.TabIndex = 5;
            this.Financiallabel1.Text = "Income :";
            // 
            // btnRefreshFinancialGraph
            // 
            this.btnRefreshFinancialGraph.Location = new System.Drawing.Point(536, 34);
            this.btnRefreshFinancialGraph.Name = "btnRefreshFinancialGraph";
            this.btnRefreshFinancialGraph.Size = new System.Drawing.Size(154, 42);
            this.btnRefreshFinancialGraph.TabIndex = 4;
            this.btnRefreshFinancialGraph.Text = "Refresh Financial Graph";
            this.btnRefreshFinancialGraph.UseVisualStyleBackColor = true;
            this.btnRefreshFinancialGraph.Click += new System.EventHandler(this.btnRefreshFinancialGraph_Click);
            // 
            // label1Financial
            // 
            this.label1Financial.AutoSize = true;
            this.label1Financial.Location = new System.Drawing.Point(6, 41);
            this.label1Financial.Name = "label1Financial";
            this.label1Financial.Size = new System.Drawing.Size(304, 32);
            this.label1Financial.TabIndex = 3;
            this.label1Financial.Text = "Choose Time Frame :";
            this.label1Financial.Click += new System.EventHandler(this.label1Financial_Click);
            // 
            // cmbPeriodFinancial
            // 
            this.cmbPeriodFinancial.FormattingEnabled = true;
            this.cmbPeriodFinancial.Items.AddRange(new object[] {
            "Lifetime",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cmbPeriodFinancial.Location = new System.Drawing.Point(366, 34);
            this.cmbPeriodFinancial.Name = "cmbPeriodFinancial";
            this.cmbPeriodFinancial.Size = new System.Drawing.Size(164, 39);
            this.cmbPeriodFinancial.TabIndex = 2;
            this.cmbPeriodFinancial.Text = "Lifetime";
            // 
            // taSupplierOrderFinancial
            // 
            this.taSupplierOrderFinancial.ClearBeforeFill = true;
            // 
            // wstGrp11DataSet1
            // 
            this.wstGrp11DataSet1.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taOrderFinancial
            // 
            this.taOrderFinancial.ClearBeforeFill = true;
            // 
            // chrtFinancial
            // 
            chartArea20.Name = "ChartArea1";
            this.chrtFinancial.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chrtFinancial.Legends.Add(legend20);
            this.chrtFinancial.Location = new System.Drawing.Point(23, 106);
            this.chrtFinancial.Name = "chrtFinancial";
            series24.ChartArea = "ChartArea1";
            series24.Legend = "Legend1";
            series24.Name = "Money Flow";
            this.chrtFinancial.Series.Add(series24);
            this.chrtFinancial.Size = new System.Drawing.Size(366, 300);
            this.chrtFinancial.TabIndex = 11;
            this.chrtFinancial.Text = "Financial chart";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1942, 783);
            this.Controls.Add(this.tcReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tcReports.ResumeLayout(false);
            this.tbpSales.ResumeLayout(false);
            this.grpbxTransactionReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtTransactionTypes)).EndInit();
            this.grpbxSalesReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalSalesDate)).EndInit();
            this.grpbxCustSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPerProvince)).EndInit();
            this.tbpFinancial.ResumeLayout(false);
            this.tbpFinancial.PerformLayout();
            this.grpbFinancialLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancialLine)).EndInit();
            this.groupBox1Financial.ResumeLayout(false);
            this.groupBox1Financial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.TabPage tbpSales;
        private System.Windows.Forms.TabPage tbpInventory;
        private System.Windows.Forms.TabPage tbpFinancial;
        private System.Windows.Forms.GroupBox grpbxCustSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCustomerPerProvince;
        private System.Windows.Forms.Button btnCustPerProvince;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.GroupBox grpbxSalesReports;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTotalSalesDate;
        private System.Windows.Forms.ComboBox cmbTotalSales;
        private System.Windows.Forms.GroupBox grpbxTransactionReport;
        private System.Windows.Forms.Button btnTransactionReports;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTransactionTypes;
        private System.Windows.Forms.GroupBox grpbxSalesRefund;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtSalesRefund;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalesRefundsReports;
        private System.Windows.Forms.GroupBox grpbxMostBoughtLeastBought;
        private System.Windows.Forms.Button btnMostLeastBought;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtLeastMostBought;
        private WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter taSupplierOrderFinancial;
        private WstGrp11DataSet wstGrp11DataSet1;
        private WstGrp11DataSetTableAdapters.OrderTableAdapter taOrderFinancial;
        private System.Windows.Forms.GroupBox groupBox1Financial;
        private System.Windows.Forms.ComboBox cmbPeriodFinancial;
        private System.Windows.Forms.Label label1Financial;
        private System.Windows.Forms.Button btnRefreshFinancialGraph;
        private System.Windows.Forms.Label lblProfitFinancial;
        private System.Windows.Forms.Label lblExpensesFinancial;
        private System.Windows.Forms.Label lblIncomeFinancial;
        private System.Windows.Forms.Label Financiallabel3;
        private System.Windows.Forms.Label Financiallabel2;
        private System.Windows.Forms.Label Financiallabel1;
        private System.Windows.Forms.DateTimePicker dtpFinancialChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFinancialLine;
        private System.Windows.Forms.GroupBox grpbFinancialLine;
        private System.Windows.Forms.Label labelFinancial10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFinancial;
    }
}