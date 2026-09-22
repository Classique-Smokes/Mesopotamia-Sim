# Artifact Freeze Checklist

**Status:** ACCEPTED — supporting mechanical checklist  
**Purpose:** Prevent identity/provenance mistakes when a reviewed artifact is frozen for downstream use.  
**Load when:** freezing a reviewed acceptance, governance, migration, or other consequential artifact.  
**Do not load merely because:** a normal Markdown file is committed.

## Checklist

1. Identify the exact candidate artifact and the ref/commit against which it was reviewed.
2. Record the reviewed candidate content SHA before making any administrative freeze edit.
3. Confirm the review result actually authorizes freeze and names no outstanding repair.
4. Make only authorized administrative/status/provenance edits after review. If substantive content changes, re-review.
5. Diff the freeze edit against the reviewed candidate and verify no operative rule/row/status/evidence obligation changed.
6. Assign a version/name that downstream tasks can cite.
7. Pin an immutable ref/commit when downstream work depends on exact bytes.
8. Avoid self-referential hashing:
   - a file may record the **reviewed candidate SHA**;
   - the **final frozen file SHA/commit** should live outside that file in a freeze record or immutable ref.
9. Record the final frozen SHA/commit and review provenance in the external freeze record.
10. Update the smallest navigation/operational surfaces needed for future retrieval.
11. Verify downstream task packets reference the frozen version/ref/SHA rather than a moving or ambiguous artifact.
12. Any later operative change requires a new version/freeze cycle rather than silently moving the existing frozen identity.

## Completion test

A freeze is complete when a fresh agent can determine, without chat history:

- what exact content was reviewed;
- what exact artifact is frozen;
- which review authorized it;
- whether the post-review diff was administrative only;
- what ref/SHA downstream work must use;
- how a future change would be versioned.
