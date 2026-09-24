# SFL v0 Slice 4 Discovery C — Verification Trigger and Acceptance Applicability Map

**Status:** DISCOVERY RETURN / ADVISORY ONLY  
**Role:** verification authority mapper  
**Canonical base:** <code>a7a9bbcdc86d4684762efd203b20225b64b001b7</code>  
**Return branch:** <code>research/slice4-verification-trigger-return</code>  
**Authority rule:** accepted SPEC/ADRs define semantics; frozen Slice-1/2/3 manifests define their historical completion applicability and are not modified here.

## 1. Executive judgment

Slice 4 is the point at which the accepted representative-role, Household decision-mode, provision-acquisition/spending, and mediated-marriage verification families become executable rather than merely deferred.

The central acceptance consequence is not just “turn on cards 04x and 06x.” Slice 4 joins previously separate authoritative domains:

- persistent Household identity/lifecycle from Slice 3;
- actor-specific Recognition/provenance from Slice 2/3;
- one-person personal initiative and response accounting from Slice 1/2;
- a persistent <code>HouseholdHeadRole(H)</code> whose occupant can change without changing H or the role;
- a separate Household initiative cognitively carried by the head;
- participant-backed provision capacity that can now be endogenously acquired and actually spent;
- authority-dependent actions whose validity can change inside the same resolution cycle.

A Slice-4 acceptance authority can be drafted from the accepted corpus now, but **must not be frozen/released unchanged until two already-tracked semantic gaps are resolved by the proper authority**:

1. **LATER-04 — authority-destroying transition versus an already accepted authority-dependent action in the same cycle.** This is now fired because Slice 4 necessarily makes role vacancy/succession/lifecycle transitions coexist with head/Household actions.
2. **LATER-05 — mediated-marriage nested response / authority topology beyond the currently accepted route wording.** This is now fired because household-mediated marriage becomes executable in Slice 4.

These are not coder/test discretion. The manifest may reserve explicit BLOCKED/pending rows while being drafted, but a frozen completion authority needs one authoritative expected result for the affected cases.

Checkpoint/restore remains a clean Slice-5 deferral. General candidate convergence, actor departure, repeated-predecessor lineage-source selection, general contested succession, and general generated-history infrastructure remain outside the bounded Slice-4 completion path unless separately triggered.

## 2. Source corpus independently retrieved

### Accepted semantic / architectural authority

- <code>specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md</code>
- <code>architecture/accepted/ADR-0001_ACTIVE_SOCIAL_STATE_REPRESENTATION.md</code>
- <code>architecture/accepted/ADR-0002_HIERARCHICAL_INDIVIDUAL_AGENCY.md</code>
- <code>architecture/accepted/ADR-0003_PROGRESSIVE_DERIVED_STATE_SPECIALIZATION.md</code>
- <code>architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md</code>
- <code>architecture/accepted/ADR-0005_HOST_RUNTIME.md</code>

### Canonical Stage-3 verification package

- <code>FORMATION_FAMILY.md</code>
- <code>CONTINUITY_TURNOVER_FAMILY.md</code>
- <code>LINEAGE_FAMILY.md</code>
- <code>RECOGNITION_INFORMATION_FAMILY.md</code>
- <code>PROVISION_GROUNDING_FAMILY.md</code>
- <code>NO_SELF_CONFIRMATION_FAMILY.md</code>
- <code>HEAD_ROLE_AND_DUAL_MODE_FAMILY.md</code>
- <code>RESOLUTION_REACTION_FAMILY.md</code>
- <code>DETERMINISM_RECOVERY_EXPLAINABILITY_FAMILY.md</code>
- <code>LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md</code>
- <code>RESPONSE_DECISION_FAMILY.md</code>
- <code>CROSS_CUTTING_VERIFICATION_CONTRACT.md</code>
- <code>REFERENCE_SCORING_PROFILES.md</code>
- <code>README.md</code>

All paths above are under <code>plans/verification/SFL_V0/</code>.

### Frozen prior-slice acceptance authority

Slice 1:

- manifest version <code>SFL-V0-S1-ACCEPTANCE-v1</code>;
- frozen ref <code>sfl-v0-slice1-acceptance-v1</code>;
- freeze commit <code>55377cc34b8bc3ccbf9cdf5029e9791dae965987</code>;
- frozen manifest blob <code>efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766</code>.

Slice 2:

- manifest version <code>SFL-V0-S2-ACCEPTANCE-v1</code>;
- frozen ref <code>sfl-v0-slice2-acceptance-v1</code>;
- freeze commit <code>88f876298852553d6afca76e743a5a811ff9f0fd</code>;
- frozen manifest blob <code>e4872531cf780d51fa1863f2a0b87e2424a71b69</code>.

Slice 3:

- manifest version <code>SFL-V0-S3-ACCEPTANCE-v1</code>;
- frozen ref <code>sfl-v0-slice3-acceptance-v1</code>;
- freeze commit <code>25160f33c994fd5f3e277ae98f03e55d37c878dd</code>;
- frozen manifest blob <code>1aae13dc27572361fe99c31ef8aee0444d39364a</code>;
- frozen census 96 REQUIRED / 11 DEFERRED / 2 UNEXERCISED, with all 128 Slice-1 REQUIRED and 46 Slice-2 REQUIRED rows inherited individually.

### Final prior-slice completion records

- <code>research/technical/IMP-0001/IMP-0001_FINAL_COMPLETION_AND_PROMOTION_RECORD.md</code>
- <code>research/technical/IMP-0002/IMP-0002_FINAL_COMPLETION_AND_PROMOTION_RECORD.md</code>
- <code>research/technical/IMP-0003/IMP-0003_FINAL_COMPLETION_AND_PROMOTION_RECORD.md</code>

Slice 3's final independently reviewed candidate was <code>b5e5409ebcaec856a74ab08a7d120a67f6078e36</code>, promoted at <code>f7ca9525d17ed20758058df7aff97b2f47e5a01a</code>.

### Deferred gaps / learning records

- <code>registers/TRES-0010_DEFERRED_GAP_LEDGER.md</code>
- <code>research/technical/IMP-0003/IMP-0003_FUTURE_LESSONS_INDEX.md</code>
- <code>research/technical/SFL_V0_OBSERVATIONS/RUN-0003_HOUSEHOLD_PAUSE/MASTER_ARCHITECT_RECONCILIATION.md</code>

### Current promoted production/test boundary

Current <code>src/Mesopotamia.Sim/README.md</code> and the promoted production surfaces implement Slices 1–3 only.

Present authoritative/runtime capability includes:

