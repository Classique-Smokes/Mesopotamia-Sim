# Master Architect Rulebook Restructuring Plan

**Status:** WORKING / NON-AUTHORITATIVE  
**Date:** 2026-09-21  
**Execution gate:** Do not restructure constitutional governance until TRES-0010 Wave B is reconciled and the Project Director explicitly approves the constitutional change.

## 1. Problem

`governance/MASTER_ARCHITECT_GUIDE.md` is the always-loaded operating doctrine for every Master Architect instance.

It is currently about 23.6 KB with 19 top-level sections. Its content is strong, but it now carries three different kinds of material at one retrieval level:

1. durable always-on Master Architect doctrine;
2. detailed procedures for recurring work modes;
3. rules that are better encoded in task templates/checklists/mechanical guardrails.

Several detailed procedures also have specialized canonical homes already:

- `INTERPRETATION_PROTOCOL.md`
- `AUTHORITY_AND_DECISION_PROMOTION.md`
- `ARCHITECTURE_DEVELOPMENT_POLICY.md`
- `ARCHITECTURE_ESCALATION_RULES.md`
- `REVIEW_AND_DRIFT_AUDIT.md`

Adding TRES-0010 lessons directly to the Guide would increase permanent context/salience load and duplicate rules.

## 2. Research basis

Current AI-agent practice strongly supports restructuring by progressive disclosure rather than growing one global instruction manual.

### OpenAI

OpenAI's agent-first repository experience reports that one large `AGENTS.md` crowded out task context, made every rule seem equally important, became stale, and was difficult to verify. Their preferred pattern is a short map into a structured repository knowledge base with progressive disclosure and mechanical checks.

OpenAI's practical agent guidance also recommends:

- using existing operating documents as the basis for agent routines;
- breaking dense resources into smaller clear steps;
- defining explicit actions/outputs;
- capturing important edge cases;
- using layered guardrails and escalating high-consequence uncertainty.

### Anthropic

Anthropic's context-engineering guidance treats context as finite and vulnerable to pollution. It recommends just-in-time retrieval and progressive disclosure.

Anthropic Agent Skills formalize a three-level pattern:

1. small always-loaded metadata sufficient to decide relevance;
2. task-specific operating instructions loaded when relevant;
3. deeper references/resources loaded only when needed.

### GitHub

GitHub recommends that repository-wide instructions be short, self-contained, and broadly applicable because they are supplied to every relevant interaction. It explicitly supports path/task-specific instructions to avoid overloading global instructions.

GitHub's review of 2,500+ agent instruction files emphasizes:

- specific role;
- exact commands/actions;
- clear boundaries;
- focused specialist agents rather than vague general helpers.

### Project interpretation

The project should preserve vendor-neutral Markdown governance, but adopt the same architecture:

**small durable core → trigger metadata → task/work-mode protocol → deeper evidence/reference → mechanical enforcement where practical.**

## 3. Design goals

The refactor should:

1. preserve every existing operative Master Architect commitment unless explicitly superseded;
2. make the always-loaded constitutional core substantially smaller and higher-signal;
3. assign each detailed recurring procedure one canonical owner;
4. make specialized protocols discoverable from explicit triggers;
5. prevent contradictory duplicate instructions;
6. move repeatable completion requirements into templates/checklists where practical;
7. move enforceable invariants into mechanical checks when the relevant infrastructure exists;
8. keep the system vendor/tool neutral;
9. make a fresh Master Architect load only the procedures relevant to the current work;
10. remain simple enough that protocol selection itself does not become a new orchestration burden.

## 4. Target rulebook architecture

### Layer 0 — machine-discoverable repository entry

`AGENTS.md`

Purpose:

- repository hard rules;
- exact retrieval entry;
- build/test commands once implementation exists;
- direct Master Architect pointer.

It should remain short.

### Layer 1 — Master Architect constitutional core

`governance/MASTER_ARCHITECT_GUIDE.md`

Purpose:

> Define the enduring cognitive/authority posture of the Master Architect and tell it which specialized protocol to load for recurring work modes.

Target characteristics:

- broadly applicable to nearly every Master Architect task;
- principles and control loop, not detailed procedure;
- explicit trigger table;
- no duplicated operational checklists;
- links to deeper protocols;
- preserve final operating test.

No hard byte/line target should override semantic preservation, but a **rough 35–50% reduction** from the current 23.6 KB is a useful signal that detailed procedure actually moved out rather than being copied.

### Layer 2 — recurring work-mode protocols

Existing protocol owners:

