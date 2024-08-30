using IS.Domain.Interfaces.Repositories;
using IS.Infrastructure.Databases.Contexts;
using IS.Infrastructure.Databases.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.Infrastructure.Extensions;

public static class ServiceExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Databases
        services.AddDbContext<ISDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MigrationDb")));
        
        // Repositories
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    }
}