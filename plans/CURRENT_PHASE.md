# Current Phase — Foundational Architecture

**Status:** Operational plan; not simulation authority.

## Goal

Select a maintainable implementation architecture and host runtime for the first Social Fabric Laboratory without redefining accepted simulation semantics.

## Completed

- Project governance and Master Architect operating model established.
- DEC-0001 Social-Fabric Model accepted.
- ADR-0001 representation and ADR-0002 individual agency accepted.
- DEC-0005 Architecture Development Policy accepted.
- ADR-0003 Progressive Derived-State Specialization accepted.
- RES-0001, TRES-0001, and TRES-0002 Stage I completed.
- Household organization, execution/time, and history/recovery conceptually surveyed as working semantic inputs.

## Active

**Prototype specification preparation — Social Fabric Laboratory v0.**

Host-independent kernel accepted: `architecture/accepted/ADR-0004_REFERENCE_SIMULATION_KERNEL.md`.

Active research spec: `research/technical/TRES-0002/HOST_RUNTIME_BAKEOFF.md`

Adversarial host review: `research/technical/TRES-0002/CSHARP_DOTNET_ADVERSARIAL_REVIEW.md`.

Implementation-risk context: `architecture/working/CSHARP_DOTNET_ENGINEERING_GUARDRAILS.md`.

The earlier A-vs-B derived-state fork is resolved: start simple and promote individual derived-state subsystems to stronger incremental maintenance only when measured need justifies it.

Approved downstream roadmap: `plans/FIRST_PROTOTYPE_DEVELOPMENT_ROADMAP.md`.

## Next

1. Define a language-neutral benchmark/bake-off workload representing the accepted semantic kernel.
2. Compare the credible host/runtime finalists on that common workload.
3. Reconcile the results into the implementation-architecture recommendation. **Complete.**
4. Run fresh adversarial review. **Complete: no architecture-level blocker found.**
5. Obtain explicit approval for the host/runtime and whole-system implementation architecture. **Host/runtime complete: C# 14 / .NET 10 LTS accepted; reference kernel already accepted.**
6. Write the bounded prototype rule specification and verification scenarios.
7. Run subsystem-specific technical design research only where unresolved risk still warrants it.
8. Prepare the PROJECT-CONTEXT implementation packet.

Derived-state break-even benchmarking is deferred until a concrete subsystem needs promotion beyond simple maintenance; it is no longer a blocker for the first architecture.
