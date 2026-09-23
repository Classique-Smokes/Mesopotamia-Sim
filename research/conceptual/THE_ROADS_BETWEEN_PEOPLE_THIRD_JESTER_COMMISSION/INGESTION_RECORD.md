# Ingestion Record — The Roads Between People / Third Jester Commission

**Status:** SOURCE INGESTION VERIFIED  
**Collection:** `THE_ROADS_BETWEEN_PEOPLE_THIRD_JESTER_COMMISSION`  
**Authority:** None; conceptual observer-source preservation only  
**Original uploaded bundle:** `THE_ROADS_BETWEEN_PEOPLE_THIRD_JESTER_COMMISSION.zip`

## Bundle identity

- ZIP SHA-256: `e9bf99485b04d131ae05be27b1ece009bdbba73861e720e56d6508f17409923f`
- ZIP itself was **not** committed.
- Individual readable Markdown members were extracted and committed as exact source bytes.
- The large combined anthology was preserved losslessly as Brotli, following the existing Uruk archive precedent.

## Exact source verification

| Original member | Bytes | Original SHA-256 | Committed Git blob |
|---|---:|---|---|
| `README.md` | 1,054 | `5e294eaf95f97942d52e9eeab0aeb4cc4711e1ca79700cc42cb811896182e269` | `ec4685122819ee69753f1fa13c6f4c5899b112ea` |
| `COMMISSION_SLATE.md` | 5,578 | `0f56d2aae15e6efa9891ab2ba1b80aa1bcd1a9768726a720274bd6eaf6a0241f` | `7fe99a5e8372211559350d1073d992fa81353b25` |
| `OBSERVER_NOTE.md` | 2,583 | `3470453e5bf7d3abdbd9cb310a42f064baeb5fdfa52c4d327b73da241ced337b` | `0d3eb54c74a178d04009da21e9e26fbf9d1d840e` |
| `THE_MAN_INTRODUCED_BY_ANOTHER_MAN.md` | 8,312 | `091ece2c5f0002a65f7f75381830d22bec0f12fb218738e8f1a156989eb49b3c` | `437bcd08d8fc9ef7cbebeac904be9d25c99b5486` |
| `THE_HOUSE_THAT_KNEW_A_MAN_WHO_NEVER_ENTERED_IT.md` | 8,992 | `d45969547591edf2504738cf0030f2ae2768b45e24a27eaf35e2740d09c2f291` | `d05877c69a8f5cf5a0216ba6c255afe061360ae4` |
| `THE_WOMAN_EVERYONE_HAD_HEARD_OF.md` | 7,629 | `21b244b144ab1ab9f0172b1bc17052111af8889a4fc0918ac1267bf7b5fba797` | `a28a319583737660c922ddf9e282ac7fda2198c4` |
| `THE_BRIDGE_EVERYONE_NEEDED.md` | 8,133 | `4f6fc1f2fc195a6a55483cdbaf0589f9921e9635f8a6885c19dfde5f40478a97` | `2b78d66b518c38d53193d0cf60fcafe91b09e685` |
| `THE_TWO_QUARTERS_THAT_REMEMBERED_DIFFERENT_FIRES.md` | 9,583 | `d771d4bd3aa2d4bb7fa57019af70ba92691ad4caa2e28060dc28b0f09b7e5203` | `5966bf9103e9934bb4336c298e07bd4a4fa0c811` |

All readable committed blobs match the Git blob identities calculated from the exact uploaded bytes.

## Combined anthology preservation

Original member:

- filename: `THE_ROADS_BETWEEN_PEOPLE_ANTHOLOGY.md`
- original bytes: **43,009**
- original SHA-256: `d0fd321f55af05cde7a5bdb08f625278bbc5440d9be0ccd3772ec0f5d0438248`
- original Git blob identity: `8e2f88c368f54334b5787f0cb0825698ee87e8b3`

Preserved as:

- `THE_ROADS_BETWEEN_PEOPLE_ANTHOLOGY.md.br`
- Brotli bytes: **12,554**
- Brotli SHA-256: `9d31ba48999d74e4c7ddfd1d49279c6c97102169b19904b801d0fff756e8547f`
- committed Git blob: `297db28929bc98a1255d1acbe09517270d5be1d7`

Restore locally:

```sh
brotli -d -c THE_ROADS_BETWEEN_PEOPLE_ANTHOLOGY.md.br > THE_ROADS_BETWEEN_PEOPLE_ANTHOLOGY.md
sha256sum THE_ROADS_BETWEEN_PEOPLE_ANTHOLOGY.md
```

The restored SHA-256 must equal the original hash above.

## Interpretation boundary

This record proves source preservation only.

No claim in this collection has been promoted into:

- accepted SFL semantics;
- architecture;
- implementation scope;
- historical evidence;
- the Institutional Dynamics synthesis.

Master Architect systematization is deliberately deferred to a separate derived artifact so the source tablets remain untouched.
