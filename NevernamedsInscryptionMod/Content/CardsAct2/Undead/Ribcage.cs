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
    static class Ribcage
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Ribcage",
                "Ribcage",
               0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 1,
                abilities: new List<Ability>() { UnderPressure.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/boil_pixel.png")
                );
        }
    }
}