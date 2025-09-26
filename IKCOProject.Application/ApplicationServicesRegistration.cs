using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace IKCOProject.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        return services;
    }
}