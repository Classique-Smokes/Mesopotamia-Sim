# VS-SFL-01x — Continuity / Turnover Family

All cards begin from a verified checkpoint produced by VS-SFL-001 or an equivalent independently verified formation result. The fixture must not write a Household ID, FormationWarrant, ContinuationWarrant, ParticipationWarrant, or lifecycle result directly.

## VS-SFL-010 — Complete founder turnover

**Level:** mechanism-isolation  
**Claim:** H can retain numerical identity after every founder has left, through explicit historical transmission.

### Initial state

- Active H with founders A/B/C as current SustainingParticipants.
- H has a valid FormationWarrant and all three founders recognize H.
- No D/E/F participation association exists.
- Newcomer setup may use controlled arrival/residence/kinship facts, but no participation state.

### Sequence

For D, then E, then F:

1. introduce newcomer in the scenario;
2. provide/communicate evidence so newcomer recognizes H;
3. establish shared residence with the intended current bridge;
4. establish a durable tie through allowed scenario-initial kinship;
5. commit one qualifying post-formation support event between newcomer and a current sustaining participant;
6. submit/accept a bilateral participation invitation/request;
7. verify ParticipationWarrant -> SustainingParticipant -> ContinuationWarrant;
8. only after that transmission exists, one original founder ends participation.

Recommended bridges:

- D through A, then A exits;
- E through B, then B exits;
- F through C, then C exits.

### Terminal assertions

- H has the same stable identity created in VS-SFL-001;
- no original founder remains a current SustainingParticipant;
- D/E/F are current SustainingParticipants;
- H is Active;
- every association change has provenance;
- continuity is justified by the warrant chain, not participant overlap;
- founder relations/history remain queryable after exit.

### Independent oracle

Check the historical chain:

`FormationWarrant -> ParticipationWarrant/ParticipationEnd -> ContinuationWarrant ...`

and stable household identity references. Never infer identity from final participant similarity.

---

## VS-SFL-011 — Broken bridge / similar endpoint

**Level:** causal ablation  
**Claim:** A similar final social snapshot does not inherit H when the required transmission bridge is absent.

Construct a paired run with a comparable newcomer/end configuration but break the required bridge before the newcomer obtains a valid ParticipationWarrant.

### Assertions

- the newcomer cannot inherit participation in H through the broken path;
- no ContinuationWarrant may cite the absent bridge;
- a later independently qualified organization may form a new identity, but may not reuse H merely because final people/residence/ties resemble the positive run.

---

## VS-SFL-012 — Inactive reactivation

**Level:** mechanism-isolation  
**Claim:** Inactive is operational dormancy, not loss of identity.

### Initial state

Active H with A/B current SustainingParticipants.

### Sequence

1. B ends participation.
2. At stable closure H becomes Inactive; A is sole continuity bearer.
3. D obtains the required evidence/conditions for participation through A.
4. D and A commit a valid bilateral participation proposal.
5. ParticipationWarrant/ContinuationWarrant commits.
6. At stable closure H becomes Active.

### Assertions

- H ID never changes;
- while Inactive, no household-mode initiative is available;
- head/provision historical state may persist but cannot create collective action while H is Inactive;
- reactivation uses A as sole bridge;
- no fresh H2 forms from the same evidence.

---

## VS-SFL-013 — Same-cycle bridge handoff

**Level:** conflict/ordering  
**Claim:** An accepted entry that causally depends on P as bridge is not destroyed by P's accepted same-cycle exit merely because of mutation order.

### Initial state

Inactive H with sole bearer A. D already satisfies all ParticipationWarrant facts except the final accepted participation proposal.

### Same-cycle proposals

- D/A accept participation using A as bridge.
- A has an accepted EndHouseholdParticipation proposal.

### Required semantic order

1. ParticipationWarrant / D association;
2. corresponding continuity handoff;
3. A participation end;
4. stable lifecycle evaluation.

### Terminal assertions

- H remains the same identity;
- D is sole SustainingParticipant;
- H is Inactive, not Dissolved;
- intermediate participant counts may appear in history but are not completed cycle state.

---

## VS-SFL-014 — Dissolution and no resurrection

**Level:** mechanism-isolation  
**Claim:** Zero current sustaining participants permanently dissolves H in v0.

### Initial state

Inactive H with sole bearer A.

### Sequence

- A commits EndHouseholdParticipation.
- No valid same-cycle continuity handoff exists.

### Assertions at stable closure

- H is Dissolved;
- H has no household-mode initiative;
- all H provision commitments are terminated;
- historical H/warrants remain queryable.

### Later control

Create a later configuration with similar people/residence/ties and enough fresh formation evidence.

- it may form a new H2;
- it may not reactivate H;
- similarity is not continuity.

---

## Family metamorphic checks

For VS-SFL-010 through 014:

- reorder nonsemantic storage/input collections -> same semantic result;
- rename nonsemantic IDs -> isomorphic result except where stable-ID fallback is intentionally reached;
- add unrelated disconnected people -> no continuity/lifecycle change;
- enable/disable diagnostic observers -> no semantic change;
- rebuild derived indexes at safe boundary -> no semantic change.

## Always-on family invariants

- current lifecycle is published only at stable cycle closure;
- no Dissolved household emits household-mode action;
- no ContinuationWarrant references a nonexistent historical event;
- residence change alone never edits SustainingParticipant state;
- one causal evidence bundle cannot both continue non-Dissolved H and form duplicate H2;
- no hidden universal membership collection is used as the oracle.
