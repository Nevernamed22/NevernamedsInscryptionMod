using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Forevenant
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Forevenant",
                "Forevenant",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.Brittle, Ability.DrawCopyOnDeath },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/forevenant_pixel.png")
                );
        }
    }
}