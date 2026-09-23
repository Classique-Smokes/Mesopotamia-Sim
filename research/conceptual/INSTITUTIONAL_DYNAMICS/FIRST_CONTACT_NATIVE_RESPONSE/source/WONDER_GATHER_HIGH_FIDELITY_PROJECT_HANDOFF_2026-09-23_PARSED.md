# Parsed Source Text — Wonder Gather High-Fidelity Project Handoff

**Source filename:** `Wonder_Gather_High_Fidelity_Project_Handoff_2026-09-23_PHONE.pdf`  
**Source PDF SHA-256:** `c72cedef26e6766c1ef882e3676632b3772188ff74b59d270b36dd87e1468aff`  
**Source pages:** 82  
**Purpose:** durable text-level archive for reconciliation and question-bounded analysis.

> This is parsed text from the received PDF, not a replacement for the original rendered artifact. Page markers are preserved where supplied by the file reader.

---

<PARSED TEXT FOR PAGE: 1 / 82>

WONDER GATHER -
HIGH-FIDELITY
PROJECT HANDOFF
Prepared for an external architect of
AI-assisted project systems
Snapshot date: 23 September 2026
Repository: MacquePanoramix/Modular-RTS
Current main head:
d03e0456f0399cd2ad9d1faecfce636f54fe6c47 - Add
lightweight Wonder Gather continuity layer
Current gameplay milestone: The Living Body
Milestone lifecycle: Technical Ready - Game
Director playtest pending
Unity: 6000.6.0f1
This document is a factual handoff, not a proposal
for a new harness.
It describes the project as it actually exists today,
including contradictions, unfinished areas, informal
practices, and recently added continuity machinery.
1

<PARSED TEXT FOR PAGE: 2 / 82>

Evidence-status vocabulary
used in this handoff
To avoid blurring fact, interpretation, and design
intent, statements below use these meanings:
Canonical/current - explicitly treated by the
repository as current project truth.
Implemented - exists in code/assets today; this
does not automatically mean the underlying
design is permanent.
Historical - useful provenance, but superseded as
current authority.
Informal convention - real practice, but not
necessarily enforced by tooling.
Inference - reconstructed from repository history
and the long-running design conversation.
Open - deliberately unresolved.
Working-memory context - known to the high￾context design conversation but not fully
externalized in durable project artifacts.
1. Project in one page
What the project is trying to build
Wonder Gather is a slow-paced, fully 3D fantasy
RTS in which players design a civilization before
the match rather than selecting a predefined
faction.
• 
• 
• 
• 
• 
• 
• 
2

<PARSED TEXT FOR PAGE: 3 / 82>

Its conventional gameplay ancestry is recognizably 
Age of Empires:
starting base → gather → construct → produce →
expand → fight
But its central distinction is that the civilization itself
is authored by the player.
A civilization is intended to become a connected
network of:
starting base properties;
starting units and resources;
unit blueprints;
building blueprints;
construction permissions;
production relationships;
resources;
progression / technology structure;
body and equipment choices;
personality and autonomy traits;
eventually other unusual civilization-specific
mechanics.
The project often compares this to deckbuilding,
except the "deck" is an entire civilization whose
possibility graph unfolds during an RTS match.
The second defining pillar is embodiment.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
3

<PARSED TEXT FOR PAGE: 4 / 82>

Units are not intended to feel like abstract RTS
tokens with animations attached. Their bodies,
movement, traits, temperament, courage, and
eventually combat should make them worth
observing at close range.
The tone explicitly rejects the deliberately slapstick
physics of Totally Accurate Battle Simulator. TABS is an
inspiration for emergence and procedural
physicality, but also an anti-reference for tone.
The desired emotional result is grounded, readable,
poetic, and quietly wondrous.
Why it exists
The design goal is larger than "make a highly
customizable RTS."
The intended pleasure is:
invent a civilization, bring it into being,
command it, and enjoy watching its
inhabitants physically live out the
consequences of what was designed.
The player should not spend the entire match in
strategic autopilot staring only at numbers,
production queues, and efficiencies.
Close observation is part of the intended play
experience.
The project therefore tries to hold two scales at once:
• the civilization / landscape / strategy scale;
4

<PARSED TEXT FOR PAGE: 5 / 82>

