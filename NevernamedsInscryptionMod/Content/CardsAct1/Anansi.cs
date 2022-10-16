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
    static class Anansi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Anansi",
                "Anansi",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Anansi, the many legged trickster. He attacks multiple times per turn, in flagrant disregard for the rules.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() {  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anansi.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anansi_emission.png"),
                traits: new List<Trait>() { NevernamedsTraits.DoubleAllStrikes }
                );
        }
    }
}