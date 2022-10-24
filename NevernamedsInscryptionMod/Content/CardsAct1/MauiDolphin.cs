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
    static class MauiDolphin
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed MauiDolphinSubmerged",
                "Maui Dolphin",
                0,
                6,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "The endangered Maui Dolphin. It will hide after being struck.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mauidolphinsub.png"),
                abilities: new List<Ability>() { Ability.Submerge, Ability.Evolve },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mauidolphinsub_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                defaultEvolutionCard: "BeastNevernamed MauiDolphin",
                defaultEvolutionTurns: 2
                );

            CardSetupUtility.NewCard("Nevernamed MauiDolphin",
                "Maui Dolphin",
                3,
                6,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The endangered Maui Dolphin. It will hide after being struck.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mauidolphin.png"),
                abilities: new List<Ability>() { Twister.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mauidolphin_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                twisterForm: "BeastNevernamed MauiDolphinSubmerged"
                );
        }
    }
}
