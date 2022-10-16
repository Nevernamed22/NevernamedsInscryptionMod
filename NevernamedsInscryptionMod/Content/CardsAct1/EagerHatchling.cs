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
    static class EagerHatcling
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Wyvern",
                "Wyvern",
                4,
                5,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "This young reptle is so eager to throw itself into the fray... it will surely perish.",
                bloodCost: 0,
                bonesCost: 6,
                abilities: new List<Ability>() { Ability.Flying, RunningStrike.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wyvern.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wyvern_emission.png")
                );

            CardSetupUtility.NewCard("Nevernamed EagerHatcling",
                "Eager Hatcling",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "This young reptle is so eager to throw itself into the fray... it will surely perish.",
                bloodCost: 0,
                bonesCost: 3,
                abilities: new List<Ability>() { Ability.Evolve, Ability.WhackAMole, Ability.Reach, Frail.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/eagerhatchling.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/eagerhatchling_emission.png"),
                defaultEvolutionCard: "Nevernamed Wyvern"
                );
        }
    }
}