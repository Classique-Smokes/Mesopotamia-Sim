# Review and Drift Audit

**Status / authority:** ACCEPTED review protocol  
**Purpose:** Check the authoritative chain for drift without rewriting higher authority to match lower-level behavior.  
**Load when:** meaningful integration milestones, consequential refactors/ADRs, persistent assumptions, reported architecture conflicts, or repository-growth checkpoints warrant a drift audit.  
**Do not load merely because:** every small commit occurred; there is no fixed calendar requirement.  
**Expected output:** concise aligned/discrepancy/undocumented-change/stale-assumption/escalation/housekeeping findings with higher-authority references.  
**Escalation / stop:** report drift before changing project intent or accepted authority to match implementation.


**Purpose:** Periodically compare the authoritative chain:

`Seed / Constitution → Accepted Decisions → Specifications → Implementation`

The audit reports discrepancies before changing project intent to match implementation.

## When to run

Run a lightweight audit at meaningful integration points, such as:

- before or after a major subsystem milestone;
- before accepting a consequential ADR;
- after a substantial refactor or persistence change;
- when implementation agents report architectural conflict;
- when assumptions have persisted beyond their intended review point;
- periodically as the project grows.

Do not impose a fixed calendar cadence until project workflow makes one useful.

## Audit checks

### 1. Seed / Constitution alignment
- Do accepted decisions remain compatible with founding intent?
- Has any constitutional change been made without explicit Human Project Director approval and versioning?

### 2. Decision integrity
- Are consequential choices present in the Decision Register?
- Are statuses accurate?
- Do accepted entries preserve rationale, authority, and lineage?
- Did any proposal become de facto architecture without explicit acceptance?

### 3. Specification alignment
- Does each accepted specification trace to accepted requirements/decisions/evidence where needed?
- Are assumptions and exclusions visible?
- Have unresolved matters been accidentally specified as settled?
- Did canonical compression omit any previously approved operative condition, edge case, exclusion, or delegated lock?

### 4. Implementation alignment
- Does code behavior match accepted specifications?
- Has implementation introduced undocumented persistence, coupling, dependencies, abstraction, or interface changes?
- Are important invariants enforced where mechanisms now exist to do so?

### 5. Assumption health
- Which assumptions are still active?
- Have their review/replacement triggers occurred?
- Has any assumption become relied upon as though it were accepted truth?

### 6. Historical-evidence discipline
- Are historically specific claims still scoped to appropriate period/place/context?
- Are interpretations and uncertainty visible?
- Has evidence been converted into mechanics without a separate design decision?

### 7. Drift and stale artifacts
- Are any specifications or accepted decisions obsolete but not superseded?
- Does `00_START_HERE.md` still point to the actual current source of truth?
- Can a fresh agent following `AGENTS.md → START_HERE → CURRENT_PHASE → local indexes/registers` discover every authority, active artifact, and required supporting context it is expected to use?
- Have navigation files accumulated stale or low-value links that should instead remain reachable only through their owning canonical artifact?


### 8. Milestone learning retention
At consequential subsystem/slice completion, ask whether implementation, independent review, or post-implementation observation produced any **surprising future-relevant lesson** that would otherwise require chat archaeology or reconstruction from several records.

If yes:

- leave one compact local future-lessons index near the subsystem/slice completion record;
- derive it from durable implementation/review/observation evidence;
- distinguish observed lesson from accepted requirement;
- link to the source records rather than duplicating their full detail;
- record only lessons that materially affect future risk maps, retrieval, verification strategy, observability, abstraction expectations, or later research questions;
- do not convert the index into simulation authority or a new acceptance gate.

If no material lesson exists, record nothing merely to satisfy ceremony.

The purpose is retrieval compression, not retrospective bureaucracy.

## Audit output

Produce a concise report with:

- **Aligned** — no action needed.
- **Discrepancy** — canonical state and implementation/specification diverge.
- **Undocumented change** — behavior/architecture changed without a corresponding accepted artifact.
- **Stale assumption** — assumption requires review.
- **Open escalation** — consequential conflict requires decision.
- **Housekeeping** — navigation/version/reference cleanup that does not alter project meaning, including missing milestone-learning indexes when consequential future lessons would otherwise be hard to retrieve.

For each discrepancy, identify the higher-authority artifact and the lower-level conflict. Do **not** automatically rewrite the higher-authority artifact to match the lower one.