- Director-input interpretation → `INTERPRETATION_PROTOCOL.md`
- authority/promotion/navigation closure → `AUTHORITY_AND_DECISION_PROMOTION.md`
- architecture-development choices → `ARCHITECTURE_DEVELOPMENT_POLICY.md`
- implementation/architecture conflict → `ARCHITECTURE_ESCALATION_RULES.md`
- periodic/integration drift review → `REVIEW_AND_DRIFT_AUDIT.md`

Proposed new protocols, subject to TRES-0010 closure:

#### A. `AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md`

Owns recurring rules for:

- PROJECT-CONTEXT vs INDEPENDENT-CONTEXT;
- anti-anchoring/source restriction;
- when parallel/multi-agent work is justified;
- context/blindness/frozen-baseline design;
- model/capability selection;
- mutation/workspace isolation;
- return schemas/provenance;
- consensus is not evidence;
- adversarial prosecution/defense/sentinel use;
- Master Architect reconciliation;
- research artifact placement.

#### B. `SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`

Owns the recurring transition from accepted design to delegated implementation:

- semantic-object lifecycle closure;
- parameter validity-domain closure;
- undefined-condition inventory;
- transition/composition/conflict closure;
- nested-action completion semantics;
- authority/precondition race analysis;
- risk-scaled formalization/model-checking trigger;
- future-slice seam preservation;
- exact implementation-slice applicability matrix;
- independent/protected verification authority;
- oracle independence;
- held-out/generated evidence policy;
- implementation packet readiness;
- release/no-release gate.

This should not become a general formal-methods framework. It is a consequence-scaled checklist/protocol for high-leverage specification→implementation boundaries.

### Layer 3 — task templates / checklists

Recurring requirements that can be made explicit at task-construction time should move into templates instead of remaining reminders in the core Guide.

Likely changes after TRES-0010:

#### Implementation packet template

Separate:

- Accepted authority
- Required non-authoritative supporting context
- Verification authority
- Working engineering guidance

Add explicit tables for:

- scope / out-of-scope;
- verification applicability:
  - requirement/card/assertion;
  - REQUIRED / DEFERRED / N/A;
  - rationale;
  - oracle/evidence;
  - mutants/metamorphic companions where relevant;
- future seams that must be preserved without implementing later features;
- local decisions versus escalation triggers.

#### Research packet template

Add optional consequential-adversarial mode fields:

- frozen baseline;
- permitted source set;
- sibling-return blindness;
- dedicated branch;
- provenance metadata;
- minimum falsification attempts;
- sentinel/replication status.

Do not burden ordinary small research tasks with those fields unless the research mode requires them.

### Layer 4 — mechanical enforcement

Only where maturity/cost justify it:

- navigation/link freshness checks;
- acceptance/applicability manifest validation;
- oracle dependency checks;
- architecture/layer dependency checks;
- build/test/analyzer commands;
- protected acceptance evaluation;
- stale-governance/doc gardening.

The Guide should state the principle that recurring failures should move toward environmental enforcement; it should not enumerate every future linter.

## 5. Proposed core Guide outline

### 1. Prime directive and role split

Retain:

- Director owns intent/consequential approvals;
- Master Architect owns process/synthesis/coherence;
- Master Architect is not primarily the coder;
- own synthesis, delegate bounded volume.

### 2. Core control loop

Retain a compact form of:

Interpret → Classify → Retrieve → Choose work mode → Synthesize → Propose → Promote → Execute → Verify → Leave clean state.

For detailed promotion mechanics, link to Authority/Decision Promotion.

### 3. Director interaction

Retain universal principles:

- conversation is not authority;
- do not over-question;
- do not outsource technical judgment upward;
- communicate synthesis;
- learn from Director corrections.

Detailed interpretation taxonomy lives only in Interpretation Protocol.

### 4. Authority and responsibility

Retain:

- four authority levels summary;
- research/agent consensus/code do not create authority;
- accepted records constrain; working material explains.

Detailed promotion/status/navigation procedure lives only in Authority/Decision Promotion.

### 5. Critical path, abstraction, and simplicity

Retain:

- highest-leverage unresolved problem;
- critical / parallel / deferred;
- don't move lower prematurely;
- smallest faithful next step.

Architecture-specific development/optimization rules remain in Architecture Development Policy.

### 6. Synthesis and delegation principle

Retain:

- Master Architect owns reconciliation/big-picture judgment;
- delegate bounded volume;
- agent count is not evidence;
- preserve uncertainty.

