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

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.tcReports = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chartStockTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.gbExpiredStock = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.btnExpiredStock = new System.Windows.Forms.Button();
            this.gbLowStock = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLowStock = new System.Windows.Forms.Button();
            this.dvgInventory1 = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbpFinancial = new System.Windows.Forms.TabPage();

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
            this.chrtFinancial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.taSupplierOrderFinancial = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter();
            this.wstGrp11DataSet1 = new Istn3ASproject.WstGrp11DataSet();
            this.taOrderFinancial = new Istn3ASproject.WstGrp11DataSetTableAdapters.OrderTableAdapter();
            this.labelFinancial10 = new System.Windows.Forms.Label();
            this.tcReports.SuspendLayout();
            this.tbpFinancial.SuspendLayout();
            this.grpbFinancialLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancialLine)).BeginInit();
            this.groupBox1Financial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet1)).BeginInit();

            this.stockTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StockTableAdapter();
            this.taExpiredStock = new Istn3ASproject.WstGrp11DataSetTableAdapters.taExpiredStock();
            this.tcReports.SuspendLayout();
            this.tbpInventory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStockTrends)).BeginInit();
            this.gbExpiredStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            this.gbLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInventory1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.tbpSales);
            this.tcReports.Controls.Add(this.tbpInventory);
            this.tcReports.Controls.Add(this.tbpFinancial);
            this.tcReports.Location = new System.Drawing.Point(0, 0);
            this.tcReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcReports.Name = "tcReports";
            this.tcReports.SelectedIndex = 0;
            

            this.tcReports.Size = new System.Drawing.Size(1525, 688);

            this.tcReports.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Location = new System.Drawing.Point(4, 25);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);


            this.tbpSales.Size = new System.Drawing.Size(1517, 659);

            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            // 
            // tbpInventory
            // 

            this.tbpInventory.Controls.Add(this.groupBox1);
            this.tbpInventory.Controls.Add(this.gbExpiredStock);
            this.tbpInventory.Controls.Add(this.gbLowStock);

            this.tbpInventory.Location = new System.Drawing.Point(4, 25);
            this.tbpInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);

    
            this.tbpInventory.Size = new System.Drawing.Size(1517, 659);

            this.tbpInventory.TabIndex = 1;
            this.tbpInventory.Text = "Inventory";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartStockTrends);
            this.groupBox1.Controls.Add(this.btnChart);
            this.groupBox1.Location = new System.Drawing.Point(6, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 321);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity of Purchases vs Quantity of Sales";
            // 
            // chartStockTrends
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStockTrends.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStockTrends.Legends.Add(legend2);
            this.chartStockTrends.Location = new System.Drawing.Point(25, 27);
            this.chartStockTrends.Name = "chartStockTrends";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStockTrends.Series.Add(series2);
            this.chartStockTrends.Size = new System.Drawing.Size(845, 294);
            this.chartStockTrends.TabIndex = 4;
            this.chartStockTrends.Text = "chartStockTrends";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(889, 36);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(107, 40);
            this.btnChart.TabIndex = 8;
            this.btnChart.Text = "Generate";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // gbExpiredStock
            // 
            this.gbExpiredStock.Controls.Add(this.dataGridView1);
            this.gbExpiredStock.Controls.Add(this.btnExpiredStock);
            this.gbExpiredStock.Location = new System.Drawing.Point(971, 25);
            this.gbExpiredStock.Name = "gbExpiredStock";
            this.gbExpiredStock.Size = new System.Drawing.Size(679, 278);
            this.gbExpiredStock.TabIndex = 2;
            this.gbExpiredStock.TabStop = false;
            this.gbExpiredStock.Text = "Expired Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expiredStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(531, 197);
            this.dataGridView1.TabIndex = 3;
            // 
            // stockIDDataGridViewTextBoxColumn1
            // 
            this.stockIDDataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn1.Name = "stockIDDataGridViewTextBoxColumn1";
            this.stockIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // expiredStockBindingSource
            // 
            this.expiredStockBindingSource.DataMember = "ExpiredStock";
            this.expiredStockBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnExpiredStock
            // 
            this.btnExpiredStock.Location = new System.Drawing.Point(204, 224);
            this.btnExpiredStock.Name = "btnExpiredStock";
            this.btnExpiredStock.Size = new System.Drawing.Size(164, 36);
            this.btnExpiredStock.TabIndex = 2;
            this.btnExpiredStock.Text = "Expired Stock";
            this.btnExpiredStock.UseVisualStyleBackColor = true;
            this.btnExpiredStock.Click += new System.EventHandler(this.btnExpiredStock_Click);
            // 
            // gbLowStock
            // 
            this.gbLowStock.Controls.Add(this.btnRefresh);
            this.gbLowStock.Controls.Add(this.btnLowStock);
            this.gbLowStock.Controls.Add(this.dvgInventory1);
            this.gbLowStock.Location = new System.Drawing.Point(8, 20);
            this.gbLowStock.Name = "gbLowStock";
            this.gbLowStock.Size = new System.Drawing.Size(957, 283);
            this.gbLowStock.TabIndex = 9;
            this.gbLowStock.TabStop = false;
            this.gbLowStock.Text = "Low Stock";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(609, 244);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 30);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLowStock
            // 
            this.btnLowStock.Location = new System.Drawing.Point(765, 241);
            this.btnLowStock.Name = "btnLowStock";
            this.btnLowStock.Size = new System.Drawing.Size(164, 36);
            this.btnLowStock.TabIndex = 1;
            this.btnLowStock.Text = "Check Low Stock";
            this.btnLowStock.UseVisualStyleBackColor = true;
            this.btnLowStock.Click += new System.EventHandler(this.btnLowStock_Click);
            // 
            // dvgInventory1
            // 
            this.dvgInventory1.AutoGenerateColumns = false;
            this.dvgInventory1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgInventory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInventory1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.poductDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.expirationTimeDataGridViewTextBoxColumn});
            this.dvgInventory1.DataSource = this.stockBindingSource;
            this.dvgInventory1.Location = new System.Drawing.Point(6, 38);
            this.dvgInventory1.Name = "dvgInventory1";
            this.dvgInventory1.RowHeadersWidth = 51;
            this.dvgInventory1.RowTemplate.Height = 24;
            this.dvgInventory1.Size = new System.Drawing.Size(942, 194);
            this.dvgInventory1.TabIndex = 0;
            this.dvgInventory1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgInventory1_RowHeaderMouseDoubleClick);
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // poductDescriptionDataGridViewTextBoxColumn
            // 
            this.poductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.HeaderText = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn.Name = "poductDescriptionDataGridViewTextBoxColumn";
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            // 
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // expirationTimeDataGridViewTextBoxColumn
            // 
            this.expirationTimeDataGridViewTextBoxColumn.DataPropertyName = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.HeaderText = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationTimeDataGridViewTextBoxColumn.Name = "expirationTimeDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DataSet;
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
            this.tbpFinancial.Size = new System.Drawing.Size(792, 421);

            this.tbpFinancial.TabIndex = 2;
            this.tbpFinancial.Text = "Financial";
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
            chartArea6.Name = "ChartArea1";
            this.chrtFinancialLine.ChartAreas.Add(chartArea6);
            this.chrtFinancialLine.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chrtFinancialLine.Legends.Add(legend6);
            this.chrtFinancialLine.Location = new System.Drawing.Point(3, 30);
            this.chrtFinancialLine.Name = "chrtFinancialLine";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "income";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "expenses";
            this.chrtFinancialLine.Series.Add(series8);
            this.chrtFinancialLine.Series.Add(series9);
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
            this.groupBox1Financial.Controls.Add(this.lblProfitFinancial);
            this.groupBox1Financial.Controls.Add(this.lblExpensesFinancial);
            this.groupBox1Financial.Controls.Add(this.lblIncomeFinancial);
            this.groupBox1Financial.Controls.Add(this.Financiallabel3);
            this.groupBox1Financial.Controls.Add(this.Financiallabel2);
            this.groupBox1Financial.Controls.Add(this.Financiallabel1);
            this.groupBox1Financial.Controls.Add(this.btnRefreshFinancialGraph);
            this.groupBox1Financial.Controls.Add(this.label1Financial);
            this.groupBox1Financial.Controls.Add(this.cmbPeriodFinancial);
            this.groupBox1Financial.Controls.Add(this.chrtFinancial);
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
            // chrtFinancial
            // 
            this.chrtFinancial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chrtFinancial.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.chrtFinancial.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chrtFinancial.Legends.Add(legend5);
            this.chrtFinancial.Location = new System.Drawing.Point(29, 92);
            this.chrtFinancial.Name = "chrtFinancial";
            this.chrtFinancial.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Money Flow";
            this.chrtFinancial.Series.Add(series7);
            this.chrtFinancial.Size = new System.Drawing.Size(615, 331);
            this.chrtFinancial.TabIndex = 1;
            this.chrtFinancial.Text = "Financial Chart";
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
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // taExpiredStock
            // 
            this.taExpiredStock.ClearBeforeFill = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;


            this.ClientSize = new System.Drawing.Size(1525, 688);

            this.Controls.Add(this.tcReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tcReports.ResumeLayout(false);

            this.tbpFinancial.ResumeLayout(false);
            this.tbpFinancial.PerformLayout();
            this.grpbFinancialLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancialLine)).EndInit();
            this.groupBox1Financial.ResumeLayout(false);
            this.groupBox1Financial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFinancial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet1)).EndInit();

            this.tbpInventory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStockTrends)).EndInit();
            this.gbExpiredStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expiredStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            this.gbLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgInventory1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.TabPage tbpSales;
        private System.Windows.Forms.TabPage tbpInventory;
        private System.Windows.Forms.TabPage tbpFinancial;

        private WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter taSupplierOrderFinancial;
        private WstGrp11DataSet wstGrp11DataSet1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFinancial;
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

        private System.Windows.Forms.DataGridView dvgInventory1;
       
        private System.Windows.Forms.BindingSource stockBindingSource;
        private WstGrp11DataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLowStock;
        private System.Windows.Forms.Button btnExpiredStock;
        private WstGrp11DataSetTableAdapters.taExpiredStock taExpiredStock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource expiredStockBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStockTrends;
        
       
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.GroupBox gbLowStock;
        private System.Windows.Forms.GroupBox gbExpiredStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;

    }
}