# TRES-0010B-T-DEFENSE — Temporal / Conflict Composition Defense Report

## Run provenance

- **Task ID / role:** `TRES-0010B-T-DEFENSE` — defense / closure attempt
- **Frozen Wave-B baseline ref:** `tres-0010-wave-b-baseline`
- **Resolved baseline commit:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Assigned return branch / workspace:** `tres-0010/wb-t-defense`
- **Return-branch state at start:** identical to the frozen Wave-B baseline
- **Model/configuration:** GPT-5.6 Sol; hidden reasoning configuration not externally exposed
- **Tools used:** GitHub repository connector for branch/ref inspection, constrained file retrieval, baseline comparison, and isolated return-file write
- **External research:** no
- **Assigned Wave-A reports read:** `TRES-0010C_TEMPORAL_DETERMINISM_REPORT.md` from branch `tres-0010/c`; `TRES-0010H_ADVERSARIAL_TRAJECTORIES_REPORT.md` from branch `tres-0010/h`
- **Opposing Wave-B return read before completion:** **no**
- **Unrelated Wave-A returns read:** **no**
- **Evidence discipline:** Wave-A C/H reports were treated as inherited claims/counterexamples, not authority. Every disposition below was rechecked against accepted/canonical artifacts at the frozen Wave-B baseline. References inside the H report to earlier TRES work were not followed.

## 1. Executive disposition

The defense closes none of the three semantic questions outright, but it materially narrows one of them.

| Finding | Wave-B result state | Slice-1 impact | Confidence | Defense result |
|---|---|---|---|---|
| C-F01 — mixed same-cycle attitude reactions | `CONFIRMED_REPAIR_BEFORE_SLICE1` | Directly in IMP-0001 | High | Closure failed |
| C-F02 — multiple accepted residence changes | `CONFIRMED_REPAIR_BEFORE_SLICE1` | Directly in IMP-0001 | High | Closure failed |
| H-002 — accepted head-scoped action versus same-cycle authority destruction | `CONFIRMED_LATER_SLICE_GAP` | Explicitly outside IMP-0001 | High | Semantic closure failed; Slice-1 blocking claim defeated |

The important defense-side narrowing is H-002. Its counterexample survives accepted authority, but IMP-0001 explicitly excludes household participation, head roles, and household-mediated marriage. Therefore H-002 must not be used as a blocker for Slice 1.

C-F01 and C-F02 are different: the exact mechanisms needed for both counterexamples are in IMP-0001, and the current authority does not uniquely resolve the competing outcomes. Both are narrow semantic repairs rather than evidence that the Slice-1 architecture is structurally unimplementable, hence `CONFIRMED_REPAIR_BEFORE_SLICE1` rather than a broader blocker classification.

---

## 2. C-F01 — mixed automatic reactions on bounded attitude

### Result

**`CONFIRMED_REPAIR_BEFORE_SLICE1`**

**Confidence:** high.

### Inherited claim

Wave-A C claimed that two distinct valid same-cycle automatic attitude effects on the same ordered attitude can produce different final authoritative values because each event update saturates at the [-100,+100] bound and accepted authority does not define a canonical order or aggregation rule.

### Smallest counterexample reconstruction

Use one committed decision snapshot with:

- stored `A -> B` attitude = +95;
- B owes A one outstanding favour;
- B has enough grain for a valid voluntary Gift to A;
- A uses its personal initiative to validly `CallFavor` on B;
- B uses its own personal initiative to make the Gift to A;
- B's independent response context selects `RefuseCalledFavor`.

This composition is valid under the accepted Slice-1 agency rules:

- the gift is a personal voluntary action;
- the called-favour response is a response decision and does not consume B's personal initiative;
- the two accepted/final events do not contend for the same scarce capacity or invalidate one another.

The committed causes then require two automatic attitude effects on the same state field:

1. accepted gift: `A -> B +10`;
2. called-favour refusal: `A -> B -20`.

The accepted verification authority states that event updates crossing the attitude bound **saturate at the bound**.

Two sequential executions therefore produce different stable state:

- gift reaction first: +95 -> +100 -> +80;
- refusal reaction first: +95 -> +75 -> +85.

