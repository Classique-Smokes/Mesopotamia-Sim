# TRES-0011D — Mesopotamian Household-Resource Historical Pressure Test

**Task type:** independent external historical research / model-boundary audit  
**Context mode followed:** external history first; project application second  
**Authority:** advisory historical evidence only; this report does not create simulation semantics  
**Project base examined:** tres-0011-v0-resource-scaffold-wave-v1

## Executive finding

The current SFL v0 Household resource scaffold is not historically neutral if its mechanics are read as a positive model of Mesopotamian ownership, household property, obligation, or resource control. Taken together, personal-only grain stocks, explicit voluntary provision commitments, the absence of a Household-owned balance, a fixed protected reserve, and one representative authorizing material acts produce a specific resource topology: collective material capacity is assembled from individually controlled stocks through explicit consent and is spent through a single scoped office.

That topology is historically possible in pieces, but it is not a defensible general description of Mesopotamian household economy. The literature instead shows overlapping and period-specific arrangements: individual control of some assets, family patrimony and collective claims, inheritance and dowry, debts and liabilities that could attach to families or estates, institutional domains, and households embedded in palace/temple/market relations. Old Assyrian evidence also makes particularly clear that control could be gendered and distributed in ways that do not reduce to a single male household head.

At the same time, SFL v0 explicitly declares historical calibration and full property/economic law out of scope, calls integral grain a replaceable laboratory discretization, and uses the resource mechanism to prove a narrower architectural proposition: a persistent Household can perform a grounded material act through intelligible people, authority, resource provenance, and history without collapsing individual and institutional capacity. For that bounded purpose, the historical problem is inferential contamination rather than immediate laboratory invalidity.

## Verdict

**SAFE ONLY WITH STRONG HISTORICAL-NONCLAIM GUARDRAILS**

## 1. Method and evidence boundary

Phase 1 was performed against external scholarship before reading the project semantics listed in the task. Phase 2 then examined:

- founding/00_MESOPOTAMIA_SIMULATION_PROJECT_SEED.md
- specifications/SPEC-SFL-0001_SOCIAL_FABRIC_LAB_V0.md
- decisions/DEC-0001_FOUNDATIONAL_SOCIAL_FABRIC.md
- decisions/DEC-0011_TRANSACTION_SPECIFIC_OFFICE_HOLDER_PRIVATE_SUPPLEMENTATION.md
- proposals/SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md

The analysis below keeps three things separate:

1. **Historical evidence:** what the cited textual/archaeological scholarship supports for a bounded period, archive, social group, or institution.
2. **Historical inference:** broader interpretations scholars draw from that evidence, including disagreements over categories such as private property.
3. **Model-design inference:** what the project may safely conclude about its v0 scaffold. This third category is advisory only and does not promote a mechanic.

The strongest recurring historical warning is that neither “personally owned” nor “Household owned” is a sufficiently general cross-period category. Rights to use, transfer, inherit, pledge, administer, benefit from, or dispose of resources could be distributed among persons, family groups, institutions, offices, and dependents. Modern unitary ownership language can therefore hide the very distinctions the evidence requires.

## 2. Scholarly source table

