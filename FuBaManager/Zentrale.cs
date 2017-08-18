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
        public DateTime Zeit = new DateTime(2017, 12, 1);
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
            Zeit_refresh();
        }

        private void Weiter_Click(object sender, EventArgs e)
        {
            Zeit = Zeit.AddDays(1);
            Zeit_refresh();
            Termin_Text(Zeit);
            if (Zeit_2.Year != Zeit.Year)
            {
                Jahresrechner(Zeit_2);
            }
        }
        private void Jahresrechner(DateTime a)
        {
            DateTime b = a;
            int Add_days = 7;
            int Remove_days;
            int Nummer = 1;
            bool Schaltjahr = DateTime.IsLeapYear(b.Year);
            //create DBContext object
            using (var dbCtx = new KalenderModel())
            {
                

                if (b.DayOfWeek.ToString() == "Monday")
                {
                    Remove_days = 1;
                }
                if (b.DayOfWeek.ToString() == "Tuesday")
                {
                    Remove_days = 2;
                }
                if (b.DayOfWeek.ToString() == "Wednesday")
                {
                    Remove_days = 3;
                }
                if (b.DayOfWeek.ToString() == "Thursday")
                {
                    Remove_days = 4;
                }
                if (b.DayOfWeek.ToString() == "Friday")
                {
                    Remove_days = 5;
                }
                if (b.DayOfWeek.ToString() == "Saturday")
                {
                    Remove_days = 6;
                }
                else
                {
                    Remove_days = 7;
                }

                dbCtx.Database.ExecuteSqlCommand("delete from Kalender");
                while (b.Year == a.Year)
                {
                    //Add Student object into Students DBset
                    var datum = new Datum();
                    datum.Date = b.ToString("s");
                   
                    
                    if (b.DayOfWeek.ToString() == "Saturday")
                    {
                        if (Schaltjahr == false)
                        {
                            if (b.DayOfYear > Add_days)
                            {
                                if (b.DayOfYear <= 151)
                                {
                                    datum.Termin = "Deutsche Liga Spiltag "+ Nummer;
                                    Nummer++;
                                }
                            }
                            if (b.DayOfYear <= 364-(7 + Remove_days))
                            {
                                if (b.DayOfYear >= 256)
                                {
                                    datum.Termin = "Deutsche Liga Spiltag " + Nummer;
                                    Nummer++;
                                }
                            }
                        }
                        if (Schaltjahr == true)
                        {
                            if (b.DayOfYear > Add_days)
                            {
                                if (b.DayOfYear <= 152)
                                {
                                    datum.Termin = "Deutsche Liga Spiltag " + Nummer;
                                    Nummer++;
                                }
                            }
                            if (b.DayOfYear <= 365 - (7 + Remove_days))
                            {
                                if (b.DayOfYear >= 257)
                                {
                                    datum.Termin = "Deutsche Liga Spiltag " + Nummer;
                                    Nummer++;
                                }
                            }
                        }
                    }
                    // call SaveChanges method to save student into database
                    b = b.AddDays(1);
                    dbCtx.Kalender.Add(datum);
                }
            dbCtx.SaveChanges();
            }
        }
        private Datum Termin;
        private void Termin_Text( DateTime Tag)
        {
            string _Tag = Tag.ToString("s");
            string _Tag2 = Tag.AddDays(1).ToString("s");
            string _Tag3 = Tag.AddDays(2).ToString("s");
            string _Tag4 = Tag.AddDays(3).ToString("s");
            string _Tag5 = Tag.AddDays(4).ToString("s");
            string _Tag6 = Tag.AddDays(5).ToString("s");
            string _Tag7 = Tag.AddDays(6).ToString("s");
            var KalenderModel = new KalenderModel();
            var Termine = KalenderModel.Kalender.Where(item => item.Termin != null);

            foreach (var termin in Termine)
            {
                Termin_refresh(termin, _Tag, _Tag2, _Tag3, _Tag4, _Tag5, _Tag6, _Tag7);
            }
        }
        private void Termin_refresh(Datum Termin, String _Tag, String _Tag2, String _Tag3, String _Tag4, String _Tag5, String _Tag6, String _Tag7)
        {
            if (_Tag == Termin.Date)
            {
                richTextBox1.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            if (_Tag2 == Termin.Date)
            {
                richTextBox2.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            if (_Tag3 == Termin.Date)
            {
                richTextBox3.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            }
            if (_Tag4 == Termin.Date)
            {
                richTextBox4.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            if (_Tag5 == Termin.Date)
            {
                richTextBox5.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            if (_Tag6 == Termin.Date)
            {
                richTextBox6.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            if (_Tag7 == Termin.Date)
            {
                richTextBox7.AppendText("\n" + Termin.Termin);
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }
        private void Zeit_refresh()
            {
                richTextBox1.Text = Zeit.DayOfWeek + "\n" + Zeit.ToShortDateString();
                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

                Zeit_2 = Zeit.AddDays(1);
                richTextBox2.Text = Zeit_2.DayOfWeek + "\n" + Zeit_2.ToShortDateString();
                richTextBox2.SelectAll();
                richTextBox2.SelectionAlignment = HorizontalAlignment.Center;

                Zeit_3 = Zeit.AddDays(2);
                richTextBox3.Text = Zeit_3.DayOfWeek + "\n" + Zeit_3.ToShortDateString();
                richTextBox3.SelectAll();
                richTextBox3.SelectionAlignment = HorizontalAlignment.Center;

                Zeit_4 = Zeit.AddDays(3);
                richTextBox4.Text = Zeit_4.DayOfWeek + "\n" + Zeit_4.ToShortDateString();
                richTextBox4.SelectAll();
                richTextBox4.SelectionAlignment = HorizontalAlignment.Center;

                Zeit_5 = Zeit.AddDays(4);
                richTextBox5.Text = Zeit_5.DayOfWeek + "\n" + Zeit_5.ToShortDateString();
                richTextBox5.SelectAll();
                richTextBox5.SelectionAlignment = HorizontalAlignment.Center;

                Zeit_6 = Zeit.AddDays(5);
                richTextBox6.Text = Zeit_6.DayOfWeek + "\n" + Zeit_6.ToShortDateString();
                richTextBox6.SelectAll();
                richTextBox6.SelectionAlignment = HorizontalAlignment.Center;

                Zeit_7 = Zeit.AddDays(6);
                richTextBox7.Text = Zeit_7.DayOfWeek + "\n" + Zeit_7.ToShortDateString();
                richTextBox7.SelectAll();
                richTextBox7.SelectionAlignment = HorizontalAlignment.Center;
            }
        
    }
}