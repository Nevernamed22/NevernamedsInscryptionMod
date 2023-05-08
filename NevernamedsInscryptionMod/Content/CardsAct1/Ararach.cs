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
    static class Ararach
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Ararach",
                "Ararach",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The infinilegged crawler, the Ararach never settles on a definitive strategy of attack for long...",
                bloodCost: 0,
                bonesCost: 5,
                abilities: new List<Ability>() { ChaosStrike.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ararach.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ararach_emission.png")
                );
        }
    }
}