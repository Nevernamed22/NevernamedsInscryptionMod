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
    static class Druid
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Druid",
                "Druid",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                gemsCost: new List<GemType>() { GemType.Green },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { WoodsieLord.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/druid_pixel.png")
                );
        }
    }
}