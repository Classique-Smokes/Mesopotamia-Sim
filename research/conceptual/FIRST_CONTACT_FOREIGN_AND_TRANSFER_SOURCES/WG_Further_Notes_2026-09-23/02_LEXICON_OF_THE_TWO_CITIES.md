# LEXICON OF THE TWO CITIES
## A bidirectional dictionary between Wonder Gather and the dialect of Uruk

**Purpose:** decode the accompanying traveler's account precisely.

If a metaphor introduces ambiguity, the Wonder Gather / engineering meaning below controls.

---

# I. The two cities

| Uruk expression | Wonder Gather / plain meaning | Notes |
|---|---|---|
| **Uruk** | The source project's accumulated institutional culture and lore | A separate AI-assisted project whose customs inspired the translation. It has no authority over Wonder Gather. |
| **City of Gathered Wonders** | **Wonder Gather** | Cultural translation of the project name. |
| **foreign city / barbarian city** | Wonder Gather as viewed from outside | Affectionate roleplay only. |
| **archive / royal library** | Git repository + durable project artifacts | Code, docs, history, tests, evidence. |

---

# II. People and offices

| Uruk expression | Wonder Gather term | Exact meaning |
|---|---|---|
| **Lugal / King** | Game Director / human project owner | Final creative authority, milestone priority, primary judge of feel and design acceptance. |
| **Chieftain** | High-context conversational AI / design witness | Carries rationale, project-history interpretation, design intent, and conceptual continuity. Not repository authority. |
| **Royal Smith** | Implementation AI / Codex / technical co-developer | Performs bounded C# implementation, Unity authoring, tests, debugging, validation, and technical documentation. |
| **coding priest** | Implementation agent, joking variant | Same as Royal Smith when the emphasis is technical/ritualized work. |
| **foreign priest** | Fresh independent technical reviewer | Used only when independent review is justified by silent + consequential risk. |
| **Akkadian priest** | Fresh reviewer, project-lore variant | Same functional meaning as foreign priest. |
| **Elamite priest** | Fresh reviewer, project-lore variant | Same functional meaning as foreign priest. |
| **Jester** | Low-authority interpretive observer | A person/AI who contributes patterns, critique, or conceptual interpretation without repository mutation authority. Not a required Wonder Gather role. |
| **scribe** | Bounded research/documentation/validation worker | Generic low-authority worker. |

---

# III. Wonder Gather documents translated into Uruk

| Uruk name | Wonder Gather artifact | Function |
|---|---|---|
| **Great Tablet of the First Dream** | `Docs/GAME_VISION.md` | Canonical living design source of truth. |
| **Tablet of Duties** | `AGENTS.md` | Agent working agreement and constraints. |
| **Scribe's Map of the Workshops** | `Docs/AI/UnityProjectContext.md` | Technical continuity and architectural context. |
| **Ledger of Omens** | `Docs/Validation.md` | Durable execution/failure/validation history. |
| **Tablet at the Gate / Tablet Nailed to the Gate** | proposed `Docs/CURRENT_STATE.md` | Very small current-state router. |
| **Tablet of Reasons** | proposed `Docs/DESIGN_RATIONALE.md` | Bounded high-value design rationale and semantic drift warnings. |
| **campaign chronicle** | Milestone/playtest document | Defines prototype question, limits, technical evidence, and human acceptance questions. |
| **small seal** | Validation receipt | Compact revision-bound machine-readable validation result. |

---

# IV. Design-status translation

These mappings are intended to be exact.

| Uruk expression | Wonder Gather status | Meaning that must be preserved |
|---|---|---|
| **Sealed by the Lugal** | **Locked** | Directly chosen; part of project identity unless deliberately revisited. |
| **The Lugal Faces This Way** | **Direction** | Strong intent; implementation/details remain open. |
| **A Tale Told in the Tavern** | **Possible** | Promising idea, no commitment. |
| **A Question Before the Court** | **Open** | Deliberately unresolved; requires design/prototype/playtest work. |
| **Built in Clay** | **Implemented** | Exists in current prototype; not automatically permanent design. |

---

# V. Suggested campaign-lifecycle translation

These are proposed lifecycle labels, not current Wonder Gather design-status terms.

| Uruk expression | Plain lifecycle label | Meaning |
|---|---|---|
| **Not Yet Begun** | Pending | Milestone not yet technically complete. |
| **The Smiths Are Finished** | Technical Ready | Technical implementation/validation complete; human acceptance may remain. |
| **The Lugal Allows the Next Campaign** | Provisionally Accepted | Good enough to serve as the next foundation; still revisable. |
| **Returned to the Workshop** | Rework | Requires another implementation/playtest iteration. |
| **Placed in the Old Archive** | Superseded | Historical milestone retained but no longer current. |

---

