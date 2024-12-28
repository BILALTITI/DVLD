using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DVLD__Business_Layer;
using System.Linq.Expressions;
namespace DVLD
{
    
    public partial class Login : Form
    {

         private int _FailedCount=0;
        public Login()
        {
            InitializeComponent();
        }
SqlConnection sqlConnection = new SqlConnection(@"Server=.;Database=DVLD;User Id=sa;Password=sa123456;");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             User user = User.FindByUserNameAndPassword(tbUserName.Text.Trim(),clsGloabalcs.ComputeHash( tbPassword.Text.Trim()));
   
            if (user != null)
            {

                if (RBremmberMe.Checked)
                {
                    //store username and password
                    clsGloabalcs.RememberUsernameAndPassword(tbUserName.Text.Trim(),tbPassword.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGloabalcs.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    tbUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGloabalcs.CurrentUser = user;
                this.Hide();

                Form1 form = new Form1(this);
               form.Show();



            }
            else
            {

                _FailedCount++;
                tbUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (_FailedCount >= 3)
                {
                    btnLogin.Visible = false;
                    LbMessage.Text = "Sorry Can't Login Now  Please try After 1 Hours ";
                    LbMessage.BackColor = Color.Red;
                
                    clsGloabalcs.SaveToEventLog("Failed More than 3 Times ", System.Diagnostics.EventLogEntryType.Error);
                    MessageBox.Show( "Failed More than 3 Traield "," Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            tbUserName.Focus();
            string UserName="", Password= "";
            if (clsGloabalcs.GetStoredCredential(ref UserName,ref Password))
                {

             tbUserName.Text = UserName;
tbPassword.Text = Password;
               RBremmberMe.Checked = true;

            }
            else
            {
                RBremmberMe.Checked= false;
            } 
                
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Login_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void Login_Activated(object sender, EventArgs e)
        {
            tbUserName.Focus();
        }
    }
}
