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
    static class MagicBag
    {

        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed MagicBag",
                "Magic Bag",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Blue, GemType.Green },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { DeckedOut.ability, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/magicbag_pixel.png")
                );           
        }
    }
}