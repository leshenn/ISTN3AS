using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istn3ASproject
{
    public partial class frmStockManagement: Form
    {
        private int previousSupplierIndex = -1;
        private DataTable currentFilteredStock = null;

        public frmStockManagement()
        {
            InitializeComponent();
            cbSupplier.SelectedIndexChanged += cbSupplier_SelectedIndexChanged;

        }

        private void frmStockManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp11DataSet.SupplierLineOrder' table. You can move, or remove it, as needed.
            //this.supplierLineOrderTableAdapter.Fill(this.wstGrp11DataSet.SupplierLineOrder);

            // TODO: This line of code loads data into the 'wstGrp11DataSet.SupplierOrder' table. You can move, or remove it, as needed.
            this.supplierOrderTableAdapter.Fill(this.wstGrp11DataSet.SupplierOrder);
            
            // TODO: This line of code loads data into the 'wstGrp11DataSet.ItemsToAdd' table. You can move, or remove it, as needed.
            this.itemsToAddTableAdapter.Fill(this.wstGrp11DataSet.ItemsToAdd);
            
            //Clears item to add table
            wstGrp11DataSet.ItemsToAdd.Clear();
            
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.wstGrp11DataSet.Stock);

            //prevent showing all stock on load
            dgvSupplierStock.DataSource = null;

            //set the index of the combo box if the user does not want to change suppliers
            previousSupplierIndex = cbSupplier.SelectedIndex;

        }

        // This method adds items to the cart when the row header is clicked
        private void dgvSupplierStock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // If there’s no row selected in the grid, just exit this function and don’t continue
            if (dgvSupplierStock.CurrentRow == null) return;

            var stockID = dgvSupplierStock.CurrentRow.Cells[0].Value;  // assuming ID is column 0

            // Skip if StockID is null (if you click an empty row)
            if (stockID == null || stockID == DBNull.Value) return;

            // Try to find existing row with this StockID in ItemsToAdd
            DataRow existingRow = wstGrp11DataSet.ItemsToAdd.Rows.Cast<DataRow>().FirstOrDefault(r => r[0].Equals(stockID));

            // If the row exists
            if (existingRow != null)
            {
                // Increment quantity
                int currentQty = Convert.ToInt32(existingRow["Quantity"]);
                existingRow["Quantity"] = currentQty + 1;
            }
            // If the row doesnt exist
            else
            {
                // Add new row with quantity = 1
                DataRow dr = wstGrp11DataSet.ItemsToAdd.NewRow();

                // Find the smallest number, this ensure that you not trying to access a column that doesnt exist
                int count = Math.Min(dr.ItemArray.Length, dgvSupplierStock.CurrentRow.Cells.Count);

                // copies each cell’s value from the selected row in the DataGridView (dgvSupplierStock) into the corresponding column of the DataRow (dr).
                for (int i = 0; i < count; i++)
                {
                    dr[i] = dgvSupplierStock.CurrentRow.Cells[i].Value;
                }

                // Set quantity to 1
                dr["Quantity"] = 1;

                // adds the new row
                wstGrp11DataSet.ItemsToAdd.Rows.Add(dr);
            }

            // update the total
            tbTotal.Text = getTotal().ToString("C2");
        }

        // This method displays the stock items that were part of the order
        private void dgvOrderTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            // if no row is selected, then stop, this avoids errors
            if (dgvOrderTable.CurrentRow == null) return;

            // gets the orderID
            int orderID = Convert.ToInt32(dgvOrderTable.CurrentRow.Cells[0].Value);

            // loads the items for that specific orderID
            supplierLineOrderTableAdapter.FillByOrderID(wstGrp11DataSet.SupplierLineOrder, orderID);
            
        }


        // Filters the stock items base on the supplier selected in the combo box
        private DataTable GetFilteredStock(int selectedIndex)
        {   
            // this just associates the supplier with their related stockIDs
            var idPairs = new[]
            {
                new[] {1, 2},
                new[] {3, 4},
                new[] {5, 6},
                new[] {7, 8},
                new[] {9, 10}
            };

            // Filters the stock table
            var filtered = wstGrp11DataSet.Stock.Where(row => idPairs[selectedIndex].Contains(row.StockID));

            // If no stock items matched the filter, it returns an empty DataTable (but with the same columns as the original)
            if (!filtered.Any())
            {
                // Return empty table with correct schema
                return wstGrp11DataSet.Stock.Clone();
            }

            // otherwise it returns a new data table with the filtered rows
            return filtered.CopyToDataTable();
        }

        private bool isRevertingSelection = false;
        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If you're reverting the selection programmatically (isRevertingSelection == true) or no supplier is selected, do nothing.
            if (isRevertingSelection || cbSupplier.SelectedIndex == -1)
                return;

            // this just gets the new selected index
            int selectedIndex = cbSupplier.SelectedIndex;

            // If there are items in the cart
            if (dgvItems.RowCount > 1)
            {
                // Display the message to tell the user, switching between suppliers will disregard everything in the cart
                DialogResult result = MessageBox.Show(
                    "Changing supplier with items in your cart will reset the cart?",
                    "Confirmation", MessageBoxButtons.YesNoCancel);

                // if the user click yes
                if (result == DialogResult.Yes)
                {
                    wstGrp11DataSet.ItemsToAdd.Clear();                             // Empty the cart
                    currentFilteredStock = GetFilteredStock(selectedIndex);         // Load new suppliers stock
                    dgvSupplierStock.DataSource = currentFilteredStock;             // show it in the grid
                    previousSupplierIndex = selectedIndex;                          // Update the previous selection
                    tbTotal.Text = "0";                                             // Set the total to 0
                }
                // if the user clicks antything else
                else
                {
                    cbSupplier.SelectedIndexChanged -= cbSupplier_SelectedIndexChanged;     // temporarily disable the event
                    isRevertingSelection = true;
                    cbSupplier.SelectedIndex = previousSupplierIndex;                       // go back to the previous supplier
                    isRevertingSelection = false;
                    cbSupplier.SelectedIndexChanged += cbSupplier_SelectedIndexChanged;     // re enable the event
                }
            }
            // If there are no items in the cart then just update the stock grid to match the newly selected supplier
            else
            {
                currentFilteredStock = GetFilteredStock(selectedIndex);             // Load new suppliers stock
                dgvSupplierStock.DataSource = currentFilteredStock;                 // show it in the grid
                previousSupplierIndex = selectedIndex;                              // Update the previous selection
            }
        }

        private void tbItemSearch_TextChanged(object sender, EventArgs e)
        {
            // If currentFilteredStock(the current list of items from the supplier) is empty or null, it stops running
            if (currentFilteredStock == null) return;

            // Get the text typed by the user
            string filterText = tbItemSearch.Text;

            // Create a filtered view of the stock
            DataView dv = new DataView(currentFilteredStock);
            dv.RowFilter = "Name LIKE '" + filterText + "%'";

            // Update the data grid to show the filtered results
            dgvSupplierStock.DataSource = dv;
        }


        // This method calculates the total cost (or sum) of items in a data table called ItemsToAdd
        private double getTotal()
        {
            double sum = 0;

            // Goes through every row(item) in the dataset and adds the value to sum
            foreach (DataRow row in wstGrp11DataSet.ItemsToAdd.Rows)
            {   
                sum += (Convert.ToDouble(row["BuyingPrice"]) * (Convert.ToDouble(row["Quantity"])));
            }

            return sum;
        }


        // This method just clears the cart and sets the total to 0 when the clear button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTotal.Text = "0";
            wstGrp11DataSet.ItemsToAdd.Clear();
        }


        // This method runs when the Record button is clicked, and it saves an order to the database
        private void btnRecord_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            DialogResult result = MessageBox.Show(
                    "Do you want to record you order?",
                    "Confirmation", MessageBoxButtons.YesNoCancel);

            // if the user clicks yes
            if (result == DialogResult.Yes)
            {
                // Tries to convert the total amount text into a decimal number
                decimal total;
                if (!decimal.TryParse(tbTotal.Text, System.Globalization.NumberStyles.Currency, null, out total))
                {   
                    // if it fails then it shows an error
                    MessageBox.Show("Invalid total format.");
                    return;
                }

                int supplierID = Convert.ToInt32(cbSupplier.SelectedIndex + 1); // get the supplier id
                DateTime currentDate = DateTime.Now;                            // get the current date
                DateTime arrivalDate = DateTime.Now.Date.AddDays(10);           // set the arrival date to 10 days after an order has been made

                // Insert the new order into the SupplierOrder table
                supplierOrderTableAdapter.Insert(supplierID, total, "PENDING", "PAID", currentDate, arrivalDate);

                // Retrieve the last inserted order ID
                int newOrderID = (int)supplierOrderTableAdapter.GetLastOrderID();

                // Insert each item in the order to the SupplierLineOrder table
                foreach (DataRow item in wstGrp11DataSet.ItemsToAdd)
                {
                    int stockID = Convert.ToInt32(item["StockID"]);
                    int quantity = Convert.ToInt32(item["Quantity"]);
                    decimal unitPrice = Convert.ToDecimal(item["BuyingPrice"]);

                    supplierLineOrderTableAdapter.Insert(stockID, newOrderID, quantity, unitPrice);
                }

                // Reload the SupplierOrder data
                supplierOrderTableAdapter.Fill(wstGrp11DataSet.SupplierOrder);
            }      
        }
    }
}
