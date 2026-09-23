using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Mesopotamia.Sim;

public readonly record struct EvidenceId(long Value);
public readonly record struct CandidateId(long Value);
public enum AcquisitionRoute { OwnState, DirectParty, Participation, Communication, Fixture }
public enum RecognitionStatus { Unknown, Recognized, Contested }
public sealed record EvidenceOrder(long Cycle, int ReactionIndex) : IComparable<EvidenceOrder>
{
    public int CompareTo(EvidenceOrder? other) => other is null ? 1 :
        Cycle != other.Cycle ? Cycle.CompareTo(other.Cycle) : ReactionIndex.CompareTo(other.ReactionIndex);
}
public sealed record EvidenceOrigin(PersonId? Source, EventId? Event, EvidenceOrder? Order, string? Fixture = null);
public sealed record CommunicationHop(PersonId Sender, PersonId Recipient, EventId Event, EvidenceOrder Delivered);
public sealed record EvidenceProvenance(AcquisitionRoute Route, EvidenceOrigin Origin, ImmutableArray<CommunicationHop> Hops);

[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(OwnStateFact), "own")]
[JsonDerivedType(typeof(ResidenceFact), "residence")]
[JsonDerivedType(typeof(AttitudeFact), "attitude")]
[JsonDerivedType(typeof(KinshipFact), "kinship")]
[JsonDerivedType(typeof(MarriageFact), "marriage")]
[JsonDerivedType(typeof(DebtFact), "debt")]
[JsonDerivedType(typeof(FavourFact), "favour")]
[JsonDerivedType(typeof(ParticipationFact), "participation")]
[JsonDerivedType(typeof(SupportFact), "support")]
[JsonDerivedType(typeof(HouseholdExistenceFact), "household")]
public abstract record FactualProposition;
public sealed record OwnStateFact(Person Person) : FactualProposition;
public sealed record ResidenceFact(PersonId Person, DwellingId Dwelling) : FactualProposition;
public sealed record AttitudeFact(Attitude Attitude) : FactualProposition;
public sealed record KinshipFact(Kinship Kinship) : FactualProposition;
public sealed record MarriageFact(Marriage Marriage) : FactualProposition;
public sealed record DebtFact(Debt Debt) : FactualProposition;
public sealed record FavourFact(Favour Favour) : FactualProposition;
public sealed record ParticipationFact(ParticipantOutcome Outcome) : FactualProposition;
public enum SupportKind { Gift, Help, Loan, FavourFulfilment }
public sealed record SupportFact(EventId Event, long Cycle, PersonId First, PersonId Second, SupportKind Kind) : FactualProposition
{
    public EvidenceOrder? Order { get; init; }
}
public sealed record KnownFact(EvidenceId Id, FactualProposition Proposition, EvidenceProvenance Provenance);

/// <summary>Inert laboratory referent, never an organization or a formation result.</summary>
public sealed record CandidateReferent(CandidateId Id, ImmutableArray<PersonId> Core, bool IsLive = true);
public sealed record CandidateRecognition(CandidateId Candidate, RecognitionStatus Status, ImmutableArray<KnownFact> Evidence);
public sealed record ActorEpistemicState(PersonId Actor, ImmutableArray<KnownFact> Facts,
    ImmutableArray<CandidateRecognition> Recognitions)
{
    public ImmutableArray<HouseholdRecognition> HouseholdRecognitions { get; init; } = [];
    public RecognitionStatus HouseholdRecognitionOf(HouseholdId household) =>
        HouseholdRecognitions.SingleOrDefault(r => r.Household == household)?.Status ?? RecognitionStatus.Unknown;
    public RecognitionStatus RecognitionOf(CandidateId candidate) =>
        Recognitions.SingleOrDefault(r => r.Candidate == candidate)?.Status ?? RecognitionStatus.Unknown;
}
public sealed record InitialKnowledge(PersonId Actor, ImmutableArray<KnownFact> Facts);
public sealed record EpistemicSnapshot(long Cycle, ImmutableDictionary<PersonId, ActorEpistemicState> Actors);

