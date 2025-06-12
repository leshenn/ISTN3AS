namespace Istn3ASproject
{
    partial class MainMenu
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
            this.panHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnStockManagement = new System.Windows.Forms.Button();
            this.btnUserMangement = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.panMain = new System.Windows.Forms.Panel();
            this.panHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHead
            // 
            this.panHead.Controls.Add(this.label1);
            this.panHead.Controls.Add(this.btnReports);
            this.panHead.Controls.Add(this.btnStockManagement);
            this.panHead.Controls.Add(this.btnUserMangement);
            this.panHead.Controls.Add(this.btnPOS);
            this.panHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHead.Location = new System.Drawing.Point(0, 0);
            this.panHead.Name = "panHead";
            this.panHead.Size = new System.Drawing.Size(1457, 61);
            this.panHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIA\'S FISHERIES";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(904, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(118, 41);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnStockManagement
            // 
            this.btnStockManagement.Location = new System.Drawing.Point(1046, 12);
            this.btnStockManagement.Name = "btnStockManagement";
            this.btnStockManagement.Size = new System.Drawing.Size(118, 41);
            this.btnStockManagement.TabIndex = 3;
            this.btnStockManagement.Text = "Stock Management";
            this.btnStockManagement.UseVisualStyleBackColor = true;
            this.btnStockManagement.Click += new System.EventHandler(this.btnStockManagement_Click);
            // 
            // btnUserMangement
            // 
            this.btnUserMangement.Location = new System.Drawing.Point(1188, 12);
            this.btnUserMangement.Name = "btnUserMangement";
            this.btnUserMangement.Size = new System.Drawing.Size(118, 41);
            this.btnUserMangement.TabIndex = 2;
            this.btnUserMangement.Text = "User Management";
            this.btnUserMangement.UseVisualStyleBackColor = true;
            this.btnUserMangement.Click += new System.EventHandler(this.btnUserMangement_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(1327, 12);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(118, 41);
            this.btnPOS.TabIndex = 1;
            this.btnPOS.Text = "Point of sales";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // panMain
            // 
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 61);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1457, 758);
            this.panMain.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 819);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.panHead);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.panHead.ResumeLayout(false);
            this.panHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHead;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnUserMangement;
        private System.Windows.Forms.Button btnStockManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panMain;
    }
}