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
    static class Moxcrafter
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Moxcrafter",
                "Moxcrafter",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                gemsCost: new List<GemType>() { GemType.Green },
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Moxcraft.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/moxcrafter_pixel.png")
                );
        }
    }
}