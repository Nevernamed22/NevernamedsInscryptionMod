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
    static class Leatherback
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Leatherback",
                "Leatherback",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The slick leatherback turtle. It cuts through the waves like a knife.",
                bloodCost: 0,
                bonesCost: 5,
                //energyCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leatherback.png"),
                abilities: new List<Ability>() { Ability.Submerge },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/leatherback_emission.png")
                );
        }
    }
}
