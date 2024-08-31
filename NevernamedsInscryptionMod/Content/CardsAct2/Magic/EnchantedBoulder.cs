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
    static class EnchantedBoulder
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EnchantedBoulder",
                 "Enchanted Boulder",
                 2,
                 4,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() { GemType.Green, GemType.Orange },
                 abilities: new List<Ability>() { Ability.MadeOfStone, Ability.GemDependant },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/enchantedboulder_pixel.png")
                 );
        }
    }
}