# TRES-0010B-T — Temporal / Conflict Prosecution Report

## Run provenance

- **Task ID / role:** TRES-0010B-T-PROSECUTION / prosecution-falsification
- **Frozen Wave-B canonical baseline:** `tres-0010-wave-b-baseline`
- **Resolved baseline SHA:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Assigned return branch/workspace:** `tres-0010/wb-t-prosecution`
- **Return branch start state:** resolved to the frozen Wave-B baseline SHA before review
- **Model/configuration:** GPT-5.6 Sol; hidden reasoning configuration not externally exposed
- **Tools used:** GitHub repository connector for branch/ref verification, bounded file retrieval, baseline inspection, compare, and isolated return-file write
- **External research:** no
- **Assigned Wave-A reports read:**
  - `tres-0010/c` @ `283730d8e91de9743195d9fd13c635baa2131cbb` — `TRES-0010C_TEMPORAL_DETERMINISM_REPORT.md`
  - `tres-0010/h` @ `138b69cf7d24765d757e33278f7d76daa4591bcb` — `TRES-0010H_ADVERSARIAL_TRAJECTORIES_REPORT.md`
- **Opposing Wave-B return read before completion:** **no**
- **Unrelated Wave-A returns read:** **no**
- **Original Wave-A task packets read:** no
- **Canonical files modified:** no; this report is advisory only

## 1. Scope and method

This prosecution independently tested the three assigned claims rather than adopting Wave-A severity labels:

1. **C-F01** — mixed automatic reactions near bounded attitude state;
2. **C-F02** — multiple accepted residence changes to one person in one cycle;
3. **H-002** — accepted role-scoped action versus same-cycle destruction of the authority that makes it valid.

For each claim I:

- reconstructed the smallest valid trace;
- checked every action/state against the frozen accepted baseline;
- searched the accepted specification, ADR, verification cards, and IMP-0001 handoff for a unique ordering/conflict rule;
- tried to close the claim using revalidation, stable-ID fallback, phase ordering, invariants, and existing narrow causal priorities;
- classified Slice-1 impact separately from later-slice impact.

The assigned Wave-A reports are treated below as inherited allegations. The verdicts rest on independently rechecked accepted authority.

## 2. Finding matrix

| Challenged finding | Verdict | Slice impact | Confidence |
|---|---|---|---|
| C-F01 mixed bounded attitude reactions | `CONFIRMED_BLOCKER_SLICE1` | Directly in IMP-0001 | High |
| C-F02 multiple accepted residence changes | `CONFIRMED_BLOCKER_SLICE1` | Directly in IMP-0001 | High |
| H-002 role-scoped action vs authority destruction | `CONFIRMED_LATER_SLICE_GAP` | Real semantic gap, but household/head/mediated-marriage substrate is explicitly out of IMP-0001 | High |

---

## 3. C-F01 — mixed automatic reactions near bounded attitude state

### Verdict

**`CONFIRMED_BLOCKER_SLICE1`**

The gap is semantic, not merely a verification omission or an implementation-local guard. Two executions can preserve the same snapshot, decisions, accepted/failure outcomes, and cause set while producing different authoritative attitude state.

### Accepted authority independently verified

- `SPEC-SFL-0001` §3.1:
  - directed attitude is bounded to [-100,+100];
  - accepted gift/help gives recipient -> giver +10;
  - refusal of called favour gives holder -> refuser -20.
- SPEC §5.1:
  - response contexts read the common committed cycle snapshot;
  - responses do not consume personal initiative;
  - multiple response contexts may activate.
- SPEC §9.1:
  - ordinary decisions/responses resolve before automatic semantic reaction closure;
  - intermediate microsteps are not a new voluntary cycle state.
- SPEC §9.3:
  - reactions are cause-keyed/idempotent;
  - the rule prevents duplicate application but does not order distinct causes.
- SPEC §9.4 and §10:
  - consequential history records `Cycle, ReactionIndex`;
  - `ReactionIndex` must be monotone;
  - attitude must remain bounded.
- `ADR-0004_REFERENCE_SIMULATION_KERNEL.md`:
  - runtime iteration/reaction scheduling order must not silently become authority;
  - mutation order cannot determine behavior merely because it happened first.
- `VS-SFL-074`:
  - pins one-cause idempotence, not ordering among different causes.
- `VS-SFL-075`:
  - pins reaction closure/progress and causal ordering where causally defined, not a total order for independent causes.
