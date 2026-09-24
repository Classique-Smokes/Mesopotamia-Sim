# SFL v0 Slice 4 Discovery B — Implementation Surface Map

**Status:** DISCOVERY / IMPLEMENTATION ARCHAEOLOGY / NON-AUTHORITATIVE  
**Task:** tasks/research/SFL_V0_SLICE4_DISCOVERY_B_IMPLEMENTATION_SURFACES.md  
**Repository:** Classique-Smokes/Mesopotamia-Sim  
**Branch:** research/slice4-implementation-surface-return  
**Exact canonical-main base:** a7a9bbcdc86d4684762efd203b20225b64b001b7  
**Scope:** map the verified promoted Slice-3 kernel against accepted Slice-4 representative/head-role, scoped authority, dual-mode decision, provision-use, and mediated-marriage requirements.  
**Explicit non-goal:** this return does not modify production code, select a concrete schema, invent same-cycle authority precedence, broaden observation semantics, or freeze Slice-4 acceptance applicability.

---

## 1. Baseline and executive finding

The exact base above records IMP-0001 / Slice 1, IMP-0002 / Slice 2, and IMP-0003 / Slice 3 as VERIFIED COMPLETE, with the Slice-3 post-implementation observation closed and Slice-4 preimplementation discovery active. Coding is not yet authorized.

Primary authority and evidence consulted independently:

- AGENTS.md, 00_START_HERE.md, and plans/CURRENT_PHASE.md;
- accepted SPEC-SFL-0001 and ADR-0001 through ADR-0005;
- the complete current src/Mesopotamia.Sim production surface;
- current acceptance-test infrastructure, especially the Slice-3 Household scenarios/oracles and cross-cutting invariant/fallback checks;
- final Slice-1, Slice-2, and Slice-3 completion/promotion records;
- research/technical/IMP-0003/IMP-0003_FUTURE_LESSONS_INDEX.md;
- RUN-0003 Household Pause Master Architect reconciliation;
- HEAD_ROLE_AND_DUAL_MODE_FAMILY.md;
- PROVISION_GROUNDING_FAMILY.md;
- RECOGNITION_INFORMATION_FAMILY.md;
- RESOLUTION_REACTION_FAMILY.md;
- DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md;
- registers/TRES-0010_DEFERRED_GAP_LEDGER.md.

### Executive finding

**Slice 4 appears to be a SUBSTANTIAL KERNEL EXTENSION within the accepted architecture, not an architecture redesign.**

The promoted Slice-3 kernel already contains the correct architectural anchors:

- a stable, explicit Household identity independent of its participants;
- provenance-bearing SustainingParticipant associations and continuity warrants;
- actor-specific Household Recognition with exact evidence identities;
- deterministic proposal / response / revalidation / commit;
- a separate authoritative Household state partition;
- same-cycle detached dependency replay with semantic-identity normalization;
- provision commitments as person-backed authority and derived capacity rather than treasury state;
- stable-cycle reaction closure and lifecycle publication;
- semantic history with causal references and rule/configuration provenance;
- immutable observation surfaces and independent acceptance-oracle infrastructure.

What Slice 4 adds crosses several kernel boundaries simultaneously:

1. a persistent office identity whose occupant can turn over without changing H or the role;
2. multilateral nomination / consent / unanimity transitions;
3. actor-specific head-role Recognition with staleness and Contested states;
4. one separate Household initiative through the head while preserving that person's personal initiative;
5. endogenous provision solicitation/reconsideration and scoped collective spending;
6. atomic fixed-rank contributor debits and mediated-marriage effects;
7. role-aware same-cycle dependency analysis, including prospective nominees and authority-destroying transitions.

Those are too broad for a bounded data-only extension, but none requires abandoning ADR-0004's deterministic reference kernel. The existing state, epistemic, proposal, resolver, projection, and history seams are reusable if extended without collapsing the distinctions accepted authority deliberately preserves.

Two deferred semantic triggers are now directly in the Slice-4 path:

- **LATER-04** — authority-destroying transition versus an already accepted authority-dependent action in the same cycle;
- **LATER-05** — mediated-marriage nested response / authority topology beyond the currently accepted route wording.

They must not be replaced by implementation convenience or technical ID ordering.

---

# A. Reusable Slice-3 substrate

## A1. Stable Household identity and lifecycle — CLEAN EXTENSION SEAM

HouseholdState.cs already represents Household as an independently identified record with Formation warrant identity, lifecycle, lifecycle event, and lifecycle semantic time. Participation turnover never changes HouseholdId. Continuity is explicit through warrants rather than endpoint similarity.

This is exactly the correct anchor for the accepted persistent HouseholdHeadRole.

Preserve:

- HouseholdId remains distinct from role identity;
- role identity remains distinct from occupant PersonId;
- lifecycle remains distinct from identity;
- appointment/succession does not recreate H;
- vacancy does not dissolve H;
- complete participant turnover continues to use existing Household continuity semantics.

Complexity level: **moderate and well-bounded**. Household identity itself does not need redesign.

## A2. Current/historical SustainingParticipant associations — CLEAN SEAM WITH ROLE SIDE EFFECTS

HouseholdState already retains current and ended SustainingParticipant associations with explicit Origin and End warrant references. HouseholdExecution ends only the typed association and preserves lower-level person relations.

This gives Slice 4 authoritative answers to:

- who may nominate;
- who may be nominated;
- who must participate in unanimous appointment/succession acceptance;
- whether a current occupant remains eligible;
- when occupant participation end must vacate the role;
- whether H is Active enough to emit a Household initiative.

The existing association state should remain the authority for participation eligibility. A new universal Members set would duplicate and weaken the accepted model.

Complexity level: **clean query seam, but role-vacancy reaction pressure is high** because an exit may now destroy office authority and invalidate accepted Household actions.

## A3. Actor-specific Household Recognition and communication — CLEAN EPISTEMIC SEAM

EpistemicState already keeps KnownFact identity/provenance separate from derived HouseholdRecognition. Household existence does not globally synchronize actors. Communication moves only sender-held evidence and preserves underlying event order plus communication hops.

This is the correct pattern for head-role Recognition:

- objective occupant state must not imply actor knowledge;
- being a current participant must not by itself grant every transition update;
- occupying the role must not create a separate omniscient mind;
- transition participants may directly acquire the new role proposition;
- outsiders remain stale until an accepted observation/communication route supplies newer evidence;
- incomparable incompatible evidence must remain Contested rather than being decided by sender ID, arrival order, or role authority.

Complexity level: **substantial but proven**. Slice 3 already paid the cost of exact evidence identities and actor-causal acquisition. Slice 4 should extend that pattern rather than create another information subsystem.

## A4. Exact evidence identity/provenance — REUSE / PRESERVE

KnownFact retains EvidenceId, proposition, acquisition route, origin source/event/order, and communication hops. Slice-3 conformance repairs established that final Recognition status alone is insufficient; exact evidence references and freshness matter.

This is directly reusable for:

- nomination/appointment/succession participant Recognition;
- stale predecessor-head evidence;
- explicit correction to successor Recognition;
- vacancy/revocation evidence;
- mediated-marriage head/scope recognition gates;
- independent reconstruction of role warrants/events.

Complexity level: **high but already required**. New role facts must participate in the same exact-reference discipline.

## A5. Semantic event history / WarrantStamp / causal references — CLEAN SEAM

