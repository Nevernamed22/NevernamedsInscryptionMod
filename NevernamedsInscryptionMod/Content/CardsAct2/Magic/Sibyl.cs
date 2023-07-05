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
    static class Sibyl
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Sibyl",
                 "Sibyl",
                 0,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Blue },
                 abilities: new List<Ability>() { Ability.GemsDraw, Divination.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sibyl_pixel.png")
                 );
        }
    }
}