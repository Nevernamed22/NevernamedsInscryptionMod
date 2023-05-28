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
    static class BotPrinter
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BotPrinter",
                "Bot Printer",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.Rare, Plugin.P03KayceesBastionRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Doomed.ability, Ability.DrawCopyOnDeath, NatureOfTheBeast.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/botprinter.png")
                );
        }
    }
}