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
    static class HotDog
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed HotDog",
                "Hot Dog",
                2,
                6,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "A poor, ignited wolf...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hotdog.png"),
                abilities: new List<Ability>() { Burning.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/hotdog_pixel.png"),
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hotdog_emission.png")
                );
        }
    }
}
