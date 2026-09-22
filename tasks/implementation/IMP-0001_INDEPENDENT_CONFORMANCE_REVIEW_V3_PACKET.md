# IMP-0001 — Candidate-v3 Fresh Independent Conformance Review Packet

**Review class:** K4 fresh independent post-implementation conformance  
**Decision:** PASS or BLOCK  
**Reviewed candidate:** `imp-0001-slice1-conformance-candidate-v3` @ exactly `06e25644879dd8505e24fcaeb43256f69c29c15f`  
**Frozen acceptance authority:** `SFL-V0-S1-ACCEPTANCE-v1`

## Independence

The reviewer must be fresh with respect to both repair-v2 and repair-v3 implementation/harness authorship.

Do **not** use an agent that authored either repair line as reviewer. The reviewer must not modify the candidate.

Treat coder reports, green CI, Master Architect reconciliation and prior K4 findings as claims/evidence to test, not conclusions to adopt.

Do not reduce this review to checking B1/B2. Re-derive full K4 conformance against the frozen acceptance authority.

## Required identity checks

At execution start and finish:

- candidate-v3 ref = `06e25644879dd8505e24fcaeb43256f69c29c15f`;
- candidate-v2 ref = `ba16829e240950f1f3c648107cf3b8b36f996971`;
- candidate-v1 ref = `7e11dab7697121eb0dbb169ba46210d81b80586e`;
- PR #23 head = candidate-v3 SHA and remains draft/unmerged;
- PR #7 and PR #16 remain draft/unmerged historical lineages;
- frozen manifest blob = `efd2d0aab4579a78a3e7a0fc8d027c15f2f5e766`;
- freeze ref `sfl-v0-slice1-acceptance-v1` = `55377cc34b8bc3ccbf9cdf5029e9791dae965987`;
- census remains 167 unique IDs: 128 REQUIRED / 33 DEFERRED / 3 N-A / 3 UNEXERCISED.

Any candidate/authority drift => **BLOCK — REVIEW BASELINE INVALIDATED**.

## Retrieval order

Retrieve the minimum authoritative context in this order:

1. `AGENTS.md`, `00_START_HERE.md`;
2. `governance/SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`;
3. this packet and `IMP-0001_CANDIDATE_V3_RECONCILIATION_AND_DISPATCH.md`;
4. original IMP-0001 task + repair-v3 packet;
5. accepted SPEC + ADRs;
6. frozen manifest and cited verification sources;
7. candidate-v3 production/tests/evidence;
8. only after independent inspection, candidate-v2 review/reconciliation as historical counterexample evidence.

The previous review's finding labels may guide adversarial follow-up after independent baseline inspection, but may not substitute for full re-derivation.

## Canonical execution

Run from an exact detached candidate-v3 checkout using SDK 10.0.401:

```text
dotnet restore Mesopotamia.Sim.slnx
dotnet format Mesopotamia.Sim.slnx --verify-no-changes --no-restore
dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore
dotnet test Mesopotamia.Sim.slnx --configuration Release --no-build --no-restore
```

Preserve outputs/exit codes/toolchain identity.

Compare with head-associated canonical PR run `35787127702` and acceptance artifact `10719823413` (digest `sha256:031f21dc553dcf0bfff4b73f3bff764ff5a8dc1856d20493b164cc164c1268ca`). The PR workflow checkout is synthetic merge `1f3f54cb750696d0bab26d2de2811e181700aead`; matching remote evidence proves reproducibility/integration only, not conformance.

## Full K4 obligations

Return separate conclusions for:

1. manifest integrity;
2. substantive evidence for every REQUIRED row;
3. source-to-assertion fidelity;
4. oracle independence;
5. fixture discipline;
6. honest deferred/later-slice boundaries;
7. absence of silently invented semantics.

Review architecture/scope, deterministic ordering, decision traces, subjective/objective boundaries, same-cycle resolution, semantic history, invariant enforcement and fault-control classifications.

## Adversarial priority A — B1 recovery projection

Independently derive the accepted `MaterialDeadlock` condition from SPEC §9.5 and cycle order.

Try to falsify candidate-v3 with public-boundary probes around:

- no future input;
- genuinely resolving future positive input;
- same-cycle cancelling credit/debit;
- partial surviving credit through consumption;
- batches split across actors;
- future withdrawals;
- recovery followed by later re-blocking;
- distant scheduled cycles;
- future impossible debit;
- checked arithmetic overflow.

Verify that diagnostic projection:

- uses complete scheduled batches and mandatory maintenance;
- does not assume future voluntary rescue;
- does not mutate authoritative state/history;
- does not move a future execution fault into the current cycle;
- treats a fault before recovery as failure to demonstrate recovery;
- recognizes an earlier genuine decision-boundary recovery even if later cycles block again.

If accepted authority cannot support a tested expectation, report semantic ambiguity rather than inventing one.

## Adversarial priority B — fallback attribution

Independently inspect `ResolutionDependencies` and actual resolution behavior.

Try to find:

- over-marked commuting proposals;
- under-marked genuine order participants;
- aggregate three-or-more interactions missed by local pair reasoning;
- debt-cap versus grain/reserve-cap intersections;
- Farm/incoming-credit enablers;
- CallFavor effective-actor/effective-terms cases;
- relation creation/retirement provenance cases;
- Residence/marriage/favour interactions;
- stable-ID sensitivity outside disclosed fallback cases.

Reproduce the candidate-v2 debt-limited Farm counterexample independently. Also construct controls where Farm or incoming credit genuinely changes a spender outcome and must be marked.

PASS requires that technical fallback marking correspond to consequential technical-order participation, not merely coarse potential resource interaction.

## Adversarial priority C — prior repair regressions

Candidate-v2 independently cleared candidate-v1 repair areas; candidate-v3 must preserve them.

Independently sample/re-derive:

- fallback/quarantine breadth from repair-v2;
- needy ordinary-request refusal consequence and attitude cause completeness;
- personal subjective-input isolation;
- D1–D5 promoted semantics;
- initiative accounting;
- deterministic replay/metamorphics;
- CallFavor closure;
- fixture/oracle restrictions.

Do not reopen accepted semantics merely because implementation changed internally.

## Evidence ledger

Build/retain an independent ledger for all 167 manifest rows.

Every REQUIRED row must have admissible substantive evidence. Preserve all frozen non-required classifications.

`S1-GLOBAL-CONFORMANCE` is awarded only by this review.

## Review return

Create branch:

`review/imp-0001-independent-conformance-v3-return`

from current `origin/main`.

Add only:

`research/technical/IMP-0001/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V3.md`

The report must include:

- independence statement;
- candidate/authority identities;
- commands/results and remote CI/artifact comparison;
- K4 item conclusions;
- all-167-row evidence ledger;
- reviewer-owned probes and outcomes;
- precise blockers with source/implementation/evidence references;
- final **PASS** or **BLOCK** applying only to candidate-v3 SHA.

If BLOCK: do not repair the candidate.

If PASS: do not merge PR #23. Master Architect performs final IMP-0001 completion/promotion reconciliation and Birth Run transition.
