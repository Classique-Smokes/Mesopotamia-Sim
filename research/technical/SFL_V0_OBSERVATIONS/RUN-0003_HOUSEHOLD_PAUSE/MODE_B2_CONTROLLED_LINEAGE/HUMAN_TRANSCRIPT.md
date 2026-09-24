# Mode B2 — Controlled Lineage — Mechanical Transcript

Generated mechanically from production simulation surfaces. No interpretation is included.

### Stable state — Initial
- P1: grain=12; need=False; dwelling=D1
- P2: grain=12; need=False; dwelling=D1
- P3: grain=12; need=False; dwelling=D1
- P4: grain=12; need=False; dwelling=D1
- P5: grain=12; need=False; dwelling=D1
- P6: grain=12; need=False; dwelling=D1
- Households: none
- P1 epistemic: candidates=[C1:Unknown]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Unknown]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 1 — predecessor-support-p1-p3

### Decisions
- P3 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=1; actor=P1; kind=Committed; reason=; event=E9

### Semantic events
- E1 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E2 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E3 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E4 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E5 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E6 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E7 r6: Proposal; participants=[P1]; causes=[]; fallback=False; detail=OfferGift(3,1)
- E8 r7: Response; participants=[P3]; causes=[E7]; fallback=False; detail=Accept
- E9 r8: Gift; participants=[P1,P3]; causes=[E8]; fallback=False; detail=OfferGift(3,1)
- E10 r9: AttitudeComposition; participants=[P3,P1]; causes=[E9]; fallback=False; detail=0->10

### Stable state — predecessor-support-p1-p3
- P1: grain=10; need=False; dwelling=D1
- P2: grain=11; need=False; dwelling=D1
- P3: grain=12; need=False; dwelling=D1
- P4: grain=11; need=False; dwelling=D1
- P5: grain=11; need=False; dwelling=D1
- P6: grain=11; need=False; dwelling=D1
- Households: none
- P1 epistemic: candidates=[C1:Unknown]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Unknown]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 2 — predecessor-support-p3-p2

### Decisions
- P2 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=2; actor=P3; kind=Committed; reason=; event=E19

### Semantic events
- E11 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E12 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E13 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E14 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E15 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E16 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E17 r6: Proposal; participants=[P3]; causes=[]; fallback=False; detail=OfferGift(2,1)
- E18 r7: Response; participants=[P2]; causes=[E17]; fallback=False; detail=Accept
- E19 r8: Gift; participants=[P3,P2]; causes=[E18]; fallback=False; detail=OfferGift(2,1)
- E20 r9: AttitudeComposition; participants=[P2,P3]; causes=[E19]; fallback=False; detail=0->10

### Stable state — predecessor-support-p3-p2
- P1: grain=9; need=False; dwelling=D1
- P2: grain=11; need=False; dwelling=D1
- P3: grain=10; need=False; dwelling=D1
- P4: grain=10; need=False; dwelling=D1
- P5: grain=10; need=False; dwelling=D1
- P6: grain=10; need=False; dwelling=D1
- Households: none
- P1 epistemic: candidates=[C1:Unknown]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Recognized]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 3 — predecessor-communicate-cycle2-support-to-p1

### Decisions

### Outcomes
- proposal=3; actor=P3; kind=Committed; reason=; event=E28

### Semantic events
- E21 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E22 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E23 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E24 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E25 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E26 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E27 r6: Proposal; participants=[P3]; causes=[]; fallback=False; detail=CommunicateClaim(1,HeldFact { Evidence = EvidenceId { Value = 1119 } })
- E28 r7: Communication; participants=[P3,P1]; causes=[E27]; fallback=False; detail=CommunicateClaim(1,HeldFact { Evidence = EvidenceId { Value = 1119 } })

### Stable state — predecessor-communicate-cycle2-support-to-p1
- P1: grain=8; need=False; dwelling=D1
- P2: grain=10; need=False; dwelling=D1
- P3: grain=9; need=False; dwelling=D1
- P4: grain=9; need=False; dwelling=D1
- P5: grain=9; need=False; dwelling=D1
- P6: grain=9; need=False; dwelling=D1
- Households: none
- P1 epistemic: candidates=[C1:Recognized]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Recognized]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 4 — predecessor-communicate-cycle1-support-to-p2

### Decisions

### Outcomes
- proposal=4; actor=P3; kind=Committed; reason=; event=E36

