using System.Security.Cryptography;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice3AcceptanceTests
{
    [TestMethod]
    public void ExecuteFrozenSlice3Evidence()
    {
        const string blob = "1aae13dc27572361fe99c31ef8aee0444d39364a";
        string manifest = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md")).Replace("\r\n", "\n", StringComparison.Ordinal);
        byte[] bytes = Encoding.UTF8.GetBytes(manifest);
        Assert.AreEqual(blob, Convert.ToHexStringLower(SHA1.HashData([.. Encoding.ASCII.GetBytes($"blob {bytes.Length}\0"), .. bytes])));
        var rows = manifest.Split('\n').Where(l => l.StartsWith("| S3-", StringComparison.Ordinal)).Select(l =>
        {
            string[] cells = l.Split('|').Select(c => c.Trim()).ToArray();
            return (Id: cells[1], Classification: cells[2], Obligation: cells[3]);
        }).ToArray();
        Assert.AreEqual(109, rows.Length); Assert.AreEqual(109, rows.Select(r => r.Id).Distinct(StringComparer.Ordinal).Count());
        Assert.AreEqual(96, rows.Count(r => r.Classification == "REQUIRED"));
        Assert.AreEqual(11, rows.Count(r => r.Classification == "DEFERRED"));
        Assert.AreEqual(2, rows.Count(r => r.Classification == "UNEXERCISED"));
        HouseholdScenarios suite = new();
        List<object> cases = [];
        List<string> failures = [];
        Dictionary<string, List<(string Name, bool Pass)>> bindings = new(StringComparer.Ordinal);
        foreach (HouseholdCase scenario in suite.All())
        {
            string[] ids = scenario.Ids.Select(id => rows.Single(r => r.Id.StartsWith("S3-" + id + "-", StringComparison.Ordinal)).Id).ToArray();
            bool pass = true; string? error = null;
            suite.Begin();
            try { scenario.Run(); suite.Audit(scenario.Name); }
            catch (Exception failure) { pass = false; error = failure.ToString(); failures.Add(scenario.Name + ": " + error); }
            foreach (string id in ids)
            {
                if (!bindings.TryGetValue(id, out var list)) bindings.Add(id, list = []);
                list.Add((scenario.Name, pass));
            }
            cases.Add(new
            {
                scenario.Name,
                AcceptanceIds = ids,
                Executed = true,
                State = pass ? "PASS" : "FAIL",
                Error = error,
                FixtureAudit = "slice3-fixtures.json",
                Oracle = "HouseholdOracle.cs + explicit scenario expectations; production classifiers are not expected-value oracles"
            });
        }

        List<object> inherited = [];
        Dictionary<string, bool> prior = new(StringComparer.Ordinal);
        try
        {
            new AcceptanceTests().ExecuteFrozenManifestEvidence();
            new Slice2AcceptanceTests().ExecuteFrozenSlice2Evidence();
            using JsonDocument s1 = JsonDocument.Parse(File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "artifacts/acceptance/slice1-results.json")));
            using JsonDocument s2 = JsonDocument.Parse(File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "artifacts/acceptance/slice2-results.json")));
            foreach (JsonElement row in s1.RootElement.GetProperty("Rows").EnumerateArray().Where(r => r.GetProperty("Classification").GetString() == "REQUIRED"))
            {
                string id = row.GetProperty("Id").GetString()!;
                bool passed = row.GetProperty("State").GetString() == "PASS";
                string basis = "Reexecuted inherited acceptance scenario";
                if (id == "S1-GLOBAL-CONFORMANCE")
                {
                    string record = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md"));
                    passed = record.Contains("PASS", StringComparison.Ordinal) && record.Contains("06e25644879dd8505e24fcaeb43256f69c29c15f", StringComparison.Ordinal);
                    basis = "Preserved accepted Slice-1 independent conformance record; does not claim independent conformance of this Slice-3 candidate";
                }
                prior.Add(id, passed); inherited.Add(new { Id = id, State = passed ? "PASS" : "FAIL", Basis = basis });
            }
            foreach (JsonElement row in s2.RootElement.GetProperty("Rows").EnumerateArray().Where(r => r.GetProperty("Classification").GetString() == "REQUIRED"))
            {
                string id = row.GetProperty("Id").GetString()!;
                bool pass = row.GetProperty("State").GetString() == "PASS";
                prior.Add(id, pass); inherited.Add(new { Id = id, State = pass ? "PASS" : "FAIL", Basis = "Reexecuted inherited acceptance scenario" });
            }
            Assert.AreEqual(174, prior.Count); Assert.IsTrue(prior.Values.All(p => p));
        }
        catch (Exception error) { failures.Add("Inherited regression: " + error); }
        foreach (var row in rows.Where(r => r.Id.StartsWith("S3-R", StringComparison.Ordinal)))
        {
            string[] ids = Regex.Matches(row.Obligation, @"S[12]-[A-Z0-9-]+", RegexOptions.CultureInvariant).Select(m => m.Value).Distinct(StringComparer.Ordinal).ToArray();
            bool pass = prior.Count == 174 && prior.Values.All(p => p) && ids.All(InheritedPassed);
            bindings[row.Id] = [("ExactInheritedRegressionBindings", pass)];
        }
        bool InheritedPassed(string id)
        {
            if (prior.TryGetValue(id, out bool pass)) return pass;
            // Exact activated bindings from frozen Slice-2 §10; old row statuses remain untouched.
            string[] prefixes = id switch
            {
                "S1-098-COMMUNICATION" => ["S2-020", "S2-021", "S2-022", "S2-023", "S2-024", "S2-025", "S2-026", "S2-027"],
                "S1-META-08" => ["S2-032"],
                "S1-MUT-27" => ["S2-031A", "S2-031B", "S2-032"],
                "S1-MUT-28" => ["S2-033"],
                "S1-076" => ["S2-020", "S2-021", "S2-022", "S2-023", "S2-024", "S2-025", "S2-026", "S2-027", "S2-031", "S2-032", "S2-033"],
                _ => []
            };
            return prefixes.Length > 0 && prefixes.All(prefix => prior.Any(p => p.Key.StartsWith(prefix, StringComparison.Ordinal)) &&
                prior.Where(p => p.Key.StartsWith(prefix, StringComparison.Ordinal)).All(p => p.Value));
        }
        string oracle = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs")) +
            File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "tests/Mesopotamia.Sim.AcceptanceTests/HouseholdWarrantOracle.cs"));
        string[] forbidden = ["HouseholdRules.", "EpistemicRules.", "CommunicationRules.", "OrdinarySupport.", "new HouseholdState", ".TryForm(", ".TryLineage(", ".ContinueHousehold("];
        bool independent = forbidden.All(token => !oracle.Contains(token, StringComparison.Ordinal));
        var results = rows.Select(r => new
        {
            r.Id,
            r.Classification,
            r.Obligation,
            Executed = bindings.ContainsKey(r.Id),
            State = bindings.TryGetValue(r.Id, out var casesForRow) ? casesForRow.All(c => c.Pass) ? "PASS" : "FAIL" : r.Classification == "REQUIRED" ? "NOT EXECUTED" : r.Classification,
            Cases = bindings.TryGetValue(r.Id, out var references) ? references.Select(c => c.Name).ToArray() : []
        }).ToArray();
        AcceptanceCatalog.WriteSupplement("slice3-results", new
        {
            ManifestVersion = "SFL-V0-S3-ACCEPTANCE-v1",
            ImplementationHead = Git("rev-parse", "HEAD"),
            WorkingTreeDirty = Git("status", "--porcelain").Length > 0,
            FrozenRef = "sfl-v0-slice3-acceptance-v1",
            FreezeCommit = "25160f33c994fd5f3e277ae98f03e55d37c878dd",
            ManifestBlob = blob,
            IndependentOracleDependencyAudit = independent ? "PASS" : "FAIL",
            S1084AdaptationTrigger = "UNFIRED: existing private inventory and audit unchanged",
            CandidateReady = results.Where(r => r.Classification == "REQUIRED").All(r => r.State == "PASS") && independent && failures.Count == 0,
            Completion = "Coder evidence only; fresh independent exact-candidate conformance required before promotion",
            Rows = results,
            Inherited = inherited,
            Failures = failures
        });
        AcceptanceCatalog.WriteSupplement("slice3-cases", cases);
        AcceptanceCatalog.WriteSupplement("slice3-fixtures", suite.FixtureEvidence);
        AcceptanceCatalog.WriteSupplement("slice3-producers", suite.ProducerEvidence);
        AcceptanceCatalog.WriteSupplement("slice3-repair-v3-controls", suite.RepairV3Evidence);
        AcceptanceCatalog.WriteSupplement("slice3-repair-v4-controls", suite.RepairV4Evidence);
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.IsTrue(independent);
        Assert.IsTrue(results.Where(r => r.Classification == "REQUIRED").All(r => r.State == "PASS"),
            string.Join("\n", results.Where(r => r.Classification == "REQUIRED" && r.State != "PASS").Select(r => r.Id + ": " + r.State)));
    }

    private static string Git(params string[] arguments)
    {
        ProcessStartInfo info = new("git") { WorkingDirectory = AcceptanceCatalog.Root, RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
        foreach (string argument in arguments) info.ArgumentList.Add(argument);
        using Process process = Process.Start(info) ?? throw new InvalidOperationException("Cannot read implementation identity.");
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.AreEqual(0, process.ExitCode, process.StandardError.ReadToEnd());
        return output.Trim();
    }
}
