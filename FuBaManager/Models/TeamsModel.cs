namespace FuBaManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TeamsModel : DbContext
    {
   
        // Der Kontext wurde für die Verwendung einer TeamsModel-Verbindungszeichenfolge aus der 
        // Konfigurationsdatei ('App.config' oder 'Web.config') der Anwendung konfiguriert. Diese Verbindungszeichenfolge hat standardmäßig die 
        // Datenbank 'FuBaManager.Models.TeamsModel' auf der LocalDb-Instanz als Ziel. 
        // 
        // Wenn Sie eine andere Datenbank und/oder einen anderen Anbieter als Ziel verwenden möchten, ändern Sie die TeamsModel-Zeichenfolge 
        // in der Anwendungskonfigurationsdatei.
        public TeamsModel()
            : base("name=Teams")
        {
        }

        // Fügen Sie ein 'DbSet' für jeden Entitätstyp hinzu, den Sie in das Modell einschließen möchten. Weitere Informationen 
        // zum Konfigurieren und Verwenden eines Code First-Modells finden Sie unter 'http://go.microsoft.com/fwlink/?LinkId=390109'.

        public virtual DbSet<Team> Teams { get; set; }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Me { get; set; }
        public int LigaId { get; set; }
    }
}