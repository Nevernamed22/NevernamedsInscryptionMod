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
    static class EnchantedBlade
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed EnchantedBlade",
                 "Enchanted Blade",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Orange },
                 abilities: new List<Ability>() { Sharpen.ability },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/enchantedblade_pixel.png")
                 );
        }
    }
}