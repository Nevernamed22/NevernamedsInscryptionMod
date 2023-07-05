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
    static class Firelight
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Firelight",
                "Firelight",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, CardMetaCategory.Part3Random, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ignition.ability, FireResistant.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/firelight.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/firelight_pixel.png")
                );
        }
    }
}