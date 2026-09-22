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

## Candidate-v3

- ref: `imp-0001-slice1-conformance-candidate-v3`
- SHA: `06e25644879dd8505e24fcaeb43256f69c29c15f`
- implementation branch: `implementation/imp-0001-slice1-repair-v3`
- draft PR: #23
- Master Architect reconciliation: `../../tasks/implementation/IMP-0001_CANDIDATE_V3_RECONCILIATION_AND_DISPATCH.md`
- fresh K4 packet: `../../tasks/implementation/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW_V3_PACKET.md`
- independent result: **PENDING**

Candidate-v3 addresses the two candidate-v2 blockers under unchanged accepted semantics: MaterialDeadlock future recovery projection and precise TechnicalFallback attribution under intersecting constraints.

IMP-0001 is not VERIFIED COMPLETE until `S1-GLOBAL-CONFORMANCE` receives fresh independent PASS.
