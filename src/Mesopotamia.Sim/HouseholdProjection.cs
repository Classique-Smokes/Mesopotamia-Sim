using System.Text.Json;
using System.Text;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private string HouseholdProjectionKey(Simulation projection, bool faulted)
    {
        // The boundary is the live pre-resolution state, not the original fixture.
        // Existing identities remain exact. Only detached allocations are renamed.
        Dictionary<EventId, SemanticEvent> history = projection.events.ToDictionary(e => e.Id);
        Dictionary<EventId, string> eventKeys = events.ToDictionary(e => e.Id, e => "existing:" + e.Id.Value);
        string EventKey(EventId id)
        {
            if (eventKeys.TryGetValue(id, out string? key)) return key;
            if (!history.TryGetValue(id, out SemanticEvent? e)) return "external:" + id.Value;
            key = JsonSerializer.Serialize(new
            {
                e.Cycle,
                e.Kind,
                e.Proposal,
                e.Participants,
                Causes = e.Causes.Select(EventKey).Order(StringComparer.Ordinal),
                // Household details carry warrant/association/lifecycle identity.
                Household = e.RulesVersion == HouseholdRulesVersion ? e.Detail : null
            });
            key = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(key)));
            eventKeys.Add(id, key);
            return key;
        }
        WorldSnapshot before = state.Snapshot(cycle);
        HashSet<RelationId> existing = [.. before.Residences.Keys, .. before.Attitudes.Keys, .. before.Kinships.Keys,
            .. before.Marriages.Keys, .. before.Debts.Keys, .. before.Favours.Keys];
        Dictionary<RelationId, string> relations = existing.ToDictionary(id => id, id => "existing:" + id.Value);
        foreach (Debt d in projection.state.Debts.Values.Where(d => !existing.Contains(d.Id))) relations.Add(d.Id, "debt:" + EventKey(d.Origin));
        foreach (Favour f in projection.state.Favours.Values.Where(f => !existing.Contains(f.Id))) relations.Add(f.Id, "favour:" + EventKey(f.Origin));
        foreach (Marriage m in projection.state.Marriages.Values.Where(m => !existing.Contains(m.Id))) relations.Add(m.Id, "marriage:" + EventKey(m.Origin!.Value));
        foreach (Attitude a in projection.state.Attitudes.Values.Where(a => !existing.Contains(a.Id))) relations.Add(a.Id, $"attitude:{a.From.Value}:{a.To.Value}");
        Dictionary<EvidenceOrder, EventId> times = history.Values.ToDictionary(e => new EvidenceOrder(e.Cycle, e.ReactionIndex), e => e.Id);
        JsonSerializerOptions options = new();
        options.Converters.Add(new ProjectionIdentityConverter<EventId>(EventKey));
        options.Converters.Add(new ProjectionIdentityConverter<RelationId>(id => relations.GetValueOrDefault(id, "external:" + id.Value)));
        options.Converters.Add(new ProjectionIdentityConverter<EvidenceOrder>(time => times.TryGetValue(time, out EventId id) ? EventKey(id) : $"time:{time.Cycle}:{time.ReactionIndex}"));
        options.Converters.Add(new ProjectionIdentityConverter<HouseholdHeadRoleId>(id => households.HeadRoles.ContainsKey(id)
            ? "existing:" + id.Value : "role:" + EventKey(projection.households.HeadRoles[id].Origin)));
        options.Converters.Add(new ProjectionIdentityConverter<CommitmentId>(id => households.Commitments.ContainsKey(id)
            ? "existing:" + id.Value : projection.households.Commitments[id].Provenance switch
            {
                EndogenousProvisionOrigin origin => "commitment:" + EventKey(origin.Created),
                SelfProvisionOrigin origin => "commitment:" + EventKey(origin.Created),
                _ => "external:" + id.Value
            }));
        HashSet<EventId> boundaryEvents = [.. events.Select(e => e.Id)];
        string FactKey(KnownFact f)
        {
            // Own-state refresh is the accumulated material endpoint. The last of
            // two additive transfers is not its sole causal origin; retain every
            // contributing event, not the incidental last refresh ordinal.
            if (f.Proposition is OwnStateFact own && f.Provenance.Route == AcquisitionRoute.OwnState &&
                f.Provenance.Origin.Event is { } origin && !boundaryEvents.Contains(origin))
                return JsonSerializer.Serialize(new
                {
                    f.Proposition,
                    f.Provenance.Route,
                    f.Provenance.Origin.Source,
                    f.Provenance.Origin.Fixture,
                    Cycle = f.Provenance.Origin.Order?.Cycle,
                    Causes = projection.events.Where(e => !boundaryEvents.Contains(e.Id) &&
                        e.ReactionIndex <= history[origin].ReactionIndex && e.Material.Any(m => m.Person == own.Person.Id))
                        .Select(e => EventKey(e.Id)).Order(StringComparer.Ordinal),
                    f.Provenance.Hops
                }, options);
            return JsonSerializer.Serialize(new { f.Proposition, f.Provenance }, options);
        }
        Dictionary<EvidenceId, string> evidence = epistemic.Snapshot(cycle).Actors.Values.SelectMany(a => a.Facts)
            .Concat(households.Formations.Values.SelectMany(f => f.Recognition).SelectMany(r => r.Evidence))
            .Concat(households.Entries.Values.SelectMany(f => f.Recognition).SelectMany(r => r.Evidence))
            .Concat(households.Continuations.Values.SelectMany(f => f.Recognition).SelectMany(r => r.Evidence))
            .Select(f => f.Id).Distinct().ToDictionary(id => id, id => "existing:" + id.Value);
        options.Converters.Add(new ProjectionIdentityConverter<EvidenceId>(id => evidence.GetValueOrDefault(id, "external:" + id.Value)));
        options.Converters.Add(new ProjectionIdentityConverter<KnownFact>(f => JsonSerializer.Serialize(new { Identity = evidence.GetValueOrDefault(f.Id, FactKey(f)), Content = FactKey(f) })));
        foreach (KnownFact fact in projection.epistemic.Snapshot(cycle).Actors.Values.SelectMany(a => a.Facts)
            .Concat(projection.households.Formations.Values.SelectMany(f => f.Recognition).SelectMany(r => r.Evidence))
            .Concat(projection.households.Entries.Values.SelectMany(f => f.Recognition).SelectMany(r => r.Evidence))
            .Concat(projection.households.Continuations.Values.SelectMany(f => f.Recognition).SelectMany(r => r.Evidence)))
            if (!evidence.ContainsKey(fact.Id)) evidence.Add(fact.Id, FactKey(fact));
        string[] Set<T>(IEnumerable<T> values) => [.. values.Select(v => JsonSerializer.Serialize(v, options)).Order(StringComparer.Ordinal)];
        HouseholdSnapshot h = projection.households.Snapshot(cycle);
        return JsonSerializer.Serialize(new
        {
            faulted,
            People = Set(projection.state.People.Values),
            Residences = Set(projection.state.Residences.Values),
            Attitudes = Set(projection.state.Attitudes.Values),
            Kinships = Set(projection.state.Kinships.Values),
            Marriages = Set(projection.state.Marriages.Values),
            Debts = Set(projection.state.Debts.Values),
            Favours = Set(projection.state.Favours.Values),
            Households = Set(h.Households.Values),
            Formations = Set(h.Formations.Values),
            Associations = Set(h.Associations.Values),
            Entries = Set(h.Entries.Values),
            Exits = Set(h.Exits.Values),
            Continuations = Set(h.Continuations.Values),
            Lineages = Set(h.Lineages.Values),
            Commitments = Set(h.Commitments.Values),
            HeadRoles = Set(h.HeadRoles.Values),
            HeadTransitions = Set(h.HeadTransitions.Values),
            ProvisionRefusals = Set(h.ProvisionRefusals.Values),
            Evidence = projection.epistemic.Snapshot(cycle).Actors.OrderBy(a => a.Key.Value).Select(a => new
            {
                a.Key,
                Facts = Set(a.Value.Facts),
                Candidates = a.Value.Recognitions.Select(r => new { r.Candidate, r.Status, Evidence = Set(r.Evidence) }),
                Households = a.Value.HouseholdRecognitions.Select(r => new { r.Household, r.Status, Evidence = Set(r.Evidence) }),
                Heads = a.Value.HeadRecognitions.Select(r => new { r.Household, r.Role, r.Occupant, r.Status, Evidence = Set(r.Evidence) }),
                // Order is significant between evidence about the same subject.
                // Unrelated loan origins do not gain meaning from exchanged ordinals.
                Precedence = a.Value.Facts.SelectMany(left => a.Value.Facts.Where(right =>
                    EpistemicRules.SameSubject(left.Proposition, right.Proposition) &&
                    left.Provenance.Origin.Order is { } x && right.Provenance.Origin.Order is { } y && x.CompareTo(y) < 0)
                    .Select(right => FactKey(left) + "<" + FactKey(right))).Order(StringComparer.Ordinal)
            })
        });
    }

    private sealed class ProjectionIdentityConverter<T>(Func<T, string> key) : JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotSupportedException();
        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) => writer.WriteStringValue(key(value));
    }
}
