# TRES-0003 — Pass F Temporal / Resolution Adversarial Review

**Status:** ADVISORY / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Scope:** Narrow review of the working SFL v0 Pass F design: snapshot visibility, proposal validation, same-cycle reactions, scarce-resource conflicts, failure knowledge, household role-mode activation, semantic history, and continuation.

## 1. Baseline reviewed

The review assumes the accepted reference kernel and the working A–E semantics:

- one deterministic single-threaded commit boundary;
- integer decision cycles;
- personal and household decision contexts propose from one committed snapshot;
- proposal effects require validation/resolution before commit;
- same-cycle automatic consequences may be ordered by a reaction/microstep index;
- no voluntary reactivation after a commit in the same cycle;
- provision commitments expose conditional household access to personal grain;
- household and personal actions can compete for the same scarce capacity;
- v0 uses no randomness.

## 2. Overall finding

No architecture-level defect was found. The core pattern is technically orthodox and internally coherent:

1. **common snapshot -> propose -> validate -> commit** is close to optimistic-concurrency read/validate/write and avoids letting iteration order silently change what actors saw;
2. staged/simultaneous agent activation is an established way to separate decision observation from update order;
3. **(cycle, reaction index)** is a standard superdense-time idea for ordering causally distinct events without pretending additional model time elapsed;
4. a collective/role context producing influences that are resolved at a shared reaction boundary is compatible with established multi-level agent-simulation formalisms.

However, the adversarial review found several details that should be tightened before Pass F is accepted.

## 3. Finding F-A — failed requests must be epistemic events, but not information leaks

### Risk

A requester may act from stale subjective information. A request can then fail because the target was already unable to comply, or because a proposal that initially appeared feasible became impossible during central resolution.

If the engine merely records "rejected", the requester remains falsely convinced the action was feasible and may repeat behavior for the wrong reason.

The opposite failure is also possible: exposing the complete authoritative target state as an invalidation reason would create accidental omniscience.

### Recommended v0 distinction

Keep three outcomes semantically distinct:

- **Declined** — target could act but chooses not to.
- **Unable(reason)** — target reports that the requested act is not feasible from the target's current state.
- **InvalidatedAtResolution(reason)** — target had accepted or the proposal had passed earlier checks, but the shared commit boundary can no longer realize it.

All direct participants learn the outcome and a bounded reason proposition.

Examples:

- `InsufficientAvailableGrainFor(amount)`
- `NoLongerEligibleForMarriage`
- `HeadRoleNoLongerValid`
- `ProvisionCapacityNoLongerAvailable`

The reason should reveal only what the interaction itself makes knowable. It should not automatically reveal an exact private grain balance, unrelated obligations, or hidden household state.

**Declined** may carry social consequences defined by the domain. **Unable** and **InvalidatedAtResolution** are feasibility failures and must not be treated as voluntary refusal for attitude penalties.

A resolution failure is still a real social/epistemic occurrence and therefore belongs in participant knowledge/history even though the requested world effect did not occur.

This closely matches the useful distinction in FIPA agent communication between a refusal with an explained feasibility reason and a later reported action failure.

## 4. Finding F-B — common-snapshot deliberation requires commit-time validation

### Risk

A shared snapshot removes activation-order bias during deliberation, but snapshot isolation by itself does not guarantee a globally valid combined result. Two individually valid proposals can conflict when committed together.

Database research on optimistic concurrency and serializable snapshot isolation is directly analogous: unrestricted reads are safe only if conflicting effects are detected/validated before writes become authoritative.

### Recommendation

Retain the proposed v0 structure:

1. read one committed post-maintenance snapshot;
2. generate personal and household proposals;
3. collect responses;
4. resolve priority/conflicts;
5. **revalidate every proposal against the then-current authoritative state immediately before commit**;
6. commit atomically or emit an explicit failure outcome.

Do not automatically rerun deliberation after validation failure in the same cycle. A same-cycle retry would grant an extra initiative and create order-sensitive cascades.

## 5. Finding F-C — superdense reaction ordering is sound, but reaction closure must terminate semantically

