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
    public partial class Mannschaft1 : UserControl
    {
        public Mannschaft1()
        {
             InitializeComponent();
            //var meinTeam= new PlayerModel.Meinteam();
            //using (var context = new PlayerModel())
            //{
            //    meinTeam = context.Myteam.Find(1);

            //}


        }
        private Player _Att;
        private Team _me;
        private BindingList<Player> _bindingList;

        protected override void OnLoad(EventArgs e)
        {

            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Mannschaft1_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            //Your code to run on load goes here 
            var teamsModel = new TeamsModel();
            teamsModel.Teams.Load();
            _me = teamsModel.Teams.Where(item => item.Me == 1).FirstOrDefault();

            var _playerModel = new PlayerModel();
            _playerModel.Players.Load();
            _bindingList = new BindingList<Player>(_playerModel.Players.Where(item => item.TeamId == _me.Id).ToList());
            //_Att=_playerModel.Players.Where(a => a.Att == 0).FirstOrDefault();
            //_bindingList.Remove(_Att);

            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.ColumnCount = 2;
            //dataGridView1.Columns[1].Name = "Nachname";
            //dataGridView1.Columns[1].DataPropertyName = "Nachname";

            this.bindingSource1.DataSource = _bindingList;
            dataGridView1.Columns[0].DataPropertyName = "Nachname";
            dataGridView1.Columns[1].DataPropertyName = "Vorname";
            dataGridView1.Columns[2].DataPropertyName = "Att";
            dataGridView1.Columns[3].DataPropertyName = "Deff";
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Left = this.Width / 2;
            this.dataGridView1.Width = this.Width / 2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
