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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpBCustomers = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalesInvoice = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpbStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.tbpRefund = new System.Windows.Forms.TabPage();
            this.taStock = new Istn3ASproject.WstGrp11DataSetTableAdapters.StockTableAdapter();
            this.taOrder = new Istn3ASproject.WstGrp11DataSetTableAdapters.OrderTableAdapter();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taOrderLine = new Istn3ASproject.WstGrp11DataSetTableAdapters.OrderLineTableAdapter();
            this.OrderLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TaSalesInvoice = new Istn3ASproject.WstGrp11DataSetTableAdapters.SalesInvoiceTableAdapter();
            this.TaCustomer = new Istn3ASproject.WstGrp11DataSetTableAdapters.CustomerTableAdapter();
            this.tcPOS.SuspendLayout();
            this.tbpSales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WstGrp11DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).BeginInit();
            this.grpbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
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
            this.tcPOS.Name = "tcPOS";
            this.tcPOS.SelectedIndex = 0;
            this.tcPOS.Size = new System.Drawing.Size(1924, 923);
            this.tcPOS.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpSales.Controls.Add(this.label3);
            this.tbpSales.Controls.Add(this.textBox1);
            this.tbpSales.Controls.Add(this.panel1);
            this.tbpSales.Controls.Add(this.grpBCustomers);
            this.tbpSales.Controls.Add(this.groupBox1);
            this.tbpSales.Controls.Add(this.grpbStock);
            this.tbpSales.Controls.Add(this.lblSearchItem);
            this.tbpSales.Controls.Add(this.txtSearchProduct);
            this.tbpSales.Location = new System.Drawing.Point(4, 25);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSales.Size = new System.Drawing.Size(1916, 894);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1062, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search for Customer PhoneNo:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.Location = new System.Drawing.Point(1418, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 22);
            this.textBox1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 58);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order Details:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCustomerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmbPaymentMethod);
            this.panel1.Controls.Add(this.btnProcessOrder);
            this.panel1.Controls.Add(this.lblTotalCaption);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(1434, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 226);
            this.panel1.TabIndex = 10;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(162, 74);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(49, 25);
            this.lblCustomerID.TabIndex = 10;
            this.lblCustomerID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "CustomerID:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(14, 169);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(121, 33);
            this.cmbPaymentMethod.TabIndex = 7;
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.BackColor = System.Drawing.Color.LightGreen;
            this.btnProcessOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessOrder.Location = new System.Drawing.Point(152, 148);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(121, 73);
            this.btnProcessOrder.TabIndex = 6;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = false;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaption.Location = new System.Drawing.Point(27, 113);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(97, 25);
            this.lblTotalCaption.TabIndex = 4;
            this.lblTotalCaption.Text = "TOTAL :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(162, 113);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // grpBCustomers
            // 
            this.grpBCustomers.BackColor = System.Drawing.Color.LightBlue;
            this.grpBCustomers.Controls.Add(this.dgvCustomer);
            this.grpBCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBCustomers.Location = new System.Drawing.Point(1062, 117);
            this.grpBCustomers.Name = "grpBCustomers";
            this.grpBCustomers.Size = new System.Drawing.Size(846, 327);
            this.grpBCustomers.TabIndex = 10;
            this.grpBCustomers.TabStop = false;
            this.grpBCustomers.Text = "Customers";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.customerBindingSource;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(3, 26);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(840, 298);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.wstGrp11DataSetBindingSource;
            // 
            // wstGrp11DataSetBindingSource
            // 
            this.wstGrp11DataSetBindingSource.DataSource = this.WstGrp11DataSet;
            this.wstGrp11DataSetBindingSource.Position = 0;
            // 
            // WstGrp11DataSet
            // 
            this.WstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.WstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.dgvSalesInvoice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1170, 352);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // dgvSalesInvoice
            // 
            this.dgvSalesInvoice.AutoGenerateColumns = false;
            this.dgvSalesInvoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSalesInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.PoductDescription,
            this.sellingPriceDataGridViewTextBoxColumn1,
            this.stockOnHandDataGridViewTextBoxColumn1,
            this.Quantity});
            this.dgvSalesInvoice.DataSource = this.salesInvoiceBindingSource;
            this.dgvSalesInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesInvoice.Location = new System.Drawing.Point(3, 26);
            this.dgvSalesInvoice.Name = "dgvSalesInvoice";
            this.dgvSalesInvoice.RowHeadersWidth = 51;
            this.dgvSalesInvoice.RowTemplate.Height = 24;
            this.dgvSalesInvoice.Size = new System.Drawing.Size(1164, 323);
            this.dgvSalesInvoice.TabIndex = 3;
            this.dgvSalesInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesInvoice_CellEndEdit);
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
            // PoductDescription
            // 
            this.PoductDescription.DataPropertyName = "PoductDescription";
            this.PoductDescription.HeaderText = "PoductDescription";
            this.PoductDescription.MinimumWidth = 6;
            this.PoductDescription.Name = "PoductDescription";
            this.PoductDescription.Width = 125;
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // salesInvoiceBindingSource
            // 
            this.salesInvoiceBindingSource.DataMember = "SalesInvoice";
            this.salesInvoiceBindingSource.DataSource = this.WstGrp11DataSet;
            // 
            // grpbStock
            // 
            this.grpbStock.BackColor = System.Drawing.Color.LightBlue;
            this.grpbStock.Controls.Add(this.dgvStock);
            this.grpbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbStock.Location = new System.Drawing.Point(30, 117);
            this.grpbStock.Name = "grpbStock";
            this.grpbStock.Size = new System.Drawing.Size(957, 333);
            this.grpbStock.TabIndex = 8;
            this.grpbStock.TabStop = false;
            this.grpbStock.Text = "Stock";
            // 
            // dgvStock
            // 
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.poductDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.stockBindingSource;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStock.Location = new System.Drawing.Point(3, 26);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(951, 304);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.DoubleClick += new System.EventHandler(this.dgvStock_DoubleClick);
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
            this.stockBindingSource.DataSource = this.WstGrp11DataSet;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItem.Location = new System.Drawing.Point(28, 65);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(171, 25);
            this.lblSearchItem.TabIndex = 2;
            this.lblSearchItem.Text = "Search for item :";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.Color.LightBlue;
            this.txtSearchProduct.Location = new System.Drawing.Point(216, 69);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(519, 22);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // tbpRefund
            // 
            this.tbpRefund.Location = new System.Drawing.Point(4, 25);
            this.tbpRefund.Name = "tbpRefund";
            this.tbpRefund.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRefund.Size = new System.Drawing.Size(1916, 894);
            this.tbpRefund.TabIndex = 1;
            this.tbpRefund.Text = "Refund";
            this.tbpRefund.UseVisualStyleBackColor = true;
            // 
            // taStock
            // 
            this.taStock.ClearBeforeFill = true;
            // 
            // taOrder
            // 
            this.taOrder.ClearBeforeFill = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.WstGrp11DataSet;
            // 
            // taOrderLine
            // 
            this.taOrderLine.ClearBeforeFill = true;
            // 
            // OrderLineBindingSource
            // 
            this.OrderLineBindingSource.DataMember = "OrderLine";
            this.OrderLineBindingSource.DataSource = this.WstGrp11DataSet;
            // 
            // TaSalesInvoice
            // 
            this.TaSalesInvoice.ClearBeforeFill = true;
            // 
            // TaCustomer
            // 
            this.TaCustomer.ClearBeforeFill = true;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 923);
            this.Controls.Add(this.tcPOS);
            this.Name = "frmPOS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.tcPOS.ResumeLayout(false);
            this.tbpSales.ResumeLayout(false);
            this.tbpSales.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WstGrp11DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInvoiceBindingSource)).EndInit();
            this.grpbStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
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
        private WstGrp11DataSet WstGrp11DataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private WstGrp11DataSetTableAdapters.StockTableAdapter taStock;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.DataGridView dgvSalesInvoice;
        private System.Windows.Forms.BindingSource salesInvoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private WstGrp11DataSetTableAdapters.OrderTableAdapter taOrder;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private WstGrp11DataSetTableAdapters.OrderLineTableAdapter taOrderLine;
        private System.Windows.Forms.BindingSource OrderLineBindingSource;
        private WstGrp11DataSetTableAdapters.SalesInvoiceTableAdapter TaSalesInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.GroupBox grpbStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBCustomers;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.BindingSource wstGrp11DataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private WstGrp11DataSetTableAdapters.CustomerTableAdapter TaCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}