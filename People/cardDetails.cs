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
    public partial class cardDetails : Form
    {


        int _PersonID;
        clsPerson _Person;
    
        public cardDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
         

        }
        public int Personid
        {
            get { return _PersonID; }
        }
        public cardDetails()
        {
            InitializeComponent();
        }

    
        private void cardDetails_Load(object sender, EventArgs e)
        {
            ctrlShowCard1.ShowCard(_PersonID);

        }

        private void ctrlShowCard1_Load(object sender, EventArgs e)
        {
 

        }
    }
}