- lower-level person/material/social state and deterministic proposal/response/resolution;
- actor-specific epistemic state and communication;
- Household identity, warrants, sustaining association, continuity/lifecycle;
- actor-specific Household Recognition;
- controlled lineage;
- provision commitment state and derived capacity;
- reaction closure and detached dependency analysis.

The current boundary explicitly does **not** implement:

- HouseholdHeadRole / occupancy;
- head Recognition;
- HouseholdDecisionContext / separate Household initiative;
- runtime/endogenous provision solicitation or reconsideration;
- Household spending/support/dowry/debit allocation execution;
- mediated-marriage authority;
- checkpoint/restore.

The only current provision-commitment producer is a verification-controlled prerequisite seam with explicit producer provenance. That is valid for Slice-3 substrate claims and is not an endogenous Slice-4 acquisition implementation.

## 3. Canonical family/card applicability for Slice 4

Classification terms:

- **REQUIRED S4** — newly executable Slice-4 semantics or a new Slice-4 instantiation is necessary for completion.
- **INHERITED REGRESSION** — already frozen/passed behavior that Slice 4 must preserve and report as an explicit regression binding.
- **DEFER S5** — engine checkpoint/recovery behavior deliberately belongs to Slice 5.
- **FUTURE / UNEXERCISED** — not required for bounded Slice-4 completion unless separately activated.
- **BLOCKED PENDING AUTHORITY** — Slice-4 witness is mandatory, but its exact expected result is not yet uniquely determined by accepted authority.

### 3.1 Formation family — VS-SFL-001/002

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-001 three-founder formation | **INHERITED REGRESSION** | Formation/H identity remains Slice-3 authority. Its “H begins headless” boundary must remain true. |
| VS-SFL-002 two-person formation smoke | **INHERITED REGRESSION** | No new role semantics are created by minimal formation. |

A new Slice-4 witness must go beyond the old headless boundary: <code>VS-SFL-060</code> requires one persistent role record for H that is vacant after formation. Slice-3 <code>S3-014-NEW-HOUSEHOLD-HEADLESS-BOUNDARY</code> remains an exact inherited regression and cannot substitute for the new role-identity assertion.

### 3.2 Continuity / turnover family — VS-SFL-010..014

All five cards remain **INHERITED REGRESSION**.

Slice 4 must additionally re-exercise the parts whose negative statements now face a real Household initiative/role implementation:

- same H survives holder turnover;
- Inactive H has no Household initiative;
- Dissolved H has no Household action;
- participation end can change role occupancy without rewriting H identity;
- continuity is still warrant-backed and never role-holder similarity.

The Slice-4 vacancy and succession witnesses must consume this stable-H substrate rather than recreate Household identity.

### 3.3 Controlled lineage family — VS-SFL-020..026

All are **INHERITED REGRESSION**.

Role occupancy, succession, provision authority, and mediated marriage must not become lineage inputs or inherited causal state. <code>S3-060-LINEAGE-NONAUTHORITY</code> is particularly high risk: lineage may not transfer authority, role occupancy, Recognition, provision rights, or pending action state.

General repeated predecessor rejoin/re-exit source selection remains **FUTURE / DEFERRED** under LATER-03 unless Slice 4 independently admits such histories.

### 3.4 Recognition / information family — VS-SFL-030..035

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-030 mediated-route Recognition causality | **REQUIRED S4** | The exact H + bride-participation + current-head/scope gate becomes executable. |
| VS-SFL-031 stale head Recognition through succession | **REQUIRED S4** | This is the canonical outsider-staleness/succession witness. |
| VS-SFL-032 event order beats late old message | **INHERITED REGRESSION + REQUIRED S4 HEAD INSTANTIATION** | Generic evidence precedence passed in Slice 2; head succession needs an explicit instantiation. |
| VS-SFL-033 incomparable Recognition evidence => Contested | **INHERITED REGRESSION + REQUIRED S4 HEAD INSTANTIATION** | Candidate/H Recognition conflict already exists; current-head Recognition must not gain an ID/arrival winner. |
| VS-SFL-034 communication consumes personal initiative | **INHERITED REGRESSION** | No free role-information broadcast. |
| VS-SFL-035 Recognition independent of attitude/compliance | **INHERITED REGRESSION + HEAD-PROPOSITION EXTENSION** | Head Recognition remains evidence-backed, not approval/obedience. |

The frozen prior rows are not reclassified. Slice 4 needs new acceptance rows that instantiate the already accepted generic epistemic laws on the new head/authority proposition.

### 3.5 Provision grounding family — VS-SFL-040..046

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-040 commitment acquisition without pooling | **REQUIRED S4** | Endogenous head-scoped solicitation/acceptance becomes live. |
| VS-SFL-041 grounded 1-grain Household support | **REQUIRED S4** | First actual Household-originated spend. |
| VS-SFL-042 mediated-marriage dowry | **REQUIRED S4, but topology-dependent portion BLOCKED by LATER-05** | Material accounting is accepted; exact authority/response topology must be resolved before freeze. |
| VS-SFL-043 dissolution terminates backing/no confiscation | **INHERITED REGRESSION** | Already promoted in Slice 3; now must remain true with actual spending surfaces present. |
| VS-SFL-044 provision reconsideration cooldown | **REQUIRED S4** | Head-scoped acquisition/reconsideration was expressly deferred to Slice 4. |
| VS-SFL-045 protected reserve boundary | **INHERITED grounding + REQUIRED S4 spend enforcement** | Capacity arithmetic already passed; actual debits must now prove reserve protection. |
| VS-SFL-046 multi-contributor fixed-rank expenditure | **REQUIRED S4** | Debit ranking/exhaustion becomes executable. |

Slice 3's controlled provision fixture cannot satisfy <code>VS-SFL-040</code>. When acquisition itself is under test, the commitment must be produced through the endogenous head request + counterparty response + commit path.

### 3.6 No Household self-confirmation family — VS-SFL-050..053

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-050 Household support cannot become formation evidence | **REQUIRED S4** | Actual Household-originated support now exists. |
| VS-SFL-051 Household feedback cannot clone existing identity | **REQUIRED S4** | The exact feedback path deferred from Slice 3 becomes executable. |
| VS-SFL-052 Household feedback cannot satisfy fresh lineage evidence | **REQUIRED S4** | Household support must remain excluded from lineage freshness. |
| VS-SFL-053 label/diagnostic ablation | **INHERITED REGRESSION** | Already required with Slice-3 Household state. |

This is an important “new action activates old negative rule” family: Slice 4 must prove that its new collective outputs do not become their own institutional evidence.

### 3.7 Head role / vacancy / succession / dual mode — VS-SFL-060..066

**VS-SFL-060 through VS-SFL-066 are all REQUIRED S4.**

