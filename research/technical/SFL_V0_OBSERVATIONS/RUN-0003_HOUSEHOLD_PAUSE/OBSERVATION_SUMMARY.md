# IMP-0003 Slice-3 Post-Implementation Observation Summary

**Task:** `IMP-0003-OBS-001`  
**Status:** COMPLETE — NON-GATING LEARNING OBSERVATION  
**Production source observed:** `f7ca9525d17ed20758058df7aff97b2f47e5a01a`  
**Configuration:** `SFL-S3-v1`  
**Successful observation harness revision:** `ecd1ebb5affbe0749d87e1aa47f4847e067e480d`  
**Frozen raw archive commit:** `c37c20e8c5d7419cd90b55dcb9da31ad3891bdb3`  
**Raw-freeze record commit:** `a8de96778db2ffb7ac18b5dd71c243e21f4e4005`  
**Successful workflow run:** `35950977185`

This document interprets the already-frozen raw package. It does not change Slice-3 authority, completion, or acceptance status.

## 1. Execution integrity

The successful workflow asserted that `src/Mesopotamia.Sim` and `tests/Mesopotamia.Sim.AcceptanceTests` had **no diff** from the promoted source revision before execution.

The canonical sequence then passed:

1. restore;
2. format verification;
3. Release build;
4. tests.

The observation runner then completed and archived the raw package. The first workflow attempt had also passed all canonical checks, but its observation harness stopped on an incorrect narrative assumption that P5 would necessarily hold the terminal dissolution fact. No raw package from that failed harness attempt was promoted. The successful harness records an unavailable declared step instead of treating missing actor-held evidence as a runner exception.

## 2. Material findings

| ID | Classification | Observation | Forward relevance |
|---|---|---|---|
| OBS-01 | **reference-policy limitation** | Across 12 autonomous cycles, all 72 personal initiatives were `Farm`; there were zero qualifying support events, zero communications, zero CandidateRecognition, and zero Household formation. | Current reference policy does not by itself exercise Slice-3 in this declared world. This is not evidence against Slice-3 semantics and is not a prerequisite for Slice 4. |
| OBS-02 | **implementation/architecture lesson** | Household knowledge is more actor-causal than a status-only narrative suggests. Direct continuation evidence went to the participant in the causal transition, not every current bearer; dissolution evidence went only to the terminal exiting participant. | Representative-role work should keep recognition/revocation evidence actor-specific and provenance-bearing rather than infer knowledge from current structural membership. |
| OBS-03 | **implementation/architecture lesson** | Stable Household identity plus explicit transition/continuation warrants made turnover and lifecycle explainable without reconstructing identity from endpoint membership. | A later role layer has a clean stable Household referent on which to hang role warrants; role identity should not be inferred from membership snapshots. |
| OBS-04 | **implementation/architecture lesson** | A residence action affecting a not-yet-member newcomer invalidated admission in the same cycle and correctly carried technical fallback on both consequential outcomes. | Future authority/role dependency grouping must include affected people before they become members or role holders; current-membership lookup alone is too narrow. |
| OBS-05 | **implementation/architecture lesson** | Provision capacity remained derived: a controlled active commitment exposed capacity 1; P1's personal gift reduced it to 0 without Household spending; P1's exit terminated the backing commitment. | Later authority should distinguish authority from resources and avoid turning derived Household capacity into a stored treasury or implicit spending power. |
| OBS-06 | **implementation/architecture lesson** | Controlled lineage was causally legible: H2 formed from fresh post-exit support and received one `DivisionDescendant` warrant citing its formation, both predecessor exits, and fresh support. | Lineage is a separate provenance relationship rather than Household identity. Later succession work can preserve that separation. |
| OBS-07 | **observability/tooling issue** | `DecisionTrace.TechnicalFallback` marked all 72 Mode-A score ties while `SemanticEvent.TechnicalFallback` remained zero. The same label therefore refers to different fallback domains on different trace objects. | Future role traces should avoid making a scoring tie look like a semantic resolution fallback in human summaries. No simulation semantic change is implied. |
| OBS-08 | **observability/tooling issue** | The long B1 narrative exhausted ordinary grain by cycle 14. That made the intended fresh support impossible, prevented reactivation, and also prevented one side of the intended compatible-loan control from executing. | Future learning narratives should be shorter or explicitly budget the lower-slice material horizon so ordinary maintenance does not silently replace the mechanism under study. |
| OBS-09 | **insufficient evidence** | This observation did not positively re-demonstrate the repaired “allocation identity alone does not cause fallback” connected-allocation case because P1's loan was already infeasible. | Keep the accepted repair-v4 verification as the evidence for that property; do not claim this observation independently reproduced it. |

