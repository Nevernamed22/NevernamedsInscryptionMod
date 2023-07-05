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
    static class Handmaster
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Handmaster",
                "Handmaster",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Blue, GemType.Green },
                abilities: new List<Ability>() { Ability.DrawNewHand, Ability.DoubleStrike },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/handmaster_pixel.png")
                );
        }
    }
}