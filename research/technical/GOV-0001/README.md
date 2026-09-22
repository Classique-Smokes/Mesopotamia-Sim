# GOV-0001 — Master Architect Rulebook Refactor State

**Status:** ACTIVE WORKING STATE / NOT PROMOTED  
**Authority:** Operational continuity record only; does not amend constitutional governance  
**Date:** 2026-09-21

## 1. Single-reality rule

The accepted constitutional governance on `main` remains authoritative until the rulebook refactor is independently evaluated, reconciled, explicitly approved at the required authority level, and promoted.

Do **not** treat branch existence, candidate prose, evaluation packets, or refactor research as accepted governance.

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

No part of this branch is accepted merely because it is complete enough to evaluate.

## 4. Evaluation branches

Frozen evaluation baseline:

- `governance-rulebook-refactor-eval-baseline`

Assigned evaluation branches:

- `governance-eval/root-routing`
- `governance-eval/delegation-research`
- `governance-eval/assurance-escalation`

At consolidation time, all four refs resolve to the same candidate commit:

`41cc0a6beda8465bc16bc8ca9bcee7e1aa9a0679`

No evaluation return commit exists yet. Therefore GOV-0001 evaluation is **prepared but not started/completed**.

These branch names do not represent divergent governance realities; they are isolated return locations prepared from one frozen candidate.

## 5. Refactor control artifacts

On the candidate branch:

- `research/technical/TRES-0010/RULEBOOK_REFACTOR_COMMITMENT_INVENTORY.md`
- `research/technical/TRES-0010/RULEBOOK_REFACTOR_LOSSLESS_RECONCILIATION.md`
- `tasks/research/GOV-0001_MASTER_ARCHITECT_RULEBOOK_EVAL/00_PROGRAM_README.md`
- `tasks/research/GOV-0001_MASTER_ARCHITECT_RULEBOOK_EVAL/01_DISPATCH_GUIDE.md`

The commitment inventory covers G-001..G-100: all baseline Guide commitments plus finalized TRES-0010 durable lessons have explicit destinations.

The lossless reconciliation claims all 100 are preserved or assigned to a canonical owner. That claim still requires fresh-agent evaluation before promotion.

## 6. Next controlled sequence

1. Do not create another governance-refactor branch or competing candidate.
2. Treat `governance-rulebook-refactor-candidate` as the sole WIP candidate.
3. Run GOV-0001 A/B/C from the frozen eval baseline, each on its assigned return branch.
4. Reconcile the independent returns centrally.
5. Repair the same candidate line only if a source-grounded rule-loss/routing defect is demonstrated.
6. Re-run affected evaluation if substantive repairs change evaluated behavior.
7. Only after a clean evaluation, prepare the constitutional promotion package and explicit Director approval.
8. Promote candidate governance and navigation together; then verify fresh-agent retrieval from `AGENTS.md → START_HERE → CURRENT_PHASE → MASTER_ARCHITECT_GUIDE`.
9. Retain Git history/ref names as historical evidence; do not keep competing current governance copies on `main`.

## 7. Separation from implementation

`IMP-0001` is already TRES-cleared and remains ready for dispatch.

GOV-0001 is a separate governance-quality task and is not a Slice-1 implementation prerequisite unless the Project Director changes priority explicitly.

## 8. Recovery rule

If a session times out or a fresh Master Architect resumes this work:

1. read `AGENTS.md`;
2. read `00_START_HERE.md`;
3. read `plans/CURRENT_PHASE.md`;
4. read this file;
5. inspect the baseline/candidate refs named above;
6. do not infer governance state from chat history or branch count.

The intended reality is always: **accepted `main` governance + one isolated candidate + isolated evaluation returns until explicit promotion.**
