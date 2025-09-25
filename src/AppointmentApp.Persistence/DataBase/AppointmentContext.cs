using AppointmentApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace AppointmentApp.Persistence.DataBase
{
    public class AppointmentContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PatientEntity> Patients { get; set; }
        public DbSet<AppointmentEntity> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("User");
            modelBuilder.Entity<PatientEntity>().ToTable("Patient");
            modelBuilder.Entity<AppointmentEntity>().ToTable("Appointment");
        }
    }
}
