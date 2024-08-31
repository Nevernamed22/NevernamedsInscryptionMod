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
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A pile of sinewy flesh, decayed beyond any recognition.",
                bonesCost: 9,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.SwapStats },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/gristle.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/gristle_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/gristle_pixel.png")
                );
        }
    }
}