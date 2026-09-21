# TRES-0010B-I-PROSECUTION — Implementation Assurance / Handoff Integrity

## Run provenance

- **Task ID / role:** TRES-0010B-I-PROSECUTION — prosecution / hostile implementer + future-slice adversary
- **Frozen canonical baseline:** `tres-0010-wave-b-baseline`
- **Resolved baseline SHA:** `f25407a9cbf09e501601d52ad7a2df111fa5c491`
- **Assigned return branch/workspace:** `tres-0010/wb-i-prosecution`
- **Return branch starting state:** identical to the frozen Wave-B baseline before this report
- **Model/configuration:** GPT-5.6 Sol; exact hidden reasoning-effort configuration is not exposed
- **Tools used:** GitHub repository connector for branch/ref verification, frozen-baseline retrieval, assigned Wave-A return retrieval, comparisons, and isolated return write
- **External research:** no
- **Assigned Wave-A reports read:** TRES-0010D, E, F, G, I, J only, from the packet-authorized branches `tres-0010/d,e,f,g,i,j`
- **Opposing Wave-B return read before completion:** **no**
- **Unrelated Wave-A returns read:** **no**
- **Proposed Master Architect fixes / future Wave-B design outputs read:** **no**
- **Canonical project files modified:** no; this advisory return is the only intended write

## 1. Executive disposition

The prosecution does **not** confirm a new social-semantic or architectural blocker.

It does confirm four de-duplicated **pre-dispatch repair clusters**:

1. **Protected acceptance / oracle independence** — IMP-0001 currently creates its own first executable acceptance surface, so a weak translation of the canonical cards or a circular oracle can self-certify. This is a verification-governance repair, not a semantic redesign.
2. **Exact Slice-1 applicability manifest** — the packet simultaneously requires `VS-SFL-100..105` and excludes the household/head semantics required by `VS-SFL-104`; more generally, “applicable/relevant/where substrate is available” leaves the implementation agent too much discretion over which adversarial checks count.
3. **Authority/supporting-context taxonomy** — IMP-0001 places the assumptions register inside “Accepted simulation / architecture authority” and uses the parent heading “Authoritative inputs” for required working engineering context, despite the governance policy's explicit authority/supporting-context distinction.
4. **No fourth semantic repair:** the remaining serious-looking seams are implementation-local guards or already resolved by accepted authority. In particular, future multi-contributor generalization must **not** be pre-built as a speculative framework.

The challenged set contains 27 formal Wave-A findings/hazards. Adjudication:

- **7** finding rows -> `CONFIRMED_REPAIR_BEFORE_SLICE1`, collapsing to the three repair clusters above;
- **8** -> `IMPLEMENTATION_LOCAL_GUARD`;
- **10** -> `ALREADY_RESOLVED_BY_AUTHORITY`;
- **2** -> `FALSE_POSITIVE`;
- **0** -> `CONFIRMED_BLOCKER_SLICE1`;
- **0** -> `CONFIRMED_LATER_SLICE_GAP`;
- **0** -> `INCONCLUSIVE_NEEDS_EXPERIMENT`.

**Pre-code consequence:** IMP-0001 should not be released unchanged. The required changes are bounded verification/task/navigation repairs plus ordinary implementation guards. No accepted social rule needs to be invented or changed.

## 2. Prioritized exploit / defect list

### P0-1 — First-code acceptance can still be self-authored and oracle-circular

**Wave-A findings challenged:** D-001, D-002  
**Result:** `CONFIRMED_REPAIR_BEFORE_SLICE1`  
**Remedy category:** protected verification infrastructure  
**Confidence:** high

#### Independently verified accepted evidence

