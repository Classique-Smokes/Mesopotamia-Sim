# VS-SFL-00x — Formation Family

## VS-SFL-001 — Three-founder formation

**Level:** mechanism-isolation  
**Claim:** A persistent household forms from lower-level social evidence and founder recognition without a household-creation fixture write.

### Initial state

- People A, B, C.
- Each starts with 12 grain and `NeedsGrain = false`.
- A, B, C reside at D1.
- Stable durable-tie graph:
  - A <-> B sibling;
  - B <-> C sibling.
- Other attitudes begin 0 unless produced by scenario events.
- No Household, FormationWarrant, SustainingParticipant, head role occupant, provision commitment, or household recognition exists.
- Each founder's initial subjective state contains scenario-sourced uncontested facts sufficient to know the three current residence facts and the durable-tie graph. Support-event knowledge is not preloaded.

### Allowed fixture writes

May create initial people/grain/residence/kinship/initial subjective observations and submit valid person-level proposals.

Must not write:

- Household;
- FormationWarrant;
- SustainingParticipant;
- CandidateRecognition;
- household recognition;
- head occupancy;
- lineage.

### Schedule

- Cycle 1: A gives 1 grain to C; C accepts.
- Cycle 2: C gives 1 grain to B; B accepts.
- Later cycles: use `CommunicateClaim/Inform` so A learns the cycle-2 support event and B learns the cycle-1 support event. C already directly participated in both.
- Stop once the last required founder can derive `CandidateRecognition(CandidateABC)` and same-cycle automatic reactions reach stable closure.

### Required causal ordering

1. two qualifying support commits exist on distinct cycles;
2. each founder independently holds uncontested evidence of residence + connected durable ties + both support events;
3. each founder reaches CandidateRecognition for the same candidate;
4. FormationWarrant commits;
5. H is created;
6. A/B/C receive provenance-bearing SustainingParticipant associations and direct recognition of H.

No fixture command may create steps 3-6.

### Terminal assertions

- exactly one newly formed H exists from this evidence;
- H is Active at stable closure;
- FormationWarrant references the three founders, D1, durable ties, both support events, founder recognition evidence, earliest sustaining evidence, and formation/reification time;
- A/B/C are SustainingParticipants with provenance to the FormationWarrant;
- H begins headless;
- no universal Members set exists;
- formation event time is distinct/queryable from earliest sustaining evidence time.

### Independent oracle

Hand-authored predicate over the recorded initial facts/events and participant subjective evidence. The oracle must not call production candidate-recognition or household-formation code.

### Adversarial companions

- omit shared residence;
- break the durable-tie graph;
- retain only one qualifying support event;
- withhold evidence so one founder cannot recognize the candidate;
- co-residence only;
- kinship only;
- marriage only;
- mutual-strong-like only.

Each companion must prevent alternate paths from recreating the removed condition during the observation horizon.

### Nonclaims

Does not validate historical household criteria or actor choice scoring.

---

## VS-SFL-002 — Two-person formation smoke

**Level:** mechanism-isolation / smoke  
**Claim:** Minimal two-distinct-person formation plumbing works under the same accepted predicate.

Use two co-resident actors with a durable tie, two qualifying support events on distinct cycles, and sufficient uncontested subjective evidence for both actors to recognize one candidate.

This card is debugging evidence only; VS-SFL-001 remains the architectural formation witness.
