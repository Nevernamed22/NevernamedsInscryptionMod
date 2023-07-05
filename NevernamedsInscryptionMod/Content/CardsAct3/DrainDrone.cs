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
    static class DrainDrone
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed DrainDrone",
                "Drain Drone",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesUndeadRegion, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { Vampiric.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/draindrone.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/draindrone_pixel.png")
                );
        }
    }
}