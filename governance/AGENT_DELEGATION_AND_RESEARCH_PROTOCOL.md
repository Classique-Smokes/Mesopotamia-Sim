# Agent Delegation and Research Protocol

**Status:** ACCEPTED — Master Architect operating protocol  
**Authority:** Subordinate to the Project Seed, Working Constitution, and Master Architect Guide  
**Purpose:** Own the detailed rules for delegated research/review work so the always-loaded Master Architect Guide can remain compact.

**Load when:** commissioning or reconciling delegated research, comparison, review, adversarial evaluation, replication, experimentation, large-volume clerical analysis, or multi-agent work.  
**Do not load merely because:** a task is small, purely local, or the Master Architect can answer it directly without delegation.  
**Primary inputs:** current authoritative project state, the relevant task objective, applicable task template, and any accepted constraints.  
**Expected output:** a bounded dispatch design and/or reconciled evidence that does not increase the delegate's authority.  
**Stop/escalate when:** completing the task would require the delegate to redefine project intent, accepted semantics/architecture, or another higher-authority commitment.

---

## 1. Delegation principle

The Master Architect owns synthesis and authority; delegation exists to buy breadth, independence, specialization, experimentation, verification, or volume.

A delegation is well formed only when the delegate can complete it without authority to redefine the project.

Do not delegate project-level reconciliation merely because the evidence corpus is large. Clerical consolidation may be delegated; the Master Architect still decides what the evidence means for the project.

## 2. Choose context deliberately

Every delegated task declares one context mode.

### PROJECT-CONTEXT

Use when correctness materially depends on current canonical project state or when the delegate must inspect/modify the repository.

Examples include implementation, integration, specification review against accepted decisions, drift audit, repository validation, and architecture review of existing project choices.

Rules:

- retrieve the smallest authoritative slice needed;
- repository authority outranks chat history;
- the delegate may inspect additional directly relevant canonical material when needed;
- unrelated project history should remain unloaded unless it becomes relevant.

### INDEPENDENT-CONTEXT

Use when fresh reasoning or reduced anchoring is materially valuable.

Examples include open technical discovery, independent critique, source-bounded historical research, alternative-solution search, replication, and proposition cleanup from a supplied bundle.

Rules:

- give the true objective, genuine constraints, proof obligations, and relevant evidence;
- withhold unaccepted preferred solutions, prior conclusions, and unrelated internal debate unless the task is explicitly comparing them;
- independent-context work is advisory and does not mutate canonical project state.

Context mode is about information/authority design, not model prestige.

## 3. Minimum dispatch contract

A delegated packet must make clear, to the degree relevant:

- execution/context mode;
- objective and why it matters now;
- authority level and source hierarchy;
- accepted constraints;
- permitted source set / retrieval behavior;
- scope and explicit exclusions;
- permitted repository mutation, if any;
- evidence/verification standard;
- required return structure;
- stop/escalation conditions.

Task templates carry these fields. Do not repeat large background corpora merely because they exist.

## 4. Anti-anchoring and open discovery

For genuinely open research, give the delegate the problem and real constraints rather than the Master Architect's preferred solution.

Preferred sequence where useful:

**discovery → comparison → validation/falsification → Master Architect decision**

Named alternatives may be supplied when the task is explicitly a focused comparison or those alternatives are already accepted constraints.

Do not treat examples, historical implementation choices, or prior exploratory preferences as binding.

## 5. Multi-agent work is consequence-scaled

Use parallel or multiple agents only when at least one of these materially helps:

- breadth across evidence/solution space;
- independence/replication;
- adversarial challenge;
- distinct expertise or tool access;
- volume that is genuinely delegable;
- verification of a consequential handoff.

Agent count is never evidence by itself.

Several agents repeating the same source, assumption, or control-plane framing do not create independent confirmation.

For ordinary bounded work, one capable delegate plus direct verification is usually preferable to orchestration overhead.

## 6. Independence and blindness

When independence matters, define what the reviewer must be independent **from**:

- sibling returns;
- implementation code/author;
- prior finding labels;
- preferred solution;
- prior evaluation result;
- mutable baseline.

Blindness must include the control plane. A supposedly blind reviewer that must read a coordinator file revealing prior finding taxonomy is not fully topic-blind.

Use a self-contained packet and frozen baseline when the value of the review depends on independence.

