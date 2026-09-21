# TRES-0010B2-SEM-T — Temporal Composition Options Report

## Run provenance

- **Task ID:** `TRES-0010B2-SEM-T`
- **B2 frozen baseline ref:** `tres-0010-b2-baseline`
- **Resolved baseline SHA:** `0729e460af35668e5b911fa561bf8cec53204142`
- **Assigned return branch/workspace:** `tres-0010/b2-sem-t`
- **Return-branch start state:** identical to the frozen B2 baseline before this report was written
- **Model/configuration:** GPT-5.6 Sol; hidden reasoning configuration not externally exposed
- **Tools used:** GitHub repository connector for bounded repository retrieval, branch/ref resolution, baseline comparison, and isolated return-file write
- **External research:** no
- **Assigned Wave-A/Wave-B reports read:** Wave-B temporal prosecution and defense returns:
  - `research/technical/TRES-0010/returns/TRES-0010B-T-PROSECUTION_TEMPORAL_CONFLICT_REPORT.md` from `tres-0010/wb-t-prosecution`
  - `research/technical/TRES-0010/returns/TRES-0010B-T-DEFENSE_TEMPORAL_CONFLICT_REPORT.md` from `tres-0010/wb-t-defense`
  - no Wave-A return was required or read directly for this B2 task
- **B2 synthesis used:** `research/technical/TRES-0010/WAVE_B_ADJUDICATION_SYNTHESIS.md`, only as the finding/disposition map required by the packet, not as semantic authority
- **Sibling B2 returns read before completion:** **no**
- **Canonical files modified:** **no**
- **External semantic authority used:** none

## 1. Executive recommendation

Two narrow semantic repairs are warranted. Neither requires an architectural change, a new framework, or a general temporal-composition system.

### S1-SEM-01 — same-cycle automatic attitude effects

**Recommend a direct-cause commutative composition batch.**

For the fixed `SPEC-SFL-0001 §3.1` attitude consequences directly produced by the current cycle's committed interaction/failure/due-review outcomes, collect all distinct signed deltas targeting the same directed attitude, sum them, and clamp **once** against the post-maintenance/pre-reaction attitude value. Preserve every individual trigger/cause key and signed delta as causal predecessors of the one authoritative attitude-composition transition.

This is intentionally narrower than a general rule for every possible future reaction chain. If a future accepted rule creates an attitude effect *causally downstream of another automatic reaction*, that future rule must state its causal placement rather than being silently folded into this direct-cause batch.

For the established witness at `A -> B = +95` with same-cycle `+10` and `-20`, the stable result becomes **+85**, independent of cause enumeration.

### S1-SEM-02 — multiple accepted same-cycle Residence changes

**Recommend one committed Residence transition per person per cycle.**

All accepted, still-feasible proposals whose committed effect would change the same person's `Residence` in the same cycle form one central-resolution conflict set. The actor may still independently Accept multiple proposals from the common snapshot. Acceptance is not rewritten as refusal. At most one Residence transition commits; the other accepted contenders become `InvalidatedAtResolution(CompetingResidenceTransition)`.

Where no accepted semantic/domain priority distinguishes the contenders, use the **already accepted disclosed stable-ID technical fallback**, with the fallback marker required in history. Do not invent a new personal-over-response, proposer-over-invite, or destination preference.

These recommendations are the smallest rules that close the two Slice-1 ambiguities while preserving the accepted common-snapshot response model and ADR-0004's ban on accidental mutation-order semantics.

Both recommendations require **Director approval** before promotion because each changes simulated behavior in cases where current accepted authority permits more than one result.

---

## 2. Issue inventory

| Issue | Current ambiguity | Slice-1 consequence | Required decision |
|---|---|---|---|
| **S1-SEM-01** | Distinct same-cycle automatic deltas can target one bounded attitude; cause order is not defined and clamp-after-each is non-commutative. | Same accepted cause set can end at different authoritative attitude values and different later threshold/scoring inputs. | Define order-independent composition or a semantic total order. |
| **S1-SEM-02** | One person can independently Accept multiple Residence proposals from the common snapshot; Residence is single-valued but sequential same-cycle moves are not prohibited. | Resolver order can choose final dwelling, or an implementation can invent a conflict class locally. | Define mutual exclusion/one-move semantics or a semantic order for multiple moves. |

No additional B2 issue is promoted here. H-002 remains the already-adjudicated later-slice gap and is outside this task's assigned cluster.

---

## 3. Accepted constraints

The following constraints are controlling for this report.

### 3.1 Attitude / reaction constraints

From `SPEC-SFL-0001`:

