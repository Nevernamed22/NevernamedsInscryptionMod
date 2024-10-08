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
    static class Photocopier
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Photocopier",
                "Photocopier",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.P03KayceesUndeadRegion, Plugin.P03KayceesBastionRegion, CardMetaCategory.ChoiceNode, CardMetaCategory.Part3Random },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Mockery.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/photocopier.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/photocopier_pixel.png")
                );
        }
    }
}