- `VS-SFL-097`:
  - explicitly requires saturation at +/-100.
- IMP-0001 §§3.3, 3.5, 3.6:
  - automatic attitude reactions, gift/help, favour fulfil/refusal, resolution, reaction closure, and `ReactionIndex` are all Slice-1 substrate.

### Minimal valid trace

Initial common state in cycle N:

- stored attitude `A -> B = +95`;
- B owes A one valid outstanding favour;
- B has enough grain and uses its one personal initiative to submit `OfferGift(B -> A, 1)`;
- A's gift response is Accept;
- A independently uses its one personal initiative to `CallFavor(A -> B)` for an otherwise-feasible ordinary action;
- B's favour response is RefuseCalledFavor.

Validity checks:

- B's gift initiative and B's response to A's call are separate because responses do not consume personal initiative.
- A's CallFavor initiative and A's response to B's gift are likewise separate.
- the gift and called-favour interaction are both legal from the same committed snapshot;
- the refusal leaves the favour outstanding and triggers A -> B -20;
- the accepted gift triggers A -> B +10.

At automatic closure the same two distinct valid cause effects target one bounded authoritative field.

**Execution X**
1. gift reaction: +95 + 10 -> clamp +100;
2. favour-refusal reaction: +100 - 20 -> **+80**.

**Execution Y**
1. favour-refusal reaction: +95 - 20 -> +75;
2. gift reaction: +75 + 10 -> **+85**.

Both respect:
- one application per cause;
- bounded attitude;
- monotone ReactionIndex;
- no same-cycle voluntary reactivation.

They disagree on authoritative stable-cycle state.

### Strongest attempted disconfirmation

#### Route A — ReactionIndex already defines the order

Rejected. The accepted text requires ReactionIndex to be monotone and retained in history, but nowhere derives which independent cause receives the earlier index. It records an order after selection; it does not select that order.

#### Route B — stable-ID fallback supplies a canonical reaction order

Rejected. SPEC §9.2 places stable-ID fallback in proposal/conflict resolution for equal-priority unresolved symmetry. No accepted clause extends that fallback to arbitrary automatic-reaction cause scheduling. Extending it would introduce a new semantic ordering rule, and different deterministic cause orderings still choose +80 versus +85.

#### Route C — determinism/metamorphic requirements make any fixed queue order acceptable

Rejected. Determinism only says repeated equivalent runs must agree and nonsemantic collection order must not leak into semantics. Multiple deterministic implementations could choose different semantic cause orders and each be internally repeatable. Because saturation is non-commutative for mixed signs, the choice changes authoritative state and therefore is not safely local/reversible implementation discretion.

### Scope impact

This blocks IMP-0001 as written. Slice 1 explicitly implements the affected actions, automatic attitude consequences, bounded attitude, reaction closure, and semantic history. An implementation agent cannot choose among +80/+85 without adding domain semantics.

### Confidence

**High.**

---

## 4. C-F02 — multiple accepted residence changes to one person

### Verdict

**`CONFIRMED_BLOCKER_SLICE1`**

The accepted baseline does not uniquely classify multiple same-cycle residence writes to one person as a mutually exclusive conflict, nor does it define a one-transition-per-cycle rule or canonical multi-transition order. Immediate precommit revalidation alone does not close the case.

### Accepted authority independently verified

- SPEC §2.3:
  - Residence is an explicit person -> dwelling relation.
- SPEC §3.6:
  - residence change is proposal-based;
  - named counterpart acceptance is sufficient in v0.
- SPEC §5.1:
  - one target may process multiple response contexts from the common snapshot;
  - multiple Accept responses are legal;
  - later capacity/conflict loss is handled only at central resolution.
- SPEC §9.2:
  - every proposal is revalidated immediately before commit;
  - accepted incompatible proposals *may* become `InvalidatedAtResolution`;
  - equal-priority unresolved symmetry uses disclosed stable-ID fallback.
- `VS-SFL-096`:
  - an accepted move/invite changes the target's Residence relation;
  - no one-residence-transition-per-cycle limit is stated.
- `VS-SFL-103`:
  - explicitly validates that one target can Accept multiple proposals from the common snapshot before central resolution.
- Cross-cutting contract:
  - nonsemantic storage/input permutation must not change semantic result;
  - collection iteration order is not an allowed conflict rule.
- IMP-0001 §§3.2, 3.5, 3.6:
  - Residence, move/invite proposal and response, and central resolution are Slice-1 requirements.

