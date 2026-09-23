# SFL v0 Slice 3 — Authority and Deferred-Gap Inventory

**Status:** SOURCE-GROUNDED DISCOVERY RETURN / ADVISORY ONLY  
**Task:** `tasks/research/SFL_V0_SLICE3_DISCOVERY_A_AUTHORITY_GAPS.md`  
**Return branch:** `research/slice3-authority-gap-return`  
**Canonical base SHA used:** `7deb43a7c2d40403f0a9cd6c600fba9db5cebf26`  
**Base commit message:** `Close Slice 2 observation pause and open Slice 3 discovery`  
**Authority boundary:** This report does not promote or modify simulation semantics.

## 1. Executive conclusion

The bounded Slice-3 path is **READY FOR ACCEPTANCE PLANNING**.

No Director-level semantic decision is currently required.

Accepted authority is sufficient to make the following executable in Slice 3 without pulling the representative-role slice forward:

- one inert, non-authoritative `CandidateOrganization` referent for each bounded formation witness;
- inherited `CandidateRecognition` used as an actual formation precondition;
- `FormationWarrant` -> persistent Household identity;
- provenance-bearing `SustainingParticipant`;
- bilateral `ParticipationWarrant` entry and explicit `ParticipationEndWarrant` exit;
- `ContinuationWarrant`-based identity transmission, including complete founder turnover;
- stable-cycle `Active / Inactive / Dissolved` lifecycle;
- continuity-over-duplicate-formation precedence;
- controlled `LineageWarrant` / direct `DerivedFrom` classification;
- `HouseholdProvisionCommitment` as backing state, its accepted termination behavior, and derived mobilizable-capacity calculation.

Slice 3 must **not** claim executable household-originated spending. Under the accepted specification, collective expenditure requires an Active Household, an occupied valid head role, in-scope authority, and sufficient backing. The head role and `HouseholdDecisionContext` belong to Slice 4. Slice 3 can truthfully demonstrate **grounded backing and derived mobilizable capacity**, not operational spending authority.

The accepted model also makes Household recognition independent of head recognition: founders can recognize a newly formed, explicitly headless Household; later head vacancy does not destroy Household identity; and Household-recognition and head-recognition are distinct propositions.

## 2. Source corpus retrieved

The analysis used the exact canonical state at the base SHA above and independently retrieved:

1. `AGENTS.md`;
2. `00_START_HERE.md`;
3. accepted `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
4. all accepted ADRs / accepted decision records current at the base;
5. `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`;
6. `plans/verification/SFL_V0/FORMATION_FAMILY.md`;
7. `plans/verification/SFL_V0/CONTINUITY_TURNOVER_FAMILY.md`;
8. `plans/verification/SFL_V0/LINEAGE_FAMILY.md`;
9. `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md`;
10. `plans/verification/SFL_V0/NO_SELF_CONFIRMATION_FAMILY.md`;
11. `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md`;
12. `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md`;
13. `registers/ASSUMPTIONS_REGISTER.md`;
14. `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`;
15. frozen Slice-1 and Slice-2 acceptance manifests/freeze records and final completion/promotion records;
16. `research/technical/SFL_V0_OBSERVATIONS/RUN-0002_EPISTEMIC_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md`.

Additional verification cards were consulted only to preserve the Slice-3/Slice-4 boundary, especially `HEAD_ROLE_AND_DUAL_MODE_FAMILY.md` and `RESPONSE_DECISION_FAMILY.md`.

## 3. Authority anchors that control the boundary

The decisive accepted constraints are:

- Households emerge from lower-level social reality and may acquire persistent identity, history, coordinated behavior, and causal influence; they are not primitive containers.
- Stable identity is not derived from mutable content such as names, current participants, residence, or allocation position.
- `CandidateRecognition(C)` is ephemeral, provenance-bearing, grants no Household power, and requires actor-held uncontested evidence for the objective formation predicate.
- Household formation creates one persistent Household plus a `FormationWarrant`, founding `SustainingParticipant` associations, and direct Household recognition by the founders.
- Later participation uses an explicit bilateral proposal plus `ParticipationWarrant`; participation end is explicit and produces `ParticipationEndWarrant`.
- Household continuity requires historical transmission through a bridge and `ContinuationWarrant`; snapshot similarity never preserves identity.
- Lifecycle is operational state only: 2+ sustaining participants Active, 1 Inactive, 0 Dissolved.
- When the same evidence supports both continuity to a non-Dissolved Household and fresh formation, continuity/participation takes precedence; one evidence bundle cannot both continue H and found a duplicate H2.
- Controlled lineage is downstream historical provenance, not identity or inherited causal state.
- Provision commitments leave grain personal until a collective expenditure commits; exposed capacity is `max(0, grain - 2)`, and `NeedsGrain` exposes zero.
- New Households begin headless.
- Head vacancy preserves Household identity and other valid provision commitments but suspends household-mode action.
- Household collective action requires Active H + occupied head + in-scope authority + sufficient valid backing.

These constraints uniquely support the Slice-3/Slice-4 split below.

## 4. Slice-3 semantic census

| Semantic item | Slice classification | Slice-3 consequence |
|---|---|---|
| `CandidateOrganization` | **REQUIRED in Slice 3, bounded use** | Provide an inert stable referent that may collect/organize formation evidence. It has no causal authority, resources, household actions, or self-supporting evidentiary force. General cross-label convergence is not required. |
| `CandidateRecognition` | **REQUIRED integration; inherited Slice-2 semantics** | No new recognition theory is needed. Slice 3 must use the already-verified actor-specific/provenance-bearing recognition state as a real formation gate and regression-protect Slice-2 epistemic semantics. |
| `FormationWarrant` | **REQUIRED in Slice 3** | Formation must be downstream of lower-level history and founder recognition; the warrant records founding core, dwelling, ties/events, recognition evidence, earliest sustaining evidence, and reification time. |
| Persistent Household identity | **REQUIRED in Slice 3** | Stable independently identified Household created only from valid formation; identity must remain distinct from residence, participants, assets, labels, graph similarity, and head occupancy. |
| `SustainingParticipant` | **REQUIRED in Slice 3** | Founders receive provenance to the FormationWarrant; later entry/exit modifies only this typed association, not a universal Members set. |
| `ParticipationWarrant` | **REQUIRED in Slice 3** | Bilateral request/invitation plus recognition, bridge, residence, tie, post-formation support, and mutual acceptance; may reactivate an Inactive H through its sole bearer. |
| `ParticipationEndWarrant` | **REQUIRED in Slice 3** | Explicit participation end remains queryable, terminates the departing person's provision commitment, and triggers continuity/lifecycle reevaluation without erasing lower-level relations. |
| `ContinuationWarrant` | **REQUIRED in Slice 3** | Historical transmission, not endpoint similarity, preserves Household numerical identity. Complete founder turnover is a required proof shape. |
| Active / Inactive / Dissolved | **REQUIRED in Slice 3** | Publish only at stable cycle closure; Inactive may reactivate through its sole bearer; Dissolved cannot reactivate as the same identity. |
| Duplicate-formation / continuity precedence | **REQUIRED in Slice 3** | Same causal evidence cannot continue a non-Dissolved H and also form duplicate H2; separately warranted overlapping organizations remain possible. |
| Controlled `LineageWarrant` | **REQUIRED in Slice 3** | Implement only the accepted narrow division/consolidation classifier. Lineage is downstream of ordinary formation, behaviorally inert, and transfers no causal state. |
| `DerivedFrom` | **REQUIRED in Slice 3 as rebuildable projection** | Direct predecessor edges derive from the authoritative `LineageWarrant`; transitive ancestry remains a distinct query. |
| General lineage/fission/merger theory | **Accepted exclusion / remain unexercised** | Do not generalize beyond the controlled v0 classifier. Mixed/ambiguous cases may form normally without a lineage classification. |
| `HouseholdProvisionCommitment` record/backing state | **REQUIRED in Slice 3 as grounding substrate** | Represent explicit accepted backing, preserve personal grain ownership, terminate on that participant's exit or H dissolution, and preserve other valid commitments through head vacancy. |
| Exposed / mobilizable provision capacity | **REQUIRED in Slice 3** | Derive from current valid commitments and personal state. Capacity is not a pooled treasury and is not permission to spend. |
| Provision solicitation / reconsideration action | **LATER — Slice 4** | The accepted endogenous request/reconsideration route is in head-role scope. Slice 3 must not invent a headless solicitation route. |
| Household-originated 1-grain support | **LATER — Slice 4** | Actual collective support requires head authority and household decision mode. |
| Mediated-marriage dowry spending | **LATER — Slice 4** | Requires the mediated head route, bride participation fact, H/head recognition, authority, and provision backing. |
| Fixed-rank debit allocation for an expenditure | **LATER — Slice 4 execution** | The accepted allocation rule applies at expenditure precommit. Slice 3 can own capacity grounding without executing a spend. |
| `HouseholdHeadRole`, appointment, vacancy, succession | **LATER — Slice 4** | New H begins headless; do not auto-elect or stub an occupant in Slice 3. |
| Head/representative Recognition | **LATER — Slice 4** | Separate proposition from Household Recognition. |
| `HouseholdDecisionContext` / separate household initiative | **LATER — Slice 4** | Do not pull collective deliberation forward merely to exercise provision state. |
| Checkpoint/restore continuation | **LATER — Slice 5** | Stable-cycle semantics still apply now, but exact save/restore continuation remains Slice 5. |

### 4.1 CandidateRecognition is not “regression only”

Slice 2 proved a bounded `CandidateRecognition(C)` substrate using one inert pre-Household referent and deliberately did not exercise formation or candidate convergence.

Slice 3 must preserve those semantics unchanged, but it now consumes them causally: founder recognition becomes one of the actual formation prerequisites. The correct acceptance posture is therefore:

**inherited semantic substrate + REQUIRED Slice-3 integration + regression protection**, not a redesign.

### 4.2 Provision commitment creation is not a Slice-3 semantic invention point

Accepted authority does not define a new headless actor action for soliciting a provision commitment. The explicit solicitation/reconsideration role is assigned to the Household head.

Therefore Slice-3 acceptance may prove the backing relation's state semantics, capacity derivation, persistence/termination, and non-pooling behavior without claiming that Slice 3 has implemented the later head-scoped acquisition path. Any fixture or producer used to establish a pre-existing valid commitment for those tests must be declared as setup and must not be counted as evidence that endogenous commitment solicitation/acceptance has been implemented.

This is a verification/fixture choice, not a new social rule.

## 5. Slice 3 / Slice 4 boundary

### 5.1 Provision state/capacity versus actual spending

**Slice 3:** provision backing state and derived capacity grounding only.

A headless or vacant Household may still have provision commitments; vacancy does not destroy them. This proves that backing state is distinct from office occupancy.

**Slice 4:** actual Household-originated spending.

The accepted specification requires every collective action to have:

- Active Household;
- occupied valid head role;
- authority within role scope;
- sufficient current backing/capacity.

Therefore implementing 1-grain support or dowry expenditure in Slice 3 would necessarily pull head authority and household decision mode forward.

### 5.2 Does any provision action require a head?

Yes for the accepted endogenous provision-action routes relevant here.

- requesting/reconsidering provision backing is a head-role scope;
- authorizing permitted Household material uses is a head-role scope;
- mediated-marriage handling is a head-role scope;
- household-mode action does not exist while the role is vacant.

No accepted headless spending route exists. Slice 3 must not invent one.

### 5.3 Does Household recognition exist independently of head recognition?

Yes.

Accepted semantics separate:

- Recognition that Household H exists/continues; and
- Recognition that P occupies H's head/representative role within scope.

Formation directly gives founders Household recognition while the new Household is explicitly headless. Later head vacancy preserves Household identity. Therefore Household existence/recognition does not depend on head recognition.

### 5.4 Truthful pre-head collective-capability claim

Before a representative role exists, Slice 3 can truthfully demonstrate:

> An independently persistent Household can carry explicit participant-backed provision commitments and expose a derived mobilizable-capacity value grounded in current personal grain and need state, while owning no pooled treasury and having no authority to spend that capacity.

It may **not** claim that the Household can yet autonomously or authoritatively execute a collective material action.

## 6. LATER-01 — CandidateOrganization equivalence / convergence

**Trigger status:** FIRED by Slice-3 planning, but **not blocking** for the bounded implementation path.

### 6.1 Does Slice 3 actually need multiple candidate labels/evidence paths?

No accepted canonical Slice-3 witness requires that.

The formation family uses one named `CandidateABC` referent. Frozen Slice-2 acceptance deliberately used exactly one inert candidate referent C, expressly stated that no second label existed, and did not exercise candidate equivalence/convergence.

A bounded Slice-3 formation witness can continue that pattern.

### 6.2 Do accepted semantics already imply a bounded equivalence rule?

They imply only identity of the **same candidate referent**:

- every required founder must recognize the same candidate C;
- candidate existence/label cannot count as evidence for itself.

Accepted authority does **not** define when two distinct `CandidateOrganization` IDs/labels/evidence accumulators should be merged or treated as equivalent.

Do not infer equivalence from equal founder sets, residence, support events, labels, or graph similarity.

### 6.3 Can the canonical formation witness use one stable referent without cheating?

Yes.

The candidate record is explicitly non-authoritative and has no household powers. A stable inert referent can organize actor-held evidence while the actual formation verdict remains downstream of accepted lower-level facts, support history, and each founder's `CandidateRecognition`.

This does not bypass the formation gate and does not make the candidate label evidence for itself.

### 6.4 LATER-01 disposition

**Keep general candidate convergence deferred.**

Slice-3 acceptance should pin one stable candidate referent per bounded formation witness and explicitly prohibit claims about multi-label equivalence.

If a later implementation requirement demands reconciling two distinct candidate IDs/evidence paths before formation, the smallest consequential semantic question to escalate is:

> Under what accepted evidence conditions are two distinct `CandidateOrganization` referents the same prospective organization rather than distinct overlapping candidates?

No broader organization-equivalence theory is needed before that trigger.

## 7. Deferred-gap / hardening trigger map

| ID | Slice-3 status | Disposition |
|---|---|---|
| **LATER-01** CandidateOrganization equivalence/convergence | **FIRED NOW** | Bounded one-referent Slice-3 path avoids the missing general rule. Keep general convergence deferred; no Director decision now. |
| **LATER-02** actor departure semantics | **NOT FIRED by bounded Slice 3** | Household participation end is not actor departure from the world. Fire only if Slice 3 enables executable actor departure as fixture/generated/runtime input. |
| **LATER-03** repeated predecessor participation lineage-source selection | **NOT FIRED if bounded classifier excludes such histories** | Controlled lineage may use unambiguous one-source histories. If implementation attempts to issue lineage for a founder with repeated relevant participation/end history in the same predecessor, this item fires before that behavior is accepted. |
| **LATER-04** authority-destroying transition vs authority-dependent same-cycle action | **LATER — Slice 4** | Head/authority transitions and authority-dependent household actions do not coexist executably in the bounded Slice-3 boundary. |
| **LATER-05** mediated-marriage nested response/authority topology | **LATER — Slice 4** | Mediated marriage is role/authority dependent and should not be executable in Slice 3. |
| **VH-01** exit-side `ContinuationWarrant` evidence | **FIRED NOW** | Continuity becomes completion evidence in Slice 3. Acceptance must explicitly prove the required transmission semantics from both entry and exit sides, not only newcomer entry. |
| **VH-02** generated-history circular validity filtering | **CONDITIONAL / not intrinsically fired** | If generated histories become REQUIRED completion evidence, their validity classifier/oracle must be independent of the production gate under test. Otherwise leave visibly unexercised. |
| **VH-03** verified-checkpoint provenance | **FIRED on checkpoint-reuse path** | Continuity cards begin from a verified formation result/checkpoint or an equivalent independently verified formation state. Any reused produced checkpoint must carry verifiable producer/pass/fixture-audit provenance. A fresh independently verified setup may avoid reuse. |
| **VH-04** checkpoint omission mutant causal suffix | **LATER — Slice 5** | Fires when checkpoint-omission mutation becomes completion evidence. |
| **VH-05** event-observer/lifecycle recognition | **FIRED NOW for lifecycle/dissolution; head-vacancy remainder later** | Slice 3 combines Household recognition with lifecycle/dissolution. Acceptance should explicitly test eligibility/provenance of recognition updates from decisive lifecycle evidence. The head-vacancy-specific half remains Slice 4. |
| **VH-06** reaction-chain / derived-state refresh timing | **FIRED NOW as Slice-3 hardening** | Formation, participation/continuity, lifecycle, and lineage add household reaction chains and derived state. Acceptance should either exercise refresh ordering or prove structurally that no behavior-affecting derived/cache state can go stale inside closure. |

These hardening items affect evidence quality and implementation discipline; they do not create new social semantics.

## 8. Lineage-specific boundary

Controlled lineage belongs in Slice 3 because it tests a core identity distinction:

- continuing numerical identity versus
- a newly formed descendant with historical derivation.

Required now:

- division descendant with predecessor H still non-Dissolved;
- consolidation descendant only after both predecessors Dissolved;
- explicit founder lineage sources from `ParticipationEndWarrant`;
- fresh ordinary person-person organizational evidence after the required separation point;
- at most one `LineageWarrant` per successor FormationWarrant;
- rebuildable direct `DerivedFrom`;
- no inherited resources, claims, authority, recognition, roles, pending process, or lifecycle state.

Not required now:

- repeated predecessor participation-source choice under LATER-03;
- mixed-origin classification beyond accepted controls;
- absorption, multiple descendants, disputed succession, reconsolidation, or a general merger/fission theory.

## 9. Recognition and no-self-confirmation obligations

Slice 3 must preserve the Slice-2 epistemic boundary:

- objective Household state does not globally broadcast actor recognition;
- formation depends on actor-held evidence and `CandidateRecognition`, not objective graph structure;
- founders directly recognize the resulting H from the formation event;
- outsiders require accepted observation/communication evidence;
- stale or contested recognition remains possible;
- Household recognition is not attitude, approval, or obedience.

No-self-confirmation rules become active Slice-3 requirements:

- Household-originated support must never count as independent formation evidence;
- Household effects must not clone an existing identity;
- same evidence with a valid continuation path to non-Dissolved H must not found duplicate H2;
- Household-originated support cannot satisfy fresh lineage evidence;
- diagnostic/reporting projections cannot become causal recognition/continuity authority.

Because actual Household support remains Slice 4, Slice 3 should still encode the provenance distinction needed to prevent later feedback from being misclassified as ordinary lower-level formation/lineage evidence. The actual support-producing action can remain unexercised until Slice 4.

## 10. Semantic decisions versus engineering / verification choices

### No semantic decision required now

Accepted authority already determines:

- the formation predicate;
- the role of CandidateRecognition;
- Household identity and continuity semantics;
- entry/exit warrants;
- lifecycle counts;
- continuity-over-duplicate precedence;
- controlled lineage rules;
- provision-capacity grounding;
- Household/head recognition separation;
- the fact that spending requires a valid head/household mode.

### Engineering / verification choices left open

Acceptance planning and implementation may choose, without semantic promotion:

- concrete record types/layouts/indexes;
- how one stable candidate referent is created/seeded for bounded witnesses, provided it has no evidentiary or causal power;
- direct recomputation versus rebuildable derived indexes under ADR-0003;
- exact fixture construction/reuse strategy, subject to VH-03 provenance;
- whether generated histories are required evidence, which determines VH-02 applicability;
- exact independent-oracle implementations;
- exact test scenario population and non-semantic IDs;
- how Slice-3 tests establish a pre-existing valid provision commitment when the acquisition route itself is not under test, provided no test claims that this proves headless solicitation/acceptance.

### Decisions that would become consequential if scope expands

A Director-level semantic decision would be required if Slice 3 were expanded to require any of:

1. reconciliation of two distinct pre-formation CandidateOrganization IDs/evidence paths;
2. a headless endogenous route for creating/soliciting provision commitments;
3. accepted lineage classification for repeated same-predecessor participation/end histories;
4. actor departure from the world;
5. same-cycle head-authority destruction racing with authority-dependent action;
6. household-mediated marriage topology.

None is required for the bounded Slice-3 path.

## 11. Acceptance-planning guardrails

The Slice-3 acceptance packet should make the following explicit:

1. **One candidate referent per bounded formation witness.** No implicit equivalence rule.
2. **CandidateRecognition is reused, not redesigned.** Formation integration is REQUIRED; Slice-2 epistemic regressions remain protected.
3. **No hidden Members set.** `SustainingParticipant` + warrants are the only accepted participation substrate.
4. **Continuity history is causal authority.** Final snapshot similarity is never an oracle.
5. **Lifecycle is operational, not identity.** Evaluate/publish it only after stable reaction closure.
6. **Lineage is provenance, not continuation.** Ordinary formation must succeed independently first.
7. **Provision state is not spending authority.** Slice 3 may expose grounded capacity but no Household-mode material action.
8. **No auto-head stub.** New H remains headless; no ID/age/sex/grain/kinship fallback occupant.
9. **No self-confirmation.** Household-produced effects cannot retroactively validate formation, continuity, or lineage.
10. **Hardening triggers VH-01, VH-03 (if reused checkpoint), VH-05 lifecycle side, and VH-06 must be visible in completion evidence.**

## 12. Director decision map

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

The bounded Slice-3 implementation can proceed to acceptance planning entirely within already accepted authority.

---

## Slice-3 semantic boundary

**REQUIRED:** bounded CandidateOrganization referent; inherited CandidateRecognition integration; FormationWarrant; persistent Household identity; SustainingParticipant; ParticipationWarrant; ParticipationEndWarrant; ContinuationWarrant; Active/Inactive/Dissolved lifecycle; continuity-over-duplicate-formation precedence; controlled LineageWarrant/DerivedFrom; HouseholdProvisionCommitment backing state and termination semantics; derived mobilizable capacity; Household recognition independent of head recognition.

**NOT Slice 3:** head appointment/succession, head Recognition, HouseholdDecisionContext, household initiative, provision solicitation/reconsideration action, actual collective support/dowry spending, mediated marriage, exact checkpoint/restore.

## Fired deferred gaps

**Now:** LATER-01 (bounded disposition only); VH-01; VH-03 when verified-state reuse is used; VH-05 lifecycle/dissolution side; VH-06.  
**Conditional:** VH-02 if generated histories become completion evidence; LATER-03 only if repeated-predecessor histories are accepted by the lineage classifier.  
**Later:** LATER-04 and LATER-05 in Slice 4; VH-04 in Slice 5; LATER-02 only if actor departure becomes executable.

## LATER-01 disposition

Use one stable, inert CandidateOrganization referent per bounded formation witness. Accepted semantics do not define equivalence across distinct candidate IDs, but Slice 3 does not need that rule. Keep general candidate convergence deferred.

## Slice3/Slice4 capability boundary

Slice 3 may demonstrate explicit personal backing and derived Household mobilizable capacity with no pooled treasury and no spending authority. Actual Household-originated support/dowry action, provision solicitation/reconsideration, and collective decision-making require the representative/head role and belong to Slice 4.

## Director-decision status

**NO DIRECTOR DECISION CURRENTLY REQUIRED.**

## Recommendation

**READY FOR ACCEPTANCE PLANNING.**
