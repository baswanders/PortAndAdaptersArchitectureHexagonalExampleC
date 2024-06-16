using Microsoft.Extensions.Caching.Memory;
using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsSecondary;

namespace PortsAndAdapters.Infrastructure.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private readonly IMemoryCache _cache;

        public InMemoryOrderRepository(IMemoryCache cache)
        {
            _cache = cache;
        }

        public Task AddOrderAsync(Order order)
        {
            _cache.Set(order.Id, order);
            return Task.CompletedTask;
        }

        public Task<Order?> GetOrderAsync(int orderId)
        {
            _cache.TryGetValue(orderId, out Order? order);
            return Task.FromResult(order);
        }
    }
}