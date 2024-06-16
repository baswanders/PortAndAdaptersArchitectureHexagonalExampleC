using PortsAndAdapters.Application.ApplicationCore;
using PortsAndAdapters.Application.PortsPrimary;
using PortsAndAdapters.Application.PortsSecondary;
using PortsAndAdapters.Infrastructure.Repositories;

namespace PortsAndAdapters.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddScoped<IOrderRepository, InMemoryOrderRepository>();
        services.AddScoped<IOrderService, OrderService>();

        return services;
    }
}