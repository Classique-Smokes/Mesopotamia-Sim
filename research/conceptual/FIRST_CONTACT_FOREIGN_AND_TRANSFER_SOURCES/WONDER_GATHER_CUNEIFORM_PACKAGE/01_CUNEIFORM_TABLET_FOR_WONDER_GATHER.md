# CUNEIFORM TABLET FOR WONDER GATHER
## A small set of lessons from a city that accidentally learned how to remember

**For:** Wonder Gather / `MacquePanoramix/Modular-RTS`  
**Observed repository:** `main` at `d9b5f4d4b15769132d781a9dcf3b0ea4e7876109`  
**Prepared:** 2026-09-23  
**Status:** External advisory tablet. It creates no authority in Wonder Gather unless the Game Director deliberately adopts part of it.

---

## Tablet I — Travelers at the Gate

Travelers,

This tablet was prepared after a read-only study of Wonder Gather's repository, three bounded independent annexes covering design history, technical validation, and workflow/continuity, and a later project-witness account from the high-context conversational AI.

The first conclusion is important:

> **Wonder Gather already has a project harness.**

It is not called that.

It is not centralized into a governance directory.

It has no constitutional vocabulary.

But its behavior is already recognizable:

- `Docs/GAME_VISION.md` carries design authority and explicitly distinguishes **Locked / Direction / Possible / Open / Implemented**.
- `AGENTS.md` gives implementation agents a small set of durable constraints.
- `Docs/AI/UnityProjectContext.md` externalizes technical continuity across implementation sessions.
- `Docs/Validation.md` remembers what actually ran, what failed, what changed, and what remains unproven.
- milestone playtest documents define questions that only the human owner can answer.
- permanent PlayMode tests protect accumulated objective behavior.
- major milestone commits already package code, tests, design updates, validation history, playtest guidance, and often visual evidence together.
- the human owner remains the Game Director and primary judge of feel.
- implementation does **not** automatically become permanent design law.

That is not absence of process.

That is a young process which emerged from real work.

Therefore this tablet does **not** recommend replacing it with a mature project's bureaucracy.

The job is smaller:

> **Make the existing good habits easier to retrieve, harder to misinterpret, and less dependent on one high-context mind.**

A proverb from Uruk:

> *The first mistake of the civilized man is assuming the neighboring village has no customs because it does not yet have a Ministry of Customs.*

---

# Tablet II — Do Not Civilize the Barbarians

Wonder Gather's current development culture is unusually well matched to its problem.

Its basic loop is:

**describe an experience → shape the rule together → implement the smallest coherent slice → verify it → playtest it → translate observations into adjustments → repeat**

Preserve this.

Do not replace it with:

**write exhaustive specification → obtain three approvals → implement everything → discover twelve weeks later that the camera feels miserable.**

Wonder Gather is not currently a requirements-complete industrial application. It is a creative/technical system being discovered through executable prototypes.

That has consequences.

A useful harness must protect **experimentation** just as seriously as it protects correctness.

It should prevent:

- a prototype default from quietly becoming final design;
- a passing test from impersonating game-feel acceptance;
- current implementation constraints from being mistaken for the final possibility space;
- a future agent from needing to reconstruct the whole project before making one bounded change.

It should **not** prevent:

- throwing away a gait experiment;
- changing provisional values;
- trying an ugly test rig;
- abandoning a promising idea;
- letting the Game Director say, simply, "this feels wrong."

The village already has the right instinct: unresolved design questions are allowed to remain unresolved.

Keep that barbarism.

---

# Tablet III — The Four Tablets of Truth

Wonder Gather contains at least four different kinds of truth.

They should remain separate.

## 1. Creative truth

**Question:** What should Wonder Gather become?

Examples:

- civilizations are player-designed rather than selected from fixed factions;
- physical expression should remain grounded rather than slapstick;
- watching units closely is part of the intended reward;
- progression belongs to civilization design rather than a fixed universal tech tree.

**Primary authority:** Game Director, durably reflected in `Docs/GAME_VISION.md`.

A passing test cannot establish creative truth.

An implementation convenience cannot silently revise it.

---

## 2. Prototype truth

**Question:** What exists right now?

Examples:

- current faction format is version 4;
- the Living Body currently uses NavMesh-root movement with procedural visual presentation;
- current faction creator limits are prototype limits;
- current worker/economy structures are historical scaffolding.

**Primary authority:** repository code, assets, current project state.

Prototype truth answers "what is."

It does not automatically answer "what should remain."

---