// Finite subject slots only; these are not a user-extensible predicate language.
internal static class EpistemicRules
{
    internal static bool SameSubject(FactualProposition a, FactualProposition b) => (a, b) switch
    {
        (OwnStateFact x, OwnStateFact y) => x.Person.Id == y.Person.Id,
        (ResidenceFact x, ResidenceFact y) => x.Person == y.Person,
        (AttitudeFact x, AttitudeFact y) => x.Attitude.Id == y.Attitude.Id,
        (KinshipFact x, KinshipFact y) => x.Kinship.Id == y.Kinship.Id,
        (MarriageFact x, MarriageFact y) => x.Marriage.Id == y.Marriage.Id,
        (DebtFact x, DebtFact y) => x.Debt.Id == y.Debt.Id,
        (FavourFact x, FavourFact y) => x.Favour.Id == y.Favour.Id,
        (ParticipationFact x, ParticipationFact y) => x.Outcome.Event == y.Outcome.Event,
        (SupportFact x, SupportFact y) => x.Event == y.Event,
        (HouseholdExistenceFact x, HouseholdExistenceFact y) => x.Household == y.Household,
        _ => false
    };

    internal static bool Supersedes(KnownFact newer, KnownFact older)
    {
        if (!SameSubject(newer.Proposition, older.Proposition) ||
            newer.Provenance.Origin.Order is not { } n || older.Provenance.Origin.Order is not { } o || n.CompareTo(o) <= 0)
            return false;
        bool direct = newer.Provenance.Route is AcquisitionRoute.OwnState or AcquisitionRoute.DirectParty or AcquisitionRoute.Participation;
        bool oldReport = older.Provenance.Route is AcquisitionRoute.Communication or AcquisitionRoute.Fixture;
        return direct || newer.Provenance.Route == AcquisitionRoute.Communication && oldReport && newer.Provenance.Origin.Event is not null;
    }

    internal static CandidateRecognition Recognize(CandidateReferent candidate, ImmutableArray<KnownFact> facts)
    {
        if (!candidate.IsLive || candidate.Core.Length < 2) return new(candidate.Id, RecognitionStatus.Unknown, []);
        HashSet<PersonId> core = [.. candidate.Core];
        KnownFact[] relevant = facts.Where(f => f.Proposition switch
        {
            ResidenceFact r => core.Contains(r.Person),
            KinshipFact k => core.Contains(k.Kinship.First) && core.Contains(k.Kinship.Second),
            MarriageFact m => core.Contains(m.Marriage.Groom) && core.Contains(m.Marriage.Bride),
            AttitudeFact a => core.Contains(a.Attitude.From) && core.Contains(a.Attitude.To),
            SupportFact s => core.Contains(s.First) && core.Contains(s.Second),
            _ => false
        }).ToArray();
        ResidenceFact[] residences = relevant.Select(f => f.Proposition).OfType<ResidenceFact>().ToArray();
        bool shared = residences.Select(r => r.Dwelling).Distinct().Any(d => core.All(p => residences.Any(r => r.Person == p && r.Dwelling == d)));
        HashSet<PersonId> connected = [candidate.Core[0]];
        bool changed;
        do
        {
            changed = false;
            foreach (PersonId a in core)
                foreach (PersonId b in core)
                    if (connected.Contains(a) && !connected.Contains(b) && Tied(a, b)) changed |= connected.Add(b);
        } while (changed);
        bool Tied(PersonId a, PersonId b) => relevant.Any(f => f.Proposition switch
        {
            KinshipFact k => k.Kinship.First == a && k.Kinship.Second == b || k.Kinship.First == b && k.Kinship.Second == a,
            MarriageFact m => m.Marriage.Groom == a && m.Marriage.Bride == b || m.Marriage.Groom == b && m.Marriage.Bride == a,
            _ => false
        }) || relevant.Any(f => f.Proposition is AttitudeFact x && x.Attitude.From == a && x.Attitude.To == b && x.Attitude.Value >= 75) &&
            relevant.Any(f => f.Proposition is AttitudeFact x && x.Attitude.From == b && x.Attitude.To == a && x.Attitude.Value >= 75);
        bool supported = relevant.Select(f => f.Proposition).OfType<SupportFact>().Select(s => s.Cycle).Distinct().Count() >= 2;
        bool conflict = residences.GroupBy(r => r.Person).Any(g => g.Select(r => r.Dwelling).Distinct().Count() > 1);
        RecognitionStatus status = shared && connected.Count == core.Count && supported ?
            conflict ? RecognitionStatus.Contested : RecognitionStatus.Recognized : RecognitionStatus.Unknown;
        return new(candidate.Id, status, [.. relevant.OrderBy(f => f.Id.Value)]);
    }
}

