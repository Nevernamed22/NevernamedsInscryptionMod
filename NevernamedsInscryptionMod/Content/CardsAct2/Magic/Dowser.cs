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
    static class Dowser
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Dowser",
                 "Dowser",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Blue, GemType.Orange },
                 abilities: new List<Ability>() { GoldRush.ability, Unhammerable.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dowser_pixel.png")
                 );
        }
    }
}