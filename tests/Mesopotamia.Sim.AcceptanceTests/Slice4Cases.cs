namespace Mesopotamia.Sim.AcceptanceTests;

internal sealed record Slice4Case(string Name, string[] Ids, Action Run);
internal static class Slice4Cases
{
    internal static IEnumerable<Slice4Case> All()
    {
        Slice4MechanismTests mechanism = new(); Slice4AdversarialTests adversarial = new(); Slice4InteractionTests interaction = new();
        Slice4FundingBoundaryTests funding = new(); Slice4KnowledgeBoundaryTests knowledge = new(); Slice4LifecycleTests lifecycle = new();
        Slice4ContextTests contexts = new(); Slice4MarriageBoundaryTests marriage = new(); Slice4AssuranceTests assurance = new(); Slice4ReconsiderationTests reconsideration = new();
        yield return C("001 002 003 004 010 011 012 015 016 017 022 030 031 039", mechanism.RoleConsentVacancyAndIdentity);
        yield return C("005 006 018 159 164 180", mechanism.ExplicitConsentAblations);
        yield return C("050 051 052 053 054 056 062 077 085", mechanism.SupportAndIndependentPersonalInitiative);
        yield return C("100 104 105 106 107 112 184 188 190", mechanism.MediatedMarriageFundingVariants);
        yield return C("120 128 130", mechanism.LastActBeforeHeadExit);
        yield return C("007 008", adversarial.NonparticipantCannotNominateOrOccupyRole);
        yield return C("019 059 064 079 181", adversarial.InactiveAppointmentAndHeadlessActionRejection);
        yield return C("032 033 038 141", adversarial.HeadEvidenceStaysLocalAndCorrectsByCommunication);
        yield return C("035 036 041", adversarial.IncomparableHeadEvidenceCannotChooseAuthority);
        yield return C("070 071 072 173 179", adversarial.SelfCommitmentPreservesPrivateAuthorization);
        yield return C("073 074 075", adversarial.RefusalCooldownSurvivesSuccession);
        yield return C("060 061 143 162", adversarial.ScopeCannotCommandOrdinaryActions);
        yield return C("081 084 160 189", adversarial.PrivateFundingCannotDoubleCountHeadCommitment);
        yield return C("040 153 172", adversarial.FundingAndRoleCorruptionsReachIndependentChecker);
        yield return C("002 003 170", adversarial.FormationOracleRejectsAutomaticOccupancy);
        yield return C("178 188", interaction.HeadMayReceiveProactiveSupportWithoutSelfResponse);
        yield return C("057 063 086 131 133 165", interaction.AcceptedSharedCapacityLossIsInvalidationWithoutPartialDebit);
        yield return C("009 123 125 177", interaction.SuccessionBridgeEntryAndExitKeepSnapshotCohort);
        yield return C("105 110", interaction.FemaleHeadMediatesOwnMarriage);
        yield return C("101 102 103 115 164", interaction.MediatedKnowledgeGatesAndMalformedAmounts);
        yield return C("161 188", interaction.DeclinedSupplementCannotSeizePrivateGrain);
        yield return C("090 091 140 190", interaction.HouseholdOutputIsNotIndependentOrganizationalSupport);
        yield return C("121 126 129 144 145 148", interaction.DisconnectedActorsObserversAndEnumerationDoNotChangeLastAct);
        yield return C("082 083 085 189", funding.FixedRankIncludesEffectiveHeadCapacityAfterPrivateDebit);
        yield return C("085 106 160 184", funding.ContributorRecipientOverlapAggregatesNetDeltaButRetainsFundingLeg);
        yield return C("042 084", funding.FundingFailureDisclosesNoUnrelatedPrivateStock);
        yield return C("090 186 187 188", funding.FullPrivateFundingWorksWithoutStandingCommitments);
        yield return C("057 089 176", funding.SupportPrecedesRepaymentAndOrdinaryTransfer);
        yield return C("089 176", funding.SupportPrecedesCalledRepaymentWithoutChangingDebtDueMeaning);
        yield return C("084 112 160", funding.OverflowCannotPartiallyPublishCollectiveEffects);
        yield return C("113 124 125 126 131 133 190", funding.AcceptedPrivateAmountCannotRebalanceOrRebindAfterSupport);
        yield return C("034 040", knowledge.OlderLateHeadReportCannotReplaceNewerTransition);
        yield return C("030 033 038 039", knowledge.KnownVacancyIsDistinctFromUnknownAndCorrectsAfterAppointment);
        yield return C("113 124 131 132", knowledge.AcceptedMediationRevalidatesActorHeldAuthorityAfterCommunication);
        yield return C("149", knowledge.IsomorphicPersonRenamingPreservesRoleAndMaterialSemantics);
        yield return C("005 006 018 055 159", lifecycle.EveryOtherNomineeConsentIsNecessaryBeforeAndAfterAppointment);
        yield return C("013 014 020 058 078 087 088 142", lifecycle.VacancyAndDissolutionSuppressOnlyHouseholdContexts);
        yield return C("038 156 181", lifecycle.InactiveRoleSurvivesPublicReactivationWithoutFreshInitiative);
        yield return C("127 156", lifecycle.SnapshotInvalidAuthorityCannotBeRevivedByAppointment);
        yield return C("122 130", lifecycle.SupportLastActPrecedesLossOfActiveStatus);
        yield return C("042 050 051 052 054 055", contexts.OnePersonCarriesSeparateContextsForTwoProducedHouseholds);
        yield return C("055 056 061 161", contexts.ResponsesAndPersonalInitiativeCoexistWithHouseholdInitiative);
        yield return C("053 062 063 155", contexts.HouseholdProfileComponentsAndFallbackDomainsAreExact);
        yield return C("115 188", contexts.PositiveIntegerTermsRejectLossyNumericIngress);
        yield return C("063 165", contexts.DecisionTieIsSeparateFromCentralResolutionFallback);
        yield return C("037", contexts.NegativeAttitudeAndVoluntaryRefusalDoNotEraseHeadRecognition);
        yield return C("111 114 162", marriage.DirectStrongLikeBypassRemainsIndependentOfHouseholdAuthority);
        yield return C("108 113 134 159", marriage.FavourCapacityRaceHasNoBlanketHeadFirstPriority);
        yield return C("080 109", marriage.GroomHeadAliasAndNonparticipantSupportAreRejected);
        yield return C("021 022 146 150 152 171 182 183 185", assurance.TypedAuthorityAndPhaseCarriedStateHaveExactInventories);
        yield return C("010 112 153 173", assurance.ConsentOriginAndMediatedEffectCorruptionsAreRejected);
        yield return C("153 159 172 173 184 190", assurance.MaterialAndOriginCorruptionMatrixReachesIndependentChecker);
        yield return C("145 146 147 156 157 158 186", assurance.ImmutableQueriesRebuildAndDuplicateClosureAreInert);
        yield return C("073 074 075 076", reconsideration.HistoricalUnfundedDowrySurvivesAndLaterRefusalResets);
        yield return C("075 076", reconsideration.SupportOnsetReentryAndUninterruptedNeedAreDistinct);
        yield return C("076", reconsideration.ProposalIdentityAndInvalidDowryCannotCreateNeed);
    }

    private static Slice4Case C(string ids, Action run) => new(run.Method.Name, ids.Split(' '), run);
}
