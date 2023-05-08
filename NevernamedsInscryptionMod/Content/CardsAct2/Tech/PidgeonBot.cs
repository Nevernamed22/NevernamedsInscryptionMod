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
    static class PidgeonBot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed PidgeonBot",
                "Pidgeon?",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, Plugin.P03KayceesNatureRegion, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 2, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Flighty.ability, Ability.Flying },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pidgeonbot_pixel.png"),
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/pidgeonbot.png")
                );
        }
    }
}