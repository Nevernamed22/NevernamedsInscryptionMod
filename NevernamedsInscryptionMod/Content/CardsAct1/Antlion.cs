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
    static class Antlion
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Antlion",
                "Antlion",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The larvae of the antlion. It's skill for trapping knows no match... in the insect world.",
                bloodCost: 0,
                bonesCost: 6,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antlion.png"),
                abilities: new List<Ability>() { Allure.ability, },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/antlion_emission.png")
                );
        }
    }
}