internal sealed class EpistemicState
{
    private readonly Dictionary<PersonId, List<KnownFact>> facts;
    private ImmutableArray<CandidateReferent> candidates;
    internal ImmutableArray<CandidateReferent> Candidates => candidates;
    internal void DeclareCandidate(CandidateReferent candidate)
    {
        if (candidate.Id.Value <= 0 || candidates.Any(c => c.Id == candidate.Id) || candidate.Core.IsDefaultOrEmpty ||
            candidate.Core.Distinct().Count() != candidate.Core.Length || candidate.Core.Any(p => !facts.ContainsKey(p)))
            throw new ArgumentException("A candidate requires a fresh stable referent and a declared nonempty core.", nameof(candidate));
        candidates = candidates.Add(candidate);
    }
    private long nextEvidence;

    internal EpistemicState(InitialWorld initial)
    {
        facts = initial.People.ToDictionary(p => p.Id, _ => new List<KnownFact>());
        candidates = initial.Candidates;
        if (candidates.Select(c => c.Id).Distinct().Count() != candidates.Length || candidates.Any(c => c.Id.Value <= 0 || c.Core.Length < 1 || c.Core.Distinct().Count() != c.Core.Length || c.Core.Any(p => !facts.ContainsKey(p))))
            throw new ArgumentException("Each bounded episode requires its own inert candidate with a valid fixed core; convergence is unsupported.", nameof(initial));
        KnownFact[] seeds = initial.Knowledge.SelectMany(k => k.Facts).ToArray();
        if (initial.Knowledge.Any(k => !facts.ContainsKey(k.Actor)) || seeds.Any(f => f.Id.Value <= 0 || string.IsNullOrWhiteSpace(f.Provenance.Origin.Fixture) ||
                f.Provenance.Route != AcquisitionRoute.Fixture || f.Provenance.Hops.IsDefault || !f.Provenance.Hops.IsEmpty ||
                f.Provenance.Origin.Source is { } source && !facts.ContainsKey(source) ||
                f.Provenance.Origin.Event is { Value: <= 0 } || f.Provenance.Origin.Order is { ReactionIndex: < 0 } || !Valid(f.Proposition)) ||
            seeds.Select(f => f.Id).Distinct().Count() != seeds.Length)
            throw new ArgumentException("Initial evidence requires unique positive IDs and explicit fixture provenance.", nameof(initial));
        if (seeds.Select(f => f.Proposition).OfType<SupportFact>().GroupBy(s => s.Event).Any(g => g.Distinct().Count() != 1))
            throw new ArgumentException("A support event identity cannot describe multiple events.", nameof(initial));
        nextEvidence = checked(seeds.Select(f => f.Id.Value).DefaultIfEmpty(0).Max() + 1);
        foreach (InitialKnowledge seed in initial.Knowledge)
            foreach (KnownFact fact in seed.Facts) Add(seed.Actor, fact);

        bool Pair(PersonId a, PersonId b) => a != b && facts.ContainsKey(a) && facts.ContainsKey(b);
        bool Valid(FactualProposition proposition) => proposition switch
        {
            OwnStateFact f => facts.ContainsKey(f.Person.Id) && Enum.IsDefined(f.Person.Sex) && f.Person.Grain >= 0 && (!f.Person.NeedsGrain || f.Person.Grain == 0),
            ResidenceFact f => facts.ContainsKey(f.Person) && initial.Dwellings.Any(d => d.Id == f.Dwelling),
            AttitudeFact f => f.Attitude.Id.Value > 0 && Pair(f.Attitude.From, f.Attitude.To) && f.Attitude.Value is >= -100 and <= 100,
            KinshipFact f => f.Kinship.Id.Value > 0 && Pair(f.Kinship.First, f.Kinship.Second) && Enum.IsDefined(f.Kinship.Kind),
            MarriageFact f => f.Marriage.Id.Value > 0 && Pair(f.Marriage.Groom, f.Marriage.Bride),
            DebtFact f => f.Debt.Id.Value > 0 && Pair(f.Debt.Creditor, f.Debt.Debtor) && f.Debt.Original > 0 && f.Debt.Remaining >= 0 && f.Debt.Remaining <= f.Debt.Original,
            FavourFact f => f.Favour.Id.Value > 0 && Pair(f.Favour.Debtor, f.Favour.Holder),
            ParticipationFact f => f.Outcome.Event.Value > 0 && f.Outcome.Proposal.Value > 0 && Enum.IsDefined(f.Outcome.Kind) && f.Outcome.Kind != OutcomeKind.InvalidTerms,
            SupportFact f => f.Event.Value > 0 && f.Cycle > 0 && Pair(f.First, f.Second) && Enum.IsDefined(f.Kind),
            _ => false
        };
    }

