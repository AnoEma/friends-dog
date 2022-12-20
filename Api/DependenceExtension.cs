using Application.services;

namespace Api;

public static class DependenceExtension
{
    public static void AddDependenceRepository(this IServiceCollection services)
    {

    }

    public static void AddDependenceService(this IServiceCollection services)
    {
       services.AddScoped<ICustomersApplication, CustomersApplication>();
    }
}