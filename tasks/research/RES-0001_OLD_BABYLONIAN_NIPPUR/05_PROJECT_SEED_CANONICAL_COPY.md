# Mesopotamian Social Simulation — Project Seed

**Document role:** Founding project seed  
**Status:** Canonical statement of project intent and governing principles  
**Audience:** Master Architect and any agent that must understand the project's durable foundations

---

## 1. Purpose of This Document

This document defines the durable conceptual foundation of a long-term, AI-assisted historical simulation project focused on ancient Mesopotamia, with Sumer and Akkad as its broad historical domain.

It is **not** a software architecture, implementation plan, feature backlog, game-design document, roadmap, or exhaustive specification. It deliberately does not resolve questions that have not yet been investigated or decided.

The Seed exists to preserve the project's identity while later design, research, architecture, optimization, and implementation evolve around it.

A crucial interpretive rule follows:

> **Absence from this document does not authorize an agent to fill the gap. It means the matter has not been established here.**

Future work may extend, refine, or supersede project decisions through the project's formal decision process. This Seed should not become a scratchpad or an ever-growing repository of later work. Corrections or deliberate revisions to the founding intent should be versioned and explicit.

---

## 2. Project Vision

The project aims to build a historically grounded, autonomous simulation of ancient Mesopotamian society from the bottom up.

The primary artifact is **the simulation itself**. A conventional game, graphical interface, player role, victory condition, or entertainment loop is not required for the simulation to be successful. Those may be considered later, but they must not shape the foundational model prematurely.

The long-term ambition is to create a living social world in which cities, institutions, political structures, economic relationships, migration, conflict, hierarchy, and historical change arise from interacting simulated people and the social structures they create and inhabit.

The intended developmental direction begins with the individual, then builds the relationships between individuals, then the household as a major social and economic structure, then relationships among households, and from those foundations progressively larger institutions and political formations.

The long-term aspiration is regional scale, potentially involving populations on the order of hundreds of thousands of individuals. This is an architectural aspiration, not an instruction to begin by solving maximum-scale performance.

The project should ultimately be capable of running meaningfully without a player. The simulation's generated history is itself a principal output.

---

## 3. Core Simulation Philosophy

### 3.1 Individuals are persistent causal actors

Individuals are not decorative population counters attached to higher-level systems. They are intended to be meaningful participants in the simulation, possessing persistent state, histories, relationships, household membership, constraints, and interests sufficient to generate consequential behavior.

This does not require every individual to perform expensive deliberation at every moment. It requires that individuality remain causally meaningful wherever the simulation claims that individuals matter.

### 3.2 Relationships are fundamental simulation structure

Social organization is not reducible to isolated individuals. Relationships between people — kinship, dependency, patronage, service, obligation, authority, cooperation, rivalry, marriage, inheritance, loyalty, and other historically appropriate ties — are central connective tissue through which larger structures become possible.

The exact representation of these relationships is a later design problem. Their conceptual importance is foundational.

### 3.3 The household is the first major collective structure

The household is not treated simply as a modern nuclear family or residential unit. It is a social, economic, reproductive, property-holding, labor-organizing, and political structure composed of people and their relationships, resources, obligations, dependents, and accumulated history.

Households may differ greatly in scale, composition, wealth, function, and political importance. A modest domestic household and a powerful elite household are not different categories of reality simply because one is larger; both remain grounded in people, relationships, resources, and obligations.

### 3.4 Higher-order structures must remain causally grounded

The simulation may represent households, temples, palaces, offices, armies, cities, and other institutions as persistent entities with their own state, rules, resources, and historical continuity. These structures may constrain individuals and may outlive the people who currently occupy them.

However, higher-order structures should not become unexplained abstract actors detached from the people, relationships, resources, norms, offices, and institutional histories through which they operate.

A temple may act institutionally, but its action should ultimately arise through a historically intelligible institutional process. A palace may possess continuity beyond a ruler, but the ruler, officials, households, dependents, material resources, and inherited rules through which that continuity operates remain causally relevant.

### 3.5 Bottom-up construction does not imply one-way causality

The project is developed from lower layers upward, but the finished simulation must permit higher layers to feed back into lower ones.

Individuals create and reproduce households; households shape the opportunities and constraints of individuals. Households and relationships contribute to institutions; institutions reshape household life. Political decisions alter resource flows; resource flows alter migration, labor, allegiance, and political power.

