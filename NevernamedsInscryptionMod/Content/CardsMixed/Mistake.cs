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
    static class Mistake
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mistake.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Mistake",
                "Mistake",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Quite possibly the most worthless collection of sigils I've ever seen.",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: tex,
                abilities: new List<Ability>() { CrookedStrikeLeft.ability, TrophyHunter.ability },
                tribes: new List<Tribe>() { },
                traits: new List<Trait>() { Trait.KillsSurvivors},
                onePerDeck: true,
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mistake_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                defaultEvolutionName: "Really Big Mistake"
                );
        }
    }
}