- §3.1: directed attitude is an integer in `[-100,+100]`; the fixed v0 event consequences include `+10` gift/help, `+5` loan, `+5` repayment, `+10` fulfilled called favour, `-5` genuine-need ordinary refusal, `-20` called-favour refusal, and `-10` unpaid social-due review.
- §3.1: due attitude decay occurs every five cycles and never crosses zero.
- §5.1: responses use the common committed snapshot, may activate multiple times, may produce multiple Accept/Fulfil selections, and do not consume personal initiative.
- §9.1: maintenance precedes the common decision snapshot; commit/failure precedes automatic semantic reaction closure; there is no fresh same-cycle voluntary activation during closure.
- §9.3: automatic reactions are cause-keyed/idempotent; one cause key cannot produce the same transition twice.
- §9.4: consequential history retains `Cycle/ReactionIndex`, committed effects, causal predecessors, and fallback markers.
- §10: attitude remains bounded; `ReactionIndex` is monotone.

From accepted ADR-0004:

- runtime iteration order and transient mutation order may not silently become simulation authority;
- completed cycle state exists only after resolution and reaction closure.

From verification authority:

- VS-SFL-097 requires saturation at `-100/+100`;
- VS-SFL-074 requires one automatic cause to apply once;
- VS-SFL-075 requires deterministic semantic closure and monotone `ReactionIndex`;
- the cross-cutting contract requires nonsemantic storage/input permutation not to change semantic output.

### 3.2 Residence / response constraints

From `SPEC-SFL-0001`:

- §2.3: Residence is a single person -> dwelling relation.
- §3.6: Residence changes are proposal-based; move and invite meanings are valid; the named counterpart's acceptance is sufficient in v0; marriage does not move Residence automatically.
- §5.1: multiple response contexts may activate for one target from the same committed snapshot; Accept does not itself guarantee final commit.
- §9.2: every proposal is revalidated immediately before commit; accepted but incompatible proposals may become `InvalidatedAtResolution`; equal-priority unresolved symmetry uses the disclosed stable-ID technical fallback.
- §6.7: `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)` remain socially distinct.

From verification authority:

- VS-SFL-096 requires accepted move/invite to change Residence and forbids residence change from implying household effects.
- VS-SFL-103 establishes that a target can Accept multiple proposals from the common snapshot and that central resolution may invalidate one without retroactive refusal.
- VS-SFL-105 establishes that response activity does not consume/cancel the person's personal initiative.
- VS-SFL-081 quarantines stable-ID fallback to explicitly recognized unresolved equal-priority competition and requires it to be disclosed.

### 3.3 Constraints that rule out shortcuts

The repair must not:

- make container/list/dictionary iteration order authoritative;
- treat `ReactionIndex` as if it already supplied an unstated social precedence;
- broaden stable-ID fallback into a general reaction scheduler;
- rewrite an independent Accept as a Decline merely because world-level effects conflict;
- add a general action-composition framework;
- introduce a historical calibration claim;
- reopen ADR-0004 or the common-snapshot response model.

---

## 4. Option matrix

### 4.1 S1-SEM-01 — attitude composition

| Option | Semantic fidelity | Determinism | Causal/history quality | Verification clarity | Future-slice compatibility | Implementation burden | Assessment |
|---|---|---|---|---|---|---|---|
| **A. Canonical sequential application**: define a total semantic order over individual attitude causes; apply/clamp after each. | Medium. Preserves event-by-event mutation, but the required precedence is not present in accepted social semantics. | High if the order is fully specified. | High for discrete intermediate states, but those states acquire meaning solely because of the new precedence. | Medium. Easy to test once precedence is chosen, but ID/order sensitivity must be explained. | Medium-low. Encourages unrelated reaction ordering to become social meaning. | Low. | Credible but not preferred. |
| **B. Whole-cycle net aggregation**: sum every same-cycle attitude delta for a directed pair and clamp once at stable closure. | High for current additive fixed deltas. | High; commutative. | Medium. Individual causes can be retained, but a future causally downstream attitude effect could be flattened into the same batch unless additional rules are added. | High. | Medium. Too broad if future automatic reactions generate new attitude deltas from other reactions. | Low. | Better than A, but broader than necessary. |
| **C. Direct-cause composition batch**: sum/clamp once only for the currently specified §3.1 attitude consequences directly triggered by this cycle's committed interaction/failure/due-review outcomes; retain every cause; future causally downstream attitude rules require explicit placement. | **High.** Changes only the ambiguous commutation point and leaves causal chains explicit. | **High; order-independent for the disputed case.** | **High.** One authoritative composition transition points to all contributing causes; no false precedence among independent causes. | **High.** Exact arithmetic, cause-set, and permutation oracles are simple. | **High.** Does not pre-decide unknown future reaction chains. | Low-medium. | **Recommended.** |

