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
    static class Growbot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GrowbotGrown",
                "Growbot",
               3,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/growbot_grown.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/growbot_grown_pixel.png")
                );

            CardSetupUtility.NewCard("Nevernamed Growbot",
                "Growbot",
                1,
                1,
                new List<CardMetaCategory> {  CardMetaCategory.Part3Random, Plugin.P03KayceesBastionRegion, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Evolve },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/growbot.png"),
                defaultEvolutionCard: "TechNevernamed GrowbotGrown",
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/growbot_pixel.png")
                );
        }
    }
}