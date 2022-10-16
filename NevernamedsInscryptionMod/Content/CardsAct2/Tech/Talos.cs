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
    static class Talos
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Talos",
                "Talos",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6, //5
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.GuardDog, Ability.StrafeSwap },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/talos_pixel.png")
                );
        }
    }
}