# VS-SFL-08x — Deadlock / Determinism / Recovery / Explainability Family

**Authority:** Verification design only.  
**Semantic source:** `SPEC-SFL-0001` §§9–11, ADR-0003, ADR-0004.  
**Supporting reviews:** `TRES-0003`, `TRES-0004`.

This family verifies that the reference laboratory fails explicitly when materially stuck, quarantines arbitrary technical tie-breaking, continues exactly from safe checkpoints, treats caches/indexes as rebuildable, and exposes enough decision evidence for causal inspection.

## Family invariants

- no technical fallback is used while a higher semantic/domain priority distinguishes alternatives;
- technical fallback use is explicitly marked in history;
- stable checkpoints exist only after resolution/reaction closure;
- checkpoint contains every authoritative value that can influence the future;
- derived caches/indexes are never required for semantic recovery;
- uninterrupted and restored runs produce identical authoritative suffixes under identical inputs/configuration;
- diagnostic/observer code does not change simulation behavior;
- decision traces record complete candidate/gate/score/subjective-input information for every activated context.

---

## VS-SFL-080 — MaterialDeadlock is diagnosed, not rescued

**Level:** terminal-condition / progress

### Initial state

Construct a stable world in which:

- every person who could Farm has `NeedsGrain = true`;
- no person/household has transferable grain capable of clearing any need;
- no valid gift/loan/favour-backed/household transfer can resolve any need;
- no scheduled exogenous grain input exists.

### Assertions

- `MaterialDeadlock` is reported;
- no magic/rescue grain is injected;
- no NeedsGrain actor Farms;
- engine does not spin indefinitely pretending progress;
- the condition is distinguishable from scheduler failure or reaction-loop failure;
- verification may terminate/mark the run stuck according to the test harness.

### Negative controls

- add one valid transferable grain path -> no MaterialDeadlock;
- schedule a future exogenous grain input -> no unrecoverable MaterialDeadlock under the accepted definition.

---

## VS-SFL-081 — Stable-ID fallback is quarantined and disclosed

**Level:** determinism / metamorphic

Create a controlled resolution state with two otherwise semantically equal alternatives competing for one indivisible outcome after every modeled social/domain priority has been exhausted.

For Slice 1, one canonical exercise may use two independently accepted, still-feasible Residence proposals that would change the same person's Residence to different dwellings, with no semantic priority distinguishing them.

### Assertions

- identical initial state/IDs/input/configuration -> identical winner and history across repeated runs;
- history explicitly marks use of technical stable-ID fallback;
- ordinary container/insertion iteration order permutation does not change the result;
- renaming the relevant nonsemantic stable IDs is allowed to change which symmetric alternative wins;
- such ID-permutation sensitivity is recorded as expected fallback sensitivity, not presented as a social preference;
- if a meaningful domain asymmetry is added, that asymmetry decides and the fallback marker disappears;
- in the Residence exercise, exactly one Residence transition commits and every non-winning accepted contender is `InvalidatedAtResolution(CompetingResidenceTransition)`.

### Nonclaim

The card does not require one particular socially arbitrary winner; it requires deterministic, inspectable, isolated fallback behavior.

---

## VS-SFL-082 — Safe-boundary checkpoint reproduces exact suffix

**Level:** checkpoint / continuation

### Pre-checkpoint history

Build a nontrivial stable SFL world containing, where applicable:

- people/grain/relations;
- at least one Household with lifecycle/participation/head/provision state;
- subjective KnownFact/Recognition including at least one stale fact;
- active debt with future social due review;
- provision-reconsideration cooldown baseline;
- pending scheduled scenario/exogenous input;
- identifier/order frontier;
- rule/configuration version.

Reach a stable cycle boundary after reaction closure and checkpoint.

### Paired executions

**Run A:** continue uninterrupted for a fixed input schedule.

**Run B:** restore from checkpoint and apply the exact same future inputs/configuration.

### Assertions

For the compared suffix:

- authoritative semantic states are identical at every stable boundary;
- consequential history suffix is identical, including `Cycle, ReactionIndex`, failures, causal refs, and fallback markers;
- subjective knowledge/recognition evolution is identical;
- debt due/cooldown eligibility occurs at identical semantic times;
- generated IDs/order are identical;
- no pre-checkpoint side effect is re-executed.

### Safety control

Checkpoint request during proposal resolution or reaction closure must not produce a valid safe checkpoint.

---

## VS-SFL-083 — Omitted future-influencing checkpoint state is detected

**Level:** semantic mutation

Run `VS-SFL-082` against deliberate defective checkpoint variants that omit one class at a time:

- subjective recognition/knowledge;
- cooldown/context baseline;
- pending future input/process;
- identifier/order state;
- household/head/provision state;
- rule/configuration version.

### Assertions

A defective restore that changes the future must be detected by state/history-suffix comparison.

A crash or parse failure is reported separately from a semantic mismatch; it is not automatically credited as the intended assertion detecting the mutant.

---

## VS-SFL-084 — Derived-state rebuild equivalence

**Level:** metamorphic / cache authority

At a safe stable boundary:

1. capture authoritative state;
2. discard every rebuildable cache/index/projection used for:
   - neighborhood/candidate lookup;
   - mobilizable provision summaries;
   - feasible-action indexes;
   - lineage/DerivedFrom projections;
   - other declared derived state;
3. rebuild them from authoritative semantic state.

### Assertions

- rebuilt query answers equal pre-discard query answers;
- continuing from rebuilt state under identical inputs yields identical authoritative state/history suffix;
- stale cached facts cannot survive a backing authoritative change;
- deleting a derived cache never deletes the authoritative relation/warrant it summarizes.

### Fault challenge

Deliberately retain a stale derived value after its backing fact changes; the suite must detect any semantic influence.

---

## VS-SFL-085 — Observer/diagnostic noninterference

**Level:** metamorphic

Run the same scenario with:

- full diagnostic tracing/readers enabled;
- equivalent optional diagnostic/reporting surfaces disabled.

### Assertions

- authoritative semantic state/history is identical;
- inspection order does not alter candidate generation/resolution;
- rendering/explanation queries do not mutate recognition, caches in a semantically visible way, IDs, or scheduling.

---

## VS-SFL-086 — Decision trace completeness

**Level:** explainability

Activate a personal or household decision context with:

- multiple generated candidates;
- at least one candidate excluded by a categorical gate;
- at least two scored feasible candidates;
- relevant subjective KnownFact/Recognition input.

### Required trace

For that activated context, history must retain:

- every generated semantic candidate;
- gate/eligibility result and explicit exclusion reason where relevant;
- component scores for every scored candidate;
- final score;
- selected candidate;
- subjective facts/recognition actually used;
- rule/configuration version.

If the selected proposal later fails at resolution, the trace also links the selection to the consequential failure/commit record.

### Assertions

An independent reader can distinguish:

- "candidate never generated";
- "candidate generated but gated out";
- "candidate scored and lost";
- "candidate selected but later failed at resolution";
- "candidate selected and committed".

---

## VS-SFL-087 — Causal explanation survives intervention

**Level:** causal intervention / explainability

Start from a decision whose trace claims a critical cause, for example household/head recognition enabling a household-mediated candidate.

### Pair

**Run A:** preserve the claimed cause -> candidate appears.

**Run B:** hold irrelevant facts constant but remove/change only the claimed critical cause -> candidate disappears or changes according to the spec.

### Assertions

- explanation references actual causal inputs rather than post-hoc prose;
- irrelevant-attribute perturbations leave the decision unchanged;
- where causes are redundant, use crossed controls rather than falsely demanding a one-factor effect.

## Family semantic mutants that must be detected

- inject grain to escape deadlock;
- use dictionary/list iteration order as hidden tie-break;
- omit fallback marker;
- checkpoint mid-reaction closure;
- omit subjective/cooldown/pending/ID/config state from checkpoint;
- persist stale cache as authority;
- tracing changes behavior;
- decision trace records only the chosen action;
- rendered explanation names a cause that intervention shows was irrelevant.
