# RES-0001 — Evidence and Output Protocol

Use this protocol for every parallel workstream so the reports can be reconciled mechanically and intellectually.

## A. Source hierarchy and provenance

Prefer, where available:

1. published primary texts, editions, transliterations/translations, excavation reports, object catalogues, and securely contextualized archaeological evidence;
2. peer-reviewed or academically reputable specialist scholarship that analyzes those materials;
3. scholarly reference works and corpora for discovery and cross-checking;
4. non-specialist summaries only as discovery aids, never as the main basis for consequential claims.

For every material claim, make it possible to recover the source. Give full bibliographic citation and stable identifiers where available: publication text number, museum number, CDLI P-number, ORACC/ePSD entry, DOI, excavation area/locus/level, archive name, or equivalent.

## B. Primary-text handling

When using a tablet/document, record when available:

- date or regnal attribution;
- Nippur provenance and, if known, archaeological/archival context;
- document genre (sale, loan, adoption, inheritance division, marriage, letter, administrative record, school/model contract, etc.);
- language and edition/translation relied upon;
- tablet/publication/corpus identifier;
- what the document directly demonstrates versus what is inferred from it.

**Model contracts and school exercises must be labeled as didactic texts.** They can illuminate formulae, scribal categories, and expected transaction forms, but must not be counted straightforwardly as records of events that occurred.

## C. Archaeological handling

Where relevant, preserve:

- excavation area, level/phase, locus/house designation;
- dating basis and uncertainty;
- association between tablets and architecture;
- whether a functional interpretation of space is excavator inference, later reinterpretation, or directly supported by finds.

Do not infer social membership solely from walls or room counts without evidentiary support.

## D. Comparative evidence

Evidence from Sippar, Ur, Larsa, Isin, Mari, or other places may be useful for interpretation, but keep it in a clearly marked **comparative** section. It must not be presented as direct evidence for Nippur.

Likewise, evidence from Ur III, Middle Babylonian, Neo-Babylonian, or other periods must be marked as chronologically comparative.

## E. Claim confidence

Use `HIGH / MODERATE / LOW` confidence only for the stated claim within its stated context.

- **HIGH:** supported by multiple converging primary examples and/or strong contextual evidence with limited serious dispute.
- **MODERATE:** plausible and supported, but sample, interpretation, chronology, or source bias materially limits certainty.
- **LOW:** suggestive, dependent on contested reconstruction, sparse examples, uncertain provenance, or broad inference.

Confidence does not imply generalizability beyond the recorded context.

## F. Required report structure

Return:

1. **Executive findings** — 5–12 concise findings, each with confidence and scope.
2. **Context and corpus** — what evidence was actually examined and its chronological/provenance distribution.
3. **Evidence table** — claim-by-claim structured entries.
4. **Analysis** — interpretation, variation, exceptions, and causal/social implications relevant to the assigned historical question.
5. **Disagreement and uncertainty** — competing readings and source limitations.
6. **Comparative evidence** — clearly separated from Nippur evidence.
7. **Unresolved questions** — what remains unknown or should be commissioned next.
8. **Register-ready claims** — candidate entries for the Historical Evidence Register; do not assign canonical `HE-` numbers.
9. **Bibliography/source ledger** — complete enough to retrieve every material source.

## G. Evidence-table schema

For each important claim use:

| Field | Required content |
|---|---|
| Local claim ID | e.g. `A-C01`, `B-C04` |
| Claim | Narrow historical proposition |
| Period/date | Most precise defensible dating |
| Nippur context | Archive/house/area/social context if known |
| Evidence type | Primary / Secondary / Mixed |
| Primary evidence | IDs/citations + what it directly shows |
| Secondary interpretation | Scholars and interpretation |
| Counterevidence/disagreement | Meaningful alternative or exception |
| Confidence | HIGH / MODERATE / LOW |
| Generalization limit | Explicit boundary |
| Project relevance | Why the evidence matters to individual/relationship/household understanding |
| Design status | Always `NO DESIGN DECISION` for this program |

## H. Scope discipline

Do not:

- propose simulation mechanics or data structures;
- define canonical “household membership” criteria for the simulation;
- collapse legal capacity into actual social practice without argument;
- collapse co-residence into household membership without argument;
- treat named persons in contracts as a representative census;
- turn one archive family into a citywide norm;
- use absence of documentation as proof of absence without a source-critical case;
- suppress scholarly disagreement for the sake of a clean answer.

A result of “the evidence does not permit a confident answer” is valid and useful.
