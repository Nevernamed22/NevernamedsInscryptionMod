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
    static class Scarecrow
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Scarecrow",
                "Scarecrow",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "I built this one myself. I wanted to put a real brain in him but oh, nobody could bear to part with one. A shame.",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { WizardOfOz.ability },
                abilities: new List<Ability>() { Fearsome.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/scarecrow.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/scarecrow_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/scarecrow_pixel.png")
                );
        }
    }
}