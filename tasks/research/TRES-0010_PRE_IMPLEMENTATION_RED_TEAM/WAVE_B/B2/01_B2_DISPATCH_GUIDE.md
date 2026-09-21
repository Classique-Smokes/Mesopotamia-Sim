# TRES-0010 B2 — Dispatch Guide

## 1. Frozen baseline

All B2 tasks use:

- ref: `tres-0010-b2-baseline`
- SHA: set after the B2 packets are committed.

Do not use a moving `main`.

## 2. Task mapping

| Human task # | Task ID | Purpose | Return branch |
|---:|---|---|---|
| 1 | TRES-0010B2-SEM-T | temporal/reaction/residence semantic options | `tres-0010/b2-sem-t` |
| 2 | TRES-0010B2-SEM-A | action/favour/amount semantic options | `tres-0010/b2-sem-a` |
| 3 | TRES-0010B2-ASR | Slice-1 acceptance authority / applicability design | `tres-0010/b2-asr` |

## 3. Minimal operator instruction

> Execute TRES-0010 B2 task 1 from the Mesopotamia-Sim repository. Read the B2 README, dispatch guide, and assigned task packet; follow them exactly. Use the frozen B2 baseline and assigned return branch. Do not read sibling B2 returns or modify canonical files.

Change only the task number.

## 4. Return metadata

Every return records:

- task ID;
- B2 baseline ref and SHA;
- model/configuration if visible;
- return branch/workspace;
- tools used;
- external research yes/no + sources if used;
- assigned Wave-A/Wave-B reports read;
- sibling B2 returns read before completion: must be no;
- canonical files modified: must be no.

## 5. Research scope

External web research is optional and should be used only when it can materially inform a technical assurance mechanism or established implementation/evaluation practice.

Do not use external sources to decide SFL social semantics. Those decisions must be derived from accepted project authority plus explicit Director judgment where needed.