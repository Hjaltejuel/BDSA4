using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using BDSA2017.Assignment04.Entities;

namespace BDSA2017.Assignment04
{
    public class RaceContext : DbContext
    {
        public virtual DbSet<Cars> Cars{ get; set; }
        public virtual DbSet<Races> Races{ get; set; }
        public virtual DbSet<Tracks> Tracks { get; set; }
        public virtual DbSet<CarInRaces> CarInRaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SlotCarRace;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarInRaces>().HasKey(t => new { t.RaceId, t.CarId });
        }
    }
}
