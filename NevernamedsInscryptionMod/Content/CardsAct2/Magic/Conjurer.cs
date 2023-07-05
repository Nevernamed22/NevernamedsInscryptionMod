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
    static class Conjurer
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Conjurer",
                 "Conjurer",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green },
                 abilities: new List<Ability>() { GiftBearerCustom.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/conjurer_pixel.png")
                 );
        }
    }
}