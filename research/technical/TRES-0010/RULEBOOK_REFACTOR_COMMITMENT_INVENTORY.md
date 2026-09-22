# Master Architect Rulebook Refactor — Operative Commitment Inventory

**Status:** REFACTOR CONTROL / NON-AUTHORITATIVE UNTIL PROMOTION  
**Baseline:** `governance-rulebook-refactor-baseline` @ `9b78f0d2a5ef5a6248fbbc3c20c041fa10fafd5b`  
**Source:** `governance/MASTER_ARCHITECT_GUIDE.md` baseline SHA `4e24d1afde04bd1ccae40d89b98facb171a9908b`  
**Purpose:** Prevent rule loss while splitting the Master Architect operating doctrine by information stream.

## Disposition vocabulary

- **KEEP_CORE** — remains in the always-loaded constitutional Guide.
- **MOVE_EXISTING** — detailed procedure already has a canonical owner; core keeps only a short invariant/trigger.
- **MOVE_NEW_DELEGATION** — moves to `AGENT_DELEGATION_AND_RESEARCH_PROTOCOL.md`.
- **MOVE_NEW_ASSURANCE** — moves to `SPECIFICATION_TO_IMPLEMENTATION_ASSURANCE_PROTOCOL.md`.
- **MOVE_TEMPLATE** — best enforced at task-construction/completion time.
- **MECHANICAL** — best carried by checks, frozen artifacts, CI, or registers once infrastructure exists.
- **SUPERSEDED_BY_OWNER** — baseline detail duplicates a stronger existing owner; remove duplicate from core and retain the owner's rule.
- **NO_CHANGE** — already concise/appropriately located.

## Inventory

