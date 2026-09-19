# WIP-0001 — Household Organization Architecture

**Status:** WORKING / NON-AUTHORITATIVE  
**Owner:** Master Architect  
**Architecture review:** Decision 3

Checkpoint of current convergence and unresolved questions. It is not an accepted ADR and must not be used as implementation authority.

## Current convergence

### Recognition / formation

Current direction combines lower-level relational structure, recurring organized activity, and endogenous recognition by simulated people.

Recognition can legitimately reinforce organization when it is represented as a modeled belief/response that changes behavior. An unexplained engine label must not create its own supporting evidence.

### Continuity / identity

Current direction favors **historical transmission**. Different households may acquire different identity anchors over time (examples under discussion include estate/property, lineage/succession, cult/ancestor responsibilities, recurring activity, roles, or external commitments). These examples are not accepted universal rules.

Identity, descent, and similarity remain distinguishable. Contested continuity should remain architecturally possible but is not required in the first prototype.

### Collective state / capacity

Current direction distinguishes persistent historical/path-dependent collective state from operational values derived from lower-level support. The update/caching/dependency mechanism is unresolved.

### Internal organization / broker roles

Current direction favors persistent organizational roles occupied by changing individuals, with scoped authority and social/organizational backing. Broker/head selection, vacancy, legitimacy, succession, contestation, and role creation/abolition remain unresolved.

## Working design lead — household accounting

Preserve this idea for later analysis without treating it as accepted architecture:

- Small collectives may need little explicit bookkeeping because relevant information is locally legible.
- Larger/more complex collectives may require reporting, accounting, information-maintenance processes, or specialized roles.
- Individuals are not cloned into every organization they participate in; finite time/attention/capacity limits simultaneous commitments.
- Higher organizations receive only the information/resources/capacities actually connected through modeled relations.
- A possible implementation direction is to divide responsibility for updates: some collective state is maintained locally, while constituent changes notify/revise relevant organizational state. The exact mechanism is unresolved.

This analogy may eventually allow organizational complexity and administrative roles to emerge from both historical/social needs and computationally bounded information flow. It is a design hypothesis, not a current mechanic.

## Immediate unresolved questions

1. How is subjective recognition/belief represented separately from objective world state?
2. How does candidate organization become persistent recognized identity without engine-only self-confirmation?
3. How are household-specific continuity anchors created, strengthened, weakened, transmitted, or contested?
4. How is a broker/head role established or refilled, and what makes its authority effective?
5. Which collective values are persistent authoritative state, derived values, or actor beliefs/reports?
6. How are derived values updated without double-counting scarce constituent capacity or triggering uncontrolled dependency cascades?

## First-prototype restraint

The first laboratory need only exercise enough to test:

- organization emerging from lower-level relationships/arrangements;
- one collective identity surviving limited turnover;
- one scoped representative role;
- one grounded collective capability feeding back into individual options;
- explainable change when supporting lower-level facts change.

Contested continuity, dynamically created offices, deep nesting, and administrative specialization are future-capability considerations, not first-implementation requirements.