SemanticEvent and WarrantStamp already carry stable event identity, Cycle/ReactionIndex, causes, participants, action, rules version, configuration version, and technical-fallback disclosure.

Slice 4 can reuse this history contract for role transitions and provision/material-use provenance, provided the new state records name their exact supporting proposal/response/evidence events rather than plausible-looking field values.

Preserve the separation:

- current typed state is authoritative;
- semantic history supplies provenance and explanation;
- observer history must not become a hidden behavior input.

Complexity level: **clean representation, high oracle burden**.

## A6. Proposal / response / resolution / immediate revalidation — REUSE, MAJOR EXTENSION PRESSURE

Execution.RunCycle already performs the accepted broad flow:

maintenance → common decision snapshot → deliberation → response → accepted-attempt collection → dependency analysis → immediate revalidation → commit/failure → automatic closure → stable publication.

This architecture should remain. Office actions must not gain a privileged mutation path.

Current reusable properties:

- feasibility precedes voluntary response;
- accepted attempts may still become InvalidatedAtResolution;
- response does not consume the target's personal initiative;
- action-relevant preconditions are checked again immediately before commit;
- committed state is immediately visible to later resolution/reaction work;
- no fresh voluntary reactivation occurs before stable closure.

Complexity level: **high** because the current pipeline assumes one voluntary proposal per person and mostly one response target per proposal. Slice 4 invalidates both assumptions in specific bounded ways.

## A7. Same-cycle dependency grouping and counterfactual fallback — REUSE, ALREADY SUBSTANTIAL

ResolutionDependencies.cs plus HouseholdResolution.cs already identify potentially interacting accepted proposals, replay bounded components against copied state, compare outcomes/final projection, and disclose technical fallback only when order is consequential.

HouseholdProjection.cs already normalizes detached event/relation/evidence allocation identities through semantic causal origins. This was a hard-won Slice-3 repair: raw allocated IDs cannot be treated as proof that two equivalent histories are socially different.

This machinery is the right broad architecture for Slice 4, but it must learn about:

- role/occupancy state;
- prospective nominees/holders;
- authority-scoped actions;
- provision contributors and debit vectors;
- new head-recognition evidence;
- reconsideration baselines;
- mediated-marriage consequences.

Complexity level: **very high**. This is one of the most sensitive Slice-4 surfaces.

## A8. Rule/configuration provenance — REUSE / PRESERVE

Simulation.RulesVersionFor and HouseholdEvent already distinguish actual exercised rule context from caller-supplied scenario configuration labels.

Slice-3 review explicitly repaired scenario-label-dependent rule attribution. Slice 4 should continue that discipline:

- personal action records describe the personal rule context actually exercised;
- Household initiative records describe the Household/head rule context actually exercised;
- mixed personal + office actions in one cycle may legitimately carry different RulesVersion values;
- role transitions and role Recognition evidence must cite the rule version that produced them.

Complexity level: **clean seam, easy to regress if shortcuts are taken**.

## A9. Provision commitment state and derived mobilizable capacity — CLEAN SUBSTRATE, NOT YET CAPABILITY

HouseholdProvisionCommitment already binds Person → Household through a sustaining association and can be terminated on participation end/dissolution. HouseholdSnapshot.MobilizableCapacity recomputes from current commitment validity, personal grain, reserve, and NeedsGrain.

Already correct:

- grain remains personal;
- there is no Household treasury;
- SustainingParticipant alone is not material access;
- capacity is derived, not separately authoritative;
- dissolution/exit can terminate backing without confiscating grain.

What is deliberately absent:

- endogenous commitment request/acceptance;
- reconsideration state;
- spending authorization;
- contributor allocation/debit;
- household support;
- mediated-marriage dowry.

Complexity level: **clean state/query seam; major execution extension remains**.

## A10. Stable closure and lifecycle publication — REUSE / PRESERVE

HouseholdExecution.CloseHouseholds publishes lifecycle only after compatible voluntary transitions and immediate continuity reactions have resolved. Intermediate participant counts are not published as completed lifecycle state.

Slice 4 must preserve this stable-boundary discipline for:

- role vacancy caused by participant exit;
- role occupancy changes;
- H Active→Inactive/Dissolved effects on Household initiative;
- provision commitment termination;
- actor-visible role Recognition updates;
- cycle-level summaries.

The exact microstep placement of role reactions is engineering-local only where accepted semantics already determine the result. It cannot be used to smuggle in an answer to LATER-04.

Complexity level: **substantial but reusable**.

## A11. Read-only verification/observation access — REUSE, WITH KNOWN INHERITANCE BREAKPOINTS

Simulation exposes immutable WorldSnapshot, EpistemicSnapshot, HouseholdSnapshot, History, and DecisionHistory. Acceptance code has InternalsVisibleTo rather than production-only mutation APIs.

This is the right observation model for Slice 4.

However, current Slice-3 tests contain several implementation-era assumptions that cannot simply remain literal after the later feature is added:

1. CanonicalThreeFounderCausalFormation currently asserts that no type named HeadRole or HouseholdDecisionContext exists anywhere in the assembly. Slice 4 must introduce the semantics that this test intentionally excluded in Slice 3. A later regression cannot preserve that literal type-absence check while also implementing Slice 4.
2. S3-093's structural test freezes the exact private-field inventory of HouseholdState. The frozen manifest itself says any necessary lossless adaptation of an exact private-field-inventory regression must be separately reviewed before coding; it may not be deleted or loosened for convenience.
3. HouseholdOracle currently asserts that every event whose Kind starts with Household or Sustaining carries no material changes. Legitimate Slice-4 Household support/dowry events can carry material debits/credits. Naming new material events to evade this test would be a verification cheat; the oracle contract must be extended/reconciled losslessly.
4. HouseholdOracle currently requires every HouseholdProvisionCommitment to have nonempty ProvisionFixtureProvenance, because Slice 3 admits commitments only as a controlled prerequisite. Slice 4 introduces endogenous request/acceptance provenance. The later oracle must distinguish fixture-created commitments from endogenous commitments and reconstruct each from its permitted source.

These are verification-compatibility pressures, not permission to weaken frozen semantics.

---

# B. Missing Slice-4 state/types

The table identifies semantic pressure only. Concrete classes, collections, files, and encoding remain engineering-local.

