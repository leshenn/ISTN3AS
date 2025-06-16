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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.grpbxTransactionReport = new System.Windows.Forms.GroupBox();
            this.btnTransactionReports = new System.Windows.Forms.Button();
            this.chtTransactionTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpbxSalesReports = new System.Windows.Forms.GroupBox();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.cmbTotalSales = new System.Windows.Forms.ComboBox();
            this.chtTotalSalesDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCustPerProvince = new System.Windows.Forms.Button();
            this.grpbxCustSales = new System.Windows.Forms.GroupBox();
            this.chtCustomerPerProvince = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.tbpFinancial = new System.Windows.Forms.TabPage();
            this.grpbxSalesRefund = new System.Windows.Forms.GroupBox();
            this.chtSalesRefund = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesRefundsReports = new System.Windows.Forms.Button();
            this.grpbxMostBoughtLeastBought = new System.Windows.Forms.GroupBox();
            this.chtLeastMostBought = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnMostLeastBought = new System.Windows.Forms.Button();
            this.tcReports.SuspendLayout();
            this.tbpSales.SuspendLayout();
            this.grpbxTransactionReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTransactionTypes)).BeginInit();
            this.grpbxSalesReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalSalesDate)).BeginInit();
            this.grpbxCustSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPerProvince)).BeginInit();
            this.grpbxSalesRefund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtSalesRefund)).BeginInit();
            this.grpbxMostBoughtLeastBought.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtLeastMostBought)).BeginInit();
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
            this.tcReports.Size = new System.Drawing.Size(1389, 761);
            this.tcReports.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Controls.Add(this.grpbxMostBoughtLeastBought);
            this.tbpSales.Controls.Add(this.grpbxSalesRefund);
            this.tbpSales.Controls.Add(this.grpbxTransactionReport);
            this.tbpSales.Controls.Add(this.grpbxSalesReports);
            this.tbpSales.Controls.Add(this.grpbxCustSales);
            this.tbpSales.Location = new System.Drawing.Point(4, 22);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSales.Size = new System.Drawing.Size(1381, 735);
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
            chartArea3.Name = "ChartArea1";
            this.chtTransactionTypes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtTransactionTypes.Legends.Add(legend3);
            this.chtTransactionTypes.Location = new System.Drawing.Point(17, 19);
            this.chtTransactionTypes.Name = "chtTransactionTypes";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtTransactionTypes.Series.Add(series3);
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
            this.cmbTotalSales.Size = new System.Drawing.Size(179, 21);
            this.cmbTotalSales.TabIndex = 4;
            this.cmbTotalSales.Text = "Choose Per Day, Month or Year";
            // 
            // chtTotalSalesDate
            // 
            chartArea4.Name = "ChartArea1";
            this.chtTotalSalesDate.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtTotalSalesDate.Legends.Add(legend4);
            this.chtTotalSalesDate.Location = new System.Drawing.Point(17, 19);
            this.chtTotalSalesDate.Name = "chtTotalSalesDate";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtTotalSalesDate.Series.Add(series4);
            this.chtTotalSalesDate.Size = new System.Drawing.Size(540, 151);
            this.chtTotalSalesDate.TabIndex = 0;
            this.chtTotalSalesDate.Text = "chart1";
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
            chartArea5.Name = "ChartArea1";
            this.chtCustomerPerProvince.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chtCustomerPerProvince.Legends.Add(legend5);
            this.chtCustomerPerProvince.Location = new System.Drawing.Point(6, 19);
            this.chtCustomerPerProvince.Name = "chtCustomerPerProvince";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chtCustomerPerProvince.Series.Add(series5);
            this.chtCustomerPerProvince.Size = new System.Drawing.Size(624, 185);
            this.chtCustomerPerProvince.TabIndex = 0;
            // 
            // tbpInventory
            // 
            this.tbpInventory.Location = new System.Drawing.Point(4, 22);
            this.tbpInventory.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInventory.Size = new System.Drawing.Size(764, 735);
            this.tbpInventory.TabIndex = 1;
            this.tbpInventory.Text = "Inventory";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // tbpFinancial
            // 
            this.tbpFinancial.Location = new System.Drawing.Point(4, 22);
            this.tbpFinancial.Margin = new System.Windows.Forms.Padding(2);
            this.tbpFinancial.Name = "tbpFinancial";
            this.tbpFinancial.Size = new System.Drawing.Size(764, 735);
            this.tbpFinancial.TabIndex = 2;
            this.tbpFinancial.Text = "Financial";
            this.tbpFinancial.UseVisualStyleBackColor = true;
            // 
            // grpbxSalesRefund
            // 
            this.grpbxSalesRefund.Controls.Add(this.btnSalesRefundsReports);
            this.grpbxSalesRefund.Controls.Add(this.chtSalesRefund);
            this.grpbxSalesRefund.Controls.Add(this.button1);
            this.grpbxSalesRefund.Location = new System.Drawing.Point(777, 27);
            this.grpbxSalesRefund.Name = "grpbxSalesRefund";
            this.grpbxSalesRefund.Size = new System.Drawing.Size(579, 215);
            this.grpbxSalesRefund.TabIndex = 2;
            this.grpbxSalesRefund.TabStop = false;
            this.grpbxSalesRefund.Text = "Sales vs. Refunds";
            // 
            // chtSalesRefund
            // 
            chartArea2.Name = "ChartArea1";
            this.chtSalesRefund.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtSalesRefund.Legends.Add(legend2);
            this.chtSalesRefund.Location = new System.Drawing.Point(6, 19);
            this.chtSalesRefund.Name = "chtSalesRefund";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtSalesRefund.Series.Add(series2);
            this.chtSalesRefund.Size = new System.Drawing.Size(567, 185);
            this.chtSalesRefund.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Bar Graph";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalesRefundsReports
            // 
            this.btnSalesRefundsReports.Location = new System.Drawing.Point(474, 101);
            this.btnSalesRefundsReports.Name = "btnSalesRefundsReports";
            this.btnSalesRefundsReports.Size = new System.Drawing.Size(75, 41);
            this.btnSalesRefundsReports.TabIndex = 2;
            this.btnSalesRefundsReports.Text = "Load Donut Chart";
            this.btnSalesRefundsReports.UseVisualStyleBackColor = true;
            this.btnSalesRefundsReports.Click += new System.EventHandler(this.btnSalesRefundsReports_Click);
            // 
            // grpbxMostBoughtLeastBought
            // 
            this.grpbxMostBoughtLeastBought.Controls.Add(this.btnMostLeastBought);
            this.grpbxMostBoughtLeastBought.Controls.Add(this.chtLeastMostBought);
            this.grpbxMostBoughtLeastBought.Location = new System.Drawing.Point(777, 262);
            this.grpbxMostBoughtLeastBought.Name = "grpbxMostBoughtLeastBought";
            this.grpbxMostBoughtLeastBought.Size = new System.Drawing.Size(579, 465);
            this.grpbxMostBoughtLeastBought.TabIndex = 6;
            this.grpbxMostBoughtLeastBought.TabStop = false;
            this.grpbxMostBoughtLeastBought.Text = "Most vs. Least Bought Products";
            // 
            // chtLeastMostBought
            // 
            chartArea1.Name = "ChartArea1";
            this.chtLeastMostBought.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtLeastMostBought.Legends.Add(legend1);
            this.chtLeastMostBought.Location = new System.Drawing.Point(16, 19);
            this.chtLeastMostBought.Name = "chtLeastMostBought";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtLeastMostBought.Series.Add(series1);
            this.chtLeastMostBought.Size = new System.Drawing.Size(533, 407);
            this.chtLeastMostBought.TabIndex = 0;
            this.chtLeastMostBought.Text = "chart1";
            // 
            // btnMostLeastBought
            // 
            this.btnMostLeastBought.Location = new System.Drawing.Point(244, 442);
            this.btnMostLeastBought.Name = "btnMostLeastBought";
            this.btnMostLeastBought.Size = new System.Drawing.Size(110, 23);
            this.btnMostLeastBought.TabIndex = 1;
            this.btnMostLeastBought.Text = "Load Funnel Chart";
            this.btnMostLeastBought.UseVisualStyleBackColor = true;
            this.btnMostLeastBought.Click += new System.EventHandler(this.btnMostLeastBought_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1386, 783);
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
            this.grpbxSalesRefund.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtSalesRefund)).EndInit();
            this.grpbxMostBoughtLeastBought.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtLeastMostBought)).EndInit();
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
    }
}