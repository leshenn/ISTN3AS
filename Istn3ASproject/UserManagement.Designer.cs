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
            this.tcUserManagement = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
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
            this.SuspendLayout();
            // 
            // tcUserManagement
            // 
            this.tcUserManagement.Controls.Add(this.tbpCustomers);
            this.tcUserManagement.Controls.Add(this.tbpStaff);
            this.tcUserManagement.Controls.Add(this.tbpSuppliers);
            this.tcUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUserManagement.Location = new System.Drawing.Point(0, 0);
            this.tcUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.tcUserManagement.Name = "tcUserManagement";
            this.tcUserManagement.SelectedIndex = 0;
            this.tcUserManagement.Size = new System.Drawing.Size(797, 541);
            this.tcUserManagement.TabIndex = 0;
            // 
            // tbpCustomers
            // 
            this.tbpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tbpCustomers.Size = new System.Drawing.Size(789, 515);
            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "Customers";
            this.tbpCustomers.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(797, 541);
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
    }
}