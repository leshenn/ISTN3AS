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
            this.components = new System.ComponentModel.Container();
            this.tcReports = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.tbpFinancial = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StockTableAdapter();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcReports.SuspendLayout();
            this.tbpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcReports
            // 
            this.tcReports.Controls.Add(this.tbpSales);
            this.tcReports.Controls.Add(this.tbpInventory);
            this.tcReports.Controls.Add(this.tbpFinancial);
            this.tcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcReports.Location = new System.Drawing.Point(0, 0);
            this.tcReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcReports.Name = "tcReports";
            this.tcReports.SelectedIndex = 0;
            this.tcReports.Size = new System.Drawing.Size(1306, 656);
            this.tcReports.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Location = new System.Drawing.Point(4, 25);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSales.Size = new System.Drawing.Size(1298, 627);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            // 
            // tbpInventory
            // 
            this.tbpInventory.Controls.Add(this.dataGridView1);
            this.tbpInventory.Location = new System.Drawing.Point(4, 25);
            this.tbpInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInventory.Size = new System.Drawing.Size(1298, 627);
            this.tbpInventory.TabIndex = 1;
            this.tbpInventory.Text = "Inventory";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // tbpFinancial
            // 
            this.tbpFinancial.Location = new System.Drawing.Point(4, 25);
            this.tbpFinancial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpFinancial.Name = "tbpFinancial";
            this.tbpFinancial.Size = new System.Drawing.Size(792, 421);
            this.tbpFinancial.TabIndex = 2;
            this.tbpFinancial.Text = "Financial";
            this.tbpFinancial.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.poductDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.expirationTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // poductDescriptionDataGridViewTextBoxColumn
            // 
            this.poductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.HeaderText = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn.Name = "poductDescriptionDataGridViewTextBoxColumn";
            this.poductDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            this.buyingPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            this.stockOnHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            this.reorderLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // expirationTimeDataGridViewTextBoxColumn
            // 
            this.expirationTimeDataGridViewTextBoxColumn.DataPropertyName = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.HeaderText = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationTimeDataGridViewTextBoxColumn.Name = "expirationTimeDataGridViewTextBoxColumn";
            this.expirationTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 656);
            this.Controls.Add(this.tcReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.tcReports.ResumeLayout(false);
            this.tbpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcReports;
        private System.Windows.Forms.TabPage tbpSales;
        private System.Windows.Forms.TabPage tbpInventory;
        private System.Windows.Forms.TabPage tbpFinancial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WstGrp11DataSet wstGrp11DataSet;
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
    }
}