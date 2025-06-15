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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.btnCustPerProvince = new System.Windows.Forms.Button();
            this.grpbxCustSales = new System.Windows.Forms.GroupBox();
            this.chtCustomerPerProvince = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.tbpFinancial = new System.Windows.Forms.TabPage();
            this.grpbxSalesReports = new System.Windows.Forms.GroupBox();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.chtTotalSalesDate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbTotalSales = new System.Windows.Forms.ComboBox();
            this.tcReports.SuspendLayout();
            this.tbpSales.SuspendLayout();
            this.grpbxCustSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPerProvince)).BeginInit();
            this.grpbxSalesReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalSalesDate)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.tbpSales);
            this.tcReports.Controls.Add(this.tbpInventory);
            this.tcReports.Controls.Add(this.tbpFinancial);
            this.tcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcReports.Location = new System.Drawing.Point(0, 0);
            this.tcReports.Margin = new System.Windows.Forms.Padding(2);
            this.tcReports.Name = "tcReports";
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(772, 582);
            this.tcReports.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Controls.Add(this.grpbxSalesReports);
            this.tbpSales.Controls.Add(this.btnCustPerProvince);
            this.tbpSales.Controls.Add(this.grpbxCustSales);
            this.tbpSales.Location = new System.Drawing.Point(4, 22);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSales.Size = new System.Drawing.Size(764, 556);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            // 
            // btnCustPerProvince
            // 
            this.btnCustPerProvince.Location = new System.Drawing.Point(665, 102);
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
            this.grpbxCustSales.Location = new System.Drawing.Point(8, 18);
            this.grpbxCustSales.Name = "grpbxCustSales";
            this.grpbxCustSales.Size = new System.Drawing.Size(636, 215);
            this.grpbxCustSales.TabIndex = 0;
            this.grpbxCustSales.TabStop = false;
            this.grpbxCustSales.Text = "Customers Per Province";
            // 
            // chtCustomerPerProvince
            // 
            chartArea4.Name = "ChartArea1";
            this.chtCustomerPerProvince.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtCustomerPerProvince.Legends.Add(legend4);
            this.chtCustomerPerProvince.Location = new System.Drawing.Point(6, 19);
            this.chtCustomerPerProvince.Name = "chtCustomerPerProvince";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtCustomerPerProvince.Series.Add(series4);
            this.chtCustomerPerProvince.Size = new System.Drawing.Size(624, 185);
            this.chtCustomerPerProvince.TabIndex = 0;
            // 
            // tbpInventory
            // 
            this.tbpInventory.Location = new System.Drawing.Point(4, 22);
            this.tbpInventory.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInventory.Size = new System.Drawing.Size(686, 556);
            this.tbpInventory.TabIndex = 1;
            this.tbpInventory.Text = "Inventory";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // tbpFinancial
            // 
            this.tbpFinancial.Location = new System.Drawing.Point(4, 22);
            this.tbpFinancial.Margin = new System.Windows.Forms.Padding(2);
            this.tbpFinancial.Name = "tbpFinancial";
            this.tbpFinancial.Size = new System.Drawing.Size(686, 556);
            this.tbpFinancial.TabIndex = 2;
            this.tbpFinancial.Text = "Financial";
            this.tbpFinancial.UseVisualStyleBackColor = true;
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
            this.btnSalesReport.Text = "Load Bar Graph";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // chtTotalSalesDate
            // 
            chartArea3.Name = "ChartArea1";
            this.chtTotalSalesDate.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtTotalSalesDate.Legends.Add(legend3);
            this.chtTotalSalesDate.Location = new System.Drawing.Point(17, 19);
            this.chtTotalSalesDate.Name = "chtTotalSalesDate";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtTotalSalesDate.Series.Add(series3);
            this.chtTotalSalesDate.Size = new System.Drawing.Size(540, 151);
            this.chtTotalSalesDate.TabIndex = 0;
            this.chtTotalSalesDate.Text = "chart1";
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
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(772, 582);
            this.Controls.Add(this.tcReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.tcReports.ResumeLayout(false);
            this.tbpSales.ResumeLayout(false);
            this.grpbxCustSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtCustomerPerProvince)).EndInit();
            this.grpbxSalesReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtTotalSalesDate)).EndInit();
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
    }
}