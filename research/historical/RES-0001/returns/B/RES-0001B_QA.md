# RES-0001B — Quality-control record

**Date:** 2026-09-19  
**Purpose:** Verify the handoff’s structure, references and file integrity. These tests are **not** independent historical peer review, renewed tablet collation or proof that every source reading is correct.

## Automated checks

| Check | Result | Detail |
|---|---|---|
| Nine mandatory sections | PASS | ['Executive findings', 'Corpus and method actually used', 'Evidence table', 'Analysis', 'Disagreement, ambiguity, and source limitations', 'Comparative evidence outside Old Babylonian Nippur', 'Unresolved questions / recommended follow-up research', 'Register-ready candidate claims', 'Source ledger'] |
| Evidence table schema | PASS | All 12 required columns present. |
| Claim identifiers | PASS | B-C01 through B-C23, once each in CSV. |
| Confidence values | PASS | No other confidence value in the claim table. |
| Design status | PASS | All 23 rows retain the mandated status. |
| No empty evidence cells | PASS | Every evidence-table field contains substantive text or an explicit limit. |
| Matrix rows | PASS | 16 rows in main report. |
| Standalone matrix equality | PASS | Matrix data identical in main report and standalone copy. |
| Candidate count | PASS | Eight candidates; no canonical numbering assigned. |
| No canonical register IDs | PASS | No HE-number was generated. |
| Source IDs | PASS | 20 ledger rows with unique source IDs. |
| Full source cross-references | PASS | All full source IDs resolve to the ledger. |
| Full document cross-references | PASS | All full document IDs resolve to the inventory. |
| Full claim cross-references | PASS | All full claim IDs resolve to the evidence table. |
| Inventory scope counts | PASS | 18 main records, 4 caution records, 2 comparative records, 1 unread lead. |
| Follow-up section is questions | PASS | All twelve entries are questions, not decisions. |
| HTML report text present | PASS | All mandatory section headings present in browser version. |
| HTML internal links | PASS | Every internal link target resolves. |
| No external HTML asset dependency | PASS | No external scripts, images, stylesheets or fonts. |
| Supplied source package unchanged | PASS | 8 supplied files match an original dispatch ZIP entry byte for byte. |

## Source-critical checks performed during research

The direct reading of PBS 8/2 116 was checked against the secondary description; the tablet/case relation of BE 6/2 40 was checked in a catalogue image; SAOC 44 1 was matched to MC 3 14 in the CDLI concordance; the house-rental and share-purchase catalogue entries were revisited; and the modern genealogy figure in van Wyk 2018 was visually inspected. These checks are described in the notes and cited in the main report.

Unresolved discrepancies remain explicitly recorded, including the BE 6/2 40 day-date, payment-category and marital-stage disagreements, SAOC 44 25 contributor count, the boy(?) support identification and architectural inference limits. No check is represented as resolving those open questions.

## Source-package integrity

- `00_READ_ME_FIRST.md`: exact match.
- `01_SHARED_RESEARCH_CONTEXT.md`: exact match.
- `02_EVIDENCE_AND_OUTPUT_PROTOCOL.md`: exact match.
- `03_SOURCE_STARTING_POINTS.md`: exact match.
- `04_RESULT_RETURN_TEMPLATE.md`: exact match.
- `05_PROJECT_SEED_CANONICAL_COPY.md`: exact match.
- `06_DISPATCH_GUIDE.md`: exact match.
- `RES-0001B_KINSHIP_MARRIAGE_AND_MEMBERSHIP.md`: exact match.

## Not claimed

The HTML reader passed structural and internal-link checks, but a browser screenshot could not be generated because the local headless browser executable was unavailable. Its visual layout was not independently rendered in this session.

Exhaustive primary-corpus coverage; independent clay or photograph collation; a comprehensive lexical audit; complete reading of every work in the ledger; representative demographic sampling; or verification of every modern genealogical link. Current-access failures are disclosed in the source ledger rather than counted as successful consultation.
