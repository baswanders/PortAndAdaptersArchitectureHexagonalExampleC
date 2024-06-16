using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsPrimary;
using PortsAndAdapters.Application.PortsSecondary;

namespace PortsAndAdapters.Application.ApplicationCore;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task PlaceOrderAsync(Order order)
    {
        order.OrderDate = DateTime.UtcNow;
        await _orderRepository.AddOrderAsync(order);
    }

    public async Task<Order?> GetOrderAsync(int orderId)
    {
        return await _orderRepository.GetOrderAsync(orderId);
    }
}
