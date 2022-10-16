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
    static class Sparky
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Sparky",
                "Sparky",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.BoneDigger, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sparky_pixel.png")
                );
        }
    }
}