    private EpistemicState(EpistemicState source)
    {
        facts = source.facts.ToDictionary(p => p.Key, p => new List<KnownFact>(p.Value));
        candidates = source.candidates;
        nextEvidence = source.nextEvidence;
    }
    internal EpistemicState Copy() => new(this);
    internal ActorEpistemicState Of(PersonId actor)
    {
        ImmutableArray<KnownFact> held = [.. facts[actor].OrderBy(f => f.Id.Value)];
        return new(actor, held, [.. candidates.OrderBy(c => c.Id.Value).Select(c => EpistemicRules.Recognize(c, held))])
        {
            HouseholdRecognitions = [.. held.Where(f => f.Proposition is HouseholdExistenceFact)
                .GroupBy(f => ((HouseholdExistenceFact)f.Proposition).Household).OrderBy(g => g.Key.Value)
                .Select(g => new HouseholdRecognition(g.Key,
                    g.All(f => ((HouseholdExistenceFact)f.Proposition).Continues) ? RecognitionStatus.Recognized :
                    g.Any(f => ((HouseholdExistenceFact)f.Proposition).Continues) ? RecognitionStatus.Contested : RecognitionStatus.Unknown, [.. g]))]
        };
    }
    internal EpistemicSnapshot Snapshot(long cycle) => new(cycle, facts.Keys.ToImmutableDictionary(p => p, Of));
    internal void Acquire(PersonId actor, FactualProposition proposition, AcquisitionRoute route, EvidenceOrigin origin)
    {
        if (facts[actor].Any(f => f.Proposition == proposition && f.Provenance.Route == route)) return;
        Add(actor, new(new(checked(nextEvidence++)), proposition, new(route, origin, [])));
    }
    internal void Receive(PersonId sender, PersonId recipient, ImmutableArray<KnownFact> payload, SemanticEvent delivery)
    {
        foreach (KnownFact fact in payload)
            Add(recipient, new(new(checked(nextEvidence++)), fact.Proposition,
                new(AcquisitionRoute.Communication, fact.Provenance.Origin,
                    [.. fact.Provenance.Hops, new(sender, recipient, delivery.Id, new(delivery.Cycle, delivery.ReactionIndex))])));
    }
    private void Add(PersonId actor, KnownFact incoming)
    {
        List<KnownFact> held = facts[actor];
        if (held.Any(f => EpistemicRules.Supersedes(f, incoming))) return;
        held.RemoveAll(f => EpistemicRules.Supersedes(incoming, f));
        held.Add(incoming);
    }
}
