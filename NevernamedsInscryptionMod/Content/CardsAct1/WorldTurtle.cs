using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class WorldTurtle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WorldTurtle3",
                "World Turtle",
                1,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "It's turtles all the way down...",
                bloodCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/worldturtle3.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/worldturtle3_emission.png"),
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                abilities: new List<Ability>() { Ability.MadeOfStone },
                tribes: new List<Tribe>() { Tribe.Reptile }
                );
            CardSetupUtility.NewCard("Nevernamed WorldTurtle2",
                "World Turtle",
                2,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "It's turtles all the way down...",
                bloodCost: 1,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/worldturtle2.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/worldturtle2_emission.png"),
                abilities: new List<Ability>() { GraveyardShift.ability, Ability.MadeOfStone },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { Tribe.Reptile },
                defaultFrozenCard: "BeastNevernamed WorldTurtle3"
                );
            CardSetupUtility.NewCard("Nevernamed WorldTurtle",
                "World Turtle",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "It's turtles all the way down...",
                bloodCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/worldturtle1.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/worldturtle1_emission.png"),
                abilities: new List<Ability>() { GraveyardShift.ability, Ability.MadeOfStone },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { Tribe.Reptile },
                defaultFrozenCard: "BeastNevernamed WorldTurtle2"
                );
        }
    }
}
