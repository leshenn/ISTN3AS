namespace Istn3ASproject
{
    partial class frmUserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcUserManagement = new System.Windows.Forms.TabControl();
            this.tbpCustomers = new System.Windows.Forms.TabPage();
            this.tbpStaff = new System.Windows.Forms.TabPage();
            this.tbpSuppliers = new System.Windows.Forms.TabPage();
            this.tcUserManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUserManagement
            // 
            this.tcUserManagement.Controls.Add(this.tbpCustomers);
            this.tcUserManagement.Controls.Add(this.tbpStaff);
            this.tcUserManagement.Controls.Add(this.tbpSuppliers);
            this.tcUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUserManagement.Location = new System.Drawing.Point(0, 0);
            this.tcUserManagement.Name = "tcUserManagement";
            this.tcUserManagement.SelectedIndex = 0;
            this.tcUserManagement.Size = new System.Drawing.Size(800, 450);
            this.tcUserManagement.TabIndex = 0;
            // 
            // tbpCustomers
            // 
            this.tbpCustomers.Location = new System.Drawing.Point(4, 25);
            this.tbpCustomers.Name = "tbpCustomers";
            this.tbpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCustomers.Size = new System.Drawing.Size(792, 421);
            this.tbpCustomers.TabIndex = 0;
            this.tbpCustomers.Text = "Customers";
            this.tbpCustomers.UseVisualStyleBackColor = true;
            // 
            // tbpStaff
            // 
            this.tbpStaff.Location = new System.Drawing.Point(4, 25);
            this.tbpStaff.Name = "tbpStaff";
            this.tbpStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStaff.Size = new System.Drawing.Size(792, 421);
            this.tbpStaff.TabIndex = 1;
            this.tbpStaff.Text = "Staff";
            this.tbpStaff.UseVisualStyleBackColor = true;
            // 
            // tbpSuppliers
            // 
            this.tbpSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tbpSuppliers.Name = "tbpSuppliers";
            this.tbpSuppliers.Size = new System.Drawing.Size(792, 421);
            this.tbpSuppliers.TabIndex = 2;
            this.tbpSuppliers.Text = "Suppliers";
            this.tbpSuppliers.UseVisualStyleBackColor = true;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcUserManagement);
            this.Name = "frmUserManagement";
            this.Text = "User Management";
            this.tcUserManagement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUserManagement;
        private System.Windows.Forms.TabPage tbpCustomers;
        private System.Windows.Forms.TabPage tbpStaff;
        private System.Windows.Forms.TabPage tbpSuppliers;
    }
}