### 4.2 S1-SEM-02 — Residence composition

| Option | Semantic fidelity | Determinism | Actor/world boundary | Verification clarity | Future-slice compatibility | Implementation burden | Assessment |
|---|---|---|---|---|---|---|---|
| **R1. One committed Residence transition/person/cycle; accepted contenders form a conflict set.** | **High for v0.** It preserves every response decision while declaring the single-valued world transition indivisible per cycle. | **High.** Existing stable-ID fallback closes only otherwise unresolved equal-priority cases. | **High.** Actor may Accept multiple; resolver decides world compatibility. | **High.** One winner + explicit invalidations + fallback marker. | **High.** Later social priorities can replace fallback without changing response architecture. | Low. | **Recommended.** |
| **R2. Canonically ordered multi-transition semantics.** Commit every still-feasible accepted move in a fixed order. | Medium-low. Makes multiple physical moves inside one non-reactivating cycle meaningful without existing social justification. | High if order is specified. | Medium. Accepts remain autonomous, but technical order can dominate the stable result. | Medium. Must test full intermediate path and final destination. | Low-medium. Intermediate residence could spur accidental later causal effects. | Low. | Credible but not preferred. |
| **R3. Snapshot-origin lock + sequential revalidation.** Each Residence proposal records the mover's snapshot origin; after one move, all others fail origin revalidation. | Medium-low. Adds an unstated origin precondition. | **Incomplete by itself**: still needs a deterministic rule for which proposal commits first. | High once a first winner is chosen. | Medium. Failure is explained as stale origin rather than explicit competition. | Medium. Hardens an implementation timing device into domain semantics. | Low. | Reject as inferior to an explicit conflict set. |

A joint-response option in which the target is allowed to Accept only one Residence proposal was considered and rejected before detailed comparison because it directly contradicts the accepted §5.1 model in which response contexts are independent and multiple Accept responses may occur.

---

## 5. Minimal counterexamples under each option

## 5.1 Attitude witness

Common cycle state:

- stored `A -> B = +95`;
- B owes A one valid favour;
- B validly gives A a voluntary gift; A Accepts -> direct §3.1 consequence `A -> B +10`;
- A validly calls B's favour; B independently RefusesCalledFavor -> direct §3.1 consequence `A -> B -20`.

Both causes are valid from the same cycle and neither invalidates the other.

### Option A — canonical sequential application

If the new precedence says gift before called-favour refusal:

`+95 -> clamp(+105)=+100 -> +80`.

If the new precedence instead says refusal before gift:

`+95 -> +75 -> +85`.

The option is deterministic only after the project chooses which event class/source ordering has semantic precedence. That choice is itself consequential.

### Option B — whole-cycle net aggregation

Net delta = `+10 - 20 = -10`.

`clamp(+95 - 10) = +85`.

Cause enumeration does not change the result.

### Option C — recommended direct-cause composition batch

The same two direct §3.1 causes enter one per-directed-attitude composition batch:

- predecessor cause 1: accepted gift, `+10`;
- predecessor cause 2: called-favour refusal, `-20`;
- base: post-maintenance/pre-reaction `+95`;
- authoritative transition: `clamp(+95 + (+10) + (-20)) = +85`.

The history preserves both source events and deltas, but it does **not** pretend that one independent social cause happened “first” for saturation purposes.

A mirrored lower-bound case is equally diagnostic:

- base `-95`;
- deltas `-10` and `+20`;
- recommended result `-85`;
- sequential clamp can instead produce `-80` or `-85` depending precedence.

## 5.2 Residence witness

Common committed snapshot:

- B resides at D0;
- A resides at D1;
- C resides at D2;
- A invites B to D1;
- C invites B to D2;
- B independently Accepts both response contexts.

### R1 — recommended one-transition conflict set

Both accepted effects target the same world slot: `Residence(B)` for cycle N.

- both are ordinarily revalidated;
- both remain valid;
- they enter one Residence conflict set keyed by B;
- no accepted domain priority distinguishes them;
- existing stable-ID technical fallback selects one;
- selected proposal commits exactly one transition, e.g. `D0 -> D1`;
- the other remains historically Accepted by B but terminates as `InvalidatedAtResolution(CompetingResidenceTransition)`;
- history marks the fallback.

Renaming the competing fallback IDs may change the winner in the deliberately controlled fallback test, but container/enumeration permutation with the same IDs must not.

### R2 — ordered multi-transition

If canonical order is A then C:

`B: D0 -> D1 -> D2`, stable D2.

If canonical order is C then A:

