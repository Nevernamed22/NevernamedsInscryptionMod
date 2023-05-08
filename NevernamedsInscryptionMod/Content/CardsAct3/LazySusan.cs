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
    static class LazySusan
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed LazySusan",
                "Lazy Susan",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Part3Random, CardMetaCategory.Rare },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 6,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Revolve.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsTech/lazysusan.png")
                );
        }
    }
}