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
    static class Balloondroid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BalloondroidPuffed",
                "Balloondroid",
               2,
                2,
                new List<CardMetaCategory> { },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 3, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Flying },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/balloondroid_puffed.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/balloondroid_puffed_pixel.png")
                );

            CardSetupUtility.NewCard("Nevernamed Balloondroid",
                "Balloondroid",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, Plugin.P03KayceesBastionRegion, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 3, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Evolve, Ability.Flying },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/balloondroid.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/balloondroid_pixel.png"),
                defaultEvolutionCard: "TechNevernamed BalloondroidPuffed"
                );
        }
    }
}