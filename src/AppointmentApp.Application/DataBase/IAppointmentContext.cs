using AppointmentApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApp.Application.DataBase
{
    public interface IAppointmentContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<PatientEntity> Patients { get; set; }
        DbSet<AppointmentEntity> Appointments { get; set; }
    }
}
