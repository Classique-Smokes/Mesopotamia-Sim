using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
public sealed class Slice2AcceptanceTests
{
    [TestMethod]
    public void ExecuteFrozenSlice2Evidence()
    {
        const string version = "SFL-V0-S2-ACCEPTANCE-v1";
        const string frozenRef = "sfl-v0-slice2-acceptance-v1";
        const string freeze = "88f876298852553d6afca76e743a5a811ff9f0fd";
        const string blob = "e4872531cf780d51fa1863f2a0b87e2424a71b69";
        string manifest = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "plans/verification/SFL_V0/SLICE2_ACCEPTANCE_MANIFEST.md"))
            .Replace("\r\n", "\n", StringComparison.Ordinal);
        byte[] bytes = Encoding.UTF8.GetBytes(manifest);
        Assert.AreEqual(blob, Convert.ToHexStringLower(SHA1.HashData([.. Encoding.ASCII.GetBytes($"blob {bytes.Length}\0"), .. bytes])));
        var rows = manifest.Split('\n').Where(l => l.StartsWith("| `S2-", StringComparison.Ordinal)).Select(l =>
        {
            string[] cells = l.Split('|').Select(c => c.Trim()).ToArray();
            return (Id: cells[1].Trim('`'), Status: cells[2].StartsWith("REQUIRED", StringComparison.Ordinal) ? "REQUIRED" : cells[2], Source: cells[3]);
        }).ToArray();
        Assert.AreEqual(46, rows.Count(r => r.Status == "REQUIRED"));
        Assert.AreEqual(9, rows.Count(r => r.Status == "DEFERRED"));
        Assert.AreEqual(55, rows.Select(r => r.Id).Distinct(StringComparer.Ordinal).Count());
        Slice2Scenarios suite = new();
        List<object> cases = [];
        Dictionary<string, List<(string Name, bool Pass)>> results = new(StringComparer.Ordinal);
        List<string> failures = [];
        foreach (Slice2Case scenario in suite.All())
        {
            string[] ids = scenario.Ids.Select(prefix => rows.Single(r => r.Id.StartsWith(prefix + "-", StringComparison.Ordinal)).Id).ToArray();
            suite.Begin();
            bool pass = true;
            string? error = null;
            try { scenario.Run(); suite.AuditCase(scenario); }
            catch (Exception failure) { pass = false; error = failure.ToString(); failures.Add(scenario.Name + ": " + error); }
            foreach (string id in ids)
            {
                if (!results.TryGetValue(id, out var evidence)) results.Add(id, evidence = []);
                evidence.Add((scenario.Name, pass));
            }
            cases.Add(new { scenario.Name, AcceptanceIds = ids, Executed = true, State = pass ? "PASS" : "FAIL", Error = error, scenario.Fixture, scenario.Oracle });
        }
        string checker = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "tests/Mesopotamia.Sim.AcceptanceTests/Slice2Scenarios.cs"));
        string[] forbidden = ["EpistemicRules.", "CommunicationRules.", "new EpistemicState(", "PersonalAgency.", "ReferenceScorer.", "ActionRules."];
        bool independent = forbidden.All(call => !checker.Contains(call, StringComparison.Ordinal));
        string[] regressions = ["S1-070", "S1-GLOBAL-KNOWLEDGE", "S1-073", "S1-098-CORE", "S1-105", "S1-085", "S1-META-04", "S1-MUT-26",
            "S1-086", "S1-MUT-29", "S1-META-07", "S1-084", "S1-META-05", "S1-MUT-24", "S1-META-03", "S1-META-02", "S1-GLOBAL-FALLBACK", "S1-GLOBAL-MANIFEST-INTEGRITY"];
        ManifestRow[] prior = AcceptanceCatalog.Read();
        Scenarios regressionSuite = new();
        Dictionary<string, List<bool>> regressionResults = regressions.ToDictionary(id => id, _ => new List<bool>(), StringComparer.Ordinal);
        regressionResults["S1-GLOBAL-MANIFEST-INTEGRITY"].Add(prior.Length == 173 && AcceptanceCatalog.Version == "SFL-V0-S1-ACCEPTANCE-v2" && AcceptanceCatalog.Blob == "174ccbae57a64f06bd88de233b11a011b4a2b115");
        foreach (Scenario scenario in regressionSuite.All().Where(s => s.Ids.Any(regressions.Contains)))
        {
            bool pass = true;
            regressionSuite.BeginCase();
            try { scenario.Run(); regressionSuite.AuditCase(scenario.Name); }
            catch (Exception failure) { pass = false; failures.Add("Regression " + scenario.Name + ": " + failure); }
            foreach (string id in scenario.Ids.Where(regressions.Contains)) regressionResults[id].Add(pass);
        }
        var evidenceRows = rows.Select(r => new
        {
            r.Id,
            Classification = r.Status,
            r.Source,
            Executed = results.ContainsKey(r.Id),
            State = results.TryGetValue(r.Id, out var evidence) ? evidence.All(e => e.Pass) ? "PASS" : "FAIL" : r.Status == "DEFERRED" ? "DEFERRED" : "NOT EXECUTED",
            Cases = results.TryGetValue(r.Id, out var references) ? references.Select(e => e.Name).ToArray() : [],
            FixtureOracleBinding = manifest.Split('\n').SingleOrDefault(line => line.StartsWith("| " + Regex.Match(r.Id, @"^S2-(?:\d+[A-Z]?|D\d+)").Value + " |", StringComparison.Ordinal)),
            ResolvedWrites = "slice2-fixture-audit.json: matching scenario and subcase",
            OracleAudit = "slice2-oracle-audit.json"
        }).ToArray();
        var regressionRows = regressionResults.Select(r => new { Id = r.Key, Executions = r.Value.Count, State = r.Value.Count > 0 && r.Value.All(p => p) ? "PASS" : "FAIL" }).ToArray();
        bool ready = evidenceRows.All(r => r.Classification != "REQUIRED" || r.State == "PASS") && independent && regressionRows.All(r => r.State == "PASS");
        AcceptanceCatalog.WriteSupplement("slice2-results", new
        {
            ManifestVersion = version,
            FrozenRef = frozenRef,
            FreezeCommit = freeze,
            ManifestBlob = blob,
            CandidateReady = ready,
            Conformance = "AWAITING FRESH INDEPENDENT REVIEW",
            Rows = evidenceRows,
            Slice1Regressions = regressionRows,
            RulesVersion = "SFL-S2-v1",
            CommunicationProfile = "SFL-COMMUNICATION-LAB-v1",
            PolicyNonclaim = "Pinned laboratory selection coefficients; no claim of autonomous social communication motivation"
        });
        AcceptanceCatalog.WriteSupplement("slice2-cases", cases);
        AcceptanceCatalog.WriteSupplement("slice2-fixture-audit", suite.Audit);
        AcceptanceCatalog.WriteSupplement("slice2-regression-fixtures", regressionSuite.FixtureEvidence);
        AcceptanceCatalog.WriteSupplement("slice2-oracle-audit", new
        {
            State = independent ? "PASS" : "FAIL",
            ForbiddenProductionCalls = forbidden,
            Checker = "Slice2Scenarios.cs",
            Basis = "Public immutable state/history, explicit expected values, independent paired-run comparisons",
            Limit = "Coder dependency audit; fresh independent conformance is a separate gate"
        });
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.IsTrue(ready, "Missing/failed required row, oracle audit, or exact regression binding.");
    }
}
