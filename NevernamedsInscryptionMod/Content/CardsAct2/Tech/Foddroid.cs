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
    static class Foddroid
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Foddroid",
                "Foddroid",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Recharge.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/foddroid_pixel.png")
                );
        }
    }
}