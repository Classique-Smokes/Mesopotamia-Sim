# Mode B1 — Continuity / Recognition / Provision — Mechanical Transcript

Generated mechanically from production simulation surfaces. No interpretation is included.

### Stable state — Initial
- P1: grain=12; need=False; dwelling=D1
- P2: grain=12; need=False; dwelling=D1
- P3: grain=12; need=False; dwelling=D1
- P4: grain=12; need=False; dwelling=D1
- P5: grain=12; need=False; dwelling=D1
- P6: grain=12; need=False; dwelling=D2
- Households: none
- P1 epistemic: candidates=[C1:Unknown]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Unknown]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 1 — ordinary-support-p1-p3

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

### Stable state — ordinary-support-p1-p3
- P1: grain=10; need=False; dwelling=D1
- P2: grain=11; need=False; dwelling=D1
- P3: grain=12; need=False; dwelling=D1
- P4: grain=11; need=False; dwelling=D1
- P5: grain=11; need=False; dwelling=D1
- P6: grain=11; need=False; dwelling=D2
- Households: none
- P1 epistemic: candidates=[C1:Unknown]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Unknown]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 2 — ordinary-support-p3-p2

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

### Stable state — ordinary-support-p3-p2
- P1: grain=9; need=False; dwelling=D1
- P2: grain=11; need=False; dwelling=D1
- P3: grain=10; need=False; dwelling=D1
- P4: grain=10; need=False; dwelling=D1
- P5: grain=10; need=False; dwelling=D1
- P6: grain=10; need=False; dwelling=D2
- Households: none
- P1 epistemic: candidates=[C1:Unknown]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Recognized]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 3 — communicate-cycle2-support-to-p1

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

### Stable state — communicate-cycle2-support-to-p1
- P1: grain=8; need=False; dwelling=D1
- P2: grain=10; need=False; dwelling=D1
- P3: grain=9; need=False; dwelling=D1
- P4: grain=9; need=False; dwelling=D1
- P5: grain=9; need=False; dwelling=D1
- P6: grain=9; need=False; dwelling=D2
- Households: none
- P1 epistemic: candidates=[C1:Recognized]; households=[]
- P2 epistemic: candidates=[C1:Unknown]; households=[]
- P3 epistemic: candidates=[C1:Recognized]; households=[]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 4 — communicate-cycle1-support-to-p2

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

### Stable state — communicate-cycle1-support-to-p2
- P1: grain=7; need=False; dwelling=D1
- P2: grain=9; need=False; dwelling=D1
- P3: grain=8; need=False; dwelling=D1
- P4: grain=8; need=False; dwelling=D1
- P5: grain=8; need=False; dwelling=D1
- P6: grain=8; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 5 — communicate-household-recognition-to-p4

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
- E53 r8: Proposal; participants=[P1]; causes=[]; fallback=False; detail=CommunicateClaim(4,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })
- E54 r9: Communication; participants=[P1,P4]; causes=[E53]; fallback=False; detail=CommunicateClaim(4,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })

### Stable state — communicate-household-recognition-to-p4
- P1: grain=6; need=False; dwelling=D1
- P2: grain=8; need=False; dwelling=D1
- P3: grain=7; need=False; dwelling=D1
- P4: grain=7; need=False; dwelling=D1
- P5: grain=7; need=False; dwelling=D1
- P6: grain=7; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 6 — postformation-support-p1-p4

### Decisions
- P4 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=6; actor=P1; kind=Committed; reason=; event=E63

### Semantic events
- E55 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E56 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E57 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E58 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E59 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E60 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E61 r6: Proposal; participants=[P1]; causes=[]; fallback=False; detail=OfferGift(4,1)
- E62 r7: Response; participants=[P4]; causes=[E61]; fallback=False; detail=Accept
- E63 r8: Gift; participants=[P1,P4]; causes=[E62]; fallback=False; detail=OfferGift(4,1)
- E64 r9: AttitudeComposition; participants=[P4,P1]; causes=[E63]; fallback=False; detail=0->10

