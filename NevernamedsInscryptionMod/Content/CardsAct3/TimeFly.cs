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
    static class TimeFly
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TimeFly",
                "Time Fly",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.P03KayceesBastionRegion, Plugin.P03KayceesNatureRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                abilities: new List<Ability>() { TimeTravel.ability, Ability.Flying },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/timefly.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/timefly_pixel.png")
                );
        }
    }
}