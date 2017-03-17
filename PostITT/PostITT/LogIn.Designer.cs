namespace PostITT
{
    partial class frmLogIn
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
            this.submitbttn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.needAnAccount = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.keepMeLogggedIn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signUp = new System.Windows.Forms.LinkLabel();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.postITT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitbttn
            // 
            this.submitbttn.BackColor = System.Drawing.Color.RoyalBlue;
            this.submitbttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.submitbttn.FlatAppearance.BorderSize = 0;
            this.submitbttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitbttn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submitbttn.Location = new System.Drawing.Point(398, 182);
            this.submitbttn.Name = "submitbttn";
            this.submitbttn.Size = new System.Drawing.Size(100, 31);
            this.submitbttn.TabIndex = 0;
            this.submitbttn.Text = "Sign In";
            this.submitbttn.UseVisualStyleBackColor = false;
            this.submitbttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(20, 113);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 18);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // needAnAccount
            // 
            this.needAnAccount.AutoSize = true;
            this.needAnAccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needAnAccount.ForeColor = System.Drawing.Color.DimGray;
            this.needAnAccount.Location = new System.Drawing.Point(355, 20);
            this.needAnAccount.Name = "needAnAccount";
            this.needAnAccount.Size = new System.Drawing.Size(107, 15);
            this.needAnAccount.TabIndex = 3;
            this.needAnAccount.Text = "Need an account ?";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(18, 52);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(42, 18);
            this.userName.TabIndex = 4;
            this.userName.Text = "Email";
            // 
            // keepMeLogggedIn
            // 
            this.keepMeLogggedIn.AutoSize = true;
            this.keepMeLogggedIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keepMeLogggedIn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepMeLogggedIn.ForeColor = System.Drawing.Color.DimGray;
            this.keepMeLogggedIn.Location = new System.Drawing.Point(33, 182);
            this.keepMeLogggedIn.Name = "keepMeLogggedIn";
            this.keepMeLogggedIn.Size = new System.Drawing.Size(125, 19);
            this.keepMeLogggedIn.TabIndex = 5;
            this.keepMeLogggedIn.Text = "Keep me logged in";
            this.keepMeLogggedIn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.signUp);
            this.groupBox1.Controls.Add(this.passwordtxt);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.userName);
            this.groupBox1.Controls.Add(this.submitbttn);
            this.groupBox1.Controls.Add(this.keepMeLogggedIn);
            this.groupBox1.Controls.Add(this.needAnAccount);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(73, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 246);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User LogIn";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Font = new System.Drawing.Font("Calibri", 9.25F, System.Drawing.FontStyle.Bold);
            this.signUp.Location = new System.Drawing.Point(462, 20);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(47, 15);
            this.signUp.TabIndex = 9;
            this.signUp.TabStop = true;
            this.signUp.Text = "Sign Up";
            this.signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUp_LinkClicked_1);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.Lavender;
            this.passwordtxt.Location = new System.Drawing.Point(24, 134);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(388, 32);
            this.passwordtxt.TabIndex = 8;
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.Lavender;
            this.emailtxt.Location = new System.Drawing.Point(22, 72);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(388, 32);
            this.emailtxt.TabIndex = 7;
            // 
            // postITT
            // 
            this.postITT.AutoSize = true;
            this.postITT.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postITT.ForeColor = System.Drawing.Color.Silver;
            this.postITT.Location = new System.Drawing.Point(282, 26);
            this.postITT.Name = "postITT";
            this.postITT.Size = new System.Drawing.Size(89, 27);
            this.postITT.TabIndex = 7;
            this.postITT.Text = "Post ITT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.signOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click_1);
            // 
            // signOutToolStripMenuItem1
            // 
            this.signOutToolStripMenuItem1.Name = "signOutToolStripMenuItem1";
            this.signOutToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem1.Text = "Sign Out";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(663, 384);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.postITT);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbttn;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label needAnAccount;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.CheckBox keepMeLogggedIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label postITT;
        private System.Windows.Forms.LinkLabel signUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem1;
    }
}

