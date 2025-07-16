using Microsoft.EntityFrameworkCore;
using OCPIApp.Models;

namespace OCPIApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Station> Stations => Set<Station>();
    public DbSet<Session> Sessions => Set<Session>();
    public DbSet<Reservation> Reservations => Set<Reservation>();
    public DbSet<Tariff> Tariffs => Set<Tariff>();
}