### Stable state — postformation-support-p1-p4
- P1: grain=4; need=False; dwelling=D1
- P2: grain=7; need=False; dwelling=D1
- P3: grain=6; need=False; dwelling=D1
- P4: grain=7; need=False; dwelling=D1
- P5: grain=6; need=False; dwelling=D1
- P6: grain=6; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 7 — p4-requests-participation-via-p1

### Decisions
- P1 Response/SCORE-RP-001: selected=Accept; rules=SFL-S3-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=7; actor=P4; kind=Committed; reason=; event=E73

### Semantic events
- E65 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E66 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E67 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E68 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E69 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E70 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E71 r6: Proposal; participants=[P4]; causes=[]; fallback=False; detail=RequestHouseholdParticipation(1,1)
- E72 r7: Response; participants=[P1]; causes=[E71]; fallback=False; detail=Accept
- E73 r8: HouseholdParticipation; participants=[P4,P1]; causes=[E72,E63,E40,E54]; fallback=False; detail=Household:1;Warrant:2
- E74 r9: SustainingParticipationStarted; participants=[P4]; causes=[E73]; fallback=False; detail=Association:4;Household:1
- E75 r10: HouseholdContinued; participants=[P4,P1]; causes=[E73,E40]; fallback=False; detail=Household:1;Warrant:3;Previous:1;Transition:2
- E76 r11: HouseholdRecognitionAcquired; participants=[P4,P1]; causes=[E75]; fallback=False; detail=Household:1;Warrant:3

### Stable state — p4-requests-participation-via-p1
- P1: grain=3; need=False; dwelling=D1
- P2: grain=6; need=False; dwelling=D1
- P3: grain=5; need=False; dwelling=D1
- P4: grain=6; need=False; dwelling=D1
- P5: grain=5; need=False; dwelling=D1
- P6: grain=5; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Checkpoint — controlled-provision-prerequisite-p1

### Stable state — controlled-provision-prerequisite-p1
- P1: grain=3; need=False; dwelling=D1
- P2: grain=6; need=False; dwelling=D1
- P3: grain=5; need=False; dwelling=D1
- P4: grain=6; need=False; dwelling=D1
- P5: grain=5; need=False; dwelling=D1
- P6: grain=5; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=1
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 8 — personal-gift-changes-capacity

### Decisions
- P6 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=8; actor=P1; kind=Committed; reason=; event=E85

### Semantic events
- E77 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E78 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E79 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E80 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E81 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E82 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E83 r6: Proposal; participants=[P1]; causes=[]; fallback=False; detail=OfferGift(6,1)
- E84 r7: Response; participants=[P6]; causes=[E83]; fallback=False; detail=Accept
- E85 r8: Gift; participants=[P1,P6]; causes=[E84]; fallback=False; detail=OfferGift(6,1)
- E86 r9: AttitudeComposition; participants=[P6,P1]; causes=[E85]; fallback=False; detail=0->10

### Stable state — personal-gift-changes-capacity
- P1: grain=1; need=False; dwelling=D1
- P2: grain=5; need=False; dwelling=D1
- P3: grain=4; need=False; dwelling=D1
- P4: grain=5; need=False; dwelling=D1
- P5: grain=4; need=False; dwelling=D1
- P6: grain=5; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 9 — connected-compatible-loans

### Decisions
- P3 Response/Feasibility: selected=none; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False
- P3 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=9; actor=P1; kind=Unable; reason=InsufficientAvailableGrain; event=E94
- proposal=10; actor=P2; kind=Committed; reason=; event=E97