# VI. Historical milestone translation

This is the most important cultural mapping.

| Uruk milestone name | Wonder Gather name | What it refers to |
|---|---|---|
| **The First Man Who Walked** | **The Wanderer** | First camera/selection/command/single-unit navigation foundation. |
| **The Eight at the Gate** | **The Group** | Eight-unit selection, box selection, group movement, separate arrival slots. |
| **The Grain-Bearer** | **The Gatherer** | Finite resource gathering, carrying, depositing, interruption/resumption. |
| **The First Enclosure** | **The Little Settlement — construction** | Building placement, worker construction, persistent progress. |
| **The First Workshop That Produced a Man** | **Little Settlement — production** | Worker production, queues, payment/refund, spawn handling. |
| **Tablets of Peoples Yet Unborn** | **Civilization Blueprints** | Data-driven starting setup, units, buildings, construction/production links. |
| **House Where Peoples Are Made** | **Faction Creator** | Player-facing editing of civilization drafts. |
| **Archive of Nations** | **Faction Saving and Library** | Durable local faction storage, migration, recovery, library operations. |
| **Tablet of Many Bodies** | **Multiple Unit Blueprints** | Multiple editable unit types within a faction. |
| **Chains of House and Workshop** | **Building Blueprints / Production Networks** | Editable building roster and mixed production relationships. |
| **Measures of Flesh** | **Prototype Unit Performance** | Temporary movement/carry/gather/construction outcome controls. |
| **Clay Man Learns to Walk** | **The Living Body** | Procedural biped presentation over authoritative NavMesh-root movement. |
| **Three Spirits** | **Three Temperaments** | Future personality/behavior expression experiment mentioned in project direction. |
| **Open Court of Peoples** | **Open Workshop** | Intended competitive mode where players bring designed civilizations into matchmaking. |

---

# VII. Core systems translated

| Uruk expression | Wonder Gather / technical term | Meaning |
|---|---|---|
| **Roads of Descent** | Civilization graph reachability | Fixed-point structural reachability from starting setup through build/production links. |
| **Inspector of Roads and Lineage** | `CivilizationValidator` | Structural civilization validation. Does not prove balance or affordability. |
| **House Where Peoples Are Made** | Faction Creator system | Player edits a draft rather than authored source assets. |
| **Archive of Nations** | Faction persistence/library | Versioned faction designs stored durably. |
| **true name / seal-name** | Stable blueprint ID / GUID identity | Durable identity that links authored/persistent data. |
| **Price Before Birth** | Design value | Pre-match cost of making a capability reachable/available to the civilization. |
| **Price After Birth** | In-match cost | Runtime resource cost to produce/use something in a match. |
| **royal road / terrain road** | NavMesh / movement route | Runtime spatial navigation path. |
| **Clay Man** | Current procedural biped | Living Body test biped; presentation-only relative to authoritative NavMesh root. |

---

# VIII. The Four Temples of Truth

| Uruk temple | Plain category | Primary authority |
|---|---|---|
| **Temple of the First Dream** | Creative/design truth | Game Director + `GAME_VISION.md` |
| **Temple of What Exists** | Current prototype truth | Repository code/assets |
| **Temple of Green Omens** | Technical verification truth | Tests/builds/validation evidence |
| **Temple of the Lugal's Eyes** | Experiential/game-feel truth | Human playtest |

### Non-impersonation rule

These categories must not substitute for one another.

Examples:

- Implemented ≠ Locked
- tests pass ≠ feels right
- human preference ≠ persistence correctness
- graph reachable ≠ balanced
- screenshot acceptable ≠ controls feel acceptable

---

# IX. Validation vocabulary

| Uruk expression | Plain meaning |
|---|---|
| **green omen / green rune** | Passing technical evidence |
| **red omen** | Failed technical evidence |
| **ritual / spell** | Exact validation procedure/command |
| **Ritual of the Green Omens** | Proposed canonical local validation entry point |
| **small seal** | Validation receipt |
| **royal inspection** | Human playtest / Game Director acceptance |
| **omen ledger** | Validation history |

### Rule

A green omen proves only the bounded property actually tested.

---

# X. Risk-material translation

| Uruk material | Engineering class | Examples | Default treatment |
|---|---|---|---|
| **Clay** | Cheap/reversible | tuning, colors, temporary costs, gait values | implement + focused check + playtest |
| **Bronze** | Moderate consequence | UI architecture, economy loop, locomotion structure | tests + regressions + human inspection |
| **Stone** | Difficult to reverse | stable IDs, save semantics, graph meaning, command contracts | stronger evidence + explicit design reconciliation + possible fresh review |
| **Temple Foundation** | Project-corrupting if wrong | destructive migration, GUID rewriting, multiplayer authority | isolated candidate + architecture scrutiny + fresh review |

