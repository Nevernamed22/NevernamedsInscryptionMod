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
    static class BootingBot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BootingBot",
                "Booting Bot",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                energyCost: 1,
                abilities: new List<Ability>() { Ability.Evolve },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/bootingbot.png"),
                defaultEvolutionCard: "Shieldbot"
                );
        }
    }
}