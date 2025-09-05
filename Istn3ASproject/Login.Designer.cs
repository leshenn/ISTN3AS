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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new Istn3ASproject.LoginDataSet();
            this.staffTableAdapter = new Istn3ASproject.LoginDataSetTableAdapters.StaffTableAdapter();
            this.checkLoginToolStrip = new System.Windows.Forms.ToolStrip();
            this.userToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.passwordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.passwordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.checkLoginToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pbVisiblity = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            this.checkLoginToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisiblity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbVisiblity);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(337, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 257);
            this.panel1.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(24, 204);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(265, 26);
            this.txtPass.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(24, 122);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(265, 26);
            this.txtUser.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightCyan;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(446, 463);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 39);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(114, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 100);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(382, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 58);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tia\'s Fisheries";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.checkLoginToolStrip.Size = new System.Drawing.Size(1051, 31);
            this.checkLoginToolStrip.TabIndex = 3;
            this.checkLoginToolStrip.Text = "checkLoginToolStrip";
            this.checkLoginToolStrip.Visible = false;
            // 
            // userToolStripLabel
            // 
            this.userToolStripLabel.Name = "userToolStripLabel";
            this.userToolStripLabel.Size = new System.Drawing.Size(39, 28);
            this.userToolStripLabel.Text = "user:";
            // 
            // userToolStripTextBox
            // 
            this.userToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userToolStripTextBox.Name = "userToolStripTextBox";
            this.userToolStripTextBox.Size = new System.Drawing.Size(132, 31);
            // 
            // passwordToolStripLabel
            // 
            this.passwordToolStripLabel.Name = "passwordToolStripLabel";
            this.passwordToolStripLabel.Size = new System.Drawing.Size(75, 28);
            this.passwordToolStripLabel.Text = "password:";
            // 
            // passwordToolStripTextBox
            // 
            this.passwordToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordToolStripTextBox.Name = "passwordToolStripTextBox";
            this.passwordToolStripTextBox.Size = new System.Drawing.Size(132, 31);
            // 
            // checkLoginToolStripButton
            // 
            this.checkLoginToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.checkLoginToolStripButton.Name = "checkLoginToolStripButton";
            this.checkLoginToolStripButton.Size = new System.Drawing.Size(89, 28);
            this.checkLoginToolStripButton.Text = "CheckLogin";
            this.checkLoginToolStripButton.Click += new System.EventHandler(this.checkLoginToolStripButton_Click);
            // 
            // pbVisiblity
            // 
            this.pbVisiblity.Image = global::Istn3ASproject.Properties.Resources.eye;
            this.pbVisiblity.Location = new System.Drawing.Point(305, 205);
            this.pbVisiblity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbVisiblity.Name = "pbVisiblity";
            this.pbVisiblity.Size = new System.Drawing.Size(27, 25);
            this.pbVisiblity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVisiblity.TabIndex = 6;
            this.pbVisiblity.TabStop = false;
            this.pbVisiblity.Click += new System.EventHandler(this.pbVisiblity_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 656);
            this.Controls.Add(this.checkLoginToolStrip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            this.checkLoginToolStrip.ResumeLayout(false);
            this.checkLoginToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisiblity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

