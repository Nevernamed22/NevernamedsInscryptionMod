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
    static class SuperDuper
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SuperDuper",
                "Super Duper",
               0,
               1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Blue },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Duppelgang.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/superduper_pixel.png")
                );
        }
    }
}