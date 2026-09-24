# TRES-0011B — Household Resource Scaffold Reversibility / Blast-Radius Audit

**Status:** COMPLETE  
**Task:** TRES-0011B  
**Base:** `tres-0011-v0-resource-scaffold-wave-v1` @ `76660eaea3be5a6a4612cfd431f9f73fe69a0f0a`  
**Authority:** advisory research only; no production-code or accepted-semantics change  
**Date:** 2026-09-24

## Verdict

**REPLACEABLE WITH PREPARATORY GUARDRAILS**

The present Slice-3 resource scaffold is still replaceable without changing Household identity, role architecture, or the reference simulation kernel. The implemented commitment/capacity mechanism is small and localized: authoritative commitment records live in the Household partition; exposed capacity is recomputed directly from current personal state; participation end/dissolution terminate commitment records; there is no Household spending path, no contributor allocator, no private-`X` implementation, and no pooled-balance implementation.

The danger is **near-term**, not already-completed lock-in. Accepted Slice-4 semantics and the blocked historical Slice-4 v1 verification package name a much wider set of exact resource mechanics: personal ownership, reserve 2 / `NeedsGrain`, persistent commitments, fixed-rank allocation, no treasury, provision priority, and now DEC-0011's transaction-specific private contribution `X`. If those rules are independently reimplemented in candidate generation, feasibility, dependency discovery, resolver ordering, commit mutation, and history reconstruction, a later economic redesign would require coordinated edits across all of those surfaces.

No speculative economy framework is justified now. The smallest useful guardrails are to keep resource sourcing transaction-local, preserve explicit typed funding provenance, make dependency/resolution consume that same declared material participation rather than rediscover the algorithm, and keep standing capacity derived/rebuildable. A generic asset/ledger/claims architecture should wait for the actual economic redesign.

---

## 1. Audit basis and authority boundary

Required sources reviewed:

- `governance/ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md`
- `architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md`
- `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md`
- `proposals/SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md`
- canonical Slice-3 implementation and acceptance tests on the stated base
- `plans/verification/SFL_V0/SLICE3_ACCEPTANCE_MANIFEST.md`
- historical/frozen `plans/verification/SFL_V0/SLICE4_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE4_BLOCKED_IMPLEMENTATION_BOUNDARY_RECORD.md`
- `research/technical/SFL_V0_SLICE4_IMPLEMENTATION_SURFACE_MAP.md`
- `research/technical/SFL_V0_SLICE4_VERIFICATION_TRIGGER_MAP.md`
- `research/technical/SFL_V0_SLICE4_PREIMPLEMENTATION_RECONCILIATION.md`

The frozen Slice-4 v1 manifest is treated as **historical blocked evidence**, not as sufficient current implementation authority. The block record explicitly states that v1 did not represent transaction-specific current-head private supplementation and requires a separately reviewed successor acceptance version. DEC-0011 and the current SPEC therefore matter more for the new `X` semantics than the old v1 rows do.

The governing architecture is deliberately favorable to replacement:

- ADR-0001 makes independently meaningful arrangements explicit typed records but leaves exact schema open.
- ADR-0003 requires derived values behind stable semantic/query boundaries and permits their maintenance strategy to change.
- ADR-0004 fixes validation/resolution/commit, stable-cycle publication, current-state authority, semantic history, and rebuildable derived state, but does not fix a Household finance model.
- Architecture Development Policy requires simple sufficient mechanisms and rejects speculative machinery absent a demonstrated dead end.

That means the audit should distinguish a **v0 semantic choice** from an **architecture dependency**. Much of the current resource scaffold is the former.

---

## 2. Current dependency map

### 2.1 Summary map

