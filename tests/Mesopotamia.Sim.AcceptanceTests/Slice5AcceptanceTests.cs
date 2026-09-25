using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice5AcceptanceTests
{
    internal const string Blob = "1834a1a49203c07af01618066a7e09b25e7e6238";
    internal const string Review = "AWAITING FRESH INDEPENDENT REVIEW";
    public static IEnumerable<object[]> Cases => new Slice5Scenarios().All().Select(c => new object[] { c.Name });

    [TestMethod]
    [DynamicData(nameof(Cases))]
    public void CheckpointDetector(string name) => new Slice5Scenarios().All().Single(c => c.Name == name).Run();

    [TestMethod]
    public void ExecuteFrozenSlice5Evidence()
    {
        var rows = Read("SLICE5_ACCEPTANCE_MANIFEST.md", "S5-", Blob);
        Assert.AreEqual(96, rows.Length); Assert.AreEqual(96, rows.Select(r => r.Id).Distinct().Count());
        Assert.AreEqual(82, rows.Count(r => r.Classification == "REQUIRED"));
        Assert.AreEqual(12, rows.Count(r => r.Classification == "DEFERRED"));
        Assert.AreEqual(2, rows.Count(r => r.Classification == "UNEXERCISED"));
        Dictionary<string, List<(string Name, bool Pass)>> bindings = [];
        List<string> failures = []; List<object> cases = [];
        Slice5Scenarios suite = new();
        foreach (Slice5Case scenario in suite.All())
        {
            bool pass = true; string? error = null;
            try { scenario.Run(); }
            catch (Exception ex) { pass = false; error = ex.ToString(); failures.Add(scenario.Name + ": " + error); }
            string[] ids = [.. scenario.Codes.Select(code => rows.Single(r => r.Id.StartsWith("S5-" + code + "-", StringComparison.Ordinal)).Id)];
            foreach (string id in ids) Bind(id, scenario.Name, pass);
            cases.Add(new { scenario.Name, AcceptanceIds = ids, State = pass ? "PASS" : "FAIL", Error = error });
        }

        List<object> inherited = [];
        try
        {
            // Fresh execution, never artifact ordering or a pre-existing aggregate.
            new Slice4AcceptanceTests().ExecuteFrozenSlice4Evidence();
            new Slice1SuccessorV2AcceptanceTests().ExecuteSuccessorV2Evidence();
            var sources = new[]
            {
                ("SLICE1_ACCEPTANCE_MANIFEST_V2.md", "S1-", Slice1SuccessorV2AcceptanceTests.Blob, "slice1-v2-results.json", 134),
                ("SLICE2_ACCEPTANCE_MANIFEST.md", "S2-", "e4872531cf780d51fa1863f2a0b87e2424a71b69", "slice2-results.json", 46),
                ("SLICE3_ACCEPTANCE_MANIFEST.md", "S3-", "1aae13dc27572361fe99c31ef8aee0444d39364a", "slice3-results.json", 96),
                ("SLICE4_ACCEPTANCE_MANIFEST_V2.md", "S4-", "b0bc79e46f82630ab78cd2f0d0414b748212a411", "slice4-results.json", 165)
            };
            foreach (var (manifest, prefix, blob, output, count) in sources)
            {
                var required = Read(manifest, prefix, blob).Where(r => r.Classification == "REQUIRED").ToArray();
                Assert.AreEqual(count, required.Length);
                using JsonDocument doc = JsonDocument.Parse(File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "artifacts/acceptance", output)));
                var evidence = doc.RootElement.GetProperty("Rows").EnumerateArray().ToDictionary(e => e.GetProperty("Id").GetString()!);
                foreach (var row in required)
                {
                    bool pass = evidence[row.Id].GetProperty("State").GetString() == "PASS";
                    string basis = output + " freshly executed row";
                    if (row.Id == "S1-GLOBAL-CONFORMANCE")
                    {
                        string historical = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root,
                            "research/technical/IMP-0001/IMP-0001_SUCCESSOR_V2_DEC0015_FINAL_COMPLETION_AND_PROMOTION_RECORD.md"));
                        pass = historical.Contains("PASS", StringComparison.Ordinal) &&
                            historical.Contains("a8ecacd98eb4835d6fb96c1e683f5b7dfcc9a96d", StringComparison.Ordinal);
                        basis = "Accepted successor-v2 historical conformance; not IMP-0005 conformance";
                    }
                    Assert.IsTrue(pass, row.Id);
                    inherited.Add(new { row.Id, State = "PASS", ManifestBlob = blob, Basis = basis });
                }
            }
            Assert.AreEqual(441, inherited.Count);
            BindCode("R00", "Fresh exact 441 inherited rows", true);
            BindCode("R10", "Four immutable frozen blobs and unchanged classifications", true);
        }
        catch (Exception ex)
        {
            failures.Add("Inherited: " + ex);
            BindCode("R00", "Inherited execution", false); BindCode("R10", "Frozen authority", false);
        }
        BindCode("121", "Exact frozen Git blob and 96-row classification census", true);
        bool substantive = rows.Where(r => r.Classification == "REQUIRED" && !r.Id.StartsWith("S5-120-", StringComparison.Ordinal) &&
            !r.Id.StartsWith("S5-122-", StringComparison.Ordinal)).All(r => bindings.TryGetValue(r.Id, out var evidence) && evidence.Count > 0 && evidence.All(e => e.Pass));
        BindCode("120", "Every coder-owned required row has executed evidence; external review explicitly pending", substantive);
        var results = rows.Select(r => new
        {
            r.Id,
            r.Classification,
            r.Obligation,
            State = r.Id.StartsWith("S5-122-", StringComparison.Ordinal) ? Review :
                bindings.TryGetValue(r.Id, out var b) ? b.All(e => e.Pass) ? "PASS" : "FAIL" :
                r.Classification == "REQUIRED" ? "NOT EXECUTED" : r.Classification,
            Cases = bindings.TryGetValue(r.Id, out var links) ? links.Select(e => e.Name).ToArray() : []
        }).ToArray();
        bool ready = failures.Count == 0 && inherited.Count == 441 &&
            results.Count(r => r.Classification == "REQUIRED" && r.State == "PASS") == 81;
        AcceptanceCatalog.WriteSupplement("slice5-results", new
        {
            ManifestVersion = "SFL-V0-S5-ACCEPTANCE-v1",
            ManifestBlob = Blob,
            FrozenRef = "sfl-v0-slice5-acceptance-v1",
            FreezeCommit = "f0f32f06cdd607b04df4f14c4bc49bcde4d056bf",
            ImplementationHead = Git("rev-parse", "HEAD"),
            WorkingTreeDirty = Git("status", "--porcelain").Length > 0,
            ExecutableEvidenceReady = ready,
            CandidateReady = false,
            FullFrozenCompletionGate = false,
            Completion = "Executed implementation mutants and exact-head CI still required; independent S5-122 remains external.",
            Rows = results,
            Inherited = inherited,
            Failures = failures
        });
        AcceptanceCatalog.WriteSupplement("slice5-cases", cases);
        AcceptanceCatalog.WriteSupplement("slice5-producers", suite.Producers);
        AcceptanceCatalog.WriteSupplement("slice5-mutations", suite.Mutations);
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.IsTrue(ready, string.Join("\n", results.Where(r => r.Classification == "REQUIRED" && r.State != "PASS").Select(r => r.Id + ": " + r.State)));
        void Bind(string id, string name, bool pass)
        {
            if (!bindings.TryGetValue(id, out var list)) bindings[id] = list = [];
            list.Add((name, pass));
        }
        void BindCode(string code, string name, bool pass) => Bind(rows.Single(r => r.Id.StartsWith("S5-" + code + "-", StringComparison.Ordinal)).Id, name, pass);
    }

    private static (string Id, string Classification, string Obligation)[] Read(string file, string prefix, string blob)
    {
        string content = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "plans/verification/SFL_V0", file)).Replace("\r\n", "\n", StringComparison.Ordinal);
        byte[] bytes = Encoding.UTF8.GetBytes(content);
        Assert.AreEqual(blob, Convert.ToHexStringLower(SHA1.HashData([.. Encoding.ASCII.GetBytes($"blob {bytes.Length}\0"), .. bytes])));
        return [.. content.Split('\n').Where(l => l.StartsWith("| " + prefix, StringComparison.Ordinal) || l.StartsWith("| `" + prefix, StringComparison.Ordinal))
            .Select(l =>
            {
                string[] cells = l.Split('|').Select(c => c.Trim().Trim('`')).ToArray();
                cells = [.. cells.Select(c => c == "REQUIRED structural/report" ? "REQUIRED" : c)];
                return (cells[1], cells.SingleOrDefault(c => c is "REQUIRED" or "DEFERRED" or "UNEXERCISED" or "N-A") ?? "", l);
            }).Where(r => r.Item2.Length > 0)];
    }

    private static string Git(params string[] args)
    {
        ProcessStartInfo info = new("git") { WorkingDirectory = AcceptanceCatalog.Root, RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
        foreach (string arg in args) info.ArgumentList.Add(arg);
        using Process process = Process.Start(info)!; string output = process.StandardOutput.ReadToEnd(); process.WaitForExit();
        Assert.AreEqual(0, process.ExitCode, process.StandardError.ReadToEnd()); return output.Trim();
    }
}
