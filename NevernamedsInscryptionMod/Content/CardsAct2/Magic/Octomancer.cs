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
    static class Octomancer
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Octomancer",
                "Octomancer",
               2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Blue },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { UnfocusedStrike.ability, SapphireDependant.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/octomancer_pixel.png")
                );
        }
    }
}