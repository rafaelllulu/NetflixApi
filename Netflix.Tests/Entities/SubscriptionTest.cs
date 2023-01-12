using Netflix.Domain.Entities;

namespace Netflix.Tests;

[TestClass]
public class SubscriptionTest
{
    [TestMethod]
    public void ShouldReturnValidWhenPlaneIsValid()
    {
        var subs = new Subscription();
        Assert.IsTrue(subs.isActive());
    }
}