### Minimal valid trace

Common snapshot:

- B resides at D0;
- A resides at D1;
- C resides at D2;
- A uses its personal initiative to invite B into A's dwelling D1;
- C uses its personal initiative to invite B into C's dwelling D2;
- B receives two response contexts from the common snapshot and Accepts both.

Every action is valid:

- A and C each spend only their own personal initiative;
- B may answer both because responses consume no personal initiative;
- named counterpart acceptance is sufficient;
- both proposals are individually feasible from the common snapshot.

Now central resolution begins.

**Execution X**
1. commit A's accepted invitation: B D0 -> D1;
2. revalidate C's accepted invitation;
3. current authority contains no rule saying B's prior same-cycle move makes this accepted residence proposal infeasible;
4. commit B D1 -> D2;
5. stable state: **B at D2**.

**Execution Y**
1. commit C's invitation: B D0 -> D2;
2. revalidate A's invitation under the same reasoning;
3. commit B D2 -> D1;
4. stable state: **B at D1**.

A third implementation can pre-classify both writes as one mutually exclusive conflict set and let one survive. The baseline does not say that this is the required interpretation.

### Strongest attempted disconfirmation

#### Route A — a single-valued Residence relation makes the proposals inherently incompatible

Not enough. Single-valuedness prevents two simultaneous current residences; it does not prevent two sequential same-cycle transitions. After the first commit the relation remains well formed, and the second action's stated semantics can still change that relation again. No accepted clause says "at most one residence transition per person per cycle."

#### Route B — immediate revalidation invalidates the second proposal

Rejected as a unique answer. The proposal's accepted semantics do not state an origin-residence lock. After B moves once, B is still a person with a Residence relation and the named counterpart's acceptance still exists. Treating the original residence as a hidden precondition would itself add semantics.

#### Route C — stable-ID fallback already selects one accepted residence proposal

Rejected as a unique answer. Stable-ID fallback applies after the engine has a semantic conflict/equal-priority symmetry to resolve. The missing step here is exactly whether sequentially valid writes to the same Residence relation form one mutually exclusive conflict set. The accepted baseline does not define that classification. Globally sorting every nonconflicting proposal by stable ID would also make technical IDs control semantic transition order outside an explicitly declared fallback case.

#### Route D — storage-permutation metamorphism forces the intended rule

Rejected. It forbids container order from deciding the result, but it does not say whether the lawful result is one selected move or multiple canonically ordered moves. It detects the underspecification; it does not resolve it.

### Scope impact

Direct Slice-1 blocker. IMP-0001 explicitly includes residence state, move/invite response semantics, and the central resolver. Different conforming implementations can end the same cycle in different dwellings.

### Confidence

**High.**

---

## 5. H-002 — accepted role-scoped action versus same-cycle authority destruction

### Verdict

**`CONFIRMED_LATER_SLICE_GAP`**

The semantic gap survives prosecution, but Wave A overstates its relevance to IMP-0001. The entire witness depends on household participation, head authority, and household-mediated marriage, all explicitly excluded from Slice 1.

### Accepted authority independently verified

- SPEC §4.2:
  - household-mediated marriage requires a valid current household/head route;
  - head acceptance is sufficient subject to other preconditions.
- SPEC §5.1:
  - role-scoped responses read the common snapshot;
  - response does not consume the role-holder's personal initiative.
- SPEC §7.4:
  - a current sustaining participant may voluntarily `EndHouseholdParticipation(H)`;
  - if that participant is head, participation end vacates the head role.
- SPEC §8.4:
  - head authority is scoped and persistent; outgoing head may nominate before vacating.
- SPEC §9.2:
  - immediate precommit revalidation includes household/head validity;
  - material priority rules do not cover this pair;
  - a separate narrow causal-handoff priority exists for a participation entry whose continuity bridge is also exiting.
- `ADR-0004`:
  - transient mutation order may not silently determine behavior.
- `VS-SFL-062/063`:
  - independently pin vacancy/succession effects.
- `VS-SFL-104`:
  - independently pins actual role authority as a categorical gate for mediated-marriage response.
- `VS-SFL-013`:
  - for the analogous asymmetric bridge-entry/bridge-exit dependency, the accepted design explicitly supplies a narrow semantic order rather than leaving it to mutation order.
- IMP-0001 §4 explicitly excludes:
  - Household / SustainingParticipant / participation warrants;
  - household recognition or head recognition;
  - household provision/head role/household-mode action;
  - household-mediated marriage.

