using PortsAndAdapters.Application.Model;

namespace PortsAndAdapters.Application.PortsSecondary;

public interface IOrderRepository
{
    Task AddOrderAsync(Order order);
    Task<Order?> GetOrderAsync(int orderId);
}