They were deliberately deferred by Slice 3 and are now the central Slice-4 role family:

- 060 persistent vacant role on newly formed H;
- 061 unanimous initial appointment + decline/unanimity/nonparticipant negative matrix;
- 062 vacancy after head participation end without H destruction/backing loss;
- 063 succession A→B with same H ID and same role ID;
- 064 personal and Household contexts are separate from one common committed snapshot;
- 065 personal/Household shared-backing conflict resolves centrally;
- 066 scoped authority negative action census.

No subset of these may be replaced by “head works” integration evidence.

### 3.8 Resolution / reaction family — VS-SFL-070..076

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-070 Declined vs Unable | **INHERITED REGRESSION** | Failure taxonomy remains unchanged. |
| VS-SFL-071 accepted then invalidated | **INHERITED REGRESSION + REQUIRED S4 authority/capacity instantiation** | Slice 4 creates new authority-dependent invalidation causes. |
| VS-SFL-072 provision priority | **REQUIRED S4** | Support > other valid Household provision > ordinary personal transfer is now executable. |
| VS-SFL-073 bounded failure reason/privacy | **INHERITED REGRESSION + role-specific reason extension** | <code>HeadRoleNoLongerValid</code>-style reasons must not leak unrelated state. |
| VS-SFL-074 cause idempotence | **INHERITED REGRESSION** | New role/provision reactions must obey it. |
| VS-SFL-075 multi-reaction closure | **INHERITED REGRESSION** | New appointment/vacancy/succession reactions must still reach stable closure. |
| VS-SFL-076 communication provenance link | **INHERITED REGRESSION** | Head correction must use accepted provenance, not a new broadcast path. |

The exact order/result for an authority-destroying transition racing an accepted authority-dependent action is **BLOCKED PENDING LATER-04 AUTHORITY**.

### 3.9 Determinism / recovery / explainability — VS-SFL-080..087

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-080 MaterialDeadlock | **INHERITED REGRESSION** | New Household capability must not create rescue grain. |
| VS-SFL-081 stable-ID fallback quarantine | **INHERITED REGRESSION + REQUIRED S4 role/fallback instantiation** | Appointment/unanimity/authority validity may never be technical-tie outcomes. |
| VS-SFL-082 safe checkpoint exact suffix | **DEFER S5** | Engine save/restore remains outside Slice 4. |
| VS-SFL-083 omitted checkpoint state detected | **DEFER S5** | Same. |
| VS-SFL-084 derived rebuild equivalence | **INHERITED REGRESSION + REQUIRED S4 new-state extension** | Role/occupancy/provision summaries/candidate indexes must not become hidden authority. |
| VS-SFL-085 observer noninterference | **INHERITED REGRESSION + REQUIRED S4 new-surface extension** | Reading role/authority traces cannot alter behavior. |
| VS-SFL-086 decision trace completeness | **REQUIRED S4 for Household/role contexts; inherited for personal/response** | New context must expose candidates/gates/components/result/subjective inputs/config. |
| VS-SFL-087 causal intervention | **REQUIRED as an S4 structured causal-control method where role/Recognition explanations are asserted; rendered-explanation UI remains FUTURE/UNEXERCISED** | Do not silently activate the frozen Slice-1 rendered-UI deferral. |

The frozen <code>S1-087</code> rendered-explanation-surface row remains unchanged. Slice 4 can and should use trace/provenance intervention to verify causality without requiring a rendered explanation product surface.

### 3.10 Lower-level social fabric — VS-SFL-090..099

All lower-level cards remain **INHERITED REGRESSION**.

Highest-risk anchors for Slice 4:

- VS-SFL-091 semantic transfer meanings stay distinct;
- VS-SFL-095 direct mutual-strong-like marriage bypass stays independent of Household mediation;
- VS-SFL-096 residence does not become participation/office authority;
- VS-SFL-098 one personal initiative remains separate from responses;
- VS-SFL-099 scorer-domain relationship behavior remains person-level.

Person-level actions do not become office acts merely because their actor is the head.

### 3.11 Counterparty response family — VS-SFL-100..105

| Card | Slice-4 disposition | Reason |
|---|---|---|
| VS-SFL-100 | **INHERITED REGRESSION** | Counterparty autonomy unchanged. |
| VS-SFL-101 | **INHERITED REGRESSION** | Feasibility still precedes preference. |
| VS-SFL-102 | **INHERITED REGRESSION** | Called-favour response closure unchanged; household/role payloads remain non-callable under v0. |
| VS-SFL-103 | **INHERITED REGRESSION** | Multiple accepted responses may later conflict; same-snapshot principle remains. |
| VS-SFL-104 role-scoped response | **REQUIRED S4, topology-dependent mediated-marriage portion BLOCKED by LATER-05** | Response profile cannot create authority. |
| VS-SFL-105 | **INHERITED REGRESSION** | Responses do not consume personal initiative. |

### 3.12 Cross-cutting verification contract and scoring profiles

**REQUIRED / inherited across Slice 4:**

- always-on identity/reference, material, cardinality, temporal/process invariants;
- storage/input iteration permutation;
- nonsemantic ID renaming except explicit technical-fallback sensitivity;
- disconnected-population locality;
- observer/diagnostic noninterference;
- derived rebuild equivalence;
- irrelevant-attribute perturbation;
- message-arrival permutation;
- fixture write-set audit;
- independent-oracle restrictions;
- semantic mutant/fault controls;
- canonical/held-out separation.

**Newly live verification configuration:**

- <code>SCORE-VP-003</code> Household support context;
- <code>SCORE-RP-005</code> role-scoped response;
- <code>SCORE-VP-002</code> remains paired with VP-003 for dual-mode conflict;
- recorded fallback domain must distinguish scorer tie fallback from central-resolution fallback.

**DEFER S5:**

- checkpoint metamorphism and omission-state recovery controls.

**FUTURE / UNEXERCISED unless separately activated:**

- general generated/shrink infrastructure (S3-U01 / VH-02 trigger);
- rendered explanation UI;
- general organization/candidate-convergence theory;
- general contested succession/multiple simultaneous authority claimants.

## 4. Minimum omission-detectable Slice-4 completion witnesses

The IDs below are proposed acceptance-design labels, not new semantic authority. Their purpose is to prevent broad integration scenarios from hiding missing obligations.