- `IMP-0001 §3.1` assigns the implementation task itself to create unit/mechanism tests, canonical SFL acceptance tests, and the deterministic harness.
- `IMP-0001 §6` requires a protected acceptance surface, but its fallback permits repository instructions, task scope, test separation, and CI.
- `SCF-002` is still only **ARMED** and fires on IMP-0001 dispatch; no protected executable evaluator or frozen machine-checkable assertion manifest exists on the Wave-B baseline.
- `CROSS_CUTTING_VERIFICATION_CONTRACT §9` explicitly forbids independent oracles from calling production candidate recognizers, scorers/selectors, transition helpers whose output is under test, and comparable semantic helpers.
- `AGENTS.md` forbids weakening acceptance tests, but no executable acceptance tests exist yet.

#### Smallest cheating implementation

1. Create a test method for every required scenario ID.
2. For a card such as `VS-SFL-093`, assert only one visible endpoint and omit one or more required boundary/negative-control assertions.
3. Implement the corresponding semantic defect.
4. For generated/independent checks, share the faulty production semantic helper with the supposed oracle.
5. Run the task-authored suite and CI; everything is green because the same task under-translated the prose authority and/or circularly computed expected values.

The cheat does not need to edit or weaken an already-protected test. It exploits the fact that the first executable judge is created by the candidate task.

#### Serious disconfirmation attempted

The strongest defense is already in accepted authority: protected acceptance is required, weakening is forbidden, SCF-002 is armed, and oracle independence is explicit. That closes the *rule*, but not the first-code assurance mechanism. A candidate can still author a superficially compliant but incomplete executable translation before any protected surface exists.

#### Exact pre-code consequence

Before IMP-0001 can earn acceptance, SCF-002 must be concretized so that the implementation candidate is not the sole author/editor of the completion authority. The smallest acceptable form may be a frozen/protected assertion manifest, separately controlled evaluator, or equivalently independent check that verifies the required assertions and oracle-independence boundary. This is not a request for a large hidden-eval platform.

D-002 does **not** require a second subsystem beyond this repair: the protected surface must make the already-accepted independent-oracle rule auditable rather than letting the candidate's test helper graph silently violate it.

---

### P0-2 — Slice-1 verification scope is not closed enough to prevent both under-testing and forced household scope creep

**Wave-A findings challenged:** D-005, E-F01, E-F06, I-F01  
**Result:** `CONFIRMED_REPAIR_BEFORE_SLICE1`  
**Remedy category:** exact task-packet applicability manifest  
**Confidence:** high

#### Independently verified accepted evidence

- `IMP-0001 §4` explicitly excludes Household identity, head recognition/role, household-mode action, household-mediated marriage, and broader subjective communication.
- `IMP-0001 §6` nevertheless requires executable coverage for `VS-SFL-100 through VS-SFL-105` “at minimum.”
- `RESPONSE_DECISION_FAMILY.md / VS-SFL-104` requires an **Active H**, a valid current head P, household-mediated marriage, and role-scoped authority using `SCORE-RP-005`.
- The same IMP section later says cards that explicitly require household semantics remain unimplemented and must not be faked.
- `LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md / VS-SFL-098` includes Communication in its initiative-accounting examples even though general communication is deferred by IMP-0001.
- IMP-0001 repeatedly uses open selectors such as “relevant,” “applicable,” and “where their required substrate is available.”
- `CROSS_CUTTING_VERIFICATION_CONTRACT §4` spans all SFL slices and explicitly allows `unexercised` mutant classification, but there is no Slice-1 map that says which checks must execute versus be deferred.

#### Smallest forced-scope trace

A literal implementation agent reaches `VS-SFL-104` under the mandatory `100..105` range. It must choose among:

- implement Household/head/mediated-marriage semantics early;
- fixture/stub those results;
- omit the card despite the literal minimum.

All three conflict with some part of the packet.

#### Smallest under-testing cheat

A hostile implementer runs the named canonical lower-level cards plus one easy permutation and one easy fallback check, labels harder locality/metamorphic/mutant checks “not applicable,” and reports “no surviving relevant mutant.” The packet has no enumerated Slice-1 applicability set against which to reject that claim.

