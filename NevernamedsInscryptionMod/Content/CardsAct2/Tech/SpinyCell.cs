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
    static class SpinyCell
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SpinyCell",
                "Spiny Cell",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { PoweredQuills.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/spinycell_pixel.png")
                );
        }
    }
}