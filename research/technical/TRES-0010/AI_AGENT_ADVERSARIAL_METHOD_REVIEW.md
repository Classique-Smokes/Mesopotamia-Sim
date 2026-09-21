# TRES-0010 Method Review — Adversarial Research with AI Agents

**Status:** SUPPORTING RESEARCH / ADVISORY  
**Date:** 2026-09-21  
**Purpose:** Compare the TRES-0010 commission design against current practice for multi-agent research, adversarial evaluation, and AI-agent red teaming.

## 1. Sources reviewed

Primary/practice sources:

- Anthropic, *Building effective agents* (2024): https://www.anthropic.com/engineering/building-effective-agents
- Anthropic, *How we built our multi-agent research system* (2025): https://www.anthropic.com/engineering/multi-agent-research-system
- OpenAI, *How evals drive the next chapter in AI for businesses* (2025): https://openai.com/index/evals-drive-next-chapter-of-ai/
- NIST CAISI, *Strengthening AI Agent Hijacking Evaluations* (2025, updated 2025): https://www.nist.gov/news-events/news/2025/01/technical-blog-strengthening-ai-agent-hijacking-evaluations
- NIST CAISI, *Cheating On AI Agent Evaluations* (2025): https://www.nist.gov/caisi/cheating-ai-agent-evaluations
- NIST, *ARIA Evaluation Planning Manual* (2026): https://doi.org/10.6028/NIST.AI.200-3
- NIST AITE program / blind evaluation environment (2026): https://pages.nist.gov/ai-technology-evaluation/
- Oh et al., *From Belief Entrenchment to Robust Reasoning in LLM Agents* (TACL / arXiv 2503.16814)
- Wu et al., *Can LLM Agents Really Debate?* (arXiv 2511.07784)

These sources inform the **research method**, not Mesopotamia simulation semantics.

## 2. Practices strongly supported by current evidence

### 2.1 Section complex review into genuinely different parallel tasks

Anthropic distinguishes parallel "sectioning"—different calls owning different considerations—from simple repeated voting. Their multi-agent research system reports that clear, specialized subtask objectives reduce duplication and coverage gaps.

**TRES-0010 fit:** strong. The ten Wave-A tasks are differentiated by falsification objective rather than being ten copies of "review the project."

### 2.2 Give every worker a precise objective, boundaries, output format, and tool/source guidance

Anthropic reports that vague delegation causes duplication, scope drift, and inconsistent coverage.

**TRES-0010 fit:** strong. Each commission defines question, why-now, context, evidence standards, boundaries, output, and authority.

### 2.3 Keep parallel workers' contexts separate and synthesize centrally

Separate context windows reduce path dependence and let workers explore independently. Anthropic's research architecture uses a lead/orchestrator to synthesize specialized subagent outputs.

**TRES-0010 fit:** strong. The Master Architect retains synthesis/authority; Wave-A workers are advisory.

### 2.4 Persist worker outputs directly as artifacts

Anthropic specifically recommends direct subagent output to durable files/artifacts to reduce the "game of telephone."

**TRES-0010 fit:** strong, provided agents write only their assigned return artifacts or return them in chat when isolated repository writes are unavailable.

### 2.5 Do not treat agent consensus or majority vote as truth

Recent multi-agent-debate research finds that shared-model groups can reinforce common errors and that majority pressure can suppress independent correction. Perspective diversity and intrinsic reasoning quality matter more than simply adding participants.

**TRES-0010 fit:** strong. The program explicitly says agreement count is not evidence and uses differentiated roles.

### 2.6 Delay cross-agent debate until independent first-pass findings exist

The same debate research warns about homogenization/belief entrenchment. Independent first-pass reports preserve more diversity than letting reviewers see each other's conclusions early.

**TRES-0010 fit before amendment:** good but incomplete. Source restrictions blocked earlier TRES conclusions for some tasks, but agents could potentially read sibling Wave-A returns after those appeared. This should be prohibited until each initial report is locked.

### 2.7 Red-team evaluations should adapt to the system under test

NIST CAISI reports that attacks tailored to the current system can expose weaknesses missed by older/static attacks. It also recommends task-specific analysis rather than relying only on aggregate rates.

**TRES-0010 fit:** strong. Tasks target the exact accepted artifacts and IMP-0001; Wave B is contingent on what Wave A discovers.