### Risk

Using a reaction index for same-cycle consequences is well-founded. The danger is an automatic rule loop:

`commit -> derived reaction -> another reaction -> first rule becomes eligible again -> ...`

An arbitrary "max 100 microsteps" would hide a domain bug rather than define semantics.

### Recommendation

Keep `(Cycle, ReactionIndex)` ordering, but require automatic reaction rules to be **idempotent/cause-keyed**:

- a semantic reaction has a stable cause key such as `(rule, triggering-event, subject)`;
- the same cause key cannot produce the same transition twice;
- automatic reactions must consume/change the condition that enabled them or establish a fact that makes repeated application a no-op;
- repetition of an already-processed cause key is an engine/specification error.

Voluntary deliberation never reopens during reaction closure.

## 6. Finding F-D — "standing commitments have priority" must be narrowed

### Risk

The phrase "standing obligations/commitments outrank voluntary spending" is too broad. Debt and favour are also standing obligations in the social model. Treating every such relation as an automatic material reservation would silently rewrite Pass B.

### Recommendation

The high-priority material class should mean only:

> **already-established commitments whose semantics explicitly reserve or conditionally authorize current scarce capacity for the proposed effect.**

In current v0, a household provision commitment authorizes capacity, but no grain is reserved until a valid household expenditure is selected for resolution. Debt and favour do not automatically reserve grain.

The currently approved household priority remains:

1. eligible household NeedsGrain support;
2. other valid household provision expenditure (currently dowry);
3. ordinary voluntary personal transfers,

subject to the protected 2-grain personal reserve and proposal-specific obligations.

## 7. Finding F-E — stable-ID tie-breaking is deterministic but socially arbitrary

### Risk

A stable-ID final tie-break is reproducible, but if IDs are nonsemantic it can make renaming otherwise identical actors change who receives support or who loses grain. Earlier project verification research explicitly recommends identifier-permutation tests where identifiers are not socially meaningful.

There is no deterministic way to break a perfectly symmetric social tie without introducing some additional asymmetry, arbitrary convention, or randomness.

### Recommendation for v0

Do **not** pretend the stable-ID fallback is a social rule.

It may remain as an explicit last-resort technical convention for v0 if:

- every higher, socially meaningful priority is exhausted first;
- history records that the technical fallback resolved the tie;
- Pass G includes identifier-permutation sensitivity tests;
- any materially important dependence on ID permutation is treated as a failed/fragile scenario requiring a social tie rule before promotion beyond the laboratory.

This is acceptable for v0 but should remain quarantined as a controlled assumption.

## 8. Finding F-F — role-mode plus personal-mode from one snapshot is coherent

### Challenge examined

The household head can emit one personal initiative and one household initiative from the same snapshot. This can create competing proposals from the same human actor/underlying resources.

### Finding

The architecture remains coherent because the two proposals represent different normative contexts and neither directly mutates state. The shared resolver can invalidate or prioritize conflicting effects.

The important constraints are:

- no role-mode action bypasses resolution;
- household mode receives only household/office-authorized perceptions plus the head's legitimately held subjective information;
- office context must not reveal private facts merely because the person occupies the role;
- no same-cycle re-deliberation after one of the two proposals fails.

This is consistent with role/coordination-context approaches in multi-agent systems and with influence/reaction multi-level models.

## 9. Finding F-G — full v0 decision traces are preferable to prematurely compressed traces

### Risk

The proposed history rule retained component scores for the chosen action and only the highest-scoring rejected alternative. That may fail to answer why another apparently possible action was absent because of a soft gate, recognition failure, or feasibility filter.

### Recommendation

The v0 laboratory is tiny. Record the **complete generated candidate set for each activated decision context**, including:

- candidate semantic action;
- gating/eligibility results;
- component scores;
- final score;
- chosen candidate;
- candidates excluded before scoring and their explicit gate reason where relevant.

This is diagnostic history, not necessarily a permanent production retention policy. Compress later only after Pass G demonstrates which detail is unnecessary.

## 10. Finding F-H — NeedsGrain can create a legitimate absorbing material deadlock

