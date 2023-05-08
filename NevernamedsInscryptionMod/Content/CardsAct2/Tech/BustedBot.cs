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
    static class BustedBot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed BustedBot",
                "Busted Bot",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, Plugin.P03KayceesUndeadRegion, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 3, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { CrookedStrikeRight.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/bustedbot.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bustedbot_pixel.png")
                );
        }
    }
}