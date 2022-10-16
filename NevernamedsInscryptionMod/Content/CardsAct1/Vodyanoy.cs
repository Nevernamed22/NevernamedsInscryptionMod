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
    static class Vodyanoy
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Vodyanoy",
                "Vodyanoy",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The vicious blubbery Vodyanoy. Halfway between fish and man.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { CoastGuard.ability, Ability.Deathtouch },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/vodyanoy.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/vodyanoy_emission.png")
                );
        }
    }
}