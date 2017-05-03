using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBot.Protocol
{
    class PackIdNames
    {
        public string ClasseName;
        public string GetClasseName(int Id)
        {
            switch (Id)
            {
                case 2:
                    ClasseName = "NetworkDataContainerMessage";
                    break;
                case 1:
                    ClasseName = "ProtocolRequired";
                    break;
                case 10:
                    ClasseName = "LoginQueueStatusMessage";
                    break;
                case 6100:
                    ClasseName = "QueueStatusMessage";
                    break;
                case 75:
                    ClasseName = "ConsoleMessage";
                    break;
                case 6127:
                    ClasseName = "ConsoleCommandsListMessage";
                    break;
                case 3:
                    ClasseName = "HelloConnectMessage";
                    break;
                case 6314:
                    ClasseName = "CredentialsAcknowledgementMessage";
                    break;
                case 5640:
                    ClasseName = "NicknameRegistrationMessage";
                    break;
                case 6607:
                    ClasseName = "AccountLinkRequiredMessage";
                    break;
                case 5638:
                    ClasseName = "NicknameRefusedMessage";
                    break;
                case 5641:
                    ClasseName = "NicknameAcceptedMessage";
                    break;
                case 22:
                    ClasseName = "IdentificationSuccessMessage";
                    break;
                case 6209:
                    ClasseName = "IdentificationSuccessWithLoginTokenMessage";
                    break;
                case 20:
                    ClasseName = "IdentificationFailedMessage";
                    break;
                case 6174:
                    ClasseName = "IdentificationFailedBannedMessage";
                    break;
                case 21:
                    ClasseName = "IdentificationFailedForBadVersionMessage";
                    break;
                case 30:
                    ClasseName = "ServersListMessage";
                    break;
                case 50:
                    ClasseName = "ServerStatusUpdateMessage";
                    break;
                case 42:
                    ClasseName = "SelectedServerDataMessage";
                    break;
                case 6469:
                    ClasseName = "SelectedServerDataExtendedMessage";
                    break;
                case 41:
                    ClasseName = "SelectedServerRefusedMessage";
                    break;
                case 6143:
                    ClasseName = "AcquaintanceSearchErrorMessage";
                    break;
                case 6142:
                    ClasseName = "AcquaintanceServerListMessage";
                    break;
                case 6731:
                    ClasseName = "MigratedServerListMessage";
                    break;
                case 101:
                    ClasseName = "HelloGameMessage";
                    break;
                case 111:
                    ClasseName = "AuthenticationTicketAcceptedMessage";
                    break;
                case 112:
                    ClasseName = "AuthenticationTicketRefusedMessage";
                    break;
                case 109:
                    ClasseName = "AlreadyConnectedMessage";
                    break;
                case 6029:
                    ClasseName = "AccountLoggingKickedMessage";
                    break;
                case 6539:
                    ClasseName = "ReloginTokenStatusMessage";
                    break;
                case 6340:
                    ClasseName = "ServerSettingsMessage";
                    break;
                case 6434:
                    ClasseName = "ServerSessionConstantsMessage";
                    break;
                case 6305:
                    ClasseName = "ServerOptionalFeaturesMessage";
                    break;
                case 6216:
                    ClasseName = "AccountCapabilitiesMessage";
                    break;
                case 6267:
                    ClasseName = "TrustStatusMessage";
                    break;
                case 6616:
                    ClasseName = "SubscriptionUpdateMessage";
                    break;
                case 6154:
                    ClasseName = "CheckFileRequestMessage";
                    break;
                case 6253:
                    ClasseName = "RawDataMessage";
                    break;
                case 1301:
                    ClasseName = "StartupActionsListMessage";
                    break;
                case 6538:
                    ClasseName = "StartupActionAddMessage";
                    break;
                case 1304:
                    ClasseName = "StartupActionFinishedMessage";
                    break;
                case 6733:
                    ClasseName = "CharacterCanBeCreatedResultMessage";
                    break;
                case 161:
                    ClasseName = "CharacterCreationResultMessage";
                    break;
                case 166:
                    ClasseName = "CharacterDeletionErrorMessage";
                    break;
                case 5544:
                    ClasseName = "CharacterNameSuggestionSuccessMessage";
                    break;
                case 164:
                    ClasseName = "CharacterNameSuggestionFailureMessage";
                    break;
                case 6475:
                    ClasseName = "BasicCharactersListMessage";
                    break;
                case 151:
                    ClasseName = "CharactersListMessage";
                    break;
                case 6550:
                    ClasseName = "CharactersListWithRemodelingMessage";
                    break;
                case 6120:
                    ClasseName = "CharactersListWithModificationsMessage";
                    break;
                case 5545:
                    ClasseName = "CharactersListErrorMessage";
                    break;
                case 153:
                    ClasseName = "CharacterSelectedSuccessMessage";
                    break;
                case 6068:
                    ClasseName = "CharacterSelectedForceMessage";
                    break;
                case 5836:
                    ClasseName = "CharacterSelectedErrorMessage";
                    break;
                case 6134:
                    ClasseName = "PopupWarningMessage";
                    break;
                case 177:
                    ClasseName = "BasicDateMessage";
                    break;
                case 175:
                    ClasseName = "BasicTimeMessage";
                    break;
                case 6341:
                    ClasseName = "AlmanachCalendarDateMessage";
                    break;
                case 176:
                    ClasseName = "BasicNoOperationMessage";
                    break;
                case 6362:
                    ClasseName = "BasicAckMessage";
                    break;
                case 189:
                    ClasseName = "SystemMessageDisplayMessage";
                    break;
                case 780:
                    ClasseName = "TextInformationMessage";
                    break;
                case 5726:
                    ClasseName = "OnConnectionEventMessage";
                    break;
                case 170:
                    ClasseName = "SetCharacterRestrictionsMessage";
                    break;
                case 6237:
                    ClasseName = "ServerExperienceModificatorMessage";
                    break;
                case 6339:
                    ClasseName = "CharacterCapabilitiesMessage";
                    break;
                case 6471:
                    ClasseName = "CharacterLoadingCompleteMessage";
                    break;
                case 200:
                    ClasseName = "GameContextCreateMessage";
                    break;
                case 6024:
                    ClasseName = "GameContextCreateErrorMessage";
                    break;
                case 201:
                    ClasseName = "GameContextDestroyMessage";
                    break;
                case 251:
                    ClasseName = "GameContextRemoveElementMessage";
                    break;
                case 252:
                    ClasseName = "GameContextRemoveMultipleElementsMessage";
                    break;
                case 6412:
                    ClasseName = "GameContextRemoveElementWithEventMessage";
                    break;
                case 6416:
                    ClasseName = "GameContextRemoveMultipleElementsWithEventsMessage";
                    break;
                case 253:
                    ClasseName = "GameContextMoveElementMessage";
                    break;
                case 254:
                    ClasseName = "GameContextMoveMultipleElementsMessage";
                    break;
                case 5637:
                    ClasseName = "GameContextRefreshEntityLookMessage";
                    break;
                case 954:
                    ClasseName = "GameMapNoMovementMessage";
                    break;
                case 951:
                    ClasseName = "GameMapMovementMessage";
                    break;
                case 6497:
                    ClasseName = "GameCautiousMapMovementMessage";
                    break;
                case 946:
                    ClasseName = "GameMapChangeOrientationMessage";
                    break;
                case 6155:
                    ClasseName = "GameMapChangeOrientationsMessage";
                    break;
                case 5693:
                    ClasseName = "GameEntityDispositionMessage";
                    break;
                case 5696:
                    ClasseName = "GameEntitiesDispositionMessage";
                    break;
                case 5695:
                    ClasseName = "GameEntityDispositionErrorMessage";
                    break;
                case 6618:
                    ClasseName = "GameRefreshMonsterBoostsMessage";
                    break;
                case 6385:
                    ClasseName = "PlayerStatusUpdateErrorMessage";
                    break;
                case 6386:
                    ClasseName = "PlayerStatusUpdateMessage";
                    break;
                case 180:
                    ClasseName = "BasicWhoIsMessage";
                    break;
                case 179:
                    ClasseName = "BasicWhoIsNoMatchMessage";
                    break;
                case 6297:
                    ClasseName = "NumericWhoIsMessage";
                    break;
                case 183:
                    ClasseName = "BasicPongMessage";
                    break;
                case 5816:
                    ClasseName = "BasicLatencyStatsRequestMessage";
                    break;
                case 6316:
                    ClasseName = "SequenceNumberRequestMessage";
                    break;
                case 6525:
                    ClasseName = "CurrentServerStatusUpdateMessage";
                    break;
                case 6053:
                    ClasseName = "CinematicMessage";
                    break;
                case 6266:
                    ClasseName = "URLOpenMessage";
                    break;
                case 2001:
                    ClasseName = "DebugHighlightCellsMessage";
                    break;
                case 2002:
                    ClasseName = "DebugClearHighlightCellsMessage";
                    break;
                case 6028:
                    ClasseName = "DebugInClientMessage";
                    break;
                case 6594:
                    ClasseName = "ClientYouAreDrunkMessage";
                    break;
                case 6563:
                    ClasseName = "DisplayNumericalValuePaddockMessage";
                    break;
                case 220:
                    ClasseName = "CurrentMapMessage";
                    break;
                case 6048:
                    ClasseName = "TeleportOnSameMapMessage";
                    break;
                case 210:
                    ClasseName = "MapFightCountMessage";
                    break;
                case 5743:
                    ClasseName = "MapRunningFightListMessage";
                    break;
                case 5751:
                    ClasseName = "MapRunningFightDetailsMessage";
                    break;
                case 6500:
                    ClasseName = "MapRunningFightDetailsExtendedMessage";
                    break;
                case 6051:
                    ClasseName = "MapObstacleUpdateMessage";
                    break;
                case 226:
                    ClasseName = "MapComplementaryInformationsDataMessage";
                    break;
                case 6130:
                    ClasseName = "MapComplementaryInformationsDataInHouseMessage";
                    break;
                case 6268:
                    ClasseName = "MapComplementaryInformationsWithCoordsMessage";
                    break;
                case 6716:
                    ClasseName = "MapFightStartPositionsUpdateMessage";
                    break;
                case 5632:
                    ClasseName = "GameRolePlayShowActorMessage";
                    break;
                case 6712:
                    ClasseName = "GameRolePlayShowMultipleActorsMessage";
                    break;
                case 6407:
                    ClasseName = "GameRolePlayShowActorWithEventMessage";
                    break;
                case 500:
                    ClasseName = "CharacterStatsListMessage";
                    break;
                case 6322:
                    ClasseName = "FighterStatsListMessage";
                    break;
                case 5670:
                    ClasseName = "CharacterLevelUpMessage";
                    break;
                case 6321:
                    ClasseName = "CharacterExperienceGainMessage";
                    break;
                case 6076:
                    ClasseName = "CharacterLevelUpInformationMessage";
                    break;
                case 5658:
                    ClasseName = "UpdateLifePointsMessage";
                    break;
                case 5684:
                    ClasseName = "LifePointsRegenBeginMessage";
                    break;
                case 5686:
                    ClasseName = "LifePointsRegenEndMessage";
                    break;
                case 5996:
                    ClasseName = "GameRolePlayPlayerLifeStatusMessage";
                    break;
                case 746:
                    ClasseName = "GameRolePlayGameOverMessage";
                    break;
                case 5822:
                    ClasseName = "GameRolePlayFightRequestCanceledMessage";
                    break;
                case 6073:
                    ClasseName = "GameRolePlayAggressionMessage";
                    break;
                case 5937:
                    ClasseName = "GameRolePlayPlayerFightFriendlyRequestedMessage";
                    break;
                case 5733:
                    ClasseName = "GameRolePlayPlayerFightFriendlyAnsweredMessage";
                    break;
                case 6284:
                    ClasseName = "GameRolePlayArenaRegistrationStatusMessage";
                    break;
                case 6276:
                    ClasseName = "GameRolePlayArenaFightPropositionMessage";
                    break;
                case 6281:
                    ClasseName = "GameRolePlayArenaFighterStatusMessage";
                    break;
                case 6301:
                    ClasseName = "GameRolePlayArenaUpdatePlayerInfosMessage";
                    break;
                case 6728:
                    ClasseName = "GameRolePlayArenaUpdatePlayerInfosAllQueuesMessage";
                    break;
                case 6575:
                    ClasseName = "GameRolePlayArenaSwitchToFightServerMessage";
                    break;
                case 6574:
                    ClasseName = "GameRolePlayArenaSwitchToGameServerMessage";
                    break;
                case 301:
                    ClasseName = "GameRolePlayShowChallengeMessage";
                    break;
                case 300:
                    ClasseName = "GameRolePlayRemoveChallengeMessage";
                    break;
                case 6114:
                    ClasseName = "GameRolePlaySpellAnimMessage";
                    break;
                case 6153:
                    ClasseName = "GameRolePlayDelayedActionMessage";
                    break;
                case 6425:
                    ClasseName = "GameRolePlayDelayedObjectUseMessage";
                    break;
                case 6150:
                    ClasseName = "GameRolePlayDelayedActionFinishedMessage";
                    break;
                case 5612:
                    ClasseName = "ShowCellMessage";
                    break;
                case 6158:
                    ClasseName = "ShowCellSpectatorMessage";
                    break;
                case 700:
                    ClasseName = "GameFightStartingMessage";
                    break;
                case 702:
                    ClasseName = "GameFightJoinMessage";
                    break;
                case 6504:
                    ClasseName = "GameFightSpectatorJoinMessage";
                    break;
                case 703:
                    ClasseName = "GameFightPlacementPossiblePositionsMessage";
                    break;
                case 6548:
                    ClasseName = "GameFightPlacementSwapPositionsErrorMessage";
                    break;
                case 6542:
                    ClasseName = "GameFightPlacementSwapPositionsOfferMessage";
                    break;
                case 6546:
                    ClasseName = "GameFightPlacementSwapPositionsCancelledMessage";
                    break;
                case 6544:
                    ClasseName = "GameFightPlacementSwapPositionsMessage";
                    break;
                case 5927:
                    ClasseName = "GameFightOptionStateUpdateMessage";
                    break;
                case 5572:
                    ClasseName = "GameFightUpdateTeamMessage";
                    break;
                case 711:
                    ClasseName = "GameFightRemoveTeamMemberMessage";
                    break;
                case 740:
                    ClasseName = "GameFightHumanReadyStateMessage";
                    break;
                case 721:
                    ClasseName = "GameFightLeaveMessage";
                    break;
                case 712:
                    ClasseName = "GameFightStartMessage";
                    break;
                case 6069:
                    ClasseName = "GameFightSpectateMessage";
                    break;
                case 6067:
                    ClasseName = "GameFightResumeMessage";
                    break;
                case 6215:
                    ClasseName = "GameFightResumeWithSlavesMessage";
                    break;
                case 720:
                    ClasseName = "GameFightEndMessage";
                    break;
                case 6239:
                    ClasseName = "GameFightNewRoundMessage";
                    break;
                case 713:
                    ClasseName = "GameFightTurnListMessage";
                    break;
                case 714:
                    ClasseName = "GameFightTurnStartMessage";
                    break;
                case 6490:
                    ClasseName = "GameFightNewWaveMessage";
                    break;
                case 6465:
                    ClasseName = "GameFightTurnStartPlayingMessage";
                    break;
                case 6307:
                    ClasseName = "GameFightTurnResumeMessage";
                    break;
                case 6214:
                    ClasseName = "SlaveSwitchContextMessage";
                    break;
                case 6699:
                    ClasseName = "RefreshCharacterStatsMessage";
                    break;
                case 715:
                    ClasseName = "GameFightTurnReadyRequestMessage";
                    break;
                case 5921:
                    ClasseName = "GameFightSynchronizeMessage";
                    break;
                case 719:
                    ClasseName = "GameFightTurnEndMessage";
                    break;
                case 5864:
                    ClasseName = "GameFightShowFighterMessage";
                    break;
                case 6309:
                    ClasseName = "GameFightRefreshFighterMessage";
                    break;
                case 6218:
                    ClasseName = "GameFightShowFighterRandomStaticPoseMessage";
                    break;
                case 6700:
                    ClasseName = "ArenaFighterLeaveMessage";
                    break;
                case 955:
                    ClasseName = "SequenceStartMessage";
                    break;
                case 956:
                    ClasseName = "SequenceEndMessage";
                    break;
                case 1000:
                    ClasseName = "AbstractGameActionMessage";
                    break;
                case 1002:
                    ClasseName = "GameActionNoopMessage";
                    break;
                case 1001:
                    ClasseName = "AbstractGameActionWithAckMessage";
                    break;
                case 6132:
                    ClasseName = "GameActionFightNoSpellCastMessage";
                    break;
                case 6118:
                    ClasseName = "AbstractGameActionFightTargetedAbilityMessage";
                    break;
                case 1010:
                    ClasseName = "GameActionFightSpellCastMessage";
                    break;
                case 6116:
                    ClasseName = "GameActionFightCloseCombatMessage";
                    break;
                case 6320:
                    ClasseName = "GameActionFightInvisibleDetectedMessage";
                    break;
                case 1030:
                    ClasseName = "GameActionFightPointsVariationMessage";
                    break;
                case 1004:
                    ClasseName = "GameActionFightTackledMessage";
                    break;
                case 1099:
                    ClasseName = "GameActionFightDeathMessage";
                    break;
                case 5571:
                    ClasseName = "GameActionFightKillMessage";
                    break;
                case 6217:
                    ClasseName = "GameActionFightVanishMessage";
                    break;
                case 6219:
                    ClasseName = "GameActionFightSpellCooldownVariationMessage";
                    break;
                case 6221:
                    ClasseName = "GameActionFightSpellImmunityMessage";
                    break;
                case 6311:
                    ClasseName = "GameActionFightLifePointsGainMessage";
                    break;
                case 6312:
                    ClasseName = "GameActionFightLifePointsLostMessage";
                    break;
                case 6310:
                    ClasseName = "GameActionFightLifeAndShieldPointsLostMessage";
                    break;
                case 6070:
                    ClasseName = "GameActionFightDispellableEffectMessage";
                    break;
                case 5531:
                    ClasseName = "GameActionFightReflectSpellMessage";
                    break;
                case 5526:
                    ClasseName = "GameActionFightReduceDamagesMessage";
                    break;
                case 5530:
                    ClasseName = "GameActionFightReflectDamagesMessage";
                    break;
                case 5828:
                    ClasseName = "GameActionFightDodgePointLossMessage";
                    break;
                case 5525:
                    ClasseName = "GameActionFightSlideMessage";
                    break;
                case 5528:
                    ClasseName = "GameActionFightTeleportOnSameMapMessage";
                    break;
                case 5527:
                    ClasseName = "GameActionFightExchangePositionsMessage";
                    break;
                case 5533:
                    ClasseName = "GameActionFightDispellMessage";
                    break;
                case 6113:
                    ClasseName = "GameActionFightDispellEffectMessage";
                    break;
                case 6176:
                    ClasseName = "GameActionFightDispellSpellMessage";
                    break;
                case 6304:
                    ClasseName = "GameActionFightModifyEffectsDurationMessage";
                    break;
                case 6147:
                    ClasseName = "GameActionFightTriggerEffectMessage";
                    break;
                case 5535:
                    ClasseName = "GameActionFightStealKamaMessage";
                    break;
                case 5532:
                    ClasseName = "GameActionFightChangeLookMessage";
                    break;
                case 5821:
                    ClasseName = "GameActionFightInvisibilityMessage";
                    break;
                case 5825:
                    ClasseName = "GameActionFightSummonMessage";
                    break;
                case 5540:
                    ClasseName = "GameActionFightMarkCellsMessage";
                    break;
                case 5570:
                    ClasseName = "GameActionFightUnmarkCellsMessage";
                    break;
                case 5741:
                    ClasseName = "GameActionFightTriggerGlyphTrapMessage";
                    break;
                case 6545:
                    ClasseName = "GameActionFightActivateGlyphTrapMessage";
                    break;
                case 5830:
                    ClasseName = "GameActionFightCarryCharacterMessage";
                    break;
                case 5829:
                    ClasseName = "GameActionFightThrowCharacterMessage";
                    break;
                case 5826:
                    ClasseName = "GameActionFightDropCharacterMessage";
                    break;
                case 5689:
                    ClasseName = "EmoteListMessage";
                    break;
                case 5644:
                    ClasseName = "EmoteAddMessage";
                    break;
                case 5687:
                    ClasseName = "EmoteRemoveMessage";
                    break;
                case 5690:
                    ClasseName = "EmotePlayAbstractMessage";
                    break;
                case 5683:
                    ClasseName = "EmotePlayMessage";
                    break;
                case 5691:
                    ClasseName = "EmotePlayMassiveMessage";
                    break;
                case 5688:
                    ClasseName = "EmotePlayErrorMessage";
                    break;
                case 801:
                    ClasseName = "ChatSmileyMessage";
                    break;
                case 6730:
                    ClasseName = "ChatCommunityChannelCommunityMessage";
                    break;
                case 6185:
                    ClasseName = "LocalizedChatSmileyMessage";
                    break;
                case 6196:
                    ClasseName = "MoodSmileyResultMessage";
                    break;
                case 6388:
                    ClasseName = "MoodSmileyUpdateMessage";
                    break;
                case 6596:
                    ClasseName = "ChatSmileyExtraPackListMessage";
                    break;
                case 880:
                    ClasseName = "ChatAbstractServerMessage";
                    break;
                case 881:
                    ClasseName = "ChatServerMessage";
                    break;
                case 6135:
                    ClasseName = "ChatAdminServerMessage";
                    break;
                case 883:
                    ClasseName = "ChatServerWithObjectMessage";
                    break;
                case 882:
                    ClasseName = "ChatServerCopyMessage";
                    break;
                case 884:
                    ClasseName = "ChatServerCopyWithObjectMessage";
                    break;
                case 870:
                    ClasseName = "ChatErrorMessage";
                    break;
                case 892:
                    ClasseName = "EnabledChannelsMessage";
                    break;
                case 891:
                    ClasseName = "ChannelEnablingChangeMessage";
                    break;
                case 1200:
                    ClasseName = "SpellListMessage";
                    break;
                case 5502:
                    ClasseName = "LeaveDialogMessage";
                    break;
                case 6012:
                    ClasseName = "PauseDialogMessage";
                    break;
                case 6384:
                    ClasseName = "InteractiveUseErrorMessage";
                    break;
                case 5745:
                    ClasseName = "InteractiveUsedMessage";
                    break;
                case 6112:
                    ClasseName = "InteractiveUseEndedMessage";
                    break;
                case 5002:
                    ClasseName = "InteractiveMapUpdateMessage";
                    break;
                case 5716:
                    ClasseName = "StatedMapUpdateMessage";
                    break;
                case 5708:
                    ClasseName = "InteractiveElementUpdatedMessage";
                    break;
                case 5709:
                    ClasseName = "StatedElementUpdatedMessage";
                    break;
                case 6571:
                    ClasseName = "ZaapRespawnUpdatedMessage";
                    break;
                case 5960:
                    ClasseName = "TeleportDestinationsListMessage";
                    break;
                case 1604:
                    ClasseName = "ZaapListMessage";
                    break;
                case 6289:
                    ClasseName = "TeleportBuddiesMessage";
                    break;
                case 6302:
                    ClasseName = "TeleportBuddiesRequestedMessage";
                    break;
                case 6287:
                    ClasseName = "TeleportToBuddyOfferMessage";
                    break;
                case 6303:
                    ClasseName = "TeleportToBuddyCloseMessage";
                    break;
                case 6654:
                    ClasseName = "SpellModifySuccessMessage";
                    break;
                case 6653:
                    ClasseName = "SpellModifyFailureMessage";
                    break;
                case 6011:
                    ClasseName = "SpellItemBoostMessage";
                    break;
                case 6705:
                    ClasseName = "SpellVariantActivationMessage";
                    break;
                case 5609:
                    ClasseName = "StatsUpgradeResultMessage";
                    break;
                case 5613:
                    ClasseName = "ChallengeTargetsListMessage";
                    break;
                case 6022:
                    ClasseName = "ChallengeInfoMessage";
                    break;
                case 6123:
                    ClasseName = "ChallengeTargetUpdateMessage";
                    break;
                case 6019:
                    ClasseName = "ChallengeResultMessage";
                    break;
                case 6584:
                    ClasseName = "IdolSelectErrorMessage";
                    break;
                case 6581:
                    ClasseName = "IdolSelectedMessage";
                    break;
                case 6585:
                    ClasseName = "IdolListMessage";
                    break;
                case 6583:
                    ClasseName = "IdolPartyRefreshMessage";
                    break;
                case 6580:
                    ClasseName = "IdolPartyLostMessage";
                    break;
                case 6586:
                    ClasseName = "IdolFightPreparationUpdateMessage";
                    break;
                case 6205:
                    ClasseName = "AchievementListMessage";
                    break;
                case 6378:
                    ClasseName = "AchievementDetailsMessage";
                    break;
                case 6358:
                    ClasseName = "AchievementDetailedListMessage";
                    break;
                case 6208:
                    ClasseName = "AchievementFinishedMessage";
                    break;
                case 6381:
                    ClasseName = "AchievementFinishedInformationMessage";
                    break;
                case 6376:
                    ClasseName = "AchievementRewardSuccessMessage";
                    break;
                case 6375:
                    ClasseName = "AchievementRewardErrorMessage";
                    break;
                case 6383:
                    ClasseName = "FriendGuildWarnOnAchievementCompleteStateMessage";
                    break;
                case 6299:
                    ClasseName = "DungeonKeyRingMessage";
                    break;
                case 6296:
                    ClasseName = "DungeonKeyRingUpdateMessage";
                    break;
                case 6454:
                    ClasseName = "UpdateMapPlayersAgressableStatusMessage";
                    break;
                case 6456:
                    ClasseName = "UpdateSelfAgressableStatusMessage";
                    break;
                case 6058:
                    ClasseName = "AlignmentRankUpdateMessage";
                    break;
                case 5584:
                    ClasseName = "CompassResetMessage";
                    break;
                case 5591:
                    ClasseName = "CompassUpdateMessage";
                    break;
                case 5589:
                    ClasseName = "CompassUpdatePartyMemberMessage";
                    break;
                case 5956:
                    ClasseName = "AtlasPointInformationsMessage";
                    break;
                case 6013:
                    ClasseName = "CompassUpdatePvpSeekMessage";
                    break;
                case 6274:
                    ClasseName = "AbstractPartyMessage";
                    break;
                case 6273:
                    ClasseName = "AbstractPartyEventMessage";
                    break;
                case 6277:
                    ClasseName = "PartyModifiableStatusMessage";
                    break;
                case 5586:
                    ClasseName = "PartyInvitationMessage";
                    break;
                case 6244:
                    ClasseName = "PartyInvitationDungeonMessage";
                    break;
                case 6263:
                    ClasseName = "PartyInvitationDetailsMessage";
                    break;
                case 6262:
                    ClasseName = "PartyInvitationDungeonDetailsMessage";
                    break;
                case 6256:
                    ClasseName = "PartyInvitationCancelledForGuestMessage";
                    break;
                case 6251:
                    ClasseName = "PartyCancelInvitationNotificationMessage";
                    break;
                case 5596:
                    ClasseName = "PartyRefuseInvitationNotificationMessage";
                    break;
                case 5583:
                    ClasseName = "PartyCannotJoinErrorMessage";
                    break;
                case 5576:
                    ClasseName = "PartyJoinMessage";
                    break;
                case 6260:
                    ClasseName = "PartyNewGuestMessage";
                    break;
                case 5575:
                    ClasseName = "PartyUpdateMessage";
                    break;
                case 6306:
                    ClasseName = "PartyNewMemberMessage";
                    break;
                case 6054:
                    ClasseName = "PartyUpdateLightMessage";
                    break;
                case 6472:
                    ClasseName = "PartyCompanionUpdateLightMessage";
                    break;
                case 5579:
                    ClasseName = "PartyMemberRemoveMessage";
                    break;
                case 6252:
                    ClasseName = "PartyMemberEjectedMessage";
                    break;
                case 5578:
                    ClasseName = "PartyLeaderUpdateMessage";
                    break;
                case 5581:
                    ClasseName = "PartyFollowStatusUpdateMessage";
                    break;
                case 5595:
                    ClasseName = "PartyLocateMembersMessage";
                    break;
                case 5594:
                    ClasseName = "PartyLeaveMessage";
                    break;
                case 5590:
                    ClasseName = "PartyKickedByMessage";
                    break;
                case 6175:
                    ClasseName = "PartyRestrictedMessage";
                    break;
                case 6261:
                    ClasseName = "PartyDeletedMessage";
                    break;
                case 6270:
                    ClasseName = "PartyLoyaltyStatusMessage";
                    break;
                case 6342:
                    ClasseName = "PartyMemberInFightMessage";
                    break;
                case 6502:
                    ClasseName = "PartyNameUpdateMessage";
                    break;
                case 6501:
                    ClasseName = "PartyNameSetErrorMessage";
                    break;
                case 6242:
                    ClasseName = "DungeonPartyFinderAvailableDungeonsMessage";
                    break;
                case 6248:
                    ClasseName = "DungeonPartyFinderListenErrorMessage";
                    break;
                case 6247:
                    ClasseName = "DungeonPartyFinderRoomContentMessage";
                    break;
                case 6250:
                    ClasseName = "DungeonPartyFinderRoomContentUpdateMessage";
                    break;
                case 6241:
                    ClasseName = "DungeonPartyFinderRegisterSuccessMessage";
                    break;
                case 6243:
                    ClasseName = "DungeonPartyFinderRegisterErrorMessage";
                    break;
                case 6265:
                    ClasseName = "SpouseStatusMessage";
                    break;
                case 4002:
                    ClasseName = "FriendsListMessage";
                    break;
                case 6356:
                    ClasseName = "SpouseInformationsMessage";
                    break;
                case 5600:
                    ClasseName = "FriendAddFailureMessage";
                    break;
                case 5599:
                    ClasseName = "FriendAddedMessage";
                    break;
                case 5924:
                    ClasseName = "FriendUpdateMessage";
                    break;
                case 5601:
                    ClasseName = "FriendDeleteResultMessage";
                    break;
                case 5630:
                    ClasseName = "FriendWarnOnConnectionStateMessage";
                    break;
                case 6513:
                    ClasseName = "WarnOnPermaDeathStateMessage";
                    break;
                case 6078:
                    ClasseName = "FriendWarnOnLevelGainStateMessage";
                    break;
                case 5674:
                    ClasseName = "IgnoredListMessage";
                    break;
                case 5679:
                    ClasseName = "IgnoredAddFailureMessage";
                    break;
                case 5678:
                    ClasseName = "IgnoredAddedMessage";
                    break;
                case 5677:
                    ClasseName = "IgnoredDeleteResultMessage";
                    break;
                case 6394:
                    ClasseName = "AllianceCreationStartedMessage";
                    break;
                case 6444:
                    ClasseName = "AllianceModificationStartedMessage";
                    break;
                case 6391:
                    ClasseName = "AllianceCreationResultMessage";
                    break;
                case 6397:
                    ClasseName = "AllianceInvitedMessage";
                    break;
                case 6396:
                    ClasseName = "AllianceInvitationStateRecruterMessage";
                    break;
                case 6392:
                    ClasseName = "AllianceInvitationStateRecrutedMessage";
                    break;
                case 6402:
                    ClasseName = "AllianceJoinedMessage";
                    break;
                case 6399:
                    ClasseName = "AllianceGuildLeavingMessage";
                    break;
                case 6398:
                    ClasseName = "AllianceLeftMessage";
                    break;
                case 6390:
                    ClasseName = "AllianceMembershipMessage";
                    break;
                case 6439:
                    ClasseName = "KohUpdateMessage";
                    break;
                case 6493:
                    ClasseName = "AreaFightModificatorUpdateMessage";
                    break;
                case 6459:
                    ClasseName = "ClientUIOpenedMessage";
                    break;
                case 6463:
                    ClasseName = "ClientUIOpenedByObjectMessage";
                    break;
                case 5920:
                    ClasseName = "GuildCreationStartedMessage";
                    break;
                case 6324:
                    ClasseName = "GuildModificationStartedMessage";
                    break;
                case 5554:
                    ClasseName = "GuildCreationResultMessage";
                    break;
                case 5552:
                    ClasseName = "GuildInvitedMessage";
                    break;
                case 5563:
                    ClasseName = "GuildInvitationStateRecruterMessage";
                    break;
                case 5548:
                    ClasseName = "GuildInvitationStateRecrutedMessage";
                    break;
                case 5564:
                    ClasseName = "GuildJoinedMessage";
                    break;
                case 6061:
                    ClasseName = "GuildMemberOnlineStatusMessage";
                    break;
                case 5557:
                    ClasseName = "GuildInformationsGeneralMessage";
                    break;
                case 5558:
                    ClasseName = "GuildInformationsMembersMessage";
                    break;
                case 5597:
                    ClasseName = "GuildInformationsMemberUpdateMessage";
                    break;
                case 5959:
                    ClasseName = "GuildInformationsPaddocksMessage";
                    break;
                case 5923:
                    ClasseName = "GuildMemberLeavingMessage";
                    break;
                case 5562:
                    ClasseName = "GuildLeftMessage";
                    break;
                case 5835:
                    ClasseName = "GuildMembershipMessage";
                    break;
                case 6062:
                    ClasseName = "GuildLevelUpMessage";
                    break;
                case 5636:
                    ClasseName = "GuildInfosUpgradeMessage";
                    break;
                case 5919:
                    ClasseName = "GuildHousesInformationMessage";
                    break;
                case 6181:
                    ClasseName = "GuildHouseUpdateInformationMessage";
                    break;
                case 6180:
                    ClasseName = "GuildHouseRemoveMessage";
                    break;
                case 5952:
                    ClasseName = "GuildPaddockBoughtMessage";
                    break;
                case 5955:
                    ClasseName = "GuildPaddockRemovedMessage";
                    break;
                case 6160:
                    ClasseName = "GuildMemberWarnOnConnectionStateMessage";
                    break;
                case 6590:
                    ClasseName = "GuildMotdMessage";
                    break;
                case 6591:
                    ClasseName = "GuildMotdSetErrorMessage";
                    break;
                case 6689:
                    ClasseName = "GuildBulletinMessage";
                    break;
                case 6691:
                    ClasseName = "GuildBulletinSetErrorMessage";
                    break;
                case 6424:
                    ClasseName = "GuildFactsErrorMessage";
                    break;
                case 6415:
                    ClasseName = "GuildFactsMessage";
                    break;
                case 6422:
                    ClasseName = "GuildInAllianceFactsMessage";
                    break;
                case 6423:
                    ClasseName = "AllianceFactsErrorMessage";
                    break;
                case 6414:
                    ClasseName = "AllianceFactsMessage";
                    break;
                case 6413:
                    ClasseName = "GuildListMessage";
                    break;
                case 6435:
                    ClasseName = "GuildVersatileInfoListMessage";
                    break;
                case 6408:
                    ClasseName = "AllianceListMessage";
                    break;
                case 6436:
                    ClasseName = "AllianceVersatileInfoListMessage";
                    break;
                case 6427:
                    ClasseName = "AlliancePartialListMessage";
                    break;
                case 6403:
                    ClasseName = "AllianceInsiderInfoMessage";
                    break;
                case 6685:
                    ClasseName = "AllianceMotdMessage";
                    break;
                case 6683:
                    ClasseName = "AllianceMotdSetErrorMessage";
                    break;
                case 6690:
                    ClasseName = "AllianceBulletinMessage";
                    break;
                case 6692:
                    ClasseName = "AllianceBulletinSetErrorMessage";
                    break;
                case 5633:
                    ClasseName = "TaxCollectorMovementMessage";
                    break;
                case 5634:
                    ClasseName = "TaxCollectorErrorMessage";
                    break;
                case 6568:
                    ClasseName = "AbstractTaxCollectorListMessage";
                    break;
                case 5930:
                    ClasseName = "TaxCollectorListMessage";
                    break;
                case 6565:
                    ClasseName = "TopTaxCollectorListMessage";
                    break;
                case 6455:
                    ClasseName = "TaxCollectorStateUpdateMessage";
                    break;
                case 5917:
                    ClasseName = "TaxCollectorMovementAddMessage";
                    break;
                case 5915:
                    ClasseName = "TaxCollectorMovementRemoveMessage";
                    break;
                case 5918:
                    ClasseName = "TaxCollectorAttackedMessage";
                    break;
                case 5635:
                    ClasseName = "TaxCollectorAttackedResultMessage";
                    break;
                case 5720:
                    ClasseName = "GuildFightPlayersHelpersJoinMessage";
                    break;
                case 5719:
                    ClasseName = "GuildFightPlayersHelpersLeaveMessage";
                    break;
                case 5928:
                    ClasseName = "GuildFightPlayersEnemiesListMessage";
                    break;
                case 5929:
                    ClasseName = "GuildFightPlayersEnemyRemoveMessage";
                    break;
                case 6611:
                    ClasseName = "TaxCollectorMovementsOfflineMessage";
                    break;
                case 6466:
                    ClasseName = "PrismSetSabotagedRefusedMessage";
                    break;
                case 5895:
                    ClasseName = "PrismFightDefenderAddMessage";
                    break;
                case 5892:
                    ClasseName = "PrismFightDefenderLeaveMessage";
                    break;
                case 5893:
                    ClasseName = "PrismFightAttackerAddMessage";
                    break;
                case 5897:
                    ClasseName = "PrismFightAttackerRemoveMessage";
                    break;
                case 6440:
                    ClasseName = "PrismsListMessage";
                    break;
                case 6438:
                    ClasseName = "PrismsListUpdateMessage";
                    break;
                case 5908:
                    ClasseName = "ChallengeFightJoinRefusedMessage";
                    break;
                case 5853:
                    ClasseName = "PrismInfoCloseMessage";
                    break;
                case 6451:
                    ClasseName = "PrismsInfoValidMessage";
                    break;
                case 6452:
                    ClasseName = "PrismFightAddedMessage";
                    break;
                case 6453:
                    ClasseName = "PrismFightRemovedMessage";
                    break;
                case 5859:
                    ClasseName = "PrismInfoInValidMessage";
                    break;
                case 6040:
                    ClasseName = "PrismFightStateUpdateMessage";
                    break;
                case 6442:
                    ClasseName = "PrismSettingsErrorMessage";
                    break;
                case 6661:
                    ClasseName = "DareListMessage";
                    break;
                case 6657:
                    ClasseName = "DareVersatileListMessage";
                    break;
                case 6658:
                    ClasseName = "DareSubscribedListMessage";
                    break;
                case 6682:
                    ClasseName = "DareWonListMessage";
                    break;
                case 6663:
                    ClasseName = "DareCreatedListMessage";
                    break;
                case 6656:
                    ClasseName = "DareInformationsMessage";
                    break;
                case 6667:
                    ClasseName = "DareErrorMessage";
                    break;
                case 6679:
                    ClasseName = "DareCanceledMessage";
                    break;
                case 6681:
                    ClasseName = "DareWonMessage";
                    break;
                case 6660:
                    ClasseName = "DareSubscribedMessage";
                    break;
                case 6668:
                    ClasseName = "DareCreatedMessage";
                    break;
                case 6677:
                    ClasseName = "DareRewardsListMessage";
                    break;
                case 6678:
                    ClasseName = "DareRewardWonMessage";
                    break;
                case 6675:
                    ClasseName = "DareRewardConsumeValidationMessage";
                    break;
                case 5626:
                    ClasseName = "QuestListMessage";
                    break;
                case 6091:
                    ClasseName = "QuestStartedMessage";
                    break;
                case 6097:
                    ClasseName = "QuestValidatedMessage";
                    break;
                case 6098:
                    ClasseName = "QuestObjectiveValidatedMessage";
                    break;
                case 6099:
                    ClasseName = "QuestStepValidatedMessage";
                    break;
                case 6096:
                    ClasseName = "QuestStepStartedMessage";
                    break;
                case 5625:
                    ClasseName = "QuestStepInfoMessage";
                    break;
                case 6717:
                    ClasseName = "FollowedQuestsMessage";
                    break;
                case 6087:
                    ClasseName = "NotificationListMessage";
                    break;
                case 6103:
                    ClasseName = "NotificationByServerMessage";
                    break;
                case 5542:
                    ClasseName = "SubscriptionLimitationMessage";
                    break;
                case 5573:
                    ClasseName = "SubscriptionZoneMessage";
                    break;
                case 6506:
                    ClasseName = "GuestLimitationMessage";
                    break;
                case 6505:
                    ClasseName = "GuestModeMessage";
                    break;
                case 5642:
                    ClasseName = "MapNpcsQuestStatusUpdateMessage";
                    break;
                case 5900:
                    ClasseName = "NpcGenericActionFailureMessage";
                    break;
                case 5618:
                    ClasseName = "NpcDialogCreationMessage";
                    break;
                case 5617:
                    ClasseName = "NpcDialogQuestionMessage";
                    break;
                case 5619:
                    ClasseName = "TaxCollectorDialogQuestionBasicMessage";
                    break;
                case 5615:
                    ClasseName = "TaxCollectorDialogQuestionExtendedMessage";
                    break;
                case 6445:
                    ClasseName = "AllianceTaxCollectorDialogQuestionExtendedMessage";
                    break;
                case 6448:
                    ClasseName = "AlliancePrismDialogQuestionMessage";
                    break;
                case 6110:
                    ClasseName = "EntityTalkMessage";
                    break;
                case 5655:
                    ClasseName = "JobDescriptionMessage";
                    break;
                case 5656:
                    ClasseName = "JobLevelUpMessage";
                    break;
                case 5809:
                    ClasseName = "JobExperienceMultiUpdateMessage";
                    break;
                case 5654:
                    ClasseName = "JobExperienceUpdateMessage";
                    break;
                case 6599:
                    ClasseName = "JobExperienceOtherPlayerUpdateMessage";
                    break;
                case 5748:
                    ClasseName = "JobAllowMultiCraftRequestMessage";
                    break;
                case 5747:
                    ClasseName = "JobMultiCraftAvailableSkillsMessage";
                    break;
                case 6046:
                    ClasseName = "JobCrafterDirectoryListMessage";
                    break;
                case 5652:
                    ClasseName = "JobCrafterDirectorySettingsMessage";
                    break;
                case 6593:
                    ClasseName = "JobBookSubscriptionMessage";
                    break;
                case 5653:
                    ClasseName = "JobCrafterDirectoryRemoveMessage";
                    break;
                case 5651:
                    ClasseName = "JobCrafterDirectoryAddMessage";
                    break;
                case 6044:
                    ClasseName = "JobCrafterDirectoryEntryMessage";
                    break;
                case 5537:
                    ClasseName = "KamasUpdateMessage";
                    break;
                case 3017:
                    ClasseName = "ObjectGroundAddedMessage";
                    break;
                case 5925:
                    ClasseName = "ObjectGroundListAddedMessage";
                    break;
                case 3014:
                    ClasseName = "ObjectGroundRemovedMessage";
                    break;
                case 5944:
                    ClasseName = "ObjectGroundRemovedMultipleMessage";
                    break;
                case 3016:
                    ClasseName = "InventoryContentMessage";
                    break;
                case 6231:
                    ClasseName = "ShortcutBarContentMessage";
                    break;
                case 6227:
                    ClasseName = "ShortcutBarAddErrorMessage";
                    break;
                case 6222:
                    ClasseName = "ShortcutBarRemoveErrorMessage";
                    break;
                case 6226:
                    ClasseName = "ShortcutBarSwapErrorMessage";
                    break;
                case 6229:
                    ClasseName = "ShortcutBarRefreshMessage";
                    break;
                case 6224:
                    ClasseName = "ShortcutBarRemovedMessage";
                    break;
                case 6706:
                    ClasseName = "ShortcutBarReplacedMessage";
                    break;
                case 5646:
                    ClasseName = "StorageInventoryContentMessage";
                    break;
                case 5645:
                    ClasseName = "StorageKamasUpdateMessage";
                    break;
                case 5647:
                    ClasseName = "StorageObjectUpdateMessage";
                    break;
                case 6036:
                    ClasseName = "StorageObjectsUpdateMessage";
                    break;
                case 5648:
                    ClasseName = "StorageObjectRemoveMessage";
                    break;
                case 6035:
                    ClasseName = "StorageObjectsRemoveMessage";
                    break;
                case 5503:
                    ClasseName = "SetUpdateMessage";
                    break;
                case 3009:
                    ClasseName = "InventoryWeightMessage";
                    break;
                case 3010:
                    ClasseName = "ObjectMovementMessage";
                    break;
                case 3025:
                    ClasseName = "ObjectAddedMessage";
                    break;
                case 6033:
                    ClasseName = "ObjectsAddedMessage";
                    break;
                case 6030:
                    ClasseName = "GoldAddedMessage";
                    break;
                case 3004:
                    ClasseName = "ObjectErrorMessage";
                    break;
                case 3024:
                    ClasseName = "ObjectDeletedMessage";
                    break;
                case 6034:
                    ClasseName = "ObjectsDeletedMessage";
                    break;
                case 3023:
                    ClasseName = "ObjectQuantityMessage";
                    break;
                case 6206:
                    ClasseName = "ObjectsQuantityMessage";
                    break;
                case 3029:
                    ClasseName = "ObjectModifiedMessage";
                    break;
                case 6014:
                    ClasseName = "ObjectJobAddedMessage";
                    break;
                case 6519:
                    ClasseName = "ObtainedItemMessage";
                    break;
                case 6520:
                    ClasseName = "ObtainedItemWithBonusMessage";
                    break;
                case 6065:
                    ClasseName = "LivingObjectMessageMessage";
                    break;
                case 6526:
                    ClasseName = "SymbioticObjectErrorMessage";
                    break;
                case 6527:
                    ClasseName = "SymbioticObjectAssociatedMessage";
                    break;
                case 6529:
                    ClasseName = "WrapperObjectErrorMessage";
                    break;
                case 6523:
                    ClasseName = "WrapperObjectAssociatedMessage";
                    break;
                case 6458:
                    ClasseName = "MimicryObjectPreviewMessage";
                    break;
                case 6461:
                    ClasseName = "MimicryObjectErrorMessage";
                    break;
                case 6462:
                    ClasseName = "MimicryObjectAssociatedMessage";
                    break;
                case 6162:
                    ClasseName = "InventoryContentAndPresetMessage";
                    break;
                case 6171:
                    ClasseName = "InventoryPresetUpdateMessage";
                    break;
                case 6606:
                    ClasseName = "IdolsPresetUpdateMessage";
                    break;
                case 6211:
                    ClasseName = "InventoryPresetItemUpdateErrorMessage";
                    break;
                case 6168:
                    ClasseName = "InventoryPresetItemUpdateMessage";
                    break;
                case 6170:
                    ClasseName = "InventoryPresetSaveResultMessage";
                    break;
                case 6604:
                    ClasseName = "IdolsPresetSaveResultMessage";
                    break;
                case 6173:
                    ClasseName = "InventoryPresetDeleteResultMessage";
                    break;
                case 6605:
                    ClasseName = "IdolsPresetDeleteResultMessage";
                    break;
                case 6163:
                    ClasseName = "InventoryPresetUseResultMessage";
                    break;
                case 6614:
                    ClasseName = "IdolsPresetUseResultMessage";
                    break;
                case 6595:
                    ClasseName = "ExchangeCraftCountModifiedMessage";
                    break;
                case 5515:
                    ClasseName = "ExchangeObjectMessage";
                    break;
                case 5516:
                    ClasseName = "ExchangeObjectAddedMessage";
                    break;
                case 6535:
                    ClasseName = "ExchangeObjectsAddedMessage";
                    break;
                case 5517:
                    ClasseName = "ExchangeObjectRemovedMessage";
                    break;
                case 6532:
                    ClasseName = "ExchangeObjectsRemovedMessage";
                    break;
                case 5519:
                    ClasseName = "ExchangeObjectModifiedMessage";
                    break;
                case 6533:
                    ClasseName = "ExchangeObjectsModifiedMessage";
                    break;
                case 6009:
                    ClasseName = "ExchangeObjectPutInBagMessage";
                    break;
                case 6010:
                    ClasseName = "ExchangeObjectRemovedFromBagMessage";
                    break;
                case 6008:
                    ClasseName = "ExchangeObjectModifiedInBagMessage";
                    break;
                case 5521:
                    ClasseName = "ExchangeKamaModifiedMessage";
                    break;
                case 6670:
                    ClasseName = "ExchangePodsModifiedMessage";
                    break;
                case 6020:
                    ClasseName = "ExchangeMultiCraftCrafterCanUseHisRessourcesMessage";
                    break;
                case 5522:
                    ClasseName = "ExchangeRequestedMessage";
                    break;
                case 5523:
                    ClasseName = "ExchangeRequestedTradeMessage";
                    break;
                case 5512:
                    ClasseName = "ExchangeStartedMessage";
                    break;
                case 6129:
                    ClasseName = "ExchangeStartedWithPodsMessage";
                    break;
                case 6236:
                    ClasseName = "ExchangeStartedWithStorageMessage";
                    break;
                case 6272:
                    ClasseName = "ExchangeBidHouseBuyResultMessage";
                    break;
                case 5945:
                    ClasseName = "ExchangeBidHouseItemAddOkMessage";
                    break;
                case 5946:
                    ClasseName = "ExchangeBidHouseItemRemoveOkMessage";
                    break;
                case 5947:
                    ClasseName = "ExchangeBidHouseGenericItemAddedMessage";
                    break;
                case 5948:
                    ClasseName = "ExchangeBidHouseGenericItemRemovedMessage";
                    break;
                case 5949:
                    ClasseName = "ExchangeBidHouseInListAddedMessage";
                    break;
                case 6337:
                    ClasseName = "ExchangeBidHouseInListUpdatedMessage";
                    break;
                case 5950:
                    ClasseName = "ExchangeBidHouseInListRemovedMessage";
                    break;
                case 6612:
                    ClasseName = "ExchangeBidHouseUnsoldItemsMessage";
                    break;
                case 6613:
                    ClasseName = "ExchangeOfflineSoldItemsMessage";
                    break;
                case 5509:
                    ClasseName = "ExchangeIsReadyMessage";
                    break;
                case 6589:
                    ClasseName = "ExchangeStoppedMessage";
                    break;
                case 5513:
                    ClasseName = "ExchangeErrorMessage";
                    break;
                case 5628:
                    ClasseName = "ExchangeLeaveMessage";
                    break;
                case 6569:
                    ClasseName = "DecraftResultMessage";
                    break;
                case 6601:
                    ClasseName = "RecycleResultMessage";
                    break;
                case 5785:
                    ClasseName = "ExchangeStartOkNpcTradeMessage";
                    break;
                case 6567:
                    ClasseName = "ExchangeStartOkRunesTradeMessage";
                    break;
                case 6600:
                    ClasseName = "ExchangeStartOkRecycleTradeMessage";
                    break;
                case 5761:
                    ClasseName = "ExchangeStartOkNpcShopMessage";
                    break;
                case 5768:
                    ClasseName = "ExchangeOkMultiCraftMessage";
                    break;
                case 5790:
                    ClasseName = "ExchangeCraftResultMessage";
                    break;
                case 6000:
                    ClasseName = "ExchangeCraftResultWithObjectIdMessage";
                    break;
                case 5999:
                    ClasseName = "ExchangeCraftResultWithObjectDescMessage";
                    break;
                case 6188:
                    ClasseName = "ExchangeCraftResultMagicWithObjectDescMessage";
                    break;
                case 5794:
                    ClasseName = "ExchangeCraftInformationObjectMessage";
                    break;
                case 5767:
                    ClasseName = "ExchangeStartOkHumanVendorMessage";
                    break;
                case 5910:
                    ClasseName = "ExchangeShopStockStartedMessage";
                    break;
                case 5909:
                    ClasseName = "ExchangeShopStockMovementUpdatedMessage";
                    break;
                case 6038:
                    ClasseName = "ExchangeShopStockMultiMovementUpdatedMessage";
                    break;
                case 5907:
                    ClasseName = "ExchangeShopStockMovementRemovedMessage";
                    break;
                case 6037:
                    ClasseName = "ExchangeShopStockMultiMovementRemovedMessage";
                    break;
                case 5984:
                    ClasseName = "ExchangeStartedMountStockMessage";
                    break;
                case 6664:
                    ClasseName = "ExchangeStartedTaxCollectorShopMessage";
                    break;
                case 5905:
                    ClasseName = "ExchangeStartedBidSellerMessage";
                    break;
                case 5904:
                    ClasseName = "ExchangeStartedBidBuyerMessage";
                    break;
                case 5755:
                    ClasseName = "ExchangeBidPriceMessage";
                    break;
                case 6464:
                    ClasseName = "ExchangeBidPriceForSellerMessage";
                    break;
                case 5765:
                    ClasseName = "ExchangeTypesExchangerDescriptionForUserMessage";
                    break;
                case 5752:
                    ClasseName = "ExchangeTypesItemsExchangerDescriptionForUserMessage";
                    break;
                case 5793:
                    ClasseName = "ExchangeWeightMessage";
                    break;
                case 5762:
                    ClasseName = "ExchangeGuildTaxCollectorGetMessage";
                    break;
                case 5769:
                    ClasseName = "ItemNoMoreAvailableMessage";
                    break;
                case 5759:
                    ClasseName = "ExchangeBuyOkMessage";
                    break;
                case 5792:
                    ClasseName = "ExchangeSellOkMessage";
                    break;
                case 5787:
                    ClasseName = "ExchangeReplyTaxVendorMessage";
                    break;
                case 5786:
                    ClasseName = "ExchangeWaitingResultMessage";
                    break;
                case 5991:
                    ClasseName = "ExchangeStartOkMountWithOutPaddockMessage";
                    break;
                case 5979:
                    ClasseName = "ExchangeStartOkMountMessage";
                    break;
                case 5981:
                    ClasseName = "ExchangeMountStableErrorMessage";
                    break;
                case 6555:
                    ClasseName = "ExchangeMountsStableAddMessage";
                    break;
                case 6561:
                    ClasseName = "ExchangeMountsPaddockAddMessage";
                    break;
                case 6557:
                    ClasseName = "ExchangeMountsStableBornAddMessage";
                    break;
                case 6556:
                    ClasseName = "ExchangeMountsStableRemoveMessage";
                    break;
                case 6559:
                    ClasseName = "ExchangeMountsPaddockRemoveMessage";
                    break;
                case 6554:
                    ClasseName = "ExchangeMountsTakenFromPaddockMessage";
                    break;
                case 6055:
                    ClasseName = "ExchangeMountFreeFromPaddockMessage";
                    break;
                case 6056:
                    ClasseName = "ExchangeMountSterilizeFromPaddockMessage";
                    break;
                case 5802:
                    ClasseName = "ExchangeBidSearchOkMessage";
                    break;
                case 5810:
                    ClasseName = "ExchangeItemAutoCraftStopedMessage";
                    break;
                case 5813:
                    ClasseName = "ExchangeStartOkCraftMessage";
                    break;
                case 5941:
                    ClasseName = "ExchangeStartOkCraftWithInformationMessage";
                    break;
                case 5818:
                    ClasseName = "ExchangeStartOkMulticraftCrafterMessage";
                    break;
                case 5817:
                    ClasseName = "ExchangeStartOkMulticraftCustomerMessage";
                    break;
                case 6598:
                    ClasseName = "ExchangeCrafterJobLevelupMessage";
                    break;
                case 5819:
                    ClasseName = "ExchangeStartOkJobIndexMessage";
                    break;
                case 6578:
                    ClasseName = "ExchangeCraftPaymentModifiedMessage";
                    break;
                case 6179:
                    ClasseName = "UpdateMountBoostMessage";
                    break;
                case 6336:
                    ClasseName = "ObjectAveragePricesErrorMessage";
                    break;
                case 6335:
                    ClasseName = "ObjectAveragePricesMessage";
                    break;
                case 5739:
                    ClasseName = "PurchasableDialogMessage";
                    break;
                case 6315:
                    ClasseName = "AccountHouseMessage";
                    break;
                case 5734:
                    ClasseName = "HousePropertiesMessage";
                    break;
                case 5735:
                    ClasseName = "HouseBuyResultMessage";
                    break;
                case 6727:
                    ClasseName = "HouseSellingUpdateMessage";
                    break;
                case 6140:
                    ClasseName = "HouseToSellListMessage";
                    break;
                case 5701:
                    ClasseName = "HouseGuildNoneMessage";
                    break;
                case 5703:
                    ClasseName = "HouseGuildRightsMessage";
                    break;
                case 6516:
                    ClasseName = "PaddockBuyResultMessage";
                    break;
                case 5824:
                    ClasseName = "PaddockPropertiesMessage";
                    break;
                case 6018:
                    ClasseName = "PaddockSellBuyDialogMessage";
                    break;
                case 6026:
                    ClasseName = "GameDataPlayFarmObjectAnimationMessage";
                    break;
                case 6138:
                    ClasseName = "PaddockToSellListMessage";
                    break;
                case 6630:
                    ClasseName = "RoomAvailableUpdateMessage";
                    break;
                case 6620:
                    ClasseName = "HavenBagPackListMessage";
                    break;
                case 6632:
                    ClasseName = "EditHavenBagStartMessage";
                    break;
                case 6628:
                    ClasseName = "EditHavenBagFinishedMessage";
                    break;
                case 6644:
                    ClasseName = "HavenBagDailyLoteryMessage";
                    break;
                case 6634:
                    ClasseName = "HavenBagFurnituresMessage";
                    break;
                case 6622:
                    ClasseName = "MapComplementaryInformationsDataInHavenBagMessage";
                    break;
                case 6713:
                    ClasseName = "HavenBagPermissionsUpdateMessage";
                    break;
                case 6645:
                    ClasseName = "InviteInHavenBagClosedMessage";
                    break;
                case 6642:
                    ClasseName = "InviteInHavenBagMessage";
                    break;
                case 6643:
                    ClasseName = "InviteInHavenBagOfferMessage";
                    break;
                case 5977:
                    ClasseName = "MountSterilizedMessage";
                    break;
                case 6308:
                    ClasseName = "MountReleasedMessage";
                    break;
                case 5983:
                    ClasseName = "MountRenamedMessage";
                    break;
                case 5970:
                    ClasseName = "MountXpRatioMessage";
                    break;
                case 5973:
                    ClasseName = "MountDataMessage";
                    break;
                case 6172:
                    ClasseName = "MountDataErrorMessage";
                    break;
                case 5968:
                    ClasseName = "MountSetMessage";
                    break;
                case 5982:
                    ClasseName = "MountUnSetMessage";
                    break;
                case 5963:
                    ClasseName = "MountEquipedErrorMessage";
                    break;
                case 5967:
                    ClasseName = "MountRidingMessage";
                    break;
                case 5993:
                    ClasseName = "GameDataPaddockObjectRemoveMessage";
                    break;
                case 5990:
                    ClasseName = "GameDataPaddockObjectAddMessage";
                    break;
                case 5992:
                    ClasseName = "GameDataPaddockObjectListAddMessage";
                    break;
                case 5978:
                    ClasseName = "MountEmoteIconUsedOkMessage";
                    break;
                case 5740:
                    ClasseName = "LockableShowCodeDialogMessage";
                    break;
                case 5672:
                    ClasseName = "LockableCodeResultMessage";
                    break;
                case 5671:
                    ClasseName = "LockableStateUpdateAbstractMessage";
                    break;
                case 5668:
                    ClasseName = "LockableStateUpdateHouseDoorMessage";
                    break;
                case 5669:
                    ClasseName = "LockableStateUpdateStorageMessage";
                    break;
                case 5675:
                    ClasseName = "DocumentReadingBeginMessage";
                    break;
                case 6536:
                    ClasseName = "ComicReadingBeginMessage";
                    break;
                case 6367:
                    ClasseName = "TitlesAndOrnamentsListMessage";
                    break;
                case 6364:
                    ClasseName = "TitleGainedMessage";
                    break;
                case 6371:
                    ClasseName = "TitleLostMessage";
                    break;
                case 6368:
                    ClasseName = "OrnamentGainedMessage";
                    break;
                case 6366:
                    ClasseName = "TitleSelectedMessage";
                    break;
                case 6373:
                    ClasseName = "TitleSelectErrorMessage";
                    break;
                case 6369:
                    ClasseName = "OrnamentSelectedMessage";
                    break;
                case 6370:
                    ClasseName = "OrnamentSelectErrorMessage";
                    break;
                case 5934:
                    ClasseName = "ContactLookMessage";
                    break;
                case 6045:
                    ClasseName = "ContactLookErrorMessage";
                    break;
                case 6688:
                    ClasseName = "SocialNoticeMessage";
                    break;
                case 6695:
                    ClasseName = "BulletinMessage";
                    break;
                case 6684:
                    ClasseName = "SocialNoticeSetErrorMessage";
                    break;
                case 6521:
                    ClasseName = "AccessoryPreviewErrorMessage";
                    break;
                case 6517:
                    ClasseName = "AccessoryPreviewMessage";
                    break;
                case 6275:
                    ClasseName = "MailStatusMessage";
                    break;
                case 6292:
                    ClasseName = "NewMailMessage";
                    break;
                case 6649:
                    ClasseName = "HaapiApiKeyMessage";
                    break;
                case 6351:
                    ClasseName = "KrosmasterAuthTokenMessage";
                    break;
                case 6345:
                    ClasseName = "KrosmasterAuthTokenErrorMessage";
                    break;
                case 6350:
                    ClasseName = "KrosmasterInventoryMessage";
                    break;
                case 6343:
                    ClasseName = "KrosmasterInventoryErrorMessage";
                    break;
                case 6348:
                    ClasseName = "KrosmasterTransferMessage";
                    break;
                case 6704:
                    ClasseName = "FinishMoveListMessage";
                    break;
                case 6498:
                    ClasseName = "TreasureHuntShowLegendaryUIMessage";
                    break;
                case 6489:
                    ClasseName = "TreasureHuntRequestAnswerMessage";
                    break;
                case 6486:
                    ClasseName = "TreasureHuntMessage";
                    break;
                case 6483:
                    ClasseName = "TreasureHuntFinishedMessage";
                    break;
                case 6484:
                    ClasseName = "TreasureHuntDigRequestAnswerMessage";
                    break;
                case 6509:
                    ClasseName = "TreasureHuntDigRequestAnswerFailedMessage";
                    break;
                case 6507:
                    ClasseName = "TreasureHuntFlagRequestAnswerMessage";
                    break;
                case 6491:
                    ClasseName = "TreasureHuntAvailableRetryCountUpdateMessage";
                    break;
                case 1502:
                    ClasseName = "PartsListMessage";
                    break;
                case 1508:
                    ClasseName = "PartInfoMessage";
                    break;
                case 1511:
                    ClasseName = "DownloadCurrentSpeedMessage";
                    break;
                case 1513:
                    ClasseName = "DownloadErrorMessage";
                    break;
                default:
                    ClasseName = "Id inconnu";
                    break;
            }
            return ClasseName;
        }
    }
}
