﻿using DVLD__Business_Layer;
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
            if (cbFilterUser.Text == "Status")
            {
                tbFilter.Visible = false;
                cbISactive.Visible = true;
                cbISactive.Enabled = true;
                cbISactive.Focus();
                cbISactive.SelectedIndex = 0;
                DGVLocalApplication.DataSource = dt;

            }

            else

            {

                tbFilter.Visible = (cbFilterUser.Text != "None");
                cbISactive.Visible = false;

                if (cbFilterUser.Text == "None")
                {
                    tbFilter.Enabled = false;
                    cbISactive.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
                    DGVLocalApplication.DataSource = dt;

                }
                else
                    tbFilter.Enabled = true;
                DGVLocalApplication.DataSource = dt;

                tbFilter.Text = "";
                tbFilter.Focus();
            }
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

            bool PassedVisionTest = LocalDrivingLicenseApplications.IsPassedTest(localDrivingLicenseApplicationID, 1);

            bool PassedWrittenTest = LocalDrivingLicenseApplications.IsPassedTest(localDrivingLicenseApplicationID, 2);
            bool PassedStreetTest = LocalDrivingLicenseApplications.IsPassedTest(localDrivingLicenseApplicationID, 3);

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
            _RefreshUserList();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Application ? [" + DGVLocalApplication.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (LocalDrivingLicenseApplications.DeletetLocalDrivingLicenseApplications((int)DGVLocalApplication.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully");
                    _RefreshUserList();
                }
                else
                    MessageBox.Show("Application  Is not Deleted");
            }
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueDriving_license_first_tie first_time  = new issueDriving_license_first_tie((int)DGVLocalApplication.CurrentRow.Cells[0].Value);
            first_time.ShowDialog();    
            _RefreshUserList(); 
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
                    _RefreshUserList();
                }
                else
                    MessageBox.Show("Application  Is not Cancel");
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Show_Application_Info  application_Info = new Show_Application_Info((int)DGVLocalApplication.CurrentRow.Cells[0].Value);
            application_Info.ShowDialog();

        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = (int)DGVLocalApplication.CurrentRow.Cells[0].Value;

            LocalDrivingLicenseApplications LocalDrivingLicenseApplication =
                LocalDrivingLicenseApplications.Find(LocalDrivingLicenseApplicationID);

            Licence_History licence_History = new Licence_History(LocalDrivingLicenseApplication.Applicationinfo.ApplicantPersonID);    
            licence_History.ShowDialog();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUser.Text == "LocalDrivingLicenseApplicationID")
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

            string query = $"{cbFilterUser.Text} = {tbFilter.Text} ";
            string query2 = $"{cbFilterUser.Text} Like '{tbFilter.Text}%' ";

            if (tbFilter.Text == "")
            {

                DGVLocalApplication.DataSource = dt;


                dt.DefaultView.RowFilter = "";


                return;
            }

             else
            {

                DGVLocalApplication.DataSource = dt;


                dt.DefaultView.RowFilter = query2;

            }
        }
    }
}
