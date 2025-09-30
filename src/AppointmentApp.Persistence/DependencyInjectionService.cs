using AppointmentApp.Application.DataBase;
using AppointmentApp.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentApp.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppointmentContext>(options => options.UseSqlServer(configuration.GetConnectionString("AppointmentDB")));
            services.AddScoped<IAppointmentContext, AppointmentContext>();
            return services;
        }
    }
}
