﻿namespace MBINCompiler.Models.Structs
{
    public class GcCreatureTypes : NMSTemplate
    {
        public int CreatureType; // enum(0x16)

        public string[] CreatureTypeValues()
        {
            return new[]
            {
                "None", "Bird", "FlyingLizard", "FlyingSnake", "Butterfly", "Beetle", "Fish", "Shark",
                "Crab", "Snake", "Dino", "Antelope", "Rodent", "Cat", "Drone", "Quad",
                "Walker", "Predator", "PlayerPredator", "Prey", "Passive", "Brainless"
            };
        }
    }
}