### Semantic events
- E29 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E30 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E31 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E32 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E33 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E34 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E35 r6: Proposal; participants=[P3]; causes=[]; fallback=False; detail=CommunicateClaim(2,HeldFact { Evidence = EvidenceId { Value = 1105 } })
- E36 r7: Communication; participants=[P3,P2]; causes=[E35]; fallback=False; detail=CommunicateClaim(2,HeldFact { Evidence = EvidenceId { Value = 1105 } })
- E37 r8: CandidateRecognitionEstablished; participants=[P1]; causes=[E9,E10,E19,E28]; fallback=False; detail=Candidate:1
- E38 r9: CandidateRecognitionEstablished; participants=[P2]; causes=[E19,E20,E9,E36]; fallback=False; detail=Candidate:1
- E39 r10: CandidateRecognitionEstablished; participants=[P3]; causes=[E9,E10,E19,E20]; fallback=False; detail=Candidate:1
- E40 r11: HouseholdFormation; participants=[P1,P2,P3]; causes=[E37,E38,E39,E9,E19]; fallback=False; detail=Household:1;Warrant:1;Candidate:1
- E41 r12: SustainingParticipationFounded; participants=[P1]; causes=[E40]; fallback=False; detail=Household:1;Association:1;Warrant:1
- E42 r13: SustainingParticipationFounded; participants=[P2]; causes=[E40]; fallback=False; detail=Household:1;Association:2;Warrant:1
- E43 r14: SustainingParticipationFounded; participants=[P3]; causes=[E40]; fallback=False; detail=Household:1;Association:3;Warrant:1
- E44 r15: HouseholdRecognitionAcquired; participants=[P1,P2,P3]; causes=[E40]; fallback=False; detail=Household:1;Warrant:1

