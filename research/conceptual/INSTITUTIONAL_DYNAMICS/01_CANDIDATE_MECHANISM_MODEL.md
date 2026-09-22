# Candidate Mechanism Model

**Status:** DRAFT / NON-AUTHORITATIVE  
**Role:** Translate conceptual distinctions into candidate simulation machinery that can later be researched, tested, rejected, refined, or promoted.

## 1. Mechanism-layer rule

Do not begin with a universal `Institution` abstraction.

Prefer reusable lower-level mechanism families that different higher-order structures may combine differently.

A household, temple, palace, office, workshop, army, council, or merchant organization may share some primitives without sharing one ontology or lifecycle.

## 2. Candidate mechanism families

### A. Persistent collective identity

**Existing precedent:** SFL household identity.

Candidate generalization:

- independently identified collective record;
- explicit formation/founding provenance;
- historical transitions that preserve, transform, divide, consolidate, or end continuity;
- identity not re-derived from snapshot similarity.

**Open issue:** what kinds of continuity evidence generalize beyond households without forcing all institutions into household-style warrants.

### B. Continuity relations and succession

Candidate machinery:

- explicit causal predecessor/successor relations;
- continuity-bearing events;
- branch/fork and consolidation representation;
- distinction between direct predecessor, ancestry, and mere resemblance;
- possibility that continuity remains contested rather than engine-collapsed prematurely.

Potential future states include continuity claims that are socially recognized but objectively unsupported, and objective continuity that actors fail to recognize.

### C. Offices / roles separate from holders

**Existing precedent:** SFL HouseholdHeadRole.

Candidate machinery:

- office/role as persistent object distinct from occupant;
- occupancy terms;
- appointment, vacancy, resignation, removal, succession, usurpation;
- scope of authority;
- office history surviving holder turnover;
- actor behavior in personal mode versus office/representative mode.

No assumption that every social role must be formalized as an office.

### D. Authority claims

Candidate machinery should keep separate:

- office identity;
- claimant/holder;
- authority scope;
- basis of claim;
- recognized procedure/form;
- objective occupancy state;
- actor-specific recognition of that state.

This makes it possible for multiple claimants to assert authority while different actors recognize different claims.

### E. Institutional capability

Capability should normally be **derived**, not a primitive power level.

Possible inputs:

- occupied relevant offices;
- actual participants/dependents/workers;
- available resources;
- valid provision/resource commitments;
- procedures and knowledge;
- tools/artifacts;
- delegated responsibility;
- current operational constraints.

This allows an institution to persist while temporarily unable to act.

### F. Participation / association arrangements

**Existing precedent:** SustainingParticipant and ParticipationWarrant.

Candidate generalization:

- typed participation/affiliation relations;
- provenance-bearing entry and exit;
- distinct rights/obligations per relation;
- no universal primitive `MemberOf(Institution)` unless a future domain specifically warrants it.

Different institutional forms may use different association types.

### G. Recognition and legitimacy

**Existing precedent:** KnownFact / Recognition.

Candidate machinery:

- actor-specific recognition propositions;
- provenance/evidence;
- recognized / contested / unknown states where appropriate;
- recognition of collective identity;
- recognition of office occupancy;
- recognition of authority scope;
- recognition of artifacts or official genealogy.

Recognition affects action availability and interaction without replacing objective state.

### H. Artifacts and documentary memory

Artifacts remain non-agent causal objects.

Candidate machinery:

- persistent artifact identity;
- content/version;
- author/issuer/copyist where known;
- source artifact / transformation relation;
- creation, copying, translation, summarization, redaction, destruction;
- authenticity status where objectively knowable;
- actor-specific beliefs about authenticity/authority;
- institutional adoption or citation;
- material location/access.

A derivative artifact may be less causally original but more institutionally authoritative.

### I. Procedures / practices

Candidate machinery may eventually represent durable action patterns or formal procedures that survive individual holders.

Possible forms:

- versioned rule/procedure records;
- learned routines carried by people;
- artifact-backed instructions;
- office-specific procedural obligations;
- procedural prerequisites for recognized acts.

Do not assume every repeated behavior deserves a first-class procedure object.

### J. Tasks, responsibility, skill, and knowledge

Candidate machinery:

- task identity and objective;
- prerequisites / hidden subtasks;
- required skills/knowledge;
- responsibility assignment;
- delegation/subtask relations;
- deadline or temporal constraints;
- observable completion/failure;
- learning/familiarity effects;
- coordination/supervision cost.

Responsibility should remain distinct from formal title and from actual influence.

### K. Effective centrality / influence

Do not encode “important person” as a scalar trait by default.

Effective centrality may be derived from:

- dependency graph of tasks/decisions;
- unique knowledge;
- recognized trust;
- brokerage between groups;
- authority paths;
- communication/work flows;
- responsibility concentration.

This creates a route for informal roles to emerge before formal recognition.

### L. Multiple genealogies

Preserve separately where needed:

1. objective causal genealogy;
2. official/institutional genealogy;
3. actor-remembered genealogy;
4. outsider/reconstructed genealogy.

Only the first is simulator-level causal history. The others are artifacts/subjective social facts.

### M. Institutional / social periodization

Do not create multiple physical clocks by default.

Candidate mechanism:

- event-referenced eras, reigns, reforms, successions, disasters, foundations, dissolutions;
- actor/institution labels such as “before X” or “since Y” built on the same underlying simulation time.

Social chronology becomes an interpretation of events, not a replacement for kernel time.

## 3. Candidate anti-shortcuts

Future design should challenge the following shortcuts:

- same participants = same institution;
- same name = same institution;
- same building = same institution;
- same archive = same institution;
- recognized claimant = objectively legitimate claimant;
- official genealogy = causal genealogy;
- formal office = effective influence;
- responsibility = authority;
- capability = identity;
- institution exists = institution can act;
- actor knows a fact = actor accepts its legitimacy;
- durable artifact = true artifact.

## 4. Relationship to the companion-tablet streams

The earlier three provisional workstreams now sit under this broader program:

- **Roles / Offices / Authority** → C, D, E, G, K.
- **Artifacts / Memory / Transmission** → G, H, I, L.
- **Work / Knowledge / Coordination** → I, J, K, E.

They are not independent destinations. They are continuity-bearing mechanism families that may combine inside future institutions.
