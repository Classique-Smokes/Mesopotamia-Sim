# SFL v0 Slice 2 — Acceptance Applicability Pre-Code Review V2

**Status:** RETURN / **BLOCK**  
**Review authority:** fresh read-only pre-code acceptance review  
**Reviewed candidate:** `plans/verification/SFL_V0/SLICE2_ACCEPTANCE_APPLICABILITY_CANDIDATE.md`  
**Reviewed candidate branch:** `verification/sfl-v0-slice2-acceptance-candidate-v2`  
**Reviewed candidate commit:** `e590963786d84250d295b4963f0f3c4543fcd83a`  
**Reviewed candidate blob:** `18c77a27903cb148e087437bb43fc27dc998af77`  
**Return branch:** `review/sfl-v0-slice2-acceptance-precode-v2-return`  
**Implementation authority exercised:** none  
**Semantic promotion authority exercised:** none

## 1. Judgment

**BLOCK.**

Candidate v2 closes nearly all v1 defects and its exact RG-01 witness is supported by accepted SFL semantics. No Household/head/checkpoint pull-forward and no Director-level semantic gap were found.

Two verification-authority defects remain:

1. **Recognition communication is not independently forced through all ordinary communication invariants.** The candidate has explicit factual/Recognition rows for held-proposition, no-invention, and provenance, but the mandatory ordinary-pipeline / initiative / recipient-only / receipt-no-reactivation-or-response coverage is not independently bound to Recognition communication. In particular, the per-row fixture table binds `S2-020`, `S2-025`, and `S2-026` only to `F-COMM-FACT`, while `S2-024` is a single generic `F-GATE` row. An implementation could therefore make factual communication obey the ordinary action path while Recognition communication bypasses initiative accounting, broadcasts, or manufactures receipt-side activation/response, yet still satisfy the present executable bindings.
2. **Recognition-vs-compliance coverage remains optional.** `S2-009` correctly makes negative-attitude independence required, but §15 says an independent ordinary voluntary `Decline` is optional. That leaves an implementation free to erase/change Recognition on refusal while still passing the mandatory attitude perturbation.

These are verification/applicability defects only. They do not require new social semantics.

**RG-01:** **SUPPORTED.**  
**Director decision:** **NO DIRECTOR DECISION REQUIRED.**  
**Freeze judgment:** the reviewed candidate **may not freeze unchanged**.

## 2. Exact source set re-derived

All repository sources below were retrieved from exact candidate commit `e590963786d84250d295b4963f0f3c4543fcd83a`.

| Source | Blob |
|---|---|
| `AGENTS.md` | `ee9f27664b912e07eb0a8fedc819a6f5a05ed257` |
| `00_START_HERE.md` | `cf11d0ce07b72fbe97577575d419df8f3e3a8ccf` |
| `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` | `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52` |
| `architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md` | `66cfd55f8b960ff5664638c41c0e731257902be5` |
| `architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md` | `aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229` |
| `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md` | `43eedd7eb49e1eae035010332883ed2d8726d451` |
| `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md` | `d8f87dea9569d41481850c7327a025c44d6c3358` |
| `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` | `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766` |
| `research/technical/SFL_V0_SLICE2_AUTHORITY_INVENTORY.md` | `a6f0bc8e6369b4cd854b42cf2042dc1052ec5b4d` |
| `research/technical/SFL_V0_SLICE2_VERIFICATION_TRIGGER_MAP.md` | `40fdeaf2e8be7b5321a5d16662c5706d4a917a32` |
| `research/technical/SFL_V0_SLICE2_IMPLEMENTATION_SURFACE_MAP.md` | `3c15cb411fd08c5bfc64670cda47bf0b0b91efd6` |
| `research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_RECONCILIATION.md` | `f6a6ffef1368836545e75aaa30ef77a0274538ef` |
| prior V1 BLOCK report | `a4e44f74710223e4f7f97ee6ff278117eafe2ab2` |
| exact candidate v2 | `18c77a27903cb148e087437bb43fc27dc998af77` |

The fresh-review task packet was retrieved separately from the named candidate branch. Conceptual tablet material was not used as semantic authority.

## 3. Independent accepted-contract re-derivation

Accepted authority fixes the relevant Slice-2 contract:

- objective execution truth and actor subjective state are distinct;
- `KnownFact` is actor-held factual state with provenance;
- `Recognition` is a provenance-bearing social interpretation, distinct from KnownFact, objective truth, confidence, attitude, approval, and obedience;
- Recognition states are `Unknown / Recognized / Contested`;
- `CandidateRecognition(C)` is an accepted **ephemeral** pre-Household Recognition proposition;
- automatic acquisition covers own objective state, direct-party relations/claims, and direct participation;
- other facts require valid event-specific observation or communication; co-residence is not omniscience;
- `CommunicateClaim/Inform` transmits a factual or Recognition proposition the sender currently holds and carries sender plus underlying source/event provenance where available;
- ordinary communication normally consumes the sender's one voluntary personal initiative;
- subjective state does not passively synchronize;
- underlying semantic event/observation order outranks delivery order;
- newer direct evidence and newer event-backed reports have only the precedence relations explicitly accepted by SPEC;
- unresolved incompatible Recognition evidence becomes `Contested`, not a stable-ID/sender-ID/arrival-order winner;
- Recognition does not decay with attitude and does not imply approval or obedience;
- inaccessible candidates are gated before scoring;
- objective commit-time revalidation remains authoritative;
- decision/history traces retain relevant subjective inputs;
- observer/debug reads must remain noninterfering.

No accepted source supplies a universal KnownFact conflict algebra, general perception model, universal evidence-strength order, autonomous communication motivation, or universal proposition ontology.

## 4. A1–A14 v1 repair closure

| Item | Result | Fresh review |
|---|---|---|
| A1 exact RG-01 witness | **CLOSED** | Candidate §7 pins one inert pre-Household C, exact controlled evidence, production-derived Contested, lifetime-scoped retention, metamorphic permutations, and an independent oracle boundary. |
| A2 Recognition communication/provenance/no-invention mandatory | **CLOSED for the stated v1 defect; new completeness blocker remains** | `S2-021R`, `S2-022R`, and `S2-023R` make held Recognition communication, no invention, and supporting provenance mandatory. However §6 below identifies a remaining cross-path omission: Recognition communication is not independently bound to all generic ordinary-communication invariants. |
| A3 Recognition-based candidate gate + trace mandatory | **CLOSED** | `S2-040R` and `S2-042` require a Recognition-based communication candidate gate and a separate Recognition/provenance trace subcase. |
| A4 Recognition independent of attitude/compliance | **STILL BLOCKING** | Negative-attitude independence is mandatory, but §15 makes the independent voluntary `Decline` variant optional. Refusal/compliance independence is therefore not omission-detectable. |
| A5 direct-evidence precedence | **CLOSED** | `S2-031A` plus §15 pins newer direct participation vs later old report. |
| A6 event-backed report precedence | **CLOSED** | `S2-031B` plus §15 pins E1<E2 report ordering independent of delivery order. |
| A7 message-arrival permutation | **CLOSED** | `S2-032` and §6 require delivery-order permutation with underlying evidence order fixed. |
| A8 Recognition lifetime wording | **CLOSED** | Candidate §4 and `S2-005` explicitly preserve CandidateRecognition ephemerality and scope retention to C's live proposition/referent lifetime. |
| A9 communication initiative scope | **CLOSED as wording/scope** | `S2-024` is limited to successful ordinary pinned-policy initiation and does not broaden SPEC's “normally” into a universal social rule. Recognition-path execution coverage still needs the repair in §10. |
| A10 no fresh response context on receipt | **CLOSED as semantic row wording** | `S2-026` explicitly forbids both fresh same-cycle personal activation and a `ResponseDecisionContext`. Recognition-path execution coverage still needs the repair in §10. |
| A11 exact Slice-1 regression IDs | **CLOSED** | §10 lists the exact prior IDs/bundles, including `S1-GLOBAL-MANIFEST-INTEGRITY`. |
| A12 per-row fixture bindings | **CLOSED structurally, with one binding repair required by communication completeness** | Every REQUIRED row is bound in §14. The remaining defect is not absence of bindings but that generic communication rows `S2-020/025/026` are fact-only in the fixture mapping. |
| A13 per-row oracle bindings | **CLOSED** | Every REQUIRED row has a declared independent oracle class and forbidden production shortcut. No self-oracle blocker was found. |
| A14 bounded broad/global wording | **CLOSED** | KnownFact has an explicit bounded census; replay/iteration/ID/cache claims are bounded; whole-population scope is explicit for no-broadcast; Recognition lifetime and initiative wording are narrowed. |

## 5. RG-01 semantic support

### Result

**SUPPORTED.**

The exact one-C witness in candidate §7 can be derived from accepted semantics without a new negative Recognition proposition, candidate-equivalence rule, general contradiction algebra, evidence-strength rule, or observation rule.

### Challenge results

**Fixture-originated incompatible Residence reports:** permissible for this row. RG-01 does not claim to prove sender acquisition. Accepted verification discipline permits controlled starting epistemic state when it is visible as fixture provenance and does not write the result under judgment. The candidate forbids writing recipient `Contested`.