No finding is classified as an implementation defect or verification blind spot.

## 3. Mode A — autonomous reachability

The autonomous run completed 12 stable cycles without fault.

Mechanical counts:

- 72 personal decisions;
- 72 `Farm` selections;
- 72 `Farm` semantic events;
- 72 consumption events;
- 0 qualifying support events;
- 0 communication events;
- 0 Household formations;
- 0 participation transitions;
- 0 lifecycle transitions;
- 0 lineage events;
- 0 provision commitments;
- final CandidateRecognition: `Unknown` for P1–P6.

The first decision trace shows the immediate reason. For P1, `Farm`, gifts, requests, loans, favours, and reciprocal-help candidates were all eligible with total score 0. The reference scorer therefore resolved a tie by its deterministic candidate key ordering and selected `Farm`. The same high-level pattern persisted through the run.

The missing voluntary behaviors are therefore identifiable in this world: the reference policy never selected the qualifying lower-level support needed across multiple cycles and never selected the communication needed to distribute that evidence to the candidate founders. The Slice-3 formation machinery was not reached.

All 72 personal decision traces had `TechnicalFallback=true` because of selection ties. No semantic event had `TechnicalFallback=true`. These are different trace domains and should not be conflated.

## 4. Mode B1 — formation, recognition, participation, continuity, lifecycle, provision

### Formation and founder recognition

Two ordinary gifts were committed on cycles 1 and 2. P3 then communicated the cycle-2 support fact to P1 and the cycle-1 support fact to P2.

On cycle 4, the last communication was followed by:

- three `CandidateRecognitionEstablished` events;
- `HouseholdFormation` E40 for H1;
- founder sustaining-participation records;
- `HouseholdRecognitionAcquired` E44 for P1, P2, and P3.

E40 directly cites the candidate-recognition events and the two support events. The formation is mechanically explainable from raw history without reconstructing a hidden Household input.

### Entry and continuity

P1 communicated H1 recognition to P4. P1 then provided post-formation support to P4. P4's participation request through P1 committed on cycle 7.

The resulting continuation event cited both the participation transition and the prior formation. The new continuation recognition was acquired by the direct transition participants P1 and P4. It was not broadcast to all other current participants.

Founder exits then produced an explicit continuation chain:

- P1 exit → continuation warrant 5;
- P2 exit → continuation warrant 7;
- P3 exit → continuation warrant 9.

The numerical Household remained H1 throughout. After P3 exited, P4 was the sole sustaining participant and H1 became `Inactive`.

### Stale recognition and accepted update route

After the founder exits, P4 was still structurally the sole bearer but did not directly acquire every founder-exit continuation merely by being current.

P3, who directly participated in the cycle-16 transition, held the latest continuation evidence and communicated it to P4 on cycle 17. P4 then communicated that evidence to P5 on cycle 18. The raw evidence retains the hop chain P3→P4→P5.

This is causally legible only when evidence identity/origin/hops are inspected. A status-only view shows `Recognized` both before and after the update and therefore cannot explain freshness.

### Residence/admission dependency and fallback

On cycle 12, P6's residence invitation moved P5 to D2. P5's same-cycle request to enter H1 through P2 was then invalidated at resolution with `HouseholdResidenceUnavailable`.

The residence transition E132 and invalidation E133 both have `TechnicalFallback=true`.

P5 was not a member before that cycle, yet the residence action was consequential to the admission. This is a concrete ordinary-history example of why dependency grouping cannot be limited to already-current Household participants.

### Inactive and dissolution

The intended fresh support P4→P5 on cycle 19 was infeasible because P4 had no available grain. P5's cycle-20 reactivation request therefore returned `PostFormationSupportUnavailable`.

This run did **not** positively test reactivation. It did continue through a clean dissolution path:

- P4, the sole bearer, exited on cycle 21;
- H1 changed from `Inactive` to `Dissolved`;
- direct dissolution evidence was acquired only by P4.

At the stable dissolved state:

- P4's H1 recognition status was `Unknown` after its direct dissolution evidence;
- P1, P2, P3, and P5 retained stale positive H1 recognition;
- P6 had no H1 recognition.

The runner's original assumption that P5 would possess a dissolution fact was therefore wrong. That harness failure was informative: the actual acquisition boundary was narrower and more causal than the narrative shortcut.

### Provision backing and derived capacity

The single manifest-authorized controlled prerequisite was an active provision commitment for P1 after P4's entry.

