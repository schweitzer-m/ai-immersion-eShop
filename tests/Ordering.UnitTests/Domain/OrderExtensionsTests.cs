namespace eShop.Ordering.UnitTests.Domain;

using eShop.Ordering.Domain.AggregatesModel.OrderAggregate;

[TestClass]
public class OrderExtensionsTests
{
    [TestMethod]
    public void ContainsProduct_Works()
    {
        var order = new OrderBuilder(new AddressBuilder().Build())
            .AddOne(1, "cup", 10.0m, 0, string.Empty)
            .Build();

        var result = order.ContainsProduct(1);
    }

    [TestMethod]
    public void ContainsProduct_Runs()
    {
        var order = new OrderBuilder(new AddressBuilder().Build()).Build();
        order.ContainsProduct(1);
    }
}
