using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Oz
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Oz",
                "Oz",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() {  },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.TriStrike, Ability.SplitStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/oz_pixel.png")
                );
        }
    }
}