| Assumption | Current implementation coupling | Verification / planned coupling | Coupling class | Replacement pressure |
|---|---|---|---|---|
| Grain is personally owned | `Person.Grain` is authoritative; ordinary material effects mutate persons. Household commitment points to a person and does not own stock. | SPEC §2.2/§8.1; S3-070/073; S4-060/090; DEC-0011 dual private/role authority. | Domain-semantic + implementation representation | **Medium.** Local today; broader once Household spend exists. |
| Reserve = 2 and `NeedsGrain` gates exposure | `HouseholdSnapshot.ExposedCapacity` is exactly `NeedsGrain ? 0 : max(0, Grain-2)`; ordinary debt repayment also embeds reserve 2. | S3-071/072; S4-081/160; DEC-0011 reuses same disposable boundary. | Domain-semantic + implementation + fixture/test | **Medium.** Exact formula is localized but duplicated conceptually outside Household. |
| Provision commitments expose personal grain | `HouseholdProvisionCommitment(Person, Household, Association,...)` plus capacity query over current personal state. | S3-070/074; S4-070–086; SPEC §8.1. | Domain-semantic + implementation representation | **Medium.** Record can be replaced, but later spend would spread its meaning. |
| Household has no pooled treasury | No Household grain field; no Household material account; current tests reflectively assert no Grain/Treasury property. | S3-073; historical S4-090; SPEC/DEC-0011 explicit no-balance rule. | Domain-semantic + verification-only structural negative | **Low in production now; high semantic rewrite later** if pooling is adopted. |
| Mobilizable capacity is derived from commitments | `MobilizableCapacity` recomputes from live commitments, associations, `Person.Grain`, and `NeedsGrain`; no authoritative cache exists. | S3-074/089; S4-146/147 and R07 preserve cache nonauthority. | Derived/query assumption | **Low and desirable.** This is an architectural seam, not lock-in. |
| Fixed-rank allocation | **Not implemented in Slice 3.** No Household expenditure allocator exists. | SPEC §8.1; historical S4-082–086 and implementation-surface planning prescribe rank-once/exhaust-in-order. | Domain-semantic + planned verification | **High future-coupling risk, zero current execution lock-in.** |
| Commitment termination on participation end/dissolution | `TerminateCommitments` runs on participation end and dissolution. | S3-075/076; S4-087/088 regression requirements. | Domain-semantic + implementation + test | **Medium.** Appropriate for participation-backed promises; may not fit already-transferred joint property. |
| Material priority | No Household material action exists yet, so current resolver has no executable Household provision priority. | SPEC §9.2 and historical S4-089; D1 proposes relation to `RepayDebt`. | Domain-semantic + planned resolver coupling | **High cross-interaction risk if encoded generically.** |
| Transaction-specific private `X` | **Not implemented on the base.** Current proposal/action/history shapes have no such term. | DEC-0011 and current SPEC are accepted authority; frozen S4 v1 is insufficient/blocked. | Domain-semantic + planned implementation/verification | **Opportunity point.** Implementing this cleanly can establish the durable seam. |
| Provenance distinguishes funding legs | Current `SemanticEvent.Material` records person before/after/meaning, but has no typed funding-leg model. Same-person private + commitment debit cannot be reconstructed safely from one aggregate delta alone. | DEC-0011 requires separate private and commitment-backed provenance; historical S4-085 requires exact debit vector/backing. | Stable history requirement + missing implementation representation | **Guardrail required before Slice-4 material commit.** |

### 2.2 Canonical Slice-3 implementation: actual coupling is narrow

The present implementation is concentrated in a few places.

#### Authoritative state and queries

`src/Mesopotamia.Sim/HouseholdState.cs`:

- `HouseholdProvisionCommitment` is a standalone typed record with `Person`, `Household`, backing `Association`, fixture provenance, and optional termination cause.
- `ExposedCapacity(Person)` directly implements the v0 rule: zero for `NeedsGrain` or grain <= 2, otherwise grain - 2.
- `MobilizableCapacity(H, world)` iterates live commitments, verifies the backing sustaining association is still live and coherent, and sums current exposed capacities.
- no separate mobilizable-capacity state or cache exists.
- no Household resource balance exists.

This is exactly the kind of replaceable direct-reference implementation ADR-0003 expects early in a subsystem.

#### Lifecycle coupling

