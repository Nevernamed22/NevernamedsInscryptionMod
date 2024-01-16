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
    static class TempleTrap
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TempleTrap",
                "Temple Trap",
              1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bonesCost: 4,
                abilities: new List<Ability>() { Ability.Sniper },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/templetrap_pixel.png")
                );
        }
    }
}