using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Mesopotamia.Sim;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice1SuccessorV2AcceptanceTests
{
    internal const string Version = "SFL-V0-S1-ACCEPTANCE-v2";
    internal const string Blob = "174ccbae57a64f06bd88de233b11a011b4a2b115";
    internal const string Freeze = "bf77bb38a8a7bc964159188b7359cb8e9af2b483";
    internal const string Review = "AWAITING FRESH INDEPENDENT REVIEW";
    private static readonly string[] AddedIds =
    [
        "S1-107-SELF-COUNTERPARTY", "S1-107-ATTITUDE-DIAGONAL", "S1-107-DEBT-DIAGONAL",
        "S1-107-FAVOUR-DIAGONAL", "S1-107-VALID-ALIAS-CONTROLS", "S1-107-GENERIC-RELATION-SEAM"
    ];

    internal static ManifestRow[] Read()
    {
        string content = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root,
            "plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST_V2.md")).Replace("\r\n", "\n", StringComparison.Ordinal);
        byte[] bytes = Encoding.UTF8.GetBytes(content);
        Assert.AreEqual(Blob, Convert.ToHexStringLower(SHA1.HashData(
            [.. Encoding.ASCII.GetBytes($"blob {bytes.Length}\0"), .. bytes])));
        StringAssert.Contains(content, Version);
        ManifestRow[] rows = content.Split('\n').Where(l => l.StartsWith("| S1-", StringComparison.Ordinal))
            .Select(l =>
            {
                string[] cells = l.Split('|').Select(c => c.Trim()).ToArray();
                return new ManifestRow(cells[1], cells.Single(c => c is "REQUIRED" or "DEFERRED" or "N-A" or "UNEXERCISED"), l);
            }).ToArray();
        Assert.AreEqual(173, rows.Length);
        Assert.AreEqual(173, rows.Select(r => r.Id).Distinct(StringComparer.Ordinal).Count());
        Assert.AreEqual(134, rows.Count(r => r.Classification == "REQUIRED"));
        Assert.AreEqual(33, rows.Count(r => r.Classification == "DEFERRED"));
        Assert.AreEqual(3, rows.Count(r => r.Classification == "N-A"));
        Assert.AreEqual(3, rows.Count(r => r.Classification == "UNEXERCISED"));
        ManifestRow[] historical = AcceptanceCatalog.Read();
        foreach (ManifestRow row in historical)
            Assert.AreEqual(row, rows.Single(r => r.Id == row.Id), "Historical status-bearing row changed.");
        CollectionAssert.AreEquivalent(AddedIds, rows.Where(r => historical.All(h => h.Id != r.Id)).Select(r => r.Id).ToArray());
        return rows;
    }

    internal static bool Ready(ManifestRow[] rows, Evidence[] evidence)
    {
        if (rows.Length != 173 || rows.Select(r => r.Id).Distinct(StringComparer.Ordinal).Count() != 173 ||
            evidence.Length != rows.Length || evidence.Select(e => e.Id).Distinct(StringComparer.Ordinal).Count() != rows.Length)
            return false;
        return rows.All(r => evidence.SingleOrDefault(e => e.Id == r.Id) is { } e &&
            e.Classification == r.Classification && e.SourceClause == r.SourceRow &&
            (r.Id == "S1-GLOBAL-CONFORMANCE" ? e.State == Review :
                r.Classification == "REQUIRED" ? e.State == "PASS" && e.References.Length > 0 :
                e.State == r.Classification));
    }

    [TestMethod]
    public void ExecuteSuccessorV2Evidence()
    {
        ManifestRow[] rows = Read();
        // Reexecute the historical runner; never trust stale artifacts or MSTest ordering.
        new AcceptanceTests().ExecuteFrozenManifestEvidence();
        using JsonDocument previous = JsonDocument.Parse(File.ReadAllText(Path.Combine(
            AcceptanceCatalog.Root, "artifacts/acceptance/slice1-results.json")));
        Assert.AreEqual(AcceptanceCatalog.Blob, previous.RootElement.GetProperty("ManifestBlob").GetString());
        Assert.AreEqual(AcceptanceCatalog.Version, previous.RootElement.GetProperty("ManifestVersion").GetString());
        Evidence[] historical = JsonSerializer.Deserialize<Evidence[]>(previous.RootElement.GetProperty("Rows"))!;
        Dictionary<string, (bool Passed, string[] References)> bindings = historical
            .Where(e => e.Classification == "REQUIRED" && e.Id != "S1-GLOBAL-CONFORMANCE")
            .ToDictionary(e => e.Id, e => (e.State == "PASS", e.References), StringComparer.Ordinal);
        List<string> failures = [];
        List<object> cases = [];
        Scenarios suite = new();
        Scenario[] scenarios = suite.Dec0015Cases().ToArray();
        Assert.AreEqual(scenarios.Length, scenarios.Select(s => s.Name).Distinct(StringComparer.Ordinal).Count());
        CollectionAssert.AreEquivalent(AddedIds, scenarios.SelectMany(s => s.Ids).Distinct(StringComparer.Ordinal).ToArray());
        foreach (Scenario scenario in scenarios)
        {
            bool pass = true;
            string? error = null;
            suite.BeginCase();
            try { scenario.Run(); suite.AuditCase(scenario.Name); }
            catch (Exception failure) { pass = false; error = failure.ToString(); failures.Add(scenario.Name + ": " + error); }
            cases.Add(new
            {
                scenario.Name,
                scenario.Ids,
                State = pass ? "PASS" : "FAIL",
                Failure = error,
                scenario.FixtureWrites,
                scenario.Oracle,
                SourceClauses = scenario.Ids.Select(id => rows.Single(r => r.Id == id).SourceRow),
                FixtureAudit = "slice1-v2-fixtures.json",
                DetachedProbes = "slice1-v2-boundary-probes.json"
            });
            foreach (string id in scenario.Ids)
            {
                Assert.Contains(id, AddedIds);
                if (bindings.TryGetValue(id, out var prior))
                    bindings[id] = (prior.Passed && pass, [.. prior.References, scenario.Name]);
                else bindings.Add(id, (pass, [scenario.Name]));
            }
        }
        string oracle = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root,
            "tests/Mesopotamia.Sim.AcceptanceTests/Dec0015Oracle.cs"));
        string[] forbidden = ["ActionRules.", "WorldState", "ReferenceScorer.", "PersonalAgency.",
            ".RunCycle(", "EvaluateTransaction(", ".Validate(", "EpistemicRules."];
        bool independent = forbidden.All(token => !oracle.Contains(token, StringComparison.Ordinal));
        bool audited = failures.Count == 0 && suite.FixtureEvidence.Count >= scenarios.Length;
        bindings["S1-GLOBAL-MANIFEST-INTEGRITY"] = (true, ["v1 and v2 Git blobs, exact census and inherited row equality"]);
        bindings["S1-GLOBAL-FIXTURE"] = (bindings["S1-GLOBAL-FIXTURE"].Passed && audited,
            ["fixture-audit.json", "slice1-v2-fixtures.json", "slice1-v2-boundary-probes.json"]);
        bindings["S1-GLOBAL-ORACLE"] = (bindings["S1-GLOBAL-ORACLE"].Passed && independent && audited,
            ["oracle-audit.json", "slice1-v2-oracle-audit.json", "InvariantOracle.cs", "Dec0015Oracle.cs"]);
        bool coverage = rows.Where(r => r.Classification == "REQUIRED" &&
            r.Id is not ("S1-GLOBAL-CONFORMANCE" or "S1-GLOBAL-REQUIRED-COVERAGE"))
            .All(r => bindings.TryGetValue(r.Id, out var b) && b.Passed && b.References.Length > 0);
        bindings["S1-GLOBAL-REQUIRED-COVERAGE"] = (coverage, ["All 173 rows; 133 coder-owned REQUIRED; external review remains pending"]);
        Evidence[] evidence = rows.Select(r => new Evidence(r.Id, r.Classification,
            r.Id == "S1-GLOBAL-CONFORMANCE" ? Review :
            bindings.TryGetValue(r.Id, out var b) ? b.Passed ? "PASS" : "FAIL" :
            r.Classification == "REQUIRED" ? "NOT EXECUTED" : r.Classification,
            bindings.TryGetValue(r.Id, out var refs) ? refs.References : [], r.SourceRow)).ToArray();
        AcceptanceCatalog.WriteSupplement("slice1-v2-results", new
        {
            ManifestVersion = Version,
            ManifestBlob = Blob,
            FreezeCommit = Freeze,
            ImplementationHead = Git("rev-parse", "HEAD"),
            WorkingTreeDirty = Git("status", "--porcelain").Length > 0,
            RulesVersion = Configuration.RulesVersion,
            ExecutableEvidenceReady = Ready(rows, evidence) && failures.Count == 0,
            CandidateReady = false,
            FullFrozenCompletionGate = false,
            Completion = "Candidate gate additionally requires the exact-revision executed mutation campaign; independent review remains external.",
            MutationGate = "slice1-v2-candidate-gate.json, produced by tests/Run-Slice1V2Mutants.ps1",
            Rows = evidence,
            Failures = failures
        });
        AcceptanceCatalog.WriteSupplement("slice1-v2-cases", cases);
        AcceptanceCatalog.WriteSupplement("slice1-v2-fixtures", suite.FixtureEvidence);
        AcceptanceCatalog.WriteSupplement("slice1-v2-boundary-probes", suite.Dec0015ProbeEvidence);
        AcceptanceCatalog.WriteSupplement("slice1-v2-oracle-audit", new
        {
            State = independent && audited ? "PASS" : "FAIL",
            ForbiddenCalls = forbidden,
            Checker = "Dec0015Oracle.cs + unchanged InvariantOracle.cs",
            TargetOnlyDependencies = "Detached WorldState.Validate and ActionRules.Invalid probes are targets; literal expected rejection is the oracle.",
            Boundary = "Detached probes never enter live simulation; public-path material and knowledge assertions use independent observations."
        });
        AcceptanceCatalog.WriteSupplement("slice1-v2-structural-audit", new
        {
            State = bindings["S1-107-GENERIC-RELATION-SEAM"].Passed ? "PASS" : "FAIL",
            References = bindings["S1-107-GENERIC-RELATION-SEAM"].References,
            InheritedInventory = "Unchanged S1-084 exact WorldState inventory, reexecuted by historical runner",
            RuntimeScope = "State.cs validation methods only; no added fields, registry, policy engine or public API"
        });
        AcceptanceCatalog.WriteSupplement("slice1-v2-fault-controls", new
        {
            InheritedExecutedChallenges = suite.FaultEvidence,
            SuccessorProductionMutationExecution = "Not inferred from positive tests. See exact-revision slice1-v2-mutants/mutant-results.json.",
            CrashOrTimeoutCredited = false
        });
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.IsTrue(Ready(rows, evidence), "Missing, failed or misclassified successor evidence.");
        Assert.IsTrue(independent);
    }

    [TestMethod]
    public void SuccessorGateRejectsOmissionsAndFalseReviewCredit()
    {
        ManifestRow[] rows = Read();
        Evidence[] green = rows.Select(r => new Evidence(r.Id, r.Classification,
            r.Id == "S1-GLOBAL-CONFORMANCE" ? Review : r.Classification == "REQUIRED" ? "PASS" : r.Classification,
            ["Synthetic gate-only witness; not acceptance evidence"], r.SourceRow)).ToArray();
        Assert.IsTrue(Ready(rows, green));
        Assert.IsFalse(Ready(rows, green.Where(e => e.Id != AddedIds[0]).ToArray()));
        Assert.IsFalse(Ready(rows, [.. green, green[0]]));
        Assert.IsFalse(Ready([.. rows, rows[0]], green));
        foreach (string bad in new[] { "UNKNOWN-ID", AddedIds[1] })
            Assert.IsFalse(Ready(rows, green.Select(e => e.Id == AddedIds[0] ? e with { Id = bad } : e).ToArray()));
        foreach (string state in new[] { "FAIL", "NOT EXECUTED", "SKIP" })
            Assert.IsFalse(Ready(rows, green.Select(e => e.Id == AddedIds[0] ? e with { State = state } : e).ToArray()));
        Assert.IsFalse(Ready(rows, green.Select(e => e.Id == "S1-GLOBAL-CONFORMANCE" ? e with { State = "PASS" } : e).ToArray()));
        Assert.IsFalse(Ready(rows, green.Select(e => e.Id == AddedIds[0] ? e with { References = [] } : e).ToArray()));
    }

    // A fast, individually named detector for each actual production mutation.
    [TestMethod]
    [DataRow("Dec0015SelfCounterpartyBoundary")]
    [DataRow("Dec0015AttitudeDiagonal")]
    [DataRow("Dec0015DebtDiagonal")]
    [DataRow("Dec0015FavourDiagonal")]
    [DataRow("Dec0015GenericRelationSeam")]
    [DataRow("Dec0015InheritedSharedSnapshotScarceGrain")]
    public void SuccessorFaultDetector(string name)
    {
        Scenarios suite = new();
        Scenario scenario = suite.Dec0015Cases().Single(s => s.Name == name);
        suite.BeginCase();
        scenario.Run();
        suite.AuditCase(name);
    }

    private static string Git(params string[] arguments)
    {
        ProcessStartInfo info = new("git")
        {
            WorkingDirectory = AcceptanceCatalog.Root,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };
        foreach (string argument in arguments) info.ArgumentList.Add(argument);
        using Process process = Process.Start(info)!;
        string result = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        Assert.AreEqual(0, process.ExitCode, process.StandardError.ReadToEnd());
        return result.Trim();
    }
}

