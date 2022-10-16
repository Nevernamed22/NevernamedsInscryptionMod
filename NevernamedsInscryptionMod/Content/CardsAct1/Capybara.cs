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
    static class Capybara
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.Rare,
            };
            List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>
            {
                CardAppearanceBehaviour.Appearance.RareCardBackground,
            };

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/capybara.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Capybara",
                "Capybara",
                0,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "The much-beloved Capybara... it's fighting spirit is closely tied to it's wellbeing.",
                bloodCost: 2,
                bonesCost: 0,
                appearanceBehaviour: appearanceBehaviour,
                defaultTex: tex,
                abilities: new List<Ability>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/capybara_emission.png"),
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { HealthDamage.ability },
                variableStat: HealthDamage.specialStatIcon
                );
        }
    }
}