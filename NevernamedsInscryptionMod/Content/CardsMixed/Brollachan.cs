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
    static class Brollachan
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Brollachan",
                "Brollachan",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack, CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The wicked Brollachan. It can take many powerful forms...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/brollachan.png"),
                abilities: new List<Ability>() { Hypermorphic.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/brollachan_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/brollachan_pixel.png")
                );
        }
    }
}