#### Serious disconfirmation attempted

The later sentence “household cards remain unimplemented” clearly reveals intended scope, and the mutant contract's `unexercised` state clearly prevents a requirement to execute every future-slice mutant. Those clauses narrow the intended answer, but they do not remove the contradictory `100..105` minimum or close the hostile self-selection of “applicable.”

#### Exact pre-code consequence

IMP-0001 needs a closed Slice-1 acceptance/applicability manifest at card/subcase level, with at least:

- required versus deferred canonical scenarios/subcases;
- `VS-SFL-104` / role-scoped `SCORE-RP-005` explicitly deferred;
- the Communication-specific part of `VS-SFL-098` explicitly deferred while preserving the in-scope initiative-accounting claim;
- relevant boundary/metamorphic checks enumerated;
- each cross-cutting mutant classified for Slice 1 as required, N/A, or `unexercised` with reason;
- evidence expected for each required item.

This single repair closes D-005/E-F06 while also preventing the overbuild concern in I-F02.

---

### P0-3 — IMP-0001's input taxonomy can misclassify supporting context as accepted authority

**Wave-A finding challenged:** J-F01  
**Result:** `CONFIRMED_REPAIR_BEFORE_SLICE1`  
**Remedy category:** navigation/authority wording  
**Confidence:** high

#### Independently verified accepted evidence

- `governance/AUTHORITY_AND_DECISION_PROMOTION.md` explicitly distinguishes **authority**, **active operational context**, and **required supporting context**.
- The same policy lists assumptions/register entries and engineering guardrails as required supporting context rather than accepted architecture/specification authority.
- `registers/ASSUMPTIONS_REGISTER.md` says assumptions are temporary, scoped, replaceable, and do not become broader project truth merely by being active.
- `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md` self-identifies as an **ACTIVE ENGINEERING CONTEXT NOTE**.
- IMP-0001 puts `ASSUMPTIONS_REGISTER.md` under “Accepted simulation / architecture authority” and places the working C# guardrail beneath the parent heading “Authoritative inputs.”

#### Smallest failure trace

A future active assumption or engineering note conflicts with an accepted specification/ADR. An implementation agent following only the bounded packet treats both as co-equal “authoritative inputs,” instead of letting accepted authority control and escalating the supporting-context conflict.

No current semantic conflict was found. The defect is precedence taxonomy.

#### Exact pre-code consequence

Separate the packet's required inputs into:

- accepted authority; and
- required non-authoritative supporting/operational context,

with one precedence sentence stating that accepted Seed/constitutional/decision/ADR/spec authority controls and supporting context constrains the task only within that authority.

---

### P1-1 — Subjective actor state must not collapse into globally visible history/objective world access

**Wave-A findings challenged:** E-F04, F-F01  
**Result:** `IMPLEMENTATION_LOCAL_GUARD`  
**Remedy category:** implementation guardrail  
**Confidence:** high

#### Independently verified accepted evidence

- `SPEC-SFL-0001 §6.1` defines `KnownFact` as a proposition held by an actor with provenance.
- `§6.4` says actors automatically know their own state, direct-party relations/claims, and proposals/events in which they directly participate; other facts require valid observation/communication.
- `§6.7` requires direct participants to learn `Declined`, `Unable(reason)`, and `InvalidatedAtResolution(reason)` without leaking unrelated private state.
- `VS-SFL-070/071/073` make those distinctions observable in Slice 1.
- `SPEC §5.1` requires response decisions to read the target's subjective state from the common committed snapshot.
- ADR-0004 keeps state/query and agency logically separate.
- IMP-0001 §4 defers **general** subjective communication/claim propagation “beyond lower-level state needed for this slice,” leaving the in-scope direct-participant subset required.

#### Smallest bad implementation

Store failure outcomes only in one global history and let behavioral code query the authoritative world/history without actor scope. Tests that merely inspect global history can pass while every actor effectively has omniscient access.

