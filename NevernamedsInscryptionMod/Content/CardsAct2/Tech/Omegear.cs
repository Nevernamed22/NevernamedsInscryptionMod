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
    static class Omegear
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Omegear",
                "Omegear",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                abilities: new List<Ability>() { VivaLaRevolution.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/omegear.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/omegear_pixel.png")
                );
        }
    }
}