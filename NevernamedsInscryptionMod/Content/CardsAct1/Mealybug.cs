using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Mealybug
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mealybug.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Mealybug",
                "Mealybug",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The diminutive mealybug. It's nutritious secretions seem ever-flowing.",
                bloodCost: 0,
                bonesCost: 4,
                abilities: new List<Ability>() { Ability.Sacrificial, Ability.Morsel, },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Insect },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/mealybug_emission.png")
                );
        }
    }
}