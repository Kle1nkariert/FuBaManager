using FuBaManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuBaManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            


        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.mainMenue1.zentrale = this.zentrale2;
            this.zentrale2.mannschaft1 = this.mannschaft11;
            this.mannschaft11.Hide();
            zentrale2.Hide();
        

        }

        private void mainMenue1_Load(object sender, EventArgs e)
        {
           
        }
        private void zentrale1_Load(object sender, EventArgs e)
        {
            zentrale2.Hide();
        }

        private void zentrale1_Load_1(object sender, EventArgs e)
        {

        }

        private void mainMenue1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
