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
    static class Energem
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Energem",
                "Energem",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 2,
                traits: new List<Trait>() { Trait.Terrain, Trait.Gem },
                abilities: new List<Ability>() { Ability.GainGemOrange, Ability.GainBattery },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/energem_pixel.png")
                );
        }
    }
}