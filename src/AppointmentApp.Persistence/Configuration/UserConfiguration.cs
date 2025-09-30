using AppointmentApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppointmentApp.Persistence.Configuration
{
    public class UserConfiguration
    {
        public UserConfiguration(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(u => u.UserId);
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.UserName).IsRequired();
            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.UserType).IsRequired();
            builder.HasMany(u => u.Appointment).WithOne(a => a.User).HasForeignKey(u => u.UserId);
        }
    }
}
