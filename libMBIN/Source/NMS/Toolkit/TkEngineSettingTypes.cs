﻿namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4,  GUID = 0x0, NameHash = 0x943946549DEC2216)]
    public class TkEngineSettingTypes : NMSTemplate
    {
        // 0x2A entries
        public enum EngineSettingEnum {
            FullScreen, Borderless, ResolutionWidth, ResolutionHeight, ResolutionScale, Monitor, FoVOnFoot, FoVInShip, VSync, TextureQuality,
            AnimationQuality, ShadowQuality, ReflectionsMultiplier, PostProcessingEffects, VolumetricsQuality, TerrainTessellation, PlanetQuality, BaseQuality, UIQuality, DLSSQuality,
            EnableTessellation, AntiAliasing, AnisotropyLevel, Brightness, VignetteAndScanlines, AvailableMonitors, MaxFrameRate, NumLowThreads, NumHighThreads, NumGraphicsThreads,
            TextureStreaming, TexturePageSizeKb, MotionBlurStrength, ShowRequirementsWarnings, AmbientOcclusion, MaxTextureMemoryMb, FixedTextureMemory, UseArbSparseTexture, UseTerrainTextureCache, AdapterIndex,
            UseHDR, MinGPUMode
        }
        public EngineSettingEnum EngineSetting;
    }
}