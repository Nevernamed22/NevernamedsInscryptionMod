using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class BatTery
    {
        public static void Init()
        {
            // Add the card
           CardSetupUtility.NewCard("Nevernamed BatTery",
                "Bat Tery",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.ChoiceNode, CardMetaCategory.Part3Random, Plugin.P03KayceesNeutralRegion },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 3, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.GainBattery, Ability.Flying },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/bat_tery.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bat_tery_pixel.png")
                );
        }
    }
}