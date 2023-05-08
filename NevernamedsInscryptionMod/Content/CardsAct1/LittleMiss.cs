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
    static class LittleMiss
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed LittleMiss",
                "Little Miss",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "She sits so peacefully- but it is best she not be startled...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { SplitSentry.ability, Sentriple.ability, BloodBorn.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/littlemiss.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/littlemiss_emission.png")
                );
        }
    }
}