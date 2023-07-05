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
    static class TheSporekers
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed TheSporekers",
                "The Sporekers",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
               bonesCost: 4,
                abilities: new List<Ability>() { Ability.QuadrupleBones, Ability.QuadrupleBones },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/SporeCards/thesporekers_pixel.png")
                );
        }
    }
}