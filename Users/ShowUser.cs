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


        public static DataTable _dtAllUsers = User.GetAllUser();
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
            _dtAllUsers = User.GetAllUser();
            DGVUser.DataSource=_dtAllUsers;
        

            lbCountRecords.Text=DGVUser.RowCount.ToString();
            cbFilterUser.SelectedIndex = 0;

            cbISactive.Visible = false;
            if (DGVUser.Rows.Count > 0)
            {
                DGVUser.Columns[0].HeaderText = "User ID";
                DGVUser.Columns[0].Width = 110;

                DGVUser.Columns[1].HeaderText = "Person ID";
                DGVUser.Columns[1].Width = 120;

                DGVUser.Columns[2].HeaderText = "Full Name";
                DGVUser.Columns[2].Width = 350;

                DGVUser.Columns[3].HeaderText = "UserName";
                DGVUser.Columns[3].Width = 120;

                DGVUser.Columns[4].HeaderText = "Is Active";
                DGVUser.Columns[4].Width = 120;
            }
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
                DGVUser.DataSource = _dtAllUsers;

                cbISactive.Visible = true;
                tbFilter.Visible = false;
            }
           
            if (tbFilter.Text == "")
            {

                DGVUser.DataSource = _dtAllUsers;

                _dtAllUsers.DefaultView.RowFilter = "";

                return;
            }

            if (cbFilterUser.Text == "PersonID"||cbFilterUser.Text== "UserID")

            {
                DGVUser.DataSource = _dtAllUsers;

                _dtAllUsers.DefaultView.RowFilter = query;

                return;
            }
            else
            {   
                DGVUser.DataSource = _dtAllUsers;

                _dtAllUsers.DefaultView.RowFilter = query2;

                return;
            }
            
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUser.Text == "UserID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                {

                    e.Handled = true;

                    MessageBox.Show("Error, A User ID  number can't contain a Letter ");

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
            ShowUser_Load(null, null);
            //MessageBox.Show(" This Option Not Active Yet ");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + DGVUser.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (User.DeletetUser((int)DGVUser.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully");
                    ShowUser_Load(null, null);
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
                DGVUser.DataSource = _dtAllUsers;

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
                    DGVUser     .DataSource = _dtAllUsers;

                }
                else
                    tbFilter.Enabled = true;
                DGVUser.DataSource = _dtAllUsers;

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
 
                DGVUser.DataSource = _dtAllUsers;

 
            else
           

            _dtAllUsers.DefaultView.RowFilter = string.Format("{0} = {1}", cbFilterUser.Text, FilterValue);
            DGVUser.DataSource = _dtAllUsers    ;

        }

        private void PBImageADD_Click(object sender, EventArgs e)
        {
            AddnewUser addnewUser = new AddnewUser();
            addnewUser.ShowDialog();
            _RefreshUserList();
        }
    }
}
