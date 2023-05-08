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
    static class Minokawa
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Minokawa3",
                "Minokawa",
                3,
                5,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "The gluttonous, dreadful minokawa. It's steely feathers only grow sharper with age.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Flying, SharpestQuills.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minokawa.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minokawa_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                defaultEvolutionName: "Moon Eater"
                );

            CardSetupUtility.NewCard("Nevernamed Minokawa2",
                "Minokawa",
                2,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "The gluttonous, dreadful minokawa. It's steely feathers only grow sharper with age.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Flying, SharperQuills.ability, Ability.Evolve },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minokawa.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minokawa_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                defaultEvolutionCard: "BeastNevernamed Minokawa3"
                );

            CardSetupUtility.NewCard("Nevernamed Minokawa",
                "Minokawa",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The gluttonous, dreadful minokawa. It's steely feathers only grow sharper with age.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Flying, Ability.Sharp, Ability.Evolve },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minokawa.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/minokawa_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                defaultEvolutionCard: "BeastNevernamed Minokawa2"
                );




        }
    }
}