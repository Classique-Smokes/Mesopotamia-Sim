# GOV-0001 — Master Architect Rulebook Refactor Fresh-Agent Evaluation

**Status:** PREPARED / PRE-PROMOTION GOVERNANCE GATE  
**Authority:** Advisory evaluation only  
**Canonical mutation:** Forbidden  
**Target:** candidate governance architecture on the frozen evaluation baseline

## 1. Purpose

Test whether the candidate Master Architect governance structure is:

- lossless enough to preserve mandatory behavior;
- easier to retrieve by work mode;
- less likely to flood ordinary context;
- explicit enough that a fresh qualified agent loads the right protocol without chat history;
- free of contradictory duplicate ownership.

This is a retrieval/behavior evaluation, not a style review.

## 2. Candidate architecture under test

The candidate uses:

- short constitutional core: `governance/MASTER_ARCHITECT_GUIDE.md`;
- existing specialized owners for interpretation, promotion, architecture, escalation, and drift;
- new specialized owners for delegation/research and specification→implementation assurance;
- task templates/checklists for repeatable task-instance mechanics.

Reviewers must test that architecture through the repository retrieval path rather than assuming the design is correct.

## 3. Evaluation design

Run three fresh reviewers from the same frozen baseline:

- GOV-0001-A — root retrieval + Director/authority/routine-work routing;
- GOV-0001-B — delegation/research/architecture/drift routing;
- GOV-0001-C — specification→implementation assurance + implementation-conflict routing.

Reviewers must not read:

- `research/technical/TRES-0010/RULEBOOK_REFACTOR_COMMITMENT_INVENTORY.md`;
- `research/technical/TRES-0010/RULEBOOK_REFACTOR_LOSSLESS_RECONCILIATION.md`;
- sibling GOV-0001 returns;
- chat history about the refactor;

until after they complete and record their primary scenario results.

The inventory/reconciliation may be read only in a second-pass audit after primary results, to check rule loss not discoverable from scenarios.

## 4. Primary retrieval path

Each reviewer begins with:

1. `AGENTS.md`;
2. `00_START_HERE.md`;
3. `plans/CURRENT_PHASE.md`;
4. if acting as Master Architect, `governance/MASTER_ARCHITECT_GUIDE.md`.

Then load only the protocol(s)/template(s) the candidate structure says are needed for the scenario.

## 5. Success criteria

Across the evaluation set:

- correct protocol selection;
- no missed mandatory protocol;
- no need for chat history;
- no material rule loss;
- no conflicting procedural owner;
- ordinary low-risk work does not load every governance file;
- consequential work still reaches required stop/approval/verification rules;
- the core Guide is sufficient to route a qualified agent to deeper detail.

A reviewer may return BLOCK for one concrete missing rule/routing defect; it should not demand more procedure merely because more procedure is imaginable.

## 6. Mutation / return rule

Each reviewer works on its assigned isolated return branch and may add only its assigned return report under:

`research/technical/GOV-0001/returns/`

No reviewer edits governance, task templates, navigation, decisions, or the candidate branch.

## 7. Return provenance

Every return records:

- task ID;
- frozen baseline ref + resolved SHA;
- assigned branch;
- model/config if visible;
- sources actually loaded for each scenario;
- tools used;
- sibling returns read before primary results: must be no;
- migration inventory/reconciliation read before primary results: must be no;
- canonical/candidate files modified: must be no.

## 8. Gate

The candidate Master Architect Guide must not replace the accepted Guide on `main` until GOV-0001 is reconciled and any demonstrated retrieval/rule-loss defects are repaired.