| Required concept | Current state | Slice-4 semantic pressure |
| --- | --- | --- |
| Persistent HouseholdHeadRole identity | Absent | **HIGH-CONFIDENCE.** One persistent role per H, created with H, independently identified, initially vacant. Role identity must not derive from occupant PersonId or be replaced on succession. |
| Vacancy / occupancy | Absent | **HIGH-CONFIDENCE.** At most one occupant. Vacancy preserves H and valid commitments but emits no Household initiative. Inactive H also emits none. |
| Appointment/succession provenance | Absent | **HIGH-CONFIDENCE.** Result must be independently reconstructable from nomination, nominee acceptance, unanimous current-SP acceptance/recognition, role/H identity, and semantic time/rule version. Exact record shape is local. |
| Head-role factual/Recognition proposition | Absent | **HIGH-CONFIDENCE.** Must bind the continuing H/role, current holder or vacancy, and relevant scope strongly enough for stale/new evidence and Contested state. Objective occupancy must not auto-sync actors. |
| HouseholdDecisionContext | Absent | **HIGH-CONFIDENCE.** One H initiative through occupied head P, separate from P's personal context, same committed decision snapshot, separate scoring and trace. |
| Household initiative identity/context on proposal/history | Absent | **HIGH-CONFIDENCE.** Resolution/history must know that P is cognitive carrier while H/role is the authority context. Person Actor alone is insufficient to represent this distinction robustly. |
| Provision solicitation state | Only fixture-created commitment | **HIGH-CONFIDENCE.** Head may request commitment from non-contributing SP; acceptance creates authoritative backing without moving grain. |
| Reconsideration cooldown/baseline | Absent | **HIGH-CONFIDENCE.** After refusal, repeat eligibility requires both three full cycles and one accepted relevant context change. Baseline must retain enough semantic state to prove both conditions without inventing extra dimensions. |
| Collective support proposal/effect | Absent | **HIGH-CONFIDENCE.** Only 1-grain support to eligible needy current SP, under Active H + valid occupied role + scope + backing. |
| Fixed-rank contributor allocation | Capacity query only | **HIGH-CONFIDENCE.** At precommit, rank valid contributors once by exposed capacity desc; exact tie by disclosed stable PersonId fallback; debit fixed order; no rerank, partial spend, reserve penetration, or double debit. |
| Mediated-marriage route | Direct strong-like marriage only | **HIGH-CONFIDENCE, WITH LATER-05 ESCALATION.** Must remain distinct from direct bypass; requires groom's bride-H fact, H recognition, head/scope recognition, head acceptance, dowry capacity, direct contributor→groom material effect, marriage, and groom→head favour. |
| Role-specific history/provenance | Generic event/history only | **HIGH-CONFIDENCE EXTENSION.** Consequential records must retain proposer/target/role context, responses, validation, effects, causes, rules/config, and fallback markers. |

### B1. Where role state should not go by semantic shortcut

The role must not be represented solely as a HeadPerson field on Person or as a derived selection from current participants. ADR-0001 requires independently referable continuing arrangements to have independent identity where terms/state/history are independently referenced.

The exact storage partition is engineering-local. There is a practical inherited-verification constraint, however: direct expansion of HouseholdState's exact private-field inventory fires the S3-093 adaptation requirement. That is not a reason to hide role authority elsewhere; it is a reason to reconcile the structural evidence before coding whichever clean authoritative partition is chosen.

---

# C. Decision-generation / dual-mode surfaces

## C1. Current hard assumption that becomes invalid

Execution.RunCycle currently rejects any CycleInput whose explicit Proposals contain more than one proposal with the same PersonId Actor:

"At most one personal initiative per person/cycle."

It also rejects giving the same person both an explicit proposal and an autonomous PersonalPolicy in that cycle.

That is correct through Slice 3. It is insufficient for Slice 4 because accepted semantics require:

- P keeps one personal initiative;
- if P occupies the valid head role of Active H, H gets one separate Household initiative through P;
- the two contexts deliberate from the same committed snapshot;
- compatible actions from both contexts may commit;
- the Household initiative does not consume or grant another personal initiative.

Therefore the cycle/input/proposal model must distinguish **initiative authority/context**, not merely count proposals by PersonId.

A patch that simply relaxes the duplicate-Actor guard would be unsafe: it would also permit two personal initiatives unless the context distinction becomes explicit and mechanically enforced.

## C2. Proposal currently represents a person actor but no office authority context

Proposal currently contains ProposalId, PersonId Actor, and ActionTerms. SemanticEvent records proposal and participants, but no structured H/role origin.

For office actions, accepted semantics need both meanings:

- P is the person carrying cognition and non-office subjective knowledge;
- H through HouseholdHeadRole is the authority context whose scoped action is attempted.

The representation may extend Proposal, introduce a parallel bounded context, or encode the authority context elsewhere. The semantic requirement is that validation, history, dependency analysis, and independent verification can distinguish personal-P from H-through-P. A free-form Detail string alone is too weak to be the only authority-bearing distinction.

## C3. Preserve PersonalDecisionInputs as a non-omniscient boundary

PersonalDecisionInputs is a strong existing seam. It contains:

- own state;
- direct-party lower-level relations/claims;
- declared policy observations;
- actor epistemic state.

Personal generation/scoring does not receive the objective WorldSnapshot directly.

Slice 4 should preserve this personal boundary. Do not make the head's personal context omniscient merely because the same person occupies office.

The logical extension should have a separate Household-decision input boundary that can supply:

- authoritative H/role-scoped records that office semantics permit the role to use;
- the head person's own actor-specific subjective information for non-office knowledge;
- current provision/capability facts relevant to in-scope Household action.

This is a semantic separation requirement, not a mandate for a specific new class name.

## C4. Agency/scoring must remain separate by context

PersonalAgency currently generates and scores personal candidates using PersonalPolicy and ReferenceScorer.

Accepted Slice-4 semantics require a separate Household concern space:

- relieve eligible NeedsGrain;
- evaluate/fund mediated marriage;
- request provision backing/reconsideration.

Do not:

- reuse the head's PersonalPolicy score as the Household score;
- add a hidden second aggregation layer;
- let Household score modify the head's personal winner;
- let personal-score ties stand in for central-resolution fallback.

ReferenceScorer's exact-integer sum/selection utility can be reusable. The candidate generator and component meanings must remain context-specific.

## C5. Household candidate generation gates

A Household decision context must not activate unless all context-level requirements hold:

- H is Active;
- the persistent role is occupied;
- occupant remains a valid current SustainingParticipant;
- the action lies within accepted role scope.

Candidate-specific gates then additionally include the relevant target/recognition/provision/cooldown/material conditions.

Vacant or Inactive H must produce no Household initiative, not an inert Wait proposal.

Ordinary personal actions remain independently available to P even when the H context is absent.

## C6. Response contexts need bounded extension

Current response code assumes one ActionRules.Target and generates Accept/Decline (or called-favour fulfil/refuse) for that respondent.

Slice 4 introduces response meanings including:

- nominee acceptance;
- current sustaining-participant acceptance/recognition for appointment/succession;
- provision commitment acceptance/refusal;
- Household support request/authorization where the route requires a target choice;
- mediated-marriage authority acceptance/refusal where applicable.

The accepted model allows multiple response contexts for one person from the common snapshot without consuming personal initiative. That broad mechanism is reusable.

The implementation must not silently collapse unanimity into one target response or majority vote. If the exact multi-party response topology or same-cycle participant-set basis is not uniquely determined by accepted authority, escalate rather than inventing it.

## C7. DecisionTrace pressure

DecisionTrace currently identifies:

- PersonId Actor;
- optional ProposalId;
- Context string;
- Profile;
- candidate traces;
- SubjectiveInputs;
- TechnicalFallback.

For Slice 4, a Household trace must make it independently legible that:

- Context is H/role scoped;
- P is the cognitive carrier;
- Household candidates/components are separate from P's personal candidates/components;
- the actual H/role and occupant identity used are recorded;
- relevant actor-specific head/H recognition evidence is visible;
- rule/configuration version is truthful;
- scoring tie fallback remains distinguishable from central-resolution fallback.

Whether that requires new structured fields or a stronger typed context record is engineering-local. A context label that cannot be independently tied to H/role state would be too weak for accepted explainability.

---

# D. Role transition / recognition surfaces

## D1. Create one persistent vacant role with a newly formed H

Current TryForm creates:

- FormationWarrant;
- Household;
- founding SustainingParticipant associations;
- founder H Recognition;
- downstream lineage evaluation.

