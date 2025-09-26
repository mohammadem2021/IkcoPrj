using IKCOProject.Application.Contracts;
using IKCOProject.Persistence.Contexts;
using IKCOProject.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IKCOProject.Persistence;

public static class PersistenceServicesRegistration
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<ToDoDbContext>(options =>
        {
            options.UseSqlServer(configuration
                .GetConnectionString("ToDoCnn"));
        });
        services.AddScoped<INoteRepository, NoteRepository>();
        return services;
    }


}