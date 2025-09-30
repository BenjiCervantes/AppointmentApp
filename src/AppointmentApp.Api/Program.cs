using AppointmentApp.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Para hacer uso de DataBaseFirst:
//1. Crear entidades 
//2. Crear Context
//3. Agregar la cadena de conexión en Appsettings.Json
//4. Inyectar la cadena de conexión en el context
//5. Crear el Scope con el context
//6. Agregar la migración al context
//7. En la consola del administrador de paquetes ejecutar el comando Add-Migration InitDB
//8. Ejecutar el proyecto api

builder.Services.AddDbContext<AppointmentContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppointmentDB")));



var app = builder.Build();

// Configure the HTTP request pipeline.

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppointmentContext>();
    context.Database.Migrate();
}

app.Run();
