using DVLD__Business_Layer;
using License;
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
    public partial class DetaineLicenceList : Form
    {

        private DataTable _dtDetainedLicenses = DetainedLicenses.GetDetainedLicenses();

        public DetaineLicenceList()
        {
            InitializeComponent();
        }

        private void lbMAngeDeivers_Click(object sender, EventArgs e)
        {

        }
        public void _RefreshDetainList()
        {
            DGVDetaindList.DataSource = DetainedLicenses.GetDetainedLicenses();
        }
        private void DetaineLicenceList_Load(object sender, EventArgs e)
        {
            cbFilterUser.SelectedIndex = 0;

            _dtDetainedLicenses = DetainedLicenses.GetDetainedLicenses();

            DGVDetaindList.DataSource = _dtDetainedLicenses;
        label2.Text =DGVDetaindList.Rows.Count.ToString();


            label2.Text = DGVDetaindList.RowCount.ToString();
         

            _RefreshDetainList();
        }

        private void PBDetained_Click(object sender, EventArgs e)
        {

            Daitain daitain = new Daitain();
            daitain.ShowDialog();
            _RefreshDetainList();
        }

        private void reliseDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelaiesLicencecs relaiesLicencecs = new RelaiesLicencecs((int)DGVDetaindList.CurrentRow.Cells[1].Value);
            relaiesLicencecs.ShowDialog();
            _RefreshDetainList();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenceID = (int)DGVDetaindList.CurrentRow.Cells[1].Value;
            License.License license = License.License.Find(LicenceID);
            int PersonID = license.Driversinfo.PersonID;
            cardDetails card = new cardDetails(PersonID);
            card.ShowDialog();


        }

        private void showLicensesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenceID = (int)DGVDetaindList.CurrentRow.Cells[1].Value;
            License.License license = License.License.Find(LicenceID);


            if (LicenceID != -1)
            {


                Form3 form3 = new Form3(LicenceID);
                form3.ShowDialog();

            }
            else
            {
                MessageBox.Show("NO Licence Found ! ", "No Licence ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _RefreshDetainList();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)DGVDetaindList.CurrentRow.Cells[1].Value;

            License.License license =
                License.License.Find(LicenseID);

            Licence_History licence_History = new Licence_History(license.Driversinfo.PersonID);
            licence_History.ShowDialog();
            _RefreshDetainList();
        }

        private void PBReleise_Click(object sender, EventArgs e)
        {
            RelaiesLicencecs relaies = new RelaiesLicencecs();
            relaies.ShowDialog();
            _RefreshDetainList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reliseDetainedLicensesToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LicenceID = (int)DGVDetaindList.CurrentRow.Cells[1].Value;

            bool ISdetained = DetainedLicenses.isDetained(LicenceID);
            reliseDetainedLicensesToolStripMenuItem.Enabled = ISdetained;


        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string query = $"{cbFilterUser.Text} = {tbFilter.Text} ";
            string query2 = $"{cbFilterUser.Text} Like '{tbFilter.Text}%' ";

            if (tbFilter.Text == "")
            {

                DGVDetaindList.DataSource = _dtDetainedLicenses;


                _dtDetainedLicenses.DefaultView.RowFilter = "";
            

                return;
            }

            if (cbFilterUser.Text == "DetainID")
            {
                DGVDetaindList.DataSource = _dtDetainedLicenses;


                _dtDetainedLicenses.DefaultView.RowFilter = query;
 
            }
            else
            {

                if (cbFilterUser.Text == "ReleaseApplicationID")
                {
                    DGVDetaindList.DataSource = _dtDetainedLicenses;


                    _dtDetainedLicenses.DefaultView.RowFilter = query;
                    return;
                }

                DGVDetaindList.DataSource = _dtDetainedLicenses;


                _dtDetainedLicenses.DefaultView.RowFilter = query2;
 
            }

        }

        private void cbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterUser.Text == "IsReleased")
            {
                tbFilter.Visible = false;
                cbISactive.Visible = true;
                cbISactive.Enabled=true;
                cbISactive.Focus();
               cbISactive.SelectedIndex = 0;
                DGVDetaindList.DataSource = _dtDetainedLicenses;

            }

            else

            {

               tbFilter.Visible = (cbFilterUser.Text != "None");
                cbISactive.Visible = false;

                if (cbFilterUser.Text == "None")
                {
                     tbFilter.Enabled = false;
                    cbISactive.Enabled = false;
                    //_dtAllUsers.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
                    DGVDetaindList.DataSource = _dtDetainedLicenses;

                }
                else
                   tbFilter.Enabled = true;
                DGVDetaindList.DataSource = _dtDetainedLicenses;

                tbFilter.Text = "";
                tbFilter.Focus();
            }


        }

        private void cbISactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cbISactive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtDetainedLicenses.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
             _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, FilterValue);

            label2.Text = DGVDetaindList.Rows.Count.ToString();

        }
    }
}