### Semantic events
- E87 r0: Consumption; participants=[P1]; causes=[]; fallback=False; detail=Paid
- E88 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E89 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E90 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E91 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E92 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E93 r6: Proposal; participants=[P1]; causes=[]; fallback=False; detail=OfferLoan(3,1)
- E94 r7: Unable; participants=[P1,P3]; causes=[E93]; fallback=False; detail=InsufficientAvailableGrain
- E95 r8: Proposal; participants=[P2]; causes=[]; fallback=False; detail=OfferLoan(3,1)
- E96 r9: Response; participants=[P3]; causes=[E95]; fallback=False; detail=Accept
- E97 r10: Loan; participants=[P2,P3]; causes=[E96]; fallback=False; detail=OfferLoan(3,1)
- E98 r11: AttitudeComposition; participants=[P3,P2]; causes=[E97]; fallback=False; detail=0->5

### Stable state — connected-compatible-loans
- P1: grain=0; need=False; dwelling=D1
- P2: grain=3; need=False; dwelling=D1
- P3: grain=4; need=False; dwelling=D1
- P4: grain=4; need=False; dwelling=D1
- P5: grain=3; need=False; dwelling=D1
- P6: grain=4; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 10 — communicate-household-recognition-to-p5

### Decisions

### Outcomes
- proposal=11; actor=P2; kind=Committed; reason=; event=E111

### Semantic events
- E99 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E100 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E101 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E102 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E103 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E104 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E105 r6: AttitudeDecay; participants=[P3,P1]; causes=[]; fallback=False; detail=8->6
- E106 r7: AttitudeDecay; participants=[P2,P3]; causes=[]; fallback=False; detail=8->6
- E107 r8: AttitudeDecay; participants=[P4,P1]; causes=[]; fallback=False; detail=10->8
- E108 r9: AttitudeDecay; participants=[P6,P1]; causes=[]; fallback=False; detail=10->8
- E109 r10: AttitudeDecay; participants=[P3,P2]; causes=[]; fallback=False; detail=5->3
- E110 r11: Proposal; participants=[P2]; causes=[]; fallback=False; detail=CommunicateClaim(5,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })
- E111 r12: Communication; participants=[P2,P5]; causes=[E110]; fallback=False; detail=CommunicateClaim(5,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })

### Stable state — communicate-household-recognition-to-p5
- P1: grain=0; need=True; dwelling=D1
- P2: grain=2; need=False; dwelling=D1
- P3: grain=3; need=False; dwelling=D1
- P4: grain=3; need=False; dwelling=D1
- P5: grain=2; need=False; dwelling=D1
- P6: grain=3; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 11 — postformation-support-p2-p5

### Decisions
- P5 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=12; actor=P2; kind=Committed; reason=; event=E120

### Semantic events
- E112 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E113 r1: Consumption; participants=[P2]; causes=[]; fallback=False; detail=Paid
- E114 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E115 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E116 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E117 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E118 r6: Proposal; participants=[P2]; causes=[]; fallback=False; detail=OfferGift(5,1)
- E119 r7: Response; participants=[P5]; causes=[E118]; fallback=False; detail=Accept
- E120 r8: Gift; participants=[P2,P5]; causes=[E119]; fallback=False; detail=OfferGift(5,1)
- E121 r9: AttitudeComposition; participants=[P5,P2]; causes=[E120]; fallback=False; detail=0->10

### Stable state — postformation-support-p2-p5
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=False; dwelling=D1
- P3: grain=2; need=False; dwelling=D1
- P4: grain=2; need=False; dwelling=D1
- P5: grain=2; need=False; dwelling=D1
- P6: grain=2; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 12 — residence-admission-dependency

### Decisions
- P2 Response/SCORE-RP-001: selected=Accept; rules=SFL-S3-v1; config=SFL-S3-v1; fallback=False
- P5 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=13; actor=P6; kind=Committed; reason=; event=E132
- proposal=14; actor=P5; kind=InvalidatedAtResolution; reason=HouseholdResidenceUnavailable; event=E133