`src/Mesopotamia.Sim/HouseholdExecution.cs`:

- ending sustaining participation calls `TerminateCommitments(h, person, cause)`;
- dissolution calls `TerminateCommitments(h, null, cause)`;
- `SupplyProvisionFixture` is a deliberately controlled test ingress and creates the commitment without grain movement.

These are real semantic couplings, but they are still local to the Household partition. No generic `WorldState` transition or scheduler assumes that Household identity depends on them.

#### Current verification coupling

`tests/Mesopotamia.Sim.AcceptanceTests/HouseholdEpistemicScenarios.cs` has one consolidated provision case that:

- pins reserve arithmetic at grain 1/2/3/8;
- pins `NeedsGrain => 0`;
- supplies fixture-provenance commitments;
- checks capacity as the sum of `max(0, grain-2)`;
- checks exit/dissolution termination;
- checks no Household material event and no Household Grain/Treasury property.

`HouseholdOracle.cs` also assumes:

- Slice-3 Household/Sustaining events are non-material;
- every commitment has fixture provenance;
- ended associations imply commitment termination;
- dissolved H has no live commitments.

`HouseholdStructuralScenarios.cs` freezes the private field inventory of `HouseholdState`, including the commitment dictionary. This is brittle **verification representation coupling**, not domain architecture. Both the frozen manifest and Slice-4 preimplementation work explicitly permit a separately reviewed lossless adaptation rather than treating the exact field list as future semantic authority.

#### Derived/projection coupling

`HouseholdProjection.cs` includes commitments when normalizing detached Household projections. Changing commitment representation will therefore alter detached-projection serialization/comparison. That is a derived/replay surface, not independent authority.

The frozen Slice-3 manifest makes this distinction explicit: provision capacity must be independently rebuildable, and stale/hidden derived state may not become behavioral authority.

### 2.3 What is *not* implemented yet

The following important resource assumptions are not currently embedded in execution code on this base:

- Household material support spend;
- mediated-marriage dowry funded by Household backing;
- fixed-rank contributor selection/debit;
- provision-vs-personal material priority;
- `RepayDebt` placement under that priority;
- endogenous commitment solicitation/acquisition;
- transaction-specific private `X`;
- same-person `X` plus commitment residual handling;
- typed source-by-source Household funding provenance.

This matters for reversibility: most of the feared blast radius is still a **planning choice**, not sunk implementation.

---

## 3. Where Slice 4 would create future lock-in if implemented naively

The historical Slice-4 v1 acceptance package already spreads resource assertions over:

- role scope and authority;
- dual personal/Household initiative;
- shared-resource conflicts;
- endogenous provision acquisition;
- support spend;
- reserve/need boundaries;
- rank-once allocation;
- exact debit history;
- live capacity revalidation;
- participation/dissolution termination;
- material priority;
- no treasury;
- mediated-marriage dowry;
- same-cycle authority races;
- derived-cache nonauthority;
- material invariants.

The implementation-surface map correspondingly identifies pressure on decision contexts, response contexts, dependency discovery, central resolution, material commit, history, projection, and acceptance oracles.

DEC-0011 adds a further cross-cutting requirement: a Household material attempt may carry an exact private term `X`, with residual `R=C-X` funded from commitments, while preserving separate role authority, private-owner consent, no double counting, live precommit revalidation, and distinct funding-leg provenance.

The risky implementation pattern would be to encode those equations independently in several layers:

1. candidate generation computes whether a funding plan seems possible;
2. response scoring separately reconstructs `X` feasibility;
3. dependency discovery separately finds possible contributors;
4. resolver priority separately knows commitment ranks and private stock;
5. commit code separately recalculates ranks/debits;
6. history infers source legs from the final personal grain deltas.

That would make the exact v0 algorithm the de facto inter-layer protocol.

The safer and smaller pattern is to make the **transaction's live funding result** the shared handoff at precommit/commit, so downstream mutation and history consume one validated source-of-truth result instead of duplicating the funding algorithm.

---

## 4. Hypothetical replacement exercise

