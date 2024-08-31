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
    static class Dozer
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Dozer",
                "D0zer",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, CardMetaCategory.Part3Random, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Trampler.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/dozer.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/dozer_pixel.png")
                );
        }
    }
}