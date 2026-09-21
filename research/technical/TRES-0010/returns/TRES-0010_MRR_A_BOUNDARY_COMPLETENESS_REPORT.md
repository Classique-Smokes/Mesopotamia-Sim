# TRES-0010 MRR-A — Boundary Completeness Report

## 0. Return metadata

- **Task ID:** TRES-0010-MRR-A
- **Terminal verdict:** `BOUNDARY_REPAIR_REQUIRED`
- **Frozen baseline ref:** `tres-0010-manifest-repair-review-baseline`
- **Frozen baseline SHA:** `8a809a05276571fb15845f012dc7dae1c71380d8`
- **Return branch:** `tres-0010/mrr-boundary`
- **Model/configuration:** GPT-5.6 Sol
- **Tools used:** GitHub repository connector for branch/ref resolution, baseline comparison, file retrieval, and return-file creation; model reasoning for source reconciliation.
- **External research:** no
- **Sibling returns read before completion:** no
- **Prior manifest BLOCK report read before completion:** no
- **Canonical files modified:** no
- **Return file only:** `research/technical/TRES-0010/returns/TRES-0010_MRR_A_BOUNDARY_COMPLETENESS_REPORT.md`

### Frozen source blobs reviewed

- `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md` — `6781e17ef5dd7b3ce5c7f23df39d46ac59b2dc74`
- `plans/verification/SFL_V0/SLICE1_ACCEPTANCE_MANIFEST.md` — `d3918bd616fa6f880d7621a62b4d7a073914e69f`
- `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md` — `e64e1160ba42aec9779d0746d93f62ebecfe1137`
- `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md` — `a1f0fa35de6f1cf70e59dd0e4cc483d0aadfbc52`
- `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md` — `5ff85234e91d3dbcb3779048e63ade1493105f02`
- `plans/verification/SFL_V0/RESPONSE_DECISION_FAMILY.md` — `6aa88185027bdec2da553b37cfd53c10eeb15153`
- `plans/verification/SFL_V0/RESOLUTION_REACTION_FAMILY.md` — `7d765988330146ddedd5e9849108eaf10831717d`
- `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md` — `cb979360e3a61239b5e918979dd01f48e0b3867e`
- `plans/verification/SFL_V0/FORMATION_FAMILY.md` — `d3280e441f1bc273474c5a5b453a88e48aa41394`
- `plans/verification/SFL_V0/CONTINUITY_TURNOVER_FAMILY.md` — `30e596a44df4eea868829c24b2fd4c3744d2a3c2`
- `plans/verification/SFL_V0/LINEAGE_FAMILY.md` — `352669d3ef647fb13b518bc613aafa81605a47a1`

## 1. Executive result

The candidate manifest does **not** close the complete cross-cutting boundary surface.

The independent source-first inventory found three repair items:

1. **Missing provision-reconsideration timing coverage.** The cross-cutting contract has three distinct cooldown boundary states, confirmed by SPEC §8.2 and VS-SFL-044, but Part E has no acceptance row for them. The existing deferred household-provision row names only capacity / NeedsGrain contributor boundaries and does not cover timing/reconsideration.
2. **Lineage predecessor-state coverage is too narrow.** The source matrix explicitly requires the boundary `one predecessor survives versus both Dissolved`. `S1-BND-LINEAGE` names only “lineage freshness/ambiguity boundaries,” which does not identify this separate predecessor-lifecycle axis.
3. **The Slice-1 reserve row is worded too broadly.** `S1-BND-RESERVE` uses rationale “Debt/transfer reserve.” Accepted semantics establish the protected 2-grain reserve for `RepayDebt` (SPEC §3.3; VS-SFL-092) and household provision (SPEC §8.1; VS-SFL-045), not a generic reserve for every lower-level transfer meaning. The status is correct, but the wording can make an implementation infer a non-existent generic transfer reserve.

No row required semantic escalation: every Slice-1 status below is derivable from accepted SPEC plus IMP-0001 scope.

