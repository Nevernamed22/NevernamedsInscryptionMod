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
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "A simple spirit, bound to this earth.",
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Flying, Ability.Brittle},
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/ghost.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/ghost_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/ghost_pixel.png")
                );
        }
    }
}