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
    static class Vila
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Vila",
                "Vila",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Orange, },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Snare.ability, Ability.Flying },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/vila_pixel.png")
                );
        }
    }
}