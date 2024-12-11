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
    public partial class ShowManageinternationlLicence : Form
    {
        public DataTable dt = InternationalLicenses.GetAlInternationalLicence();
       License.License _license;
        public ShowManageinternationlLicence()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void _RefreshUserList()
        {
            DGVinternationalApplication.DataSource = InternationalLicenses.GetAlInternationalLicence();
        }
        private void ShowManageinternationlLicence_Load(object sender, EventArgs e)
        {
            cbFilterUser.SelectedIndex = 0;


            DGVinternationalApplication.DataSource = InternationalLicenses.GetAlInternationalLicence ();
            DGVinternationalApplication.DataSource = dt;

            lbCountRecords.Text = DGVinternationalApplication.RowCount.ToString();
            cbFilterUser.SelectedIndex = 0;
            tbFilter.Visible = false;
            cbISactive.Visible = false;
            _RefreshUserList();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InternationalLicence internationalLicence = new InternationalLicence((int)DGVinternationalApplication.CurrentRow.Cells[0].Value);
            internationalLicence.Show();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Application_Info application_Info = new Show_Application_Info((int)DGVinternationalApplication.CurrentRow.Cells[0].Value);
            application_Info.ShowDialog();

        }

        private void showLicenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int internationalLicenseApplicationID = (int)DGVinternationalApplication.CurrentRow.Cells[0].Value;
            internationalLicenceForm internationalLicenceForm = new internationalLicenceForm(internationalLicenseApplicationID);
            internationalLicenceForm.ShowDialog();
        }

        private void showPersonLicenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalApplicationID = (int)DGVinternationalApplication.CurrentRow.Cells[0].Value;

         InternationalLicenses internationalLicenses =
                InternationalLicenses.Find(InternationalApplicationID);

            Licence_History licence_History = new Licence_History(internationalLicenses.InternationalLicenseID);
            licence_History.ShowDialog();
        }

        private void cbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterUser.Text == "Status")
            {
                tbFilter.Visible = false;
                cbISactive.Visible = true;
                cbISactive.Enabled = true;
                cbISactive.Focus();
                cbISactive.SelectedIndex = 0;
                DGVinternationalApplication.DataSource = dt;

            }

            else

            {

                tbFilter.Visible = (cbFilterUser.Text != "None");
                cbISactive.Visible = false;

                if (cbFilterUser.Text == "None")
                {
                    tbFilter.Enabled = false;
                    cbISactive.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
                    DGVinternationalApplication.DataSource = dt;

                }
                else
                    tbFilter.Enabled = true;
                DGVinternationalApplication.DataSource = dt;

                tbFilter.Text = "";
                tbFilter.Focus();
            }
        }

        private void cbISactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "Status";
            string FilterValue = cbISactive.Text;
            cbISactive.Visible = true;





            if (FilterValue == "All")
                dt.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE  '{1}%'", FilterColumn, FilterValue);

            lbCountRecords.Text = DGVinternationalApplication.Rows.Count.ToString();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            string query = $"{cbFilterUser.Text} = {tbFilter.Text} ";
            string query2 = $"{cbFilterUser.Text} Like '{tbFilter.Text}%' ";

            if (tbFilter.Text == "")
            {

                DGVinternationalApplication.DataSource = dt;


                dt.DefaultView.RowFilter = "";


                return;
            }

            else
            {

                DGVinternationalApplication.DataSource = dt;


                dt.DefaultView.RowFilter = query2;

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
    
    }

