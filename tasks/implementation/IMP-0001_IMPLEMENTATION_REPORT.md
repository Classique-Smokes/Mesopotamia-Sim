# IMP-0001 implementation report

Status: **INCOMPLETE — milestone 1 verified; remaining milestones pending**.

Branch: `implementation/imp-0001-slice1`. PR #7 remains draft; no merge authorized.

## Authority

- Manifest version: `SFL-V0-S1-ACCEPTANCE-v1`
- Freeze commit: `55377cc34b8bc3ccbf9cdf5029e9791dae965987`
- Manifest blob: `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`
- Frozen ref: `origin/sfl-v0-slice1-acceptance-v1`
- Census: 128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED.

The frozen manifest is unchanged. Bootstrap tests map to zero AcceptanceIds.

## Environment and verification

SDK 10.0.401 is installed outside the repository in the Codex task workspace. SDK discovery is process-local; no toolchain payload is committed.

Initial Windows verification exposed CRLF C# checkout endings incompatible with the existing LF formatter policy. C#-only `.gitattributes` and normalization repair this without changing Markdown authority. The repaired scaffold passed all four canonical commands (2 tests, no warnings/errors):

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

## Evidence

Canonical tests emit `artifacts/acceptance/slice1-results.json` and `.md`, listing every manifest row individually. Unimplemented rows remain NOT EXECUTED. Independent conformance is REQUIRED and awaiting external review; no self-awarded PASS.

Milestone 1 introduces typed identities, immutable state/snapshots, validation, and the frozen-manifest evidence catalog. Domain transitions, semantic acceptance, metamorphic/fault controls, complete fixture/oracle audits, and independent conformance remain outstanding.

## Assumptions, deviations, and escalation

Accepted laboratory assumptions remain unchanged. No semantic or architectural deviations. The LF checkout repair is a local tooling correction. No current escalation. No later-slice semantics implemented; SCF-002 remains active.

Milestone 1 canonical sequence: PASS; 5 tests passed, 0 skipped, 0 warnings/errors. CI publishes the generated acceptance evidence. Manifest-integrity row is the only current acceptance PASS.

Milestone 2 canonical sequence: PASS; 8 tests, no skips/warnings/errors. Consumption, Farm, exogenous need clearing, immutable prior snapshots, and decay are implemented. Seven manifest rows now have evidence; later semantic rows remain unexecuted. Milestone 1 push succeeded after Git Credential Manager completed authentication.

Milestone 3 canonical sequence: PASS; 8 MSTest tests, six substantive acceptance scenarios, 28 manifest rows PASS. Proposal validation, snapshot responses, central revalidation, atomic copy-and-publish commits, bounded outcome knowledge, and direct attitude composition are implemented. Gift/help supplied the smallest real interaction needed to verify this pipeline (dependency adjustment from milestone 4). Milestones 1 and 2 remote CI passed: runs 35689425927 and 35689473407.

Milestone 4 canonical sequence: PASS; 8 MSTest tests executing ten acceptance scenarios, 41 manifest rows PASS. Loan offer/request, partial/full repayment with historical provenance, reserve/term validation, and N+3 post-decision one-shot review implemented. Milestone 3 CI PASS: 35689766352.

Milestone 5 canonical sequence: PASS; 8 MSTest tests executing eighteen acceptance scenarios, 69 manifest rows PASS. Atomic bargains, reciprocal help, favour capacity/cancellation, and response-scoped Farm/RepayDebt fulfilment implemented. The reciprocal-help term records request versus offer direction explicitly, preserving donor/recipient roles and knowingly accepted meaning; its request form supplies the capacity-race fixture with one initiative per actor. Full non-callable matrices follow once marriage/residence shapes exist. Milestone 4 CI PASS: 35689966056.

Milestone 6 canonical sequence: PASS; 8 MSTest tests executing 24 acceptance scenarios, 92 manifest rows PASS. Direct marriage, independent residence proposals/conflicts, all eleven non-callable semantic shapes, non-payload type exclusion, and nested repayment ingress boundaries implemented/tested. Milestone 5 CI PASS: 35690260519.

Milestone 7 canonical sequence: PASS; 8 MSTest tests executing 28 acceptance scenarios, 98 manifest rows PASS. Production personal candidate generation, shared checked scorer, canonical personal/response profiles, complete retained decision traces, and autonomous cycle entry are implemented. Reference default preferences are explicitly versioned laboratory configuration. Milestone 6 CI PASS: 35690505528.
