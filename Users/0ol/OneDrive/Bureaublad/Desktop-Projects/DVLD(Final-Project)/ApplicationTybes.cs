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
    public partial class ApplicationTybes : Form
    {
       

        public ApplicationTybes()
        {
            InitializeComponent();
        }

        private void ApplicationTybes_Load(object sender, EventArgs e)
        {
            DGVApplicationtyebes.DataSource = Applicationstype.GetAllApplicationtype();
            lbCount.Text = DGVApplicationtyebes.RowCount.ToString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editApplicationTyebsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditApplication editApplication = new EditApplication((int) DGVApplicationtyebes.CurrentRow.Cells[0].Value);
        
        editApplication.ShowDialog();
        
        }
    }
}
