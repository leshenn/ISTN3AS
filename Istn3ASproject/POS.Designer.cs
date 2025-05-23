namespace Istn3ASproject
{
    partial class frmPOS
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
            this.tcPOS = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpbAddCustomer = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.dgvSalesInvoice = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.tbpRefund = new System.Windows.Forms.TabPage();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DS = new Istn3ASproject.WstGrp11DataSet();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wstGrp11DS = new Istn3ASproject.WstGrp11DataSet();
            this.tbpRefund = new System.Windows.Forms.TabPage();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taStock = new Istn3ASproject.WstGrp11DataSetTableAdapters.StockTableAdapter();
            this.taSalesInvoice = new Istn3ASproject.WstGrp11DataSetTableAdapters.SalesInvoiceTableAdapter();
            this.taCustomer = new Istn3ASproject.WstGrp11DataSetTableAdapters.CustomerTableAdapter();
            this.taOrder = new Istn3ASproject.WstGrp11DataSetTableAdapters.OrderTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taOrderLine = new Istn3ASproject.WstGrp11DataSetTableAdapters.OrderLineTableAdapter();
            this.OrderLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcPOS.SuspendLayout();
            this.tbpSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPOS
            // 
            this.tcPOS.Controls.Add(this.tbpSales);
            this.tcPOS.Controls.Add(this.tbpRefund);
            this.tcPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPOS.Location = new System.Drawing.Point(0, 0);
            this.tcPOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcPOS.Name = "tcPOS";
            this.tcPOS.SelectedIndex = 0;
            this.tcPOS.Size = new System.Drawing.Size(1811, 923);
            this.tcPOS.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Controls.Add(this.dataGridView1);
            this.tbpSales.Controls.Add(this.grpbAddCustomer);
            this.tbpSales.Controls.Add(this.cmbPaymentMethod);
            this.tbpSales.Controls.Add(this.btnProcessOrder);
            this.tbpSales.Controls.Add(this.lblTotal);
            this.tbpSales.Controls.Add(this.lblTotalCaption);
            this.tbpSales.Controls.Add(this.dgvSalesInvoice);
            this.tbpSales.Controls.Add(this.lblSearchItem);
            this.tbpSales.Controls.Add(this.txtSearchProduct);
            this.tbpSales.Controls.Add(this.dgvStock);
            this.tbpSales.Location = new System.Drawing.Point(4, 22);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSales.Size = new System.Drawing.Size(1803, 894);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 712);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // grpbAddCustomer
            // 
            this.grpbAddCustomer.Location = new System.Drawing.Point(1245, 124);
            this.grpbAddCustomer.Name = "grpbAddCustomer";
            this.grpbAddCustomer.Size = new System.Drawing.Size(495, 363);
            this.grpbAddCustomer.TabIndex = 8;
            this.grpbAddCustomer.TabStop = false;
            this.grpbAddCustomer.Text = "ADD CUSTOMER";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(218, 522);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 24);
            this.cmbPaymentMethod.TabIndex = 7;
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(33, 514);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(121, 38);
            this.btnProcessOrder.TabIndex = 6;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(97, 314);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(30, 315);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(57, 16);
            this.lblTotalCaption.TabIndex = 4;
            this.lblTotalCaption.Text = "TOTAL :";
            // 
            // dgvSalesInvoice
            // 
            this.dgvSalesInvoice.AutoGenerateColumns = false;
            this.dgvSalesInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.poductDescriptionDataGridViewTextBoxColumn1,
            this.sellingPriceDataGridViewTextBoxColumn1,
            this.stockOnHandDataGridViewTextBoxColumn1,
            this.Quantity});
            this.dgvSalesInvoice.DataSource = this.salesInvoiceBindingSource;
            this.dgvSalesInvoice.Location = new System.Drawing.Point(30, 337);
            this.dgvSalesInvoice.Name = "dgvSalesInvoice";
            this.dgvSalesInvoice.RowHeadersWidth = 51;
            this.dgvSalesInvoice.RowTemplate.Height = 24;
            this.dgvSalesInvoice.Size = new System.Drawing.Size(979, 150);
            this.dgvSalesInvoice.TabIndex = 3;
            this.dgvSalesInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesInvoice_CellEndEdit);
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(27, 95);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(102, 16);
            this.lblSearchItem.TabIndex = 2;
            this.lblSearchItem.Text = "Search for item :";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(135, 95);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(519, 22);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // dgvStock
            // 
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.poductDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.stockBindingSource;
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.dgvStock.Location = new System.Drawing.Point(30, 142);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(979, 150);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.DoubleClick += new System.EventHandler(this.dgvStock_DoubleClick);
            // 
            // tbpRefund
            // 
            this.tbpRefund.Location = new System.Drawing.Point(4, 25);
            this.tbpRefund.Name = "tbpRefund";
            this.tbpRefund.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRefund.Size = new System.Drawing.Size(1803, 894);
            this.tbpRefund.TabIndex = 1;
            this.tbpRefund.Text = "Refund";
            this.tbpRefund.UseVisualStyleBackColor = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.wstGrp11DS;
            // 
            // wstGrp11DS
            // 
            this.wstGrp11DS.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockIDDataGridViewTextBoxColumn1
            // 
            this.stockIDDataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn1.Name = "stockIDDataGridViewTextBoxColumn1";
            this.stockIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // poductDescriptionDataGridViewTextBoxColumn1
            // 
            this.poductDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn1.HeaderText = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn1.Name = "poductDescriptionDataGridViewTextBoxColumn1";
            this.poductDescriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sellingPriceDataGridViewTextBoxColumn1
            // 
            this.sellingPriceDataGridViewTextBoxColumn1.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn1.Name = "sellingPriceDataGridViewTextBoxColumn1";
            this.sellingPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // stockOnHandDataGridViewTextBoxColumn1
            // 
            this.stockOnHandDataGridViewTextBoxColumn1.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn1.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn1.Name = "stockOnHandDataGridViewTextBoxColumn1";
            this.stockOnHandDataGridViewTextBoxColumn1.Width = 125;
            // 
            // salesInvoiceBindingSource
            // 
            this.salesInvoiceBindingSource.DataMember = "SalesInvoice";
            this.salesInvoiceBindingSource.DataSource = this.wstGrp11DS;
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
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            this.stockOnHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DS;
            // 
            // taStock
            // 
            this.taStock.ClearBeforeFill = true;
            // 
            // taSalesInvoice
            // 
            this.taSalesInvoice.ClearBeforeFill = true;
            // 
            // taCustomer
            // 
            this.taCustomer.ClearBeforeFill = true;
            // 
            // taOrder
            // 
            this.taOrder.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.wstGrp11DS;
            // 
            // taOrderLine
            // 
            this.taOrderLine.ClearBeforeFill = true;
            // 
            // OrderLineBindingSource
            // 
            this.OrderLineBindingSource.DataMember = "OrderLine";
            this.OrderLineBindingSource.DataSource = this.wstGrp11DS;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DS;
            // 
            // wstGrp11DS
            // 
            this.wstGrp11DS.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbpRefund
            // 
            this.tbpRefund.Location = new System.Drawing.Point(4, 22);
            this.tbpRefund.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpRefund.Name = "tbpRefund";
            this.tbpRefund.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpRefund.Size = new System.Drawing.Size(1353, 533);
            this.tbpRefund.TabIndex = 1;
            this.tbpRefund.Text = "Refund";
            this.tbpRefund.UseVisualStyleBackColor = true;
            // 
            // taStock
            // 
            this.taStock.ClearBeforeFill = true;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 923);
            this.Controls.Add(this.tcPOS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPOS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.tcPOS.ResumeLayout(false);
            this.tbpSales.ResumeLayout(false);
            this.tbpSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderLineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPOS;
        private System.Windows.Forms.TabPage tbpSales;
        private System.Windows.Forms.TabPage tbpRefund;
        private System.Windows.Forms.DataGridView dgvStock;
        private WstGrp11DataSet wstGrp11DS;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private WstGrp11DataSetTableAdapters.StockTableAdapter taStock;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvSalesInvoice;
        private System.Windows.Forms.BindingSource salesInvoiceBindingSource;
        private WstGrp11DataSetTableAdapters.SalesInvoiceTableAdapter taSalesInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpbAddCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private WstGrp11DataSetTableAdapters.CustomerTableAdapter taCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private WstGrp11DataSetTableAdapters.OrderTableAdapter taOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private WstGrp11DataSetTableAdapters.OrderLineTableAdapter taOrderLine;
        private System.Windows.Forms.BindingSource OrderLineBindingSource;
    }
}