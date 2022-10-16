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
    static class HiveCrawler
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed HiveCrawler",
                "Hive Crawler",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A peculiar crustacean that cultivates a hive of bees upon it's back.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.WhackAMole, Ability.BeesOnHit },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hivecrawler.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hivecrawler_emission.png")
                );
        }
    }
}