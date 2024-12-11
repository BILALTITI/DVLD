using DVLD__Business_Layer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD
{
    public partial class RelaiesLicencecs : Form
    {

        private int _LicenseID=-1;
        private License.License _License;

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public RelaiesLicencecs(int LicenceID)
        {

            InitializeComponent();
            _LicenseID = LicenceID;
            licenceInfoWithFilter21.txtSearchValue = _LicenseID.ToString();
            licenceInfoWithFilter21.FIndNow(LicenceID);
            licenceInfoWithFilter21.FilterEnable = false;
           

        }
        public RelaiesLicencecs()
        {
            InitializeComponent();

            licenceInfoWithFilter21.FilterEnable = true;

        }

        private void RelaiesLicencecs_Load(object sender, EventArgs e)
        {
            if (_LicenseID==-1)

                btnReleise.Enabled = false; 
            LLShowHistory.Enabled = false;
            LLShowInfo.Enabled = false;
            lbApplicationID2.Text = DateTime.Now.ToString();

            //lbApplicationFees2.Text = Presntation_Layet.Applicationstype.Find(5).ApplicationFees.ToString();

            //lbDetainDate22.Text = DateTime.Now.ToString();
            //lboldLicecnceIID2.Text =licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID.ToString();;


            //lbTotalFees2.Text = (Convert.ToDecimal(lbApplicationFees2.Text) + Convert.ToDecimal(lbFineFees2.Text)).ToString();
        }

        private void licenceInfoWithFilter21_OnLicenceSelected(object sender, int e)
        {


            int SelectedLicencID = e;
            lbLicenceID2.Text = SelectedLicencID.ToString();
            LLShowHistory.Enabled = (SelectedLicencID != -1);


            if (SelectedLicencID == -1)
            {
                return;


            }

            if (!licenceInfoWithFilter21.SelectedLiceenceInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReleise.Enabled = false;
                return;
            }


            if (!licenceInfoWithFilter21.SelectedLiceenceInfo.IsDetained)
            {
                MessageBox.Show("Selected License is not Detained, choose an Detained license."
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReleise.Enabled = false;
                return;
            }


            lbLicenceID2.Text = licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID.ToString();
            lbApplicationFees2.Text = Applicationstype.Find(5).ApplicationFees.ToString();
            lbFineFees2.Text = licenceInfoWithFilter21.SelectedLiceenceInfo.Licenseinfo.ClassFees.ToString();
            lbTotalFees2.Text = (Convert.ToSingle(lbApplicationFees2.Text) + Convert.ToSingle(lbFineFees2.Text)).ToString();
            lbDetainID2.Text = licenceInfoWithFilter21.SelectedLiceenceInfo.DetainedInfo.DetainID.ToString();
            lbDetainDate22.Text = licenceInfoWithFilter21.SelectedLiceenceInfo.DetainedInfo.DetainDate.ToString();

            lbCreatedBy2.Text = 1.ToString();
             
            btnReleise.Enabled = true;
            
        }

        private void btnReleise_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Releise a  for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Applications applications = new Applications();

            applications.ApplicantPersonID = licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID;
            applications.ApplicationsTypesID = Presntation_Layet.Applicationstype.Find(licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseClass).ApplicationTypeID;
            applications.CreatedByUserID = 1;
            applications.ApplicationDate = DateTime.Now;
            applications.ApplicationStatus = 3;
            applications.LastStatusDate = DateTime.Now;
            applications.PaidFees = Presntation_Layet.Applicationstype.Find(5).ApplicationFees;
            if (applications.Save())
            {

                bool IsRelaise = licenceInfoWithFilter21.SelectedLiceenceInfo.DetainedInfo.ReliseDetainLicence(applications.ApplicationID, 1);


                if (!IsRelaise)
                {
                    MessageBox.Show("Faild to Relise   License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }


                MessageBox.Show("Licensed Relised Successfully with ID=" + licenceInfoWithFilter21.SelectedLiceenceInfo.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnReleise.Enabled = false;
            groupBox2.Enabled = false;
            licenceInfoWithFilter21.FilterEnable = false;
            LLShowInfo.Enabled = true;
            LLShowHistory.Enabled=true;

        }

    
            private void licenceInfoWithFilter21_Load(object sender, EventArgs e)
            {

            }

        private void LLShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form3 info = new Form3(_LicenseID);
            info.Show();
        }

        private void LLShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Licence_History licence_History = new Licence_History(licenceInfoWithFilter21.SelectedLiceenceInfo.Driversinfo.PersonID);
            licence_History.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


