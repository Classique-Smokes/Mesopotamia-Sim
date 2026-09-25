using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public readonly record struct PersonId(long Value);
public readonly record struct DwellingId(long Value);
public readonly record struct RelationId(long Value);
public readonly record struct ProposalId(long Value);
public readonly record struct EventId(long Value);
public enum Sex { Male, Female }
public enum KinshipKind { ParentChild, Sibling }
public sealed record Person(PersonId Id, string Name, Sex Sex, long Grain, bool NeedsGrain = false);
public sealed record Dwelling(DwellingId Id);
public sealed record Residence(RelationId Id, PersonId Person, DwellingId Dwelling);
public sealed record Attitude(RelationId Id, PersonId From, PersonId To, int Value);
public sealed record Kinship(RelationId Id, PersonId First, PersonId Second, KinshipKind Kind);
public sealed record Marriage(RelationId Id, PersonId Groom, PersonId Bride, EventId? Origin = null);
public sealed record Debt(RelationId Id, PersonId Creditor, PersonId Debtor, long Original,
    long Remaining, long CommittedCycle, bool DueReviewed, EventId Origin);
public sealed record Favour(RelationId Id, PersonId Debtor, PersonId Holder, bool Outstanding, EventId Origin);
public sealed record GrainInput(long Id, long Cycle, PersonId Person, long Delta);
public sealed record Configuration(string Version = "SFL-S2-v1")
{
    public const string RulesVersion = "SFL-S2-v1";
}

public sealed record InitialWorld(
    ImmutableArray<Person> People,
    ImmutableArray<Dwelling> Dwellings,
    ImmutableArray<Residence> Residences,
    ImmutableArray<Attitude> Attitudes,
    ImmutableArray<Kinship> Kinships,
    ImmutableArray<Marriage> Marriages,
    ImmutableArray<GrainInput> Inputs,
    Configuration Configuration)
{
    public ImmutableArray<InitialKnowledge> Knowledge { get; init; } = [];
    public ImmutableArray<CandidateReferent> Candidates { get; init; } = [];
}

/// <summary>Immutable materialized view. Dictionaries are authoritative copies, not derived caches.</summary>
public sealed record WorldSnapshot(
    long Cycle,
    ImmutableDictionary<PersonId, Person> People,
    ImmutableDictionary<DwellingId, Dwelling> Dwellings,
    ImmutableDictionary<RelationId, Residence> Residences,
    ImmutableDictionary<RelationId, Attitude> Attitudes,
    ImmutableDictionary<RelationId, Kinship> Kinships,
    ImmutableDictionary<RelationId, Marriage> Marriages,
    ImmutableDictionary<RelationId, Debt> Debts,
    ImmutableDictionary<RelationId, Favour> Favours)
{
    public int AttitudeOf(PersonId from, PersonId to) =>
        Attitudes.Values.SingleOrDefault(a => a.From == from && a.To == to)?.Value ?? 0;
    public DwellingId HomeOf(PersonId person) => Residences.Values.Single(r => r.Person == person).Dwelling;
    public bool AreKin(PersonId a, PersonId b) => Kinships.Values.Any(k =>
        (k.First == a && k.Second == b) || (k.First == b && k.Second == a));
    public bool AreMarried(PersonId a, PersonId b) => Marriages.Values.Any(m =>
        (m.Groom == a && m.Bride == b) || (m.Groom == b && m.Bride == a));
    public bool HasMarriage(PersonId person) => Marriages.Values.Any(m => m.Groom == person || m.Bride == person);
    public bool HasFavour(PersonId debtor, PersonId holder) =>
        Favours.Values.Any(f => f.Debtor == debtor && f.Holder == holder && f.Outstanding);
}

internal sealed partial class WorldState
{
    internal Dictionary<PersonId, Person> People { get; }
    internal Dictionary<DwellingId, Dwelling> Dwellings { get; }
    internal Dictionary<RelationId, Residence> Residences { get; }
    internal Dictionary<RelationId, Attitude> Attitudes { get; }
    internal Dictionary<RelationId, Kinship> Kinships { get; }
    internal Dictionary<RelationId, Marriage> Marriages { get; }
    internal Dictionary<RelationId, Debt> Debts { get; } = [];
    internal Dictionary<RelationId, Favour> Favours { get; } = [];
    private long nextRelation;

