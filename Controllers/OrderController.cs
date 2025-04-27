using Microsoft.AspNetCore.Mvc;
using OrderProcessing.Models;
using OrderProcessing.Services;

namespace OrderProcessing.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(Order order)
    {
        var createdOrder = await _orderService.CreateOrderAsync(order);
        return CreatedAtAction(nameof(GetOrder), new { id = createdOrder.Id }, createdOrder);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrder(int id)
    {
        var order = await _orderService.GetOrderAsync(id);
        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }
}
