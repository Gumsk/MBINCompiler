﻿namespace MBINCompiler.Models.Structs
{
    public class TkPaletteTexture : NMSTemplate
    {
        public int Palette; // enum(0x26)
        public int ColourAlt;

        public string[] ColourAltValues()
        {
            return new[] { "Primary", "Alternative1", "Alternative2", "Alternative3", "Alternative4", "Unique", "MatchGround", "None" };
        }
    }
}
