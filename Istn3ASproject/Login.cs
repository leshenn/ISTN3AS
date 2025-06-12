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

namespace Istn3ASproject
{
    public partial class frmLogin: Form
    {
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
            else if (txtPass.UseSystemPasswordChar = true)
            {
                txtPass.UseSystemPasswordChar = false;
            }

                
        }
    }
}
