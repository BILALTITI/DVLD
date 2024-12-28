using DVLD__Business_Layer;
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
    public partial class Show_Application_Info : Form
    {
        int _localDrivingLicenseApplicationID;
        LocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        public Show_Application_Info(int localDrivingLicenseApplicationID)
        {
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Application_Info_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.ShowInfo(_localDrivingLicenseApplicationID);
        }

        private void ctrlApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