It does not create office state.

Slice 4 must extend the formation reaction so the resulting H has one persistent HouseholdHeadRole whose initial occupancy is vacant. It must not:

- select a founder automatically;
- infer the head from sex, age, grain, ID, founder order, kinship, or fixture order;
- make the role identity equal to H or Person identity.

The exact same-cycle event shape is local, but the role creation must be causally attributable to H formation and stable across all later occupant changes.

## D2. Nomination and eligibility

Accepted constraints:

- any current SustainingParticipant may nominate;
- nominee must be a current SustainingParticipant;
- outgoing head may nominate a successor before vacating.

Current HouseholdRules already has authoritative current-association queries and precommit revalidation for participation actions. The same pattern is reusable for nomination/appointment eligibility.

Important: prospective nominees/holders must enter dependency analysis before they become occupants. RUN-0003 specifically warns against current-holder-only grouping.

## D3. Nominee acceptance + unanimous current-SP acceptance/recognition

No existing action is a multilateral institutional transition. Current bilateral participation proposals have one target response.

Slice 4 must represent enough proposal/response/provenance state to establish:

- who nominated whom for which persistent role/H;
- nominee consent;
- acceptance/recognition by every required current SustainingParticipant;
- no missing participant;
- no majority fallback;
- no stable-ID fallback to manufacture consent;
- immediate revalidation of action-relevant eligibility before commit.

The role transition's independent oracle must reconstruct the exact participant/evidence set, not only check that a plausible occupant appeared.

## D4. Appointment does not alter H identity or personal state

Successful appointment changes only role occupancy plus accepted direct Recognition/history consequences. It does not by itself:

- create a new Household;
- move residence;
- move grain;
- create/delete provision commitments;
- create arbitrary relation/attitude changes;
- grant generic sovereignty.

The current typed-state/history separation is a clean basis for this.

## D5. Participation end vacates current occupant

CommitHousehold currently ends the SustainingParticipant association, creates ParticipationEndWarrant, terminates that person's provision commitment, and continues/re-evaluates H.

Slice 4 adds a required causal consequence:

- if the exiting person occupies HouseholdHeadRole(H), that same role becomes vacant;
- H identity persists;
- other valid commitments persist unless normal dissolution rules terminate them;
- Household initiative is suspended while vacant;
- direct vacancy evidence goes only to actors with an accepted acquisition route.

The order of vacancy, lifecycle change, and other accepted same-cycle authority-dependent actions is exactly where LATER-04 becomes material. Do not settle it by insertion order.

## D6. Succession A→B uses the same role identity

Accepted succession preserves:

- H ID;
- role ID;
- valid unrelated commitments;
- lower-level person state.

It changes occupant A→B through a provenance-bearing transition. Transition participants directly recognize the new role state. Outsiders with old A evidence remain stale until accepted newer evidence arrives.

Any implementation that allocates a new role for B has confused occupancy with office identity.

## D7. Head Recognition must remain actor-causal

RUN-0003's strongest information lesson remains binding: institutional status is not information entitlement.

Do not infer "knows current head" from any of:

- current SustainingParticipant;
- being the current head;
- co-residence;
- access to HouseholdState;
- being a provision contributor;
- observing a final HouseholdSnapshot.

Only accepted direct participation/observation/communication routes may supply the role proposition.

This especially matters after succession and vacancy. Objective state can be B-current while outsider X still recognizes A from older evidence. That stale state is expected until displaced/contested by accepted evidence.

---

# E. Resolution / dependency pressure

## E1. Current dependency scope is too current-association-centric for role transitions

HouseholdResolutionFallbacks currently builds Scope from:

- proposal actor;
- ActionRules target;
- current material people;
- Households containing those people through current associations;
- candidates containing those people;
- explicitly targeted Household;
- communicated HouseholdExistenceFact.

That is adequate for Slice 3. It is insufficient for Slice 4 unless extended, because a prospective nominee or other role-transition participant can affect the outcome before becoming an occupant.

Scope/dependency must include the semantically relevant H/role and prospective actors explicitly rather than relying on "person is already current holder" lookup.

## E2. PotentialDependency does not know role or collective material semantics

ResolutionDependencies.PotentialDependency currently covers:

- epistemic dependency;
- residence dependency;
- direct-marriage capacity;
- favour creation/retirement;
- overlap in ordinary MaterialPeople.

MaterialPeople currently understands ordinary Transfer or Farm only.

Slice 4 must account for dependency through:

- role occupancy/vacancy;
- participant eligibility for nomination/unanimity;
- old/new head authority;
- H lifecycle;
- commitment creation/termination;
- cooldown/context baselines;
- contributor pools/capacity;
- fixed-rank debit vector;
- support recipient;
- mediated bride/groom/head/favour state;
- head Recognition evidence.

If these are missing, detached replay can falsely classify interacting histories as commuting or fail to mark a true technical fallback.

## E3. HouseholdRules.Order currently contains only one semantic precedence

HouseholdRules.Order topologically enforces the accepted Slice-3 bridge-handoff rule: a valid entry depending on bridge P occurs before P's accepted participation exit.

There is no current semantic precedence for:

- old-head action vs vacancy;
- old-head action vs succession;
- new-head action vs succession;
- role transition vs H Active→Inactive;
- provision request/commit vs participant exit;
- support vs dowry vs personal transfer.

Some Slice-4 priorities are already accepted:

- eligible NeedsGrain Household support;
- then other valid Household provision expenditure;
- then ordinary voluntary personal transfer.

But LATER-04 explicitly marks authority-destroying transition ordering as unresolved before these behaviors coexist. HouseholdRules.Order must not grow a guessed precedence based on proposal ID or current code convenience.

## E4. A separate Household initiative invalidates actor-uniqueness assumptions

The resolver currently receives accepted Proposal objects all keyed to person Actor. HouseholdRules.Order and outcome lookup assume ProposalId uniqueness, which is fine, but RunCycle's actor-level cardinality validation occurs before resolution.

After dual mode exists, dependency grouping must be able to consider:

- P's personal proposal;
- H-through-P Household proposal;
- responses by P to others;
- other role/participation transitions;

all from the same committed decision snapshot without treating them as duplicate personal initiatives.

The resolver should still resolve attempts centrally. Do not pre-reserve resources for H simply because the H context selected an action.

## E5. HouseholdProjectionKey must grow with every future-influencing role dimension

Detached Household replay compares a normalized semantic projection containing:

- people/relations;
- Households;
- formation/association/entry/exit/continuation/lineage warrants;
- commitments;
- actor evidence/recognition and evidence precedence.

Slice 4 must include any new authoritative state whose difference can change later resolution/closure, including:

- role identity and occupancy;
- appointment/succession/vacancy provenance;
- provision solicitation/reconsideration baselines;
- newly created commitments;
- exact contributor debit/material effects;
- actor-held head-role evidence and Recognition;
- any pending role transition state if such state is introduced.

The Slice-3 v2/v3 history is directly relevant: detached replay once produced false TechnicalFallback because allocation-sensitive identities differed. New role/warrant/evidence IDs need the same semantic-origin normalization discipline. Raw allocation order must not decide whether authority histories are socially different.

## E6. Commit dispatch assumes Household actions are non-material participation transitions

Execution.Commit currently routes:

- CommunicateClaim → CommitCommunication;
- HouseholdRules.Target action → CommitHousehold;
- everything else → ordinary EvaluateTransaction.

