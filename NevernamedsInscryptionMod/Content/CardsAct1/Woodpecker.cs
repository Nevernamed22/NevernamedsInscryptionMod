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
    static class Woodpecker
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Woodpecker",
                "Woodpecker",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "For the feisty woodpecker, one strike is simply not enough.",
                bloodCost: 1,
                bonesCost: 3,
                //energyCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/woodpecker.png"),
                abilities: new List<Ability>() { Ability.DoubleStrike, Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Bird },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/woodpecker_emission.png")
                );
        }
    }
}
