using DVLD__Business_Layer;
using License;
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

namespace DVLD
{
    public partial class Form3 : Form
    {
        private int _LicenseID;
        private License.License _License;


         

        public Form3(int LicenseID)
        {
            _LicenseID = LicenseID;


            InitializeComponent();
        }
        public Form3()
        {
            InitializeComponent();
        }

        public int LicenseID
        {
            get
            {
                return _LicenseID;
            }
        }
                private void lbExpier_Click(object sender, EventArgs e)
        {

        }
        //public void _LoadData(int LicenseID)
        //{
        //  licenceInfo1.getLicenceInfo(LicenseID);
        //}
        private void Form3_Load(object sender, EventArgs e)
        {
            licenceInfo1.getLicenceInfo(LicenseID);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void licenceInfo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
