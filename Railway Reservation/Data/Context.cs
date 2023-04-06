using Microsoft.EntityFrameworkCore;
using Railway_Reservation.Models;
using System;

namespace Railway_Reservation.Data
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }

        
        public DbSet<User> Users { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Fare> Fares { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationDatails> ReservationDatails { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TrainDetail>()
        //        .HasIndex(p => new { p.TrainNo })
        //        .IsUnique(true);
        //}
    }
}
