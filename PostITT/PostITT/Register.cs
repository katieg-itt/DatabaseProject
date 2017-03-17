using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostITT
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            
                InitializeComponent();
        }

        private void submitbttn_Click(object sender, EventArgs e)
        {
            if (firstNametxt.Text.Equals(""))
            {
                MessageBox.Show("Please enter in a First Name", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNametxt.Focus();
                return;
            }

            if (lastNametxt.Text.Equals(""))
            {
                MessageBox.Show("Please enter in your surname", "Field Empty",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNametxt.Focus();
                return;
            }

            if (emailtxt.Text.Equals(""))
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

            using (var db = new PostITTEntities())
            {



                ITTUSER newStud = new ITTUSER()
                {
                    FIRSTNAME = firstNametxt.Text,
                    SURNAME = lastNametxt.Text,
                    EMAIL = emailtxt.Text,
                    PASSWORD = passwordtxt.Text,
                    PROFILEPIC= null,
                   
                };
                try
                {
                    db.CREATEITTUSER(newStud.FIRSTNAME, newStud.SURNAME, newStud.EMAIL, newStud.PASSWORD);                    
                    MessageBox.Show("You've successfully Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);

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

                    this.Visible = false;
                    frmProfile newfrm = new frmProfile(emailtxt.Text.ToString());
                    newfrm.Show();
                    newfrm.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().ToString() , "Error",MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogIn newfrm = new frmLogIn();
            newfrm.Show();
           newfrm.Visible = true;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
