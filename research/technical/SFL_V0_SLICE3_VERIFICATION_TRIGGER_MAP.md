# SFL v0 Slice 3 — Verification Trigger and Acceptance Applicability Map

**Status:** RETURN / ADVISORY VERIFICATION-APPLICABILITY INVENTORY  
**Commission:** tasks/research/SFL_V0_SLICE3_DISCOVERY_C_VERIFICATION_TRIGGERS.md  
**Repository:** Classique-Smokes/Mesopotamia-Sim  
**Canonical base SHA:** 7deb43a7c2d40403f0a9cd6c600fba9db5cebf26  
**Return branch:** research/slice3-verification-trigger-return  
**Implementation authority:** none  
**Semantic/design authority:** none  
**Frozen-manifest edit authority:** none

## 1. Scope and interpretation rule

This return answers:

> Which already-accepted Stage-3 verification obligations become executable completion obligations in Slice 3, which prior obligations must remain regression-protected, which obligations remain later, and what a separate Slice-3 acceptance authority must make omission-detectable?

This report does not edit or reclassify either frozen manifest:

- SFL-V0-S1-ACCEPTANCE-v1;
- SFL-V0-S2-ACCEPTANCE-v1.

Any reference below to a frozen Slice-1 or Slice-2 AcceptanceId is an applicability or regression statement for a future Slice-3 authority. Its historical frozen status remains unchanged.

The current Slice-3 planning boundary is persistent household identity + grounded collective capability. Slice 4 owns representative role + turnover/succession of that role; Slice 5 owns delayed-process/checkpoint continuation. The accepted SPEC remains controlling when a planning label is less precise.

## 2. Sources independently retrieved

This inventory read from canonical base 7deb43a7c2d40403f0a9cd6c600fba9db5cebf26:

- AGENTS.md;
- 00_START_HERE.md;
- plans/CURRENT_PHASE.md;
- plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md;
- specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md;
- all accepted ADRs under architecture/accepted/;
- all canonical verification families under plans/verification/SFL_V0/;
- plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md;
- plans/verification/SFL_V0/REFERENCE_SCORING_PROFILES.md;
- frozen Slice-1 and Slice-2 manifests and freeze records;
- research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md;
- research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md;
- registers/ASSUMPTIONS_REGISTER.md;
- registers/TRES-0010_DEFERRED_GAP_LEDGER.md;
- research/technical/SFL_V0_OBSERVATIONS/RUN-0002_EPISTEMIC_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md;
- current production/test boundary, including src/Mesopotamia.Sim/README.md, VerificationAccess.cs, and the acceptance harness README/catalog/fixture/oracle surfaces;
- the prior Slice-2 verification-trigger return as format/process precedent.

The Slice-2 observation reconciliation adds no new semantics. Its important Slice-3 evidence is negative: objective co-residence, durable ties, and repeated support did not create CandidateRecognition without actor-held evidence. Slice 3 therefore cannot replace the verified actor-specific epistemic substrate with engine-global household truth.

## 3. Controlling semantic consequences for Slice 3

The following accepted distinctions are now executable and therefore must be completion-visible:

1. CandidateOrganization is pre-household evidence organization only; it has no household power and its label cannot prove itself.
2. Household is not a dwelling, kinship cluster, marriage cluster, co-resident graph component, participant list, or mutable snapshot.
3. Formation is a causal reaction to lower-level history plus every required founder's own CandidateRecognition.
4. Formation creates one stable Household identity, one FormationWarrant, founder SustainingParticipant associations, and founder household recognition.
5. SustainingParticipant is provenance-bearing; there is no authoritative universal Members set.
6. Post-formation participation entry is bilateral and requires a ParticipationWarrant plus a live continuity bridge.
7. Participation end is explicit and provenance-bearing; residence change alone never edits participation.
8. Identity continuity is historical transmission through ContinuationWarrant, not snapshot similarity or raw participant overlap.
9. Active / Inactive / Dissolved is operational lifecycle only and is published at stable closure.
10. Inactive may reactivate through its sole bearer; Dissolved never resurrects as the same identity.
11. A valid continuity/participation interpretation to a non-Dissolved H takes precedence over fresh formation from the same causal evidence bundle.
12. Household existence/continuity Recognition remains subjective and provenance-bearing; engine-side H does not globally synchronize actors.
13. Controlled lineage is historical derivation, not identity or inherited causal state.
14. Stable IDs are reference identity only; they are not a social convergence, continuity, lineage, or recognition rule.
15. All automatic formation/continuity/lifecycle/lineage reactions remain inside the accepted deterministic stable-cycle closure contract.

## 4. Canonical family applicability map

### 4.1 Formation family

| Card / obligation | Slice-3 classification | Reason |
|---|---|---|
| VS-SFL-001 — Three-founder formation | **REQUIRED** | This is the architectural formation witness: lower-level support + founder-specific evidence/Recognition -> FormationWarrant -> H -> founder participation/recognition. |
| VS-SFL-001 adversarial companions | **REQUIRED** | Shared residence, durable connectivity, recurrence, and all-founder Recognition must each remain causally necessary; proxy-only formation must fail. |
| VS-SFL-002 — Two-person formation smoke | **STILL FUTURE / UNEXERCISED as a standalone completion card** | The card calls itself debugging evidence only. However the accepted two-person minimum is REQUIRED through the formation boundary matrix. |
| Cross-cutting founding-core 1 / 2 / 3 boundary | **REQUIRED** | One founder must fail; two and three may qualify when every other formation condition holds. |
| Qualifying-support 1 / 2-same-cycle / 2-distinct-cycle boundary | **REQUIRED** | Prevents one-event and same-cycle recurrence shortcuts. |
| CandidateRecognition missing from 0 / some / all founders | **REQUIRED** | Formation must remain downstream of actor-held recognition, not objective graph state. |

The Slice-3 acceptance authority should treat VS-SFL-001 as the canonical positive narrative and bind the boundary/ablation suite conjunctively rather than accepting “one happy-path household formed” as sufficient evidence.

### 4.2 Continuity / turnover family

All five canonical cards become **REQUIRED in Slice 3**:

- VS-SFL-010 — complete founder turnover;
- VS-SFL-011 — broken bridge / similar endpoint;
- VS-SFL-012 — Inactive reactivation;
- VS-SFL-013 — same-cycle bridge handoff;
- VS-SFL-014 — Dissolution and no resurrection.

The family metamorphic checks are also Slice-3-active:

- nonsemantic storage/input permutation;
- nonsemantic ID renaming;
- disconnected-population locality;
- observer/diagnostic noninterference;
- derived-index rebuild equivalence.

The family always-on invariants are completion requirements, especially:

- lifecycle only at stable closure;
- no ContinuationWarrant to nonexistent history;
- residence alone never edits SustainingParticipant;
- one causal bundle cannot both continue H and found duplicate H2;
- no hidden Members set as oracle.

### 4.3 No-Self-Confirmation family

The family splits at the Slice-3/Slice-4 action boundary.

| Card / claim | Slice-3 classification | Reason |
|---|---|---|
| VS-SFL-050 — household support cannot become formation evidence | **DEFERRED TO SLICE 4** as written | The canonical intervention needs household-originated support, whose executable production path requires active head authority/provision. |
| VS-SFL-051 — household feedback cannot clone existing identity | **DEFERRED TO SLICE 4** as written | The canonical “feedback” evidence depends on household-originated effects. Slice 3 must nevertheless prove continuity-over-duplicate-formation precedence using lower-level evidence available in Slice 3. |
| VS-SFL-052 — household feedback cannot satisfy fresh-lineage evidence | **DEFERRED TO SLICE 4** as written | It depends on household-originated support. Fresh-lineage person-person evidence rules themselves are Slice-3-active. |
| VS-SFL-053 — label/diagnostic ablation | **REQUIRED** | Household/candidate labels and reporting projections must not become causal formation/continuity evidence. |

Slice 3 also needs an explicit negative control that a CandidateOrganization/Household identifier or diagnostic projection cannot count as formation or continuity evidence. This is the Slice-3 portion of the broader no-self-confirmation obligation and does not require executable household spending.

### 4.4 Recognition / Information family

Slice 2 already verified the generic epistemic machinery. Slice 3 activates the new Household existence/continuity proposition while keeping head-role recognition later.

| Card / property | Slice-3 classification | Reason |
|---|---|---|
| VS-SFL-030 — mediated-route Recognition causality | **DEFERRED TO SLICE 4 as written** | The canonical action gate is household-mediated marriage through a head. Slice 3 still needs a household-Recognition causal gate, best exercised through ParticipationWarrant eligibility rather than fake head mechanics. |
| VS-SFL-031 — stale head Recognition through succession | **DEFERRED TO SLICE 4** | Head/succession substrate. |
| VS-SFL-032 — event order beats late old message | **REGRESSION-PROTECTED INHERITED REQUIREMENT** | Generic law already passed in Slice 2; the exact head-shaped canonical narrative remains Slice 4. |
| VS-SFL-033 — incomparable evidence becomes Contested | **REGRESSION-PROTECTED INHERITED REQUIREMENT**, plus household-specific coverage when such evidence is exercised | CandidateRecognition conflict already passed in Slice 2. Household Recognition may not introduce an arbitrary ID/arrival winner. |
| VS-SFL-034 — communication consumes initiative | **REGRESSION-PROTECTED INHERITED REQUIREMENT** | Already frozen/passed in Slice 2. |
| VS-SFL-035 — Recognition independent of attitude/compliance | **REGRESSION-PROTECTED**, with Household proposition extension | Generic Recognition independence already passed in Slice 2; adding H may not collapse Recognition into attitude or obedience. |

New Slice-3 acceptance coverage is required for:

- founders directly recognize the produced H;
- an uninvolved outsider does not passively acquire household Recognition;
- newcomer Household Recognition is causally necessary for participation entry;
- household continuity Recognition remains evidence-backed across turnover;
- decisive lifecycle evidence updates Recognition only through an accepted acquisition/provenance route;
- stale outsiders remain stale when no route delivers decisive evidence.

### 4.5 Lineage family

The controlled lineage family is **REQUIRED in Slice 3**.

Reason: SPEC `7.7 makes lineage part of household formation/identity semantics; every canonical lineage prerequisite is available from Slice-3 formation/participation/lifecycle substrate; lineage has no head-role, household-decision, or checkpoint dependency; no later Stage-4 slice is assigned the household-lineage substrate.

Required cards:

- VS-SFL-020 — controlled division descendant;
- VS-SFL-021 — division freshness ablation;
- VS-SFL-022 — predecessor lifecycle, structural-proxy, and ambiguity controls;
- VS-SFL-023 — controlled consolidation descendant;
- VS-SFL-024 — survivor / no-fresh-cross-support / unrelated-predecessor / order controls;
- VS-SFL-025 — lineage has no v0 causal power;
- VS-SFL-026 — direct versus transitive ancestry and rebuild.

Also REQUIRED:

- cross-cutting lineage boundary matrix;
- S1-META-09 lineage predecessor-set ordering as a newly applicable prior Stage-3 relation;
- zero-or-one LineageWarrant per successor FormationWarrant;
- direct lineage irreflexive/acyclic/temporally forward;
- no inherited grain, relations, claims, authority, recognition, roles, residence, attitudes, pending work, or lifecycle state.

LATER-03 does not block these bounded canonical histories if repeated rejoin/re-exit predecessor participation is deliberately absent. It must remain visible and must fire before acceptance broadens to those histories.

### 4.6 Provision Grounding family

Under the currently published Stage-4 order, the canonical provision cards are **DEFERRED TO SLICE 4 as written**, pending the separate Slice-3/Slice-4 capability-boundary reconciliation.

Why this is not a mere test-detail choice:

- VS-SFL-040 begins from an occupied recognized head and has that head request the provision commitment;
- VS-SFL-041/042 require household-mode expenditure through a head;
- VS-SFL-044 is explicitly head reconsideration;
- VS-SFL-046 is actual collective expenditure;
- SPEC `8.5 says collective action requires Active H + occupied head + valid authority + backing/capacity;
- Slice 4, not Slice 3, owns the representative/head role.

Therefore this commission does not invent a headless provision-request path merely to satisfy the phrase “grounded collective capability.”

