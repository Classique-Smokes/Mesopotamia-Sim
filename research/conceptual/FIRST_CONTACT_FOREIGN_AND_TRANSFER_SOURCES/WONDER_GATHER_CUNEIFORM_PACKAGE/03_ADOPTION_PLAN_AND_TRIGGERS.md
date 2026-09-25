# Wonder Gather — Adoption Plan and Escalation Triggers
## How to receive the tablets without founding an empire

**Status:** advisory. The Game Director may adopt, modify, defer, or reject any step.

---

# 1. Purpose

The desired outcome is not "more governance."

It is:

- faster orientation for fresh agents;
- less dependence on one high-context conversational AI;
- clearer separation of design, implementation, verification, and human acceptance;
- more reproducible validation claims;
- protection of valuable local human work;
- stronger scrutiny only where errors are silent and consequential.

The existing development loop should remain recognizable.

---

# 2. Recommended adoption sequence

## Phase 0 — Discussion only

No repository changes.

The Game Director and design witness decide whether these observations fit the project.

Questions:

- Does the four-truth model describe current practice?
- Would a tiny current-state router reduce repeated explanation?
- Is preserving a small amount of design rationale worth the maintenance cost?
- Is local workspace protection already understood well enough, or should it be explicit?

**Exit condition:** owner agrees on which Phase 1 items are useful.

---

## Phase 1 — Orientation, not governance

Potential files:

- `Docs/CURRENT_STATE.md`
- `Docs/DESIGN_RATIONALE.md`

Potential `AGENTS.md` edits:

- route through `CURRENT_STATE`;
- retrieve deeper context by task type;
- protect uncommitted human workspace.

### Keep Phase 1 small

Target:

- `CURRENT_STATE.md`: roughly one screen to two screens;
- `DESIGN_RATIONALE.md`: initial 5–10 principles, not a design encyclopedia;
- `AGENTS.md`: still short.

### Observe for several milestones

Ask:

- Does a fresh implementation agent orient faster?
- Does the chieftain answer fewer repository-state questions?
- Does `CURRENT_STATE` stay current?
- Are rationale entries preventing actual confusion?
- Is there duplication?

If the files become stale or burdensome, simplify or remove them.

---

## Phase 2 — Canonical local validation

Only after Phase 1 settles.

Create one stable local entry point for validation.

Start with the smallest useful scope:

- focused test execution;
- full PlayMode execution;
- optional Windows build.

Bind results to:

- commit;
- Unity version;
- mode;
- pass/fail;
- elapsed time;
- build status.

Optionally produce a compact receipt.

### Do not require CI

Remote CI remains a separate future decision.

The objective of Phase 2 is to make:

> "I ran full validation"

mean the same thing to every implementation session.

---

## Phase 3 — Milestone template for new substantial work

Do not retrofit history.

Try the template on the next meaningful experiment.

Review after use:

- Did it clarify what the prototype was supposed to prove?
- Did "Explicitly not established" prevent overclaiming?
- Did separating design status from milestone lifecycle help?
- Did the Game Director find the playtest questions useful?
- Was the document cheaper than the confusion it prevented?

If not, shrink it.

---

## Phase 4 — Risk-triggered fresh review

Do not create a permanent reviewer role.

When a change crosses the fresh-review trigger:

1. freeze/identify the exact candidate revision;
2. give a fresh reviewer a bounded packet;
3. ask for independent evidence/counterexamples;
4. keep review and repair separate where independence matters.

Good early candidates might be:

- save-schema v5 migration;
- a major persistence rewrite;
- a civilization-graph semantic expansion;
- destructive asset/data migration.

Bad candidates:

- camera tuning;
- body lean;
- HUD copy;
- provisional costs.

---

## Phase 5 — Scale machinery only when project structure changes

### Pull requests

Adopt regular PR integration when one or more become true:

- multiple contributors work concurrently;
- branch conflicts become normal;
- review provenance matters;
- stable/release lines coexist with development;
- direct-main mistakes happen often enough to justify a gate.

Until then, direct coherent milestone commits may remain appropriate.

### CI

Adopt remote CI when:

- local validation is canonical and scriptable;
- remote Unity setup/licensing is stable enough;
- CI catches errors earlier or saves human integration time;
- releases or multiple contributors make enforcement valuable.

### ADRs

Use decision records when:

