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
    static class Sluagh
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Sluagh",
                "Sluagh",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { CrookedStrikeRight.ability, Ability.SplitStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/sluagh_pixel.png")
                );
        }
    }
}