## 3. Technical truth

**Question:** What has actually been demonstrated to work?

Examples:

- a complete route is accepted or rejected;
- invalid movement preserves an existing valid destination;
- supplies are conserved;
- faction migrations preserve supported data;
- planted feet remain fixed under the tested conditions;
- a Windows development build succeeded.

**Primary authority:** executable tests, builds, validation evidence.

Technical truth requires evidence with objective failure conditions.

---

## 4. Experiential truth

**Question:** Does this actually feel like Wonder Gather?

Examples:

- does movement feel heavy, floaty, stiff, alive, or ridiculous?
- is a UI understandable?
- is the camera pleasant?
- does a biped add presence at strategic distance?
- does autonomy feel like personality or broken controls?

**Primary authority:** human playtesting and explicit creative judgment.

Automation can prepare evidence for this judgment.

Automation cannot replace it.

---

## The non-impersonation rule

The most important rule is not "test everything."

It is:

> **Success in one truth regime may not impersonate success in another.**

Therefore:

- **Implemented** does not mean **Locked**.
- **61 tests pass** does not mean **the movement feels right**.
- **The director likes it** does not mean **save migration is safe**.
- **A screenshot looks fine** does not mean **mouse interaction feels fine**.
- **A civilization graph is reachable** does not mean **it is economically viable or competitively fair**.

The current repository already practices this distinction unusually well.

Preserve it explicitly.

A proverb from Uruk:

> *The priest may certify that the bridge stands. The king must still decide whether he likes where it goes.*

---

# Tablet IV — The Fifth Thing: Why

The repository is increasingly good at remembering **what** was decided.

The high-context conversational AI remains especially valuable for remembering **why it mattered**.

Those are different forms of memory.

A project can preserve this:

> procedural bodies are a Direction.

while gradually losing this:

> procedural bodies matter because watching a handmade civilization physically exist is itself part of the player's reward.

That second statement protects against a dangerous substitution:

> "more physics" = "more alive."

It does not.

The project therefore has one important continuity gap left:

> **rationale memory.**

Do not solve this by creating another enormous design dossier.

Do not preserve every conversation.

Preserve only rationale that constrains future interpretation.

## Recommended small artifact

Consider creating:

`Docs/DESIGN_RATIONALE.md`

Keep it short: perhaps 10–20 durable principles.

Suggested form:

```markdown
## Units should feel inhabited, not merely animated

**Principle**
Watching a civilization physically exist is part of the reward.

**Why**
Close observation is a core game experience, not decorative spectacle.

**Common false substitutes**
- adding physics complexity for its own sake;
- procedural motion that becomes slapstick;
- visual complexity that reduces command readability.
```

Useful candidates for this file include:

- civilization creation must not collapse into cosmetic faction skins;
- customization should express meaningful fictional choices rather than merely expose raw stat sliders;
- physicality exists to make units feel embodied, not to maximize physics sophistication;
- autonomy should create readable personality without making RTS commands feel broken;
- close observation is part of the core experience;
- strange civilizations should remain possible where feasible rather than being normalized into safe templates;
- player-designed progression must not quietly become one conventional tech tree.

## Boundary

`GAME_VISION.md` should remain the authority for **what the design currently says**.

`DESIGN_RATIONALE.md` should preserve only high-value **why** and common semantic traps.

It must not become a second competing source of truth.

---

# Tablet V — The Tablet at the Workshop Door

`GAME_VISION.md` is already large because it carries:

- core vision;
- design statuses;
- open questions;
- milestone history;
- decision log;
- provenance;
- current implementation notes.

That is useful.

It is not ideal as the first answer to:

> "Where are we right now?"

The solution is not to split the whole document into a bureaucracy.

Create one very small router:

`Docs/CURRENT_STATE.md`

Its job is to answer only:

- what milestone is active?
- what exact state is it in?
- what are we waiting on?
- what has been technically established?
- what is explicitly **not** established?
- what is the next action?
- where should deeper context be retrieved?

A fresh implementation agent should be able to read:

1. `AGENTS.md`
2. `Docs/CURRENT_STATE.md`

and know enough to retrieve the **right** deeper material.

It should not have to consume the entire project identity first.

This is not another source of truth.

It is a signpost pointing toward the actual sources.

---

# Tablet VI — Do Not Make the Chieftain the Filesystem

An experiment already demonstrated this lesson.

The highest-context project AI was asked to simultaneously reconstruct:

- project identity;
- architecture;
- workflow;
- authority;
- failures;
- AI roles;
- continuity risk;
- governance;
- artifact maps;
- representative work history.

