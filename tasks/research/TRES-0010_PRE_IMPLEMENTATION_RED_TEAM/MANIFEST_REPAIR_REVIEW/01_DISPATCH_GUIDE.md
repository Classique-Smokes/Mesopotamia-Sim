# TRES-0010 Manifest Repair Review — Dispatch Guide

## 1. Frozen baseline

All three tasks use:

- ref: `tres-0010-manifest-repair-review-baseline`
- SHA: set after the review packets are committed.

Do not use moving `main`.

## 2. Task mapping

| Human task # | Task ID | Primary burden | Return branch |
|---:|---|---|---|
| 1 | TRES-0010-MRR-A | cross-cutting boundary completeness / Slice-1 status audit | `tres-0010/mrr-boundary` |
| 2 | TRES-0010-MRR-B | semantic-subordination / wording-scope audit of manifest | `tres-0010/mrr-semantic-scope` |
| 3 | TRES-0010-MRR-C | grain-denominated ingress exhaustiveness / D4 validation matrix | `tres-0010/mrr-grain-ingress` |

## 3. Minimal operator instruction

> Execute TRES-0010 Manifest Repair Review task 1 from the Mesopotamia-Sim repository. Read the program README, dispatch guide, and assigned task packet and follow them exactly. Use the frozen review baseline and assigned return branch. Do not read sibling returns or the prior manifest BLOCK report. Do not modify canonical files.

Change only the task number.

## 4. Return location

Each task packet declares one exact return path under:

`research/technical/TRES-0010/returns/`

Agents may add only that return file on their assigned branch.
