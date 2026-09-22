# IMP-0001 Technical Review Evidence

**Status:** Active conformance/repair lineage for SFL v0 Slice 1

## Candidate-v1

- ref: `imp-0001-slice1-conformance-candidate-v1`
- SHA: `7e11dab7697121eb0dbb169ba46210d81b80586e`
- independent result: **BLOCK**
- full report: `IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW.md`
- reconciliation: `IMP-0001_CONFORMANCE_BLOCK_RECONCILIATION.md`

The full v1 report is preserved byte-identically:

- SHA-256 `09fb414448000784866c2e8d172ed576d8180ad9d5db9e7d38ed4bb61a3ab91d`
- Git blob `23206f0891ff13135a683c56dbe264f75db80533`

## Candidate-v2

- ref: `imp-0001-slice1-conformance-candidate-v2`
- SHA: `ba16829e240950f1f3c648107cf3b8b36f996971`
- independent result: **BLOCK**
- full report: `IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V2.md`
- reconciliation: `IMP-0001_CANDIDATE_V2_BLOCK_RECONCILIATION.md`

The v2 reviewer independently cleared the v1 repair areas and found two new narrow blockers: MaterialDeadlock future-input resolution and over-broad fallback attribution under intersecting debt/grain constraints.

## Active repair-v3

- implementation branch: `implementation/imp-0001-slice1-repair-v3`
- draft PR: #23
- repair packet: `../../tasks/implementation/IMP-0001_V3_REPAIR_PACKET.md`
- base: frozen candidate-v2

After repair-v3, the Master Architect must reconcile and freeze a new candidate-v3 SHA before commissioning another **fresh independent K4 reviewer**.

IMP-0001 is not VERIFIED COMPLETE until `S1-GLOBAL-CONFORMANCE` receives fresh independent PASS.
