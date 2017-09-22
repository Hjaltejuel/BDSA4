using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;

namespace BDSA2017.Assignment04.Entities

{
    public class SlotCarContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<CarInRace> CarInRaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.useSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SlotCar;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(entity=>
            {
             
            })
              
        }
    }
}
