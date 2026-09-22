namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private readonly WorldState state;
    private readonly InitialWorld initial;
    private long cycle;
    private WorldSnapshot published;

    public Simulation(InitialWorld initial)
    {
        ArgumentNullException.ThrowIfNull(initial);
        this.initial = initial;
        state = new WorldState(initial);
        cycle = 0;
        published = state.Snapshot(cycle);
        if (initial.Inputs.Any(i => i.Id <= 0 || i.Cycle <= 0 || !state.People.ContainsKey(i.Person)) ||
            initial.Inputs.Select(i => i.Id).Distinct().Count() != initial.Inputs.Length)
            throw new ArgumentException("Invalid input schedule.", nameof(initial));
    }

    public WorldSnapshot Snapshot => published;
    public Configuration Configuration => initial.Configuration;
}
