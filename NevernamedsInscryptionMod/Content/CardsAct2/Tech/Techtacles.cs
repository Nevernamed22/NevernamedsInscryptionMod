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
    static class Techtacles
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Techtacles",
                "Techtacles",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { Ability.Submerge, Ability.TriStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/techtacles_pixel.png")
                );
        }
    }
}