CommitHousehold currently mutates Household/epistemic state but not WorldState material state. HouseholdOracle even enforces this for Slice-3 event names.

Slice 4 adds Household-scoped actions with material effects. They need a transaction boundary that can atomically validate and commit both:

- Household authority/provision state;
- ordinary WorldState grain/marriage/favour effects.

A split commit where contributor debits happen before marriage/favour validation, or where role state commits while material state fails, would violate atomicity.

Representation is local; the semantic requirement is one all-or-nothing authoritative effect.

## E7. H Active→Inactive/Dissolved changes are now action-relevant authority preconditions

Slice 3 lifecycle already publishes only at stable closure. Slice 4 adds a rule that Household collective action requires Active H.

Same-cycle participation changes can therefore change whether an accepted H action remains valid at precommit. Dependency analysis must include those prospective lifecycle/participant effects even if the stable public lifecycle value has not yet been published.

Do not read only the last published HouseholdLifecycle and ignore current authoritative associations during resolution.

## E8. Stale/Contested head Recognition belongs in both generation and revalidation

Mediated marriage and authority-channel use require actor-specific head/scope Recognition.

A proposal can be generated from the common decision snapshot using Recognition that is later displaced/contested by an earlier accepted same-cycle communication/role event. If that Recognition is action-relevant at commit, revalidation must see the authoritative epistemic state rather than the original snapshot.

Current communication revalidation already demonstrates this pattern through StillHolds. Slice 4 should extend the same principle, not freeze all authority knowledge at generation.

## E9. Semantic priority versus technical fallback

Technical fallback is permitted only after modeled semantic/domain priorities are exhausted.

Permitted example already accepted:

- exact equal exposed-capacity contributors within one expenditure may use stable semantic PersonId to order the initial fixed rank, with fallback disclosure.

Not permitted:

- stable ID selecting a head;
- stable ID substituting for unanimity;
- stable ID deciding which head claim is true;
- stable ID deciding an unresolved old-head/new-head social authority rule that LATER-04 has not defined;
- raw allocated role/warrant/evidence IDs deciding conflict.

---

# F. Provision / material-use surfaces

## F1. What Slice 3 already has

Slice 3 supplies:

- authoritative HouseholdProvisionCommitment relation;
- binding to Person, H, and originating SustainingParticipant association;
- termination on participant exit and H dissolution;
- derived ExposedCapacity;
- derived MobilizableCapacity;
- personal grain ownership;
- protected reserve semantics;
- NeedsGrain contributor exclusion;
- no treasury;
- fixture-provenance path solely for Slice-3 prerequisite testing.

This is substrate only.

## F2. Endogenous provision request/acceptance

Slice 4 must add the accepted acquisition route:

- valid head requests provision backing from a non-contributing current SP;
- target response is separate from personal initiative;
- acceptance creates one commitment;
- personal grain does not move at acceptance;
- commitment's provenance refers to the actual request/response/commit history;
- head authority and participant status are revalidated before commit.

Do not preserve ProvisionFixtureProvenance as the only provenance model by pretending endogenous commitments are fixtures.

## F3. Reconsideration cooldown + context baseline

After a refusal, another request requires BOTH:

1. three full cycles elapsed; and
2. a relevant context change since refusal in exactly one of the accepted dimensions:
   - person's grain/NeedsGrain;
   - attitude toward head;
   - head occupant;
   - new Household material need.

The implementation therefore needs authoritative provenance/baseline sufficient to test both conditions.

Do not:

- use elapsed cycles alone;
- treat any irrelevant state mutation as context change;
- reset the cooldown silently on read;
- derive baseline from observer history at decision time;
- let occupant turnover erase the original refusal record without trace.

Exact baseline record shape is local.

## F4. One-grain Household support

A valid support effect requires:

- Active H;
- occupied valid head role;
- eligible needy current SustainingParticipant;
- required head Recognition route for a participant-initiated request;
- sufficient current provision backing/capacity;
- central resolution/revalidation.

On commit:

- backing contributor grain decreases exactly once;
- recipient grain increases exactly once;
- no Household treasury is debited;
- recipient need clears through ordinary material semantics;
- history links H/role, backing commitments, contributor debit vector, recipient credit, and causal proposal/authorization.

Household-originated support must remain excluded from ordinary lower-level support evidence used as independent proof of formation/continuity/fresh lineage.

## F5. Fixed-rank multi-contributor expenditure

This is a new material transaction algorithm with accepted semantics:

1. at precommit, compute every currently valid contributor's exposed capacity;
2. sort once by capacity descending;
3. use stable semantic PersonId only for exact capacity ties;
4. debit each contributor up to validated capacity in that fixed order until fully funded;
5. do not rerank after a debit;
6. if total validated capacity is insufficient, commit nothing.

The exact debit vector is semantic history.

Cheat risks:

- one-grain mini-transactions that can partially commit;
- dynamic reranking after each unit;
- container iteration order;
- debiting a commitment twice through overlapping paths;
- penetrating reserve;
- debiting a NeedsGrain contributor;
- using a cached capacity that no longer matches personal state.

## F6. Mediated-marriage dowry

Current ProposeMarriage is only the mutual-strong-like direct route. ActionRules.Infeasible explicitly rejects it when the direct gate is unavailable.

Slice 4 must not weaken that direct action to become a mixed "direct or mediated" path based on objective H state. The mediated route has additional authority and subjective gates and should remain semantically distinguishable.

Required material/relationship result on a valid mediated commit:

- selected provision contributors are debited atomically;
- groom receives dowry directly;
- no H-owned grain appears;
- marriage is created;
- groom receives exactly one favour owed to mediating head;
- no commit if groom already owes head a favour or groom == mediating head;
- female head may mediate her own marriage;
- all effects share causal provenance.

LATER-05 remains the explicit stop if the exact nested response/authority topology required to reach that commit is not already uniquely determined.

## F7. Priority

For competing material uses, accepted priority is:

1. eligible NeedsGrain Household support;
2. other valid Household provision expenditure;
3. ordinary voluntary personal transfer.

This priority belongs in central resolution, followed by immediate revalidation after each committed effect.

An invalid higher-priority attempt does not reserve resources forever or block a still-valid lower-priority attempt. Debt/favour does not silently reserve grain.

---

# G. Likely source pressure

Classification refers to current files/logical responsibilities, not a mandated file layout.