### Risk

A `NeedsGrain` actor cannot Farm. If all actors become `NeedsGrain` while no transferable grain exists, no endogenous action can recreate grain. Because v0 has no mortality, the simulation can remain permanently stuck.

### Recommendation

Do not silently inject rescue grain; that would defeat the social-dependence test.

Instead define this as an explicit diagnosable **MaterialDeadlock** condition for the laboratory:

- all active people who could produce grain are barred by `NeedsGrain`;
- no available personal/household transfer can clear any need;
- no scheduled exogenous grain input can resolve it.

The run may terminate or be marked stuck according to the verification scenario. This is a model consequence, not a scheduler failure.

## 11. Finding F-I — provision reconsideration cooldown should reflect both time and context

### Risk

A pure fixed cooldown prevents constant requests but still allows the head to ask again forever on a timer even when literally nothing relevant has changed.

### Recommendation

Make reconsideration eligible only when:

1. the cooldown has expired; **and**
2. at least one relevant state dimension has changed since the prior refusal.

For v0, relevant change may be limited to:

- person's grain / NeedsGrain state;
- person's attitude toward the head;
- head occupant changed;
- household has a new unmet support/dowry demand.

This preserves the requested "do not pester before anything changed" behavior without a reputation/persuasion system.

## 12. Finding F-J — safe checkpoints remain the right simplification

Checkpoint only after the cycle's proposal resolution and same-time reaction closure are stable.

The checkpoint must include all future-influencing authoritative state, including subjective knowledge/recognition, cooldown/reconsideration baselines, pending scenario inputs, ID/order state, and role/household state.

Derived indexes/caches may be rebuilt.

Because v0 has no randomness, RNG state is not required for exact continuation.

## 13. Recommended Pass F amendments before closure

Adopt the original Pass F batch with these refinements:

1. model `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)` separately;
2. all direct participants learn failure outcome + bounded causal reason;
3. no attitude penalty for feasibility invalidation;
4. no automatic same-cycle retry;
5. cause-key/idempotence rule for same-cycle reaction closure;
6. narrow "standing commitment" priority to commitments that explicitly authorize/reserve material capacity;
7. retain stable-ID tie-break only as disclosed technical fallback + Pass G permutation sensitivity test;
8. record full v0 candidate/gate/score traces;
9. diagnose universal-grain exhaustion as `MaterialDeadlock`;
10. provision reconsideration requires cooldown expiry plus relevant context change.

With these amendments, no architecture-level blocker remains.

## 14. Sources

### Project sources

- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `research/technical/TRES-0001/returns/TRES-0001C_RESEARCH_RETURN.md`
- `research/technical/TRES-0001/returns/TRES-0001F_RESEARCH_REPORT.md`
- `research/technical/TRES-0001/returns/TRES-0001E_RESEARCH_REPORT.md`
- `specifications/working/SFL_V0_WORKING_SPEC.md`

### External checks

- H. T. Kung & J. T. Robinson, *On Optimistic Methods for Concurrency Control*, ACM TODS 6(2), 1981: https://www.cs.cmu.edu/~15712/papers/kung81.pdf
- M. Cahill, U. Röhm & A. Fekete, *Serializable Isolation for Snapshot Databases*, ACM TODS 34(4), 2009: https://www.cs.cornell.edu/~sowell/dbpapers/serializable_isolation.pdf
- Ptolemy II, `SuperdenseTime` / superdense-time semantics: https://ptolemy.berkeley.edu/ptolemyII/ptII11.0/ptII11.0.1/doc/codeDoc/ptolemy/actor/util/SuperdenseTime.html
- Mesa, *Agent Activation* documentation (simultaneous/staged activation and activation-order effects): https://mesa.readthedocs.io/v3.5.1/tutorials/2_agent_activation.html
- FIPA, *Communicative Act Library Specification* (refuse/failure and causal reason semantics): https://jmvidal.cse.sc.edu/library/XC00037H.pdf
- G. Morvan et al., *IRM4MLS: the influence reaction model for multi-level simulation*: https://arxiv.org/abs/1310.7951
