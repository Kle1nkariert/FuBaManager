using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuBaManager
{
    public partial class MainMenue : UserControl
    {
        internal Zentrale zentrale;

        public MainMenue()
        {
            InitializeComponent();
        }

        private void NeuesSpiel_Click(object sender, EventArgs e)
        {

        }
        private void NeuesSpiel_Click_1(object sender, EventArgs e)
        {

        }

        private void MainMenue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            zentrale.Show();
        }
    }
}
