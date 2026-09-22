using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.Tests;

[TestClass]
public sealed class ToolingSmokeTests
{
    [TestMethod]
    public void TestPlatformExecutesOnAcceptedRuntime()
    {
        Assert.IsGreaterThanOrEqualTo(10, Environment.Version.Major);
    }
}
