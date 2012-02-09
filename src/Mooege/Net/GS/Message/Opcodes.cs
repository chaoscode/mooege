﻿/*
 * Copyright (C) 2011 - 2012 mooege project - http://www.mooege.org
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

namespace Mooege.Net.GS.Message
{
    public enum Opcodes : int
    {
        TryConsoleCommand1 = 1,
        TryConsoleCommand2 = 2,
        QuitGameMessage = 3, // len: 	12
        CreateBNetGameMessage = 4, // len: 	88
        CreateBNetGameResultMessage = 5, // len: 	40
        DWordDataMessage1 = 6, // len: 	12
        RequestJoinBNetGameMessage = 8, // len: 	56
        BNetJoinGameRequestResultMessage = 9, // len: 	72
        JoinBNetGameMessage = 10, // len: 	80
        JoinLANGameMessage = 11, // len: 	196
        VersionsMessage = 13, // len: 	48
        GenericBlobMessage1 = 14, // len: 	
        NetworkAddressMessage = 15, // len: 	16
        GameIdMessage = 17, // len: 	32
        UInt64DataMessage = 18, // len: 	16
        IntDataMessage1 = 20, // len: 	12
        EntityIdMessage = 22, // len: 	24
        CreateHeroMessage = 23, // len: 	68
        CreateHeroResultMessage = 24, // len: 	32
        SimpleMessage1 = 25, // len: 	8
        BlizzconCVarsMessage = 26, // len: 	20
        SimpleMessage2 = 27, // len: 	8
        GenericBlobMessage2 = 28, // len: 	
        GenericBlobMessage3 = 29, // len: 	
        GenericBlobMessage4 = 30, // len: 	
        GenericBlobMessage5 = 31, // len: 	
        OpenArtisanWindowMessage = 32, // len: 	12 former ANNDataMessage1
        ArtisanWindowClosedMessage = 33, // len: 	8 former SimpleMessage3
        OpenTradeWindow = 34, // len: 	12          former ANNDataMessage2
        RequestBuyItemMessage = 35, // len: 	12, former ANNDataMessage3
        RequestSellItemMessage = 36, // len: 	12, former ANNDataMessage4
        //RequestUseCauldronOfJordanMessage = 37, // len: 	12  former ANNDataMessage5
        LogoutContextMessage1 = 37, // len: 	16
        LogoutTickTimeMessage = 38, // len: 	20
        LogoutComplete = 39, // len: 	8 formor SimpleMessage4
        LogoutContextMessage2 = 40, // len: 	16
        PlayerIndexMessage1 = 41, // len: 	12
        PlayerIndexMessage2 = 42, // len: 	12
        SimpleMessage5 = 43, // len: 	8
        SimpleMessage6 = 44, // len: 	8
        TutorialMessage = 45, //len:    former GenericBlobMessage6
        GenericBlobMessage15 = 46, //len:  added 8058
        Message = 47, //len: 36
        SimpleMessage48 = 48, //Len: 8  added 8058
        ConnectionEstablishedMessage = 49, // len: 	20
        GameSetupMessage = 50, // len: 	20
        SimpleMessage7 = 51, // len: 	8
        NewPlayerMessage = 52, // len: 	16916
        PlayerBannerMessage = 53, // len: 	former GenericBlobMessage7
        EnterWorldMessage = 54, // len: 	28
        RevealSceneMessage = 55, // len: 	1292
        DestroySceneMessage = 56, // len: 	16
        SwapSceneMessage = 57, // len: 	20
        RevealWorldMessage = 58, // len: 	16
        RevealTeamMessage = 59, // len: 	20
        PlayerActorSetInitialMessage = 60, // len: 	16
        HeroStateMessage = 61, // len: 	16652
        ACDEnterKnownMessage = 62, // len: 	132
        ACDDestroyActorMessage = 63, // len: 	12 former ANNDataMessage6
        PlayerEnterKnownMessage = 64, // len: 	16
        ACDCreateActorMessage = 65, // len: 	12 former ANNDataMessage7
        ACDWorldPositionMessage = 66, // len: 	48
        ACDInventoryPositionMessage = 67, // len: 	32
        ACDInventoryUpdateActorSNO = 68, // len: 	16
        TrickleMessage = 69, // len: 	116
        ANNDataMessage8 = 70, // len: 	12
        MapRevealSceneMessage = 71, // len: 	52
        SavePointInfoMessage = 72, // len: 	12
        HearthPortalInfoMessage = 73, // len: 	16
        ReturnPointInfoMessage = 74, // len: 	12
        AffixMessage = 75, // len: 	148
        RareMonsterNamesMessage = 76, // len: 	52
        RareItemNameMessage = 77, // len: 	28
        PortalSpecifierMessage = 78, // len: 	24
        AttributeSetValueMessage = 79, // len: 	28
        AttributesSetValuesMessage = 80, // len: 	256
        VisualInventoryMessage = 81, // len: 	140
        ProjectileStickMessage = 82, // len: 	28
        TargetMessage = 83, // len: 	60
        SecondaryAnimationPowerMessage = 84, // len: 	28
        LoopingAnimationPowerMessage = 85, // len:  20
        DWordDataMessage2 = 86, // len: 	12
        DWordDataMessage3 = 87, // len: 	12
        DWordDataMessage4 = 88, // len: 	12
        DWordDataMessage5 = 89, // len: 	12
        TryChatMessage = 90, // len: 	528
        ChatMessage = 91, // len: 	528
        ANNDataMessage9 = 92, // len: 	12
        InventoryRequestMoveMessage1 = 93, // len: 	28
        InventoryRequestQuickMoveMessage = 94, // len:  28
        InventoryRequestSocketMessage = 95, // len: 	16
        InventoryRequestMoveMessage2 = 96, // len: 	28
        InventorySplitStackMessage = 97, // len: 	40
        InventoryDropStackPortionMessage = 98, //len:   24
        InventoryStackTransferMessage = 99, // len: 	24
        ANNDataMessage10 = 100, // len: 	12
        SimpleMessage47 = 101, //len 8 added in 7841
        ANNDataMessage11 = 102, // len: 	12
        InventoryRequestUseMessage = 103, // len: 	36
        SocketSpellMessage = 104, // len: 	16
        HelperDetachMessage = 105, // len: 	12
        AssignSkillMessage1 = 106, // len: 	16
        AssignSkillMessage2 = 107, // len: 	16
        AssignSkillMessage3 = 108, // len: 	16
        AssignSkillMessage4 = 109, // len: 	16
        HirelingRequestLearnSkillMessage = 110, // len: 	20
        HotbarButtonData = 111, // len: 	12 former ANNDataMessage12
        PlayerChangeHotbarButtonMessage = 112, // len: 	20
        IntDataMessage2 = 113, // len: 	12 dont know why someone renamed it PlayAnimationMessageSpec 
        PlayAnimationMessage = 114, // len: 	72
        ANNDataMessage13 = 115, // len: 	12
        ACDTranslateNormalMessage = 116, // len: 	76 former ACDTranslateNormalMessage1
        ACDTranslateSnappedMessage = 117, // len: 	36
        ACDTranslateFacingMessage = 118, // len: 	20
        ACDTranslateFixedMessage = 119, // len: 	36
        ACDTranslateArcMessage = 120, // len: 	60
        ACDTranslateDetPathMessage = 121, // len: 	88
        ACDTranslateDetPathSinMessage = 122, // len: 	104
        ACDTranslateDetPathSpiralMessage = 123, // len: 	72
        ACDTranslateSyncMessage = 124, // len: 	32
        ACDTranslateFixedUpdateMessage = 125, // len: 	36
        ACDClientTranslateMessage = 126, //len: 44 (Added patch 8)
        PlayerTranslateFacingMessage = 127, // len: 	20 former ACDTranslateFacingMessage2
        PlayEffectMessage = 128, // len: 	24
        PlayHitEffectMessage = 129, // len: 	24
        PlayHitEffectOverrideMessage = 130, // len: 	20
        PlayNonPositionalSoundMessage = 131, // len: 	12
        PlayErrorSoundMessage = 132, // len: 	12
        PlayMusicMessage = 133, // len: 	12
        PlayCutsceneMessage = 134, // len: 	12
        ComplexEffectAddMessage = 135, // len: 	36
        FlippyMessage = 136, // len: 	32
        WaypointActivatedMessage = 137, // len: 	20
        OpenWaypointSelectionWindowMessage = 138, // len: 	12 former ANNDataMessage14
        ANNDataMessage15 = 139, // len: 	12
        ANNDataMessage16 = 140, // len: 	12
        AimTargetMessage = 141, // len: 	36
        ACDChangeGBHandleMessage = 142, // len: 	20
        GameTickMessage = 143, // len: 	12  former DWordDataMessage6
        DataIDDataMessage1 = 144, // len: 	12
        DataIDDataMessage2 = 145, // len: 	12
        EndOfTickMessage = 146, // len: 	16
        TryWaypointMessage = 147, // len: 	16
        NPCInteractOptionsMessage = 148, // len: 	340
        ANNDataMessage17 = 149, // len: 	12
        ANNDataMessage18 = 150, // len: 	12
        SimpleMessage8 = 151, // len: 	8
        QuestUpdateMessage = 152, // len: 	28
        QuestMeterMessage = 153, // len: 	20
        QuestCounterMessage = 154, // len: 	20
        QuestStepCompleteMessage = 155, // len:  // former GenericBlobMessage8	
        PlayerIndexMessage3 = 156, // len: 	12
        PlayerLevel = 157, // len: 	16
        OpenSharedStashMessage = 158, // len: 	12, former ANNDataMessage19
        UseNephalemAltarMessage = 159, //len:  12 added 7728 ANNDataMessage
        NephalemAltarWindowClosedMessage = 160, // len: 8   former SimpleMessage9
        ACDPickupFailedMessage = 161, // len: 	16
        PetMessage = 162, // len: 	24
        PetDetachMessage = 163, // len: 16
        HirelingInfoUpdateMessage = 164, // len: 	24
        UIElementMessage = 165, // len: 	16
        PlayerBusyMessage = 166, // len: 	12      //  former: BoolDataMessage1
        TradeMessage1 = 167, // len: 	56
        TradeMessage2 = 168, // len: 	56
        PlayerIndexMessage4 = 169, // len: 	12
        SimpleMessage10 = 170, // len: 	8
        PlayerIndexMessage5 = 171, // len: 	12
        SetIdleAnimationMessage = 172, // len: 	16
        ACDCollFlagsMessage = 173, // len: 	16
        GoldModifiedMessage = 174, // len: 	12
        ActTransitionMessage = 175, // len: 	16
        InterstitialMessage = 176, // len: 	16
        EffectGroupACDToACDMessage = 177, // len: 	20
        RopeEffectMessageACDToACD = 178, // len: 	28
        RopeEffectMessageACDToPlace = 179, // len: 	36
        ANNDataMessage21 = 180, // len: 	12
        ShrineActivatedMessage = 181, // len: 	12   former ANNDataMessage22
        GameSyncedDataMessage = 182, // len: 	96
        ACDChangeActorMessage = 183, // len: 	16
        PlayerWarpedMessage = 184, // len: 	16
        VictimMessage = 185, // len: 	48
        KillCountMessage = 186, // len: 	24
        WorldStatusMessage = 187, // len: 	16
        WeatherOverrideMessage = 188, // len: 	16
        SimpleMessage11 = 189, // len: 	8
        ACDShearMessage = 190, // len: 	16
        ACDGroupMessage = 191, // len: 	20
        SimpleMessage12 = 192, // len: 	8
        PlayConvLineMessage = 193, // len: 	172
        StopConvLineMessage = 194, // len: 	16
        AdvanceConvMessage = 195, //len : 16
        UpdateConvAutoAdvanceMessage = 196, // len: 20
        RequestCloseConversationWindowMessage = 197, // len: 	8 former SimpleMessage13
        EndConversationMessage = 198, // len: 	20
        SNODataMessage2 = 199, // len: 	12
        FinishConversationMessage = 200, // len: 	12 former SNODataMessage3
        HirelingSwapMessage1 = 201, // len: 	12
        HirelingSwapMessage2 = 202, // len: 	12
        SimpleMessage14 = 203, // len: 	8
        DeathFadeTimeMessage = 204, // len: 	24
        ANNDataMessage23 = 205, // len: 	12
        ANNDataMessage24 = 206, // len: 	12
        DisplayGameTextMessage = 207, // len: 	536
        IntDataMessage4 = 208, // len: 	12
        DWordDataMessage7 = 209, // len: 	12
        GBIDDataMessage1 = 210, // len: 	12
        ANNDataMessage25 = 211, // len: 	12
        ANNDataMessage26 = 212, // len: 	12
        ACDLookAtMessage = 213, // len: 	16
        KillCounterUpdateMessage = 214, // len: 	24
        LowHealthCombatMessage = 215, // len: 	16
        SaviorMessage = 216, // len: 	16
        FloatingNumberMessage = 217, // len: 	20
        FloatingAmountMessage = 218, // len: 	40
        RemoveRagdollMessage = 219, // len: 	16
        SNONameDataMessage = 220, // len: 	16
        LoreMessage = 221, // len: 	16
        DWordDataMessage12 = 224, // len: 12 added 8059
        WorldDeletedMessage = 225, // len: 	12
        SimpleMessage16 = 226, // len: 	8
        IntDataMessage5 = 227, // len: 	12
        TimedEventStartedMessage = 228, // len: 	20
        SNODataMessage4 = 229, // len: 	12
        ActTransitionStartedMessage = 230, // len: 	16
        SimpleMessage17 = 231, // len: 	8 //added in 7728
        RequestBuySharedStashSlotsMessage = 232, // len: 	8   former SimpleMessage17
        PlayerQuestMessage1 = 233, // len: 	16
        PlayerQuestMessage2 = 234, // len: 	16
        PlayerDeSyncSnapMessage = 235, // len: 	28
        RequestUseNephalemCubeMessage = 236, // len: 	12  former ANNDataMessage27
        SalvageResultsMessage = 237, // len: 	60
        SimpleMessage18 = 238, // len: 	8
        MapMarkerInfoMessage = 239, // len: 	72
        BlacksmithDataProgressMessage = 240, // len: 	   former GenericBlobMessage9
        JewelerDataProgressMessage = 241, // len: 	   former GenericBlobMessage10
        MysticDataProgressMessage = 242, // len: 	former GenericBlobMessage11
        BlacksmithDataInitialMessage = 243, // len:   former genericBlobMessage 12	
        JewelerDataInitialMessage = 244, // len: 	former GenericBlobMessage13
        MysticDataInitialMessage = 245, // len: 	former GenericBlobMessage14 
        ANNDataMessage28 = 246, // len: 	12
        DebugActorTooltipMessage = 247, // len: 	524
        BossEncounterMessage1 = 248, // len: 	16
        SimpleMessage20 = 249, // len: 	8
        SimpleMessage21 = 250, // len: 	8
        BossEncounterMessage2 = 251, // len: 	16
        SimpleMessage22 = 252, // len: 	8
        SimpleMessage23 = 253, // len: 	8
        EncounterInviteStateMessage = 254, // len: 	12
        SimpleMessage24 = 255, // len: 	8
        SimpleMessage25 = 256, // len: 	8
        IntDataMessage3 = 257, // len: 12 added 8059
        SimpleMessage26 = 258, // len: 	8
        SimpleMessage27 = 259, // len: 	8
        SimpleMessage28 = 260, // len: 	8
        SimpleMessage29 = 261, // len: 	8
        CameraFocusMessage = 262, // len: 	20
        CameraZoomMessage = 263, // len: 	20
        CameraYawMessage = 264, // len: 	20
        SimpleMessage30 = 265, // len: 	8
        BoolDataMessage2 = 266, // len: 	12
        BossZoomMessage = 267, // len: 	16
        EnchantItemMessage = 268, // len: 	16
        ANNDataMessage29 = 269, // len: 	12
        SimpleMessage31 = 270, // len: 	8
        SimpleMessage32 = 271, // len: 	8
        //RequestAddSocketMessage = 272, // len: 	12 former ANNDataMessage30
        RequestTrainArtisanMessage = 272, // len: 	8   former SimpleMessage33
        IntDataMessage6 = 273, // len: 	12
        DebugDrawPrimMessage = 274, // len: 	188
        GBIDDataMessage2 = 275, // len: 	12
        CraftingResultsMessage = 276, // len: 	20
        CrafterLevelUpMessage = 277, // len: 	20
        SimpleMessage34 = 278, // len: 	8
        ANNDataMessage31 = 279, // len: 	12
        ANNDataMessage32 = 280, // len: 	12
        ANNDataMessage33 = 281, // len: 	12
        IntDataMessage7 = 282, // len: 	12
        IntDataMessage8 = 283, // len: 	12
        IntDataMessage9 = 284, // len: 	12
        SimpleMessage35 = 285, // len: 	8
        SimpleMessage36 = 286, // len: 	8
        GameTestingSamplingStartMessage = 287, // len: 	16
        SimpleMessage37 = 288, // len: 	8
        TutorialShownMessage = 289, // len: 	12 former SNODataMessage5
        RequestBuffCancelMessage = 290, // len: 	16
        SimpleMessage38 = 291, // len: 	8
        PlayerIndexMessage7 = 292, // len: 	12
        SimpleMessage39 = 293, // len: 	8
        SimpleMessage40 = 294, // len: 	8
        DWordDataMessage8 = 295, // len: 	12
        DWordDataMessage9 = 296, // len: 	12
        DWordDataMessage10 = 297, // len: 	12
        DWordDataMessage11 = 298, // len: 	12
        BroadcastTextMessage = 299, // len: 	520
        SimpleMessage41 = 300, // len: 	8
        SimpleMessage42 = 301, // len: 	8
        NPCSelectConversationMessage = 302, // len: 	12 former SNODataMessage6
        HirelingDismissMessage = 303, // len: 	12 former ANNDataMessage33
        CraftInteractionMessage = 304, // len: 	8 former SimpleMessage43
        HirelingHireMessage = 305, // len: 	8 former SimpleMessage44
        HirelingInventoryMessage = 306, // len: 	8 former SimpleMessage45
        SNODataMessage7 = 307, // len:  12
        //SimpleMessage46 = 307, // len: 	8
        ActTransitionStartedMessage2 = 308, //len:   16
        VoteKickMessage1 = 309, //len:   528
        PlayerIndexMessage8 = 310, // len: 	12
        PlayerIndexMessage9 = 311, // len: 	12
        VoteKickMessage2 = 312, //len:   528
        BoolDataMessage3 = 313, // len: 	12
        PlayerIndexMessage10 = 314, // len: 	12
        PlayerIndexMessage11 = 315, // len: 	12
    }
}
