using DVLD__Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Mange_Drivers : Form
    {

        public static DataTable dt = Drivers.GetAllDriverData();
        public Mange_Drivers()
        {
            InitializeComponent();
        }
        public void _RefreshDriversList()
        {
            DGVDrivers.DataSource = Drivers.GetAllDriverData();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        void _LoadData()
        {
            DGVDrivers.DataSource = Drivers.GetAllDriverData();
            DGVDrivers.DataSource = dt;

            lbCountRecords.Text = DGVDrivers.RowCount.ToString();
            cbFilterUser.SelectedIndex = 0;
            cbISactive.Visible = false;
            _RefreshDriversList();
        }
        private void Mange_Drivers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void cbISactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbISactive.Text;
            DGVDrivers.DataSource = dt;

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

                dt.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                DGVDrivers.DataSource = dt;

            dt.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterColumn, FilterValue);

            lbCountRecords.Text = DGVDrivers.Rows.Count.ToString();

        }

        private void cbFilterUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterUser.Text == "IsActive")
            {
                tbFilter.Visible = false;
                cbISactive.Visible = true;
                cbISactive.Enabled = true;
                cbISactive.Focus();
                cbISactive.SelectedIndex = 0;
                DGVDrivers.DataSource = dt;

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
                    DGVDrivers.DataSource = dt;

                }
                else
                    tbFilter.Enabled = true;
                DGVDrivers.DataSource = dt;

                tbFilter.Text = "";
                tbFilter.Focus();
            }


        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string query = $"{cbFilterUser.Text} = {tbFilter.Text} ";
            string query2 = $"{cbFilterUser.Text} Like '{tbFilter.Text}%' ";

            if (tbFilter.Text == "")
            {

                DGVDrivers.DataSource = dt;

                dt.DefaultView.RowFilter = "";

                return;
            }

            if (cbFilterUser.Text == "PersonID"|| cbFilterUser.Text == "DriverID"||cbFilterUser. Text== "CreatedByUserID")
            {
                DGVDrivers.DataSource = dt;

                dt.DefaultView.RowFilter = query;

            }
            else
            {
                DGVDrivers.DataSource = dt;

                dt.DefaultView.RowFilter = query2;


            }
        }
    }
}
