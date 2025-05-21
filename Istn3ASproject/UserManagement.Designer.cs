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
            this.btnArchiveStaff = new System.Windows.Forms.Button();
            this.lblStaffMgtHeading = new System.Windows.Forms.Label();
            this.txtSearchStaffByName = new System.Windows.Forms.TextBox();
            this.lblSearchStaff = new System.Windows.Forms.Label();
            this.lblFilterRole = new System.Windows.Forms.Label();
            this.cmbFilterByRole = new System.Windows.Forms.ComboBox();
            this.gbxUpdateStaff = new System.Windows.Forms.GroupBox();
            this.lblSelectAstaffMemeber = new System.Windows.Forms.Label();
            this.cmbStaffRoleUpdate = new System.Windows.Forms.ComboBox();
            this.txtContactUpdate = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.lblUpdateStaffRole = new System.Windows.Forms.Label();
            this.lblUpdateStaffContactNo = new System.Windows.Forms.Label();
            this.lblUpdateStaffLastName = new System.Windows.Forms.Label();
            this.txtLastNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateStaffFirstName = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateStaffpassword = new System.Windows.Forms.Label();
            this.txtUsernameUpdate = new System.Windows.Forms.TextBox();
            this.lblUpdateStaffUusername = new System.Windows.Forms.Label();
            this.gbxAddNewStaff = new System.Windows.Forms.GroupBox();
            this.cmbStaffRole = new System.Windows.Forms.ComboBox();
            this.txtContactStaff = new System.Windows.Forms.MaskedTextBox();
            this.btnAddStaffMember = new System.Windows.Forms.Button();
            this.lblRoleFilterAddNewStaff = new System.Windows.Forms.Label();
            this.lblContactNoStaff = new System.Windows.Forms.Label();
            this.lblLastNameStaff = new System.Windows.Forms.Label();
            this.txtLastNameStaff = new System.Windows.Forms.TextBox();
            this.lblFirstNameStaff = new System.Windows.Forms.Label();
            this.txtFirstNameStaff = new System.Windows.Forms.TextBox();
            this.txtPasswordStaff = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsernameStaff = new System.Windows.Forms.TextBox();
            this.lblUsernameStaff = new System.Windows.Forms.Label();
            this.dgvStaffMgt = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wstGrp11DataSet = new Istn3ASproject.WstGrp11DataSet();
            this.tbpSuppliers = new System.Windows.Forms.TabPage();
            this.staffTableAdapter = new Istn3ASproject.WstGrp11DataSetTableAdapters.StaffTableAdapter();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tcUserManagement.SuspendLayout();
            this.tbpStaff.SuspendLayout();
            this.gbxUpdateStaff.SuspendLayout();
            this.gbxAddNewStaff.SuspendLayout();
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
            this.tbpStaff.Controls.Add(this.lblStaffMgtHeading);
            this.tbpStaff.Controls.Add(this.txtSearchStaffByName);
            this.tbpStaff.Controls.Add(this.lblSearchStaff);
            this.tbpStaff.Controls.Add(this.lblFilterRole);
            this.tbpStaff.Controls.Add(this.cmbFilterByRole);
            this.tbpStaff.Controls.Add(this.gbxUpdateStaff);
            this.tbpStaff.Controls.Add(this.gbxAddNewStaff);
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
            // lblStaffMgtHeading
            // 
            this.lblStaffMgtHeading.AutoSize = true;
            this.lblStaffMgtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffMgtHeading.Location = new System.Drawing.Point(22, 28);
            this.lblStaffMgtHeading.Name = "lblStaffMgtHeading";
            this.lblStaffMgtHeading.Size = new System.Drawing.Size(110, 13);
            this.lblStaffMgtHeading.TabIndex = 20;
            this.lblStaffMgtHeading.Text = "Staff Management";
            // 
            // txtSearchStaffByName
            // 
            this.txtSearchStaffByName.Location = new System.Drawing.Point(633, 154);
            this.txtSearchStaffByName.Name = "txtSearchStaffByName";
            this.txtSearchStaffByName.Size = new System.Drawing.Size(121, 20);
            this.txtSearchStaffByName.TabIndex = 19;
            this.txtSearchStaffByName.TextChanged += new System.EventHandler(this.txtSearchStaffByName_TextChanged);
            // 
            // lblSearchStaff
            // 
            this.lblSearchStaff.AutoSize = true;
            this.lblSearchStaff.Location = new System.Drawing.Point(632, 131);
            this.lblSearchStaff.Name = "lblSearchStaff";
            this.lblSearchStaff.Size = new System.Drawing.Size(115, 13);
            this.lblSearchStaff.TabIndex = 18;
            this.lblSearchStaff.Text = "Search Staff By Name:";
            // 
            // lblFilterRole
            // 
            this.lblFilterRole.AutoSize = true;
            this.lblFilterRole.Location = new System.Drawing.Point(635, 65);
            this.lblFilterRole.Name = "lblFilterRole";
            this.lblFilterRole.Size = new System.Drawing.Size(69, 13);
            this.lblFilterRole.TabIndex = 17;
            this.lblFilterRole.Text = "Filter By Role";
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
            // gbxUpdateStaff
            // 
            this.gbxUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxUpdateStaff.Controls.Add(this.lblSelectAstaffMemeber);
            this.gbxUpdateStaff.Controls.Add(this.cmbStaffRoleUpdate);
            this.gbxUpdateStaff.Controls.Add(this.txtContactUpdate);
            this.gbxUpdateStaff.Controls.Add(this.btnUpdateStaff);
            this.gbxUpdateStaff.Controls.Add(this.lblUpdateStaffRole);
            this.gbxUpdateStaff.Controls.Add(this.lblUpdateStaffContactNo);
            this.gbxUpdateStaff.Controls.Add(this.lblUpdateStaffLastName);
            this.gbxUpdateStaff.Controls.Add(this.txtLastNameUpdate);
            this.gbxUpdateStaff.Controls.Add(this.lblUpdateStaffFirstName);
            this.gbxUpdateStaff.Controls.Add(this.txtNameUpdate);
            this.gbxUpdateStaff.Controls.Add(this.txtPasswordUpdate);
            this.gbxUpdateStaff.Controls.Add(this.lblUpdateStaffpassword);
            this.gbxUpdateStaff.Controls.Add(this.txtUsernameUpdate);
            this.gbxUpdateStaff.Controls.Add(this.lblUpdateStaffUusername);
            this.gbxUpdateStaff.Location = new System.Drawing.Point(22, 376);
            this.gbxUpdateStaff.Name = "gbxUpdateStaff";
            this.gbxUpdateStaff.Size = new System.Drawing.Size(732, 131);
            this.gbxUpdateStaff.TabIndex = 15;
            this.gbxUpdateStaff.TabStop = false;
            this.gbxUpdateStaff.Text = "Update Staff Member";
            // 
            // lblSelectAstaffMemeber
            // 
            this.lblSelectAstaffMemeber.AutoSize = true;
            this.lblSelectAstaffMemeber.Location = new System.Drawing.Point(322, 104);
            this.lblSelectAstaffMemeber.Name = "lblSelectAstaffMemeber";
            this.lblSelectAstaffMemeber.Size = new System.Drawing.Size(173, 13);
            this.lblSelectAstaffMemeber.TabIndex = 15;
            this.lblSelectAstaffMemeber.Text = "**Select A staff Member To Update";
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
            // lblUpdateStaffRole
            // 
            this.lblUpdateStaffRole.AutoSize = true;
            this.lblUpdateStaffRole.Location = new System.Drawing.Point(9, 89);
            this.lblUpdateStaffRole.Name = "lblUpdateStaffRole";
            this.lblUpdateStaffRole.Size = new System.Drawing.Size(32, 13);
            this.lblUpdateStaffRole.TabIndex = 11;
            this.lblUpdateStaffRole.Text = "Role:";
            // 
            // lblUpdateStaffContactNo
            // 
            this.lblUpdateStaffContactNo.AutoSize = true;
            this.lblUpdateStaffContactNo.Location = new System.Drawing.Point(606, 24);
            this.lblUpdateStaffContactNo.Name = "lblUpdateStaffContactNo";
            this.lblUpdateStaffContactNo.Size = new System.Drawing.Size(70, 13);
            this.lblUpdateStaffContactNo.TabIndex = 9;
            this.lblUpdateStaffContactNo.Text = "Contact No. :";
            // 
            // lblUpdateStaffLastName
            // 
            this.lblUpdateStaffLastName.AutoSize = true;
            this.lblUpdateStaffLastName.Location = new System.Drawing.Point(460, 24);
            this.lblUpdateStaffLastName.Name = "lblUpdateStaffLastName";
            this.lblUpdateStaffLastName.Size = new System.Drawing.Size(61, 13);
            this.lblUpdateStaffLastName.TabIndex = 7;
            this.lblUpdateStaffLastName.Text = "Last Name:";
            // 
            // txtLastNameUpdate
            // 
            this.txtLastNameUpdate.Location = new System.Drawing.Point(463, 44);
            this.txtLastNameUpdate.Name = "txtLastNameUpdate";
            this.txtLastNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameUpdate.TabIndex = 6;
            this.txtLastNameUpdate.TextChanged += new System.EventHandler(this.txtLastNameUpdate_TextChanged);
            // 
            // lblUpdateStaffFirstName
            // 
            this.lblUpdateStaffFirstName.AutoSize = true;
            this.lblUpdateStaffFirstName.Location = new System.Drawing.Point(326, 24);
            this.lblUpdateStaffFirstName.Name = "lblUpdateStaffFirstName";
            this.lblUpdateStaffFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblUpdateStaffFirstName.TabIndex = 5;
            this.lblUpdateStaffFirstName.Text = "First Name:";
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
            // lblUpdateStaffpassword
            // 
            this.lblUpdateStaffpassword.AutoSize = true;
            this.lblUpdateStaffpassword.Location = new System.Drawing.Point(169, 24);
            this.lblUpdateStaffpassword.Name = "lblUpdateStaffpassword";
            this.lblUpdateStaffpassword.Size = new System.Drawing.Size(56, 13);
            this.lblUpdateStaffpassword.TabIndex = 2;
            this.lblUpdateStaffpassword.Text = "Password:";
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
            // lblUpdateStaffUusername
            // 
            this.lblUpdateStaffUusername.AutoSize = true;
            this.lblUpdateStaffUusername.Location = new System.Drawing.Point(7, 24);
            this.lblUpdateStaffUusername.Name = "lblUpdateStaffUusername";
            this.lblUpdateStaffUusername.Size = new System.Drawing.Size(58, 13);
            this.lblUpdateStaffUusername.TabIndex = 0;
            this.lblUpdateStaffUusername.Text = "Username:";
            // 
            // gbxAddNewStaff
            // 
            this.gbxAddNewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxAddNewStaff.Controls.Add(this.cmbStaffRole);
            this.gbxAddNewStaff.Controls.Add(this.txtContactStaff);
            this.gbxAddNewStaff.Controls.Add(this.btnAddStaffMember);
            this.gbxAddNewStaff.Controls.Add(this.lblRoleFilterAddNewStaff);
            this.gbxAddNewStaff.Controls.Add(this.lblContactNoStaff);
            this.gbxAddNewStaff.Controls.Add(this.lblLastNameStaff);
            this.gbxAddNewStaff.Controls.Add(this.txtLastNameStaff);
            this.gbxAddNewStaff.Controls.Add(this.lblFirstNameStaff);
            this.gbxAddNewStaff.Controls.Add(this.txtFirstNameStaff);
            this.gbxAddNewStaff.Controls.Add(this.txtPasswordStaff);
            this.gbxAddNewStaff.Controls.Add(this.lblPassword);
            this.gbxAddNewStaff.Controls.Add(this.txtUsernameStaff);
            this.gbxAddNewStaff.Controls.Add(this.lblUsernameStaff);
            this.gbxAddNewStaff.Location = new System.Drawing.Point(22, 233);
            this.gbxAddNewStaff.Name = "gbxAddNewStaff";
            this.gbxAddNewStaff.Size = new System.Drawing.Size(732, 131);
            this.gbxAddNewStaff.TabIndex = 1;
            this.gbxAddNewStaff.TabStop = false;
            this.gbxAddNewStaff.Text = "Add New Staff Member";
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
            // lblRoleFilterAddNewStaff
            // 
            this.lblRoleFilterAddNewStaff.AutoSize = true;
            this.lblRoleFilterAddNewStaff.Location = new System.Drawing.Point(9, 89);
            this.lblRoleFilterAddNewStaff.Name = "lblRoleFilterAddNewStaff";
            this.lblRoleFilterAddNewStaff.Size = new System.Drawing.Size(32, 13);
            this.lblRoleFilterAddNewStaff.TabIndex = 11;
            this.lblRoleFilterAddNewStaff.Text = "Role:";
            // 
            // lblContactNoStaff
            // 
            this.lblContactNoStaff.AutoSize = true;
            this.lblContactNoStaff.Location = new System.Drawing.Point(606, 24);
            this.lblContactNoStaff.Name = "lblContactNoStaff";
            this.lblContactNoStaff.Size = new System.Drawing.Size(70, 13);
            this.lblContactNoStaff.TabIndex = 9;
            this.lblContactNoStaff.Text = "Contact No. :";
            // 
            // lblLastNameStaff
            // 
            this.lblLastNameStaff.AutoSize = true;
            this.lblLastNameStaff.Location = new System.Drawing.Point(460, 24);
            this.lblLastNameStaff.Name = "lblLastNameStaff";
            this.lblLastNameStaff.Size = new System.Drawing.Size(61, 13);
            this.lblLastNameStaff.TabIndex = 7;
            this.lblLastNameStaff.Text = "Last Name:";
            // 
            // txtLastNameStaff
            // 
            this.txtLastNameStaff.Location = new System.Drawing.Point(463, 44);
            this.txtLastNameStaff.Name = "txtLastNameStaff";
            this.txtLastNameStaff.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameStaff.TabIndex = 6;
            this.txtLastNameStaff.TextChanged += new System.EventHandler(this.txtLastNameStaff_TextChanged);
            // 
            // lblFirstNameStaff
            // 
            this.lblFirstNameStaff.AutoSize = true;
            this.lblFirstNameStaff.Location = new System.Drawing.Point(326, 24);
            this.lblFirstNameStaff.Name = "lblFirstNameStaff";
            this.lblFirstNameStaff.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNameStaff.TabIndex = 5;
            this.lblFirstNameStaff.Text = "First Name:";
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
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(169, 24);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsernameStaff
            // 
            this.txtUsernameStaff.Location = new System.Drawing.Point(7, 44);
            this.txtUsernameStaff.Name = "txtUsernameStaff";
            this.txtUsernameStaff.Size = new System.Drawing.Size(100, 20);
            this.txtUsernameStaff.TabIndex = 1;
            this.txtUsernameStaff.TextChanged += new System.EventHandler(this.txtUsernameStaff_TextChanged);
            // 
            // lblUsernameStaff
            // 
            this.lblUsernameStaff.AutoSize = true;
            this.lblUsernameStaff.Location = new System.Drawing.Point(7, 24);
            this.lblUsernameStaff.Name = "lblUsernameStaff";
            this.lblUsernameStaff.Size = new System.Drawing.Size(58, 13);
            this.lblUsernameStaff.TabIndex = 0;
            this.lblUsernameStaff.Text = "Username:";
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
            this.gbxUpdateStaff.ResumeLayout(false);
            this.gbxUpdateStaff.PerformLayout();
            this.gbxAddNewStaff.ResumeLayout(false);
            this.gbxAddNewStaff.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxAddNewStaff;
        private System.Windows.Forms.Label lblUsernameStaff;
        private System.Windows.Forms.TextBox txtUsernameStaff;
        private System.Windows.Forms.TextBox txtFirstNameStaff;
        private System.Windows.Forms.TextBox txtPasswordStaff;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAddStaffMember;
        private System.Windows.Forms.Label lblRoleFilterAddNewStaff;
        private System.Windows.Forms.Label lblContactNoStaff;
        private System.Windows.Forms.Label lblLastNameStaff;
        private System.Windows.Forms.TextBox txtLastNameStaff;
        private System.Windows.Forms.Label lblFirstNameStaff;
        private System.Windows.Forms.MaskedTextBox txtContactStaff;
        private System.Windows.Forms.ComboBox cmbStaffRole;
        private System.Windows.Forms.BindingSource staffBindingSource1;
        private System.Windows.Forms.GroupBox gbxUpdateStaff;
        private System.Windows.Forms.ComboBox cmbStaffRoleUpdate;
        private System.Windows.Forms.MaskedTextBox txtContactUpdate;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Label lblUpdateStaffRole;
        private System.Windows.Forms.Label lblUpdateStaffContactNo;
        private System.Windows.Forms.Label lblUpdateStaffLastName;
        private System.Windows.Forms.TextBox txtLastNameUpdate;
        private System.Windows.Forms.Label lblUpdateStaffFirstName;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Label lblUpdateStaffpassword;
        private System.Windows.Forms.TextBox txtUsernameUpdate;
        private System.Windows.Forms.Label lblUpdateStaffUusername;
        private System.Windows.Forms.Label lblFilterRole;
        private System.Windows.Forms.ComboBox cmbFilterByRole;
        private System.Windows.Forms.Label lblSelectAstaffMemeber;
        private System.Windows.Forms.TextBox txtSearchStaffByName;
        private System.Windows.Forms.Label lblSearchStaff;
        private System.Windows.Forms.Label lblStaffMgtHeading;
        private System.Windows.Forms.Button btnArchiveStaff;
    }
}