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
        List<object> caseEvidence = [];
        Scenarios suite = new();
        Scenario[] scenarios = suite.All().ToArray();
        Assert.AreEqual(scenarios.Length, scenarios.Select(s => s.Name).Distinct(StringComparer.Ordinal).Count());
        foreach (Scenario scenario in scenarios)
        {
            bool passed = true;
            string? diagnostic = null;
            suite.BeginCase();
            try { scenario.Run(); suite.AuditCase(scenario.Name); }
            catch (Exception error) { passed = false; diagnostic = error.ToString(); failures.Add($"{scenario.Name}: {error}"); }
            caseEvidence.Add(new
            {
                scenario.Name,
                scenario.Ids,
                State = passed ? "PASS" : "FAIL",
                Failure = diagnostic,
                scenario.FixtureWrites,
                scenario.Oracle,
                SourceClauses = scenario.Ids.Select(id => rows.Single(r => r.Id == id).SourceRow),
                EvidenceCategories = scenario.Ids.Select(id => id.StartsWith("S1-META-", StringComparison.Ordinal) ? "metamorphic pair" :
                    id.StartsWith("S1-MUT-", StringComparison.Ordinal) ? "focused fault control" : id.StartsWith("S1-BND-", StringComparison.Ordinal) || id.StartsWith("S1-D4-", StringComparison.Ordinal) ? "boundary matrix" : "canonical card").Distinct(),
                ProfilesAndExactFixtureWrites = "fixture-audit.json: matching Scenario and Subcase",
                InvariantChecker = "InvariantOracle.cs: independent material, attitude, residence, relation, causal and score replay"
            });
            foreach (string id in scenario.Ids)
            {
                if (results.TryGetValue(id, out var previous))
                    results[id] = (previous.Passed && passed, [.. previous.References, scenario.Name]);
                else results[id] = (passed, [scenario.Name]);
            }
        }
        bool auditPassed = failures.Count == 0 && suite.FixtureEvidence.Count >= scenarios.Length;
        results["S1-GLOBAL-FIXTURE"] = (auditPassed, ["fixture-audit.json: exact initial fields/inputs, endogenous provenance, profiles and proposal terms for every subcase"]);
        string oracleSource = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "tests/Mesopotamia.Sim.AcceptanceTests/InvariantOracle.cs"));
        string[] forbidden = ["ActionRules.", "ReferenceScorer.", "PersonalAgency.", ".RunCycle(", ".RunAutonomousCycle(", "WorldState", ".Infeasible(", ".Commit(",
            "ResolutionFallbacks(", "EvaluateTransaction(", "FutureInputsResolveMaterialBlock(", "ApplyGrainInput(", "ConsumeGrain("];
        bool independent = forbidden.All(token => !oracleSource.Contains(token, StringComparison.Ordinal));
        results["S1-GLOBAL-ORACLE"] = (independent && auditPassed, ["oracle-audit.json", "InvariantOracle.cs and explicit expected arithmetic in scenario source"]);
        AcceptanceCatalog.WriteSupplement("oracle-audit", new
        {
            State = independent && auditPassed ? "PASS" : "FAIL",
            Scope = "Coder-owned checker dependency audit; not independent post-implementation conformance",
            Checker = "tests/Mesopotamia.Sim.AcceptanceTests/InvariantOracle.cs",
            ForbiddenCalls = forbidden,
            Permitted = new[] { "Immutable ID/state/event schemas", "MSTest assertions", "LINQ enumeration", "Checked arithmetic and explicit constants" },
            ScenarioOracle = "Hand-authored values in *Scenarios.cs; production entry used only as target; state query answers also verified by raw-dictionary ledger replay",
            CallFavorOracle = "Explicit two callable / eleven non-callable list transcribed from frozen manifest; no production applicability classifier calls",
            Adequacy = "Corrupted material/attitude witnesses and coherently omitted mandatory causes raise semantic assertion failures; actual duplicate and closure injections exercise production guards"
        });
        bool coverage = rows.Where(r => r.Classification == "REQUIRED" && r.Id is not ("S1-GLOBAL-REQUIRED-COVERAGE" or "S1-GLOBAL-CONFORMANCE"))
            .All(r => results.TryGetValue(r.Id, out var result) && result.Passed && result.References.Length > 0);
        results["S1-GLOBAL-REQUIRED-COVERAGE"] = (coverage, ["All 173 rows individually emitted; 133 coder-owned REQUIRED must pass; REQUIRED external conformance explicitly awaiting review"]);
        AcceptanceCatalog.WriteSupplement("cases", caseEvidence);
        AcceptanceCatalog.WriteSupplement("fixture-audit", suite.FixtureEvidence);
        AcceptanceCatalog.WriteSupplement("fault-controls", new
        {
            ExecutedChallenges = suite.FaultEvidence,
            FocusedControls = rows.Where(r => r.Id.StartsWith("S1-MUT-", StringComparison.Ordinal)).Select(r => new
            {
                r.Id,
                r.Classification,
                r.SourceRow,
                FocusedEvidence = results.TryGetValue(r.Id, out var result) ? result.References : [],
                FocusedEvidenceState = results.TryGetValue(r.Id, out var evidence) ? evidence.Passed ? "PASS" : "FAIL" : r.Classification,
                MutationExecution = "unexercised unless explicitly listed in ExecutedChallenges; focused negative/structural routes are separate from mutant execution"
            }),
            OutcomeVocabulary = new[] { "detected", "survived", "unexercised", "invalid/equivalent", "crash", "timeout" },
            CrashOrTimeoutAutomaticallyCredited = false
        });
        AcceptanceCatalog.Write(rows, results);
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.IsTrue(independent, "Independent checker imported production assertion-target logic.");
        Assert.IsTrue(coverage, "A coder-owned REQUIRED row is missing, failed, or unexecuted.");
        Assert.AreEqual(134, rows.Count(r => r.Classification == "REQUIRED"));
    }
}
