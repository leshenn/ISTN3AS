namespace Istn3ASproject
{
    partial class frmUserManagement
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
            System.Windows.Forms.Label lblSupplierSearch;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcUserManagement = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.btnCustomerRestore = new System.Windows.Forms.Button();
            this.gbUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.mtUpdateCustContact = new System.Windows.Forms.MaskedTextBox();
            this.lblEditCusPostal = new System.Windows.Forms.Label();
            this.txtUaddress = new System.Windows.Forms.TextBox();
            this.lblEditCusCity = new System.Windows.Forms.Label();
            this.lblEditCusProvince = new System.Windows.Forms.Label();
            this.txtUcode = new System.Windows.Forms.TextBox();
            this.txtUfname = new System.Windows.Forms.TextBox();
            this.txtUcity = new System.Windows.Forms.TextBox();
            this.txtUemail = new System.Windows.Forms.TextBox();
            this.cbUprovince = new System.Windows.Forms.ComboBox();
            this.lblEditCusEmail = new System.Windows.Forms.Label();
            this.lblEditCusFname = new System.Windows.Forms.Label();
            this.lblEditCusLname = new System.Windows.Forms.Label();
            this.lblEditCusNumber = new System.Windows.Forms.Label();
            this.txtUlname = new System.Windows.Forms.TextBox();
            this.lblEditCusAddress = new System.Windows.Forms.Label();
            this.gbAddCustomer = new System.Windows.Forms.GroupBox();
            this.mtCustomerNo = new System.Windows.Forms.MaskedTextBox();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lblCustomerPostal = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.lblCustomerProvince = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblCusFname1 = new System.Windows.Forms.Label();
            this.lblCusLname = new System.Windows.Forms.Label();
            this.lblCusNum = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.mtSearchNo = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchByNo = new System.Windows.Forms.Button();
            this.lblSearchByPhoneNumber = new System.Windows.Forms.Label();
            this.tbpStaff = new System.Windows.Forms.TabPage();
            this.gbStaff = new System.Windows.Forms.GroupBox();
            this.dgvStaffMgt = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnArchiveStaff = new System.Windows.Forms.Button();
            this.txtSearchStaffByName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbFilterByRole = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbStaffRoleUpdate = new System.Windows.Forms.ComboBox();
            this.txtContactUpdate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastNameUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStaffRole = new System.Windows.Forms.ComboBox();
            this.txtContactStaff = new System.Windows.Forms.MaskedTextBox();
            this.btnAddStaffMember = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastNameStaff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstNameStaff = new System.Windows.Forms.TextBox();
            this.txtPasswordStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernameStaff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpSuppliers = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvSupplier = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbUpdateSupplier = new System.Windows.Forms.GroupBox();
            this.mtEditSupplierContact = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateSupplier = new System.Windows.Forms.Button();
            this.lblSupplierEditPostal = new System.Windows.Forms.Label();
            this.txtEditSaddress = new System.Windows.Forms.TextBox();
            this.lblSupplierEditCity = new System.Windows.Forms.Label();
            this.lblSupplierEditProvince = new System.Windows.Forms.Label();
            this.txtEditScode = new System.Windows.Forms.TextBox();
            this.txtEditScity = new System.Windows.Forms.TextBox();
            this.txtEditSemail = new System.Windows.Forms.TextBox();
            this.cbEditSprovince = new System.Windows.Forms.ComboBox();
            this.lblSupplierEditEmail = new System.Windows.Forms.Label();
            this.lblSupplierEditName = new System.Windows.Forms.Label();
            this.lblSupplierEditNum = new System.Windows.Forms.Label();
            this.txtEditSname = new System.Windows.Forms.TextBox();
            this.lblSupplierEditAddress = new System.Windows.Forms.Label();
            this.gbAddSupplier = new System.Windows.Forms.GroupBox();
            this.mtSupplierContact = new System.Windows.Forms.MaskedTextBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lblSupplierPostal = new System.Windows.Forms.Label();
            this.txtSaddress = new System.Windows.Forms.TextBox();
            this.lblSupplierCity = new System.Windows.Forms.Label();
            this.lblSupplierProvince = new System.Windows.Forms.Label();
            this.txtScode = new System.Windows.Forms.TextBox();
            this.txtScity = new System.Windows.Forms.TextBox();
            this.txtSemail = new System.Windows.Forms.TextBox();
            this.cbSprovince = new System.Windows.Forms.ComboBox();
            this.lblSupplierEmail = new System.Windows.Forms.Label();
            this.lblSupplierFname = new System.Windows.Forms.Label();
            this.lblSupplierNum = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.CustomerTableAdapter();
            this.staffTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StaffTableAdapter();
            this.supplierTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierTableAdapter();
            lblSupplierSearch = new System.Windows.Forms.Label();
            this.tcUserManagement.SuspendLayout();
            this.tbpCustomers.SuspendLayout();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            this.gbUpdateCustomer.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            this.tbpStaff.SuspendLayout();
            this.gbStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpSuppliers.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.gbUpdateSupplier.SuspendLayout();
            this.gbAddSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupplierSearch
            // 
            lblSupplierSearch.AutoSize = true;
            lblSupplierSearch.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSupplierSearch.Location = new System.Drawing.Point(360, 49);
            lblSupplierSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSupplierSearch.Name = "lblSupplierSearch";
            lblSupplierSearch.Size = new System.Drawing.Size(267, 32);
            lblSupplierSearch.TabIndex = 1;
            lblSupplierSearch.Text = "Enter Supplier\'s Name";
            // 
            // tcUserManagement
            // 
            this.tcUserManagement.Controls.Add(this.tbpCustomers);
            this.tcUserManagement.Controls.Add(this.tbpStaff);
            this.tcUserManagement.Controls.Add(this.tbpSuppliers);
            this.tcUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUserManagement.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUserManagement.Location = new System.Drawing.Point(0, 0);
            this.tcUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcUserManagement.Name = "tcUserManagement";
            this.tcUserManagement.SelectedIndex = 0;
            this.tcUserManagement.Size = new System.Drawing.Size(1942, 757);
            this.tcUserManagement.TabIndex = 0;
            // 
            // tbpCustomers
            // 
            this.tbpCustomers.AutoScroll = true;
            this.tbpCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpCustomers.Controls.Add(this.btnNewOrder);
            this.tbpCustomers.Controls.Add(this.gbCustomer);
            this.tbpCustomers.Controls.Add(this.btnCustomerRestore);
            this.tbpCustomers.Controls.Add(this.gbUpdateCustomer);
            this.tbpCustomers.Controls.Add(this.gbAddCustomer);
            this.tbpCustomers.Controls.Add(this.mtSearchNo);
            this.tbpCustomers.Controls.Add(this.btnSearchByNo);
            this.tbpCustomers.Controls.Add(this.lblSearchByPhoneNumber);
            this.tbpCustomers.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCustomers.Location = new System.Drawing.Point(4, 30);
            this.tbpCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(4);
            this.tbpCustomers.Size = new System.Drawing.Size(1934, 723);
            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "Customers";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Nirmala UI", 9.7F, System.Drawing.FontStyle.Bold);
            this.btnNewOrder.Location = new System.Drawing.Point(1499, 350);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(205, 42);
            this.btnNewOrder.TabIndex = 40;
            this.btnNewOrder.Text = "Create a New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.gvCustomer);
            this.gbCustomer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomer.Location = new System.Drawing.Point(269, 117);
            this.gbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.gbCustomer.Size = new System.Drawing.Size(1223, 275);
            this.gbCustomer.TabIndex = 39;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // gvCustomer
            // 
            this.gvCustomer.AllowUserToAddRows = false;
            this.gvCustomer.AutoGenerateColumns = false;
            this.gvCustomer.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Address,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn});
            this.gvCustomer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvCustomer.EnableHeadersVisualStyles = false;
            this.gvCustomer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvCustomer.Location = new System.Drawing.Point(24, 34);
            this.gvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gvCustomer.Name = "gvCustomer";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvCustomer.RowHeadersWidth = 51;
            this.gvCustomer.RowTemplate.Height = 24;
            this.gvCustomer.Size = new System.Drawing.Size(1133, 213);
            this.gvCustomer.TabIndex = 0;
            this.gvCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvCustomer_RowHeaderMouseClick);
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
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 90;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            this.provinceDataGridViewTextBoxColumn.Width = 125;
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "Postal Code";
            this.postalCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            this.postalCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCustomerRestore
            // 
            this.btnCustomerRestore.BackColor = System.Drawing.Color.LightBlue;
            this.btnCustomerRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerRestore.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRestore.Location = new System.Drawing.Point(1287, 42);
            this.btnCustomerRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerRestore.Name = "btnCustomerRestore";
            this.btnCustomerRestore.Size = new System.Drawing.Size(159, 41);
            this.btnCustomerRestore.TabIndex = 38;
            this.btnCustomerRestore.Text = "Restore";
            this.btnCustomerRestore.UseVisualStyleBackColor = false;
            this.btnCustomerRestore.Click += new System.EventHandler(this.btnCustomerRestore_Click);
            // 
            // gbUpdateCustomer
            // 
            this.gbUpdateCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.gbUpdateCustomer.Controls.Add(this.btnUpdateCustomer);
            this.gbUpdateCustomer.Controls.Add(this.mtUpdateCustContact);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusPostal);
            this.gbUpdateCustomer.Controls.Add(this.txtUaddress);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusCity);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusProvince);
            this.gbUpdateCustomer.Controls.Add(this.txtUcode);
            this.gbUpdateCustomer.Controls.Add(this.txtUfname);
            this.gbUpdateCustomer.Controls.Add(this.txtUcity);
            this.gbUpdateCustomer.Controls.Add(this.txtUemail);
            this.gbUpdateCustomer.Controls.Add(this.cbUprovince);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusEmail);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusFname);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusLname);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusNumber);
            this.gbUpdateCustomer.Controls.Add(this.txtUlname);
            this.gbUpdateCustomer.Controls.Add(this.lblEditCusAddress);
            this.gbUpdateCustomer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdateCustomer.Location = new System.Drawing.Point(269, 642);
            this.gbUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gbUpdateCustomer.Name = "gbUpdateCustomer";
            this.gbUpdateCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.gbUpdateCustomer.Size = new System.Drawing.Size(1493, 239);
            this.gbUpdateCustomer.TabIndex = 35;
            this.gbUpdateCustomer.TabStop = false;
            this.gbUpdateCustomer.Text = "Update Customer Details *(Please Select a Customer First)";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(1280, 166);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(192, 54);
            this.btnUpdateCustomer.TabIndex = 50;
            this.btnUpdateCustomer.Text = "Update Customer Details";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            this.btnUpdateCustomer.MouseLeave += new System.EventHandler(this.btnUpdateCustomer_MouseLeave);
            this.btnUpdateCustomer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUpdateCustomer_MouseMove);
            // 
            // mtUpdateCustContact
            // 
            this.mtUpdateCustContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtUpdateCustContact.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtUpdateCustContact.Location = new System.Drawing.Point(627, 76);
            this.mtUpdateCustContact.Margin = new System.Windows.Forms.Padding(4);
            this.mtUpdateCustContact.Mask = "(999) 000-0000";
            this.mtUpdateCustContact.Name = "mtUpdateCustContact";
            this.mtUpdateCustContact.Size = new System.Drawing.Size(197, 32);
            this.mtUpdateCustContact.TabIndex = 49;
            // 
            // lblEditCusPostal
            // 
            this.lblEditCusPostal.AutoSize = true;
            this.lblEditCusPostal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusPostal.Location = new System.Drawing.Point(633, 128);
            this.lblEditCusPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusPostal.Name = "lblEditCusPostal";
            this.lblEditCusPostal.Size = new System.Drawing.Size(103, 23);
            this.lblEditCusPostal.TabIndex = 37;
            this.lblEditCusPostal.Text = "Postal Code";
            // 
            // txtUaddress
            // 
            this.txtUaddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUaddress.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUaddress.Location = new System.Drawing.Point(1103, 76);
            this.txtUaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtUaddress.Name = "txtUaddress";
            this.txtUaddress.Size = new System.Drawing.Size(244, 32);
            this.txtUaddress.TabIndex = 43;
            // 
            // lblEditCusCity
            // 
            this.lblEditCusCity.AutoSize = true;
            this.lblEditCusCity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusCity.Location = new System.Drawing.Point(32, 128);
            this.lblEditCusCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusCity.Name = "lblEditCusCity";
            this.lblEditCusCity.Size = new System.Drawing.Size(42, 23);
            this.lblEditCusCity.TabIndex = 46;
            this.lblEditCusCity.Text = "City";
            // 
            // lblEditCusProvince
            // 
            this.lblEditCusProvince.AutoSize = true;
            this.lblEditCusProvince.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusProvince.Location = new System.Drawing.Point(333, 128);
            this.lblEditCusProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusProvince.Name = "lblEditCusProvince";
            this.lblEditCusProvince.Size = new System.Drawing.Size(78, 23);
            this.lblEditCusProvince.TabIndex = 48;
            this.lblEditCusProvince.Text = "Province";
            // 
            // txtUcode
            // 
            this.txtUcode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUcode.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcode.Location = new System.Drawing.Point(627, 166);
            this.txtUcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtUcode.Name = "txtUcode";
            this.txtUcode.Size = new System.Drawing.Size(197, 32);
            this.txtUcode.TabIndex = 45;
            // 
            // txtUfname
            // 
            this.txtUfname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUfname.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUfname.Location = new System.Drawing.Point(35, 76);
            this.txtUfname.Margin = new System.Windows.Forms.Padding(4);
            this.txtUfname.Name = "txtUfname";
            this.txtUfname.Size = new System.Drawing.Size(232, 32);
            this.txtUfname.TabIndex = 34;
            // 
            // txtUcity
            // 
            this.txtUcity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUcity.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcity.Location = new System.Drawing.Point(36, 166);
            this.txtUcity.Margin = new System.Windows.Forms.Padding(4);
            this.txtUcity.Name = "txtUcity";
            this.txtUcity.Size = new System.Drawing.Size(231, 32);
            this.txtUcity.TabIndex = 44;
            // 
            // txtUemail
            // 
            this.txtUemail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUemail.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUemail.Location = new System.Drawing.Point(863, 76);
            this.txtUemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUemail.Name = "txtUemail";
            this.txtUemail.Size = new System.Drawing.Size(216, 32);
            this.txtUemail.TabIndex = 42;
            // 
            // cbUprovince
            // 
            this.cbUprovince.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbUprovince.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUprovince.FormattingEnabled = true;
            this.cbUprovince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "North West",
            "Northern Cape",
            "Western Cape"});
            this.cbUprovince.Location = new System.Drawing.Point(337, 166);
            this.cbUprovince.Margin = new System.Windows.Forms.Padding(4);
            this.cbUprovince.Name = "cbUprovince";
            this.cbUprovince.Size = new System.Drawing.Size(231, 28);
            this.cbUprovince.TabIndex = 47;
            // 
            // lblEditCusEmail
            // 
            this.lblEditCusEmail.AutoSize = true;
            this.lblEditCusEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusEmail.Location = new System.Drawing.Point(859, 43);
            this.lblEditCusEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusEmail.Name = "lblEditCusEmail";
            this.lblEditCusEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEditCusEmail.TabIndex = 40;
            this.lblEditCusEmail.Text = "Email";
            // 
            // lblEditCusFname
            // 
            this.lblEditCusFname.AutoSize = true;
            this.lblEditCusFname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusFname.Location = new System.Drawing.Point(31, 43);
            this.lblEditCusFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusFname.Name = "lblEditCusFname";
            this.lblEditCusFname.Size = new System.Drawing.Size(97, 23);
            this.lblEditCusFname.TabIndex = 36;
            this.lblEditCusFname.Text = "First Name";
            // 
            // lblEditCusLname
            // 
            this.lblEditCusLname.AutoSize = true;
            this.lblEditCusLname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusLname.Location = new System.Drawing.Point(332, 43);
            this.lblEditCusLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusLname.Name = "lblEditCusLname";
            this.lblEditCusLname.Size = new System.Drawing.Size(94, 23);
            this.lblEditCusLname.TabIndex = 38;
            this.lblEditCusLname.Text = "Last Name";
            // 
            // lblEditCusNumber
            // 
            this.lblEditCusNumber.AutoSize = true;
            this.lblEditCusNumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusNumber.Location = new System.Drawing.Point(623, 43);
            this.lblEditCusNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusNumber.Name = "lblEditCusNumber";
            this.lblEditCusNumber.Size = new System.Drawing.Size(143, 23);
            this.lblEditCusNumber.TabIndex = 39;
            this.lblEditCusNumber.Text = "Contact Number";
            // 
            // txtUlname
            // 
            this.txtUlname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUlname.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUlname.Location = new System.Drawing.Point(337, 76);
            this.txtUlname.Margin = new System.Windows.Forms.Padding(4);
            this.txtUlname.Name = "txtUlname";
            this.txtUlname.Size = new System.Drawing.Size(231, 32);
            this.txtUlname.TabIndex = 35;
            // 
            // lblEditCusAddress
            // 
            this.lblEditCusAddress.AutoSize = true;
            this.lblEditCusAddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusAddress.Location = new System.Drawing.Point(1099, 43);
            this.lblEditCusAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditCusAddress.Name = "lblEditCusAddress";
            this.lblEditCusAddress.Size = new System.Drawing.Size(74, 23);
            this.lblEditCusAddress.TabIndex = 41;
            this.lblEditCusAddress.Text = "Address";
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.BackColor = System.Drawing.Color.LightBlue;
            this.gbAddCustomer.Controls.Add(this.mtCustomerNo);
            this.gbAddCustomer.Controls.Add(this.btnNewCustomer);
            this.gbAddCustomer.Controls.Add(this.lblCustomerPostal);
            this.gbAddCustomer.Controls.Add(this.txtAddress);
            this.gbAddCustomer.Controls.Add(this.lblCustomerCity);
            this.gbAddCustomer.Controls.Add(this.lblCustomerProvince);
            this.gbAddCustomer.Controls.Add(this.txtPostalCode);
            this.gbAddCustomer.Controls.Add(this.txtFName);
            this.gbAddCustomer.Controls.Add(this.txtCity);
            this.gbAddCustomer.Controls.Add(this.txtEmail);
            this.gbAddCustomer.Controls.Add(this.cbProvince);
            this.gbAddCustomer.Controls.Add(this.lblCustomerEmail);
            this.gbAddCustomer.Controls.Add(this.lblCusFname1);
            this.gbAddCustomer.Controls.Add(this.lblCusLname);
            this.gbAddCustomer.Controls.Add(this.lblCusNum);
            this.gbAddCustomer.Controls.Add(this.txtLName);
            this.gbAddCustomer.Controls.Add(this.lblCustomerAddress);
            this.gbAddCustomer.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCustomer.Location = new System.Drawing.Point(269, 415);
            this.gbAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddCustomer.Size = new System.Drawing.Size(1493, 206);
            this.gbAddCustomer.TabIndex = 34;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add New Customer";
            // 
            // mtCustomerNo
            // 
            this.mtCustomerNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtCustomerNo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCustomerNo.Location = new System.Drawing.Point(640, 69);
            this.mtCustomerNo.Margin = new System.Windows.Forms.Padding(4);
            this.mtCustomerNo.Mask = "(999) 000-0000";
            this.mtCustomerNo.Name = "mtCustomerNo";
            this.mtCustomerNo.Size = new System.Drawing.Size(197, 32);
            this.mtCustomerNo.TabIndex = 33;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCustomer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewCustomer.Location = new System.Drawing.Point(1280, 132);
            this.btnNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(192, 57);
            this.btnNewCustomer.TabIndex = 18;
            this.btnNewCustomer.Text = "Add New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click_1);
            this.btnNewCustomer.MouseLeave += new System.EventHandler(this.btnNewCustomer_MouseLeave);
            this.btnNewCustomer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNewCustomer_MouseMove);
            // 
            // lblCustomerPostal
            // 
            this.lblCustomerPostal.AutoSize = true;
            this.lblCustomerPostal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPostal.Location = new System.Drawing.Point(636, 114);
            this.lblCustomerPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerPostal.Name = "lblCustomerPostal";
            this.lblCustomerPostal.Size = new System.Drawing.Size(103, 23);
            this.lblCustomerPostal.TabIndex = 19;
            this.lblCustomerPostal.Text = "Postal Code";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAddress.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(1104, 69);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 32);
            this.txtAddress.TabIndex = 26;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCity.Location = new System.Drawing.Point(20, 114);
            this.lblCustomerCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(42, 23);
            this.lblCustomerCity.TabIndex = 29;
            this.lblCustomerCity.Text = "City";
            // 
            // lblCustomerProvince
            // 
            this.lblCustomerProvince.AutoSize = true;
            this.lblCustomerProvince.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerProvince.Location = new System.Drawing.Point(333, 114);
            this.lblCustomerProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerProvince.Name = "lblCustomerProvince";
            this.lblCustomerProvince.Size = new System.Drawing.Size(78, 23);
            this.lblCustomerProvince.TabIndex = 31;
            this.lblCustomerProvince.Text = "Province";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPostalCode.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(640, 149);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(197, 32);
            this.txtPostalCode.TabIndex = 28;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(24, 69);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(231, 32);
            this.txtFName.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCity.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(24, 149);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(231, 32);
            this.txtCity.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(864, 69);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 32);
            this.txtEmail.TabIndex = 25;
            // 
            // cbProvince
            // 
            this.cbProvince.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbProvince.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "North West",
            "Northern Cape",
            "Western Cape"});
            this.cbProvince.Location = new System.Drawing.Point(339, 146);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(4);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(231, 28);
            this.cbProvince.TabIndex = 30;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(860, 36);
            this.lblCustomerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(54, 23);
            this.lblCustomerEmail.TabIndex = 22;
            this.lblCustomerEmail.Text = "Email";
            // 
            // lblCusFname1
            // 
            this.lblCusFname1.AutoSize = true;
            this.lblCusFname1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusFname1.Location = new System.Drawing.Point(20, 36);
            this.lblCusFname1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusFname1.Name = "lblCusFname1";
            this.lblCusFname1.Size = new System.Drawing.Size(110, 23);
            this.lblCusFname1.TabIndex = 17;
            this.lblCusFname1.Text = "* First Name";
            // 
            // lblCusLname
            // 
            this.lblCusLname.AutoSize = true;
            this.lblCusLname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusLname.Location = new System.Drawing.Point(333, 36);
            this.lblCusLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusLname.Name = "lblCusLname";
            this.lblCusLname.Size = new System.Drawing.Size(107, 23);
            this.lblCusLname.TabIndex = 20;
            this.lblCusLname.Text = "* Last Name";
            // 
            // lblCusNum
            // 
            this.lblCusNum.AutoSize = true;
            this.lblCusNum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusNum.Location = new System.Drawing.Point(635, 36);
            this.lblCusNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusNum.Name = "lblCusNum";
            this.lblCusNum.Size = new System.Drawing.Size(156, 23);
            this.lblCusNum.TabIndex = 21;
            this.lblCusNum.Text = "* Contact Number";
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLName.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(339, 69);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(231, 32);
            this.txtLName.TabIndex = 16;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(1100, 36);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(74, 23);
            this.lblCustomerAddress.TabIndex = 23;
            this.lblCustomerAddress.Text = "Address";
            // 
            // mtSearchNo
            // 
            this.mtSearchNo.BackColor = System.Drawing.Color.LightBlue;
            this.mtSearchNo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtSearchNo.Location = new System.Drawing.Point(833, 46);
            this.mtSearchNo.Margin = new System.Windows.Forms.Padding(4);
            this.mtSearchNo.Mask = "(999) 000-0000";
            this.mtSearchNo.Name = "mtSearchNo";
            this.mtSearchNo.Size = new System.Drawing.Size(185, 39);
            this.mtSearchNo.TabIndex = 32;
            // 
            // btnSearchByNo
            // 
            this.btnSearchByNo.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearchByNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchByNo.FlatAppearance.BorderSize = 0;
            this.btnSearchByNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByNo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByNo.Location = new System.Drawing.Point(1084, 42);
            this.btnSearchByNo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchByNo.Name = "btnSearchByNo";
            this.btnSearchByNo.Size = new System.Drawing.Size(159, 41);
            this.btnSearchByNo.TabIndex = 5;
            this.btnSearchByNo.Text = "Search";
            this.btnSearchByNo.UseVisualStyleBackColor = false;
            this.btnSearchByNo.Click += new System.EventHandler(this.btnSearchByNo_Click);
            this.btnSearchByNo.MouseLeave += new System.EventHandler(this.btnSearchByNo_MouseLeave);
            this.btnSearchByNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSearchByNo_MouseMove);
            // 
            // lblSearchByPhoneNumber
            // 
            this.lblSearchByPhoneNumber.AutoSize = true;
            this.lblSearchByPhoneNumber.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByPhoneNumber.Location = new System.Drawing.Point(493, 46);
            this.lblSearchByPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchByPhoneNumber.Name = "lblSearchByPhoneNumber";
            this.lblSearchByPhoneNumber.Size = new System.Drawing.Size(318, 32);
            this.lblSearchByPhoneNumber.TabIndex = 4;
            this.lblSearchByPhoneNumber.Text = "Search by Phone Number :";
            this.lblSearchByPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbpStaff
            // 
            this.tbpStaff.AutoScroll = true;
            this.tbpStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpStaff.Controls.Add(this.gbStaff);
            this.tbpStaff.Controls.Add(this.btnArchiveStaff);
            this.tbpStaff.Controls.Add(this.txtSearchStaffByName);
            this.tbpStaff.Controls.Add(this.label15);
            this.tbpStaff.Controls.Add(this.label14);
            this.tbpStaff.Controls.Add(this.cmbFilterByRole);
            this.tbpStaff.Controls.Add(this.groupBox2);
            this.tbpStaff.Controls.Add(this.groupBox1);
            this.tbpStaff.Location = new System.Drawing.Point(4, 30);
            this.tbpStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpStaff.Name = "tbpStaff";
            this.tbpStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpStaff.Size = new System.Drawing.Size(1934, 723);
            this.tbpStaff.TabIndex = 1;
            this.tbpStaff.Text = "Staff";
            // 
            // gbStaff
            // 
            this.gbStaff.Controls.Add(this.dgvStaffMgt);
            this.gbStaff.Location = new System.Drawing.Point(360, 127);
            this.gbStaff.Margin = new System.Windows.Forms.Padding(4);
            this.gbStaff.Name = "gbStaff";
            this.gbStaff.Padding = new System.Windows.Forms.Padding(4);
            this.gbStaff.Size = new System.Drawing.Size(1185, 252);
            this.gbStaff.TabIndex = 22;
            this.gbStaff.TabStop = false;
            this.gbStaff.Text = "Staff";
            // 
            // dgvStaffMgt
            // 
            this.dgvStaffMgt.AutoGenerateColumns = false;
            this.dgvStaffMgt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaffMgt.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvStaffMgt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMgt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaffMgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMgt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn1,
            this.userNameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn2,
            this.lastNameDataGridViewTextBoxColumn2,
            this.contactNoDataGridViewTextBoxColumn3,
            this.roleDataGridViewTextBoxColumn1});
            this.dgvStaffMgt.DataSource = this.staffBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaffMgt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaffMgt.EnableHeadersVisualStyles = false;
            this.dgvStaffMgt.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStaffMgt.Location = new System.Drawing.Point(33, 34);
            this.dgvStaffMgt.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStaffMgt.Name = "dgvStaffMgt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaffMgt.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStaffMgt.RowHeadersWidth = 51;
            this.dgvStaffMgt.Size = new System.Drawing.Size(1103, 185);
            this.dgvStaffMgt.TabIndex = 0;
            this.dgvStaffMgt.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaffMgt_CellMouseClick);
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            this.staffIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn1.Width = 95;
            // 
            // userNameDataGridViewTextBoxColumn1
            // 
            this.userNameDataGridViewTextBoxColumn1.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn1.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn1.Name = "userNameDataGridViewTextBoxColumn1";
            this.userNameDataGridViewTextBoxColumn1.Width = 120;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            this.passwordDataGridViewTextBoxColumn1.Width = 112;
            // 
            // firstNameDataGridViewTextBoxColumn2
            // 
            this.firstNameDataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn2.Name = "firstNameDataGridViewTextBoxColumn2";
            this.firstNameDataGridViewTextBoxColumn2.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn2
            // 
            this.lastNameDataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn2.Name = "lastNameDataGridViewTextBoxColumn2";
            this.lastNameDataGridViewTextBoxColumn2.Width = 117;
            // 
            // contactNoDataGridViewTextBoxColumn3
            // 
            this.contactNoDataGridViewTextBoxColumn3.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn3.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn3.Name = "contactNoDataGridViewTextBoxColumn3";
            this.contactNoDataGridViewTextBoxColumn3.Width = 123;
            // 
            // roleDataGridViewTextBoxColumn1
            // 
            this.roleDataGridViewTextBoxColumn1.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn1.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn1.Name = "roleDataGridViewTextBoxColumn1";
            this.roleDataGridViewTextBoxColumn1.Width = 73;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // btnArchiveStaff
            // 
            this.btnArchiveStaff.BackColor = System.Drawing.Color.LightBlue;
            this.btnArchiveStaff.ForeColor = System.Drawing.Color.Black;
            this.btnArchiveStaff.Location = new System.Drawing.Point(1269, 391);
            this.btnArchiveStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveStaff.Name = "btnArchiveStaff";
            this.btnArchiveStaff.Size = new System.Drawing.Size(283, 68);
            this.btnArchiveStaff.TabIndex = 21;
            this.btnArchiveStaff.Text = "Archive Staff Member";
            this.btnArchiveStaff.UseVisualStyleBackColor = false;
            this.btnArchiveStaff.Click += new System.EventHandler(this.btnArchiveStaff_Click);
            // 
            // txtSearchStaffByName
            // 
            this.txtSearchStaffByName.BackColor = System.Drawing.Color.LightBlue;
            this.txtSearchStaffByName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchStaffByName.Location = new System.Drawing.Point(639, 60);
            this.txtSearchStaffByName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchStaffByName.Name = "txtSearchStaffByName";
            this.txtSearchStaffByName.Size = new System.Drawing.Size(399, 39);
            this.txtSearchStaffByName.TabIndex = 19;
            this.txtSearchStaffByName.TextChanged += new System.EventHandler(this.txtSearchStaffByName_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(357, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 32);
            this.label15.TabIndex = 18;
            this.label15.Text = "Search Staff By Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1095, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 32);
            this.label14.TabIndex = 17;
            this.label14.Text = "Filter By Role:";
            // 
            // cmbFilterByRole
            // 
            this.cmbFilterByRole.BackColor = System.Drawing.Color.LightBlue;
            this.cmbFilterByRole.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterByRole.FormattingEnabled = true;
            this.cmbFilterByRole.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Cashier",
            "Terminated"});
            this.cmbFilterByRole.Location = new System.Drawing.Point(1277, 57);
            this.cmbFilterByRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilterByRole.Name = "cmbFilterByRole";
            this.cmbFilterByRole.Size = new System.Drawing.Size(273, 40);
            this.cmbFilterByRole.TabIndex = 16;
            this.cmbFilterByRole.Text = "Select Staff Role -->";
            this.cmbFilterByRole.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByRole_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbStaffRoleUpdate);
            this.groupBox2.Controls.Add(this.txtContactUpdate);
            this.groupBox2.Controls.Add(this.btnUpdateStaff);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtLastNameUpdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtNameUpdate);
            this.groupBox2.Controls.Add(this.txtPasswordUpdate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtUsernameUpdate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(348, 727);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1204, 218);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Staff Member";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 154);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(293, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "**Select A staff Member To Update";
            // 
            // cmbStaffRoleUpdate
            // 
            this.cmbStaffRoleUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbStaffRoleUpdate.FormattingEnabled = true;
            this.cmbStaffRoleUpdate.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Cashier"});
            this.cmbStaffRoleUpdate.Location = new System.Drawing.Point(19, 162);
            this.cmbStaffRoleUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStaffRoleUpdate.Name = "cmbStaffRoleUpdate";
            this.cmbStaffRoleUpdate.Size = new System.Drawing.Size(221, 29);
            this.cmbStaffRoleUpdate.TabIndex = 14;
            // 
            // txtContactUpdate
            // 
            this.txtContactUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContactUpdate.Location = new System.Drawing.Point(947, 78);
            this.txtContactUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactUpdate.Mask = "(999) 0000000";
            this.txtContactUpdate.Name = "txtContactUpdate";
            this.txtContactUpdate.Size = new System.Drawing.Size(196, 29);
            this.txtContactUpdate.TabIndex = 13;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateStaff.Location = new System.Drawing.Point(1013, 156);
            this.btnUpdateStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(160, 44);
            this.btnUpdateStaff.TabIndex = 12;
            this.btnUpdateStaff.Text = "Update Staff Member";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(941, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Contact No. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(721, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Last Name:";
            // 
            // txtLastNameUpdate
            // 
            this.txtLastNameUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLastNameUpdate.Location = new System.Drawing.Point(727, 78);
            this.txtLastNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastNameUpdate.Name = "txtLastNameUpdate";
            this.txtLastNameUpdate.Size = new System.Drawing.Size(176, 29);
            this.txtLastNameUpdate.TabIndex = 6;
            this.txtLastNameUpdate.TextChanged += new System.EventHandler(this.txtLastNameUpdate_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "First Name:";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNameUpdate.Location = new System.Drawing.Point(480, 78);
            this.txtNameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(209, 29);
            this.txtNameUpdate.TabIndex = 4;
            this.txtNameUpdate.TextChanged += new System.EventHandler(this.txtNameUpdate_TextChanged);
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPasswordUpdate.Location = new System.Drawing.Point(263, 78);
            this.txtPasswordUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(185, 29);
            this.txtPasswordUpdate.TabIndex = 3;
            this.txtPasswordUpdate.TextChanged += new System.EventHandler(this.txtPasswordUpdate_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password:";
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsernameUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameUpdate.Location = new System.Drawing.Point(19, 78);
            this.txtUsernameUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(221, 29);
            this.txtUsernameUpdate.TabIndex = 1;
            this.txtUsernameUpdate.TextChanged += new System.EventHandler(this.txtUsernameUpdate_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.cmbStaffRole);
            this.groupBox1.Controls.Add(this.txtContactStaff);
            this.groupBox1.Controls.Add(this.btnAddStaffMember);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLastNameStaff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstNameStaff);
            this.groupBox1.Controls.Add(this.txtPasswordStaff);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUsernameStaff);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(348, 471);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1204, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Staff Member";
            // 
            // cmbStaffRole
            // 
            this.cmbStaffRole.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbStaffRole.FormattingEnabled = true;
            this.cmbStaffRole.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Cashier"});
            this.cmbStaffRole.Location = new System.Drawing.Point(9, 175);
            this.cmbStaffRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStaffRole.Name = "cmbStaffRole";
            this.cmbStaffRole.Size = new System.Drawing.Size(231, 29);
            this.cmbStaffRole.TabIndex = 14;
            this.cmbStaffRole.Text = "Select Staff Role -->";
            // 
            // txtContactStaff
            // 
            this.txtContactStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContactStaff.Location = new System.Drawing.Point(947, 87);
            this.txtContactStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactStaff.Mask = "(999) 0000000";
            this.txtContactStaff.Name = "txtContactStaff";
            this.txtContactStaff.Size = new System.Drawing.Size(196, 29);
            this.txtContactStaff.TabIndex = 13;
            // 
            // btnAddStaffMember
            // 
            this.btnAddStaffMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStaffMember.Location = new System.Drawing.Point(1001, 166);
            this.btnAddStaffMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaffMember.Name = "btnAddStaffMember";
            this.btnAddStaffMember.Size = new System.Drawing.Size(160, 44);
            this.btnAddStaffMember.TabIndex = 12;
            this.btnAddStaffMember.Text = "Add Staff Member";
            this.btnAddStaffMember.UseVisualStyleBackColor = false;
            this.btnAddStaffMember.Click += new System.EventHandler(this.btnAddStaffMember_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(721, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // txtLastNameStaff
            // 
            this.txtLastNameStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLastNameStaff.Location = new System.Drawing.Point(727, 87);
            this.txtLastNameStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastNameStaff.Name = "txtLastNameStaff";
            this.txtLastNameStaff.Size = new System.Drawing.Size(176, 29);
            this.txtLastNameStaff.TabIndex = 6;
            this.txtLastNameStaff.TextChanged += new System.EventHandler(this.txtLastNameStaff_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            // 
            // txtFirstNameStaff
            // 
            this.txtFirstNameStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtFirstNameStaff.Location = new System.Drawing.Point(480, 87);
            this.txtFirstNameStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstNameStaff.Name = "txtFirstNameStaff";
            this.txtFirstNameStaff.Size = new System.Drawing.Size(209, 29);
            this.txtFirstNameStaff.TabIndex = 4;
            this.txtFirstNameStaff.TextChanged += new System.EventHandler(this.txtFirstNameStaff_TextChanged);
            // 
            // txtPasswordStaff
            // 
            this.txtPasswordStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPasswordStaff.Location = new System.Drawing.Point(268, 87);
            this.txtPasswordStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordStaff.Name = "txtPasswordStaff";
            this.txtPasswordStaff.Size = new System.Drawing.Size(180, 29);
            this.txtPasswordStaff.TabIndex = 3;
            this.txtPasswordStaff.TextChanged += new System.EventHandler(this.txtPasswordStaff_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsernameStaff
            // 
            this.txtUsernameStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsernameStaff.Location = new System.Drawing.Point(15, 87);
            this.txtUsernameStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsernameStaff.Name = "txtUsernameStaff";
            this.txtUsernameStaff.Size = new System.Drawing.Size(225, 29);
            this.txtUsernameStaff.TabIndex = 1;
            this.txtUsernameStaff.TextChanged += new System.EventHandler(this.txtUsernameStaff_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // tbpSuppliers
            // 
            this.tbpSuppliers.AutoScroll = true;
            this.tbpSuppliers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbpSuppliers.Controls.Add(this.groupBox3);
            this.tbpSuppliers.Controls.Add(this.gbUpdateSupplier);
            this.tbpSuppliers.Controls.Add(this.gbAddSupplier);
            this.tbpSuppliers.Controls.Add(this.button1);
            this.tbpSuppliers.Controls.Add(lblSupplierSearch);
            this.tbpSuppliers.Controls.Add(this.btnSearchSupplier);
            this.tbpSuppliers.Controls.Add(this.txtSearch);
            this.tbpSuppliers.Location = new System.Drawing.Point(4, 30);
            this.tbpSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpSuppliers.Name = "tbpSuppliers";
            this.tbpSuppliers.Size = new System.Drawing.Size(1934, 723);
            this.tbpSuppliers.TabIndex = 2;
            this.tbpSuppliers.Text = "Suppliers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvSupplier);
            this.groupBox3.Location = new System.Drawing.Point(255, 123);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1483, 277);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier";
            // 
            // gvSupplier
            // 
            this.gvSupplier.AllowUserToAddRows = false;
            this.gvSupplier.AutoGenerateColumns = false;
            this.gvSupplier.BackgroundColor = System.Drawing.Color.LightBlue;
            this.gvSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn2,
            this.emailDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn1,
            this.provinceDataGridViewTextBoxColumn1,
            this.postalCodeDataGridViewTextBoxColumn1});
            this.gvSupplier.DataSource = this.supplierBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSupplier.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvSupplier.EnableHeadersVisualStyles = false;
            this.gvSupplier.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvSupplier.Location = new System.Drawing.Point(27, 37);
            this.gvSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.gvSupplier.Name = "gvSupplier";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvSupplier.RowHeadersWidth = 51;
            this.gvSupplier.RowTemplate.Height = 24;
            this.gvSupplier.Size = new System.Drawing.Size(1427, 218);
            this.gvSupplier.TabIndex = 0;
            this.gvSupplier.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvSupplier_RowHeaderMouseClick);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn2
            // 
            this.contactNoDataGridViewTextBoxColumn2.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn2.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn2.Name = "contactNoDataGridViewTextBoxColumn2";
            this.contactNoDataGridViewTextBoxColumn2.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn1
            // 
            this.cityDataGridViewTextBoxColumn1.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn1.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn1.Name = "cityDataGridViewTextBoxColumn1";
            this.cityDataGridViewTextBoxColumn1.Width = 125;
            // 
            // provinceDataGridViewTextBoxColumn1
            // 
            this.provinceDataGridViewTextBoxColumn1.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn1.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.provinceDataGridViewTextBoxColumn1.Name = "provinceDataGridViewTextBoxColumn1";
            this.provinceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // postalCodeDataGridViewTextBoxColumn1
            // 
            this.postalCodeDataGridViewTextBoxColumn1.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn1.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.postalCodeDataGridViewTextBoxColumn1.Name = "postalCodeDataGridViewTextBoxColumn1";
            this.postalCodeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // gbUpdateSupplier
            // 
            this.gbUpdateSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.gbUpdateSupplier.Controls.Add(this.mtEditSupplierContact);
            this.gbUpdateSupplier.Controls.Add(this.btnUpdateSupplier);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditPostal);
            this.gbUpdateSupplier.Controls.Add(this.txtEditSaddress);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditCity);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditProvince);
            this.gbUpdateSupplier.Controls.Add(this.txtEditScode);
            this.gbUpdateSupplier.Controls.Add(this.txtEditScity);
            this.gbUpdateSupplier.Controls.Add(this.txtEditSemail);
            this.gbUpdateSupplier.Controls.Add(this.cbEditSprovince);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditEmail);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditName);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditNum);
            this.gbUpdateSupplier.Controls.Add(this.txtEditSname);
            this.gbUpdateSupplier.Controls.Add(this.lblSupplierEditAddress);
            this.gbUpdateSupplier.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdateSupplier.Location = new System.Drawing.Point(255, 676);
            this.gbUpdateSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.gbUpdateSupplier.Name = "gbUpdateSupplier";
            this.gbUpdateSupplier.Padding = new System.Windows.Forms.Padding(4);
            this.gbUpdateSupplier.Size = new System.Drawing.Size(1483, 247);
            this.gbUpdateSupplier.TabIndex = 36;
            this.gbUpdateSupplier.TabStop = false;
            this.gbUpdateSupplier.Text = "Update Supplier Details";
            this.gbUpdateSupplier.Enter += new System.EventHandler(this.gbUpdateSupplier_Enter);
            // 
            // mtEditSupplierContact
            // 
            this.mtEditSupplierContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtEditSupplierContact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtEditSupplierContact.Location = new System.Drawing.Point(347, 79);
            this.mtEditSupplierContact.Margin = new System.Windows.Forms.Padding(4);
            this.mtEditSupplierContact.Mask = "(999) 000-0000";
            this.mtEditSupplierContact.Name = "mtEditSupplierContact";
            this.mtEditSupplierContact.Size = new System.Drawing.Size(197, 29);
            this.mtEditSupplierContact.TabIndex = 33;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(1216, 162);
            this.btnUpdateSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSupplier.Name = "btnUpdateSupplier";
            this.btnUpdateSupplier.Size = new System.Drawing.Size(199, 54);
            this.btnUpdateSupplier.TabIndex = 18;
            this.btnUpdateSupplier.Text = "Update Supplier Details";
            this.btnUpdateSupplier.UseVisualStyleBackColor = false;
            this.btnUpdateSupplier.Click += new System.EventHandler(this.btnUpdateSupplier_Click);
            // 
            // lblSupplierEditPostal
            // 
            this.lblSupplierEditPostal.AutoSize = true;
            this.lblSupplierEditPostal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditPostal.Location = new System.Drawing.Point(344, 142);
            this.lblSupplierEditPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditPostal.Name = "lblSupplierEditPostal";
            this.lblSupplierEditPostal.Size = new System.Drawing.Size(103, 23);
            this.lblSupplierEditPostal.TabIndex = 19;
            this.lblSupplierEditPostal.Text = "Postal Code";
            // 
            // txtEditSaddress
            // 
            this.txtEditSaddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEditSaddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSaddress.Location = new System.Drawing.Point(853, 79);
            this.txtEditSaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSaddress.Name = "txtEditSaddress";
            this.txtEditSaddress.Size = new System.Drawing.Size(231, 29);
            this.txtEditSaddress.TabIndex = 26;
            // 
            // lblSupplierEditCity
            // 
            this.lblSupplierEditCity.AutoSize = true;
            this.lblSupplierEditCity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditCity.Location = new System.Drawing.Point(1131, 46);
            this.lblSupplierEditCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditCity.Name = "lblSupplierEditCity";
            this.lblSupplierEditCity.Size = new System.Drawing.Size(42, 23);
            this.lblSupplierEditCity.TabIndex = 29;
            this.lblSupplierEditCity.Text = "City";
            // 
            // lblSupplierEditProvince
            // 
            this.lblSupplierEditProvince.AutoSize = true;
            this.lblSupplierEditProvince.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditProvince.Location = new System.Drawing.Point(48, 142);
            this.lblSupplierEditProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditProvince.Name = "lblSupplierEditProvince";
            this.lblSupplierEditProvince.Size = new System.Drawing.Size(78, 23);
            this.lblSupplierEditProvince.TabIndex = 31;
            this.lblSupplierEditProvince.Text = "Province";
            // 
            // txtEditScode
            // 
            this.txtEditScode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEditScode.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditScode.Location = new System.Drawing.Point(348, 183);
            this.txtEditScode.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditScode.Name = "txtEditScode";
            this.txtEditScode.Size = new System.Drawing.Size(196, 29);
            this.txtEditScode.TabIndex = 28;
            // 
            // txtEditScity
            // 
            this.txtEditScity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEditScity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditScity.Location = new System.Drawing.Point(1135, 79);
            this.txtEditScity.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditScity.Name = "txtEditScity";
            this.txtEditScity.Size = new System.Drawing.Size(219, 29);
            this.txtEditScity.TabIndex = 27;
            // 
            // txtEditSemail
            // 
            this.txtEditSemail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEditSemail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSemail.Location = new System.Drawing.Point(595, 79);
            this.txtEditSemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSemail.Name = "txtEditSemail";
            this.txtEditSemail.Size = new System.Drawing.Size(216, 29);
            this.txtEditSemail.TabIndex = 25;
            // 
            // cbEditSprovince
            // 
            this.cbEditSprovince.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbEditSprovince.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditSprovince.FormattingEnabled = true;
            this.cbEditSprovince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "North West",
            "Northern Cape",
            "Western Cape"});
            this.cbEditSprovince.Location = new System.Drawing.Point(49, 183);
            this.cbEditSprovince.Margin = new System.Windows.Forms.Padding(4);
            this.cbEditSprovince.Name = "cbEditSprovince";
            this.cbEditSprovince.Size = new System.Drawing.Size(247, 29);
            this.cbEditSprovince.TabIndex = 30;
            // 
            // lblSupplierEditEmail
            // 
            this.lblSupplierEditEmail.AutoSize = true;
            this.lblSupplierEditEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditEmail.Location = new System.Drawing.Point(591, 46);
            this.lblSupplierEditEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditEmail.Name = "lblSupplierEditEmail";
            this.lblSupplierEditEmail.Size = new System.Drawing.Size(54, 23);
            this.lblSupplierEditEmail.TabIndex = 22;
            this.lblSupplierEditEmail.Text = "Email";
            // 
            // lblSupplierEditName
            // 
            this.lblSupplierEditName.AutoSize = true;
            this.lblSupplierEditName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditName.Location = new System.Drawing.Point(48, 46);
            this.lblSupplierEditName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditName.Name = "lblSupplierEditName";
            this.lblSupplierEditName.Size = new System.Drawing.Size(57, 23);
            this.lblSupplierEditName.TabIndex = 20;
            this.lblSupplierEditName.Text = "Name";
            // 
            // lblSupplierEditNum
            // 
            this.lblSupplierEditNum.AutoSize = true;
            this.lblSupplierEditNum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditNum.Location = new System.Drawing.Point(343, 46);
            this.lblSupplierEditNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditNum.Name = "lblSupplierEditNum";
            this.lblSupplierEditNum.Size = new System.Drawing.Size(156, 23);
            this.lblSupplierEditNum.TabIndex = 21;
            this.lblSupplierEditNum.Text = "* Contact Number";
            // 
            // txtEditSname
            // 
            this.txtEditSname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEditSname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSname.Location = new System.Drawing.Point(48, 79);
            this.txtEditSname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSname.Name = "txtEditSname";
            this.txtEditSname.Size = new System.Drawing.Size(248, 29);
            this.txtEditSname.TabIndex = 16;
            // 
            // lblSupplierEditAddress
            // 
            this.lblSupplierEditAddress.AutoSize = true;
            this.lblSupplierEditAddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditAddress.Location = new System.Drawing.Point(849, 46);
            this.lblSupplierEditAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEditAddress.Name = "lblSupplierEditAddress";
            this.lblSupplierEditAddress.Size = new System.Drawing.Size(74, 23);
            this.lblSupplierEditAddress.TabIndex = 23;
            this.lblSupplierEditAddress.Text = "Address";
            // 
            // gbAddSupplier
            // 
            this.gbAddSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.gbAddSupplier.Controls.Add(this.mtSupplierContact);
            this.gbAddSupplier.Controls.Add(this.btnAddSupplier);
            this.gbAddSupplier.Controls.Add(this.lblSupplierPostal);
            this.gbAddSupplier.Controls.Add(this.txtSaddress);
            this.gbAddSupplier.Controls.Add(this.lblSupplierCity);
            this.gbAddSupplier.Controls.Add(this.lblSupplierProvince);
            this.gbAddSupplier.Controls.Add(this.txtScode);
            this.gbAddSupplier.Controls.Add(this.txtScity);
            this.gbAddSupplier.Controls.Add(this.txtSemail);
            this.gbAddSupplier.Controls.Add(this.cbSprovince);
            this.gbAddSupplier.Controls.Add(this.lblSupplierEmail);
            this.gbAddSupplier.Controls.Add(this.lblSupplierFname);
            this.gbAddSupplier.Controls.Add(this.lblSupplierNum);
            this.gbAddSupplier.Controls.Add(this.txtSname);
            this.gbAddSupplier.Controls.Add(this.lblSupplierAddress);
            this.gbAddSupplier.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddSupplier.Location = new System.Drawing.Point(255, 425);
            this.gbAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.gbAddSupplier.Name = "gbAddSupplier";
            this.gbAddSupplier.Padding = new System.Windows.Forms.Padding(4);
            this.gbAddSupplier.Size = new System.Drawing.Size(1483, 214);
            this.gbAddSupplier.TabIndex = 35;
            this.gbAddSupplier.TabStop = false;
            this.gbAddSupplier.Text = "Add New Supplier";
            // 
            // mtSupplierContact
            // 
            this.mtSupplierContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mtSupplierContact.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtSupplierContact.Location = new System.Drawing.Point(347, 80);
            this.mtSupplierContact.Margin = new System.Windows.Forms.Padding(4);
            this.mtSupplierContact.Mask = "(999) 000-0000";
            this.mtSupplierContact.Name = "mtSupplierContact";
            this.mtSupplierContact.Size = new System.Drawing.Size(197, 29);
            this.mtSupplierContact.TabIndex = 33;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSupplier.Location = new System.Drawing.Point(1216, 140);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(199, 54);
            this.btnAddSupplier.TabIndex = 18;
            this.btnAddSupplier.Text = "Add New Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lblSupplierPostal
            // 
            this.lblSupplierPostal.AutoSize = true;
            this.lblSupplierPostal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierPostal.Location = new System.Drawing.Point(344, 126);
            this.lblSupplierPostal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierPostal.Name = "lblSupplierPostal";
            this.lblSupplierPostal.Size = new System.Drawing.Size(103, 23);
            this.lblSupplierPostal.TabIndex = 19;
            this.lblSupplierPostal.Text = "Postal Code";
            // 
            // txtSaddress
            // 
            this.txtSaddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSaddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaddress.Location = new System.Drawing.Point(853, 80);
            this.txtSaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaddress.Name = "txtSaddress";
            this.txtSaddress.Size = new System.Drawing.Size(231, 29);
            this.txtSaddress.TabIndex = 26;
            // 
            // lblSupplierCity
            // 
            this.lblSupplierCity.AutoSize = true;
            this.lblSupplierCity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCity.Location = new System.Drawing.Point(1131, 47);
            this.lblSupplierCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierCity.Name = "lblSupplierCity";
            this.lblSupplierCity.Size = new System.Drawing.Size(42, 23);
            this.lblSupplierCity.TabIndex = 29;
            this.lblSupplierCity.Text = "City";
            // 
            // lblSupplierProvince
            // 
            this.lblSupplierProvince.AutoSize = true;
            this.lblSupplierProvince.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierProvince.Location = new System.Drawing.Point(48, 126);
            this.lblSupplierProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierProvince.Name = "lblSupplierProvince";
            this.lblSupplierProvince.Size = new System.Drawing.Size(78, 23);
            this.lblSupplierProvince.TabIndex = 31;
            this.lblSupplierProvince.Text = "Province";
            // 
            // txtScode
            // 
            this.txtScode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtScode.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScode.Location = new System.Drawing.Point(348, 167);
            this.txtScode.Margin = new System.Windows.Forms.Padding(4);
            this.txtScode.Name = "txtScode";
            this.txtScode.Size = new System.Drawing.Size(196, 29);
            this.txtScode.TabIndex = 28;
            // 
            // txtScity
            // 
            this.txtScity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtScity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScity.Location = new System.Drawing.Point(1135, 80);
            this.txtScity.Margin = new System.Windows.Forms.Padding(4);
            this.txtScity.Name = "txtScity";
            this.txtScity.Size = new System.Drawing.Size(219, 29);
            this.txtScity.TabIndex = 27;
            // 
            // txtSemail
            // 
            this.txtSemail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSemail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemail.Location = new System.Drawing.Point(595, 80);
            this.txtSemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSemail.Name = "txtSemail";
            this.txtSemail.Size = new System.Drawing.Size(216, 29);
            this.txtSemail.TabIndex = 25;
            // 
            // cbSprovince
            // 
            this.cbSprovince.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSprovince.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSprovince.FormattingEnabled = true;
            this.cbSprovince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "North West",
            "Northern Cape",
            "Western Cape"});
            this.cbSprovince.Location = new System.Drawing.Point(49, 167);
            this.cbSprovince.Margin = new System.Windows.Forms.Padding(4);
            this.cbSprovince.Name = "cbSprovince";
            this.cbSprovince.Size = new System.Drawing.Size(247, 29);
            this.cbSprovince.TabIndex = 30;
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEmail.Location = new System.Drawing.Point(615, 47);
            this.lblSupplierEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(54, 23);
            this.lblSupplierEmail.TabIndex = 22;
            this.lblSupplierEmail.Text = "Email";
            // 
            // lblSupplierFname
            // 
            this.lblSupplierFname.AutoSize = true;
            this.lblSupplierFname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierFname.Location = new System.Drawing.Point(44, 47);
            this.lblSupplierFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierFname.Name = "lblSupplierFname";
            this.lblSupplierFname.Size = new System.Drawing.Size(62, 23);
            this.lblSupplierFname.TabIndex = 20;
            this.lblSupplierFname.Text = " Name";
            // 
            // lblSupplierNum
            // 
            this.lblSupplierNum.AutoSize = true;
            this.lblSupplierNum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierNum.Location = new System.Drawing.Point(343, 47);
            this.lblSupplierNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierNum.Name = "lblSupplierNum";
            this.lblSupplierNum.Size = new System.Drawing.Size(156, 23);
            this.lblSupplierNum.TabIndex = 21;
            this.lblSupplierNum.Text = "* Contact Number";
            // 
            // txtSname
            // 
            this.txtSname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(48, 80);
            this.txtSname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(248, 29);
            this.txtSname.TabIndex = 16;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(861, 47);
            this.lblSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(74, 23);
            this.lblSupplierAddress.TabIndex = 23;
            this.lblSupplierAddress.Text = "Address";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1349, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1129, 46);
            this.btnSearchSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(169, 41);
            this.btnSearchSupplier.TabIndex = 3;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightBlue;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(665, 49);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(415, 32);
            this.txtSearch.TabIndex = 2;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.wstGrp11DataSet;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 78;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn1
            // 
            this.lastNameDataGridViewTextBoxColumn1.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn1.Name = "lastNameDataGridViewTextBoxColumn1";
            this.lastNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // contactNoDataGridViewTextBoxColumn1
            // 
            this.contactNoDataGridViewTextBoxColumn1.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn1.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.contactNoDataGridViewTextBoxColumn1.Name = "contactNoDataGridViewTextBoxColumn1";
            this.contactNoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 54;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 757);
            this.Controls.Add(this.tcUserManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.tcUserManagement.ResumeLayout(false);
            this.tbpCustomers.ResumeLayout(false);
            this.tbpCustomers.PerformLayout();
            this.gbCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            this.gbUpdateCustomer.ResumeLayout(false);
            this.gbUpdateCustomer.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            this.tbpStaff.ResumeLayout(false);
            this.tbpStaff.PerformLayout();
            this.gbStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpSuppliers.ResumeLayout(false);
            this.tbpSuppliers.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.gbUpdateSupplier.ResumeLayout(false);
            this.gbUpdateSupplier.PerformLayout();
            this.gbAddSupplier.ResumeLayout(false);
            this.gbAddSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUserManagement;
        private System.Windows.Forms.TabPage tbpCustomers;
        private System.Windows.Forms.TabPage tbpStaff;

        private System.Windows.Forms.TabPage tbpSuppliers;
        private System.Windows.Forms.DataGridView dgvStaffMgt;
        private WstGrp11DataSet wstGrp11DataSet;

        
        private System.Windows.Forms.DataGridView gvCustomer;
      
        private System.Windows.Forms.BindingSource customerBindingSource;
        private WstGrp11DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        

        private System.Windows.Forms.BindingSource staffBindingSource;
        private WstGrp11DataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsernameStaff;
        private System.Windows.Forms.TextBox txtFirstNameStaff;
        private System.Windows.Forms.TextBox txtPasswordStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddStaffMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastNameStaff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtContactStaff;
        private System.Windows.Forms.ComboBox cmbStaffRole;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbStaffRoleUpdate;
        private System.Windows.Forms.MaskedTextBox txtContactUpdate;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastNameUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsernameUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbFilterByRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchStaffByName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnArchiveStaff;

        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn1;
     //   private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gvSupplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private WstGrp11DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblSearchByPhoneNumber;
        private System.Windows.Forms.Button btnSearchByNo;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label lblCustomerPostal;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.Label lblCustomerProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblCusFname1;
        private System.Windows.Forms.Label lblCusLname;
        private System.Windows.Forms.Label lblCusNum;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.MaskedTextBox mtSearchNo;
        private System.Windows.Forms.MaskedTextBox mtCustomerNo;
        private System.Windows.Forms.GroupBox gbAddCustomer;
        private System.Windows.Forms.GroupBox gbUpdateCustomer;
        private System.Windows.Forms.Label lblEditCusPostal;
        private System.Windows.Forms.TextBox txtUaddress;
        private System.Windows.Forms.Label lblEditCusCity;
        private System.Windows.Forms.Label lblEditCusProvince;
        private System.Windows.Forms.TextBox txtUcode;
        private System.Windows.Forms.TextBox txtUfname;
        private System.Windows.Forms.TextBox txtUcity;
        private System.Windows.Forms.TextBox txtUemail;
        private System.Windows.Forms.ComboBox cbUprovince;
        private System.Windows.Forms.Label lblEditCusEmail;
        private System.Windows.Forms.Label lblEditCusFname;
        private System.Windows.Forms.Label lblEditCusLname;
        private System.Windows.Forms.Label lblEditCusNumber;
        private System.Windows.Forms.TextBox txtUlname;
        private System.Windows.Forms.Label lblEditCusAddress;
        private System.Windows.Forms.MaskedTextBox mtUpdateCustContact;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearchSupplier;
       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbAddSupplier;
        private System.Windows.Forms.MaskedTextBox mtSupplierContact;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblSupplierPostal;
        private System.Windows.Forms.TextBox txtSaddress;
        private System.Windows.Forms.Label lblSupplierCity;
        private System.Windows.Forms.Label lblSupplierProvince;
        private System.Windows.Forms.TextBox txtScode;
        private System.Windows.Forms.TextBox txtScity;
        private System.Windows.Forms.TextBox txtSemail;
        private System.Windows.Forms.ComboBox cbSprovince;
        private System.Windows.Forms.Label lblSupplierEmail;
        private System.Windows.Forms.Label lblSupplierFname;
        private System.Windows.Forms.Label lblSupplierNum;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.GroupBox gbUpdateSupplier;
        private System.Windows.Forms.MaskedTextBox mtEditSupplierContact;
        private System.Windows.Forms.Button btnUpdateSupplier;
        private System.Windows.Forms.Label lblSupplierEditPostal;
        private System.Windows.Forms.TextBox txtEditSaddress;
        private System.Windows.Forms.Label lblSupplierEditCity;
        private System.Windows.Forms.Label lblSupplierEditProvince;
        private System.Windows.Forms.TextBox txtEditScode;
        private System.Windows.Forms.TextBox txtEditScity;
        private System.Windows.Forms.TextBox txtEditSemail;
        private System.Windows.Forms.ComboBox cbEditSprovince;
        private System.Windows.Forms.Label lblSupplierEditEmail;
        private System.Windows.Forms.Label lblSupplierEditName;
        private System.Windows.Forms.Label lblSupplierEditNum;
        private System.Windows.Forms.TextBox txtEditSname;
        private System.Windows.Forms.Label lblSupplierEditAddress;
     
        private System.Windows.Forms.Button btnCustomerRestore;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.GroupBox gbStaff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNewOrder;
    }
}