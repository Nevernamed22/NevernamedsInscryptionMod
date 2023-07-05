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
    static class Techromancer
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Techromancer",
                "Techromancer",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 5,
                abilities: new List<Ability>() { Ability.DoubleDeath },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/techromancer_pixel.png")
                );
        }
    }
}