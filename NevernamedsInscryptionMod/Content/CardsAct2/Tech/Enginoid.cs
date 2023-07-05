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
    static class Enginoid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Enginoid",
                "Enginoid",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode,
                 Plugin.P03KayceesNeutralRegion},
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { PutSentryHere.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/enginoid.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/enginoid_pixel.png")
                );
        }
    }
}