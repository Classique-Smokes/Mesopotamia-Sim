# TRES-0010 Wave B — Dispatch Guide

## 1. Operating model

Use one fresh repo-enabled chat per task.

Do not run prosecution and defense for the same cluster in one conversation.

All B1 reviewers use the frozen Wave-B canonical baseline:

`tres-0010-wave-b-baseline`

Sentinels still evaluate canonical inputs from the original:

`tres-0010-review-baseline`

## 2. Task mapping

| # | Task | Role | Return branch |
|---:|---|---|---|
| 1 | B-SENTINEL | blind semantic-reachability replication | `tres-0010/wb-sentinel-b` |
| 2 | D-SENTINEL | blind verification-cheat replication | `tres-0010/wb-sentinel-d` |
| 3 | T-PROSECUTION | temporal/conflict prosecution | `tres-0010/wb-t-prosecution` |
| 4 | T-DEFENSE | temporal/conflict defense | `tres-0010/wb-t-defense` |
| 5 | A-PROSECUTION | action/favour prosecution | `tres-0010/wb-a-prosecution` |
| 6 | A-DEFENSE | action/favour defense | `tres-0010/wb-a-defense` |
| 7 | F-PROSECUTION | formation/lifecycle prosecution | `tres-0010/wb-f-prosecution` |
| 8 | F-DEFENSE | formation/lifecycle defense | `tres-0010/wb-f-defense` |
| 9 | I-PROSECUTION | implementation-assurance prosecution | `tres-0010/wb-i-prosecution` |
| 10 | I-DEFENSE | implementation-assurance defense | `tres-0010/wb-i-defense` |

## 3. Minimal operator instruction

For example:

> Execute TRES-0010 Wave B task 3 from the Mesopotamia-Sim repository. Read the Wave-B README, dispatch guide, and assigned task packet; follow them exactly. Use the declared frozen baseline and assigned return branch. Do not read the opposing Wave-B return or unrelated Wave-A returns.

Change only the task number.

## 4. Return metadata

Each return must record:

- task ID/role;
- canonical baseline ref + resolved SHA;
- model/configuration if visible;
- return branch/workspace;
- tools used;
- external research yes/no and key sources;
- assigned Wave-A reports read;
- opposing Wave-B return read before completion: must be **no**;
- unrelated Wave-A returns read: must be **no**.

## 5. AI-use rules

- Prefer precise repository retrieval over copying giant context bundles.
- Keep issue packets bounded; do not read the whole project unless the packet requires it.
- Before confirming a finding, attempt at least one serious disconfirmation route.
- Before dismissing a finding, reconstruct the smallest claimed counterexample and show exactly where it becomes invalid/resolved.
- Cite exact accepted artifacts/sections, not previous agent authority.
- Do not infer truth from severity labels, reviewer count, or confident prose.
- Do not design fixes unless the task explicitly asks.
- Stop when the assigned issue is adjudicated; do not expand into general architecture review.

## 6. Model diversity

If convenient, use a different capable model/provider or materially different reasoning configuration for prosecution and defense within a cluster.

If not, fresh contexts and asymmetric role prompts are still useful. Same-family outputs remain correlated evidence and are never treated as independent votes.
