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
    public partial class internationalLicenceForm : Form
    {
        private int _internationalLicenseApplicationID;
        private InternationalLicenses _intLicense;


        public internationalLicenceForm(int internationalLicenseApplicationID)

        {

            _internationalLicenseApplicationID = internationalLicenseApplicationID;
             InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        public int internationalLicenseApplicationID
        {
            get
            {
                return _internationalLicenseApplicationID;
            }

        }

            

        public void _getLicenceInfo()
        {
             

        }
        private void internationalLicenceForm_Load(object sender, EventArgs e)
        {

            international_Licence1.getintLicenceInfo(internationalLicenseApplicationID);
        }
    }
}
