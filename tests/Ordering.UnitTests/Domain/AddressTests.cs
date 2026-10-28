namespace eShop.Ordering.UnitTests.Domain;

using eShop.Ordering.Domain.AggregatesModel.OrderAggregate;

[TestClass]
public class AddressTests
{
    [TestMethod]
    public void ToSingleLine_JoinsAllParts()
    {
        var address = new Address("1 Main St", "Springfield", "IL", "USA", "62701");

        Assert.AreEqual("1 Main St, Springfield, IL, USA, 62701", address.ToSingleLine());
    }

    [TestMethod]
    public void ToSingleLine_SkipsMissingParts()
    {
        var address = new Address("1 Main St", "Springfield", null, "USA", " ");

        Assert.AreEqual("1 Main St, Springfield, USA", address.ToSingleLine());
    }

    [TestMethod]
    public void ToSingleLine_IsEmptyForDefaultAddress()
    {
        Assert.AreEqual(string.Empty, new Address().ToSingleLine());
    }
}
