using DLWMS.Data;
using DLWMS.Data.IspitIB220035;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<Student> Studenti { get; set; }
        public DbSet<StipendijeIB220035> StipendijeIB220035 { get; set; }
        public DbSet<StipendijeGodineIB220035> StipendijeGodineIB220035 { get; set; }
        public DbSet<StudentiStipendijeIB220035> StudentiStipendijeIB220035 { get; set; }
    }
}