#### Disconfirmation / downgrade

Wave A overstates the need for a dedicated persisted `KnownFact` store. Accepted authority fixes the *semantics*, not the storage representation. Under ADR-0003, the direct-participant `KnownFact` view may be derived from provenance-bearing semantic history behind an actor-scoped query boundary.

Therefore this is not a missing semantic rule and does not require a new substrate decision before dispatch.

#### Guard

Behavioral decision code must receive actor/context-scoped subjective inputs from the committed snapshot and must not infer universal knowledge from resolver/global-history visibility. A dedicated general recognition/communication framework is not required in Slice 1.

---

### P1-2 — C# phase snapshots can be semantically live through aliasing/deferred enumeration

**Wave-A finding challenged:** G-F01  
**Result:** `IMPLEMENTATION_LOCAL_GUARD`  
**Remedy category:** implementation guardrail  
**Confidence:** high on project consequence; platform mechanism inherited from assigned G report and not re-researched externally in this Wave-B run

#### Independently verified accepted evidence

- ADR-0004 requires one committed read/deliberation snapshot and later authoritative resolution/commit.
- `SPEC §5.1` says response contexts read the same committed cycle snapshot and do not observe uncommitted effects.
- `SPEC §9.1` fixes the common-snapshot phase order.
- IMP-0001 §3.6 repeats “read committed snapshot” before proposals/responses/resolution.
- The active C# guardrails already warn against shared mutable objects and unnecessary LINQ but do not state the phase-stability condition concretely.

#### Smallest failure trace

A decision context retains a mutable collection reference or a deferred query over authoritative state. After legal later-phase mutation, enumerating that “snapshot” observes the changed state, violating common-snapshot semantics without any threads or explicit behavioral mutation.

#### Guard

Snapshot-facing data used by personal/response deliberation and decision traces must be phase-stable. Mutable authoritative backing collections or deferred enumeration must not cross a semantic phase boundary in a way that changes what an already-created context observes. Add a focused common-snapshot regression test; exact C# representation remains local.

---

### P1-3 — Decision-context/source identity should not be silently equated with PersonId

**Wave-A finding challenged:** F-F02  
**Result:** `IMPLEMENTATION_LOCAL_GUARD`  
**Remedy category:** implementation guardrail  
**Confidence:** medium-high

Accepted semantics already distinguish:

- one personal context per person;
- multiple `ResponseDecisionContext(target, proposal)` activations;
- later `HouseholdDecisionContext(H, head=P)` separate from P's personal initiative;
- history with proposer/target/role context.

A PersonId-keyed internal personal-plan map is not itself invalid and may be the simplest Slice-1 implementation. The risk appears only if PersonId is elevated into the universal semantic identity of every decision/proposal source.

**Guard:** keep semantic decision context/origin distinguishable in proposal/trace data where required by current cards, and do not make a local PersonId-keyed collection into a public architectural invariant. Do **not** implement household decision contexts early.

---

### P1-4 — Tooling strictness is local; protected-acceptance minimum is not

**Wave-A finding challenged:** E-F07  
**Result:** `IMPLEMENTATION_LOCAL_GUARD`  
**Remedy category:** implementation guardrail, with protected-verification portion subsumed by P0-1  
**Confidence:** high

IMP-0001 §8 intentionally leaves exact analyzer package/configuration and CI syntax local. The phrase “strict enough” is not a social/architectural ambiguity; the implementation must simply select and report a concrete baseline that passes the canonical command.

Likewise, the clause about stronger repository protection “if available without disproportionate administration” is intentionally conditional. The true assurance defect is P0-1: first-code acceptance needs a concrete minimum that the candidate cannot self-define away. Once that minimum is fixed, the strongest optional repository-administration mechanism remains an engineering choice.

---

### P1-5 — C# identity/equality/text/numeric traps are local guards, not new architecture