Detailed context modes/anti-anchoring/multi-agent mechanics move to Agent Delegation and Research Protocol.

### 7. Context, continuity, and repository memory

Retain:

- repository over chat memory;
- progressive disclosure;
- retrieve smallest authoritative slice;
- leave recoverable long-horizon state;
- current source of truth should be discoverable.

Detailed navigation-promotion procedure remains elsewhere.

### 8. Verification and learning principle

Retain:

- agent confidence is not verification;
- Director is not manual code-review system;
- verification intensity scales with consequence;
- recurring failures should improve environment;
- prefer mechanical enforcement when mature.

Detailed pre-implementation assurance moves to Specification-to-Implementation Assurance Protocol.

### 9. Universal stop / escalation rule

Retain a compact universal stop condition.

Link to Architecture Escalation Rules for full criteria and escalation payload.

### 10. Work-mode trigger map

A small table maps situations to protocols/templates.

### 11. Final operating test

Retain the current final questions, possibly tightened after TRES-0010.

### 12. Evolution and research basis

Keep only:

- durable principles over vendor-specific tactics;
- link to `MASTER_ARCHITECT_GUIDE_RESEARCH_BASIS.md`;
- constitutional amendments require deliberate approval.

## 6. Current-section migration map

| Current Guide section | Proposed disposition |
|---|---|
| 1 Prime directive | KEEP in core |
| 2 Control loop | KEEP compact; detailed promotion link out |
| 3 Director interaction | KEEP principles; interpretation taxonomy/procedure in Interpretation Protocol |
| 4 Authority/decision discipline | KEEP summary; detailed promotion in Authority/Decision Promotion |
| 5 Critical path/abstraction | KEEP in core |
| 6 Own synthesis/delegate | KEEP principle; detailed delegation moves to new Delegation Protocol |
| 7 Delegation context | MOVE detailed rules to new Delegation Protocol |
| 8 Anti-anchoring | MOVE to new Delegation Protocol |
| 9 Research returns/evidence | SPLIT: core evidence principle; detailed reconciliation/provenance in Delegation Protocol |
| 10 Implementation from contracts | SPLIT: core principle; detailed release/readiness in new Assurance Protocol + template |
| 11 Verification | SPLIT: core principle; detailed assurance/checks in Assurance Protocol/templates |
| 12 Context scarce | KEEP compact in core |
| 13 Long-horizon survival | KEEP compact in core |
| 14 Repeated AI failure | KEEP core principle; specific triggers/checklists/mechanics elsewhere |
| 15 Agent capability choice | MOVE detail to Delegation Protocol; keep consequence principle |
| 16 Automatic stop | KEEP summary; full list in Escalation Rules |
| 17 Quick-reference defaults | REPLACE with work-mode trigger map; move procedure detail to owners |
| 18 Final operating test | KEEP |
| 19 Research basis/evolution | KEEP compact link |

## 7. Protocol metadata standard

Each recurring protocol should begin with lightweight metadata analogous to skill/agent progressive-disclosure metadata:

- **Status / authority**
- **Purpose**
- **Load when**
- **Do not load merely because**
- **Inputs / prerequisite authority**
- **Expected output**
- **Escalation / stop condition**
- **Related template(s)**

This metadata should be small enough that the Master Architect can select the right protocol from the core trigger map without reading them all.

Do not adopt vendor-specific Skills/custom-instruction formats as canonical governance. Adapter files may later point to these Markdown protocols if a tool benefits from them.

## 8. Single-owner / anti-conflict rule

Every detailed operational rule should have one primary canonical owner.

The core Guide may restate a **short invariant**, but not duplicate the full procedure.

Example:

Core:
> Consequential approved material must be promoted losslessly and made discoverable. Follow Authority and Decision Promotion.

Owner:
`AUTHORITY_AND_DECISION_PROMOTION.md` contains inventory/reconciliation/navigation details.

This reduces drift and avoids conflicting instruction sets.

## 9. Refactor execution sequence

Do not edit the constitutional Guide incrementally while Wave B is unresolved.

### Phase R0 — TRES-0010 closure

1. finish Wave B;
2. classify durable process lessons;
3. obtain Director approval for any new constitutional/process doctrine.

### Phase R1 — freeze and inventory

1. freeze a rulebook-refactor baseline;
2. inventory every operative statement in current Guide;
3. assign temporary migration IDs;
4. mark each statement:
   - KEEP_CORE;
   - MOVE_EXISTING_PROTOCOL;
   - MOVE_NEW_PROTOCOL;
   - MOVE_TEMPLATE/CHECKLIST;
   - MECHANICAL_ENFORCEMENT_CANDIDATE;
   - SUPERSEDED;
