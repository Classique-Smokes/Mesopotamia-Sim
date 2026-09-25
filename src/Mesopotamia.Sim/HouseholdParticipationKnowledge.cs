using System.Collections.Immutable;

namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private void AcquireSustainingFact(SustainingParticipant association, SemanticEvent cause, ImmutableArray<PersonId> observers)
    {
        List<AcquiredFact> receipts = [];
        foreach (PersonId actor in observers.Distinct().OrderBy(p => p.Value))
        {
            SustainingParticipationFact proposition = new(association.Household, association.Id, association.Person, association.End is null, cause.Id);
            epistemic.Acquire(actor, proposition, AcquisitionRoute.Participation, new(actor, cause.Id, new(cause.Cycle, cause.ReactionIndex)));
            receipts.AddRange(epistemic.Of(actor).Facts.Where(f => f.Proposition == proposition).Select(f => new AcquiredFact(actor, f)));
        }
        int index = events.FindIndex(e => e.Id == cause.Id);
        events[index] = events[index] with { AcquiredEvidence = [.. events[index].AcquiredEvidence, .. receipts] };
    }
}
