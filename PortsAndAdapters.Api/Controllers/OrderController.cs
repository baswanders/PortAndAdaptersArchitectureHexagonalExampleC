using Microsoft.AspNetCore.Mvc;
using PortsAndAdapters.Application.Model;
using PortsAndAdapters.Application.PortsPrimary;

namespace PortsAndAdapters.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> PlaceOrderAsync(Order order)
    {
        await _orderService.PlaceOrderAsync(order);
        return Ok();
    }

    [HttpGet("{orderId}")]
    public async Task<IActionResult> GetOrderAsync(int orderId)
    {
        var order = await _orderService.GetOrderAsync(orderId);
        if (order is null)
        {
            return NotFound();
        }
        return Ok(order);
    }
    
}