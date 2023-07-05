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
    static class Taurobolium
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/taurobolium.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Taurobolium",
                "Taurobolium",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The Taurobolium... raised from a calf for use in rituals, but sacrificing it may be more difficult than anticipated.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { SavageRitual.ability, Ability.Sacrificial },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/taurobolium_emission.png"),
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/taurobolium_pixel.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );
        }
    }
}