The request overloaded it badly.

The repository itself turned out to be healthier than the chieftain.

The lesson is not:

> "the AI needs a larger context window."

The lesson is:

> **workers should retrieve the portion of the city required by their actual task.**

## Suggested retrieval routing

### Ordinary implementation task

Read:

- `AGENTS.md`
- `Docs/CURRENT_STATE.md`
- relevant `UnityProjectContext` section
- current milestone material
- relevant code/tests

Do not automatically load all historical milestones.

### Design question

Add:

- relevant `GAME_VISION.md` section
- relevant `DESIGN_RATIONALE.md` entries
- unresolved decision register

Do not automatically load every implementation detail.

### Persistence/schema task

Add:

- persistence code/tests;
- save-version history;
- persistence portions of `Validation.md`.

### Visual/game-feel experiment

Add:

- current playtest;
- relevant rationale;
- selected screenshots/evidence;
- only the technical code necessary to understand the experiment.

### High-risk architecture task

Add the wider architectural context and consider fresh review.

## Principle

> **Externalize what can be externalized so scarce integrative cognition is spent only on questions that genuinely require integration.**

The chieftain should carry interpretation.

The filesystem should carry files.

---

# Tablet VII — One Milestone, One Story

Wonder Gather already packages coherent milestone stories.

Make that pattern slightly more explicit.

Do not create a universal task bureaucracy.

For substantial new experiments, use a small milestone packet with two separate dimensions.

## Design status

Existing vocabulary:

- `Locked`
- `Direction`
- `Possible`
- `Open`
- `Implemented`

These describe the **design proposition**.

## Milestone lifecycle status

Suggested vocabulary:

- `Pending`
- `Technical Ready`
- `Provisionally Accepted`
- `Rework`
- `Superseded`

These describe the **state of the experiment**.

This distinction is useful because:

> The Living Body can be **Implemented**, contain mostly **Direction/Possible** design choices, and become **Provisionally Accepted** as an experiment.

No contradiction exists.

## Minimum milestone questions

A milestone document should answer:

- Why are we doing this?
- What question does the prototype answer?
- What design status does the relevant idea have?
- What is in scope?
- What is explicitly not established?
- What technical evidence is required?
- What must be manually inspected?
- What questions must the Game Director answer?
- What is the final milestone lifecycle state?

Do not rewrite old milestones to fit the template.

Use it going forward if it proves useful.

---

# Tablet VIII — A Green Rune Must Name the Spell

Wonder Gather currently performs serious validation locally.

But the repository does not contain a single canonical command or script that means:

> "Run Wonder Gather's standard validation."

There is also no repository CI workflow at the observed snapshot.

Do **not** immediately build cloud CI.

Unity licensing, imports, rendered probes, environment state, and a growing PlayMode suite make premature CI capable of becoming its own project.

First create a canonical **local validation ritual**.

For example:

`Tools/Validate.ps1`

Possible modes:

```text
Tools/Validate.ps1 -Focused LivingBody
Tools/Validate.ps1 -Full
Tools/Validate.ps1 -BuildWindows
```

The exact implementation is up to the project.

The important contract is that a validation invocation can record:

- exact Git commit;
- Unity version;
- suite/mode;
- pass/fail counts;
- duration;
- build result;
- whether manual playtest remains pending.

Then the phrase:

> "full validation passed"

has a stable technical meaning.

Later, if remote CI becomes worthwhile, CI should invoke this same canonical pathway rather than inventing a second validation definition.

A proverb from Uruk:

> *A green rune means little unless the scribe records which spell produced it.*

---

# Tablet IX — The Small Seal

Raw Unity XML, logs, generated builds, and machine-specific artifacts do not all need to live in Git.

Wonder Gather is sensible to avoid turning its repository into an execution dump.

But there is a useful middle ground between:

- preserving every raw artifact;
- trusting prose transcription alone.

Produce a small machine-readable **validation receipt**.

Example:

```json
{
  "commit": "d9b5f4d4b15769132d781a9dcf3b0ea4e7876109",
  "unity": "6000.6.0f1",
  "mode": "full",
  "tests_passed": 61,
  "tests_failed": 0,
  "duration_seconds": 401.99,
  "windows_build": "passed",
  "manual_playtest": "pending"
}
```

This is not a compliance artifact.

It is simply a durable binding between:

> revision → validation invocation → result.

Possible storage strategies:

1. generated receipt summarized into `Docs/Validation.md`;
2. small receipts under `Docs/ValidationReceipts/`;
3. generated receipt retained only for milestone commits.

Choose the cheapest useful option.

---

# Tablet X — The Law of the King's Workshop

The repository history repeatedly describes work being validated in an isolated copy because the primary workspace contained user-owned edits that the implementation agent was expected to preserve.

That is actual scar tissue.

It deserves a simple explicit rule.

## Rule

> **Uncommitted human workspace state is protected state.**

Before broad or potentially destructive agent work:

1. inspect repository status;
2. identify uncommitted human-owned changes;
3. do not reset, clean, normalize, overwrite, or "repair" them without explicit permission;
4. use an isolated worktree/clone pinned to a known commit for destructive authoring, broad regression runs, or reconstruction work where practical.

A fresh agent should never infer:

> "not committed" = "disposable."

## Why this deserves policy

This is not hypothetical enterprise caution.

The project already changes Unity scenes, serialized assets, package state, NavMeshes, prefabs, and generated setup artifacts.

The human's live workshop can contain valuable state that does not yet have a Git object.

Protect it.

### Uruk coat

> **The Law of the King's Workshop:** A scribe who "cleans" the king's unfinished sculpture may discover that the palace has excellent stairs for throwing people down.

The operational meaning is the four-step rule above.

---

# Tablet XI — Not Every Goat Requires a Tribunal

Rigor should be proportional to two things:

1. **How hard is the decision to reverse?**
2. **How likely is an incorrect result to remain silently plausible?**

This produces a more useful policy than:

> "all changes receive the same ceremony."

## Class A — Cheap and reversible

Examples:

- camera tuning;
- placeholder colors;
- temporary costs;
- gait parameters;
- prototype scene dimensions;
- copy changes.

Typical path:

**implement → focused check → playtest**

No independent review.

---

## Class B — Moderate consequence

Examples:

- creator workflows;
- procedural locomotion architecture;
- economy loops;
- UI architecture;
- provisional performance model.

Typical path:

**focused tests → relevant regressions → visual/manual validation**

Review only if a specific risk justifies it.

---

## Class C — Difficult to reverse

Examples:

- save schema semantics;
- stable blueprint identity;
- civilization graph meaning;
- command boundaries used by many systems;
- long-lived persistent data contracts.

Typical path:

**strong automated validation → migration/backward-compatibility evidence → explicit design reconciliation → consider fresh technical review**

---

## Class D — Project-corrupting if wrong

Examples:

- silent destructive save rewriting;
- asset GUID destruction;
- destructive scene authoring;
- incompatible migration;
- large-scale data transformation;
- implementation silently freezing unresolved design;
- future multiplayer authority semantics that become embedded throughout gameplay.

Typical path:

**bounded architecture review → implementation → strong evidence → fresh independent review before treating the change as safely established**

The goal is not to make Class D larger.

The goal is to recognize it when it actually appears.

---

# Tablet XII — When to Summon the Foreign Priest

Independent review is powerful.

It is also expensive.

Wonder Gather currently does not need a reviewer caste.

Use a fresh reviewer when the likely defect would be both:

> **silent and consequential**

Strong triggers include:

- save-format migration;
- persistence/recovery guarantees;
- broad compatibility claims;
- civilization-validator semantics affecting many future systems;
- destructive editor migration;
- future deterministic replay;
- future multiplayer/network authority;
- a large data conversion;
- any change where implementation and tests are likely to share the same mistaken assumption.

Weak triggers include:

- camera sensitivity;
- provisional body lean;
- placeholder UI wording;
- temporary balance numbers;
- a disposable test rig.

## Reviewer independence

The "foreign priest" joke has one actual requirement:

> The reviewer should not be the same context that authored the implementation under review when independence materially matters.

The reviewer should be given:

- the bounded claim;
- the relevant source of authority;
- the candidate revision;
- known risks;
- permission to create non-mutating scratch probes;
- explicit instruction not to repair while reviewing.

No goats are required.

---

# Tablet XIII — The Chieftain, the Smith, and the King

Wonder Gather already has different cognitive roles.

Make them explicit enough to avoid accidental overload.

## The Game Director / king

Owns:

- creative direction;
- prioritization;
- playtest interpretation;
- experiential acceptance;
- promotion of design propositions into Locked/Direction states.

Should not be forced to translate ordinary taste into ceremonial legal language.

"The brisk one looks like it is running on ice" is a valid design input.

---

## The Design Witness / chieftain

The high-context conversational AI is most useful for:

