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
    static class Rook
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Rook",
                "Rook",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Orange, GemType.Blue },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { EternalGallop.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/rook_pixel.png")
                );
        }
    }
}