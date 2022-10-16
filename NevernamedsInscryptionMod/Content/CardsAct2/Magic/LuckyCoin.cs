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
    static class LuckyCoin
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed LuckyCoin",
                "Lucky Coin",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Blue },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Flip.ability, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/luckycoin_pixel.png")
                );
        }
    }
}