| ID | Scholarly source | Main period/context | Evidence used here | Important limit |
|---|---|---|---|---|
| S1 | Jason A. Ur, “Households and the Emergence of Cities in Ancient Mesopotamia,” Cambridge Archaeological Journal 24.2 (2014), 249–268. [DOI](https://doi.org/10.1017/S095977431400047X) | Fourth millennium urbanization interpreted through later Mesopotamian terminology | Household organization can be extended metaphorically into larger institutions; warns against assuming a modern family/state divide | A macro-historical model, not a transaction-level property code |
| S2 | Ignace J. Gelb, “Household and Family in Early Mesopotamia,” in State and Temple Economy in the Ancient Near East I (1979), 1–97. [Yale eHRAF record](https://ehrafarchaeology.yale.edu/traditions/mh64/documents/005) | Early Mesopotamia; lexical, legal, and administrative evidence | Distinguishes household/family phenomena and treats both private and public households, including temple and royal households | Broad synthesis across heterogeneous evidence |
| S3 | J. N. Postgate, Early Mesopotamia: Society and Economy at the Dawn of History (Routledge, 1992), especially chapters on household/family, temple, palace, and domestic economy. [Publisher](https://www.routledge.com/Early-Mesopotamia-Society-and-Economy-at-the-Dawn-of-History/Postgate/p/book/9780415110327) | Third–early second millennium synthesis | Household/family and temple/palace/domestic economies must be analyzed together rather than reduced to one ownership regime | Synthetic treatment; local archives still vary |
| S4 | Johannes M. Renger, “Institutional, Communal, and Individual Ownership or Possession of Arable Land in Ancient Mesopotamia from the End of the Fourth to the End of the First Millennium B.C.,” Chicago-Kent Law Review 71 (1995), 269–319. [Journal](https://scholarship.kentlaw.iit.edu/cklawreview/vol71/iss1/11/) | Long-run land tenure | The relevant historical field itself includes institutional, communal, and individual possession/control; “ownership” requires period-sensitive analysis | Very long chronological span; not a household micro-model |
| S5 | Steven J. Garfinkle, “Shepherds, Merchants, and Credit: Some Observations on Lending Practices in Ur III Mesopotamia,” Journal of the Economic and Social History of the Orient 47.1 (2004), 1–30. [DOI](https://doi.org/10.1163/156852004323069385) | Ur III, late third millennium BCE | Credit was important across society; large institutional economies coexisted with non-institutional households engaged in lending and gain-seeking | Loan documents overrepresent documented credit relations |
| S6 | Marcelo Rede, “Preservar e resistir: padrões de alienação de imóveis no período babilônico antigo,” Tempo 12.23 (2007), 123–149. [SciELO](https://www.scielo.br/j/tem/a/YwpPyJj9p9wvXHxMFvchz5S/?lang=pt) | Old Babylonian Larsa, early second millennium BCE | Family control of real property; collective sellers; resistance to alienating family patrimony; private-property language can misdescribe family, communal, and palatial control | Elite/private archives and land transactions do not represent the whole economy |
| S7 | Marcelo Rede, “Héritage, dot et prestations matrimoniales en Babylonie ancienne,” Dialogues d’histoire ancienne 35.2 (2009), 13–44. [DOI](https://doi.org/10.3406/dha.2009.3179) | Old Babylonian inheritance/dowry | Dowry and inheritance are intertwined modes of patrimonial transmission; challenges overly simple patrilineal accounts | Interpretive argument within an active scholarly debate |
| S8 | Cécile Michel, “Women and Real Estate in the Old Assyrian Texts,” Orient 51 (2016), 83–94. [DOI](https://doi.org/10.5356/orient.51.83) | Nineteenth-century BCE Aššur/Kaneš | Women could manage households and own/acquire/transmit houses; female resource authority is directly visible in the archive | Old Assyrian merchant corpus is socially and geographically selective |
| S9 | Cécile Michel, Women of Assur and Kanesh: Texts from the Archives of Assyrian Merchants (SBL Press, 2020). [Publisher](https://cart.sbl-site.org/books/061539C) | Old Assyrian merchant families | Women appear as economic actors, creditors, investors, and parties to loans, wills, purchases, marriage/divorce; family economy is not reducible to one male property holder | Same unusually rich merchant archive family as much of S8/S10 |
| S10 | Klaas R. Veenhof, “Families of Old Assyrian Traders,” in La famille dans le Proche-Orient ancien (2014), 341–372. [DOI](https://doi.org/10.5325/j.ctv1bxh3bw.26) | Old Assyrian traders at Kaneš | Family and commercial organization are tightly connected; explicitly identifies “colonial bias” because surviving archives are trader archives from Kaneš rather than Aššur | Strong source-selection bias is itself a central finding |
| S11 | Małgorzata Sandowicz, “The Case of Ubartu: On Inheriting Family Debts in Late Sixth-Century Uruk,” in La famille dans le Proche-Orient ancien (2014), 563–572. [DOI](https://doi.org/10.5325/j.ctv1bxh3bw.41) | Late sixth-century BCE Uruk | Family inheritance could include debts/liabilities as well as assets; heirs could face a linked choice concerning inheritance and liability | First-millennium legal practice must not be projected backward |
| S12 | Michael Jursa, Aspects of the Economic History of Babylonia in the First Millennium BC (Ugarit-Verlag, 2010). [University of Vienna record](https://ucrisportal.univie.ac.at/en/publications/aspects-of-the-economic-history-of-babylonia-in-the-first-millenn/) | First-millennium Babylonia | Large corpus-based synthesis of private, institutional, agricultural, monetary, labor, and business activity demonstrates a substantially different economic environment from earlier periods | First millennium cannot stand as a proxy for Sumerian/Old Babylonian conditions |

These sources deliberately mix long-run synthesis with tightly bounded case studies. No single archive or interpretation is treated as a universal Mesopotamian template.

## 3. Historical findings by period and context

### 3.1 “Household” is historically broader than a personal-resource aggregator

Ur’s central contribution is not that every Mesopotamian household had one standard economic constitution. It is that “house” organization was a powerful indigenous social form that could be extended into larger organizations. Gelb likewise treats both private and public households, including temple and royal households. Postgate places household/family analysis beside temple, palace, land, labor, and domestic economy rather than treating them as separable modern sectors. [S1–S3]

**Historical evidence:** household language and organization can encompass kin, dependents, labor, property/control, and institutional structures; “household” is not simply a list of autonomous individuals who optionally expose privately owned goods.

**Model-design inference:** SFL v0 is historically safest when HouseholdProvisionCommitment is described as one deliberately synthetic resource conduit used to test collective grounding, not as the historical essence of the Mesopotamian household.

### 3.2 Ur III: institutional scale and non-institutional household activity coexist

Garfinkle’s Ur III credit study is important because it resists a binary choice between an all-encompassing institutional economy and atomized private exchange. Surviving loans show sophisticated credit practices; large institutional economies were dominant in scale while non-institutional households still had room to lend and pursue economic gains. [S5]

This matters for the v0 boundary in two ways.

First, the existence of individually or household-controlled resources is historically plausible. Second, it does not follow that collective economic action was normally reconstructed from purely personal stocks through revocable voluntary commitments. Institutional and household economic capacity could be embedded in larger administrative, land, labor, and obligation structures that v0 intentionally omits.

### 3.3 Old Babylonian Larsa: family patrimony is not equivalent to modern individual private property

Rede’s serial study of Larsa real-estate alienation is the clearest pressure against reading v0’s personal stock as a general property ontology. The proliferation of alienation contracts in the early second millennium does not establish the primacy of modern-style private property. Rede distinguishes family, communal, and palatial modes of access/control and explicitly warns against assimilating family control to modern private property. [S6]

Within the Larsa corpus, multiple sellers can represent substantive collective agreement over the fate of family patrimony, not mere scribal decoration. Brothers, wives, and children could matter to legitimating alienation and forestalling later family claims. Buyers’ archives also create a preservation bias toward transactions and title chains. [S6]

**Historical evidence:** rights over property could be relational and distributed within a family group; alienation could require or record collective interests.

**Model-design inference:** a system in which all usable wealth is technically owned by individual persons and the Household can reach it only through explicit person-to-Household commitments is not a neutral historical default. It may still be a neutral *software fixture* if the project refuses to interpret it as property history.

### 3.4 Inheritance and dowry distribute claims across persons and family lines

Rede’s inheritance/dowry study challenges a simple account in which male inheritance exhausts family transmission. Dowry can be part of the transmission of material goods and of strategies defining succession rights inside the family. [S7]

This is especially important for “personal versus Household” modeling. An asset might be controlled, used, transmitted, or protected through a woman’s dowry or through family succession rules without mapping cleanly to either a modern personal wallet or a Household treasury. The historical question is often a bundle of rights and expectations, not merely the location of a balance.

The v0 protected reserve therefore should not be retrospectively analogized to dowry, inheritance shares, maintenance rights, or legally protected personal property. It is a laboratory safety boundary.

### 3.5 Old Assyrian trader households: separate property and household management coexist

Michel’s work provides strong evidence that personal control and household economic organization can coexist in a way that defeats simple assumptions about a single household head owning or controlling everything. Women in Aššur/Kaneš could manage households, own or acquire houses, appear in wills and purchase contracts, lend, borrow, invest, and act as creditors. [S8–S9]

This makes two opposite overgeneralizations unsafe:

- It would be wrong to infer that Mesopotamian resources were universally “Household property” with no personal rights.
- It would also be wrong to infer that resources were universally personal property made available to the Household only by explicit voluntary contribution.

Veenhof’s source warning is equally important: the Old Assyrian evidence is extraordinarily rich because trader archives survived at Kaneš, which creates a “colonial” and commercial bias. [S10] It is excellent evidence that multiple control arrangements were possible; it is poor evidence for a universal frequency.

### 3.6 Debt can be economically and socially entangled with household continuity

Garfinkle shows credit’s importance in Ur III; Michel documents women as borrowers and lenders in Old Assyrian contexts; Sandowicz shows in late sixth-century Uruk that inheritance could transmit liabilities as well as property, with legal mechanisms around acceptance or disclaimer. [S5, S9, S11]

These periods must not be collapsed into one rule. What they jointly establish is narrower but important: debt is not safely modeled, for historical inference, as an isolated personal claim whose relation to Household resources can be assigned a universal fixed priority. Debt, family patrimony, personal assets, pledges, inheritance, and institutional claims could intersect differently by context.

That observation bears directly on D1: a v0 resolver may choose an order for deterministic laboratory execution, but that order has no historical warrant as a general hierarchy of obligations.

### 3.7 First-millennium evidence reinforces the need for period bounding

Jursa’s first-millennium synthesis addresses an economic environment with extensive monetization, private archives, institutional economies, wage labor, agriculture, business organizations, and market activity on a scale and documentary basis that differ substantially from earlier Mesopotamian contexts. [S12]

Sandowicz’s sixth-century inheritance of debt likewise demonstrates legal possibilities that cannot simply be back-projected to Ur III or Old Babylonian Larsa. [S11]

The correct cross-period inference is therefore not “Mesopotamian households used system X.” It is that resource control was historically variable enough that a general simulation needs either explicit period/status scoping or a deliberately non-historical scaffold until that research is done.

## 4. A — Historical specificity of the current scaffold

No item below is classified as “clearly contradicted by evidence.” The surviving record is too diverse for that strong cross-Mesopotamian claim. Several items are, however, misleading if treated as general semantics.

| Current abstraction | Primary classification | Historical assessment | v0 boundary |
|---|---|---|---|
| **All grain represented as personal stock** | **Likely misleading if treated as general Mesopotamian household semantics** | Separate personal control is historically real in some contexts, but family patrimony, communal/palatial access, institutional holdings, dowry/inheritance, and distributed claims make personal ownership an unsafe universal baseline. [S4, S6–S9] | Acceptable only as the chosen laboratory state container. It must not be cited as evidence that grain or wealth was normally individually owned. |
| **No Household treasury/property pool** | **Likely misleading if treated as general Mesopotamian household semantics** | Family patrimony and public/private “house” organization make the absence of any collective holding/control relation historically non-neutral. [S2, S6, S7] | A useful seam for proving that collective action can remain grounded in persons. It does not test or falsify historical Household property-holding. |
| **Household access only through explicit personal provision commitment** | **Highly period/status dependent** | Historically, access could arise from family claims, inheritance, office, institutional allocation, labor/dependency, patrimonial control, credit, or other embedded relations; explicit voluntary consent is only one possible path. [S5–S9] | Safe as a synthetic access relation if it is never described as the normal historical source of Household material authority. |
| **Protected personal reserve** | **Neutral abstraction** | The exact invariant floor of two grain units has no historical basis established here. Historically separate/protected personal entitlements could exist, but their basis and amount varied by legal/social context. [S7–S9] | Keep it explicitly as a v0 anti-self-destruction / feasibility boundary. Do not analogize it to historical subsistence law, dowry, maintenance, or protected property. |
| **Voluntary office-holder private supplementation** | **Historically plausible as one possible arrangement** | People holding household/institutional authority could also control resources in personal capacities; Old Assyrian evidence particularly demonstrates non-collapsed personal economic agency. [S8–S10] | DEC-0011’s separation of office authority from private-resource consent is historically safer than automatic office seizure. The exact X mechanism remains synthetic and frequency-neutral. |
| **Commitments terminate with participation/dissolution** | **Likely misleading if treated as general Mesopotamian household semantics** | Historical obligations, claims, property interests, and liabilities could survive changes in residence, status, death, or household composition and could enter succession. [S6, S7, S11] | Safe only because HouseholdProvisionCommitment is a project-defined v0 relation, not a claim to model historical obligation. Later obligation/property systems must not inherit this lifecycle automatically. |
| **Fixed-rank contributor allocation** | **Neutral abstraction** | No historical evidence here supports “largest exposed capacity first” or stable-ID tie order as a social allocation rule. | The spec correctly marks stable ID as technical fallback. The entire debit ordering should likewise remain a deterministic accounting device, not evidence about rank, wealth duty, fairness, seniority, or household contribution norms. |
| **Household support to participant** | **Historically plausible as one possible arrangement** | Households and institutional houses organized dependents, consumption, labor, and resource flows, and family economies plainly supported members/dependents in varied ways. [S2, S3, S8–S10] | One-grain support to a NeedsGrain sustaining participant is a proof action, not a historical rationing model or evidence of entitlement/frequency. |
| **One head/representative authorizing material acts** | **Highly period/status dependent** | Heads/representatives are historically intelligible, but authority was not universally unitary. Larsa transactions can involve collective family consent; Old Assyrian women could manage households/property; public households used more complex administrative offices. [S2, S6, S8–S10] | A single scoped head is acceptable as the smallest v0 authority channel. It must not become a general claim that Mesopotamian households had one unilateral material sovereign. |

### Combination effect

The historical risk is stronger in combination than in any one row. Personal-only grain + explicit voluntary commitment + protected personal reserve + no Household balance + single-head authorization can be read as a coherent modern individual-property/contractual ontology even though the project never states that ontology as historical truth.

That is the principal pressure finding. The scaffold is not contaminated merely because it is simple; it becomes contaminated if test outcomes are interpreted as evidence about ownership, voluntarism, authority, or obligation in ancient Mesopotamia.

## 5. B — Laboratory contamination test

### Seed claim 1: Households are persistent higher-order social/economic structures grounded in people, relations, resources, and history

**Can v0 test it? Yes, with a limitation.**

SPEC-SFL-0001 gives Household persistent identity, sustaining participation, history/warrants, a derived mobilizable capacity, material effects, and lifecycle continuity. The resource path is grounded in live people and provenance rather than an unexplained magic Household balance.

What v0 does **not** test is the Seed’s separate long-run proposition that households can be property-holding structures in historically richer senses. The absence of a Household-owned pool means success in v0 is not evidence that property-holding is unnecessary to the eventual model.

### Seed claim 2: Higher-order action arises through intelligible people/offices/resources

**Can v0 test it? Yes, strongly.**

The Household head provides scoped authority; persistent commitments and DEC-0011 private supplementation preserve resource provenance; precommit revalidation makes actual contributors/material state causally relevant; history records the funding legs. This is a legitimate mechanism-laboratory test of grounded collective action.

Historical contamination appears only if the particular conduit is promoted from “one grounded implementation” to “how Mesopotamian households funded action.”

### Seed claim 3: Individual and institutional capacities remain distinct

**Can v0 test it? Yes, and DEC-0011 improves this test.**

DEC-0011 explicitly requires two authorities when the head supplies private grain: role authority validates the Household act, while personal-property authority exposes the exact private term. Office occupancy alone cannot seize personal grain; personal ownership alone cannot authorize the Household act.

This separation is valuable independent of historical frequency. It demonstrates that one person can act in multiple causal capacities without those capacities collapsing.

### Seed claim 4: Household identity does not reduce to residence, kinship, or property alone

**Can v0 test it? Yes.**

DEC-0001 states that no single Household association implies ownership, residence, kinship, support, dependency, and so on. SPEC-SFL-0001 likewise says residence is not ownership; assets/residence/kinship overlap alone do not preserve identity; resource changes do not by themselves break identity when continuity is valid.

The no-treasury scaffold actually helps prove a narrow negative proposition: a persistent Household identity need not be defined by a stored pile of Household-owned goods. That is an ontological test, not historical evidence that real households lacked patrimony.

### Exact distortion to guard against

The v0 resource graph operationalizes collective capacity as:

**personal stock -> explicit conditional exposure -> one authorized Household transaction**

with an optional current-head private term.

If later observers mistake that graph for historical ontology, it will systematically underrepresent at least four historically important possibilities:

1. **patrimonial/collective claims** that are not reducible to a voluntary individual contribution at the moment of use;
2. **institutional or office-linked resource access** that is neither personal property nor a pooled treasury in a modern sense;
3. **obligations and liabilities that persist or transmit** rather than ending with v0 participation;
4. **distributed authority/control rights** among spouses, heirs, kin groups, dependents, creditors, and institutional actors.

This is a serious interpretive distortion, but it does not prevent v0 from testing the narrower causal-grounding questions for which the scaffold was built.

## 6. C — Dangerous future inferences that must not be drawn from v0

Results from this scaffold must not be used to infer any of the following historical conclusions:

1. **Ownership prevalence:** that most grain, movable wealth, land, or productive assets were personally owned rather than family-, institution-, community-, office-, or patrimony-controlled.
2. **Absence of Household property:** that Mesopotamian households normally lacked collective assets, patrimonial claims, common stores, or other non-personal control arrangements.
3. **Voluntarism:** that Household access to resources normally depended on explicit revocable personal consent analogous to HouseholdProvisionCommitment.
4. **Protected-reserve norms:** that contributors historically retained a fixed subsistence reserve, or that two v0 grain units map to any legal/customary protection.
5. **Contribution ordering:** that wealthier/better-stocked contributors were historically debited first, or that contributor order reflected rank, fairness, status, seniority, or custom.
6. **Debt priority:** that Household need or Household spending generally had precedence over debt repayment, or the reverse.
7. **Obligation termination:** that duties to a household ended automatically on exit, dissolution, death, succession, or residence change.
8. **Household-head sovereignty:** that one head normally possessed unilateral material authority for the whole Household.
9. **Gendered authority:** any claim that men or women generally controlled Household resources at a given rate or in a single pattern. The surviving evidence is strongly context-sensitive.
10. **Class/status structure:** any estimate of elite, dependent, servant, slave, free, temple, palace, merchant, rural, or urban resource relations.
11. **Support entitlement/frequency:** that needy participants had a general right to one-grain support, or that the simulated support rate reflects historical provisioning.
12. **Economic efficiency:** that the scaffold demonstrates efficient, welfare-maximizing, rational, fair, or historically stable resource allocation.
13. **Household size/composition:** any demographic inference from the resource mechanism.
14. **Institutional balance:** any inference about the relative weight of private households, temples, palaces, communities, or markets.
15. **Inheritance and dowry norms:** that personal stocks pass, disappear, or remain outside Household control in any historically representative way.
16. **Credit incidence or enforcement:** v0 debt lacks interest, collection/default, pledges, inheritance, and institutional enforcement, so its observed debt behavior cannot calibrate Mesopotamian credit.
17. **Grain as complete wealth:** v0 grain is a fungible proof resource; it cannot stand in for land, houses, silver, livestock, textiles, labor claims, prebends, tools, archives, or other historically differentiated resources.
18. **Historical frequency of private supplementation:** DEC-0011 proves a representable dual-capacity act, not how often office holders funded collective acts privately.
19. **Historical frequency of Household formation/continuity:** resource mechanics used as warrant/support evidence are laboratory criteria, not estimated Mesopotamian social frequencies.
20. **Cross-period universality:** no behavior observed under this scaffold may be generalized simultaneously to Ur III, Old Babylonian, Old Assyrian, Neo-Babylonian, or other periods without new research.

## 7. D — Research trigger before a richer resource model replaces the scaffold

A later redesign should not begin with “add a treasury.” It should begin by establishing the historical target and the bundle of rights/obligations the model is intended to represent.

Before replacing the v0 resource scaffold, historical research should establish at least the following.

### 7.1 Target scope

- period(s), polity/city/region, and chronological resolution;
- social strata/status groups to be represented;
- whether the target is domestic households, elite houses, merchant houses, institutional households, rural groups, or a deliberately comparative mixture;
- which source corpora are representative enough for each target and which are archive-biased.

### 7.2 Resource classes

For each historically important resource class, research should distinguish where possible:

- grain/food stocks;
- land and orchards;
- houses/urban real estate;
- livestock;
- silver and other valuables;
- textiles and trade goods;
- tools/production assets;
- labor/service claims;
- debts/credits/pledges;
- institutional allotments, offices, prebends, or analogous entitlements.

A later model should not assume that all of these share the same possession/transfer rules merely because v0 grain is fungible.

### 7.3 Rights and control bundles

For each resource class and social context, determine the evidence for:

- possession/custody;
- use and consumption;
- management;
- income/benefit rights;
- alienation/sale;
- pledge/encumbrance;
- inheritance;
- dowry/marriage transfer;
- gift;
- institutional recall or conditional tenure;
- collective consent requirements;
- usufruct or life-interest-like arrangements where the evidence supports them.

The research question should be “who could do what with this resource, under what conditions?” rather than “who owned it?” alone.

### 7.4 Household authority and consent

Establish the documented roles of:

- spouses;
- parents/children;
- siblings/heirs;
- widows/widowers;
- household heads or senior representatives;
- dependents;
- creditors;
- institutional officials.

Determine when one person could act alone, when multiple family members appeared as necessary/strategic consenters, and when the documentary appearance of one actor may reflect archive/scribal convention rather than sole substantive authority.

### 7.5 Obligation and lifecycle

Research must establish, by target period/context:

- what obligations survived death, marriage, household change, succession, or dissolution;
- whether and how debts/claims passed to heirs or estates;
- how maintenance/dependency obligations were organized;
- effects of adoption, inheritance, dowry, widowhood, and remarriage;
- how institutional claims intersected with family resources.

This is necessary before inheriting v0’s “commitment ends with participation/dissolution” behavior into any richer system.

### 7.6 Institutional interfaces

A richer model needs evidence about the interface among:

- domestic/private households;
- temple institutions;
- palace/royal administration;
- communities;
- merchants/creditors;
- labor/dependent populations.

The research must establish which distinctions are meaningful for the chosen period rather than importing a modern household/firm/state separation.

### 7.7 Calibration discipline

Only after the categories above are established should research attempt frequencies or probabilities. Any quantitative calibration must record:

- source corpus;
- period/place/status denominator;
- preservation/genre bias;
- whether the quantity is directly observed, reconstructed, or assumed;
- uncertainty range and scholarly disagreement.

Completion of these research steps should trigger a design decision. They do not themselves prescribe whether the richer implementation should use personal balances, household pools, claims graphs, ledgers, offices, estates, or another representation.

## 8. E — D1–D6 historical coupling

The six D1–D6 items are still proposal-only in SFL_V0_SLICE4_SID_OPEN_SEMANTIC_DECISIONS.md on the examined base. Historical research should therefore bound their interpretation before any promotion, but should not be treated as authority deciding them.

| Decision | Historical coupling | Pressure-test result | Required nonclaim boundary |
|---|---|---|---|
| **D1 — Household provision priority versus RepayDebt** | **High** | A fixed Household-over-repayment resolver is not supported as a general historical hierarchy. Credit and family/institutional obligations were context-dependent, and liabilities could be deeply entangled with patrimony. [S5, S11] | If D1 A is adopted, state that it is a v0 same-cycle conflict-resolution rule only. It says nothing about historical priority, enforceability, moral importance, or frequency of debt versus household claims. |
| **D2 — snapshot-bound consent cohort for bridge entry/succession** | **Low** | Primarily a temporal/consent-cohort closure rule. Historical evidence here neither validates nor falsifies the same-snapshot construction. | Do not label snapshot consent mechanics historically representative. |
| **D3 — head as needy Household-support recipient** | **Medium** | It is historically plausible that an authority-holder could also be a beneficiary/dependent in another capacity, but no generic frequency or entitlement follows. | Treat dual capacity as a semantic possibility, not evidence of head privilege, Household welfare law, or typical conflict-of-interest practice. |
| **D4 — current head creating/reconsidering own persistent provision commitment** | **High** | Separate personal resource authority alongside Household authority is historically possible, especially in the Old Assyrian material, but making explicit individual consent the sole route to standing Household access would be historically over-specific. [S8–S10] | If D4 A is adopted, define the commitment as a synthetic v0 access relation. “Personal-property consent” must not be read as a universal Mesopotamian property regime, and office-holding must not imply that all other Household resources are personal until voluntarily committed. |
| **D5 — self-nomination for Household head** | **Low to medium** | Resource coupling is indirect, but because the head controls the only v0 Household material-action channel, head-selection semantics can look more historically consequential than they are. | Self-nomination/collapsed self-consent is a laboratory governance mechanic, not an asserted historical appointment norm. |
| **D6 — head-role appointment while Household is Inactive** | **Low to medium** | This tests persistence of role capacity apart from active Household initiative. It does not establish a historical institution/lifecycle rule. | Keep “Inactive,” role vacancy, and reactivation explicitly internal to v0. |

### D1 specific warning

The Master Architect’s proposed D1 A rationale is mechanically coherent with existing v0 semantics: debt does not reserve grain, while Household provision has an accepted material priority class. Historical research does not provide a reason to prefer that ordering.

Accordingly, historical evidence should neither block nor justify D1 A. The safe statement is only that deterministic laboratory resolution needs an explicit order and that this choice is not a historical hierarchy of obligations.

### D4 specific warning

D4 A is also mechanically coherent with DEC-0011’s distinction between office authority and private-resource consent. Historically, that separation is plausible: the evidence does not support an automatic rule that office occupancy absorbs all resources of the office holder.

The danger lies in the opposite inference. If every standing Household resource path is modeled as a person voluntarily exposing personally owned grain, the simulation may silently teach an atomized property model. D4 can be retained as a v0 dual-capacity test only if the project explicitly refuses that inference.

### Overall D1–D6 finding

None of D2, D3, D5, or D6 creates a new historical-resource blocker by itself. D1 and D4 are the two decisions whose wording or future interpretation could most directly universalize provisional resource assumptions. They should be promoted, if at all, only with explicit non-historical framing in the authoritative semantics and verification commentary.

## 9. Project-specific boundary recommendations

These are boundary recommendations, not a final resource design.

1. **Name the current resource subsystem for what it is:** a synthetic v0 material-grounding scaffold, not a Mesopotamian household economy model.
2. **Keep the existing explicit exclusions visible wherever results are interpreted:** full economy/agriculture/property law and historical calibration remain out of scope.
3. **Treat personal grain as a state container, not an ownership thesis.** “Personal grain stock” must not silently imply that all historical claims over that grain belong exclusively to the person.
4. **Treat HouseholdProvisionCommitment as a proof relation, not a reconstructed legal/social institution.** Its explicit acceptance, reserve boundary, and termination semantics are model conveniences until historically researched.
5. **Keep fixed-rank allocation and conflict priorities non-social.** They establish determinism and material closure; they must not acquire language of customary rank, fairness, duty, historical seniority, or normal priority.
6. **Keep the head role scope-limited.** The current one-head authorization path proves grounded institutional action, not universal household sovereignty. Future historical research must remain free to discover distributed, gendered, kin-based, office-based, or collective authority.
7. **For D1, add an express historical nonclaim before promotion:** the resolver order does not represent historical precedence of Household provision over debt repayment.
8. **For D4, add an express historical nonclaim before promotion:** the self-commitment route demonstrates dual capacity but does not imply general individual ownership or voluntary-contract foundations for Household resources.
9. **Do not validate the Seed’s “property-holding household” aspiration from v0 results.** v0 demonstrates resource-grounded action without Household-owned property; property-holding remains an untested later historical/modeling question.
10. **Do not tune later behavior to v0 emergent frequencies.** Any frequency involving provision, support, debt conflict, private supplementation, or head-funded action requires its own period/status research.
11. **Preserve replaceability at the seam.** Future historical models must be able to replace personal-stock/commitment semantics without rewriting Household identity, causal history, individual/institutional authority separation, or the observation machinery that v0 is actually testing.

## 10. Uncertainty and disagreement

### 10.1 “Private property” is a contested analytical category

Renger’s long-run survey and Rede’s Larsa work both show why an apparently simple ownership question can be misleading. Sale/alienation does not automatically imply modern absolute private property, and family, communal, palatial, and institutional claims can coexist. [S4, S6]

This report therefore prefers “control,” “claim,” “possession,” “right,” “patrimony,” and specific powers such as alienation or inheritance where possible.

### 10.2 Archive survival biases the social groups we can see

Old Assyrian evidence is unusually rich for merchant families precisely because private trader archives from Kaneš survived. Veenhof explicitly cautions that this creates a commercial and colonial bias. [S10] It would be wrong to use those women’s substantial economic agency to estimate all Mesopotamian women’s authority; it is equally wrong to build a universal male-head model that cannot represent such agency.

Larsa land-sale archives likewise foreground successful transactions and title histories rather than every ordinary act of use or household provisioning. Rede notes that buyer-side archive formation shapes what survives. [S6]

### 10.3 Legal/normative texts are not frequency tables

Inheritance, dowry, loan, will, and sale documents establish possible and enforceable arrangements in their contexts. They do not directly tell us how often each arrangement occurred in the full population.

### 10.4 Period differences are substantive

Ur III institutional economies, Old Babylonian Larsa patrimonial land practice, Old Assyrian merchant households, and first-millennium Babylonian business/legal environments are not interchangeable samples of one timeless system. [S5, S6, S8–S12]

### 10.5 Household language itself spans scales

Ur and Gelb show that “house” organization can bridge domestic and institutional scales. That is useful for the Project Seed, but it also means the project should not assume that a mechanic suitable for a small domestic Household automatically scales to temple, palace, or elite institutional households without further evidence.

## 11. Bottom line

The current resource scaffold is historically too specific to be interpreted as a general model of Mesopotamian household property or obligation, but it remains adequate for the narrower SFL v0 laboratory purpose because the accepted specification already treats historical calibration/property law as out of scope and because the scaffold preserves the causal properties the laboratory needs: people remain real resource holders in the model, Household action is not magical, office authority and private capacity stay distinguishable, resource provenance is inspectable, and Household identity is not reduced to a balance.

The boundary that must survive reconciliation is therefore simple: **v0 may demonstrate how one deliberately artificial grounded-resource mechanism behaves; it may not establish how Mesopotamian households generally owned, controlled, obligated, inherited, prioritized, or spent resources.** A richer resource model should be reopened only after research selects a bounded historical target and reconstructs the relevant bundles of control, obligation, authority, lifecycle, and institutional interface.