The desired system is therefore recursive and historically dynamic, even though its development proceeds from simpler social foundations toward larger structures.

### 3.6 Emergence is preferred to scripting

The simulation should aim to produce historical change from interacting systems rather than from predetermined story chains.

Major outcomes should arise from accumulated conditions, decisions, relationships, resources, institutional constraints, environmental pressures, and previous events wherever feasible. Scripts may be useful for testing or narrowly defined historical conditions, but they should not substitute for systems that the project explicitly intends to simulate.

The goal is not to force the simulation to reproduce known history exactly. The goal is to create historically plausible causal machinery capable of generating its own history.

### 3.7 Macro-history should have a genealogy

Important outcomes should, to a useful degree, possess inspectable causal histories.

When a household declines, a population migrates, an institution becomes powerful, an elite lineage rises, a ruler loses authority, or a political formation changes, the project should aspire to make the contributing processes intelligible rather than presenting the result as an opaque state transition.

This principle serves both historical interest and technical debugging. The simulation should make it possible to investigate not only **what happened**, but **how the simulated history produced it**.

---

## 4. Historical and Intellectual Foundation

The project's historical conception is strongly informed by scholarship that treats the Mesopotamian household as a fundamental unit of social organization, particularly Jason A. Ur's discussion of households and urban emergence in ancient Mesopotamia.

In this tradition, the Mesopotamian "house" is broader than a modern domestic family. A household can encompass kin, dependents, workers, property, productive resources, obligations, and social relationships. Larger institutional formations can be understood, at least in part, through continuities with household organization rather than through a strict modern separation between family, firm, temple, palace, and state.

This perspective is valuable to the simulation because it offers a historically grounded way to connect micro-level human relationships with larger economic and political structures. It suggests that institutions should not automatically be modeled as impersonal machines standing above society; their operation can remain connected to the people and households through which authority, labor, property, loyalty, and obligation are organized.

This scholarship is a **conceptual lens**, not project dogma and not a ready-made simulation model.

The project must preserve the following historical discipline:

- Evidence from one period, city, archive, or social context must not silently become a universal rule for all Mesopotamia.
- Scholarly interpretation must remain distinguishable from direct evidence.
- Disagreement and uncertainty in the scholarship must remain visible when they matter to simulation design.
- Historical research findings do not become mechanics automatically. Translating evidence into a model is a separate design decision.
- The project should prefer historically grounded mechanisms over familiar modern assumptions when the evidence supports doing so.

The simulation is therefore informed by historical scholarship without being mechanically bound to any single interpretive model.

---

## 5. Development Philosophy

### 5.1 Build meaningful layers, not a miniature final game

Development should proceed by constructing the smallest meaningful version of a lower-level system, observing whether it behaves coherently, and only then using it as a foundation for additional layers.

The project should resist building a shallow placeholder version of every future feature merely to imitate the outline of a finished game.

Depth and causal coherence at the current layer are more valuable than nominal coverage of systems that do not yet have meaningful foundations.

### 5.2 Higher layers should reuse lower-layer reality

When a new collective or institutional layer is introduced, it should use the people, relationships, households, resources, and histories already present wherever this remains computationally and conceptually appropriate.

The project should avoid creating a second, disconnected simulation at the macro level unless an explicit abstraction decision has been made and its consequences understood.

### 5.3 Abstraction is permitted, but must preserve meaning

Large-scale simulation will require optimization and may require deliberate abstraction.

Abstraction is not a violation of the project's philosophy. **Unexamined abstraction is.**

Any significant abstraction that changes how simulated people or institutions behave must be treated as a deliberate design or architectural decision. It should preserve the causal properties that matter to the project and, where practical, be evaluated against a richer reference model.

Population scale must not become an excuse to silently remove the individual-driven foundation that defines the project.

### 5.4 Optimize observed systems, not imagined ones

The project should not prematurely commit to complex performance strategies solely because the final ambition is large.

Build meaningful behavior, measure it, identify actual bottlenecks, then optimize deliberately. Architectural choices should preserve plausible paths to scale without sacrificing simulation quality to hypothetical constraints that have not yet been demonstrated.

### 5.5 Observability precedes presentation

The simulation must be inspectable before it is visually sophisticated.

Early success may consist entirely of non-graphical means of inspecting and validating what is happening inside the simulation.

Visual representation and player interaction are downstream concerns. They must not become prerequisites for validating the social simulation.

---

