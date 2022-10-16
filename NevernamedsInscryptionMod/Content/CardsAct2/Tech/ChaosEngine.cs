﻿using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class ChaosEngine
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed ChaosEngine",
                "Chaos Engine",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Hypermorphic.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/chaosengine_pixel.png")
                );
        }
    }
}