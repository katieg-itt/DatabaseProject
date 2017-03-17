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
    public partial class frmProfile : Form
    {
      

        public frmProfile(string loginEmail)
        {
          
                InitializeComponent();
               
        }



        private void Profile_Load(object sender, EventArgs e)
        {
            using (var db = new PostITTEntities())
            {


                
            //    var user = from ITTUSER e in db.ITTUSERs
              //                where e.USERID == 1
                //               select e;

                // this.userIdtxt.Text = user.First();


               // ITTUSER c = user.First();
                //int userId = c.USERID;
                //string email = c.EMAIL;


                
             }

           

        }
        private void signOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confirmbttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