### Semantic events
- E122 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E123 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E124 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E125 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E126 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E127 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E128 r6: Proposal; participants=[P6]; causes=[]; fallback=False; detail=InviteResidence(5,2)
- E129 r7: Response; participants=[P5]; causes=[E128]; fallback=False; detail=Accept
- E130 r8: Proposal; participants=[P5]; causes=[]; fallback=False; detail=RequestHouseholdParticipation(1,2)
- E131 r9: Response; participants=[P2]; causes=[E130]; fallback=False; detail=Accept
- E132 r10: ResidenceTransition; participants=[P6,P5]; causes=[E129]; fallback=True; detail=InviteResidence(5,2)
- E133 r11: InvalidatedAtResolution; participants=[P5,P2]; causes=[E131]; fallback=True; detail=HouseholdResidenceUnavailable
- E134 r12: DebtSocialDueReview; participants=[P2,P3]; causes=[E97]; fallback=False; detail=UnpaidBalance
- E135 r13: AttitudeComposition; participants=[P2,P3]; causes=[E134]; fallback=False; detail=6->-4

### Stable state — residence-admission-dependency
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=1; need=False; dwelling=D1
- P4: grain=1; need=False; dwelling=D1
- P5: grain=1; need=False; dwelling=D2
- P6: grain=1; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 13 — p5-returns-to-dwelling1

### Decisions
- P2 Response/SCORE-RP-001: selected=Accept; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=15; actor=P5; kind=Committed; reason=; event=E144

### Semantic events
- E136 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E137 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E138 r2: Consumption; participants=[P3]; causes=[]; fallback=False; detail=Paid
- E139 r3: Consumption; participants=[P4]; causes=[]; fallback=False; detail=Paid
- E140 r4: Consumption; participants=[P5]; causes=[]; fallback=False; detail=Paid
- E141 r5: Consumption; participants=[P6]; causes=[]; fallback=False; detail=Paid
- E142 r6: Proposal; participants=[P5]; causes=[]; fallback=False; detail=MoveResidence(2,1)
- E143 r7: Response; participants=[P2]; causes=[E142]; fallback=False; detail=Accept
- E144 r8: ResidenceTransition; participants=[P5,P2]; causes=[E143]; fallback=False; detail=MoveResidence(2,1)

