namespace eShop.Ordering.UnitTests.Domain;

[TestClass]
public class FreeShippingTests
{
    [TestMethod]
    public void Large_order_qualifies_for_free_shipping()
    {
        var order = new OrderBuilder(new AddressBuilder().Build())
            .AddOne(1, "cup", 150.0m, 0, string.Empty)
            .Build();

        Assert.IsTrue(order.QualifiesForFreeShipping());
    }

    [TestMethod]
    public void Small_order_does_not_qualify_for_free_shipping()
    {
        var order = new OrderBuilder(new AddressBuilder().Build())
            .AddOne(1, "cup", 50.0m, 0, string.Empty)
            .Build();

        Assert.IsFalse(order.QualifiesForFreeShipping());
    }
}
