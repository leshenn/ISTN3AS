using Istn3ASproject.WstGrp11DataSetTableAdapters;
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
    public partial class frmUserManagement: Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.wstGrp11DataSet.Staff);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);

        }

       


        private void btnSearchByNo_Click(object sender, EventArgs e)

        {
            mtSearchNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            customerTableAdapter.FillByContactNumber(this.wstGrp11DataSet.Customer, mtSearchNo.Text);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add this Customer?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                mtCNo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                customerTableAdapter.InsertCustomer(txtFName.Text, txtLName.Text, mtCNo.Text, txtEmail.Text, txtCity.Text, cbProvince.Text, txtPostalCode.Text, txtAddress.Text);
                customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
                txtFName.Clear();
                txtLName.Clear();
                txtEmail.Clear();
                txtCity.Clear();
                txtPostalCode.Clear();
                mtCNo = null;
                cbProvince.Text = null;
            }
            else if (result == DialogResult.No)
            {
                txtFName.Clear();
                txtLName.Clear();
                txtEmail.Clear();
                txtCity.Clear();
                txtPostalCode.Clear();
                mtCNo = null;
                cbProvince.Text = null;
            }
           

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
            mtUcnum.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mtUcnum.Text = gvCustomer.CurrentRow.Cells[3].Value.ToString();
            txtUemail.Text= gvCustomer.CurrentRow.Cells[4].Value.ToString();
            txtUaddress.Text= gvCustomer.CurrentRow.Cells[5].Value.ToString();
            txtUcity.Text= gvCustomer.CurrentRow.Cells[6].Value.ToString();
            cbUprovince.Text= gvCustomer.CurrentRow.Cells[7].Value.ToString();
            txtUcode.Text = gvCustomer.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this Customer's Details?", "Confirm Details?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                mtUcnum.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                customerTableAdapter.UpdateCustomerDetails(txtUfname.Text, txtUlname.Text, mtUcnum.Text, txtUemail.Text, txtUaddress.Text, txtUcity.Text, cbUprovince.Text, txtUcode.Text, Convert.ToInt32(gvCustomer.CurrentRow.Cells[0].Value.ToString()));
                customerTableAdapter.Fill(this.wstGrp11DataSet.Customer);
                txtUfname.Clear();
                txtUlname.Clear();
                txtUemail.Clear();
                txtUaddress.Clear();
                txtUcity.Clear();
                mtUcnum.Clear();
                txtUcode.Clear();
                cbUprovince.Text = null;
            }
            else if (result == DialogResult.No){
                txtUfname.Clear();
                txtUlname.Clear();
                txtUemail.Clear();
                txtUaddress.Clear();
                txtUcity.Clear();
                mtUcnum.Clear();
                txtUcode.Clear();
                cbUprovince.Text = null;
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
            supplierTableAdapter.InsertSupplier(txtSname.Text, mtScnum.Text, txtSemail.Text, txtSaddress.Text, txtScity.Text, cbSprovince.Text, txtScode.Text);
            supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            supplierTableAdapter.UpdateSupplierDetails(txtEditSname.Text, mtEditcnum.Text, txtEditSemail.Text, txtEditSaddress.Text, txtEditScity.Text, cbEditSprovince.Text, txtEditScode.Text, Convert.ToInt32(gvSupplier.CurrentRow.Cells[0].Value.ToString()));
            supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
            txtEditSname.Clear();
            mtEditcnum.Clear();
            txtEditSemail.Clear(); 
            txtEditSaddress.Clear();
            txtEditScode.Clear();
            cbEditSprovince.Text = null;

        }

        private void gvSupplier_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEditSname.Text = gvSupplier.CurrentRow.Cells[1].Value.ToString();
            mtEditcnum.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            mtEditcnum.Text = gvSupplier.CurrentRow.Cells[2].Value.ToString();
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
    }
}