the individual body / gesture / small emergent
event scale.
The newer project-culture shorthand for this tension
is:
One eye on the constellation, one hand in the
soil.
What a successful end state looks
like
The long-term intended primary competitive mode is
Open Workshop multiplayer.
Players would bring previously authored civilizations
into matchmaking under shared design-budget and
legality rules.
Two civilizations could differ profoundly in:
starting structure;
economy;
progression depth;
build permissions;
production topology;
body types;
physical capabilities;
equipment;
temperament;
resource usage;
resilience;
strategic style.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
5

<PARSED TEXT FOR PAGE: 6 / 82>

Despite that freedom, the game must remain:
legible;
competitively meaningful;
physically grounded;
strategically controllable;
visually coherent;
pleasant to observe.
A key locked design distinction is the two-cost
model:
Design value - pre-match cost for how much
possibility/resilience is accessible from the
starting setup.
In-match cost - resources/time/capacity required
to actually produce something during play.
A powerful late unit can have high in-match cost but
modest design value if hidden behind a long fragile
progression chain. Direct access from the starting
base would cost much more design value.
Current stage
This is no longer merely a paper concept.
The repository contains working small-scale versions
of:
3D RTS camera;
click / shift-click / box selection;
group movement;
NavMesh navigation and local avoidance;
alternate reachable destination handling;
• 
• 
• 
• 
• 
• 
1. 
2. 
• 
• 
• 
• 
• 
6

<PARSED TEXT FOR PAGE: 7 / 82>

finite resource gathering;
carrying and depositing;
building placement;
timed construction;
unit production queues;
civilization definitions;
multiple editable unit blueprints;
multiple editable building blueprints;
many-to-many build and production relationships;
civilization reachability validation;
player-facing faction creation;
persistent local faction storage;
schema migration / corruption safeguards;
provisional unit-performance customization;
procedural biped presentation layered over
navigation.
The latest documented full Unity PlayMode
regression is:
61 passed, 0 failed.
That is evidence for the covered behavior only. It is
not evidence that the full game is close to
completion.
What is actively being worked on
now
The active gameplay milestone is The Living Body.
Its question is deliberately narrow:
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
7

<PARSED TEXT FOR PAGE: 8 / 82>

Can a navigation-driven procedural body make
an RTS unit feel grounded, expressive, and worth
watching without becoming slapstick or
weakening strategic readability?
The current implementation includes:
world-space support feet;
alternating steps;
predictive placement;
slope-normal adaptation;
procedural knees;
variable pelvis height;
acceleration/body lean;
arm counter-swing;
start/stop response;
redirection behavior.
The gameplay root remains NavMesh-authoritative.
This is not active-ragdoll locomotion.
The current remaining gate is human experiential
acceptance by the Game Director.
What the next major milestone is
Canonical answer: no next major milestone is
currently locked.
Docs/CURRENT_STATE.md explicitly says the next
action is human playtest first.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
8

<PARSED TEXT FOR PAGE: 9 / 82>