**Residence incompatibility:** accepted. SPEC models Residence as an explicit person→dwelling relation and constrains Residence transitions as a single current state. `Residence(P,D1)` and `Residence(P,D2)`, with D1 != D2, are incompatible for the same person/current-state proposition.

**No negative Recognition proposition:** satisfied. S- supplies only the lower-level factual Residence report. The conflict is between evidence supporting the formation predicate and incompatible factual evidence; no invented proposition such as “C is not recognized” is required.

**Contested derivation:** supported. SPEC defines `Contested` as incompatible evidence that prevents safe reliance, and §6.3 requires a founder's CandidateRecognition basis to be uncontested evidence sufficient for the formation predicate. If R holds the D1-based supporting bundle and an incomparable D2 report, the required shared-residence evidence is unresolved and the Recognition proposition cannot be safely relied upon. `Unknown` is not the fitting state because R still retains an accepted recognition basis; `Contested` is the accepted unresolved-conflict state.

**No CandidateOrganization equivalence/formation:** satisfied. Only one referent C exists; no second label, convergence, FormationWarrant, Household, head role, or authority action is created.

**No new evidence-strength relation:** satisfied. The fixture declares only that neither controlled provenance dominates under an already accepted precedence relation. It does not create a new strength ordering.

**Lifetime:** supported. The candidate requires retention only while C remains live and no accepted evidence displaces/changes the state, preserving CandidateRecognition's accepted ephemerality.

**Oracle independence:** sound. Public/read-only Recognition/provenance plus paired-run equality is sufficient; the production conflict resolver, precedence helper, and CandidateRecognition derivation helper are explicitly forbidden as expected-answer oracles.

## 6. Communication completeness

### Factual communication

The candidate is omission-detectable for:

- held-proposition constraint: `S2-021F`;
- no invention: `S2-022F`;
- provenance: `S2-023F`;
- ordinary action pipeline: `S2-020` with `F-COMM-FACT`;
- recipient-only delivery: `S2-025` with whole declared population;
- receipt no reactivation / no response context: `S2-026`;
- ordinary initiative accounting: `S2-024`.

### Recognition communication

The candidate is omission-detectable for:

- held-proposition constraint: `S2-021R`;
- no invention: `S2-022R`;
- provenance: `S2-023R`.

It is **not yet independently omission-detectable** for the rest of the ordinary communication contract.

The normative prose in §5 applies those properties to ordinary factual or Recognition communication, but the executable row bindings do not force the Recognition path itself through them:

- `S2-020` → `F-COMM-FACT` only;
- `S2-025` → `F-COMM-FACT` only;
- `S2-026` → `F-COMM-FACT` only;
- `S2-024` is one generic `F-GATE` execution with no mandatory factual+Recognition paired subcases.

Therefore a defective implementation could pass factual communication through the normal personal-action pipeline while Recognition communication uses a separate path that is free, broadcasts, reactivates the recipient, or creates a response context. The current mandatory evidence would not necessarily catch that defect.

This is a **verification-authority blocker**, not a semantic ambiguity.

## 7. Evidence ordering audit

**PASS.**

Candidate v2 now requires all accepted bounded subcases separately:

1. newer direct-participation evidence vs later-delivered older incompatible report — `S2-031A`;
2. newer event-backed report vs older event-backed report — `S2-031B`;
3. delivery-order permutation with underlying evidence order fixed — `S2-032`;
4. unresolved incomparable Recognition evidence → `Contested` — `S2-033`.

The candidate explicitly refuses to generalize these into a universal evidence algebra and forbids stable IDs, sender IDs, container order, or arrival order from becoming Recognition winner rules.

## 8. Fixture/oracle audit

### Fixture discipline

**PASS except for the communication-path coverage defect in §6.**

Strengths:

- every REQUIRED row has a normative fixture mapping;
- acquisition rows forbid fixture-writing the acquisition result;
- communication fact/Recognition fixtures forbid writing recipient postconditions;
- RG-01 forbids fixture-writing recipient `Contested`;
- gate fixtures forbid writing candidate/score/chosen-action/trace outputs;
- executable reports must expose resolved write sets;
- `S2-003` explicitly requires all four bounded KnownFact categories;
- `S2-025` defines the entire declared fixture population as the no-broadcast domain, so sampling one nonrecipient is insufficient.

Remaining mapping defect:

- the generic ordinary communication rows `S2-020`, `S2-025`, and `S2-026` are fact-only in §14. They must also bind a mandatory Recognition communication subcase.
- `S2-024` must likewise require both factual and Recognition ordinary-communication executions, not merely one generic path.

### Oracle independence

**PASS.**

No REQUIRED row needs to grade itself with the production helper under judgment.

In particular:

- provenance rows independently compare public source/sender/event metadata rather than calling a production provenance summarizer;
- RG-01 forbids production conflict/precedence/recognition derivation helpers as oracles;
- gating rows use frozen expected-case/public traces and paired objective-equal inputs rather than the candidate generator as expected-answer logic;
- metamorphic rows use paired-run relations rather than a production semantic normalizer;
- cache nonauthority permits structural absence or a stale/rebuild metamorphic challenge;
- trace/config rows compare emitted public evidence to declared inputs/config rather than hard-coding production output as its own truth.

No additional oracle repair is required.

## 9. Recognition vs attitude/compliance audit

**BLOCK on compliance omission.**

`S2-009` correctly holds C/evidence fixed and requires Recognition not to change because an unrelated Attitude changes. Candidate §15 makes that perturbation mandatory.

However the same §15 says an independent ordinary voluntary `Decline` is **optional**. That is not enough to detect an implementation that couples refusal/compliance to Recognition state.

Accepted semantics distinguish Recognition from approval/obedience and permit recognition while refusing a request. The acceptance authority therefore needs a mandatory refusal/compliance witness as a separate subcase, without pulling Household/head mechanics forward.

## 10. Exact verification-only repairs required

No social-semantic repair is needed. Candidate v2 can be repaired within existing authority by making only the following acceptance edits.

### R1 — Recognition communication parity across ordinary communication invariants

For each of the following, require **two mandatory executable subcases**: factual communication and Recognition communication, or split the AcceptanceIds into explicit F/R rows.

- `S2-020-COMMUNICATION-ACTION`: both proposition kinds must execute through the ordinary personal-action pipeline.
- `S2-024-ORDINARY-COMMUNICATION-INITIATIVE-COST`: successful ordinary factual and Recognition initiation each consume the sender's personal initiative and block a second ordinary personal initiation that cycle.
- `S2-025-NO-FREE-BROADCAST`: for both proposition kinds, only intended recipient(s) acquire; assert against the entire declared fixture population.
- `S2-026-RECEIPT-NO-REACTIVATION-OR-RESPONSE`: for both proposition kinds, receipt creates neither fresh same-cycle personal activation nor a `ResponseDecisionContext`.

Update §14 so the Recognition subcases use `F-COMM-REC` (and `F-GATE` where initiative/candidate setup is needed) rather than leaving these rows fact-only. Preserve the existing independent `O-PUBLIC/O-META` style; no new oracle class is required.

### R2 — Make compliance/refusal independence mandatory

Change `S2-009` evidence shape so both are mandatory paired perturbations with C and evidence held fixed:

1. unrelated Attitude moved into a negative band;
2. an otherwise independent ordinary voluntary `Decline`/refusal occurs.

Each perturbation must independently leave `Recognition(C)` unchanged solely because of that perturbation.

Do not introduce Household/head authority or any new obedience/compliance state.

After these verification-only edits, the repaired candidate requires another fresh pre-code review of its exact new bytes before freeze.

## 11. Later-slice leakage audit

**PASS.**

No REQUIRED row needs:

- persistent Household identity/lifecycle;
- HouseholdHeadRole, office occupancy, or succession;
- mediated marriage;
- household provision or lineage;
- checkpoint/restore;
- generic nonparticipant perception;
- trust/reliability, lying, rumor, reputation, or brokerage;
- richer planning/motivation or stochastic behavior.

RG-01 uses only one inert pre-Household CandidateRecognition referent and controlled lower-level evidence. It does not create CandidateOrganization convergence, Household formation, head authority, or a generic observation rule.

The two repairs in §10 remain entirely inside Slice 2 and do not pull later substrate forward.

## 12. Director decision

**NO DIRECTOR DECISION REQUIRED.**

The remaining defects are verification wording/binding issues. Accepted authority already fixes:

- factual and Recognition communication as the same ordinary action meaning;
- the ordinary initiative rule;
- recipient-scoped communication rather than global broadcast;
- stable-cycle no-reactivation behavior;
- response contexts only for action meanings that require target choice;
- Recognition's independence from attitude, approval, and obedience/refusal.

Escalate only if a future repaired RG-01 implementation actually requires a new Recognition proposition meaning, new candidate-equivalence rule, universal contradiction/evidence-strength algebra, or event-specific nonparticipant observation rule. This review found no such need.

## 13. Final disposition

**BLOCK candidate v2 from freeze and implementation dispatch.**

The exact reviewed candidate commit/blob is:

- commit: `e590963786d84250d295b4963f0f3c4543fcd83a`
- blob: `18c77a27903cb148e087437bb43fc27dc998af77`

RG-01 is **SUPPORTED** and no Director semantic decision is required.

The candidate **may not freeze unchanged**. Apply only R1 and R2 above as verification-authority repairs, then submit the exact repaired bytes to another fresh independent pre-code review.