### Stable state — predecessor-communicate-cycle1-support-to-p2
- P1: grain=7; need=False; dwelling=D1
- P2: grain=9; need=False; dwelling=D1
- P3: grain=8; need=False; dwelling=D1
- P4: grain=8; need=False; dwelling=D1
- P5: grain=8; need=False; dwelling=D1
- P6: grain=8; need=False; dwelling=D1
- H1: lifecycle=Active; participants=[P1,P2,P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 5 — p1-exits-predecessor

### Decisions

### Outcomes
- proposal=5; actor=P1; kind=Committed; reason=; event=E54

### Semantic events
- E45 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E46 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E47 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E48 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E49 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E50 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E51 r6: AttitudeDecay; participants=[P3,P1]; causes=[]; fallback=False; detail=10->8
- E52 r7: AttitudeDecay; participants=[P2,P3]; causes=[]; fallback=False; detail=10->8
- E53 r8: Proposal; participants=[P1]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E54 r9: HouseholdParticipationEnded; participants=[P1]; causes=[E53]; fallback=False; detail=Household:1;Warrant:2;Association:1
- E55 r10: HouseholdContinued; participants=[P1]; causes=[E54,E40]; fallback=False; detail=Household:1;Warrant:3;Previous:1;Transition:2
- E56 r11: HouseholdRecognitionAcquired; participants=[P1]; causes=[E55]; fallback=False; detail=Household:1;Warrant:3

### Stable state — p1-exits-predecessor
- P1: grain=6; need=False; dwelling=D1
- P2: grain=8; need=False; dwelling=D1
- P3: grain=7; need=False; dwelling=D1
- P4: grain=7; need=False; dwelling=D1
- P5: grain=7; need=False; dwelling=D1
- P6: grain=7; need=False; dwelling=D1
- H1: lifecycle=Active; participants=[P2,P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 6 — p2-exits-predecessor

### Decisions

### Outcomes
- proposal=6; actor=P2; kind=Committed; reason=; event=E64

### Semantic events
- E57 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E58 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E59 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E60 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E61 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E62 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E63 r6: Proposal; participants=[P2]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E64 r7: HouseholdParticipationEnded; participants=[P2]; causes=[E63]; fallback=False; detail=Household:1;Warrant:4;Association:2
- E65 r8: HouseholdContinued; participants=[P2]; causes=[E64,E55]; fallback=False; detail=Household:1;Warrant:5;Previous:3;Transition:4
- E66 r9: HouseholdRecognitionAcquired; participants=[P2]; causes=[E65]; fallback=False; detail=Household:1;Warrant:5
- E67 r10: HouseholdLifecycle; participants=[P3]; causes=[E64,E65]; fallback=False; detail=Household:1;Inactive

### Stable state — p2-exits-predecessor
- P1: grain=5; need=False; dwelling=D1
- P2: grain=7; need=False; dwelling=D1
- P3: grain=6; need=False; dwelling=D1
- P4: grain=6; need=False; dwelling=D1
- P5: grain=6; need=False; dwelling=D1
- P6: grain=6; need=False; dwelling=D1
- H1: lifecycle=Inactive; participants=[P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 7 — fresh-postexit-support-p1-p2

### Decisions
- P2 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=7; actor=P1; kind=Committed; reason=; event=E76

### Semantic events
- E68 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E69 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E70 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E71 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E72 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E73 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E74 r6: Proposal; participants=[P1]; causes=[]; fallback=False; detail=OfferGift(2,1)
- E75 r7: Response; participants=[P2]; causes=[E74]; fallback=False; detail=Accept
- E76 r8: Gift; participants=[P1,P2]; causes=[E75]; fallback=False; detail=OfferGift(2,1)
- E77 r9: AttitudeComposition; participants=[P2,P1]; causes=[E76]; fallback=False; detail=0->10

### Stable state — fresh-postexit-support-p1-p2
- P1: grain=3; need=False; dwelling=D1
- P2: grain=7; need=False; dwelling=D1
- P3: grain=5; need=False; dwelling=D1
- P4: grain=5; need=False; dwelling=D1
- P5: grain=5; need=False; dwelling=D1
- P6: grain=5; need=False; dwelling=D1
- H1: lifecycle=Inactive; participants=[P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 8 — fresh-postexit-support-p2-p1

### Decisions
- P1 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=8; actor=P2; kind=Committed; reason=; event=E86

### Semantic events
- E78 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E79 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E80 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E81 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E82 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E83 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E84 r6: Proposal; participants=[P2]; causes=[]; fallback=False; detail=OfferGift(1,1)
- E85 r7: Response; participants=[P1]; causes=[E84]; fallback=False; detail=Accept
- E86 r8: Gift; participants=[P2,P1]; causes=[E85]; fallback=False; detail=OfferGift(1,1)
- E87 r9: AttitudeComposition; participants=[P1,P2]; causes=[E86]; fallback=False; detail=0->10

### Stable state — fresh-postexit-support-p2-p1
- P1: grain=3; need=False; dwelling=D1
- P2: grain=5; need=False; dwelling=D1
- P3: grain=4; need=False; dwelling=D1
- P4: grain=4; need=False; dwelling=D1
- P5: grain=4; need=False; dwelling=D1
- P6: grain=4; need=False; dwelling=D1
- H1: lifecycle=Inactive; participants=[P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Checkpoint — declare-successor-candidate

### Stable state — declare-successor-candidate
- P1: grain=3; need=False; dwelling=D1
- P2: grain=5; need=False; dwelling=D1
- P3: grain=4; need=False; dwelling=D1
- P4: grain=4; need=False; dwelling=D1
- P5: grain=4; need=False; dwelling=D1
- P6: grain=4; need=False; dwelling=D1
- H1: lifecycle=Inactive; participants=[P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized,C2:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized,C2:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized,C2:Unknown]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown,C2:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown,C2:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown,C2:Unknown]; households=[]

## Cycle 9 — close-successor-formation

### Decisions

### Outcomes
- none

### Semantic events
- E88 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E89 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E90 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E91 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E92 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E93 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E94 r6: CandidateRecognitionEstablished; participants=[P1]; causes=[E76,E77,E86,E87]; fallback=False; detail=Candidate:2
- E95 r7: CandidateRecognitionEstablished; participants=[P2]; causes=[E76,E77,E86,E87]; fallback=False; detail=Candidate:2
- E96 r8: HouseholdFormation; participants=[P1,P2]; causes=[E94,E95,E76,E86]; fallback=False; detail=Household:2;Warrant:6;Candidate:2
- E97 r9: SustainingParticipationFounded; participants=[P1]; causes=[E96]; fallback=False; detail=Household:2;Association:4;Warrant:6
- E98 r10: SustainingParticipationFounded; participants=[P2]; causes=[E96]; fallback=False; detail=Household:2;Association:5;Warrant:6
- E99 r11: HouseholdRecognitionAcquired; participants=[P1,P2]; causes=[E96]; fallback=False; detail=Household:2;Warrant:6
- E100 r12: HouseholdLineage; participants=[P1,P2]; causes=[E96,E54,E64,E76,E86]; fallback=False; detail=Successor:2;Warrant:7;Kind:DivisionDescendant

### Stable state — close-successor-formation
- P1: grain=2; need=False; dwelling=D1
- P2: grain=4; need=False; dwelling=D1
- P3: grain=3; need=False; dwelling=D1
- P4: grain=3; need=False; dwelling=D1
- P5: grain=3; need=False; dwelling=D1
- P6: grain=3; need=False; dwelling=D1
- H1: lifecycle=Inactive; participants=[P3]; capacity=0
- H2: lifecycle=Active; participants=[P1,P2]; capacity=0
- P1 epistemic: candidates=[C1:Recognized,C2:Recognized]; households=[H1:Recognized,H2:Recognized]
- P2 epistemic: candidates=[C1:Recognized,C2:Recognized]; households=[H1:Recognized,H2:Recognized]
- P3 epistemic: candidates=[C1:Recognized,C2:Unknown]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown,C2:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown,C2:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown,C2:Unknown]; households=[]

