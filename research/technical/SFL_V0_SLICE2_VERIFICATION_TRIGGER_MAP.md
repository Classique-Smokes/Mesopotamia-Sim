# SFL v0 Slice 2 — Verification Trigger Map

**Status:** RETURN / READ-ONLY FROZEN-VERIFICATION INVENTORY  
**Commission:** `tasks/research/SFL_V0_SLICE2_DISCOVERY_C_VERIFICATION_TRIGGERS.md`  
**Repository:** `Classique-Smokes/Mesopotamia-Sim`  
**Base SHA:** `ece7d45f48512f9ddf3c0dc82034e0317265b36e`  
**Branch:** `research/slice2-verification-trigger-return`  
**Implementation authority:** none  
**Semantic/design authority:** none  
**Reclassification authority:** none

## 1. Scope and interpretation rule

This report answers only:

> Which already-frozen verification obligations become live planning/execution obligations in Slice 2, which remain later-slice obligations, which need an authority question settled before executable coverage can be claimed, and which Slice-1 obligations are already satisfied infrastructure that must remain regression-protected?

"Fires in Slice 2" below is an **applicability/trigger statement for new Slice-2 planning**. It does **not** edit the frozen Slice-1 manifest. Every `AcceptanceId` retains exactly the `SliceStatus` frozen in `SFL-V0-S1-ACCEPTANCE-v1`.

The frozen Slice-1 authority remains:

- manifest: `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`;
- version: `SFL-V0-S1-ACCEPTANCE-v1`;
- frozen ref: `sfl-v0-slice1-acceptance-v1`;
- freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`;
- frozen manifest blob: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- frozen census: 167 unique AcceptanceIds — 128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED.

Slice 1 is already VERIFIED COMPLETE. Therefore previously REQUIRED rows are not re-opened or reclassified here; they appear only in the regression-protection section where Slice 2 makes their existing contract newly consequential.

## 2. Authority retrieved

Read for this inventory:

- `AGENTS.md`
- `00_START_HERE.md`
- `plans/CURRENT_PHASE.md`
- `tasks/research/SFL_V0_SLICE2_PREIMPLEMENTATION_DISCOVERY.md`
- `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`
- `plans/verification/SFL_V0/README.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_FREEZE_RECORD.md`
- `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md`
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`
- `plans/verification/SFL_V0/DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md`
- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- `plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md`
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`
- `registers/ASSUMPTIONS_REGISTER.md`
- `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md` only to confirm that frozen REQUIRED Slice-1 obligations were actually completed.

The new conceptual tablet collections were not used.

## 3. Controlling slice boundary

`plans/CURRENT_PHASE.md` fixes Stage-4 order as:

1. Slice 1 — individuals + relationships + proposal/response/commit + semantic history;
2. **Slice 2 — subjective recognition + minimal individual agency integration**;
3. Slice 3 — persistent household identity + grounded collective capability;
4. Slice 4 — representative role + turnover/succession;
5. Slice 5 — delayed processes + checkpoint/restore continuation.

The Slice-2 inter-slice prompt specifically expects post-verification evidence of:

- actors holding different knowledge about the same objective state;
- stale facts;
- contested recognition;
- recognition changing action availability;
- inspectable epistemic provenance.

That makes subjective-state divergence, provenance ordering, contested state, communication cost, and causal use of subjective inputs Slice-2 concerns. It does **not** pull household identity, head succession, provision, lineage, or checkpoint semantics forward.

## 4. Frozen DEFERRED rows that fire in Slice 2

| AcceptanceId | Frozen status | Why the obligation fires now | Canonical source / caution |
|---|---|---|---|
| `S1-098-COMMUNICATION` | DEFERRED | Slice 2 explicitly introduces communication/claim propagation into minimal personal agency. Communication is an ordinary voluntary personal action and consumes the sender's one personal initiative. | `VS-SFL-034`; `SPEC-SFL-0001` §§5, 6.4. Must preserve separation from response initiative and later household initiative. |
| `S1-META-08` | DEFERRED | Message-arrival permutation is now executable because Slice 2 must carry provenance-bearing communicated evidence and stale knowledge without letting arrival order become evidence order. | `SPEC-SFL-0001` §6.5; recognition/information family invariant. A lower-level person-fact witness can exercise this without pulling head succession forward. |
| `S1-MUT-27` | DEFERRED | Slice 2 must reject the mutant where a later-arriving older message overwrites newer event evidence. This is the direct negative control for §6.5. | Stage-3 mutant 27; `VS-SFL-032` expresses the same law, although its canonical example uses later-slice head succession. |
| `S1-MUT-28` | DEFERRED | Slice 2 is explicitly expected to produce `Contested` recognition. Arbitrary stable-ID/sender-ID/arrival-order selection would violate the accepted `Unknown / Recognized / Contested` model. | `SPEC-SFL-0001` §§6.1, 6.5; `VS-SFL-033`. Do not confuse the recognition-state test with later authority-action routing. |
| `S1-076` | DEFERRED | The cross-family "communication provenance regression" set becomes a Slice-2 acceptance-planning obligation because its three preserved properties are precisely stale/provenance ordering, contested recognition, and communication initiative cost. | `VS-SFL-076` references `VS-SFL-032/033/034`. **Execution-shape caveat:** 032/033 are written with head/continuity examples. Slice 2 must not fake household/head state merely to mark this row passed; see §7. |

### 4.1 What "fires" does not mean

These rows remain marked DEFERRED in the frozen Slice-1 manifest forever unless separately versioned authority changes them. Slice-2 planning should import/reference them as triggered prior obligations, then create Slice-2 completion authority separately.

A triggered row is not automatically executable in its old canonical fixture shape. Where the old card used later-slice substrate, the Slice-2 plan must either supply an admissible witness under already accepted semantics or leave the exact old card visibly pending. This commission does not choose or authorize that witness.

## 5. Relevant frozen DEFERRED rows that remain beyond Slice 2

### 5.1 Household / role / recognition rows

| AcceptanceId | Frozen status | Remains deferred because |
|---|---|---|
| `S1-104` | DEFERRED | Exact card is role-scoped household-mediated response through a valid head. Representative role is Slice 4. |
| `S1-075` | DEFERRED | Exact card is household formation reaction closure, including CandidateRecognition -> FormationWarrant -> Household -> founding participation/recognition. Household identity is Slice 3. |
| `S1-BND-FORMATION` | DEFERRED | Formation/participation/lifecycle boundaries belong to persistent household identity in Slice 3. |
| `S1-MUT-01` | DEFERRED | "form H from co-residence alone" requires executable household formation. Slice 3. |
| `S1-MUT-02` | DEFERRED | Insufficient/same-cycle support mutant requires executable household formation. Slice 3. |
| `S1-MUT-03` | DEFERRED | The frozen mutant is specifically **global household/head recognition**. Generic anti-omniscience is a Slice-2 concern, but this exact mutant cannot be fully exercised before household/head objective substrate exists; it spans Slices 3–4. Do not repurpose the frozen row as a generic person-fact test. |
| `S1-MUT-05` | DEFERRED | Identity-by-overlap/similarity requires household continuity/identity. Slice 3 or later. |
| `S1-MUT-06` | DEFERRED | Inactive/Dissolved H emitting household-mode action requires executable household lifecycle/capability. Later than Slice 2. |
| `S1-MUT-07` | DEFERRED | Participation entry without bilateral acceptance/warrant requires household participation. Slice 3. |
| `S1-MUT-08` | DEFERRED | Household self-feedback clone requires formation machinery. Slice 3. |

Recognition semantics may be implemented in Slice 2, but these rows assert behavior of **later objective entities or authority routes**. Slice 2 must not create fake Household/head mechanics to satisfy them.

### 5.2 Checkpoint/recovery rows that contain subjective state but do not fire until Slice 5

| AcceptanceId | Frozen status | Reason |
|---|---|---|
| `S1-082` | DEFERRED | Exact checkpoint suffix equivalence includes subjective KnownFact/Recognition, but checkpoint/restore belongs to Slice 5. |
| `S1-083` | DEFERRED | Omitted-checkpoint-state challenge includes subjective state but requires checkpoint machinery. Slice 5. |
| `S1-META-06` | DEFERRED | Checkpoint metamorphism remains Slice 5. |
| `S1-MUT-25` | DEFERRED | Omitting subjective/cooldown/pending/ID/config state from checkpoint is a Slice-5 mutant. |

Slice 2 should ensure subjective state is represented as authoritative future-influencing state rather than an irrecoverable side cache, but it must not implement or claim checkpoint acceptance early.

### 5.3 Explanation-surface rows

| AcceptanceId | Frozen status | Reason |
|---|---|---|
| `S1-087` | DEFERRED | The frozen rationale explicitly says no rendered explanation surface is required. Slice 2 needs truthful decision/history evidence, not a new rendered explanation product. |
| `S1-MUT-30` | DEFERRED | Unsupported rendered-explanation cause is the negative control paired with the deferred explanation surface. |

### 5.4 Other frozen DEFERRED rows are not Slice-2 epistemic triggers

For completeness, the remaining frozen DEFERRED rows continue to wait on household provision, lineage, head/role, or other later substrate:

- `S1-072`
- `S1-BND-HOUSEHOLD-PROVISION`
- `S1-BND-PROVISION-RECONSIDERATION`
- `S1-BND-LINEAGE`
- `S1-META-09`
- `S1-MUT-09`
- `S1-MUT-10`
- `S1-MUT-11`
- `S1-MUT-12`
- `S1-MUT-13B`
- `S1-MUT-14`
- `S1-MUT-15`

None is made Slice-2-applicable merely because future household/role logic will consume subjective recognition.

## 6. Already-satisfied Slice-1 obligations that must remain regression-protected

Slice 1 is VERIFIED COMPLETE, so these rows are not "firing" from DEFERRED. They are already satisfied contracts that Slice 2 must preserve while adding epistemic state.

| AcceptanceId(s) | Existing protected contract | Slice-2 regression significance |
|---|---|---|
| `S1-070`, `S1-GLOBAL-KNOWLEDGE` | Direct participants learn Declined/Unable/Invalidated outcomes with the accepted bounded meaning. | New knowledge machinery must not erase, globally broadcast, or reinterpret already-required participant knowledge. |
| `S1-073` | Bounded failure reason; resolver omniscience does not leak unrelated private state. | This is the existing anti-omniscience boundary. New actor knowledge must not be populated by raw objective-state access hidden behind failure reporting. |
| `S1-098-CORE`, `S1-105` | One personal initiative; responses consume no personal initiative. | `CommunicateClaim/Inform` now consumes the personal initiative without changing response accounting. |
| `S1-085`, `S1-META-04`, `S1-MUT-26` | Observer/diagnostic noninterference. | Epistemic inspection/tracing must not itself mutate knowledge/recognition, scheduling, IDs, or candidate generation. |
| `S1-086`, `S1-MUT-29` | Complete decision trace, not chosen-action-only logging. | Slice 2 makes the previously latent "subjective facts/recognition actually used" field substantive. New acceptance should exercise a context with real KnownFact/Recognition input and verify the trace records it. |
| `S1-META-07` | Irrelevant-attribute perturbation / causal specificity. | Subjective gating/scoring must change only when relevant subjective inputs change, not because unrelated objective/private state differs. |
| `S1-084`, `S1-META-05`, `S1-MUT-24` | Derived cache/indexes are non-authoritative; stale derived state cannot influence behavior. | If Slice 2 adds knowledge/recognition indexes or caches, the frozen conditional branch becomes materially important: behavior-affecting derived state requires executable stale/rebuild evidence rather than merely the old "no such cache" structural argument. |
| `S1-META-03` | Disconnected-population locality / no hidden global coupling. | Useful regression against accidental global synchronization of actor state. |
| `S1-META-02`, `S1-GLOBAL-FALLBACK` | Nonsemantic ID renaming and fallback quarantine. | `Contested` recognition must never be resolved by importing the technical stable-ID fallback used for genuinely symmetric action choices. |

### 6.1 Important non-reclassification point for S1-086

`S1-086` remains REQUIRED and already passed for Slice 1. Slice 2 should not relabel it or claim it was previously "deferred." Instead, the Slice-2 acceptance plan needs a **new executable witness of the existing trace contract with actual subjective inputs present**.

That is a coverage-planning consequence of new substrate, not a correction to the frozen Slice-1 manifest.

## 7. Semantic questions / execution dependencies that must not be invented by this commission

### 7.1 Event-specific observation eligibility

Accepted `SPEC-SFL-0001` §6.4 says actors know:

- their own objective state;
- proposals/events in which they directly participate;

and that other facts require valid **event-specific observation or communication**.

The accepted source does not establish one generic observer-eligibility rule for every event class. Therefore:

- direct participation and communication provenance can be verified in Slice 2 from accepted authority;
- a generic "nearby actor observes event X" mechanism must not be invented just to broaden coverage;
- if the Slice-2 implementation plan requires indirect observation for an event whose observer rule is not already fixed, that is an authority question before code/acceptance is dispatched.

This is a **new coverage/semantic-clarity issue**, not a reclassification of a frozen AcceptanceId.

### 7.2 `S1-076` canonical witness shape

`VS-SFL-076` preserves three properties by reference to `VS-SFL-032/033/034`.

- 034 is directly Slice-2 executable.
- 032 and 033 are semantically Slice-2 properties, but their canonical fixtures are written using head/continuity transitions that belong to later slices.

Therefore `S1-076` **fires as a Slice-2 verification obligation**, but the Slice-2 acceptance plan must explicitly decide how to evidence the same accepted laws without pulling later-slice mechanics forward. A semantically equivalent lower-level witness is a verification-design decision; if it would require changing the semantic claim, authority escalation is required.

Until that plan exists, do not report `S1-076` as executable PASS merely because one of its three referenced properties passed.

### 7.3 Recognition causality versus later household action gates

The Stage-3 Recognition/Information family has no one-to-one frozen Slice-1 AcceptanceId for each card:

- `VS-SFL-030` — recognition changes household-mediated candidate availability;
- `VS-SFL-031` — stale head recognition through succession;
- `VS-SFL-032` — provenance order beats message arrival;
- `VS-SFL-033` — incomparable evidence becomes Contested;
- `VS-SFL-034` — communication consumes personal initiative;
- `VS-SFL-035` — recognition is independent of attitude/compliance.

Slice 2 must make subjective differences causally relevant, but **030/031/035 as written depend on Household/head objective substrate**. They must not be marked executable by stubbing fake later-slice entities.

The Slice-2 verification plan therefore needs explicit new completion coverage for the accepted Slice-2 portions that are not individually represented by frozen AcceptanceIds. This report may identify that gap, but it may not author new AcceptanceIds or acceptance authority.

## 8. Deferred-gap ledger trigger check

`registers/TRES-0010_DEFERRED_GAP_LEDGER.md` contains separate later-slice gaps/hardening items. Slice 2 does not automatically close them.

| Ledger ID | Slice-2 trigger result |
|---|---|
| `LATER-01` CandidateOrganization same-candidate equivalence | **Still deferred**, unless Slice-2 planning makes creation/reconciliation of multiple CandidateOrganization labels/evidence paths executable. If it does, this trigger fires before code. |
| `LATER-02` actor departure semantics | **Still deferred**. Slice 2 does not require actor departure. Do not use executable departure as a convenient observation fixture without first closing this trigger. |
| `LATER-03` rejoin/re-exit lineage source | Later household lineage; not Slice 2. |
| `LATER-04` authority-destroying transition race | Later household/head coexistence; not Slice 2. |
| `LATER-05` mediated-marriage nested response/authority topology | Later mediated marriage/head execution; not Slice 2. |
| `VH-01` exit-side ContinuationWarrant | Later continuity; not Slice 2. |
| `VH-02` generated-history oracle circularity | Triggered only if generated histories become required completion evidence. No Slice-2 requirement found that makes this necessary. |
| `VH-03`, `VH-04` checkpoint provenance/omission hardening | Slice 5. |
| `VH-05` observer eligibility + recognition after dissolution/head vacancy | Later lifecycle/head coexistence; not Slice 2. It does, however, reinforce the §7.1 warning not to invent a universal observation rule now. |
| `VH-06` household/reaction derived-state refresh | Later household reactions; not Slice 2. |

## 9. Full frozen-DEFERRED census by earliest trigger class

This section ensures none of the 33 frozen DEFERRED rows disappears from view.

### Slice 2 trigger

- `S1-098-COMMUNICATION`
- `S1-076`
- `S1-META-08`
- `S1-MUT-27`
- `S1-MUT-28`

### Later than Slice 2 — household/continuity/provision/lineage/role

- `S1-104`
- `S1-072`
- `S1-075`
- `S1-BND-HOUSEHOLD-PROVISION`
- `S1-BND-PROVISION-RECONSIDERATION`
- `S1-BND-FORMATION`
- `S1-BND-LINEAGE`
- `S1-META-09`
- `S1-MUT-01`
- `S1-MUT-02`
- `S1-MUT-03`
- `S1-MUT-05`
- `S1-MUT-06`
- `S1-MUT-07`
- `S1-MUT-08`
- `S1-MUT-09`
- `S1-MUT-10`
- `S1-MUT-11`
- `S1-MUT-12`
- `S1-MUT-13B`
- `S1-MUT-14`
- `S1-MUT-15`

### Slice 5 checkpoint/recovery trigger

- `S1-082`
- `S1-083`
- `S1-META-06`
- `S1-MUT-25`

### Later explicit explanation-surface trigger

- `S1-087`
- `S1-MUT-30`

Count check: **5 + 22 + 4 + 2 = 33 DEFERRED rows**, matching the frozen manifest census.

## 10. Missing executable coverage to carry into Slice-2 planning

These are planning gaps only; this commission creates no new authority.

1. **Actor-specific objective-vs-subjective divergence needs its own Slice-2 completion witness.** The frozen Slice-1 manifest has no dedicated AcceptanceId for generic KnownFact acquisition/non-acquisition.
2. **Anti-global-synchronization needs a Slice-2 witness that does not misuse `S1-MUT-03`.** The frozen mutant is household/head-specific and remains later.
3. **Stale person-level facts need executable evidence.** `S1-META-08` and `S1-MUT-27` fire, but the canonical Stage-3 stale example is head-shaped; the Slice-2 plan should use only already accepted lower-level event/provenance semantics or escalate if adaptation would alter the claim.
4. **Contested recognition needs a Slice-2 witness without arbitrary fallback.** `S1-MUT-28` fires now; later authority-action consequences remain separately deferred.
5. **Communication truthfulness/provenance needs coverage.** The Stage-3 family invariant says a sender never communicates a proposition absent from its own subjective state and carries source/event provenance. No distinct frozen Slice-1 AcceptanceId isolates that claim.
6. **Decision traces must now carry real subjective inputs.** Existing `S1-086` infrastructure is already accepted; Slice 2 needs coverage where KnownFact/Recognition actually affects candidate generation/gating/scoring and the trace names the used inputs.
7. **Observation eligibility must remain event-specific.** If no accepted observer rule exists for the chosen event, do not invent one in test or production.

## 11. Verification-planning conclusion

The frozen verification record does **not** justify pulling household, head, mediated-marriage, lineage, checkpoint, or rendered-explanation mechanics into Slice 2.

It does justify activating the existing communication/provenance subset:

- `S1-098-COMMUNICATION`;
- `S1-META-08`;
- `S1-MUT-27`;
- `S1-MUT-28`;
- `S1-076` as the cross-family provenance-set trigger, with the execution-shape caveat recorded above.

At the same time, Slice 2 must regression-protect the already-passed failure-knowledge/privacy, initiative-accounting, observer-noninterference, decision-trace, derived-state, locality, and fallback contracts.

The Master Architect's next verification-planning action should therefore be to author a **separate Slice-2 acceptance/applicability authority** that:

- references rather than edits the frozen Slice-1 manifest;
- imports the five triggered prior obligations above;
- adds explicit Slice-2 coverage for accepted KnownFact/Recognition semantics that lacked individual Slice-1 AcceptanceIds;
- uses only Slice-2-valid objective substrate;
- leaves all later-slice rows visibly deferred;
- escalates only genuine missing semantic distinctions, especially any event-specific observation rule required by the chosen Slice-2 witnesses.
