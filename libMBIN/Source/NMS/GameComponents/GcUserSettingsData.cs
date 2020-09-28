﻿using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3930, GUID = 0x838C05025A95A72C, NameHash = 0x3A50D683FD1CF4BF)]
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x0000 */ public bool InvertLookControls;
        /* 0x0001 */ public bool InvertFlightControls;
        /* 0x0002 */ public bool HUDHidden;
        /* 0x0003 */ public bool Vibration;
        /* 0x0004 */ public int ScreenBrightness;
        /* 0x0008 */ public int MusicVolume;
        /* 0x000C */ public int SfxVolume;
        /* 0x0010 */ public int LookSensitivityV2;
        /* 0x0014 */ public int FlightSensitivityV2;
        /* 0x0018 */ public int MouseSpringSmoothing;
        /* 0x001C */ public GcBlockListPersistence BlockList;
        /* 0x386C */ public int MotionBlurAmount;
        /* 0x3870 */ public int Filter;
        /* 0x3874 */ public bool DamageNumbers;
        public enum PS4FixedFPSEnum { Invalid, False, True}
        /* 0x3878 */ public PS4FixedFPSEnum PS4FixedFPS;
        /* 0x387C */ public float PS4FOVFoot;
        /* 0x3880 */ public float PS4FOVShip;
        /* 0x3884 */ public bool XboxOneXHighResolutionMode;
        /* 0x3885 */ public bool PS4VignetteAndScanlines;
        public enum BaseSharingModeEnum { Undecided, On, Off }
		/* 0x3888 */ public BaseSharingModeEnum BaseSharingMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x388C */ public byte[] Padding380C;
        /* 0x3890 */ public List<NMSString0x10> SeenSubstances;
        /* 0x38A0 */ public List<NMSString0x10> SeenTechnologies;
        /* 0x38B0 */ public List<NMSString0x10> SeenProducts;
        /* 0x38C0 */ public List<NMSString0x20> SeenWikiTopics;
        /* 0x38D0 */ public List<NMSString0x20> UnlockedWikiTopics;
        /* 0x38E0 */ public List<NMSString0x10> UnlockedTitles;
        /* 0x38F0 */ public bool VoiceChat;
        /* 0x38F1 */ public bool Multiplayer;
        /* 0x38F2 */ public bool InstantUIInputs;
        /* 0x38F3 */ public bool SpeechToText;
        /* 0x38F4 */ public bool Translate;
        /* 0x38F5 */ public bool CrossPlatform;
        public enum TemperatureUnitEnum { Invalid, C, F, K }
        /* 0x38F8 */ public TemperatureUnitEnum TemperatureUnit;
        /* 0x38FC */ public bool UseOldMouseFlight;
        /* 0x3900 */ public int LastSeenCommunityMission;
        /* 0x3904 */ public int LastSeenCommunityMissionTier;
        public enum MovementModeEnum { Teleporter, Smooth }
        /* 0x3908 */ public MovementModeEnum MovementMode;
        /* 0x390C */ public GcMovementDirection MovementDirectionPad;
        /* 0x3910 */ public GcMovementDirection MovementDirectionHands;
        public enum TurnModeEnum { Smooth, Snap }
        /* 0x3914 */ public TurnModeEnum TurnMode;
        /* 0x3918 */ public bool UseVrVignette;
        /* 0x3919 */ public bool UseShipAutoControlVignette;
        /* 0x391C */ public float HUDZoom;
        /* 0x3920 */ public float FrontendZoom;
        /* 0x3924 */ public bool UseAutoTorch;
        /* 0x3925 */ public bool VRHeadBob;
        /* 0x3926 */ public bool VRShowBody;
        /* 0x3927 */ public bool BaseComplexityLimitsEnabled;
        /* 0x3928 */ public bool EnableLargeLobbies;
        /* 0x392C */ public int FireteamSessionCount;
    }
}