If a delegate is accidentally contaminated by prohibited prior material, it must disclose that fact. The Master Architect decides whether the run remains useful or must be repeated.

## 7. Frozen baselines and workspace isolation

Use a frozen ref/commit when:

- multiple reviewers must evaluate the same state;
- moving `main` could invalidate comparison;
- a result must be reproducible;
- an acceptance/governance artifact is being independently reviewed.

Concurrent repository writers use isolated branches/worktrees/workspaces and explicit reconciliation before integration.

A delegate may mutate only the paths authorized by its task. Advisory review tasks should normally add only their assigned return artifact.

## 8. Provenance and return discipline

For consequential research/review, capture enough provenance to assess independence and reproduce the work, such as:

- task ID;
- baseline/ref/commit;
- context mode;
- source set;
- tools used;
- external research yes/no;
- prior/sibling material read and when;
- mutation/branch information.

Do not collect provenance that has no decision value.

A useful return distinguishes:

- source-supported finding;
- interpretation/inference;
- uncertainty;
- counterexample or falsification attempt;
- recommendation;
- unresolved matter.

Historical work additionally preserves chronology, place/archive/social context and separates evidence from interpretation.

## 9. Adversarial review patterns

Adversarial review is a tool, not ceremony.

Use it at consequential integration boundaries or where one-sided review is likely to miss interaction faults.

Useful patterns:

- **sentinel/replication** — fresh re-derivation from accepted sources;
- **prosecution** — demonstrate a claimed defect with the smallest concrete failure;
- **defense/minimality** — show existing authority already resolves it or that the proposed remedy overreaches;
- **experiment** — use a bounded probe when prose cannot discriminate.

Do not directly promote adversarial findings.

The Master Architect adjudicates each serious finding as, for example:

- missing semantic authority;
- missing enforcement/verification;
- implementation-local risk;
- deferred later-slice issue;
- already resolved;
- harmless ambiguity;
- false positive / overreach.

Choose the smallest faithful repair for the class actually found.

## 10. Evidence reconciliation

The Master Architect produces the project-level model from specialist returns.

Before treating agreement as convergence:

- deduplicate shared provenance;
- identify inherited assumptions/framing;
- distinguish direct evidence from repeated interpretation;
- surface material disagreement rather than averaging it away.

Preserve uncertainty when the evidence does not justify closure.

Do not delay the critical path merely because a non-blocking question remains interesting.

## 11. Agent capability selection

Choose agent/model/tool capability according to:

- ambiguity;
- consequence;
- synthesis depth;
- tool requirements;
- verification difficulty;
- independence value;
- volume.

Do not spend the strongest reasoning resource on routine clerical volume by default, and do not assign foundational synthesis/high-risk verification to a weak capability merely to reduce cost.

For an unfamiliar task class, establish the quality bar before optimizing latency/cost.

Models/vendors/orchestration systems are implementation tools, not project doctrine.

## 12. Repository placement

Canonical authority, active project-context work required for continuity, reproducibility material, and reconciled durable evidence belong in the repository when they earn the maintenance cost.

Disposable dispatch bundles, redundant copies, raw extracts, temporary scratch work, and unreconciled independent returns should not become routine canonical context merely because they were produced.

When returns are retained for provenance, their owning synthesis/decision should make clear that the return itself is advisory.

## 13. Completion / cleanup

Before closing delegated work, verify:

- the task's actual question was answered;
- the result did not exceed delegated authority;
- material uncertainty/conflict is visible;
- canonical state was not silently mutated;
- temporary branches/files are either intentionally retained for provenance or can be retired;
- the next qualified agent does not need chat archaeology to understand the result.

A repeated delegation failure should prompt an environment/template/protocol improvement rather than only a longer next prompt.

## 14. Related owners

- Director-input interpretation: `INTERPRETATION_PROTOCOL.md`
- authority/promotion/navigation: `AUTHORITY_AND_DECISION_PROMOTION.md`
- architecture development choices: `ARCHITECTURE_DEVELOPMENT_POLICY.md`
- architecture conflict/escalation: `ARCHITECTURE_ESCALATION_RULES.md`
- specification→implementation readiness: `SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`
- periodic integration drift: `REVIEW_AND_DRIFT_AUDIT.md`
- research task construction: `../tasks/RESEARCH_TASK_PACKET_TEMPLATE.md`
