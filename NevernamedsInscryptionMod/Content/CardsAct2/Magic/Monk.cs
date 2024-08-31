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
    static class Monk
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Monk",
                "Monk",
               2,
               2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Blue, GemType.Green },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Glitterheart.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/monk_pixel.png")
                );
        }
    }
}