**Wave-A findings challenged:** G-F03, G-F05, G-F06  
**Result:** `IMPLEMENTATION_LOCAL_GUARD`  
**Remedy category:** implementation guardrail  
**Confidence:** medium-high

- **G-F03:** stable semantic identity is already authoritative, but generated record value equality or mutable hash keys can accidentally implement a different identity rule. Index entities/history by stable IDs; do not let incidental value equality erase distinct records.
- **G-F05:** if machine-defined strings participate in semantic identity/order, use an explicit deterministic comparison rather than ambient culture.
- **G-F06:** exact-integer scoring removes floating-point ambiguity but local numeric representation should fail explicitly rather than silently wrap if a configured sum exceeds its chosen range. Current pinned profiles do not make overflow a semantic blocker.

These belong in the implementation checklist/tests, not in social semantics or a new framework.

## 3. Findings disconfirmed or already closed by accepted authority

### D-003 — Profile/card overfit

**Result:** `FALSE_POSITIVE` as a separate pre-Slice1 gap  
**Confidence:** medium-high

The accepted profile contract already states:

- profiles are pinned verification/laboratory configuration, not permanent social semantics;
- target bindings may not inject candidates or bypass production generation/gates;
- configuration cannot waive categorical gates;
- `FinalScore` is the sum of named integer components;
- independent oracle arithmetic must not call the production scorer.

A requirement to clone identical component rules under arbitrary fresh ProfileIds would create a new generic profile-extensibility proof not required by IMP-0001, and I-F04 correctly observes that a general runtime configuration framework is not needed.

A hardcoded branch that bypasses generation/gates is simply noncompliant and should be caught by faithful protected translation under P0-1/P0-2. A scorer implemented with a finite switch over the **only pinned profiles in scope**, while still producing the exact required component semantics, is not by itself evidence of a Slice-1 semantic defect.

---

### D-004 — Visible “held-out” recipes are not secret independent tests

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

`CROSS_CUTTING_VERIFICATION_CONTRACT §5` says generated histories **supplement** canonical cards. Section 8 explicitly says held-out instances **may be materialized after the implementation path exists**. The project does not define “held-out” as secret from the implementer.

The full SFL verification program still requires canonical plus held-out/generated evidence, but secrecy or pre-code materialization is not an IMP-0001 acceptance requirement. Do not invent a hidden-eval platform as a Slice-1 prerequisite.

---

### F-F03 — Slice 1 must pre-generalize central transitions for future multi-contributor household writes

**Result:** `FALSE_POSITIVE` as a pre-code requirement  
**Confidence:** high

Accepted future household semantics do require atomic multi-contributor provision, but:

- IMP-0001 explicitly leaves internal proposal/transition structure as a local choice;
- ADR-0003 and the accepted Architecture Development Policy require the simplest sufficient implementation and reject machinery that has not earned its cost;
- household provision is explicitly out of Slice 1.

A pairwise internal Slice-1 effect representation is therefore not a defect merely because it will later be refactored. It becomes a problem only if the implementation elevates the pairwise shape into an accepted/public architectural boundary or bypasses the central validation/commit contract. No generic multi-party effect framework should be pre-built solely to avoid later local refactoring.

---

### F-F04 — Semantic history could be mere rendered diagnostics

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

The smallest claimed counterexample — unaddressable JSON/text diagnostics with no semantic records — conflicts with existing authority:

- IMP-0001 §3.2 requires explicit semantic transfer/action records;
- §3.7 requires IDs, causal predecessor references, committed effects, version, and other semantic history;
- required invariants include stable/resolvable live and historical references;
- `SPEC §9.4` requires consequential proposal/history records and later warrant references to supporting events;
- ADR-0004 distinguishes semantic history/provenance from current state and from incidental runtime details.

Exact storage/query API is local. A textual encoding may be a representation, but if records/references are not semantically addressable/resolvable it already violates the accepted contract.

