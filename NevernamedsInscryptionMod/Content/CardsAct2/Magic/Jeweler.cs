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
    static class Jeweler
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Jeweler",
                "Jeweler",
               0,
               2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Orange },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Bejeweled.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/jeweler_pixel.png")
                );
        }
    }
}
