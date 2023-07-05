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
    static class Mageskull
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Mageskull",
                 "Mageskull",
                 0,
                 1,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { },
                 abilities: new List<Ability>() { PainfulPresence.ability, Ability.GemDependant },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mageskull_pixel.png")
                 );
        }
    }
}