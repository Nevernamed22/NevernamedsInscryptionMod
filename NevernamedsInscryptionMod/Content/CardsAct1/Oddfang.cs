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
    static class Oddfang
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Oddfang",
                "Oddfang",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The barbarous oddfang. Each of it's teeth delivers a different bite.",
                bloodCost: 0,
                bonesCost: 5,
                abilities: new List<Ability>() { WeirdLatch.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/oddfang.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/oddfang_emission.png")
                );
        }
    }
}