| Surface | Classification | Slice-4 pressure |
| --- | --- | --- |
| src/Mesopotamia.Sim/HouseholdState.cs | **HIGH-CONFIDENCE CHANGE OR ADJACENT AUTHORITATIVE PARTITION** | Role identity/occupancy, role-transition provenance, endogenous commitment provenance, cooldown/baseline state. Direct field expansion fires S3-093 exact-inventory adaptation; do not hide authority merely to dodge the test. |
| src/Mesopotamia.Sim/HouseholdExecution.cs | **HIGH-CONFIDENCE CHANGE** | Create vacant persistent role on formation; appointment/succession/vacancy commits; participant-exit vacancy; direct role evidence acquisition; endogenous commitment creation; support/dowry execution/closure interactions. |
| src/Mesopotamia.Sim/HouseholdRules.cs | **HIGH-CONFIDENCE CHANGE** | New action targeting, eligibility, authority scope, nomination/unanimity, cooldown, support/dowry gates, contributor validity, accepted material priority. LATER-04 prevents guessed authority precedence. |
| src/Mesopotamia.Sim/HouseholdResolution.cs | **HIGH-CONFIDENCE CHANGE / HIGH COMPLEXITY** | Role/prospective-actor dependency scope; detached replay of role/material changes; outcome comparison; authority/epistemic revalidation. |
| src/Mesopotamia.Sim/HouseholdProjection.cs | **HIGH-CONFIDENCE CHANGE / HIGH COMPLEXITY** | Normalize role/warrant/evidence allocation identities; include role/cooldown/material/head-recognition state in semantic projection; avoid repeat of Slice-3 false-fallback defects. |
| src/Mesopotamia.Sim/EpistemicState.cs | **HIGH-CONFIDENCE CHANGE** | New bounded head-role proposition/Recognition subject, stale/new precedence, vacancy/succession evidence, Contested state. No global sync. |
| src/Mesopotamia.Sim/EpistemicExecution.cs | **HIGH-CONFIDENCE OR CONDITIONAL ON CLAIM ENCODING** | Communicate held head-role evidence/Recognition; exact payload/receipt provenance; direct transition acquisition. Do not add passive participant broadcast. |
| src/Mesopotamia.Sim/Simulation.cs | **HIGH-CONFIDENCE SMALL CHANGE** | Publish/access any new role state partition/snapshot; truthful RulesVersionFor for role/H actions and claims. |
| src/Mesopotamia.Sim/Execution.cs | **HIGH-CONFIDENCE MAJOR CHANGE** | Dual initiative cardinality by context; role-context proposals/history; multi-party responses; new central priority; revalidation; atomic cross-partition material commits. Current Actor uniqueness assumption becomes invalid. |
| src/Mesopotamia.Sim/Decisions.cs | **HIGH-CONFIDENCE CHANGE** | New role/provision/material action terms or context types; stronger role context in trace/proposal; bounded response meanings. Preserve direct-marriage meaning. |
| src/Mesopotamia.Sim/PersonalDecisionInputs.cs | **CONDITIONAL / PRESERVE BOUNDARY** | Personal input should remain personal. Do not inject omniscient H state. Likely new separate H input boundary rather than broadening this one. |
| src/Mesopotamia.Sim/Agency.cs | **LOGICAL LAYER HIGH-CONFIDENCE; CURRENT FILE CONDITIONAL** | Need separate Household candidate generation/scoring and policy/profile. ReferenceScorer may be reused; PersonalAgency should remain semantically independent. A new source file could carry the H-specific implementation. |
| src/Mesopotamia.Sim/ResolutionDependencies.cs | **HIGH-CONFIDENCE CHANGE / HIGH COMPLEXITY** | PotentialDependency and MaterialPeople are unaware of role/provision/H material effects. Must include authority, prospective actors, contributors, mediated marriage, and head evidence. |
| src/Mesopotamia.Sim/State.cs | **NO EXPECTED ROLE-AUTHORITY PRESSURE; CONDITIONAL MATERIAL HELPER PRESSURE** | Do not add head occupant as Person field. Lower-level grain/marriage/favour state remains authoritative endpoint of valid collective effects. Shared transaction helpers may need extension/refactor only. |
| src/Mesopotamia.Sim/MaterialRecovery.cs | **NO EXPECTED PRESSURE** | Maintenance/deadlock logic remains lower-level unless a concrete accepted material-deadlock interaction proves otherwise. |
| src/Mesopotamia.Sim/VerificationAccess.cs | **NO EXPECTED PRESSURE** | Existing InternalsVisibleTo already exposes internal seams to acceptance/unit tests. |
| src/Mesopotamia.Sim/README.md | **CONDITIONAL DOCUMENTATION UPDATE AFTER IMPLEMENTATION** | Must eventually describe dual mode/role authority accurately, but no semantic role. |
| tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs | **HIGH-CONFIDENCE VERIFICATION-ADAPTATION PRESSURE** | Current S3-014 helper asserts HeadRole/HouseholdDecisionContext type absence. Later-slice regression must preserve "headless/no initiative at S3 boundary" meaning without prohibiting Slice-4 types. |
| tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs | **HIGH-CONFIDENCE VERIFICATION-ADAPTATION PRESSURE** | Current blanket no-material Household-event check and fixture-only commitment provenance assumptions are not valid for new S4 behavior. Extend independently; do not weaken by omission. |
| tests/Mesopotamia.Sim.AcceptanceTests/HouseholdWarrantOracle.cs | **REUSE + EXTEND OR ADD S4-SPECIFIC ORACLE** | Exact event/evidence replay pattern is valuable for role recognition and transition warrants. Preserve dependency independence and assertion adequacy. |
| tests/Mesopotamia.Sim.AcceptanceTests/InvariantOracle.cs | **HIGH-CONFIDENCE EXTENSION FOR S4 ACCEPTANCE** | Needs independent replay of collective debit vectors, reserve/no-double-debit, head cardinality, marriage/favour atomicity, and dual-context trace constraints. |
| tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs | **PRESERVE FROZEN AUTHORITY; WATCH REEXECUTION COMPATIBILITY** | Do not rewrite frozen classifications. Slice-4 applicability/inheritance must explicitly reconcile literal structural/type-absence assumptions that later feature addition invalidates. |
| current lower-slice acceptance suites | **REUSE AS REGRESSION** | Ordinary person actions, recognition, failure taxonomy, fallback quarantine, stable closure, and lower-level invariants must remain green in meaning. |

### G1. Known inherited-test breakpoints before code

These are concrete, not hypothetical:

- **S3-014 current executable witness:** assembly-wide absence of HeadRole and HouseholdDecisionContext. Slice 4 necessarily invalidates that literal implementation-era assertion.
- **S3-093 current executable witness:** exact HouseholdState private-field inventory. Directly adding role authoritative fields there trips the separately-reviewed adaptation clause.
- **HouseholdOracle no-material prefix assumption:** legitimate Household material events would fail it.
- **HouseholdOracle fixture-only commitment assumption:** endogenous Slice-4 commitments would fail it.

Do not "solve" these by semantic camouflage such as misleading event/type names or storing authority in opaque fields. Reconcile verification applicability/structure explicitly.

---

# H. Cheat / architecture hazards

