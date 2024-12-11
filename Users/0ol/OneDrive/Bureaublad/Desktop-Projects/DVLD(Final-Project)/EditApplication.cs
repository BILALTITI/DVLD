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
    public partial class EditApplication : Form
    {

        int _ApplicationTypeID;
        Applicationstype _Applicationstype;

       
        public EditApplication(int ApplicationTypeID)
        {

             
            _ApplicationTypeID = ApplicationTypeID;
           _Applicationstype= Applicationstype.Find(ApplicationTypeID);
            InitializeComponent();
        }
        public EditApplication()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }

        private void EditApplication_Load(object sender, EventArgs e)
        {
          
            lbID2.Text = _Applicationstype.ApplicationTypeID.ToString();
            tbTitle.Text = _Applicationstype.ApplicationTypeTitle;
            tbFees.Text= _Applicationstype.ApplicationFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            tbTitle.Text=_Applicationstype.ApplicationTypeTitle;
            tbFees.Text = _Applicationstype.ApplicationFees.ToString();
            

            if (_Applicationstype.Save())

            {
                MessageBox.Show("Data Saved Successfully.");
                 
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");

        }
    }
}
