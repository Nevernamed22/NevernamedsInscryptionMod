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
    static class DeathsDoor
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DeathsDoor",
                "Deaths Door",
                0,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Don't worry, we'll pull you through.",
                bloodCost: 0,
                bonesCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { OtherSide.ability },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/deathsdoor.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/deathsdoor_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/deathsdoor_pixel.png")
                );
        }
    }
}