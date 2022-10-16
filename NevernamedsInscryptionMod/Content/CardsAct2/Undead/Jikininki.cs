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
    static class Jikininki
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Jikininki",
                "Jikininki",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 4,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.OpponentBones },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/jikininki_pixel.png")
                );
        }
    }
}