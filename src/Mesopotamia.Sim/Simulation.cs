namespace Mesopotamia.Sim;

public sealed partial class Simulation
{
    private WorldState state;
    private readonly InitialWorld initial;
    private long cycle;
    private WorldSnapshot published;
    private EpistemicState epistemic;
    private EpistemicSnapshot publishedEpistemic;

    public Simulation(InitialWorld initial)
    {
        ArgumentNullException.ThrowIfNull(initial);
        this.initial = initial;
        state = new WorldState(initial);
        cycle = 0;
        published = state.Snapshot(cycle);
        epistemic = new(initial);
        AcquireInitialFacts();
        publishedEpistemic = epistemic.Snapshot(cycle);
        publishedHouseholds = households.Snapshot(cycle);
        if (initial.Inputs.Any(i => i.Id <= 0 || i.Cycle <= 0 || !state.People.ContainsKey(i.Person)) ||
            initial.Inputs.Select(i => i.Id).Distinct().Count() != initial.Inputs.Length)
            throw new ArgumentException("Invalid input schedule.", nameof(initial));
    }

    public WorldSnapshot Snapshot => published;
    public Configuration Configuration => initial.Configuration;
    private string ActiveRulesVersion => initial.Configuration.Version == "SFL-S3-v1" ? "SFL-S3-v1" : Configuration.RulesVersion;
    public EpistemicSnapshot EpistemicSnapshot => publishedEpistemic;
    public ActorEpistemicState EpistemicStateOf(PersonId actor) => publishedEpistemic.Actors[actor];
}
