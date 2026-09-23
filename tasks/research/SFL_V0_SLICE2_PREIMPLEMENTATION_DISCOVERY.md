# SFL v0 Slice 2 — Pre-Implementation Discovery Inventory

**Status:** READY FOR LOW-AUTHORITY DELEGATION  
**Class:** Research / inventory / implementation-readiness discovery  
**No implementation authority:** yes  
**No semantic promotion authority:** yes  
**Owning reconciliation:** Master Architect

## 1. Purpose

Prepare Slice 2 for safe planning by inventorying what is already accepted, what is already implemented from Slice 1, what verification obligations were deferred, and what consequential gaps remain.

Do **not** design new social semantics merely to make agents more interesting.

## 2. Controlling question

> What exact accepted Slice-2 subjective-knowledge/recognition machinery must become executable, and what minimal agency integration is required so those subjective differences can causally affect action without inventing richer motivation, global omniscience, or later-slice mechanics?

## 3. Required retrieval order

1. `AGENTS.md` and `00_START_HERE.md`;
2. `plans/CURRENT_PHASE.md`;
3. `research/technical/SFL_V0_OBSERVATIONS/BIRTH_RUN_001_RECONCILIATION.md`;
4. `plans/SFL_V0_INTERSLICE_DISCOVERY_PROMPTS.md`;
5. accepted `SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`;
6. accepted ADRs, especially ADR-0002;
7. Slice-1 frozen acceptance manifest and later-slice/deferred verification rows;
8. current production implementation surfaces for state, personal decision inputs, agency, history and execution;
9. `research/conceptual/INSTITUTIONAL_DYNAMICS/07_SFL_V0_DISCOVERY_SEAMS.md` only as a question generator.

## 4. Inventory outputs

Produce one report answering:

### A. Accepted Slice-2 semantics

For every accepted subjective-information/recognition concept relevant to Slice 2, identify:

- exact authoritative source;
- objective versus subjective state distinction;
- provenance requirements;
- stale/contested/unknown meanings where accepted;
- communication/observation route where accepted;
- which action gates or decision inputs it can affect;
- any lifecycle/update rules already fixed.

Do not paraphrase away distinctions among objective fact, KnownFact, Recognition, communication evidence and engine truth.

### B. Current implementation baseline

Identify which supporting primitives already exist from Slice 1 and which are absent.

Inspect at minimum:

- state types;
- decision-input construction;
- `PersonalAgency`;
- semantic/decision history;
- execution cycle boundaries;
- deterministic ordering;
- checkpoint-adjacent future state only insofar as Slice 2 requires it.

### C. Verification/deferred rows

Inventory all frozen verification rows whose implementation was deferred from Slice 1 and which become relevant to Slice 2.

Do not reclassify them.

Separate:

- clearly Slice-2 rows;
- later-slice rows that remain deferred;
- rows whose firing depends on an unresolved semantic choice.

### D. Birth-run implications

Treat the Birth Run reconciliation as evidence about **reference-policy breadth**, not new authority.

Identify where Slice 2 can legitimately make subjective information causally relevant under already accepted semantics.

Do not assume Slice 2 must solve:

- rich motivation;
- historical calibration;
- multi-step strategic planning;
- stochastic behavior;
- all action types receiving positive utility.

### E. Unresolved questions

Return a bounded list of questions classified as:

1. already answered by accepted authority;
2. engineering choice within accepted architecture;
3. consequential semantic/architectural gap requiring Master Architect/Director escalation;
4. outside Slice 2 and should remain deferred.

For every category-3 item, cite the exact missing distinction rather than proposing a preferred answer.

## 5. Required anti-shortcuts

Do not:

- make actor knowledge globally synchronized;
- replace provenance-bearing knowledge with direct reads from objective state;
- collapse Recognition into objective truth;
- turn Birth Run observations into new semantics;
- add richer scoring weights just to exercise unused actions;
- pull household/office/checkpoint mechanics forward;
- promote Institutional Dynamics concepts into Slice 2.

## 6. Return format

Add only:

`research/technical/SFL_V0_SLICE2_PREIMPLEMENTATION_DISCOVERY.md`

The report should include:

- retrieved authority list;
- accepted-semantics inventory;
- implementation-gap map;
- deferred-verification map;
- bounded escalation list;
- recommended next planning action.

Do not edit production code, accepted spec, ADRs, verification authority, or observation records.

## 7. Completion condition

The task is complete when the Master Architect can answer:

- Is Slice 2 semantically ready to plan?
- Which exact accepted mechanics belong in it?
- Which deferred verification obligations fire?
- Is any Director-level decision required before implementation?
- What can safely be delegated to engineering without inventing semantics?
