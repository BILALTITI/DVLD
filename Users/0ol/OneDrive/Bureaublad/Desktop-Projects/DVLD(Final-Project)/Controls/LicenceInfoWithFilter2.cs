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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLD
{
    public partial class LicenceInfoWithFilter2 : UserControl
    {
        public event EventHandler<int> OnLicenceSelected;
        private int _LicenseID;
     //   private License.License _License;
        public License.License SelectedLiceenceInfo {  get { return licenceInfo1._License; } }
        public delegate void OnepersonSelect (object sender,int LicenseID);
        public event OnepersonSelect DataSend;
    public    License.License SelectedLicense ;
        public bool _FilterEnabled;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value; FilterGroupBox.Enabled = _FilterEnabled; }
        }
        public string txtSearchValue { set { TbLicenceID.Text = value; } }
        //public int SelectIndexCombox { set { CBFilter.SelectedIndex = value; } }

        public bool FilterEnable { set { FilterGroupBox.Enabled = value; } }
        public LicenceInfoWithFilter2(int LicenceID)
        {
            InitializeComponent();
        }
        public LicenceInfoWithFilter2()
        {
            InitializeComponent();
        }
        public void FIndNow(int LicenceID)
        {
            licenceInfo1.getLicenceInfo(LicenceID);
            if (OnLicenceSelected != null) OnLicenceSelected(this, licenceInfo1.LicenseID);
        }
        private void licenceInfo1_Load(object sender, EventArgs e)
        {
            FilterGroupBox.Focus();
            FilterEnable = true;

        }
        public void txtLicenseIDFocus()
        {
            TbLicenceID.Focus();
        }
        private void FilterGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PBSeaech_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TbLicenceID.Focus();
                return;

            }


            int LicenceID = int.Parse(TbLicenceID.Text);
            licenceInfo1.getLicenceInfo(LicenceID);

            if (OnLicenceSelected != null) OnLicenceSelected(this,licenceInfo1.LicenseID );
            //DetainedLicenses.Find(_LicenseID);
        }

        private void LicenceInfoWithFilter2_Load(object sender, EventArgs e)
        {
         TbLicenceID.Focus();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LicenceInfoWithFilter2_Validating(object sender, CancelEventArgs e)
        {
          

        }

        private void LicenceInfoWithFilter2_KeyPress(object sender, KeyPressEventArgs e)
        {
       

        }

        private void TbLicenceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TbLicenceID.Text != "")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                {

                    e.Handled = true;

                    MessageBox.Show("Error, A License ID  number can't contain a Letter ");


                }
            if (e.KeyChar == (char)13)
            {

                PBSeaech_Click(null, null);

            }
            }
        }
        private void TbLicenceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbLicenceID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TbLicenceID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TbLicenceID, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(TbLicenceID, null);
            }
        }
    }
}
