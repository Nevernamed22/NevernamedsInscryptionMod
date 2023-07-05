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
    static class FogMachine
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FogMachine",
                "Fog Machine",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                energyCost: 4,
                abilities: new List<Ability>() { Ability.DebuffEnemy },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/fogmachine_pixel.png")
                );
        }
    }
}