### Minimal valid trace

Initial common snapshot:

- H is Active;
- P is a current SustainingParticipant and valid current head;
- bride B is a current SustainingParticipant;
- groom G satisfies the mediated-route subjective/eligibility requirements;
- valid provision backing covers dowry;
- P is free to end participation.

Same-cycle decisions:

1. G submits an otherwise-valid household-mediated marriage proposal through P.
2. P's role-scoped response selects Accept.
3. P independently uses the personal initiative to `EndHouseholdParticipation(H)`.

This combination is valid from the common snapshot because the role response does not consume P's personal initiative.

**Execution A — role-dependent action first**
1. revalidate mediated marriage while P is still head;
2. commit marriage/dowry/favour effects;
3. commit P's participation end;
4. head becomes vacant.

**Execution B — authority destruction first**
1. commit P's participation end;
2. head becomes vacant;
3. revalidate the already-accepted mediated marriage;
4. it fails as `InvalidatedAtResolution(HeadRoleNoLongerValid)`.

The histories differ in marriage, material spend, favour creation, and failure outcome.

### Strongest attempted disconfirmation

#### Route A — immediate revalidation uniquely resolves the pair

Rejected. Revalidation determines what happens *given an order*. It does not choose whether the authority-dependent action or authority-destroying action is revalidated/committed first.

#### Route B — equal-priority stable-ID fallback closes the conflict

Rejected as a unique accepted interpretation. The pair is not ordinary symmetric competition for one indivisible resource. One ordering allows both actions to commit; the other destroys a precondition and suppresses one action. To use fallback, an implementation must first decide that these heterogeneous actions form one competing conflict set and what "winner" means. That classification is not stated.

The accepted bridge-handoff rule is strong counterevidence to treating this whole class as automatically covered by technical fallback: where entry depends on a bridge who is also exiting, SPEC §9.2 explicitly provides a narrow causal order and says it is not a general entry-over-exit rule.

#### Route C — personal actions always precede or follow household/role actions by phase

Rejected. SPEC §9.1 puts personal/household deliberation before responses and then central resolution; it does not create a personal-versus-household commit subphase ordering.

### Scope impact

**Later slice only.**

This is a genuine accepted-semantic gap for the later household/head/mediated-marriage implementation, but it does **not** by itself block IMP-0001 because IMP-0001 explicitly forbids implementing that substrate.

If Wave B adjudicates only H-002, its correct TRES-0010 state for the current dispatch gate is therefore not `CONFIRMED_REPAIR_BEFORE_SLICE1`; it is `CONFIRMED_LATER_SLICE_GAP`.

### Confidence

**High.**

---

## 6. Related structural-class search

No additional independent blocker is promoted from the bounded search.

I tested three nearby classes specifically to avoid overgeneralizing the findings:

1. **Two accepted ordinary grain transfers competing for one unit.**  
   This is already closed by SPEC §9.2 plus VS-SFL-071/103: actual scarce capacity conflict, revalidation, equal-priority fallback, one committed effect, one `InvalidatedAtResolution`.

2. **Two direct-marriage attempts sharing a person.**  
   The explicit at-most-once-marriage invariant makes the second establishment infeasible after the first commit; this is a genuine mutual-exclusion case rather than the residence "sequential writes remain feasible" pattern. A conflict/fallback implementation has accepted semantic grounding here.

3. **Participation entry depending on a bridge who exits in the same cycle.**  
   This is the closest structural analogue to H-002 and is already closed explicitly by SPEC §9.2 / VS-SFL-013's narrow causal-handoff priority.

The surviving common failure class is therefore narrower:

> same-cycle accepted effects whose composition is non-commutative or whose order destroys another effect's precondition, where accepted authority neither defines a semantic order/aggregation nor clearly classifies the pair as a mutually exclusive conflict.

C-F01, C-F02, and H-002 each satisfy that condition for different reasons.

## 7. Final prosecution disposition

- **C-F01:** `CONFIRMED_BLOCKER_SLICE1`
- **C-F02:** `CONFIRMED_BLOCKER_SLICE1`
- **H-002:** `CONFIRMED_LATER_SLICE_GAP`

This report does **not** propose a repair. It establishes only that the first two unresolved choices must be settled at accepted semantic authority before IMP-0001 can safely implement the affected Slice-1 behavior, while H-002 should be carried forward to the later household/head slice rather than treated as an IMP-0001 blocker.