After that, the project should either:
refine The Living Body because the experiment
has not yet answered its question; or
deliberately choose the next milestone.
A personality/temperament prototype ("Three
Temperaments") is a plausible directional next
experiment from the design history, but it is not
current canonical project state and should not be
treated as scheduled work without the Game
Director choosing it.
2. What kind of project this
really is
Wonder Gather is best understood as a creative /
technical hybrid containing several research-like
problems inside a game-development project.
It is not merely "an RTS implemented in Unity."
Conventional game engineering
The project includes ordinary software/game
systems:
input;
selection;
camera;
navigation;
UI;
persistence;
1. 
2. 
• 
• 
• 
• 
• 
• 
9

<PARSED TEXT FOR PAGE: 10 / 82>

resource systems;
building placement;
production;
scene authoring;
regression tests;
build tooling.
These areas generally have objective correctness
criteria.
Systems-design research
A much harder question is whether an RTS
civilization can be represented as a very flexible
player-authored dependency graph without
becoming:
incomprehensible;
impossible to balance;
trivial to exploit;
too tedious to author;
too conventional after restrictions are added.
The project is actively discovering the answer rather
than implementing a known design pattern.
Simulation / AI research
The intended future unit model combines ideas that
are individually difficult and mutually interacting:
body/physical traits;
personality;
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
10

<PARSED TEXT FOR PAGE: 11 / 82>

courage and morale;
autonomy;
procedural motion;
combat;
emergent reactions;
eventual networking constraints.
The exact behavioral model is open.
Visual / experiential research
Many important success criteria cannot be reduced
to tests.
For example:
does movement feel grounded?
does a body feel alive rather than robotic?
is autonomy legible rather than frustrating?
do close-up events remain interesting after
repetition?
does the game preserve wonder rather than
become merely technical?
Words such as "weighty," "floaty," "gentle,"
"awkward," "alive," and "goofy" are real acceptance
vocabulary in this project.
Where uncertainty lives
Highest uncertainty currently exists in:
final body/customization vocabulary;
procedural animation depth;
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
11

<PARSED TEXT FOR PAGE: 12 / 82>

physics authority;
combat resolution;
personality and autonomy;
morale;
multiple-resource architecture;
tech/progression representation;
design-budget formulas;
multiplayer authority;
scale/performance targets;
final UI;
art direction;
individual unit variation;
long-term persistence compatibility rules.
These areas are intentionally not frozen.
Where correctness matters most
Correctness matters disproportionately in systems
where errors can remain silent, persist, or
reinterpret player-authored content:
faction save integrity;
schema migration;
stable blueprint IDs;
asset GUIDs;
civilization graph semantics;
payment/refund conservation;
runtime permissions;
deterministic interpretation of persistent
authored relationships;
eventual multiplayer authority.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
12

<PARSED TEXT FOR PAGE: 13 / 82>

A gait parameter can be thrown away.
A migration that silently changes a player-created
civilization is a different class of risk.
3. Where project truth
currently lives
The project now has a clearer hierarchy than it did at
inception.
Docs/CURRENT_STATE.md
Type of truth: current-state router.
Authority: high for active milestone/lifecycle.
Current: yes.
Can become stale: yes, deliberately; it must be
refreshed when the active milestone meaningfully
changes.
It answers:
where are we now?
what is technically established?
what remains unproven?
what is waiting on the Game Director?
which deeper document should be retrieved next?
Subtlety: it records runtime baseline commit 
d9b5f4d4 because the current docs-only continuity
commit did not change gameplay. Actual repository
head is now d03e0456 .
• 
• 
• 
• 
• 
13

<PARSED TEXT FOR PAGE: 14 / 82>

That is not currently treated as a contradiction
requiring correction; it records the implementation
baseline when the state note was written.
Docs/GAME_VISION.md
Type of truth: canonical living design source of
truth.
Authority: highest durable design authority under
the Game Director.
Current: yes.
Can become stale: yes if decisions are changed
without updating it.
It distinguishes:
Locked;
Direction;
Possible;
Open;
Implemented.
This distinction is one of the most important
safeguards in the project.
Implementation does not automatically promote a
choice into design law.
Docs/DESIGN_RATIONALE.md
Type of truth: high-value "why" memory.
Authority: supporting rationale, not replacement
design authority.
• 
• 
• 
• 
• 
14

<PARSED TEXT FOR PAGE: 15 / 82>

Current: yes, newly added.
Can become stale: less frequently than current
state, but yes.
Its purpose is to preserve reasons whose loss could
let a competent contributor follow the words of the
design while building the wrong experience.
Examples include:
observation is gameplay;
physicality serves embodiment, not physics
spectacle;
customization should feel like authorship rather
than spreadsheet editing;
strange civilizations deserve room to breathe;
slowness creates attention;
implemented is not locked.
Docs/PROJECT_CULTURE.md
Type of truth: collaboration vocabulary, context
routing, consequence-sensitive working culture.
Authority: mnemonic / operational shorthand only.
Current: yes, newly added.
Can become stale: yes if collaboration patterns
change.
It defines optional project-native roles:
Keeper of the Horizon - Game Director;
Threadkeeper - high-context design/continuity AI;
Worldsmith - implementation AI/developer;
Guest Cartographer - fresh independent reviewer
for rare high-risk work.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
15

<PARSED TEXT FOR PAGE: 16 / 82>

It explicitly states that plain meanings outrank
metaphor.
Source code under Assets/
_WonderGather
Type of truth: what runtime/editor implementation
actually does.
Authority: highest implementation truth.
Current: yes.
Can become stale: not in the same sense; code is
reality for the checked-out commit, though docs may
describe it incorrectly.
Important areas include:
Assets/_WonderGather/Scripts/Civilizations/
Assets/_WonderGather/Scripts/Creator/
Assets/_WonderGather/Scripts/Units/
Assets/_WonderGather/Scripts/Commands/
Assets/_WonderGather/Scripts/Selection/
Assets/_WonderGather/Scripts/Camera/
If prose disagrees with current runtime behavior,
inspect code/tests before assuming prose is correct.
Docs/AI/UnityProjectContext.md
Type of truth: technical architecture/history and
implementation-agent continuity.
Authority: high for engineering context.
• 
• 
• 
• 
• 
• 
16

<PARSED TEXT FOR PAGE: 17 / 82>

Current: maintained through milestones.
Can become stale: yes; later sections supersede
earlier constraints.
Its job is to reduce rediscovery across disposable
implementation-agent sessions.
Docs/Validation.md
Type of truth: execution evidence, failure history,
known limitations.
Authority: high for what was actually tested/run.
Current: updated through Living Body.
Can become stale: yes after new work.
It records:
focused tests;
full regression results;
build results;
failures;
corrected assumptions;
visual-probe findings;
things explicitly not validated.
This document is unusually important because it
records failed attempts rather than only final green
states.
Milestone playtest documents
Examples:
Docs/LivingBodyPlaytest.md
• 
• 
• 
• 
• 
• 
• 
• 
17

<PARSED TEXT FOR PAGE: 18 / 82>

Docs/UnitPerformancePlaytest.md
Docs/BuildingNetworkPlaytest.md
Docs/FactionLibraryPlaytest.md
Docs/MultipleBlueprintPlaytest.md
Type of truth: human acceptance questions for a
specific milestone.
Authority: high for what the Game Director should
manually judge.
Current: milestone-specific.
They distinguish automated correctness from
experiential acceptance.
AGENTS.md
Type of truth: repository-level working agreement
for agents.
Authority: high for agent behavior.
Current: yes, expanded in d03e0456 .
It now instructs agents to:
start at CURRENT_STATE.md ;
retrieve only relevant deeper context;
preserve Game Director authority;
preserve unresolved design questions;
protect uncommitted human workspace state;
preserve GUIDs;
keep runtime free of UnityEditor references;
validate changes with bounded evidence;
avoid treating test success as experiential
acceptance;
scale review rigor with consequence.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
18

<PARSED TEXT FOR PAGE: 19 / 82>

README.md
Type of truth: repository entry point and current
launch instructions.
Authority: medium.
Current: yes.
It now points newcomers toward the current-state/
rationale/culture documents.
Automated PlayMode tests
Type of truth: executable invariants.
Authority: high for exactly what each test asserts.
Current: latest documented full suite = 61 green.
They cover behavior across navigation, selection,
economy, building, production, faction authoring,
persistence, migrations, networks, performance, and
procedural locomotion.
They do not prove aesthetics, balance, game feel, or
the full intended design.
Git history
Type of truth: provenance.
Authority: high for what changed and when.
Current: yes.
The milestone progression is unusually legible:
19

<PARSED TEXT FOR PAGE: 20 / 82>

Wanderer → Group → Gatherer → Settlement →
Production → Civilization → Faction Creator →
Faction Library → Multiple Blueprints → Building
Network → Unit Performance → Living Body →
Conservatory continuity layer
GitHub issues / pull requests /
branches
Current observable state:
GitHub issues: none;
Pull requests: one historical merged PR, the
docs-only Conservatory continuity change;
visible branches: main and the continuity branch
used for that one-off change.
The project does not currently use issues as task
truth.
It does not currently have a mandatory PR review
workflow.
The continuity-layer PR should not be mistaken for a
newly established branch policy; it was deliberately
used for a self-referential governance/
documentation change.
• 
• 
• 
20

<PARSED TEXT FOR PAGE: 21 / 82>

Conversation history / high-context
AI memory
Type of truth: rationale, continuity, discarded
alternatives, taste, relationships among decisions.
Authority: important but non-canonical.
Current: partially persistent, partially compressed/
implicit.
Can become stale/incomplete: yes.
This was once the primary location of the design.
The repository has progressively externalized the
most important material because conversation
memory should not be the only project archive.
Generated local test reports / builds
Examples:
local XML test results under ignored Docs/
TestResults/ -style paths;
local Windows builds such as Builds/
WindowsLivingBody/WonderGather.exe .
Type of truth: raw local execution artifacts.
Authority: execution evidence when present.
Repository availability: generally not committed.
Validation.md preserves the durable summary.
• 
• 
21

<PARSED TEXT FOR PAGE: 22 / 82>

4. Authority and decision￾making
Final authority
The human owner / Game Director has final
authority over:
game design;
creative direction;
priorities;
whether an experiment feels right;
whether an Open/Possible/Direction idea
becomes Locked;
whether a milestone is experientially accepted.
The newer cultural shorthand calls this role Keeper
of the Horizon.
That title is optional; the authority is not.
What implementation agents may
decide autonomously
Implementation AI/developers may normally decide
bounded engineering details such as:
class/component structure;
local APIs;
test setup;
dependency wiring;
editor authoring code;
bug fixes needed to meet an explicit milestone;
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
22

<PARSED TEXT FOR PAGE: 23 / 82>

implementation-level refactors that preserve
semantics.
They should not silently decide unresolved game
design.
What requires human approval
Human judgment is especially required for:
game feel;
aesthetic tone;
movement quality;
camera feel;
customization fantasy;
autonomy readability;
milestone acceptance where the question is
experiential;
locking previously open design.
How architectural decisions are
recorded
There is no formal ADR system.
Architecture is currently recorded through a
combination of:
source code;
UnityProjectContext.md ;
GAME_VISION.md where architecture intersects
design meaning;
milestone documentation;
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
23

<PARSED TEXT FOR PAGE: 24 / 82>

validation history;
Git history.
Can implementation silently create
new semantics?
Formal answer: it should not.
The repository repeatedly labels provisional systems
as:
prototype;
temporary;
not final;
open;
implemented but not locked.
This distinction is now reinforced directly in 
AGENTS.md , GAME_VISION.md , DESIGN_RATIONALE.md ,
and PROJECT_CULTURE.md .
How disagreements are resolved
There is no committee mechanism.
The Game Director has final creative authority.
Technical disagreements are generally resolved
through:
code inspection;
tests;
reproduced behavior;
bounded prototypes;
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
24

<PARSED TEXT FOR PAGE: 25 / 82>

occasionally fresh review if risk justifies it.
If the disagreement is about game feel or intended
experience, human creative judgment controls.
How a decision becomes official
The clearest durable path is:
Game Director decides/accepts a direction;
relevant design status in GAME_VISION.md is
updated;
implementation/docs/tests are changed
consistently;
CURRENT_STATE.md changes if milestone state
changes.
There is no separate approval database.
5. Current architecture and
major conceptual
boundaries
RTS command path
Current high-level command architecture:
• 
1. 
2. 
3. 
4. 
25

<PARSED TEXT FOR PAGE: 26 / 82>

RtsInput
 ↓
SelectionController
 ↓
CommandDispatcher / commands
 ↓
UnitMotor
 ↓
NavMeshAgent
RtsCamera is separate and consumes input/selection
context independently.
This separation was established early and remains
important for later autonomy/networking
possibilities.
Civilization architecture
Core types include:
CivilizationDefinition
UnitBlueprint
BuildingBlueprint
CivilizationValidator
CivilizationSession
A civilization currently owns a starting setup plus
rosters of units/buildings and their relationships.
Civilization graph semantics
A fixed-point reachability model currently
determines structural accessibility.
• 
• 
• 
• 
• 
26

<PARSED TEXT FOR PAGE: 27 / 82>

A unit becomes reachable if:
it starts reachable; or
a reachable building can produce it.
A building becomes reachable if:
it is the starting base; or
a reachable unit can build it.
Cycles are allowed but do not bootstrap themselves.
This graph meaning is foundational enough that
later semantic changes would deserve high scrutiny.
Validator boundary
Current validation distinguishes blocking errors
from non-blocking warnings.
It can detect structural issues such as:
broken IDs;
duplicate IDs;
invalid prefabs;
invalid links;
unreachable branches;
absence of reachable gathering capability.
It does not prove:
competitive balance;
full economic viability;
map resource sufficiency;
military survivability;
matchmaking legality.
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
• 
27

<PARSED TEXT FOR PAGE: 28 / 82>

Faction creator boundary
The player-facing creator edits runtime/draft copies
rather than mutating canonical authored assets
directly.
Current prototype limits include small fixed rosters
and a provisional supply economy.
These are scaffolds, not final design limits.
Creator / playtest separation
The creator and playtest are intentionally separated
so runtime match state does not silently mutate
faction design state.
The creator remains loaded while a playtest scene
can be loaded additively; returning removes the
runtime playtest state.
Persistence boundary
Current faction schema is version 4.
Important properties include:
explicit DTO records;
stable IDs;
schema versioning;
unknown-field rejection;
migrations from older versions;
migrations occur in memory;
• 
• 
• 
• 
• 
• 
28

<PARSED TEXT FOR PAGE: 29 / 82>

old data is rewritten only after explicit save/
rename;
optimistic hash/state tokens;
temp-write + atomic replacement;
.bak previous-version backup;
deletion recovery directory.
Save files represent civilization designs, not ongoing
matches.
Unit-performance boundary
Current performance values are:
movement percentage;
carry capacity;
gathering percentage;
construction percentage.
They are intentionally described as temporary
