# TRES-0010 — Human / Agent Dispatch Guide

**Purpose:** Make each Wave-A commission executable from a fresh repo-enabled chat with minimal operator work.

## 1. Simple operating model

Use **one fresh chat per Wave-A task**.

Do not execute multiple Wave-A tasks in one conversation: shared conversational context weakens independence.

All reviewers use the frozen review baseline `tres-0010-review-baseline` declared in `00_PROGRAM_README.md`.

Do not review a moving `main` branch.

## 2. Task-number mapping

| Human shorthand | Task ID | Packet | Dedicated return branch |
|---:|---|---|---|
| 1 | TRES-0010A | `TRES-0010A_FOUNDATIONAL_ALIGNMENT_AUDIT.md` | `tres-0010/a` |
| 2 | TRES-0010B | `TRES-0010B_SEMANTIC_REACHABILITY_AUDIT.md` | `tres-0010/b` |
| 3 | TRES-0010C | `TRES-0010C_TEMPORAL_DETERMINISM_AUDIT.md` | `tres-0010/c` |
| 4 | TRES-0010D | `TRES-0010D_VERIFICATION_CHEAT_RED_TEAM.md` | `tres-0010/d` |
| 5 | TRES-0010E | `TRES-0010E_IMP0001_HANDOFF_AUDIT.md` | `tres-0010/e` |
| 6 | TRES-0010F | `TRES-0010F_FUTURE_SLICE_COMPATIBILITY_AUDIT.md` | `tres-0010/f` |
| 7 | TRES-0010G | `TRES-0010G_CSHARP_IMPLEMENTATION_HAZARD_REVIEW.md` | `tres-0010/g` |
| 8 | TRES-0010H | `TRES-0010H_ADVERSARIAL_TRAJECTORY_DESIGN.md` | `tres-0010/h` |
| 9 | TRES-0010I | `TRES-0010I_SCOPE_MINIMALITY_RED_TEAM.md` | `tres-0010/i` |
| 10 | TRES-0010J | `TRES-0010J_FRESH_AGENT_RETRIEVAL_AUDIT.md` | `tres-0010/j` |

## 3. Minimal dispatch instruction

A repo-enabled fresh chat should be able to execute a task from this instruction:

> Execute TRES-0010A from the Mesopotamia-Sim repository. Read the TRES-0010 program README, dispatch guide, and the TRES-0010A task packet; follow them exactly. Use the frozen review baseline. Do not read sibling Wave-A returns before finalizing your report. Do not modify canonical project files.

Replace `A` with the assigned task letter.

## 4. Return / repository behavior

Preferred order:

1. Agent reads the frozen baseline.
2. Agent performs the assigned research independently.
3. Agent finalizes its report **before** reading sibling Wave-A reports.
4. If isolated-branch GitHub writes are available:
   - use the task's pre-created dedicated branch from the table above;
   - that branch starts from the frozen review baseline;
   - write only the assigned return under `research/technical/TRES-0010/returns/`;
   - report branch + commit SHA.
5. If isolated writes are not available, return the complete report in chat; do not write to main.

Never allow ten concurrent reviewers to mutate canonical files.

## 5. Required run metadata

Every return begins with:

- Task ID;
- TRES-0010 baseline ref and commit SHA;
- model/configuration if visible;
- branch/workspace used;
- tools used;
- external web research: yes/no; key sources if yes;
- prior TRES-0003–0009 read: yes/no and when;
- sibling Wave-A reports read before initial report: **must be no**.

## 6. Independence / effort rule

Before returning `NO BLOCKER FROM THIS REVIEW`, the reviewer should attempt at least three materially distinct attacks appropriate to its task, unless the task's structure clearly makes fewer sufficient.

Report failed attacks too. A no-finding report without evidence of attempted falsification is weak evidence.

## 7. Sentinel replication

After the ten primary Wave-A reports return, do not immediately synthesize "all clear."

Before final closure:

- rerun at least two high-leverage objectives in fresh chats with no access to original reports;
- default: TRES-0010B semantic reachability and TRES-0010D verification-cheat;
- where practical, vary model/provider or reasoning configuration;
- treat disagreement as a lead for reconciliation, not a vote.

## 8. What the human operator should not need to do

The operator should not have to:

- paste the project history;
- explain the simulation;
- manually choose source files;
- restate the finding schema;
- tell the agent where authority lives.

The task packet + repository retrieval path carry that context.

If an agent cannot locate or interpret its packet from the minimal instruction, that is itself evidence for TRES-0010J.


## 9. Same-model caveat

Using ten fresh chats of the same model is still worthwhile, but it is not ten statistically independent reviewers.

The design controls this by:

- one task per fresh chat;
- materially different attack objectives;
- different source restrictions;
- sibling-report blindness;
- frozen baseline;
- sentinel reruns;
- evidence-based rather than vote-based reconciliation.

If another capable model/provider with equivalent repository/tool access is conveniently available, using it for one or both sentinel reruns adds useful diversity. It is optional, not a requirement.
