using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FuBaManager.Models
{
    public class KalenderModel : DbContext
    {
        public KalenderModel():base("name=KalenderModel")
        {
            Database.SetInitializer<KalenderModel>(null);
        }
        public virtual DbSet<Datum> Kalender{ get; set; }
    }

    [Table("Kalender")]
    public class Datum
    {
        [Key] public string Date { get; set; }
        public string Termin { get; set; }
    }
}
