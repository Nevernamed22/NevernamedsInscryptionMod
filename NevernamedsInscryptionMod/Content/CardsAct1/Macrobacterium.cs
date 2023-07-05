using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Macrobacterium
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Macrobacterium3",
               "Macrobacterium",
               1,
               2,
               new List<CardMetaCategory> { },
               CardTemple.Nature,
               description: "",
               bloodCost: 0,
               abilities: new List<Ability>() { },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
               defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macrobacterium.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/macrobacterium_pixel.png"),
               emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macrobacterium_emission.png")
               );

            CardSetupUtility.NewCard("Nevernamed Macrobacterium2",
               "Macrobacterium",
               2,
               3,
               new List<CardMetaCategory> { },
               CardTemple.Nature,
               description: "",
               bloodCost: 2,
               specialAbilities: new List<SpecialTriggeredAbility>() { InherentGraveyardShift.ability },
               abilities: new List<Ability>() { FatalFlank.ability, Ability.Brittle },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
               defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macrobacterium.png"),
               emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macrobacterium_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/macrobacterium_pixel.png"),
               defaultFrozenCard: "BeastNevernamed Macrobacterium3"
               ).SetExtendedProperty("FatalFlankOverride", "BeastNevernamed Macrobacterium3");

            CardSetupUtility.NewCard("Nevernamed Macrobacterium",
                "Macrobacterium",
                4,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "A single, bloated cell. It divides, and it conquers. Veni, vidi, vici.",
                bloodCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macrobacterium.png"),
                specialAbilities: new List<SpecialTriggeredAbility>() { InherentGraveyardShift.ability },
                abilities: new List<Ability>() { FatalFlank.ability, Ability.Brittle },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macrobacterium_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/macrobacterium_pixel.png"),
                defaultFrozenCard: "BeastNevernamed Macrobacterium2"
               ).SetExtendedProperty("FatalFlankOverride", "BeastNevernamed Macrobacterium2");
        }
    }
}
