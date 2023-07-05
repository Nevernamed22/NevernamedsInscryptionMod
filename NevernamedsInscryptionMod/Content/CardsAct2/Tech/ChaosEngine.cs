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
    static class ChaosEngine
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ChaosEngine",
                "Chaos Engine",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 4, 
                abilities: new List<Ability>() { Hypermorphic.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/chaosengine.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/chaosengine_pixel.png")
                );
        }
    }
}