5. no rule may disappear without explicit disposition.

### Phase R2 — create/repair specialized owners first

1. draft new Delegation/Research Protocol;
2. draft new Specification-to-Implementation Assurance Protocol;
3. repair existing protocol boundaries where duplication exists;
4. amend task templates;
5. add trigger metadata to recurring protocol files.

The old Guide remains authoritative during this phase.

### Phase R3 — draft compact core Guide

Rewrite only after all moved content already has a destination.

The new Guide references protocol owners rather than duplicating them.

### Phase R4 — lossless reconciliation

Create a permanent reconciliation table:

`old guide commitment → new location → preserved/superseded rationale`

Run the same anti-compression standard used for SFL promotion.

### Phase R5 — fresh-agent governance eval

Before constitutional promotion, test the new instruction architecture with fresh agents against a frozen branch.

Suggested scenarios:

1. Director exploratory brainstorm → retrieves core + Interpretation Protocol only.
2. Director approves consequential decision → retrieves Authority/Promotion and updates navigation.
3. Open technical/adversarial research → retrieves Delegation/Research Protocol and uses correct context mode.
4. Architecture recommendation → retrieves Architecture Development Policy.
5. Subsystem ready for implementation → retrieves Assurance Protocol and produces closure/applicability manifest.
6. Coding task discovers architecture conflict → stops and retrieves Escalation Rules.
7. Major milestone drift review → retrieves Review/Drift Audit.
8. Ordinary low-risk reasoning task → does **not** unnecessarily load every protocol.

Acceptance:

- correct protocol selection;
- no missed mandatory protocol;
- no conflicting instructions;
- no need for chat history;
- no material operative rule lost;
- lower irrelevant-context load than old Guide.

Use at least one fresh-agent retrieval red team.

### Phase R6 — constitutional promotion

After Director approval:

1. promote new Guide/protocols together;
2. update DEC-0002 / constitutional references as governance requires;
3. update `AGENTS.md`, `START_HERE`, and governance navigation;
4. archive/reconcile old-guide state through Git history rather than leaving a competing current copy;
5. verify fresh-agent retrieval after merge.

## 10. Evaluation criteria

The refactor is successful if:

- every current operative Guide commitment is reconciled;
- the always-loaded Guide is materially smaller/high-signal;
- specialized procedure has one owner;
- a fresh Master Architect can select the right protocol from task context;
- ordinary tasks do not require reading all governance files;
- consequential workflows still surface all required stop/approval/verification rules;
- templates encode recurring task-specific requirements;
- no tool/vendor-specific instruction format becomes governance authority;
- the repository remains comprehensible without this conversation.

## 11. Risks of restructuring

### Over-segmentation

Too many tiny protocol files create retrieval failure and conflict.

Mitigation: split by **recurring work mode**, not individual rule.

### Hidden mandatory protocol

A protocol may exist but never be loaded.

Mitigation: explicit core trigger map + protocol metadata + fresh-agent evals.

### Rule loss through compression

Mitigation: temporary commitment inventory and permanent lossless reconciliation.

### Duplicate conflicting ownership

Mitigation: single-owner rule and drift audit.

### Vendor lock-in

Mitigation: canonical Markdown governance; tool-specific instruction/skill adapters remain secondary.

### New bureaucracy

Mitigation: protocols are consequence-triggered; routine low-risk work uses core Guide only.

## 12. Research references

- OpenAI, *Harness engineering: leveraging Codex in an agent-first world* (2026).
- OpenAI, *A practical guide to building AI agents*.
- Anthropic, *Effective context engineering for AI agents* (2025).
- Anthropic, *Equipping agents for the real world with Agent Skills* (2025).
- Anthropic, *Building effective agents* (2024).
- GitHub Docs, *About customizing GitHub Copilot responses*.
- GitHub Blog, *How to write a great agents.md: Lessons from over 2,500 repositories* (2025).
- GitHub Docs, repository/path-specific/agent instruction guidance.

## 13. Current recommendation

Do not immediately rewrite the Guide.

Finish TRES-0010 Wave B, then use this plan as the migration scaffold. The likely end state is:

**short constitutional core + explicit protocol trigger map + a small number of recurring work-mode protocols + stronger task templates/checklists + mechanical enforcement for mature invariants.**

That is both more AI-legible and more faithful to the current Guide's own progressive-disclosure/context-discipline principles than continuing to grow the monolith.
