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
    static class Tlamacazqui
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Tlamacazqui",
                 "Tlamacazqui",
                 1,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Orange },
                 abilities: new List<Ability>() { ExaltedRune.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/tlamacazqui_pixel.png")
                 );
        }
    }
}