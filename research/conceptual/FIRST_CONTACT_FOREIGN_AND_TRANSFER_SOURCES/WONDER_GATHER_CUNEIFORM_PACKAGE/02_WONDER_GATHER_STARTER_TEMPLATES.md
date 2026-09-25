# Wonder Gather Harness — Starter Templates
## Copy only what earns its keep

**Status:** advisory templates. These are deliberately small. Do not create every file merely because a template exists.

---

# Template A — `Docs/CURRENT_STATE.md`

```markdown
# Wonder Gather — Current State

**Updated:** YYYY-MM-DD
**Repository head:** `<commit>`
**Current milestone:** `<name>`
**Milestone lifecycle:** Pending | Technical Ready | Provisionally Accepted | Rework | Superseded

## Current question

What are we trying to learn or decide with this milestone?

## Waiting on

- ...

## Technically established

- ...

## Human/experiential acceptance still pending

- ...

## Explicitly not established

- ...

## Current design decisions affected

- `Locked`: ...
- `Direction`: ...
- `Possible`: ...
- `Open`: ...

## Next action

One concrete next action, or:

**Next milestone not yet chosen.**

## Retrieve deeper context only if needed

- Design authority → `Docs/GAME_VISION.md`
- Design rationale → `Docs/DESIGN_RATIONALE.md`
- Technical architecture → `Docs/AI/UnityProjectContext.md`
- Validation evidence/history → `Docs/Validation.md`
- Current playtest → `<path>`
```

### Rule

Keep this file short.

If it starts becoming a second `GAME_VISION.md`, delete material until it becomes a router again.

---

# Template B — `Docs/DESIGN_RATIONALE.md`

```markdown
# Wonder Gather — Design Rationale

This file preserves a small number of high-value reasons that help future
contributors interpret the design correctly.

It does not replace `GAME_VISION.md`.

Only add rationale that prevents a plausible future conceptual substitution.

---

## <Principle name>

**Principle**

<One or two sentences.>

**Why it matters**

<The experiential/system reason.>

**Common false substitutes**

- ...
- ...

**Related design authority**

- `Docs/GAME_VISION.md` — <section>
```

## Example

```markdown
## Physicality serves embodiment, not physics spectacle

**Principle**

Procedural and physical systems should make units feel like embodied inhabitants
while preserving command readability and grounded tone.

**Why it matters**

Watching the civilization physically exist is part of the player's reward.

**Common false substitutes**

- adding physics complexity merely because it is impressive;
- accepting slapstick instability as "emergence";
- sacrificing strategic readability for close-up spectacle.

**Related design authority**

- `Docs/GAME_VISION.md` — Movement and combat
- `Docs/GAME_VISION.md` — Watch it become alive
```

### Admission test

Before adding an entry, ask:

> Would losing this "why" make a competent future contributor likely to build the wrong thing while believing they were following the design?

If no, it probably does not belong here.

---

# Template C — Milestone packet

```markdown
# Milestone — <name>

**Owner:** Game Director
**Implementation:** <agent/person>
**Design status:** Locked | Direction | Possible | Open
**Lifecycle:** Pending

## Why this milestone exists

...

## Question this prototype should answer

...

## In scope

- ...

## Explicitly not established

- ...

## Existing systems that must remain intact

- ...

## Technical acceptance

- focused test(s):
- regression test(s):
- build/import requirement:
- data compatibility requirement, if any:

## Visual/manual inspection

- ...

## Game Director playtest questions

- ...

## Evidence to retain

- validation summary:
- screenshots/captures if useful:
- validation receipt:
- relevant commit:

## Result

Pending | Technical Ready | Provisionally Accepted | Rework | Superseded

## Follow-up decision

...
```

### Important distinction

`Implemented` is a **design-status fact**.

`Technical Ready` or `Provisionally Accepted` is a **milestone lifecycle fact**.

Do not merge those concepts.

---

# Template D — Validation receipt

Example JSON:

```json
{
  "schema": "wonder-gather-validation-receipt-v1",
  "repository": "MacquePanoramix/Modular-RTS",
  "commit": "<full sha>",
  "unity": "6000.6.0f1",
  "mode": "focused|full|build",
  "focus": "LivingBody",
  "tests_passed": 0,
  "tests_failed": 0,
  "tests_skipped": 0,
  "duration_seconds": 0.0,
  "windows_build": "not-run|passed|failed",
  "manual_playtest": "not-required|pending|accepted|rework",
  "notes": []
}
```

## Minimum requirements

The receipt should be:

- generated from the validation invocation where practical;
- bound to an exact Git commit;
- small enough to inspect;
- explicit about tests that were not run;
- explicit that manual acceptance may remain pending.

Do not claim raw artifacts exist in Git if they remain local.

---

# Template E — Canonical validation contract

The exact implementation can be PowerShell, a Unity entry point, or another small tool.

The desired interface is conceptually:

