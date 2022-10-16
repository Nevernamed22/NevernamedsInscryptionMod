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
    static class DentalMage
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DentalMage",
                "Dental Mage",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                gemsCost: new List<GemType>() { GemType.Green },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { ToothPuller.ability, Ability.GemDependant },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dentalmage_pixel.png")
                );
        }
    }
}