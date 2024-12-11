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
using static DVLD__Business_Layer.TestTypess;

namespace DVLD
{
    public partial class EditTestTypes : Form
    {

        int _TestTypeID;
        TestTypes _TestType;
        public EditTestTypes(int TestTypeID)
        {
            _TestTypeID = TestTypeID;
            _TestType = TestTypes.Find(TestTypeID);
            InitializeComponent();
        }
        public EditTestTypes()
        {
            InitializeComponent();
        }
        private void EditTestTypes_Load(object sender, EventArgs e)
        {
            lbID2.Text = _TestType.TestTypeID.ToString();
            tbTitle.Text = _TestType.TestTypeTitle;
            tbFees.Text =_TestType.TestTypeFees.ToString();
            tbDescription.Text = _TestType.TestTypeDescription;



        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TestType.TestTypeFees= Convert.ToDecimal(tbFees.Text.Trim());
            _TestType.TestTypeDescription =Convert.ToString( tbDescription.Text);
            _TestType.TestTypeTitle =Convert.ToString( tbTitle.Text);
            if (_TestType.Save())
            {

                MessageBox.Show("Data save Succseefully");

            }
            else
            {

                MessageBox.Show("Data is not Saved ");
            }
        }
    }
}