## 2. Method

The review followed the packet order:

1. derive the complete boundary inventory from `CROSS_CUTTING_VERIFICATION_CONTRACT.md` §2 without using the manifest;
2. classify each boundary from accepted SPEC and IMP-0001 scope;
3. consult canonical family files only where needed to disambiguate whether the substrate is in Slice 1 or deferred;
4. read and map the candidate manifest;
5. run an anti-whack-a-mole check for collapsed rows and wording that could broaden scope.

Source shorthand below:

- **CCVC** = `plans/verification/SFL_V0/CROSS_CUTTING_VERIFICATION_CONTRACT.md`
- **SPEC** = `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`
- **IMP** = `tasks/implementation/IMP-0001_SFL_V0_SLICE1_LOWER_LEVEL_KERNEL.md`
- **LLSF** = `plans/verification/SFL_V0/LOWER_LEVEL_SOCIAL_FABRIC_FAMILY.md`
- **PROV** = `plans/verification/SFL_V0/PROVISION_GROUNDING_FAMILY.md`
- **LIN** = `plans/verification/SFL_V0/LINEAGE_FAMILY.md`

## 3. Complete boundary inventory and manifest reconciliation

| # | Source boundary / clause | Independent Slice-1 status | Scope basis | Current manifest mapping | Treatment |
|---:|---|---|---|---|---|
| 1 | CCVC §2 Attitude — strong-like gate `+74/+75/+76` | REQUIRED | SPEC §§3.4, 4.1; IMP §3.5 includes direct marriage/favour; LLSF VS-SFL-093/095 | `S1-BND-ATT-STRONGLIKE`, `S1-093-RECIP-74/75/76`, `S1-095-74` | EXACT |
| 2 | CCVC §2 Attitude — mixed-sign same-cycle direct causes near bounds / sum-then-clamp | REQUIRED | SPEC §3.1, §9.3; IMP applicable cross-cutting obligations; LLSF VS-SFL-097 | `S1-BND-ATT-MIXED`, `S1-097-DIRECT-BATCH-*`, `S1-074-DIRECT-BATCH` | EXACT |
| 3 | CCVC §2 Attitude — strong-dislike `-76/-75/-74` where behavior uses band | N-A | No named Slice-1 categorical action gate uses this band; LLSF has no such gate | `S1-BND-ATT-STRONGDISLIKE` | EXACT |
| 4 | CCVC §2 Attitude — dislike/neutral `-27/-26/-25` | N-A | No applicable Slice-1 categorical behavior depends on this boundary | `S1-BND-ATT-DISLIKE-NEUTRAL` | EXACT |
| 5 | CCVC §2 Attitude — neutral/like `+25/+26/+27` | N-A | No applicable Slice-1 categorical behavior depends on this boundary | `S1-BND-ATT-NEUTRAL-LIKE` | EXACT |
| 6 | CCVC §2 Attitude — saturation beyond `-100/+100` | REQUIRED | SPEC §3.1 / §10; LLSF VS-SFL-097 | `S1-BND-ATT-SAT`, `S1-097-SAT` | EXACT |
| 7 | CCVC §2 Attitude — kinship multiplication cannot alter stored attitude or satisfy stored-attitude gates | REQUIRED | SPEC §3.2; IMP §5; LLSF VS-SFL-093/095/099 | `S1-093-KIN-GATE`, `S1-099-KIN`, `S1-MUT-04` | EXACT |
| 8 | CCVC §2 Grain/provision/need — grain action amount negative / 0 / 1 / representative non-integral | REQUIRED for Slice-1 grain-denominated action shapes | SPEC §2.2, §5.1; IMP §3.5; household-only action shapes remain outside scope | `S1-BND-GRAIN-ACTION`, D4 bundle | EXACT |
| 9 | CCVC §2 Grain/provision/need — debt repayment `remaining-1 / remaining / remaining+1` | REQUIRED | SPEC §3.3; IMP §3.5; LLSF VS-SFL-092 | `S1-BND-REPAY-AMOUNT`, `S1-092-AMOUNT-VALIDITY` | EXACT |
| 10 | CCVC §2 Grain/provision/need — protected 2-grain reserve as applied to Slice-1 `RepayDebt` | REQUIRED | SPEC §3.3; LLSF VS-SFL-092 | `S1-BND-RESERVE`, `S1-092-RESERVE` | PRESENT_BUT_TOO_BROAD |
| 11 | CCVC §2 Grain/provision/need — protected reserve as applied to household provision capacity/spend | DEFERRED | SPEC §8.1; IMP §4 explicitly defers provision; PROV VS-SFL-045 | `S1-BND-HOUSEHOLD-PROVISION` | EXACT at deferred family scope |
| 12 | CCVC §2 Grain/provision/need — NeedsGrain clearing `grain 0 / 1` | REQUIRED | SPEC §2.2; IMP §§3.3, 3.5; LLSF VS-SFL-090 | `S1-BND-NEED`, `S1-090-D` | EXACT |
| 13 | CCVC §2 Grain/provision/need — provision contributor `NeedsGrain=false/true` at same grain | DEFERRED | SPEC §8.1; IMP §4; PROV VS-SFL-040/045 | `S1-BND-HOUSEHOLD-PROVISION` | EXACT at deferred family scope |
| 14 | CCVC §2 Grain/provision/need — exact collective capacity insufficient / equal / greater than spend | DEFERRED | SPEC §8.1; IMP §4; PROV VS-SFL-046 | `S1-BND-HOUSEHOLD-PROVISION` | EXACT at deferred family scope |
| 15 | CCVC §2 Formation/participation/lifecycle — founding core cardinality `1/2/3` | DEFERRED | SPEC §7.2; IMP §4 defers household formation | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 16 | CCVC §2 Formation/participation/lifecycle — qualifying support: 1 event | DEFERRED | SPEC §7.2; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 17 | CCVC §2 Formation/participation/lifecycle — qualifying support: 2 events same cycle | DEFERRED | SPEC §7.2 requires distinct cycles; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 18 | CCVC §2 Formation/participation/lifecycle — qualifying support: 2 events on distinct cycles | DEFERRED | SPEC §7.2; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 19 | CCVC §2 Formation/participation/lifecycle — CandidateRecognition missing from 0 / 1 / all required founders | DEFERRED | SPEC §§6.3, 7.2; IMP §4 defers formation/recognition | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 20 | CCVC §2 Formation/participation/lifecycle — lifecycle participant count `0/1/2` | DEFERRED | SPEC §7.6; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 21 | CCVC §2 Formation/participation/lifecycle — participation entry into Active H | DEFERRED | SPEC §7.4; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 22 | CCVC §2 Formation/participation/lifecycle — participation entry into Inactive H with sole bearer | DEFERRED | SPEC §§7.4, 7.6; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 23 | CCVC §2 Formation/participation/lifecycle — participation entry into Dissolved H | DEFERRED | SPEC §7.6; IMP §4 | `S1-BND-FORMATION` | EXACT at deferred group scope |
| 24 | CCVC §2 Cooldowns/periodic timing — provision reconsideration before 3 full cycles | DEFERRED | SPEC §8.2; IMP §4; PROV VS-SFL-044 | none | MISSING |
| 25 | CCVC §2 Cooldowns/periodic timing — exactly 3 full cycles with no relevant context change | DEFERRED | SPEC §8.2; IMP §4; PROV VS-SFL-044 | none | MISSING |
| 26 | CCVC §2 Cooldowns/periodic timing — exactly 3 full cycles plus relevant context change | DEFERRED | SPEC §8.2; IMP §4; PROV VS-SFL-044 | none | MISSING |
| 27 | CCVC §2 Cooldowns/periodic timing — attitude decay immediately before / at / after 5-cycle cadence | REQUIRED | SPEC §3.1; IMP §3.3; LLSF VS-SFL-097 | `S1-BND-DECAY`, `S1-097-DECAY` | EXACT |
| 28 | CCVC §2 Cooldowns/periodic timing — debt social-due before N+3 / after N+3 decisions / later cycles, one penalty only | REQUIRED | SPEC §3.3 and §9; IMP §3.3; LLSF VS-SFL-092 | `S1-BND-DEBT-DUE`, `S1-092-DUE` | EXACT |
| 29 | CCVC §2 Cardinality — first vs second marriage establishment | REQUIRED | SPEC §4; IMP §3.5; LLSF VS-SFL-095 | `S1-BND-MARRIAGE-CARD`, `S1-095-LIFETIME` | EXACT |
| 30 | CCVC §2 Cardinality — first vs additional favour for same ordered pair | REQUIRED | SPEC §3.4; IMP §3.5; LLSF VS-SFL-093 | `S1-BND-FAVOUR-CARD`, `S1-093-BFF-FULL` | EXACT |
| 31 | CCVC §2 Cardinality — full favour-slot behavior: ExplicitBenefitForFavor vs RelationshipMediatedReciprocalHelp | REQUIRED | SPEC §§3.4–3.5; IMP §3.5; LLSF VS-SFL-093 | `S1-BND-FAVOUR-MEANING`, D5 bundle | EXACT |
| 32 | CCVC §2 Cardinality — one vs multiple independently accepted same-person Residence transitions in one cycle | REQUIRED | SPEC §§3.6, 9.2; IMP §§3.5–3.6; LLSF VS-SFL-096 | `S1-BND-RESIDENCE-CARD`, D2 bundle | EXACT |
| 33 | CCVC §2 Lineage — fresh division support before / after all cited exits | DEFERRED | SPEC §7.7.3–7.7.4; IMP §4; LIN VS-SFL-020/021 | `S1-BND-LINEAGE` | EXACT at deferred lineage scope |
| 34 | CCVC §2 Lineage — consolidation cross-predecessor support before / after both predecessor dissolutions | DEFERRED | SPEC §7.7.3 / §7.7.5; IMP §4; LIN VS-SFL-023/024 | `S1-BND-LINEAGE` | EXACT at deferred lineage scope |
| 35 | CCVC §2 Lineage — one predecessor survives vs both Dissolved | DEFERRED | SPEC §7.7.5; IMP §4; LIN VS-SFL-024A | `S1-BND-LINEAGE` | PRESENT_BUT_TOO_NARROW |
| 36 | CCVC §2 Lineage — unambiguous vs ambiguous predecessor-source mapping | DEFERRED | SPEC §§7.7.1–7.7.2; IMP §4; LIN VS-SFL-022C | `S1-BND-LINEAGE` | EXACT at deferred lineage scope |

