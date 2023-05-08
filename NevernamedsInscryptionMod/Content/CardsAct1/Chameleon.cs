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
    static class Chameleon
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Chameleon",
                "Chameleon",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A chameleon always changes it's spots, as is the proverb.",
                bonesCost: 3,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chameleon.png"),
                abilities: new List<Ability>() { Ability.RandomAbility },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chameleon_emission.png")
                );
        }
    }
}