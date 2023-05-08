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
            CardSetupUtility.NewCard("Nevernamed Capybara",
                "Capybara",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The much-beloved Capybara... it's fighting spirit is closely tied to it's wellbeing.",
                bloodCost: 2,
                bonesCost: 0,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/capybara.png"),
                abilities: new List<Ability>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/capybara_emission.png"),
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                specialAbilities: new List<SpecialTriggeredAbility>() { HealthDamage.ability },
                variableStat: HealthDamage.specialStatIcon
                );
        }
    }
}