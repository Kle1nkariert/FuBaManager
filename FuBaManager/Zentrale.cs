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
        // Zeit Verlegen -- Database?? --
        public DateTime Zeit = new DateTime(2016, 8, 1);
        DateTime Zeit_2 = new DateTime();
        DateTime Zeit_3 = new DateTime();
        DateTime Zeit_4 = new DateTime();
        DateTime Zeit_5 = new DateTime();
        DateTime Zeit_6 = new DateTime();
        DateTime Zeit_7 = new DateTime();
        public Zentrale()
        {
            InitializeComponent();
            
            
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

        private void Zentrale_Load(object sender, EventArgs e)
        {
            Zeit_tick();
        }

        private void Weiter_Click(object sender, EventArgs e)
        {
            Zeit = Zeit.AddDays(1);
            Zeit_tick();
        }
        private void Zeit_tick()
        {
            richTextBox1.Text = Zeit.ToShortDateString();

            Zeit_2 = Zeit.AddDays(1);
            richTextBox2.Text = Zeit_2.ToShortDateString();

            Zeit_3 = Zeit.AddDays(2);
            richTextBox3.Text = Zeit_3.ToShortDateString();

            Zeit_4 = Zeit.AddDays(3);
            richTextBox4.Text = Zeit_4.ToShortDateString();

            Zeit_5 = Zeit.AddDays(4);
            richTextBox5.Text = Zeit_5.ToShortDateString();

            Zeit_6 = Zeit.AddDays(5);
            richTextBox6.Text = Zeit_6.ToShortDateString();

            Zeit_7 = Zeit.AddDays(6);
            richTextBox7.Text = Zeit_7.ToShortDateString();
        }
    }
}
