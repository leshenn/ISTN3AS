namespace Istn3ASproject
{
    partial class frmPOS
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
            this.tcPOS = new System.Windows.Forms.TabControl();
            this.tbpSales = new System.Windows.Forms.TabPage();
            this.tbpRefund = new System.Windows.Forms.TabPage();
            this.tcPOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPOS
            // 
            this.tcPOS.Controls.Add(this.tbpSales);
            this.tcPOS.Controls.Add(this.tbpRefund);
            this.tcPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPOS.Location = new System.Drawing.Point(0, 0);
            this.tcPOS.Name = "tcPOS";
            this.tcPOS.SelectedIndex = 0;
            this.tcPOS.Size = new System.Drawing.Size(800, 450);
            this.tcPOS.TabIndex = 0;
            // 
            // tbpSales
            // 
            this.tbpSales.Location = new System.Drawing.Point(4, 25);
            this.tbpSales.Name = "tbpSales";
            this.tbpSales.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSales.Size = new System.Drawing.Size(792, 421);
            this.tbpSales.TabIndex = 0;
            this.tbpSales.Text = "Sales";
            this.tbpSales.UseVisualStyleBackColor = true;
            // 
            // tbpRefund
            // 
            this.tbpRefund.Location = new System.Drawing.Point(4, 25);
            this.tbpRefund.Name = "tbpRefund";
            this.tbpRefund.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRefund.Size = new System.Drawing.Size(792, 421);
            this.tbpRefund.TabIndex = 1;
            this.tbpRefund.Text = "Refund";
            this.tbpRefund.UseVisualStyleBackColor = true;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcPOS);
            this.Name = "frmPOS";
            this.Text = "POS";
            this.tcPOS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPOS;
        private System.Windows.Forms.TabPage tbpSales;
        private System.Windows.Forms.TabPage tbpRefund;
    }
}