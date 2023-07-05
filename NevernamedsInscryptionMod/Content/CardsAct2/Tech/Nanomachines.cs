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
    static class Nanomachines
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Nanomachines",
                "Nanomachines",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, Plugin.P03KayceesBastionRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 6, 
                abilities: new List<Ability>() { Hypermorphic.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/nanomachines.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nanomachines_pixel.png")
                );
        }
    }
}