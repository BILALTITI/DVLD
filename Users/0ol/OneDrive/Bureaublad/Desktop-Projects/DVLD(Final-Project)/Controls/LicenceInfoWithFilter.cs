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
    public partial class LicenceInfoWithFilter : UserControl
    {
        //private int _LicenseID;
        //private License.License _License;


        public LicenceInfoWithFilter()
        {
            //_LicenseID = LicenseID;
            InitializeComponent();
        }

        private void licenceInfo1_Load(object sender, EventArgs e)
        {
            TbLicenceID.Focus();
                    
            //licenceInfo1.getLicenceInfo(_LicenseID);
        }

        private void TbLicenceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LicenceInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void FilterGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void TbLicenceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {

                PBSeaech_Click(null, null);
               
            }
        }

        private void TbLicenceID_Click(object sender, EventArgs e)
        {

        }

        private void PBSeaech_Click(object sender, EventArgs e)
        {

        }
    }
}
