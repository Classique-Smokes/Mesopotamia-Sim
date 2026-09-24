# IMP-0003 independent whole-candidate conformance review — candidate v4

**Verdict: PASS — PROMOTE**
**Recommendation: PROMOTE** exact candidate `b5e5409ebcaec856a74ab08a7d120a67f6078e36`. This is a conformance recommendation; this review does not merge, promote, or change the implementation.

No material semantic, architectural, acceptance-coverage, fixture, oracle, inherited-regression, or scope defect was established. No semantic escalation is required. The conclusion combines accepted authority, source and assertion inspection, independent interventions, canonical execution, and corroborating exact-head CI. Generated PASS labels alone were not used as proof.

## Identity, authority, and independence

Repository: `Classique-Smokes/Mesopotamia-Sim`. Candidate ref: `refs/heads/imp-0003-slice3-conformance-candidate-v4`. Canonical base: `77f3d1dd9630401ff6bba0b38283a823e26d2a01`. The immutable dispatch packet was read first at [packet commit 5ad518d](https://raw.githubusercontent.com/Classique-Smokes/Mesopotamia-Sim/5ad518da651dafe62c8c6cda7ca7d3c4c943ccb1/tasks/implementation/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V4_PACKET.md).

Review used a fresh detached checkout of the exact candidate. An existing local repository supplied Git objects to the clone only; its working tree and prior task judgments were not adopted. No subagent or prior candidate reviewer was used. The reviewer did not author an IMP-0003 implementation or repair. The candidate ref and all three frozen refs were checked remotely before substantive review and again after testing; all remained exact. The candidate tracked tree remained clean. SPEC, accepted ADRs, and all three frozen manifests have an empty base-to-candidate diff.

Frozen identities were checked using remote refs and Git blob identities at both the frozen commit and candidate:

| Authority / frozen ref | Freeze commit | Manifest Git blob |
|---|---|---|
| SFL-V0-S1-ACCEPTANCE-v1 / sfl-v0-slice1-acceptance-v1 | 55377cc34b8bc3ccbf9cdf5029e9791dae965987 | efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766 |
| SFL-V0-S2-ACCEPTANCE-v1 / sfl-v0-slice2-acceptance-v1 | 88f876298852553d6afca76e743a5a811ff9f0fd | e4872531cf780d51fa1863f2a0b87e2424a71b69 |
| SFL-V0-S3-ACCEPTANCE-v1 / sfl-v0-slice3-acceptance-v1 | 25160f33c994fd5f3e277ae98f03e55d37c878dd | 1aae13dc27572361fe99c31ef8aee0444d39364a |

The controlling authority read included AGENTS.md, 00_START_HERE.md, CURRENT_PHASE, SPEC-SFL-0001 (particularly Household, information, provision, temporal and invariant rules), accepted ADR-0001 through ADR-0005, IMP-0003 task, three manifests/freeze records, and the FORMATION, CONTINUITY_TURNOVER, LINEAGE, RECOGNITION_INFORMATION, PROVISION_GROUNDING, NO_SELF_CONFIRMATION, RESOLUTION_REACTION, DETERMINISM_RECOVERY_EXPLAINABILITY families and CROSS_CUTTING_VERIFICATION_CONTRACT. Working designs and reports were not promoted to authority.

The provisional independent judgment was fixed at `2026-09-23T23:35:40.5888893-03:00`, after source review, canonical tests, and independent probes, before reading IMP-0003 implementation/repair reports or remote CI metadata/artifacts. The saved provisional file SHA-256 is `3face1fd64bae49ad4dd858654d38c132a643b82284659379fe0dfeeb4a2b4a0`. It supported PASS subject to exact-head CI and final identity checks. The packet itself disclosed earlier defect categories and claimed CI identities; repair-labelled tests and runtime/test README descriptions were necessarily visible as source under review. These are contamination disclosures, not independent proof. Prior IMP-0003 review/reconciliation verdicts and PR #62 narrative were not consulted. Implementation and repair reports were consulted only afterward for corroboration; their generated tables did not determine this judgment.

## Canonical verification

Unchanged candidate root; .NET SDK **10.0.401**. Executed once in the prescribed order:

| Command | Result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | exit 0 |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | exit 0, no output/change |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | exit 0; 0 warnings, 0 errors |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | exit 0; 10 passed, 0 failed, 0 skipped; 31.614 seconds |

The ten test entries are aggregate runner tests, not a claim that only ten semantic scenarios exist. Their emitted exact-ID bindings and scenario bodies were examined separately. Test output was generated in ignored evidence locations; no tracked candidate file was modified.

## Whole-candidate source and architecture findings

All modified production files and all new/modified Slice-3 acceptance surfaces were inspected, including HouseholdProjection.cs, which is consequential to v4. Runtime/test README and CI changes were checked. The exact v1→v2 repair diff was also inspected: `6b9d40e33b94d9094c02fe3d9f026914dd7986ec` → `69ae753da2e05450766a9042ac6958fa7aa0b3e7`. Review did not stop at that repair or the v3/v4 defect categories.

**Formation and authority.** HouseholdState owns explicit persistent identities, associations, warrants and counters. Candidate referents are inert. Formation requires a live bounded candidate, at least two founders, common residence, connected durable ties, two qualifying ordinary supports in distinct cycles, and actor-held CandidateRecognition by every founder. Actual support events and founder-specific evidence are checked; a candidate label or objective graph cannot stand in for recognition. The canonical acceptance witness is the three-founder VS-SFL-001 causal schedule, not a two-person substitute. Earliest organizational evidence and reification time are distinct. No public FormHousehold mechanism, inferred universal membership cache, or hidden membership container supplies authority. The qualifying support-kind census is closed and excludes Household-produced support.

**Participation and continuity.** Both Request and Invite use truthful Slice-3 action/response/event provenance even with a custom scenario label; ordinary actions retain Slice-2 provenance. Immediate precommit revalidation checks recognition, bridge participation, bilateral acceptance, current residence/ties and post-formation support. A residence/admission race can change the winner through disclosed unresolved-order fallback, but not through input enumeration. Exit creates explicit historical warrant/association state; it does not erase ordinary ties or prior history. Continuation requires a real previous warrant and recognized current bridge, rather than similar endpoints. Complete founder turnover is possible through transmission. The same-cycle sole-bearer handoff orders its dependent entry before that bearer's exit; it is not a blanket entry priority.

**Lifecycle and epistemics.** Active/Inactive/Dissolved is published at stable closure using 2+/1/0 participants. Dissolution is terminal for that numerical identity; later formation gets a new identity. Lifecycle event, Household subject, state, cycle and reaction index must match the actual latest applicable publication. Recognition is actor-held and provenance-bearing. Outsiders and remote uninvolved current bearers are not passively synchronized. Earlier leavers can retain stale recognition; direct participants or accepted communication update it. Incompatible incomparable evidence remains Contested with no arbitrary evidence-ID winner and blocks the participation gate. Attitude is independent of the factual recognition route.

**Lineage.** Division/consolidation require explicit ended predecessor participation and fresh ordinary organizational evidence, with the required predecessor lifecycle conditions. An already-Dissolved division source is excluded; unrelated current H4 history does not enter consolidation's exact predecessor set. Enumeration produces zero or one interpretation; ambiguity withholds lineage without withholding an otherwise valid Household formation. Direct DerivedFrom and transitive AncestorOf remain distinct, rebuildable and behaviorally inert. No identity, debt, office, provision or recognition inheritance is inferred from lineage. The repeated predecessor rejoin/re-exit source algorithm remains explicitly outside the implemented slice.

**Provision.** Only the narrow controlled commitment-state fixture seam is present. Commitments remain person-backed, terminate on participation end/dissolution, and expose derived capacity. NeedsGrain yields zero; otherwise capacity protects reserve 2 and is bounded by personal grain. There is no pooled Household treasury, contributor debit/ranking execution, household spending proposal, endogenous solicitation, or head authority. Querying capacity does not move grain.

**Scheduler and dependencies.** Dependency components include relevant persons, explicit Household targets, historical Household associations/candidate cores, and Household communication. Disconnected ordinary components retain the ordinary resolver. Household-relevant commutativity checks use detached copies and real commit/learning/debt/attitude/Household closure paths, with the narrow bridge-handoff order constraint. HouseholdProjection causally normalizes ordinary event/relation/evidence allocation identities so independent allocations are not mistaken for semantic conflicts. It retains Household/warrant/association identity, semantic outcomes, evidence content and consequential same-subject precedence. Scratch probes verify disconnected and connected compatible loans, connected favours, and genuine capacity/communication/favour-debt noncommutation. Neither every permutation receiving fallback nor every case commuting is accepted. Detached exploration does not consume live counters. Closure is cause-keyed, bounded and checked before publication; intentional skipped closure fails the guard.

**S1-084 trigger: UNFIRED.** WorldState's existing inventory and CrossCuttingScenarios.cs (including the old structural checker) are byte-for-byte unchanged against the canonical base. New explicit Household authority is separately inventoried; the existing exact private-field check is not weakened or reinterpreted. Derived Household projections do not become an undisclosed source of behavior.

Inherited high-risk verification inspected included the unchanged CrossCuttingScenarios, InvariantOracle, FixtureAudit, AcceptanceCatalog/AcceptanceTests, Slice2Scenarios/Slice2AcceptanceTests and the relevant agency, pipeline, marriage/residence paths. Exact inherited binding checks supplement these source checks; they do not replace them.

## Fixture, producer, and oracle findings

The Slice-3 fixture artifact has 123 resolved fixture records, each with zero endogenous Household fixture writes and PASS independent warrant audit. Declared lower-level people, residence, kinship, attitudes, knowledge, inert candidates, inputs, proposal schedules, controlled writes and output identities are retained. Fixture code was checked rather than trusting these summaries. The canonical three-founder producer establishes the formation chain through ordinary events and actor evidence. Participation, continuity and lineage subjects are runtime-produced. Controlled evidence acquisition/commitment setup is used only where that mechanism is not the subject under test, is declared, and does not inject Household identities or warrants as the expected conclusion.

The producer surface has 132 rows: 88 VS-SFL-001 bindings and 44 BoundedOrdinaryFormation bindings. These are repeated producer/binding records, not 132 independent canonical formation witnesses. Producer IDs, acceptance IDs, configuration, lower-level-only audit and output identities were cross-checked with fixture/scenario execution. Detached corruption controls are not silently installed as authoritative initial state.

HouseholdOracle.cs and HouseholdWarrantOracle.cs independently reconstruct expected facts from initial declarations, actual event/history records, actor-held epistemic evidence and snapshots. They do not invoke production HouseholdRules, TryForm, TryLineage, ContinueHousehold, ordinary-support or recognition classifiers as expected-answer oracles. Token-based dependency checks in the runner are supporting evidence only; source inspection and actual corruption rejection carry the independence finding. Observer-only acquisition receipts preserve the precise retained EvidenceId and provenance; they do not allocate authority/IDs or feed policy. Valid stale and same-cycle bases pass while fabricated retained, direct and communicated IDs fail the actual checker.

Independent probes link the unchanged actual checker source as the target under attack. Corruption tests count rejection only when AssertFailedException comes from that checker; unrelated exceptions do not count. Formation, participation, exit-continuation, lineage, lifecycle and epistemic identity corruptions were rejected while corresponding valid controls passed. There is no separately reimplemented permissive checker substituted for the actual verifier.

## Reviewer-owned probes

All probe source and output are outside the candidate in reviewer scratch. A separate .NET console harness references the unchanged Release production assembly through its existing test-access boundary and links the two actual oracle sources. Worlds are independently constructed from lower-level persons, residence, ties and known facts; ordinary gifts/support over separate cycles and communication produce the tested Household state. Most probes use an eight-person controlled world with ample grain so unrelated subsistence does not obscure the intervention. Some boundary probes deliberately reduce grain or install declared commitment/held-report fixtures. The probe three-founder positive is an additional witness, not a replacement for canonical VS-SFL-001.

Final run: **28 categories, 423 explicit reviewer assertions, zero failed categories**. Internal oracle assertions are additional and excluded from that count. P01–P24 correspond to every mandatory packet category; P25–P28 expand ablations and corruptions. A scratch-only compile error from assigning an init-only property was corrected by constructing the input record correctly; no candidate edit was made. All final results below are from the completed corrected harness.

| Probe | Assertions | Setup / independent intervention and result |
|---|---|---|
| P01 | 4 | Formation with objective residence/ties/two-cycle support but one missing founder recognition does not form H; three-founder positive. PASS. |
| P02 | 8 | Independent Request and Invite entries commit and satisfy the actual oracle. PASS. |
| P03 | 16 | Residence/admission race under swapped proposal IDs and input order; immediate invalidation and disclosed winner dependence. PASS. |
| P04 | 4 | Broken bridge cannot transmit old identity despite similar resulting membership. PASS. |
| P05 | 48 | Sole-bearer handoff across all eight ID/input/world-order variants; entry precedes exit, no fallback, identity retained, Inactive closure. PASS. |
| P06 | 5 | Dissolved identity never reactivates; later formation creates a different identity. PASS. |
| P07 | 4 | Outsider remains Unknown until accepted communication. PASS. |
| P08 | 8 | Controlled sender-held incomparable report, both arrival orders: Contested result, blocked entry, actual oracle. PASS. |
| P09 | 8 | Division live-predecessor positive and already-Dissolved negative. PASS. |
| P10 | 14 | Consolidation exact unordered two-source set; unrelated H4 excluded; reversed world order. PASS. |
| P11 | 7 | Detached lineage projection removal/rebuild; paired later trajectories and histories equal; behavioral non-use source checked. PASS. |
| P12 | 13 | Grain 1/2/3/11 crossed with NeedsGrain; reserve arithmetic independently computed; no personal debit; exit terminates commitment. PASS. |
| P13 | 3 | 100 repeated observer reads preserve exact subsequent history and identifiers. PASS. |
| P14 | 6 | Non-order-preserving person ID renaming (200-n) preserves mapped formation/entry results. PASS. |
| P15 | 2 | Action vocabulary lacks head/office/provision spending action; no treasury state. PASS. |
| P16 | 10 | Custom configuration label: Request, Invite and ordinary loan coexist with truthful action-specific rule provenance. PASS. |
| P17 | 4 | Remote uninvolved current bearer retains old recognition basis across another entry, then updates through communication. PASS. |
| P18 | 8 | Valid formed/entered/exited/division snapshots; detached bad support, tie, acceptance, bridge and lineage event rejected by actual checker. PASS. |
| P19 | 40 | Disconnected H with two compatible ordinary loans: eight ID/input/world permutations, both committed, no fallback, two debts, oracle. PASS. |
| P20 | 18 | Real capacity, communication/repayment and favour/debt conflicts in both orders retain disclosed fallback. PASS. |
| P21 | 40 | Household-connected compatible loans across eight permutations retain both commits without fallback. PASS. |
| P22 | 32 | Household-connected compatible favour allocation across eight permutations remains free of false fallback. PASS. |
| P23 | 25 | Valid Active/Inactive/reactivated/Dissolved controls; nonexistent event, negative cycle, wrong microstep/kind/state lifecycle corruptions rejected. PASS. |
| P24 | 10 | Valid retained, same-cycle handoff and communicated recognition; fabricated EvidenceIds rejected in entries and continuation. PASS. |
| P25 | 56 | Both entry directions crossed with none/missing recognition/bridge/acceptance/residence/tie/support; exact rejection controls. PASS. |
| P26 | 9 | Duplicate-cause guard, continuity over duplicate formation, independent-evidence overlap, skipped closure prevents publication. PASS. |
| P27 | 4 | Valid two-Household state; another Household lifecycle event rejected. PASS. |
| P28 | 17 | Fifteen additional formation/entry/exit-continuation reference corruptions: stamp, candidate, earliest/evidence, support endpoint/cycle, tie, previous/transition/recognition. PASS. |

## Exact Slice-3 REQUIRED audit — 96 rows

The table is an exact full-ID census against the frozen manifest, with no prefix-count substitution, missing IDs, duplicate IDs or extra REQUIRED IDs. Obligation wording is retained from the immutable manifest-derived binding and source checked. Each case name below resolves to the inspected assertion path in the following locator table. Every case executed in the fresh canonical run; reviewer disposition additionally rests on the semantic findings and independent probes above. A bound case name alone is not the basis for PASS. R01–R11 are checked against the complete inherited sets, including frozen Slice-2 activated bindings for earlier deferred Slice-1 subjects.

| Exact REQUIRED ID | Frozen obligation | Executed assertion paths | Reviewer evidence / disposition |
|---|---|---|---|
| S3-001-FORMATION-POSITIVE | Canonical completion witness is `VS-SFL-001` three-founder formation, or a fresh-reviewer-approved semantically equivalent three-founder witness preserving its causal schedule, fixture restrictions, multi-founder evidence acquisition/communication, CandidateRecognition by all founders, automatic FormationWarrant→H→founding participation/Recognition chain, and stable closure. A two-founder smoke/cardinality case may not substitute for this architectural witness. | CanonicalThreeFounderCausalFormation; RepairV3DetachedFormationCorruptions | P01/P15/P26/P28; formation/authority source; PASS |
| S3-002-FOUNDING-CARDINALITY | One-person founding fails; two- and three-person cores may qualify when all other accepted conditions hold. | FoundingCardinalityAndPredicateAblations | P01/P15/P26/P28; formation/authority source; PASS |
| S3-003-FORMATION-RESIDENCE-ABLATION | Removing shared residence from an otherwise positive formation witness prevents formation. | FoundingCardinalityAndPredicateAblations | Exact inherited audit below; P13/P19–P22; PASS |
| S3-004-FORMATION-DURABLE-TIE-ABLATION | Removing connected durable-tie structure from an otherwise positive witness prevents formation. | FoundingCardinalityAndPredicateAblations | P01/P15/P26/P28; formation/authority source; PASS |
| S3-005-FORMATION-SUPPORT-COUNT-ORDER | One qualifying support event or two same-cycle support events do not satisfy two-distinct-cycle recurrence; two qualifying events on distinct cycles may. | FoundingCardinalityAndPredicateAblations | P01/P15/P26/P28; formation/authority source; PASS |
| S3-006-FORMATION-RECOGNITION-ABLATION | Missing required founder CandidateRecognition prevents formation even when objective graph/history facts are otherwise positive. | FoundingCardinalityAndPredicateAblations | Exact inherited audit below; P13/P19–P22; PASS |
| S3-007-CANDIDATE-NONAUTHORITY | Candidate ID/label/diagnostic presence is not evidence for CandidateRecognition, formation, Household identity, or continuity. | ExplicitAuthorityAndInertCandidateBoundary | P01/P15/P26/P28; formation/authority source; PASS |
| S3-008-NO-PRIMITIVE-HOUSEHOLD-INGRESS | No public/mechanism fixture ingress or privileged FormHousehold command directly creates H or accepted Household warrants. | ExplicitAuthorityAndInertCandidateBoundary | P01/P15/P26/P28; formation/authority source; PASS |
| S3-009-NO-HIDDEN-MEMBERS-AUTHORITY | No universal authoritative Members set, graph cluster, residence projection, kinship cluster, marriage cluster, or participant snapshot decides H identity. | ExplicitAuthorityAndInertCandidateBoundary | P01/P15/P26/P28; formation/authority source; PASS |
| S3-010-FORMATION-WARRANT-PROVENANCE | Independent reconstruction verifies founders, dwelling, durable ties, qualifying support events/cycles, founder Recognition evidence, earliest sustaining evidence, formation/reification time, and rule/configuration version. | CanonicalThreeFounderCausalFormation; IndependentOracleRejectsCorruptedWitness; RepairV3DetachedFormationCorruptions | P01/P15/P26/P28; formation/authority source; PASS |
| S3-011-EARLIEST-EVIDENCE-VS-REIFICATION-TIME | History distinguishes earliest retained sustaining-organization evidence from later Household formation/reification time. | CanonicalThreeFounderCausalFormation; RepairV3DetachedFormationCorruptions | Exact inherited audit below; P13/P19–P22; PASS |
| S3-012-FOUNDING-PARTICIPATION-PROVENANCE | Every founding SustainingParticipant association is provenance-bearing and supported by the FormationWarrant. | CanonicalThreeFounderCausalFormation; RepairV3DetachedFormationCorruptions | P01/P15/P26/P28; formation/authority source; PASS |
| S3-013-FOUNDERS-DIRECTLY-RECOGNIZE-H | Founders directly acquire Household existence Recognition from the formation event; no head/office state is required. | CanonicalThreeFounderCausalFormation; RepairV3DetachedFormationCorruptions | Exact inherited audit below; P13/P19–P22; PASS |
| S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY | Newly formed H has no occupied head and exposes no household-mode initiative or head-mediated effect merely because H exists. | CanonicalThreeFounderCausalFormation; RepairV3DetachedFormationCorruptions | P01/P15/P26/P28; formation/authority source; PASS |
| S3-015-QUALIFYING-SUPPORT-KIND-CENSUS | The closed qualifying ordinary person-person support set is omission-detectable wherever the shared predicate is used: accepted gift/help, loan provision, and favour fulfilment are each eligible; Household-originated support is excluded as independent formation/continuity/fresh-lineage evidence. Table-driven or structural coverage may establish the shared census without multiplying every scenario combination. | SupportMeaningClosedCensus | P01/P15/P26/P28; formation/authority source; PASS |
| S3-020-PARTICIPATION-ENTRY-POSITIVE | Independently exercise **both** accepted bilateral directions: `RequestHouseholdParticipation(H)` by the newcomer through a current sustaining participant, and `InviteHouseholdParticipation(P)` by a current sustaining participant. For each direction, newcomer Recognition + live recognizing bridge + shared residence + durable tie + qualifying post-formation support + named-counterpart acceptance produce ParticipationWarrant, SustainingParticipant, and required continuity reaction. | BothParticipationDirectionsAndPrerequisiteAblations; ImmediateRevalidationAndDisclosedTechnicalConflict; RepairB1DetachedParticipationCorruptionsP17P18P19; RepairB2CustomLabelHouseholdProvenance; RepairV4SameCycleCommunicatedIdentity; RepairV4RecognitionIdentity | P02/P03/P08/P16/P25/P28; entry revalidation; PASS |
| S3-021-PARTICIPATION-RECOGNITION-ABLATION | Removing newcomer H Recognition prevents valid entry. | BothParticipationDirectionsAndPrerequisiteAblations; RepairB1DetachedParticipationCorruptionsP17P18P19; RepairB2CustomLabelHouseholdProvenance | Exact inherited audit below; P13/P19–P22; PASS |
| S3-022-PARTICIPATION-BRIDGE-ABLATION | Removing the live continuity bridge prevents valid entry/continuation. | BothParticipationDirectionsAndPrerequisiteAblations | P02/P03/P08/P16/P25/P28; entry revalidation; PASS |
| S3-023-PARTICIPATION-BILATERAL-ABLATION | Missing the named counterpart's accepted bilateral participation response prevents valid entry. | BothParticipationDirectionsAndPrerequisiteAblations; RepairB1DetachedParticipationCorruptionsP17P18P19 | P02/P03/P08/P16/P25/P28; entry revalidation; PASS |
| S3-024-PARTICIPATION-RESIDENCE-ABLATION | Missing shared residence prevents valid entry. | BothParticipationDirectionsAndPrerequisiteAblations; ImmediateRevalidationAndDisclosedTechnicalConflict | Exact inherited audit below; P13/P19–P22; PASS |
| S3-025-PARTICIPATION-DURABLE-TIE-ABLATION | Missing durable tie prevents valid entry. | BothParticipationDirectionsAndPrerequisiteAblations | P02/P03/P08/P16/P25/P28; entry revalidation; PASS |
| S3-026-PARTICIPATION-POSTFORMATION-SUPPORT-ABLATION | Missing qualifying post-formation newcomer/current-participant support prevents valid entry. | BothParticipationDirectionsAndPrerequisiteAblations; RepairB1DetachedParticipationCorruptionsP17P18P19 | P02/P03/P08/P16/P25/P28; entry revalidation; PASS |
| S3-027-PARTICIPATION-END-WARRANT | Explicit EndHouseholdParticipation(H) commits ParticipationEndWarrant, ends only the typed sustaining association, and remains historically queryable. | CompleteTurnoverAndNonErasure | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-028-PARTICIPATION-END-NONERASURE | Participation end does not erase residence, kinship, marriage, debt, favour, attitude, or historical records. | CompleteTurnoverAndNonErasure; RepairV3DetachedExitContinuationCorruptions | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-029-RESIDENCE-NOT-PARTICIPATION | Residence change alone neither creates nor ends SustainingParticipant and does not create/destroy/split/merge H. | ResidenceDoesNotChangeParticipation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-030-EXIT-SIDE-CONTINUATION | If H continues after a participant exits, explicit exit-side ContinuationWarrant evidence carries historical transmission; endpoint similarity is insufficient. | CompleteTurnoverAndNonErasure; IndependentOracleRejectsCorruptedWitness; RepairB1DetachedParticipationCorruptionsP17P18P19; RepairC1RemoteBearerRetainsStaleRecognition; RepairV3DetachedExitContinuationCorruptions; RepairV4SameCycleRecognitionIdentity; RepairV4SameCycleCommunicatedIdentity; RepairV4RecognitionIdentity | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-031-COMPLETE-FOUNDER-TURNOVER | Every founder may exit through valid sequential transmission while H preserves the same numerical identity solely through the warrant chain. | CompleteTurnoverAndNonErasure; RepairV3DetachedExitContinuationCorruptions | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT | Removing a required bridge while preserving a superficially similar endpoint prevents inheritance of old H identity. | BrokenBridgeDissolutionAndNewIdentity | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-033-INACTIVE-STATE | Exactly one current sustaining participant yields Inactive only at stable closure; identity remains the same and no household-mode initiative exists. | InactiveReactivationAndSameCycleHandoff | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-034-INACTIVE-REACTIVATION | Inactive H reactivates only through valid ParticipationWarrant bridged by its sole bearer; same H returns Active and no duplicate H2 forms from the same evidence. | InactiveReactivationAndSameCycleHandoff; RepairV4SameCycleRecognitionIdentity | Exact inherited audit below; P13/P19–P22; PASS |
| S3-035-SAME-CYCLE-BRIDGE-HANDOFF | When newcomer entry depends on sole bearer A and A also has accepted same-cycle exit, bridged entry/continuity resolves before A exit; stable result is same H with newcomer sole bearer/Inactive, without transient dissolve/recreate semantics. | InactiveReactivationAndSameCycleHandoff; RepairV4LifecycleReferences; RepairV4LifecycleWrongHousehold | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-036-DISSOLUTION-STABLE-CLOSURE | Zero sustaining participants yields Dissolved only at stable cycle closure after compatible participation/continuity reactions finish. | BrokenBridgeDissolutionAndNewIdentity | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-037-DISSOLVED-NO-RESURRECTION | Dissolved H never reactivates as the same identity; later similar lower-level organization must form a new H if independently warranted. | BrokenBridgeDissolutionAndNewIdentity | Exact inherited audit below; P13/P19–P22; PASS |
| S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION | When the same causal evidence supports valid participation/continuity to an existing non-Dissolved H and superficially fresh formation, continuity/participation takes precedence and no duplicate FormationWarrant consumes the same causal bundle. | ContinuityEvidencePrecedenceAndIndependentOverlap | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP | Duplicate-precedence does not prohibit a separately warranted overlapping organization based on distinct causal evidence. | ContinuityEvidencePrecedenceAndIndependentOverlap | P04–P06/P17/P23/P24/P26/P28; continuity/closure; PASS |
| S3-040-HOUSEHOLD-RECOGNITION-DISTINCT | H existence/continuity Recognition remains distinct from objective H state, CandidateRecognition, KnownFact, attitude, approval, obedience, and later head Recognition. | HouseholdRecognitionRoutesAndStaleness | Exact inherited audit below; P13/P19–P22; PASS |
| S3-041-OUTSIDER-NO-PASSIVE-H-RECOGNITION | Uninvolved outsider remains Unknown absent an accepted acquisition route even though H exists objectively. | HouseholdRecognitionRoutesAndStaleness; DissolutionDoesNotInformEarlierSameCycleLeavers | Exact inherited audit below; P13/P19–P22; PASS |
| S3-042-H-RECOGNITION-CAUSAL-PARTICIPATION-GATE | With objective world held equal, newcomer Recognized H may make valid participation available while Unknown suppresses it. | BothParticipationDirectionsAndPrerequisiteAblations; RepairB2CustomLabelHouseholdProvenance | Exact inherited audit below; P13/P19–P22; PASS |
| S3-043-H-RECOGNITION-STALE-RETENTION | Turnover/lifecycle change does not passively synchronize an actor's Household Recognition. | HouseholdRecognitionRoutesAndStaleness; DissolutionDoesNotInformEarlierSameCycleLeavers; RepairC1RemoteBearerRetainsStaleRecognition | Exact inherited audit below; P13/P19–P22; PASS |
| S3-044-H-RECOGNITION-ACCEPTED-UPDATE-ROUTE | Household Recognition acquisition/update is exercised through accepted actor-held routes: an outsider/newcomer initially Unknown acquires `Recognized` H through provenance-bearing `CommunicateClaim/Inform` from a sender that actually holds the proposition; separately, newer valid same-H continuation evidence refreshes the actor's current positive H-recognition provenance. Engine/global H state is never evidence by itself. | HouseholdRecognitionRoutesAndStaleness; RepairC1RemoteBearerRetainsStaleRecognition | Exact inherited audit below; P13/P19–P22; PASS |
| S3-045-DISSOLUTION-RECOGNITION-ROUTE | Newer decisive dissolution evidence reaches the actor only through accepted direct-participation/communication provenance and makes an older positive `H exists/continues` basis no longer safely usable. The witness may resolve by accepted precedence or `Contested` as applicable; it must not invent a new negative Recognition enum or generic nonparticipant observation entitlement. | HouseholdRecognitionRoutesAndStaleness; DissolutionDoesNotInformEarlierSameCycleLeavers; RepairC1RemoteBearerRetainsStaleRecognition | Exact inherited audit below; P13/P19–P22; PASS |
| S3-046-H-RECOGNITION-NO-ID-WINNER | Household/stable/person IDs, container order, message arrival, engine-side H existence, or diagnostic history do not become arbitrary Recognition winner/evidence rules. | ContestedRecognitionAndArrivalPermutation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-047-H-RECOGNITION-INDEPENDENT-ATTITUDE | Holding accepted H evidence constant, unrelated attitude/compliance changes do not by themselves change Household Recognition. | HouseholdRecognitionRoutesAndStaleness | Exact inherited audit below; P13/P19–P22; PASS |
| S3-048-H-RECOGNITION-CONTESTED | Incompatible Household existence/continuity evidence with no accepted provenance/order dominance produces and retains `Contested`; sender/stable/Household IDs, arrival order, engine-side state, and diagnostic history do not select a winner. | ContestedRecognitionAndArrivalPermutation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-049-H-RECOGNITION-CONTESTED-GATE | With the same objective H and other participation prerequisites held equal, `Recognized` may satisfy the Household-recognition participation gate while `Contested` does not safely satisfy that gate. | ContestedRecognitionAndArrivalPermutation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-050-DIVISION-DESCENDANT | New H2 independently forms while predecessor H remains non-Dissolved; every H2 founder maps unambiguously to ended participation in H; fresh qualifying person-person support occurs after all cited exits; one DivisionDescendant LineageWarrant issues with predecessor set {H}. | DivisionPositiveFreshnessAndDissolvedExclusion; RepairV3DetachedLineageCorruptions | P09–P11/P18; lineage source and exclusions; PASS |
| S3-051-DIVISION-FRESHNESS-ABLATION | Missing/stale fresh evidence withholds division lineage classification without blocking otherwise valid ordinary formation. | DivisionPositiveFreshnessAndDissolvedExclusion | P09–P11/P18; lineage source and exclusions; PASS |
| S3-052-DIVISION-PREDECESSOR-CONTINUITY | Continuing predecessor H remains the same numerical H only through ordinary continuity; branch size/residence/assets/graph overlap do not decide continuation or lineage. | DivisionPositiveFreshnessAndDissolvedExclusion | P09–P11/P18; lineage source and exclusions; PASS |
| S3-053-CONSOLIDATION-DESCENDANT | H3 independently forms only after both H1/H2 are Dissolved for consolidation classification; founders map unambiguously to both predecessors; fresh post-dissolution cross-predecessor support exists; one ConsolidationDescendant LineageWarrant issues with unordered predecessor set {H1,H2}. | ConsolidationPositiveAndPredecessorControls; RepairV3DetachedLineageCorruptions | P09–P11/P18; lineage source and exclusions; PASS |
| S3-054-CONSOLIDATION-SURVIVOR-ABLATION | If a claimed predecessor remains Active/Inactive, controlled consolidation classification is withheld without blocking independently valid H3 formation. | ConsolidationPositiveAndPredecessorControls | P09–P11/P18; lineage source and exclusions; PASS |
| S3-055-CONSOLIDATION-FRESH-CROSS-SUPPORT-ABLATION | Missing fresh post-dissolution cross-predecessor support withholds consolidation classification without blocking ordinary formation. | ConsolidationPositiveAndPredecessorControls | P09–P11/P18; lineage source and exclusions; PASS |
| S3-056-LINEAGE-AMBIGUITY-WITHHOLDS-WARRANT | Equally valid predecessor-set/kind interpretation or ambiguous founder-source mapping produces no LineageWarrant rather than an ID-selected answer; H still forms normally. | AmbiguousDivisionAndConsolidationWithholdLineage | P09–P11/P18; lineage source and exclusions; PASS |
| S3-057-LINEAGE-SOURCE-PROVENANCE | Every founder-lineage source cites founder ID, predecessor H ID, and explicit supporting ParticipationEndWarrant. | AmbiguousDivisionAndConsolidationWithholdLineage; RepairV3DetachedLineageCorruptions | P09–P11/P18; lineage source and exclusions; PASS |
| S3-058-LINEAGE-ZERO-OR-ONE | Zero or one authoritative LineageWarrant exists per successor FormationWarrant. | DivisionPositiveFreshnessAndDissolvedExclusion | P09–P11/P18; lineage source and exclusions; PASS |
| S3-059-LINEAGE-DIRECT-EDGE-INVARIANTS | Direct lineage is irreflexive, acyclic, and temporally forward. | DivisionPositiveFreshnessAndDissolvedExclusion; TransitiveLineageRebuildPersistenceAndNoninterference; RepairV3DetachedLineageCorruptions | P09–P11/P18; lineage source and exclusions; PASS |
| S3-060-LINEAGE-NONAUTHORITY | Lineage transfers no resources, claims, obligations, authority, Recognition, roles, residence, attitudes, pending processes, lifecycle, or numerical identity and has no independent behavioral power. | DivisionPositiveFreshnessAndDissolvedExclusion; TransitiveLineageRebuildPersistenceAndNoninterference | P09–P11/P18; lineage source and exclusions; PASS |
| S3-061-DERIVEDFROM-REBUILD | DerivedFrom(successor, predecessor) is rebuilt solely from authoritative LineageWarrant rather than separate semantic authority. | DivisionPositiveFreshnessAndDissolvedExclusion; TransitiveLineageRebuildPersistenceAndNoninterference | Exact inherited audit below; P13/P19–P22; PASS |
| S3-062-DIRECT-VS-TRANSITIVE-ANCESTRY | Direct DerivedFrom and transitive AncestorOf remain distinguishable and independently reproducible. | TransitiveLineageRebuildPersistenceAndNoninterference | P09–P11/P18; lineage source and exclusions; PASS |
| S3-063-LINEAGE-PREDECESSOR-ORDER-METAMORPHIC | Reversing nonsemantic predecessor enumeration for consolidation preserves the unordered direct-predecessor result. | ConsolidationPositiveAndPredecessorControls | P09–P11/P18; lineage source and exclusions; PASS |
| S3-064-LINEAGE-PERSISTENCE-HISTORY | Committed LineageWarrant remains immutable/queryable within the run after predecessor or successor dissolution and retains rule/configuration version. | CompleteTurnoverAndNonErasure; TransitiveLineageRebuildPersistenceAndNoninterference; RepairV3DetachedExitContinuationCorruptions; RepairV3DetachedLineageCorruptions | P09–P11/P18; lineage source and exclusions; PASS |
| S3-066-DIVISION-PREDECESSOR-DISSOLVED-EXCLUSION | Hold ordinary H2 formation valid but make predecessor H Dissolved before H2 forms; no controlled `DivisionDescendant` LineageWarrant from H may issue. H2 remains a valid newly formed Household rather than being blocked by failure to classify lineage. | DivisionPositiveFreshnessAndDissolvedExclusion | P09–P11/P18; lineage source and exclusions; PASS |
| S3-067-CONSOLIDATION-UNRELATED-PREDECESSOR-EXCLUSION | Give a consolidation founder unrelated H4 participation/contact history that does not satisfy the controlled founder-lineage-source conditions for H3; H4 must not enter the LineageWarrant direct predecessor set and must not contaminate `{H1,H2}`. | ConsolidationPositiveAndPredecessorControls | P09–P11/P18; lineage source and exclusions; PASS |
| S3-070-PROVISION-COMMITMENT-BACKING-STATE | From declared controlled pre-existing valid commitment setup, H carries participant-backed commitment state without transferring ownership of personal grain and without head/office state. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-071-PROVISION-EXPOSED-CAPACITY | Independent arithmetic proves exposed capacity `max(0, grain - 2)` and freezes the reserve boundary for a non-`NeedsGrain` committed contributor at personal grain 1 / 2 / 3 => capacity 0 / 0 / 1 (a larger positive control may also be used). | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-072-PROVISION-NEEDSGRAIN-ZERO | At the same otherwise-positive grain where a non-`NeedsGrain` contributor exposes capacity, toggling `NeedsGrain` false→true forces exposed capacity to zero; include the canonical same-grain false/true comparison. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-073-NO-POOLED-HOUSEHOLD-TREASURY | Commitment/capacity creates no pooled Household grain balance and no grain movement before a later collective effect commits. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-074-MOBILIZABLE-CAPACITY-DERIVED | H mobilizable capacity rebuilds from currently valid commitments and current personal grain/need state; stale derived state cannot become authority. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT | Ending a participant's sustaining association terminates that person's commitment to H without confiscating personal grain. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-076-DISSOLUTION-TERMINATES-COMMITMENTS | H dissolution terminates its commitments; unspent personal grain remains personal. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-077-NO-SPENDING-AUTHORITY | Slice 3 backing/capacity exposes no household-originated expenditure, support, dowry, contributor debit execution, or household initiative; those remain Slice 4. | ProvisionBackingReserveNeedAndTermination | P12/P15; capacity and scope; PASS |
| S3-080-FORMATION-REACTION-CHAIN | Evidence records same-cycle causal chain from lower-level support/evidence through CandidateRecognition, FormationWarrant, H, founding participation, founder H Recognition, and stable publication; final snapshot alone is insufficient. | CanonicalThreeFounderCausalFormation; RepairV3DetachedFormationCorruptions | Exact inherited audit below; P13/P19–P22; PASS |
| S3-081-CAUSE-IDEMPOTENCE | Automatic Household/continuity/lifecycle/lineage reactions are cause-keyed/idempotent and one cause key cannot apply the same transition twice. | DuplicateCauseClosureAndSnapshotIsolation; RenamedTurnoverAndLineageTrajectories | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-082-REACTIONINDEX-MONOTONE | ReactionIndex remains monotone and preserves causal ordering without creating social priority among unrelated independent causes. | CanonicalThreeFounderCausalFormation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-083-DERIVED-REFRESH-CLOSURE | Later same-cycle automatic rules see earlier authoritative commits where required; stale behavior-affecting Household/lineage derived state cannot change formation/continuity/lifecycle/lineage result. | DuplicateCauseClosureAndSnapshotIsolation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-084-NO-MID-CLOSURE-PUBLICATION | No completed cycle, lifecycle summary, same-cycle voluntary reactivation, or stable checkpoint is published before resolution/reaction closure. | InactiveReactivationAndSameCycleHandoff; DuplicateCauseClosureAndSnapshotIsolation | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-085-NONSEMANTIC-ITERATION-METAMORPHIC | Permuting nonsemantic storage/input enumeration preserves representative formation/continuity/lineage semantic results. | IterationLocalityObserverAndIrrelevantAttributes; DisconnectedHouseholdDoesNotChangeContinuity; RepairV3DisconnectedHouseholdCompatibleLoans; RepairV4ConnectedHouseholdCompatibleLoans; RepairV4OtherOrdinaryAllocations | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-086-ISOMORPHIC-ID-RENAMING | Consistent isomorphic renaming of nonsemantic IDs preserves representative formation/continuity/Recognition/lineage results; stable ID never resolves candidate convergence, continuity, Recognition, or lineage ambiguity. | IsomorphicSemanticIdentityRenaming; RenamedTurnoverAndLineageTrajectories | Exact inherited audit below; P13/P19–P22; PASS |
| S3-087-LOCALITY | Adding disconnected unrelated actors/households does not alter an existing formation/continuity/lifecycle result. | IterationLocalityObserverAndIrrelevantAttributes; DisconnectedHouseholdDoesNotChangeContinuity; RepairV3DisconnectedHouseholdCompatibleLoans; RepairV4ConnectedHouseholdCompatibleLoans; RepairV4OtherOrdinaryAllocations | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-088-OBSERVER-NONINTERFERENCE | Household/continuity/lineage inspection and diagnostic reads do not alter later behavior, IDs, ordering, subjective state, or semantic history. | IterationLocalityObserverAndIrrelevantAttributes; DisconnectedHouseholdDoesNotChangeContinuity | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE | New participant-count, candidate, continuity, lifecycle, DerivedFrom/AncestorOf, provision-capacity, or reporting projections are either structurally absent as behavior-affecting caches or reproduce identically after discard/rebuild. | TransitiveLineageRebuildPersistenceAndNoninterference; DuplicateCauseClosureAndSnapshotIsolation | Exact inherited audit below; P13/P19–P22; PASS |
| S3-090-FALLBACK-QUARANTINE | Disclosed stable-ID fallback may resolve only explicitly accepted unresolved technical symmetry and is recorded; it cannot decide candidate equivalence, continuity, H Recognition, lineage ambiguity, or similar-endpoint identity. | InactiveReactivationAndSameCycleHandoff; ImmediateRevalidationAndDisclosedTechnicalConflict; RepairV3DisconnectedHouseholdCompatibleLoans; RepairV3DisconnectedHouseholdPositiveFallbackControls; RepairV4ConnectedHouseholdCompatibleLoans; RepairV4ConnectedHouseholdPositiveFallbackControls; RepairV4OtherOrdinaryAllocations | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-091-VERIFIED-PRODUCER-PROVENANCE | Any reused produced H/checkpoint-like verification state carries producer, pass result, fixture audit, authority/configuration version, and output identity. This is verification provenance, not engine checkpoint/restore. | DuplicateCauseClosureAndSnapshotIsolation; RepairV3DetachedFormationCorruptions; RepairV3DetachedExitContinuationCorruptions; RepairV3DetachedLineageCorruptions; RepairV4LifecycleReferences; RepairV4LifecycleWrongHousehold; RepairV4SameCycleRecognitionIdentity; RepairV4SameCycleCommunicatedIdentity; RepairV4RecognitionIdentity | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-092-TRACE-CONFIGURATION-TRUTH | Any Slice-3 personal/response decision context records actual subjective inputs, gates/components/result, and active rule/configuration version consistently with inherited trace semantics. | BothParticipationDirectionsAndPrerequisiteAblations; ImmediateRevalidationAndDisclosedTechnicalConflict; RepairB2CustomLabelHouseholdProvenance | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-093-STRUCTURAL-AUTHORITY-NONHIDING | Adding authoritative Household/warrant state preserves the semantic invariant behind S1-084: no hidden behavior-affecting derived authority. Any necessary lossless adaptation of an exact private-field-inventory regression is separately reviewed before coding; implementation may not delete/loosen it for convenience. | ExplicitAuthorityAndInertCandidateBoundary | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-094-IRRELEVANT-ATTRIBUTE-PERTURBATION | On representative new Slice-3 formation/continuity/lineage histories, perturb a specifically declared SPEC-irrelevant attribute while holding authoritative causal inputs fixed; the bounded semantic result remains unchanged. | IterationLocalityObserverAndIrrelevantAttributes; RenamedTurnoverAndLineageTrajectories | P03/P05/P11/P13/P14/P16/P18–P28; structural/temporal review; PASS |
| S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION | S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION; S2-002-KNOWNFACT-RETENTION; S2-003-KNOWNFACT-PROVENANCE-CENSUS; S2-004-RECOGNITION-DISTINCT; S2-005-RECOGNITION-TRISTATE-LIFETIME; S2-006-NO-PASSIVE-SYNC; S2-007-NO-HISTORY-OMNISCIENCE; S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R02-COMMUNICATION-PROVENANCE-STALENESS | S2-020F-FACT-COMMUNICATION-ACTION; S2-020R-RECOGNITION-COMMUNICATION-ACTION; S2-021F-COMMUNICATE-HELD-FACT; S2-021R-COMMUNICATE-HELD-RECOGNITION; S2-022F-NO-INVENTED-FACT; S2-022R-NO-INVENTED-RECOGNITION; S2-023F-FACT-COMMUNICATION-PROVENANCE; S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE; S2-024F-FACT-COMMUNICATION-INITIATIVE-COST; S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST; S2-025F-FACT-NO-FREE-BROADCAST; S2-025R-RECOGNITION-NO-FREE-BROADCAST; S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE; S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE; S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE; S2-030-STALE-FACT-PERSISTS; S2-031A-DIRECT-EVIDENCE-PRECEDENCE; S2-031B-REPORT-EVENT-PRECEDENCE; S2-032-MESSAGE-ARRIVAL-PERMUTATION; S2-033-CANDIDATE-RECOGNITION-CONTESTED; S1-098-COMMUNICATION; S1-META-08; S1-MUT-27; S1-MUT-28; S1-076. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R03-INITIATIVE-RESPONSE-ACCOUNTING | S1-098-CORE; S1-105; S2-024F-FACT-COMMUNICATION-INITIATIVE-COST; S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST; S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE; S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE; S2-044-OBJECTIVE-REVALIDATION-PRESERVED. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R04-OBSERVER-NONINTERFERENCE | S1-085; S1-META-04; S1-MUT-26; S2-050-EPISTEMIC-READ-NONINTERFERENCE. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R05-LOCALITY | S1-META-03; S2-008-LOCALITY. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R06-FALLBACK-ID-QUARANTINE | S1-081; S1-META-02; S1-GLOBAL-FALLBACK; S2-033-CANDIDATE-RECOGNITION-CONTESTED; S2-052-NONSEMANTIC-ITERATION-METAMORPHIC; S2-053-ISOMORPHIC-ID-RENAMING. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R07-CACHE-DERIVED-NONAUTHORITY | S1-084; S1-META-05; S1-MUT-24; S2-054-CACHE-NONAUTHORITY. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R08-STABLE-CLOSURE | S1-074-IDEMP; S1-MUT-22; S1-MUT-23; S1-090-D; S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE; S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R09-PERSON-LEVEL-SEMANTICS | S1-091-MEANING-SEPARATION; S1-093-GIFT-CONTROL; S1-093-KIN-GATE; S1-095-NO-RESIDENCE; S1-096-NO-HH; S1-096-MARRIAGE-CONTROL; S1-097-EVENTS; S1-MUT-04; S1-MUT-16; S1-MUT-17; S1-MUT-18; S1-MUT-19; S1-MUT-20; S1-MUT-21. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R10-TRACE-CONFIGURATION | S1-086; S1-MUT-29; S2-042-SUBJECTIVE-TRACE; S2-045-PINNED-POLICY-NONCLAIM; S2-055-CONFIGURATION-PROVENANCE. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |
| S3-R11-FROZEN-AUTHORITY-INTEGRITY | Slice-1 and Slice-2 frozen manifest version/blob/ref identities remain unchanged; no prior DEFERRED/UNEXERCISED status is rewritten; every prior REQUIRED AcceptanceId listed in the exact inherited expansion below is reported individually as executed/green rather than hidden behind one aggregate suite result. | ExactInheritedRegressionBindings | Exact inherited audit below; P13/P19–P22; PASS |

### Assertion source locators

Locators are relative to `tests/Mesopotamia.Sim.AcceptanceTests/` at the exact candidate. All scenarios also pass through suite fixture audit and the actual Household checker except explicit structural/inherited bindings where their own checker is the relevant path.


| Case | Source |
|---|---|
| AmbiguousDivisionAndConsolidationWithholdLineage | HouseholdLineageScenarios.cs:108 |
| BothParticipationDirectionsAndPrerequisiteAblations | HouseholdScenarios.cs:177 |
| BrokenBridgeDissolutionAndNewIdentity | HouseholdScenarios.cs:250 |
| CanonicalThreeFounderCausalFormation | HouseholdScenarios.cs:132 |
| CompleteTurnoverAndNonErasure | HouseholdScenarios.cs:195 |
| ConsolidationPositiveAndPredecessorControls | HouseholdLineageScenarios.cs:79 |
| ContestedRecognitionAndArrivalPermutation | HouseholdEpistemicScenarios.cs:37 |
| ContinuityEvidencePrecedenceAndIndependentOverlap | HouseholdEpistemicScenarios.cs:60 |
| DisconnectedHouseholdDoesNotChangeContinuity | HouseholdAdversarialScenarios.cs:38 |
| DissolutionDoesNotInformEarlierSameCycleLeavers | HouseholdAdversarialScenarios.cs:11 |
| DivisionPositiveFreshnessAndDissolvedExclusion | HouseholdLineageScenarios.cs:53 |
| DuplicateCauseClosureAndSnapshotIsolation | HouseholdStructuralScenarios.cs:29 |
| ExactInheritedRegressionBindings | Slice3AcceptanceTests.cs: inherited binding loop |
| ExplicitAuthorityAndInertCandidateBoundary | HouseholdStructuralScenarios.cs:12 |
| FoundingCardinalityAndPredicateAblations | HouseholdScenarios.cs:146 |
| HouseholdRecognitionRoutesAndStaleness | HouseholdEpistemicScenarios.cs:9 |
| ImmediateRevalidationAndDisclosedTechnicalConflict | HouseholdAdversarialScenarios.cs:20 |
| InactiveReactivationAndSameCycleHandoff | HouseholdScenarios.cs:227 |
| IndependentOracleRejectsCorruptedWitness | HouseholdAdversarialScenarios.cs:102 |
| IsomorphicSemanticIdentityRenaming | HouseholdStructuralScenarios.cs:77 |
| IterationLocalityObserverAndIrrelevantAttributes | HouseholdStructuralScenarios.cs:43 |
| ProvisionBackingReserveNeedAndTermination | HouseholdEpistemicScenarios.cs:73 |
| RenamedTurnoverAndLineageTrajectories | HouseholdAdversarialScenarios.cs:67 |
| RepairB1DetachedParticipationCorruptionsP17P18P19 | HouseholdRepairV2Scenarios.cs:10 |
| RepairB2CustomLabelHouseholdProvenance | HouseholdRepairV2Scenarios.cs:60 |
| RepairC1RemoteBearerRetainsStaleRecognition | HouseholdRepairV2Scenarios.cs:88 |
| RepairV3DetachedExitContinuationCorruptions | HouseholdRepairV3Scenarios.cs:59 |
| RepairV3DetachedFormationCorruptions | HouseholdRepairV3Scenarios.cs:20 |
| RepairV3DetachedLineageCorruptions | HouseholdRepairV3Scenarios.cs:87 |
| RepairV3DisconnectedHouseholdCompatibleLoans | HouseholdRepairV3Scenarios.cs:119 |
| RepairV3DisconnectedHouseholdPositiveFallbackControls | HouseholdRepairV3Scenarios.cs:166 |
| RepairV4ConnectedHouseholdCompatibleLoans | HouseholdRepairV4Scenarios.cs:11 |
| RepairV4ConnectedHouseholdPositiveFallbackControls | HouseholdRepairV4Scenarios.cs:74 |
| RepairV4LifecycleReferences | HouseholdRepairV4Scenarios.cs:53 |
| RepairV4LifecycleWrongHousehold | HouseholdRepairV4Scenarios.cs:108 |
| RepairV4OtherOrdinaryAllocations | HouseholdRepairV4Scenarios.cs:161 |
| RepairV4RecognitionIdentity | HouseholdRepairV4Scenarios.cs:182 |
| RepairV4SameCycleCommunicatedIdentity | HouseholdRepairV4Scenarios.cs:143 |
| RepairV4SameCycleRecognitionIdentity | HouseholdRepairV4Scenarios.cs:127 |
| ResidenceDoesNotChangeParticipation | HouseholdScenarios.cs:214 |
| SupportMeaningClosedCensus | HouseholdScenarios.cs:161 |
| TransitiveLineageRebuildPersistenceAndNoninterference | HouseholdLineageScenarios.cs:131 |

## Deferred and unexercised audit — 11 / 2

These are not executable PASS claims. Each remains at its frozen classification with no case binding; source/action/fixture review found no implemented dependency on its later-slice behavior. S3-065 is one of the 11 deferred rows, in addition to D01–D10. The repeated-predecessor guard preserves that boundary rather than implementing a general source algorithm. Generated bounded fixed scenarios do not claim the U01 infrastructure; JSON diagnostics do not claim U02 rendered explanation.

| Exact ID | Frozen classification | Obligation / reviewed boundary | Disposition |
|---|---|---|---|
| S3-065-NO-REPEATED-PREDECESSOR-SOURCE-GENERALIZATION | DEFERRED | Repeated predecessor rejoin/re-exit histories remain outside controlled v0 classifier; fire LATER-03 before accepting such histories. | Preserved; not claimed as exercised |
| S3-D01-CANDIDATE-CONVERGENCE | DEFERRED | General multi-label CandidateOrganization equivalence remains LATER-01; fire if implementation must merge/reconcile distinct candidate referents. | Preserved; not claimed as exercised |
| S3-D02-ACTOR-DEPARTURE | DEFERRED | Participation end is not world departure; fire LATER-02 only if actor departure becomes executable. | Preserved; not claimed as exercised |
| S3-D03-REPEATED-PREDECESSOR-PARTICIPATION | DEFERRED | Controlled lineage excludes repeated rejoin/re-exit predecessor histories; fire LATER-03 before admitting them. | Preserved; not claimed as exercised |
| S3-D04-HEAD-OFFICE | DEFERRED | Head appointment/vacancy/succession and head Recognition are Slice 4. | Preserved; not claimed as exercised |
| S3-D05-HOUSEHOLD-DECISION-MODE | DEFERRED | Separate household initiative/deliberation is Slice 4. | Preserved; not claimed as exercised |
| S3-D06-PROVISION-SOLICITATION-RECONSIDERATION | DEFERRED | Accepted endogenous acquisition/reconsideration path is head-scoped, Slice 4. | Preserved; not claimed as exercised |
| S3-D07-HOUSEHOLD-SPENDING | DEFERRED | Support, dowry, debit ranking/execution and provision priority are Slice 4. | Preserved; not claimed as exercised |
| S3-D08-MEDIATED-MARRIAGE-AUTHORITY | DEFERRED | Household-mediated marriage response/authority topology is Slice 4. | Preserved; not claimed as exercised |
| S3-D09-AUTHORITY-DESTROYING-RACE | DEFERRED | Requires executable head/authority state plus authority-dependent action, Slice 4. | Preserved; not claimed as exercised |
| S3-D10-CHECKPOINT-RESTORE | DEFERRED | Exact engine checkpoint/restore continuation and omission mutants are Slice 5. | Preserved; not claimed as exercised |
| S3-U01-GENERATED-HISTORY-INFRASTRUCTURE | UNEXERCISED | General generated/shrink framework is not a Slice-3 completion gate. If activated, VH-02 oracle-independence hardening fires first. | Preserved; not claimed as exercised |
| S3-U02-RENDERED-CAUSAL-EXPLANATION | UNEXERCISED | Rendered causal-explanation surface remains future unless separately activated. | Preserved; not claimed as exercised |

## Exact inherited audit — 128 Slice-1 and 46 Slice-2 REQUIRED IDs

The full required-ID sets were independently extracted from the frozen Markdown tables and compared to local and remote evidence. All 174 exact bindings are present once. The old manifests and their deferred classifications are unchanged. Slice-2 activated mappings are checked explicitly in the Slice-3 inherited binding logic; no generic prefix success substitutes for the full frozen required sets.

**Historical conformance distinction:** the raw Slice-1 runner deliberately leaves S1-GLOBAL-CONFORMANCE awaiting independent review and FullFrozenCompletionGate=false. Slice-3's inherited binding points to `research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md`, whose accepted completion and candidate `06e25644879dd8505e24fcaeb43256f69c29c15f` were read. Thus 127 Slice-1 executable obligations re-pass and one historical external-conformance obligation is preserved. It is not a newly executed coder test or a circular claim of this candidate's independent conformance. Slice-2 likewise leaves its new external-review status to the reviewer. This report supplies the present whole-candidate judgment.

### Slice 1 — 128 exact REQUIRED rows


| Exact ID | Executed scenario / preserved basis | Reviewer disposition |
|---|---|---|
| S1-090-A | ConsumptionAndFarm | PASS — reexecuted and exact binding retained |
| S1-090-B | ConsumptionAndFarm | PASS — reexecuted and exact binding retained |
| S1-090-C | ConsumptionAndFarm | PASS — reexecuted and exact binding retained |
| S1-090-D | GiftHelpMeaningsAndNeedClearing | PASS — reexecuted and exact binding retained |
| S1-090-E | ConsumptionAndFarm | PASS — reexecuted and exact binding retained |
| S1-091-GIFT | GiftHelpMeaningsAndNeedClearing | PASS — reexecuted and exact binding retained |
| S1-091-HELP | GiftHelpMeaningsAndNeedClearing | PASS — reexecuted and exact binding retained |
| S1-091-LOAN-OFFER | LoanRoutesAndRepaymentHistory | PASS — reexecuted and exact binding retained |
| S1-091-LOAN-REQUEST | LoanRoutesAndRepaymentHistory | PASS — reexecuted and exact binding retained |
| S1-091-BFF-POS | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-091-RMRH | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-091-MEANING-SEPARATION | DistinctTransferMeanings | PASS — reexecuted and exact binding retained |
| S1-092-PARTIAL | LoanRoutesAndRepaymentHistory; RepairAggregateDebtCapacity; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-092-AMOUNT-VALIDITY | RepaymentAmountAndReserve | PASS — reexecuted and exact binding retained |
| S1-092-RESERVE | RepaymentAmountAndReserve; RepairTransferShapesAndReserve; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-092-FULL | LoanRoutesAndRepaymentHistory | PASS — reexecuted and exact binding retained |
| S1-092-DUE | DebtDueAfterThirdFullCycle | PASS — reexecuted and exact binding retained |
| S1-093-BFF-POS | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-093-RECIP-74 | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-093-RECIP-75 | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-093-RECIP-76 | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-093-KIN-GATE | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-093-GIFT-CONTROL | GiftHelpMeaningsAndNeedClearing | PASS — reexecuted and exact binding retained |
| S1-093-BFF-FULL | FullFavourSlotDistinguishesBargainFromHelp | PASS — reexecuted and exact binding retained |
| S1-093-BFF-RACE | BargainCapacityRace; RepairFavourCreationProvenance | PASS — reexecuted and exact binding retained |
| S1-093-RMRH-FULL | FullFavourSlotDistinguishesBargainFromHelp; RepairFavourCreationProvenance | PASS — reexecuted and exact binding retained |
| S1-094-FARM-CALLABLE | CalledFarmSuccessRefusalAndInability; RepairCalledPayloadPrivateFeasibility | PASS — reexecuted and exact binding retained |
| S1-094-REPAY-CALLABLE | CalledRepaymentThirdPartyAndInvalidation; RepairFavourRetirementDependencies; RepairObservedDebtBoundary; RepairCalledPayloadPrivateFeasibility | PASS — reexecuted and exact binding retained |
| S1-094-PERSONAL-COEXIST | CalledFarmPersonalCoexistence | PASS — reexecuted and exact binding retained |
| S1-094-NONCALLABLE-MATRIX | CompleteCallFavorPayloadMatrix | PASS — reexecuted and exact binding retained |
| S1-094-NONPAYLOAD-MATRIX | CompleteCallFavorPayloadMatrix | PASS — reexecuted and exact binding retained |
| S1-094-UNABLE | CalledFarmSuccessRefusalAndInability | PASS — reexecuted and exact binding retained |
| S1-094-DECLINE | CalledFarmSuccessRefusalAndInability | PASS — reexecuted and exact binding retained |
| S1-094-INVALIDATED | CalledRepaymentThirdPartyAndInvalidation; RepairAggregateDebtCapacity; RepairTransferShapesAndReserve; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-094-SUCCESS | CalledFarmSuccessRefusalAndInability | PASS — reexecuted and exact binding retained |
| S1-094-NESTED-GUARD | CalledFarmSuccessRefusalAndInability | PASS — reexecuted and exact binding retained |
| S1-094-RECIP-CANCEL | ReciprocalCancellation; RepairFavourRetirementDependencies | PASS — reexecuted and exact binding retained |
| S1-095-POS | DirectMarriageBoundaries | PASS — reexecuted and exact binding retained |
| S1-095-74 | DirectMarriageBoundaries | PASS — reexecuted and exact binding retained |
| S1-095-KIN | DirectMarriageBoundaries | PASS — reexecuted and exact binding retained |
| S1-095-LIFETIME | MarriageDeclineAndLifetime | PASS — reexecuted and exact binding retained |
| S1-095-NO-RESIDENCE | DirectMarriageBoundaries | PASS — reexecuted and exact binding retained |
| S1-096-MOVE | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-096-INVITE | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-096-COMPETE | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-096-NO-HH | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-096-MARRIAGE-CONTROL | DirectMarriageBoundaries | PASS — reexecuted and exact binding retained |
| S1-097-EVENTS | FixedAttitudeEventMatrix; RepairNeedyReciprocalRequestRefusal; RepairMissingMandatoryAttitudeCause | PASS — reexecuted and exact binding retained |
| S1-097-SAT | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-097-DIRECT-BATCH-POS | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-097-DIRECT-BATCH-NEG | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-097-DECAY | DecayBoundaries | PASS — reexecuted and exact binding retained |
| S1-098-CORE | SharedSnapshotScarceGrain | PASS — reexecuted and exact binding retained |
| S1-098-CALLFAVOR-INIT | CalledFarmSuccessRefusalAndInability | PASS — reexecuted and exact binding retained |
| S1-099-KIN | GeneratedActionVocabularyAndRepaymentTarget; ExactKinScoringAndFullTrace | PASS — reexecuted and exact binding retained |
| S1-099-CORES | CoResidenceMotivationWithoutCompulsion; RepairExplicitSexAndResidenceObservations | PASS — reexecuted and exact binding retained |
| S1-100 | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-101 | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-102 | CalledFarmSuccessRefusalAndInability | PASS — reexecuted and exact binding retained |
| S1-103-GRAIN | SharedSnapshotScarceGrain | PASS — reexecuted and exact binding retained |
| S1-103-RESIDENCE | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-105 | PersonalResidenceAndIncomingResponse | PASS — reexecuted and exact binding retained |
| S1-070 | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-071 | SharedSnapshotScarceGrain | PASS — reexecuted and exact binding retained |
| S1-073 | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-074-IDEMP | DuplicateReactionAndPrematureClosure | PASS — reexecuted and exact binding retained |
| S1-074-DIRECT-BATCH | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-080 | MaterialDeadlockAndNegativeControls; RepairV3FutureFaultTiming; RepairV3DistantInputBoundary; RepairV3FutureMaterialRecovery | PASS — reexecuted and exact binding retained |
| S1-081 | StableFallbackSensitivityAndSemanticAsymmetry; RepairResidenceDestinationDependency; RepairCallCancellationDependency; RepairResidenceReadWriteMatrix; RepairMarriageCapacityPermutation; RepairFavourCreationProvenance; RepairFavourRetirementDependencies; RepairAggregateDebtCapacity; RepairAggregateGrainAndEnablers; RepairTransferShapesAndReserve; RepairCommutingAndAsymmetricControls; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-084 | NoDerivedAuthorityStructuralAudit | PASS — reexecuted and exact binding retained |
| S1-085 | ReplayStorageInputObserverAndAttributePairs; RepairPersonalInputIsolationAndTrace | PASS — reexecuted and exact binding retained |
| S1-086 | GeneratedActionVocabularyAndRepaymentTarget; ExactKinScoringAndFullTrace; RepairHiddenCounterpartyGrain; RepairHiddenWorldFacts; RepairExplicitSexAndResidenceObservations; RepairObservedDebtBoundary; RepairCalledPayloadPrivateFeasibility; RepairPersonalInputIsolationAndTrace | PASS — reexecuted and exact binding retained |
| S1-BND-ATT-STRONGLIKE | DirectMarriageBoundaries | PASS — reexecuted and exact binding retained |
| S1-BND-ATT-SAT | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-BND-ATT-MIXED | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-GIFT-OFFER | GiftGrainIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-GIFT-REQUEST | GiftGrainIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-LOAN-OFFER | LoanGrainIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-LOAN-REQUEST | LoanGrainIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-REPAY-DIRECT | RepaymentAmountAndReserve | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-BFF-BENEFIT | BenefitGrainIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-RMRH-BENEFIT | BenefitGrainIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-MARRIAGE-DOWRY-DIRECT | MarriageDowryIngress | PASS — reexecuted and exact binding retained |
| S1-D4-GRAIN-CALLFAVOR-REPAY-INNER | NestedRepaymentIngress | PASS — reexecuted and exact binding retained |
| S1-BND-REPAY-AMOUNT | NestedRepaymentIngress | PASS — reexecuted and exact binding retained |
| S1-BND-RESERVE | RepaymentAmountAndReserve | PASS — reexecuted and exact binding retained |
| S1-BND-NEED | GiftHelpMeaningsAndNeedClearing | PASS — reexecuted and exact binding retained |
| S1-BND-DECAY | DecayBoundaries | PASS — reexecuted and exact binding retained |
| S1-BND-DEBT-DUE | DebtDueAfterThirdFullCycle | PASS — reexecuted and exact binding retained |
| S1-BND-MARRIAGE-CARD | MarriageDeclineAndLifetime | PASS — reexecuted and exact binding retained |
| S1-BND-FAVOUR-CARD | FullFavourSlotDistinguishesBargainFromHelp | PASS — reexecuted and exact binding retained |
| S1-BND-FAVOUR-MEANING | FullFavourSlotDistinguishesBargainFromHelp | PASS — reexecuted and exact binding retained |
| S1-BND-RESIDENCE-CARD | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-META-01 | ReplayStorageInputObserverAndAttributePairs; RepairV3FutureMaterialRecovery; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-META-02 | IdentityIsomorphismAndDisconnectedLocality; RepairResidenceDestinationDependency; RepairCallCancellationDependency; RepairResidenceReadWriteMatrix; RepairMarriageCapacityPermutation; RepairFavourCreationProvenance; RepairFavourRetirementDependencies; RepairAggregateDebtCapacity; RepairAggregateGrainAndEnablers; RepairTransferShapesAndReserve; RepairCommutingAndAsymmetricControls; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-META-03 | IdentityIsomorphismAndDisconnectedLocality | PASS — reexecuted and exact binding retained |
| S1-META-04 | ReplayStorageInputObserverAndAttributePairs; RepairV3FutureFaultTiming; RepairV3DistantInputBoundary; RepairV3FutureMaterialRecovery | PASS — reexecuted and exact binding retained |
| S1-META-05 | NoDerivedAuthorityStructuralAudit | PASS — reexecuted and exact binding retained |
| S1-META-07 | ReplayStorageInputObserverAndAttributePairs; RepairHiddenCounterpartyGrain; RepairHiddenWorldFacts; RepairExplicitSexAndResidenceObservations; RepairObservedDebtBoundary; RepairCalledPayloadPrivateFeasibility | PASS — reexecuted and exact binding retained |
| S1-META-10 | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-META-11 | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-MUT-04 | ExplicitBargainAndReciprocalHelp | PASS — reexecuted and exact binding retained |
| S1-MUT-13A | RepaymentAmountAndReserve | PASS — reexecuted and exact binding retained |
| S1-MUT-16 | SharedSnapshotScarceGrain; AggregateCapacityAndIndependentLedgerFault | PASS — reexecuted and exact binding retained |
| S1-MUT-17 | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-MUT-18 | ResponseAutonomyAndBoundedFailureKnowledge; RepairNeedyReciprocalRequestRefusal | PASS — reexecuted and exact binding retained |
| S1-MUT-19 | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-MUT-20 | SharedSnapshotScarceGrain | PASS — reexecuted and exact binding retained |
| S1-MUT-21 | SharedSnapshotScarceGrain; AggregateCapacityAndIndependentLedgerFault | PASS — reexecuted and exact binding retained |
| S1-MUT-22 | DuplicateReactionAndPrematureClosure | PASS — reexecuted and exact binding retained |
| S1-MUT-23 | DuplicateReactionAndPrematureClosure | PASS — reexecuted and exact binding retained |
| S1-MUT-24 | NoDerivedAuthorityStructuralAudit | PASS — reexecuted and exact binding retained |
| S1-MUT-26 | ReplayStorageInputObserverAndAttributePairs | PASS — reexecuted and exact binding retained |
| S1-MUT-29 | ExactKinScoringAndFullTrace | PASS — reexecuted and exact binding retained |
| S1-MUT-31 | DirectAttitudeCompositionAndPermutation | PASS — reexecuted and exact binding retained |
| S1-MUT-32 | ResidenceMoveInviteAndConflict | PASS — reexecuted and exact binding retained |
| S1-MUT-33 | NestedRepaymentIngress | PASS — reexecuted and exact binding retained |
| S1-MUT-34 | CalledRepaymentThirdPartyAndInvalidation | PASS — reexecuted and exact binding retained |
| S1-MUT-35 | FullFavourSlotDistinguishesBargainFromHelp; BargainCapacityRace | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-FIXTURE | fixture-audit.json: exact initial fields/inputs, endogenous provenance, profiles and proposal terms for every subcase | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-KNOWLEDGE | ResponseAutonomyAndBoundedFailureKnowledge | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-ORACLE | oracle-audit.json; InvariantOracle.cs and explicit expected arithmetic in scenario source | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-FALLBACK | ReferenceProfilesAndAutonomousCycle; StableFallbackSensitivityAndSemanticAsymmetry; RepairResidenceDestinationDependency; RepairCallCancellationDependency; RepairResidenceReadWriteMatrix; RepairMarriageCapacityPermutation; RepairAggregateGrainAndEnablers; RepairCommutingAndAsymmetricControls; RepairV3DebtLimitedCommutingFarm; RepairV3IntersectingCapacities | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-ITERATION | ReplayStorageInputObserverAndAttributePairs | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-CALLFAVOR-MAP | CompleteCallFavorPayloadMatrix | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-REQUIRED-COVERAGE | All 167 rows individually emitted; 127 coder-owned REQUIRED must pass; REQUIRED external conformance explicitly awaiting review | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-MANIFEST-INTEGRITY | AcceptanceCatalog.Read: Git blob and census | PASS — reexecuted and exact binding retained |
| S1-GLOBAL-CONFORMANCE | Accepted IMP-0001 final completion/promotion record; historical external gate | PASS — accepted historical gate preserved; not a new executable test |

### Slice 2 — 46 exact REQUIRED rows


| Exact ID | Executed scenario / preserved basis | Reviewer disposition |
|---|---|---|
| S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION | SubjectiveGatesAndTraces | PASS — reexecuted and exact binding retained |
| S2-002-KNOWNFACT-RETENTION | StaleResidenceAndLocality | PASS — reexecuted and exact binding retained |
| S2-003-KNOWNFACT-PROVENANCE-CENSUS | AutomaticAcquisition | PASS — reexecuted and exact binding retained |
| S2-004-RECOGNITION-DISTINCT | StructuralBoundaryAndConfiguration | PASS — reexecuted and exact binding retained |
| S2-005-RECOGNITION-TRISTATE-LIFETIME | ExactRG01; RecognitionEvidenceAdequacy | PASS — reexecuted and exact binding retained |
| S2-006-NO-PASSIVE-SYNC | StaleResidenceAndLocality | PASS — reexecuted and exact binding retained |
| S2-007-NO-HISTORY-OMNISCIENCE | StructuralBoundaryAndConfiguration | PASS — reexecuted and exact binding retained |
| S2-008-LOCALITY | StaleResidenceAndLocality | PASS — reexecuted and exact binding retained |
| S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE | RecognitionIndependentAttitudeAndRefusal | PASS — reexecuted and exact binding retained |
| S2-010-OWN-STATE-KNOWLEDGE | AutomaticAcquisition | PASS — reexecuted and exact binding retained |
| S2-011-DIRECT-CLAIM-KNOWLEDGE | AutomaticAcquisition | PASS — reexecuted and exact binding retained |
| S2-012-DIRECT-PARTICIPATION-KNOWLEDGE | AutomaticAcquisition | PASS — reexecuted and exact binding retained |
| S2-013-BOUNDED-FAILURE-PRIVACY-REGRESSION | AutomaticAcquisition | PASS — reexecuted and exact binding retained |
| S2-020F-FACT-COMMUNICATION-ACTION | CommunicationF | PASS — reexecuted and exact binding retained |
| S2-020R-RECOGNITION-COMMUNICATION-ACTION | CommunicationR | PASS — reexecuted and exact binding retained |
| S2-021F-COMMUNICATE-HELD-FACT | CommunicationF | PASS — reexecuted and exact binding retained |
| S2-021R-COMMUNICATE-HELD-RECOGNITION | CommunicationR | PASS — reexecuted and exact binding retained |
| S2-022F-NO-INVENTED-FACT | SubjectiveGatesAndTraces | PASS — reexecuted and exact binding retained |
| S2-022R-NO-INVENTED-RECOGNITION | SubjectiveGatesAndTraces | PASS — reexecuted and exact binding retained |
| S2-023F-FACT-COMMUNICATION-PROVENANCE | CommunicationF | PASS — reexecuted and exact binding retained |
| S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE | CommunicationR | PASS — reexecuted and exact binding retained |
| S2-024F-FACT-COMMUNICATION-INITIATIVE-COST | CommunicationF | PASS — reexecuted and exact binding retained |
| S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST | CommunicationR | PASS — reexecuted and exact binding retained |
| S2-025F-FACT-NO-FREE-BROADCAST | CommunicationF | PASS — reexecuted and exact binding retained |
| S2-025R-RECOGNITION-NO-FREE-BROADCAST | CommunicationR | PASS — reexecuted and exact binding retained |
| S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE | CommunicationF; SameCycleCommunicationBoundary | PASS — reexecuted and exact binding retained |
| S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE | CommunicationR; SameCycleCommunicationBoundary | PASS — reexecuted and exact binding retained |
| S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE | StaleResidenceAndLocality | PASS — reexecuted and exact binding retained |
| S2-030-STALE-FACT-PERSISTS | StaleResidenceAndLocality | PASS — reexecuted and exact binding retained |
| S2-031A-DIRECT-EVIDENCE-PRECEDENCE | DebtDirectPrecedence | PASS — reexecuted and exact binding retained |
| S2-031B-REPORT-EVENT-PRECEDENCE | ReportEventPrecedence | PASS — reexecuted and exact binding retained |
| S2-032-MESSAGE-ARRIVAL-PERMUTATION | ReportEventPrecedence | PASS — reexecuted and exact binding retained |
| S2-033-CANDIDATE-RECOGNITION-CONTESTED | ExactRG01 | PASS — reexecuted and exact binding retained |
| S2-040F-KNOWNFACT-CANDIDATE-GATE | SubjectiveGatesAndTraces | PASS — reexecuted and exact binding retained |
| S2-040R-RECOGNITION-CANDIDATE-GATE | SubjectiveGatesAndTraces; RecognitionEvidenceAdequacy | PASS — reexecuted and exact binding retained |
| S2-041-GATES-BEFORE-SCORING | SubjectiveGatesAndTraces | PASS — reexecuted and exact binding retained |
| S2-042-SUBJECTIVE-TRACE | SubjectiveGatesAndTraces; RecognitionEvidenceAdequacy | PASS — reexecuted and exact binding retained |
| S2-043-IRRELEVANT-SUBJECTIVE-PERTURBATION | SubjectiveGatesAndTraces | PASS — reexecuted and exact binding retained |
| S2-044-OBJECTIVE-REVALIDATION-PRESERVED | SubjectiveGatesAndTraces; SameCycleCommunicationBoundary | PASS — reexecuted and exact binding retained |
| S2-045-PINNED-POLICY-NONCLAIM | StructuralBoundaryAndConfiguration | PASS — reexecuted and exact binding retained |
| S2-050-EPISTEMIC-READ-NONINTERFERENCE | ReplayReadAndEnumeration | PASS — reexecuted and exact binding retained |
| S2-051-DETERMINISTIC-REPLAY | ReplayReadAndEnumeration | PASS — reexecuted and exact binding retained |
| S2-052-NONSEMANTIC-ITERATION-METAMORPHIC | ReplayReadAndEnumeration; SameCycleCommunicationBoundary | PASS — reexecuted and exact binding retained |
| S2-053-ISOMORPHIC-ID-RENAMING | ExactRG01 | PASS — reexecuted and exact binding retained |
| S2-054-CACHE-NONAUTHORITY | StructuralBoundaryAndConfiguration | PASS — reexecuted and exact binding retained |
| S2-055-CONFIGURATION-PROVENANCE | StructuralBoundaryAndConfiguration | PASS — reexecuted and exact binding retained |

## Scope leakage and escalation

No blocking later-slice behavior was found. Specifically absent as implemented mechanisms or required dependencies: general CandidateOrganization convergence/equivalence; universal membership; HouseholdHeadRole appointment/succession or head Recognition; HouseholdDecisionContext/separate initiative; endogenous provision solicitation/reconsideration; Household support/dowry spending; contributor debit/ranking; authority-destroying head races; mediated-marriage authority topology; checkpoint/save-load; general nonparticipant observation; repeated predecessor rejoin/re-exit lineage source algorithm; general fission/merger/reconsolidation; trust/rumor/reputation; strategic/stochastic policy redesign. Existing ordinary marriage/favour mechanics and internal detached simulation are not claims of those deferred Household features.

Accepted semantics are sufficient for this bounded candidate. No consequential missing rule needs invention or escalation. No repair is requested by this review.

## Exact-head CI and downloadable evidence

[GitHub Actions run 35945067153](https://github.com/Classique-Smokes/Mesopotamia-Sim/actions/runs/35945067153) was fetched independently after provisional judgment. Head SHA is exactly `b5e5409ebcaec856a74ab08a7d120a67f6078e36`; conclusion **success**, status completed. Its workflow is `.github/workflows/ci.yml`; run branch is `implementation/imp-0003-slice3-repair-v4`. This different branch name does not change the verified commit identity. Job `107461098500` records SDK 10.0.401 and successful restore → format verification → Release build → Release test steps, with zero build warnings/errors and passing test summary.

Artifact `10786760862`, `sfl-slice1-slice2-slice3-acceptance-evidence`, was present and unexpired when retrieved (expires `2026-12-23T01:56:01Z`). The downloaded ZIP is 616,395 bytes. Its independently computed SHA-256 equals both the packet and GitHub digest:

`f89b3c09fd386b1efb8c1678b4f49eeb503c1b96a73ce105b71cdfcf13a77d21`

All 17 expected files are present: cases, fault-controls, fixture-audit, oracle-audit, slice1-results JSON/Markdown; slice2-cases, fixture-audit, oracle-audit, regression-fixtures, results; slice3-cases, fixtures, producers, repair-v3-controls, repair-v4-controls, results. All JSON contents are semantically equal to the independently generated local artifact. Sixteen files also match after CRLF/LF normalization; Slice-2 fixture audit differs only in JSON dictionary property order and is structurally equal. Byte hashes of uncompressed Windows/Linux text were not misreported as identical.

Remote slice3-results independently confirms ImplementationHead exact, WorkingTreeDirty=false, no failures, 96 REQUIRED PASS / 11 DEFERRED / 2 UNEXERCISED and exact 128+46 inherited sets. Remote case, fixture and producer contents match the examined local executions.

The v4 control artifact contains 48 entries: eight ConnectedLoans, four OtherAllocations, six PositiveFallback, 21 lifecycle corruptions plus four valid lifecycle controls, and three fabricated Recognition identity negatives plus two valid same-cycle controls. These counts are corroboration only. Source paths show actual independent checker invocation; reviewer P19–P24/P27 independently challenge the same risks with their own setups and permutations. Valid Active/Inactive/reactivated/Dissolved and legitimate stale/same-cycle evidence controls survive. The repairs remain effective without weakening genuine-conflict fallback or introducing passive recognition synchronization.

## Review scope inventory and delivery

The following is the complete base-to-candidate changed-path inventory. Production, acceptance, workflow and runtime documentation were examined before provisional judgment; implementation/repair reports only afterward as claims. No candidate source, test, accepted authority or frozen manifest was changed by the reviewer.

- `.github/workflows/ci.yml`
- `src/Mesopotamia.Sim/Decisions.cs`
- `src/Mesopotamia.Sim/EpistemicExecution.cs`
- `src/Mesopotamia.Sim/EpistemicState.cs`
- `src/Mesopotamia.Sim/Execution.cs`
- `src/Mesopotamia.Sim/HouseholdExecution.cs`
- `src/Mesopotamia.Sim/HouseholdProjection.cs`
- `src/Mesopotamia.Sim/HouseholdResolution.cs`
- `src/Mesopotamia.Sim/HouseholdRules.cs`
- `src/Mesopotamia.Sim/HouseholdState.cs`
- `src/Mesopotamia.Sim/README.md`
- `src/Mesopotamia.Sim/ResolutionDependencies.cs`
- `src/Mesopotamia.Sim/Simulation.cs`
- `tasks/implementation/IMP-0003_IMPLEMENTATION_REPORT.md`
- `tasks/implementation/IMP-0003_REPAIR_V2_REPORT.md`
- `tasks/implementation/IMP-0003_REPAIR_V3_REPORT.md`
- `tasks/implementation/IMP-0003_REPAIR_V4_REPORT.md`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdAdversarialScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdEpistemicScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdLineageScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdRepairV2Scenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdRepairV3Scenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdRepairV4Scenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdStructuralScenarios.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdWarrantOracle.cs`
- `tests/Mesopotamia.Sim.AcceptanceTests/README.md`
- `tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs`


The return branch is `review/imp-0003-conformance-v4-independent-return`, created from the exact candidate in a separate report checkout. Its only added path is `research/technical/IMP-0003/IMP-0003_INDEPENDENT_CONFORMANCE_REVIEW_V4.md`. Scratch code, logs and downloaded CI evidence remain outside the candidate and are not committed on the return branch. A separate delivered evidence ZIP retains the reviewer harness, canonical logs, provisional judgment and CI verification files for reproducibility. Local SDK/assembly reference paths in the harness can be adjusted when reproducing on another machine; the candidate DLL and checker sources must remain pinned to the reviewed SHA.

Bounded testing is not exhaustive proof over all possible histories. Within the frozen slice and required review interventions, there is no established material defect or insufficient required evidence. **PASS — PROMOTE; recommendation PROMOTE the exact candidate.**
