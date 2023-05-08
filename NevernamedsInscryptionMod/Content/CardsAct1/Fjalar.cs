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
    static class Fjalar
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Fjalar",
                "Fjalar",
                1,
               4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The blood red cockerel of war... it's cry spurs it's comrades to battle. The time is nigh.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { CallToArms.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fjalar.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fjalar_emission.png")
                );
        }
    }
}