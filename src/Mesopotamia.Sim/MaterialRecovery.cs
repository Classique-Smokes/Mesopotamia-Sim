namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private static Person ApplyGrainInput(Person person, long delta)
    {
        long after = checked(person.Grain + delta);
        if (after < 0) throw new InvalidOperationException("Exogenous debit exceeds stock.");
        return person with { Grain = after, NeedsGrain = person.NeedsGrain && after == 0 };
    }

    private static Person ConsumeGrain(Person person) => person.Grain > 0
        ? person with { Grain = person.Grain - 1 }
        : person with { NeedsGrain = true };

    private bool FutureInputsResolveMaterialBlock()
    {
        // Called only from the all-zero/NeedsGrain stable boundary. Until an
        // input batch escapes that condition, input-free cycles preserve it.
        Dictionary<PersonId, Person> projected = new(state.People);
        foreach (var inputs in initial.Inputs.Where(i => i.Cycle > cycle).OrderBy(i => i.Cycle).GroupBy(i => i.Cycle))
        {
            try
            {
                foreach (GrainInput input in inputs.OrderBy(i => i.Id))
                    projected[input.Person] = ApplyGrainInput(projected[input.Person], input.Delta);
            }
            catch (Exception error) when (error is OverflowException or InvalidOperationException)
            {
                // This diagnostic cannot execute a future failure early. A
                // faulting prefix has not demonstrated a resolving boundary;
                // ordinary execution still faults at the scheduled cycle.
                return false;
            }
            foreach (Person person in projected.Values.ToArray())
                projected[person.Id] = ConsumeGrain(person);
            if (projected.Values.Any(p => !p.NeedsGrain)) return true;
        }
        return false;
    }
}
