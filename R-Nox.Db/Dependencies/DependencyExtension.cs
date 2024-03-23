using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using R_Nox.Db.Context;

namespace R_Nox.Db.Dependencies;

public static class DependencyExtension
{
    public static void AddConfigDatabase(this IServiceCollection services, IConfiguration configs)
    {
        var assembly = typeof(DependencyExtension).Assembly.GetName().Name;

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configs.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly(assembly ?? "R-Nox.Db")));
    }
}