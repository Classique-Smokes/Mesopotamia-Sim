# SID Retrospective Screen — Slice 2

**Status:** COMPLETE — advisory retrospective screen  
**Policy lens:** `SID-ASSURANCE-v1` / DEC-0012  
**Role:** independent review scribe  
**Authority:** advisory triage only; this report does not reopen or alter Slice-2 authority

## 1. Question and conclusion

Had `SID-ASSURANCE-v1` existed when Slice 2 introduced actor-specific subjective knowledge, bounded CandidateRecognition, communication, and subjective communication gating over the verified Slice-1 world, the semantic-interaction-delta trigger would have fired.

That historical trigger does **not** by itself establish a reason to run a full retrospective SID audit now. I found no concrete unclosed interaction, accidental Slice-1 regression, or unauthorized retargeting of an old capability after independently reconstructing the interaction frontier and then checking it against the frozen acceptance authority, the exact implementation candidate, and the fresh independent conformance evidence.

**Retrospective trigger: FIRED.**

`Semantic-interaction-delta trigger: FIRED — Slice 2 added actor-specific epistemic state, communication, subjective accessibility gates, initiative competition, direct-participant knowledge acquisition, and commit-time epistemic revalidation that can materially interact with already-executable Slice-1 action and response paths.`

## 2. Historical-boundary verification

This screen used the requested historical boundary rather than current later-slice behavior.

- Prior accepted Slice-1 boundary: `sfl-v0-slice1-acceptance-v1`, freeze commit `55377cc34b8bc3ccbf9cdf5029e9791dae965987`, frozen manifest blob `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`.
- Slice-2 frozen acceptance: `sfl-v0-slice2-acceptance-v1`, freeze commit `88f876298852553d6afca76e743a5a811ff9f0fd`, frozen manifest blob `e4872531cf780d51fa1863f2a0b87e2424a71b69`.
- Final Slice-2 implementation candidate: `imp-0002-slice2-conformance-candidate-v1`, commit `5a452078c845b8aa4cc2756f5638517dce87e6e8`.
- Final completion record: `research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`. It records promotion commit `3887d1d9984f5606c816afb84365cc3f455f52b4` and states that the promoted tree is byte-identical to the reviewed candidate tree.
- The Slice-1 freeze record establishes the frozen prior acceptance authority; the Slice-2 freeze record establishes that the operative acceptance body was unchanged from the independently reviewed candidate.
- Governance and the task packet were read from dispatch ref `sid-retro-screen-slices1-3-v1`; historical semantic judgments were tied to the frozen Slice-1/Slice-2 refs above.

Anti-anchoring discipline was preserved. I formed the interaction-risk frontier from the frozen semantic/verification boundary and implementation surfaces before reading the later independent conformance/completion evidence. I did not inspect Slice-3 or Slice-4 semantics as Slice-2 requirements, did not inspect the current Slice-4 SID pilot, and did not use the Slice-2 future-lessons index.

## 3. Independent interaction-risk frontier

