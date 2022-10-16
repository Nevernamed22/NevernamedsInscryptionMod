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
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Hypermorphic.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nanomachines_pixel.png")
                );
        }
    }
}