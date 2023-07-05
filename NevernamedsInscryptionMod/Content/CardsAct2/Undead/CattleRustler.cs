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
    static class CattleRustler
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CattleRustler",
                "Cattle Rustler",
               2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 7,
                abilities: new List<Ability>() { Tug.ability, Ability.StrafePush },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/cattlerustler_pixel.png")
                );
        }
    }
}