
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace R_Nox.Services.Dependencies;

public static class DependencyExtension
{
    public static void RegisterCqrsMediator(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}