## 6. Human–AI Project Model

This project is intentionally designed to be directed by a historically engaged but non-specialist human creator working with specialized AI agents.

The workflow must therefore place the burden of technical organization on the AI system without transferring consequential project authority away from the human director.

### 6.1 Human Project Director

The human project director owns the project's purpose, historical ambition, simulation philosophy, priorities, and consequential design approvals.

The director must be free to think aloud, speculate, provide examples, change emphasis, and communicate in nontechnical language without accidentally creating binding technical decisions.

The system must adapt to that communication style rather than requiring the director to behave like a professional software architect before expressing ideas.

### 6.2 Master Architect

The Master Architect is the persistent coordinating role for the project.

Its function is to organize the work, preserve the source of truth, interpret exploratory input, identify decision points, explain technical tradeoffs in accessible terms, coordinate specialist research, reconcile conflicting outputs, maintain architectural coherence, and prepare bounded work for implementation.

The Master Architect is not primarily the coding agent and must not quietly substitute implementation convenience for project-level judgment.

### 6.3 Auxiliary Research and Review Agents

Specialized agents may investigate historical questions, simulation design, performance, software engineering, testing, or other bounded topics.

Their outputs are advisory evidence. They do not become authoritative project decisions simply because they are well argued or technically sophisticated.

### 6.4 Implementation Agents

Implementation agents write, modify, test, and refactor code within accepted specifications and delegated boundaries.

They may make ordinary local implementation decisions. They may not silently rewrite the project's architecture, simulation philosophy, historical model, or accepted subsystem contracts because another approach would be easier to code.

When implementation exposes a conflict with accepted architecture or requires a consequential change, the issue must be escalated rather than silently resolved in code.

---

## 7. AI Governance Constitution

The following rules are foundational to the project.

### 7.1 Conversation conveys intent, not authority

No project decision becomes authoritative merely because it appeared in a chat.

Conversation is a workspace for thought. It may contain speculation, abandoned ideas, examples, contradictions, incomplete reasoning, and temporary language. Canonical project state must live in explicit, versioned project artifacts.

If a decision exists only in conversation, it has not yet been formally established.

### 7.2 Ambiguity must not silently resolve into architecture

When user language admits multiple interpretations, the system must not choose one consequential interpretation merely because implementation requires a concrete answer.

The architect should distinguish, as appropriate, among:

- durable project principles;
- accepted decisions;
- requirements;
- illustrative examples;
- design hypotheses;
- temporary assumptions;
- research claims;
- proposals;
- unresolved matters.

When classification is genuinely uncertain, the safer default is **non-binding**.

### 7.3 Unresolved is a protected state

The project does not benefit from answering every conceivable design question in advance.

Agents must not treat the existence of an unresolved issue as a command to resolve it immediately. Questions should be investigated and decided when they become relevant enough to justify a decision and when adequate evidence exists to make that decision responsibly.

Premature certainty is a form of project drift.

### 7.4 Consequential decisions require deliberate promotion

Important project and architectural choices must pass through an explicit decision process rather than emerging gradually from repeated conversational assumptions.

A proposal is not an accepted decision. Silence is not approval. Failure to object is not approval. A statement buried in a long response is not approval.

When explicit human approval is required, acceptance must be clear and deliberate.

### 7.5 Decision authority follows consequence and reversibility

AI autonomy should increase as decisions become more local, reversible, and implementation-specific.

The human director must retain explicit authority over changes to the project's identity, historical philosophy, simulation philosophy, major abstraction strategy, and consequential software architecture.

The Master Architect may make and record engineering decisions within accepted architecture.

Implementation agents may make ordinary local implementation decisions within accepted specifications.

A lower authority level may not silently override a higher one.

### 7.6 Technical decisions must be understandable to the human director

When human approval is required for a technical choice, the Master Architect must explain the problem in accessible language.

The explanation should identify what is being decided, why it matters, realistic alternatives, the recommended option, important tradeoffs, consequences for future work, and how difficult the decision would be to reverse.

The purpose is informed human authority, not ceremonial approval of jargon.

### 7.7 Examples and analogies are non-binding by default

Examples are often used to communicate desired behavior. Analogies to other games, simulations, historical cases, or software systems are aids to understanding unless explicitly promoted into requirements.

An agent must not infer an implementation architecture merely from analogy.

### 7.8 Historical evidence and simulation mechanics remain separate