This exercise intentionally does not select or design a future economy.

### 4.1 Family 1 — Household-owned pooled store

Assume Household H can own a persistent stock distinct from personal stocks.

What breaks:

- `HouseholdProvisionCommitment` can no longer be assumed to be the sole standing source of Household material capability.
- `MobilizableCapacity = sum(live personal exposed capacity)` no longer describes total Household capability.
- “no Household treasury” reverses.
- fixed-rank direct personal debit on every expenditure may disappear or become contribution/deposit logic instead.
- participation-end/dissolution semantics require a new decision: already transferred pooled property is not automatically equivalent to an unspent personal promise.
- private `X` can remain a separate current-holder contribution, but the residual need may be a Household-balance debit rather than commitment allocation.
- current `MaterialChange(PersonId,...)` cannot directly represent a Household-owned stock without changing/generalizing material history representation.
- tests that structurally prohibit Household grain and require direct contributor debit vectors must be replaced.

What survives unchanged in principle:

- H identity and sustaining participation;
- head role / authority distinction;
- explicit private-owner consent when private property is contributed;
- read/deliberate/resolve/commit lifecycle;
- live precommit validation;
- atomic commit;
- provenance-bearing semantic history;
- derived/cache nonauthority.

**Change class:** new semantic decisions + new verification + local resource-state/spend rewrite + resolver/history adaptation. **No Household identity/role rewrite and no ADR-0004 kernel redesign are inherently required.**

### 4.2 Family 2 — Mixed personal + jointly controlled assets/claims

Assume some value remains personal while some assets/claims are jointly controlled or Household-associated.

What breaks:

- one scalar `MobilizableCapacity` from personal commitments becomes incomplete or may need to become one query among several;
- `HouseholdProvisionCommitment` remains potentially useful but cannot stand for all material authority;
- fixed-rank ordering over personal contributors cannot decide use of jointly controlled resources;
- no-treasury invariant no longer holds in its current literal form;
- termination semantics become source-specific: ending participation may terminate a revocable personal commitment without extinguishing already-existing joint claims;
- `X` remains meaningful only as one personal funding leg;
- dependency discovery must include whatever entities control joint assets/claims, not only contributors' PersonIds.

What survives:

- the strongest currently proposed seam: explicit transaction source/authority legs with provenance;
- separation of office authority from property/control authority;
- atomic precommit and commit;
- history that records source, authority, amount/effect, and causal basis;
- rebuildable derived queries.

**Change class:** new semantic decisions + new verification + local subsystem rewrite + resolver/history extension. **Role/Household identity remains stable; kernel redesign is not implied.**

### 4.3 Family 3 — No stock pool; authorization against obligations/contributions/production flows

Assume Household action does not “spend a store” at all. It authorizes obligations, promised contributions, claims, or production flows which may settle later.

What breaks:

- standing `MobilizableCapacity` as a stock sum may cease to be a meaningful authorization test;
- reserve-2 arithmetic may no longer determine institutional action capacity directly;
- fixed-rank contributor exhaustion may disappear;
- “funding” may create future-influencing process/claim state rather than immediate grain debits;
- participation-end/dissolution rules need explicit treatment of outstanding obligations;
- history must distinguish authorization from later settlement;
- resolver dependencies may be over claims/processes rather than shared current Person.Grain.

What survives:

- action authority and private consent remain separate capacities;
- precommit can validate live authority to create the obligation/authorization;
- that authorization commit can still be atomic;
- later settlement can be represented as separate semantic transitions;
- current-state authority + semantic history + deterministic scheduling remain appropriate architectural principles.

ADR-0004 already anticipates serializable delayed/interruptible process state. The current implementation would need new process/resource code, but the accepted kernel does not need to be abandoned merely because settlement ceases to be an immediate stock debit.

**Change class:** new semantic decisions + new verification + substantial local resource/process subsystem rewrite + resolver/history rewrite. **Still no inherent Household identity/role rewrite or cross-cutting kernel redesign.**

---

## 5. Future redesign blast radius

