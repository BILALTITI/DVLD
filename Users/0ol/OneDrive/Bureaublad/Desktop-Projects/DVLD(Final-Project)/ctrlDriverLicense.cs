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
    public partial class ctrlDriverLicense : UserControl
    {
        private int _DriverID;
        private Drivers _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;


        public ctrlDriverLicense()
        {
            InitializeComponent();
        }
        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = Drivers.GetLicense(_DriverID);


            DGVLocal.DataSource = _dtDriverLocalLicensesHistory;
            lbCount2.Text = DGVLocal.Rows.Count.ToString();

            if (DGVLocal.Rows.Count > 0)
            {
                DGVLocal.Columns[0].HeaderText = "Lic.ID";
                DGVLocal.Columns[0].Width = 110;

                DGVLocal.Columns[1].HeaderText = "App.ID";
                DGVLocal.Columns[1].Width = 110;

                DGVLocal    .Columns[2].HeaderText = "Class Name";
                DGVLocal.Columns[2].Width = 270;

                DGVLocal.Columns[3].HeaderText = "Issue Date";
                DGVLocal.Columns[3].Width = 170;

                DGVLocal.Columns[4].HeaderText = "Expiration Date";
                DGVLocal.Columns[4].Width = 170;

                DGVLocal.Columns[5].HeaderText = "Is Active";
                DGVLocal.Columns[5].Width = 110;

            }
        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = Drivers.GetInternationalLicenses(_DriverID);


            DGVInternational.DataSource = _dtDriverInternationalLicensesHistory;
            lbCount.Text = DGVInternational.Rows.Count.ToString();

            if (DGVInternational.Rows.Count > 0)
            {
                DGVInternational.Columns[0].HeaderText = "Int.License ID";
                DGVInternational.Columns[0].Width = 160;

                DGVInternational.Columns[1].HeaderText = "Application ID";
                DGVInternational.Columns[1].Width = 130;

                DGVInternational.Columns[2].HeaderText = "L.License ID";
                DGVInternational.Columns[2].Width = 130;

                DGVInternational.Columns[3].HeaderText = "Issue Date";
                DGVInternational.Columns[3].Width = 180;

                DGVInternational.Columns[4].HeaderText = "Expiration Date";
                DGVInternational.Columns[4].Width = 180;

                DGVInternational.Columns[5].HeaderText = "Is Active";
                DGVInternational.Columns[5].Width = 120;

            }
        }
        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }
        public void LoadInfo(int DriverID)
        {
            _DriverID = DriverID;
            _Driver = Drivers.Find(_DriverID);
            if(_Driver == null )
            {

                MessageBox.Show("Could not find Driver ID = " + _DriverID.ToString(),
    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();

        }

        public void LoadInfoByPersonID(int PersonID)
        {

            _Driver = Drivers.FindbyPersonID(PersonID);

            if (_Driver== null)
            {
                MessageBox.Show("THere is No Driver ID Linekd With Oerson ID  = " + PersonID.ToString(),
"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _Driver.DriverID;


            if (_Driver != null)
            {
                _DriverID = Drivers.FindbyPersonID(PersonID).DriverID;
            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        private void ctrlDriverLicense_Load(object sender, EventArgs e)
        {

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)DGVInternational.CurrentRow.Cells[0].Value;
            internationalLicenceForm frm = new internationalLicenceForm(InternationalLicenseID);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DGVLocal.CurrentRow.Cells[0].Value;
            Form3 frm = new Form3(LicenseID);
            frm.ShowDialog();

        }

        private void CMSLocal_Opening(object sender, CancelEventArgs e)
        {
            if (DGVLocal.Rows.Count > 0)
            {
                CMSLocal.Enabled = false;
            }
            else
            {
                CMSLocal.Enabled = true;

            }
        }

        private void CMSInternatinal_Opening(object sender, CancelEventArgs e)
        {
            if (DGVInternational.Rows.Count > 0)
            {
                CMSInternatinal.Enabled = false;
            }
            else
            {
               CMSInternatinal.Enabled = true;

            }
        }
    }
}
    