## 4. Defects and minimal repairs

### MRR-A-01 — Missing provision-reconsideration cooldown boundary

- **Severity:** HIGH — acceptance-surface completeness blocker
- **Source:** CCVC §2 “Cooldowns / periodic timing”; SPEC §8.2; PROV VS-SFL-044.
- **Current manifest:** no Part-E row covers the three reconsideration states. `S1-BND-HOUSEHOLD-PROVISION` is explicitly described as “provision capacity/needs contributor boundaries,” so it does not cover reconsideration timing.
- **Correct Slice-1 status:** DEFERRED, because IMP §4 explicitly excludes household provision/head-role semantics.
- **Minimal repair:** add one explicit deferred boundary row, for example:
  - `S1-BND-PROVISION-RECONSIDERATION` — “before 3 full cycles / exactly 3 with no relevant context change / exactly 3 plus relevant context change” — **DEFERRED** — rationale: household provision/head reconsideration is outside IMP-0001.
- **Why one row is sufficient:** all three source states share the same semantic substrate and the same Slice-1 status, and the row would name the complete source matrix rather than an open-ended family label.

### MRR-A-02 — Lineage row omits predecessor lifecycle-state boundary

- **Severity:** MEDIUM — deferred-family completeness defect
- **Source:** CCVC §2 “Lineage” bullet “one predecessor survives versus both Dissolved”; SPEC §7.7.5; LIN VS-SFL-024A.
- **Current manifest:** `S1-BND-LINEAGE` says only “lineage freshness/ambiguity boundaries.”
- **Correct Slice-1 status:** DEFERRED.
- **Why current wording is too narrow:** predecessor survival/dissolution is a separate classifier input from fresh-evidence timing and source ambiguity. It is not named by the current source-clause text.
- **Minimal repair:** broaden the Boundary cell without changing status, e.g. “lineage freshness / predecessor lifecycle-state / predecessor-source ambiguity boundaries,” or add a dedicated deferred row for predecessor lifecycle state.

