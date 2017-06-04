using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuBaManager.Models;
using System.Data.Entity;

namespace FuBaManager
{
    public partial class Zentrale : UserControl
    {

        public Mannschaft1 mannschaft1 { get; internal set; }

        public Zentrale()
        {
            InitializeComponent();
            //this.dataGridView1.AutoGenerateColumns = true;

            //_teamsModel = new TeamsModel();
            //_teamsModel.Teams.Load();

            //this.bindingSource1.DataSource = _teamsModel.Teams.Local.ToBindingList();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            mannschaft1.Show();
        }
    }
}
