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
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, CardMetaCategory.Part3Random, Plugin.P03KayceesWizardRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                traits: new List<Trait>() { Trait.Terrain, Trait.Gem },
                abilities: new List<Ability>() { Ability.GainGemOrange, Ability.GainBattery },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/energem.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/energem_pixel.png")
                );
        }
    }
}