| Surface | Pooled store | Mixed personal + joint | Obligation / flow authorization |
|---|---|---|---|
| SPEC resource semantics | Rewrite | Rewrite/extend | Rewrite |
| `Person.Grain` as sole Household funding substrate | Remove as sole substrate | Retain as one substrate | Potentially decouple from authorization |
| `HouseholdProvisionCommitment` | Replace or repurpose | Retain as one source type | Replace/repurpose as claim/obligation |
| `ExposedCapacity` reserve-2 rule | No longer global Household capacity rule | Applies only to personal leg if retained | May cease to be authorization basis |
| `MobilizableCapacity` query | Redefine/remove | Generalize or split | Redefine/remove |
| Exit/dissolution termination | Re-decide for pooled property | Source-specific | Re-decide outstanding obligations |
| Fixed-rank allocator | Remove/move to deposit side | One source policy at most | Remove |
| Material priority | Re-decide conflict classes | Re-decide | Re-decide around claims/flows |
| Private `X` | Can remain optional contribution leg | Can remain one personal leg | May become explicit personal authorization/contribution promise |
| Funding provenance/history | **Preserve concept; change leg kinds** | **Preserve concept; broaden leg kinds** | **Preserve concept; distinguish authorization/settlement** |
| Resolver dependency discovery | Adapt | Adapt | Rewrite locally around claims/processes |
| Household identity/continuity | Stable | Stable | Stable |
| Head role / dual-capacity agency | Stable | Stable | Stable |
| ADR-0004 resolve/commit/history kernel | Stable | Stable | Stable; may use delayed-process support |

The common result is important: even the deliberately hostile third family does not force Household identity or office architecture to be redefined. The blast radius is concentrated in the material-resource subsystem, its resolver dependencies, and its verification/history payloads.

---

## 6. Stable seam test

### 6.1 Genuinely present today

The following durable abstractions are already real rather than aspirational:

1. **Typed authoritative semantic state.** Household identity, associations, commitments, and personal resource state are explicit records, not hidden caches.
2. **Decision snapshot → validation/response → central resolution → commit.** The execution kernel already revalidates against current committed state before mutation.
3. **Atomic mutation pattern.** Ordinary material actions evaluate against a copied `WorldState`, validate the resulting transaction, and only then publish the new state.
4. **Current state is authoritative; history is consequential evidence.** `SemanticEvent` records causes, participants, material changes, configuration/rules and fallback markers.
5. **Derived state is rebuildable/non-authoritative.** Current Household capacity is recomputed, not stored as an independent balance.
6. **Household identity and role/lifecycle semantics are not resource-derived.** Capacity does not define Household identity or continuity.

Those are the durable architecture seams a future economy can reuse.

### 6.2 Not genuinely present yet

The following proposed seams are **not yet implementation facts**:

- “Household material action produces one explicit funding plan/result.”
- “funding legs are typed by source/owner/authority/backing.”
- “dependency discovery consumes the exact possible/live funding participants from the same source as precommit.”
- “history stores private-`X` and commitment-backed legs distinctly even when the same person supplies both.”

Current `SemanticEvent.Material` is person-delta oriented. It can represent the final grain change, but DEC-0011 explicitly says the final personal delta may aggregate while provenance must still distinguish private and commitment-backed legs. Therefore the material delta vector alone is not a sufficient future-facing seam.

### 6.3 Stable semantic interface to preserve

The narrow durable interface supported by accepted authority is:

> A Household material action reaches precommit with explicit action authority and an explicit proposed resource-source plan; precommit validates the live authorities/capacities needed for that exact plan, produces a deterministic validated funding/effect result, and commit applies the whole effect atomically while history records source/provenance and effects.

This statement does **not** require commitments, reserve 2, fixed-rank allocation, personal-only stock, or even a stock pool. Those are replaceable policy below/inside the resource-source resolution step.

The current kernel already supplies the outside of this seam. Slice 4 must avoid making the exact v0 allocator the inter-layer API.

---

## 7. Premature-generalization test