| Proposed witness | Minimum observable claim | Canonical basis |
|---|---|---|
| W-S4-01 HEADLESS-ROLE | Newly formed H has a persistent <code>HouseholdHeadRole(H)</code>, same H identity, role vacant, no Household initiative, and no implicit founder election. | 060 + S3-014 |
| W-S4-02 INITIAL-APPOINTMENT | Valid nomination by current participant, current-participant nominee, nominee acceptance, unanimous current-participant acceptance/recognition => sole occupant. | 061 |
| W-S4-03 APPOINTMENT-NEGATIVE-MATRIX | Nominee decline; one missing unanimity vote; nonparticipant nominator; nonparticipant nominee each prevents occupancy; no majority/ID fallback. | 061 |
| W-S4-04 VACANCY | Head participation ends; H remains same Active H when enough participants remain; role becomes vacant; exiting head commitment ends, other commitments remain; no Household initiative. | 062 |
| W-S4-05 SUCCESSION | A→B changes occupant but preserves H ID and exact role ID; event links old/new occupancy; no role recreation. | 063 |
| W-S4-06 HEAD-RECOGNITION-STALE | Outsider X retains predecessor A after unwitnessed A→B objective succession; no passive synchronization. | 031 |
| W-S4-07 HEAD-RECOGNITION-CORRECTION | Accepted event-backed communication/direct evidence of newer B succession updates routing to B with full provenance. | 031/032 |
| W-S4-08 HEAD-RECOGNITION-CONTESTED | Nondominated incompatible head evidence becomes Contested and cannot safely gate authority action; no ID/arrival winner. | 033 |
| W-S4-09 DUAL-MODE-COMMON-SNAPSHOT | Head has one personal trace and H one separate Household trace; both read same committed snapshot; H scoring uses Household concerns/capability; no role mind/omniscience. | 064 |
| W-S4-10 DUAL-MODE-COMPATIBLE-COMMIT | Compatible personal + Household actions both commit; neither initiative consumes the other; responses remain separate. | 064 + inherited 098/105 |
| W-S4-11 DUAL-MODE-CONFLICT | Same-snapshot personal gift and Household support compete for shared backing; central priority/revalidation commits support and invalidates personal action without refusal/retry. | 065 |
| W-S4-12 SCOPED-AUTHORITY-CENSUS | No head candidate/action can seize personal grain, command residence/gift/loan/favour, create kinship/debt/favour, or alter attitude; person-level routes remain independent. | 066 |
| W-S4-13 PROVISION-ACQUISITION | Head solicits noncontributing sustaining participant; target accepts via real response path; commitment created; grain unchanged; capacity derived; no treasury. | 040 |
| W-S4-14 PROVISION-RECONSIDERATION | Decline → before 3 cycles ineligible; after 3 with no context change still ineligible; after 3 + one accepted relevant context change eligible; irrelevant change does not unlock. | 044 |
| W-S4-15 HOUSEHOLD-SUPPORT | Active H + valid head + valid backing commits 1-grain support; backing person debited exactly once, recipient credited exactly once, Need clears; Inactive/vacant/nonparticipant controls fail. | 041 |
| W-S4-16 MULTI-CONTRIBUTOR-DEBIT | Precommit capacities ranked once, exact ties only by semantic person ID, contributors exhausted in fixed order, no rerank, exact debit vector history, insufficient capacity atomically fails. | 046 |
| W-S4-17 MEDIATED-MARRIAGE | Bride participation fact + H/head Recognition + current authority + backing + accepted route produce dowry debit, groom credit, marriage and exactly one groom→head favour; bypass remains independent. | 042/030/104; **LATER-05 blocks exact topology freeze** |
| W-S4-18 PROVISION-PRIORITY | Eligible support > other valid Household provision > ordinary personal transfer; lower-priority attempts revalidate after higher-priority commits. | 072 |
| W-S4-19 AUTHORITY-RACE | Pending authority-dependent action is challenged by head exit/vacancy, succession, and/or H lifecycle loss in same cycle; result must be omission-detectable. | §9.2 + LATER-04; **expected ordering/result blocked pending authority** |
| W-S4-20 INACTIVE-VACANT-NO-INITIATIVE | Active+occupied enables H initiative; vacant or Inactive suppresses it; Dissolved suppresses it; personal initiatives remain available where otherwise valid. | 060/062 + S3-033/036 |
| W-S4-21 HOUSEHOLD-FEEDBACK-NONAUTHORITY | Actual Household-originated support cannot satisfy formation evidence, clone H, or satisfy fresh lineage evidence. | 050/051/052 |
| W-S4-22 ROLE-FALLBACK-QUARANTINE | Appointment/succession validity, unanimity, Recognition and current authority never fall through to technical ID/container ordering. | 061/063/081 + S3-090 |
| W-S4-23 ROLE-TRACE-TRUTH | Appointment/succession/Household decision traces identify actual rule/config, exact gates/evidence, score components where applicable, selected result, causal event refs, and correct fallback domain. | 086 + S3-092/R10 |
| W-S4-24 ROLE-CAUSAL-INTERVENTION | Removing one claimed critical authority/Recognition cause while holding irrelevant facts fixed removes/changes the candidate/result; irrelevant perturbation does not. | 087 + S3-094 |

The manifest should also keep every prior-slice REQUIRED row individually visible through inherited regression reporting rather than hiding “all prior tests pass” behind one aggregate row.

## 5. Role identity / occupancy / Recognition oracle requirements

### 5.1 What the independent oracle must reconstruct

The checker must reconstruct the claimed role result from public authoritative evidence without calling a production role classifier, appointment validator, Recognition resolver, candidate gate, decision scorer, or transition helper whose result is under judgment.

For each appointment/succession:

1. identify H from pre-existing verified Household evidence;
2. identify the one persistent role record anchored to H;
3. reconstruct pre-transition occupant (vacant or A);
4. identify the exact nomination event:
   - nominator identity;
   - nominee identity;
   - H/role identity;
   - semantic time;
5. independently establish nominator and nominee were current SustainingParticipants at the relevant authoritative snapshot/precommit point;
6. identify exact nominee acceptance;
7. reconstruct the complete current sustaining-participant set at the required acceptance point;
8. prove one accepted appointment/succession acceptance/recognition from every required current participant;
9. reject duplicates as substitutes for distinct participant unanimity;
10. reject acceptance from a nonparticipant as a substitute for a missing participant;
11. reconstruct commit-time eligibility and current role/H validity;
12. verify the occupancy transition:
    - vacant→B for initial appointment; or
    - A→B for succession;
13. verify exact role ID persists through succession;
14. verify exact H ID persists;
15. verify direct transition participants acquire the resulting head-role Recognition only through their participation evidence;
16. verify an uninvolved outsider does not acquire B merely from objective state;
17. verify any outsider correction names the actual newer event/evidence and communication/direct-observation provenance;
18. verify no auto-election/majority/fallback event is present.

The expected answer is derived from accepted facts/events and simple set logic. “Production says B is current head” is an observation to check, never the oracle.

