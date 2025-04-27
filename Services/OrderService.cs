using OrderProcessing.Data;
using OrderProcessing.Models;

namespace OrderProcessing.Services;

public class OrderService : IOrderService
{
    private readonly AppDbContext _context;
    private readonly IEventPublisher _eventPublisher;
    private readonly ILogger<OrderService> _logger;

    public OrderService(AppDbContext context, IEventPublisher eventPublisher, ILogger<OrderService> logger)
    {
        _context = context;
        _eventPublisher = eventPublisher;
        _logger = logger;
    }
    public async Task<Order> CreateOrderAsync(Order order)
    {
        order.Status = "Confirmed";
        order.CreatedAt = DateTime.UtcNow;

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        _eventPublisher.PublishOrderConfirmed(order.Id);

        _logger.LogInformation($"Order {order.Id} created successfully.");
        return order;
    }

    public async Task<Order> GetOrderAsync(int id)
    {
        return await _context.Orders.FindAsync(id);
    }
}
