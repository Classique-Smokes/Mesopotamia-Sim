# 00 — Intake Manifest

**Intake date:** 2026-09-23  
**Repository:** `Classique-Smokes/Mesopotamia-Sim`  
**Working branch:** `research/wg-native-perspective-response-intake-2026-09-23`  
**Branch basis:** `main` at `60a466eee43c1820e4009f61fecc262acaa6864c`  
**Status:** source frozen for analysis; no promotion implied

## Delivered questionnaire

- Filename: `A_TABLET_OF_QUESTIONS_SENT_ACROSS_THE_BORDER.md`
- Lines: 222
- SHA-256: `486d13bb169f277dbeee10fd9b30550bed768fdf422c442579ca0f61244f9653`
- Delivery condition reconstructed from screenshot: attached into the existing Wonder Gather development conversation without an additional substantive explanatory prompt from Luis.

## Pre-delivery control protocol

- Filename: `PRIVATE_DELIVERY_PROTOCOL_FOR_LUIS.md`
- SHA-256: `57dbadd25c46b805504935ed9093fe7b7dea3fd606bfcb1d9bb1ab3671d1332c`
- Purpose: constrain the first pass to the exact public questionnaire, preserve the same high-context Wonder Gather responder where possible, withhold Uruk's interpretations and the private observer sheet, and freeze the first response before discussion.
- Repository copy: `source/PRIVATE_DELIVERY_PROTOCOL_FOR_LUIS.md`

The preserved protocol independently supports the intended anti-anchoring condition. It also explicitly references a **private observer sheet**. During intake closure, no separately preserved byte-identical copy of that pre-delivery sheet was located among the repository and accessible Library artifacts. Therefore `analysis/14_OBSERVER_SHEET_RECONCILIATION.md` preserves the observer dimensions used during intake, but the exact pre-delivery wording/order of that sheet cannot be independently byte-verified. This limitation does not affect the identity of the delivered questionnaire, screenshot, or received response artifact; it only limits claims that depend on exact observer-sheet phrasing.

## Delivery evidence

- Screenshot filename: `Screenshot_2026-09-23-17-49-24-368_com.whatsapp.jpg`
- SHA-256: `aa1cfc6d8264ad95c70007a6e0c14645cf88366e3db6a29faa1cac301b5130ae`
- Visible responder declaration:
  - it would treat the tablet as the request itself;
  - answer from the current Wonder Gather repository including the merged Conservatory layer;
  - avoid merely repeating the older handoff;
  - turn the result into a clean handoff to send back across the border.

This means the first-pass response was **blind with respect to Uruk's hidden analytical conclusions**, but **not context-free**: it was produced inside Wonder Gather's existing high-context conversation and current repository state, by design.

## Received response artifact

- Filename: `Wonder_Gather_High_Fidelity_Project_Handoff_2026-09-23_PHONE.pdf`
- PDF title metadata: `Wonder Gather - High-Fidelity Project Handoff`
- Pages: 82
- Bytes: 267,418
- SHA-256: `c72cedef26e6766c1ef882e3676632b3772188ff74b59d270b36dd87e1468aff`
- PDF creation timestamp: 2026-09-23 20:21:55 UTC
- Producer: iOS Quartz PDFContext
- Declared repository snapshot: `MacquePanoramix/Modular-RTS`
- Declared current main head: `d03e0456f0399cd2ad9d1faecfce636f54fe6c47` — `Add lightweight Wonder Gather continuity layer`
- Declared gameplay milestone: `The Living Body`
- Declared lifecycle: `Technical Ready - Game Director playtest pending`

## Analysis extraction

- Local text extraction method: `pdftotext -layout`
- Extracted lines: 3,052
- Extracted bytes: 69,486
- Extract SHA-256: `f5b3ae94b3d1d07131dc326072ccddd227f7b385cf36ffda821f278ddba64d6d`

The PDF was also rendered page-by-page and visually scanned before structural analysis. No hidden alternate questionnaire-response section was found outside the parsed text.

Repository parsed-text archive: `source/WONDER_GATHER_HIGH_FIDELITY_PROJECT_HANDOFF_2026-09-23_PARSED.md` (Files-reader extraction with preserved page markers; source PDF hash above remains the byte-level identity anchor).

## Provenance finding at intake

The response is **not formatted as twelve direct answers**. It is a transformed response artifact: a high-fidelity project handoff generated after receipt of the tablet.

The responder's own visible preamble establishes that this format choice was deliberate. Therefore the handoff must not be rejected as the wrong file merely because it resembles an earlier handoff genre.

The correct first analytical question is not "did it answer each question in order?" but:

> Which questionnaire problems did the responder answer directly, answer indirectly through project description, transform into a different framing, or omit?

That mapping is preserved in `02_QUESTION_COVERAGE_AUDIT.md` before any deeper interpretation.

## Intake-closure verification

On 2026-09-23, closure verification independently confirmed:

- the accessible source PDF is 267,418 bytes and hashes to `c72cedef26e6766c1ef882e3676632b3772188ff74b59d270b36dd87e1468aff`;
- the accessible delivery screenshot hashes to `aa1cfc6d8264ad95c70007a6e0c14645cf88366e3db6a29faa1cac301b5130ae`;
- the preserved pre-delivery protocol hashes to `57dbadd25c46b805504935ed9093fe7b7dea3fd606bfcb1d9bb1ab3671d1332c`;
- the repository parsed-response archive contains exactly one preserved page marker for each page 1 through 82;
- the twelve question-bounded analysis packets are present;
- the branch remains research-only and does not promote any response content into simulation semantics, architecture, or implementation authority.

The exact pre-questionnaire older high-fidelity handoff remains an unresolved comparison control, as recorded in the final synthesis.
