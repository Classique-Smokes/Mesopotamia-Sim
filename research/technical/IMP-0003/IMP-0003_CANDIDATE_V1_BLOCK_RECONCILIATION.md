# IMP-0003 Candidate-v1 — Independent Conformance BLOCK Reconciliation

**Status:** MASTER ARCHITECT RECONCILIATION / REPAIR REQUIRED  
**Date:** 2026-09-23  
**Frozen candidate ref:** `imp-0003-slice3-conformance-candidate-v1`  
**Frozen candidate SHA:** `6b9d40e33b94d9094c02fe3d9f026914dd7986ec`  
**Independent review:** `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_FRESH.md`  
**Review result:** **BLOCK — IMPLEMENTATION / VERIFICATION DEFECT**  
**Promotion recommendation:** **DO NOT PROMOTE**

## 1. Bottom line

The independent reviewer found two confirmed blockers and one additional epistemic overreach.

No missing Director-level social semantic or architectural decision is required.

Candidate-v1 remains immutable and must not be changed or promoted.

Repairs belong on a successor implementation branch and must return through a new immutable candidate + fresh independent conformance review.

## 2. Confirmed blocker B1 — participation oracle inadequacy

**Accepted.**

The candidate's production participation gates are not the primary defect. The independent participation-warrant checker is too permissive.

Reviewer-owned corrupt-witness probes demonstrated that the checker accepts:

- missing Recognition evidence;
- fabricated/nonexistent/future support evidence with wrong endpoints;
- an unrelated earlier `Response: Accept` event as the participation acceptance.

This means the supposed independent oracle is not independently reconstructing the ParticipationWarrant claim strongly enough.

### Required repair

The checker must independently bind a ParticipationWarrant to actual recorded evidence and reconstruct the relevant precommit state without calling production Household classifiers/validators under judgment.

At minimum it must verify:

- the exact named Request/Invite proposal and proposal ID;
- newcomer and named bridge/counterpart identities;
- the actual acceptance response belongs to that proposal and counterpart;
- required newcomer + bridge Household Recognition bases are present, recognized, and grounded in valid provenance;
- each cited support is a real qualifying committed ordinary support event;
- support endpoints include newcomer and a valid current participant/bridge as required;
- support occurs after H formation and before participation commit;
- cited residence/tie evidence is valid at the applicable precommit state;
- no fabricated/nonexistent event ID can satisfy the oracle.

Add detached corrupt-witness regressions equivalent to reviewer P17/P18/P19 and require them to reach and fail the independent checker.

Do not repair this by calling `HouseholdRules` or production participation validation as the oracle.

## 3. Confirmed blocker B2 — rule/configuration provenance coupling

**Accepted.**

The candidate derives response/decision `RulesVersion` from the literal scenario configuration label:

`initial.Configuration.Version == "SFL-S3-v1"`

while Household semantics remain executable under other caller configuration labels.

The reviewer demonstrated that a custom scenario configuration can execute valid Slice-3 Household participation while the response trace claims `SFL-S2-v1`.

That violates truthful rule/configuration provenance.

### Required repair

Separate active semantic-rule identity from scenario/configuration naming.

Required outcome:

- Household response/event/warrant traces report the actual Slice-3 rule set exercised, independent of arbitrary caller scenario label spelling;
- existing genuine Slice-2 execution/tests retain truthful Slice-2 provenance;
- do not mechanically relabel all historical/inherited execution as S3;
- scenario configuration identity remains separately recorded where appropriate.

Add a custom-label Household participation case showing response/event/warrant provenance remains truthful and mutually consistent.

Exact implementation factoring is local engineering discretion.

## 4. Additional defect C1 — continuation evidence must not broadcast by sustaining status

The review did not count this as an independent blocker because the accepted source boundary required interpretation.

Master Architect reconciliation closes that interpretation from accepted authority.

SPEC §6.4 grants automatic knowledge for events/proposals an actor **directly participates in**.

SPEC §7.5 requires at least one historical bridge and that the bridge recognize the successor as the same H.

It does **not** grant every current `SustainingParticipant` automatic knowledge of every continuation reaction.

Candidate-v1 currently records every current sustaining participant as a participant in `HouseholdContinued` and refreshes Household Recognition for all of them. This lets mere current-participant status become an epistemic broadcast route.

### Required repair

Continuation evidence acquisition must be limited to actors whose direct participation/evidence entitlement is established by the actual transition/warrant.

At minimum:

- current sustaining status alone must not refresh Household Recognition;
- bridge/newcomer/transition parties may acquire/update only where their direct participation is grounded in the causal transition;
- remote current bearers who did not directly participate retain stale Recognition until accepted communication or another valid direct route updates them;
- do not invent generic observation entitlement.

Add a regression equivalent to reviewer P20: a remote current bearer who neither participates in the entry nor receives communication must not receive the newer continuation basis solely because H continued.

If repair discovers an actor class whose entitlement cannot be uniquely determined from accepted direct-participation/communication rules, stop and escalate rather than generalizing.

## 5. What the reviewer cleared

Candidate-v1 otherwise received substantial independent support for:

- formation downstream of lower-level evidence + founder Recognition;
- no hidden universal membership authority;
- both participation directions and runtime prerequisite gates;
- participation-end non-erasure;
- continuity/founder turnover/broken bridge/same-cycle handoff;
- dissolution/no resurrection;
- continuity-over-duplicate-formation precedence;
- Household Recognition conflict/gating generally;
- controlled division/consolidation and negative controls;
- lineage nonauthority;
- provision backing/capacity/no treasury/no spending;
- reaction closure/idempotence;
- dependency grouping and semantic bridge priority;
- S1-084 trigger remaining unfired;
- frozen authority integrity and scope deferrals.

These findings reduce repair scope but do not authorize promotion before fresh conformance.

## 6. Candidate-v1 status

Keep:

- `imp-0003-slice3-conformance-candidate-v1` @ `6b9d40e33b94d9094c02fe3d9f026914dd7986ec`

immutable as failed reviewed evidence.

Do not move the ref.

## 7. Next action

Dispatch:

`tasks/implementation/IMP-0003_CANDIDATE_V1_BLOCK_REPAIR_PACKET.md`

on successor branch:

`implementation/imp-0003-slice3-repair-v2`

After bounded repair and exact-head CI:

1. freeze a new immutable candidate ref;
2. commission a fresh independent conformance reviewer;
3. do not reuse the candidate-v1 reviewer as implementation author;
4. promote only on **PASS — PROMOTE**.
