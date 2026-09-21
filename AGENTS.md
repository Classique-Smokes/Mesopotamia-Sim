# AGENTS.md

This file is the machine-discoverable entrypoint for agents working in this repository. Keep it short.

## Start here

1. Read `00_START_HERE.md`.
2. Read `plans/CURRENT_PHASE.md`.
3. Retrieve only the accepted decisions/specifications relevant to the task.
4. For delegated work, follow the applicable task packet in `tasks/`.

## Hard rules

- Repository authority outranks conversation, agent output, existing code, and working notes.
- Do not modify accepted semantics or architecture to make implementation easier; escalate conflicts.
- Working/proposed artifacts are not authority.
- Completion requires observable verification; agent confidence is not evidence.
- Do not weaken acceptance tests, graders, or invariants unless the task explicitly authorizes changing the specification/verification itself.
- Delegation cannot increase authority or tool permissions beyond the parent task.
- Concurrent agents that mutate files must use isolated branches/worktrees/workspaces and reconcile explicitly before integration.
- Keep accepted records concise; put explanation in working/research material.

## Commands

No production implementation exists yet, so there is no canonical build/test command.

Before persistent implementation begins, replace this section with the exact root verification commands used by agents and CI.

## Context discipline

Prefer links and retrieval over copying large project history into context. Add rules here only when a recurrent agent failure shows that a durable root instruction is needed.

For work that changes project scaffolding, tooling, CI, verification, delegation, or agent workflow, consult `registers/SCAFFOLDING_TRIGGER_REGISTER.md`.
