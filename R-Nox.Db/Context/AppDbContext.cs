using System.Reflection;
using Microsoft.EntityFrameworkCore;
using R_Nox.Db.Entities;

namespace R_Nox.Db.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<AssemblyEntity> Assemblies { get; set; }
    public DbSet<ModuleEntity> Modules { get; set; }
    public DbSet<TelemetryEntity> Telemetries { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}