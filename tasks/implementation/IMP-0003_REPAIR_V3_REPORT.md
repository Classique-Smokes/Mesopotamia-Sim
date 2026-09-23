# IMP-0003 — Candidate-v2 bounded repair return

**Terminal status:** COMPLETE CANDIDATE, conditional on the exact-head CI evidence in the final delivery record. Fresh independent whole-candidate conformance remains required before promotion.

**Repair branch:** `implementation/imp-0003-slice3-repair-v3`.

**Immutable failed parent:** `imp-0003-slice3-conformance-candidate-v2` at `69ae753da2e05450766a9042ac6958fa7aa0b3e7`.

**Proposed candidate-v3 SHA:** the exact tested repair head identified in the PR delivery record and CI `slice3-results.json`. The Master Architect owns creation of `imp-0003-slice3-conformance-candidate-v3`; this task does not freeze or promote it.

As in the v2 return, the tracked report cannot contain its own future commit SHA or CI artifact identity. The final delivery record and PR description supply the full head SHA, exact-head CI URL/run, artifact ID and SHA-256 digest. CI checks out that head directly, and its evidence records `ImplementationHead` and `WorkingTreeDirty`. No report-only commit follows that verification.

## Scope and authority

Implements only Repair A and Repair B from `tasks/implementation/IMP-0003_CANDIDATE_V2_BLOCK_REPAIR_PACKET.md` on canonical main and its BLOCK reconciliation. Accepted SPEC §§6.3–6.6, 7.2–7.7 and the frozen Slice-3 acceptance contract govern the checks. No accepted semantics, frozen classifications, toolchain, or CI workflow changed.

Candidate-v1 and candidate-v2 refs remain unchanged. Candidate convergence, head/office, provision acquisition/spending, mediated marriage authority, checkpoint/restore, and repeated predecessor-source generalization remain deferred.

**S1-084 adaptation trigger: UNFIRED.** `src/Mesopotamia.Sim/State.cs` and the existing `NoDerivedAuthorityStructuralAudit` in `CrossCuttingScenarios.cs` are byte-for-byte unchanged from candidate-v2. The scaffolding trigger register was consulted; none of its deferred triggers fired.

## Warrant checker repairs

- **Formation:** bind the stamp to actual event kind, time, Household, warrant, candidate, founders and rule/configuration versions. Validate the bounded candidate against initial or recorded laboratory declarations. Replay residence and durable-tie facts at formation; validate every recorded relation reference/pair and require connectivity using only recorded ties. Validate actual support meaning, endpoints, cycle/order and formation causes. Check one founder-specific CandidateRecognition basis against actual retained facts, independently test its predicate, and validate fixture/direct/communication provenance. Compute the exact earliest retained evidence time. Bind every founding association and its event to the correct founder, Household and origin warrant.
- **Continuation:** independently reconstruct prior/successor association sets and historical predecessor chain around actual entry/exit transitions. Validate every continuation stamp, previous/transition references, causal event set, bridge identity and nonempty Recognized evidence. Reuse the independently reconstructed held-evidence/provenance check from the v2 entry repair; no production recognizer or classifier supplies expected values. Exit stamps also bind actual actors, associations and proposals, including terminal exits.
- **Lineage:** bind actual lineage stamps to successor formation, kind, sources, causes and versions. Retain independent predecessor lifecycle/count, source identity, division post-exit freshness, consolidation post-dissolution freshness and cross-source checks. Every fresh item must now be an actual qualifying ordinary support event used by the formation, strictly before successor formation. Formation itself cannot serve as fresh support.
- Match formation/continuation/lineage record counts to committed stamp events. The oracle dependency audit now covers both partial oracle files.

## Detached corruption results

All bad records are constructed successfully as detached public snapshots before entering the checker. Only `AssertFailedException` from `HouseholdOracle.Verify` counts as rejection; production guards, runtime exceptions and timeouts do not.

| Family | Detached corruptions rejected | Valid control |
|---|---:|---|
| Formation | 23 / 23 | PASS |
| Exit continuation | 14 / 14 | PASS |
| Division lineage | 13 / 13 | PASS |
| Consolidation lineage | 13 / 13 | PASS |
| Total | **63 / 63** | **4 / 4 PASS** |

These include every required reviewer corruption: empty ties, duplicate founder Recognition, nonexistent candidate, false earliest time, nonexistent stamps, real support IDs with altered endpoints/kind, empty continuation Recognition, Recognized bridges with empty evidence, invented rules, and successor formation substituted as fresh lineage support. Additional controls isolate relation, dwelling, founder, evidence-origin, association, predecessor, source and configuration corruption.

