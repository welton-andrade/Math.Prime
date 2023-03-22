namespace PrimeNumber.Tests;

[TestClass]
public class PrimeNumberTests
{
    [TestMethod]
    public void ShouldPrimeNumber()
    {
        int value = 11;
        bool result = value.isPrime();
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void ShouldNotPrimeNumber()
    {
        int value = 4;
        bool result = value.isPrime();
        Assert.IsFalse(result);
    }
}