A broad abstraction layer now would be speculative and should not be added.

### Do **not** add now

- a generic asset hierarchy;
- a generalized institutional treasury framework;
- arbitrary ownership/control-rights polymorphism;
- a universal claims/obligation ledger;
- generic split-tender infrastructure for unrelated actions;
- a pluggable “economy provider” interface;
- generalized settlement/process machinery solely to anticipate a possible future model.

None is required to implement the accepted v0 semantics, and the future research may choose a model that makes the guessed abstraction wrong.

### Small preparatory guardrails justified now

#### G1 — One authoritative live funding-resolution point per Household material action

The exact v0 rules (private `X`, residual `R`, live commitment validity, residual same-person capacity, fixed-rank allocation, sufficiency) should be computed in one place at precommit/transaction evaluation and returned as one deterministic validated result.

Candidate generation/response may perform feasibility checks for deliberation, but commit/history/resolver must not each carry independent copies of the allocator semantics.

This is not speculative architecture; DEC-0011 already requires one exact transaction funding plan and no silent renegotiation.

#### G2 — Explicit typed funding provenance in semantic history

The successful action must retain enough structured information to distinguish at minimum:

- total action cost/effect;
- private current-holder contribution, if any;
- each commitment-backed contribution;
- person/source owner;
- backing commitment or other accepted source reference;
- authority/consent provenance;
- actual debit/effect;
- relevant causal/rule/configuration references.

Do not require an oracle to infer source legs from aggregate `MaterialChange` rows or a free-form `Detail` string.

This guardrail is already required by DEC-0011, so it introduces no speculative future mechanism.

#### G3 — Resolver/dependency discovery must consume declared material participation, not duplicate funding policy

The central resolver needs to know which live actors/claims/resources can conflict. That dependency surface should derive from the Household action's resource-resolution inputs/result (or a conservative declared possible-source set) rather than independently reimplementing fixed-rank/private-`X` allocation logic.

Otherwise any future resource change would require synchronized edits in both funding and dependency semantics.

#### G4 — Keep mobilizable capacity derived and non-authoritative

Do not add a standing Household balance-like cache merely for convenience. A cache may be introduced later if measured, but it must remain rebuildable behind a query boundary.

This directly follows ADR-0003 and existing frozen verification.

#### G5 — Keep resource mechanics out of Household identity and role identity

Do not make commitment presence, capacity, contributor rank, private `X`, or resource balance define:

- Household numerical identity;
- sustaining participation;
- head-role identity;
- role occupancy;
- recognition identity.

Resource capability may gate an action; it must not become organizational identity.

### What can wait until actual redesign

All genericization beyond G1–G5 can wait. In particular, there is no present evidence requiring a generic ownership model or a multi-resource ledger. When historical/economic research chooses a future family, migration can introduce the concrete state/process types required by that model while retaining the stable kernel and organizational identities.

---

## 8. D1–D6 blast-radius assessment

These are working inclinations in the proposal packet, not all accepted authority. The question here is whether each inclination couples future architecture to the current resource scaffold.

| Decision | Resource coupling judgment | Future blast radius |
|---|---|---|
| **D1 — Household provision priority vs RepayDebt** | **Increases v0 coupling.** It specifically orders two attempts competing for the same personal grain and therefore assumes the current stock/conflict shape. | Keep this as a bounded v0 material-conflict rule, not an intrinsic property of debt or a generic office precedence. A future pool/claims model should be free to replace it. |
| **D2 — snapshot-bound consent cohort** | **Resource-independent.** This is about multilateral role-transition consent and same-cycle membership changes. | Preserves general agency/authority principles; no resource redesign impact. |
| **D3 — head as Household-support recipient** | **Core alias principle is resource-independent; eligibility details are v0-specific.** One person may simultaneously be office-holder/authorizer and beneficiary. The statements that `NeedsGrain` blocks `X`/commitment exposure are current resource semantics. | Preserve distinct capacities and no fake self-request. Revisit only the material eligibility/funding predicates if the resource model changes. |
| **D4 — head creates/reconsiders own persistent commitment** | **Strongest commitment-model coupling among D1–D6.** It validates self-commitment as a specific v0 resource act. | Preserve the durable principle: office authority does not itself expose private property; personal consent is separately explicit. The future model may replace the commitment act entirely. |
| **D5 — self-nomination** | **Resource-independent.** It is role/consent topology. | No resource redesign impact. |
| **D6 — inert office while Household inactive** | **Resource-independent at its core.** Role occupancy persists while action capability is absent. | Strongly preserves separation of institutional identity/office from current action capability. Future resource mechanics can change without altering the role. |

