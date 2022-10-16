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
    static class Omnibot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Omnibot",
                "Omnibot",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.Rare, Plugin.P03KayceesBastionRegion},
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 3,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() {UpgradeSubroutine.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/omnibot.png")
                );
        }
    }
}