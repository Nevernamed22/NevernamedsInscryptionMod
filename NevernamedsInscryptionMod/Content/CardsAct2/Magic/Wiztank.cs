using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Wiztank
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Wiztank",
                "Wiztank",
                2,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Orange, GemType.Blue, GemType.Green },
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Sniper, Ability.TriStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/wiztank_pixel.png")
                );
        }
    }
}