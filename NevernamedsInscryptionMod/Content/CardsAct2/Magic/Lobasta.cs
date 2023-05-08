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
    static class Lobasta
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Lobasta",
                "Lobasta",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { GemType.Green },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { CollateralDamage.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/lobasta_pixel.png")
                );
        }
    }
}