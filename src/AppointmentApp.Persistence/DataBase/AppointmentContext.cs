using AppointmentApp.Application.DataBase;
using AppointmentApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApp.Persistence.DataBase
{
    public class AppointmentContext(DbContextOptions options) : DbContext(options), IAppointmentContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PatientEntity> Patients { get; set; }
        public DbSet<AppointmentEntity> Appointments { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("User");
            modelBuilder.Entity<PatientEntity>().ToTable("Patient");
            modelBuilder.Entity<AppointmentEntity>().ToTable("Appointment");
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new UserConfiguration(modelBuilder.Entity<UserEntity>());
            new PatientConfiguration(modelBuilder.Entity<PatientEntity>());
            new AppointmentConfiguration(modelBuilder.Entity<AppointmentEntity>());
        }
    }
}
