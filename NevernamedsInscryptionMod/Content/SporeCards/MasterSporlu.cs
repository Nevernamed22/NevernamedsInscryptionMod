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
    static class MasterSporlu
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MasterSporlu",
                "Master Sporlu",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
              gemsCost: new List<GemType>() { GemType.Orange, GemType.Blue },
                abilities: new List<Ability>() { Ability.Flying, Ability.Loot, Ability.Loot },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/SporeCards/mastersporlu_pixel.png")
                );
        }
    }
}