# IMP-0003 Repair-v4 Implementation Return

**Terminal status:** IMPLEMENTED / LOCAL VERIFICATION PASS; exact-head CI and delivery identity are recorded in the final delivery and PR description. Pending fresh independent whole-candidate conformance; not promoted.

**Branch:** `implementation/imp-0003-slice3-repair-v4`  
**Immutable failed base:** `imp-0003-slice3-conformance-candidate-v3` @ `35c4fb83bdac15e09c9e89e5dad67a5b6fae7048`  
**Packet:** `tasks/implementation/IMP-0003_CANDIDATE_V3_BLOCK_REPAIR_PACKET.md`

The exact return head/proposed candidate-v4 SHA is the commit containing this report, resolved in the final delivery after committing. Exact-head CI/artifact identity is recorded there and in the PR body without a subsequent metadata-only commit that would invalidate that identity. Candidate-v1/v2/v3 refs are unchanged; candidate-v4 is not frozen by this implementation return.

## Reproduced failures

Before production/oracle edits, the new tests reproduced all three defects against candidate-v3: connected compatible loans carried fallback, a nonexistent lifecycle event passed the checker, and a fabricated Recognition EvidenceId passed the checker. All other test entry points passed in that baseline run. No manifest or acceptance requirement was weakened.

## A — causal normalization

`HouseholdProjectionKey` now uses the live pre-resolution boundary. Existing relation, event and retained/historical warrant evidence identities remain exact. Newly allocated debts, favours and marriages are keyed by their causal event (kind, proposal identity, ordered participants, causal ancestry and cycle); newly allocated attitude relations use their directed person pair. The same serialization mapping reaches relation origins, factual payloads, participation outcomes, support events, provenance and communication hops. Causal event keys are hashed to bound recursive signature size.

The complete projected material/relationship state and Household records are compared. Household, warrant, association and commitment identities are preserved. Retained factual multisets, candidate/Household Recognition bases, subject-relevant evidence precedence, action outcomes and invalidation reasons remain significant. Household details retain the lifecycle and warrant chain. Own-state refreshes retain all contributing projected material causes and the final personal state; the incidental last of two additive transfers does not become a false sole-origin conflict.

No unconditional fallback suppression was added. The disconnected inherited ordinary resolver remains unchanged.

- Connected compatible loans: **8/8** proposal-ID/input/world-enumeration permutations; both committed, no fallback, independently normalized semantic endpoint equal.
- Other connected allocations: **4/4** favour/marriage controls; both committed, no fallback.
- Connected genuine conflicts: **6/6** capacity, communication invalidated by repayment, favour/debt runs across both proposal orders; fallback retained.
- Prior disconnected controls: **8/8** compatible-loan permutations and **6/6** positive fallback runs retained.
- Existing residence/admission, Household transition and same-cycle causal handoff controls remain green.

## B — lifecycle provenance

The oracle starts from the verified formation stamp, independently replays associations grouped by stable cycle, and derives each Active/Inactive/Dissolved publication. It requires the exact latest justified history event, matching Household/state, actual Cycle/ReactionIndex, causal participation/continuity set, publication participants and rules/configuration. It rejects transient lifecycle publication, stale references and resurrection after stable dissolution. Existing commitment-termination checks remain intact.

**21/21** detached lifecycle corruptions are rejected through checker assertions, including nonexistent events, negative/false times, wrong event kind, stale formation references, another Household's event and published-state mismatch. Valid initial Active, Inactive, reactivated Active and Dissolved controls all pass.

## C — exact Recognition identity

`SameEvidence` now includes `KnownFact.Id` in addition to proposition and complete provenance. Retained bases bind directly to the preceding stable actor-held facts. Same-cycle bases bind to exact acquisition receipts, after independent reconstruction of their proposition, causal origin or delivered communication hop. No other warrant supplies an expected ID.

Observer-only `AcquiredEvidence` receipts are attached to the existing Household acquisition and communication events; they record the resulting retained actor/fact identity. They allocate no IDs, change no transition, and are not decision inputs. The independent checker replays Household evidence retention from causal acquisitions and transmitted payloads, rejects duplicate identities and unjustified receipts, and compares exact IDs/content/provenance with every stable actor snapshot. Superseded payload members are handled at the completed delivery boundary. Explicit nondominated-report fixtures remain separately marked laboratory inputs.

