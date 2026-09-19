# Research Basis — Master Architect Operating Guide

**Status:** Supporting research note; non-authoritative  
**Purpose:** Preserve the external AI/software-engineering research used to revise the proposed Master Architect Operating Guide. The Guide distills durable project principles; this note preserves source provenance and current-industry context without making vendor-specific techniques constitutional.

## 1. Research question

How should a persistent Master Architect role operate in a long-horizon, AI-driven software/research project so that:

- the human Project Director can communicate conversationally rather than manage prompting/process details;
- specialist agents can be used efficiently without losing authority or coherence;
- context remains usable as the project grows;
- implementation remains trustworthy even when the Project Director is an inexperienced programmer;
- AI-generated drift and handoff failures are caught early;
- accumulated process knowledge compounds across sessions and models.

## 2. Strong convergences in current practice

### Repository-local, versioned knowledge beats one giant prompt

OpenAI reports that a large monolithic `AGENTS.md` became stale, crowded out task context, and was difficult to verify. Their agent-first repository instead uses a short orientation file as a table of contents into a structured, versioned knowledge base, with progressive disclosure and automated checks for documentation freshness. This supports the project's existing `START_HERE` plus modular canonical artifacts approach.

Source: OpenAI, “Harness engineering: leveraging Codex in an agent-first world,” 2026.  
https://openai.com/index/harness-engineering/

Anthropic similarly frames context as finite and recommends high-signal context, just-in-time retrieval, structured external organization, and progressive disclosure rather than loading entire corpora into working context.

Source: Anthropic, “Effective context engineering for AI agents,” 2025.  
https://www.anthropic.com/engineering/effective-context-engineering-for-ai-agents

### Long-running agents need incremental progress and explicit handoffs

Anthropic's experiments found that long-running coding agents failed when they tried to one-shot large projects or when future sessions had to guess at half-finished work. Incremental tasks, version history, progress artifacts, clean states, and explicit end-to-end verification improved continuity.

Source: Anthropic, “Effective harnesses for long-running agents,” 2025.  
https://www.anthropic.com/engineering/effective-harnesses-for-long-running-agents

### Human attention should be spent on intent, judgment, and feedback loops

OpenAI's agent-first engineering report describes humans shifting from manually producing code toward specifying intent, designing environments, creating feedback loops, prioritizing work, and validating outcomes. It also emphasizes that repeated agent failures should become improvements to tooling, documentation, guardrails, or observability rather than repeated manual prompting.

Source: OpenAI, “Harness engineering: leveraging Codex in an agent-first world,” 2026.  
https://openai.com/index/harness-engineering/

### Multi-agent systems are most useful for parallelizable research and independent exploration

Anthropic reports that subagents are particularly effective for breadth-first research because they create separate context windows and exploration trajectories. Their experience also stresses clear objectives, boundaries, output contracts, and deliberate orchestration. Multi-agent coordination has real cost and should not be used indiscriminately.

Source: Anthropic, “How we built our multi-agent research system,” 2025.  
https://www.anthropic.com/engineering/multi-agent-research-system

OpenAI's agent guidance similarly recommends maximizing a single agent first and adding multi-agent complexity when it solves a real coordination or tool-overload problem.

Source: OpenAI, “A practical guide to building agents.”  
https://openai.com/business/guides-and-resources/a-practical-guide-to-building-ai-agents/

### Clear task scope and acceptance criteria materially improve coding-agent work

GitHub's guidance for coding agents recommends well-scoped tasks, explicit problem statements, acceptance criteria, and repository-level instructions for build/test conventions. It also recommends research/planning before code changes for less certain work.

Source: GitHub Docs, “Best practices for using GitHub Copilot to work on tasks.”  
https://docs.github.com/en/copilot/tutorials/cloud-agent/get-the-best-results

### Evals and measurable definitions of success are a core AI-era practice

OpenAI summarizes its evaluation framework as `Specify → Measure → Improve`, emphasizing that reliable AI workflows require defining what good means and measuring it under relevant conditions rather than relying on qualitative confidence.

Source: OpenAI, “How evals drive the next chapter in AI for businesses,” 2025.  
https://openai.com/index/evals-drive-next-chapter-of-ai/

### Novice users need externalized verification, not only warnings to be cautious

Recent empirical work suggests that non-developers and novice developers may understand that AI-generated code has risks while still lacking equivalent ability to evaluate, debug, and verify it. This supports a workflow in which tests, acceptance scenarios, independent review, and reproducible checks carry the verification burden instead of assuming the Project Director can manually inspect generated code.

Sources:

- Fawzy, Tahir & Blincoe, “From Prompting to Verification: How Experience Shapes Vibe Coding Practices,” 2026. https://arxiv.org/abs/2605.24521
- Nguyen et al., “How Beginning Programmers and Code LLMs (Mis)read Each Other,” CHI 2024. https://doi.org/10.1145/3613904.3642706
- Gardella, Bolton & Riggs, “Relationships Between Trust, Compliance, and Performance for Novice Programmers Using AI Code Generation,” Human Factors, 2026. https://doi.org/10.1177/00187208261467254

### Established software engineering practice still matters

NIST's Secure Software Development Framework emphasizes documented requirements, provenance, tracked design decisions, verification, version-controlled source management, and automated security/reliability practices. The project does not need to adopt the SSDF wholesale, but these mature practices support treating AI-generated software as software that still requires disciplined lifecycle controls.

Source: NIST, Secure Software Development Framework (SSDF).  
https://csrc.nist.gov/projects/ssdf

## 3. Project-specific interpretation

The sources above do **not** prescribe our exact architecture or agent system. Their durable implications for this project are:

1. Keep canonical project knowledge modular, versioned, and retrievable.
2. Keep orientation short and use progressive disclosure.
3. Treat context as a scarce working resource.
4. Preserve continuity through artifacts rather than chat memory.
5. Break long implementation into verifiable increments.
6. Define observable success before asking agents to implement consequential work.
7. Use parallel agents when breadth/independence/verification justifies coordination cost.
8. Let specialists discover solutions before narrowing them to a comparison set.
9. Make recurring AI failures improve the project system itself.
10. Do not make a novice Director's ability to inspect code the primary quality gate.
11. Use mechanical checks and independent evidence to make important correctness claims legible.
12. Preserve human authority at the level of intent and consequential judgment while allowing AI to carry process detail and bounded execution.

## 4. Important limits

- Vendor engineering reports describe particular systems and may not generalize perfectly to this simulation project.
- Agent capabilities will continue changing quickly; the constitutional guide should therefore encode stable principles rather than model-specific tricks.
- The novice-programmer literature is still young; findings support stronger verification scaffolding but do not justify removing human judgment entirely.
- Multi-agent systems add cost and coordination failure modes; parallelism should be purposeful.
- No current research demonstrates that a long-horizon AI-driven project can remain coherent for years without active governance, versioned state, verification, and periodic cleanup.

## 5. Why this is a separate supporting artifact

The Master Architect Guide should remain durable even as today's models, vendors, tools, and preferred harnesses change. This research note preserves why the current proposal was written the way it was without forcing future Master Architects to treat 2025–2026 tool-specific techniques as permanent doctrine.
