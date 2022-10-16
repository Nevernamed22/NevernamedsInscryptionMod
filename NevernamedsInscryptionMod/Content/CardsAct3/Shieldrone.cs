using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Shieldrone
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Shieldrone",
                "Shieldrone",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, Plugin.P03KayceesBastionRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { RepulsiveWhenPowered.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/shieldrone.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/shieldrone_pixel.png")
                );
        }
    }
}