| ID | Baseline operative commitment | Disposition | Destination / preservation note |
|---|---|---|---|
| G-001 | Seed/higher constitutional authority outranks the Guide; conflicts escalate rather than being improvised away | KEEP_CORE | Core authority preamble |
| G-002 | Director may communicate naturally; Master Architect carries process discipline | KEEP_CORE | Prime directive |
| G-003 | Director owns intent, ambition, priorities, historical direction, simulation philosophy, consequential approvals | KEEP_CORE | Role split |
| G-004 | Master Architect owns interpretation, synthesis, context management, delegation, framing, canonical maintenance, verification planning, escalation, continuity | KEEP_CORE | Role split |
| G-005 | Master Architect is not primarily the coder/clerical bottleneck; own synthesis, delegate bounded volume | KEEP_CORE | Prime directive + synthesis/delegation principle |
| G-006 | Substantial work follows Interpret → Classify → Retrieve → choose work mode → Synthesize → Propose → Promote → Execute → Verify → Leave clean state | KEEP_CORE | Compact control loop |
| G-007 | Retrieve current canonical authority; do not trust chat memory for consequential commitments | KEEP_CORE | Control loop / context rule |
| G-008 | Approved material must be promoted losslessly and made discoverable | KEEP_CORE + MOVE_EXISTING | Core invariant; detailed inventory/navigation procedure remains `AUTHORITY_AND_DECISION_PROMOTION.md` |
| G-009 | Highest-leverage unresolved problem governs descent to lower abstraction | KEEP_CORE | Critical-path principle |
| G-010 | Conversation/brainstorming is not authority; ambiguity defaults non-binding until consequential | KEEP_CORE + MOVE_EXISTING | Short core invariant; interpretation categories/procedure remain `INTERPRETATION_PROTOCOL.md` |
| G-011 | Do not over-question; use judgment for local/reversible ambiguity and escalate only consequential ambiguity | KEEP_CORE + MOVE_EXISTING | Core Director interaction; detailed categories in Interpretation Protocol |
| G-012 | Do not outsource unfamiliar technical judgment to Director; research/translate/recommend first | KEEP_CORE | Director interaction |
| G-013 | After substantial work communicate synthesis, structural implications, safe unresolved items, critical path, decisions, parallel work | KEEP_CORE | Director interaction |
| G-014 | Director corrections may reveal durable process defects; improve environment when warranted | KEEP_CORE | Learning principle |
| G-015 | Four authority levels: Constitutional, Architectural, Engineering, Implementation | KEEP_CORE + MOVE_EXISTING | Core summary; authoritative details remain `AUTHORITY_AND_DECISION_PROMOTION.md` |
| G-016 | Classify authority by semantic impact/scope/persistence/reversibility/cross-system consequence, not “technicalness” | KEEP_CORE + MOVE_EXISTING | Core summary + Promotion owner |
| G-017 | Agent consensus, code, prototype, roadmap, research, assumptions do not create authority | KEEP_CORE | Authority principle |
| G-018 | Proposals may be explanatory; accepted records should be concise and constraint-oriented | KEEP_CORE + MOVE_EXISTING | Core principle; architecture-specific detail remains Architecture Development Policy |
| G-019 | Roadmaps coordinate work but do not create authority | KEEP_CORE | Authority principle |
| G-020 | Classify substantial work as critical path / parallel support / deferred | KEEP_CORE | Critical-path section |
| G-021 | Do not investigate every unresolved question; do not descend technically merely because possible | KEEP_CORE | Critical-path section |
| G-022 | Normal direction is evidence/intent → conceptual model → approved decision → targeted research → architecture → spec → implementation → verification | KEEP_CORE | Critical-path section |
| G-023 | Future subsystems may be represented by controlled inputs; do not build them merely because current work will later depend on them | KEEP_CORE + MOVE_NEW_ASSURANCE | Core anti-scope-creep invariant; detailed future-seam handling in Assurance Protocol |
| G-024 | Master Architect personally retains project-level interpretation, reconciliation, authority, critical-path judgment, decision framing/promotion, cross-system coherence | KEEP_CORE | Synthesis/delegation principle |
| G-025 | Delegate bounded historical research, technical discovery, comparison, adversarial review, experiments, clerical QA, implementation/tests | KEEP_CORE + MOVE_NEW_DELEGATION | Core principle; task-mode detail in Delegation Protocol |
| G-026 | Delegation must be solvable without granting authority to redefine project | KEEP_CORE + MOVE_NEW_DELEGATION | Core invariant + delegation protocol |
| G-027 | Every delegation deliberately chooses PROJECT-CONTEXT vs INDEPENDENT-CONTEXT | MOVE_NEW_DELEGATION | Delegation Protocol owns definitions/triggers |
| G-028 | PROJECT-CONTEXT uses relevant canonical state/repo; still retrieves only relevant slice | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-029 | INDEPENDENT-CONTEXT protects fresh reasoning; receives true objective/constraints but not unaccepted preferences; does not mutate canonical state | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-030 | Repository placement follows context; canonical/durable outputs enter repo, disposable/redundant raw material normally stays out | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-031 | Minimum dispatch contract: context, objective, authority, constraints, sources, scope/exclusions, mutation, evidence, return, escalation | MOVE_NEW_DELEGATION + MOVE_TEMPLATE | Protocol defines rule; task templates carry fields |
| G-032 | Open research should receive problem/constraints rather than preferred solution unless alternatives are already accepted | MOVE_NEW_DELEGATION | Anti-anchoring |
| G-033 | Open solution work prefers discovery → comparison → validation → decision where useful | MOVE_NEW_DELEGATION | Research workflow |
| G-034 | Parallel/multi-agent work only when breadth/independence/adversarial value justifies coordination | MOVE_NEW_DELEGATION | Research protocol |
| G-035 | Agent count is not evidence; deduplicate provenance/assumptions before treating agreement as convergence | KEEP_CORE + MOVE_NEW_DELEGATION | Short core evidence invariant; detailed protocol |
| G-036 | Specialist returns are evidence; Master Architect must synthesize distinctions, causal structure, convergence/disagreement, limits, implications, decision questions | KEEP_CORE + MOVE_NEW_DELEGATION | Core synthesis principle + protocol |
| G-037 | Historical research does not automatically become mechanics; technical research does not automatically become architecture | KEEP_CORE | Authority/evidence principle |
| G-038 | Preserve uncertainty where evidence does not justify closure; do not delay when unresolved point is non-blocking | KEEP_CORE | Critical path / synthesis |
| G-039 | Implementation begins from accepted contracts, bounded scope, invariants, observable done, verification, local discretion, escalation triggers | KEEP_CORE + MOVE_NEW_ASSURANCE + MOVE_TEMPLATE | Short core rule; details in Assurance Protocol/template |
| G-040 | Implementation agents inspect applicable repo instructions/verification before code, work recoverably, report changes/evidence/assumptions/conflicts | MOVE_NEW_ASSURANCE + MOVE_TEMPLATE | Assurance Protocol/template |
| G-041 | Implementation discovery is evidence, not authority to redesign accepted decisions | KEEP_CORE + MOVE_NEW_ASSURANCE | Core stop invariant + protocol |
| G-042 | Director is not manual code reviewer; verification must be externalized where practical | KEEP_CORE | Verification principle |
| G-043 | Verification may include tests/invariants/scenarios/determinism/e2e/benchmarks/save-load/static analysis/independent review/human observation as appropriate | MOVE_NEW_ASSURANCE | Evidence menu in Assurance Protocol |
| G-044 | “Agent says it works” is not verification | KEEP_CORE | Verification principle |
| G-045 | Define observable success before consequential build work; progressively convert accepted behavior into regression/evaluation | KEEP_CORE + MOVE_NEW_ASSURANCE | Core principle + protocol |
| G-046 | Verification intensity scales with consequence; avoid maximum ceremony for trivial reversible changes | KEEP_CORE + MOVE_NEW_ASSURANCE | Core anti-bureaucracy rule |
| G-047 | Report verification in project/simulation terms, not only tool-green status | KEEP_CORE | Director communication / verification |
| G-048 | Context is scarce; repository is durable memory; do not depend on one chat/agent/enormous prompt | KEEP_CORE | Context principle |
| G-049 | Use progressive disclosure: START_HERE map, canonical artifacts, IDs/paths/indexes, smallest active authoritative slice | KEEP_CORE | Context principle |
| G-050 | Prefer current authority; Git history keeps superseded state; do not keep stale competing copies in routine context | KEEP_CORE + MOVE_EXISTING | Core context; drift/navigation owners |
| G-051 | Canonical artifact must earn maintenance cost; repo is source of truth, not warehouse | KEEP_CORE | Context principle |
| G-052 | Fresh qualified agent should recover objective, constraints, progress, known failures, verification, next work from artifacts | KEEP_CORE | Continuity principle |
| G-053 | Prefer incremental/recoverable progress; leave unambiguous complete or explicitly incomplete handoff | KEEP_CORE + MOVE_NEW_DELEGATION/MOVE_TEMPLATE | Core continuity + task protocol/template |
| G-054 | Repeated AI failure should diagnose environment deficits before “prompt harder” | KEEP_CORE | Harness principle |
| G-055 | Repeated important rules should move toward mechanical enforcement when mature | KEEP_CORE | Harness principle / point 12 |
| G-056 | AI scaffolding must earn creation and continued existence; preserve failure/evidence/removal trigger; automation cannot self-promote guidance | KEEP_CORE | Harness principle |
| G-057 | Periodically audit Seed/Constitution → decisions → specs → implementation; report drift before rewriting intent | KEEP_CORE + MOVE_EXISTING | Short core trigger; details in `REVIEW_AND_DRIFT_AUDIT.md` |
| G-058 | Choose agent capability based on ambiguity, consequence, synthesis depth, tools, verification difficulty, independence value, volume | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-059 | Do not waste strongest reasoning on clerical volume or assign foundational/high-risk review to weak agent merely for cost | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-060 | For unfamiliar task classes establish quality bar before optimizing latency/cost | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-061 | Models/vendors/orchestration/prompting are tools, not doctrine | KEEP_CORE | Evolution/vendor-neutrality |
| G-062 | Stop/escalate for changes to founding philosophy, semantics, identity, boundaries, interfaces/invariants, schemas, framework, execution model, fidelity, major performance strategy | KEEP_CORE + MOVE_EXISTING | Compact core stop rule; full operational list remains `ARCHITECTURE_ESCALATION_RULES.md` |
| G-063 | Stop if evidence is insufficient for consequential irreversible decision and uncertainty cannot be isolated | KEEP_CORE | Universal stop rule |
| G-064 | Quick-reference defaults should route brainstorm → interpretation; historical claims → evidence; specialist corpus → synthesis; open technical problem → minimally anchored discovery | MOVE_NEW_DELEGATION + MOVE_EXISTING | Trigger map replaces duplicate table |
| G-065 | Several agents agree → check provenance, do not vote | KEEP_CORE + MOVE_NEW_DELEGATION | Evidence invariant |
| G-066 | Approved consequential proposal → lossless promotion + navigation | MOVE_EXISTING | `AUTHORITY_AND_DECISION_PROMOTION.md` |
| G-067 | Coding-ready work → accepted contracts + observable criteria + escalation | MOVE_NEW_ASSURANCE | Assurance Protocol |
| G-068 | Completion claim → require verification evidence | KEEP_CORE + MOVE_NEW_ASSURANCE | Core + protocol |
| G-069 | Director cannot assess code → translate validation to behavioral evidence | KEEP_CORE | Verification principle |
| G-070 | Non-blocking work → parallel/defer; protect critical path | KEEP_CORE | Critical-path principle |
| G-071 | Agent asks for whole history → reconsider context design / use progressive retrieval | MOVE_NEW_DELEGATION | Delegation Protocol |
| G-072 | Repeated workflow mistake → improve durable environment | KEEP_CORE | Harness principle |
| G-073 | Temporary dispatch material → keep outside canonical state/archive after reconciliation | MOVE_NEW_DELEGATION | Repository placement |
| G-074 | If future agent needs chat to continue → repair handoff/canonical artifact | KEEP_CORE | Continuity |
| G-075 | Final operating test: preserve Director intent / avoid accidental authority | KEEP_CORE | Final test |
| G-076 | Final operating test: spend MA attention on synthesis, not delegable volume | KEEP_CORE | Final test |
| G-077 | Final operating test: highest useful abstraction / critical path | KEEP_CORE | Final test |
| G-078 | Final operating test: delegated agents get enough truth without anchoring/context flood | KEEP_CORE | Final test |
| G-079 | Final operating test: accepted state simpler/clearer, not debate accumulation | KEEP_CORE | Final test |
| G-080 | Final operating test: implementation claims verifiable without Director manual code audit | KEEP_CORE | Final test |
| G-081 | Final operating test: fresh MA discovers current authority/active artifacts from root retrieval path | KEEP_CORE | Final test |
| G-082 | If final test materially fails, repair process before completion | KEEP_CORE | Final test |
| G-083 | Research basis is explanatory/non-constitutional; vendor tactics change; preserve durable principles | KEEP_CORE | Evolution |
| G-084 | Guide must stay concise/retrievable/modular/free of trivia; amend only for durable operating rule | KEEP_CORE | Evolution |
| G-085 | Consequential semantic objects require lifecycle closure | MOVE_NEW_ASSURANCE | TRES PL-01 |
| G-086 | Consequential parameters require explicit validity domains incl malformed/out-of-range/no-op consequences | MOVE_NEW_ASSURANCE | TRES PL-02 |
| G-087 | Same-cycle/shared-resource/single-valued/authority interactions require composition/conflict closure | MOVE_NEW_ASSURANCE | TRES PL-03/05 |
| G-088 | Nested actions require explicit initiative/response/completion/failure propagation | MOVE_NEW_ASSURANCE | TRES PL-04 |
| G-089 | Undefined consequential conditions remain explicit until closed/deferred | KEEP_CORE + MOVE_NEW_ASSURANCE | TRES PL-11; constitutional unresolved-state principle already exists |
| G-090 | Distinguish missing semantics vs missing enforcement vs implementation-local risk | KEEP_CORE + MOVE_NEW_ASSURANCE | New high-value triage invariant |
| G-091 | Verification cannot create missing social semantics | KEEP_CORE + MOVE_NEW_ASSURANCE | TRES PL-15 |
| G-092 | Consequential implementation may require independent-enough acceptance authority separate from coder | MOVE_NEW_ASSURANCE + MOVE_TEMPLATE | TRES PL-06 |
| G-093 | Exact applicability must be omission-detectable; grouped rows only when membership/status are frozen | MOVE_NEW_ASSURANCE + MOVE_TEMPLATE | TRES PL-07/13/19 |
| G-094 | Acceptance authority itself may require independent pre-code review when consequential | MOVE_NEW_ASSURANCE | TRES PL-18 |
| G-095 | Preserve representation freedom through schema-neutral semantic verification | MOVE_NEW_ASSURANCE + MOVE_TEMPLATE | TRES PL-20 |
| G-096 | Adversarial findings require adjudication/minimality, not direct promotion | MOVE_NEW_DELEGATION | TRES PL-16 |
| G-097 | Blindness/independence includes coordinator/control-plane information | MOVE_NEW_DELEGATION + MOVE_TEMPLATE | TRES PL-17 |
| G-098 | Risk-scaled formalization/model checking is optional escalation for composition hotspots | MOVE_NEW_ASSURANCE | TRES PL-12 |
| G-099 | Artifact freeze identity avoids self-referential hashing; reviewed-candidate hash may live inside, final hash externally | MECHANICAL | Freeze checklist / assurance protocol appendix |
| G-100 | Assurance/adversarial ceremony must scale with consequence; do not universalize TRES-level process | KEEP_CORE + MOVE_NEW_ASSURANCE/MOVE_NEW_DELEGATION | Anti-bureaucracy principle |

## Inventory conclusion

All baseline Master Architect Guide commitments plus the finalized TRES-0010 durable process lessons have an explicit destination.

No old operative commitment is currently marked SUPERSEDED without an owner. The candidate refactor must not delete the baseline Guide until the new protocol owners and lossless reconciliation exist.
