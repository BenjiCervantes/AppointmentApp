using AppointmentApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentApp.Persistence.Configuration
{
    public class AppointmentConfiguration
    {
        public AppointmentConfiguration(EntityTypeBuilder<AppointmentEntity> builder)
        {
            builder.HasKey(a => a.AppointmentId);
            builder.Property(a => a.AppointmentType);
            builder.Property(a => a.Attended);
            builder.Property(a => a.AppointmentTitle);
            builder.Property(a => a.AppointmentDate);
            builder.Property(a => a.AppointmentDescription);
            builder.Property(a => a.UserId);
            builder.Property(a => a.PatientId);
            builder.HasOne(a => a.User).WithMany(u => u.Appointment).HasForeignKey(u => u.UserId);
            builder.HasOne(a => a.Patient).WithMany(u => u.Appointment).HasForeignKey(u => u.PatientId);
        }
    }
}
