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
    public partial class Filter : UserControl
    {


        public static DataTable dt = User.GetAllUser();
        public Filter()
        {
            InitializeComponent();
        }
        private bool _ShoeAddPerson = true;
        private bool ShoeAddPerson
        {
            get
            {
                return _ShoeAddPerson;


            }
            set
            {
                _ShoeAddPerson = value;
                PBAddnewPerson.Visible = _ShoeAddPerson;

            }
        }
        public bool _FilterEnabled;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value; groupBox1.Enabled = _FilterEnabled; }
        }
        public string txtSearchValue { set { tbFilter.Text = value; } }
        public int SelectIndexCombox { set { CBFilter.SelectedIndex = value; } }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            //string query = $"{CBFilter.Text} = {tbFilter.Text} ";
            //string query2 = $"{CBFilter.Text} Like '{tbFilter.Text}%' ";

            //if (tbFilter.Text == "")
            //{


            //    dt.DefaultView.RowFilter = "";

            //    return;
            //}

            //if (CBFilter.Text == "PersonID")
            //{
            //    dt.DefaultView.RowFilter = query;

            //}
            //else
            //{
            //    dt.DefaultView.RowFilter = query2;


            //}
        }

        private void CBFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (tbFilter.Text == "")
            ////{


            //    dt.DefaultView.RowFilter = "";


            //    MessageBox.Show("Message box Must contain A value");

            //    return;
            //}
            //else
            //{
              

               
            //}
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

        private void Filter_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
