namespace eShop.Ordering.API.Application.IntegrationEvents.Events;

public record OrderStatusChangedToPaidIntegrationEvent : IntegrationEvent
{
    public int OrderId { get; }
    public OrderStatus OrderStatus { get; }
    public string CustomerName { get; }
    public string BuyerIdentityGuid { get; }
    public IEnumerable<OrderStockItem> OrderStockItems { get; }

    public OrderStatusChangedToPaidIntegrationEvent(int orderId,
        OrderStatus orderStatus, string buyerName, string buyerIdentityGuid,
        IEnumerable<OrderStockItem> orderStockItems)
    {
        OrderId = orderId;
        OrderStockItems = orderStockItems;
        OrderStatus = orderStatus;
        CustomerName = buyerName;
        BuyerIdentityGuid = buyerIdentityGuid;
    }
}

