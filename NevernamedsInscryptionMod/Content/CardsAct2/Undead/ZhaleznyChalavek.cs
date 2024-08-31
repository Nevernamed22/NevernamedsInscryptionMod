using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class ZhaleznyChalavek
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ZhaleznyChalavek",
                "Zhalezny Chalavek",
                4,
                7,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A lumbering iron golem, spirit of the swamp. A stalwart protector.",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.MadeOfStone, Ability.StrafePush },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/zhaleznychalavek.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/zhaleznychalavek_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/zhaleznychalavek_pixel.png")
                );
        }
    }
}