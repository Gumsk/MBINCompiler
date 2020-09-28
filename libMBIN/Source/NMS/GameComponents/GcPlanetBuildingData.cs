﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x941CD1BE6E6A5FAE, NameHash = 0xF6213EDD899A8CAE)]
    public class GcPlanetBuildingData : NMSTemplate
    {
        /* 0x00 */ public List<GcBuildingSpawnSlot> BuildingSlots;
        /* 0x10 */ public List<GcBuildingSpawnData> Buildings;
        /* 0x20 */ public List<GcBuildingOverrideData> OverrideBuildings;
        /* 0x30 */ public float Spacing;
        /* 0x34 */ public float PlanetRadius;
        /* 0x38 */ public float VoronoiPointDivisions;
        /* 0x3C */ public int VoronoiSectorSeed;
        /* 0x40 */ public int VoronoiPointSeed;
        [NMS(Size = 0x3, EnumType = typeof(GcBuildingClusterPlacement.BuildingClusterPlacementEnum))]
        /* 0x44 */ public float[] ClusterProbability;
        /* 0x50 */ public int WaypointIndex;
        /* 0x54 */ public int LandingPadIndex;
        /* 0x58 */ public float AddShelterChance;
        [NMS(Size = 0x3)]
        /* 0x5C */ public int[] ShelterIndices;
        /* 0x68 */ public int NumShelters;
        /* 0x6C */ public bool InitialBuildingsPlaced;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x6D */ public byte[] EndPadding;
    }
}
