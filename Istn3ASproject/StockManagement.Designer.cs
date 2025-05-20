namespace Istn3ASproject
{
    partial class frmStockManagement
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
            this.tcStockManagement = new System.Windows.Forms.TabControl();
            this.tbpInventoryManagement = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbpSupplierOrder = new System.Windows.Forms.TabPage();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.tbItemSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSupplierStock = new System.Windows.Forms.DataGridView();
            this.tabOrderDetails = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvOrderLines = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOrderTable = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsToAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierOrderIDLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierLineOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplierOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StockTableAdapter();
            this.itemsToAddTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.ItemsToAddTableAdapter();
            this.supplierOrderTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter();
            this.supplierLineOrderTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierLineOrderTableAdapter();
            this.tcStockManagement.SuspendLayout();
            this.tbpInventoryManagement.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tbpSupplierOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierStock)).BeginInit();
            this.tabOrderDetails.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToAddBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierLineOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStockManagement
            // 
            this.tcStockManagement.Controls.Add(this.tbpInventoryManagement);
            this.tcStockManagement.Controls.Add(this.tbpSupplierOrder);
            this.tcStockManagement.Controls.Add(this.tabOrderDetails);
            this.tcStockManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStockManagement.Location = new System.Drawing.Point(0, 0);
            this.tcStockManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tcStockManagement.Name = "tcStockManagement";
            this.tcStockManagement.SelectedIndex = 0;
            this.tcStockManagement.Size = new System.Drawing.Size(1025, 524);
            this.tcStockManagement.TabIndex = 0;
            // 
            // tbpInventoryManagement
            // 
            this.tbpInventoryManagement.Controls.Add(this.label8);
            this.tbpInventoryManagement.Controls.Add(this.panel5);
            this.tbpInventoryManagement.Location = new System.Drawing.Point(4, 22);
            this.tbpInventoryManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInventoryManagement.Name = "tbpInventoryManagement";
            this.tbpInventoryManagement.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInventoryManagement.Size = new System.Drawing.Size(1017, 498);
            this.tbpInventoryManagement.TabIndex = 0;
            this.tbpInventoryManagement.Text = "Manage Inventory";
            this.tbpInventoryManagement.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Add New Inventory Item";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.btnAddItem);
            this.panel5.Controls.Add(this.txtExpiration);
            this.panel5.Controls.Add(this.txtReorder);
            this.panel5.Controls.Add(this.txtBuy);
            this.panel5.Controls.Add(this.txtSell);
            this.panel5.Controls.Add(this.txtDesc);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.lblBuy);
            this.panel5.Controls.Add(this.lblSell);
            this.panel5.Controls.Add(this.lblDesc);
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Location = new System.Drawing.Point(33, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 444);
            this.panel5.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(248, 379);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(211, 36);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item to Inventory";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(248, 325);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(210, 20);
            this.txtExpiration.TabIndex = 11;
            this.txtExpiration.TextChanged += new System.EventHandler(this.txtExpiration_TextChanged);
            // 
            // txtReorder
            // 
            this.txtReorder.Location = new System.Drawing.Point(249, 268);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(210, 20);
            this.txtReorder.TabIndex = 10;
            this.txtReorder.TextChanged += new System.EventHandler(this.txtReorder_TextChanged);
            // 
            // txtBuy
            // 
            this.txtBuy.Location = new System.Drawing.Point(249, 215);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(210, 20);
            this.txtBuy.TabIndex = 9;
            this.txtBuy.TextChanged += new System.EventHandler(this.txtBuy_TextChanged);
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(248, 162);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(210, 20);
            this.txtSell.TabIndex = 8;
            this.txtSell.TextChanged += new System.EventHandler(this.txtSell_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(248, 105);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(210, 20);
            this.txtDesc.TabIndex = 7;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Expiration time (days):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Reorder level:";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.Location = new System.Drawing.Point(38, 215);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(112, 20);
            this.lblBuy.TabIndex = 3;
            this.lblBuy.Text = "Buying price:";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(37, 162);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(113, 20);
            this.lblSell.TabIndex = 2;
            this.lblSell.Text = "Selling Price:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(37, 105);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(169, 20);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Product description:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Product name:";
            // 
            // tbpSupplierOrder
            // 
            this.tbpSupplierOrder.BackColor = System.Drawing.Color.Transparent;
            this.tbpSupplierOrder.Controls.Add(this.tbTotal);
            this.tbpSupplierOrder.Controls.Add(this.label7);
            this.tbpSupplierOrder.Controls.Add(this.btnRecord);
            this.tbpSupplierOrder.Controls.Add(this.btnClear);
            this.tbpSupplierOrder.Controls.Add(this.label6);
            this.tbpSupplierOrder.Controls.Add(this.label5);
            this.tbpSupplierOrder.Controls.Add(this.label2);
            this.tbpSupplierOrder.Controls.Add(this.cbSupplier);
            this.tbpSupplierOrder.Controls.Add(this.tbItemSearch);
            this.tbpSupplierOrder.Controls.Add(this.label1);
            this.tbpSupplierOrder.Controls.Add(this.panel2);
            this.tbpSupplierOrder.Controls.Add(this.panel1);
            this.tbpSupplierOrder.Location = new System.Drawing.Point(4, 22);
            this.tbpSupplierOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSupplierOrder.Name = "tbpSupplierOrder";
            this.tbpSupplierOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSupplierOrder.Size = new System.Drawing.Size(1017, 498);
            this.tbpSupplierOrder.TabIndex = 1;
            this.tbpSupplierOrder.Text = "Supplier Orders";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(747, 365);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(195, 26);
            this.tbTotal.TabIndex = 11;
            this.tbTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(684, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.LightGreen;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(821, 414);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(121, 51);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(688, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Items.AddRange(new object[] {
            "Deep Blue Fisheries",
            "Ocean Catchers Ltd",
            "Neptune Seafood Co",
            "Aqua Harvest Suppliers",
            "Bay Fish Distributors"});
            this.cbSupplier.Location = new System.Drawing.Point(172, 21);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(254, 28);
            this.cbSupplier.TabIndex = 4;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // tbItemSearch
            // 
            this.tbItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemSearch.Location = new System.Drawing.Point(596, 23);
            this.tbItemSearch.Name = "tbItemSearch";
            this.tbItemSearch.Size = new System.Drawing.Size(374, 26);
            this.tbItemSearch.TabIndex = 3;
            this.tbItemSearch.TextChanged += new System.EventHandler(this.tbItemSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Item";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvItems);
            this.panel2.Location = new System.Drawing.Point(67, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 175);
            this.panel2.TabIndex = 1;
            // 
            // dgvItems
            // 
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.poductDescriptionDataGridViewTextBoxColumn1,
            this.buyingPriceDataGridViewTextBoxColumn1,
            this.Quantity});
            this.dgvItems.DataSource = this.itemsToAddBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(15, 16);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(546, 150);
            this.dgvItems.TabIndex = 0;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgvSupplierStock);
            this.panel1.Location = new System.Drawing.Point(67, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 172);
            this.panel1.TabIndex = 0;
            // 
            // dgvSupplierStock
            // 
            this.dgvSupplierStock.AutoGenerateColumns = false;
            this.dgvSupplierStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplierStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.poductDescriptionDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn,
            this.stockOnHandDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.expirationTimeDataGridViewTextBoxColumn});
            this.dgvSupplierStock.DataSource = this.stockBindingSource;
            this.dgvSupplierStock.Location = new System.Drawing.Point(15, 13);
            this.dgvSupplierStock.Name = "dgvSupplierStock";
            this.dgvSupplierStock.Size = new System.Drawing.Size(860, 150);
            this.dgvSupplierStock.TabIndex = 0;
            this.dgvSupplierStock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSupplierStock_RowHeaderMouseClick);
            // 
            // tabOrderDetails
            // 
            this.tabOrderDetails.Controls.Add(this.label4);
            this.tabOrderDetails.Controls.Add(this.label3);
            this.tabOrderDetails.Controls.Add(this.panel4);
            this.tabOrderDetails.Controls.Add(this.panel3);
            this.tabOrderDetails.Location = new System.Drawing.Point(4, 22);
            this.tabOrderDetails.Name = "tabOrderDetails";
            this.tabOrderDetails.Size = new System.Drawing.Size(1017, 498);
            this.tabOrderDetails.TabIndex = 2;
            this.tabOrderDetails.Text = "Order Details";
            this.tabOrderDetails.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier Order Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Order";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.dgvOrderLines);
            this.panel4.Location = new System.Drawing.Point(65, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 192);
            this.panel4.TabIndex = 1;
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AutoGenerateColumns = false;
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.SupplierOrderIDLine,
            this.QuantityLine,
            this.priceDataGridViewTextBoxColumn});
            this.dgvOrderLines.DataSource = this.supplierLineOrderBindingSource;
            this.dgvOrderLines.Location = new System.Drawing.Point(21, 28);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.Size = new System.Drawing.Size(445, 150);
            this.dgvOrderLines.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.dgvOrderTable);
            this.panel3.Location = new System.Drawing.Point(65, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 197);
            this.panel3.TabIndex = 0;
            // 
            // dgvOrderTable
            // 
            this.dgvOrderTable.AutoGenerateColumns = false;
            this.dgvOrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierOrderID,
            this.supplierIDDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.OrderStatus,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn});
            this.dgvOrderTable.DataSource = this.supplierOrderBindingSource;
            this.dgvOrderTable.Location = new System.Drawing.Point(21, 29);
            this.dgvOrderTable.Name = "dgvOrderTable";
            this.dgvOrderTable.Size = new System.Drawing.Size(789, 150);
            this.dgvOrderTable.TabIndex = 0;
            this.dgvOrderTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOrderTable_CellBeginEdit);
            this.dgvOrderTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderTable_CellValueChanged);
            this.dgvOrderTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderTable_RowHeaderMouseClick);
            // 
            // stockIDDataGridViewTextBoxColumn1
            // 
            this.stockIDDataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn1.Name = "stockIDDataGridViewTextBoxColumn1";
            this.stockIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // poductDescriptionDataGridViewTextBoxColumn1
            // 
            this.poductDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn1.HeaderText = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn1.Name = "poductDescriptionDataGridViewTextBoxColumn1";
            // 
            // buyingPriceDataGridViewTextBoxColumn1
            // 
            this.buyingPriceDataGridViewTextBoxColumn1.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn1.HeaderText = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn1.Name = "buyingPriceDataGridViewTextBoxColumn1";
            // 
            // itemsToAddBindingSource
            // 
            this.itemsToAddBindingSource.DataMember = "ItemsToAdd";
            this.itemsToAddBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // poductDescriptionDataGridViewTextBoxColumn
            // 
            this.poductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.HeaderText = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.Name = "poductDescriptionDataGridViewTextBoxColumn";
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            // 
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // expirationTimeDataGridViewTextBoxColumn
            // 
            this.expirationTimeDataGridViewTextBoxColumn.DataPropertyName = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.HeaderText = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.Name = "expirationTimeDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            // 
            // SupplierOrderIDLine
            // 
            this.SupplierOrderIDLine.DataPropertyName = "SupplierOrderID";
            this.SupplierOrderIDLine.HeaderText = "SupplierOrderID";
            this.SupplierOrderIDLine.Name = "SupplierOrderIDLine";
            // 
            // QuantityLine
            // 
            this.QuantityLine.DataPropertyName = "Quantity";
            this.QuantityLine.HeaderText = "Quantity";
            this.QuantityLine.Name = "QuantityLine";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // supplierLineOrderBindingSource
            // 
            this.supplierLineOrderBindingSource.DataMember = "SupplierLineOrder";
            this.supplierLineOrderBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // SupplierOrderID
            // 
            this.SupplierOrderID.DataPropertyName = "SupplierOrderID";
            this.SupplierOrderID.HeaderText = "SupplierOrderID";
            this.SupplierOrderID.Name = "SupplierOrderID";
            this.SupplierOrderID.ReadOnly = true;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "OrderStatus";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.FillWeight = 120F;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            // 
            // supplierOrderBindingSource
            // 
            this.supplierOrderBindingSource.DataMember = "SupplierOrder";
            this.supplierOrderBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // itemsToAddTableAdapter
            // 
            this.itemsToAddTableAdapter.ClearBeforeFill = true;
            // 
            // supplierOrderTableAdapter
            // 
            this.supplierOrderTableAdapter.ClearBeforeFill = true;
            // 
            // supplierLineOrderTableAdapter
            // 
            this.supplierLineOrderTableAdapter.ClearBeforeFill = true;
            // 
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 524);
            this.Controls.Add(this.tcStockManagement);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmStockManagement";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.frmStockManagement_Load);
            this.tcStockManagement.ResumeLayout(false);
            this.tbpInventoryManagement.ResumeLayout(false);
            this.tbpInventoryManagement.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tbpSupplierOrder.ResumeLayout(false);
            this.tbpSupplierOrder.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierStock)).EndInit();
            this.tabOrderDetails.ResumeLayout(false);
            this.tabOrderDetails.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToAddBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierLineOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStockManagement;
        private System.Windows.Forms.TabPage tbpInventoryManagement;
        private System.Windows.Forms.TabPage tbpSupplierOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSupplierStock;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource itemsToAddBindingSource;
        private WstGrp11DataSetTableAdapters.ItemsToAddTableAdapter itemsToAddTableAdapter;
        private System.Windows.Forms.TabPage tabOrderDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvOrderTable;
        private System.Windows.Forms.BindingSource supplierOrderBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter supplierOrderTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvOrderLines;
        private System.Windows.Forms.BindingSource supplierLineOrderBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierLineOrderTableAdapter supplierLineOrderTableAdapter;
        private System.Windows.Forms.TextBox tbItemSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierOrderIDLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.TextBox txtBuy;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}