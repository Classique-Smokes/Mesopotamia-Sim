using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

[TestClass]
[DoNotParallelize]
public sealed class Slice4AcceptanceTests
{
    [TestMethod]
    public void ExecuteFrozenSlice4Evidence()
    {
        const string blob = "b0bc79e46f82630ab78cd2f0d0414b748212a411";
        string manifest = ReadAndVerify("plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST_V2.md", blob);
        ReadAndVerify("research/technical/SFL_V0_SLICE4_INHERITED_VERIFICATION_ADAPTATION_PLAN.md", "00c3e64a128fa00e91b99117e321a0e379dd61c5");
        var rows = manifest.Split('\n').Where(l => l.StartsWith("| S4-", StringComparison.Ordinal)).Select(l =>
        { string[] cells = l.Split('|').Select(c => c.Trim()).ToArray(); return (Id: cells[1], Classification: cells[2], Obligation: cells[3]); }).ToArray();
        Assert.AreEqual(176, rows.Length); Assert.AreEqual(176, rows.Select(r => r.Id).Distinct(StringComparer.Ordinal).Count());
        Assert.AreEqual(165, rows.Count(r => r.Classification == "REQUIRED"));
        Assert.AreEqual(9, rows.Count(r => r.Classification == "DEFERRED")); Assert.AreEqual(2, rows.Count(r => r.Classification == "UNEXERCISED"));
        Dictionary<string, List<(string Case, bool Pass)>> bindings = [];
        List<string> failures = []; List<object> cases = [], fixtures = [];
        foreach (Slice4Case scenario in Slice4Cases.All())
        {
            bool pass = true; string? error = null; Slice4FixtureAudit.Begin();
            try { scenario.Run(); }
            catch (Exception ex) { pass = false; error = ex.ToString(); }
            try { fixtures.AddRange(Slice4FixtureAudit.Complete(scenario.Name)); }
            catch (Exception ex) { pass = false; error += "\nFixture/oracle audit: " + ex; }
            if (!pass) failures.Add(scenario.Name + ": " + error);
            string[] ids = [.. scenario.Ids.Select(code => rows.Single(r => r.Id.StartsWith("S4-" + code + "-", StringComparison.Ordinal)).Id)];
            foreach (string id in ids) Bind(id, scenario.Name, pass);
            cases.Add(new
            {
                scenario.Name,
                AcceptanceIds = ids,
                State = pass ? "PASS" : "FAIL",
                Error = error,
                FixtureAudit = "slice4-fixtures.json",
                Oracle = "Slice4Oracle.cs plus explicit source-grounded scenario assertions"
            });
        }
        bool inheritedPass = true;
        try { new Slice3AcceptanceTests().ExecuteFrozenSlice3Evidence(); }
        catch (Exception ex) { inheritedPass = false; failures.Add("Inherited: " + ex); }
        using JsonDocument inherited = JsonDocument.Parse(File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, "artifacts/acceptance/slice3-results.json")));
        var prior = inherited.RootElement.GetProperty("Inherited").EnumerateArray().Select(e => e.Clone())
            .Concat(inherited.RootElement.GetProperty("Rows").EnumerateArray().Where(e => e.GetProperty("Classification").GetString() == "REQUIRED").Select(e => e.Clone())).ToArray();
        inheritedPass &= prior.Length == 276 && prior.All(e => e.GetProperty("State").GetString() == "PASS");
        foreach (var row in rows.Where(r => r.Id.StartsWith("S4-R", StringComparison.Ordinal))) Bind(row.Id, "Exact276InheritedRequired", inheritedPass);
        BindCode("163", "Frozen manifests and exact inherited census", inheritedPass);
        BindCode("174", "Approved immutable adaptation-plan blob verified before scenario execution", true);
        BindCode("175", "Immutable manifest blob and classification census", true);
        bool audited = failures.Count == 0 && fixtures.Count > 0;
        BindCode("151", "Every registered public-path lab: exact initial writes, inputs, report prerequisites, and final oracle", audited);
        BindCode("154", "Independently checked public formation producers and retained output identities", audited);
        var results = rows.Select(r => new
        {
            r.Id,
            r.Classification,
            r.Obligation,
            Executed = bindings.ContainsKey(r.Id),
            State = bindings.TryGetValue(r.Id, out var b) ? b.All(c => c.Pass) ? "PASS" : "FAIL" : r.Classification == "REQUIRED" ? "NOT EXECUTED" : r.Classification,
            Cases = bindings.TryGetValue(r.Id, out var references) ? references.Select(c => c.Case).ToArray() : []
        }).ToArray();
        bool ready = results.Where(r => r.Classification == "REQUIRED").All(r => r.State == "PASS") && failures.Count == 0;
        AcceptanceCatalog.WriteSupplement("slice4-results", new
        {
            ManifestVersion = "SFL-V0-S4-ACCEPTANCE-v2",
            ManifestBlob = blob,
            ImplementationHead = Git("rev-parse", "HEAD"),
            WorkingTreeDirty = Git("status", "--porcelain").Length > 0,
            CandidateReady = ready,
            Completion = "Coder-owned evidence only. Fresh independent conformance and PASS — PROMOTE remain separate gates.",
            HistoricalConformance = "S1-GLOBAL-CONFORMANCE preserves accepted historical Slice-1 independent conformance, not this candidate's conformance.",
            Rows = results,
            Inherited = prior,
            Failures = failures
        });
        AcceptanceCatalog.WriteSupplement("slice4-cases", cases); AcceptanceCatalog.WriteSupplement("slice4-fixtures", fixtures);
        Assert.IsEmpty(failures, string.Join("\n", failures));
        Assert.IsTrue(ready, string.Join("\n", results.Where(r => r.Classification == "REQUIRED" && r.State != "PASS").Select(r => r.Id + ": " + r.State)));

        void Bind(string id, string name, bool pass)
        { if (!bindings.TryGetValue(id, out var list)) bindings[id] = list = []; list.Add((name, pass)); }
        void BindCode(string code, string name, bool pass) => Bind(rows.Single(r => r.Id.StartsWith("S4-" + code + "-", StringComparison.Ordinal)).Id, name, pass);
    }

    private static string ReadAndVerify(string path, string expected)
    {
        string value = File.ReadAllText(Path.Combine(AcceptanceCatalog.Root, path)).Replace("\r\n", "\n", StringComparison.Ordinal);
        byte[] bytes = Encoding.UTF8.GetBytes(value);
        Assert.AreEqual(expected, Convert.ToHexStringLower(SHA1.HashData([.. Encoding.ASCII.GetBytes($"blob {bytes.Length}\0"), .. bytes])));
        return value;
    }

    private static string Git(params string[] args)
    {
        ProcessStartInfo info = new("git") { WorkingDirectory = AcceptanceCatalog.Root, RedirectStandardOutput = true, RedirectStandardError = true, UseShellExecute = false, CreateNoWindow = true };
        foreach (string arg in args) info.ArgumentList.Add(arg);
        using Process process = Process.Start(info)!; string output = process.StandardOutput.ReadToEnd(); process.WaitForExit();
        Assert.AreEqual(0, process.ExitCode, process.StandardError.ReadToEnd()); return output.Trim();
    }
}