Current classification:

- VS-SFL-040 — **DEFERRED TO SLICE 4 unless separate accepted authority explicitly makes provision-commitment creation/capacity executable in Slice 3**;
- VS-SFL-041 — **DEFERRED TO SLICE 4**;
- VS-SFL-042 — **DEFERRED TO SLICE 4**;
- VS-SFL-043 — **DEFERRED TO SLICE 4 as a provision card**; Slice-3 dissolution itself is still REQUIRED;
- VS-SFL-044 — **DEFERRED TO SLICE 4**;
- VS-SFL-045 — **DEFERRED TO SLICE 4 unless commitment/capacity alone is explicitly pulled into Slice 3**;
- VS-SFL-046 — **DEFERRED TO SLICE 4**.

No Slice-3 fixture may write a provision commitment merely to claim grounded capacity. If the authority reconciliation decides commitment/capacity is required before the head exists, the acceptance manifest needs a new accepted creation route or an already-authorized headless mechanism; the current verification mapper cannot supply one.

### 4.7 Head Role / Dual-Mode family

VS-SFL-060 through VS-SFL-066 are **DEFERRED TO SLICE 4**.

Slice 3 may and should assert only the already accepted negative boundary relevant to formation:

- a newly formed H has no occupied head;
- no household-mode initiative or head-mediated effect is available merely because H exists.

That does not authorize pulling appointment, succession, dual-mode deliberation, household scoring, or role-scoped responses into Slice 3.

### 4.8 Resolution / Reaction family

| Card | Slice-3 classification |
|---|---|
| VS-SFL-070 — Declined versus Unable | **REGRESSION-PROTECTED INHERITED** |
| VS-SFL-071 — accepted then invalidated | **REGRESSION-PROTECTED INHERITED** |
| VS-SFL-072 — provision priority | **DEFERRED TO SLICE 4** |
| VS-SFL-073 — bounded failure reason/privacy | **REGRESSION-PROTECTED INHERITED** |
| VS-SFL-074 — cause idempotence / direct attitude batch | **REGRESSION-PROTECTED INHERITED**, and reaction idempotence applies to new household reactions |
| VS-SFL-075 — multi-reaction formation closure | **REQUIRED** |
| VS-SFL-076 — communication provenance regression link | **REGRESSION-PROTECTED INHERITED** |

VS-SFL-075 is especially important for Slice 3. The suite must observe the same-cycle causal chain from lower-level support/evidence through CandidateRecognition, FormationWarrant, H, founding participation, founder Recognition, and stable publication. A successful final snapshot without the ordered causal chain is insufficient.

### 4.9 Determinism / Recovery / Explainability family

| Card | Slice-3 classification |
|---|---|
| VS-SFL-080 — MaterialDeadlock | **REGRESSION-PROTECTED INHERITED** |
| VS-SFL-081 — stable-ID fallback quarantine | **REGRESSION-PROTECTED INHERITED**, with new household-specific ID-renaming controls |
| VS-SFL-082 — safe checkpoint exact suffix | **DEFERRED TO SLICE 5** |
| VS-SFL-083 — omitted checkpoint state | **DEFERRED TO SLICE 5** |
| VS-SFL-084 — derived-state rebuild equivalence | **REQUIRED on any new household/lineage derived state**, while preserving the inherited lower-level regression |
| VS-SFL-085 — observer/diagnostic noninterference | **REQUIRED on new household inspection surfaces**, while preserving the inherited regression |
| VS-SFL-086 — decision-trace completeness | **REGRESSION-PROTECTED INHERITED**; applies to any actual personal/response context used by Slice-3 participation scenarios |
| VS-SFL-087 — causal explanation surface | **STILL FUTURE / UNEXERCISED as the canonical rendered-explanation obligation**; its causal-intervention method is still appropriate for independent Slice-3 oracles |

