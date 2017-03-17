using PostITT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostITT
{
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
                InitializeComponent();
                
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if(emailtxt.Text.Equals(""))
            {
                MessageBox.Show("Please enter in an email", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailtxt.Focus();
                return;
            }

            if (passwordtxt.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a password", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtxt.Focus();
                return;
            }


            //Context.ITTUSER.ADDObject(ittuser);

            using (var db = new PostITTEntities())
            {

                /*  var results = from ITTUSER in db.ITTUSERs
                                 where ITTUSER.EMAIL == emailtxt.Text
                                 select ITTUSER;


                   ITTUSER c = results.First();
                   MessageBox.Show(c.EMAIL);
                   int UserId = c.USERID;
                   int score = (short)c.SCORE; */



                ITTUSER newStud = new ITTUSER();
                newStud.EMAIL = emailtxt.Text;
                newStud.PASSWORD = passwordtxt.Text;

                try
                {


                    var result = db.LOGIN(newStud.EMAIL, newStud.PASSWORD);
                    db.SaveChanges();
                    MessageBox.Show("You have Loged In", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);


                    var userID = from ITTUSER in db.ITTUSERs
                                 where ITTUSER.EMAIL == newStud.EMAIL
                                 select ITTUSER.USERID;

                    var score = from ITTUSER in db.ITTUSERs
                                where ITTUSER.EMAIL == newStud.EMAIL
                                select ITTUSER.SCORE;


                    foreach (var stuff in userID)
                    {
                        CurrentUsers.userId = stuff.ToString();
                    }

                    foreach (var stuff in score)
                    {
                        CurrentUsers.score = stuff.ToString();
                    }

                    Form newfrm = new frmProfile(emailtxt.Text.ToString());
                    newfrm.Show();
                    this.Hide();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }


            }
            }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUp_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            frmRegister newfrm = new frmRegister();
            newfrm.Show();
            newfrm.Visible = true;
        }

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            frmRegister newfrm = new frmRegister();
            newfrm.Show();
            newfrm.Visible = true;
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
