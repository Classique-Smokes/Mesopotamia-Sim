# Open Issues / Questions Register

**Purpose:** Preserve genuinely unresolved matters without forcing premature resolution.

Only add an issue when it arises from current work, blocks or shapes a near-term decision, or is important enough that losing it would create drift. Do **not** manufacture an exhaustive future-design backlog.

## Statuses

`OPEN / DEFERRED / RESOLVED`

## Current register

### OQ-0001 — Initial historical research frame

- **Status:** RESOLVED
- **Question:** What bounded period and geographic/archive context should anchor the project's first substantive historical research into the individual → relationship → household foundation?
- **Why this was opened:** The Seed deliberately names Sumer and Akkad only as a broad domain while requiring evidence to remain specific to period, place, archive, and social context.
- **Resolution:** Old Babylonian Nippur, approximately 1900–1600 BCE, emphasizing private/legal archives and archaeologically contextualized residential evidence.
- **Resolution date:** 2026-09-19
- **Approved by:** Human Project Director, explicitly in conversation and now promoted into canonical project state.
- **Interpretive limit:** This is the project's **initial research anchor**, not a declaration that Nippur is representative of all Old Babylonian society or Mesopotamia generally.
- **Decision level:** Project-direction / research-scope choice; not by itself a software or simulation architecture decision.
- **Unblocked work:** RES-0001 parallel household-foundations research program.
- **Related artifacts:** `founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md`, `tasks/research/RES-0001_OLD_BABYLONIAN_NIPPUR/00_PROGRAM_README.md`

### OQ-0002 — Household identity and continuity criteria

- **Status:** RESOLVED
- **Question:** What simulation-level conditions are sufficient for a household to form, persist through turnover, divide, consolidate, or dissolve without reducing those outcomes to one relationship, one address, one property event, or a naive graph-clustering rule?
- **Why it matters now:** DEC-0001 makes the issue necessary for the first foundation specification, but the historical evidence does not provide a ready-made algorithm or universal threshold.
- **What it blocks or influences:** Detailed subsystem specification for household recognition/continuity; technical research on emergent aggregate identity.
- **What it does not decide:** It does not reopen the Seed's commitment to households as the first major collective structure, and it does not select software architecture.
- **Owner:** Master Architect, informed by technical research and reconciled historical evidence.
- **Resolution criteria:** A historically defensible and technically coherent proposal that preserves causal legibility, continuity, and the independence of residence/kinship/property/support/labor dimensions.
- **Resolution:** SFL v0 now defines explicit formation, provenance-bearing participation, continuity warrants, Active/Inactive/Dissolved operational lifecycle, and controlled lineage semantics. Snapshot similarity/residence/assets/kinship/overlap are insufficient for identity.
- **Resolution date:** 2026-09-21
- **Approved by:** Human Project Director through Stage-2 and Stage-3 semantic decisions.
- **Related artifacts:** `decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md`, `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`

## Entry template

### OQ-XXXX — [Question]

- **Status:** OPEN / DEFERRED / RESOLVED
- **Question:**
- **Why it matters now:**
- **What it blocks or influences:**
- **What it does not decide:**
- **Owner:**
- **Resolution criteria:**
- **Resolution / date:** —
- **Related artifacts:**

### OQ-0003 — Subjective recognition and organizational legitimacy

- **Status:** RESOLVED
- **Question:** How should simulated actors represent and update recognition/belief about collective identity, legitimate roles, authority, and obligations so that social recognition can reinforce institutions without an engine-only classification becoming its own evidence?
- **Why it matters now:** Decision 3 has converged on endogenous recognition as part of household institutionalization and continuity.
- **What it blocks or influences:** Household formation/recognition, broker legitimacy, continuity, and later reputation/office/institution systems.
- **What it does not decide:** Exact household thresholds, belief psychology, information-spread rates, contested-claim mechanics, or later political legitimacy systems.
- **Owner:** Master Architect.
- **Resolution criteria:** Distinguish objective state from actor knowledge/recognition and allow grounded feedback into behavior without global omniscience.
- **Resolution:** SFL v0 separates objective state, KnownFact, and evidence-backed Recognition (Unknown/Recognized/Contested); recognition is actor-specific, provenance-bearing, stale until displaced/contested, and causally gates household/role-specific action without global omniscience.
- **Resolution date:** 2026-09-21
- **Approved by:** Human Project Director through Pass C and subsequent Stage-3 restorations.
- **Related artifacts:** `specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md`, `plans/verification/SFL_V0/RECOGNITION_INFORMATION_FAMILY.md`


### OQ-0004 — TRES-0010 deferred later-slice gaps

- **Status:** DEFERRED
- **Question:** Which confirmed pre-code gaps must be closed before later household/continuity/lineage/checkpoint features become executable?
- **Why it matters now:** TRES-0010 deliberately kept several real later-slice semantic and verification issues off the Slice-1 critical path. Losing them would turn a safe deferral into accidental implementation discretion.
- **What it blocks or influences:** Only the future trigger surfaces named in the dedicated ledger; it does not block IMP-0001.
- **What it does not decide:** It does not supply the missing later-slice semantics, expand Slice 1, or reopen already closed D1–D5 / acceptance-authority decisions.
- **Owner:** Master Architect; consequential semantic closures return to the Project Director where required.
- **Resolution criteria:** Each ledger entry is resolved/promoted or explicitly retired before its named feature becomes executable/completion-authoritative.
- **Resolution / date:** —
- **Related artifacts:** `registers/TRES-0010_DEFERRED_GAP_LEDGER.md`; `research/technical/TRES-0010/WAVE_B_ADJUDICATION_SYNTHESIS.md`; `research/technical/TRES-0010/B2_MASTER_ARCHITECT_DECISION_SYNTHESIS.md`
