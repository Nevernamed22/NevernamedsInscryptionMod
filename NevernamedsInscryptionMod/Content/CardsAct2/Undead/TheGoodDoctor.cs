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
    static class TheGoodDoctor
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TheGoodDoctor",
                "The Good Doctor",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "I assure you he is licensed.",
                bloodCost: 0,
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { OrganThief.ability, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/thegooddoctor.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/thegooddoctor_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/thegooddoctor_pixel.png")
                );
        }
    }
}