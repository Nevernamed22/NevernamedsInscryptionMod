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
    static class HeartOfHarts
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed HeartOfHarts",
                "Heart Of Harts",
                0,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The horrifying Heart of Harts. You hear distressed noises beneath it's writhing surface.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Reach, HartsWithin.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/heartofharts.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Hooved },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/heartofharts_emission.png")
                );
        }
    }
}