| New/changed Slice-2 surface | Existing Slice-1 capability/path at risk | Independent concern | Screen finding |
|---|---|---|---|
| Subjective state attached to personal deliberation | Farm, gift/help, loan/repay, favour, direct marriage, Residence actions | Old candidates might silently require new knowledge/Recognition | Preserved. Existing candidate generation and gates continue to use the bounded Slice-1 personal input boundary. The added epistemic gate applies to `CommunicateClaim`; ordinary person-person actions are not made Recognition-dependent. |
| Communication as an ordinary voluntary action | One personal initiative per actor/cycle | New communication could either be free or accidentally erase response autonomy | Intentional shared-capacity interaction. Successful communication uses the existing one-personal-initiative budget. Responses remain separate, consume no personal initiative, and receipt creates neither a response context nor a fresh same-cycle activation. |
| Direct-participant/direct-party epistemic acquisition | Existing response/failure/action execution | Learning an outcome might become authority, alter feasibility, or recursively trigger action | Preserved. Acquisition writes the separate epistemic layer after valid participation/commit/failure; current-cycle personal/response decisions read the common pre-resolution snapshot. No automatic reactivation follows receipt/acquisition. |
| Subjective selection plus objective execution | All accepted Slice-1 action meanings | “Knows” might become permission to bypass world validity/feasibility | Preserved. Objective invalidity, feasibility, central conflict resolution, and immediate revalidation remain authoritative. Communication additionally revalidates that the sender still holds the captured claim before commit. |
| Stale / Contested Recognition | Existing person-person actions and decision policy | Stale or Contested state might suppress unrelated older actions | No material suppression found. Contested/Unknown state gates communication of the Recognition proposition under Slice 2; unrelated ordinary actions continue on their prior inputs. Negative attitude or unrelated refusal does not erase Recognition. |
| Failure knowledge and provenance | `Declined`, `Unable`, `InvalidatedAtResolution` and Slice-1 privacy | Epistemic expansion might leak resolver-private state or turn invalid terms into social knowledge | Preserved. Invalid terms do not enter participant learning; valid direct participants learn bounded outcomes/reasons. Frozen `S1-073` and Slice-2 `S2-013` explicitly regression-bind privacy. |
| Provenance / evidence precedence | Existing causal history and deterministic resolution | Sender ID, evidence ID, delivery order, or observer history might become causal authority | No retargeting found. Underlying semantic evidence order controls the bounded precedence cases; message arrival and IDs do not select a Recognition winner. Objective history is not treated as actor knowledge. |
| Same-cycle communication versus old direct-party state change | Debt/repayment and other participant-updating actions | An old action could invalidate a sender’s captured proposition, creating an unclassified new↔old conflict | Real interaction, but already closed operationally. The candidate detects the dependency, preserves the common decision snapshot, revalidates the held proposition at commit, and can produce `InvalidatedAtResolution(PropositionNoLongerHeld)` with technical fallback disclosure. |
| Participant alias/overlap | Initiative accounting, direct participation, provenance | Sender/recipient/direct participant overlap might double-count initiative or mutate current-cycle cognition | No concrete old-world regression found. The material overlap case—an actor communicating while an old action changes sender/recipient direct-party evidence—is covered by the dependency/revalidation path. Communication to self is rejected by the ordinary counterparty-validity boundary and does not remove a pre-existing Slice-1 capability. |
| CandidateRecognition itself | Authority/capability boundaries | “Recognized” might silently confer organization/household powers | Not present in Slice 2. The one candidate referent is explicitly inert; CandidateRecognition is evidence-backed subjective state used for bounded communication accessibility, not Household identity, office authority, or material capability. |

The frontier is therefore compact: personal initiative, legacy personal candidate availability, response autonomy, direct-participant knowledge/privacy, central revalidation, same-cycle communication/action dependency, provenance ordering, and participant overlap. No broader later-slice household/role frontier belongs to this retrospective screen.

## 4. Concrete suspicious omissions or regressions

No concrete unclosed omission or regression was established.

The most suspicious interaction found independently was the same-cycle case where an actor selects communication from the common decision snapshot and an existing Slice-1 action changes the direct-party fact on which the outgoing message was based before the message commits. That is genuine new↔old noncommutativity rather than a merely theoretical risk.

It is nevertheless not an unclassified hole:

- the candidate captures the sender-held evidence at decision time;
- old objective action execution remains authoritative;
- the dependency projection identifies the potentially noncommuting pair;
- live commit-time `StillHolds` revalidation can invalidate the message as `PropositionNoLongerHeld`;
- the original personal decision trace is retained rather than rewritten as a refusal or a different choice;
- fresh independent conformance exercised both orders and found the expected contrast.

The other initially suspicious surfaces also resolve without an unclosed frontier:

- epistemic state does not replace the established Slice-1 personal-input membrane for old actions;
- Recognition does not become attitude, approval, obedience, Household authority, or capability;
- communication uses rather than enlarges the personal-initiative budget;
- response processing remains independent of personal initiative and communication receipt;
- valid failure knowledge remains participant-bounded and privacy-bounded;
- stale/Contested Recognition does not become a general veto on older person-person actions;
- provenance determines bounded evidence precedence without changing objective world truth.

## 5. Comparison with frozen acceptance authority

Although Slice 2 predates the formal SID policy, its frozen acceptance authority already covers the material frontier unusually closely.

The manifest requires, among other things:

- objective/subjective separation and no passive synchronization;
- direct-party/direct-participant acquisition with bounded failure privacy;
- factual and Recognition communication through the ordinary personal-action pipeline;
- communication initiative cost;
- recipient-only delivery, no response activation, and no same-cycle reactivation;
- stale-state retention and explicit evidence-order cases;
- `Contested` with no ID/arrival winner;
- subjective communication gates before scoring;
- actual subjective inputs in decision traces;
- objective revalidation after subjective candidate selection;
- read noninterference/determinism.

It also binds exact Slice-1 regressions rather than relying on a generic “old tests still pass” claim. Of particular relevance to this screen are `S1-070` / `S1-GLOBAL-KNOWLEDGE`, `S1-073`, `S1-098-CORE`, and `S1-105`, covering failure meaning/participant knowledge, failure privacy, one-personal-initiative plus multiple responses, and coexistence of personal initiative with incoming response.

The frozen deferrals also keep the boundary honest: generic nonparticipant observation, a universal factual-conflict algebra, richer communication motivation, trust/lying/rumor/reputation, Household/head Recognition action gates, role succession Recognition, checkpoint epistemics, rich memory decay, and role-conditioned salience were not silently pulled into Slice 2.

## 6. Comparison with independent conformance evidence

The fresh independent conformance review reached the same boundary from the exact candidate, after recording its own provisional judgment before consulting coder reports or prior conformance output.

Relevant corroboration is stronger than a green-test summary:

- all four canonical commands passed on the exact candidate;
- all **46/46** REQUIRED Slice-2 rows passed;
- all **18/18** exact Slice-1 regression bindings passed;
- all **9/9** Slice-2 deferrals remained deferred;
- the reviewer inspected every modified production/acceptance surface;
- reviewer-owned public-boundary probes executed **143 assertions across 12 cases covering all 13 mandatory probe areas**;
- the reviewer specifically challenged communication initiative/no-reactivation, direct-vs-reported precedence, arrival order, Contested Recognition, unrelated attitude/refusal, observer noninterference, and same-cycle sender-fact invalidation;
- no semantic escalation, implementation blocker, later-slice leakage, fixture defect, or oracle defect was established.

The completion record then promoted the exact reviewed tree and records successful post-promotion verification. There is therefore no candidate drift that would reopen this screen’s evidence basis.

## 7. Old-world projection

Embed a Slice-1 scenario into Slice 2 with no communication selected and no CandidateRecognition-dependent communication requested.

The old person-person candidate families remain generated from the prior bounded inputs: own state, direct-party relations/claims, and explicit laboratory observations already admitted by Slice 1. Their action-specific gates remain their prior objective/direct-party gates. The new epistemic store is attached for communication accessibility and trace evidence; it is not a universal prerequisite for Farm, gift/help, loan/repay, favour, direct marriage, or Residence actions.

Responses still arise from valid incoming proposals, do not consume the target’s personal initiative, and remain subject to objective feasibility and central resolution. Direct acquisition adds subjective records after the corresponding accepted world/participant event; it does not make those records the authority for the objective commit.

Accordingly, no old Slice-1 capability appears accidentally suppressed, retargeted, or made dependent on new epistemic state without authority.

There is one deliberate narrowing of what an actor can do **in the same cycle after choosing the new communication action**: communication consumes the actor’s already-existing one voluntary personal initiative. That is an accepted interaction with the old initiative budget, not an accidental regression. It does not consume or cancel response contexts.

## 8. Recommendation

A full retrospective SID audit would currently duplicate interaction work that the frozen acceptance manifest and a genuinely fresh post-implementation reviewer already performed over the material Slice-1↔Slice-2 frontier. The historical trigger would have fired, but the screen found no consequential unresolved or accidental gap that needs a deeper audit now.

A closer look would become warranted only if new evidence shows that an old person-person capability has begun consulting epistemic/Recognition state, that direct-participant acquisition changes action feasibility rather than policy accessibility, that participant overlap causes double initiative/effects or privacy leakage, or that later modification materially changes this exact historical frontier. None of those conditions is established at the frozen/promoted Slice-2 boundary reviewed here.

**NO CLOSER LOOK NEEDED**
