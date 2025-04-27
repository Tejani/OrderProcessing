namespace OrderProcessing.Services;

public class InMemoryEventPublisher : IEventPublisher
{
    private readonly ILogger<InMemoryEventPublisher> _logger;
    public InMemoryEventPublisher(ILogger<InMemoryEventPublisher> logger)
    {
        _logger = logger;
    }
    public void PublishOrderConfirmed(int orderId)
    {
        _logger.LogInformation($"[Event Published] Order {orderId} confirmed!");
    }
}
