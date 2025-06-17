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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcStockManagement = new System.Windows.Forms.TabControl();
            this.tbpInventoryManagement = new System.Windows.Forms.TabPage();
            this.btnManageInventoryHelp = new System.Windows.Forms.Button();
            this.btnViewLowStock = new System.Windows.Forms.Button();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.lblSearchByStockName = new System.Windows.Forms.Label();
            this.grpUpdateItemDetails = new System.Windows.Forms.GroupBox();
            this.btnUpdateItemDetails = new System.Windows.Forms.Button();
            this.txtProdBPriceUpdate = new System.Windows.Forms.TextBox();
            this.txtProdExpirUpdate = new System.Windows.Forms.TextBox();
            this.txtProdSPriceUpdate = new System.Windows.Forms.TextBox();
            this.txtProdDescUpdate = new System.Windows.Forms.TextBox();
            this.txtProdReorderUpdate = new System.Windows.Forms.TextBox();
            this.txtProdNameUpdate = new System.Windows.Forms.TextBox();
            this.lblExpirUpdate = new System.Windows.Forms.Label();
            this.lblReorderUpdate = new System.Windows.Forms.Label();
            this.lblBPriceUpdate = new System.Windows.Forms.Label();
            this.lblSPriceUpdate = new System.Windows.Forms.Label();
            this.lblDescUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.dgvUpdateStock = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.StockUpdateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.grpAddNewItem = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtReorder = new System.Windows.Forms.TextBox();
            this.lblProductDesc = new System.Windows.Forms.Label();
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblExpirAdd = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblReorderAdd = new System.Windows.Forms.Label();
            this.tbpSupplierOrder = new System.Windows.Forms.TabPage();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblTotalItemsCost = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCartHeading = new System.Windows.Forms.Label();
            this.lblStockHeading = new System.Windows.Forms.Label();
            this.lblChooseSupplier = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbItemSearch = new System.Windows.Forms.TextBox();
            this.lblSearchItems = new System.Windows.Forms.Label();
            this.panSupplierCartItems = new System.Windows.Forms.Panel();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.itemsToAddBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panSupplierStockItems = new System.Windows.Forms.Panel();
            this.dgvSupplierStock = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poductDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOnHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabOrderDetails = new System.Windows.Forms.TabPage();
            this.btnHelpOrderDetails = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.stockTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StockTableAdapter();
            this.itemsToAddTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.ItemsToAddTableAdapter();
            this.supplierLineOrderTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierLineOrderTableAdapter();
            this.supplierTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierTableAdapter();
            this.supplierOrderTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter();
            this.btnInventoryRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcStockManagement.SuspendLayout();
            this.tbpInventoryManagement.SuspendLayout();
            this.grpUpdateItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockUpdateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            this.grpAddNewItem.SuspendLayout();
            this.tbpSupplierOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
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
            this.tcStockManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcStockManagement.Name = "tcStockManagement";
            this.tcStockManagement.SelectedIndex = 0;
            this.tcStockManagement.Size = new System.Drawing.Size(1848, 750);
            this.tcStockManagement.TabIndex = 0;
            // 
            // tbpInventoryManagement
            // 
            this.tbpInventoryManagement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpInventoryManagement.Controls.Add(this.button1);
            this.tbpInventoryManagement.Controls.Add(this.btnInventoryRefresh);
            this.tbpInventoryManagement.Controls.Add(this.btnManageInventoryHelp);
            this.tbpInventoryManagement.Controls.Add(this.btnViewLowStock);
            this.tbpInventoryManagement.Controls.Add(this.txtSearchByName);
            this.tbpInventoryManagement.Controls.Add(this.lblSearchByStockName);
            this.tbpInventoryManagement.Controls.Add(this.grpUpdateItemDetails);
            this.tbpInventoryManagement.Controls.Add(this.dgvUpdateStock);
            this.tbpInventoryManagement.Controls.Add(this.grpAddNewItem);
            this.tbpInventoryManagement.Location = new System.Drawing.Point(4, 30);
            this.tbpInventoryManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInventoryManagement.Name = "tbpInventoryManagement";
            this.tbpInventoryManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInventoryManagement.Size = new System.Drawing.Size(1840, 716);
            this.tbpInventoryManagement.TabIndex = 0;
            this.tbpInventoryManagement.Text = "Manage Inventory";
            // 
            // btnManageInventoryHelp
            // 
            this.btnManageInventoryHelp.BackColor = System.Drawing.Color.LightBlue;
            this.btnManageInventoryHelp.Location = new System.Drawing.Point(1712, 6);
            this.btnManageInventoryHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageInventoryHelp.Name = "btnManageInventoryHelp";
            this.btnManageInventoryHelp.Size = new System.Drawing.Size(100, 38);
            this.btnManageInventoryHelp.TabIndex = 8;
            this.btnManageInventoryHelp.Text = "Help";
            this.btnManageInventoryHelp.UseVisualStyleBackColor = false;
            this.btnManageInventoryHelp.Click += new System.EventHandler(this.btnManageInventoryHelp_Click);
            // 
            // btnViewLowStock
            // 
            this.btnViewLowStock.BackColor = System.Drawing.Color.LightBlue;
            this.btnViewLowStock.Location = new System.Drawing.Point(1343, 147);
            this.btnViewLowStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewLowStock.Name = "btnViewLowStock";
            this.btnViewLowStock.Size = new System.Drawing.Size(213, 48);
            this.btnViewLowStock.TabIndex = 7;
            this.btnViewLowStock.Text = "View Low Stock";
            this.btnViewLowStock.UseVisualStyleBackColor = false;
            this.btnViewLowStock.Click += new System.EventHandler(this.btnViewLowStock_Click);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(1344, 74);
            this.txtSearchByName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(212, 29);
            this.txtSearchByName.TabIndex = 6;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblSearchByStockName
            // 
            this.lblSearchByStockName.AutoSize = true;
            this.lblSearchByStockName.Location = new System.Drawing.Point(1340, 37);
            this.lblSearchByStockName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByStockName.Name = "lblSearchByStockName";
            this.lblSearchByStockName.Size = new System.Drawing.Size(194, 23);
            this.lblSearchByStockName.TabIndex = 4;
            this.lblSearchByStockName.Text = "Search by Stock Name:";
            // 
            // grpUpdateItemDetails
            // 
            this.grpUpdateItemDetails.Controls.Add(this.btnUpdateItemDetails);
            this.grpUpdateItemDetails.Controls.Add(this.txtProdBPriceUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.txtProdExpirUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.txtProdSPriceUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.txtProdDescUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.txtProdReorderUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.txtProdNameUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.lblExpirUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.lblReorderUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.lblBPriceUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.lblSPriceUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.lblDescUpdate);
            this.grpUpdateItemDetails.Controls.Add(this.lblNameUpdate);
            this.grpUpdateItemDetails.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUpdateItemDetails.Location = new System.Drawing.Point(245, 533);
            this.grpUpdateItemDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateItemDetails.Name = "grpUpdateItemDetails";
            this.grpUpdateItemDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpUpdateItemDetails.Size = new System.Drawing.Size(1312, 185);
            this.grpUpdateItemDetails.TabIndex = 3;
            this.grpUpdateItemDetails.TabStop = false;
            this.grpUpdateItemDetails.Text = "Edit Stock Details";
            // 
            // btnUpdateItemDetails
            // 
            this.btnUpdateItemDetails.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateItemDetails.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItemDetails.Location = new System.Drawing.Point(992, 110);
            this.btnUpdateItemDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateItemDetails.Name = "btnUpdateItemDetails";
            this.btnUpdateItemDetails.Size = new System.Drawing.Size(281, 44);
            this.btnUpdateItemDetails.TabIndex = 13;
            this.btnUpdateItemDetails.Text = "Update Item Details";
            this.btnUpdateItemDetails.UseVisualStyleBackColor = false;
            this.btnUpdateItemDetails.Click += new System.EventHandler(this.btnUpdateItemDetails_Click);
            // 
            // txtProdBPriceUpdate
            // 
            this.txtProdBPriceUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.txtProdBPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdBPriceUpdate.Location = new System.Drawing.Point(1051, 59);
            this.txtProdBPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdBPriceUpdate.Name = "txtProdBPriceUpdate";
            this.txtProdBPriceUpdate.Size = new System.Drawing.Size(221, 23);
            this.txtProdBPriceUpdate.TabIndex = 11;
            // 
            // txtProdExpirUpdate
            // 
            this.txtProdExpirUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.txtProdExpirUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdExpirUpdate.Location = new System.Drawing.Point(387, 129);
            this.txtProdExpirUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdExpirUpdate.Name = "txtProdExpirUpdate";
            this.txtProdExpirUpdate.Size = new System.Drawing.Size(227, 23);
            this.txtProdExpirUpdate.TabIndex = 10;
            // 
            // txtProdSPriceUpdate
            // 
            this.txtProdSPriceUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.txtProdSPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSPriceUpdate.Location = new System.Drawing.Point(715, 57);
            this.txtProdSPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdSPriceUpdate.Name = "txtProdSPriceUpdate";
            this.txtProdSPriceUpdate.Size = new System.Drawing.Size(225, 23);
            this.txtProdSPriceUpdate.TabIndex = 9;
            // 
            // txtProdDescUpdate
            // 
            this.txtProdDescUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.txtProdDescUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDescUpdate.Location = new System.Drawing.Point(387, 60);
            this.txtProdDescUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdDescUpdate.Name = "txtProdDescUpdate";
            this.txtProdDescUpdate.Size = new System.Drawing.Size(227, 23);
            this.txtProdDescUpdate.TabIndex = 8;
            // 
            // txtProdReorderUpdate
            // 
            this.txtProdReorderUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.txtProdReorderUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdReorderUpdate.Location = new System.Drawing.Point(37, 129);
            this.txtProdReorderUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdReorderUpdate.Name = "txtProdReorderUpdate";
            this.txtProdReorderUpdate.Size = new System.Drawing.Size(227, 23);
            this.txtProdReorderUpdate.TabIndex = 7;
            // 
            // txtProdNameUpdate
            // 
            this.txtProdNameUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.txtProdNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdNameUpdate.Location = new System.Drawing.Point(37, 60);
            this.txtProdNameUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdNameUpdate.Name = "txtProdNameUpdate";
            this.txtProdNameUpdate.Size = new System.Drawing.Size(227, 23);
            this.txtProdNameUpdate.TabIndex = 6;
            // 
            // lblExpirUpdate
            // 
            this.lblExpirUpdate.AutoSize = true;
            this.lblExpirUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirUpdate.Location = new System.Drawing.Point(49, 400);
            this.lblExpirUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirUpdate.Name = "lblExpirUpdate";
            this.lblExpirUpdate.Size = new System.Drawing.Size(226, 28);
            this.lblExpirUpdate.TabIndex = 5;
            this.lblExpirUpdate.Text = "Expiration time (days):";
            // 
            // lblReorderUpdate
            // 
            this.lblReorderUpdate.AutoSize = true;
            this.lblReorderUpdate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderUpdate.Location = new System.Drawing.Point(51, 330);
            this.lblReorderUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReorderUpdate.Name = "lblReorderUpdate";
            this.lblReorderUpdate.Size = new System.Drawing.Size(142, 28);
            this.lblReorderUpdate.TabIndex = 4;
            this.lblReorderUpdate.Text = "Reorder level:";
            // 
            // lblBPriceUpdate
            // 
            this.lblBPriceUpdate.AutoSize = true;
            this.lblBPriceUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPriceUpdate.Location = new System.Drawing.Point(1051, 39);
            this.lblBPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBPriceUpdate.Name = "lblBPriceUpdate";
            this.lblBPriceUpdate.Size = new System.Drawing.Size(93, 20);
            this.lblBPriceUpdate.TabIndex = 3;
            this.lblBPriceUpdate.Text = "Buying Price:";
            // 
            // lblSPriceUpdate
            // 
            this.lblSPriceUpdate.AutoSize = true;
            this.lblSPriceUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPriceUpdate.Location = new System.Drawing.Point(712, 37);
            this.lblSPriceUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSPriceUpdate.Name = "lblSPriceUpdate";
            this.lblSPriceUpdate.Size = new System.Drawing.Size(93, 20);
            this.lblSPriceUpdate.TabIndex = 2;
            this.lblSPriceUpdate.Text = "Selling Price:";
            // 
            // lblDescUpdate
            // 
            this.lblDescUpdate.AutoSize = true;
            this.lblDescUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescUpdate.Location = new System.Drawing.Point(387, 39);
            this.lblDescUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescUpdate.Name = "lblDescUpdate";
            this.lblDescUpdate.Size = new System.Drawing.Size(143, 20);
            this.lblDescUpdate.TabIndex = 1;
            this.lblDescUpdate.Text = "Product Description:";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUpdate.Location = new System.Drawing.Point(37, 39);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(107, 20);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Product Name:";
            // 
            // dgvUpdateStock
            // 
            this.dgvUpdateStock.AutoGenerateColumns = false;
            this.dgvUpdateStock.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvUpdateStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpdateStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dgvUpdateStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdateStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.poductDescriptionDataGridViewTextBoxColumn2,
            this.sellingPriceDataGridViewTextBoxColumn1,
            this.buyingPriceDataGridViewTextBoxColumn2,
            this.stockOnHandDataGridViewTextBoxColumn1,
            this.reorderLevelDataGridViewTextBoxColumn1,
            this.expirationTimeDataGridViewTextBoxColumn1});
            this.dgvUpdateStock.DataSource = this.stockBindingSource1;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUpdateStock.DefaultCellStyle = dataGridViewCellStyle56;
            this.dgvUpdateStock.EnableHeadersVisualStyles = false;
            this.dgvUpdateStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvUpdateStock.Location = new System.Drawing.Point(245, 37);
            this.dgvUpdateStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUpdateStock.Name = "dgvUpdateStock";
            this.dgvUpdateStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUpdateStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvUpdateStock.RowHeadersWidth = 51;
            this.dgvUpdateStock.Size = new System.Drawing.Size(1063, 250);
            this.dgvUpdateStock.TabIndex = 2;
            this.dgvUpdateStock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUpdateStock_RowHeaderMouseClick);
            // 
            // stockIDDataGridViewTextBoxColumn2
            // 
            this.stockIDDataGridViewTextBoxColumn2.DataPropertyName = "StockID";
            this.stockIDDataGridViewTextBoxColumn2.HeaderText = "StockID";
            this.stockIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.stockIDDataGridViewTextBoxColumn2.Name = "stockIDDataGridViewTextBoxColumn2";
            this.stockIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn2.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 90;
            // 
            // poductDescriptionDataGridViewTextBoxColumn2
            // 
            this.poductDescriptionDataGridViewTextBoxColumn2.DataPropertyName = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn2.HeaderText = "PoductDescription";
            this.poductDescriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.poductDescriptionDataGridViewTextBoxColumn2.Name = "poductDescriptionDataGridViewTextBoxColumn2";
            this.poductDescriptionDataGridViewTextBoxColumn2.Width = 155;
            // 
            // sellingPriceDataGridViewTextBoxColumn1
            // 
            this.sellingPriceDataGridViewTextBoxColumn1.DataPropertyName = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.HeaderText = "SellingPrice";
            this.sellingPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sellingPriceDataGridViewTextBoxColumn1.Name = "sellingPriceDataGridViewTextBoxColumn1";
            this.sellingPriceDataGridViewTextBoxColumn1.Width = 80;
            // 
            // buyingPriceDataGridViewTextBoxColumn2
            // 
            this.buyingPriceDataGridViewTextBoxColumn2.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn2.HeaderText = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.buyingPriceDataGridViewTextBoxColumn2.Name = "buyingPriceDataGridViewTextBoxColumn2";
            this.buyingPriceDataGridViewTextBoxColumn2.Width = 80;
            // 
            // stockOnHandDataGridViewTextBoxColumn1
            // 
            this.stockOnHandDataGridViewTextBoxColumn1.DataPropertyName = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn1.HeaderText = "StockOnHand";
            this.stockOnHandDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stockOnHandDataGridViewTextBoxColumn1.Name = "stockOnHandDataGridViewTextBoxColumn1";
            this.stockOnHandDataGridViewTextBoxColumn1.Width = 95;
            // 
            // reorderLevelDataGridViewTextBoxColumn1
            // 
            this.reorderLevelDataGridViewTextBoxColumn1.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn1.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.reorderLevelDataGridViewTextBoxColumn1.Name = "reorderLevelDataGridViewTextBoxColumn1";
            this.reorderLevelDataGridViewTextBoxColumn1.Width = 90;
            // 
            // expirationTimeDataGridViewTextBoxColumn1
            // 
            this.expirationTimeDataGridViewTextBoxColumn1.DataPropertyName = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn1.HeaderText = "ExpirationTime";
            this.expirationTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.expirationTimeDataGridViewTextBoxColumn1.Name = "expirationTimeDataGridViewTextBoxColumn1";
            this.expirationTimeDataGridViewTextBoxColumn1.Width = 90;
            // 
            // stockBindingSource1
            // 
            this.stockBindingSource1.DataMember = "Stock";
            this.stockBindingSource1.DataSource = this.StockUpdateBindingSource;
            // 
            // StockUpdateBindingSource
            // 
            this.StockUpdateBindingSource.DataSource = this.wstGrp11DataSet;
            this.StockUpdateBindingSource.Position = 0;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpAddNewItem
            // 
            this.grpAddNewItem.Controls.Add(this.btnAddItem);
            this.grpAddNewItem.Controls.Add(this.txtName);
            this.grpAddNewItem.Controls.Add(this.txtExpiration);
            this.grpAddNewItem.Controls.Add(this.lblProductName);
            this.grpAddNewItem.Controls.Add(this.txtReorder);
            this.grpAddNewItem.Controls.Add(this.lblProductDesc);
            this.grpAddNewItem.Controls.Add(this.txtBuy);
            this.grpAddNewItem.Controls.Add(this.txtDesc);
            this.grpAddNewItem.Controls.Add(this.txtSell);
            this.grpAddNewItem.Controls.Add(this.lblSell);
            this.grpAddNewItem.Controls.Add(this.lblExpirAdd);
            this.grpAddNewItem.Controls.Add(this.lblBuy);
            this.grpAddNewItem.Controls.Add(this.lblReorderAdd);
            this.grpAddNewItem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddNewItem.Location = new System.Drawing.Point(245, 319);
            this.grpAddNewItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddNewItem.Name = "grpAddNewItem";
            this.grpAddNewItem.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddNewItem.Size = new System.Drawing.Size(1312, 180);
            this.grpAddNewItem.TabIndex = 1;
            this.grpAddNewItem.TabStop = false;
            this.grpAddNewItem.Text = "Add New Inventory Item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddItem.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(992, 113);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(281, 44);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "Add Item to Inventory";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightBlue;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(37, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 23);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtExpiration
            // 
            this.txtExpiration.BackColor = System.Drawing.Color.LightBlue;
            this.txtExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiration.Location = new System.Drawing.Point(387, 133);
            this.txtExpiration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(225, 23);
            this.txtExpiration.TabIndex = 11;
            this.txtExpiration.TextChanged += new System.EventHandler(this.txtExpiration_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(33, 42);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(107, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtReorder
            // 
            this.txtReorder.BackColor = System.Drawing.Color.LightBlue;
            this.txtReorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorder.Location = new System.Drawing.Point(37, 133);
            this.txtReorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.Size = new System.Drawing.Size(227, 23);
            this.txtReorder.TabIndex = 10;
            this.txtReorder.TextChanged += new System.EventHandler(this.txtReorder_TextChanged);
            // 
            // lblProductDesc
            // 
            this.lblProductDesc.AutoSize = true;
            this.lblProductDesc.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDesc.Location = new System.Drawing.Point(383, 42);
            this.lblProductDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductDesc.Name = "lblProductDesc";
            this.lblProductDesc.Size = new System.Drawing.Size(143, 20);
            this.lblProductDesc.TabIndex = 1;
            this.lblProductDesc.Text = "Product Description:";
            // 
            // txtBuy
            // 
            this.txtBuy.BackColor = System.Drawing.Color.LightBlue;
            this.txtBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuy.Location = new System.Drawing.Point(1047, 62);
            this.txtBuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(225, 23);
            this.txtBuy.TabIndex = 9;
            this.txtBuy.TextChanged += new System.EventHandler(this.txtBuy_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.LightBlue;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(385, 62);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(227, 23);
            this.txtDesc.TabIndex = 7;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // txtSell
            // 
            this.txtSell.BackColor = System.Drawing.Color.LightBlue;
            this.txtSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell.Location = new System.Drawing.Point(715, 62);
            this.txtSell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(225, 23);
            this.txtSell.TabIndex = 8;
            this.txtSell.TextChanged += new System.EventHandler(this.txtSell_TextChanged);
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSell.Location = new System.Drawing.Point(711, 42);
            this.lblSell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(93, 20);
            this.lblSell.TabIndex = 2;
            this.lblSell.Text = "Selling Price:";
            // 
            // lblExpirAdd
            // 
            this.lblExpirAdd.AutoSize = true;
            this.lblExpirAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirAdd.Location = new System.Drawing.Point(383, 113);
            this.lblExpirAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirAdd.Name = "lblExpirAdd";
            this.lblExpirAdd.Size = new System.Drawing.Size(162, 20);
            this.lblExpirAdd.TabIndex = 5;
            this.lblExpirAdd.Text = "Expiration Time (Days):";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuy.Location = new System.Drawing.Point(1047, 42);
            this.lblBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(93, 20);
            this.lblBuy.TabIndex = 3;
            this.lblBuy.Text = "Buying Price:";
            // 
            // lblReorderAdd
            // 
            this.lblReorderAdd.AutoSize = true;
            this.lblReorderAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReorderAdd.Location = new System.Drawing.Point(33, 113);
            this.lblReorderAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReorderAdd.Name = "lblReorderAdd";
            this.lblReorderAdd.Size = new System.Drawing.Size(103, 20);
            this.lblReorderAdd.TabIndex = 4;
            this.lblReorderAdd.Text = "Reorder Level:";
            // 
            // tbpSupplierOrder
            // 
            this.tbpSupplierOrder.AutoScroll = true;
            this.tbpSupplierOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpSupplierOrder.Controls.Add(this.btnHelp);
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
            this.tbpSupplierOrder.Location = new System.Drawing.Point(4, 30);
            this.tbpSupplierOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSupplierOrder.Name = "tbpSupplierOrder";
            this.tbpSupplierOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSupplierOrder.Size = new System.Drawing.Size(1840, 716);
            this.tbpSupplierOrder.TabIndex = 1;
            this.tbpSupplierOrder.Text = "Supplier Orders";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.LightBlue;
            this.btnHelp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(207, 74);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(151, 63);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.LightBlue;
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(1496, 517);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(239, 30);
            this.tbTotal.TabIndex = 11;
            this.tbTotal.Text = "0";
            // 
            // lblTotalItemsCost
            // 
            this.lblTotalItemsCost.AutoSize = true;
            this.lblTotalItemsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItemsCost.Location = new System.Drawing.Point(1423, 519);
            this.lblTotalItemsCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalItemsCost.Name = "lblTotalItemsCost";
            this.lblTotalItemsCost.Size = new System.Drawing.Size(61, 25);
            this.lblTotalItemsCost.TabIndex = 10;
            this.lblTotalItemsCost.Text = "Total";
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.LightGreen;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(1585, 577);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(151, 63);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1428, 577);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 63);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCartHeading
            // 
            this.lblCartHeading.AutoSize = true;
            this.lblCartHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartHeading.Location = new System.Drawing.Point(247, 462);
            this.lblCartHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartHeading.Name = "lblCartHeading";
            this.lblCartHeading.Size = new System.Drawing.Size(53, 25);
            this.lblCartHeading.TabIndex = 7;
            this.lblCartHeading.Text = "Cart";
            // 
            // lblStockHeading
            // 
            this.lblStockHeading.AutoSize = true;
            this.lblStockHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockHeading.Location = new System.Drawing.Point(247, 162);
            this.lblStockHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockHeading.Name = "lblStockHeading";
            this.lblStockHeading.Size = new System.Drawing.Size(67, 25);
            this.lblStockHeading.TabIndex = 6;
            this.lblStockHeading.Text = "Stock";
            // 
            // lblChooseSupplier
            // 
            this.lblChooseSupplier.AutoSize = true;
            this.lblChooseSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSupplier.Location = new System.Drawing.Point(447, 92);
            this.lblChooseSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseSupplier.Name = "lblChooseSupplier";
            this.lblChooseSupplier.Size = new System.Drawing.Size(92, 25);
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
            this.cbSupplier.Location = new System.Drawing.Point(555, 89);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(337, 33);
            this.cbSupplier.TabIndex = 4;
            this.cbSupplier.ValueMember = "SupplierID";
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // tbItemSearch
            // 
            this.tbItemSearch.BackColor = System.Drawing.Color.LightBlue;
            this.tbItemSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItemSearch.Location = new System.Drawing.Point(1120, 86);
            this.tbItemSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbItemSearch.Name = "tbItemSearch";
            this.tbItemSearch.Size = new System.Drawing.Size(493, 34);
            this.tbItemSearch.TabIndex = 3;
            this.tbItemSearch.TextChanged += new System.EventHandler(this.tbItemSearch_TextChanged);
            // 
            // lblSearchItems
            // 
            this.lblSearchItems.AutoSize = true;
            this.lblSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItems.Location = new System.Drawing.Point(969, 92);
            this.lblSearchItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchItems.Name = "lblSearchItems";
            this.lblSearchItems.Size = new System.Drawing.Size(128, 25);
            this.lblSearchItems.TabIndex = 2;
            this.lblSearchItems.Text = "Search Item";
            // 
            // panSupplierCartItems
            // 
            this.panSupplierCartItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupplierCartItems.Controls.Add(this.dgvItems);
            this.panSupplierCartItems.Location = new System.Drawing.Point(207, 475);
            this.panSupplierCartItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panSupplierCartItems.Name = "panSupplierCartItems";
            this.panSupplierCartItems.Size = new System.Drawing.Size(1193, 227);
            this.panSupplierCartItems.TabIndex = 1;
            // 
            // dgvItems
            // 
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.poductDescriptionDataGridViewTextBoxColumn1,
            this.buyingPriceDataGridViewTextBoxColumn1,
            this.Quantity,
            this.Delete});
            this.dgvItems.DataSource = this.itemsToAddBindingSource;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle59;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvItems.Location = new System.Drawing.Point(20, 20);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(1145, 185);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvItems_CellBeginEdit);
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            this.dgvItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvItems_CellValidating);
            this.dgvItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItems_DataError);
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
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "DELETE";
            this.Delete.ToolTipText = "Delete the current row";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
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
            this.panSupplierStockItems.Location = new System.Drawing.Point(207, 175);
            this.panSupplierStockItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panSupplierStockItems.Name = "panSupplierStockItems";
            this.panSupplierStockItems.Size = new System.Drawing.Size(1529, 236);
            this.panSupplierStockItems.TabIndex = 0;
            // 
            // dgvSupplierStock
            // 
            this.dgvSupplierStock.AutoGenerateColumns = false;
            this.dgvSupplierStock.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvSupplierStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSupplierStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
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
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierStock.DefaultCellStyle = dataGridViewCellStyle62;
            this.dgvSupplierStock.EnableHeadersVisualStyles = false;
            this.dgvSupplierStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvSupplierStock.Location = new System.Drawing.Point(20, 27);
            this.dgvSupplierStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSupplierStock.Name = "dgvSupplierStock";
            this.dgvSupplierStock.ReadOnly = true;
            this.dgvSupplierStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.dgvSupplierStock.RowHeadersWidth = 51;
            dataGridViewCellStyle64.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSupplierStock.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvSupplierStock.Size = new System.Drawing.Size(1464, 185);
            this.dgvSupplierStock.TabIndex = 0;
            this.dgvSupplierStock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSupplierStock_RowHeaderMouseClick);
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
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // tabOrderDetails
            // 
            this.tabOrderDetails.AutoScroll = true;
            this.tabOrderDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabOrderDetails.Controls.Add(this.btnHelpOrderDetails);
            this.tabOrderDetails.Controls.Add(this.btnUpdateStatus);
            this.tabOrderDetails.Controls.Add(this.label4);
            this.tabOrderDetails.Controls.Add(this.label3);
            this.tabOrderDetails.Controls.Add(this.panSupplierOtderLine);
            this.tabOrderDetails.Controls.Add(this.panSupplierOrders);
            this.tabOrderDetails.Location = new System.Drawing.Point(4, 30);
            this.tabOrderDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabOrderDetails.Name = "tabOrderDetails";
            this.tabOrderDetails.Size = new System.Drawing.Size(1840, 716);
            this.tabOrderDetails.TabIndex = 2;
            this.tabOrderDetails.Text = "Order Details";
            // 
            // btnHelpOrderDetails
            // 
            this.btnHelpOrderDetails.BackColor = System.Drawing.Color.LightBlue;
            this.btnHelpOrderDetails.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpOrderDetails.Location = new System.Drawing.Point(348, 30);
            this.btnHelpOrderDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelpOrderDetails.Name = "btnHelpOrderDetails";
            this.btnHelpOrderDetails.Size = new System.Drawing.Size(147, 53);
            this.btnHelpOrderDetails.TabIndex = 4;
            this.btnHelpOrderDetails.Text = "Help";
            this.btnHelpOrderDetails.UseVisualStyleBackColor = false;
            this.btnHelpOrderDetails.Click += new System.EventHandler(this.btnHelpOrderDetails_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.Location = new System.Drawing.Point(1485, 373);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(204, 74);
            this.btnUpdateStatus.TabIndex = 1;
            this.btnUpdateStatus.Text = "Update Order Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Supplier Order Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier Order";
            // 
            // panSupplierOtderLine
            // 
            this.panSupplierOtderLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panSupplierOtderLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSupplierOtderLine.Controls.Add(this.dgvOrderLines);
            this.panSupplierOtderLine.Location = new System.Drawing.Point(348, 452);
            this.panSupplierOtderLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panSupplierOtderLine.Name = "panSupplierOtderLine";
            this.panSupplierOtderLine.Size = new System.Drawing.Size(945, 236);
            this.panSupplierOtderLine.TabIndex = 1;
            // 
            // dgvOrderLines
            // 
            this.dgvOrderLines.AutoGenerateColumns = false;
            this.dgvOrderLines.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvOrderLines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle65.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.SupplierOrderIDLine,
            this.QuantityLine,
            this.priceDataGridViewTextBoxColumn});
            this.dgvOrderLines.DataSource = this.supplierLineOrderBindingSource;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderLines.DefaultCellStyle = dataGridViewCellStyle66;
            this.dgvOrderLines.EnableHeadersVisualStyles = false;
            this.dgvOrderLines.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderLines.Location = new System.Drawing.Point(28, 34);
            this.dgvOrderLines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrderLines.Name = "dgvOrderLines";
            this.dgvOrderLines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderLines.RowHeadersDefaultCellStyle = dataGridViewCellStyle67;
            this.dgvOrderLines.RowHeadersWidth = 51;
            dataGridViewCellStyle68.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrderLines.RowsDefaultCellStyle = dataGridViewCellStyle68;
            this.dgvOrderLines.Size = new System.Drawing.Size(892, 185);
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
            this.panSupplierOrders.Location = new System.Drawing.Point(348, 111);
            this.panSupplierOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panSupplierOrders.Name = "panSupplierOrders";
            this.panSupplierOrders.Size = new System.Drawing.Size(1341, 242);
            this.panSupplierOrders.TabIndex = 0;
            // 
            // dgvOrderTable
            // 
            this.dgvOrderTable.AutoGenerateColumns = false;
            this.dgvOrderTable.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvOrderTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle69.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle69.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle69;
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
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderTable.DefaultCellStyle = dataGridViewCellStyle70;
            this.dgvOrderTable.EnableHeadersVisualStyles = false;
            this.dgvOrderTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderTable.Location = new System.Drawing.Point(28, 36);
            this.dgvOrderTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrderTable.Name = "dgvOrderTable";
            this.dgvOrderTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle71;
            this.dgvOrderTable.RowHeadersWidth = 51;
            dataGridViewCellStyle72.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrderTable.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvOrderTable.Size = new System.Drawing.Size(1281, 185);
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 0;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // itemsToAddTableAdapter
            // 
            this.itemsToAddTableAdapter.ClearBeforeFill = true;
            // 
            // supplierLineOrderTableAdapter
            // 
            this.supplierLineOrderTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierOrderTableAdapter
            // 
            this.supplierOrderTableAdapter.ClearBeforeFill = true;
            // 
            // btnInventoryRefresh
            // 
            this.btnInventoryRefresh.BackColor = System.Drawing.Color.LightBlue;
            this.btnInventoryRefresh.Location = new System.Drawing.Point(1344, 253);
            this.btnInventoryRefresh.Name = "btnInventoryRefresh";
            this.btnInventoryRefresh.Size = new System.Drawing.Size(213, 44);
            this.btnInventoryRefresh.TabIndex = 9;
            this.btnInventoryRefresh.Text = "Refresh";
            this.btnInventoryRefresh.UseVisualStyleBackColor = false;
            this.btnInventoryRefresh.Click += new System.EventHandler(this.btnInventoryRefresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(1343, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Order Low Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 750);
            this.Controls.Add(this.tcStockManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmStockManagement";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.frmStockManagement_Load);
            this.tcStockManagement.ResumeLayout(false);
            this.tbpInventoryManagement.ResumeLayout(false);
            this.tbpInventoryManagement.PerformLayout();
            this.grpUpdateItemDetails.ResumeLayout(false);
            this.grpUpdateItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdateStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockUpdateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            this.grpAddNewItem.ResumeLayout(false);
            this.grpAddNewItem.PerformLayout();
            this.tbpSupplierOrder.ResumeLayout(false);
            this.tbpSupplierOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panSupplierOtderLine;
        private System.Windows.Forms.DataGridView dgvOrderLines;
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
        private System.Windows.Forms.Label lblExpirAdd;
        private System.Windows.Forms.Label lblReorderAdd;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.GroupBox grpAddNewItem;
        private System.Windows.Forms.DataGridView dgvUpdateStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource supplierOrderBindingSource;
        private System.Windows.Forms.BindingSource supplierLineOrderBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private WstGrp11DataSetTableAdapters.SupplierOrderTableAdapter supplierOrderTableAdapter;
        private System.Windows.Forms.BindingSource StockUpdateBindingSource;
        private System.Windows.Forms.BindingSource stockBindingSource1;
        private System.Windows.Forms.GroupBox grpUpdateItemDetails;
        private System.Windows.Forms.Button btnUpdateItemDetails;
        private System.Windows.Forms.TextBox txtProdBPriceUpdate;
        private System.Windows.Forms.TextBox txtProdExpirUpdate;
        private System.Windows.Forms.TextBox txtProdSPriceUpdate;
        private System.Windows.Forms.TextBox txtProdDescUpdate;
        private System.Windows.Forms.TextBox txtProdReorderUpdate;
        private System.Windows.Forms.TextBox txtProdNameUpdate;
        private System.Windows.Forms.Label lblExpirUpdate;
        private System.Windows.Forms.Label lblReorderUpdate;
        private System.Windows.Forms.Label lblBPriceUpdate;
        private System.Windows.Forms.Label lblSPriceUpdate;
        private System.Windows.Forms.Label lblDescUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockOnHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poductDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnHelpOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierOrderIDLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Label lblSearchByStockName;
        private System.Windows.Forms.Button btnViewLowStock;
        private System.Windows.Forms.Button btnManageInventoryHelp;
        private System.Windows.Forms.Button btnInventoryRefresh;
        private System.Windows.Forms.Button button1;
    }
}