Both use the same initial snapshot, decisions, committed cause set, and fixed event deltas.

### Accepted authority independently checked

At the frozen Wave-B baseline:

- `SPEC-SFL-0001` §3.1 defines attitude as integer [-100,+100], assigns accepted gift/help +10 and called-favour refusal -20.
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` VS-SFL-097 states that updates exceeding +100/-100 saturate at the bound.
- `SPEC-SFL-0001` §9.1 places automatic semantic reactions after commit/failure and before stable-cycle publication.
- `SPEC-SFL-0001` §9.3 requires cause-keyed/idempotent automatic reactions, but only forbids duplicate application of the same cause and requires progress/no-op closure.
- `SPEC-SFL-0001` §9.4 records `Cycle/ReactionIndex`, causal predecessors, and committed effects.
- `SPEC-SFL-0001` §10 requires attitude bounds and monotone `ReactionIndex`.
- ADR-0004 forbids runtime iteration order from silently becoming simulation authority.
- VS-SFL-074 proves one automatic cause applies once; VS-SFL-075 proves multi-reaction closure/progress and monotone indexes. Neither specifies a total order among independent valid reaction causes.
- IMP-0001 §3.5 includes Gift and CallFavor/fulfil/refuse; §3.6 includes automatic same-cycle reactions to closure; §5 requires the attitude bound, one-cause idempotence, and monotone `ReactionIndex`; the determinism contract requires storage/input permutation not to alter results and stable-ID sensitivity to appear only in explicit fallback cases.

### Defense attempts

#### 1. Could generic precommit revalidation make one path invalid?

No.

The two committed source events are not competing writes to the same scarce resource. The favour refusal has no material capacity dependency, and a valid Gift does not invalidate the refusal. Immediate proposal revalidation therefore does not remove either cause.

#### 2. Could cause-key idempotence uniquely resolve the order?

No.

Cause keys prevent the *same* automatic transition from firing twice. They do not order two different valid causes.

#### 3. Could monotone `ReactionIndex` define the order?

No.

Monotonicity constrains indexes after an execution order exists. It does not define which independent reaction receives the earlier index.

#### 4. Could the generic stable-ID fallback order the reactions?

Not under current accepted authority without invention.

The stable-ID rule appears in conflict resolution for equal-priority unresolved symmetry. ASM-0007 describes it as a last-resort equal-priority tie-break, and VS-SFL-081 deliberately quarantines it to a controlled resolution state with two **otherwise semantically equal alternatives competing for one indivisible outcome**. The cross-cutting contract further requires stable-ID sensitivity only in explicit fallback cases.

Independent automatic attitude causes are not currently declared a fallback conflict set, and no accepted rule says to sort reaction causes by semantic ID. Extending the fallback to reaction scheduling would itself add semantics.

#### 5. Could this be diagnostic/history-only?

No.

The final attitude value is authoritative state. It feeds later response/action scoring and threshold gates. +80 and +85 are not merely different diagnostic orderings.

#### 6. Could all same-field deltas be aggregated before clamping?

That would resolve this trace, but it is not currently specified. Choosing aggregation is exactly one of the semantic choices under dispute and cannot be assumed as defense.

### Smallest undefined semantic choice

Accepted authority must determine **how multiple distinct same-cycle automatic attitude effects on the same ordered attitude compose when sequential clamping is non-commutative**, including the corresponding semantic history/`ReactionIndex` ordering. The unresolved choice is composition semantics itself: ordered individual application versus some other explicitly authorized composition rule.

This report does not select a rule.

### Slice-1 impact

Direct.

IMP-0001 explicitly implements Gift, CallFavor/refusal, attitude updates, automatic same-cycle semantic reactions, bounded attitude, semantic history, and deterministic ordering. An implementation must therefore choose an authoritative result for this trace.

Because the missing choice is narrow and local to reaction composition, the result state is `CONFIRMED_REPAIR_BEFORE_SLICE1`.

---

## 3. C-F02 — multiple accepted residence changes to one person

### Result

**`CONFIRMED_REPAIR_BEFORE_SLICE1`**

**Confidence:** high.

### Inherited claim

Wave-A C claimed that one target can accept multiple same-cycle residence proposals from the common snapshot, while the accepted authority does not state whether those writes are mutually exclusive or sequentially legal. If both remain valid under precommit revalidation, final Residence can depend on resolver order.

### Smallest counterexample reconstruction

Common committed snapshot:

- B resides at D0;
- A resides at D1;
- C resides at D2;
- A validly invites B to A's current dwelling D1;
- C validly invites B to C's current dwelling D2;
- B has two response contexts and selects Accept for both from the same common snapshot.

This is permitted by the accepted response model: response contexts do not observe uncommitted effects of other responses, and multiple response contexts may activate.

Now consider two resolver sequences.

**Sequence X**

1. revalidate and commit A's accepted invite: B moves D0 -> D1;
2. revalidate C's accepted invite;
3. no accepted rule makes B's current residence at D1 disqualifying, so commit B D1 -> D2;
4. stable Residence(B) = D2.

**Sequence Y**

1. revalidate and commit C's accepted invite: B moves D0 -> D2;
2. revalidate A's accepted invite;
3. same reasoning;
4. stable Residence(B) = D1.

At every microstep the authoritative Residence relation remains single-valued.

### Accepted authority independently checked

At the frozen Wave-B baseline:

- `SPEC-SFL-0001` §2.3 states: Residence is an explicit person -> dwelling relation.
- §3.6 states that residence change is proposal-based and the named counterpart's acceptance is sufficient in v0.
- §5.1 states response contexts read the same committed cycle snapshot and do not observe uncommitted effects of other responses.
- §9.2 requires every proposal to be revalidated immediately before commit against all action-relevant preconditions.
- §9.2 says accepted but incompatible proposals **may** fail as `InvalidatedAtResolution`; it does not define every same-key Residence write as incompatible.
- §9.2 authorizes stable-ID fallback only for equal-priority unresolved symmetry after the semantic conflict/priority model has identified a competition.
- VS-SFL-096 tests one accepted residence move/invite and does not impose a per-person per-cycle transition limit.
- VS-SFL-103 proves that multiple Accept responses are legitimate from a common snapshot and that central resolution may later invalidate an actual capacity conflict.
- IMP-0001 §3.5 includes residence move/invite proposal and response; §3.6 includes central resolution/revalidation/commit; its canonical coverage includes VS-SFL-090..105 and applicable cross-cutting determinism checks.

### Defense attempts

#### 1. Does the single-valued person -> dwelling relation make the two proposals inherently incompatible?

Not uniquely.

Single-valued Residence prevents B from occupying two authoritative dwellings at the same instant. It does not state that B may undergo only one Residence transition per cycle.

Both sequential histories preserve the invariant: after each commit, Residence(B) has exactly one value.

#### 2. Does immediate precommit revalidation invalidate the second proposal?

Not on the accepted preconditions presently stated.

For an invitation, the relevant accepted semantics are proposal + named counterpart acceptance, with the inviter's current dwelling as destination. After the first move, B's current Residence changed, but no rule says "target must still reside at the snapshot-origin dwelling" or "a prior same-cycle residence commit consumes eligibility."

Thus the first move does not obviously falsify the second move's accepted preconditions.

#### 3. Does "accepted but incompatible proposals may fail" close the case?

No.

That clause defines an available outcome for proposals already determined to be incompatible. The authority does not say that multiple Residence writes for one person form a single conflict class, nor does it say that later sequentially valid writes remain compatible.

Treating same-target Residence writes as mutually exclusive is a plausible design, but it is not currently a uniquely authorized inference.

#### 4. Can stable-ID fallback choose one winner?

Only after an accepted rule identifies the proposals as competing equal-priority alternatives.

VS-SFL-081 deliberately constrains stable-ID fallback to otherwise semantically equal alternatives competing for one indivisible outcome after modeled priorities are exhausted. Applying that fallback here first requires a semantic declaration that same-cycle Residence transitions are one indivisible outcome/conflict set. That declaration is the missing rule, not an implementation detail.

#### 5. Is final write order safely local or merely diagnostic?

No.

D1 versus D2 changes authoritative Residence state and therefore later co-residence incentives, proposal feasibility, and any future semantics conditioned on residence. It is not a history-only choice.

### Smallest undefined semantic choice

Accepted authority must determine **whether multiple accepted same-cycle Residence changes targeting the same person are mutually exclusive or may compose sequentially**.

If they are exclusive, the semantic conflict class/winner mechanism must be defined by accepted authority. If multiple transitions are legal, their semantic ordering must be defined. This report does not select either family.

### Slice-1 impact

Direct.

Residence move/invite semantics, response decisions, revalidation, central resolution, and deterministic stable state are all explicitly in IMP-0001.

Because the ambiguity is narrow and repairable but cannot be delegated as a silent implementation choice, the result state is `CONFIRMED_REPAIR_BEFORE_SLICE1`.

---

## 4. H-002 — role-scoped accepted action versus same-cycle authority destruction

### Result

**`CONFIRMED_LATER_SLICE_GAP`**

**Confidence:** high.

### Inherited claim

Wave-A H claimed an ordering gap when a current household head accepts an action whose validity depends on head authority while independently taking an accepted same-cycle action that destroys that authority.

### Smallest counterexample reconstruction

Initial committed state:

- H is Active;
- P is H's current valid head and a current `SustainingParticipant`;
- bride B is a current `SustainingParticipant`;
- groom G satisfies the mediated-route recognition/eligibility requirements;
- H has sufficient valid provision backing for the proposed dowry;
- P may validly end household participation.

Same snapshot / decisions:

1. G submits a valid household-mediated marriage proposal through current head P.
2. P's role-scoped response context selects Accept.
3. P independently uses the personal initiative to select `EndHouseholdParticipation(H)`.

These are compatible at decision time because the role-scoped response is separate from P's personal initiative.

**History A — dependent action first**

1. mediated marriage revalidates while P is still current head;
2. marriage/dowry/favour commit;
3. P's participation end commits;
4. the participation end vacates H's head role.

**History B — authority destruction first**

1. P's participation end commits;
2. P ceases to be sustaining participant and the head role is vacated;
3. the already-accepted mediated marriage is revalidated;
4. current head validity fails, so the attempt becomes `InvalidatedAtResolution`.

The histories differ in marriage, dowry, favour, and causal record.

### Accepted authority independently checked

At the frozen Wave-B baseline:

- `SPEC-SFL-0001` §4.2 makes household-mediated marriage depend on recognition of H and its **current head/scope**, and says head acceptance is sufficient subject to the other preconditions.
- §7.4 permits a current sustaining participant to `EndHouseholdParticipation(H)`; participation end vacates H's head role if the exiting person is current head.
- §8.4 scopes the head role to household-mediated marriage and explicitly says an outgoing head may nominate a successor before vacating.
- §9.2 requires immediate precommit revalidation against all action-relevant preconditions, expressly including household/head validity.
- §9.2 contains a special precedence rule for a `ParticipationWarrant` that depends on a continuity bridge who is also exiting, and explicitly says this is a **narrow causal-handoff priority, not a general rule that entry outranks exit**.
- ADR-0004 states that runtime iteration/mutation order must not silently become simulation authority.
- VS-SFL-062 proves head vacancy through participation end; VS-SFL-104 proves role-scoped response requires actual role authority and that acceptance does not bypass precommit revalidation.
- VS-SFL-081 restricts the stable-ID fallback example to otherwise semantically equal alternatives after every modeled priority is exhausted.

### Defense attempts

#### 1. Does precommit revalidation close the case?

Only after an execution order has already been chosen.

If participation end commits first, revalidation invalidates the mediated action. If the mediated action commits first, it passes revalidation. Revalidation therefore exposes the order dependency rather than selecting a unique order.

#### 2. Does the outgoing-head nomination rule imply a general "head acts before vacating" priority?

No.

The accepted text specifically grants an outgoing head the ability to nominate a successor before vacating. It does not state that every already-accepted head-scoped action has causal priority over the exit.

Generalizing the nomination clause to marriage mediation would add semantics.

#### 3. Does the special participation-bridge precedence generalize?

No.

The specification expressly labels that ordering rule a **narrow causal-handoff priority** and says it is not a general entry-over-exit rule. Its presence is evidence that some causally asymmetric conflicts receive explicit precedence, not authority to extrapolate a new precedence here.

#### 4. Does stable-ID fallback choose between the two operations?

Not uniquely under current accepted authority.

VS-SFL-081 defines the fallback test using two otherwise semantically equal alternatives competing for one indivisible outcome. Here the operations are heterogeneous and causally asymmetric: one depends on authority, the other destroys that authority.

Treating them as equal-priority symmetric alternatives is a possible new semantic policy, not an already stated one.

#### 5. Does this block IMP-0001?

No. This defense route succeeds decisively.

IMP-0001's objective is the lower-level Slice-1 kernel **without implementing household identity/recognition yet**. Its explicit out-of-scope section excludes:

- CandidateOrganization / household formation;
- Household / SustainingParticipant / participation warrants;
- household recognition or head recognition;
- household provision/head role/household-mode action;
- household-mediated marriage.

It also states that cards requiring household semantics remain unimplemented and must not be faked.

Therefore the H-002 trajectory cannot execute in IMP-0001 and cannot be a Slice-1 implementation blocker.

### Smallest undefined semantic choice

For the later household-capable slice, accepted authority must determine **how an already-accepted role-scoped action composes with a same-cycle transition that destroys the role authority required by that action**.

The unresolved choice is the semantic ordering/atomicity/conflict relation between the authority-dependent action and the authority-destroying transition. This report does not select a rule.

### Slice-1 impact

None for IMP-0001.

The gap remains real for the first later slice that implements both the relevant head-scoped action and authority-destroying participation transition. Accordingly: `CONFIRMED_LATER_SLICE_GAP`.

---

## 5. Cross-finding defense conclusions

### 5.1 Generic revalidation is necessary but not sufficient

The accepted contract is strong where a prior commit clearly falsifies a later action precondition, but revalidation alone does not choose the order in which independently accepted operations are presented for commit.

- In C-F02, the first residence move does not clearly falsify the second move's accepted preconditions.
- In H-002, either ordering produces locally valid revalidation behavior but different authoritative outcomes.
- C-F01 occurs after source-event commit in automatic reaction closure, so proposal precommit revalidation is not the relevant closure mechanism.

### 5.2 Stable-ID fallback cannot be silently broadened

The accepted fallback is explicitly technical and quarantined:

- equal-priority unresolved symmetry in the specification/assumption register;
- otherwise semantically equal alternatives competing for one indivisible outcome in VS-SFL-081;
- stable-ID sensitivity only in explicit fallback cases under IMP-0001.

Using stable IDs to order arbitrary automatic causes, define same-person Residence conflict classes, or decide causally asymmetric authority destruction would exceed current authority.

### 5.3 Deterministic implementation is not enough when the chosen order changes semantic state

A fixed local queue or insertion order would make one implementation repeatable, but ADR-0004 and the cross-cutting contract explicitly reject nonsemantic iteration order as authority. The question is not merely "can the engine be deterministic?" but "does accepted authority select the same authoritative result across conforming implementations?"

For C-F01 and C-F02, it currently does not.

### 5.4 Wave-A severity labels were not adopted

The dispositions above were derived from the frozen Wave-B baseline and current IMP-0001 scope, not from Wave-A's blocker/high labels.

In particular, H-002's Wave-A pre-code severity does not survive Slice-1 scope analysis: it is a later-slice gap.

---

## 6. Final defense disposition

- **C-F01:** `CONFIRMED_REPAIR_BEFORE_SLICE1` — accepted authority does not uniquely define bounded same-field reaction composition; the ambiguity directly enters IMP-0001.
- **C-F02:** `CONFIRMED_REPAIR_BEFORE_SLICE1` — accepted authority does not uniquely define multiple same-cycle Residence writes for one person; the ambiguity directly enters IMP-0001.
- **H-002:** `CONFIRMED_LATER_SLICE_GAP` — the authority-destruction race is not closed by current semantics, but every required household mechanism is explicitly outside IMP-0001.

No solution rule is proposed or selected here. The report stops at adjudication and the smallest remaining semantic choices, as required by the Wave-B defense packet.
