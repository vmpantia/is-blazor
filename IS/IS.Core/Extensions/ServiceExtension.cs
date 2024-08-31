using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace IS.Core.Extensions;

public static class ServiceExtension
{
    public static void AddCore(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}