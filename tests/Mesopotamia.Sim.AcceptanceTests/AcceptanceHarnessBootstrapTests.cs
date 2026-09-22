using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
public sealed class AcceptanceHarnessBootstrapTests
{
    [TestMethod]
    public void HarnessExecutesWithoutClaimingFrozenAcceptanceCoverage()
    {
        // Dispatch-scaffold smoke test only. It is intentionally not mapped to
        // any SFL-V0-S1-ACCEPTANCE-v1 AcceptanceId.
        string? assemblyName = typeof(AcceptanceHarnessBootstrapTests).Assembly.GetName().Name;

        Assert.IsNotNull(assemblyName);
        StringAssert.Contains(assemblyName, "AcceptanceTests");
    }
}
