using Istn3ASproject.WstGrp11DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Istn3ASproject
{
    public partial class frmUserManagement : Form
    {
        int orginalStaffID;
        public frmUserManagement()
        {
            InitializeComponent();
        }
        

        private Action<Form> navigate;
        private frmPOS posForm;

        public frmUserManagement(Action<Form> navigateTo, frmPOS posFormRef)
        {
            InitializeComponent();
            navigate = navigateTo;
            posForm = posFormRef;
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
           
            DialogResult dialoganswer = MessageBox.Show("Are you sure you want to add a new staff member?", "Confirmation", MessageBoxButtons.YesNo);
            bool Validate = validateFields(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
                txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);

            bool bFlag = true; // goes to false if notSelected=true
            bool notSelected = cmbStaffRole.SelectedIndex == -1;
            if (notSelected) {
                bFlag = false;
                MessageBox.Show("You have not selected a Staff Role");
            }

            if (dialoganswer == DialogResult.Yes && Validate && bFlag) 
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

                    MessageBox.Show("Staff Member NOT Added","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    SystemSounds.Exclamation.Play();
                }
            }
                else{ 
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
            DialogResult result = MessageBox.Show("Are you sure you want to update this Customer's Details?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //bool valid = validateInput(txtUfname.Text, txtUlname.Text, mtUpdateCustContact.Text, txtUemail.Text, txtUaddress.Text, txtUcity.Text, cbUprovince.Text, txtUcode.Text);

            if (result == DialogResult.Yes)
            {
                try
                {
                    mtUpdateCustContact.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    customerTableAdapter.UpdateCustomerDetails(txtUfname.Text, txtUlname.Text, mtUpdateCustContact.Text, txtUemail.Text,  txtUcity.Text, cbUprovince.Text, txtUcode.Text, txtUaddress.Text, Convert.ToInt32(gvCustomer.CurrentRow.Cells[0].Value.ToString()));
                    customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
                    txtUfname.Clear();
                    txtUlname.Clear();
                    txtUemail.Clear();
                    txtUaddress.Clear();
                    txtUcity.Clear();
                    mtUpdateCustContact.Clear();
                    txtUcode.Clear();
                    cbUprovince.Text = null;
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
            if (txtUsernameUpdate.Text.Length < 5)
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
            bool updateIsValid = validateFields(txtUsernameUpdate.Text,txtPasswordUpdate.Text,txtNameUpdate.Text,
                txtLastNameUpdate.Text,txtContactUpdate.Text,cmbStaffRoleUpdate.SelectedItem.ToString());
            DialogResult dialoganswerUpdate = MessageBox.Show("Are you sure you want to Update staff member: " + txtNameUpdate.Text + " " + txtLastNameUpdate.Text + " ?"
                , "Confirmation", MessageBoxButtons.YesNo);

            if (updateIsValid == true && dialoganswerUpdate == DialogResult.Yes)
            {
                staffTableAdapter.UpdateStaffMember(txtUsernameUpdate.Text,txtPasswordUpdate.Text,txtNameUpdate.Text,
                    txtLastNameUpdate.Text,txtContactUpdate.Text,cmbStaffRoleUpdate.Text,orginalStaffID);
                MessageBox.Show("Staff Member Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("Staff Member NOT Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }

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
               /* staffTableAdapter.ArchiveStaffMember("Terminated", Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[1].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[2].Value),
                    Convert.ToString(dgvStaffMgt.CurrentRow.Cells[3].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[4].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[5].Value),
                    Convert.ToString(dgvStaffMgt.CurrentRow.Cells[6].Value), Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value));
                staffTableAdapter.Fill(wstGrp11DataSet.Staff);*/
                MessageBox.Show("Archive not Successful please check code", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Archive Terminated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }

        private void txtUsernameStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernameStaff.Text.Length < 5)
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

              

        

        private void btnSearchByNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearchByNo.BackColor = Color.DodgerBlue;
            btnSearchByNo.ForeColor = Color.White;
        }

        private void btnSearchByNo_MouseLeave(object sender, EventArgs e)
        {
            btnSearchByNo.BackColor = Color.Azure;
            btnSearchByNo.ForeColor = Color.Black;
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
            DialogResult result = MessageBox.Show("Are you sure you want to add this Supplier's Details?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //bool valid = validateInput(txtSname.Text,txtLName.Text, mtSupplierContact.Text, txtSemail.Text, txtSaddress.Text, txtScity.Text, cbSprovince.Text, txtScode.Text);
          
            if (result == DialogResult.Yes )
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
            supplierTableAdapter.UpdateSupplierDetails(txtEditSname.Text, mtEditSupplierContact.Text, txtEditSemail.Text, txtEditSaddress.Text, txtEditScity.Text, cbEditSprovince.Text, txtEditScode.Text, Convert.ToInt32(gvSupplier.CurrentRow.Cells[0].Value.ToString()));
            supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
            txtEditSname.Clear();
            mtEditSupplierContact.Clear();
            txtEditSemail.Clear(); 
            txtEditSaddress.Clear();
            txtEditScode.Clear();
            cbEditSprovince.Text = null;

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
            DialogResult result = MessageBox.Show("Are you sure you want to add this Customer?", "Confirm Details?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //bool valid = validateInput(txtFName.Text, txtLName.Text, mtCustomerNo.Text, txtEmail.Text, txtAddress.Text, txtCity.Text, cbProvince.Text, txtPostalCode.Text);

            if (result == DialogResult.Yes)
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
                }
                catch (Exception)
                {
                    MessageBox.Show("New Customer not Added", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                DialogResult retry =MessageBox.Show("Customer was not added: Invalid data", "Process Termination", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
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
                }
            }



        }

        private void gbUpdateSupplier_Enter(object sender, EventArgs e)
        {

        }

        

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            
            posForm.UpdateLabel(gvCustomer.CurrentRow.Cells[1].Value.ToString(), gvCustomer.CurrentRow.Cells[2].Value.ToString(), gvCustomer.CurrentRow.Cells[0].Value.ToString());
            navigate(posForm);

        }
    }
}
