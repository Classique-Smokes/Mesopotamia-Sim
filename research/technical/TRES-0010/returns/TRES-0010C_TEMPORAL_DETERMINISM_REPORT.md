# TRES-0010C — Temporal / Determinism / Conflict Red-Team Report

## Run provenance

- **Task ID:** TRES-0010C
- **Frozen baseline ref:** `tres-0010-review-baseline`
- **Resolved baseline commit:** `8966b9862aa16b53f9a73d5ebebe8c0f0864d4ac`
- **Dedicated return branch:** `tres-0010/c`
- **Branch state at start:** identical to frozen baseline
- **Model/configuration:** GPT-5.6 Sol; hidden reasoning configuration not externally exposed
- **Tools used:** GitHub repository connector for branch/ref inspection, constrained file retrieval, compare, and isolated return-file write
- **External web research:** no
- **Prior TRES-0003–0009 read:** no
- **Sibling Wave-A returns read before initial report:** no
- **Source-discipline note:** initial findings were drafted from the packet-mandated source set. Narrow post-draft higher-authority checks of SPEC §§2.3, 3.1, and 3.6 were used only to validate the two traces; no prior TRES review or Wave-A return was consulted.

## 1. Executive finding summary

**Recommendation: BLOCK IMPLEMENTATION.**

Two accepted-semantic gaps can make same-cycle execution depend on an ordering choice that the accepted kernel does not define:

1. **TRES-0010C-F01 — automatic reaction closure is not confluent or canonically ordered.** Opposite-signed same-cycle attitude reactions against bounded state can produce different stable-cycle values from the same causes.
2. **TRES-0010C-F02 — multiple accepted residence changes to one person have no defined same-cycle conflict rule.** Because responses may accept multiple proposals from the common snapshot and residence change remains feasible after a first move, two plausible resolver executions end in different dwellings.

A third finding is verification-facing:

3. **TRES-0010C-F03 — the packet-mandated explicit Slice-1 cards do not directly pin either failure mode.** General determinism/cross-cutting suites referenced by IMP-0001 were outside this task's restricted first-pass source set, so this finding is scoped to the explicit cards reviewed; regardless, a generic test cannot choose the missing semantics on behalf of the specification.

Both F01 and F02 require a semantic decision before code. A local implementation ordering rule would otherwise become undeclared simulation authority.

---

## 2. Detailed findings

### TRES-0010C-F01 — Mixed automatic reactions can produce order-dependent stable state

- **Classification:** missing semantic rule / implementation hazard
- **Severity:** `BLOCKER_BEFORE_CODE`
- **Fix type:** semantic, followed by verification coverage
- **Confidence:** high

#### Evidence

- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`, Decision / Consequences:
  - single-threaded deterministic reference kernel;
  - stable cycle exists only after resolution and automatic reaction closure;
  - runtime iteration/reaction scheduling order must not silently become authority.
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`:
  - §3.1 defines fixed positive and negative attitude updates;
  - §9.1 places automatic semantic reactions in same-cycle closure;
  - §9.3 requires cause-keyed/idempotent reactions but gives no total order or confluence rule;
  - §9.4 makes `ReactionIndex` part of semantic history;
  - §10 requires attitude to remain in [-100,+100] and `ReactionIndex` monotonicity.
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-097:
  - attitude updates saturate at +/-100.
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`, VS-SFL-074/075:
  - duplicate-cause protection and closure progress are tested, but the reviewed cards do not define ordering for distinct simultaneously enabled causes.

#### Smallest failing trace

Initial committed state at cycle N:

- stored attitude `A -> B = +95`;
- B owes A one favour;
- B's personal initiative produces an accepted voluntary Gift to A;
- A's personal initiative is a valid `CallFavor` to B;
- B voluntarily refuses the called favour;
- both decision paths are valid from the common snapshot.

Closure has two distinct valid semantic attitude causes affecting the same bounded field:

- accepted gift: `A -> B +10`;
- called-favour refusal: `A -> B -20`.

Two plausible executions satisfy the current idempotence and monotone-`ReactionIndex` rules:

**Execution X**
1. apply gift reaction: +95 + 10 => saturates to +100;
2. apply refusal reaction: +100 - 20 => **+80**.

**Execution Y**
1. apply refusal reaction: +95 - 20 => +75;
2. apply gift reaction: +75 + 10 => **+85**.

Same snapshot, same voluntary decisions, same accepted/failure outcomes, same reaction cause set; different stable-cycle authoritative state.

Even when two reactions commute in state, the current text also permits their `ReactionIndex` assignments to swap, producing different semantic history unless a canonical reaction-order rule exists.

#### Why existing authority does not answer it

Cause-key idempotence prevents duplicate application of one cause; it does not choose an order among distinct valid causes. Monotone `ReactionIndex` records an order after one has been chosen; it does not define which order is semantically correct. Saturation makes simple sequential application non-commutative.

A local queue order, hash order, insertion order, or implementation-chosen cause sort would therefore create simulation semantics not selected by accepted authority.

#### Consequence if ignored

- repeated runs can become sensitive to queue/container scheduling;
- different conforming implementations can reach different stable cycle states;
- history order can diverge even when state happens to commute;
- future checkpoint/replay exactness inherits the arbitrary order;
- later threshold-sensitive behavior can diverge from the first affected cycle onward.

#### Recommended disposition

Before IMP-0001 dispatch, define one accepted rule for simultaneous automatic effects, for example either:

- a canonical total ordering over enabled semantic reaction causes, including how `ReactionIndex` is assigned; **or**
- an explicit aggregation rule for commensurable state updates (for example, net attitude delta followed by one clamp) plus a canonical history-order rule.

The choice is semantic because the alternatives produce different values near bounds. Then add a permutation/confluence acceptance case using mixed-sign updates to one attitude.

---

### TRES-0010C-F02 — Multiple accepted residence changes can overwrite by resolver order

- **Classification:** missing semantic rule / implementation hazard
- **Severity:** `BLOCKER_BEFORE_CODE`
- **Fix type:** semantic, followed by verification coverage
- **Confidence:** high

#### Evidence

- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`:
  - §2.3: Residence is an explicit person -> dwelling relation;
  - §3.6: residence change is proposal-based; named counterpart acceptance is sufficient in v0;
  - §5.1: one target may have multiple response contexts in a cycle, each reading the common committed snapshot; multiple Accept responses are permitted;
  - §9.2: accepted proposals are revalidated before commit; accepted incompatible proposals *may* fail as `InvalidatedAtResolution`; equal-priority unresolved symmetry uses stable-ID fallback.
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`, family invariants / VS-SFL-103:
  - multiple responses by one target are explicitly allowed from the common snapshot.
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`, VS-SFL-096:
  - accepted residence proposal changes the person's Residence relation;
  - no per-cycle residence-transition limit is stated.
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` §§3.5–3.6:
  - residence move/invite and central resolution are in Slice 1.

#### Smallest failing trace

Common cycle snapshot:

- B resides at D0;
- A resides at D1;
- C resides at D2;
- A uses its personal initiative to invite B to D1;
- C uses its personal initiative to invite B to D2;
- B receives two independent response contexts and selects Accept for both from the common snapshot.

At resolution, both accepted proposals remain individually meaningful. After one residence move commits, current authority does not state that:

- B becomes ineligible to perform another accepted residence change in the same cycle;
- the second proposal must be invalidated because another residence write already committed;
- residence writes form a mutually exclusive conflict class resolved before either commit.

Therefore two plausible executions exist:

**Execution X**
1. commit A's accepted invite: B D0 -> D1;
2. revalidate C's accepted invite; named acceptance still exists and no stated rule makes it invalid;
3. commit: B D1 -> D2;
4. stable state: **B at D2**.

**Execution Y**
1. commit C's accepted invite: B D0 -> D2;
2. revalidate A's accepted invite; same reasoning;
3. commit: B D2 -> D1;
4. stable state: **B at D1**.

A third implementation could instead classify the two writes as incompatible before commit and choose one by stable-ID fallback. That produces a different history and potentially a different winner. The accepted text does not tell the implementer which interpretation is correct.

The problem becomes even sharper when B also has its own accepted personal move proposal in the same cycle: personal initiative plus multiple incoming responses can create three accepted writes to the same single-valued Residence relation.

#### Why existing authority does not answer it

Immediate precommit revalidation is insufficient because the first move does not obviously falsify the semantic preconditions of the second move. The generic phrase "accepted but incompatible proposals may fail" does not define whether sequentially valid writes to one single-valued relation are incompatible, nor does it impose a one-residence-change-per-cycle rule.

Stable-ID fallback only helps after the system has a semantic rule saying these proposals are competing members of one conflict set.

#### Consequence if ignored

- final residence can depend on resolver/proposal iteration order;
- semantic history can record one move or multiple moves depending on implementation;
- same inputs can produce different later co-residence candidate sets and relationship behavior;
- a local write-conflict heuristic becomes undeclared domain semantics.

#### Recommended disposition

Before IMP-0001 dispatch, choose and record one rule, for example:

- **single-transition rule:** at most one committed Residence change per person per cycle, with competing accepted changes resolved through the ordinary priority/domain-tie/stable-ID mechanism; or
- **ordered multi-transition rule:** multiple same-cycle residence changes are legal, but their canonical semantic order is explicitly defined.

The first is narrower and easier to verify, but the report does not select it as authority. Add an acceptance case with two accepted invitations to one target, plus a three-way personal-move + two-response variant.

---

### TRES-0010C-F03 — Explicit Slice-1 verification cards do not directly force the two conflict semantics above

- **Classification:** verification weakness
- **Severity:** `MEDIUM_AMEND_OR_GUARD`
- **Fix type:** verification-only after F01/F02 semantic repair
- **Confidence:** medium

#### Evidence

Within the task-mandated verification sources:

- VS-SFL-103 checks two accepted responses competing for scarce grain, where one winner/one invalidation is already expected;
- VS-SFL-105 checks a **compatible** personal initiative plus incoming response;
- VS-SFL-096 checks one residence change at a time;
- VS-SFL-074 checks duplicate-cause idempotence;
- VS-SFL-075 checks closure progress but not mixed-sign bounded-state confluence.

IMP-0001's explicit minimum scenario list likewise names VS-SFL-090–105 plus 070/071/073/074 as applicable.

#### Smallest cheat

An implementation can:

- process distinct reaction causes in one fixed local queue order;
- process multiple accepted residence writes in proposal insertion order;

and still satisfy the single-event/single-conflict cases above while embedding undeclared order semantics.

#### Uncertainty

IMP-0001 also references broader cross-cutting/determinism verification artifacts that were not part of this task's restricted first-pass source set. They may catch some order sensitivity. They cannot, however, determine the missing expected outcome until F01/F02 are semantically resolved.

#### Recommended disposition

After semantic repair, add targeted acceptance/metamorphic tests that permute:

1. reaction queue/insertion order for the same mixed-sign cause set;
2. proposal/response insertion order for competing residence writes.

Expected stable state **and semantic history** must remain identical except where the accepted rule explicitly declares stable-ID sensitivity.

---

## 3. Attempted attacks that did not expose a separate defect

### A. Two accepted ordinary grain transfers competing for one available unit

The combination is explicitly anticipated. Response contexts may both Accept from the common snapshot; central revalidation admits only one commit; equal-priority unresolved symmetry uses the disclosed stable-ID fallback; the loser is `InvalidatedAtResolution`, not retroactively Declined. VS-SFL-103 directly exercises the pattern.

**Result:** no separate defect found.

### B. Debt repayment versus another same-cycle transfer, including N+3 review

The accepted text deliberately does not let debt/favour silently reserve grain. Revalidation resolves actual remaining capacity, and debt social-due review occurs only after cycle N+3 ordinary decisions/commits and repayment opportunities.

**Result:** no resource-order defect found beyond F01 if the successful-repayment attitude reaction and the due-cycle penalty hit the same bounded attitude in one closure.

### C. NeedsGrain maintenance/clearing plus proposals

Maintenance precedes the common decision snapshot. A NeedsGrain actor cannot Farm. A valid transfer can clear NeedsGrain, but no same-cycle voluntary reactivation is granted merely because need clears.

**Result:** no same-cycle initiative/order defect found in the reviewed Slice-1 semantics.

### D. Exact-score and equal-priority fallback

The scorer and conflict rules both disclose stable-ID technical fallback rather than collection order, and IMP-0001 explicitly forbids nonsemantic collection iteration from becoming semantic order.

**Result:** no semantic defect found, with one implementation guardrail: proposal/candidate IDs used for fallback must themselves not be allocated from nondeterministic traversal/runtime order.

### E. Future household bridge-handoff race

SPEC §9.2 explicitly orders a valid bridged entry plus continuity reaction before the bridge participant's accepted exit.

**Result:** the reviewed future-compatibility race has an explicit narrow precedence rule.

### F. Checkpoint during resolution/reaction closure

ADR-0004 and SPEC §9.6 restrict checkpoints to stable cycle boundaries after reaction closure. IMP-0001 does not implement checkpointing but requires future-influencing state introduced by Slice 1 to remain explicit/serializable in principle.

**Result:** no Slice-1 blocker found from checkpoint timing itself.

---

## 4. Could not determine from the accepted artifacts in this review

1. **Derived/cache refresh timing for later household-recognition chains.** ADR-0004 places derived/index refresh after commit in its ordinary phase description, while SPEC §9.1 places final record/refresh with stable-cycle publication and VS-SFL-075 expects a multi-step household formation chain during automatic closure. The restricted Task-C source set does not include enough household-recognition semantics to construct a valid accepted-rule counterexample, so this is not promoted to a finding here.
2. **Coverage in broader determinism/cross-cutting files referenced by IMP-0001.** Those files were not read under the packet's restricted first-pass source discipline. This limits F03's coverage claim, not F01/F02's semantic traces.

---

## 5. Prior TRES findings read

None.

- TRES-0003: not read.
- TRES-0004–0009: not read.
- Sibling TRES-0010 Wave-A returns: not read.

---

## 6. Recommendation

**BLOCK IMPLEMENTATION.**

Repair F01 and F02 at accepted semantic authority before dispatching IMP-0001. Then add direct verification for both resolved rules. F03 is an amendment/guard item contingent on those semantic decisions.

The required repair is small in surface area but not safely delegable to an implementation agent, because either local choice changes authoritative same-cycle outcomes and/or semantic history.
