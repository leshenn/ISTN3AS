namespace Istn3ASproject
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbVisiblity = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new Istn3ASproject.LoginDataSet();
            this.staffTableAdapter = new Istn3ASproject.LoginDataSetTableAdapters.StaffTableAdapter();
            this.checkLoginToolStrip = new System.Windows.Forms.ToolStrip();
            this.userToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.passwordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passwordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.checkLoginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisiblity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            this.checkLoginToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pbVisiblity);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(206, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 225);
            this.panel1.TabIndex = 1;
            // 
            // pbVisiblity
            // 
            this.pbVisiblity.Image = global::Istn3ASproject.Properties.Resources.eye;
            this.pbVisiblity.Location = new System.Drawing.Point(346, 131);
            this.pbVisiblity.Margin = new System.Windows.Forms.Padding(2);
            this.pbVisiblity.Name = "pbVisiblity";
            this.pbVisiblity.Size = new System.Drawing.Size(20, 20);
            this.pbVisiblity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVisiblity.TabIndex = 6;
            this.pbVisiblity.TabStop = false;
            this.pbVisiblity.Click += new System.EventHandler(this.pbVisiblity_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(136, 132);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(136, 81);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(129, 177);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 32);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 81);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tia\'s Fisheries";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Istn3ASproject.Properties.Resources.loginbg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Staff";
            this.bindingSource1.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "LoginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // checkLoginToolStrip
            // 
            this.checkLoginToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.checkLoginToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripLabel,
            this.userToolStripTextBox,
            this.passwordToolStripLabel,
            this.passwordToolStripTextBox,
            this.checkLoginToolStripButton});
            this.checkLoginToolStrip.Location = new System.Drawing.Point(0, 0);
            this.checkLoginToolStrip.Name = "checkLoginToolStrip";
            this.checkLoginToolStrip.Size = new System.Drawing.Size(788, 25);
            this.checkLoginToolStrip.TabIndex = 3;
            this.checkLoginToolStrip.Text = "checkLoginToolStrip";
            this.checkLoginToolStrip.Visible = false;
            // 
            // userToolStripLabel
            // 
            this.userToolStripLabel.Name = "userToolStripLabel";
            this.userToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.userToolStripLabel.Text = "user:";
            // 
            // userToolStripTextBox
            // 
            this.userToolStripTextBox.Name = "userToolStripTextBox";
            this.userToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // passwordToolStripLabel
            // 
            this.passwordToolStripLabel.Name = "passwordToolStripLabel";
            this.passwordToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.passwordToolStripLabel.Text = "password:";
            // 
            // passwordToolStripTextBox
            // 
            this.passwordToolStripTextBox.Name = "passwordToolStripTextBox";
            this.passwordToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // checkLoginToolStripButton
            // 
            this.checkLoginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.checkLoginToolStripButton.Name = "checkLoginToolStripButton";
            this.checkLoginToolStripButton.Size = new System.Drawing.Size(74, 22);
            this.checkLoginToolStripButton.Text = "CheckLogin";
            this.checkLoginToolStripButton.Click += new System.EventHandler(this.checkLoginToolStripButton_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 533);
            this.Controls.Add(this.checkLoginToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisiblity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            this.checkLoginToolStrip.ResumeLayout(false);
            this.checkLoginToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbVisiblity;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LoginDataSet loginDataSet;
        private LoginDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.ToolStrip checkLoginToolStrip;
        private System.Windows.Forms.ToolStripLabel userToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel passwordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox passwordToolStripTextBox;
        private System.Windows.Forms.ToolStripButton checkLoginToolStripButton;
    }
}

