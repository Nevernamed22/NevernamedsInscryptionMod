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
    static class Necrophidius
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Necrophidius",
                "Necrophidius",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.CreateDams },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/necrophidius_pixel.png"),
                overrideDamID: "BeastNevernamed BoneClutter"
                );

            CardSetupUtility.NewCard("Nevernamed NecrophidiusGrimora",
                "Necrophidius",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A long construct created by a powerful necromancer. The dear thing bears many more bones than it would seem.",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() { Ability.CreateDams },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/necrophidius.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/necrophidius_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/necrophidius_pixel.png"),
                overrideDamID: "DeadNevernamed BoneClutterGrimora"
                );
        }
    }
}