using PortsAndAdapters.Application.Model;

namespace PortsAndAdapters.Application.PortsPrimary;

public interface IOrderService
{
    Task PlaceOrderAsync(Order order);
    
    Task<Order?> GetOrderAsync(int orderId);
}