Mechanical checkpoints:

| Checkpoint | P1 grain | P1 exposed capacity | Active commitment | H1 mobilizable capacity |
|---|---:|---:|---|---:|
| after controlled prerequisite | 3 | 1 | yes | 1 |
| after P1 personal gift | 1 | 0 | yes | 0 |
| after next cycle | 0 | 0 | yes | 0 |
| after P1 exit | 0 / NeedsGrain | 0 | no | 0 |

The capacity moved because personal state changed and because backing terminated on participation exit. No Household spending action was introduced.

### Material-horizon interference

By cycle 13, all six people had grain 0. From then on the narrative accumulated missed-consumption events. This lower-slice maintenance dynamic was valid runtime behavior, but it made later B1 steps poor positive controls for mechanisms that require fresh material support.

In particular:

- the cycle-9 “compatible connected loans” step did not become a two-commit control: P1 was already unable for insufficient grain while P2 committed;
- the fresh support required for positive reactivation could not be produced.

These are limitations of this observation narrative, not demonstrated Slice-3 defects.

## 5. Mode B2 — controlled lineage

The second assisted narrative was deliberately shorter.

H1 formed from the same two-cycle support/evidence chain. P1 and P2 then exited, leaving H1 `Inactive` with P3.

Fresh post-exit gifts P1→P2 and P2→P1 committed on cycles 7 and 8. A fresh inert candidate referent for P1/P2 was declared, and the next ordinary closure formed H2.

The lineage event E100 recorded:

- successor H2;
- kind `DivisionDescendant`;
- predecessor H1;
- cause H2 formation E96;
- both founder participation-end events E54 and E64;
- both fresh support events E76 and E86.

No lineage result was fixture-written. No technical fallback appeared in this narrative.

## 6. Causal-legibility audit

| Question | Result from raw history |
|---|---|
| Why did H form? | **Legible.** Formation cites candidate-recognition and support events. |
| Why did it remain the same numerical H through turnover? | **Legible.** Transition and continuation warrants retain H1 plus previous/transition references while associations change. |
| Why did an actor recognize or fail to recognize H? | **Legible with provenance, weak with status alone.** Direct acquisition and communication hops explain freshness; status alone hides stale-vs-updated positive recognition. |
| Why did lifecycle change? | **Legible.** Sole-bearer state produced `Inactive`; terminal exit produced `Dissolved`, with direct causal events. |
| Why did lineage classify? | **Legible.** The lineage event cites formation, predecessor exits, and fresh evidence. |
| Where did provision capacity come from? | **Legible.** Active commitment plus current exposed personal capacity are directly visible in snapshots/checkpoints. |
| Why did technical fallback appear? | **Legible for the residence/admission conflict.** The two consequential outcomes are explicitly marked. Positive allocation-noise suppression was not independently exercised here. |

The main observability weakness is not missing causal data; it is that a human summary based only on recognition status or a single generic “fallback” field can erase distinctions already present in the detailed evidence.

## 7. Slice-4 / later implementation lens

The observation supports implementation constraints, not new accepted role semantics:

- **Actor-specific recognition provenance should survive into role work.** Structural position should not imply that an actor observed every authority transition.
- **Dependency grouping must look beyond current holders.** A person who is not yet a member/role holder can still be causally affected by a same-cycle prerequisite change.
- **Stable Household identity is a useful anchor.** Turnover and lineage remained separate from H identity; later roles can reference H without rebuilding it from membership.
- **Resource backing and authority should remain separate.** Derived provision capacity changed through personal state without any Household spending authority.
- **Role/succession explanations will need evidence freshness, not just status.** Communication hops were necessary to explain who had current evidence.
- **Observation scenarios for role work should be short.** Otherwise ordinary maintenance can dominate the intended authority transition before the relevant step.

These points do not select a head model, succession rule, representative action set, or role-recognition semantics.

## 8. Roadmap effect

There is **no demonstrated reason to interrupt the roadmap before Slice 4**.

No conformance regression, persistence/identity inconsistency, new missing consequential Slice-3 rule, implementation defect, or verification blind spot was observed.

The strongest new learning is architectural:

1. current autonomous reachability is narrow because of the reference policy;
2. Household evidence entitlement is deliberately actor-causal and must stay visible when authority is layered on top;
3. stable identity/warrant interfaces are cleaner than reconstructing institutional state from membership;
4. dependency analysis must include prospective actors, not only current members;
5. long causal narratives need tighter material-horizon control.

The one fallback sub-question not positively exercised by this observation is explicitly retained as **insufficient evidence**, not converted into a new claim.