### MRR-A-03 — Reserve wording can invent a generic lower-level transfer reserve

- **Severity:** MEDIUM — wording-scope / semantic-subordination risk
- **Source:** SPEC §3.3 makes the personal 2-grain reserve explicit for `RepayDebt`; SPEC §8.1 makes it explicit for household provision. LLSF VS-SFL-092 is the Slice-1 reserve card; PROV VS-SFL-045 is deferred with household provision.
- **Current manifest:** `S1-BND-RESERVE` — REQUIRED — rationale “Debt/transfer reserve.”
- **Correct Slice-1 status:** REQUIRED for the Slice-1 `RepayDebt` reserve boundary. Household provision reserve remains DEFERRED.
- **Why current wording is too broad:** accepted SPEC does not impose a generic 2-grain reserve on every Gift/Help/Loan/other lower-level transfer meaning. “transfer reserve” can be read that way.
- **Minimal repair:** narrow the row to “RepayDebt protected-reserve feasibility (grain 1/2/3)” and, if desired, explicitly note that household-provision reserve coverage is deferred under `S1-BND-HOUSEHOLD-PROVISION`. Do not introduce a generic transfer reserve.

## 5. Anti-whack-a-mole / disconfirmation results

The review actively tried to show the broad deferred rows were sufficient.

