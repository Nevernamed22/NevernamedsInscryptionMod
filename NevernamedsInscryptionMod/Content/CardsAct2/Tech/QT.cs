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
    static class QT
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed QT",
                "Q-T",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 2,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Cute.ability, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/qt_pixel.png")
                );
        }
    }
}