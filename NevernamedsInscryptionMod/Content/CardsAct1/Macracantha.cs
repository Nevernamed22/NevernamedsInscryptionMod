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
    static class Macracantha
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MacracanthaBi",
                "Macracantha",
                1,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "A most curious weaver. It cycles through attack styles when harmed.",
                bloodCost: 1,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macracantha.png"),
                abilities: new List<Ability>() { Twister.ability, Ability.SplitStrike },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macracantha_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                twisterForm: "BeastNevernamed MacracanthaTri"
                );

            CardSetupUtility.NewCard("Nevernamed MacracanthaTri",
                "Macracantha",
                1,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "A most curious weaver. It cycles through attack styles when harmed.",
                bloodCost: 1,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macracantha.png"),
                abilities: new List<Ability>() { Twister.ability, Ability.TriStrike },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macracantha_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                twisterForm: "BeastNevernamed Macracantha"
                );

            CardSetupUtility.NewCard("Nevernamed Macracantha",
                "Macracantha",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A most curious weaver. It cycles through attack styles when harmed.",
                bloodCost: 1,
                bonesCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macracantha.png"),
                abilities: new List<Ability>() { Twister.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/macracantha_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                twisterForm: "BeastNevernamed MacracanthaBi"
                );
        }
    }
}
