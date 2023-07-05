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
    static class Gristle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Gristle",
                "Gristle",
                2,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 9,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.SwapStats },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/gristle_pixel.png")
                );
        }
    }
}