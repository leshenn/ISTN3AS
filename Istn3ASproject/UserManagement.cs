using Istn3ASproject.WstGrp11DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Istn3ASproject
{
    public partial class frmUserManagement: Form
    {
        private readonly string _userRole;
        int orginalStaffID;
        public frmUserManagement(string userRole)
        {

            InitializeComponent();
            _userRole = userRole;
            ConfigureAccess();
        }
        

        private Action<Form> navigate;
        private frmPOS posForm;

        public frmUserManagement(Action<Form> navigateTo, string role)
        {
            InitializeComponent();
            navigate = navigateTo;

            _userRole = role;
        }

        private int _currentStaffID;
        private string _currentStaffName;

        public frmUserManagement(Action<Form> navigateTo, string userRole, int staffID, string staffName)
        {
            InitializeComponent();
            navigate = navigateTo;
            this._userRole = userRole;
            this._currentStaffID = staffID; // Store the current staff ID
            this._currentStaffName = staffName; // Store the current staff name
            ConfigureAccess();
        }

        public frmUserManagement(Action<Form> navigateTo,frmPOS posform,string role)
        {
            InitializeComponent();
            navigate = navigateTo;
            this.posForm = posform;
            _userRole =role; 
            ConfigureAccess();
        }

        private void ConfigureAccess()
        {
            // Disable all tabs first
            tbpStaff.Enabled = false;
            tbpCustomers.Enabled = false;
            tbpSuppliers.Enabled = false;
            // Enable based on role
            switch (_userRole.ToLower())
            {
                case "owner":
                case "manager":
                    tbpStaff.Enabled = true;
                    tbpCustomers.Enabled = true;
                    tbpSuppliers.Enabled = true;
                    break;

                case "cashier":
                    tbpCustomers.Enabled = true; // Only customers tab
                    tcUserManagement.TabPages.Remove(tbpStaff);
                    tcUserManagement.TabPages.Remove(tbpSuppliers);
                    break;
            }
        }



        private void frmUserManagement_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'wstGrp11DataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.wstGrp11DataSet.Staff);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
           
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
      

        }

        private Boolean validateFields(string Username,string Password,string FirstName,string LastName
            ,string ContactNo,string Role)
        {
            // Initialize all validation flags
            bool isValid = true;

            // Validate First Name (letters and spaces only)
            bool isFirstNameValid = !string.IsNullOrWhiteSpace(FirstName) &&
                                  FirstName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            if (!isFirstNameValid)
            {
                MessageBox.Show("First name can only contain letters and spaces", "Validation Error");
                isValid = false;
            }

            // Validate Last Name (letters and spaces only)
            bool isLastNameValid = !string.IsNullOrWhiteSpace(LastName) &&
                                 LastName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            if (!isLastNameValid)
            {
                MessageBox.Show("Last name can only contain letters and spaces", "Validation Error");
                isValid = false;
            }

            // Validate Password (minimum 6 characters)
            bool isPasswordValid = !string.IsNullOrWhiteSpace(Password) && Password.Length >= 6;
            if (!isPasswordValid)
            {
                MessageBox.Show("Password must be at least 6 characters long", "Validation Error");
                isValid = false;
            }

            // Validate Username
            bool isUsernameValid = !string.IsNullOrWhiteSpace(Username) &&
                                 Username.Length >= 6 &&
                                 !Username.Contains(" ");
            if (!isUsernameValid)
            {
                MessageBox.Show("Username must be at least 6 characters with no spaces", "Validation Error");
                isValid = false;
            }

            // Validate Role (not empty)
            bool isRoleValid = !string.IsNullOrWhiteSpace(Role);
            if (!isRoleValid)
            {
                MessageBox.Show("Please select a role", "Validation Error");
                isValid = false;
            }

            // Validate Contact Number
            string cleanContactNo = new string(ContactNo.Where(char.IsDigit).ToArray());
            // (098) 8908765 --> 0988908765
            if (cleanContactNo.Length != 10)
            {
                MessageBox.Show("Phone number must contain exactly 10 digits", "Validation Error");
                isValid = false;
            }

            return isValid;
        }
        

        private void btnAddStaffMember_Click(object sender, EventArgs e)
        {

            //DialogResult dialoganswer = MessageBox.Show("Are you sure you want to add a new staff member?", "Confirmation", MessageBoxButtons.YesNo);
            //bool Validate = validateFields(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
            //    txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);

            //bool bFlag = true; // goes to false if notSelected=true
            //bool notSelected = cmbStaffRole.SelectedIndex == -1;
            //if (notSelected) {
            //    bFlag = false;
            //    MessageBox.Show("You have not selected a Staff Role");
            //}

            //if (dialoganswer == DialogResult.Yes && Validate && bFlag) 
            //{
            //    try
            //    {
            //        staffTableAdapter.AddNewStaffMember(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
            //    txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);

            //        SystemSounds.Beep.Play();
            //        MessageBox.Show("Staff Member Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtUsernameStaff.Clear();
            //        txtPasswordStaff.Clear();
            //        txtLastNameStaff.Clear();
            //        txtFirstNameStaff.Clear();
            //        txtContactStaff.Clear();
            //        cmbStaffRole.SelectedIndex = -1;
            //        staffTableAdapter.Fill(wstGrp11DataSet.Staff);
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Staff Member NOT Added","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //        SystemSounds.Exclamation.Play();
            //    }
            //}
            //    else{ 
            //         SystemSounds.Beep.Play();
            //        MessageBox.Show("Staff Member NOT Added : Process Termination", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtUsernameStaff.Clear();
            //        txtPasswordStaff.Clear();
            //        txtLastNameStaff.Clear();
            //        txtFirstNameStaff.Clear();
            //        txtContactStaff.Clear();
            //        cmbStaffRole.SelectedIndex = -1;
            //        SystemSounds.Beep.Play();
            //}

            bool Validate = validateFields(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
                txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);

            bool bFlag = true; // goes to false if notSelected=true
            bool notSelected = cmbStaffRole.SelectedIndex == -1;
            if (notSelected)
            {
                bFlag = false;
                MessageBox.Show("You have not selected a Staff Role");
            }

            //  Only ask for confirmation if validation & role check pass
            if (Validate && bFlag)
            {
                DialogResult dialoganswer = MessageBox.Show("Are you sure you want to add a new staff member?", "Confirmation", MessageBoxButtons.YesNo);

                if (dialoganswer == DialogResult.Yes)
                {
                    try
                    {
                        staffTableAdapter.AddNewStaffMember(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
                            txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);

                        SystemSounds.Beep.Play();
                        MessageBox.Show("Staff Member Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsernameStaff.Clear();
                        txtPasswordStaff.Clear();
                        txtLastNameStaff.Clear();
                        txtFirstNameStaff.Clear();
                        txtContactStaff.Clear();
                        cmbStaffRole.SelectedIndex = -1;
                        staffTableAdapter.Fill(wstGrp11DataSet.Staff);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Staff Member NOT Added", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        SystemSounds.Exclamation.Play();
                    }
                }
                else
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Staff Member NOT Added : Process Termination", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsernameStaff.Clear();
                    txtPasswordStaff.Clear();
                    txtLastNameStaff.Clear();
                    txtFirstNameStaff.Clear();
                    txtContactStaff.Clear();
                    cmbStaffRole.SelectedIndex = -1;
                    SystemSounds.Beep.Play();
                }
            }
            else
            {
                // Validation failed, so no confirmation is shown
                SystemSounds.Beep.Play();
                MessageBox.Show("Staff Member NOT Added : Validation Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            

        

       


        private void btnSearchByNo_Click(object sender, EventArgs e)

        {
            mtSearchNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            customerTableAdapter.FillByContactNumber(this.wstGrp11DataSet.Customer, mtSearchNo.Text);
        }

      
       
        private void btnNewCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            btnNewCustomer.BackColor = Color.DodgerBlue;
            btnNewCustomer.ForeColor = Color.White;
        }

        private void btnNewCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnNewCustomer.BackColor = Color.Azure;
            btnNewCustomer.ForeColor = Color.Black;

        }
        //adds the selected customer to the Update textbox section
        private void gvCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUfname.Text= gvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtUlname.Text= gvCustomer.CurrentRow.Cells[2].Value.ToString();
            mtUpdateCustContact.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mtUpdateCustContact.Text = gvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtUemail.Text= gvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtUaddress.Text= gvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtUcity.Text= gvCustomer.CurrentRow.Cells[6].Value.ToString();
            cbUprovince.Text= gvCustomer.CurrentRow.Cells[7].Value.ToString();
            txtUcode.Text = gvCustomer.CurrentRow.Cells[8].Value.ToString();
        }


        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            mtUpdateCustContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            DialogResult result = MessageBox.Show("Are you sure you want to update " + txtUfname.Text + " " + txtUlname.Text + " Details?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool valid = validateInput(txtUfname, txtUlname, mtUpdateCustContact, txtUemail, txtUaddress, txtUcity, cbUprovince, txtUcode, lblEditCusFname, lblEditCusLname, lblEditCusNumber, lblEditCusEmail, lblEditCusAddress, lblEditCusCity, lblEditCusProvince, lblEditCusPostal);

            if (result == DialogResult.Yes && valid)
            {
                try
                {
                    mtUpdateCustContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    customerTableAdapter.UpdateCustomerDetails(txtUfname.Text, txtUlname.Text, mtUpdateCustContact.Text, txtUemail.Text, txtUcity.Text, cbUprovince.Text, txtUcode.Text, txtUaddress.Text, Convert.ToInt32(gvCustomer.CurrentRow.Cells[0].Value.ToString()));
                    customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
                    txtUfname.Clear();
                    txtUlname.Clear();
                    txtUemail.Clear();
                    txtUaddress.Clear();
                    txtUcity.Clear();
                    mtUpdateCustContact.Clear();
                    txtUcode.Clear();
                    cbUprovince.Text = null;
                    MessageBox.Show("Customer Details successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Customer Details could not be Updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                DialogResult retry = MessageBox.Show("Customer Details could not be Updated: Invalid Data", "Process Termination", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                if (retry == DialogResult.Cancel)
                {
                    txtUfname.Clear();
                    txtUlname.Clear();
                    txtUemail.Clear();
                    txtUaddress.Clear();
                    txtUcity.Clear();
                    mtUpdateCustContact.Clear();
                    txtUcode.Clear();
                    cbUprovince.Text = null;
                }
            }
        }




        private void dgvStaffMgt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orginalStaffID = Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value);
            txtUsernameUpdate.Text = Convert.ToString(dgvStaffMgt.CurrentRow.Cells[1].Value);
            txtPasswordUpdate.Text = Convert.ToString(dgvStaffMgt.CurrentRow.Cells[2].Value);
            txtNameUpdate.Text = Convert.ToString(dgvStaffMgt.CurrentRow.Cells[3].Value);
            txtLastNameUpdate.Text = Convert.ToString(dgvStaffMgt.CurrentRow.Cells[4].Value);
            txtContactUpdate.Text = Convert.ToString(dgvStaffMgt.CurrentRow.Cells[5].Value);
            cmbStaffRoleUpdate.Text = Convert.ToString(dgvStaffMgt.CurrentRow.Cells[6].Value);

        }

        private void txtUsernameUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernameUpdate.Text.Length < 6)
            {
                txtUsernameUpdate.ForeColor = Color.Red;
            }
            else {
                txtUsernameUpdate.ForeColor = Color.Black;
            }

        }

        private void txtPasswordUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordUpdate.Text.Length < 5)
            {
                txtPasswordUpdate.ForeColor = Color.Red;
            }
            else
            {
                txtPasswordUpdate.ForeColor = Color.Black;
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            //bool updateIsValid = validateFields(txtUsernameUpdate.Text,txtPasswordUpdate.Text,txtNameUpdate.Text,
            //    txtLastNameUpdate.Text,txtContactUpdate.Text,cmbStaffRoleUpdate.SelectedItem.ToString());
            //DialogResult dialoganswerUpdate = MessageBox.Show("Are you sure you want to Update staff member: " + txtNameUpdate.Text + " " + txtLastNameUpdate.Text + " ?"
            //    , "Confirmation", MessageBoxButtons.YesNo);

            //if (updateIsValid == true && dialoganswerUpdate == DialogResult.Yes)
            //{
            //    staffTableAdapter.UpdateStaffMember(txtUsernameUpdate.Text,txtPasswordUpdate.Text,txtNameUpdate.Text,
            //        txtLastNameUpdate.Text,txtContactUpdate.Text,cmbStaffRoleUpdate.Text,orginalStaffID);
            //    MessageBox.Show("Staff Member Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    staffTableAdapter.Fill(wstGrp11DataSet.Staff);
            //}
            //else { MessageBox.Show("Staff Member NOT Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            // Validate first
            bool updateIsValid = validateFields(
                txtUsernameUpdate.Text,
                txtPasswordUpdate.Text,
                txtNameUpdate.Text,
                txtLastNameUpdate.Text,
                txtContactUpdate.Text,
                cmbStaffRoleUpdate.SelectedItem?.ToString() ?? ""
            );

            // Only proceed if validation passed
            if (!updateIsValid)
            {
                MessageBox.Show("Please fix the validation errors before updating.", "Validation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop execution here
            }

            //  Ask for confirmation only if valid
            DialogResult dialoganswerUpdate = MessageBox.Show(
                "Are you sure you want to update staff member: " + txtNameUpdate.Text + " " + txtLastNameUpdate.Text + " ?",
                "Confirmation", MessageBoxButtons.YesNo
            );

            //  Update if user confirms
            if (dialoganswerUpdate == DialogResult.Yes)
            {
                staffTableAdapter.UpdateStaffMember(
                    txtUsernameUpdate.Text,
                    txtPasswordUpdate.Text,
                    txtNameUpdate.Text,
                    txtLastNameUpdate.Text,
                    txtContactUpdate.Text,
                    cmbStaffRoleUpdate.Text,
                    orginalStaffID
                );

                MessageBox.Show("Staff Member Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                staffTableAdapter.Fill(wstGrp11DataSet.Staff);
            }
            else
            {
                MessageBox.Show("Staff Member NOT Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cmbFilterByRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        staffTableAdapter.FillByRole(wstGrp11DataSet.Staff,cmbFilterByRole.Text);
         
        }

        private void txtSearchStaffByName_TextChanged(object sender, EventArgs e)
        {
            staffTableAdapter.FillByFirstName(wstGrp11DataSet.Staff,txtSearchStaffByName.Text); 
        }

        private void btnArchiveStaff_Click(object sender, EventArgs e)
        {
            DialogResult ArchiveResult = MessageBox.Show("Are you Sure you want to Archive/Terminate staff member: " + dgvStaffMgt.CurrentRow.Cells[3].Value + " " + dgvStaffMgt.CurrentRow.Cells[4].Value + "?", "Archive/Termination Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ArchiveResult == DialogResult.Yes)
            {
                staffTableAdapter.FillTerminateStaff(wstGrp11DataSet.Staff, orginalStaffID);
                staffTableAdapter.Fill(wstGrp11DataSet.Staff);

                MessageBox.Show("Archive Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Archive Terminated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }

        private void txtUsernameStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernameStaff.Text.Length < 6)
            {
                txtUsernameStaff.ForeColor = Color.Red;
            }
            else
            {
                txtUsernameStaff.ForeColor = Color.Black;
            }
        }

        private void txtPasswordStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordStaff.Text.Length < 5)
            {
                txtPasswordStaff.ForeColor = Color.Red;
            }
            else
            {
                txtPasswordStaff.ForeColor = Color.Black;
            }
        }

        private void txtNameUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtNameUpdate.Text.All(char.IsLetter))
            {
                txtNameUpdate.ForeColor = Color.Black;
            }
            else
            {
                txtNameUpdate.ForeColor = Color.Red;
            }
        }

        private void txtLastNameUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtLastNameUpdate.Text.All(char.IsLetter))
            {
                txtLastNameUpdate.ForeColor = Color.Black;
            }
            else
            {
                txtLastNameUpdate.ForeColor = Color.Red;
            }
        }

        private void txtFirstNameStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstNameStaff.Text.All(char.IsLetter))
            {
                txtFirstNameStaff.ForeColor = Color.Black;
            }
            else
            {
                txtFirstNameStaff.ForeColor = Color.Red;
            }
        }

        private void txtLastNameStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtLastNameStaff.Text.All(char.IsLetter))
            {
                txtLastNameStaff.ForeColor = Color.Black;
            }
            else
            {
                txtLastNameStaff.ForeColor = Color.Red;
            }
        }

              

        

       

        private void btnUpdateCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            btnUpdateCustomer.BackColor = Color.DodgerBlue;
            btnUpdateCustomer.ForeColor = Color.White;
        }

        private void btnUpdateCustomer_MouseLeave(object sender, EventArgs e)
        {
            btnUpdateCustomer.BackColor = Color.Azure;
            btnUpdateCustomer.ForeColor = Color.Black;
        }

        private void btnSearchSupplier_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(this.wstGrp11DataSet.Supplier,txtSearch.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {


            mtSupplierContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            DialogResult result = MessageBox.Show("Are you sure you want to add " + txtSname.Text + " ?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool valid = validateInputSupplier(txtSname, mtSupplierContact, txtSemail, txtSaddress, txtScity, cbSprovince, txtScode,lblSupplierFname,lblSupplierNum,lblSupplierEmail,lblSupplierAddress,lblSupplierCity,lblSupplierProvince,lblSupplierPostal);

            if (result == DialogResult.Yes && valid)
            {
                try
                {
                    mtSupplierContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    supplierTableAdapter.InsertSupplier(txtSname.Text, mtSupplierContact.Text, txtSemail.Text, txtSaddress.Text, txtScity.Text, cbSprovince.Text, txtScode.Text);
                    supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
                    txtSname.Clear();

                    txtSemail.Clear();
                    txtSaddress.Clear();
                    txtScity.Clear();
                    mtSupplierContact.Clear();
                    txtScode.Clear();
                    cbSprovince.Text = null;
                    MessageBox.Show("Supplier Details successfully added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Supplier Details could not be Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                DialogResult retry = MessageBox.Show("Supplier Details could not be Added: Invalid Data", "Process Termination", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                if (retry == DialogResult.Cancel)
                {
                    txtSname.Clear();
                    txtSemail.Clear();
                    txtSaddress.Clear();
                    txtScity.Clear();
                    mtSupplierContact.Clear();
                    txtScode.Clear();
                    cbSprovince.Text = null;

                }
            }
        }


        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {


            mtEditSupplierContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            DialogResult result = MessageBox.Show("Are you sure you want to edit " + txtEditSname.Text + " Details?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            bool valid = validateInputSupplier(txtEditSname, mtEditSupplierContact, txtEditSemail, txtEditSaddress, txtEditScity, cbEditSprovince, txtEditScode,lblSupplierEditName,lblSupplierEditNum,lblSupplierEditEmail,lblSupplierEditAddress,lblSupplierEditCity,lblSupplierEditProvince,lblSupplierEditPostal);

            if (result == DialogResult.Yes && valid)
            {
                try
                {
                    mtSupplierContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    supplierTableAdapter.UpdateSupplierDetails(txtEditSname.Text, mtEditSupplierContact.Text, txtEditSemail.Text, txtEditSaddress.Text, txtEditScity.Text, cbEditSprovince.Text, txtEditScode.Text, Convert.ToInt32(gvSupplier.CurrentRow.Cells[0].Value.ToString()));
                    supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);


                    txtEditSname.Clear();
                    mtEditSupplierContact.Clear();
                    txtEditSemail.Clear();
                    txtEditSaddress.Clear();
                    txtEditScode.Clear();
                    cbEditSprovince.Text = null;
                    MessageBox.Show("Supplier Details successfully updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Supplier Details could not be Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                DialogResult retry = MessageBox.Show("Supplier Details could not be Added: Invalid Data", "Process Termination", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                if (retry == DialogResult.Cancel)
                {
                    txtEditSname.Clear();
                    mtEditSupplierContact.Clear();
                    txtEditSemail.Clear();
                    txtEditSaddress.Clear();
                    txtEditScode.Clear();
                    cbEditSprovince.Text = null;
                }
            }

        }


        

        private void gvSupplier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEditSname.Text = gvSupplier.CurrentRow.Cells[1].Value.ToString();
            mtEditSupplierContact.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mtEditSupplierContact.Text = gvSupplier.CurrentRow.Cells[2].Value.ToString();
            txtEditSemail.Text = gvSupplier.CurrentRow.Cells[3].Value.ToString();
            txtEditSaddress.Text = gvSupplier.CurrentRow.Cells[4].Value.ToString();
            txtEditScity.Text = gvSupplier.CurrentRow.Cells[5].Value.ToString();
            cbEditSprovince.Text = gvSupplier.CurrentRow.Cells[6].Value.ToString();
            txtEditScode.Text = gvSupplier.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnCustomerRestore_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
        }



        private void btnNewCustomer_Click_1(object sender, EventArgs e)
        {
            mtCustomerNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            DialogResult result = MessageBox.Show("Are you sure you want to add this " + txtFName.Text + " " + txtLName.Text, "Confirm Details?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            bool valid = validateInput(txtFName, txtLName, mtCustomerNo, txtEmail, txtAddress, txtCity, cbProvince, txtPostalCode, lblCusFname1, lblCusLname, lblCusNum, lblCustomerEmail, lblCustomerAddress, lblCustomerCity, lblCustomerProvince, lblCustomerPostal);

            if (result == DialogResult.Yes && valid)
            {
                try
                {

                    mtCustomerNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    customerTableAdapter.InsertCustomer(txtFName.Text, txtLName.Text, mtCustomerNo.Text, txtEmail.Text, txtCity.Text, cbProvince.Text, txtPostalCode.Text, txtAddress.Text);
                    customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
                    MessageBox.Show("Customer successfully added", "Confirmation", MessageBoxButtons.OK);
                    txtFName.Clear();
                    txtLName.Clear();
                    txtEmail.Clear();
                    txtCity.Clear();
                    txtAddress.Clear();
                    txtPostalCode.Clear();
                    mtCustomerNo.Text = null;
                    cbProvince.SelectedIndex = -1;
                    //MessageBox.Show("Customer Details successfully added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("New Customer not Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                DialogResult retry = MessageBox.Show("Customer was not added: Invalid data", "Process Termination", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                if (retry == DialogResult.Cancel)
                {
                    txtFName.Clear();
                    txtLName.Clear();
                    txtEmail.Clear();
                    txtCity.Clear();
                    txtAddress.Clear();
                    txtPostalCode.Clear();
                    mtCustomerNo.Text = null;
                    cbProvince.SelectedIndex = -1;

                    txtFName.BackColor = Color.White;
                    txtLName.BackColor = Color.White;
                    txtCity.BackColor = Color.White;
                    mtCustomerNo.BackColor = Color.White;
                    cbProvince.BackColor = Color.White;
                    txtPostalCode.BackColor = Color.White;
                    txtAddress.BackColor = Color.White;

                }
            }


        }

        private void gbUpdateSupplier_Enter(object sender, EventArgs e)
        {

        }


        private void btnNewOrder_Click(object sender, EventArgs e)

        {
            var posForm = new frmPOS(navigate, _userRole, _currentStaffID, this._currentStaffName);
            //var posForm = new frmPOS();

            posForm.UpdateLabel(gvCustomer.CurrentRow.Cells[1].Value.ToString(), gvCustomer.CurrentRow.Cells[2].Value.ToString(), gvCustomer.CurrentRow.Cells[0].Value.ToString());
            navigate(posForm);

        }
        private bool validateInput(TextBox txtFName, TextBox txtLName, MaskedTextBox mtCustomerNo, TextBox txtEmail, TextBox txtAddress, TextBox txtCity, ComboBox cbProvince, TextBox txtPostalCode,Label lblFname, Label lbllname,Label lblCustomerNo,Label lblEmail,Label lblAddress,Label lblCity,Label lblprovince, Label lblpostalCode)
        {
            bool isValid = true;



            // First Name
            string fName = txtFName.Text.Trim();
            if (string.IsNullOrWhiteSpace(fName) || !fName.All(char.IsLetter))
            {
                isValid = false;
                lblFname.ForeColor = Color.Red;
            }
            else { lblFname.ForeColor = Color.Black; }


            // Last Name
            string lName = txtLName.Text.Trim();
            if (string.IsNullOrWhiteSpace(lName) || !lName.All(char.IsLetter))
            {

                isValid = false;
                lbllname.ForeColor = Color.Red;
            }
            else { lbllname.ForeColor = Color.Black; }

            // Contact Number
            string contact = mtCustomerNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(contact) || !contact.All(char.IsDigit) || contact.Length < 10)
            {

                isValid = false;
                lblCustomerNo.ForeColor = Color.Red;
            }
            else { lblCustomerNo.ForeColor = Color.Black; }

            // Email
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.'))
            {

                isValid = false;
                lblEmail.ForeColor = Color.Red;
            }
            else { lblEmail.ForeColor = Color.Black; }

            // Address
            string address = txtAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(address) || !address.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c=='-' || c==','))
            {

                isValid = false;
                lblAddress.ForeColor = Color.Red;
            }
            else { lblAddress.ForeColor = Color.Black; }

            // City
            string city = txtCity.Text.Trim();
            if (string.IsNullOrWhiteSpace(city) || !city.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-' || c == ',')) 
            {

                isValid = false;
                lblCity.ForeColor = Color.Red;
            }
            else { lblCity.ForeColor = Color.Black; }

            // Province 
            string province = cbProvince.Text.Trim();
            if (!string.IsNullOrWhiteSpace(province) && province.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-'))
            {
                lblprovince.ForeColor = Color.Black;

            }
            else
            {
                isValid = false;
                lblprovince.ForeColor = Color.Red;
            }

            // Postal Code
            string postalCode = txtPostalCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(postalCode) || !postalCode.All(char.IsLetterOrDigit) || txtPostalCode.Text.Length<4)
            {

                isValid = false;
                lblpostalCode.ForeColor = Color.Red;

            }
            else { lblpostalCode.ForeColor = Color.Black; }
            // MessageBox.Show(Convert.ToString(isValid));

            return isValid;
        }




        private bool validateInputSupplier(TextBox txtName, MaskedTextBox txtContactNumber, TextBox txtEmail, TextBox txtAddress, TextBox txtCity, ComboBox cbProvince, TextBox txtPostalCode, Label lblName, Label lblNo, Label lblEmail, Label lblAddress, Label lblCity, Label lblprovince, Label lblpostalCode)
        {
            bool isValid = true;

            // Name
            string name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || !name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                isValid = false;
                lblName.ForeColor = Color.Red;
            }
            else
            {
                lblName.ForeColor = Color.Black;
            }

            // Contact Number
            string contact = txtContactNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(contact) || !contact.All(char.IsDigit) || contact.Length != 10)
            {
                isValid = false;
                lblNo.ForeColor = Color.Red;
            }
            else
            {
                lblNo.ForeColor = Color.Black;
            }

            // Email
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.All(c => char.IsLetterOrDigit(c) || c == '@' || c == '.'))
            {
                isValid = false;
                lblEmail.ForeColor = Color.Red;
            }
            else
            {
                lblEmail.ForeColor = Color.Black;
            }

            // Address
            string address = txtAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(address) || !address.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == '-' || c == ','))
            {
                isValid = false;
                lblAddress.ForeColor = Color.Red;
            }
            else
            {
                lblAddress.ForeColor = Color.Black;
            }

            // City
            string city = txtCity.Text.Trim();
            if (string.IsNullOrWhiteSpace(city) || !city.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-' || c == ','))
            {
                isValid = false;
                lblCity.ForeColor = Color.Red;
            }
            else
            {
                lblCity.ForeColor = Color.Black;
            }

            // Province
            string province = cbProvince.Text.Trim();
            if (!string.IsNullOrWhiteSpace(province) && province.All(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c == '-'))
            {
                lblprovince.ForeColor = Color.Black;

            }
            else
            {
                isValid = false;
                lblprovince.ForeColor = Color.Red;
            }

            // Postal Code
            string postalCode = txtPostalCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(postalCode) || !postalCode.All(char.IsDigit) || postalCode.Length != 4)
            {
                isValid = false;
                lblpostalCode.ForeColor = Color.Red;
            }
            else
            {
                lblpostalCode.ForeColor = Color.Black;
            }

            return isValid;
        }
       

        private void btnHelpCustomerTab_Click(object sender, EventArgs e)
        {
            string helpMessage = @"CUSTOMER TAB GUIDE
==============================================================================

1. SEARCH FOR CUSTOMER:
   - Enter cellphone number in the search textbox
   - Click the 'Search' button to find the customer

2. ADD NEW CUSTOMER:
   - Required Fields:
     * Name/Lastname: Letters only (no numbers)
     * Cellphone: 10 digits (e.g., (098) 789-7654)
     * Valid email (e.g., david@gmail.com)
     * City and Postal Code: Cannot be empty
     * Province: Must select an option (not default)
   - Click 'Add New Customer' when complete

3. UPDATE CUSTOMER:
   - First select a customer from the grid
   - Customer details will auto-populate in fields
   - Follow the same data rules as adding new
   - Click 'Update Customer Details' to save
   - System will display errors if update fails";



            MessageBox.Show(helpMessage, "Customer Tab Help", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }

        private void btnHelpStaffTab_Click(object sender, EventArgs e)
        {
            string helpMessage = @"STAFF TAB GUIDE
==============================================================================

1. SEARCH FOR STAFF:
   - All Matching Results will be displayed automatically.
   - eg. Enter 'Da' --> all staff starting with 'Da' will be displayed.

2. ADD NEW STAFF:
   - Required Fields:
     * Name/Lastname: Letters only (no numbers)
     * Cellphone: 10 digits (e.g., (098) 789-7654)
     * Username of 6 or more characters. (digits, letters and special characters allowed)
     * Staff Role:  Must select an option (not default)
     * Password: Must be 6 characters or more.

TIPS :
   - The test will turn RED (while you are typing) if information is not following the above rules.
   - Click 'Add New Staff Member' when complete

3. UPDATE CUSTOMER:
   - First select a customer from the grid
   - Customer details will auto-populate in fields
   - Follow the same data rules as adding new staff
   - Click 'Update Customer Details' to save
   - System will display errors if update fails

TIPS:
   - If Update Fails because of not following input rules,
     use the system feedback to correct the input, and try again.

4. ARCHIVE STAFF MEMBER:
   - Select Staff Member First
   - Then Click 'Archive Staff Memeber'
   - This will change the role to TERMINATED
   - This means staff is no longer employed here

5. FILTER BY ROLE:
   - You can display certain staff according to role
   - Select an option 
";



        MessageBox.Show(helpMessage, "Staff Tab Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string helpMessage = @"CUSTOMER TAB GUIDE
==============================================================================

1. SEARCH FOR SUPPLIER:
   - Enter cellphone number in the search textbox
   - Click the 'Search' button to find the supplier

2. ADD NEW CUSTOMER:
   - Required Fields:
     * Name: Letters only (no numbers)
     * Cellphone: 10 digits (e.g., (098) 789-7654)
     * Valid email (e.g., david@gmail.com)
     * City and Postal Code: Cannot be empty
     * Province: Must select an option (not default)
   - Click 'Add New Supplier' when complete

3. UPDATE SUPPLIER:
   - First select a supplier from the grid
   - Supplier details will auto-populate in fields
   - Follow the same data rules as adding new
   - Click 'Update Supplier Details' to save
   - System will display errors if update fails";



            MessageBox.Show(helpMessage, "Supplier Tab Help", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void mtSearchNo_TextChanged(object sender, EventArgs e)
        {
            mtSearchNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            customerTableAdapter.FillByContactNumber(this.wstGrp11DataSet.Customer, mtSearchNo.Text);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            supplierTableAdapter.FillBySupplierName(this.wstGrp11DataSet.Supplier, txtSearch.Text);
        }

        
    }
}
