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
    static class Recyclotron
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Recyclotron",
                "Recyclotron",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { Recycle.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/recyclotron_pixel.png")
                );
        }
    }
}