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
    static class FalseProphet
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FalseProphet",
                 "False Prophet",
                 0,
                2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Orange, GemType.Blue },
                 abilities: new List<Ability>() { Allure.ability, Sentriple.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/falseprophet_pixel.png")
                 );
        }
    }
}