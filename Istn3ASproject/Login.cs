using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Istn3ASproject
{
    public partial class frmLogin: Form
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Role { get; set; }
        public int staffID { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void pbVisiblity_Click(object sender, EventArgs e)
        {
            if  (txtPass.UseSystemPasswordChar == false)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }

                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUser.Text;
            string enteredPassword = txtPass.Text;
            bool bGrantAccess = true;

            this.staffTableAdapter.CheckLogin(this.loginDataSet.Staff, enteredUsername, enteredPassword);

            if (loginDataSet.Staff.Rows.Count > 0)
            {
                //LOGIN SUCCESSFUL 
                //capture users details into global vars
                staffID = Convert.ToInt32(loginDataSet.Staff.Rows[0].ItemArray[0].ToString());
                Fname = loginDataSet.Staff.Rows[0].ItemArray[3].ToString();
                Lname = loginDataSet.Staff.Rows[0].ItemArray[4].ToString();
                Role = loginDataSet.Staff.Rows[0].ItemArray[6].ToString();
               

                if (Role.ToLower() == "terminated") {
                    bGrantAccess = false; //deny access
                }

                if (loginDataSet.Staff.Rows.Count > 0 && bGrantAccess == true)
                {
                    new SpeechSynthesizer().Speak("Access Granted" + "Welcome" + Fname + Lname);
                    MainMenu mainForm = new MainMenu(Fname,Lname,Role,staffID);
                    //mainForm.lblU.Text = "User Logged in: " + Fname + " " + Lname;
                    //mainForm.lblR.Text = "Role: " + Role;
                    this.Hide();
                    mainForm.ShowDialog();
                   
                }
                else
                {
                    new SpeechSynthesizer().Speak("Access Denied: Staff Member Is Terminated");
                }

            }
            else {
                //LOGIN UNSUCCESSFUL
                new SpeechSynthesizer().Speak("Access Denied: username or password is not found");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.loginDataSet.Staff);

        }

        private void checkLoginToolStripButton_Click(object sender, EventArgs e)
        {
            try {
                
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