Important distinction: engine checkpoint/restore remains Slice 5, but VH-03 verification-checkpoint provenance fires now because continuity/lineage scenarios reuse verified upstream scenario results. See `8.

### 4.10 Lower-Level Social Fabric and Response Decision families

VS-SFL-090 through VS-SFL-099 are **REGRESSION-PROTECTED INHERITED requirements**.

Particularly vulnerable to household implementation:

- explicit transfer meanings remain distinct;
- Debt/Favour existence alone is not household formation evidence;
- marriage does not move residence;
- residence does not create/end household participation;
- attitude/kinship remain distinct from household association;
- one personal initiative and response accounting remain unchanged.

VS-SFL-100/101/102/103/105 are likewise **REGRESSION-PROTECTED INHERITED requirements**.

VS-SFL-104 is **DEFERRED TO SLICE 4** because it is a role-scoped mediated-marriage response.

Slice-3 participation request/invite may reuse the existing response machinery, but the acceptance authority still needs a participation-specific bilateral-acceptance witness; a generic Slice-1 response test cannot substitute for the new ParticipationWarrant claim.

## 5. Minimum Slice-3 completion witnesses

The following are the minimum independently observable witness groups a Slice-3 acceptance manifest should make omission-detectable. These are planning labels, not new authoritative AcceptanceIds.

### W-S3-01 — Formation from lower-level history

Positive VS-SFL-001-shaped run:

- no H exists initially;
- two qualifying person-person supports occur on distinct cycles;
- each founder independently obtains sufficient uncontested evidence;
- each founder reaches CandidateRecognition for the same bounded candidate referent;
- FormationWarrant commits automatically;
- exactly one H is created;
- founding SustainingParticipant associations and direct H Recognition follow;
- H is Active only at stable closure;
- earliest sustaining evidence time and formation/reification time remain distinct.

Required paired/ablated companions remove one condition at a time: shared residence, durable connectivity, recurrence, or one founder's Recognition.

### W-S3-02 — No primitive Household creation / no hidden Members authority

Structural + executable audit:

- public/mechanism fixture ingress cannot directly create H;
- no privileged FormHousehold command exists;
- acceptance fixtures never write H, warrants, participation, lifecycle, or final household Recognition;
- no authoritative Members set or graph-cluster projection is used to decide H identity;
- residence/kinship/marriage snapshot similarity does not reify H.

### W-S3-03 — Formation warrant provenance

Independently reconstruct every FormationWarrant reference from recorded lower-level history and founder subjective evidence:

- founders;
- dwelling;
- durable ties;
- both support events;
- founder Recognition evidence;
- earliest sustaining evidence;
- formation time;
- rule/configuration version.

No production formation/candidate-recognition helper may serve as the oracle.

### W-S3-04 — Participation entry + bilateral negative control

From a verifiably produced non-Dissolved H:

- newcomer recognizes H;
- a current sustaining participant is a valid bridge and recognizes the same H;
- shared residence + durable tie + post-formation support are present;
- request/invite + named counterpart acceptance occurs;
- ParticipationWarrant -> SustainingParticipant -> ContinuationWarrant occurs.

Paired negative variants remove:

- newcomer H Recognition;
- bridge;
- bilateral acceptance;
- shared residence;
- durable tie;
- post-formation support.

No missing condition may be recreated by another path during the horizon.

### W-S3-05 — Participation end + exit-side continuity

A current sustaining participant explicitly ends participation:

- ParticipationEndWarrant is created;
- only SustainingParticipant ends;
- residence/kinship/marriage/debt/favour/attitude/history remain under their own semantics;
- any continuing H has explicit exit-side ContinuationWarrant evidence;
- residence change alone never creates the same result.

This witness is the required VH-01 exit-side hardening.

### W-S3-06 — Complete founder turnover / stable numerical identity

Execute VS-SFL-010 through D/E/F or an isomorphic held-out topology:

- every founder exits after a valid bridge transmission;
- no original founder remains;
- H stable ID is unchanged;
- continuity is justified solely by the historical warrant chain;
- final participant similarity is never the identity oracle.

### W-S3-07 — Broken bridge / similar endpoint

Paired with W-S3-06:

- comparable endpoint;
- required bridge removed before newcomer entry;
- no ContinuationWarrant may cite the absent bridge;
- old H identity cannot be inherited from endpoint similarity.

### W-S3-08 — Inactive reactivation

Produce exactly one current SustainingParticipant at stable closure:

- H becomes Inactive, same ID;
- no household-mode initiative is available;
- newcomer validly enters through the sole bearer;
- H returns Active at stable closure;
- no H2 forms from the same evidence.

### W-S3-09 — Same-cycle bridge handoff

Accepted newcomer entry depends on sole bearer A while A also has accepted same-cycle exit:

- entry/ParticipationWarrant;
- continuity handoff;
- A end;
- stable lifecycle publication.

Result: same H, newcomer is sole bearer, Inactive. Mutation order or transient participant count may not dissolve/recreate H.

### W-S3-10 — Dissolution / no resurrection

Final bearer ends with no valid same-cycle handoff:

- H becomes Dissolved only at stable closure;
- history remains queryable;
- later similar lower-level configuration may form a new H2;
- H itself never reactivates.

No Household ID, participant count snapshot, residence similarity, or old recognition can resurrect H.

### W-S3-11 — Continuity-over-duplicate-formation precedence

Use one causal evidence bundle that could superficially resemble a fresh formation while it validly supports participation/continuity to a non-Dissolved H.

Assert:

- the valid continuity path is taken;
- no H2 FormationWarrant consumes that same causal bundle;
- nonsemantic iteration/ID changes do not alter the semantic result.

This is REQUIRED in Slice 3 even though household-feedback variants VS-SFL-050/051 are deferred with household-originated action to Slice 4.

### W-S3-12 — Household existence/continuity Recognition

At minimum:

1. founders directly recognize produced H;
2. an unrelated outsider remains Unknown absent accepted evidence;
3. newcomer participation succeeds only when newcomer recognizes H through accepted evidence;
4. a stale actor is not passively synchronized by turnover/lifecycle change;
5. accepted newer decisive lifecycle/continuity evidence updates the actor according to accepted precedence;
6. no stable ID, Household ID, engine-side state, or history reader acts as subjective evidence by itself.

The decisive-dissolution subcase is also the Slice-3 side of VH-05. The witness must use an already accepted direct-participation/communication route; it may not invent generic nonparticipant observation.

### W-S3-13 — Controlled division lineage

VS-SFL-020 + 021 + 022 obligations:

- successor forms independently;
- predecessor continues through ordinary continuity;
- every founder source is an explicit ParticipationEndWarrant;
- qualifying fresh person-person support occurs after all cited exits;
- exactly one DivisionDescendant LineageWarrant issues;
- DerivedFrom is a rebuildable projection;
- predecessor dissolution / stale fresh evidence / ambiguous source controls withhold lineage without blocking ordinary formation.

### W-S3-14 — Controlled consolidation lineage

VS-SFL-023 + 024 obligations:

- both predecessors Dissolved first;
- founder predecessor sources explicit and unambiguous;
- fresh post-dissolution cross-predecessor support exists;
- H3 forms independently and is a new numerical identity;
- predecessor set is unordered and stable under enumeration reversal;
- survivor/no-cross-support/unrelated-predecessor controls withhold classification without blocking formation.

### W-S3-15 — Lineage nonauthority / ancestry rebuild

VS-SFL-025 + 026:

- removing/rebuilding lineage projection changes only lineage/ancestry inspection;
- no material/social/recognition/authority behavior changes;
- direct DerivedFrom and transitive AncestorOf stay distinct;
- cache rebuild reproduces direct/transitive answers.

### W-S3-16 — Reaction closure / derived refresh hardening

A formation and at least one participation/lifecycle chain must prove:

- cause keys are unique/idempotent;
- ReactionIndex is monotone;
- later same-cycle automatic rules see earlier authoritative commits where required;
- derived refresh does not lag so that formation/continuity/lifecycle is evaluated from stale household state;
- no completed cycle, voluntary reactivation, or lifecycle summary is published before closure.

This is the primary VH-06 witness and should be paired with a stale-derived-value fault challenge or rebuild-equivalence proof where a behavior-affecting derived household index exists.

### W-S3-17 — Cross-cutting metamorphic set

Apply at least these to representative formation/continuity/lineage histories:

- storage/input iteration permutation;
- isomorphic nonsemantic ID renaming;
- disconnected-population locality;
- observer/diagnostic noninterference;
- derived rebuild equivalence;
- irrelevant-attribute perturbation;
- lineage predecessor order reversal.

Stable-ID fallback may remain sensitive only in explicitly accepted symmetric fallback cases and must be marked. It must never resolve candidate equivalence, continuity, household Recognition, or lineage ambiguity.

### Conditional W-S3-PROV — Provision commitment / grounded capacity

Do not freeze this witness as REQUIRED until the separate capability-boundary authority resolves whether Slice 3 has an accepted way to create a provision commitment before the head role exists.

If that authority makes commitment/capacity executable in Slice 3, the minimum witness must prove:

- explicit accepted commitment;
- contributor retains personal grain;
- exposed capacity = max(0, grain - 2);
- NeedsGrain exposes zero;
- no pooled household treasury;
- derived capacity rebuilds from authoritative commitments;
- participation end/dissolution terminates applicable commitments without confiscation.

It still must not exercise household support/dowry spending or head authority unless those are separately pulled forward by accepted authority.

## 6. Fixture authority map

The acceptance manifest should bind each witness to a concrete fixture class/write set rather than merely saying “uses legal fixtures.”

| Witness class | May fixture-seed | Must never fixture-write / assume |
|---|---|---|
| Formation | people, grain, residence, kinship/marriage/attitude needed as lower-level facts, initial subjective lower-level observations, scheduled lower-level proposals/communications | Household, FormationWarrant, SustainingParticipant, CandidateRecognition when its derivation is under test, final H Recognition, lifecycle, head, lineage |
| Formation ablation | same positive fixture with exactly one causal input removed | alternate hidden evidence path that recreates the removed condition |
| Participation entry | verified produced H state; newcomer basic facts; declared lower-level evidence not under acquisition test; valid public request/invite inputs | H creation, ParticipationWarrant, SustainingParticipant result, ContinuationWarrant, lifecycle result, final newcomer H Recognition |
| Participation end | verified produced participating H state; public EndHouseholdParticipation proposal | ParticipationEndWarrant, ended association, ContinuationWarrant, lifecycle result |
| Turnover/reactivation/handoff | only states produced by preceding verified scenario steps plus ordinary newcomer lower-level setup | hand-authored H identity, direct participant list mutation, lifecycle verdict, continuity result |
| Dissolution/no resurrection | verified produced Inactive H with sole bearer; later fresh lower-level configuration | direct Dissolved write; reusing H ID as proof that a later organization is H |
| Household Recognition | sender/actor-held evidence may be controlled only when acquisition is explicitly not the assertion target and provenance remains fixture-marked | recipient/final Recognition state; engine-side H ID as evidence; generic observation entitlement not accepted by SPEC |
| Lineage | verified produced predecessor histories; ordinary lower-level successor setup and proposals | LineageWarrant, DerivedFrom, predecessor classification, fresh-evidence verdict |
| Metamorphic/cache | baseline authoritative fixture plus exactly declared permutation/read/rebuild perturbation | hidden semantic changes between paired runs; production normalizer as expected result |
| Conditional provision | only lower-level/person state and a valid accepted commitment ingress if separately authorized | provision commitment result, capacity result under judgment, provision-spend result, pooled grain, head result |

“Verified produced H state” means a state reached through a scenario whose producer, pass result, fixture audit, authority version, and output identity are recorded. It does not mean a fixture may write a Household ID into a fresh world and call it verified.

## 7. Oracle-independence requirements

### Formation

Independent oracle recomputes the accepted formation predicate from:

- recorded initial/lower-level facts;
- recorded qualifying committed support events and their cycle order;
- each founder's visible subjective evidence/provenance.

Forbidden: production CandidateRecognition, CandidateOrganization convergence, formation eligibility, or formation transition helpers as expected answers.

### Participation

Independent oracle checks the accepted ParticipationWarrant prerequisites from public history/state:

- H provenance from a verified producer;
- newcomer H Recognition;
- live bridge;
- shared residence;
- durable tie;
- post-formation support;
- bilateral proposal/acceptance.

Forbidden: production participation validator/classifier as sole oracle.

### Continuity / identity

Independent oracle follows direct historical references:

FormationWarrant -> ParticipationWarrant / ParticipationEndWarrant -> ContinuationWarrant -> successor state.

Stable household identity equality is checked as a referenced historical fact, never inferred from final participants, residence, assets, kinship, or production “same household” classifier.

The broken-bridge and duplicate-precedence pairs are mandatory causal/metamorphic checks.

### Lifecycle

Independent oracle reconstructs the current SustainingParticipant associations from accepted association transitions, then applies the accepted 2+ / 1 / 0 lifecycle rule only at stable closure.

Forbidden: production lifecycle classifier as expected result.

### Recognition

Use paired runs and public actor-specific epistemic state/provenance:

- same objective world, different accepted evidence -> different H Recognition/eligibility;
- no accepted evidence route -> no passive update;
- later accepted evidence -> accepted precedence result.

Forbidden: production Recognition updater/conflict resolver/precedence helper as expected oracle.

### Lineage

Independent oracle checks:

- successor ordinary FormationWarrant;
- explicit founder ParticipationEndWarrant sources;
- predecessor lifecycle state at the required times;
- fresh support event ordering;
- cross-predecessor condition for consolidation;
- no ambiguity.

Forbidden: production lineage classifier.

DerivedFrom/AncestorOf rebuild must be checked independently from LineageWarrants.

### Derived state / cache

Either:

- structural evidence proves no behavior-affecting household/lineage cache exists; or
- discard/rebuild + deliberately stale-cache challenge proves authoritative state wins.

A production cache helper cannot certify its own nonauthority.

### Provision, if later activated

Capacity arithmetic is independent simple arithmetic over personal grain, NeedsGrain, and valid commitments.

Forbidden: production derived-capacity helper when the arithmetic is under judgment.

## 8. Deferred-gap and hardening trigger map

### 8.1 Semantic/model gaps

| Ledger ID | Slice-3 disposition |
|---|---|
| LATER-01 — CandidateOrganization same-candidate equivalence/convergence | **FIRED / NEAR-TERM.** A bounded one-candidate formation witness can avoid inventing a general convergence theory. The Slice-3 manifest may be drafted with exactly one stable candidate referent and must state that candidate ID/label is not evidence. If production will independently create/reconcile multiple candidate labels/evidence paths, this becomes a semantic blocker before implementation/freeze. |
| LATER-02 — actor departure semantics | **NOT FIRED** by required Slice-3 evidence. Use EndHouseholdParticipation, not actor departure, for turnover. If fixture/runtime departure is introduced, this fires first. |
| LATER-03 — repeated predecessor participation lineage-source selection | **DELIBERATELY DEFERRED.** Controlled lineage can avoid repeated rejoin/re-exit histories. It fires before such histories are accepted/generated. |
| LATER-04 — authority-destroying transition vs accepted authority action | **DEFERRED TO SLICE 4.** Requires head/authority action coexistence. |
| LATER-05 — mediated-marriage authority topology | **DEFERRED TO SLICE 4.** |

### 8.2 Verification hardening

| Ledger ID | Slice-3 disposition |
|---|---|
| VH-01 — exit-side ContinuationWarrant | **FIRES NOW / REQUIRED completion evidence.** Continuity is a Slice-3 completion claim; both entry-side and exit-side transmission must be explicit. |
| VH-02 — generated-history oracle circularity | **STILL UNEXERCISED unless generated histories are made REQUIRED.** If generated histories are promoted into completion evidence, this fires first. |
| VH-03 — verified-checkpoint producer/pass/fixture provenance | **FIRES NOW / REQUIRED.** Continuity and lineage cards depend on previously verified formation/household states. This is verification-fixture provenance, not engine checkpoint/restore. |
| VH-04 — checkpoint omission mutant continuation suffix | **DEFERRED TO SLICE 5.** |
| VH-05 — event-observer/lifecycle recognition | **FIRES NOW for decisive household lifecycle evidence; head-vacancy half remains Slice 4.** The Slice-3 witness must not invent generic nonparticipant observation. If no already accepted acquisition route can carry decisive dissolution/continuity evidence to the actor under test, that exact observation route is an authority question, not test discretion. |
| VH-06 — household/reaction-chain derived refresh | **FIRES NOW / REQUIRED.** Formation, participation, continuity, lifecycle, and lineage reactions now depend on same-cycle closure and derived-state freshness. |

## 9. Exact prior-slice regression protection

All frozen REQUIRED Slice-1 and Slice-2 evidence remains runnable under the canonical test suite. The Slice-3 manifest should additionally name the exact high-risk regression bindings below rather than using prose such as “prior slices still pass.”

### 9.1 Objective / subjective separation and no passive synchronization

From Slice 2:

- S2-001-OBJECTIVE-SUBJECTIVE-SEPARATION;
- S2-002-KNOWNFACT-RETENTION;
- S2-003-KNOWNFACT-PROVENANCE-CENSUS;
- S2-004-RECOGNITION-DISTINCT;
- S2-005-RECOGNITION-TRISTATE-LIFETIME;
- S2-006-NO-PASSIVE-SYNC;
- S2-007-NO-HISTORY-OMNISCIENCE;
- S2-009-RECOGNITION-INDEPENDENT-ATTITUDE-COMPLIANCE.

These protect against replacing actor-specific epistemic state with objective Household truth.

### 9.2 Communication / provenance / stale evidence

From Slice 2:

- S2-020F-FACT-COMMUNICATION-ACTION;
- S2-020R-RECOGNITION-COMMUNICATION-ACTION;
- S2-021F-COMMUNICATE-HELD-FACT;
- S2-021R-COMMUNICATE-HELD-RECOGNITION;
- S2-022F-NO-INVENTED-FACT;
- S2-022R-NO-INVENTED-RECOGNITION;
- S2-023F-FACT-COMMUNICATION-PROVENANCE;
- S2-023R-RECOGNITION-COMMUNICATION-PROVENANCE;
- S2-024F-FACT-COMMUNICATION-INITIATIVE-COST;
- S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST;
- S2-025F-FACT-NO-FREE-BROADCAST;
- S2-025R-RECOGNITION-NO-FREE-BROADCAST;
- S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE;
- S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE;
- S2-027-DIRECT-VS-COMMUNICATED-PROVENANCE;
- S2-030-STALE-FACT-PERSISTS;
- S2-031A-DIRECT-EVIDENCE-PRECEDENCE;
- S2-031B-REPORT-EVENT-PRECEDENCE;
- S2-032-MESSAGE-ARRIVAL-PERMUTATION;
- S2-033-CANDIDATE-RECOGNITION-CONTESTED.

Imported Slice-1 obligations already bound by Slice 2 also remain protected:

- S1-098-COMMUNICATION;
- S1-META-08;
- S1-MUT-27;
- S1-MUT-28;
- S1-076.

### 9.3 Initiative / response accounting

Exact inherited bindings:

- S1-098-CORE;
- S1-105;
- S2-024F-FACT-COMMUNICATION-INITIATIVE-COST;
- S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST;
- S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE;
- S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE;
- S2-044-OBJECTIVE-REVALIDATION-PRESERVED.

Participation responses must not consume/grant a second personal initiative, and new household reactions must not reopen same-cycle voluntary action.

### 9.4 Observer / diagnostic noninterference

Exact inherited bindings:

- S1-085;
- S1-META-04;
- S1-MUT-26;
- S2-050-EPISTEMIC-READ-NONINTERFERENCE.

New H/continuity/lineage readers must obey the same noninterference rule.

### 9.5 Locality

Exact inherited bindings:

- S1-META-03;
- S2-008-LOCALITY.

Add unrelated disconnected people/households: existing formation/continuity/lifecycle result must remain unchanged.

### 9.6 Fallback quarantine / nonsemantic IDs

Exact inherited bindings:

- S1-081;
- S1-META-02;
- S1-GLOBAL-FALLBACK;
- S2-033-CANDIDATE-RECOGNITION-CONTESTED;
- S2-052-NONSEMANTIC-ITERATION-METAMORPHIC;
- S2-053-ISOMORPHIC-ID-RENAMING.

Stable ID may break an explicitly accepted technical symmetry; it may not decide:

- CandidateOrganization equivalence;
- whether continuity exists;
- which Recognition proposition wins;
- lineage ambiguity;
- whether similar endpoints are the same H.

### 9.7 Cache / derived-state nonauthority

Exact inherited bindings:

- S1-084;
- S1-META-05;
- S1-MUT-24;
- S2-054-CACHE-NONAUTHORITY.

Any new participant-count summary, candidate index, continuity lookup, lifecycle projection, DerivedFrom/AncestorOf index, or reporting projection must remain rebuildable/non-authoritative unless accepted semantics explicitly say otherwise.

### 9.8 Stable-cycle / reaction closure

Exact inherited bindings:

- S1-074-IDEMP;
- S1-MUT-22;
- S1-MUT-23;
- S1-090-D;
- S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE;
- S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE.

New required coverage:

- VS-SFL-075;
- W-S3-09 same-cycle handoff;
- W-S3-16 VH-06 refresh/closure.

No intermediate participant count is a completed lifecycle state.

### 9.9 Current person-level relation semantics

At minimum rebind:

- S1-091-MEANING-SEPARATION;
- S1-093-GIFT-CONTROL;
- S1-093-KIN-GATE;
- S1-095-NO-RESIDENCE;
- S1-096-NO-HH;
- S1-096-MARRIAGE-CONTROL;
- S1-097-EVENTS;
- S1-MUT-04;
- S1-MUT-16;
- S1-MUT-17;
- S1-MUT-18;
- S1-MUT-19;
- S1-MUT-20;
- S1-MUT-21.

Household implementation must not silently redefine Gift/Help/Loan/Favour, marriage, Residence, kinship, attitude, failure meaning, revalidation, or initiative semantics.

S1-096-NO-HH is especially important: a Residence transition alone must still create/remove no SustainingParticipant association and create/destroy/split/merge no Household.

### 9.10 Trace/configuration truth

Exact inherited bindings:

- S1-086;
- S1-MUT-29;
- S2-042-SUBJECTIVE-TRACE;
- S2-045-PINNED-POLICY-NONCLAIM;
- S2-055-CONFIGURATION-PROVENANCE.

If a Slice-3 witness activates personal/response decision contexts, its traces must continue to expose actual subjective inputs/configuration and must not record only the chosen proposal.

### 9.11 Frozen authority integrity

The Slice-3 acceptance authority should require:

- Slice-1 frozen manifest version/blob/freeze identity unchanged;
- Slice-2 frozen manifest version/blob/freeze identity unchanged;
- all prior REQUIRED suites green;
- exact Slice-3 regression bindings reported independently of test-method ordering;
- no prior DEFERRED row silently rewritten merely because Slice 3 now exercises related semantics.

## 10. Cross-cutting prior Stage-3 obligations that newly fire

The following frozen Slice-1 DEFERRED Stage-3 items now become Slice-3 planning obligations without changing their frozen historical status:

- S1-075 — household formation reaction chain: **fires now**;
- S1-BND-FORMATION: **fires now**;
- S1-BND-LINEAGE: **fires now**;
- S1-META-09 — lineage predecessor-set ordering: **fires now**;
- S1-MUT-01 — co-residence-only formation: **fires now**;
- S1-MUT-02 — insufficient/same-cycle support formation: **fires now**;
- S1-MUT-05 — identity by overlap/similarity: **fires now**;
- S1-MUT-07 — participation entry without acceptance/warrant: **fires now**;
- S1-MUT-09 — inherited causal state through lineage: **fires now**.

The following remain later despite mentioning households:

- S1-104 — role-scoped response: Slice 4;
- S1-072 — provision priority: Slice 4;
- S1-BND-HOUSEHOLD-PROVISION: Slice 4 pending capability-boundary reconciliation;
- S1-BND-PROVISION-RECONSIDERATION: Slice 4;
- S1-MUT-06 — Inactive/Dissolved H emits household-mode action: exact action mutant requires Slice-4 household action, although Slice-3 lifecycle/no-resurrection is separately REQUIRED;
- S1-MUT-08 — household self-feedback clone: exact household-feedback path requires Slice 4, although Slice-3 duplicate-formation precedence is separately REQUIRED;
- S1-MUT-10 — household support as fresh lineage evidence: exact support path Slice 4;
- S1-MUT-11 / 12 / 13B — provision spend/backing/accounting: Slice 4 under current boundary;
- S1-MUT-14 / 15 — head scope/unanimity: Slice 4;
- S1-082 / S1-083 / S1-META-06 / S1-MUT-25 — engine checkpoint/recovery: Slice 5;
- S1-087 / S1-MUT-30 — rendered causal-explanation surface: still future/unexercised unless a later implementation slice explicitly activates it.

S1-MUT-03 — “global household/head recognition” spans two objective substrates. The frozen row must not be edited or split. Slice 3 needs new Household-only no-global-recognition evidence; the head portion remains Slice 4.

## 11. Generated / held-out evidence status

The cross-cutting Stage-3 package recommends bounded generated histories and held-out variants, but the frozen Slice-1 authority deliberately kept:

- S1-SUP-GENERATED;
- S1-SUP-SHRINK;
- S1-SUP-HELDOUT

visible as UNEXERCISED rather than retroactive completion gates.

This commission finds no accepted source that automatically promotes a general generated-history framework into Slice-3 completion authority. Therefore:

- generated-history infrastructure remains **STILL FUTURE / UNEXERCISED** unless the Slice-3 acceptance author deliberately makes it REQUIRED;
- if it becomes REQUIRED, VH-02 fires and generation validity may not be circularly filtered by the production formation/participation/continuity gate under test;
- canonical cards, boundary matrices, causal ablations, metamorphic pairs, focused mutant controls, fixture audits, and independent oracles remain mandatory regardless.

A small held-out isomorphic turnover/formation case would be useful assurance, but this report does not promote it to semantic authority.

## 12. Acceptance-authority readiness

### 12.1 Ready to draft

The accepted sources are sufficient to draft omission-detectable Slice-3 authority for:

- formation;
- formation ablations/boundaries;
- founder Recognition causality;
- no primitive Household / no hidden Members;
- formation-warrant provenance;
- participation entry/end;
- entry-side and exit-side ContinuationWarrant evidence;
- complete founder turnover;
- broken bridge;
- Inactive/reactivation;
- same-cycle bridge handoff;
- Dissolution/no resurrection;
- continuity-over-duplicate-formation precedence using Slice-3 lower-level evidence;
- Household existence/continuity Recognition using accepted epistemic routes;
- controlled division/consolidation lineage;
- lineage nonauthority/rebuild;
- reaction closure / VH-06;
- locality, iteration, ID-renaming, observer, cache/rebuild, fallback quarantine;
- exact inherited Slice-1/Slice-2 regression bindings.

### 12.2 Not ready to freeze

One current boundary item prevents a final Slice-3 freeze without reconciliation:

**Grounded collective capability / provision commitment boundary.**

The stage plan names grounded collective capability in Slice 3, but every canonical provision-creation/spend witness is currently head-dependent and the head role is assigned to Slice 4. Accepted sources do not authorize this verification mapper to invent a headless provision-request/commit path.

The acceptance manifest should therefore not freeze until the separate authority/gap reconciliation establishes one of these outcomes from accepted authority:

1. Slice 3 intentionally ends at household identity/continuity/lineage and all provision commitment/capacity cards remain Slice 4; or
2. a specific already-accepted headless provision-commitment/capacity path exists and is made executable in Slice 3, in which case the manifest must add the bounded commitment/capacity witness without pulling spend/head mechanics forward; or
3. a consequential missing semantic choice exists and is escalated through normal authority.

### 12.3 Conditional blockers, not automatic blockers

**LATER-01:** not an automatic acceptance-draft blocker if Slice 3 uses exactly one stable candidate referent and does not implement multiple-label reconciliation. It becomes a blocker before freeze/implementation if production can create/reconcile multiple candidate labels/evidence paths.

**VH-05:** can be verification hardening rather than a new semantic decision if the dissolution/continuity Recognition witness uses already accepted direct-participation/communication acquisition routes. If the only feasible test requires a new generic/event-specific nonparticipant observation entitlement, that exact route must be escalated rather than invented.

**LATER-03:** does not block bounded lineage when repeated predecessor rejoin/re-exit histories are excluded and visibly deferred.

## 13. Required terminal summary

### Triggered requirements

- VS-SFL-001 formation + all causal ablations/boundaries;
- VS-SFL-010 through 014 continuity/turnover/lifecycle;
- VS-SFL-053 label/diagnostic nonauthority;
- Household existence/continuity Recognition extension over the verified Slice-2 epistemic substrate;
- VS-SFL-020 through 026 controlled lineage;
- VS-SFL-075 formation reaction closure;
- household/lineage application of derived rebuild, observer noninterference, locality, nonsemantic iteration/ID renaming, fallback quarantine, and stable closure;
- frozen prior Stage-3 rows S1-075, S1-BND-FORMATION, S1-BND-LINEAGE, S1-META-09, S1-MUT-01, 02, 05, 07, 09 as newly applicable planning obligations;
- VH-01, VH-03, lifecycle side of VH-05, and VH-06.

### Deliberate deferrals

- full head-role / appointment / succession / dual-mode family -> Slice 4;
- mediated household Recognition gate cards that require head -> Slice 4;
- household-originated support/self-feedback cards -> Slice 4;
- provision creation/spend/reconsideration cards -> Slice 4 under current boundary, pending capability reconciliation;
- LATER-04 and LATER-05 -> Slice 4;
- engine checkpoint/recovery family and VH-04 -> Slice 5;
- LATER-02 unless actor departure becomes executable;
- LATER-03 repeated predecessor participation source selection until such histories are admitted;
- general generated/shrink infrastructure and rendered explanation surface -> still future/unexercised unless separately activated.

### New Slice-3 completion witnesses

- causal three-founder formation + ablations;
- no primitive H / no hidden Members structural and fixture audit;
- independent FormationWarrant provenance reconstruction;
- bilateral participation entry + negative prerequisites;
- explicit participation end + exit-side ContinuationWarrant;
- complete founder turnover with stable identity;
- broken-bridge similar-endpoint negative control;
- Inactive reactivation;
- same-cycle bridge handoff;
- Dissolution/no resurrection;
- continuity-over-duplicate-formation precedence;
- Household Recognition causality/staleness/update without passive sync;
- controlled division and consolidation lineage;
- lineage behavioral nonauthority/direct-vs-transitive rebuild;
- formation/continuity/lifecycle reaction closure + VH-06 derived-refresh control;
- representative cross-cutting metamorphic set.

### Exact inherited regressions

At minimum the Slice-3 authority must explicitly bind the IDs listed in `9, including:

- S2-001 through the cited objective/subjective/no-sync set;
- the exact S2 communication/provenance/staleness set S2-020F/R through S2-033 identified in `9.2;
- S1-098-CORE / S1-105 initiative-response accounting;
- S1-085 / S1-META-04 / S1-MUT-26 / S2-050 observer noninterference;
- S1-META-03 / S2-008 locality;
- S1-081 / S1-META-02 / S1-GLOBAL-FALLBACK / S2-052 / S2-053 fallback/ID quarantine;
- S1-084 / S1-META-05 / S1-MUT-24 / S2-054 cache nonauthority;
- S1-074-IDEMP / S1-MUT-22 / S1-MUT-23 and S2 receipt-no-reactivation stable-closure protections;
- S1-091-MEANING-SEPARATION, S1-095-NO-RESIDENCE, S1-096-NO-HH, S1-096-MARRIAGE-CONTROL, and the failure/revalidation rows identified in `9.9;
- S1/S2 trace/configuration truth and both frozen-manifest integrity baselines.

### Acceptance-manifest blocker status

**DRAFTABLE NOW / NOT FREEZABLE YET.**

Primary blocker: resolve the Slice-3/Slice-4 grounded-capability boundary because the canonical provision path currently requires the Slice-4 head role.

Conditional blockers:

- LATER-01 only if implementation creates/reconciles multiple candidate labels/evidence paths;
- VH-05 only if the chosen dissolution/continuity Recognition witness would require a new observation entitlement rather than already accepted direct-participation/communication provenance.

No other verification-authority blocker is established by this commission.