| Temptation | Why it is attractive | Required guardrail |
| --- | --- | --- |
| Put head occupant directly on Person | Minimal field change | Persistent role has its own identity/history and is anchored to H; occupant turnover must not redefine person/H/role identity. |
| Derive head from stable ID/age/sex/grain/founder order | Deterministic and easy | Appointment requires nominee consent + unanimous current-SP acceptance/recognition. No automatic winner. |
| Majority vote | Easier multilateral response | Accepted rule is unanimity. Missing consent means no appointment. |
| Occupancy globally updates recognition | Engine already knows occupant | Objective state is not actor knowledge. Only accepted direct/observation/communication routes update actors. |
| Treat current participant set as information entitlement | Convenient because H already has associations | RUN-0003 explicitly disproves this shortcut. Current status does not imply knowledge of every institutional transition. |
| Office authority = personal authority | Same PersonId carries both contexts | H action is scoped authority through a persistent role; P's ordinary personal action remains separate. |
| Household initiative consumes personal initiative | Existing guard is one proposal/person | Slice 4 requires one personal P initiative plus one separate H initiative. Enforce per-context cardinality. |
| Create a separate omniscient Household mind | Makes Household candidate generation easy | Cognition/non-office knowledge remains P's actor-specific state; role/H only supply scoped authority/records. |
| Vacancy dissolves H | Simplifies authority state | Vacancy preserves H and commitments; it only suspends H initiative/mediation until valid occupancy. |
| Succession allocates a new role or H | Easy append-only transition | H ID and role ID persist; only occupant changes. |
| Head gets general sovereignty | Many operations can reuse office path | Scope is closed: provision request/reconsideration, permitted material uses, mediated marriage, succession. No residence/personal commands or arbitrary relations/attitude. |
| Provision backing becomes treasury | Simplifies spend accounting | Grain stays personal until spend; debit exact contributors atomically. No H-owned balance. |
| MobilizableCapacity becomes stored authority | Avoid recomputation | Derived capacity cannot create action authority and must reflect current backing/personal state. |
| Household action mutates directly before resolution | Role feels "authoritative" | Roles propose/attempt; authoritative mutation still goes through validation/resolution/commit. |
| Dependency grouping looks only at current holder | Cheap scope calculation | Prospective nominees/holders and other eligibility-affecting actors can create dependencies before occupancy. |
| Raw allocated role/warrant/evidence IDs distinguish histories | Convenient projection key | Normalize detached new identities through semantic causal origins; only established semantic IDs and accepted technical fallbacks may matter. |
| Direct ProposeMarriage is broadened to inspect H automatically | Reuses existing action | Direct strong-like bypass and mediated route have different subjective/authority/material semantics and must remain distinguishable. |
| Rename Household material events to evade old oracle | Keeps S3 test green | Verification camouflage is a cheat. Update/reconcile oracle applicability while preserving the old semantic claim. |
| Hide office state outside typed authority to preserve field-count test | Avoids S3-093 failure | Structural regression may be adapted only losslessly and explicitly. Authority must remain explicit, typed, inspectable, and non-derived. |

---

# I. Escalation triggers

The following discoveries are semantic/architectural escalation rather than coder discretion.

## I1. LATER-04 — authority-destroying transition race — FIRED

Slice 4 is the trigger condition: head/Household authority transitions and authority-dependent actions now coexist executably.

Escalate before coding any rule that must decide a same-cycle case such as:

- accepted old-head Household action versus old head's participation exit/vacancy;
- accepted old-head action versus valid A→B succession;
- new-head action whose authority becomes true only through same-cycle succession;
- authority-dependent action versus H becoming Inactive/Dissolved;
- provision request/spend versus authority loss.

Accepted immediate revalidation tells the implementation to re-check authority before commit. It does **not by itself** establish which of two otherwise accepted authority-changing/authority-using attempts receives semantic precedence.

Do not let proposal ID, container order, raw role ID, or detached replay's technical fallback silently become the missing social rule.

## I2. LATER-05 — mediated-marriage nested response/authority topology — FIRED before route execution

The accepted route defines strong substantive gates/effects, including that head acceptance is sufficient, but the deferred ledger explicitly preserves unresolved response/authority topology beyond the current wording.

If implementation needs to decide:

- exact proposal target/routing among groom, bride, and head;
- whether/where a bride response context exists in the mediated route;
- how a female head self-mediating her own marriage is represented without self-authorizing;
- how nested acceptance interacts with head succession/vacancy in the same cycle;

stop and close only that bounded semantic question through normal authority.

## I3. Inherited S3 structural/type-absence evidence needs lossless adaptation

Before production code introduces the office types/state that make S3-014/S3-093 literal witnesses false, reconcile the inherited verification evidence.

This is not a new social semantic decision. It is nevertheless not coder permission to delete/loosen a frozen regression. S3-093 explicitly requires separate review of a necessary exact-field-inventory adaptation.

## I4. Head Recognition requires a proposition distinction not determined by accepted evidence semantics

If implementation cannot represent stale A-head versus current B-head, vacancy, and relevant scope using the existing bounded evidence/precedence model without adding:

- generic nonparticipant observation;
- trust/reputation;
- global synchronization;
- arbitrary conflict winner;

escalate the missing distinction. Do not invent a universal epistemic framework.

## I5. Appointment unanimity becomes ambiguous under same-cycle participant changes

If "current sustaining participants" cannot be uniquely determined for an appointment/succession because entry/exit/continuity transitions coexist in the same cycle and accepted precedence does not determine which participant set controls the commit, stop.

Do not freeze the decision-snapshot participant set or use the final stable participant set merely because one is easier. Treat this as an action-precondition race requiring authority-level reconciliation.

## I6. Role vacancy evidence needs a new observation entitlement

VH-05's head-vacancy half reaches its trigger in Slice 4. If a required scenario needs someone who did not participate in the transition to learn vacancy/succession and no accepted observation/communication route exists, do not invent proximity or participant omniscience.

## I7. Household material transaction cannot be made atomic across authoritative partitions

If the chosen implementation cannot guarantee all-or-nothing:

- authority validity;
- provision capacity;
- fixed contributor debit vector;
- recipient/groom credit;
- marriage/favour effects where applicable;

without partial commit, that is an architecture/transaction-boundary problem requiring explicit review. Do not accept compensating history or rollback-by-convention as equivalent semantics.

## I8. New dependency state cannot be represented in detached replay without allocation artifacts

If role/warrant/evidence allocation identities cause order-sensitive projection differences that are not social differences, stop and normalize through semantic causal origins as learned in Slice 3.

Do not broaden TechnicalFallback to cover projection-key weakness.

## I9. Provision reconsideration requires a context-change category beyond the accepted closed list

The accepted list is specific. If implementation discovers it needs another trigger such as elapsed time, unrelated relation changes, residence alone, or generic "world changed", that is new semantics.

## I10. Mediated-marriage implementation would require weakening the direct-route gate

The direct mutual-strong-like bypass and Household-mediated route are semantically different. If a proposed implementation cannot keep them distinguishable without making ProposeMarriage consult objective H state or bypassing groom subjective Recognition, stop and redesign the representation within accepted semantics.

## I11. Office implementation appears to require replacing ADR-0004

Nothing reviewed establishes a need for:

- event-sourced current authority;
- same-cycle fresh voluntary reactivation;
- parallel/distributed resolution;
- a global institutional inference engine;
- a graph database;
- an omniscient agent layer.

If such a requirement emerges, it is an architectural escalation. The current reference kernel already has the broad shape Slice 4 needs.

---

## 2. Main resolver assumptions that must not survive unchanged

For implementation planning, the current code has five especially important assumptions that are correct through Slice 3 but not sufficient for Slice 4:

1. **One proposal per PersonId means one voluntary initiative.**  
   Slice 4 needs one personal initiative plus one H initiative through the same person, so initiative authority/context must become explicit enough to enforce both cardinalities correctly.

2. **One proposal has one response target.**  
   Appointment/succession requires nominee consent plus unanimity from all current sustaining participants. A bounded multilateral response/provenance path is required.

3. **Household actions are non-material participation transitions.**  
   Slice 4 adds material Household support/dowry that must update WorldState and Household authority/provision state atomically.

4. **Current associations are a sufficient Household dependency proxy.**  
   Prospective nominees/holders and actor-specific authority evidence can matter before occupancy/current-role status.

5. **The semantic-order table contains only bridge-entry-before-exit.**  
   Slice 4 adds accepted material priority and fires an unresolved authority-transition race. Technical ordering cannot fill that gap.

