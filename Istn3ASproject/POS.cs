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

namespace Istn3ASproject
{
    public partial class frmPOS: Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp11DS.Order' table. You can move, or remove it, as needed.
            this.taOrder.Fill(this.wstGrp11DS.Order);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Order' table. You can move, or remove it, as needed.
            this.taOrder.Fill(this.wstGrp11DS.Order);
            // TODO: This line of code loads data into the 'wstGrp11DS.Customer' table. You can move, or remove it, as needed.
            //this.taCustomer.Fill(this.wstGrp11DS.Customer);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Stock' table. You can move, or remove it, as needed.
            this.taStock.Fill(this.wstGrp11DS.Stock);

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            taStock.FillByName(wstGrp11DS.Stock, txtSearchProduct.Text);
        }

        private void dgvStock_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataRow dr;
                dr = wstGrp11DS.SalesInvoice.NewRow();

                for (int i =0; i < 5; i++)
                {
                    dr[i] = dgvStock.CurrentRow.Cells[i].Value;
                }

                wstGrp11DS.SalesInvoice.Rows.Add(dr);
                dgvSalesInvoice.Rows[dgvSalesInvoice.Rows.Count - 2].Cells[5].Value = 0;
            }catch (Exception ec)
            {
                MessageBox.Show("Error" + ec.Message);       
            }
            

        }

        private void dgvSalesInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal Total= 0;
            int quantity = 0;
            decimal price = 0;

            //loops through table to calculate total
            for (int i = 0; i < dgvSalesInvoice.Rows.Count - 1; i++)
            {
                price = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells[3].Value);                         
                quantity = HandleQuantityInput(dgvSalesInvoice.Rows[i].Cells[5].Value.ToString(),i);

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
                MessageBox.Show("Quantity cannot be letters or symbols","Invalid character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvSalesInvoice.Rows[i].Cells[5].Value = 0;
                return 0;
            }

            // checks is quantiy is in a valid range
            if (quantity<0 || quantity > Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[4].Value)) 
            {
                MessageBox.Show("Quantity amount has to be greater than 0 and at most equal to stock on hand", "Invalid quantity range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvSalesInvoice.Rows[i].Cells[5].Value = 0;
                return 0;
            }

            return quantity;
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            int CustomerID = 1;
            int StaffID = 1;
            string TransactionType = "sale";
            string Today = DateTime.Today.ToString("yyyy-MM-dd");
            string CurrentTime = DateTime.Now.ToString("HH:mm:ss");
            Decimal Total = Convert.ToDecimal(lblTotal.Text);
            string PaymentMethod = cmbPaymentMethod.Text;

            if (ReadyToProcess())
            {
                //LETS USER CONFIRM IF ORDER IS CORRECT
               DialogResult result= MessageBox.Show("CustomerID :" + CustomerID.ToString() +"\n"+
                                "StaffID :" + StaffID.ToString() + "\n" +
                                "Method of Payment :" + PaymentMethod + "\n" +
                                "Transaction Type :" + TransactionType + "\n" +
                                "Date :" + Today + "\n" +
                                "Time :" + CurrentTime + "\n" +
                                "Total :" + Total.ToString() + "\n" +listItems() ,
                                "OrderDetails",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    ProcessOrder(CustomerID,StaffID,PaymentMethod,TransactionType,Today,CurrentTime,Total);
                    wstGrp11DS.SalesInvoice.Clear();
                    txtSearchProduct.Clear();
                    cmbPaymentMethod.Text = "";
                }
                else
                {
                    MessageBox.Show("Order has been cancelled");
                    wstGrp11DS.SalesInvoice.Clear();
                    txtSearchProduct.Clear();
                    cmbPaymentMethod.Text = "";

                }
            }

        }

        //ERROR CHECKS ALL FIELDS OF INFORMATION
        private bool ReadyToProcess()
        {
            bool ReadyToProcess = true;
            if (lblTotal.Text == "0")
            {
                ReadyToProcess = false;
                MessageBox.Show("Please select items for the order", "No items selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbPaymentMethod.Text != "Cash" && cmbPaymentMethod.Text != "Card")
            {
                ReadyToProcess = false;
                MessageBox.Show("Please choose a payment method", "Missing payment method", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
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
            string listOfItems ="";

            for (int i = 0; i < dgvSalesInvoice.Rows.Count - 1; i++)
            {
                //GET ITEM INFORMATION
                string StockID = dgvSalesInvoice.Rows[i].Cells[0].Value.ToString();
                string name = dgvSalesInvoice.Rows[i].Cells[1].Value.ToString();
                decimal price = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells[3].Value);
                int quantity = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[5].Value.ToString());
                decimal SubTotal = price * quantity;

                //ADD TO STRING OF ITEMS
                listOfItems += StockID+" "+name + "\t" + SubTotal.ToString("C2") + "\n";
            }
            return listOfItems;
        }

        private void ProcessOrder(int CustomerID, int StaffID, string MethodOfPayment, string TransactionType,string Today, string CurrentTime, Decimal Total)
        {
            try
            {
                int OrderID = taOrder.InsertNewSalesOrder(CustomerID, StaffID, MethodOfPayment, TransactionType, Today, CurrentTime, Total);
                ProcessOrderLine(OrderID);
                MessageBox.Show("Order has been processed");
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
                for (int i = 0; i < dgvSalesInvoice.Rows.Count - 1; i++)
                {
                    //GET ITEM INFORMATION
                    int StockID = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[0].Value.ToString());
                    decimal price = Convert.ToDecimal(dgvSalesInvoice.Rows[i].Cells[3].Value);
                    int quantity = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[5].Value);

                    decimal SubTotal = price * quantity;
                    int AfterSaleStock = Convert.ToInt32(dgvSalesInvoice.Rows[i].Cells[4].Value) - quantity;

                    //insert in ORDERLINE TABLE
                    taOrderLine.InsertNewOrdelineItem(OrderID, StockID, quantity, SubTotal);
                    updateStock(StockID,AfterSaleStock);
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
            }catch (Exception ex)
            {
                MessageBox.Show("Error updating stock" + ex.Message);
            }
        }
    }
}
