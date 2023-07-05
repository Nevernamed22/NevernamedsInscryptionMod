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
    static class Skelemagnus
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Skelemagnus",
                "Skelemagnus",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Brittle, Ability.GainGemTriple },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/skelemagnus_pixel.png")
                );
        }
    }
}