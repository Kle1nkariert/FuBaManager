using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuBaManager.Models
{
    using System.Data.Entity;
    public class PlayerModel : DbContext
    {

        public PlayerModel()
            : base("name=Player")
            {
            }

        public virtual DbSet<Player> Players { get; set; }
    }

    public class Player
    {
        public int TeamId { get; set; }
        public int PlayerId { get; set; }
        public int Att { get; set; }
        public int Deff { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}

