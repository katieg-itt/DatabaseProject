namespace PostITT
{
    partial class NewPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPost));
            this.MainPagegrp = new System.Windows.Forms.GroupBox();
            this.tag = new System.Windows.Forms.Label();
            this.tagtxt = new System.Windows.Forms.TextBox();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.category = new System.Windows.Forms.Label();
            this.post = new System.Windows.Forms.Label();
            this.categorytxt = new System.Windows.Forms.TextBox();
            this.postOnetxt = new System.Windows.Forms.RichTextBox();
            this.subbmitPostbttn = new System.Windows.Forms.Button();
            this.postITT = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPagegrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPagegrp
            // 
            this.MainPagegrp.BackColor = System.Drawing.Color.Azure;
            this.MainPagegrp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPagegrp.Controls.Add(this.tag);
            this.MainPagegrp.Controls.Add(this.tagtxt);
            this.MainPagegrp.Controls.Add(this.profilePic);
            this.MainPagegrp.Controls.Add(this.category);
            this.MainPagegrp.Controls.Add(this.post);
            this.MainPagegrp.Controls.Add(this.categorytxt);
            this.MainPagegrp.Controls.Add(this.postOnetxt);
            this.MainPagegrp.Controls.Add(this.subbmitPostbttn);
            this.MainPagegrp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPagegrp.ForeColor = System.Drawing.Color.Black;
            this.MainPagegrp.Location = new System.Drawing.Point(37, 67);
            this.MainPagegrp.Name = "MainPagegrp";
            this.MainPagegrp.Size = new System.Drawing.Size(610, 296);
            this.MainPagegrp.TabIndex = 11;
            this.MainPagegrp.TabStop = false;
            // 
            // tag
            // 
            this.tag.AutoSize = true;
            this.tag.Location = new System.Drawing.Point(129, 219);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(30, 16);
            this.tag.TabIndex = 22;
            this.tag.Text = "Tag";
            // 
            // tagtxt
            // 
            this.tagtxt.Location = new System.Drawing.Point(132, 240);
            this.tagtxt.Name = "tagtxt";
            this.tagtxt.Size = new System.Drawing.Size(312, 22);
            this.tagtxt.TabIndex = 21;
            // 
            // profilePic
            // 
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(20, 21);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(92, 88);
            this.profilePic.TabIndex = 12;
            this.profilePic.TabStop = false;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(129, 163);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(63, 16);
            this.category.TabIndex = 20;
            this.category.Text = "Category";
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(129, 88);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(31, 16);
            this.post.TabIndex = 19;
            this.post.Text = "Post";
            // 
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(132, 184);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(312, 22);
            this.categorytxt.TabIndex = 18;
            // 
            // postOnetxt
            // 
            this.postOnetxt.Location = new System.Drawing.Point(132, 110);
            this.postOnetxt.Name = "postOnetxt";
            this.postOnetxt.Size = new System.Drawing.Size(312, 36);
            this.postOnetxt.TabIndex = 17;
            this.postOnetxt.Text = "";
            // 
            // subbmitPostbttn
            // 
            this.subbmitPostbttn.BackColor = System.Drawing.Color.RoyalBlue;
            this.subbmitPostbttn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.subbmitPostbttn.FlatAppearance.BorderSize = 0;
            this.subbmitPostbttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subbmitPostbttn.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbmitPostbttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subbmitPostbttn.Location = new System.Drawing.Point(493, 261);
            this.subbmitPostbttn.Name = "subbmitPostbttn";
            this.subbmitPostbttn.Size = new System.Drawing.Size(94, 25);
            this.subbmitPostbttn.TabIndex = 10;
            this.subbmitPostbttn.Text = "Submit  post";
            this.subbmitPostbttn.UseVisualStyleBackColor = false;
            this.subbmitPostbttn.Click += new System.EventHandler(this.subbmitPostbttn_Click);
            // 
            // postITT
            // 
            this.postITT.AutoSize = true;
            this.postITT.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postITT.ForeColor = System.Drawing.Color.Silver;
            this.postITT.Location = new System.Drawing.Point(284, 31);
            this.postITT.Name = "postITT";
            this.postITT.Size = new System.Drawing.Size(89, 27);
            this.postITT.TabIndex = 12;
            this.postITT.Text = "Post ITT";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainPageToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.mainPageToolStripMenuItem1,
            this.signOutToolStripMenuItem,
            this.signOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            this.mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            this.mainPageToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.mainPageToolStripMenuItem.Text = "LogIn";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // mainPageToolStripMenuItem1
            // 
            this.mainPageToolStripMenuItem1.Name = "mainPageToolStripMenuItem1";
            this.mainPageToolStripMenuItem1.Size = new System.Drawing.Size(75, 20);
            this.mainPageToolStripMenuItem1.Text = "Main Page";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.signOutToolStripMenuItem.Text = "New Post";
            // 
            // signOutToolStripMenuItem1
            // 
            this.signOutToolStripMenuItem1.Name = "signOutToolStripMenuItem1";
            this.signOutToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.signOutToolStripMenuItem1.Text = "Sign Out";
            // 
            // NewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(685, 400);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.postITT);
            this.Controls.Add(this.MainPagegrp);
            this.Name = "NewPost";
            this.Text = "NewPost";
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
        private System.Windows.Forms.RichTextBox postOnetxt;
        private System.Windows.Forms.Button subbmitPostbttn;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label post;
        private System.Windows.Forms.TextBox categorytxt;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label tag;
        private System.Windows.Forms.TextBox tagtxt;
        private System.Windows.Forms.Label postITT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainPageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem1;
    }
}