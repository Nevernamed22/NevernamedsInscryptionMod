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
    static class Hafgufa
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Hafgufa",
                "Hafgufa",
                2,
                8,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A terrible steaming monster of the sea.",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { FringeStrike.ability, TransformerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hafgufa.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hafgufa_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                transformerForm: "BeastNevernamed HafgufaAlt"
                );

            CardSetupUtility.NewCard("Nevernamed HafgufaAlt",
                "Hafgufa",
                2,
                8,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "A terrible steaming monster of the sea.",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { CenterStrike.ability, TransformerCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hafgufa.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hafgufa_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                transformerForm: "BeastNevernamed Hafgufa"
                );
        }
    }
}