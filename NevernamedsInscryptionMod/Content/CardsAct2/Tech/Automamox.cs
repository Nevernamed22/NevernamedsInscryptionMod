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
    static class Automamox
    {
        public static void Init()
        {
            CardInfo card = CardSetupUtility.NewCard("Nevernamed Automamox",
                "Automamox",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 3,
                abilities: new List<Ability>() { Ability.GainGemBlue },
                traits: new List<Trait>() { Trait.Terrain },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/automamox_pixel.png")
                );
            card.Mods.Add(new CardModificationInfo() { gemify = true });
        }
    }
}