### Stable state — p5-returns-to-dwelling1
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=False; dwelling=D1
- P4: grain=0; need=False; dwelling=D1
- P5: grain=0; need=False; dwelling=D1
- P6: grain=0; need=False; dwelling=D2
- H1: lifecycle=Active; participants=[P1,P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 14 — founder-p1-exits

### Decisions

### Outcomes
- proposal=16; actor=P1; kind=Committed; reason=; event=E152

### Semantic events
- E145 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E146 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E147 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E148 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E149 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E150 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E151 r6: Proposal; participants=[P1]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E152 r7: HouseholdParticipationEnded; participants=[P1]; causes=[E151]; fallback=False; detail=Household:1;Warrant:4;Association:1
- E153 r8: HouseholdContinued; participants=[P1]; causes=[E152,E75]; fallback=False; detail=Household:1;Warrant:5;Previous:3;Transition:4
- E154 r9: HouseholdRecognitionAcquired; participants=[P1]; causes=[E153]; fallback=False; detail=Household:1;Warrant:5

### Stable state — founder-p1-exits
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Active; participants=[P2,P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 15 — founder-p2-exits

### Decisions

### Outcomes
- proposal=17; actor=P2; kind=Committed; reason=; event=E168

### Semantic events
- E155 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E156 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E157 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E158 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E159 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E160 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E161 r6: AttitudeDecay; participants=[P3,P1]; causes=[]; fallback=False; detail=6->4
- E162 r7: AttitudeDecay; participants=[P2,P3]; causes=[]; fallback=False; detail=-4->-3
- E163 r8: AttitudeDecay; participants=[P4,P1]; causes=[]; fallback=False; detail=8->6
- E164 r9: AttitudeDecay; participants=[P6,P1]; causes=[]; fallback=False; detail=8->6
- E165 r10: AttitudeDecay; participants=[P3,P2]; causes=[]; fallback=False; detail=3->1
- E166 r11: AttitudeDecay; participants=[P5,P2]; causes=[]; fallback=False; detail=10->8
- E167 r12: Proposal; participants=[P2]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E168 r13: HouseholdParticipationEnded; participants=[P2]; causes=[E167]; fallback=False; detail=Household:1;Warrant:6;Association:2
- E169 r14: HouseholdContinued; participants=[P2]; causes=[E168,E153]; fallback=False; detail=Household:1;Warrant:7;Previous:5;Transition:6
- E170 r15: HouseholdRecognitionAcquired; participants=[P2]; causes=[E169]; fallback=False; detail=Household:1;Warrant:7

### Stable state — founder-p2-exits
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Active; participants=[P3,P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 16 — founder-p3-exits

### Decisions

### Outcomes
- proposal=18; actor=P3; kind=Committed; reason=; event=E178

### Semantic events
- E171 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E172 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E173 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E174 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E175 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E176 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E177 r6: Proposal; participants=[P3]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E178 r7: HouseholdParticipationEnded; participants=[P3]; causes=[E177]; fallback=False; detail=Household:1;Warrant:8;Association:3
- E179 r8: HouseholdContinued; participants=[P3]; causes=[E178,E169]; fallback=False; detail=Household:1;Warrant:9;Previous:7;Transition:8
- E180 r9: HouseholdRecognitionAcquired; participants=[P3]; causes=[E179]; fallback=False; detail=Household:1;Warrant:9
- E181 r10: HouseholdLifecycle; participants=[P4]; causes=[E178,E179]; fallback=False; detail=Household:1;Inactive

### Stable state — founder-p3-exits
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Inactive; participants=[P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 17 — latest-continuation-report-p3-to-p4

### Decisions

### Outcomes
- proposal=19; actor=P3; kind=Committed; reason=; event=E189

### Semantic events
- E182 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E183 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E184 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E185 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E186 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E187 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E188 r6: Proposal; participants=[P3]; causes=[]; fallback=False; detail=CommunicateClaim(4,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })
- E189 r7: Communication; participants=[P3,P4]; causes=[E188]; fallback=False; detail=CommunicateClaim(4,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })

### Stable state — latest-continuation-report-p3-to-p4
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Inactive; participants=[P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 18 — updated-household-report-p4-to-p5

### Decisions

### Outcomes
- proposal=20; actor=P4; kind=Committed; reason=; event=E197

### Semantic events
- E190 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E191 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E192 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E193 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E194 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E195 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E196 r6: Proposal; participants=[P4]; causes=[]; fallback=False; detail=CommunicateClaim(5,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })
- E197 r7: Communication; participants=[P4,P5]; causes=[E196]; fallback=False; detail=CommunicateClaim(5,HeldHouseholdRecognition { Household = HouseholdId { Value = 1 } })

### Stable state — updated-household-report-p4-to-p5
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Inactive; participants=[P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 19 — fresh-support-p4-p5

### Decisions
- P5 Response/Feasibility: selected=none; rules=SFL-S2-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=21; actor=P4; kind=Unable; reason=InsufficientAvailableGrain; event=E205

### Semantic events
- E198 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E199 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E200 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E201 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E202 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E203 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E204 r6: Proposal; participants=[P4]; causes=[]; fallback=False; detail=OfferGift(5,1)
- E205 r7: Unable; participants=[P4,P5]; causes=[E204]; fallback=False; detail=InsufficientAvailableGrain

### Stable state — fresh-support-p4-p5
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Inactive; participants=[P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 20 — p5-requests-reactivation-entry-via-p4

### Decisions
- P4 Response/Feasibility: selected=none; rules=SFL-S3-v1; config=SFL-S3-v1; fallback=False

### Outcomes
- proposal=22; actor=P5; kind=Unable; reason=PostFormationSupportUnavailable; event=E219

### Semantic events
- E206 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E207 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E208 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E209 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E210 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E211 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E212 r6: AttitudeDecay; participants=[P3,P1]; causes=[]; fallback=False; detail=4->2
- E213 r7: AttitudeDecay; participants=[P2,P3]; causes=[]; fallback=False; detail=-3->-2
- E214 r8: AttitudeDecay; participants=[P4,P1]; causes=[]; fallback=False; detail=6->4
- E215 r9: AttitudeDecay; participants=[P6,P1]; causes=[]; fallback=False; detail=6->4
- E216 r10: AttitudeDecay; participants=[P3,P2]; causes=[]; fallback=False; detail=1->0
- E217 r11: AttitudeDecay; participants=[P5,P2]; causes=[]; fallback=False; detail=8->6
- E218 r12: Proposal; participants=[P5]; causes=[]; fallback=False; detail=RequestHouseholdParticipation(1,4)
- E219 r13: Unable; participants=[P5,P4]; causes=[E218]; fallback=False; detail=PostFormationSupportUnavailable

### Stable state — p5-requests-reactivation-entry-via-p4
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Inactive; participants=[P4]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 21 — p4-exits

### Decisions

### Outcomes
- proposal=23; actor=P4; kind=Committed; reason=; event=E227

### Semantic events
- E220 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E221 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E222 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E223 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E224 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E225 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E226 r6: Proposal; participants=[P4]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E227 r7: HouseholdParticipationEnded; participants=[P4]; causes=[E226]; fallback=False; detail=Household:1;Warrant:10;Association:4
- E228 r8: HouseholdLifecycle; participants=[P4]; causes=[E227]; fallback=False; detail=Household:1;Dissolved
- E229 r9: HouseholdDissolutionEvidenceAcquired; participants=[P4]; causes=[E228]; fallback=False; detail=Household:1;Warrant:1

### Stable state — p4-exits
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Dissolved; participants=[]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Unknown]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Cycle 22 — p5-terminal-exit

### Decisions

### Outcomes
- proposal=24; actor=P5; kind=Unable; reason=HouseholdDissolved; event=E237

### Semantic events
- E230 r0: MissedConsumption; participants=[P1]; causes=[]; fallback=False; detail=NeedsGrain
- E231 r1: MissedConsumption; participants=[P2]; causes=[]; fallback=False; detail=NeedsGrain
- E232 r2: MissedConsumption; participants=[P3]; causes=[]; fallback=False; detail=NeedsGrain
- E233 r3: MissedConsumption; participants=[P4]; causes=[]; fallback=False; detail=NeedsGrain
- E234 r4: MissedConsumption; participants=[P5]; causes=[]; fallback=False; detail=NeedsGrain
- E235 r5: MissedConsumption; participants=[P6]; causes=[]; fallback=False; detail=NeedsGrain
- E236 r6: Proposal; participants=[P5]; causes=[]; fallback=False; detail=EndHouseholdParticipation(1)
- E237 r7: Unable; participants=[P5]; causes=[E236]; fallback=False; detail=HouseholdDissolved

### Stable state — p5-terminal-exit
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Dissolved; participants=[]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Unknown]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

## Checkpoint — communicate-dissolution-fact-p5-to-p4-unavailable

### Stable state — communicate-dissolution-fact-p5-to-p4-unavailable
- P1: grain=0; need=True; dwelling=D1
- P2: grain=0; need=True; dwelling=D1
- P3: grain=0; need=True; dwelling=D1
- P4: grain=0; need=True; dwelling=D1
- P5: grain=0; need=True; dwelling=D1
- P6: grain=0; need=True; dwelling=D2
- H1: lifecycle=Dissolved; participants=[]; capacity=0
- P1 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P2 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P3 epistemic: candidates=[C1:Recognized]; households=[H1:Recognized]
- P4 epistemic: candidates=[C1:Unknown]; households=[H1:Unknown]
- P5 epistemic: candidates=[C1:Unknown]; households=[H1:Recognized]
- P6 epistemic: candidates=[C1:Unknown]; households=[]

