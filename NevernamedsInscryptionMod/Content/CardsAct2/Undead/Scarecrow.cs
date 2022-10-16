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
    static class Scarecrow
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Scarecrow",
                "Scarecrow",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 6,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Fearsome.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/scarecrow_pixel.png")
                );
        }
    }
}