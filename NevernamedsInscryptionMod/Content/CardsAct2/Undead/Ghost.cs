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
    static class Ghost
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Ghost",
                "Ghost",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Flying, Ability.Brittle},
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ghost_pixel.png")
                );
        }
    }
}