```text
Tools/Validate.ps1 -Focused LivingBody
Tools/Validate.ps1 -Full
Tools/Validate.ps1 -BuildWindows
```

The validation entry point should:

1. print the current commit;
2. print/check the expected Unity version;
3. run the requested suite;
4. preserve exit status;
5. print pass/fail counts and elapsed time;
6. optionally generate a validation receipt;
7. never silently convert a partial run into a "full validation passed" claim.

Do not build cloud CI before this local meaning is stable.

---

# Template F — The Law of the King's Workshop

Suggested addition to `AGENTS.md`:

```markdown
## Protected local workspace

Uncommitted human-owned workspace state is protected.

Before broad or destructive work:

- inspect repository status;
- preserve existing human modifications;
- do not reset, clean, overwrite, normalize, or discard them without explicit permission;
- prefer an isolated Git worktree/clone pinned to a known commit for destructive
  authoring, broad validation, reconstruction, or migration work.

"Uncommitted" does not mean "disposable."
```

This is the plain rule.

Optional cultural annotation elsewhere:

> **The Law of the King's Workshop:** do not "clean" unfinished work belonging to the Game Director.

---

# Template G — Retrieval routing for `AGENTS.md`

Suggested lightweight routing section:

```markdown
## Context routing

Read `Docs/CURRENT_STATE.md` before substantial work.

Then retrieve only the context needed for the task:

- design meaning / open questions → `Docs/GAME_VISION.md`
- high-value design rationale → `Docs/DESIGN_RATIONALE.md`
- technical architecture / historical implementation context →
  `Docs/AI/UnityProjectContext.md`
- execution evidence / known limitations → `Docs/Validation.md`
- current human acceptance questions → the current milestone playtest file

Do not load the complete project history for bounded work unless the task genuinely
requires project-wide integration.
```

---

# Template H — Risk-trigger checklist

Before deciding whether a change needs fresh independent review:

```markdown
## Fresh-review trigger

Would an incorrect implementation be:

### Silent?
- [ ] likely to pass ordinary smoke testing
- [ ] likely to be repeated by tests sharing the same assumption
- [ ] capable of preserving plausible-looking output while changing meaning

### Consequential?
- [ ] persistent player data affected
- [ ] destructive asset/data mutation
- [ ] difficult-to-reverse architecture boundary
- [ ] broad compatibility claim
- [ ] multiplayer/network authority semantics
- [ ] large migration/transformation
- [ ] core civilization-graph meaning
- [ ] unresolved design could be silently frozen into infrastructure

If the answer is strongly "yes" in both categories, commission a fresh bounded
technical reviewer.

Otherwise prefer ordinary implementation validation.
```

---

# Template I — Foreign-priest review packet

Plain engineering meaning: fresh independent technical review.

```markdown
# Independent Review — <change>

**Candidate revision:** `<sha>`
**Review scope:** <bounded claim>
**Do not modify the candidate.**

## Authority / intended behavior

- <source>
- <source>

## Claims to test

1. ...
2. ...

## Known risk

...

## Required reviewer behavior

- inspect the candidate independently;
- treat implementation reports as claims, not conclusions;
- use scratch/public-boundary probes if useful;
- distinguish implementation defect from unclear design authority;
- return PASS or BLOCK with concrete evidence;
- do not repair during review.

## Return

- candidate identity;
- commands/environment;
- evidence;
- counterexamples, if any;
- final PASS/BLOCK.
```

Do not use this for ordinary tuning.

---

# Template J — Design-witness / chieftain prompt

Use when the high-context conversational AI is needed for interpretation rather than repository implementation:

```text
Act as Wonder Gather's design witness.

Do not reconstruct the entire repository.

Question:
<one bounded design/interpretation question>

Retrieve only the relevant current design/rationale material if available.

Distinguish:
- current canonical design;
- historical context;
- your interpretation/inference;
- unresolved questions.

Do not turn remembered preference into a new Locked decision.

Return:
1. relevant design truth;
2. relevant rationale;
3. possible conceptual substitutions/drift risks;
4. questions that require the Game Director.
```

The chieftain is not the filesystem.

---

# Template K — Implementation-agent / smith prompt

```text
Implement the bounded milestone/task described in:
<path or prompt>

First read:
- AGENTS.md
- Docs/CURRENT_STATE.md
- only the routed context relevant to this task.

Preserve unresolved design questions.
Do not promote prototype defaults into design authority.

Before mutation:
- inspect working-tree status;
- protect human uncommitted state;
- use an isolated worktree/clone where appropriate.

Validate using the project's canonical local validation path.

Return:
- exact revision;
- files changed;
- focused validation;
- relevant regression/full validation;
- build result where required;
- validation receipt;
- remaining manual Game Director acceptance questions.

Do not claim experiential acceptance from automated evidence.
```

---

# Final warning

Templates are tools, not obligations.

The project should copy only the pieces that solve a current problem.

> *A tablet nobody needs is merely a heavier wall.*