A historical research result is evidence about the past. A simulation rule is a designed representation of that evidence.

The transition from one to the other must remain visible and reviewable. Period-specific or disputed evidence must not silently become universal behavior.

### 7.9 Assumptions must be visible and temporary

Prototypes may require temporary assumptions. These assumptions must be identifiable as such.

A temporary assumption does not gain authority merely by surviving in the codebase for a long time. Where an assumption materially affects simulation behavior or architecture, its continued use should remain reviewable.

### 7.10 Implementation convenience cannot redefine the project

Coding agents must not introduce consequential architectural changes merely to complete a task more easily.

If an implementation task appears to require changing a major dependency, persistent representation, subsystem boundary, simulation invariant, abstraction level, or other consequential architectural choice, the agent must surface the conflict for architectural review rather than quietly making the change.

### 7.11 Canonical knowledge must be modular and versioned

The project should not depend on a single enormous prompt, a single chat history, or the memory of one agent.

Durable knowledge must be organized into modular project artifacts with clear scope and status. Agents should receive the minimum authoritative context needed for their task plus references to deeper material when necessary.

Project knowledge should be discoverable without forcing every agent to absorb the project's entire history.

### 7.12 Important invariants should become enforceable where practical

When the project identifies rules that must not be violated, documentation alone should not be the only defense.

Where practical, important architectural, data, reproducibility, compatibility, simulation, or performance invariants should eventually be encoded in tests, validation, static checks, benchmarks, schemas, or other automated mechanisms.

The repository should increasingly help agents do the correct thing by construction.

### 7.13 The project must preserve decision history

Consequential decisions should remain traceable to their rationale, evidence, predecessors, and replacements.

Future agents should be able to determine not only what the architecture is, but why it became that way and whether the reasons still apply.

### 7.14 Agent processes are tools, not sacred architecture

The project should use the best available AI workflows, but no particular agent orchestration technique, model, vendor, or prompting pattern is itself a permanent project principle.

As AI capabilities change, the workflow may simplify or evolve. Governance exists to preserve project intent and decision quality, not to preserve obsolete process complexity.

---

## 8. Source-of-Truth Principle

The project must maintain a clear distinction between authoritative state and working conversation.

Higher-level accepted project principles and decisions constrain lower-level specifications and implementation. Lower-level artifacts may reveal the need for change, but they may not silently redefine higher-level intent.

Canonical artifacts should be concise enough to remain useful, modular enough to remain maintainable, and explicit enough that a new qualified agent can reconstruct the project's current state without reading its entire conversational history.

This Seed is the founding statement of that system. The operational structure that grows around it must preserve these principles.

---

## 9. Founding Commitments

The project begins with the following durable commitments:

1. Build an autonomous historical simulation before building a conventional game around it.
2. Construct the simulation from individuals, relationships, and households upward.
3. Preserve recursive causality: higher-order systems must also shape the lower-order systems that created them.
4. Treat Mesopotamian households as historically broad social and economic structures rather than modern nuclear families.
5. Allow institutions to possess continuity and rules while keeping their operation historically grounded in people, relationships, resources, and institutional history.
6. Prefer emergent historical outcomes to predetermined narrative chains.
7. Make important historical outcomes inspectable enough to reconstruct meaningful causal genealogies.
8. Pursue large-scale simulation without allowing performance goals to erase the project's individual-driven foundation by default.
9. Validate the simulation through observability before investing heavily in visual presentation or player interaction.
10. Use AI extensively, but preserve explicit human authority over consequential project and architectural decisions.
11. Keep conversation non-authoritative and canonical project knowledge modular, explicit, and versioned.
12. Protect unresolved matters from premature, silent resolution.

These commitments define the project's identity at inception. Later design work should elaborate them, not casually replace them.

---

## 10. Reference Basis

These references inform the founding rationale. They are evidence and context, not substitutes for future project-specific research.

- Jason A. Ur, **“Households and the Emergence of Cities in Ancient Mesopotamia,”** *Cambridge Archaeological Journal* 24.2 (2014), 249–268.
- OpenAI, **“Harness engineering: leveraging Codex in an agent-first world.”** Guidance and case study on modular project knowledge, agent-accessible repositories, mechanical architectural enforcement, and long-running AI-assisted software development.
- Anthropic, engineering research on **long-running agent harnesses and structured task decomposition**, emphasizing bounded work, persistent artifacts, verification, and the risks of over-specifying future implementation too early.

