using OrderProcessing.Models;

namespace OrderProcessing.Services;

public interface IOrderService
{
    Task<Order> CreateOrderAsync(Order order);
    Task<Order> GetOrderAsync(int id);
}
