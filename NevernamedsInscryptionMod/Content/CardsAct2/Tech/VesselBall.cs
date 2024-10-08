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
    static class VesselBall
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed VesselBall",
                "Vessel Ball",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { VesselShedder.ability, },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/vesselball.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/vesselball_pixel.png")
                );
        }
    }
}