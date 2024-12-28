﻿using System;
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
using static DVLD__Business_Layer.TestTypess;


namespace DVLD
{
    public partial class TestTybe : Form
    {

         
        public TestTybe()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TestTybe_Load(object sender, EventArgs e)
        {

            DGVTestTybe.DataSource = TestTypes.GetAllTestTypes();


            lbCountRecords.Text=DGVTestTybe.RowCount.ToString();
           DGVTestTybe.Columns[0].HeaderText = "ID";
           DGVTestTybe.Columns[0].Width = 50;
            
           DGVTestTybe.Columns[1].HeaderText = "Title";
           DGVTestTybe.Columns[1].Width = 120;
            
           DGVTestTybe.Columns[2].HeaderText = "Description";
           DGVTestTybe.Columns[2].Width = 500;
            
           DGVTestTybe.Columns[3].HeaderText = "Fees";
            DGVTestTybe.Columns[3].Width = 60;
        }

        private void editTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTestTypes  editTestTypes  = new EditTestTypes((int)DGVTestTybe.CurrentRow.Cells[0].Value);
            editTestTypes.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}