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
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Trio.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/spambot_pixel.png")
                );
        }
    }
}