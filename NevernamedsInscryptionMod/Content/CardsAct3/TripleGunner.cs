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
    static class TripleGunner
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed TripleGunner",
                "Triple Gunner",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.Rare , CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable},
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.TriStrike },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/triplegunner.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/triplegunner_pixel.png")
                );
        }
    }
}