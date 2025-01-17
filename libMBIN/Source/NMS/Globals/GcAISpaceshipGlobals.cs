using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0xF70, GUID = 0x57D137DB00D02984, NameHash = 0xD338272248F67908)]
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        /* 0x000 */ public GcPlayerSquadronConfig PlayerSquadronConfig;
        /* 0x240 */ public bool DisplayShipAttackTypes;
        /* 0x244 */ public float MinimumCircleTimeBeforeLanding;
        /* 0x248 */ public float MinimumTimeBetweenOutpostLandings;
        /* 0x24C */ public float VisibleDistance;
        /* 0x250 */ public bool TradersAttackPirates;
        /* 0x251 */ public bool FreightersAlwaysAttackPlayer;
        /* 0x252 */ public bool GroundEffectEnabled;
        /* 0x253 */ public bool AtmosphereEffectEnabled;
        /* 0x254 */ public bool FillUpOutposts;
        /* 0x258 */ public float SalvageTime;
        /* 0x25C */ public float SalvageRemovalTime;
        /* 0x260 */ public float SalvageValueMultiplier;
        /* 0x264 */ public float DockingWaitDistance;
        /* 0x268 */ public int MaxNumActiveTraders;
        /* 0x26C */ public float MaxNumActiveTraderRadius;
        /* 0x270 */ public int MaxNumActivePolice;
        /* 0x274 */ public float MaxNumActivePoliceRadius;
        /* 0x278 */ public int MinAggroDamage;
        /* 0x27C */ public float TrailLandingFadeTime;
        /* 0x280 */ public bool EnergyShieldsEnabled;
        /* 0x281 */ public NMSString0x80 EnergyShield;
        /* 0x308 */ public NMSString0x10 EnergyShieldDepletedEffect;
        /* 0x318 */ public NMSString0x10 EnergyShieldStartRechargeEffect;
        /* 0x328 */ public NMSString0x10 EnergyShieldStartRechargeFromDepletedEffect;
        /* 0x338 */ public bool EnergyShieldAlwaysVisible;
        /* 0x33C */ public float EnergyShieldFadeMinOpacityInCombat;
        /* 0x340 */ public float EnergyShieldFadeNonPlayerHitOpacity;
        /* 0x344 */ public float EnergyShieldFadeInRate;
        /* 0x348 */ public float EnergyShieldFadeOutRate;
        /* 0x34C */ public float MinLaserFireTime;
        /* 0x350 */ public float ShipAlertPirateRange;
        /* 0x354 */ public float PlanetaryPirateHostileShipPerceptionRange;
        /* 0x358 */ public float PlanetaryPirateRaidFocusBuildingsTime;
        /* 0x35C */ public float PlanetaryPirateRaidTradersEngageTime;
        /* 0x360 */ public int PlanetaryPirateRaidMaxTradersJoinCombat;
        /* 0x364 */ public float EscapeRollTimePlanet;
        /* 0x368 */ public float EscapeRollTime;
        /* 0x36C */ public float EscapeRollPlanet;
        /* 0x370 */ public float EscapeRoll;
        /* 0x374 */ public int CrashedShipMinNonBrokenSlots;
        /* 0x378 */ public float CrashedShipBrokenSlotChance;
        /* 0x37C */ public float CrashedShipBrokenTechChance;
        /* 0x380 */ public float CrashedShipRepairSlotCostIncreaseFactor;
        /* 0x384 */ public float CrashedShipGeneralCostDiscount;
        /* 0x388 */ public float CrashedShipTechSlotsCostDiscount;
        /* 0x38C */ public float PirateSpawnSpacing;
        /* 0x390 */ public float DistanceFlareMinDistance;
        /* 0x394 */ public float DistanceFlareRange;
        /* 0x398 */ public float DistanceFlareMinScale;
        /* 0x39C */ public float DistanceFlareMaxScale;
        /* 0x3A0 */ public float DistanceFlareMinSpeed;
        /* 0x3A4 */ public float DistanceFlareSpeedRange;
        /* 0x3A8 */ public float DistanceFlareFlickerFreq;
        /* 0x3AC */ public float DistanceFlareFlickerAmp;
        /* 0x3B0 */ public bool AttackRepositionBoost;
        /* 0x3B1 */ public bool AttackShipsFollowLeader;
        /* 0x3B4 */ public float AttackTooCloseMinRelSpeed;
        [NMS(Size = 0x7)]
        /* 0x3B8 */ public NMSString0x10[] ProjectileWeaponMuzzleFlashes;
        /* 0x428 */ public float RewardLootOffset;
        /* 0x42C */ public float RewardLootOffsetSpeed;
        /* 0x430 */ public float RewardLootAngularSpeed;
        /* 0x434 */ public float FlybyPlanetLandingProbability;
        /* 0x438 */ public GcCombatEffectsComponentData CombatEffectsComponentData;
        /* 0x468 */ public GcSpaceshipTravelData FallbackTravelData;
        /* 0x4B0 */ public GcSpaceshipTravelData SlowCombatEffectAttackTravel;
        /* 0x4F8 */ public GcSpaceshipTravelData AsteroidMiningPositioningTravelData;
        /* 0x540 */ public GcSpaceshipTravelData AsteroidMiningTravelData;
        /* 0x588 */ public float AsteroidMiningSearchRadius;
        /* 0x58C */ public float AsteroidMiningMaxAsteroidRadius;
        /* 0x590 */ public float AsteroidMiningMaxViewAngleYaw;
        /* 0x594 */ public float AsteroidMiningMinViewAnglePitch;
        /* 0x598 */ public float AsteroidMiningMaxViewAnglePitch;
        /* 0x59C */ public float AsteroidMiningMinDistFromPlayer;
        /* 0x5A0 */ public float AsteroidMiningMinMiningAngle;
        /* 0x5A4 */ public float AsteroidMiningMaxMiningTime;
        /* 0x5A8 */ public float AttackShipAvoidStartTime;
        /* 0x5AC */ public float AttackMinimumTimeBeforeTargetSwitch;
        /* 0x5B0 */ public float PirateExtraDamage;
        [NMS(Size = 0x34, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x5B4 */ public bool[] PirateAttackableBuildingClasses;
        /* 0x5E8 */ public float PirateMaintainBuildingTargetTime;
        /* 0x5EC */ public float ShieldCollisionRadiusMultiplier;
        /* 0x5F0 */ public float CollisionRayLengthMin;
        /* 0x5F4 */ public float CollisionRayLengthMax;
        /* 0x5F8 */ public GcSpaceshipTravelData OutpostLanding;
        /* 0x640 */ public GcSpaceshipTravelData PlanetLanding;
        /* 0x688 */ public float OutpostLandingNoiseFreq;
        /* 0x68C */ public float OutpostLandingNoiseAmp;
        /* 0x690 */ public float OutpostLandingNoiseOffset;
        /* 0x694 */ public float OutpostDockUpAlignMaxAngleFirstPerson;
        /* 0x698 */ public float OutpostDockUpAlignMaxAngle;
        /* 0x69C */ public float OutpostDockMaxApproachSpeed;
        /* 0x6A0 */ public float OutpostDockOverspeedBrake;
        /* 0x6A4 */ public float OutpostDockGetToApproachForce;
        /* 0x6A8 */ public float OutpostDockGetToApproachBrakeForce;
        /* 0x6AC */ public float OutpostDockGetToApproachExtraBrakeForce;
        /* 0x6B0 */ public float OutpostDockApproachSpeedForce;
        /* 0x6B4 */ public float OutpostDockApproachDistance;
        /* 0x6B8 */ public float OutpostDockApproachSpeedUpDamper;
        /* 0x6BC */ public float OutpostDockAIGetToApproachForce;
        /* 0x6C0 */ public float OutpostDockAIGetToApproachBrakeForce;
        /* 0x6C4 */ public float OutpostDockAIApproachSpeedForce;
        /* 0x6C8 */ public float OutpostDockMaxForce;
        /* 0x6CC */ public float OutpostDockMinTipLength;
        /* 0x6D0 */ public float OutpostDockMaxTipLength;
        /* 0x6D4 */ public float OutpostDockApproachUpAmount;
        /* 0x6D8 */ public float OutpostDockApproachRenderRadius;
        /* 0x6DC */ public float OutpostDockApproachRenderFlickerOffset;
        /* 0x6E0 */ public float LandingTipAngle;
        /* 0x6E4 */ public float LandingLongTipAngle;
        /* 0x6E8 */ public Vector2f SpaceBattleSpawnAngle;
        /* 0x6F0 */ public Vector2f SpaceBattleSpawnPitch;
        /* 0x6F8 */ public Vector2f SpaceBattleSpawnOffset;
        /* 0x700 */ public Vector2f SpaceBattleSunHeightAngle;
        /* 0x708 */ public Vector2f SpaceBattleSunAroundAngle;
        /* 0x710 */ public List<Vector2f> SpaceBattleSpawnRange;
        /* 0x720 */ public List<Vector2f> SpaceBattlePirateRange;
        /* 0x730 */ public List<Vector2f> SpaceBattleGuardsRange;
        /* 0x740 */ public float SpaceBattleGuardOffset;
        /* 0x744 */ public float SpaceBattleGuardUpOffset;
        /* 0x748 */ public float SpaceBattleInitialPirateUpOffset;
        /* 0x74C */ public float SpaceBattleInitialPirateOffset;
        /* 0x750 */ public float SpaceBattleObstructionRadius;
        /* 0x754 */ public float SpaceBattleFlybyTime;
        /* 0x758 */ public int SpaceBattleLevel;
        /* 0x75C */ public Vector2f ConeSpawnOffsetFactor;
        /* 0x764 */ public float ConeSpawnFlattenUp;
        /* 0x768 */ public float ConeSpawnFlattenDown;
        /* 0x76C */ public bool FreighterAlertLights;
        /* 0x770 */ public float FreighterAlertLightCapitalSize;
        /* 0x774 */ public NMSString0x80 LegacyHangarFilename;
        /* 0x7F4 */ public NMSString0x80 HangarFilename;
        /* 0x874 */ public float PoliceFreighterWarpOutRange;
        /* 0x878 */ public float MissileRange;
        /* 0x880 */ public Colour FreighterDoorColourActive;
        /* 0x890 */ public Colour FreighterDoorColourInactive;
        /* 0x8A0 */ public Colour AlertLightColour;
        /* 0x8B0 */ public TkHitCurveData FreighterLightHitCurve;
        /* 0x8C0 */ public float FreighterAlertLightTime;
        /* 0x8C4 */ public float FreighterAlertLightIntensity;
        /* 0x8C8 */ public int MaxNumTurretMissiles;
        /* 0x8CC */ public float TurretOriginOffset;
        /* 0x8D0 */ public float TurretAlertLightIntensity;
        /* 0x8E0 */ public Vector3f TurretAlertLightOffset;
        /* 0x8F0 */ public bool DisableTradeRoutes;
        /* 0x8F4 */ public float AttackFreighterGetThereBoost;
        /* 0x8F8 */ public float AttackFreighterApproach;
        /* 0x8FC */ public float AttackFreighterWingmanAlignMinDist;
        /* 0x900 */ public float AttackFreighterWingmanAlignRange;
        /* 0x904 */ public float AttackFreighterApproachDistance;
        /* 0x908 */ public float AttackFreighterAttackRunStartDistance;
        /* 0x90C */ public float AttackFreighterBugOutDistance;
        /* 0x910 */ public float AttackFreighterButOutTurnUp;
        /* 0x914 */ public float AttackFreighterButOutSpeedUp;
        /* 0x918 */ public float AttackFreighterWingmanRadius;
        /* 0x91C */ public float AttackFreighterWingmanOffset;
        /* 0x920 */ public float AttackFreighterWingmanLockAlign;
        /* 0x924 */ public float AttackFreighterWingmanLock;
        /* 0x928 */ public float AttackFreighterWingmanMaxForce;
        /* 0x92C */ public float AttackFreighterAngle;
        /* 0x930 */ public float AttackFreighterRunOffset;
        /* 0x934 */ public float AttackFreighterWingmanStart;
        /* 0x938 */ public float PirateFreighterWarpOffset;
        /* 0x93C */ public Vector2f PirateFreighterAttackRange;
        /* 0x944 */ public float MissileLaunchSpeed;
        /* 0x948 */ public float AttackAfterSpawnTime;
        /* 0x94C */ public Vector2f FreighterMiniSpeeds;
        /* 0x954 */ public float AttackBuildingGetThereBoost;
        /* 0x958 */ public float AttackBuildingApproachDistance;
        /* 0x95C */ public float AttackBuildingRunStartDistance;
        /* 0x960 */ public float AttackBuildingAttackRunDistTolerance;
        /* 0x964 */ public float AttackBuildingFiringAngleTolerance;
        /* 0x968 */ public float AttackBuildingBugOutDistance;
        /* 0x96C */ public float AttackBuildingBugOutTurnUp;
        /* 0x970 */ public float AttackBuildingBugOutSpeedUp;
        /* 0x974 */ public float AttackBuildingRunAngleMin;
        /* 0x978 */ public float AttackBuildingRunAngleMax;
        /* 0x97C */ public float AttackBuildingNextRunAngleDeltaMin;
        /* 0x980 */ public float AttackBuildingNextRunAngleDeltaMax;
        /* 0x984 */ public float AttackBuildingTargetGroundOffsetScaleStart;
        /* 0x988 */ public float AttackBuildingTargetGroundOffsetScaleEnd;
        /* 0x98C */ public float AsteroidShootAngle;
        /* 0x990 */ public float TraderWantedTime;
        /* 0x994 */ public float TraderRequestTime;
        /* 0x998 */ public float TraderPostCombatRequestTime;
        /* 0x99C */ public float TradingPostTraderRequestTime;
        /* 0x9A0 */ public float TradingPostTraderRange;
        /* 0x9A4 */ public float TradingPostTraderRangeSpace;
        /* 0x9A8 */ public float SpaceStationTraderRequestTime;
        /* 0x9AC */ public float AbandonedSystemShipSpawnProbablity;
        /* 0x9B0 */ public int FlybyCloseOdds;
        /* 0x9B4 */ public float BountySpawnAngle;
        /* 0x9B8 */ public float PoliceLaunchSpeed;
        /* 0x9BC */ public float PoliceLaunchTime;
        /* 0x9C0 */ public float PolicePauseTime;
        /* 0x9C4 */ public float PolicePauseTimeSpaceBattle;
        /* 0x9C8 */ public float PoliceEscapeTime;
        /* 0x9CC */ public float PoliceEscapeMinTime;
        /* 0x9D0 */ public float PoliceStationWaveTimer;
        /* 0x9D4 */ public float PoliceStationEngageRange;
        /* 0x9D8 */ public int PoliceStationNumToLaunch;
        /* 0x9DC */ public int TraderIgnoreHits;
        /* 0x9E0 */ public float PirateFreighterSpawnAttackAngle;
        /* 0x9E4 */ public float PirateFreighterSpawnAttackOffset;
        /* 0x9E8 */ public float PirateFreighterSpawnAttackSpread;
        /* 0x9EC */ public float PirateSpawnAngle;
        /* 0x9F0 */ public float PirateBattleMaxTime;
        /* 0x9F4 */ public float PirateArriveTime;
        /* 0x9F8 */ public float PirateStartSpeed;
        /* 0x9FC */ public float PirateBattleStartSpeed;
        /* 0xA00 */ public float PirateInterestTime;
        /* 0xA04 */ public float PirateBattleInterestTime;
        /* 0xA08 */ public float TraderArriveSpeed;
        /* 0xA0C */ public float TraderArriveTime;
        /* 0xA10 */ public float HeightTestSampleDistance;
        /* 0xA14 */ public float HeightTestSampleTime;
        /* 0xA18 */ public float OutpostToLandingDistance;
        /* 0xA1C */ public bool FreightersSamePalette;
        /* 0xA20 */ public float PlanetUpAlignTime;
        /* 0xA24 */ public float CollisionReactionTime;
        /* 0xA28 */ public float FreighterScale;
        /* 0xA2C */ public bool PoliceSpawnEffect;
        /* 0xA30 */ public int MaxNumFreighters;
        /* 0xA34 */ public float ShipSpawnStationRadius;
        /* 0xA38 */ public float ShipSpawnAnomalyRadius;
        /* 0xA3C */ public float BattleSpawnStationMinDistance;
        /* 0xA40 */ public float PoliceSpawnViewAngle;
        /* 0xA44 */ public float PoliceEntranceStartTime;
        /* 0xA48 */ public float PoliceEntranceProbe;
        /* 0xA4C */ public float PoliceEntranceEscalateProbingTime;
        /* 0xA50 */ public float PoliceEntranceEscalateIncomingTime;
        /* 0xA54 */ public float PoliceEntranceCargoScanStartTime;
        /* 0xA58 */ public float PoliceEntranceCargoProbingTime;
        /* 0xA5C */ public float PoliceEntranceCargoOpenCommsWaitTime;
        /* 0xA60 */ public float PoliceEntranceCargoAttackWaitTime;
        /* 0xA64 */ public float PoliceEntranceCargoScanHailNotificationWaitTime;
        /* 0xA68 */ public float PoliceArriveTime;
        /* 0xA6C */ public float PoliceAbortRange;
        /* 0xA70 */ public float PoliceWarnBeaconPulseTime;
        /* 0xA74 */ public float ArrivalStaggerOffset;
        /* 0xA78 */ public float TrailScaleMinDistance;
        /* 0xA7C */ public float TrailScale;
        /* 0xA80 */ public float TrailScaleRange;
        /* 0xA84 */ public float TrailScaleMaxScale;
        /* 0xA88 */ public float TrailScaleFreighterMaxScale;
        /* 0xA8C */ public TkCurveType TrailScaleCurve;
        /* 0xA90 */ public float TradeRouteSeekOutpostRange;
        /* 0xA94 */ public float TradeRouteFollowOffset;
        /* 0xA98 */ public NMSString0x100 TradeRouteIcon;
        /* 0xB98 */ public float TradeRouteSpawnDistance;
        /* 0xB9C */ public float TradeRouteTrailDrawDistance;
        /* 0xBA0 */ public float TradeRouteTrailFadeTime;
        /* 0xBA4 */ public float TradeRouteTrailTimeOffset;
        /* 0xBA8 */ public float TradeRouteStationRadius;
        /* 0xBAC */ public float TradeRouteSpeed;
        /* 0xBB0 */ public float TradeRouteSlowRange;
        /* 0xBB4 */ public float TradeRouteSlowSpeed;
        /* 0xBB8 */ public int TradeRouteDivisions;
        /* 0xBBC */ public float TradeRouteFlickerFreq;
        /* 0xBC0 */ public float TradeRouteFlickerAmp;
        /* 0xBC4 */ public int TradeRouteMaxNum;
        /* 0xBC8 */ public List<Colour> TradeRouteColours;
        /* 0xBD8 */ public bool EnableLoot;
        /* 0xBDC */ public float LaserHitOffset;
        /* 0xBE0 */ public float DirectionBrakeThresholdSq;
        /* 0xBE4 */ public int PoliceNumPerTarget;
        /* 0xBE8 */ public Vector2f PoliceSideOffset;
        /* 0xBF0 */ public Vector2f PoliceUpOffset;
        /* 0xBF8 */ public float WitnessHearingRange;
        /* 0xBFC */ public float WitnessSightRange;
        /* 0xC00 */ public float WitnessSightAngle;
        /* 0xC04 */ public float FreighterImpactScale;
        /* 0xC08 */ public float FreighterAlertThreshold;
        /* 0xC0C */ public float FreighterAttackDisengageDistance;
        /* 0xC10 */ public float FreighterAttackAlertThreshold;
        /* 0xC14 */ public float FreighterAlertTimeOutRate;
        /* 0xC18 */ public float FreighterAlertTimeOutMinTime;
        /* 0xC1C */ public float FreighterShipLaunchSpeed;
        /* 0xC20 */ public float FreighterLaunchTime;
        /* 0xC24 */ public float FreighterLaunchStartTime;
        /* 0xC28 */ public bool FreighterIgnorePlayer;
        /* 0xC2C */ public int FreighterNotifySquadAlertLevel;
        /* 0xC30 */ public int FreighterMaxNumLaunchedShips;
        /* 0xC34 */ public float FreighterSpawnMargin;
        /* 0xC38 */ public float FreighterSpawnRadius;
        /* 0xC3C */ public float FreighterSpawnRate;
        /* 0xC40 */ public float FreighterSpawnViewAngle;
        /* 0xC44 */ public float FreighterSpawnVisibleFreightersDistance;
        /* 0xC48 */ public float FrigateSpawnMargin;
        /* 0xC4C */ public float EngineFlareAccelMin;
        /* 0xC50 */ public float EngineFlareAccelMax;
        /* 0xC54 */ public float EngineFlareSizeMin;
        /* 0xC58 */ public float EngineFlareSizeMax;
        /* 0xC5C */ public float EngineFlareVibrateAmp;
        /* 0xC60 */ public float EngineFlareVibrateFreq;
        /* 0xC64 */ public float EngineFlareOffset;
        /* 0xC68 */ public float EngineFireSize;
        /* 0xC6C */ public float PitchFlip;
        /* 0xC70 */ public float AttackAimTime;
        /* 0xC74 */ public float AttackRunSlowdown;
        /* 0xC78 */ public float PiratePlayerAttackRange;
        /* 0xC7C */ public float MoveHeightAdjust;
        /* 0xC80 */ public float MoveAvoidRange;
        /* 0xC84 */ public int MoveHeightNumSamples;
        /* 0xC88 */ public float MoveHeightSampleSectionSize;
        /* 0xC8C */ public float MoveHeightCheckTime;
        /* 0xC90 */ public float TurretRandomOffset;
        /* 0xC94 */ public float TurretRandomAIShipOffset;
        /* 0xC98 */ public float PoliceLaunchDistance;
        /* 0xC9C */ public float Scaler;
        /* 0xCA0 */ public float ScaleTime;
        /* 0xCA4 */ public float ScalerMinDist;
        /* 0xCA8 */ public float ScalerMaxDist;
        /* 0xCAC */ public float ScaleHeightMin;
        /* 0xCB0 */ public float ScaleHeightMax;
        /* 0xCB4 */ public bool ScaleDisabledWhenOnFreighter;
        /* 0xCB8 */ public float WarpInPlayerLocatorTime;
        /* 0xCBC */ public float WarpInPlayerLocatorMinOffset;
        /* 0xCC0 */ public float WarpInTime;
        /* 0xCC4 */ public float WarpFadeInTime;
        /* 0xCC8 */ public float WarpInTimeFreighter;
        /* 0xCCC */ public TkCurveType WarpInCurve;
        /* 0xCD0 */ public float WarpInVariance;
        /* 0xCD4 */ public float WarpInDistance;
        /* 0xCD8 */ public float WarpInPostSpeed;
        /* 0xCDC */ public float WarpInPostSpeedFreighter;
        /* 0xCE0 */ public float WarpInAudioFXDelay;
        /* 0xCE4 */ public float WarpOutDistance;
        [NMS(Size = 0x7)]
        /* 0xCE8 */ public NMSString0x10[] WarpStartEffectIDs;
        [NMS(Size = 0x7)]
        /* 0xD58 */ public NMSString0x10[] WarpArriveEffectIDs;
        /* 0xDC8 */ public float ShipEscapeTimeBeforeWarpOut;
        /* 0xDCC */ public float ShipEscortLockOnDistance;
        /* 0xDD0 */ public float ShipEscortVelocityBand;
        /* 0xDD4 */ public float ShipEscortVelocityBandForce;
        /* 0xDD8 */ public float ShipEscortFwdForceTime;
        /* 0xDDC */ public float ShipEscortBackForceTime;
        /* 0xDE0 */ public float ShipEscortPerpForceTime;
        /* 0xDE4 */ public float ShipEscortRadialOffsetScaleMin;
        /* 0xDE8 */ public float ShipEscortRadialOffsetScaleMax;
        /* 0xDEC */ public float ShipEscortForwardOffsetScaleMin;
        /* 0xDF0 */ public float ShipEscortForwardOffsetScaleMax;
        /* 0xDF4 */ public float PirateFlybyLength;
        /* 0xDF8 */ public float FlybyLength;
        /* 0xDFC */ public float FlybyHeight;
        /* 0xE00 */ public float FlybyOffset;
        /* 0xE04 */ public GcProjectileLineData ShipBullet;
        /* 0xE2C */ public float WingmanLockDistance;
        /* 0xE30 */ public float WingmanLockBetweenTime;
        /* 0xE34 */ public float WingmanLockArriveTime;
        /* 0xE38 */ public float WingmanMinHeight;
        /* 0xE3C */ public float WingmanHeightAdjust;
        /* 0xE40 */ public float WingmanStartTime;
        /* 0xE44 */ public float WingmanOffsetStart;
        /* 0xE48 */ public float WingmanOffset;
        /* 0xE4C */ public float WingmanSideOffset;
        /* 0xE50 */ public float WingmanRotate;
        /* 0xE54 */ public float WingmanAtTime;
        /* 0xE58 */ public float WingmanAtTimeBack;
        /* 0xE5C */ public float WingmanPerpTime;
        /* 0xE60 */ public float WingmanVelocityBand;
        /* 0xE64 */ public float WingmanVelocityBandForce;
        /* 0xE68 */ public float TraderAtTime;
        /* 0xE6C */ public float TraderAtTimeBack;
        /* 0xE70 */ public float TraderPerpTime;
        /* 0xE74 */ public float TraderVelocityBand;
        /* 0xE78 */ public float TraderVelocityBandForce;
        /* 0xE7C */ public float WingmanAlign;
        /* 0xE80 */ public float WarpSpeed;
        /* 0xE84 */ public float WarpForce;
        /* 0xE88 */ public float TrailSpeedFadeMinSpeed;
        /* 0xE8C */ public float TrailSpeedFadeFalloff;
        /* 0xE90 */ public float DockingLandingTime;
        /* 0xE94 */ public float DockingLandingTimeDirectional;
        /* 0xE98 */ public float DockingSpringTime;
        /* 0xE9C */ public float DockingLandingBounceTime;
        /* 0xEA0 */ public float DockingLandingBounceHeight;
        /* 0xEA4 */ public float DockingRotateStartTime;
        /* 0xEA8 */ public float DockingRotateSpeed;
        /* 0xEAC */ public float DockWaitMinTime;
        /* 0xEB0 */ public float DockWaitMaxTime;
        /* 0xEB4 */ public float TakeOffHoverPointReachedDistance;
        /* 0xEB8 */ public float TakeOffExitHeightOffset;
        /* 0xEBC */ public float TakeOffExtraAIHeight;
        /* 0xEC0 */ public float LandingManuevreTime;
        /* 0xEC4 */ public float LandingManeuvreAlignTime;
        /* 0xEC8 */ public float LandingHoverPointReachedDistance;
        /* 0xECC */ public float LandingDirectionalHoverPointReachedDistance;
        /* 0xED0 */ public float AtmosphereTerminalSpeed;
        /* 0xED4 */ public float CircleApproachDistance;
        /* 0xED8 */ public float TravelMinBoostTime;
        /* 0xEDC */ public float GroundCircleHeight;
        /* 0xEE0 */ public float GroundCircleHeightMax;
        /* 0xEE4 */ public float OrbitHeight;
        /* 0xEE8 */ public float AtmosphereEffectMin;
        /* 0xEEC */ public float AtmosphereEffectMax;
        /* 0xEF0 */ public float MaxTorque;
        /* 0xEF4 */ public float ShipAngularFactor;
        /* 0xEF8 */ public float RollAmount;
        /* 0xEFC */ public float RollMinTurnAngle;
        /* 0xF00 */ public float FinalDeathExplosionScale;
        /* 0xF04 */ public float FinalDeathExplosionTime;
        /* 0xF08 */ public float FinalDeathFadeTime;
        /* 0xF0C */ public GcShipAIDeathData Death;
        /* 0xF28 */ public GcShipAIPlanetPatrolData WingmanPathData;
        /* 0xF60 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
    }
}
