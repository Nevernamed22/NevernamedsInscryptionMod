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
    static class Chuman
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Chuman",
                "Chuman",
                1,
                3,
                new List<CardMetaCategory> {  CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Unholy union.",
                bonesCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chuman.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chuman_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                abilities: new List<Ability>() { Ability.Sentry, Ability.GainAttackOnKill },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}