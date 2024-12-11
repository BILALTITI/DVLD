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

namespace DVLD
{
    public partial class Licence_History : Form
    {

        public static DataTable dt = LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications();
        int _PersonID;
        clsPerson _Person;
  public static    DataTable dt2 = InternationalLicenses.GetAlInternationalLicence();
         
        //int _LocalDrivingLicenseApplicationsID;
        //LocalDrivingLicenseApplications _LocalDrivingLicenseApplications;
        public Licence_History(int PersonID)

        {

            InitializeComponent();
            _PersonID = PersonID;
            //_LocalDrivingLicenseApplicationsID = localDrivingLicenseApplicationsID;
        }
        public Licence_History()
        {
            InitializeComponent();
        }

        private void Licence_History_Load(object sender, EventArgs e)
        {
          dt   = License.License.GetAlLLicenseByPersonID(_PersonID);
            dt2 = License.License.GetInternationalLicencebyPersonID(_PersonID);
            if (_PersonID != -1)
            {
                filter1.txtSearchValue = _PersonID.ToString();
                filter1.FilterEnabled = false;
                filter1.SelectIndexCombox = 4;
                ctrlShowCard1.ShowCard(_PersonID);
            }
            else
            {
                filter1.Enabled = true;
            }
            dataGridView1.DataSource = License.License.GetAlLLicenseByPersonID(_PersonID);
            dataGridView2.DataSource = License.License.GetInternationalLicencebyPersonID(_PersonID);
            lbCountRecords.Text= dataGridView1.RowCount.ToString();
            lbCountRecords.Text=dataGridView2.RowCount.ToString();
            //dataGridView1.DataSource =LocalDrivingLicenseApplications.GetAlLocalDrivingLicenseApplications ();
            //dataGridView2.DataSource=InternationalLicenses.GetAllInternationalLicenses();
        }

        private void ctrlShowCard1_Load(object sender, EventArgs e)
        {
            //ctrlShowCard1.ShowCard(_PersonID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filter1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
