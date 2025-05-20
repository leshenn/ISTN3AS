using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istn3ASproject
{
    public partial class frmUserManagement: Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.wstGrp11DataSet.Staff);
      

        }

        private Boolean validateFields(string Username,string Password,string FirstName,string LastName
            ,string ContactNo,string Role)
        {
            bool isAllLetters_Name = FirstName.All(char.IsLetter);
            bool isAllLetters_LastName = LastName.All(char.IsLetter);
            bool passwordLength = Password.Length > 5;
            bool UsernameLength = Username.Length > 5;
            bool RoleNotEmpty = Role.Length > 0;
            bool ContactOk = ContactNo.Length == 10;

            if (isAllLetters_LastName && isAllLetters_LastName && passwordLength && UsernameLength && RoleNotEmpty && ContactOk)
            {
                return true;    
            }
            else
            {
                return false;
            }


        }

        private void btnAddStaffMember_Click(object sender, EventArgs e)
        {
           
            DialogResult dialoganswer = MessageBox.Show("Are you sure you want to add a new staff member?", "Confirmation", MessageBoxButtons.YesNo);
            bool Validate = validateFields(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
                txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);

            if (dialoganswer == DialogResult.Yes && Validate) 
            {
                try
                {
                    staffTableAdapter.AddNewStaffMember(txtUsernameStaff.Text, txtPasswordStaff.Text, txtFirstNameStaff.Text,
                txtLastNameStaff.Text, txtContactStaff.Text, cmbStaffRole.Text);
                    staffTableAdapter.Fill(wstGrp11DataSet.Staff);
                    SystemSounds.Beep.Play();
                    MessageBox.Show("Staff Member Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsernameStaff.Clear();
                    txtPasswordStaff.Clear();
                    txtLastNameStaff.Clear();
                    txtFirstNameStaff.Clear();
                    txtContactStaff.Clear();
                    cmbStaffRole.SelectedIndex = -1;
                }
                catch (Exception)
                {

                    MessageBox.Show("Staff Member NOT Added","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
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

        private void dgvStaffMgt_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
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
                txtLastNameUpdate.Text,txtContactUpdate.Text,cmbStaffRoleUpdate.Text);
            DialogResult dialoganswerUpdate = MessageBox.Show("Are you sure you want to Update staff member: " + txtNameUpdate.Text + " " + txtLastNameUpdate.Text + " ?"
                , "Confirmation", MessageBoxButtons.YesNo);

            if (updateIsValid && dialoganswerUpdate==DialogResult.Yes )
            {
                staffTableAdapter.UpdateStaffMember(txtUsernameUpdate.Text, txtPasswordUpdate.Text, txtNameUpdate.Text,
                txtLastNameUpdate.Text, txtContactUpdate.Text, cmbStaffRoleUpdate.Text, 
                Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[1].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[2].Value),
                Convert.ToString(dgvStaffMgt.CurrentRow.Cells[3].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[4].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[5].Value),
                Convert.ToString(dgvStaffMgt.CurrentRow.Cells[6].Value), Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value));
                staffTableAdapter.Fill(wstGrp11DataSet.Staff);
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Staff Member Updated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                staffTableAdapter.ArchiveStaffMember("Terminated", Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[1].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[2].Value),
                    Convert.ToString(dgvStaffMgt.CurrentRow.Cells[3].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[4].Value), Convert.ToString(dgvStaffMgt.CurrentRow.Cells[5].Value),
                    Convert.ToString(dgvStaffMgt.CurrentRow.Cells[6].Value), Convert.ToInt32(dgvStaffMgt.CurrentRow.Cells[0].Value));
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
                txtNameUpdate.ForeColor = Color.Red;
            }
            else
            {
                txtNameUpdate.ForeColor = Color.Black;
            }
        }

        private void txtLastNameUpdate_TextChanged(object sender, EventArgs e)
        {
            if (txtLastNameUpdate.Text.All(char.IsLetter))
            {
                txtLastNameUpdate.ForeColor = Color.Red;
            }
            else
            {
                txtLastNameUpdate.ForeColor = Color.Black;
            }
        }

        private void txtFirstNameStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstNameStaff.Text.All(char.IsLetter))
            {
                txtFirstNameStaff.ForeColor = Color.Red;
            }
            else
            {
                txtFirstNameStaff.ForeColor = Color.Black;
            }
        }

        private void txtLastNameStaff_TextChanged(object sender, EventArgs e)
        {
            if (txtLastNameStaff.Text.All(char.IsLetter))
            {
                txtLastNameStaff.ForeColor = Color.Red;
            }
            else
            {
                txtLastNameStaff.ForeColor = Color.Black;
            }
        }
    }
}
