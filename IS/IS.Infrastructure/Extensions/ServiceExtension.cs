using IS.Infrastructure.Databases.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IS.Infrastructure.Extensions;

public static class ServiceExtension
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ISDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MigrationDb")));
    }
}