### 5.2 Recognition-specific oracle boundary

The checker must distinguish:

- objective current occupant;
- actor's held head proposition;
- Recognition status;
- exact supporting EvidenceId/event;
- provenance route and event time;
- message delivery time.

It must be possible for objective B and outsider-held A to coexist after unwitnessed succession.

A final <code>Recognized</code> enum alone is insufficient evidence. The oracle must inspect freshness/provenance to distinguish:

- stale predecessor Recognition;
- direct transition-participant Recognition;
- corrected successor Recognition;
- Contested incompatible evidence.

Current participant status, current head occupancy, shared residence, observer history, or “engine knows B” cannot be treated as an information-acquisition route.

### 5.3 Detached corruptions / adequacy challenges

At minimum, an independent checker should reject detached/fabricated witnesses with one corruption at a time:

- succession creates a new role ID while leaving H unchanged;
- succession creates a new H or rewrites H reference;
- occupant changes without a nomination event;
- nomination cites wrong H/role;
- missing nominee acceptance;
- acceptance attributed to wrong nominee;
- one required participant acceptance removed;
- duplicate one participant acceptance used twice to fake unanimity;
- nonparticipant acceptance substituted for a current participant;
- nominator became nonparticipant before commit;
- nominee became nonparticipant/ineligible before commit;
- current participant set reconstructed from the wrong time;
- predecessor A remains objective occupant while history claims B;
- outsider B Recognition fabricated without accepted evidence;
- direct participant's Recognition cites an unrelated event;
- correction references an older/predecessor event;
- communicated correction invents a proposition sender did not hold;
- later-arriving old report overwrites newer event-backed successor evidence;
- Contested head Recognition arbitrarily selects by sender/person/role ID;
- auto-election installs lowest/highest ID without the accepted unanimity chain.

### 5.4 Metamorphic controls

- reorder proposal/container enumeration: valid appointment/succession result unchanged;
- consistent nonsemantic ID renaming: isomorphic result, except an explicitly authorized technical fallback domain that is not social appointment;
- add disconnected actors/Households: role result unchanged;
- enable/disable diagnostics/readers: role result unchanged;
- permute message arrival while preserving underlying event order: final evidence resolution follows event order;
- rebuild derived role/candidate indexes at a safe stable boundary: result/query equivalence;
- change an explicitly irrelevant attribute: role result unchanged.

For counterfactual/detached resolution, newly allocated event/relation/evidence IDs must be compared through semantic causal origin where appropriate. Allocation noise must not manufacture a false <code>TechnicalFallback</code> conflict.

## 6. Fixture authority for Slice-4 acceptance

General rule: fixtures may supply bounded lower-level prerequisites and may reuse already-produced verified state, but may not directly write the result whose endogenous production is the claim.

| Witness class | May seed/reuse | Must never direct-write when under test |
|---|---|---|
| Headless role after formation | verified produced H/founding state with producer provenance | role occupancy; implicit elected head |
| Initial appointment | verified Active headless H; participant/residence/lower-level facts | occupied-head result; appointment result/warrant/event; final participant head Recognition |
| Succession | verified produced H + role/occupant A from a passed appointment producer | B occupancy; succession result/event; replacement role ID; final successor Recognition |
| Vacancy | verified produced occupied role and H; accepted participant configuration | vacancy result; H destruction/preservation result; remaining commitment result |
| Head Recognition staleness/correction | outsider's older held evidence may be a declared prerequisite only when its acquisition is not under test; preferably reuse a produced evidence checkpoint | final corrected Recognition; fabricated succession evidence; passive broadcast |
| Dual-mode deliberation | produced Active H + valid occupied role; pinned canonical scoring profiles and target bindings | generated candidate set; final scores; HouseholdDecisionContext result/winner; personal result/winner |
| Provision acquisition | produced Active H + valid head + noncontributor state | provision commitment itself; acceptance result; derived capacity result |
| Provision spend | produced valid commitment may be reused when acquisition is not the assertion target | debit vector; contributor spend result; Household treasury balance; support result |
| Reconsideration | produced prior declined request and recorded baseline | cooldown eligibility result; changed-context verdict |
| Mediated marriage | lower-level eligibility/attitudes/residence and produced H/head/commitments where those are prerequisites | mediated result; marriage/favour/dowry result; final role response; head Recognition under test |
| Authority race | verified pre-cycle authoritative state and proposals from public boundaries | winner/order/invalidation result; post-race occupancy/lifecycle |
| No-self-confirmation | verified H plus actual production path for Household support | formation/lineage result or “support qualifies” classification |

### 6.1 Produced-state reuse rule

A downstream Slice-4 card may begin from a produced role/H/provision state only if the reused output records at least:

- producer/scenario identity;
- pass result;
- fixture audit;
- authority/configuration/rule version;
- exact output identity.

This extends the already frozen <code>S3-091-VERIFIED-PRODUCER-PROVENANCE</code> discipline.

It is verification producer provenance, not an engine checkpoint/restore claim.

### 6.2 Controlled provision fixture after Slice 4 exists

Slice 3 permits a controlled pre-existing provision commitment because acquisition was outside that slice.

In Slice 4:

- it remains permissible only as a prerequisite for a card whose assertion target is not acquisition;
- it may not satisfy W-S4-13 / VS-SFL-040;
- where practical, prefer reuse of a commitment produced by the new endogenous acquisition witness so fixture-only state does not mask integration defects.

## 7. Dual-mode / initiative accounting requirements

Slice 4 must prove all of the following in one omission-detectable bundle and in targeted subcases:

1. head P receives exactly one ordinary personal initiative;
2. H receives exactly one separate Household initiative through P when Active + occupied;
3. Household initiative does not consume/cancel P's personal initiative;
4. P's personal initiative does not consume/cancel H's initiative;
5. both deliberate from the same committed cycle snapshot;
6. neither sees uncommitted effects of the other's proposal;
7. incoming response contexts remain separate from both initiative counts;
8. P may execute multiple valid responses without gaining/losing either initiative;
9. Household scoring uses Household concerns/capability and the declared Household profile, not P's personal score;
10. role/H provides authority context but does not create a second omniscient subjective state;
11. P's non-office subjective knowledge remains P's actor-specific state;
12. compatible personal and Household attempts may both commit;
13. incompatible attempts resolve centrally; no same-cycle redeliberation/extra initiative occurs after invalidation.

### Exact inherited initiative/response regressions at greatest risk

