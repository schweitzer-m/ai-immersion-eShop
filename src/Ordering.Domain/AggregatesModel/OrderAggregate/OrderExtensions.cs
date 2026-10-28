namespace eShop.Ordering.Domain.AggregatesModel.OrderAggregate;

public static class OrderExtensions
{
    public static bool ContainsProduct(this Order order, int productId) =>
        order.OrderItems.Any(i => i.ProductId == productId);
}
