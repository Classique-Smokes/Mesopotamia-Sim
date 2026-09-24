# SID Retrospective Screen — Slice 3

**Status:** COMPLETE — retrospective screen only  
**Policy lens:** `SID-ASSURANCE-v1` / DEC-0012  
**Role:** independent review scribe  
**Authority:** advisory triage only; this report does not reopen or modify frozen Slice-3 authority

## 1. Historical boundary verification

This screen used the requested historical boundary:

- prior world: verified Slice 1 + verified Slice 2;
- Slice-1 frozen authority: `SFL-V0-S1-ACCEPTANCE-v1` / `sfl-v0-slice1-acceptance-v1`;
- Slice-2 frozen authority: `SFL-V0-S2-ACCEPTANCE-v1` / `sfl-v0-slice2-acceptance-v1`;
- Slice-3 frozen acceptance: `SFL-V0-S3-ACCEPTANCE-v1` / `sfl-v0-slice3-acceptance-v1`;
- Slice-3 freeze commit: `25160f33c994fd5f3e277ae98f03e55d37c878dd`;
- frozen Slice-3 manifest blob: `1aae13dc27572361fe99c31ef8aee0444d39364a`;
- final implementation candidate: `imp-0003-slice3-conformance-candidate-v4` at `b5e5409ebcaec856a74ab08a7d120a67f6078e36`;
- final independent conformance: `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V4.md`;
- final completion/promotion record: `research/technical/IMP-0003/IMP-0003_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`.

The accepted Slice-3 specification state was read at the frozen Slice-3 ref, together with the canonical formation, continuity/turnover, lineage, Recognition/information, provision-grounding, no-self-confirmation, resolution/reaction, determinism, and cross-cutting verification material. Applicability was taken from the frozen Slice-3 manifest rather than from later functionality present elsewhere in the full SFL specification.

Historical discipline was preserved:

- no current Slice-4 SID pilot material was inspected;
- no Slice-4 behavior was treated as a missing Slice-3 requirement;
- the independent interaction frontier below was constructed before consulting the Slice-3 implementation-review defect history;
- the Slice-3 future-lessons index was not used to generate the frontier.

The frozen prior boundaries are also materially preserved by Slice 3's completion contract: the Slice-3 manifest binds the exact 128 REQUIRED Slice-1 rows and 46 REQUIRED Slice-2 rows, and the final candidate reexecuted all 174 before independent promotion review.

## 2. Retrospective trigger

**Semantic-interaction-delta trigger: FIRED —** Slice 3 introduced persistent Household identity, participation/continuity/lifecycle, actor-specific Household Recognition, lineage, and provision commitments on top of existing person-level relations, subjective knowledge, personal grain/NeedsGrain, ordinary support events, and the central resolver. Those additions can materially touch existing paths through identity/lifecycle, knowledge entitlement, transition carryover, personal resources, causal interpretation of prior events, and resolution/fallback behavior.

The fact that the trigger would have fired is not by itself a reason to reopen Slice 3. The retrospective question is whether a concrete consequential interaction remains insufficiently closed by frozen acceptance plus final conformance evidence.

## 3. Independent interaction-risk frontier