- <code>S1-098-CORE</code>
- <code>S1-105</code>
- <code>S3-R03-INITIATIVE-RESPONSE-ACCOUNTING</code>, including:
  - <code>S2-024F-FACT-COMMUNICATION-INITIATIVE-COST</code>
  - <code>S2-024R-RECOGNITION-COMMUNICATION-INITIATIVE-COST</code>
  - <code>S2-026F-FACT-RECEIPT-NO-REACTIVATION-OR-RESPONSE</code>
  - <code>S2-026R-RECOGNITION-RECEIPT-NO-REACTIVATION-OR-RESPONSE</code>
  - <code>S2-044-OBJECTIVE-REVALIDATION-PRESERVED</code>
- inherited VS-SFL-100/101/103/105 response-autonomy and accepted-then-resolution semantics.

A Slice-4 implementation must not implement “two modes” as two personal turns for P.

## 8. Same-cycle authority / dependency trigger map

RUN-0003 is used here only as a risk lens. Accepted SPEC/verification remains the authority.

| Prospective dependency | Classification | Slice-4 acceptance requirement |
|---|---|---|
| Nominee eligibility/participant state changes before occupancy commit | **Accepted semantic rule already applies + NEW S4 witness needed** | Immediate precommit revalidation includes participant/status eligibility. Produce an accepted nomination whose nominee or nominator loses eligibility before commit; occupancy must not be installed. No new semantic priority is needed merely to assert final eligibility revalidation. |
| Head exits/vacates while an authority-dependent action is pending | **SEMANTIC GAP — LATER-04 FIRED** | Must be represented in acceptance, but exact resolution/order cannot be frozen until authority decides the race. Stable-ID/container order may not decide semantically unequal authority states. |
| Succession changes current holder before another authority-dependent action commits | **SEMANTIC GAP — LATER-04 FIRED** | Same blocker. Need authoritative rule for whether/how pending action survives, rebinds, or invalidates; tests may not guess. |
| H becomes Inactive/Dissolved while Household action is pending | **Accepted action gate + LATER-04 interaction risk; new witness required, exact same-cycle ordering blocked where outcomes depend on transition order** | H action requires Active H and current authority. If accepted transitions can race, freeze requires the LATER-04 decision rather than technical order. |
| Provision capacity changes before Household spend commit | **Already required canonically + NEW S4 completion witness** | Revalidate live capacity. VS-SFL-065/072/046 cover shared-backing, priority and debit behavior. Additional same-cycle capacity loss should terminate with bounded failure/invalidation, never stale capacity. |
| Head Recognition becomes stale or Contested | **Already required by Recognition action gate + NEW S4 head-specific witness** | Authority-dependent candidate generation/use requires safely Recognized current head/scope; stale predecessor or Contested evidence cannot be replaced by objective engine truth. |
| Personal and Household actions compete for same backing | **Already required canonically** | VS-SFL-065 + VS-SFL-072 are mandatory. |
| Prospective nominee/holder affects dependency graph before occupancy | **Accepted precommit requirements + NEW S4 dependency adequacy witness** | Dependency grouping must include prospective nominees and actors whose state affects eligibility, not only current holders/current participants. |

### 8.1 LATER-04 decision boundary

Accepted authority already establishes:

- all action-relevant preconditions revalidate immediately before commit;
- current head validity/authority matters;
- H must be Active for Household action;
- accepted proposals can become <code>InvalidatedAtResolution</code>;
- technical fallback applies only after semantic/domain priorities are exhausted.

What is not uniquely fixed is the semantic ordering/interaction when an accepted authority-destroying transition and an accepted authority-dependent action coexist and either could commit first. Because the two orders can change whether the authority-dependent effect commits, raw proposal ID, container order, or technical fallback cannot be allowed to invent the social rule.

The authority resolution should specify the narrow v0 behavior rather than introduce a general transaction theory.

## 9. Fallback / ordering quarantine

Slice-4 acceptance must make the following failures independently visible.

### 9.1 Appointment/succession is not a tie problem

Forbidden:

- lowest/highest role/person/proposal ID auto-election;
- majority vote as fallback for missing unanimity;
- fixture order choosing a nominee;
- stable-ID selection between semantically unequal “eligible” and “ineligible” candidates;
- stable-ID selection between “unanimous” and “not unanimous.”

Unanimity is a categorical requirement. Failure to satisfy it means no appointment, not a technical tie.

### 9.2 Allocation-ID noise is not social conflict

Detached/counterfactual permutations may allocate different internal event/relation/evidence IDs while representing the same causal history.

Acceptance must normalize/compare through semantic causal origins where necessary and fail an implementation/checker that reports a central <code>TechnicalFallback</code> solely because incidental allocation identities differ.

This is the direct Slice-4 continuation of the candidate-v2/v3 assurance lesson.

### 9.3 Distinguish scoring fallback from resolution fallback

Human-facing and machine evidence should explicitly name the domain:

- **Decision/scoring tie fallback** — selecting among exactly tied scored candidates after valid gates;
- **Central-resolution technical fallback** — resolving semantically equal incompatible committed attempts after all semantic/domain priority.

A trace field with only <code>TechnicalFallback=true</code> is insufficient for a Slice-4 explanatory summary if it makes these two meanings indistinguishable.

### 9.4 Technical fallback cannot decide authority validity

No technical fallback may select among states that differ on:

- current vs former head;
- current participant vs nonparticipant nominee/nominator;
- accepted unanimity vs missing acceptance;
- Active vs Inactive/Dissolved H;
- valid provision backing vs insufficient backing;
- Recognized current authority vs stale predecessor/Contested authority.

These are semantic gates/preconditions, not unresolved symmetry.

## 10. Exact prior-slice regression protection

A future Slice-4 manifest should continue to execute/report every frozen REQUIRED prior row. In addition, it should bind the following high-risk bundles explicitly so omission cannot hide behind a global regression count.

### 10.1 Household identity / continuity independent of role

Keep all Slice-3 participation/continuity/lifecycle REQUIRED rows green, especially:

- <code>S3-027-PARTICIPATION-END-WARRANT</code>
- <code>S3-030-EXIT-SIDE-CONTINUATION</code>
- <code>S3-031-COMPLETE-FOUNDER-TURNOVER</code>
- <code>S3-032-BROKEN-BRIDGE-SIMILAR-ENDPOINT</code>
- <code>S3-033-INACTIVE-STATE</code>
- <code>S3-034-INACTIVE-REACTIVATION</code>
- <code>S3-035-SAME-CYCLE-BRIDGE-HANDOFF</code>
- <code>S3-036-DISSOLUTION-STABLE-CLOSURE</code>
- <code>S3-037-DISSOLVED-NO-RESURRECTION</code>
- <code>S3-038-CONTINUITY-OVER-DUPLICATE-FORMATION</code>
- <code>S3-039-SEPARATE-EVIDENCE-MAY-FORM-OVERLAP</code>.

