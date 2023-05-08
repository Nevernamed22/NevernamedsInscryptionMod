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
    static class Helhest
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Helfire",
                "Helfire",
                0,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/helfire.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/helfire_emission.png"),
                abilities: new List<Ability>() { Burning.ability, Remove.ability },
                traits: new List<Trait>() { Trait.Terrain },
                tribes: new List<Tribe>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CustomAppearances.RareTerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout }
                );

            CardSetupUtility.NewCard("Nevernamed Helhest",
                "Helhest",
                3,
              2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The wicked tripedal Helhest- it moves with ethereal grace- trailing the icy flames of Hel in it's wake.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Phantasmic.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/helhest.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/helhest_emission.png"),
                phantasmicLeaveBehind: "BeastNevernamed Helfire"
                );
        }
    }
}