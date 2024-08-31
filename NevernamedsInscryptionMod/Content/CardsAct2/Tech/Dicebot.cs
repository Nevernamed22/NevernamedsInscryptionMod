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
    static class Dicebot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Dicebot",
                "Dicebot",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.P03KayceesNeutralRegion, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { },
                variableStat: DamageDice.specialStatIcon,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/dicebot.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dicebot_pixel.png")
                );
        }
    }
}