New role occupancy must be subordinate to, not redefine, this identity chain.

### 10.2 Actor-specific Recognition / no passive sync

Keep:

- <code>S3-R01-OBJECTIVE-SUBJECTIVE-SEPARATION</code>;
- <code>S3-040..049</code> Household Recognition requirements;
- underlying Slice-2 <code>S2-006-NO-PASSIVE-SYNC</code>, <code>S2-007-NO-HISTORY-OMNISCIENCE</code>, and Recognition distinctness/retention rows.

Add head proposition evidence without collapsing it into Household Recognition or objective occupancy.

### 10.3 Communication provenance / staleness

Keep exact <code>S3-R02-COMMUNICATION-PROVENANCE-STALENESS</code>, including:

- sender-held fact/Recognition requirement;
- no invented communication;
- underlying provenance retention;
- communication initiative cost;
- no free broadcast;
- no same-cycle reactivation;
- direct vs communicated provenance;
- stale retention;
- direct/report event precedence;
- message-arrival permutation;
- Contested behavior.

### 10.4 Personal initiative / response accounting

Keep <code>S3-R03-INITIATIVE-RESPONSE-ACCOUNTING</code>, <code>S1-098-CORE</code>, and <code>S1-105</code> exact.

### 10.5 Observer noninterference

Keep <code>S3-R04-OBSERVER-NONINTERFERENCE</code> and <code>S3-088-OBSERVER-NONINTERFERENCE</code>.

Extend the metamorphic pair to role/occupancy/head-Recognition/Household-decision readers.

### 10.6 Locality

Keep <code>S3-R05-LOCALITY</code> and <code>S3-087-LOCALITY</code>.

Adding disconnected H/roles/people must not change a local appointment, succession, capacity, or authority result.

### 10.7 Fallback quarantine

Keep <code>S3-R06-FALLBACK-ID-QUARANTINE</code> and <code>S3-090-FALLBACK-QUARANTINE</code>.

Slice 4 adds appointment/succession/authority validity to the list of domains that technical fallback cannot decide.

### 10.8 Stable closure

Keep <code>S3-R08-STABLE-CLOSURE</code>, <code>S3-081..084</code>, and inherited cause-idempotence/reaction-closure rows.

Role/occupancy/Recognition reactions must close before completed-cycle publication. No fresh voluntary action may see an intermediate microstep as a new cycle snapshot.

### 10.9 Cache / derived nonauthority

Keep <code>S3-R07-CACHE-DERIVED-NONAUTHORITY</code>, <code>S3-089-DERIVED-STATE-REBUILD-EQUIVALENCE</code>, and <code>S3-093-STRUCTURAL-AUTHORITY-NONHIDING</code>.

Any “current head” lookup/index, available-Household-action index, mobilizable capacity cache, or role-recognition projection is derived/query support, not a second source of authority.

If Slice 4 changes a previously exact structural regression's implementation-local field inventory, use the same principle established in Slice 3: review a lossless adaptation; do not weaken the semantic invariant for convenience.

### 10.10 Provision capacity grounding / no pooled treasury

Keep every Slice-3 provision substrate row green:

- <code>S3-070-PROVISION-COMMITMENT-BACKING-STATE</code>
- <code>S3-071-PROVISION-EXPOSED-CAPACITY</code>
- <code>S3-072-PROVISION-NEEDSGRAIN-ZERO</code>
- <code>S3-073-NO-POOLED-HOUSEHOLD-TREASURY</code>
- <code>S3-074-MOBILIZABLE-CAPACITY-DERIVED</code>
- <code>S3-075-PARTICIPATION-END-TERMINATES-COMMITMENT</code>
- <code>S3-076-DISSOLUTION-TERMINATES-COMMITMENTS</code>.

Slice 4 intentionally supersedes only the old *capability boundary* asserted by <code>S3-077-NO-SPENDING-AUTHORITY</code>: the frozen row remains historical evidence that Slice 3 itself did not implement spending. A Slice-4 manifest must not edit/reclassify that frozen row; it adds new Slice-4 rows proving the now-authorized spending path.

### 10.11 Person-level actions remain independent of office

Keep <code>S3-R09-PERSON-LEVEL-SEMANTICS</code> and its exact lower-level bindings.

A person who happens to be head:

- still performs ordinary gifts/loans/favours/residence/marriage-bypass/communication as person-level actions;
- gains no office shortcut around counterpart responses;
- does not relabel personal transfers as Household expenditure;
- does not use role authority to compel ordinary person-person behavior.

### 10.12 Trace/configuration truth and frozen-authority integrity

Keep:

- <code>S3-R10-TRACE-CONFIGURATION</code>;
- <code>S3-R11-FROZEN-AUTHORITY-INTEGRITY</code>;
- <code>S3-091-VERIFIED-PRODUCER-PROVENANCE</code>;
- <code>S3-092-TRACE-CONFIGURATION-TRUTH</code>.

Role/Household rules must identify the rule actually exercised, not infer rule identity from an arbitrary scenario label.

## 11. Authority-integrity and corruption requirements for a future Slice-4 manifest

The acceptance authority should explicitly require:

1. **fixture-write audit** for every Slice-4 card;
2. **oracle dependency audit** proving role/Recognition/capacity/debit expected answers are not sourced from production classifiers/helpers under judgment;
3. **oracle adequacy corruptions** for role warrants/events, unanimity, occupancy identity, Recognition EvidenceIds, debit vectors, and mediated result linkage;
4. **deterministic repeated runs** for representative role/provision cases;
5. **nonsemantic iteration permutation**;
6. **isomorphic ID rename**;
7. **disconnected locality**;
8. **observer noninterference**;
9. **derived rebuild / structural nonauthority**;
10. **message-arrival permutation** for head correction;
11. **irrelevant-attribute perturbation**;
12. **technical-fallback domain census**;
13. **held-out variants** with changed role holder, evidence sender, contributor identities/capacities, and nonessential topology;
14. **fresh independent whole-candidate conformance review** against an exact frozen implementation candidate before promotion.

The independent reviewer should include detached public-boundary corruptions. Candidate-v1 of Slice 3 demonstrated why “checker does not call production” is not enough if materially false evidence still passes.

## 12. Deliberate deferrals

### Slice 5

Keep these deferred:

- VS-SFL-082 checkpoint exact-suffix continuation;
- VS-SFL-083 omitted checkpoint-state detection;
- frozen <code>S1-082</code>, <code>S1-083</code>, <code>S1-META-06</code>, <code>S1-MUT-25</code>;
- <code>S3-D10-CHECKPOINT-RESTORE</code>;
- <code>VH-04</code> checkpoint omission mutant causal suffix.

