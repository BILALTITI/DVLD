using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Form1 : Form
    {
  private int _LicenseID;
        private License.License _License;


        private Login _Login;
        public Form1(Login login)
        {

            InitializeComponent();
        _Login= login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUser showUser = new ShowUser(); 
            showUser.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PeopleForm peopleForm = new PeopleForm();
            peopleForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

            this.Close();
           _Login.Show();
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ApplicationTybes applicationTybes = new ApplicationTybes();
            applicationTybes.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            TestTybe testTybe = new TestTybe();     
            testTybe.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            New_local_driving_lisince new_Local_Driving_Lisince = new New_local_driving_lisince();
            new_Local_Driving_Lisince.ShowDialog();
        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddnewLocalDrivingLicense addnewLocalDrivingLicense = new AddnewLocalDrivingLicense ();
            addnewLocalDrivingLicense.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mange_Drivers mange_Drivers = new Mange_Drivers();
            mange_Drivers.ShowDialog();
        }

        private void interNationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicence internationalLicence = new InternationalLicence();
            internationalLicence.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            renew Renew = new renew();
            Renew.ShowDialog();

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            damgeorlost damgeorlost = new damgeorlost();
            damgeorlost.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Daitain daitain = new Daitain();
            daitain.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DetaineLicenceList detaineLicenceList = new DetaineLicenceList();
            detaineLicenceList.ShowDialog();
        }

        private void relasedDrivingLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelaiesLicencecs relaiesLicencecs = new RelaiesLicencecs();
            relaiesLicencecs.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowManageinternationlLicence showManageinternationlLicence = new ShowManageinternationlLicence();
            showManageinternationlLicence.Show();
        }
    }
}