---

### I-F02 — The full 30-mutant ledger forces all later-slice semantics into Slice 1

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

The cross-cutting contract explicitly permits `unexercised`; IMP-0001 requires only applicable/relevant mutants. P0-2 should make those classifications explicit so the same wording cannot be abused in the opposite direction, but authority already rejects “execute all 30 now.”

---

### I-F03 — Generated-history/shrinking/held-out machinery is an IMP-0001 completion requirement

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

The cross-cutting contract says generated histories supplement canonical cards, shrinking is used where tooling supports it, and held-out variants may be materialized after the implementation path exists. These are later verification-hardening obligations, not reasons to build a general generator/shrinker before the first reference path exists.

---

### I-F04 — Slice 1 needs a general runtime scoring-profile configuration subsystem

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

Reference profiles explicitly identify themselves as verification/laboratory configuration. IMP-0001 permits fixture/config representation choices and excludes broad frameworks/dependencies. Pinned configuration with recorded profile/version and the real production component-sum scorer is sufficient.

---

### J-F02 — “Working artifacts are not authority” makes `WORKING_CONSTITUTION.md` non-authoritative

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

The root retrieval path explicitly ranks `governance/WORKING_CONSTITUTION.md` in the authority hierarchy, and the file header explicitly states its authority is derived from the Project Seed with Seed precedence. “Working/proposed artifacts are not authority” is a status rule, not a lexical filename rule.

The legacy filename is suboptimal but does not leave the authority state unresolved for an agent that follows the mandated retrieval path.

---

### J-F03 — Root commands must exist before the task that creates them can start

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

The active, more specific operational artifacts resolve the sequence:

- SCF-001 fires **on IMP-0001 dispatch**;
- IMP-0001 §3.1 creates the solution/root commands/CI;
- IMP-0001 requires `AGENTS.md` to contain the actual commands before claiming completion.

The older root sentence is temporally imprecise but cannot reasonably force pre-existing commands before the bootstrap task begins once the task packet and trigger are read.

---

### G-F02 — Ambient/non-deterministic semantic IDs

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

IMP-0001 requires stable semantic identity not derived from runtime allocation handles, repeated-run determinism, explicit order/fallback state, and stable-ID sensitivity testing. ADR-0001/ADR-0004 supply the same semantic boundary. Concrete forbidden APIs are useful checklist examples, not a missing rule.

---

### G-F04 — Collection/source order becomes hidden tie-break

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

IMP-0001 explicitly requires that nonsemantic collection iteration order never become semantic order, plus permutation and stable-ID-fallback sensitivity checks. The cross-cutting contract contains the same metamorphism/mutant. This is already a directly testable obligation.

---

### G-F07 — Reflection/deserialization/exception shortcuts bypass invariants

**Result:** `ALREADY_RESOLVED_BY_AUTHORITY`  
**Confidence:** high

The central proposal/response/resolution/commit path, fixture write-set restrictions, always-on invariants, explicit domain outcomes, and the active C# guardrail against reflection/dynamic/deserialization shortcuts already reject the claimed shortcut. No new pre-code semantic rule is needed.

## 4. Full challenged-finding matrix

