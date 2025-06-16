namespace Istn3ASproject
{
    partial class CardPortal
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
            this.grpbxCardPortal = new System.Windows.Forms.GroupBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.lblCardCVV = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConfirmBankCard = new System.Windows.Forms.Button();
            this.picBankLogo = new System.Windows.Forms.PictureBox();
            this.picCardType = new System.Windows.Forms.PictureBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.grpbxCardPortal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBankLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardType)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxCardPortal
            // 
            this.grpbxCardPortal.Controls.Add(this.txtCVV);
            this.grpbxCardPortal.Controls.Add(this.txtCardNumber);
            this.grpbxCardPortal.Controls.Add(this.btnConfirmBankCard);
            this.grpbxCardPortal.Controls.Add(this.picBankLogo);
            this.grpbxCardPortal.Controls.Add(this.picCardType);
            this.grpbxCardPortal.Controls.Add(this.comboBox1);
            this.grpbxCardPortal.Controls.Add(this.lblCardCVV);
            this.grpbxCardPortal.Controls.Add(this.txtCardHolderName);
            this.grpbxCardPortal.Controls.Add(this.lblCardHolder);
            this.grpbxCardPortal.Controls.Add(this.lblCardNum);
            this.grpbxCardPortal.Location = new System.Drawing.Point(12, 12);
            this.grpbxCardPortal.Name = "grpbxCardPortal";
            this.grpbxCardPortal.Size = new System.Drawing.Size(618, 354);
            this.grpbxCardPortal.TabIndex = 0;
            this.grpbxCardPortal.TabStop = false;
            this.grpbxCardPortal.Text = "Enter Card Details";
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Location = new System.Drawing.Point(18, 31);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(72, 13);
            this.lblCardNum.TabIndex = 0;
            this.lblCardNum.Text = "Card Number:";
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(18, 93);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(97, 13);
            this.lblCardHolder.TabIndex = 2;
            this.lblCardHolder.Text = "Card Holder Name:";
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Location = new System.Drawing.Point(18, 121);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(199, 20);
            this.txtCardHolderName.TabIndex = 4;
            // 
            // lblCardCVV
            // 
            this.lblCardCVV.AutoSize = true;
            this.lblCardCVV.Location = new System.Drawing.Point(23, 168);
            this.lblCardCVV.Name = "lblCardCVV";
            this.lblCardCVV.Size = new System.Drawing.Size(59, 13);
            this.lblCardCVV.TabIndex = 5;
            this.lblCardCVV.Text = "Card CVV: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ABSA",
            "Capitec",
            "FNB",
            "Nedbank",
            "Standard Bank"});
            this.comboBox1.Location = new System.Drawing.Point(21, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select a Bank -->";
            // 
            // btnConfirmBankCard
            // 
            this.btnConfirmBankCard.Location = new System.Drawing.Point(60, 293);
            this.btnConfirmBankCard.Name = "btnConfirmBankCard";
            this.btnConfirmBankCard.Size = new System.Drawing.Size(124, 23);
            this.btnConfirmBankCard.TabIndex = 9;
            this.btnConfirmBankCard.Text = "Confirm Details";
            this.btnConfirmBankCard.UseVisualStyleBackColor = true;
            // 
            // picBankLogo
            // 
            this.picBankLogo.Location = new System.Drawing.Point(223, 232);
            this.picBankLogo.Name = "picBankLogo";
            this.picBankLogo.Size = new System.Drawing.Size(72, 24);
            this.picBankLogo.TabIndex = 8;
            this.picBankLogo.TabStop = false;
            // 
            // picCardType
            // 
            this.picCardType.Location = new System.Drawing.Point(223, 50);
            this.picCardType.Name = "picCardType";
            this.picCardType.Size = new System.Drawing.Size(72, 24);
            this.picCardType.TabIndex = 7;
            this.picCardType.TabStop = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(18, 54);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(199, 20);
            this.txtCardNumber.TabIndex = 10;
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(24, 191);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(196, 20);
            this.txtCVV.TabIndex = 11;
            // 
            // CardPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxCardPortal);
            this.Name = "CardPortal";
            this.Text = "CardPortal";
            this.grpbxCardPortal.ResumeLayout(false);
            this.grpbxCardPortal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBankLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxCardPortal;
        private System.Windows.Forms.PictureBox picBankLogo;
        private System.Windows.Forms.PictureBox picCardType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCardCVV;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.Button btnConfirmBankCard;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCVV;
    }
}