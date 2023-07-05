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
    static class WildCell
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WildCell",
                "Wild Cell",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.P03KayceesBastionRegion, Plugin.P03KayceesNatureRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { DoubleStrikeWhenPowered.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/wildcell.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/wildcell_pixel.png")

                );
        }
    }
}