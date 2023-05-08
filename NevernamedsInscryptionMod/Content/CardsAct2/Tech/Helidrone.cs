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
    static class Helidrone
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Helidrone",
                "Helidrone",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Part3Random, CardMetaCategory.ChoiceNode },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4, 
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Flying, Downdraft.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/helidrone_pixel.png"),
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/helidrone.png")
                );
        }
    }
}