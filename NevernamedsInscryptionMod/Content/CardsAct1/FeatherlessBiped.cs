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
    static class FeatherlessBiped
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FeatherlessBipedMan",
                "Man",
                4,
                4,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { HaunterCustom.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/featherlessbiped.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/featherlessbiped_emission.png")
                );

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/featherlessbiped.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed FeatherlessBiped",
                "Featherless Biped",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "It is a... man?",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Evolve, HaunterCustom.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/featherlessbiped_emission.png"),
                defaultEvolutionCard: "Nevernamed FeatherlessBipedMan",
                defaultEvolutionTurns: 2
                );
        }
    }
}