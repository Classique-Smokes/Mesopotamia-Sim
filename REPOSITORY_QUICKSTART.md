# Repository Quickstart

This repository is now the canonical working copy of the project.

## Recommended local setup

If you received `MESOPOTAMIA_SIMULATION.bundle`:

```bash
git clone MESOPOTAMIA_SIMULATION.bundle mesopotamia-simulation
cd mesopotamia-simulation
git status
git log --oneline --decorate --graph
```

The repository starts on `main` at tag `architecture-foundation-v0.1`.

## Normal working habit

You do not need to manage Git ceremony during design conversations. The Master Architect should identify which canonical files need updates and prepare coherent changes. Before implementation agents start persistent code work, keep the repository clean and commit accepted/checkpointed project state at meaningful boundaries.

Useful commands:

```bash
git status                      # What changed?
git diff                        # What changed inside files?
git log --oneline --decorate    # Recent history
git show architecture-foundation-v0.1
```

## Authority reminder

A Git commit preserves project state; it does not itself grant authority. Working notes remain non-authoritative when their files say so. Accepted decisions/specifications become authoritative through the project's approval process.
