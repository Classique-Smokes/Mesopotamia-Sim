# Wonder Gather — Cuneiform Package

**Prepared for:** `MacquePanoramix/Modular-RTS`  
**Repository snapshot checked:** `main` at `d9b5f4d4b15769132d781a9dcf3b0ea4e7876109` on 2026-09-23  
**Status:** external advisory material; read-only study; not project authority unless the Wonder Gather owner deliberately adopts it.

## What this package is

This package does **not** propose importing another project's bureaucracy into Wonder Gather.

The repository already has a functioning primitive harness:

- a real design source of truth in `Docs/GAME_VISION.md`;
- a concise agent agreement in `AGENTS.md`;
- technical continuity in `Docs/AI/UnityProjectContext.md`;
- a durable validation/failure history in `Docs/Validation.md`;
- milestone-specific human playtest guides;
- permanent PlayMode regression tests;
- a clear human design authority / AI implementation responsibility split.

The purpose of this package is to help Wonder Gather **recognize, simplify, and strengthen what it already evolved**.

## Read in this order

1. **`01_CUNEIFORM_TABLET_FOR_WONDER_GATHER.md`**  
   The main argument: what is already working, what should be preserved, what small additions are justified, and what should deliberately remain informal.

2. **`02_WONDER_GATHER_STARTER_TEMPLATES.md`**  
   Copyable templates for a tiny current-state router, design-rationale memory, milestone packets, validation receipts, protected-workspace rules, and bounded fresh review.

3. **`03_ADOPTION_PLAN_AND_TRIGGERS.md`**  
   A staged adoption path designed to prevent the harness itself from becoming the project.

## Uruk vocabulary

Some harmless roleplay is used as a mnemonic layer. It never replaces the engineering meaning.

| Uruk phrase | Plain meaning |
|---|---|
| **Game Director / king** | The human owner with creative and acceptance authority |
| **Chieftain / design witness** | The high-context AI carrying intent, rationale, and historical interpretation |
| **Smith / implementation agent** | The task-bounded AI or developer implementing and validating code |
| **Foreign priest** | A fresh independent technical reviewer used only for high-risk changes |
| **Tablet** | A durable project document |
| **King's workshop** | The human's local/uncommitted working state |
| **Green rune** | A passing test/build/validation result |

If the jokes ever obscure the rule, ignore the joke and keep the rule.

## Core recommendation in one paragraph

Keep Wonder Gather's existing loop:

**experience → jointly shape rule → smallest coherent prototype → technical verification → human playtest → adjustment**

Then add only enough structure to make that loop easier to resume:

- a tiny `CURRENT_STATE.md`;
- a bounded `DESIGN_RATIONALE.md`;
- one canonical local validation entry point plus a small receipt;
- a milestone template that separates design status from milestone status;
- explicit protection for uncommitted human workspace state;
- fresh independent review only when a likely error would be both **silent and consequential**.

Do **not** add mandatory PRs, universal CI gates, exhaustive acceptance matrices, or formal review for ordinary prototype tuning unless concrete project growth or actual failures justify them.

> *Do not civilize the barbarians. They already have customs. Give them better roads, clearer signposts, a standard measuring stick, and a fireproof archive box.*
