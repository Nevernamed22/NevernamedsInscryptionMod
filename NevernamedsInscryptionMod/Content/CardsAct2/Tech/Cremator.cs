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
    static class Cremator
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Cremator",
                "Cremator",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Burning.ability, BoneSpurs.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/cremator_pixel.png")
                );
        }
    }
}