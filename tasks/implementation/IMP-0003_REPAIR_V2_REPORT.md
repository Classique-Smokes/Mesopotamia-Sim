# IMP-0003 — Candidate-v1 bounded repair return

**Terminal status:** COMPLETE CANDIDATE — subject to the exact-head CI evidence identified in the delivery record; fresh independent conformance is still required before promotion.

**Repair branch:** `implementation/imp-0003-slice3-repair-v2`

**Immutable failed parent:** `imp-0003-slice3-conformance-candidate-v1` at `6b9d40e33b94d9094c02fe3d9f026914dd7986ec`.

**Proposed successor ref:** `imp-0003-slice3-conformance-candidate-v2`, targeting the exact tested repair head reported by the PR, delivery record and CI `slice3-results.json`. The Master Architect owns freezing and dispatch; this return does not create the candidate ref or self-promote.

The tracked report cannot embed its own commit hash or a future CI artifact identity. The final delivery record supplies the full repair SHA, PR URL, exact-head CI run, artifact ID and digest. CI checks out the PR head itself and its evidence records `ImplementationHead` and `WorkingTreeDirty`. No report-only commit is added after that verification.

## Authority and scope

Implemented the three bounded repairs from `tasks/implementation/IMP-0003_CANDIDATE_V1_BLOCK_REPAIR_PACKET.md` and its Master Architect reconciliation on canonical main. Accepted SPEC §§6.4–6.6, 7.4–7.5 and 9.4 govern the repaired behavior. Accepted ADRs and frozen `SFL-V0-S3-ACCEPTANCE-v1` remain unchanged.

The failed candidate remains immutable. No frozen manifest or classification changed. No new social semantics, generic observation, head/office, provision spending, checkpointing, lineage generalization or scheduler architecture was added.

**S1-084 conditional adaptation gate: UNFIRED.** `WorldState` and the existing `NoDerivedAuthorityStructuralAudit` remain byte-for-byte unchanged from candidate-v1. The applicable scaffolding register was reviewed; this task does not fire its deferred workflow/tooling triggers.

## Repair evidence

| Finding | Repair | Executable evidence |
|---|---|---|
| B1 — participation oracle accepts absent/fabricated/unrelated evidence | Bind the warrant to its actual Request/Invite, correct actor/newcomer/bridge, named counterpart's causally linked acceptance, commit and rules/configuration stamp. Reconstruct live prior associations and residence/tie facts at the precommit microstep. Validate every cited support event's actual meaning, endpoints and strict temporal window. Match both actors' held Recognition bases and verify household origin plus communication-hop provenance. Bind resulting association and continuation to the entry. | `RepairB1DetachedParticipationCorruptionsP17P18P19`: both entry directions, valid witness before/after corruption checks, 36 detached corruptions rejected by the independent checker. |
| B2 — scenario label controls claimed semantic rules | Rule identity follows the typed action/held household proposition. Proposal, response, outcome and decision retain that identity; household stamps remain S3. Decisions separately expose scenario `ConfigurationVersion`. Ordinary inherited actions remain S2, including in mixed cycles. | `RepairB2CustomLabelHouseholdProvenance`: Request and Invite under `review-custom-config`, `SFL-S2-v1` and `SFL-S3-v1`; six produced worlds, each with mixed S2/S3 actions and household Recognition/factual communication. |
| C1 — continuation broadcasts to all current bearers | Continuation's event participants and direct evidence recipients are the causal entry/exit parties. Retained bridge evidence remains explicit in the warrant but does not grant automatic observation of the new transition. | `RepairC1RemoteBearerRetainsStaleRecognition`: remote B remains current and Recognized with exactly its prior evidence after either entry direction; bridge/newcomer receive direct evidence; later accepted communication adds the newer basis to B. |

P17 removes the entire Recognition array. Additional controls duplicate the newcomer basis and fabricate its event provenance. P18 covers combined nonexistent/future/wrong-endpoint support, isolated nonexistent identity, fabricated time, false endpoints, real unrelated support and real support committed after admission. P19 substitutes an earlier unrelated `Response: Accept`. Further controls corrupt proposal, bridge, newcomer, prior associations, residence, tie relation IDs and the produced association's person. These inputs reach `HouseholdOracle.Verify` as detached public snapshots; production validation is not used to reject them.

