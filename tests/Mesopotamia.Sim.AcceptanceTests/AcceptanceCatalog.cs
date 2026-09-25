using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed record ManifestRow(string Id, string Classification, string SourceRow);
internal sealed record Evidence(string Id, string Classification, string State, string[] References, string SourceClause);

internal static class AcceptanceCatalog
{
    internal const string Version = "SFL-V0-S1-ACCEPTANCE-v2";
    internal const string Blob = "174ccbae57a64f06bd88de233b11a011b4a2b115";
    internal const string Freeze = "bf77bb38a8a7bc964159188b7359cb8e9af2b483";
    internal static string Root
    {
        get
        {
            DirectoryInfo? directory = new(AppContext.BaseDirectory);
            while (directory is not null && !File.Exists(Path.Combine(directory.FullName, "Mesopotamia.Sim.slnx")))
                directory = directory.Parent;
            return directory?.FullName ?? throw new InvalidOperationException("Repository root unavailable.");
        }
    }

    internal static ManifestRow[] Read()
    {
        string content = File.ReadAllText(Path.Combine(Root, "plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST_V2.md"))
            .Replace("\r\n", "\n", StringComparison.Ordinal);
        byte[] bytes = Encoding.UTF8.GetBytes(content);
        byte[] header = Encoding.ASCII.GetBytes($"blob {bytes.Length}\0");
        string sha = Convert.ToHexStringLower(SHA1.HashData([.. header, .. bytes]));
        if (sha != Blob || !content.Contains(Version, StringComparison.Ordinal))
            throw new InvalidOperationException("Frozen manifest integrity failure.");
        ManifestRow[] rows = content.Split('\n').Where(l => l.StartsWith("| S1-", StringComparison.Ordinal))
            .Select(l =>
            {
                string[] cells = l.Split('|').Select(c => c.Trim()).ToArray();
                string classification = cells.Single(c => c is "REQUIRED" or "DEFERRED" or "N-A" or "UNEXERCISED");
                return new ManifestRow(cells[1], classification, l);
            }).ToArray();
        if (rows.Length != 173 || rows.Select(r => r.Id).Distinct(StringComparer.Ordinal).Count() != 173 ||
            rows.Count(r => r.Classification == "REQUIRED") != 134 ||
            rows.Count(r => r.Classification == "DEFERRED") != 33 ||
            rows.Count(r => r.Classification == "N-A") != 3 ||
            rows.Count(r => r.Classification == "UNEXERCISED") != 3)
            throw new InvalidOperationException("Unexpected frozen census.");
        return rows;
    }

    internal static void Write(ManifestRow[] rows, IReadOnlyDictionary<string, (bool Passed, string[] References)> results)
    {
        if (results.Keys.Any(id => !rows.Any(r => r.Id == id)))
            throw new InvalidOperationException("Evidence names an unknown AcceptanceId.");
        Evidence[] evidence = rows.Select(r => new Evidence(r.Id, r.Classification,
            results.TryGetValue(r.Id, out var result) ? (result.Passed ? "PASS" : "FAIL") :
            r.Id == "S1-GLOBAL-CONFORMANCE" ? "AWAITING INDEPENDENT REVIEW" :
            r.Classification == "REQUIRED" ? "NOT EXECUTED" : r.Classification,
            results.TryGetValue(r.Id, out var references) ? references.References : [], r.SourceRow)).ToArray();
        string directory = Path.Combine(Root, "artifacts", "acceptance");
        Directory.CreateDirectory(directory);
        File.WriteAllText(Path.Combine(directory, "slice1-results.json"), JsonSerializer.Serialize(new
        {
            ManifestVersion = Version,
            ManifestBlob = Blob,
            FreezeCommit = Freeze,
            CandidateReady = evidence.Count(e => e.Classification == "REQUIRED" && e.State == "PASS") == 133 &&
                evidence.Single(e => e.Id == "S1-GLOBAL-CONFORMANCE").State == "AWAITING INDEPENDENT REVIEW",
            FullFrozenCompletionGate = false,
            Completion = "INDEPENDENT CONFORMANCE REQUIRED; coder evidence is not external review",
            Rows = evidence
        }, new JsonSerializerOptions { WriteIndented = true }));
        File.WriteAllLines(Path.Combine(directory, "slice1-results.md"),
            new[] { $"# {Version}", $"Manifest blob: `{Blob}`", "", "| AcceptanceId | Classification | Evidence state | References |", "|---|---|---|---|" }
            .Concat(evidence.Select(e => $"| {e.Id} | {e.Classification} | {e.State} | {string.Join(", ", e.References)} |")));
    }

    internal static void WriteSupplement(string name, object value)
    {
        string directory = Path.Combine(Root, "artifacts", "acceptance");
        Directory.CreateDirectory(directory);
        File.WriteAllText(Path.Combine(directory, name + ".json"), JsonSerializer.Serialize(value, new JsonSerializerOptions { WriteIndented = true }));
    }
}