`B: D0 -> D2 -> D1`, stable D1.

The project would need to make the ordering rule authoritative and accept that one actor physically moves twice in one cycle even though all choices were made from the original common snapshot.

### R3 — snapshot-origin lock

Both proposals record origin D0.

If A's proposal is processed first:

- A invite commits `D0 -> D1`;
- C invite later fails because current Residence is no longer D0.

If C is processed first, the reverse happens.

The origin lock therefore does not eliminate the need to select a first proposal; it merely changes the losing proposal's explanation. An explicit conflict set is both clearer and more faithful to existing §9.2 terminology.

---

## 6. Option-by-option simulation consequences

## 6.1 Attitude

### A. Canonical sequential ordering

**Stable state near bounds.** Deterministic only after choosing a precedence. Mixed-sign causes near ±100 remain precedence-sensitive.

**ReactionIndex/history.** Natural one-reaction-per-cause sequence, but `ReactionIndex` now carries a new semantic precedence that current authority does not supply.

**Attribution.** Excellent: each cause is a separate mutation.

**Decay/due-review interaction.** Maintenance decay remains earlier under §9.1. Due-review effects need a place in the new ordering beside interaction-driven causes, requiring another precedence choice.

**Social meaning versus technical order.** Main weakness. A priority such as “gift before refusal” is a social rule; ordering by event/proposal IDs is technical. Neither currently has accepted grounding.

**Verification/permutation.** A fully explicit order is testable, but if technical IDs determine order, ID renaming changes attitude near bounds. That would create a new fallback-sensitive domain not currently authorized.

### B. Whole-cycle net aggregation

**Stable state near bounds.** Commutative and deterministic.

**ReactionIndex/history.** Requires representing causes as predecessors of one composition transition rather than as order-significant individual state writes.

**Attribution.** Preserved if all deltas/cause keys are retained in the composition record.

**Decay/due-review interaction.** Decay is naturally outside the batch because it occurs in maintenance. Due-review deltas can enter the batch. But “whole cycle” is broader than needed if a future automatic reaction itself creates another attitude consequence.

**Social meaning versus technical order.** No artificial precedence among independent causes.

**Verification/permutation.** Very simple arithmetic/metamorphic oracle.

### C. Direct-cause composition batch — recommended

**Stable state near bounds.** Same commutative benefit as B for every currently specified §3.1 direct attitude consequence.

**ReactionIndex/history.** One authoritative state transition per directed attitude/direct-cause batch. Its causal-predecessor set records every triggering event, cause key, and signed delta. `ReactionIndex` locates the composition transition in closure; it does not rank member causes.

**Attribution.** Preserved. A reader can still answer exactly which gift/refusal/repayment/due review contributed what.

**Decay/due-review interaction.**
- maintenance/attitude decay runs first and supplies the batch base;
- a debt social-due penalty that survives the cycle's repayment opportunities is a direct due-review contribution and composes with other direct §3.1 effects;
- no maintenance decay is itself included in the sum.

**Social meaning versus technical order.** Independent social causes remain simultaneous for bounded composition. No proposal ID, dictionary order, or reaction queue order becomes a social priority.

**Verification/permutation.** Cause enumeration permutation and nonsemantic ID renaming cannot alter the numeric result.

**Future slices.** The rule does not silently aggregate a future attitude effect that is causally downstream of another automatic reaction. Such a later rule must explicitly join a batch or occur after its predecessor. This prevents the current repair from becoming a generic scheduler doctrine.

## 6.2 Residence

### R1. One committed transition/person/cycle — recommended

**Actor autonomy.** Preserved. B can independently Accept both invitations because response contexts are still autonomous and snapshot-based.

**Response semantics.** Acceptance means willingness/authorization, not guaranteed world commit. That is already the accepted distinction demonstrated by VS-SFL-103.

**Personal initiative + incoming responses.** A person's own selected residence proposal and one or more incoming accepted invitations can coexist as decisions. They compete only at world-effect resolution; no extra initiative is granted or consumed.

**Precommit revalidation.** Ordinary action-relevant revalidation still happens. The new rule applies only if more than one valid accepted Residence effect for the same mover remains.

**Stable-ID fallback.** Now lawfully applicable because accepted authority would explicitly declare the contenders one equal-priority conflict set. Fallback remains technical, logged, and replaceable by any later accepted social/domain priority.

**Causal history.** All response decisions remain visible. One commit is visible. Every losing accepted contender gets an explicit `InvalidatedAtResolution(CompetingResidenceTransition)`.

**Later co-residence consequences.** Only the committed destination becomes authoritative Residence. Losing accepted proposals never become objective residence facts and cannot generate co-residence consequences.

