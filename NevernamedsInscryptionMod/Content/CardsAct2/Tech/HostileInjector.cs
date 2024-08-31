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
    static class HostileInjector
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed HostileInjector",
                 "Hostile Injector",
                 1,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, CardMetaCategory.Part3Random, Plugin.P03KayceesUndeadRegion },
                 CardTemple.Tech,
                 description: "",
                 energyCost: 4,
                 abilities: new List<Ability>() { WeirdLatch.ability  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/hostileinjector.png"),
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/hostileinjector_pixel.png")
                 );
        }
    }
}