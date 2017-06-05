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
            PerformAutoScale();
            //var meinTeam= new PlayerModel.Meinteam();
            //using (var context = new PlayerModel())
            //{
            //    meinTeam = context.Myteam.Find(1);

            //}


        }

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

            this.bindingSource1.DataSource = _bindingList;

            dataGridView1.AutoGenerateColumns = true;

        }
    }
}