**Meaning of physical movement.** v0 models at most one authoritative move per cycle, avoiding two or more physical moves based on choices that all observed the same pre-move snapshot.

### R2. Canonically ordered multiple transitions

**Actor autonomy.** Preserved.

**Response semantics.** Preserved.

**Precommit revalidation.** Both can remain valid and commit sequentially.

**Stable-ID/order use.** Some total order must become semantic. If it is technical, final residence can depend on otherwise non-social identifiers.

**Causal history.** Rich but potentially misleading: multiple microstep residences become authoritative within the cycle even though actors never re-deliberate on those intermediate states.

**Later co-residence consequences.** Dangerous. A later reaction keyed to Residence could observe an intermediate dwelling and accidentally turn ordering into additional causal meaning.

### R3. Snapshot-origin lock

**Actor autonomy.** Preserved.

**Response semantics.** Preserved until resolution.

**Precommit revalidation.** Stronger than current semantics because current-origin equality becomes a new hidden precondition.

**Stable-ID/order use.** Still required to choose which proposal sees the original Residence first.

**Causal history.** Loser appears stale/invalid rather than explicitly competing, obscuring the actual reason for the new rule.

**Future slices.** Tends to fossilize one implementation representation of a proposal (“from D0 to D1”) into domain semantics.

---

## 7. Strongest disconfirmation of the recommended options

## 7.1 Against attitude direct-cause batching

The strongest counterargument is that the accepted language speaks of fixed attitude **updates**, VS-SFL-097 says updates that cross the bound **saturate at the bound**, and the history model includes same-cycle `ReactionIndex`. A reasonable Director interpretation could be that every social event is intended to cause a discrete bounded attitude state transition, in which case an explicit sequential precedence—not batching—would be the more faithful model.

Batching also removes an observable intermediate attitude value. If a future automatic rule is intended to react specifically to the first discrete attitude transition before another independent consequence arrives, batching would change behavior.

That objection is real. It is why the recommendation is deliberately limited to the *currently specified direct §3.1 causes* and does not assert a universal “all attitude effects in a cycle are simultaneous” principle. For the current Slice-1 case, no accepted clause gives independent causes a social precedence, while ADR-0004 positively rejects accidental mutation order. The narrow batch therefore requires less invented meaning than a new total ordering.

If the Director instead intends event-by-event attitude semantics, B2 should not choose the precedence indirectly; the Director must choose and promote the exact sequential rule.

## 7.2 Against one Residence transition per person/cycle

The strongest counterargument is that current accepted semantics never say a person is physically incapable of moving twice in a cycle. Cycle duration is abstract. Two accepted moves could therefore be meaningful rather than contradictory, and imposing a one-transition cap suppresses one action the person autonomously accepted. In an equal-priority conflict, the technical stable-ID fallback can even choose the final dwelling.

That objection is also real. The recommendation rests on v0's common-snapshot/no-reactivation structure: every accepted Residence decision was made without seeing any earlier same-cycle move, and accepted authority already distinguishes “target accepted” from “effect committed.” Treating those same-person world writes as one indivisible cycle-level outcome adds only one narrow compatibility rule. By contrast, ordered multi-move semantics must add a total order and give intermediate moves causal status even though no actor observes them as a completed state.

If the Director intends multiple physical moves within one cycle to be socially meaningful, the project should choose R2 and state the exact semantic order rather than allowing resolver implementation order to decide it.

---

## 8. Recommendations translated into simulation consequences

### 8.1 S1-SEM-01

Recommended stable semantics:

- fixed direct attitude causes do not compete or cancel each other as events;
- every valid cause contributes its full fixed signed delta exactly once;
- the bounded state is computed from their **net direct effect**, not from an arbitrary sequence of intermediate clamps;
- the cause set remains fully explainable.

Concrete example:

> A likes B at +95. In one cycle B both gives A a valid gift (+10) and refuses A's called favour (-20). At stable closure A's attitude to B is +85. History shows both causes. Reversing queue/list/cause enumeration does not change +85.

### 8.2 S1-SEM-02

Recommended stable semantics:

- actors may say yes to multiple Residence proposals;
- those Accept decisions remain true historical decisions;
- the world commits at most one Residence change for that person in the cycle;
- an equal-priority collision is resolved by the existing disclosed technical fallback, not by hidden processing order;
- non-winning accepted proposals are invalidated by central resolution, not recast as refusal.

Concrete example:

> B accepts invitations from A at D1 and C at D2 from the common snapshot. Exactly one move commits. The other attempt records B's Accept plus `InvalidatedAtResolution(CompetingResidenceTransition)`. B does not move D0 -> D1 -> D2 merely because A happened to be enumerated first.

