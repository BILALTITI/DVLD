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
using Presntation_Layet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD
{
    public partial class PeopleForm : Form
    {
        private const string V = " ";

        public static DataTable dt = clsPerson.GetAllPerson();
        public PeopleForm()
        {
            InitializeComponent();
        }
        private void _RefreshPerosnList()
        {
            DGVPeople.DataSource = clsPerson.GetAllPerson();


        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTAddNewPerson_Click(object sender, EventArgs e)
        {
            Form2 Addnewpeople = new Form2(-1);
            Addnewpeople.ShowDialog();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            CBFilter.SelectedIndex = 0;

            DGVPeople.DataSource = dt;
            lbCountrecord.Text = DGVPeople.RowCount.ToString();

            _RefreshPerosnList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TSMAddNewPerson_Click(object sender, EventArgs e)
        {
            Form2 Addnewpeople = new Form2(-1);
            Addnewpeople.ShowDialog();
            _RefreshPerosnList();
        }

       
        private void TSMEdit_Click_1(object sender, EventArgs e)
        {
            Form2 frmEditORADD = new Form2((int)DGVPeople.CurrentRow.Cells[0].Value);
            frmEditORADD.ShowDialog();
            _RefreshPerosnList();  
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Person [" + DGVPeople.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                if (clsPerson.DeletetPerso((int)DGVPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully");
                    _RefreshPerosnList();
                }
                else
                    MessageBox.Show("Person  Is not Deleted");
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This Option Not Active Yet");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" This Option Not Active Yet ");

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            cardDetails cardDetails1 = new cardDetails((int)DGVPeople.CurrentRow.Cells[0].Value);
            cardDetails1.ShowDialog();
           //show showDeteils = new CtrlShowDetails((int)DGVPeople.CurrentRow.Cells[0].Value);
           // showDeteils.Show();
           // //    MessageBox.Show(" This Option Not Active Yet ");
           // //
           // //
           // //
           // //          }
        }
        private void lbCountrecord_Click(object sender, EventArgs e)
        {
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string query= $"{CBFilter.Text} = {tbFilter.Text} ";
            string query2 = $"{CBFilter.Text} Like '{tbFilter.Text}%' ";

            if (tbFilter.Text=="")
            {

                DGVPeople.DataSource = dt;
                dt.DefaultView.RowFilter = "";
                 return;
            }

            if (CBFilter.Text == "PersonID")
            {
                DGVPeople.DataSource = dt;
                dt.DefaultView.RowFilter = query;
             }
            else
           {
                DGVPeople.DataSource = dt;
                dt.DefaultView.RowFilter = query2;


           }
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (CBFilter.Text == "None")
            {
                tbFilter.Enabled = false;
                /*cbISactive.Enabled = false*/;
                //_dtDetainedLicenses.DefaultView.RowFilter = "";
                //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
                DGVPeople.DataSource = dt;

            }
            else
                tbFilter.Enabled = true;
            DGVPeople.DataSource = dt;

            tbFilter.Text = "";
            tbFilter.Focus();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CBFilter.Text == "PersonID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

                {

                    e.Handled = true;

                    MessageBox.Show("Error, A Person ID  number can't contain a Letter ");


                }

            }
        }

        private void lbRecords_Click(object sender, EventArgs e)
        {

        }
    }
}
