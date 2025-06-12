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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPOS = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpBCustomers = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalesInvoice = new System.Windows.Forms.DataGridView();
            this.salesInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpbStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
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
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPOS.SuspendLayout();
            this.tbpSales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tcPOS.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPOS.Location = new System.Drawing.Point(0, 0);
            this.tcPOS.Margin = new System.Windows.Forms.Padding(2);
            this.tcPOS.Name = "tcPOS";
            this.tcPOS.SelectedIndex = 0;
            this.tcPOS.Size = new System.Drawing.Size(1528, 779);
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
            this.tbpSales.Location = new System.Drawing.Point(4, 26);
            this.tbpSales.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSales.Size = new System.Drawing.Size(1520, 749);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(785, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search for Customer Phone Number:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1130, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 33);
            this.textBox1.TabIndex = 12;
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
            this.panel1.Location = new System.Drawing.Point(977, 445);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 237);
            this.panel1.TabIndex = 10;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(138, 92);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(41, 21);
            this.lblCustomerID.TabIndex = 10;
            this.lblCustomerID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "CustomerID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(66, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 48);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order Details:";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(23, 164);
            this.cmbPaymentMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(131, 38);
            this.cmbPaymentMethod.TabIndex = 7;
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.BackColor = System.Drawing.Color.LightGreen;
            this.btnProcessOrder.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessOrder.Location = new System.Drawing.Point(205, 155);
            this.btnProcessOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(139, 59);
            this.btnProcessOrder.TabIndex = 6;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = false;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCaption.Location = new System.Drawing.Point(19, 119);
            this.lblTotalCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(64, 21);
            this.lblTotalCaption.TabIndex = 4;
            this.lblTotalCaption.Text = "TOTAL :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(89, 119);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // grpBCustomers
            // 
            this.grpBCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBCustomers.Controls.Add(this.dgvCustomer);
            this.grpBCustomers.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBCustomers.Location = new System.Drawing.Point(713, 86);
            this.grpBCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.grpBCustomers.Name = "grpBCustomers";
            this.grpBCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.grpBCustomers.Size = new System.Drawing.Size(717, 310);
            this.grpBCustomers.TabIndex = 10;
            this.grpBCustomers.TabStop = false;
            this.grpBCustomers.Text = "Customers";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCustomer.Location = new System.Drawing.Point(18, 35);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomer.Name = "dgvCustomer";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCustomer.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(678, 248);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dgvSalesInvoice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 422);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(783, 304);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invoice";
            // 
            // dgvSalesInvoice
            // 
            this.dgvSalesInvoice.AllowUserToAddRows = false;
            this.dgvSalesInvoice.AutoGenerateColumns = false;
            this.dgvSalesInvoice.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvSalesInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSalesInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.PoductDescription,
            this.sellingPriceDataGridViewTextBoxColumn1,
            this.stockOnHandDataGridViewTextBoxColumn1,
            this.Quantity});
            this.dgvSalesInvoice.DataSource = this.salesInvoiceBindingSource;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesInvoice.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSalesInvoice.EnableHeadersVisualStyles = false;
            this.dgvSalesInvoice.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSalesInvoice.Location = new System.Drawing.Point(27, 23);
            this.dgvSalesInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSalesInvoice.Name = "dgvSalesInvoice";
            this.dgvSalesInvoice.RowHeadersWidth = 51;
            this.dgvSalesInvoice.RowTemplate.Height = 24;
            this.dgvSalesInvoice.Size = new System.Drawing.Size(715, 263);
            this.dgvSalesInvoice.TabIndex = 3;
            this.dgvSalesInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesInvoice_CellEndEdit);
            // 
            // salesInvoiceBindingSource
            // 
            this.salesInvoiceBindingSource.DataMember = "SalesInvoice";
            this.salesInvoiceBindingSource.DataSource = this.WstGrp11DataSet;
            // 
            // grpbStock
            // 
            this.grpbStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpbStock.Controls.Add(this.dgvStock);
            this.grpbStock.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbStock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpbStock.Location = new System.Drawing.Point(13, 86);
            this.grpbStock.Margin = new System.Windows.Forms.Padding(2);
            this.grpbStock.Name = "grpbStock";
            this.grpbStock.Padding = new System.Windows.Forms.Padding(2);
            this.grpbStock.Size = new System.Drawing.Size(668, 310);
            this.grpbStock.TabIndex = 8;
            this.grpbStock.TabStop = false;
            this.grpbStock.Text = "Stock";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.poductDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.stockBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStock.Location = new System.Drawing.Point(22, 35);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStock.Name = "dgvStock";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvStock.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStock.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(619, 248);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.DoubleClick += new System.EventHandler(this.dgvStock_DoubleClick);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.WstGrp11DataSet;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItem.Location = new System.Drawing.Point(12, 44);
            this.lblSearchItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(157, 25);
            this.lblSearchItem.TabIndex = 2;
            this.lblSearchItem.Text = "Search for item :";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.Color.LightBlue;
            this.txtSearchProduct.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(173, 38);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(390, 33);
            this.txtSearchProduct.TabIndex = 1;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // tbpRefund
            // 
            this.tbpRefund.Location = new System.Drawing.Point(4, 26);
            this.tbpRefund.Margin = new System.Windows.Forms.Padding(2);
            this.tbpRefund.Name = "tbpRefund";
            this.tbpRefund.Padding = new System.Windows.Forms.Padding(2);
            this.tbpRefund.Size = new System.Drawing.Size(1520, 749);
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
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact No";
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
            this.emailDataGridViewTextBoxColumn.Width = 160;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 135;
            // 
            // poductDescriptionDataGridViewTextBoxColumn
            // 
            this.poductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.poductDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn.Name = "poductDescriptionDataGridViewTextBoxColumn";
            this.poductDescriptionDataGridViewTextBoxColumn.Width = 190;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            this.stockOnHandDataGridViewTextBoxColumn.Width = 70;
            // 
            // stockIDDataGridViewTextBoxColumn1
            // 
            this.stockIDDataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.stockIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn1.Name = "stockIDDataGridViewTextBoxColumn1";
            this.stockIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 135;
            // 
            // PoductDescription
            // 
            this.PoductDescription.DataPropertyName = "PoductDescription";
            this.PoductDescription.HeaderText = "Description";
            this.PoductDescription.MinimumWidth = 6;
            this.PoductDescription.Name = "PoductDescription";
            this.PoductDescription.Width = 190;
            // 
            // sellingPriceDataGridViewTextBoxColumn1
            // 
            this.sellingPriceDataGridViewTextBoxColumn1.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.sellingPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn1.Name = "sellingPriceDataGridViewTextBoxColumn1";
            this.sellingPriceDataGridViewTextBoxColumn1.Width = 70;
            // 
            // stockOnHandDataGridViewTextBoxColumn1
            // 
            this.stockOnHandDataGridViewTextBoxColumn1.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn1.HeaderText = "Stock";
            this.stockOnHandDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn1.Name = "stockOnHandDataGridViewTextBoxColumn1";
            this.stockOnHandDataGridViewTextBoxColumn1.Width = 70;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 90;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 779);
            this.Controls.Add(this.tcPOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPOS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.tcPOS.ResumeLayout(false);
            this.tbpSales.ResumeLayout(false);
            this.tbpSales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpbStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBCustomers;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.BindingSource wstGrp11DataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private WstGrp11DataSetTableAdapters.CustomerTableAdapter TaCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
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
    }
}