---

## 9. Exact proposed semantic wording

The following is proposed wording for promotion if approved. It is advisory and has **not** been written into canonical artifacts.

### 9.1 `SPEC-SFL-0001 §3.1 Attitude` — add after fixed updates/decay

> **Same-cycle direct attitude composition.** The fixed attitude consequences in this section that are directly triggered by the current cycle's committed interaction, failure, or social-due-review outcomes compose order-independently per directed attitude. Starting from that directed attitude's value after the cycle's maintenance/decay and before automatic attitude consequences, collect every distinct currently due direct cause, sum its signed fixed delta exactly once, and clamp the resulting total once to `[-100,+100]`. Do not clamp contribution-by-contribution. Maintenance decay is not part of this sum. Each contributing cause key and signed delta remains explicit causal history for the resulting attitude transition; enumeration order among those causes has no semantic effect. A future rule that creates an attitude consequence causally downstream of another automatic reaction must define its causal placement explicitly and is not silently folded into this direct-cause batch.

### 9.2 `SPEC-SFL-0001 §9.3 Automatic reactions` — add/clarify

> For a direct attitude-composition batch under §3.1, cause-key idempotence applies to contribution membership: one cause key may contribute its signed delta at most once. The batch commits one bounded attitude-state transition for the directed attitude and retains the complete contributing cause-key/delta set as causal predecessors. `ReactionIndex` orders the resulting authoritative transition relative to other consequential transitions; it does not impose a social precedence among independent member causes.

### 9.3 `SPEC-SFL-0001 §3.6 Residence change` — add

> **Same-cycle Residence compatibility.** At most one Residence transition for a given person may commit in one cycle. A person may still independently Accept multiple Residence proposals from the common snapshot, and those Accept responses remain part of history. Multiple accepted, still-feasible proposals whose effects would change the same person's Residence in that cycle are mutually incompatible at central resolution; incompatibility does not rewrite any Accept as Decline.

### 9.4 `SPEC-SFL-0001 §9.2 Revalidation and conflicts` — add

> Residence-transition conflict sets are keyed by the person whose Residence would change. After ordinary action-relevant revalidation, if more than one valid accepted Residence transition remains for that person, at most one may commit. Unless another accepted semantic/domain priority explicitly distinguishes the contenders, treat them as equal-priority unresolved alternatives and use the existing disclosed stable-ID technical fallback. Record fallback use. Every non-winning accepted contender terminates as `InvalidatedAtResolution(CompetingResidenceTransition)`. A committed Residence transition does not authorize a second Residence transition for that person in the same cycle.

### 9.5 `SPEC-SFL-0001 §10 Invariants` — add

- same-cycle direct attitude-composition result is independent of member-cause enumeration;
- at most one committed Residence transition per person per cycle.

No change to §5.1 response independence is proposed.

---

## 10. Exact verification additions/changes

No new general harness is required.

### 10.1 `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` — VS-SFL-097

Add **Same-cycle mixed-sign composition**:

1. base `A -> B = +95`;
2. establish two valid same-cycle direct causes targeting that attitude: `+10` and `-20`;
3. require stable result `+85`;
4. require both cause IDs/deltas in the composition transition's causal predecessor set;
5. permute cause/enumeration order and require identical authoritative result and semantically equivalent cause set/history;
6. require no technical-fallback marker merely to compose the attitude.

Add lower-bound mirror:

- base `-95`, causes `-10` and `+20`, result `-85`.

Add **maintenance separation**:

- on a due decay cycle, begin at `+95`;
- maintenance decay produces `+93`;
- same direct `+10/-20` batch then produces `+83`;
- prove decay is not folded into the direct-cause sum.

Add **social-due contribution**:

- create a valid due-review `-10` and another direct `+10` effect on the same directed attitude in the same cycle;
- require both direct causes to compose from the post-maintenance base, with net zero before clamp.

### 10.2 `RESOLUTION_REACTION_FAMILY.md` — VS-SFL-074

Extend the duplicate-cause challenge:

- if a duplicated direct attitude cause is presented twice to the batch, it contributes once;
- the duplicate is rejected/reported under existing idempotence diagnostics;
- distinct causes remain distinct even if their signed delta is numerically equal.

### 10.3 `RESOLUTION_REACTION_FAMILY.md` — VS-SFL-075

Add:

- independent direct attitude causes targeting one directed attitude do not acquire precedence from reaction-queue enumeration;
- the composition transition reaches stable closure with all cause predecessors retained;
- any truly causally downstream automatic reaction remains ordered after its predecessor rather than being relabeled “independent.”