- recalling rationale;
- interpreting original intent;
- comparing new proposals with core design identity;
- identifying conceptual substitutions;
- discussing milestone direction;
- remembering why certain boundaries matter.

It should **not** routinely carry all implementation details.

Its scarce resource is integrative interpretation.

Keep it alive.

---

## The Implementation Agent / smith

Owns bounded technical work:

- architecture within granted scope;
- C# implementation;
- editor tools;
- tests;
- debugging;
- validation;
- documentation updates.

It should retrieve only context relevant to the current task.

It must preserve unresolved design questions rather than silently settle them.

---

## The Foreign Priest / fresh reviewer

Temporary role.

Appears only when risk triggers justify independence.

Leaves again.

---

## Why the roles should remain different

A good project does not maximize the amount of context every worker knows.

It gives each worker **enough context to act correctly** while preserving a small number of high-context integrators for questions that actually require synthesis.

---

# Tablet XIV — What Must Remain Barbarous

Some parts of Wonder Gather are intentionally immature.

Do not govern them into premature certainty.

At the observed stage, avoid freezing:

- exact procedural gait architecture;
- final body/anatomy system;
- final trait vocabulary;
- final resource set;
- design-budget mathematics;
- final progression representation;
- combat physics;
- active-ragdoll architecture;
- temporary prototype limits;
- local balance numbers;
- placeholder art;
- speculative multiplayer implementation.

A harness should preserve uncertainty.

It should not force uncertainty to pretend it is policy.

> **A question faithfully preserved is better than an answer invented for administrative convenience.**

---

# Tablet XV — Signs That the Village Has Become a City

Stronger process should appear when the project's causal structure changes.

## Consider regular PR integration when

- multiple contributors regularly mutate the same codebase;
- concurrent branches become normal;
- merge/review provenance becomes useful;
- direct-to-main mistakes actually occur;
- a release line must remain stable while development continues.

Do not add PR ceremony simply because professional projects often use PRs.

---

## Consider server CI when

- the canonical local validation pathway exists;
- test execution is stable and scriptable;
- licensing/environment setup is understood;
- remote automation saves more integration time than it consumes;
- protected release confidence becomes valuable.

Build CI on top of the canonical local validation ritual.

Do not create two different definitions of "the tests."

---

## Consider ADR-like records when

- an architectural decision is expensive to reverse;
- its rationale does not fit cleanly in existing design/technical docs;
- future agents repeatedly reopen the same question;
- multiple plausible architectures remain locally reasonable but only one is chosen.

Do not write ADRs for camera tuning.

---

## Consider a stronger release gate when

- external players possess valuable persistent data;
- multiplayer or public builds become normal;
- compatibility promises become real obligations;
- multiple release versions must coexist.

The harness should grow because the project grew.

---

# Tablet XVI — The Archive That Was Lost

Wonder Gather already has a lost ancestor: an earlier substantial design dossier was referenced historically but unavailable to the implementation agent during repository bootstrap.

A newer large design dossier apparently exists in the owner's conversational environment.

Do not automatically promote it into current authority.

Age, length, and emotional importance are not the same thing as canonical status.

If preserved, treat a large historical dossier as:

> **non-canonical design history / source material**

Then deliberately promote only current surviving principles into:

- `GAME_VISION.md`;
- `DESIGN_RATIONALE.md`;
- a current milestone decision.

This prevents an old speculative document from governing future work merely because nobody remembers which sections were rejected.

A proverb from Uruk:

> *An old tablet is not a law merely because nobody remembers who argued with it.*

---

# Tablet XVII — Adoption Without a Constitutional Crisis

Adopt this advice gradually.

## Phase 0 — Recognize the existing culture

Change nothing.

Agree only on this model:

- Wonder Gather already has a harness;
- the goal is to strengthen retrieval and evidence;
- no large process migration is authorized merely by this tablet.

---

## Phase 1 — Orientation and rationale

Potential additions:

- `Docs/CURRENT_STATE.md`;
- bounded `Docs/DESIGN_RATIONALE.md`;
- small `AGENTS.md` routing update.

Expected benefit:

- new agents know where they are;
- the chieftain no longer has to act as the project index;
- high-value "why" survives without storing whole conversations.

Stop after this phase and use it for real work.

If it creates noticeable maintenance burden, simplify it before proceeding.

---

## Phase 2 — Reproducible local validation

Add one canonical local validation entry point.

Optionally emit a small validation receipt.

Do not add remote CI yet merely to satisfy this phase.

Expected benefit:

