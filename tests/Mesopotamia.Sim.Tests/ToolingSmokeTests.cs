using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.Tests;

[TestClass]
public sealed class ToolingSmokeTests
{
    [TestMethod]
    public void TestPlatformExecutes()
    {
        Assert.AreEqual(4, 2 + 2);
    }
}
