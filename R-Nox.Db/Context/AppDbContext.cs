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
        builder.HasPostgresExtension("uuid-ossp");
        
        builder.Entity<AssemblyEntity>()
            .Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()")
            .IsRequired();
        
        builder.Entity<ModuleEntity>()
            .Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()")
            .IsRequired(); 
        
        builder.Entity<TelemetryEntity>()
            .Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("uuid")
            .HasDefaultValueSql("uuid_generate_v4()")
            .IsRequired();
        
        base.OnModelCreating(builder);
    }
}