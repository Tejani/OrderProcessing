namespace OrderProcessing.Services;

public interface IEventPublisher
{
    void PublishOrderConfirmed(int orderId);
}
