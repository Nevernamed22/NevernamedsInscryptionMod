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
    static class Drawtomaton
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Drawtomaton",
                "Drawtomaton",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                energyCost: 1,
                abilities: new List<Ability>() { Draw.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/drawtomaton_pixel.png")
                );
        }
    }
}