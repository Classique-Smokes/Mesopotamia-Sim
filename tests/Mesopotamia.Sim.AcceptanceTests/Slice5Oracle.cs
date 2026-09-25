using System.Collections;
using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mesopotamia.Sim.AcceptanceTests;

// Test-owned structural comparison. No production codec, projection normalizer, restore
// classifier, scoring, recognition, funding or state-validation function supplies answers.
internal static class Slice5Oracle
{
    internal static string Canonical(object? value)
    {
        if (value is null) return "null";
        Type type = value.GetType();
        if (value is string text) return JsonSerializer.Serialize(text);
        if (type.IsEnum || type.IsPrimitive || value is decimal)
            return Convert.ToString(value, CultureInfo.InvariantCulture)!;
        if (value is IEnumerable collection)
        {
            string[] items = [.. collection.Cast<object?>().Select(Canonical)];
            bool unordered = type.GetInterfaces().Append(type).Any(i => i.IsGenericType &&
                (i.GetGenericTypeDefinition() == typeof(IDictionary<,>) || i.GetGenericTypeDefinition() == typeof(IReadOnlyDictionary<,>) ||
                 i.GetGenericTypeDefinition() == typeof(ISet<>) || i.GetGenericTypeDefinition() == typeof(IImmutableSet<>)));
            if (unordered) Array.Sort(items, StringComparer.Ordinal);
            return "[" + string.Join(",", items) + "]";
        }
        return type.Name + "{" + string.Join(",", type.GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Where(p => p.CanRead && p.GetIndexParameters().Length == 0).OrderBy(p => p.Name, StringComparer.Ordinal)
            .Select(p => p.Name + ":" + Canonical(p.GetValue(value)))) + "}";
    }

    internal static object Field(object owner, string name) =>
        owner.GetType().GetField(name, BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(owner)!;

    internal static string Hidden(Simulation sim)
    {
        string Partition(string name)
        {
            object owner = Field(sim, name);
            return string.Join("|", owner.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .OrderBy(f => f.Name, StringComparer.Ordinal).Select(f => f.Name + ":" + Canonical(f.GetValue(owner))));
        }
        return Partition("state") + Partition("epistemic") + Partition("households") +
            string.Join("|", new[] { "nextEvent", "nextProposal", "usedProposals" }.Select(n => n + ":" + Canonical(Field(sim, n))));
    }

    internal static void Same(object? expected, object? actual, string meaning)
    {
        string a = Canonical(expected), b = Canonical(actual);
        int prefix = 0;
        while (prefix < Math.Min(a.Length, b.Length) && a[prefix] == b[prefix]) prefix++;
        Assert.IsTrue(a == b, $"S5 semantic mismatch: {meaning}; offset {prefix}; expected {a.Substring(prefix, Math.Min(180, a.Length - prefix))}; actual {b.Substring(prefix, Math.Min(180, b.Length - prefix))}");
    }

    internal static void EqualBoundary(Simulation expected, Simulation actual)
    {
        Same(expected.Snapshot, actual.Snapshot, "world");
        Same(expected.EpistemicSnapshot, actual.EpistemicSnapshot, "subjective");
        Same(expected.HouseholdSnapshot, actual.HouseholdSnapshot, "households");
        Same(expected.History, actual.History, "history");
        Same(expected.DecisionHistory, actual.DecisionHistory, "decision history");
        Assert.AreEqual(Hidden(expected), Hidden(actual), "S5 hidden authority mismatch");
        foreach (PersonId p in expected.Snapshot.People.Keys) Same(expected.KnowledgeOf(p), actual.KnowledgeOf(p), "observer");
        foreach (HouseholdId h in expected.HouseholdSnapshot.Households.Keys)
        {
            Same(expected.HouseholdSnapshot.Participants(h), actual.HouseholdSnapshot.Participants(h), "participants");
            Assert.AreEqual(expected.HouseholdSnapshot.MobilizableCapacity(h, expected.Snapshot),
                actual.HouseholdSnapshot.MobilizableCapacity(h, actual.Snapshot), "capacity");
            foreach (HouseholdId other in expected.HouseholdSnapshot.Households.Keys)
            {
                Assert.AreEqual(expected.HouseholdSnapshot.DerivedFrom(h, other), actual.HouseholdSnapshot.DerivedFrom(h, other));
                Assert.AreEqual(expected.HouseholdSnapshot.AncestorOf(h, other), actual.HouseholdSnapshot.AncestorOf(h, other));
            }
        }
    }

    internal static void PrefixAndOrder(Simulation sim, SemanticEvent[] prefix)
    {
        Same(prefix, sim.History.Take(prefix.Length).ToArray(), "immutable history prefix");
        foreach (var cycle in sim.History.GroupBy(e => e.Cycle))
        {
            int[] indices = [.. cycle.Select(e => e.ReactionIndex)];
            Assert.IsTrue(indices.SequenceEqual(indices.Order()) && indices.Distinct().Count() == indices.Length);
        }
        HashSet<EventId> known = [];
        foreach (SemanticEvent e in sim.History)
        {
            Assert.IsTrue(e.Causes.All(known.Contains), "Unresolved causal predecessor");
            Assert.IsTrue(known.Add(e.Id), "Event identity reused");
        }
    }
}

