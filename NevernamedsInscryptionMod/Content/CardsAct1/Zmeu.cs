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
    static class Zmeu
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Zmeu",
                "Zmeu",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Zmeu, the dragon prince. It scorches it's foes, and flees the scene.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Sentry, Ignition.ability, Bloodrunner.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/zmeu.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/zmeu_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile }

                );
        }
    }
}