### 10.4 `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` — VS-SFL-096

Add **Competing accepted Residence transitions**:

- B at D0; A at D1; C at D2;
- A and C each invite B; B Accepts both from the common snapshot;
- exactly one Residence transition for B commits;
- the other accepted proposal becomes `InvalidatedAtResolution(CompetingResidenceTransition)`;
- neither is rewritten as Declined/Unable;
- B ends in exactly one winning destination;
- input/container enumeration permutation does not change the winner for fixed IDs/configuration;
- when the contenders are otherwise equal, history records stable-ID technical fallback.

Add **personal-plus-response variant**:

- B uses its one personal initiative for one Residence proposal and independently Accepts an incoming Residence invitation;
- both decisions remain present;
- exactly one Residence effect can commit;
- no response consumes/grants a personal initiative.

### 10.5 `RESPONSE_DECISION_FAMILY.md` — VS-SFL-103

Add a Residence-specific cross-family variant/reference establishing that:

- multiple Accept responses remain valid response decisions;
- world-effect incompatibility is resolved later;
- the losing accepted Residence effect is `InvalidatedAtResolution`, not retroactive refusal.

### 10.6 `DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md` — VS-SFL-081

Add a controlled Residence conflict instance as an explicit fallback-sensitive case:

- same accepted contenders + same IDs -> same winner/history across repeat runs;
- collection/insertion permutation -> same winner;
- renaming the relevant competing stable IDs may change the symmetric winner;
- fallback marker must be present;
- if a later accepted domain priority is introduced, that priority wins and the fallback marker disappears.

### 10.7 `CROSS_CUTTING_VERIFICATION_CONTRACT.md`

Add/clarify:

- permutation of independent direct attitude contribution enumeration must not alter bounded stable attitude;
- semantic mutant: clamp each independent direct attitude contribution sequentially in container order;
- semantic mutant: allow two committed Residence transitions for one person in one cycle;
- semantic mutant: choose Residence winner by unmarked container iteration rather than declared conflict/fallback.

These tests can use simple hand-authored arithmetic and direct history inspection; they do not require production helpers as oracles.

---

## 11. Assumption-register treatment

**No new assumption ID is required.**

If the Director approves the recommendations, the cleanest register maintenance is to extend existing entries rather than create parallel assumptions:

- **ASM-0002** already owns the replaceable v0 fixed attitude event magnitudes and decay behavior. Add the approved direct same-cycle composition/clamp-once rule to its SFL-v0 scope.
- **ASM-0007** already owns v0 temporal/conflict parameters and the stable semantic ID as last-resort equal-priority tie-break. Add that same-person same-cycle Residence transitions are one conflict set with at most one commit.

The semantic authority must still live in `SPEC-SFL-0001`. The assumptions register should mirror the fact that these are controlled, replaceable v0 laboratory choices, not substitute for the specification.

If the Director instead wants either rule to be permanent beyond the reference laboratory, do not mislabel it as a temporary assumption; promote the semantic rule in SPEC and leave the corresponding assumption wording narrow.

---

## 12. Exact canonical artifacts/sections requiring amendment if approved

### Semantic authority

1. `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
   - §3.1 — add direct same-cycle attitude composition;
   - §3.6 — add one committed Residence transition/person/cycle;
   - §9.2 — add Residence conflict-set treatment;
   - §9.3 — clarify attitude batch cause-key idempotence and history;
   - §10 — add the two new invariants.

2. `registers/ASSUMPTIONS_REGISTER.md`
   - amend ASM-0002;
   - amend ASM-0007;
   - no new assumption ID recommended.

### Verification authority

3. `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
   - VS-SFL-096;
   - VS-SFL-097.

4. `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`
   - VS-SFL-074;
   - VS-SFL-075.

5. `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`
   - VS-SFL-103 cross-reference/variant.

6. `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
   - VS-SFL-081 Residence fallback case.

7. `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
   - permutation and semantic-mutant additions above.

### Implementation handoff

8. `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`
   - §3.3: identify post-maintenance attitude base / direct-cause batch timing;
   - §3.6: require same-person Residence conflict grouping and direct attitude composition during reaction closure;
   - §3.7: require composition predecessor cause-set and Residence invalidation/fallback evidence;
   - §5: add order-independent attitude composition and one Residence commit/person/cycle invariants;
   - §6: explicitly point Slice-1 acceptance at the amended VS-SFL-096/097, 074/075, and 081 cases;
   - §7: require evidence for attitude-cause permutation and Residence fallback sensitivity.

### Architecture

**No amendment to ADR-0004 is recommended.** The proposed rules instantiate domain semantics inside the already accepted deterministic kernel. They do not change the single-threaded execution architecture, actor/world mutation boundary, stable-cycle rule, or persistence model.