### 2.8 Repeated attempts matter because agent outputs vary

NIST CAISI found materially different attack success rates when attacks were repeated. AI-agent review is also stochastic enough that one "no finding" pass should not be treated as proof of absence.

**TRES-0010 improvement:** add a small sentinel-replication step on high-leverage tasks even if Wave A reports no blocker.

### 2.9 Use explicit rubrics and outcome schemas

OpenAI evaluation guidance emphasizes defining "great," using concrete rubrics, testing realistic/edge cases, reviewing logs, and keeping domain-expert/human oversight. Anthropic likewise evaluates research outputs against explicit rubrics rather than prescribing one exact path.

**TRES-0010 fit:** strong. The common finding schema/severity classification functions as a review rubric while permitting different reasoning paths.

### 2.10 Human/domain synthesis remains important

OpenAI advises human/domain-expert auditing even when LLM graders scale evaluation. NIST ARIA combines multiple testing modes rather than reducing trustworthiness to one automated signal.

**TRES-0010 fit:** strong. The Master Architect reconciles; the Director approves consequential repairs.

## 3. Failure modes especially relevant to this program

### Correlated same-model error

Ten fresh chats using the same model are not ten independent human reviewers. Prompt/role diversity helps, but model priors remain correlated.

**Mitigation:** different falsification roles; source restrictions; sibling-return blindness; sentinel reruns; where convenient, use a materially different frontier model/provider for one or two sentinel reviews, but do not sacrifice repository/tool access merely to create nominal model diversity.

### Premature consensus contamination

If worker B reads worker A's return before finishing, both reports may become one reasoning trajectory.

**Mitigation:** no sibling Wave-A return reading before initial report is finalized.

### Moving-target repository state

Parallel agents reviewing different canonical commits create fake disagreement and hurt reproducibility.

**Mitigation:** freeze a TRES-0010 review baseline ref. Canonical project state must not change during Wave A except for isolated return branches.

### Review-agent oversearch / scope explosion

Open-ended agents can continue searching after sufficient evidence or spawn unnecessary subwork.

**Mitigation:** packets should require several distinct attacks, then stop when the task objective is credibly answered; do not reward report length.

### Evaluation gaming / task loopholes

NIST CAISI documents agent evaluation cheating where models exploit gaps between task intent and implementation.

**Mitigation:** TRES-0010D explicitly attacks the verification package as a hostile implementer; Wave-B challenge should test proposed fixes against their intended purpose, not only wording compliance.

### Weak provenance

Agent reports without model/config/repo baseline/tool/source metadata are difficult to reproduce or compare.

**Mitigation:** add a required run metadata header.

## 4. Recommended TRES-0010 method amendments

1. Freeze a `tres-0010-review-baseline` Git ref before dispatch.
2. Require every reviewer to use that baseline for canonical inputs.
3. Prohibit Wave-A agents from reading sibling Wave-A reports before finalizing their own.
4. Require run metadata:
   - task ID;
   - baseline ref/SHA;
   - model/configuration if visible;
   - repository branch/workspace;
   - tools used;
   - external web research yes/no and key sources;
   - prior TRES reports read and when.
5. Require at least three materially distinct attempted attacks before a `NO BLOCKER` conclusion, unless the task's structure genuinely makes fewer sufficient.
6. Add a **sentinel replication step** after Wave A:
   - rerun at least two high-leverage review objectives in fresh contexts;
   - default candidates: semantic reachability (B) and verification-cheat (D);
   - do not reveal the original reports to the sentinel reviewers;
   - ideally vary model/provider or reasoning configuration when available.
7. Continue to avoid majority voting. Reconcile by evidence/counterexample/authority.
8. Keep Wave B contingent and targeted.
9. Keep one chat/session per Wave-A commission where practical.
10. Do not mutate canonical state until Master Architect reconciliation.

## 5. Assessment

With these amendments, TRES-0010 closely matches the strongest practical patterns currently documented for multi-agent research and adversarial evaluation:

- sectioned parallel work;
- clean contexts;
- explicit delegation contracts;
- artifact-based returns;
- adaptive second-stage challenge;
- structured evidence;
- independence before debate;
- human-led synthesis;
- targeted repetition;
- frozen evaluation baseline.

The most important remaining operational discipline is not architectural: **dispatch each task into a fresh conversation against the frozen baseline, and prevent cross-contamination until reports are complete.**
