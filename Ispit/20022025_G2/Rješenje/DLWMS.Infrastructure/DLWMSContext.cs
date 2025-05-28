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
        public DbSet<CertifikatiIB220035> CertifikatiIB220035 { get; set; }
        public DbSet<CertifikatiGodineIB220035> CertifikatiGodineIB220035 { get; set; }
        public DbSet<StudentiCertifikatiIB220035> StudentiCertifikatiIB220035 { get; set; }

    }
}