- `S1-BND-FORMATION` is acceptable as a group-level row for this Slice because its text explicitly names formation, participation, and lifecycle, and every material sub-boundary in that CCVC subsection is household-only and therefore DEFERRED under the same IMP §4 scope reason.
- `S1-BND-HOUSEHOLD-PROVISION` is sufficient for the capacity / NeedsGrain contributor sub-boundaries, including the deferred household provision reserve/capacity surface. It is **not** sufficient for the separate provision-reconsideration timing matrix because the row text limits itself to capacity / contributor boundaries.
- `S1-BND-LINEAGE` correctly captures freshness and ambiguity, but its source-clause wording is not exhaustive because predecessor lifecycle state is a separate required boundary dimension.
- The N-A attitude-band rows are supported: the reviewed Slice-1 lower-level family exposes no named categorical action gate at strong-dislike, dislike/neutral, or neutral/like. The +75 strong-like gate, saturation, mixed direct causes, and decay are separately REQUIRED.
- No accepted source required choosing new social semantics. `SEMANTIC_ESCALATION_REQUIRED` is therefore not triggered.

## 6. “Beyond the currently obvious ones” statement

I did not read the prior manifest BLOCK report and therefore cannot know which defects it previously labeled “obvious.”

Independently, the boundary audit found defects in **three distinct forms**: a wholly missing cooldown matrix, a too-narrow lineage source-clause description, and a too-broad lower-level reserve description. Therefore the boundary defect surface is not exhausted by a single missing row or one household-provision issue.

## 7. Final verdict

`BOUNDARY_REPAIR_REQUIRED`

The candidate manifest should not be frozen for IMP-0001 until MRR-A-01 through MRR-A-03 are repaired and the corrected boundary surface is rechecked against the same accepted source hierarchy.
