# SFL v0 — Reference Scoring Contract Erratum

**Status:** OPEN / REQUIRES DIRECTOR DECISION  
**Date:** 2026-09-21  
**Authority:** Working semantic erratum only.

## Gap

Accepted architecture/specification requires:

- hierarchical/context-sensitive candidate generation;
- soft/conditional concerns/gates;
- transparent component scoring;
- deterministic selection of the highest-scoring generated candidate;
- deterministic semantic tie-break;
- complete candidate/gate/component/final-score traces.

It intentionally leaves exact scoring coefficients as laboratory configuration.

What is still missing is the **aggregation/configuration contract** that tells an implementation what a "component score" and "final score" mean.

Open examples:

- are component scores summed, lexicographically compared by concern tier, normalized, capped, or otherwise aggregated?
- how do soft concern tiers interact with component totals?
- what configuration schema makes a scenario's pinned profile executable?
- what exact fallback orders two equal final scores before the separately disclosed technical-ID fallback?

Without this contract, two conforming-looking implementations could choose different actions from the same candidate/component values.

## Why this is semantic

The scorer changes actor actions and therefore world history. Stage 4 must not invent it as a local coding choice.

## Recommended v0 direction

Keep the model deliberately simple:

1. categorical gates first remove invalid/inaccessible candidates;
2. each remaining candidate has a finite set of named integer score components;
3. `FinalScore = sum(all component values)`;
4. component values are supplied by the v0 rule/configuration profile and may depend only on explicitly listed objective/subjective inputs;
5. highest FinalScore wins;
6. exact-score ties use an explicitly declared domain tie key where the action domain defines one; otherwise the existing disclosed stable-semantic-ID technical fallback applies and is logged;
7. soft concern/tier behavior is represented by named score components and candidate-generation gates in v0 rather than a second hidden aggregation layer;
8. complete component decomposition is recorded.

This keeps the scorer replaceable later while making the reference laboratory executable and independently testable.

## Still to specify if this direction is approved

Stage 3 must define the small default/reference component table or closed-loop test profiles for the in-scope concern/action families actually exercised by SFL v0. Historical plausibility of the numeric weights remains outside the verification contract.
