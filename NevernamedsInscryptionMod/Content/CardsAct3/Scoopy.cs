﻿using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using NevernamedsSigils;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Scoopy
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Scoopy",
                "Scoopy",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.StrafeSwap },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/scoopy.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/scoopy_pixel.png")
                );
        }
    }
}