### D1 specifically

If D1 is accepted, avoid placing “RepayDebt has lower priority than Household” inside generic `ActionRules` as an unconditional debt property. Its rationale is explicitly a current Household-material conflict over shared personal grain. Keeping it scoped to the v0 Household-material resolver prevents a future pooled or obligation-based model from inheriting an obsolete debt rule.

### D4 specifically

D4 should not motivate a generic self-transfer or self-response mechanism. The durable rule is only that a person can occupy two semantic capacities in one act and must explicitly consent in the private-property capacity. If future resource semantics have no persistent provision commitment, D4's exact action can disappear without touching role architecture.

### D3 specifically

D3 is mostly healthy separation pressure: role authority does not erase ordinary person eligibility, and beneficiary identity may alias the office-holder. That is useful beyond grain. Do not bake the current inference “recipient NeedsGrain => zero personal supplement/exposure” into generic role code; keep it in the current resource policy.

### D6 specifically

D6 actively helps reversibility. It says office identity/occupancy can persist while Household action capability is inert. That prevents resource capability from becoming the definition of office existence.

---

## 9. Concrete migration expectations if redesign happens later

With G1–G5 respected, a later redesign should normally require:

1. revise the accepted resource semantics;
2. replace or extend Household resource-state records/queries;
3. replace the v0 funding-resolution policy;
4. adapt resource-specific dependency declarations and conflict priorities;
5. adapt semantic funding/effect provenance payloads;
6. replace resource-specific acceptance rows while preserving historical frozen evidence;
7. preserve Household identity, sustaining participation, head-role identity, recognition, general decision snapshot, atomic commit, stable closure, and history/reproducibility contracts.

It should **not** require:

- renumbering/redefining Households;
- redefining sustaining participation merely because finance changes;
- rebuilding the head role as a different organization concept;
- replacing ADR-0004's reference kernel;
- making derived capacity independently authoritative;
- changing unrelated person-person semantics solely to fit the Household economy.

If a future implementation finds that replacing fixed-rank commitments requires changing Household identity or the entire simulation kernel, that would be evidence that Slice 4 crossed the seam this audit is trying to preserve.

---

## 10. Final judgment

The present code is still on the safe side of the line.

Slice 3 implemented the minimum resource scaffold: a participant-backed commitment record, a direct derived-capacity query, and lifecycle termination. It deliberately did **not** implement spending. The exact reserve formula and no-treasury rule are semantically pinned, but they are locally represented. Verification has some brittle structural assumptions, yet those are already recognized as losslessly adaptable later-slice evidence rather than future architecture.

The next implementation wave is where lock-in can be created. DEC-0011's private-`X` semantics make this especially visible because one person's final grain delta may contain two semantically distinct funding legs. That forces the project to represent transaction funding provenance explicitly instead of treating “who lost grain” as the funding model.

Therefore the recommended action is narrow:

- implement the accepted v0 resource rules without a speculative economic framework;
- establish one transaction-local live funding-resolution result;
- retain explicit typed funding-leg provenance;
- have resolver dependencies consume the same material-participation truth rather than duplicating allocation policy;
- keep standing capacity derived and resource mechanics outside Household/role identity.

Everything else can wait until the historical/economic research selects the future model.

Under those guardrails, all three deliberately different replacement families examined here remain a **resource-subsystem + verification/history migration**, not an organizational or kernel rewrite.
