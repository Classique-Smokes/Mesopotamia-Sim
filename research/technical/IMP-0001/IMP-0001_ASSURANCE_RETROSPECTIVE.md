# IMP-0001 Assurance Retrospective — Candidate-v1 BLOCK

**Status:** LIGHTWEIGHT PROCESS LEARNING / IMPLEMENTED  
**Scope:** Candidate-v1 independent conformance BLOCK only  
**Principle:** Improve the existing harness/protocol where evidence demonstrated a gap; do not add a new governance layer.

## Result

The candidate-v1 BLOCK does **not** justify a new protocol, standing panel, or generalized pre-code red-team stage.

The existing assurance architecture worked: frozen authority, coder evidence, Master Architect reconciliation, and fresh K4 review produced a reproducible BLOCK before merge.

Four durable lessons were assessed.

### 1. Same-cycle interaction surface — protocol sharpened

Existing protocol already required authority/precondition races to be defined/deferred.

Added one bounded clarification: when claiming global ordering/fallback quarantine, inspect the executable interaction surface rather than extrapolating from representative conflict examples.

### 2. Subjective-input provenance — protocol sharpened

Existing protocol already protected objective/subjective seams.

Added one bounded clarification: actor decision inputs should be provenance-classified, and traces should expose actual behavior-affecting subjective inputs.

### 3. Global claims need span-matched evidence — protocol sharpened

Added explicit scrutiny for "all/every/global/complete/only" claims whose evidence is only sampled cases.

No formal-proof requirement was introduced. Bounded enumeration, structural closure, metamorphic/combinatorial evidence, or justified decomposition remain acceptable.

### 4. Reviewer-owned counterexample probes — protocol clarified

The existing delegation protocol already explicitly supports counterexample/falsification attempts and bounded experiments. **NO CHANGE NEEDED** there.

The assurance protocol now explicitly notes that fresh conformance reviewers may build small scratch probes against the unchanged public boundary when testing broad claims. These probes do not replace canonical evidence.

## What was deliberately not added

- no new protocol;
- no mandatory pairwise test matrix for every slice;
- no generalized formal-methods requirement;
- no second standing independent reviewer;
- no pre-code duplication of K4;
- no change to simulation semantics or architecture.

## Archive preservation correction

The compressed reviewer archive previously added at:

`research/technical/IMP-0001/archive/IMP-0001_INDEPENDENT_CONFORMANCE_REVIEW.md.br`

is **not a valid preservation copy**. Repair-v2 independently detected that its actual bytes do not match the metadata recorded in the BLOCK reconciliation and Brotli decompression fails.

The original user-supplied review artifact remains identified by:

- bytes: 127,757;
- lines: 636;
- SHA-256: `09fb414448000784866c2e8d172ed576d8180ad9d5db9e7d38ed4bb61a3ab91d`.

Until a correct byte-identical repository copy is installed, the invalid `.br` must not be cited as the full reviewer evidence. The readable reconciliation remains valid as a Master Architect synthesis, but it is not a substitute for the original full review.

This preservation defect is clerical and does not alter the candidate-v1 BLOCK or candidate-v2 repair semantics.
