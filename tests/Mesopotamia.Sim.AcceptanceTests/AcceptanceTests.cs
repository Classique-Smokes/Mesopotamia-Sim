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
        List<string> failures = [];
        foreach (Scenario scenario in Scenarios.All())
        {
            bool passed = true;
            try { scenario.Run(); }
            catch (Exception error) { passed = false; failures.Add($"{scenario.Name}: {error}"); }
            foreach (string id in scenario.Ids)
            {
                if (results.TryGetValue(id, out var previous))
                    results[id] = (previous.Passed && passed, [.. previous.References, scenario.Name]);
                else results[id] = (passed, [scenario.Name]);
            }
        }
        AcceptanceCatalog.Write(rows, results);
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.AreEqual(128, rows.Count(r => r.Classification == "REQUIRED"));
    }
}
