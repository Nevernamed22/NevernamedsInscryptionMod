using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class SeaMonk
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SeaMonk",
                "Sea Monk",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A remnant of an old world, beneath the sea...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/seamonk.png"),
                abilities: new List<Ability>() { Enchanting.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/seamonk_emission.png")
                );
        }
    }
}