The oracle calls no production household/epistemic classifiers, participation feasibility or continuity helpers. It uses explicit accepted predicates, stable snapshots and recorded microstep effects. The existing dependency audit remains PASS.

The prior household staleness scenario relied on an uninvolved retained bearer receiving exit-continuation evidence. It now supplies accepted communication from the actual exit party before relaying that evidence onward. The mixed residence/admission regression now asserts S3 for the household response and S2 for the ordinary residence response. Neither adjustment relaxes a frozen obligation; both remove dependence on the repaired defects.

## File-by-file return

| File | Change |
|---|---|
| `src/Mesopotamia.Sim/Simulation.cs` | Replace configuration-label comparison with action/held-proposition semantic rule attribution. |
| `src/Mesopotamia.Sim/Execution.cs` | Stamp proposal provenance once; carry it to its history/decision records; preserve scenario label separately. Metadata lookup does not supply actor knowledge or select simulation behavior. |
| `src/Mesopotamia.Sim/Decisions.cs` | Add `DecisionTrace.ConfigurationVersion`. |
| `src/Mesopotamia.Sim/HouseholdExecution.cs` | Restrict continuation event participants and evidence acquisition to the causal transition parties. |
| `src/Mesopotamia.Sim/README.md` | Document arbitrary scenario labels, mixed rule provenance and continuation evidence routes. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs` | Independent participation identity, precommit-state, support, Recognition provenance and output validation. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdRepairV2Scenarios.cs` | Detached corruption, custom-label and remote-bearer regressions. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs` | Register the three repair scenario groups in the frozen-row runner. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdAdversarialScenarios.cs` | Assert the separate S2/S3 rule paths in the existing mixed residence/admission scenario. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdEpistemicScenarios.cs` | Supply the explicit communication needed to relay exit-continuation evidence. |
| `tests/Mesopotamia.Sim.AcceptanceTests/README.md` | Document the added checker and regression evidence. |
| `tasks/implementation/IMP-0003_REPAIR_V2_REPORT.md` | This bounded repair return. |

## Verification

SDK: **10.0.401**, using the already installed review SDK outside the repository. No toolchain or CI changes.

| Exact root command | Final local result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | PASS, exit 0. |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | PASS, exit 0. |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | PASS, exit 0; zero warnings/errors. |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | PASS, exit 0; 10 passed, zero failed/skipped. |

The final runner executes **28 Slice-3 scenario groups** and independently audits **82 produced worlds**. `slice3-results.json`, `slice3-cases.json`, `slice3-fixtures.json` and `slice3-producers.json` retain the detailed bindings and inputs; canonical CI uploads them with inherited evidence as `sfl-slice1-slice2-slice3-acceptance-evidence`.

| Acceptance population | Result |
|---|---|
| Slice-3 REQUIRED | 96 / 96 PASS |
| Slice-3 DEFERRED | 11 unchanged |
| Slice-3 UNEXERCISED | 2 unchanged |
| Inherited Slice-1 REQUIRED bindings | 128 / 128 PASS |
| Inherited Slice-2 REQUIRED bindings | 46 / 46 PASS |

As before, `S1-GLOBAL-CONFORMANCE` retains the accepted historical Slice-1 independent review/completion record. It does not certify this repair independently. All other executable inherited evidence is rerun by the acceptance pipeline.

All three manifest blob identities remain frozen: Slice 1 `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`; Slice 2 `e4872531cf780d51fa1863f2a0b87e2424a71b69`; Slice 3 `1aae13dc27572361fe99c31ef8aee0444d39364a`. `git diff --check` passes.

## Unexpected issues and remaining handoff

No semantic escalation or structural adaptation was required. During local iteration, nullable analysis required an explicit provenance-order assertion. The remote-bearer regression initially assumed new communication replaces old direct evidence; it was corrected to verify the inherited rule: new communicated evidence is added while older direct evidence may remain. The production evidence-precedence rules were not changed.

After exact-head CI PASS, the Master Architect may freeze the proposed candidate-v2 SHA and commission fresh independent conformance. Promotion still requires **PASS — PROMOTE**. Candidate-v1 remains failed immutable evidence.
