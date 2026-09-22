# GOV-0001 — Master Architect Rulebook Refactor State

**Status:** EVALUATION COMPLETE / AWAITING CONSTITUTIONAL DECISION  
**Authority:** Operational continuity record only; does not amend constitutional governance  
**Date:** 2026-09-21

## 1. Single-reality rule

The accepted constitutional governance on `main` remains authoritative until the rulebook refactor is explicitly approved at the required authority level and promoted.

Do **not** treat branch existence, candidate prose, evaluation reports, reconciliation, or the promotion proposal as accepted governance.

## 2. Frozen baseline

- ref: `governance-rulebook-refactor-baseline`
- commit: `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b`
- accepted Guide blob at baseline: `governance/MASTER_ARCHITECT_GUIDE.md` @ `4e24d1afde04bd1ccae40d89b98facb171a9908b`

This is the pre-refactor constitutional baseline.

## 3. Sole candidate line

- branch: `governance-rulebook-refactor-candidate`
- candidate head: `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679`
- relation to baseline: **19 commits ahead / 0 behind**

The candidate contains the complete unpromoted working refactor:

- compact candidate `MASTER_ARCHITECT_GUIDE.md`;
- new `AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md`;
- new `SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`;
- existing-protocol metadata/ownership clarifications;
- `governance/checklists/ARTIFACT_FREEZE_CHECKLIST.md`;
- research/implementation template adjustments;
- operative commitment inventory;
- lossless reconciliation;
- GOV-0001 fresh-agent evaluation packets.

No part of this branch is accepted merely because it passed evaluation.

## 4. Fresh-agent evaluation result

Frozen evaluation baseline:

- `governance-rulebook-refactor-eval-baseline` @ `41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679`

Returns:

- GOV-0001-A / root routing: **PASS**
  - branch: `governance-eval/root-routing`
  - return commit: `f467151ffedd8c822eb6bcfda1d473f81e8bcd77`
- GOV-0001-B / delegation-research-architecture-drift: **PASS**
  - branch: `governance-eval/delegation-research`
  - return commit: `39e9ca11a4e256591719e7e545b760736a7391bc`
- GOV-0001-C / assurance-escalation: **PASS**
  - branch: `governance-eval/assurance-escalation`
  - blind primary-result commit: `6dc653a1c9a946871a65e73b09190f2bd8678657`
  - final return commit: `f9e15e09027bf45bab5fbec4a09932fa0a3d09e2`

Each evaluation branch changed only its assigned return report relative to the frozen candidate.

Central reconciliation:

- `research/technical/GOV-0001/FRESH_AGENT_EVALUATION_RECONCILIATION.md`

Reconciled result: **PASS / no candidate repair required / no rerun required**.

## 5. Refactor control artifacts

On the candidate branch:

- `research/technical/TRES-0010/RULEBOOK_REFACTOR_COMMITMENT_INVENTORY.md`
- `research/technical/TRES-0010/RULEBOOK_REFACTOR_LOSSLESS_RECONCILIATION.md`
- `tasks/research/GOV-0001_MASTER_ARCHITECT_RULEBOOK_EVAL/00_PROGRAM_README.md`
- `tasks/research/GOV-0001_MASTER_ARCHITECT_RULEBOOK_EVAL/01_DISPATCH_GUIDE.md`

On `main`:

- `research/technical/GOV-0001/FRESH_AGENT_EVALUATION_RECONCILIATION.md`
- constitutional promotion proposal: `proposals/GOV-0001_MASTER_ARCHITECT_RULEBOOK_PROMOTION.md`
- proposed decision record: `decisions/DEC-0009_MASTER_ARCHITECT_RULEBOOK_REFACTOR.md`

The commitment inventory covers G-001..G-100: all baseline Guide commitments plus finalized TRES-0010 durable lessons have explicit destinations. Fresh-agent evaluation and central reconciliation found no material rule loss or routing defect.

## 6. Controlled next sequence

1. Do not create another governance-refactor branch or competing candidate.
2. Treat `governance-rulebook-refactor-candidate` @ `41cc0a6...` as the sole evaluated candidate.
3. Obtain explicit Project Director approval or rejection of DEC-0009.
4. If rejected or returned for changes, keep accepted governance on `main`; repair only the demonstrated issue and re-evaluate affected behavior if the candidate changes substantively.
5. If approved, promote the evaluated candidate's operative governance content together with required status/decision/navigation integration.
6. Verify that promotion changed no evaluated operative content except explicitly administrative status/navigation/lineage changes.
7. Verify fresh-agent retrieval after promotion from:
   `AGENTS.md → 00_START_HERE.md → plans/CURRENT_PHASE.md → MASTER_ARCHITECT_GUIDE → triggered owner`.
8. Retain frozen baseline/candidate/evaluation refs as historical evidence; do not keep competing current governance copies on `main`.

## 7. Separation from implementation

`IMP-0001` is already TRES-cleared and remains ready for dispatch.

GOV-0001 is a separate governance-quality task and is not a Slice-1 implementation prerequisite unless the Project Director changes priority explicitly.

## 8. Recovery rule

If a session times out or a fresh Master Architect resumes this work:

1. read `AGENTS.md`;
2. read `00_START_HERE.md`;
3. read `plans/CURRENT_PHASE.md`;
4. read this file;
5. read the fresh-agent evaluation reconciliation;
6. inspect DEC-0009 status;
7. do not infer governance state from chat history or branch count.

Until explicit promotion, the intended reality is:

**accepted `main` governance + one frozen evaluated candidate + retained evaluation evidence + a non-authoritative promotion proposal.**
