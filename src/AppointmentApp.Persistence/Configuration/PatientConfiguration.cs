using AppointmentApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentApp.Persistence.Configuration
{
    public class PatientConfiguration
    {
        public PatientConfiguration(EntityTypeBuilder<PatientEntity> builder)
        {
            builder.HasKey(p => p.PatientId);
            builder.Property(p => p.PatientName);
            builder.Property(p => p.PatientDescription);
            builder.Property(p => p.PhoneNumber);
            builder.Property(p => p.Email);
            builder.HasMany(p => p.Appointment).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
        }
    }
}
