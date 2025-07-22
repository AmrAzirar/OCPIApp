using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OCPIApp.Data;
using OCPIApp.Models;
using OCPIApp.Repositories;
using OCPIApp.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Ajouter des services n�cessaires � l'application
builder.Services.AddEndpointsApiExplorer();

// Ajouter les services des contr�leurs
builder.Services.AddControllers();

// Ajouter Swagger pour la documentation de l'API
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "OCPI API",
        Version = "v1",
        Description = "API pour g�rer les stations, r�servations et sessions."
    });
});

// Ajouter les services de la base de donn�es (Entity Framework Core avec PostgreSQL)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Ajouter les services de l'application (Services et Repositories)
builder.Services.AddScoped<IStationService, StationService>();
builder.Services.AddScoped<ISessionService, SessionService>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<ITariffService, TariffService>();

// Ajouter les Repositories pour les entit�s
builder.Services.AddScoped<IStationRepository, StationRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<ITariffRepository, TariffRepository>();

// Construire l'application
var app = builder.Build();

// Activer Swagger pour l'interface utilisateur si l'environnement est en d�veloppement
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "OCPI API v1");
        c.RoutePrefix = string.Empty; // Swagger UI � la racine
    });
}

// Middleware pour redirection HTTPS (si n�cessaire)
app.UseHttpsRedirection();

// Configurer les contr�leurs pour l'application
app.MapControllers();

// D�marrer l'application
app.Run();
