﻿using DLWMS.Data;
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
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Spol> SpolIB220035 { get; set; }
        public DbSet<UniverzitetiIB220035> UniverzitetiIB220035 { get; set; }
        public DbSet<RazmjeneIB220035> RazmjeneIB220035 { get; set; }
    }
}
