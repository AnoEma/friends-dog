using Application.services;
using Infra.Interface;
using Infra.Repository;

namespace Api;

public static class DependenceExtension
{
    public static void AddDependenceRepository(this IServiceCollection services)
    {
        services.AddScoped<ICustomersRepository, CustomersRepository>();
    }

    public static void AddDependenceService(this IServiceCollection services)
    {
       services.AddScoped<ICustomersApplication, CustomersApplication>();
    }
}