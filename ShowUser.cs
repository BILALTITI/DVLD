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
using DVLD__Business_Layer;
using System.Collections;
using System.Reflection.Emit;


namespace DVLD
{
    public partial class ShowUser : Form
    {


        public static DataTable _dtDetainedLicenses = User.GetAllUser();
        public ShowUser()
        {
            InitializeComponent();
        }
        private void _RefreshUserList()
        {
            DGVUser.DataSource = User.GetAllUser();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowUser_Load(object sender, EventArgs e)
        {
            DGVUser.DataSource=User.GetAllUser();
            DGVUser.DataSource = _dtDetainedLicenses;

            lbCountRecords.Text=DGVUser.RowCount.ToString();
            cbFilterUser.SelectedIndex = 0;

            cbISactive.Visible = false;
            _RefreshUserList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string query = $"{cbFilterUser.Text} = {tbFilter.Text} ";
            string query2 = $"{cbFilterUser.Text} Like '{tbFilter.Text}%' ";


            if (cbFilterUser.Text == "IsActive")
            {
                DGVUser.DataSource = _dtDetainedLicenses;

                cbISactive.Visible = true;
                tbFilter.Visible = false;
            }
           
            if (tbFilter.Text == "")
            {

                DGVUser.DataSource = _dtDetainedLicenses;

                _dtDetainedLicenses.DefaultView.RowFilter = "";

                return;
            }

            if (cbFilterUser.Text == "PersonID"||cbFilterUser.Text== "UserID")

            {
                DGVUser.DataSource = _dtDetainedLicenses;

                _dtDetainedLicenses.DefaultView.RowFilter = query;

                return;
            }
            else
            {   
                DGVUser.DataSource = _dtDetainedLicenses;

                _dtDetainedLicenses.DefaultView.RowFilter = query2;

                return;
            }
            
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUser.Text == "PersonID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                {

                    e.Handled = true;

                    MessageBox.Show("Error, A Person ID  number can't contain a Letter ");

                    return;
                }

            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetails showUserDetails = new ShowUserDetails((int)DGVUser.CurrentRow.Cells[0].Value);
            showUserDetails.ShowDialog();
            //MessageBox.Show(" This Option Not Active Yet ");
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        {

            AddnewUser addnewUser = new AddnewUser();
            addnewUser.ShowDialog();
            _RefreshUserList();
            //    MessageBox.Show(" This Option Not Active Yet ");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddnewUser addnewUser = new AddnewUser((int)DGVUser.CurrentRow.Cells[0].Value);
            addnewUser.ShowDialog();
            _RefreshUserList();    

            //MessageBox.Show(" This Option Not Active Yet ");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + DGVUser.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (User.DeletetUser((int)DGVUser.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully");
                    _RefreshUserList();
                }
                else
                    MessageBox.Show("User  Is not Deleted");
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword((int )DGVUser.CurrentRow.Cells[0].Value);
            changePassword.ShowDialog();
            //MessageBox.Show(" This Option Not Active Yet ");
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" This Option Not Active Yet ");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" This Option Not Active Yet ");
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterUser.Text == "IsActive")
            {
                tbFilter.Visible = false;
                cbISactive.Visible = true;
                cbISactive.Enabled = true;
                cbISactive.Focus();
                cbISactive.SelectedIndex = 0;
                DGVUser.DataSource = _dtDetainedLicenses;

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
                    DGVUser     .DataSource = _dtDetainedLicenses;

                }
                else
                    tbFilter.Enabled = true;
                DGVUser.DataSource = _dtDetainedLicenses;

                tbFilter.Text = "";
                tbFilter.Focus();
            }

        }

        private void cbISactive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = "";

            switch (cbISactive.Text.Trim())
            {
                case "All":
                    FilterValue = "All";
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }
            if (FilterValue == "All")
 
                DGVUser.DataSource = _dtDetainedLicenses;

 
            else
           

            _dtDetainedLicenses.DefaultView.RowFilter = string.Format("{0} = {1}", cbFilterUser.Text, FilterValue);
            DGVUser.DataSource = _dtDetainedLicenses    ;

        }

        private void PBImageADD_Click(object sender, EventArgs e)
        {
            AddnewUser addnewUser = new AddnewUser();
            addnewUser.ShowDialog();
            _RefreshUserList();
        }
    }
}
