using DVLD__Business_Layer;
using Presntation_Layet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class AddnewLocalDrivingLicense : Form
    {
        public enum enTestType { Vision = 0, Written = 1, Street };
        private enTestType _Test;

        public static DataTable dt = LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications();
        public AddnewLocalDrivingLicense()
        {
            InitializeComponent();
        }

        public void _RefreshUserList()
        {
            DGVLocalApplication.DataSource = LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddnewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            DGVLocalApplication.DataSource = LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications();
            DGVLocalApplication.DataSource = dt;

            lbCountRecords.Text = DGVLocalApplication.RowCount.ToString();
            cbFilterUser.SelectedIndex = 0;
            tbFilter.Visible = false;
            cbISactive.Visible = false;
            if (DGVLocalApplication.Rows.Count > 0)
            {

                DGVLocalApplication.Columns[0].HeaderText = "L.D.L.AppID";
                DGVLocalApplication.Columns[0].Width = 60;

                DGVLocalApplication.Columns[1].HeaderText = "Driving Class";
                DGVLocalApplication.Columns[1].Width = 160;

                DGVLocalApplication.Columns[2].HeaderText = "National No.";
                DGVLocalApplication.Columns[2].Width = 55;

                DGVLocalApplication.Columns[3].HeaderText = "Full Name";
                DGVLocalApplication.Columns[3].Width = 210;

                DGVLocalApplication .Columns[4].HeaderText = "Application Date";
                 DGVLocalApplication.Columns[4].Width = 120;

                DGVLocalApplication.Columns[5].HeaderText = "Passed Tests";
                DGVLocalApplication.Columns[5].Width = 55;
                DGVLocalApplication.Columns[6].HeaderText = "Status";
                DGVLocalApplication.Columns[6].Width = 70;
            }

            _RefreshUserList();
        }

        private void DGVLocalApplication_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            New_local_driving_lisince new_Local_Driving_Lisince = new New_local_driving_lisince(-1);
            new_Local_Driving_Lisince.ShowDialog();

            _RefreshUserList();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)DGVLocalApplication.CurrentRow.Cells[0].Value;
