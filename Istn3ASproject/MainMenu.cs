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
        

        public MainMenu()
        {
            InitializeComponent();
        }

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
            loadForm(new frmUserManagement());
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            loadForm(new frmPOS());
        }
    }
}
