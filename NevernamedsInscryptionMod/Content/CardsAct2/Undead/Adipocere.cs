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
    static class Adipocere
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Adipocere",
                "Adipocere",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Hypermorphic.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/adipocere_pixel.png")
                );
        }
    }
}