int LicenceID=LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID).GetActiveLicence();
            if (LicenceID != -1)
            {


                Form3 form3 = new Form3(LicenceID);
                form3.ShowDialog();

            }
            else
            {
                MessageBox.Show("NO Licence Found ! ","No Licence ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            }

        private void sechudleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule_Vision_Test schedule_Vision_Test = new Schedule_Vision_Test((int)DGVLocalApplication.CurrentRow.Cells[0].Value, 1, -1);
            schedule_Vision_Test.ShowDialog();
            _RefreshUserList();
        }

        private void sechudleToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilterUser.Text != "None");

            if (tbFilter.Visible)
            {
                tbFilter.Text = "";
                tbFilter.Focus();
            }

            dt.DefaultView.RowFilter = "";
            lbCountRecords.Text = DGVLocalApplication.Rows.Count.ToString();
        }

        private void cbISactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Status";
            string FilterValue = cbISactive.Text;
            cbISactive.Visible = true;
           


 

            if (FilterValue == "All")
                dt.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE  '{1}%'", FilterColumn, FilterValue);

            lbCountRecords.Text = DGVLocalApplication.Rows.Count.ToString();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            string Status = (string)DGVLocalApplication.CurrentRow.Cells[6].Value;
            int localDrivingLicenseApplicationID = (int)DGVLocalApplication.CurrentRow.Cells[0].Value;
            LocalDrivingLicenseApplications localDrivingLicenseApplications = LocalDrivingLicenseApplications.Find(localDrivingLicenseApplicationID);
            int TotalPassedTest=(int)DGVLocalApplication.CurrentRow.Cells[5].Value;
            localDrivingLicenseApplications.Applicationinfo.ApplicationsTypesID.ToString();

            bool PassedVisionTest = LocalDrivingLicenseApplications.IsPassedTest(localDrivingLicenseApplicationID,(int) Tests.enTestType.Vision);

            bool PassedWrittenTest = LocalDrivingLicenseApplications.IsPassedTest(localDrivingLicenseApplicationID, (int)Tests.enTestType.Written);
            bool PassedStreetTest = LocalDrivingLicenseApplications.IsPassedTest(localDrivingLicenseApplicationID, (int)Tests.enTestType.Street);

            bool LicenseExists = localDrivingLicenseApplications.IslicenseIssued();
            cancelApplicationToolStripMenuItem.Enabled = Status=="New";
            deleteApplicationToolStripMenuItem.Enabled = Status=="New";

            editApplicationToolStripMenuItem.Enabled = !LicenseExists&& Status == "New";
            sechudleToolsToolStripMenuItem.Enabled= (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && Status == "New";
            //issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = !PassedStreetTest && Status != "Completed";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = TotalPassedTest==3&&!LicenseExists&&Status=="New";
         
            showToolStripMenuItem.Enabled = LicenseExists;
            //showToolStripMenuItem.Enabled = (!PassedVisionTest || !PassedWrittenTest || !PassedStreetTest) && Status == "New";
                if (sechudleToolsToolStripMenuItem.Enabled)
            {
                sechudleVisionTestToolStripMenuItem.Enabled = !PassedVisionTest;
                sechudleWritenTestToolStripMenuItem.Enabled = PassedVisionTest&&!PassedWrittenTest;
                sechudleStreetTestToolStripMenuItem.Enabled = PassedVisionTest && PassedWrittenTest &&!PassedStreetTest;

            }
        }

        private void sechudleWritenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Schedule_Vision_Test schedule_Vision_Test = new Schedule_Vision_Test((int)DGVLocalApplication.CurrentRow.Cells[0].Value, 2, -1);
 
            schedule_Vision_Test.ShowDialog();
            _RefreshUserList();
        }

        private void sechudleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Schedule_Vision_Test schedule_Vision_Test = new Schedule_Vision_Test((int)DGVLocalApplication.CurrentRow.Cells[0].Value, 3,-1);

            schedule_Vision_Test.ShowDialog();
            AddnewLocalDrivingLicense_Load(null, null);
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Application ? [" + DGVLocalApplication.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (LocalDrivingLicenseApplications.DeletetLocalDrivingLicenseApplications((int)DGVLocalApplication.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully");

                    AddnewLocalDrivingLicense_Load(null, null);
                }
                else
                    MessageBox.Show("Application  Is not Deleted");
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueDriving_license_first_tie first_time  = new issueDriving_license_first_tie((int)DGVLocalApplication.CurrentRow.Cells[0].Value);
            first_time.ShowDialog();
            AddnewLocalDrivingLicense_Load(null, null);
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
               if (MessageBox.Show("Are you sure you want to Cancel Application ? [" + DGVLocalApplication.CurrentRow.Cells[0].Value + "]", "Confirm Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int LocalDrivingLicenseApplicationID = (int)DGVLocalApplication.CurrentRow.Cells[0].Value;

                LocalDrivingLicenseApplications LocalDrivingLicenseApplication =
                    LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);


                if (LocalDrivingLicenseApplication.Applicationinfo.UpDateApplicationStatus(LocalDrivingLicenseApplicationID, 2))
                {
                    MessageBox.Show("Application Cancel Successfully");

                    AddnewLocalDrivingLicense_Load(null, null);
                }
                else
                    MessageBox.Show("Application  Is not Cancel");
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Show_Application_Info  application_Info = new Show_Application_Info((int)DGVLocalApplication.CurrentRow.Cells[0].Value);
            application_Info.ShowDialog();

            AddnewLocalDrivingLicense_Load(null, null);
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = (int)DGVLocalApplication.CurrentRow.Cells[0].Value;

            LocalDrivingLicenseApplications LocalDrivingLicenseApplication =
                LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

            Licence_History licence_History = new Licence_History(LocalDrivingLicenseApplication.Applicationinfo.ApplicantPersonID);
            licence_History.ShowDialog();

            AddnewLocalDrivingLicense_Load(null, null);
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterUser.Text)
            {

                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                dt.DefaultView.RowFilter = "";
                DGVLocalApplication.DataSource = dt;

                lbCountRecords.Text = DGVLocalApplication.Rows.Count.ToString();
                return;
            }
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUser.Text == "L.D.L.AppID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                {

                    e.Handled = true;

                    MessageBox.Show("Error, A LocalDriving License ApplicationID  number can't contain a Letter ");
                    return;

                }

            }
        }

        private void tbFilter_TextChanged_1(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterUser.Text)
            {

                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (tbFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                dt.DefaultView.RowFilter = "";
                DGVLocalApplication.DataSource = dt;

                lbCountRecords.Text =DGVLocalApplication.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                //in this case we deal with integer not string.
                dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilter.Text.Trim());
            else
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilter.Text.Trim());

            lbCountRecords.Text = DGVLocalApplication.Rows.Count.ToString();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)

        {
            int LocalDrivingLicenseApplicationID = (int)DGVLocalApplication.CurrentRow.Cells[0].Value;
            New_local_driving_lisince new_Local_Driving_Lisince = new New_local_driving_lisince(LocalDrivingLicenseApplicationID);
        
            
            new_Local_Driving_Lisince.ShowDialog();



            AddnewLocalDrivingLicense_Load(null, null);
        }


    }
}
