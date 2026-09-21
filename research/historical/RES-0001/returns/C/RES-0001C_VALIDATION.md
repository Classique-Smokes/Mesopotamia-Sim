# RES-0001C — Validation record

**Date:** 19 September 2026
**Status:** PASS

Structural, consistency and preservation checks do not independently certify translations, historical truth, full source access, or representativeness. No fresh clay collation or architectural verification is claimed.

## Checks actually performed

| Check | Result | Detail |
|---|---|---|
| Nine required report sections | PASS | Sections 1–9 in order. |
| No unfilled assembly markers | PASS | All table/candidate placeholders resolved. |
| Two principal microhistories | PASS | Plus one judicial countercase and supplementary instruments. |
| Twelve-column evidence schema | PASS | All 24 rows have all required fields populated. |
| Claim confidence vocabulary | PASS | Confidence is claim-specific; no citywide prevalence inferred. |
| Advisory design status | PASS | All evidence rows and nine candidate claims carry the required status. |
| No canonical HE identifiers assigned | PASS | No canonical historical-evidence numbers assigned. |
| Unique Document_ID values | PASS | 27 unique values. |
| Unique Local claim ID values | PASS | 24 unique values. |
| Unique Process_ID values | PASS | 13 unique values. |
| Unique Source_ID values | PASS | 20 unique values. |
| Unique object identifiers | PASS | 27 different CDLI object records; event deduplication is separate. |
| Direct-text corpus counts | PASS | 17 artifacts / 15 acts total; core 15 artifacts / 13 acts; two supplementary uncertain-provenance acts. |
| Parallel witnesses deduplicated | PASS | OECT 8, 17/18 count as one act; TMH 10, 18a/b/c likewise. |
| Candidate template fields | PASS | Title plus all twelve required fields, for nine candidates. |
| D references resolve | PASS | 27 referenced IDs; no undefined IDs. |
| S references resolve | PASS | 20 referenced IDs; no undefined IDs. |
| C-C references resolve | PASS | 24 referenced IDs; no undefined IDs. |
| CSV roundtrip: DOCUMENT_LEDGER | PASS | 27 rows, same content as JSON. |
| CSV roundtrip: EVIDENCE_TABLE | PASS | 24 rows, same content as JSON. |
| CSV roundtrip: CONTINUITY_PROCESS_MATRIX | PASS | 13 rows, same content as JSON. |
| CSV roundtrip: SOURCE_LEDGER | PASS | 20 rows, same content as JSON. |
| CSV roundtrip: SOURCE_CRITICAL_AUDIT | PASS | 14 rows, same content as JSON. |
| HTML unique anchors | PASS | 149 anchors. |
| HTML internal links resolve | PASS | 611 internal references and navigation links. |
| HTML data tables | PASS | Executive, evidence, estate allocation, process, audit, sources, documents. |
| HTML offline independence | PASS | No external rendering resources; source retrieval links are optional. |
| Original archive CRC | PASS | ZIP member integrity test passed. |
| Task package supplied checksums | PASS | All seven task-package files match supplied SHA-256 values. |
| Original local source unchanged: 04_RESULT_RETURN_TEMPLATE.md | PASS | Byte-for-byte comparison with original ZIP member. |
| Original local source unchanged: 02_EVIDENCE_AND_OUTPUT_PROTOCOL.md | PASS | Byte-for-byte comparison with original ZIP member. |
| Original local source unchanged: RES-0001C_ADOPTION_INHERITANCE_AND_CONTINUITY.md | PASS | Byte-for-byte comparison with original ZIP member. |
| Original local source unchanged: 01_SHARED_RESEARCH_CONTEXT.md | PASS | Byte-for-byte comparison with original ZIP member. |
| Original local source unchanged: 03_SOURCE_STARTING_POINTS.md | PASS | Byte-for-byte comparison with original ZIP member. |
| Canonical Seed identity | PASS | Task copy equals program-master Seed in original archive. |

## Original input archive

`MESOPOTAMIA_RES-0001_RESEARCH_DISPATCH.zip`
`SHA-256: 6d11e82794e5e26415f3f9e8d964a11f0a7678e6c85aaa4fddf6379c46e54caf`

The input ZIP was read, not rewritten. The seven task-package files match their supplied checksums. Every available local original task file was compared with its ZIP member. No canonical project state was edited.

## Source-critical limits

The complete Stone/Owen 1991 and Goddeeris 2016 volumes, the full Meinhold 2020 chapter, and Stone 1987 architectural plans were not accessed. Individual primary editions and later published corrections were inspected where recorded in the source and document ledgers. An access limit is not a bibliographic quality judgment.

## Rendering review

Browser checks and any visual inspection are recorded separately in RES-0001C_RENDER_CHECK.json when present.