| New Slice-3 surface | Existing Slice-1/2 surface at risk | Concrete retrospective question | Screen disposition |
|---|---|---|---|
| Formation from lower-level history | Gift/help, loan, favour fulfilment; residence; kinship/marriage/attitude; CandidateRecognition | Can reification reinterpret, consume, mutate, or self-confirm the old person-level causes that made formation possible? | **Closed.** Formation is downstream of committed ordinary evidence; `S3-001..015` require independent reconstruction, inert candidates, no primitive Household ingress, and a closed ordinary-support census. `S3-080` requires the causal chain rather than a terminal snapshot. The final implementation records ordinary support evidence and creates separate warrants/associations without rewriting the lower-level event or relation. |
| Participation entry/exit and lifecycle | Residence, kinship, marriage, debt, favour, attitude, histories, ordinary proposals | Can joining/leaving/dissolving H erase old state, make old capabilities newly Household-dependent, or use residence/overlap as hidden membership? | **Closed.** `S3-027..029` explicitly make exit end only the typed sustaining association, preserve old relations/history, and keep residence independent. Complete-turnover evidence deliberately creates pre-existing debt/favour and verifies their survival. Lifecycle is a stable-closure projection of current sustaining associations, not a rewrite of the lower-level fabric. |
| Continuity | Old identity/reference and transition semantics | Can endpoint similarity, residence, graph overlap, or stable IDs silently become continuity authority? | **Closed.** `S3-030..039`, the turnover/broken-bridge witnesses, and final corruption probes require explicit warrant transmission, allow complete founder turnover, reject similar endpoints without a bridge, prevent resurrection, and quarantine stable-ID fallback. |
| Household Recognition | Slice-2 KnownFact/Recognition/provenance/staleness/communication | Can current engine-side Household state become global knowledge, or can Household Recognition overwrite the pre-existing epistemic rules? | **Closed.** `S3-040..049` plus inherited R01/R02 preserve objective/subjective separation, stale knowledge, actor-specific provenance, Contested handling, communication rules, and no passive synchronization. Ordinary person-person actions remain available independently of Household Recognition. |
| Lifecycle transitions and knowledge carryover | Direct-participant knowledge and stale subjective state | Can a transition inform uninvolved actors merely because they remain/currently were participants, or strand/erase previously held knowledge? | **Closed.** Recognition is updated only through accepted direct-participation or communication provenance. Final source and probes distinguish the direct parties to a causal transition from remote/uninvolved current or former participants; stale recognition may persist until valid newer evidence arrives. |
| Lineage / DerivedFrom / AncestorOf | Debt, favour, resource ownership, residence, Recognition, pending process, identity | Can ancestry become a hidden transfer/inheritance mechanism for old causal state? | **Closed.** `S3-060..064` and the lineage family make lineage behaviorally inert: it transfers no resources, claims, obligations, authority, Recognition, roles, residence, attitudes, pending processes, lifecycle, or numerical identity. `DerivedFrom` and transitive ancestry are rebuildable projections of the authoritative warrant history. |
| Provision commitment/capacity | Personal grain ownership and `NeedsGrain` | Can Household backing pool/confiscate grain, penetrate the existing reserve/need semantics, or make participation itself material authority? | **Closed.** `S3-070..077` preserve personal ownership, expose `max(0, grain-2)`, force zero capacity for `NeedsGrain`, deny material access from participation alone, terminate backing on exit/dissolution without confiscation, and explicitly exclude Slice-3 spending/debit execution. |
| Same-PersonId positions | Cardinality, response/initiative, provenance, resource identity | Can aliasing collapse semantically distinct positions and create self-authorization, duplicate effects, or double-counting? | **Closed for the Slice-3 surface.** Formation requires distinct founders/core identities. Participation requires a nonparticipant newcomer and a current bridge, so newcomer=bridge cannot satisfy the entry predicate. The intentional bridge=exiting-person handoff is explicitly ordered and tested. Provision backing is keyed to one person/Household/current association and does not spend grain in Slice 3. No separate Household initiative exists. |
| Derived Household projections | Slice-1/2 cache/non-authority and observer invariants | Can participant counts, lifecycle, capacity, lineage, or reporting caches become hidden behavior-affecting authority? | **Closed.** `S3-074`, `S3-083`, `S3-089`, `S3-093`, R07, and the final source/structural audit preserve warrant/association authority and rebuild derived projections. The inherited `S1-084` structural check remained unchanged and the new Household authority partition was separately inventoried. |
| Household-aware central resolution | Existing ordinary action ordering, revalidation, technical fallback | Can merely sharing/possessing Household state make otherwise compatible old person-level actions acquire a new social priority, invalidation, or fallback dependency? | **Historically suspicious, now closed.** This was a real implementation risk: earlier candidates produced false fallback from detached allocation identities, including Household-connected ordinary actions. Candidate v4 normalizes nonsemantic detached allocations while retaining consequential Household/evidence identity. Final reviewer probes showed compatible disconnected and Household-connected ordinary loans/favours remain jointly committable without false fallback, while genuine noncommutation still produces disclosed fallback. |

This frontier is deliberately narrower than the full SFL action catalogue. It follows the old surfaces that Slice 3 can actually read, write, classify, gate, carry across transition, or place into a shared resolution component.

## 4. Suspicious omissions / regressions

No presently unclosed Slice-3 omission or regression was established.

After freezing the frontier above, the historical implementation-review lineage was consulted as a closure check. It is probative because the earlier candidates exposed failures in the same frontier rather than merely reporting green tests:

- candidate v1 over-broadcast continuation evidence to uninvolved current sustaining participants and had an underpowered participation-warrant oracle;
- candidate v2 still had incomplete independent Formation/exit-continuation/lineage warrant reconstruction and false fallback labeling from detached allocation identity;
- candidate v3 still allowed Household-connected compatible ordinary loans to acquire false fallback and under-verified lifecycle event/time plus exact Recognition evidence identity;
- candidate v4 received a fresh whole-candidate review after those repairs rather than a repair-only review.

Those defects are not reasons to reopen the final candidate; they are evidence that the interaction surfaces were capable of failing and were independently exercised until the final candidate closed them.

The final review's own probes directly stress the retrospective frontier, including:

- missing founder Recognition;
- both participation directions and their prerequisites;
- broken continuity bridge and complete turnover;
- sole-bearer same-cycle handoff;
- no resurrection after dissolution;
- outsider unknown-until-communication;
- Contested Recognition under arrival permutation;
- lineage predecessor/source controls and rebuild/non-use;
- provision capacity across grain boundaries and `NeedsGrain`, with no personal debit from commitment itself;
- observer noninterference and nonsemantic ID renaming;
- connected/disconnected compatible ordinary actions versus genuine conflicts;
- lifecycle and exact Recognition-evidence corruption rejection.

The reviewer reported 28 probe categories and 423 explicit reviewer assertions with zero failed categories, in addition to the frozen acceptance execution.

## 5. Frozen acceptance versus final implementation/conformance

The frozen Slice-3 manifest already contains most of the protections a SID review would demand for this boundary:

- explicit new-to-old causal controls rather than only positive Household examples;
- transition non-erasure;
- objective/subjective Household Recognition separation;
- continuity versus duplicate formation;
- lineage noninheritance;
- personal-grain/provision separation;
- derived-state nonauthority;
- locality, observer noninterference, ID-renaming, iteration and fallback quarantine;
- exact inherited regression bundles for the old Slice-1/2 semantics.

This matters more than the historical absence of the SID label. The substance of the relevant interaction frontier was already made omission-detectable in the frozen acceptance authority.

The final independent conformance was also stronger than generated acceptance labels alone. It:

- inspected all modified production and Slice-3 acceptance surfaces;
- independently audited all 96 Slice-3 REQUIRED rows;
- confirmed the 11 DEFERRED and 2 UNEXERCISED rows remained unchanged;
- confirmed/reexecuted the exact inherited 128 Slice-1 + 46 Slice-2 REQUIRED sets;
- checked fixture boundaries and independent oracles with corruption challenges;
- inspected scheduler/fallback behavior and performed fresh reviewer-owned interventions;
- confirmed the inherited `S1-084` authority check was not weakened;
- confirmed no later-slice implementation was pulled into Slice 3;
- verified exact candidate/CI/artifact identity.

The exact reviewed candidate was then promoted without implementation/test drift, and post-promotion canonical CI passed.

## 6. Old Slice-1/2 capability erasure, retargeting, or unauthorized dependency

### Accidental erasure

None established.

The strongest direct evidence is not merely aggregate regression status: Slice 3 reexecuted every prior REQUIRED row, while its own dedicated non-erasure witness carries pre-existing debt/favour through complete Household turnover and keeps residence/kinship independent of participation. The Household exit path writes the typed association/commitment state rather than deleting lower-level relations.

### Causal retargeting

None established.

Ordinary person-person support remains ordinary support after it contributes evidence to formation; formation does not retroactively convert its meaning. Household Recognition gates Household-specific participation while ordinary person-person actions remain independent of that Recognition. Lineage does not retarget predecessor claims/resources/Recognition to a successor. Provision commitment reads personal resource state without changing ownership or creating a pooled Household resource.

### New dependency

One implementation-level dependency deserved special scrutiny: once Household state exists, the central resolver may place otherwise ordinary actions into a Household-aware dependency component because participants share Household scope. That is acceptable only as a conservative analysis mechanism; it must not create new social coupling.

Earlier candidates demonstrated the danger through false fallback. The final candidate's semantic projection normalization plus independent connected-action probes establish that the dependency analysis no longer turns shared Household association or incidental allocation order into semantic conflict for the exercised ordinary actions. Genuine old-resource/epistemic noncommutation remains detectable. Together with the full inherited regression set and generic structural projection logic, there is no concrete residual evidence that an old capability is now accidentally Household-dependent.

## 7. Screen conclusion

Had `SID-ASSURANCE-v1` existed before Slice-3 acceptance, its trigger should have fired. A proper frontier would have included exactly the kinds of interaction checked here: lower-level support becoming formation evidence, typed participation crossing old relations, Household-specific epistemics, transition carryover, lineage noninheritance, person-backed capacity, aliasing, derived-state authority, and resolver/fallback leakage.

However, the retrospective screen does not identify a consequential frontier item that is both plausible in the historical Slice-3 scope and insufficiently closed by frozen acceptance plus final independent conformance. The strongest candidate for a closer look — Household-aware resolution accidentally changing ordinary person-level action semantics — was an actual pre-promotion defect class, was repaired, and received targeted independent probes on the final whole candidate.

This is a bounded screen, not a proof over every possible history. New concrete evidence of an old-action regression, unauthorized Household dependency, epistemic broadcast, or fallback contamination would justify reopening the relevant narrow frontier. On the evidence now available, there is no such residual trigger.

**NO CLOSER LOOK NEEDED**
