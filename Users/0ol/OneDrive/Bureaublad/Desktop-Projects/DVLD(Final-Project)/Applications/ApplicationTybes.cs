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
 private  DataTable _dt = Applicationstype.GetAllApplicationtype();

        public ApplicationTybes()
        {
            InitializeComponent();
        }

        private void ApplicationTybes_Load(object sender, EventArgs e)
        {

         _dt = Applicationstype.GetAllApplicationtype();
            DGVApplicationtyebes.DataSource = _dt;
            lbCount.Text = DGVApplicationtyebes.RowCount.ToString();

           DGVApplicationtyebes.Columns[0].HeaderText = "ID";
           DGVApplicationtyebes.Columns[0].Width = 60;
            DGVApplicationtyebes.Columns[1].HeaderText = "Title";
           DGVApplicationtyebes.Columns[1].Width = 230;
            
           DGVApplicationtyebes.Columns[2].HeaderText = "Fees";
            DGVApplicationtyebes.Columns[2].Width = 75;
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