---

# XI. Workspace vocabulary

| Uruk expression | Plain meaning |
|---|---|
| **King's Workshop** | Human owner's local workspace, especially uncommitted state |
| **Law of the King's Workshop** | Do not reset/clean/overwrite human uncommitted work; use isolated worktree/clone for broad/destructive work |

"Uncommitted" does not mean "disposable."

---

# XII. Context and memory vocabulary

| Uruk expression | Plain meaning |
|---|---|
| **Do not make the Chieftain the filesystem** | Do not preload or centralize all project memory in one high-context AI |
| **roads through the city** | Task-specific context routing |
| **lost tablet** | Missing historical source/context |
| **anonymous artist** | Contributor whose causal contribution survives better than their attribution |
| **the archive remembers** | Durable artifacts preserve consequences across worker/successor turnover |

---

# XIII. Review vocabulary

| Uruk expression | Plain meaning |
|---|---|
| **summon a foreign priest** | Commission a fresh independent reviewer |
| **read the omens** | Inspect tests/evidence |
| **PASS** | Independent review found the bounded candidate satisfies reviewed claims |
| **BLOCK** | Independent review found a substantive defect or unsupported claim |
| **priest must not repair during judgment** | Preserve reviewer independence where it matters |

---

# XIV. Adoption translation

| Uruk phase | Plain phase |
|---|---|
| **First Moon — Place the Signposts** | Add tiny current-state/rationale/routing/workspace protection if useful |
| **Second Moon — Standardize the Omens** | Create canonical local validation path and optional receipts |
| **Third Moon — Chronicle New Campaigns** | Use lightweight milestone template for future substantial experiments |
| **Fourth Moon — Send for a Priest Only When Needed** | Risk-triggered independent review |
| **Fifth Moon — Build Walls Only After the City Needs Walls** | Add PR/CI/ADR/release machinery only when concrete growth justifies it |

---

# XV. Common Uruk sayings decoded

## "A wall may be built as an experiment. A statue may stand in the square without becoming a god."

Meaning:

> Implementation does not automatically create permanent design authority.

---

## "The priest may certify that the bridge stands. The king must still decide whether he likes where it goes."

Meaning:

> Technical verification and creative acceptance are separate.

---

## "Do not make the Chieftain the filesystem."

Meaning:

> Use durable artifacts and task-specific retrieval instead of forcing one AI to carry the entire project.

---

## "A scribe who cleans the King's unfinished sculpture may discover that even young cities have walls high enough to throw people from."

Meaning:

> Protect uncommitted human local state.

---

## "Do not worship CI before the ritual itself has a stable meaning."

Meaning:

> Standardize the canonical local validation procedure before automating it remotely.

---

## "A question faithfully preserved is better than an answer invented for administrative convenience."

Meaning:

> Preserve unresolved design questions instead of forcing premature decisions.

---

## "Governance should remember wounds. It should not imagine them."

Meaning:

> Formalize process mainly in response to actual recurring failure or demonstrated risk.

---

## "Let the Lugal judge beauty. Let the Royal Smith build. Let the Chieftain remember why. Send for an Elamite when silent errors can poison generations."

Meaning:

> Separate creative authority, implementation, design-memory/interpretation, and independent review; use each where appropriate.

---

# XVI. What is intentionally loose rather than exact

Some translations carry cultural color and should not be treated as new technical categories.

These include:

- king / Lugal;
- chieftain;
- priest;
- jester;
- clay;
- bronze;
- stone;
- temple foundation;
- grain;
- city;
- campaign;
- moon.

They are mnemonic metaphors.

The underlying engineering definitions in this lexicon control.

---

# XVII. What is intended to be exact

The following mappings should preserve their original Wonder Gather semantics exactly:

- Locked ↔ Sealed by the Lugal
- Direction ↔ The Lugal Faces This Way
- Possible ↔ A Tale Told in the Tavern
- Open ↔ A Question Before the Court
- Implemented ↔ Built in Clay
- `GAME_VISION.md` ↔ Great Tablet of the First Dream
- `Validation.md` ↔ Ledger of Omens
- `UnityProjectContext.md` ↔ Scribe's Map of the Workshops
- Game Director ↔ Lugal
- implementation agent ↔ Royal Smith
- independent reviewer ↔ foreign/Akkadian/Elamite priest
- human playtest ↔ royal inspection / Temple of the Lugal's Eyes
- save/persistence system ↔ Archive of Nations
- civilization graph reachability ↔ Roads of Descent
- Living Body ↔ Clay Man Learns to Walk

---

# XVIII. Final note

If the foreign city begins using some of these phrases differently over time, that is not necessarily an error.

The engineering meaning should remain clear where work depends on it.

The cultural shorthand may evolve.

That is, after all, the point of sending the tablets.
