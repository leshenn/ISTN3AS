using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istn3ASproject
{
    public partial class MainMenu : Form
    {
        public string ROLE;
        public int staffID;

        public MainMenu(string firstName, string lastName, string role, int staffID)
        {
            InitializeComponent();

            lblU.Text = $"User Logged in: {firstName} {lastName}";
            lblR.Text = $"Role: {role}";
            ROLE = role;
            this.staffID = staffID;
            lblStaffID.Text = $"StaffID: {staffID.ToString()}" ;
            ConfigureAccess(role);
        }

        private void ConfigureAccess(string role)
        {
            //  role-based  access
            // Reset all buttons first
            btnPOS.Enabled = false;
            btnStockManagement.Enabled = false;
            btnUserMangement.Enabled = false;
            btnReports.Enabled = false;

            // Set access based on role
            switch (role.ToLower())
            {
                case "owner":
                case "manager":
                    btnPOS.Enabled = true;
                    btnStockManagement.Enabled = true;
                    btnUserMangement.Enabled = true;
                    btnReports.Enabled = true;
                    break;

                case "cashier":
                    btnPOS.Enabled = true;
                    btnUserMangement.Enabled = true; // But will limit access in the actual form
                    break;
            }
        }

        //private frmPOS posForm = new frmPOS();

        public void loadForm(Form formToLoad)
        {
            // Hide welcome label safely
            if (lblWelcome != null)
            {
                lblWelcome.Visible = false;
                lblWelcome.SendToBack();
            }
                

            // Check if a form is already loaded
            if (this.panMain.Controls.Count > 0)
            {
                Form currentForm = this.panMain.Controls[0] as Form;

                // If the same form type is already loaded, do nothing
                if (currentForm != null && currentForm.GetType() == formToLoad.GetType())
                    return;

                // Otherwise, remove the current form
                this.panMain.Controls.Remove(currentForm);
            }

            // Load the new form
            formToLoad.TopLevel = false;
            formToLoad.Dock = DockStyle.Fill;
            this.panMain.Controls.Add(formToLoad);
            this.panMain.Tag = formToLoad;
            formToLoad.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            loadForm(new frmReports());
        }

        private void btnStockManagement_Click(object sender, EventArgs e)
        {
            loadForm(new frmStockManagement());
        }

        private void btnUserMangement_Click(object sender, EventArgs e)
        {
            //var userForm = new frmUserManagement(loadForm, new frmPOS(loadForm, ROLE, staffID), ROLE);
            var userForm = new frmUserManagement(loadForm, ROLE, staffID);
            loadForm(userForm);
        }


        private void btnPOS_Click(object sender, EventArgs e)
        {
            // Add protection against multiple clicks
            if (this.panMain.Controls.OfType<frmPOS>().Any())
            {
                MessageBox.Show("POS form is already open");
                return;
            }

            // MessageBox.Show($"Creating POS form with staffID: {staffID}"); // Debug
            var posForm = new frmPOS(loadForm, ROLE, staffID);
            loadForm(posForm);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            frmLogin loginform = new frmLogin();
        
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to LOGOUT?", "Logout Confirmation", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