These are the strongest reasons the work is a substantial kernel extension rather than a bounded extension.

---

## 3. Suggested implementation-planning decomposition after authority/verification reconciliation

This is a surface decomposition, not a concrete design prescription.

1. **Close fired semantics and inherited-verification triggers first**
   - LATER-04;
   - LATER-05;
   - S3-014/S3-093 lossless regression adaptation;
   - head-vacancy evidence verification trigger.

2. **Add minimum persistent office authority**
   - stable role identity anchored to H;
   - vacancy/occupancy;
   - transition provenance;
   - immutable inspection surface;
   - at-most-one occupant invariant.

3. **Extend actor epistemics only for the accepted head-role proposition**
   - direct transition participant acquisition;
   - stale predecessor evidence;
   - communication/correction;
   - Contested state;
   - no general observation subsystem.

4. **Add appointment/succession through normal attempt/response/resolution**
   - current-SP nomination/nominee gates;
   - nominee consent;
   - unanimity;
   - role persistence;
   - vacancy on participation end.

5. **Add separate Household decision context**
   - same committed snapshot as personal;
   - separate initiative cardinality;
   - separate scoring/trace;
   - P's subjective knowledge retained;
   - no context when vacant/Inactive.

6. **Add endogenous provision acquisition/reconsideration**
   - request/refusal/acceptance provenance;
   - cooldown + context baseline;
   - commitment creation without grain movement.

7. **Add atomic collective material transaction**
   - one-grain support;
   - fixed-rank contributor allocation;
   - exact debit vector;
   - accepted material priority;
   - no treasury.

8. **Add mediated marriage only after LATER-05 closure**
   - subjective route gates;
   - head authority;
   - dowry allocation;
   - marriage + groom→head favour atomicity;
   - direct bypass remains separate.

9. **Extend detached dependency replay and independent oracles together**
   - prospective actors;
   - role/precondition state;
   - head evidence;
   - contributor/material dependencies;
   - semantic-origin normalization;
   - corruption tests for exact role/evidence references.

---

## 4. Conclusion

**Classification: SUBSTANTIAL KERNEL EXTENSION.**

Slice 4 does not require a new simulation architecture. The promoted Slice-3 kernel already provides the important foundations: stable institutional identity, explicit provenance, actor-specific epistemics, deterministic central resolution, stable closure, person-backed provision capacity, and a sophisticated detached dependency/fallback mechanism.

But it is not a bounded extension either. Correct implementation must alter or extend the logical responsibilities for:

- state authority;
- decision context and initiative cardinality;
- response topology;
- role Recognition;
- immediate revalidation;
- dependency grouping;
- semantic projection normalization;
- atomic material transactions;
- history/provenance;
- independent verification.

The central discipline is to keep these identities and authorities separate:

**Person ≠ Household ≠ HouseholdHeadRole ≠ role occupant ≠ actor Recognition ≠ provision backing ≠ material ownership.**

And to keep these execution meanings separate:

**personal initiative ≠ Household initiative; office authority ≠ personal authority; accepted proposal ≠ committed effect; semantic priority ≠ technical fallback; objective occupancy ≠ actor knowledge.**

No production code should begin until the fired authority-race and mediated-marriage topology triggers, plus the known inherited-verification adaptation points, have been reconciled into implementation-facing authority.

---

## Appendix A — exact source evidence index at base a7a9bbcdc86d4684762efd203b20225b64b001b7

### Accepted authority

- specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md — blob a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52
- architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md — blob 66cfd55f8b960ff5664638c41c0e731257902be5
- architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md — blob aebeecf61bb46ef4bd954cb0a42f4a17eb0bf229
- architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md — blob 9ce78a311f006215a2afe3575065005e74c4e916
- architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md — blob 43eedd7eb49e1eae035010332883ed2d8726d451
- architecture/accepted/ADR-0005_HOST_RUNTIME.md — blob 7e6732a928656da28d299a4d78bf27d1ffc139f5

### Key project-learning and deferred-trigger evidence

- research/technical/IMP-0003/IMP-0003_FUTURE_LESSONS_INDEX.md — blob c163637721411892d06129e21734c44fbdaef0d7
- research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md — blob 13804a01d84683c992bc1d42640a84b28ae67c48
- registers/TRES-0010_DEFERRED_GAP_LEDGER.md — blob 2dece4f8b9f33b0c46f384b7bd75f58bcfaac101

### Production implementation inspected

- src/Mesopotamia.Sim/HouseholdState.cs — blob 6172779073f7590d0f0b03d560ed7c7952e925a3
- src/Mesopotamia.Sim/HouseholdExecution.cs — blob 1d9953cbe126b3286d55487e5d6d1260fba603a0
- src/Mesopotamia.Sim/HouseholdRules.cs — blob 6915184ccbbafcb256506862213268019634387a
- src/Mesopotamia.Sim/HouseholdResolution.cs — blob a864359fad6b96548751c44e584cda4f613fd04b
- src/Mesopotamia.Sim/HouseholdProjection.cs — blob db1d3e738dd24d681667be4a6ddc9f20fcf40162
- src/Mesopotamia.Sim/EpistemicState.cs — blob 2b1cfe6c912d0962b7e049ded88f2c1488623c57
- src/Mesopotamia.Sim/EpistemicExecution.cs — blob 4da321ce5eaeb6c39b93a66913627f5fb21fa9b1
- src/Mesopotamia.Sim/Simulation.cs — blob 6e59830cef1f2c99d915ffe738e40d68ef4c1740
- src/Mesopotamia.Sim/Execution.cs — blob f34d42e32b2d6cfa38079a8acd8673a3f5c3ffd9
- src/Mesopotamia.Sim/Decisions.cs — blob 695a94e54d3abea2e3a2bcb26e92df7601ee6fe7
- src/Mesopotamia.Sim/PersonalDecisionInputs.cs — blob 5dd6b1cbbc84bcf3c7469cfa5d17e10862d80f3a
- src/Mesopotamia.Sim/Agency.cs — blob 50504860e5ee5558a5d6e738af654f24833008dd
- src/Mesopotamia.Sim/ResolutionDependencies.cs — blob dc681569fcb72114bd87ea8b06ef386298881d44
- src/Mesopotamia.Sim/VerificationAccess.cs — blob c378090058205bed18ed04b7ece083ba71ad818c

The remaining production files were also inspected. State.cs retains lower-level world authority and must not acquire head-as-person authority; MaterialRecovery.cs is lower-level maintenance/deadlock support; the project file has no Slice-4 semantic role.

### Acceptance implementation inspected

- tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs — blob cc8b894245da0f89a411e07ff5ed8b677a4bc58b
- tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs — blob 122d6702c807a91071a227f4ea31d892a6ed7fea
- tests/Mesopotamia.Sim.AcceptanceTests/HouseholdWarrantOracle.cs — blob 57d88a7e7405d07a833e14b3c1f224815793bcfd
- tests/Mesopotamia.Sim.AcceptanceTests/InvariantOracle.cs — blob e754486681e9a1300f0c14363b52966a6b23d6eb
- tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs — blob 48c29df3ff795743e2e8f95d926984a95d695510

The broader current acceptance inventory was inspected for inherited fallback, resolution, material-ledger, fixture-audit, and regression behavior. This return does not alter frozen Slice-1/2/3 classifications or decide Slice-4 acceptance applicability.
