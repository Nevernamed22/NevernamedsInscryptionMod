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
    static class Trenchfoot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Trenchfoot",
                "Trenchfoot",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Trampler.ability, Ability.DoubleStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/trenchfoot_pixel.png")
                );
        }
    }
}