**3/3** fabricated-ID corruptions are rejected: retained entry basis, same-cycle continuation/handoff basis, and same-cycle communicated entry basis. Both same-cycle valid controls pass. Valid stale Recognition remains admissible.

## Preserved repairs and census

All **63/63** previous formation/continuation/lineage detached corruptions and their four valid controls remain green, as do candidate-v2 entry controls, custom-label rule provenance, continuation locality, dissolution locality, same-cycle bridge handoff and inherited fallback controls.

| Population | Verified result |
|---|---:|
| Slice-3 REQUIRED | 96/96 PASS |
| Slice-3 DEFERRED / UNEXERCISED | 11 / 2 unchanged |
| Inherited Slice-1 REQUIRED | 128/128 PASS |
| Inherited Slice-2 REQUIRED | 46/46 PASS |
| Slice-3 scenario groups / audited worlds | 41 / 123 |
| Oracle dependency audit | PASS |
| Repair-v4 named outcomes | 48 PASS/rejected-as-required |

Inherited S1 global conformance refers to its accepted historical independent review. This return does not self-award Slice-3 conformance.

## Canonical verification

SDK **10.0.401** is available outside the repository and selected through PATH; the pinned toolchain is unchanged. Final committed-head verification runs the canonical commands in order:

1. `dotnet restore Mesopotamia.Sim.slnx`
2. `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore`
3. `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore`
4. `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore`

Local implementation validation passed all 10 test entry points, with zero failures/skips. Exact committed-head command results, CI run, artifact ID and SHA-256 digest are returned in the final delivery and PR body. CI emits the complete frozen-row reports and both repair-v3/v4 named evidence files.

Frozen manifest blobs are unchanged:

- Slice 1: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- Slice 2: `e4872531cf780d51fa1863f2a0b87e2424a71b69`
- Slice 3: `1aae13dc27572361fe99c31ef8aee0444d39364a`

**S1-084 conditional adaptation gate: UNFIRED.** `WorldState` field inventory and `NoDerivedAuthorityStructuralAudit` are unchanged. SPEC, accepted ADRs, frozen manifests and deferred boundaries are unchanged.

## File-by-file changes

| File | Repair |
|---|---|
| `src/Mesopotamia.Sim/HouseholdProjection.cs` | Boundary-preserving causal normalization and complete detached endpoint key. |
| `src/Mesopotamia.Sim/HouseholdResolution.cs` | Replace the allocation-sensitive key with the new partial implementation; retain resolver routing/search. |
| `src/Mesopotamia.Sim/Execution.cs` | Typed observer acquisition receipt on SemanticEvent. |
| `src/Mesopotamia.Sim/EpistemicExecution.cs` | Bind retained communication facts to their delivery event. |
| `src/Mesopotamia.Sim/HouseholdExecution.cs` | Bind direct Household acquisitions to their existing acquisition event. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs` | Exact evidence equality, same-cycle receipt reconstruction and lifecycle/receipt audit wiring. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdWarrantOracle.cs` | Independent lifecycle history and exact acquisition/retention verification. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdRepairV4Scenarios.cs` | Permutation, positive fallback, lifecycle and Recognition identity regressions. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs` | Register repair-v4 cases. |
| `tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs` | Emit named repair-v4 evidence in canonical artifact. |
| `tests/Mesopotamia.Sim.AcceptanceTests/README.md` | Explain normalization and exact observer evidence checks. |
| `tasks/implementation/IMP-0003_REPAIR_V4_REPORT.md` | This bounded implementation return. |

**Unexpected issue/escalation:** no semantic or authority escalation required. The ordinary last-refresh provenance and within-delivery evidence supersession needed explicit treatment to preserve compatible transactions and valid stale/mixed evidence. No additional agent delegation occurred. Master Architect candidate freeze and fresh whole-candidate **PASS — PROMOTE** remain required before promotion.
