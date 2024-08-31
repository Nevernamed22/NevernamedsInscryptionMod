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
    static class Trojan
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Trojan",
                "Trojan",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.P03KayceesNatureRegion, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 2,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Traitor.ability, Trampler.ability },
                flipPortraitWhenStrafing: true,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/trojan.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/trojan_pixel.png")
                );
        }
    }
}