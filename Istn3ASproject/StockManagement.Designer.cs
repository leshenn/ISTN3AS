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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcStockManagement = new System.Windows.Forms.TabControl();
            this.tbpInventoryManagement = new System.Windows.Forms.TabPage();
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
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbpSupplierOrder = new System.Windows.Forms.TabPage();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotalItemsCost = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCartHeading = new System.Windows.Forms.Label();
            this.lblStockHeading = new System.Windows.Forms.Label();
            this.lblChooseSupplier = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.tbItemSearch = new System.Windows.Forms.TextBox();
            this.lblSearchItems = new System.Windows.Forms.Label();
            this.panSupplierCartItems = new System.Windows.Forms.Panel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.itemsToAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panSupplierStockItems = new System.Windows.Forms.Panel();
            this.dgvSupplierStock = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOrderDetails = new System.Windows.Forms.TabPage();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panSupplierOtderLine = new System.Windows.Forms.Panel();
            this.dgvOrderLines = new System.Windows.Forms.DataGridView();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierOrderIDLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierLineOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panSupplierOrders = new System.Windows.Forms.Panel();
            this.dgvOrderTable = new System.Windows.Forms.DataGridView();
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
            this.supplierTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcStockManagement.SuspendLayout();
            this.tbpInventoryManagement.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tbpSupplierOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            this.panSupplierCartItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToAddBindingSource)).BeginInit();
            this.panSupplierStockItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.tabOrderDetails.SuspendLayout();
            this.panSupplierOtderLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierLineOrderBindingSource)).BeginInit();
            this.panSupplierOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStockManagement
            // 
            this.tcStockManagement.Controls.Add(this.tbpInventoryManagement);
            this.tcStockManagement.Controls.Add(this.tbpSupplierOrder);
            this.tcStockManagement.Controls.Add(this.tabOrderDetails);
            this.tcStockManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStockManagement.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcStockManagement.Location = new System.Drawing.Point(0, 0);
            this.tcStockManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tcStockManagement.Name = "tcStockManagement";
            this.tcStockManagement.SelectedIndex = 0;
            this.tcStockManagement.Size = new System.Drawing.Size(1465, 721);
            this.tcStockManagement.TabIndex = 0;
            // 
            // tbpInventoryManagement
            // 
            this.tbpInventoryManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpInventoryManagement.Controls.Add(this.label1);
            this.tbpInventoryManagement.Controls.Add(this.panel5);
            this.tbpInventoryManagement.Location = new System.Drawing.Point(4, 24);
            this.tbpInventoryManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInventoryManagement.Name = "tbpInventoryManagement";
            this.tbpInventoryManagement.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInventoryManagement.Size = new System.Drawing.Size(1457, 693);
            this.tbpInventoryManagement.TabIndex = 0;
            this.tbpInventoryManagement.Text = "Manage Inventory";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
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
            this.panel5.Controls.Add(this.lblProductDesc);
            this.panel5.Controls.Add(this.lblProductName);
            this.panel5.Location = new System.Drawing.Point(476, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 444);
            this.panel5.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddItem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtExpiration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtExpiration.Location = new System.Drawing.Point(248, 325);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(210, 25);
            this.txtExpiration.TabIndex = 11;
            this.txtExpiration.TextChanged += new System.EventHandler(this.txtExpiration_TextChanged);
            // 
            // txtReorder
            // 
            this.txtReorder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtReorder.Location = new System.Drawing.Point(249, 268);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(210, 25);
            this.txtReorder.TabIndex = 10;
            this.txtReorder.TextChanged += new System.EventHandler(this.txtReorder_TextChanged);
            // 
            // txtBuy
            // 
            this.txtBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBuy.Location = new System.Drawing.Point(249, 215);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(210, 25);
            this.txtBuy.TabIndex = 9;
            this.txtBuy.TextChanged += new System.EventHandler(this.txtBuy_TextChanged);
            // 
            // txtSell
            // 
            this.txtSell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSell.Location = new System.Drawing.Point(248, 162);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(210, 25);
            this.txtSell.TabIndex = 8;
            this.txtSell.TextChanged += new System.EventHandler(this.txtSell_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDesc.Location = new System.Drawing.Point(248, 105);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(210, 25);
            this.txtDesc.TabIndex = 7;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.Location = new System.Drawing.Point(248, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 25);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Expiration time (days):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Reorder level:";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.Location = new System.Drawing.Point(38, 215);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(110, 21);
            this.lblBuy.TabIndex = 3;
            this.lblBuy.Text = "Buying price:";
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(37, 162);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(109, 21);
            this.lblSell.TabIndex = 2;
            this.lblSell.Text = "Selling Price:";
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(37, 105);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(164, 21);
            this.lblProductDesc.TabIndex = 1;
            this.lblProductDesc.Text = "Product description:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(37, 51);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(121, 21);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product name:";
            // 
            // tbpSupplierOrder
            // 
            this.tbpSupplierOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpSupplierOrder.Controls.Add(this.tbTotal);
            this.tbpSupplierOrder.Controls.Add(this.lblTotalItemsCost);
            this.tbpSupplierOrder.Controls.Add(this.btnRecord);
            this.tbpSupplierOrder.Controls.Add(this.btnClear);
            this.tbpSupplierOrder.Controls.Add(this.lblCartHeading);
            this.tbpSupplierOrder.Controls.Add(this.lblStockHeading);
            this.tbpSupplierOrder.Controls.Add(this.lblChooseSupplier);
            this.tbpSupplierOrder.Controls.Add(this.cbSupplier);
            this.tbpSupplierOrder.Controls.Add(this.tbItemSearch);
            this.tbpSupplierOrder.Controls.Add(this.lblSearchItems);
            this.tbpSupplierOrder.Controls.Add(this.panSupplierCartItems);
            this.tbpSupplierOrder.Controls.Add(this.panSupplierStockItems);
            this.tbpSupplierOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpSupplierOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSupplierOrder.Name = "tbpSupplierOrder";
            this.tbpSupplierOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSupplierOrder.Size = new System.Drawing.Size(1457, 693);
            this.tbpSupplierOrder.TabIndex = 1;
            this.tbpSupplierOrder.Text = "Supplier Orders";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.LightBlue;
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(1035, 441);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(202, 26);
            this.tbTotal.TabIndex = 11;
            this.tbTotal.Text = "0";
            // 
            // lblTotalItemsCost
            // 
            this.lblTotalItemsCost.AutoSize = true;
            this.lblTotalItemsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsCost.Location = new System.Drawing.Point(972, 444);
            this.lblTotalItemsCost.Name = "lblTotalItemsCost";
            this.lblTotalItemsCost.Size = new System.Drawing.Size(49, 20);
            this.lblTotalItemsCost.TabIndex = 10;
            this.lblTotalItemsCost.Text = "Total";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.LightGreen;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(1109, 490);
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
            this.btnClear.Location = new System.Drawing.Point(976, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 51);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCartHeading
            // 
            this.lblCartHeading.AutoSize = true;
            this.lblCartHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartHeading.Location = new System.Drawing.Point(181, 396);
            this.lblCartHeading.Name = "lblCartHeading";
            this.lblCartHeading.Size = new System.Drawing.Size(43, 20);
            this.lblCartHeading.TabIndex = 7;
            this.lblCartHeading.Text = "Cart";
            // 
            // lblStockHeading
            // 
            this.lblStockHeading.AutoSize = true;
            this.lblStockHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHeading.Location = new System.Drawing.Point(181, 153);
            this.lblStockHeading.Name = "lblStockHeading";
            this.lblStockHeading.Size = new System.Drawing.Size(55, 20);
            this.lblStockHeading.TabIndex = 6;
            this.lblStockHeading.Text = "Stock";
            // 
            // lblChooseSupplier
            // 
            this.lblChooseSupplier.AutoSize = true;
            this.lblChooseSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSupplier.Location = new System.Drawing.Point(338, 96);
            this.lblChooseSupplier.Name = "lblChooseSupplier";
            this.lblChooseSupplier.Size = new System.Drawing.Size(75, 20);
            this.lblChooseSupplier.TabIndex = 5;
            this.lblChooseSupplier.Text = "Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.cbSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSupplier.DataSource = this.supplierBindingSource;
            this.cbSupplier.DisplayMember = "Name";
            this.cbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSupplier.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(419, 93);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(254, 28);
            this.cbSupplier.TabIndex = 4;
            this.cbSupplier.ValueMember = "SupplierID";
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbItemSearch
            // 
            this.tbItemSearch.BackColor = System.Drawing.Color.LightBlue;
            this.tbItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemSearch.Location = new System.Drawing.Point(843, 91);
            this.tbItemSearch.Name = "tbItemSearch";
            this.tbItemSearch.Size = new System.Drawing.Size(370, 29);
            this.tbItemSearch.TabIndex = 3;
            this.tbItemSearch.TextChanged += new System.EventHandler(this.tbItemSearch_TextChanged);
            // 
            // lblSearchItems
            // 
            this.lblSearchItems.AutoSize = true;
            this.lblSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItems.Location = new System.Drawing.Point(730, 96);
            this.lblSearchItems.Name = "lblSearchItems";
            this.lblSearchItems.Size = new System.Drawing.Size(107, 20);
            this.lblSearchItems.TabIndex = 2;
            this.lblSearchItems.Text = "Search Item";
            // 
            // panSupplierCartItems
            // 
            this.panSupplierCartItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupplierCartItems.Controls.Add(this.dgvItems);
            this.panSupplierCartItems.Location = new System.Drawing.Point(151, 407);
            this.panSupplierCartItems.Name = "panSupplierCartItems";
            this.panSupplierCartItems.Size = new System.Drawing.Size(766, 185);
            this.panSupplierCartItems.TabIndex = 1;
            // 
            // dgvItems
            // 
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.poductDescriptionDataGridViewTextBoxColumn1,
            this.buyingPriceDataGridViewTextBoxColumn1,
            this.Quantity});
            this.dgvItems.DataSource = this.itemsToAddBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvItems.Location = new System.Drawing.Point(15, 16);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(720, 150);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvItems_CellBeginEdit);
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            this.dgvItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvItems_CellValidating);
            this.dgvItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItems_DataError);
            // 
            // itemsToAddBindingSource
            // 
            this.itemsToAddBindingSource.DataMember = "ItemsToAdd";
            this.itemsToAddBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // panSupplierStockItems
            // 
            this.panSupplierStockItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panSupplierStockItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupplierStockItems.Controls.Add(this.dgvSupplierStock);
            this.panSupplierStockItems.Location = new System.Drawing.Point(151, 163);
            this.panSupplierStockItems.Name = "panSupplierStockItems";
            this.panSupplierStockItems.Size = new System.Drawing.Size(1147, 192);
            this.panSupplierStockItems.TabIndex = 0;
            // 
            // dgvSupplierStock
            // 
            this.dgvSupplierStock.AutoGenerateColumns = false;
            this.dgvSupplierStock.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvSupplierStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSupplierStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
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
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierStock.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSupplierStock.EnableHeadersVisualStyles = false;
            this.dgvSupplierStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSupplierStock.Location = new System.Drawing.Point(15, 22);
            this.dgvSupplierStock.Name = "dgvSupplierStock";
            this.dgvSupplierStock.ReadOnly = true;
            this.dgvSupplierStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSupplierStock.RowHeadersWidth = 51;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSupplierStock.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSupplierStock.Size = new System.Drawing.Size(1098, 150);
            this.dgvSupplierStock.TabIndex = 0;
            this.dgvSupplierStock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSupplierStock_RowHeaderMouseClick);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // tabOrderDetails
            // 
            this.tabOrderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabOrderDetails.Controls.Add(this.btnUpdateStatus);
            this.tabOrderDetails.Controls.Add(this.label4);
            this.tabOrderDetails.Controls.Add(this.label3);
            this.tabOrderDetails.Controls.Add(this.panSupplierOtderLine);
            this.tabOrderDetails.Controls.Add(this.panSupplierOrders);
            this.tabOrderDetails.Location = new System.Drawing.Point(4, 26);
            this.tabOrderDetails.Name = "tabOrderDetails";
            this.tabOrderDetails.Size = new System.Drawing.Size(1457, 691);
            this.tabOrderDetails.TabIndex = 2;
            this.tabOrderDetails.Text = "Order Details";
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(1114, 335);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(153, 60);
            this.btnUpdateStatus.TabIndex = 1;
            this.btnUpdateStatus.Text = "Update Order Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier Order Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Order";
            // 
            // panSupplierOtderLine
            // 
            this.panSupplierOtderLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panSupplierOtderLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupplierOtderLine.Controls.Add(this.dgvOrderLines);
            this.panSupplierOtderLine.Location = new System.Drawing.Point(261, 399);
            this.panSupplierOtderLine.Name = "panSupplierOtderLine";
            this.panSupplierOtderLine.Size = new System.Drawing.Size(619, 192);
            this.panSupplierOtderLine.TabIndex = 1;
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AutoGenerateColumns = false;
            this.dgvOrderLines.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvOrderLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.SupplierOrderIDLine,
            this.QuantityLine,
            this.priceDataGridViewTextBoxColumn});
            this.dgvOrderLines.DataSource = this.supplierLineOrderBindingSource;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderLines.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvOrderLines.EnableHeadersVisualStyles = false;
            this.dgvOrderLines.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderLines.Location = new System.Drawing.Point(21, 28);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvOrderLines.RowHeadersWidth = 51;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrderLines.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvOrderLines.Size = new System.Drawing.Size(573, 150);
            this.dgvOrderLines.TabIndex = 0;
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.Width = 125;
            // 
            // SupplierOrderIDLine
            // 
            this.SupplierOrderIDLine.DataPropertyName = "SupplierOrderID";
            this.SupplierOrderIDLine.HeaderText = "OrderID";
            this.SupplierOrderIDLine.MinimumWidth = 6;
            this.SupplierOrderIDLine.Name = "SupplierOrderIDLine";
            this.SupplierOrderIDLine.Width = 125;
            // 
            // QuantityLine
            // 
            this.QuantityLine.DataPropertyName = "Quantity";
            this.QuantityLine.HeaderText = "Quantity";
            this.QuantityLine.MinimumWidth = 6;
            this.QuantityLine.Name = "QuantityLine";
            this.QuantityLine.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierLineOrderBindingSource
            // 
            this.supplierLineOrderBindingSource.DataMember = "SupplierLineOrder";
            this.supplierLineOrderBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // panSupplierOrders
            // 
            this.panSupplierOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panSupplierOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupplierOrders.Controls.Add(this.dgvOrderTable);
            this.panSupplierOrders.Location = new System.Drawing.Point(261, 122);
            this.panSupplierOrders.Name = "panSupplierOrders";
            this.panSupplierOrders.Size = new System.Drawing.Size(1006, 197);
            this.panSupplierOrders.TabIndex = 0;
            // 
            // dgvOrderTable
            // 
            this.dgvOrderTable.AutoGenerateColumns = false;
            this.dgvOrderTable.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvOrderTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
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
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderTable.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvOrderTable.EnableHeadersVisualStyles = false;
            this.dgvOrderTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderTable.Location = new System.Drawing.Point(21, 29);
            this.dgvOrderTable.Name = "dgvOrderTable";
            this.dgvOrderTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvOrderTable.RowHeadersWidth = 51;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrderTable.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvOrderTable.Size = new System.Drawing.Size(961, 150);
            this.dgvOrderTable.TabIndex = 0;
            this.dgvOrderTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderTable_CellValueChanged);
            this.dgvOrderTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderTable_RowHeaderMouseClick);
            // 
            // SupplierOrderID
            // 
            this.SupplierOrderID.DataPropertyName = "SupplierOrderID";
            this.SupplierOrderID.HeaderText = "OrderID";
            this.SupplierOrderID.MinimumWidth = 6;
            this.SupplierOrderID.Name = "SupplierOrderID";
            this.SupplierOrderID.ReadOnly = true;
            this.SupplierOrderID.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "OrderStatus";
            this.OrderStatus.MinimumWidth = 6;
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderStatus.Width = 125;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.FillWeight = 120F;
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.Width = 125;
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
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add New Product";
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
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // poductDescriptionDataGridViewTextBoxColumn
            // 
            this.poductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.poductDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn.Name = "poductDescriptionDataGridViewTextBoxColumn";
            this.poductDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.poductDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellingPriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "Buying Price";
            this.buyingPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            this.buyingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyingPriceDataGridViewTextBoxColumn.Width = 140;
            // 
            // stockOnHandDataGridViewTextBoxColumn
            // 
            this.stockOnHandDataGridViewTextBoxColumn.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn.Name = "stockOnHandDataGridViewTextBoxColumn";
            this.stockOnHandDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockOnHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            this.reorderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.reorderLevelDataGridViewTextBoxColumn.Width = 125;
            // 
            // expirationTimeDataGridViewTextBoxColumn
            // 
            this.expirationTimeDataGridViewTextBoxColumn.DataPropertyName = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.HeaderText = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationTimeDataGridViewTextBoxColumn.Name = "expirationTimeDataGridViewTextBoxColumn";
            this.expirationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.expirationTimeDataGridViewTextBoxColumn.Width = 125;
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
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // poductDescriptionDataGridViewTextBoxColumn1
            // 
            this.poductDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.poductDescriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn1.Name = "poductDescriptionDataGridViewTextBoxColumn1";
            this.poductDescriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.poductDescriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // buyingPriceDataGridViewTextBoxColumn1
            // 
            this.buyingPriceDataGridViewTextBoxColumn1.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn1.HeaderText = "Buying Price";
            this.buyingPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.buyingPriceDataGridViewTextBoxColumn1.Name = "buyingPriceDataGridViewTextBoxColumn1";
            this.buyingPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.buyingPriceDataGridViewTextBoxColumn1.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 721);
            this.Controls.Add(this.tcStockManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            this.panSupplierCartItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToAddBindingSource)).EndInit();
            this.panSupplierStockItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.tabOrderDetails.ResumeLayout(false);
            this.tabOrderDetails.PerformLayout();
            this.panSupplierOtderLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierLineOrderBindingSource)).EndInit();
            this.panSupplierOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcStockManagement;
        private System.Windows.Forms.TabPage tbpInventoryManagement;
        private System.Windows.Forms.TabPage tbpSupplierOrder;
        private System.Windows.Forms.Panel panSupplierStockItems;
        private System.Windows.Forms.DataGridView dgvSupplierStock;
        private WstGrp11DataSet wstGrp11DataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private WstGrp11DataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Panel panSupplierCartItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource itemsToAddBindingSource;
        private WstGrp11DataSetTableAdapters.ItemsToAddTableAdapter itemsToAddTableAdapter;
        private System.Windows.Forms.TabPage tabOrderDetails;
        private System.Windows.Forms.Panel panSupplierOrders;
        private System.Windows.Forms.DataGridView dgvOrderTable;
        private System.Windows.Forms.BindingSource supplierOrderBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter supplierOrderTableAdapter;
        private System.Windows.Forms.Panel panSupplierOtderLine;
        private System.Windows.Forms.DataGridView dgvOrderLines;
        private System.Windows.Forms.BindingSource supplierLineOrderBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierLineOrderTableAdapter supplierLineOrderTableAdapter;
        private System.Windows.Forms.TextBox tbItemSearch;
        private System.Windows.Forms.Label lblSearchItems;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblChooseSupplier;
        private System.Windows.Forms.Label lblCartHeading;
        private System.Windows.Forms.Label lblStockHeading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotalItemsCost;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblProductDesc;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.TextBox txtReorder;
        private System.Windows.Forms.TextBox txtBuy;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
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