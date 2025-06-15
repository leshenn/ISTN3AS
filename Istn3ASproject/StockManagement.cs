using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istn3ASproject
{
    public partial class frmStockManagement : Form
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
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
            // TODO: This line of code loads data into the 'wstGrp11DataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.wstGrp11DataSet.Supplier);
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
            //dgvSupplierStock.DataSource = null;

            //set the index of the combo box if the user does not want to change suppliers
            previousSupplierIndex = cbSupplier.SelectedIndex;

            this.dgvOrderTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderTable_CellValueChanged);

            // This hides the empty "new row"
            dgvItems.AllowUserToAddRows = false; 
            dgvOrderLines.AllowUserToAddRows = false;
            dgvOrderTable.AllowUserToAddRows = false;
            dgvSupplierStock.AllowUserToAddRows = false;


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


        /*
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
        */


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
                    //currentFilteredStock = GetFilteredStock(selectedIndex);         // Load new suppliers stock
                    //dgvSupplierStock.DataSource = currentFilteredStock;             // show it in the grid
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
                //currentFilteredStock = GetFilteredStock(selectedIndex);             // Load new suppliers stock
                //dgvSupplierStock.DataSource = currentFilteredStock;                 // show it in the grid
                previousSupplierIndex = selectedIndex;                              // Update the previous selection
            }
        }

        private void tbItemSearch_TextChanged(object sender, EventArgs e)
        {
            // If currentFilteredStock(the current list of items from the supplier) is empty or null, it stops running
            //if (currentFilteredStock == null) return;

            // Get the text typed by the user
            string filterText = tbItemSearch.Text;

            stockTableAdapter.FillByName(wstGrp11DataSet.Stock, filterText);

            // Create a filtered view of the stock
            //DataView dv = new DataView(currentFilteredStock);
            //dv.RowFilter = "Name LIKE '" + filterText + "%'";

            // Update the data grid to show the filtered results
            //dgvSupplierStock.DataSource = dv;
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
            if(dgvItems.Rows.Count == 0) 
            {
                MessageBox.Show("Please add items to the cart before recording the order");
                return; 
            }
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

                // Clear the total and also the tablw
                tbTotal.Text = "0";
                wstGrp11DataSet.ItemsToAdd.Clear();
            }
        }


        private bool isUpdatingStock = false;
        private DateTime lastUpdateTime = DateTime.MinValue;
        private void dgvOrderTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Skip if we're already processing or if it's an invalid cell
            if (isUpdatingStock || e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Only process OrderStatus column
            if (dgvOrderTable.Columns[e.ColumnIndex].Name == "OrderStatus")
            {
                var cell = dgvOrderTable.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Get the test in the OrderStatus Cell
                string newStatus = cell.Value.ToString().Trim().ToUpper();

                // If the text is ARRIVED
                if (newStatus == "ARRIVED")
                {
                    // Show a message to show that the stock has been updated
                    MessageBox.Show("The stock on hand has been updated");

                    // Prevent duplicate updates within 2 seconds
                    if ((DateTime.Now - lastUpdateTime).TotalSeconds < 2)
                    {
                        return;
                    }

                    // Sets a flag to show that the stock is being updated
                    isUpdatingStock = true;
                    try
                    {
                        // Gets the supplier id from the selected row
                        int orderID = Convert.ToInt32(dgvOrderTable.Rows[e.RowIndex].Cells["SupplierOrderID"].Value);
                        UpdateStockOnHand(orderID);

                        // This is where the time of the update is recorded to prevent duplicate updates
                        lastUpdateTime = DateTime.Now;
                    }

                    // If a supplier order id is missing
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating stock: " + ex.Message);
                    }

                    // resets the flag regardless of what happen previously
                    finally
                    {
                        isUpdatingStock = false;
                    }
                }
                else if (newStatus == "PENDING") 
                {
                    // Show a message to show that the stock has been updated
                    MessageBox.Show("The stock on hand has been updated");

                    // Prevent duplicate updates within 2 seconds
                    if ((DateTime.Now - lastUpdateTime).TotalSeconds < 2)
                    {
                        return;
                    }

                    // Sets a flag to show that the stock is being updated
                    isUpdatingStock = true;
                    try
                    {
                        // Gets the supplier id from the selected row
                        int orderID = Convert.ToInt32(dgvOrderTable.Rows[e.RowIndex].Cells["SupplierOrderID"].Value);
                        RevertStockOnHand(orderID);

                        // This is where the time of the update is recorded to prevent duplicate updates
                        lastUpdateTime = DateTime.Now;
                    }

                    // If a supplier order id is missing
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating stock: " + ex.Message);
                    }

                    // resets the flag regardless of what happen previously
                    finally
                    {
                        isUpdatingStock = false;
                    }
                }
            }
        }


        private void UpdateStockOnHand(int orderID)
        {
            try
            {
                // Get all the items first
                var orderLines = supplierLineOrderTableAdapter.GetDataByOrderID(orderID);

                // For each item in the table
                foreach (DataRow row in orderLines.Rows)
                {
                    int stockID = Convert.ToInt32(row["StockID"]);                                  // get the stock id
                    int quantityOrdered = Convert.ToInt32(row["Quantity"]);                         // Get the quantity orders
                    int currentStock = Convert.ToInt32(stockTableAdapter.GetStockOnHand(stockID));  // Get the current stock ordered
                    stockTableAdapter.UpdateStockOnHand(currentStock + quantityOrdered, stockID);   // Update the stock
                }

                // Update the order status in the database
                supplierOrderTableAdapter.UpdateOrderStatus("ARRIVED", orderID);

                // Refresh the data
                supplierOrderTableAdapter.Fill(wstGrp11DataSet.SupplierOrder);
                stockTableAdapter.Fill(wstGrp11DataSet.Stock);
            }

            // Error handling
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order status: " + ex.Message);
            }
        }

        // If the status is accidentally set to arrive, this method takes care of reverting it back to its original value
        private void RevertStockOnHand(int orderID)
        {
            try
            {
                var orderLines = supplierLineOrderTableAdapter.GetDataByOrderID(orderID);

                foreach (DataRow row in orderLines.Rows)
                {
                    int stockID = Convert.ToInt32(row["StockID"]);
                    int quantityOrdered = Convert.ToInt32(row["Quantity"]);
                    int currentStock = Convert.ToInt32(stockTableAdapter.GetStockOnHand(stockID));

                    int newStock = currentStock - quantityOrdered;
                    if (newStock < 0) newStock = 0; // prevent negative stock

                    stockTableAdapter.UpdateStockOnHand(newStock, stockID);
                }

                // Update order status
                supplierOrderTableAdapter.UpdateOrderStatus("PENDING", orderID);

                // Refresh views
                supplierOrderTableAdapter.Fill(wstGrp11DataSet.SupplierOrder);
                stockTableAdapter.Fill(wstGrp11DataSet.Stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reverting order status: " + ex.Message);
            }
        }


        private void dgvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Skip if not Quantity column or if we're already cancelling
            if (dgvItems.Columns[e.ColumnIndex].Name != "Quantity" ||
                dgvItems.Rows[e.RowIndex].IsNewRow ||
                isCancellingEdit)
            {
                return;
            }

            if (!int.TryParse(e.FormattedValue.ToString(), out int qty) || qty < 1)
            {
                // Set flag to indicate we're cancelling
                isCancellingEdit = true;

                // Cancel the edit
                e.Cancel = true;

                // Show message
                MessageBox.Show("Quantity must be a positive whole number");

                // Reset the value
                dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = originalQuantityValue;

                // Refresh the total
                tbTotal.Text = getTotal().ToString("C2");
            }
        }



        private object originalQuantityValue;
        private bool isCancellingEdit = false;
        private void dgvItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvItems.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Store original value
                originalQuantityValue = dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                isCancellingEdit = false;
            }
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // If we're not cancelling, update the total
                if (!isCancellingEdit)
                {
                    tbTotal.Text = getTotal().ToString("C2");
                }
                isCancellingEdit = false;
            }
        }

        private void dgvItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            if (dgvItems.Columns[e.ColumnIndex].Name == "Quantity")
            {
                dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = originalQuantityValue;
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            String orderStatus = dgvOrderTable.CurrentRow.Cells["OrderStatus"].Value.ToString();

            if (orderStatus == "PENDING")
            {
                dgvOrderTable.CurrentRow.Cells["OrderStatus"].Value = "ARRIVED";
            }
            else
            {
                dgvOrderTable.CurrentRow.Cells["OrderStatus"].Value = "PENDING";
            }
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItems.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dgvItems.Rows.RemoveAt(e.RowIndex);
                    tbTotal.Text = getTotal().ToString("C2");
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = @"🛠 HELP GUIDE – STOCK & CART MANAGEMENT
=======================================

1. SEARCH FOR STOCK ITEMS
    - Supplier Dropdown: Select a supplier from the dropdown list.
    - Search Item:
        • Enter the name of the item in the Search Item textbox.
        • The system will filter and display matching stock items in the Stock table.

2. STOCK TABLE
    - This table displays all available stock items with the following details:
        • StockID – Unique identifier for each item
        • Name – Item name
        • Description – Brief description of the item
        • Selling Price – Price at which the item is sold
        • Buying Price – Purchase price of the item
        • StockOnHand – Current quantity available
        • ReorderLevel – Quantity threshold for restocking
        • ExpirationTime – Expiry date of perishable items

    📌 Tip: Click from this table to add it to the Cart.

3. CART TABLE
    - Displays items selected for purchase with the following columns:
        • StockID, Name, Description, Buying Price
        • Quantity – Editable field to specify how many units to add
        • Delete – Click the Delete button in this column to remove the row from the cart

4. TOTAL AMOUNT
    - Displays the calculated total cost of all items in the cart (based on buying price × quantity).
    - Automatically updates as items are added or removed.

5. BUTTONS
    - Help: Opens this help guide.
    - Clear Cart: Empties all items from the cart. A confirmation may be required.
    - Record: Finalizes the transaction (e.g., saves the cart, updates the database, etc.).

    ⚠️ Warning: Ensure the cart is reviewed before clicking ""Record"" as this may commit the order permanently.

📝 DATA VALIDATION NOTES
    - Cart Quantity should be a positive number.
    - If a stock item is out of stock or below reorder level, the system may restrict adding it to the cart.
    - Only items listed in the Stock Table can be added to the Cart.";

            MessageBox.Show(helpMessage, "Supplier Order Tab Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnHelpOrderDetails_Click(object sender, EventArgs e)
        {
            string helpMessage = @"🛠 HELP GUIDE – SUPPLIER ORDERS DETAILS
====================================

1. SUPPLIER ORDER TABLE
    - Displays existing supplier orders with the following details:
        • OrderID – Unique ID for each order
        • SupplierID – ID of the supplier linked to the order
        • TotalCost – Total value of the order
        • OrderStatus – Current status (e.g., Pending, Arrived)
        • PaymentStatus – Payment progress (e.g., Paid, Unpaid)
        • OrderDate – Date the order was placed
        • ArrivalDate – Expected or actual delivery date

    📌 Tip: Click a row to view its details in the Supplier Order Line section.

2. SUPPLIER ORDER LINE TABLE
    - Shows detailed line items (products) associated with the selected order:
        • StockID – ID of the stock item ordered
        • OrderID – Related order ID
        • Quantity – Number of units ordered
        • Price – Cost per unit or line total

3. UPDATE ORDER STATUS
    - Use the 'Update Order Status' button to modify the status of a selected order.
    - Typical transitions: 
        • 'Pending' → 'Arrived'
        • PaymentStatus may also update depending on the workflow.

    ✅ How to Update:
        • Select a row in the Supplier Order table.
        • Click 'Update Order Status'.
        • The system may prompt for confirmation or additional input.
        • On successful update, the table refreshes and stock quantities may be adjusted.

4. HELP BUTTON
    - Click this button to view instructions for using this tab.
    - Useful for understanding how orders and items are displayed and updated.

📝 VALIDATION & BUSINESS RULES
    - Only one order should be selected when updating status.
    - Cannot update orders that are already marked as 'Arrived'.
    - ArrivalDate may be set automatically upon arrival.
    - Ensure data is saved before closing the application.

📌 TIP: Always confirm you're updating the correct order to avoid accidental stock changes.";

            MessageBox.Show(helpMessage, "Supplier Order Tab Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //THIS IS TO ADD A NEW ITEM TO THE STOCK TABLE
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool bname = true, bdesc = true, bsell = true, bbuy = true; //for manditory values
                if (txtBuy.Text == "")
                {
                    //set label to red to show maditory value
                    lblBuy.Text = "*Buying price:";
                    lblBuy.ForeColor = Color.Red;
                    bbuy = false;
                } 

                if (txtSell.Text == "")
                {
                    //set label to red to show maditory value
                    lblSell.Text = "*Selling price:";
                    lblSell.ForeColor = Color.Red;
                    bsell = false;
                }

                if (txtName.Text == "")
                {
                    //set label to red to show maditory value
                    lblProductName.Text = "*Product Name:";
                    lblProductName.ForeColor = Color.Red;
                    bname = false;
                }

                if (txtDesc.Text == "")
                {
                    //set label to red to show maditory value
                    lblProductDesc.Text = "*Product Description:";
                    lblProductDesc.ForeColor = Color.Red;
                    bdesc = false;
                }
                
                if (bname && bdesc && bbuy && bsell) //if all manditory values are entered
                {
                    DialogResult result = MessageBox.Show("Do you want to add this item to inventory?", "Confirmation", MessageBoxButtons.YesNoCancel); //confirmation message

                    if (result == DialogResult.Cancel)
                    {
                        MessageBox.Show("Cancelled");
                    }
                    else if ((result == DialogResult.No))
                    {
                        MessageBox.Show("Item not added");
                    }
                    else //clicked Yes
                    {
                        //retrieve values
                        string name = txtName.Text;
                        string desc = txtDesc.Text;
                        Decimal sell = Convert.ToDecimal(txtSell.Text);
                        Decimal buy = Convert.ToDecimal(txtBuy.Text);
                        int? reorder, expiration; //set to nullable int's

                        if (txtReorder.Text == "") //because cant convert null to int
                        {
                            reorder = null;
                        }
                        else
                        {
                            reorder = Convert.ToInt32(txtReorder.Text);
                        }

                        if (txtExpiration.Text == "") //because cant convert null to int
                        {
                            expiration = null;
                        }
                        else
                        {
                            expiration = Convert.ToInt32(txtExpiration.Text);
                        }

                        stockTableAdapter.InsertStockItem(name, desc, sell, buy, 0, reorder, expiration); //insert query
                        MessageBox.Show("Item added to inventory", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information); //notify added item

                        //clear all textboxes
                        txtName.Clear();
                        txtDesc.Clear();
                        txtSell.Clear();
                        txtBuy.Clear();
                        txtReorder.Clear();
                        txtExpiration.Clear();

                    }
                } 
                else
                {
                    MessageBox.Show("Please enter all manditory values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //warns to enter all manditory values
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't add item to inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //error if value cant be added
            }
        }

        private void txtSell_TextChanged(object sender, EventArgs e)
        {
            //remove red warning text
            if (txtSell.Text!="")
            {
                lblSell.Text = "Selling price:";
                lblSell.ForeColor = Color.Black;
            }

            if (txtSell.Text == "")
            {
                //to avoid warning message if text removed
            } 
            else if (!Decimal.TryParse(txtSell.Text, out _)) //validate type decimal
            {
                MessageBox.Show("Enter a monetary value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int len = txtSell.Text.Length;
                txtSell.Text = txtSell.Text.Substring(0, len - 1); //remove last character typed
                txtSell.SelectionStart = txtSell.Text.Length; //set focus to end of text typed
            }
        }

        private void txtBuy_TextChanged(object sender, EventArgs e)
        {
            //remove red warning text
            if (txtBuy.Text!="")
            {
                lblBuy.Text = "Buying price:";
                lblBuy.ForeColor = Color.Black;
            }

            if (txtBuy.Text == "")
            {
                //to avoid warning message if text removed
            }
            else if (!Decimal.TryParse(txtBuy.Text, out _)) //validate type decimal
            {
                MessageBox.Show("Enter a monetary value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int len = txtBuy.Text.Length;
                txtBuy.Text = txtBuy.Text.Substring(0, len - 1); //remove last character typed
                txtBuy.SelectionStart = txtBuy.Text.Length; //set focus to end of text typed
            }
        }

        private void txtReorder_TextChanged(object sender, EventArgs e)
        {
            if (txtReorder.Text == "")
            {
                //to avoid warning message if text removed
            }
            else if (!Int32.TryParse(txtReorder.Text, out _))
            {
                MessageBox.Show("Enter an integer value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int len = txtReorder.Text.Length;
                txtReorder.Text = txtReorder.Text.Substring(0, len - 1); //remove last character typed
                txtReorder.SelectionStart = txtReorder.Text.Length; //set focus to end of text typed
            }
        }

        private void txtExpiration_TextChanged(object sender, EventArgs e)
        {
            if (txtExpiration.Text == "")
            {
                //to avoid warning message if text removed
            }
            else if (!Int32.TryParse(txtExpiration.Text, out _))
            {
                MessageBox.Show("Enter an integer value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int len = txtExpiration.Text.Length;
                txtExpiration.Text = txtExpiration.Text.Substring(0, len - 1); //remove last character typed
                txtExpiration.SelectionStart = txtExpiration.Text.Length; //set focus to end of lext typed
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //remove red warning text
            if (txtName.Text!=null)
            {
                lblProductName.Text = "Product Name:";
                lblProductName.ForeColor = Color.Black;
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            //remove red warning text
            if (txtDesc.Text != null)
            {
                lblProductDesc.Text = "Product Description:";
                lblProductDesc.ForeColor = Color.Black;
            }
        }

        private void dgvUpdateStock_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtProdNameUpdate.Text = dgvUpdateStock.CurrentRow.Cells[1].Value.ToString();
            txtProdDescUpdate.Text = dgvUpdateStock.CurrentRow.Cells[2].Value.ToString();
            txtProdSPriceUpdate.Text = dgvUpdateStock.CurrentRow.Cells[3].Value.ToString();
            txtProdBPriceUpdate.Text = dgvUpdateStock.CurrentRow.Cells[4].Value.ToString();
            txtProdReorderUpdate.Text = dgvUpdateStock.CurrentRow.Cells[6].Value.ToString();
            txtProdExpirUpdate.Text = dgvUpdateStock.CurrentRow.Cells[7].Value.ToString(); ;
        }

        private bool validateUpdateValues(string name, string desc, string sprice, string bprice, string reorder, string expir)
        {
            bool isLettersName = false;
            bool isLettersDesc = false;
            bool isFloatS = false;
            bool isFloatB = false;
            bool isIntReorder = false;
            bool isIntExpir = false;

            if (name is string)
            {
                isLettersName = true;
            }
            if (desc is string)
            {
                isLettersDesc = true;
            }
            if (sprice is float)
            {
                isFloatS = true;
            }
            if (bprice is float)
            {
                isFloatB = true;
            }
            if (reorder is int)
            {
                isIntReorder = true;
            }
            if (expir is int)
            {
                isIntExpir = true;
            }

            return isLettersName && isLettersDesc && isFloatS && isFloatB && isIntReorder && isIntExpir;
        }

        private void btnUpdateItemDetails_Click(object sender, EventArgs e)
        {
            try
            {
                bool selected = true;
                if (txtProdNameUpdate.Text=="" ||
                    txtProdDescUpdate.Text=="" ||
                    txtProdSPriceUpdate.Text=="" ||
                    txtProdBPriceUpdate.Text=="" ||
                    txtProdReorderUpdate.Text=="" ||
                    txtProdExpirUpdate.Text=="")
                {
                    selected = false;
                    MessageBox.Show("Please select a record before updating", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (selected)
                {
                    DialogResult result = MessageBox.Show("Do you want to update item: " + txtProdNameUpdate.Text + ", " + txtProdDescUpdate.Text, "Confirmation", MessageBoxButtons.YesNoCancel);

                    if (result==DialogResult.Yes)
                    {
                        string name = txtProdNameUpdate.Text;
                        string desc = txtProdDescUpdate.Text;
                        string sprice = txtProdSPriceUpdate.Text;
                        string bprice = txtProdBPriceUpdate.Text;
                        string reorder = txtProdReorderUpdate.Text;
                        string expir = txtProdExpirUpdate.Text;
                        decimal sPrice, bPrice;
                        int Reorder, Expir;
                        bool bsprice = false, bbprice = false, breorder = false, bexpir = false;
                        string warning = "Please enter a:\n";

                        if (!decimal.TryParse(sprice, out sPrice))
                        {
                            //MessageBox.Show("Enter a monetary value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtProdSPriceUpdate.Text = dgvUpdateStock.CurrentRow.Cells[3].Value.ToString();
                        }
                        else
                        {
                            bsprice = true;
                        }

                        if (!decimal.TryParse(bprice, out bPrice))
                        {
                            //MessageBox.Show("Enter a monetary value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtProdBPriceUpdate.Text = dgvUpdateStock.CurrentRow.Cells[4].Value.ToString();
                        }
                        else
                        {
                            bbprice = true;
                        }

                        if (!int.TryParse(reorder, out Reorder))
                        {
                            //MessageBox.Show("Enter an integer value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtProdReorderUpdate.Text = dgvUpdateStock.CurrentRow.Cells[6].Value.ToString();
                        }
                        else
                        {
                            breorder = true;
                        }

                        if (!int.TryParse(expir, out Expir))
                        {
                            //MessageBox.Show("Enter an integer value", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtProdExpirUpdate.Text = dgvUpdateStock.CurrentRow.Cells[7].Value.ToString();
                        }
                        else
                        {
                            bexpir = true;
                        }

                        if (!bsprice)
                        {
                            warning += "Monetary value for Selling price\n";
                        }
                        if (!bbprice)
                        {
                            warning += "Monetary value for Buying price\n";
                        }
                        if (!breorder)
                        {
                            warning += "Integer value for Reorder level\n";
                        }
                        if (!bexpir)
                        {
                            warning += "Integer value for Expiration time\n";
                        }

                        if (!bsprice || !bbprice || !breorder || !bexpir)
                        {
                            MessageBox.Show(warning, "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } 
                        else
                        {
                            stockTableAdapter.UpdateStockDetails(name, desc, sPrice, bPrice, Reorder, Expir, 
                                Convert.ToInt32(dgvUpdateStock.CurrentRow.Cells[0].Value.ToString()), 
                                Convert.ToInt32(dgvUpdateStock.CurrentRow.Cells[0].Value.ToString()));
                            stockTableAdapter.Fill(wstGrp11DataSet.Stock);
                            MessageBox.Show("Item details udpated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if (result==DialogResult.No)
                    {
                        MessageBox.Show("Item details not updated", "Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Updated cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    
                } //selected

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update stock item details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

    }
}
