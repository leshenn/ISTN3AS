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

            this.tcUserManagement = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.btnCustomerRestore = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            
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
            this.lblSearchByPhoneNumber = new System.Windows.Forms.Label();
            this.tbpStaff = new System.Windows.Forms.TabPage();

            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.dgvStaffMgt = new System.Windows.Forms.DataGridView();
            this.tbpSuppliers = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFilterByRole = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchStaffByName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnArchiveStaff = new System.Windows.Forms.Button();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.staffTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StaffTableAdapter();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tcUserManagement.SuspendLayout();
            this.tbpStaff.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();

          
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpgSuppliers = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            
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
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.CustomerTableAdapter();
            this.staffTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StaffTableAdapter();
            this.supplierTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.SupplierTableAdapter();
            lblSupplierSearch = new System.Windows.Forms.Label();
            this.tcUserManagement.SuspendLayout();
            this.tbpCustomers.SuspendLayout();
            this.gbUpdateCustomer.SuspendLayout();
            this.gbAddCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).BeginInit();
            this.tbpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.tpgSuppliers.SuspendLayout();
            this.gbUpdateSupplier.SuspendLayout();
            this.gbAddSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();

            this.SuspendLayout();
            // 
            // lblSupplierSearch
            // 
            lblSupplierSearch.AutoSize = true;
            lblSupplierSearch.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSupplierSearch.Location = new System.Drawing.Point(1072, 44);
            lblSupplierSearch.Name = "lblSupplierSearch";
            lblSupplierSearch.Size = new System.Drawing.Size(166, 17);
            lblSupplierSearch.TabIndex = 1;
            lblSupplierSearch.Text = "Enter Supplier\'s Name";
            // 
            // tcUserManagement
            // 
            this.tcUserManagement.Controls.Add(this.tbpCustomers);
            this.tcUserManagement.Controls.Add(this.tbpStaff);
            this.tcUserManagement.Controls.Add(this.tpgSuppliers);
            this.tcUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUserManagement.Location = new System.Drawing.Point(0, 0);
            this.tcUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tcUserManagement.Name = "tcUserManagement";
            this.tcUserManagement.SelectedIndex = 0;


            this.tcUserManagement.Size = new System.Drawing.Size(1582, 853);

            this.tcUserManagement.TabIndex = 0;
            // 
            // tbpCustomers
            // 

            this.tbpCustomers.Margin = new System.Windows.Forms.Padding(2);
        
            this.tbpCustomers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpCustomers.Controls.Add(this.btnCustomerRestore);
            this.tbpCustomers.Controls.Add(this.comboBox1);
           
            this.tbpCustomers.Controls.Add(this.gbUpdateCustomer);
            this.tbpCustomers.Controls.Add(this.gbAddCustomer);
            this.tbpCustomers.Controls.Add(this.mtSearchNo);
            this.tbpCustomers.Controls.Add(this.btnSearchByNo);
            this.tbpCustomers.Controls.Add(this.gvCustomer);
            this.tbpCustomers.Controls.Add(this.lblSearchByPhoneNumber);
            this.tbpCustomers.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpCustomers.Location = new System.Drawing.Point(4, 25);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomers.Size = new System.Drawing.Size(1574, 824);

            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "Customers";
            // 
            // btnCustomerRestore
            // 
            this.btnCustomerRestore.BackColor = System.Drawing.Color.Azure;
            this.btnCustomerRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomerRestore.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRestore.Location = new System.Drawing.Point(1087, 293);
            this.btnCustomerRestore.Name = "btnCustomerRestore";
            this.btnCustomerRestore.Size = new System.Drawing.Size(101, 40);
            this.btnCustomerRestore.TabIndex = 38;
            this.btnCustomerRestore.Text = "Restore";
            this.btnCustomerRestore.UseVisualStyleBackColor = false;
            this.btnCustomerRestore.Click += new System.EventHandler(this.btnCustomerRestore_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "City";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1347, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 37;
            // 
            
            // 
            // gbUpdateCustomer
            // 
            this.gbUpdateCustomer.BackColor = System.Drawing.Color.Azure;
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
            this.gbUpdateCustomer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdateCustomer.Location = new System.Drawing.Point(19, 598);
            this.gbUpdateCustomer.Name = "gbUpdateCustomer";
            this.gbUpdateCustomer.Size = new System.Drawing.Size(1312, 218);
            this.gbUpdateCustomer.TabIndex = 35;
            this.gbUpdateCustomer.TabStop = false;
            this.gbUpdateCustomer.Text = "Update Customer Details *(Please Select a Customer First)";
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.Azure;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(1051, 111);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(222, 57);
            this.btnUpdateCustomer.TabIndex = 50;
            this.btnUpdateCustomer.Text = "Update Customer Details";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            this.btnUpdateCustomer.MouseLeave += new System.EventHandler(this.btnUpdateCustomer_MouseLeave);
            this.btnUpdateCustomer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnUpdateCustomer_MouseMove);
            // 
            // mtUpdateCustContact
            // 
            this.mtUpdateCustContact.Location = new System.Drawing.Point(474, 86);
            this.mtUpdateCustContact.Mask = "(999) 000-0000";
            this.mtUpdateCustContact.Name = "mtUpdateCustContact";
            this.mtUpdateCustContact.Size = new System.Drawing.Size(149, 25);
            this.mtUpdateCustContact.TabIndex = 49;
            // 
            // lblEditCusPostal
            // 
            this.lblEditCusPostal.AutoSize = true;
            this.lblEditCusPostal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusPostal.Location = new System.Drawing.Point(479, 150);
            this.lblEditCusPostal.Name = "lblEditCusPostal";
            this.lblEditCusPostal.Size = new System.Drawing.Size(95, 17);
            this.lblEditCusPostal.TabIndex = 37;
            this.lblEditCusPostal.Text = "Postal Code";
            // 
            // txtUaddress
            // 
            this.txtUaddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUaddress.Location = new System.Drawing.Point(831, 86);
            this.txtUaddress.Name = "txtUaddress";
            this.txtUaddress.Size = new System.Drawing.Size(132, 25);
            this.txtUaddress.TabIndex = 43;
            // 
            // lblEditCusCity
            // 
            this.lblEditCusCity.AutoSize = true;
            this.lblEditCusCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusCity.Location = new System.Drawing.Point(27, 150);
            this.lblEditCusCity.Name = "lblEditCusCity";
            this.lblEditCusCity.Size = new System.Drawing.Size(37, 17);
            this.lblEditCusCity.TabIndex = 46;
            this.lblEditCusCity.Text = "City";
            // 
            // lblEditCusProvince
            // 
            this.lblEditCusProvince.AutoSize = true;
            this.lblEditCusProvince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusProvince.Location = new System.Drawing.Point(253, 150);
            this.lblEditCusProvince.Name = "lblEditCusProvince";
            this.lblEditCusProvince.Size = new System.Drawing.Size(72, 17);
            this.lblEditCusProvince.TabIndex = 48;
            this.lblEditCusProvince.Text = "Province";
            // 
            // txtUcode
            // 
            this.txtUcode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcode.Location = new System.Drawing.Point(483, 181);
            this.txtUcode.Name = "txtUcode";
            this.txtUcode.Size = new System.Drawing.Size(100, 25);
            this.txtUcode.TabIndex = 45;
            // 
            // txtUfname
            // 
            this.txtUfname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUfname.Location = new System.Drawing.Point(30, 86);
            this.txtUfname.Name = "txtUfname";
            this.txtUfname.Size = new System.Drawing.Size(174, 25);
            this.txtUfname.TabIndex = 34;
            // 
            // txtUcity
            // 
            this.txtUcity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUcity.Location = new System.Drawing.Point(22, 181);
            this.txtUcity.Name = "txtUcity";
            this.txtUcity.Size = new System.Drawing.Size(165, 25);
            this.txtUcity.TabIndex = 44;
            // 
            // txtUemail
            // 
            this.txtUemail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUemail.Location = new System.Drawing.Point(651, 86);
            this.txtUemail.Name = "txtUemail";
            this.txtUemail.Size = new System.Drawing.Size(163, 25);
            this.txtUemail.TabIndex = 42;
            // 
            // cbUprovince
            // 
            this.cbUprovince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbUprovince.Location = new System.Drawing.Point(257, 182);
            this.cbUprovince.Name = "cbUprovince";
            this.cbUprovince.Size = new System.Drawing.Size(174, 25);
            this.cbUprovince.TabIndex = 47;
            // 
            // lblEditCusEmail
            // 
            this.lblEditCusEmail.AutoSize = true;
            this.lblEditCusEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusEmail.Location = new System.Drawing.Point(663, 50);
            this.lblEditCusEmail.Name = "lblEditCusEmail";
            this.lblEditCusEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEditCusEmail.TabIndex = 40;
            this.lblEditCusEmail.Text = "Email";
            // 
            // lblEditCusFname
            // 
            this.lblEditCusFname.AutoSize = true;
            this.lblEditCusFname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusFname.Location = new System.Drawing.Point(27, 59);
            this.lblEditCusFname.Name = "lblEditCusFname";
            this.lblEditCusFname.Size = new System.Drawing.Size(86, 17);
            this.lblEditCusFname.TabIndex = 36;
            this.lblEditCusFname.Text = "First Name";
            // 
            // lblEditCusLname
            // 
            this.lblEditCusLname.AutoSize = true;
            this.lblEditCusLname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusLname.Location = new System.Drawing.Point(253, 50);
            this.lblEditCusLname.Name = "lblEditCusLname";
            this.lblEditCusLname.Size = new System.Drawing.Size(83, 17);
            this.lblEditCusLname.TabIndex = 38;
            this.lblEditCusLname.Text = "Last Name";
            // 
            // lblEditCusNumber
            // 
            this.lblEditCusNumber.AutoSize = true;
            this.lblEditCusNumber.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusNumber.Location = new System.Drawing.Point(479, 50);
            this.lblEditCusNumber.Name = "lblEditCusNumber";
            this.lblEditCusNumber.Size = new System.Drawing.Size(125, 17);
            this.lblEditCusNumber.TabIndex = 39;
            this.lblEditCusNumber.Text = "Contact Number";
            // 
            // txtUlname
            // 
            this.txtUlname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUlname.Location = new System.Drawing.Point(257, 86);
            this.txtUlname.Name = "txtUlname";
            this.txtUlname.Size = new System.Drawing.Size(174, 25);
            this.txtUlname.TabIndex = 35;
            // 
            // lblEditCusAddress
            // 
            this.lblEditCusAddress.AutoSize = true;
            this.lblEditCusAddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCusAddress.Location = new System.Drawing.Point(857, 50);
            this.lblEditCusAddress.Name = "lblEditCusAddress";
            this.lblEditCusAddress.Size = new System.Drawing.Size(65, 17);
            this.lblEditCusAddress.TabIndex = 41;
            this.lblEditCusAddress.Text = "Address";
            // 
            // gbAddCustomer
            // 
            this.gbAddCustomer.BackColor = System.Drawing.Color.MintCream;
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
            this.gbAddCustomer.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddCustomer.Location = new System.Drawing.Point(20, 354);
            this.gbAddCustomer.Name = "gbAddCustomer";
            this.gbAddCustomer.Size = new System.Drawing.Size(1320, 226);
            this.gbAddCustomer.TabIndex = 34;
            this.gbAddCustomer.TabStop = false;
            this.gbAddCustomer.Text = "Add New Customer";
            // 
            // mtCustomerNo
            // 
            this.mtCustomerNo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCustomerNo.Location = new System.Drawing.Point(531, 71);
            this.mtCustomerNo.Mask = "(999) 000-0000";
            this.mtCustomerNo.Name = "mtCustomerNo";
            this.mtCustomerNo.Size = new System.Drawing.Size(149, 25);
            this.mtCustomerNo.TabIndex = 33;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.Azure;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCustomer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewCustomer.Location = new System.Drawing.Point(1051, 140);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(199, 54);
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
            this.lblCustomerPostal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPostal.Location = new System.Drawing.Point(527, 135);
            this.lblCustomerPostal.Name = "lblCustomerPostal";
            this.lblCustomerPostal.Size = new System.Drawing.Size(95, 17);
            this.lblCustomerPostal.TabIndex = 19;
            this.lblCustomerPostal.Text = "Postal Code";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(879, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 25);
            this.txtAddress.TabIndex = 26;
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCity.Location = new System.Drawing.Point(75, 135);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(37, 17);
            this.lblCustomerCity.TabIndex = 29;
            this.lblCustomerCity.Text = "City";
            // 
            // lblCustomerProvince
            // 
            this.lblCustomerProvince.AutoSize = true;
            this.lblCustomerProvince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerProvince.Location = new System.Drawing.Point(301, 135);
            this.lblCustomerProvince.Name = "lblCustomerProvince";
            this.lblCustomerProvince.Size = new System.Drawing.Size(72, 17);
            this.lblCustomerProvince.TabIndex = 31;
            this.lblCustomerProvince.Text = "Province";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(531, 166);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 25);
            this.txtPostalCode.TabIndex = 28;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(61, 71);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(174, 25);
            this.txtFName.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(70, 166);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(165, 25);
            this.txtCity.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(699, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 25);
            this.txtEmail.TabIndex = 25;
            // 
            // cbProvince
            // 
            this.cbProvince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbProvince.Location = new System.Drawing.Point(305, 167);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(174, 25);
            this.cbProvince.TabIndex = 30;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.AutoSize = true;
            this.lblCustomerEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(696, 44);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(47, 17);
            this.lblCustomerEmail.TabIndex = 22;
            this.lblCustomerEmail.Text = "Email";
            // 
            // lblCusFname1
            // 
            this.lblCusFname1.AutoSize = true;
            this.lblCusFname1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusFname1.Location = new System.Drawing.Point(75, 44);
            this.lblCusFname1.Name = "lblCusFname1";
            this.lblCusFname1.Size = new System.Drawing.Size(98, 17);
            this.lblCusFname1.TabIndex = 17;
            this.lblCusFname1.Text = "* First Name";
            // 
            // lblCusLname
            // 
            this.lblCusLname.AutoSize = true;
            this.lblCusLname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusLname.Location = new System.Drawing.Point(301, 44);
            this.lblCusLname.Name = "lblCusLname";
            this.lblCusLname.Size = new System.Drawing.Size(95, 17);
            this.lblCusLname.TabIndex = 20;
            this.lblCusLname.Text = "* Last Name";
            // 
            // lblCusNum
            // 
            this.lblCusNum.AutoSize = true;
            this.lblCusNum.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusNum.Location = new System.Drawing.Point(527, 44);
            this.lblCusNum.Name = "lblCusNum";
            this.lblCusNum.Size = new System.Drawing.Size(137, 17);
            this.lblCusNum.TabIndex = 21;
            this.lblCusNum.Text = "* Contact Number";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(305, 71);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(174, 25);
            this.txtLName.TabIndex = 16;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(876, 44);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(65, 17);
            this.lblCustomerAddress.TabIndex = 23;
            this.lblCustomerAddress.Text = "Address";
            // 
            // mtSearchNo
            // 
            this.mtSearchNo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtSearchNo.Location = new System.Drawing.Point(1122, 76);
            this.mtSearchNo.Mask = "(999) 000-0000";
            this.mtSearchNo.Name = "mtSearchNo";
            this.mtSearchNo.Size = new System.Drawing.Size(160, 25);
            this.mtSearchNo.TabIndex = 32;
            // 
            // btnSearchByNo
            // 
            this.btnSearchByNo.BackColor = System.Drawing.Color.Azure;
            this.btnSearchByNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchByNo.FlatAppearance.BorderSize = 0;
            this.btnSearchByNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchByNo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByNo.Location = new System.Drawing.Point(1151, 121);
            this.btnSearchByNo.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchByNo.Name = "btnSearchByNo";
            this.btnSearchByNo.Size = new System.Drawing.Size(106, 32);
            this.btnSearchByNo.TabIndex = 5;
            this.btnSearchByNo.Text = "Search";
            this.btnSearchByNo.UseVisualStyleBackColor = false;
            this.btnSearchByNo.Click += new System.EventHandler(this.btnSearchByNo_Click);
            this.btnSearchByNo.MouseLeave += new System.EventHandler(this.btnSearchByNo_MouseLeave);
            this.btnSearchByNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSearchByNo_MouseMove);
            // 
            // gvCustomer
            // 
            this.gvCustomer.AutoGenerateColumns = false;
            this.gvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.gvCustomer.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvCustomer.Location = new System.Drawing.Point(20, 41);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.RowHeadersWidth = 51;
            this.gvCustomer.RowTemplate.Height = 24;
            this.gvCustomer.Size = new System.Drawing.Size(1052, 292);
            this.gvCustomer.TabIndex = 0;
            this.gvCustomer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvCustomer_RowHeaderMouseClick);
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
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
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
            // lblSearchByPhoneNumber
            // 
            this.lblSearchByPhoneNumber.AutoSize = true;
            this.lblSearchByPhoneNumber.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByPhoneNumber.Location = new System.Drawing.Point(1100, 41);
            this.lblSearchByPhoneNumber.Name = "lblSearchByPhoneNumber";
            this.lblSearchByPhoneNumber.Size = new System.Drawing.Size(201, 17);
            this.lblSearchByPhoneNumber.TabIndex = 4;
            this.lblSearchByPhoneNumber.Text = "Search by Phone Number :";
            this.lblSearchByPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbpStaff
            // 

            this.tbpStaff.Controls.Add(this.btnArchiveStaff);
            this.tbpStaff.Controls.Add(this.label16);
            this.tbpStaff.Controls.Add(this.txtSearchStaffByName);
            this.tbpStaff.Controls.Add(this.label15);
            this.tbpStaff.Controls.Add(this.label14);
            this.tbpStaff.Controls.Add(this.cmbFilterByRole);
            this.tbpStaff.Controls.Add(this.groupBox2);
            this.tbpStaff.Controls.Add(this.groupBox1);
            this.tbpStaff.Controls.Add(this.dgvStaffMgt);
            this.tbpStaff.Location = new System.Drawing.Point(4, 22);
            this.tbpStaff.Margin = new System.Windows.Forms.Padding(2);
            this.tbpStaff.Name = "tbpStaff";
            this.tbpStaff.Padding = new System.Windows.Forms.Padding(2);
            this.tbpStaff.Size = new System.Drawing.Size(789, 515);
            this.tbpStaff.TabIndex = 1;
            this.tbpStaff.Text = "Staff";
            this.tbpStaff.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.groupBox2.Location = new System.Drawing.Point(22, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 131);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Staff Member";
            // 
            // cmbStaffRoleUpdate
            // 
            this.cmbStaffRoleUpdate.FormattingEnabled = true;
            this.cmbStaffRoleUpdate.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Cashier"});
            this.cmbStaffRoleUpdate.Location = new System.Drawing.Point(10, 106);
            this.cmbStaffRoleUpdate.Name = "cmbStaffRoleUpdate";
            this.cmbStaffRoleUpdate.Size = new System.Drawing.Size(121, 21);
            this.cmbStaffRoleUpdate.TabIndex = 14;
            // 
            // txtContactUpdate
            // 
            this.txtContactUpdate.Location = new System.Drawing.Point(609, 44);
            this.txtContactUpdate.Mask = "(999) 0000000";
            this.txtContactUpdate.Name = "txtContactUpdate";
            this.txtContactUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtContactUpdate.TabIndex = 13;
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateStaff.Location = new System.Drawing.Point(172, 89);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(120, 36);
            this.btnUpdateStaff.TabIndex = 12;
            this.btnUpdateStaff.Text = "Update Staff Member";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Contact No. :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Last Name:";
            // 
            // txtLastNameUpdate
            // 
            this.txtLastNameUpdate.Location = new System.Drawing.Point(463, 44);
            this.txtLastNameUpdate.Name = "txtLastNameUpdate";
            this.txtLastNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameUpdate.TabIndex = 6;
            this.txtLastNameUpdate.TextChanged += new System.EventHandler(this.txtLastNameUpdate_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "First Name:";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(329, 44);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNameUpdate.TabIndex = 4;
            this.txtNameUpdate.TextChanged += new System.EventHandler(this.txtNameUpdate_TextChanged);
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Location = new System.Drawing.Point(172, 44);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordUpdate.TabIndex = 3;
            this.txtPasswordUpdate.TextChanged += new System.EventHandler(this.txtPasswordUpdate_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(169, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Password:";
            // 
            // txtUsernameUpdate
            // 
            this.txtUsernameUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameUpdate.Location = new System.Drawing.Point(7, 44);
            this.txtUsernameUpdate.Name = "txtUsernameUpdate";
            this.txtUsernameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameUpdate.TabIndex = 1;
            this.txtUsernameUpdate.TextChanged += new System.EventHandler(this.txtUsernameUpdate_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Username:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.groupBox1.Location = new System.Drawing.Point(22, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Staff Member";
            // 
            // cmbStaffRole
            // 
            this.cmbStaffRole.FormattingEnabled = true;
            this.cmbStaffRole.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Cashier"});
            this.cmbStaffRole.Location = new System.Drawing.Point(10, 106);
            this.cmbStaffRole.Name = "cmbStaffRole";
            this.cmbStaffRole.Size = new System.Drawing.Size(121, 21);
            this.cmbStaffRole.TabIndex = 14;
            this.cmbStaffRole.Text = "Select Staff Role -->";
            // 
            // txtContactStaff
            // 
            this.txtContactStaff.Location = new System.Drawing.Point(609, 44);
            this.txtContactStaff.Mask = "(999) 0000000";
            this.txtContactStaff.Name = "txtContactStaff";
            this.txtContactStaff.Size = new System.Drawing.Size(100, 20);
            this.txtContactStaff.TabIndex = 13;
            // 
            // btnAddStaffMember
            // 
            this.btnAddStaffMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddStaffMember.Location = new System.Drawing.Point(172, 89);
            this.btnAddStaffMember.Name = "btnAddStaffMember";
            this.btnAddStaffMember.Size = new System.Drawing.Size(120, 36);
            this.btnAddStaffMember.TabIndex = 12;
            this.btnAddStaffMember.Text = "Add Staff Member";
            this.btnAddStaffMember.UseVisualStyleBackColor = false;
            this.btnAddStaffMember.Click += new System.EventHandler(this.btnAddStaffMember_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact No. :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name:";
            // 
            // txtLastNameStaff
            // 
            this.txtLastNameStaff.Location = new System.Drawing.Point(463, 44);
            this.txtLastNameStaff.Name = "txtLastNameStaff";
            this.txtLastNameStaff.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameStaff.TabIndex = 6;
            this.txtLastNameStaff.TextChanged += new System.EventHandler(this.txtLastNameStaff_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            // 
            // txtFirstNameStaff
            // 
            this.txtFirstNameStaff.Location = new System.Drawing.Point(329, 44);
            this.txtFirstNameStaff.Name = "txtFirstNameStaff";
            this.txtFirstNameStaff.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameStaff.TabIndex = 4;
            this.txtFirstNameStaff.TextChanged += new System.EventHandler(this.txtFirstNameStaff_TextChanged);
            // 
            // txtPasswordStaff
            // 
            this.txtPasswordStaff.Location = new System.Drawing.Point(172, 44);
            this.txtPasswordStaff.Name = "txtPasswordStaff";
            this.txtPasswordStaff.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordStaff.TabIndex = 3;
            this.txtPasswordStaff.TextChanged += new System.EventHandler(this.txtPasswordStaff_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsernameStaff
            // 
            this.txtUsernameStaff.Location = new System.Drawing.Point(7, 44);
            this.txtUsernameStaff.Name = "txtUsernameStaff";
            this.txtUsernameStaff.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameStaff.TabIndex = 1;
            this.txtUsernameStaff.TextChanged += new System.EventHandler(this.txtUsernameStaff_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // dgvStaffMgt
            // 
            this.dgvStaffMgt.AutoGenerateColumns = false;
            this.dgvStaffMgt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaffMgt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStaffMgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMgt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvStaffMgt.DataSource = this.staffBindingSource;
            this.dgvStaffMgt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvStaffMgt.Location = new System.Drawing.Point(22, 60);
            this.dgvStaffMgt.Name = "dgvStaffMgt";
            this.dgvStaffMgt.Size = new System.Drawing.Size(593, 150);
            this.dgvStaffMgt.TabIndex = 0;
            this.dgvStaffMgt.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaffMgt_CellMouseClick);
            // 
            // tbpSuppliers
            // 
            this.tbpSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tbpSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSuppliers.Name = "tbpSuppliers";
            this.tbpSuppliers.Size = new System.Drawing.Size(789, 515);
            this.tbpSuppliers.TabIndex = 2;
            this.tbpSuppliers.Text = "Suppliers";
            this.tbpSuppliers.UseVisualStyleBackColor = true;

           
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
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
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // tpgSuppliers
            // 
            this.tpgSuppliers.Controls.Add(this.comboBox3);
            this.tpgSuppliers.Controls.Add(this.label34);
            this.tpgSuppliers.Controls.Add(this.gbUpdateSupplier);
            this.tpgSuppliers.Controls.Add(this.gbAddSupplier);
            this.tpgSuppliers.Controls.Add(this.button1);
            this.tpgSuppliers.Controls.Add(this.gvSupplier);
            this.tpgSuppliers.Controls.Add(lblSupplierSearch);
            this.tpgSuppliers.Controls.Add(this.btnSearchSupplier);
            this.tpgSuppliers.Controls.Add(this.txtSearch);
            this.tpgSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tpgSuppliers.Name = "tpgSuppliers";
            this.tpgSuppliers.Size = new System.Drawing.Size(1574, 824);
            this.tpgSuppliers.TabIndex = 2;
            this.tpgSuppliers.Text = "Suppliers";
            this.tpgSuppliers.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1075, 215);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 39;
            // 
            
            
            // 
            // gbUpdateSupplier
            // 
            this.gbUpdateSupplier.BackColor = System.Drawing.Color.MintCream;
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
            this.gbUpdateSupplier.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUpdateSupplier.Location = new System.Drawing.Point(17, 570);
            this.gbUpdateSupplier.Name = "gbUpdateSupplier";
            this.gbUpdateSupplier.Size = new System.Drawing.Size(1320, 226);
            this.gbUpdateSupplier.TabIndex = 36;
            this.gbUpdateSupplier.TabStop = false;
            this.gbUpdateSupplier.Text = "Update Supplier Details";
            // 
            // mtEditSupplierContact
            // 
            this.mtEditSupplierContact.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtEditSupplierContact.Location = new System.Drawing.Point(252, 71);
            this.mtEditSupplierContact.Mask = "(999) 000-0000";
            this.mtEditSupplierContact.Name = "mtEditSupplierContact";
            this.mtEditSupplierContact.Size = new System.Drawing.Size(149, 25);
            this.mtEditSupplierContact.TabIndex = 33;
            // 
            // btnUpdateSupplier
            // 
            this.btnUpdateSupplier.BackColor = System.Drawing.Color.Azure;
            this.btnUpdateSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateSupplier.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSupplier.Location = new System.Drawing.Point(1091, 140);
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
            this.lblSupplierEditPostal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditPostal.Location = new System.Drawing.Point(249, 122);
            this.lblSupplierEditPostal.Name = "lblSupplierEditPostal";
            this.lblSupplierEditPostal.Size = new System.Drawing.Size(95, 17);
            this.lblSupplierEditPostal.TabIndex = 19;
            this.lblSupplierEditPostal.Text = "Postal Code";
            // 
            // txtEditSaddress
            // 
            this.txtEditSaddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSaddress.Location = new System.Drawing.Point(632, 71);
            this.txtEditSaddress.Name = "txtEditSaddress";
            this.txtEditSaddress.Size = new System.Drawing.Size(174, 25);
            this.txtEditSaddress.TabIndex = 26;
            // 
            // lblSupplierEditCity
            // 
            this.lblSupplierEditCity.AutoSize = true;
            this.lblSupplierEditCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditCity.Location = new System.Drawing.Point(864, 44);
            this.lblSupplierEditCity.Name = "lblSupplierEditCity";
            this.lblSupplierEditCity.Size = new System.Drawing.Size(37, 17);
            this.lblSupplierEditCity.TabIndex = 29;
            this.lblSupplierEditCity.Text = "City";
            // 
            // lblSupplierEditProvince
            // 
            this.lblSupplierEditProvince.AutoSize = true;
            this.lblSupplierEditProvince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditProvince.Location = new System.Drawing.Point(75, 122);
            this.lblSupplierEditProvince.Name = "lblSupplierEditProvince";
            this.lblSupplierEditProvince.Size = new System.Drawing.Size(72, 17);
            this.lblSupplierEditProvince.TabIndex = 31;
            this.lblSupplierEditProvince.Text = "Province";
            // 
            // txtEditScode
            // 
            this.txtEditScode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditScode.Location = new System.Drawing.Point(252, 156);
            this.txtEditScode.Name = "txtEditScode";
            this.txtEditScode.Size = new System.Drawing.Size(100, 25);
            this.txtEditScode.TabIndex = 28;
            // 
            // txtEditScity
            // 
            this.txtEditScity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditScity.Location = new System.Drawing.Point(843, 71);
            this.txtEditScity.Name = "txtEditScity";
            this.txtEditScity.Size = new System.Drawing.Size(165, 25);
            this.txtEditScity.TabIndex = 27;
            // 
            // txtEditSemail
            // 
            this.txtEditSemail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSemail.Location = new System.Drawing.Point(438, 71);
            this.txtEditSemail.Name = "txtEditSemail";
            this.txtEditSemail.Size = new System.Drawing.Size(163, 25);
            this.txtEditSemail.TabIndex = 25;
            // 
            // cbEditSprovince
            // 
            this.cbEditSprovince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbEditSprovince.Location = new System.Drawing.Point(28, 156);
            this.cbEditSprovince.Name = "cbEditSprovince";
            this.cbEditSprovince.Size = new System.Drawing.Size(174, 25);
            this.cbEditSprovince.TabIndex = 30;
            // 
            // lblSupplierEditEmail
            // 
            this.lblSupplierEditEmail.AutoSize = true;
            this.lblSupplierEditEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditEmail.Location = new System.Drawing.Point(453, 44);
            this.lblSupplierEditEmail.Name = "lblSupplierEditEmail";
            this.lblSupplierEditEmail.Size = new System.Drawing.Size(47, 17);
            this.lblSupplierEditEmail.TabIndex = 22;
            this.lblSupplierEditEmail.Text = "Email";
            // 
            // lblSupplierEditName
            // 
            this.lblSupplierEditName.AutoSize = true;
            this.lblSupplierEditName.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditName.Location = new System.Drawing.Point(54, 44);
            this.lblSupplierEditName.Name = "lblSupplierEditName";
            this.lblSupplierEditName.Size = new System.Drawing.Size(55, 17);
            this.lblSupplierEditName.TabIndex = 20;
            this.lblSupplierEditName.Text = " Name";
            // 
            // lblSupplierEditNum
            // 
            this.lblSupplierEditNum.AutoSize = true;
            this.lblSupplierEditNum.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditNum.Location = new System.Drawing.Point(249, 44);
            this.lblSupplierEditNum.Name = "lblSupplierEditNum";
            this.lblSupplierEditNum.Size = new System.Drawing.Size(137, 17);
            this.lblSupplierEditNum.TabIndex = 21;
            this.lblSupplierEditNum.Text = "* Contact Number";
            // 
            // txtEditSname
            // 
            this.txtEditSname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditSname.Location = new System.Drawing.Point(28, 71);
            this.txtEditSname.Name = "txtEditSname";
            this.txtEditSname.Size = new System.Drawing.Size(174, 25);
            this.txtEditSname.TabIndex = 16;
            // 
            // lblSupplierEditAddress
            // 
            this.lblSupplierEditAddress.AutoSize = true;
            this.lblSupplierEditAddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEditAddress.Location = new System.Drawing.Point(638, 44);
            this.lblSupplierEditAddress.Name = "lblSupplierEditAddress";
            this.lblSupplierEditAddress.Size = new System.Drawing.Size(65, 17);
            this.lblSupplierEditAddress.TabIndex = 23;
            this.lblSupplierEditAddress.Text = "Address";
            // 
            // gbAddSupplier
            // 
            this.gbAddSupplier.BackColor = System.Drawing.Color.MintCream;
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
            this.gbAddSupplier.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddSupplier.Location = new System.Drawing.Point(17, 326);
            this.gbAddSupplier.Name = "gbAddSupplier";
            this.gbAddSupplier.Size = new System.Drawing.Size(1320, 226);
            this.gbAddSupplier.TabIndex = 35;
            this.gbAddSupplier.TabStop = false;
            this.gbAddSupplier.Text = "Add New Supplier";
            // 
            // mtSupplierContact
            // 
            this.mtSupplierContact.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtSupplierContact.Location = new System.Drawing.Point(252, 71);
            this.mtSupplierContact.Mask = "(999) 000-0000";
            this.mtSupplierContact.Name = "mtSupplierContact";
            this.mtSupplierContact.Size = new System.Drawing.Size(149, 25);
            this.mtSupplierContact.TabIndex = 33;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Azure;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSupplier.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSupplier.Location = new System.Drawing.Point(1091, 140);
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
            this.lblSupplierPostal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierPostal.Location = new System.Drawing.Point(249, 122);
            this.lblSupplierPostal.Name = "lblSupplierPostal";
            this.lblSupplierPostal.Size = new System.Drawing.Size(95, 17);
            this.lblSupplierPostal.TabIndex = 19;
            this.lblSupplierPostal.Text = "Postal Code";
            // 
            // txtSaddress
            // 
            this.txtSaddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaddress.Location = new System.Drawing.Point(632, 71);
            this.txtSaddress.Name = "txtSaddress";
            this.txtSaddress.Size = new System.Drawing.Size(174, 25);
            this.txtSaddress.TabIndex = 26;
            // 
            // lblSupplierCity
            // 
            this.lblSupplierCity.AutoSize = true;
            this.lblSupplierCity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCity.Location = new System.Drawing.Point(864, 44);
            this.lblSupplierCity.Name = "lblSupplierCity";
            this.lblSupplierCity.Size = new System.Drawing.Size(37, 17);
            this.lblSupplierCity.TabIndex = 29;
            this.lblSupplierCity.Text = "City";
            // 
            // lblSupplierProvince
            // 
            this.lblSupplierProvince.AutoSize = true;
            this.lblSupplierProvince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierProvince.Location = new System.Drawing.Point(75, 122);
            this.lblSupplierProvince.Name = "lblSupplierProvince";
            this.lblSupplierProvince.Size = new System.Drawing.Size(72, 17);
            this.lblSupplierProvince.TabIndex = 31;
            this.lblSupplierProvince.Text = "Province";
            // 
            // txtScode
            // 
            this.txtScode.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScode.Location = new System.Drawing.Point(252, 156);
            this.txtScode.Name = "txtScode";
            this.txtScode.Size = new System.Drawing.Size(100, 25);
            this.txtScode.TabIndex = 28;
            // 
            // txtScity
            // 
            this.txtScity.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScity.Location = new System.Drawing.Point(843, 71);
            this.txtScity.Name = "txtScity";
            this.txtScity.Size = new System.Drawing.Size(165, 25);
            this.txtScity.TabIndex = 27;
            // 
            // txtSemail
            // 
            this.txtSemail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemail.Location = new System.Drawing.Point(438, 71);
            this.txtSemail.Name = "txtSemail";
            this.txtSemail.Size = new System.Drawing.Size(163, 25);
            this.txtSemail.TabIndex = 25;
            // 
            // cbSprovince
            // 
            this.cbSprovince.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbSprovince.Location = new System.Drawing.Point(28, 156);
            this.cbSprovince.Name = "cbSprovince";
            this.cbSprovince.Size = new System.Drawing.Size(174, 25);
            this.cbSprovince.TabIndex = 30;
            // 
            // lblSupplierEmail
            // 
            this.lblSupplierEmail.AutoSize = true;
            this.lblSupplierEmail.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierEmail.Location = new System.Drawing.Point(453, 44);
            this.lblSupplierEmail.Name = "lblSupplierEmail";
            this.lblSupplierEmail.Size = new System.Drawing.Size(47, 17);
            this.lblSupplierEmail.TabIndex = 22;
            this.lblSupplierEmail.Text = "Email";
            // 
            // lblSupplierFname
            // 
            this.lblSupplierFname.AutoSize = true;
            this.lblSupplierFname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierFname.Location = new System.Drawing.Point(54, 44);
            this.lblSupplierFname.Name = "lblSupplierFname";
            this.lblSupplierFname.Size = new System.Drawing.Size(55, 17);
            this.lblSupplierFname.TabIndex = 20;
            this.lblSupplierFname.Text = " Name";
            // 
            // lblSupplierNum
            // 
            this.lblSupplierNum.AutoSize = true;
            this.lblSupplierNum.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierNum.Location = new System.Drawing.Point(249, 44);
            this.lblSupplierNum.Name = "lblSupplierNum";
            this.lblSupplierNum.Size = new System.Drawing.Size(137, 17);
            this.lblSupplierNum.TabIndex = 21;
            this.lblSupplierNum.Text = "* Contact Number";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(28, 71);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(174, 25);
            this.txtSname.TabIndex = 16;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(638, 44);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(65, 17);
            this.lblSupplierAddress.TabIndex = 23;
            this.lblSupplierAddress.Text = "Address";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1075, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvSupplier
            // 
            this.gvSupplier.AutoGenerateColumns = false;
            this.gvSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.gvSupplier.Location = new System.Drawing.Point(8, 17);
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.RowHeadersWidth = 51;
            this.gvSupplier.RowTemplate.Height = 24;
            this.gvSupplier.Size = new System.Drawing.Size(1048, 269);
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
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.Azure;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchSupplier.Location = new System.Drawing.Point(1075, 123);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(114, 34);
            this.btnSearchSupplier.TabIndex = 3;
            this.btnSearchSupplier.Text = "Search";
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            this.btnSearchSupplier.Click += new System.EventHandler(this.btnSearchSupplier_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1071, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 22);
            this.txtSearch.TabIndex = 2;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(322, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "**Select A staff Member To Update";
            // 
            // cmbFilterByRole
            // 
            this.cmbFilterByRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFilterByRole.FormattingEnabled = true;
            this.cmbFilterByRole.Items.AddRange(new object[] {
            "Owner",
            "Manager",
            "Cashier",
            "Terminated"});
            this.cmbFilterByRole.Location = new System.Drawing.Point(633, 82);
            this.cmbFilterByRole.Name = "cmbFilterByRole";
            this.cmbFilterByRole.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterByRole.TabIndex = 16;
            this.cmbFilterByRole.Text = "Select Staff Role -->";
            this.cmbFilterByRole.SelectedIndexChanged += new System.EventHandler(this.cmbFilterByRole_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(635, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Filter By Role";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(632, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Search Staff By Name:";
            // 
            // txtSearchStaffByName
            // 
            this.txtSearchStaffByName.Location = new System.Drawing.Point(633, 154);
            this.txtSearchStaffByName.Name = "txtSearchStaffByName";
            this.txtSearchStaffByName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchStaffByName.TabIndex = 19;
            this.txtSearchStaffByName.TextChanged += new System.EventHandler(this.txtSearchStaffByName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(22, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Staff Management";
            // 
            // btnArchiveStaff
            // 
            this.btnArchiveStaff.BackColor = System.Drawing.Color.Cyan;
            this.btnArchiveStaff.ForeColor = System.Drawing.Color.Black;
            this.btnArchiveStaff.Location = new System.Drawing.Point(634, 187);
            this.btnArchiveStaff.Name = "btnArchiveStaff";
            this.btnArchiveStaff.Size = new System.Drawing.Size(119, 23);
            this.btnArchiveStaff.TabIndex = 21;
            this.btnArchiveStaff.Text = "Archive Staff Member";
            this.btnArchiveStaff.UseVisualStyleBackColor = false;
            this.btnArchiveStaff.Click += new System.EventHandler(this.btnArchiveStaff_Click);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 78;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 83;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 54;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.wstGrp11DataSet;
            // 
            // wstGrp11DataSet
            // 
            this.wstGrp11DataSet.DataSetName = "WstGrp11DataSet";
            this.wstGrp11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.wstGrp11DataSet;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;


            this.ClientSize = new System.Drawing.Size(1582, 853);

            this.Controls.Add(this.tcUserManagement);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUserManagement";

            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.tcUserManagement.ResumeLayout(false);
            this.tbpStaff.ResumeLayout(false);
            this.tbpStaff.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            

          
            this.tbpCustomers.PerformLayout();
            this.gbUpdateCustomer.ResumeLayout(false);
            this.gbUpdateCustomer.PerformLayout();
            this.gbAddCustomer.ResumeLayout(false);
            this.gbAddCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wstGrp11DataSet)).EndInit();
            this.tbpStaff.ResumeLayout(false);
         
           
            this.tpgSuppliers.ResumeLayout(false);
            this.tpgSuppliers.PerformLayout();
            this.gbUpdateSupplier.ResumeLayout(false);
            this.gbUpdateSupplier.PerformLayout();
            this.gbAddSupplier.ResumeLayout(false);
            this.gbAddSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        

        private System.Windows.Forms.BindingSource staffBindingSource;
        private WstGrp11DataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;

        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnArchiveStaff;

        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.ComboBox comboBox1;
       
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
        private System.Windows.Forms.ComboBox comboBox3;
     
        private System.Windows.Forms.Button btnCustomerRestore;

    }
}