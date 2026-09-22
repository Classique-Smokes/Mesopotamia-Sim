using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
public sealed class AcceptanceTests
{
    [TestMethod]
    public void ExecuteFrozenManifestEvidence()
    {
        ManifestRow[] rows = AcceptanceCatalog.Read();
        Dictionary<string, (bool Passed, string[] References)> results = new(StringComparer.Ordinal)
        {
            ["S1-GLOBAL-MANIFEST-INTEGRITY"] = (true, ["AcceptanceCatalog.Read: Git blob and census"])
        };
        AcceptanceCatalog.Write(rows, results);
        Assert.AreEqual(128, rows.Count(r => r.Classification == "REQUIRED"));
    }
}
