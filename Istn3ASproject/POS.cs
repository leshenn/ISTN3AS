using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Windows.Forms;

  using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Istn3ASproject
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        //move to user management form
        private Action<Form> navigate;
        private frmUserManagement userManagement;

        private frmUserManagement cusForm;
        private string userRole;
        private int staffID;

        public frmPOS(Action<Form> navigateTo, string userRole, int staffID)
        {
            InitializeComponent();
            navigate = navigateTo;
            this.userRole = userRole;
            lblStaffID.Text = staffID.ToString();

        }
        public frmPOS(Action<Form> navigateTo, frmUserManagement userRef)
        {
            InitializeComponent();

            // Initialize references inside the constructor
            navigate = navigateTo;
            userManagement = userRef;
        }



        private void frmPOS_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'wstGrp11DS.Order' table. You can move, or remove it, as needed.
            this.taOrder.Fill(this.WstGrp11DataSet.Order);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Order' table. You can move, or remove it, as needed.
            this.taOrder.Fill(this.WstGrp11DataSet.Order);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Stock' table. You can move, or remove it, as needed.
            this.taStock.Fill(this.WstGrp11DataSet.Stock);


        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            taStock.FillByName(WstGrp11DataSet.Stock, txtSearchProduct.Text);
        }

        private void dgvStock_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                dr = WstGrp11DataSet.SalesInvoice.NewRow();

                for (int i = 0; i < 5; i++)
                {
                    dr[i] = dgvStock.CurrentRow.Cells[i].Value;
                }

                WstGrp11DataSet.SalesInvoice.Rows.Add(dr);

                //set quantity to 1
                dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 1].Cells[5].Value = 1;



                CalcTotal();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Error" + ec.Message);
            }


        }

        private void dgvSalesInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcTotal();
        }

        private void CalcTotal()
        {
            decimal Total = 0;
            int quantity = 0;
            decimal price = 0;

            //loops through table to calculate total
            for (int i = 0; i < dgvSalesInvoice.Rows.Count; i++)
            {
                price = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells[3].Value);
                quantity = HandleQuantityInput(dgvSalesInvoice.Rows[i].Cells[5].Value.ToString(), i);

                dgvSalesInvoice.Rows[i].Cells[6].Value = price * quantity;
                Total += price * quantity;
            }
            lblTotal.Text = Total.ToString();
        }

        private int HandleQuantityInput(string s, int i)
        {
            int quantity = 0;
            bool isNumber = int.TryParse((dgvSalesInvoice.Rows[i].Cells[5].Value.ToString()), out quantity);

            // Checks if quantity is a number
            if (!isNumber)
            {
                MessageBox.Show("Quantity cannot be letters or symbols", "Invalid character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvSalesInvoice.Rows[i].Cells[5].Value = 1;
                return 1;
            }

            // checks is quantiy is in a valid range
            if (quantity <= 0 || quantity > Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[4].Value))
            {
                MessageBox.Show("Quantity amount has to be greater than 0 and at most equal to stock on hand", "Invalid quantity range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvSalesInvoice.Rows[i].Cells[5].Value = 1;
                return 1;
            }


            return quantity;
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {


            if (ReadyToProcess())
            {
                int CustomerID = Convert.ToInt32(lblCustID.Text);
                int StaffID = Convert.ToInt32(lblStaffID.Text);
                string TransactionType = "sale";
                string Today = DateTime.Today.ToString("yyyy-MM-dd");
                string CurrentTime = DateTime.Now.ToString("HH:mm:ss");
                Decimal Total = Convert.ToDecimal(lblTotal.Text);
                string PaymentMethod = cmbPaymentMethod.Text;

                //LETS USER CONFIRM IF ORDER IS CORRECT
                DialogResult result = MessageBox.Show("CustomerID :" + CustomerID.ToString() + "\n" +
                                 "StaffID :" + StaffID.ToString() + "\n" +
                                 "Method of Payment :" + PaymentMethod + "\n" +
                                 "Transaction Type :" + TransactionType + "\n" +
                                 "Date :" + Today + "\n" +
                                 "Time :" + CurrentTime + "\n" +
                                 "Total :" + Total.ToString() + "\n" + listItems(),
                                 "OrderDetails", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ProcessOrder(CustomerID, StaffID, PaymentMethod, TransactionType, Today, CurrentTime, Total);
                    resetInterface();
                }
                else
                {
                    MessageBox.Show("Order has been cancelled");
                    resetInterface();
                }
            }

        }

        public void resetInterface()
        {
            WstGrp11DataSet.SalesInvoice.Clear();
            txtSearchProduct.Clear();
            cmbPaymentMethod.Text = "";

            WstGrp11DataSet.RefundInnerJoin.Clear();
            taOrder.Fill(WstGrp11DataSet.Order);
            taStock.Fill(WstGrp11DataSet.Stock);

            lblTotal.Text = "R0.00";
            lblCustID.Text = "N/A";
            lblCustomerLN.Text = "N/A";
            lblCustomerName.Text = "N/A";
        }

        //ERROR CHECKS ALL FIELDS OF INFORMATION
        private bool ReadyToProcess()
        {
            bool ReadyToProcess = true;
            if (lblCustID.Text == "N/A")
            {
                ReadyToProcess = false;
                MessageBox.Show("Please select a customer for the order", "No customer selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (lblTotal.Text == "R0.00")
            {
                ReadyToProcess = false;
                MessageBox.Show("Please select items for the order", "No items selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (cmbPaymentMethod.Text != "Cash" && cmbPaymentMethod.Text != "Card")
            {
                ReadyToProcess = false;
                MessageBox.Show("Please choose a payment method", "Missing payment method", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (cmbPaymentMethod.Text == "Cash")
                {
                    bool ChangeValid = false;
                    decimal dChange = 0;
                    //ERROR CHECKING INPUT FOR  CHANGE
                    while (!ChangeValid)
                    {
                        string sChange = Interaction.InputBox("Enter amount recieved :", "Calculate change");

                        //check change amount is a number
                        if (decimal.TryParse(sChange, out dChange))
                        {
                            //check if amount recieved is greater than total
                            if (dChange > Convert.ToDecimal(lblTotal.Text))
                            {
                                ChangeValid = true;
                            }
                            else
                            {
                                MessageBox.Show("Amount receieved has to be greater than total", "Invalid change amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter a change amount with no special characters", "Invalid change amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    //CALCULATE CHANGE AMOUNT
                    decimal dChangeToGive = dChange - Convert.ToDecimal(lblTotal.Text);
                    MessageBox.Show("Change amount :" + dChangeToGive.ToString());
                }
            }
            return ReadyToProcess;
        }

        private string listItems()
        {
            string listOfItems = "";

            for (int i = 0; i < dgvSalesInvoice.Rows.Count; i++)
            {
                //GET ITEM INFORMATION
                string StockID = dgvSalesInvoice.Rows[i].Cells[0].Value.ToString();
                string name = dgvSalesInvoice.Rows[i].Cells[1].Value.ToString();
                decimal price = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells[3].Value);
                int quantity = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[5].Value.ToString());
                decimal SubTotal = price * quantity;

                //ADD TO STRING OF ITEMS
                listOfItems += " " + name + "\t" + SubTotal.ToString("C2") + "\n";
            }
            return listOfItems;
        }

        private void ProcessOrder(int CustomerID, int StaffID, string MethodOfPayment, string TransactionType, string Today, string CurrentTime, Decimal Total)
        {
            try
            {
                int OrderID = Convert.ToInt32(taOrder.InsertNewSalesOrder(CustomerID, StaffID, MethodOfPayment, TransactionType, Today, CurrentTime, Total));
                ProcessOrderLine(OrderID);
                MessageBox.Show("Order has been processed OrderId :" + OrderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order" + ex.Message);
            }
        }

        private void ProcessOrderLine(int OrderID)
        {
            try
            {
                for (int i = 0; i < dgvSalesInvoice.Rows.Count; i++)
                {
                    //GET ITEM INFORMATION
                    int StockID = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[0].Value.ToString());
                    decimal price = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells[3].Value);
                    int quantity = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[5].Value);

                    decimal SubTotal = price * quantity;
                    int AfterSaleStock = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[4].Value) - quantity;

                    //insert in ORDERLINE TABLE
                    taOrderLine.InsertNewOrdelineItem(OrderID, StockID, quantity, SubTotal);
                    updateStock(StockID, AfterSaleStock);
                }

                MessageBox.Show("Orderline items added");
                MessageBox.Show("Stock Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order " + ex.Message);
            }
        }

        private void updateStock(int StockID, int AfterSaleStock)
        {
            try
            {
                taStock.UpdateStockAfterSale(AfterSaleStock, StockID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock" + ex.Message);
            }
        }

        /* private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             lblCustomerID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
         }

         private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             lblCustomerID.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
         }*/

        public void UpdateLabel(string name, string lastName, string ID)
        {
            lblCustomerName.Text = name;
            lblCustomerLN.Text = lastName;
            lblCustID.Text = ID;
        }

        private void dgvSalesInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSalesInvoice.Rows.Count > 0)
            {
                if (e.ColumnIndex == 7)
                {
                    dgvSalesInvoice.Rows.RemoveAt(e.RowIndex);
                    CalcTotal();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            taOrder.FillByOrderID(WstGrp11DataSet.Order, Convert.ToInt32(npSearchOrderID.Value));
        }

        private void dgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TaRefundInnerJoin.FillByOrderID(WstGrp11DataSet.RefundInnerJoin, Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value));
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TaRefundInnerJoin.FillByOrderID(WstGrp11DataSet.RefundInnerJoin, Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value));
        }

        private void btnRefundOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int OrderID = Convert.ToInt32(dgvOrder.CurrentRow.Cells[0].Value);
                taOrder.RefundFullOrder(OrderID);
                taOrderLine.RefundFullOrder(OrderID);

                WstGrp11DataSet.RefundInnerJoin.Clear();
                taOrder.Fill(WstGrp11DataSet.Order);

                MessageBox.Show("Order Number :" + OrderID.ToString() + " has been refunded");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRefundInnerJoin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRefundInnerJoin.Rows.Count > 0)
            {
                if (e.ColumnIndex == 6)
                {
                    int OrderID = Convert.ToInt32(dgvRefundInnerJoin.Rows[e.RowIndex].Cells[0].Value);
                    int StockID = Convert.ToInt32(dgvRefundInnerJoin.Rows[e.RowIndex].Cells[1].Value);

                    taOrderLine.RefundItem(OrderID, StockID);
                    TaRefundInnerJoin.FillByOrderID(WstGrp11DataSet.RefundInnerJoin, OrderID);

                    UpdateOrderTable(OrderID);
                    taOrder.Fill(WstGrp11DataSet.Order);
                }
            }
        }

        public void UpdateOrderTable(int OrderID)
        {
            decimal Total = 0;
            bool Refund = true;

            for (int i = 0; i < dgvRefundInnerJoin.Rows.Count; i++)
            {
                decimal Price = Convert.ToDecimal(dgvRefundInnerJoin.Rows[i].Cells[5].Value);

                //Totals value of items in orderline and checks if its a full refund
                if (Price != 0)
                {
                    Refund = false;
                }

                Total += Price;
            }

            string TransactionType = "Refund";
            if (!Refund)
            {
                TransactionType = "Partial Refund";
            }

            taOrder.RefundItem(TransactionType, Total, OrderID);
        }

        private void btnGoToCustomer_Click(object sender, EventArgs e)
        {

            var userForm = new frmUserManagement(navigate, this.userRole);
            
            navigate(userForm);
        }
    }
}
