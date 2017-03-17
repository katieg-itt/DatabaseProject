namespace PostITT
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.MainPagegrp = new System.Windows.Forms.GroupBox();
            this.scoretxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.userIdtxt = new System.Windows.Forms.TextBox();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.postITT = new System.Windows.Forms.Label();
            this.confirmbttn = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNametxt = new System.Windows.Forms.TextBox();
            this.lNametxt = new System.Windows.Forms.TextBox();
            this.MainPagegrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPagegrp
            // 
            this.MainPagegrp.BackColor = System.Drawing.Color.Azure;
            this.MainPagegrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPagegrp.Controls.Add(this.lNametxt);
            this.MainPagegrp.Controls.Add(this.fNametxt);
            this.MainPagegrp.Controls.Add(this.label2);
            this.MainPagegrp.Controls.Add(this.label1);
            this.MainPagegrp.Controls.Add(this.email);
            this.MainPagegrp.Controls.Add(this.score);
            this.MainPagegrp.Controls.Add(this.userId);
            this.MainPagegrp.Controls.Add(this.confirmbttn);
            this.MainPagegrp.Controls.Add(this.scoretxt);
            this.MainPagegrp.Controls.Add(this.emailtxt);
            this.MainPagegrp.Controls.Add(this.userIdtxt);
            this.MainPagegrp.Controls.Add(this.profilePic);
            this.MainPagegrp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPagegrp.ForeColor = System.Drawing.Color.Black;
            this.MainPagegrp.Location = new System.Drawing.Point(55, 69);
            this.MainPagegrp.Name = "MainPagegrp";
            this.MainPagegrp.Size = new System.Drawing.Size(539, 304);
            this.MainPagegrp.TabIndex = 11;
            this.MainPagegrp.TabStop = false;
            this.MainPagegrp.Text = "Profile";
            // 
            // scoretxt
            // 
            this.scoretxt.Location = new System.Drawing.Point(433, 34);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(55, 32);
            this.scoretxt.TabIndex = 39;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(226, 191);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(141, 32);
            this.emailtxt.TabIndex = 38;
            // 
            // userIdtxt
            // 
            this.userIdtxt.Location = new System.Drawing.Point(226, 34);
            this.userIdtxt.Name = "userIdtxt";
            this.userIdtxt.Size = new System.Drawing.Size(51, 32);
            this.userIdtxt.TabIndex = 36;
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(17, 34);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(95, 94);
            this.profilePic.TabIndex = 11;
            this.profilePic.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signOutToolStripMenuItem1
            // 
            this.signOutToolStripMenuItem1.Name = "signOutToolStripMenuItem1";
            this.signOutToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem1.Text = "Sign Out";
            this.signOutToolStripMenuItem1.Click += new System.EventHandler(this.signOutToolStripMenuItem1_Click);
            // 
            // postITT
            // 
            this.postITT.AutoSize = true;
            this.postITT.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postITT.ForeColor = System.Drawing.Color.Silver;
            this.postITT.Location = new System.Drawing.Point(260, 29);
            this.postITT.Name = "postITT";
            this.postITT.Size = new System.Drawing.Size(89, 27);
            this.postITT.TabIndex = 13;
            this.postITT.Text = "Post ITT";
            // 
            // confirmbttn
            // 
            this.confirmbttn.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirmbttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.confirmbttn.FlatAppearance.BorderSize = 0;
            this.confirmbttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmbttn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmbttn.Location = new System.Drawing.Point(433, 267);
            this.confirmbttn.Name = "confirmbttn";
            this.confirmbttn.Size = new System.Drawing.Size(100, 31);
            this.confirmbttn.TabIndex = 40;
            this.confirmbttn.Text = "Confirm";
            this.confirmbttn.UseVisualStyleBackColor = false;
            this.confirmbttn.Click += new System.EventHandler(this.confirmbttn_Click);
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.Location = new System.Drawing.Point(152, 42);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(53, 18);
            this.userId.TabIndex = 41;
            this.userId.Text = "User ID";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(352, 42);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(42, 18);
            this.score.TabIndex = 42;
            this.score.Text = "Score";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(139, 199);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 18);
            this.email.TabIndex = 43;
            this.email.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Last Name";
            // 
            // fNametxt
            // 
            this.fNametxt.Location = new System.Drawing.Point(226, 96);
            this.fNametxt.Name = "fNametxt";
            this.fNametxt.Size = new System.Drawing.Size(141, 32);
            this.fNametxt.TabIndex = 46;
            // 
            // lNametxt
            // 
            this.lNametxt.Location = new System.Drawing.Point(226, 141);
            this.lNametxt.Name = "lNametxt";
            this.lNametxt.Size = new System.Drawing.Size(141, 32);
            this.lNametxt.TabIndex = 47;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(645, 410);
            this.Controls.Add(this.postITT);
            this.Controls.Add(this.MainPagegrp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.MainPagegrp.ResumeLayout(false);
            this.MainPagegrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainPagegrp;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label postITT;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem1;
        private System.Windows.Forms.TextBox scoretxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox userIdtxt;
        private System.Windows.Forms.Button confirmbttn;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label userId;
        private System.Windows.Forms.TextBox lNametxt;
        private System.Windows.Forms.TextBox fNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}