Stable-cycle/checkpoint-*safety* invariants remain inherited now; engine save/restore continuation does not.

### Still future / unexercised unless separately triggered

- S3-U01 general generated-history/shrink infrastructure; if made completion-critical, fire VH-02 first;
- LATER-01 general CandidateOrganization multi-referent convergence;
- LATER-02 executable actor departure;
- LATER-03 repeated predecessor rejoin/re-exit lineage-source selection;
- rendered causal-explanation UI;
- general contested succession/multiple simultaneous authority claimants;
- general organizational sovereignty/deep administration;
- generalized fission/merger/reconsolidation;
- stochastic/strategic planning and production persistence/scaling.

LATER-04 and LATER-05 are **not** in this deliberate-deferral list because mandatory Slice-4 behavior fires them.

## 13. Acceptance-authority readiness / blocker status

### 13.1 Draft readiness

**READY TO DRAFT.**

The accepted SPEC/ADRs and canonical Stage-3 verification package determine the overwhelming majority of Slice-4 applicability:

- all 060–066 role/dual-mode cards;
- 040/041/044/046 provision acquisition/spend;
- 030/031 head/mediation Recognition;
- 072 provision priority;
- 104 role-scoped response;
- 050–052 no-self-confirmation with actual Household support;
- inherited determinism/locality/cache/fallback/closure/initiative/response protections.

A candidate manifest can therefore be written now with explicit pending-authority markers for the two blocked areas.

### 13.2 Freeze/release blockers

**BLOCKED FOR FREEZE by two semantic items.**

#### BLOCKER S4-B01 — LATER-04 authority-destroying same-cycle race

Needed before freezing expected results for cases where:

- current head exits/vacates while a head-dependent action is pending;
- succession changes current holder before another head-dependent commit;
- H becomes Inactive/Dissolved while a Household action is pending and outcome depends on transition order.

Required authority output: one narrow accepted v0 rule that determines semantic ordering/revalidation/invalidation for these interactions, or otherwise explicitly classifies them. It must not allow container/proposal/allocation ID order to become social authority.

#### BLOCKER S4-B02 — LATER-05 mediated-marriage authority/response topology

Needed before freezing the exact VS-SFL-042 / VS-SFL-030 / VS-SFL-104 mediated path, including the female-head self-mediation companion.

Required authority output: the exact bounded v0 response/authority topology consistent with the existing statement that the accepted mediated route is head-scoped and head acceptance is sufficient, including which response contexts are created, which actor/role owns each response, and how nested-response prohibition applies. Verification must not infer this from implementation convenience.

### 13.3 Hardening item that is not currently a semantic blocker

The head-vacancy half of <code>VH-05</code> fires in Slice 4.

The acceptance design can satisfy it without inventing generic observation by using already accepted information routes:

- direct participation in the vacancy/succession transition; and
- provenance-bearing communication from an actor who actually holds the proposition.

If acceptance instead needs an uninvolved nonparticipant to learn vacancy merely by being nearby/current participant/observer, that would become a separate authority question. Do not silently add such a route.

## 14. Required return summary

### Triggered requirements

- VS-SFL-060..066 entire head/vacancy/succession/dual-mode family.
- VS-SFL-040, 041, 044, 046; spend-side enforcement of 045; mediated 042 after LATER-05 closure.
- VS-SFL-030/031 head/mediated Recognition plus head-specific instantiations of 032/033/035.
- VS-SFL-050/051/052 now that Household-originated support is executable.
- VS-SFL-072 provision priority.
- VS-SFL-104 role-scoped response after LATER-05 closure.
- Slice-4 authority/capacity instantiations of VS-SFL-071/073/081/084/085/086/087.
- Cross-cutting fixture, independent-oracle, locality, observer, cache/derived, fallback, stable-closure, metamorphic and fault-control obligations.
- Head-vacancy half of VH-05.
- LATER-04 and LATER-05 are fired and require authority resolution before freeze.

### Deliberate deferrals

- engine checkpoint/restore and omission mutants to Slice 5;
- general generated-history infrastructure unless separately activated;
- general candidate convergence, actor departure, repeated-predecessor lineage source selection unless independently triggered;
- rendered explanation UI;
- general contested succession/multiple simultaneous claimants and other explicit v0 exclusions.

### New Slice-4 completion witnesses

At minimum W-S4-01 through W-S4-24 above, covering:

- persistent vacant role after formation;
- appointment positive + full negative matrix;
- vacancy without H destruction;
- same-role succession;
- stale/corrected/Contested head Recognition;
- dual-mode common-snapshot accounting, compatible commit and conflict;
- scoped-authority negative action census;
- endogenous provision acquisition and reconsideration;
- support, fixed-rank multi-contributor debit, mediated dowry;
- provision priority;
- authority-dependent race coverage;
- Inactive/vacant/Dissolved no-initiative controls;
- Household-feedback nonauthority;
- fallback quarantine;
- trace/configuration truth and causal intervention.

### Exact inherited regressions

Highest-risk exact bundles:

- Slice-3 participation/continuity/lifecycle S3-020..039;
- Household Recognition S3-040..049;
- provision substrate S3-070..076;
- determinism/nonauthority S3-080..094;
- S3-R01 objective/subjective separation;
- S3-R02 communication provenance/staleness;
- S3-R03 initiative/response accounting;
- S3-R04 observer noninterference;
- S3-R05 locality;
- S3-R06 fallback-ID quarantine;
- S3-R07 cache/derived nonauthority;
- S3-R08 stable closure;
- S3-R09 person-level semantics;
- S3-R10 trace/configuration;
- S3-R11 frozen-authority integrity;
- every prior frozen REQUIRED Slice-1 and Slice-2 AcceptanceId individually green.

### Oracle / corruption requirements

Independent verification must reconstruct role identity/occupancy/unanimity/eligibility and head Recognition from exact public event/evidence references, not production role classifiers. Detached corruptions must include role recreation, wrong H/role link, missing/duplicate/wrong-party acceptance, stale-time participant sets, prospective nominee eligibility loss, fabricated Recognition EvidenceIds, passive outsider sync, bad correction provenance, auto-election, and allocation-ID false fallback. Metamorphic controls must cover enumeration, ID renaming, locality, observer noninterference, message-arrival order, rebuild equivalence, and irrelevant attributes.

### Acceptance-manifest blocker status

**Candidate manifest: READY TO DRAFT.**  
**Freeze/release: BLOCKED pending authoritative closure of LATER-04 and LATER-05.**

No other currently known item prevents drafting the bounded Slice-4 acceptance authority while keeping Slice-5 recovery and other future work explicitly deferred.
