using DVLD__Business_Layer;
using Presntation_Layet;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class New_local_driving_lisince : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public static DataTable dt = LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications();
        int _LocalDrivingLicenseApplicationsID;
        LocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        Applications _Applications;
        public New_local_driving_lisince(int LocalDrivingLicenseApplicationsID)
        {
            _LocalDrivingLicenseApplicationsID = LocalDrivingLicenseApplicationsID;
            if (_LocalDrivingLicenseApplicationsID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
            InitializeComponent();
        }
        public New_local_driving_lisince()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public void _fillCountryinComboBox()
        {
            DataTable DtliceceClass = LicenseClasses.GetAlLLicenseClasses();
            foreach (DataRow row in DtliceceClass.Rows)
            {
                cbClass.Items.Add(row["ClassName"]);
            }
        }
        private void TPersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void ctrlShowCard1_Load(object sender, EventArgs e)
        {

        }
        void _loadData()
        {
            _fillCountryinComboBox();
            if (_Mode == enMode.AddNew)
            {

                lbnewlocal.Text = "New Local Driving License  Application ";
                this.Text = "New Local Driving License  Application";
                _Applications = new Applications();
                _LocalDrivingLicenseApplications = new LocalDrivingLicenseApplications();
                cbClass.SelectedIndex = 3;
                CBFilter.SelectedIndex = 0;
                TApplicationinfo.Enabled = false;


                lbDate2.Text = DateTime.Now.ToShortDateString();
                lbfees2.Text = Applicationstype.Find(1).ApplicationFees.ToString();
                lbcreatedby2.Text = "Bilal";


                btnSave.Enabled = true;

            }
            else
            {

                lbnewlocal.Text = "Update Local Driving License  Application ";
                this.Text = "Update  Local Driving License  Application";

                TApplicationinfo.Enabled = true;
                btnSave.Enabled = true;
            }

        }
        void _loadDataUpdate()
        {
            _fillCountryinComboBox();
            CBFilter.SelectedIndex = 0;
            groupBox1.Enabled = false;
            _LocalDrivingLicenseApplications = LocalDrivingLicenseApplications.Find(_LocalDrivingLicenseApplicationsID);


            if (_LocalDrivingLicenseApplications == null)
            {
                MessageBox.Show("No Aoolication With ID " + _LocalDrivingLicenseApplicationsID, "Application Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _Applications = Applications.Find(_LocalDrivingLicenseApplications.ApplicationID);

            ctrlShowCard1.ShowCard(_LocalDrivingLicenseApplications.Applicationinfo.ApplicantPersonID);

            tbFilter.Text = _LocalDrivingLicenseApplications.Applicationinfo.ApplicantPersonID.ToString();
            lbApplicationID2.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
            lbDate2.Text = _LocalDrivingLicenseApplications.Applicationinfo.ApplicationDate.ToString();
            cbClass.SelectedIndex = cbClass.FindString(LicenseClasses.Find(_LocalDrivingLicenseApplications.LicenseClassID).ClassName);
            lbfees2.Text = _LocalDrivingLicenseApplications.Applicationinfo.PaidFees.ToString();
            lbcreatedby2.Text = _LocalDrivingLicenseApplications.Applicationinfo.CreatedByUserID.ToString();
            btnSave.Enabled = true;
        }
        private void New_local_driving_lisince_Load(object sender, EventArgs e)
        {

            _loadData();
            if (_Mode == enMode.Update)
            {
                _loadDataUpdate();
                //TApplicationinfo.Enabled = true;

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (tbFilter.Text == "")
            {



                MessageBox.Show("Message box Must contain A value");

                return;
            }
            if (CBFilter.Text == "PersonID")
            {
                int PersonID = int.Parse(tbFilter.Text);

                ctrlShowCard1.ShowCard(PersonID);

            }
            else
            {
                string NationalNo = tbFilter.Text;

                ctrlShowCard1.ShowCard(NationalNo);


            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(-1);

            form2.DataBack += Form2_databack;
            form2.ShowDialog();
        }
        private void Form2_databack(object sender, int PersonID)
        {
            tbFilter.Text = PersonID.ToString();
            CBFilter.SelectedIndex = 0;
            ctrlShowCard1.ShowCard(PersonID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(tbFilter.Text);

            if (!LocalDrivingLicenseApplications.isLocalDrivingLicenseApplicationsExsist(PersonID))
            {

                tabControl1.SelectedIndex = 1;
                TApplicationinfo.Enabled = true;
            }

            else

            {

                tabControl1.SelectedIndex = 0;

                MessageBox.Show("The PersonID Is Already User ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Applications.ApplicantPersonID = ctrlShowCard1.PersonID;
            _Applications.ApplicationDate = DateTime.Now;
            _Applications.PaidFees = Convert.ToDecimal(lbfees2.Text);
            _Applications.ApplicationStatus = 1;
            _Applications.ApplicationsTypesID = 1;
            _Applications.CreatedByUserID = 1;
            _Applications.LastStatusDate = DateTime.Now;



            if (_Applications.Save())
            {
                _LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.Find(cbClass.Text).LicenseClassID  ;
                _LocalDrivingLicenseApplications.ApplicationID = _Applications.ApplicationID;

                if (_LocalDrivingLicenseApplications.Save())
                {
                    lbApplicationID2.Text = _LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID.ToString();
                    MessageBox.Show("Data Saved Succesfully");

                    _Mode = enMode.Update;
                    lbnewlocal.Text = "Update Local Driving License  Application ";
                    this.Text = "Update  Local Driving License  Application";

                }

            }
            else
            {
                MessageBox.Show("Data Not Saved Succesfully");

            }

            //LocalDrivingLicenseApplications _LocalDrivingLicenseApplications = new LocalDrivingLicenseApplications();
            //if (_LocalDrivingLicenseApplications.Save())
            //{
            //    MessageBox.Show("Data Saved Succesfully");


            //}
            //else
            //{
            //    MessageBox.Show("Data Not Saved Succesfully");

            //}
        }

        private void lbApplicationID2_Click(object sender, EventArgs e)
        {

        }

        private void TApplicationinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
