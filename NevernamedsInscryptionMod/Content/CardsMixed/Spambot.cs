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
    static class Spambot
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Spambot",
                "Spambot",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare, CardMetaCategory.Part3Random, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Trio.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/spambot.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/spambot_pixel.png"),
                decals: new List<Texture>() {  }
                );
        }
    }
}