Detailed names/results are emitted in `artifacts/acceptance/slice3-repair-v3-controls.json` and uploaded with the canonical acceptance evidence.

## False-fallback repair

Use the packet's allowed bounded approach: structurally independent ordinary components retain the inherited resolver. Component closure still includes material, residence, marriage, favour/debt, epistemic and actor overlap. Any contact with a candidate core, a current or historical Household association, an explicit Household target, or a communicated Household proposition keeps the component on the Household-aware resolver. Historical associations are conservatively retained for lineage relevance.

The inherited resolver already binds newly created ordinary relations to synthetic proposal origins. No final-balance shortcut or unconditional fallback suppression was added, and no `WorldState` field changed.

- **Disconnected compatible loans:** 8 / 8 runs PASS across exchanged proposal IDs, reversed proposal input order and reversed initial-world ordering. Both loans commit, every event has `TechnicalFallback=false`, and normalized material/relationship/Household state, retained factual evidence and Recognition statuses are equal.
- **Positive fallback controls:** 6 / 6 runs PASS across both proposal orders for individually feasible but jointly unaffordable loans, captured communication invalidated by repayment, and a called debt-repayment favour competing with reciprocal cancellation.
- Existing residence/admission, same-cycle bridge priority, household transition, and inherited capacity/favour/debt/communication fallback controls remain green. Candidate-v2 entry corruption, custom S2/S3 rule provenance, remote-bearer staleness and dissolution-locality tests remain green.

One new capacity fixture initially requested the giver's entire grain balance, so voluntary response declined before resolution. The fixture was corrected to individually acceptable amounts whose sum exceeds available capacity. No production rule or assertion was weakened.

## Verification census

Canonical local commands use SDK **10.0.401**, installed outside the repository:

| Root command | Result |
|---|---|
| `dotnet restore Mesopotamia.Sim.slnx` | PASS |
| `dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore` | PASS |
| `dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore` | PASS; zero warnings/errors |
| `dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore` | PASS; 10 tests, zero failures/skips |

| Population | Result |
|---|---|
| Slice-3 REQUIRED | 96 / 96 PASS |
| Slice-3 DEFERRED / UNEXERCISED | 11 / 2 unchanged |
| Inherited Slice-1 REQUIRED | 128 / 128 PASS |
| Inherited Slice-2 REQUIRED | 46 / 46 PASS |
| Slice-3 scenario groups / independently audited worlds | 33 / 100 |
| Oracle dependency audit | PASS |

The inherited S1 global-conformance row remains grounded in its accepted historical independent review; this report does not claim independent conformance for Slice 3.

Frozen manifest blob identities remain:

- Slice 1: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`.
- Slice 2: `e4872531cf780d51fa1863f2a0b87e2424a71b69`.
- Slice 3: `1aae13dc27572361fe99c31ef8aee0444d39364a`.

Exact-head CI and artifact identity are recorded in the final delivery and PR description, without a subsequent commit that would invalidate that identity.

## Files changed

| File | Purpose |
|---|---|
| `src/Mesopotamia.Sim/ResolutionDependencies.cs` | Extract the inherited ordinary resolver for reuse without recursive Household dispatch. |
| `src/Mesopotamia.Sim/HouseholdResolution.cs` | Route structurally independent components to that resolver; conservatively include historical Household associations in dependency scope. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdOracle.cs` | Wire complete warrant checks, historical exit bindings, record census and reusable held-Household evidence reconstruction. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdWarrantOracle.cs` | Independent formation, continuation, lineage, support, stamp and candidate-evidence checks. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdRepairV3Scenarios.cs` | Detached corruption controls, compatible-loan permutations, positive fallback controls and named evidence. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdScenarios.cs` | Register repair cases and pass declared bounded candidates to the checker. |
| `tests/Mesopotamia.Sim.AcceptanceTests/HouseholdLineageScenarios.cs` | Supply recorded candidate declarations to producer verification. |
| `tests/Mesopotamia.Sim.AcceptanceTests/Slice3AcceptanceTests.cs` | Audit both oracle files and emit repair-control evidence. |
| `tests/Mesopotamia.Sim.AcceptanceTests/README.md` | Document the added checker and regression evidence. |
| `tasks/implementation/IMP-0003_REPAIR_V3_REPORT.md` | This bounded return. |

**Unexpected issue/escalation:** none requiring authority or semantic change. No S1-084 adaptation or additional delegated review was triggered. Ready for Master Architect candidate freeze and fresh independent whole-candidate review after exact-head CI PASS; **do not self-promote**.