    internal WorldState(InitialWorld initial)
    {
        People = initial.People.ToDictionary(p => p.Id);
        Dwellings = initial.Dwellings.ToDictionary(d => d.Id);
        Residences = initial.Residences.ToDictionary(r => r.Id);
        Attitudes = initial.Attitudes.ToDictionary(a => a.Id);
        Kinships = initial.Kinships.ToDictionary(k => k.Id);
        Marriages = initial.Marriages.ToDictionary(m => m.Id);
        long[] ids = [.. Residences.Keys.Select(i => i.Value), .. Attitudes.Keys.Select(i => i.Value),
            .. Kinships.Keys.Select(i => i.Value), .. Marriages.Keys.Select(i => i.Value)];
        if (ids.Any(i => i <= 0) || ids.Distinct().Count() != ids.Length)
            throw new ArgumentException("Relation IDs must be positive and unique.", nameof(initial));
        nextRelation = checked(ids.DefaultIfEmpty(0).Max() + 1);
        Validate();
    }

    internal RelationId AllocateRelation() => new(checked(nextRelation++));
    private WorldState(WorldState source)
    {
        People = new(source.People);
        Dwellings = new(source.Dwellings);
        Residences = new(source.Residences);
        Attitudes = new(source.Attitudes);
        Kinships = new(source.Kinships);
        Marriages = new(source.Marriages);
        Debts = new(source.Debts);
        Favours = new(source.Favours);
        nextRelation = source.nextRelation;
    }
    internal WorldState Copy() => new(this);
    internal WorldSnapshot Snapshot(long cycle) => new(cycle, People.ToImmutableDictionary(),
        Dwellings.ToImmutableDictionary(), Residences.ToImmutableDictionary(), Attitudes.ToImmutableDictionary(),
        Kinships.ToImmutableDictionary(), Marriages.ToImmutableDictionary(), Debts.ToImmutableDictionary(), Favours.ToImmutableDictionary());

    internal void Validate()
    {
        if (People.Keys.Any(i => i.Value <= 0) || Dwellings.Keys.Any(i => i.Value <= 0))
            throw new ArgumentException("Entity IDs must be positive.");
        foreach (Person person in People.Values)
        {
            if (person.Grain < 0 || (person.NeedsGrain && person.Grain > 0))
                throw new ArgumentException("Invalid grain/need state.");
            if (Residences.Values.Count(r => r.Person == person.Id) != 1)
                throw new ArgumentException("Each person requires exactly one residence.");
        }
        foreach (Residence residence in Residences.Values)
            if (!People.ContainsKey(residence.Person) || !Dwellings.ContainsKey(residence.Dwelling))
                throw new ArgumentException("Unresolved residence reference.");
        foreach (Attitude attitude in Attitudes.Values)
        {
            CheckPeopleExist(attitude.From, attitude.To);
            if (attitude.Value is < -100 or > 100) throw new ArgumentException("Attitude outside bounds.");
        }
        if (Attitudes.Values.Select(a => (a.From, a.To)).Distinct().Count() != Attitudes.Count)
            throw new ArgumentException("Duplicate directed attitude.");
        foreach (Kinship kinship in Kinships.Values)
        {
            CheckPeopleExist(kinship.First, kinship.Second);
            if (kinship.First == kinship.Second) throw new ArgumentException("Kinship requires distinct people.");
        }
        foreach (Marriage marriage in Marriages.Values)
        {
            CheckPeopleExist(marriage.Groom, marriage.Bride);
            if (marriage.Groom == marriage.Bride) throw new ArgumentException("Marriage requires distinct people.");
            if (People[marriage.Groom].Sex != Sex.Male || People[marriage.Bride].Sex != Sex.Female ||
                Snapshot(0).AreKin(marriage.Groom, marriage.Bride)) throw new ArgumentException("Invalid marriage.");
        }
        if (Marriages.Values.SelectMany(m => new[] { m.Groom, m.Bride }).GroupBy(i => i).Any(g => g.Count() > 1))
            throw new ArgumentException("Multiple established marriages.");
        foreach (Debt debt in Debts.Values)
        {
            CheckPeopleExist(debt.Creditor, debt.Debtor);
            if (debt.Creditor == debt.Debtor) throw new ArgumentException("Debt requires distinct people.");
            if (debt.Original <= 0 || debt.Remaining < 0 || debt.Remaining > debt.Original)
                throw new ArgumentException("Invalid debt balance.");
        }
        foreach (Favour favour in Favours.Values)
        {
            CheckPeopleExist(favour.Debtor, favour.Holder);
            if (favour.Debtor == favour.Holder) throw new ArgumentException("Favour requires distinct people.");
        }
        if (Favours.Values.Where(f => f.Outstanding).GroupBy(f => (f.Debtor, f.Holder)).Any(g => g.Count() > 1))
            throw new ArgumentException("Favour capacity exceeded.");
    }

    private void CheckPeopleExist(PersonId a, PersonId b)
    {
        if (!People.ContainsKey(a) || !People.ContainsKey(b))
            throw new ArgumentException("Unresolved relation participants.");
    }
}