- an architectural choice is difficult to reverse;
- multiple options are locally reasonable;
- rationale does not fit existing design/technical docs;
- future agents keep reopening the issue.

### Release governance

Add stronger release discipline when:

- external players have valuable saves;
- public multiplayer exists;
- compatibility promises become durable;
- multiple versions must be supported.

---

# 3. Risk matrix

| Change | Reversibility | Silent-error risk | Default treatment |
|---|---|---:|---|
| Camera sensitivity | Very high | Low | Implement + playtest |
| Placeholder visuals | Very high | Low | Implement + visual check |
| Body gait tuning | High | Medium experiential | Focused test + playtest |
| Creator UI flow | Medium | Medium | Tests + manual UX |
| Economy loop | Medium | Medium | Tests + regressions |
| Procedural body architecture | Medium | Medium | Tests + rendered/manual review |
| Command boundary | Low | Medium/high | Strong regression; architecture discussion |
| Civilization graph semantics | Low | High | Strong tests + explicit design reconciliation + consider fresh review |
| Stable blueprint IDs | Low | High | Strong tests + migration review |
| Faction save schema migration | Low | Very high | Migration matrix + fresh review |
| Destructive scene/data migration | Very low | Very high | Isolated candidate + fresh review |
| Multiplayer authority model | Very low | Very high | Architecture review before broad implementation |

This table is guidance, not law.

---

# 4. Health metrics for the harness

Do not measure harness success by file count.

Look for these outcomes:

## Orientation

A fresh implementation agent can answer within minutes:

- What are we building now?
- What is waiting on the human?
- What is explicitly unproven?
- Which documents matter for this task?

## Continuity

The chieftain can disappear for one milestone without the technical project becoming unrecoverable.

## Rationale

A future contributor can understand why core principles matter without reading old chats.

## Validation

A statement like "full validation passed" names a repeatable procedure and exact revision.

## Human authority

The Game Director can still give normal feedback in normal language.

## Creative freedom

Possible/Open ideas remain cheap to explore and cheap to abandon.

## Evidence honesty

Automated validation continues to state what it cannot establish.

---

# 5. Failure conditions for the harness

Simplify or roll back process if:

- `CURRENT_STATE` routinely disagrees with the real project;
- agents update three files with the same information;
- the Game Director avoids experimentation because paperwork follows;
- implementation agents spend substantial context learning governance rather than the task;
- every milestone receives independent review;
- validation receipts become audit theater rather than useful provenance;
- CI becomes harder to maintain than the defects it catches;
- PRs become mandatory even though no one is meaningfully reviewing them;
- the chieftain is again asked to carry repository state, implementation detail, design history, and process auditing simultaneously.

A harness can fail by becoming too weak.

It can also fail by becoming the new integration bottleneck.

---

# 6. Suggested first meeting after receiving this package

The Game Director and design witness can answer only these five questions:

1. Should we create `CURRENT_STATE.md`?
2. Which 5–10 design rationales would be genuinely dangerous to lose?
3. Should "uncommitted human workspace = protected state" become explicit in `AGENTS.md`?
4. Is there a repeatable local Unity validation command today, and if not, is creating one worth doing now?
5. What upcoming change is likely to be the first one that genuinely deserves a fresh independent reviewer?

Stop there.

Do not plan the whole governance future.

---

# 7. Final adoption principle

> **Governance should remember real wounds, not imagined ones.**

Wonder Gather already has useful scars:

- lost early design context produced stronger repository design memory;
- Unity/package problems produced pinned technical context;
- real tests caught lifecycle, persistence, validation-order, and physical-invariant defects;
- rendered probes exposed UI and locomotion problems logic tests could not see;
- isolated copies protected human work.

Build from those.

Do not manufacture bureaucracy for disasters that have never happened.

---

# 8. The Uruk covenant, translated into plain engineering

**Uruk version**

> Let no scribe carry the whole city.  
> Let no green omen claim more than it observed.  
> Let no smith turn a provisional shape into law.  
> Let no servant clean the king's unfinished workshop.  
> Summon the foreign priest when silent errors can poison future generations.  
> Preserve the wound only if remembering it makes future work safer.

**Plain version**

- retrieve task-specific context;
- keep evidence claims scoped;
- preserve design uncertainty;
- protect uncommitted human state;
- use independent review selectively for high-risk work;
- institutionalize lessons only when failures justify them.

That is enough civilization for now.
