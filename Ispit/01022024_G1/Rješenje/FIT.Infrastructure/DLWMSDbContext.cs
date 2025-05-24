using FIT.Data;
using FIT.Data.IspitIB220035;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<SemestriIB220035> Semestri { get; set; }
        public DbSet<PredmetiIB220035> Predmeti { get; set; }
        public DbSet<PolozeniPredmetiIB220035> PolozeniPredmeti { get; set; }
        public DbSet<DrzaveIB220035> DrzaveIB220035 { get; set; }
        public DbSet<GradoviIB220035> GradoviIB220035 { get; set; }

    }
}