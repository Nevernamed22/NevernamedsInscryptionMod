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
    static class FetchCard
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Fetch",
                "Fetch",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.ExcludeFromAct2Endless },
                CardTemple.Nature,
                description: "The Fetch... it shifts it's form to mimick the opponent, whomever that may be.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { FaceToFace.ability  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fetch.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fetch_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/fetch_pixel.png")
                );
        }
    }
}