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
          
          int _PersonID=-1;
        clsPerson _Person;
         public Licence_History(int PersonID)

        {

            InitializeComponent();
            _PersonID =PersonID;
        }
        public Licence_History()
        {
            InitializeComponent();
        }
         
            private void Licence_History_Load(object sender, EventArgs e)
        {

         if (_PersonID!=-1)
            {

                ctrlShowCard1.ShowCard(_PersonID);
                filter1.Enabled = false;
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
            
            
            
            
            }
         else
            {

                filter1.Enabled = true;
                filter1.Focus();

            }



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

        private void ctrlDriverLicense1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlShowCard1_OnLicenceSelected(object sender, int e)
        {
            if (_PersonID ==-1)
            {

                ctrlDriverLicense1.Clear();
            }
            else
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);

        }
    }
}