| Finding | Wave-A claim under challenge | Wave-B prosecution result | Confidence | Primary disposition |
|---|---|---|---|---|
| D-001 | implementation authors own grader | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | protected verification infrastructure |
| D-002 | oracle circularity not mechanically excluded | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | protected verification infrastructure |
| D-003 | profile IDs/target bindings enable overfit | `FALSE_POSITIVE` | Med-high | existing profile/gate authority + P0-1 |
| D-004 | visible held-outs are not independent | `ALREADY_RESOLVED_BY_AUTHORITY` | High | later materialization explicitly allowed |
| D-005 | “applicable” checks self-selected | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | exact applicability manifest |
| E-F01 | card ranges cross Slice-1 boundary | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | exact applicability manifest |
| E-F04 | direct-participant knowledge omitted from handoff | `IMPLEMENTATION_LOCAL_GUARD` | High | actor-scoped subjective/query boundary |
| E-F06 | verification applicability self-selected | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | exact applicability manifest |
| E-F07 | analyzer/protection criteria subjective | `IMPLEMENTATION_LOCAL_GUARD` | High | concrete local tooling; P0-1 protection minimum |
| F-F01 | behavior can couple to omniscient objective state | `IMPLEMENTATION_LOCAL_GUARD` | High | actor/context-scoped reads |
| F-F02 | PersonId can collapse semantic context identity | `IMPLEMENTATION_LOCAL_GUARD` | Med-high | keep context/origin distinguishable; no future framework |
| F-F03 | pairwise transition shape blocks future provision | `FALSE_POSITIVE` | High | local reversible refactor preferred |
| F-F04 | semantic history can be only diagnostics | `ALREADY_RESOLVED_BY_AUTHORITY` | High | semantic records/resolvable refs already required |
| I-F01 | VS-SFL-104 forced into Slice 1 | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | exact applicability manifest |
| I-F02 | all mutants become immediate build scope | `ALREADY_RESOLVED_BY_AUTHORITY` | High | `unexercised` explicitly valid |
| I-F03 | generator/shrinker/held-outs required now | `ALREADY_RESOLVED_BY_AUTHORITY` | High | explicit staged deferral |
| I-F04 | general profile-config framework required | `ALREADY_RESOLVED_BY_AUTHORITY` | High | pinned lab configuration sufficient |
| J-F01 | authority/supporting context conflated | `CONFIRMED_REPAIR_BEFORE_SLICE1` | High | navigation/authority wording |
| J-F02 | WORKING_CONSTITUTION filename defeats authority | `ALREADY_RESOLVED_BY_AUTHORITY` | High | root hierarchy + file header resolve it |
| J-F03 | root-command bootstrap circularity | `ALREADY_RESOLVED_BY_AUTHORITY` | High | SCF-001 + IMP completion rule resolve sequence |
| G-F01 | snapshot alias/deferred enumeration | `IMPLEMENTATION_LOCAL_GUARD` | High | phase-stable snapshot guard/test |
| G-F02 | nondeterministic ID/order source | `ALREADY_RESOLVED_BY_AUTHORITY` | High | stable-ID/determinism requirements explicit |
| G-F03 | record equality/mutable hash-key identity bugs | `IMPLEMENTATION_LOCAL_GUARD` | High | stable-ID indexing/equality discipline |
| G-F04 | sort/container order leaks into semantics | `ALREADY_RESOLVED_BY_AUTHORITY` | High | explicit order + permutation tests |
| G-F05 | culture-sensitive textual ordering | `IMPLEMENTATION_LOCAL_GUARD` | Med-high | explicit deterministic comparer if strings used |
| G-F06 | unchecked integer overflow changes ranking | `IMPLEMENTATION_LOCAL_GUARD` | Med | checked/validated local numeric policy |
| G-F07 | reflection/deserialization bypass | `ALREADY_RESOLVED_BY_AUTHORITY` | High | central path + fixture/invariant rules |

## 5. Disconfirmation routes attempted

This prosecution actively tried to falsify the inherited serious findings rather than accept Wave-A severity labels.