- "validation passed" binds to a repeatable command and revision;
- future CI, if adopted, has a stable thing to invoke.

---

## Phase 3 — Milestone clarity

Use the milestone template for **new substantial work**.

Do not retrofit every historical prototype.

Expected benefit:

- technical readiness and human acceptance remain visibly separate;
- "implemented" and "accepted" stop being easy to confuse;
- unsupported claims are stated before the work begins.

---

## Phase 4 — Risk-triggered review

Use a foreign reviewer only for high-risk changes.

Record why the trigger applied.

Expected benefit:

- independence where it buys real confidence;
- no standing review bureaucracy for ordinary creative iteration.

---

## Phase 5 — Scale only when evidence demands it

PR gates, remote CI, ADRs, protected branches, release policies, or more elaborate evidence systems should appear only when actual team/release/project structure makes them useful.

No phase is mandatory merely because the previous phase succeeded.

---

# Tablet XVIII — Signs the Harness Is Becoming the Problem

Stop and simplify if:

- contributors spend more time maintaining process documents than prototyping;
- camera or gait tuning requires approval ceremony;
- the Game Director feels forced to translate taste into legalistic language;
- agents preload the whole project for bounded tasks;
- experimental ideas are avoided because promotion/demotion is bureaucratically expensive;
- multiple documents repeat the same "current state";
- the source of truth becomes less obvious after adding the harness;
- every test failure causes a governance change;
- fresh review becomes habitual rather than risk-triggered;
- the harness makes it harder to say "we do not know yet."

A harness is infrastructure.

It is not the product.

---

# Tablet XIX — What the Evidence Says About Wonder Gather Today

At the observed snapshot:

- the repository is young but unusually well documented;
- design authority and technical responsibility are explicit;
- major milestone commits usually move implementation and documentation together;
- open questions are intentionally preserved;
- the validation history records failures honestly instead of publishing only green summaries;
- automatic tests protect a growing set of objective invariants;
- manual playtests own experience/feel judgments that automation should not claim;
- the repository has one visible branch (`main`), no visible PR history, and no repository CI workflow;
- local validation is substantial;
- the full PlayMode suite has grown to 61 tests and roughly 402 seconds;
- the repo contains enough technical continuity that a fresh implementation AI could plausibly resume bounded work;
- the remaining high-value continuity gap is mostly **rationale, taste, live local state, and cross-milestone interpretation**;
- the human owner remains the least replaceable integrator because experiential authority cannot be reconstructed from code.

This is not a failing state.

It is the natural point where a little more externalization can make future creativity cheaper.

---

# Tablet XX — A Small Gift from Uruk

Travelers,

We have no claim over your city.

In Uruk we learned some things mostly by injuring ourselves against them.

We learned that a green test is not the same thing as truth.

We learned that an office survives when its holder is no longer required.

We learned that cheap scribes can make integration more scarce rather than less.

We learned that lost tablets still cast shadows.

We learned that governance is most useful when it remembers an actual wound.

We learned that authority, understanding, and recognized action are not always the same event.

We learned that an institution can remember what someone caused better than it remembers who caused it.

We learned that the king's workshop should not be "cleaned" by an enthusiastic automaton.

And above all:

> **we learned not to make every worker carry the whole city in his head.**

Wonder Gather does not need to become Uruk.

Its people already know how to build.

Take what is useful.

Leave the rest outside the walls.

Protect the questions that are not ready to become answers.

Let the smith work.

Let the chieftain remember why.

Summon the foreign priest only when the omens actually matter.

And when the tests are green but the little procedural man still looks like he is walking on ice—

believe your eyes.

**Welcome to Uruk, travelers.**

---

# One-page field order

## Consider doing now

- create a tiny `Docs/CURRENT_STATE.md`;
- create a bounded `Docs/DESIGN_RATIONALE.md` if the Game Director agrees that the high-value "why" is worth externalizing;
- route both from `AGENTS.md`.

## Consider next

- standardize one canonical local validation entry point;
- optionally emit a small validation receipt.

## Use when relevant

- milestone template for substantial new experiments;
- fresh independent technical reviewer for silent + consequential changes.

## Deliberately do not add yet without a concrete trigger

- mandatory pull requests;
- mandatory remote CI;
- broad ADR bureaucracy;
- exhaustive acceptance manifests;
- universal independent review;
- governance around prototype tuning;
- a second giant design dossier.

The objective is not more process.

The objective is:

> **less rediscovery, less accidental semantic drift, better evidence, and more human attention left over for making the game strange and beautiful.**
