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
    static class Changeling
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EnragedFey",
               "Enraged Fey",
               4,
               2,
               new List<CardMetaCategory> {  },
               CardTemple.Nature,
               description: "The development of the changeling is entirely dependant on it's early childhood... violence begets violence.",
               bloodCost: 1,
               bonesCost: 0,
               abilities: new List<Ability>() { Enraged.ability },
               defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/enragedfey.png"),
               emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/enragedfey_emission.png"),
               appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
               tribes: new List<Tribe>() { }
               );

            CardSetupUtility.NewCard("Nevernamed PitifulFey",
                           "Pitiful Fey",
                           0,
                           4,
                           new List<CardMetaCategory> { },
                           CardTemple.Nature,
                           description: "The development of the changeling is entirely dependant on it's early childhood... violence begets violence.",
                           bloodCost: 1,
                           bonesCost: 0,
                           abilities: new List<Ability>() {  },
                           defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/pitifulfey.png"),
                           appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                           tribes: new List<Tribe>() { }
                           );

            CardSetupUtility.NewCard("Nevernamed Changeling",
                "Changeling",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The development of the changeling is entirely dependant on it's early childhood... violence begets violence.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() {  TransformerCustom.ability, GraveyardShift.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/changeling.png"),
                //emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/whitewhale_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                transformerForm: "BeastNevernamed PitifulFey",
                defaultFrozenCard: "BeastNevernamed EnragedFey"
                );
        }
    }
}