---

## 13. IMP-0001 knock-on effect

If approved, IMP-0001 becomes more constrained but not broader.

### Required implementation behavior

- maintain or derive a per-directed-attitude set of direct §3.1 contributions for the cycle's reaction closure;
- produce one bounded composition transition per affected directed attitude/direct-cause batch with full predecessor attribution;
- ensure enumeration order cannot affect the result;
- group valid accepted Residence effects by mover/person;
- allow at most one commit per person/cycle;
- use the existing resolver fallback only after the explicit Residence conflict classification exists;
- preserve Accept response records for losing Residence contenders and emit `InvalidatedAtResolution(CompetingResidenceTransition)`;
- mark fallback use.

### Not required

- no generic event-composition algebra;
- no general causal-DAG framework beyond the already required predecessor references/history;
- no new planning layer;
- no secret tests;
- no broad scheduler redesign;
- no new public architecture boundary;
- no household semantics.

The implementation agent should not receive discretion to replace the approved rules with “whichever deterministic order is easiest.”

---

## 14. Director approval

**Required for both recommendations.**

These are not mere clarifications of already unique accepted behavior. The current accepted authority admits multiple stable outcomes, and each recommendation selects one behavioral contract:

- attitude recommendation selects **net direct same-cycle bounded composition** over discrete ordered saturation;
- Residence recommendation selects **one committed move/person/cycle** over potentially multiple ordered physical moves.

The Master Architect can draft/promote the approved wording, but the behavior choice should be explicitly approved by the Director before canonical amendment and IMP-0001 release.

---

## 15. Residual risks and deferred questions

1. **Future causally downstream attitude effects.** The recommended attitude rule intentionally covers the currently specified direct §3.1 causes. If a later slice introduces an attitude effect caused by another automatic reaction, its causal placement must be explicit. Do not silently expand the direct batch.

2. **Intermediate attitude observability.** The recommendation deliberately removes arbitrary intermediate bounded attitude values among independent direct causes. If a future accepted semantic rule needs such an intermediate value, that rule must establish a true causal order.

3. **Residence fallback remains socially arbitrary.** In an otherwise equal Residence conflict, stable-ID fallback can choose different destinations under relevant ID renaming. This is acceptable only because the fallback is explicit, logged, and not represented as actor preference.

4. **Later Residence priorities.** A richer model may later decide that personal initiative, prior commitment, destination type, household duty, or another social factor should prioritize one Residence transition. R1 leaves room for that: add an accepted semantic priority before the technical fallback rather than changing response architecture.

5. **Cycle duration is not historical calibration.** The one-transition cap is a v0 temporal compatibility rule, not a claim that a historical person could never change dwelling twice in the real-world duration represented by a cycle.

6. **No hidden origin precondition.** Implementation should not additionally require the mover to remain at the snapshot-origin dwelling unless that is separately approved. The recommended conflict rule is sufficient.

7. **No reaction-type priority implied.** The attitude recommendation does not say gifts, refusals, repayments, or due-review penalties are more important than one another. Their fixed signed deltas all contribute.

No stop condition from the B2 README was triggered. The two repairs can be expressed as narrow SFL-v0 semantics without changing a founding/architectural principle, selecting historical calibration, or requiring broad new infrastructure.

---

## 16. Director-facing choices

### Choice A — bounded attitude composition

**What changes in simulated behavior:** independent same-cycle direct attitude causes no longer get different weight merely because one happens to be processed nearer the `+100/-100` bound. Example: `+95 +10 -20` ends at **+85**.

**Recommended:** direct-cause commutative batch, sum then clamp once, preserving all causal predecessors.

**Credible alternative:** define and approve a canonical sequential semantic precedence, then clamp after each event.

**Why this cannot remain a local implementation detail:** `+80` versus `+85` is authoritative social state and can later change thresholds, scoring, and behavior. A queue/order choice would silently become simulation semantics.

### Choice B — same-cycle Residence competition

**What changes in simulated behavior:** a person may independently Accept multiple residence proposals, but the world records at most one Residence move for that person in the cycle. Other accepted contenders are resolution invalidations.

**Recommended:** one committed Residence transition/person/cycle; explicit same-person conflict set; existing disclosed stable-ID fallback only when no semantic priority distinguishes contenders.

**Credible alternatives:** canonical ordered multi-move semantics, or an origin-lock rule plus an explicit winner order.

**Why this cannot remain a local implementation detail:** different orders produce different final dwellings and therefore different later co-residence incentives and other Residence-dependent behavior. The resolver must not decide that by accidental mutation order.
