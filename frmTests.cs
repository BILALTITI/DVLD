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
    public partial class frmTests : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private TestTypess.TestTypes.enTestType _TestType = TestTypess.TestTypes.enTestType.VisionTest;
        private int _AppotmentID = -1;
        public frmTests(int LocalDrivingLicenseApplicationID,TestTypess.TestTypes.enTestType TestType ,int AppotmentID=-1)
        {
            InitializeComponent();
             _LocalDrivingLicenseApplicationID= LocalDrivingLicenseApplicationID;
            _TestType = TestType;
            _AppotmentID= AppotmentID;
        }

        private void ctrlSchduleTest1_Load(object sender, EventArgs e)
        {
         
        }

        private void ctrlSchduleTest1_Load_1(object sender, EventArgs e)
        {
            ctrlSchduleTest1.TestTypeID = _TestType;
            ctrlSchduleTest1.LoadInfo(_LocalDrivingLicenseApplicationID, _AppotmentID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTests_Load(object sender, EventArgs e)
        {

        }
    }
}
