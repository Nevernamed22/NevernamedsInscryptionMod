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
    static class Undertecher
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Undertecher",
                "Undertecher",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, Plugin.P03KayceesUndeadRegion, CardMetaCategory.ChoiceNode, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 5,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Harbinger.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/undertecher.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/undertecher_pixel.png")
                );
        }
    }
}