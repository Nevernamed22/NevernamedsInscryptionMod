using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Flammaball
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Flammaball",
                "Flammaball",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNeutralRegion, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { Firebomb.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/flammaball.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/flammaball_pixel.png")
                );
        }
    }
}