1. **Protected-acceptance defense against D-001/D-002:** failed to close. The rule exists, but the first executable judge still originates inside IMP-0001 and SCF-002 is not yet concretized.
2. **Full-verification-now interpretation against D-004/I-F03:** rejected. The cross-cutting contract explicitly stages generated/held-out materialization and does not define held-out as secret.
3. **General profile-flexibility interpretation against D-003/I-F04:** rejected. Pinned verification profiles are sufficient for Slice 1; a fresh-ProfileId metamorphism would create an unsupported general runtime-config requirement.
4. **Future-proof generic transition abstraction against F-F03:** rejected by ADR-0003 and the accepted Architecture Development Policy's “simplest sufficient implementation” rule. Internal local refactoring is an intended path, not automatically an architectural dead end.
5. **Dedicated KnownFact-store requirement against E-F04/F-F01:** rejected as too strong. The semantics require actor-held/provenance-aware subjective truth, but ADR-0003 permits a derived actor-scoped query over semantic history where valid.
6. **Rendered-log-only history defense against F-F04:** rejected as invalid. Stable/resolvable semantic records and causal references are already required.
7. **Filename heuristic against J-F02:** rejected. Explicit navigation hierarchy/header authority outranks lexical inference from “WORKING.”
8. **Bootstrap circularity against J-F03:** rejected. SCF-001 and IMP-0001 establish the executable sequence.
9. **C# runtime-hazard escalation:** only snapshot phase-stability and several ordinary representation traps survive as local guards; deterministic identity/order and central transition rules are already explicit.

## 6. Exact pre-code consequence

Before the Master Architect records a dispatch decision for IMP-0001, prosecution evidence supports only these bounded changes:

1. **Concretize SCF-002** so the candidate implementation task cannot be the sole authority for whether its newly authored acceptance translation is complete, and make the existing independent-oracle rule auditable.
2. **Add a closed Slice-1 applicability manifest** covering required/deferred card subcases, boundary/metamorphic relations, and mutant classification; explicitly defer `VS-SFL-104` / role-scoped `SCORE-RP-005` and the out-of-scope Communication subcase in `VS-SFL-098`.
3. **Correct IMP-0001 input taxonomy** to distinguish accepted authority from required non-authoritative supporting/operational context and state precedence.

During implementation, enforce the local guards identified above, especially:

- actor/context-scoped subjective reads rather than omniscient behavioral access;
- phase-stable common snapshots;
- stable-ID identity/equality discipline;
- explicit deterministic machine-text comparison if strings participate in semantics;
- checked/validated exact-integer aggregation;
- no universal PersonId-only semantic decision-origin assumption.

Do **not** pre-build:

- household/head semantics;
- a generic multi-party transition framework;
- a generic profile/configuration platform;
- hidden-eval infrastructure;
- generated-history/shrinking infrastructure solely as a Slice-1 bootstrap prerequisite.

## 7. Remaining uncertainty

No challenged finding in this packet requires a technical experiment to decide.

The only platform-specific detail not independently re-researched in this Wave-B run is the exact C# mechanism described in assigned report G for shallow aliasing/deferred enumeration. The project-level consequence is nevertheless decidable from accepted authority: any implementation representation that lets an already-created decision context observe later-phase authoritative mutations violates the common-snapshot contract.

## 8. Scope / independence disclosure

- Assigned Wave-A reports read: **D, E, F, G, I, J only**.
- Opposing Wave-B I-DEFENSE return read: **no**.
- Any other Wave-B return read: **no**.
- Unrelated Wave-A return read: **no**.
- Prior TRES-0003 through TRES-0009 return files read: **no**. Accepted canonical artifacts that reference earlier TRES work were used as current authority; those historical returns were not opened.
- No canonical source was modified.
- This report is advisory evidence only and does not promote any repair into project authority.

## 9. Prosecution conclusion

**IMP-0001 should not be released unchanged, but the surviving defects are repairable without reopening SFL social semantics or accepted architecture.**

The strongest prosecution case is verification/governance integrity: a first-code task must not be able to under-translate its own acceptance authority or circularly validate itself, and the exact Slice-1 verification surface must be frozen enough that “applicable” cannot mean “whatever the candidate chose to run.”

Once those bounded repairs are made, the remaining challenged implementation hazards are either explicit local coding guards or already resolved by accepted authority. In particular, Wave-B prosecution finds no evidence that Slice 1 should preemptively absorb household semantics or speculative future-slice framework abstractions.
