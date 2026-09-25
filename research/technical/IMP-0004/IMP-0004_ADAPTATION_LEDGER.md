# IMP-0004 inherited verification adaptation ledger

Status: implementation evidence in progress, not independent conformance.

Authority: `sfl-v0-slice4-inherited-verification-adaptation-v2-approved`, commit `68fddec788b5cf41db5934c8719a6fd1ce474d32`, plan blob `00c3e64a128fa00e91b99117e321a0e379dd61c5`. Frozen manifests and approved refs remain unchanged.

| Approved mapping | Actual trigger and change | Replacement evidence / limitations |
|---|---|---|
| A: formation headlessness | Adding head role/context types caused the inherited S3-014 type-absence assertion to fail. `HouseholdScenarios.cs` now checks one vacant role per produced H, no installed occupant/transition, and no Household decision or effect from formation. | Historical producer still independently verified. `FormationOracleRejectsAutomaticOccupancy` passes a well-formed occupied-role corruption to the actual Slice-4 oracle and expects rejection. |
| B: exact structural inventory | Adding typed HeadRoles, HeadTransitions, ProvisionRefusals, and nextHeadRole caused S3-093's exact HouseholdState field inventory to fail. `HouseholdStructuralScenarios.cs` adds only these named fields; the exact comparison remains. | WorldState field inventory remains unchanged. Full new-record and phase-carried-authority audits are unfinished. Critical-seam mutant evidence is recorded separately when executed. |
| C: Household material events | Actual support/dowry now emit material Household events. The historical Slice-3 oracle remains strict for its historical producer scope. `Slice4Oracle.cs` independently validates the bounded S4 material events and rejects other Household material events. | Funding/role/provenance corruptions are exercised in the new mechanism suite. Complete adaptation-C mutation census remains unfinished. |
| D: commitment provenance | Changing commitment provenance to a closed typed union made the old `.Provenance.Fixture` access fail compilation. The historical oracle now first requires `ProvisionFixtureProvenance` and retains its nonempty fixture assertion. | Slice-4 origin checks separately validate actual endogenous request/response/creation or self-authorization events. Complete cross-label/cause-order corruption matrix remains unfinished. |

Exact diffs are retained in Git from baseline `683183c1b58f82dccdcc776644759fe1c04fe109`. No inherited witness beyond these four approved mappings was loosened. No acceptance row was reclassified. The full inherited runner remains the authority for individual regression results; a passing runner does not substitute for the unfinished Slice-4 assurance work.
