using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsSecondary;

namespace PortsAndAdapters.Infrastructure.Repositories;

public class OracleOrderRepository : IOrderRepository
{
    public Task AddOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<Order?> GetOrderAsync(int orderId)
    {
        throw new NotImplementedException();
    }
}